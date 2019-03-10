using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BumpMaker
{
    public partial class _frmMain : Form
    {
        Bitmap _loadedImage = null;
        Bitmap _processedImage = null;
        Task _imageTask;
        CancellationTokenSource _imageTaskTokenSource;
        CancellationToken _imageTaskToken;
        public enum BumpMapType
        {
            Invalid, Normal, Bump
        };
        public enum TextureLoadResult
        {
            Success,
            TooLarge,
            InvalidPath,
            InvalidExtension
        }
        public List<string> _objValidImageExtensions = new List<string> { ".jpg", ".bmp", ".png", ".gif" };
        public List<string> _objValidSaveExtensions = new List<string> { ".jpg", ".bmp", ".png" };
        public _frmMain()
        {
            InitializeComponent();

            _lblContrastValue.Text = "0.79378";
            UpdateUi();
        }

        private void UpdateUi()
        {
            _lblBumpAmount.Text = String.Format("{0:0.00}", GetBumpAmount() * 2.0f - 1.0f);
            _lblContrastValue.Text = String.Format("{0:0.00}", GetContrastAmount());
            _pbLoaded.SizeMode = PictureBoxSizeMode.Zoom;
            _pbResult.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void _frmMain_Load(object sender, EventArgs e)
        {

        }
        private void _btnOpenFileLoc_Click(object sender, EventArgs e)
        {
            GetAndLoadImage();

        }
        private float GetBumpAmount()
        {
            return (float)_tbBumpAmount.Value / (float)_tbBumpAmount.Maximum;
        }
        private float GetContrastAmount()
        {
            return (float)_tbContrast.Value / (float)_tbContrast.Maximum;
        }
        private async void _btnProcess_Click(object sender, EventArgs e)
        {
            if (_imageTaskTokenSource != null)
            {
                _imageTaskTokenSource.Cancel();
            }
            else
            {
                if (_txtFileLoc.Text != String.Empty)
                {
                    if (LoadTex(_txtFileLoc.Text) == TextureLoadResult.Success)
                    {
                        _pbLoaded.Image = _loadedImage;
                    }
                    _pbResult.Image = null;
                    _processedImage = null;
                    GC.Collect();



                    //Map Type
                    if (_cboMapType.SelectedIndex < 0)
                    {
                        _cboMapType.SelectedIndex = 0;
                    }
                    string sel = _cboMapType.Items[_cboMapType.SelectedIndex].ToString();
                    BumpMapType eMapType = BumpMapType.Normal;
                    if (sel == "Normal")
                    {
                        eMapType = BumpMapType.Normal;
                    }
                    else if (sel == "Bump")
                    {
                        eMapType = BumpMapType.Bump;
                    }
                    else
                    {
                        SetStatus("Unrecognized map type " + sel);
                        eMapType = BumpMapType.Invalid;
                    }

                    if (eMapType != BumpMapType.Invalid)
                    {
                        //Collect initial data
                        float fBumpAmount = GetBumpAmount();
                        float fContrast = GetContrastAmount();
                        //Thread cancellation
                        _imageTaskTokenSource = new CancellationTokenSource();
                        _imageTaskToken = _imageTaskTokenSource.Token;

                        //Run thes tuff
                        _imageTask = Task.Run(() =>
                        {
                            try
                            {
                                Bitmap final = NormalizeImage(_loadedImage, fBumpAmount, eMapType, fContrast);
                                if (final != null)
                                {
                                    _processedImage = final;
                                }
                            }
                            catch (Exception ex)
                            {
                                EndProcess();
                                SetStatus(ex.ToString());
                            }
                        }, _imageTaskToken);
                        await _imageTask;
                    }
                }
            }
        }
        private string GetValidOpenSaveUserFile(bool bSave)
        {
            string filter;
            int filterIndex = 0;

            System.Windows.Forms.DialogResult res;
            FileDialog dlg;
            if (bSave == false)
            {
                dlg = new System.Windows.Forms.OpenFileDialog();
                filter = "Image Files (*.png,*.jpg,*.jpeg,*.gif,*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            }
            else
            {
                dlg = new System.Windows.Forms.SaveFileDialog();
                filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpeg;*.jpg|GIF (*.gif)|*.gif|BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
            }

            dlg.DefaultExt = "png";
            dlg.Filter = filter;
            dlg.FilterIndex = filterIndex;
            res = dlg.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.Cancel)
            {
                return string.Empty;
            }

            if (bSave == false && !System.IO.File.Exists(dlg.FileName))
            {
                return string.Empty;
            }

            return dlg.FileName;
        }
        private void SetStatus(string stat)
        {
            BeginInvoke((Action)(() =>
            {
                _lblStatus.Text = stat;
            }));
        }
        private TextureLoadResult LoadTex(string path)
        {
            _loadedImage = new Bitmap(path);
            Width = _loadedImage.Width;
            Height = _loadedImage.Height;


            int ts = 32767;// Gpu.GetMaxTextureSize();
            if (Width >= ts)
            {
                return TextureLoadResult.TooLarge;
            }
            if (Height >= ts)
            {
                return TextureLoadResult.TooLarge;
            }

            _lblHeight.Text = Height.ToString();
            _lblWidth.Text = Width.ToString();

            return TextureLoadResult.Success;
        }
        private void BeginProcess()
        {
            BeginInvoke((Action)(() =>
            {
                _btnProcess.BackColor = Color.Red;
                _btnProcess.Text = "Cancel";
                _pgbProgress.Value = 0;
                _btnOpenFileLoc.Enabled = false;
                _txtFileLoc.Enabled = false;
                _tbBumpAmount.Enabled = false;
            }));

        }
        private void EndProcess()
        {
            SetStatus("Done.");
            BeginInvoke((Action)(() =>
            {
                _btnProcess.BackColor = Color.LightGreen;
                _btnProcess.Text = "Process";
                _btnOpenFileLoc.Enabled = true;
                _txtFileLoc.Enabled = true;
                _tbBumpAmount.Enabled = true;
                _tabControl0.SelectedTab = _tabResult;
                _pgbProgress.Value = 100;
                _imageTaskTokenSource.Dispose();
                //_imageTaskToken = null;
                _imageTaskTokenSource = null;
            }));
        }
        private Bitmap CloneImage(Bitmap imgIn)
        {
            Rectangle cloneRect = new Rectangle(0, 0, imgIn.Width, imgIn.Height);
            PixelFormat format = imgIn.PixelFormat;
            Bitmap ret = imgIn.Clone(cloneRect, format);
            return ret;
        }
        private Bitmap NormalizeImage(Bitmap imgIn, float fAmount, BumpMapType eMapType, float fContrast)
        {
            BeginProcess();

            //Copy Bitmap data to new image

            BeginInvoke((Action)(() =>
            {
                _pgbProgress.Value = 10;
            }));

            //Run in loop
            Bitmap imgOut = NormalizeImageLoop(imgIn, fAmount, eMapType, fContrast);

            EndProcess();

            return imgOut;
        }
        private Bitmap NormalizeImageLoop(Bitmap imgIn, float fAmount, BumpMapType eMapType, float fContrast)
        {
            Bitmap imgOut = CloneImage(imgIn);

            int wi = imgIn.Width;
            int hi = imgIn.Height;

            //Normalize all shit
            for (int yi = 0; yi < imgIn.Height; ++yi)
            {
                for (int xi = 0; xi < imgIn.Width; ++xi)
                {
                    Color c = normalizePixel(xi, yi, imgIn, fAmount, eMapType, fContrast);
                    imgOut.SetPixel(xi, yi, c);
                    if (_imageTaskToken.IsCancellationRequested)
                    {
                        return null;
                    }
                }
                float fProgress = (float)(yi * wi) / (wi * hi) * 90.0f;
                int iProgress = (int)Math.Min(10 + (int)fProgress, 100);
                BeginInvoke((Action)(() =>
                {
                    _pgbProgress.Value = iProgress;
                }));
                SetStatus(iProgress + "%");
                if (iProgress % 10 == 0)
                {
                    Bitmap sendImg = CloneImage(imgOut);
                    //Update image every 10 percent
                    BeginInvoke((Action)(() =>
                    {
                        _pbResult.Image = sendImg;
                        _tabControl0.SelectedTab = _tabResult;
                    }));
                }
            }

            BeginInvoke((Action)(() =>
            {
                _pbResult.Image = imgOut;
            }));

            return imgOut;
        }
        int hwrap(int off, Bitmap b)
        {
            int ret = off % b.Width;
            if (ret < 0)
            {
                ret += b.Width;
            }
            return ret;
        }
        int vwrap(int off, Bitmap b)
        {
            int ret = off % b.Height;
            if (ret < 0)
            {
                ret += b.Height;
            }
            return ret;
        }
        float pav(int x, int y, Bitmap b, float fC)
        {
            return contrast(pixelAverage24(pixelAt32(hwrap(x, b), vwrap(y, b), b)), fC);
        }
        Color normalizePixel(int x, int y, Bitmap b, float fAmount, BumpMapType eMapType, float fContrast)
        {
            float c = fContrast;
            // = 
            float[] mat = new float[]
            {
            pav(x - 1, y - 1, b, c),pav(x  ,y - 1, b, c),pav(x + 1,y - 1, b, c),
            pav(x - 1, y    , b, c),pav(x  ,y    , b, c),pav(x + 1,y    , b, c),
            pav(x - 1, y + 1, b, c),pav(x  ,y + 1, b, c),pav(x + 1,y + 1, b, c)
            };


            float[] sobel_v1 = new float[] {
                 3, 10, 3,
                 0,     0, 0,
                -3,-10,-3
            };
            float[] sobel_h1 = new float[] {
                 3, 0,-3,
                10, 0,-10,
                 3, 0,-3
            };

            float sumH1 = 0, sumV1 = 0, sumH2 = 0, sumV2 = 0;
            for (int i = 0; i < 9; ++i)
            {
                sumH1 += mat[i] * sobel_h1[i];
                sumV1 += mat[i] * sobel_v1[i];
                //sumH2 += mat[i]*sobel_h2[i];
                //sumV2 += mat[i]*sobel_v2[i];
            }

            float fH1 = (sumH1 + 16.0f) / 32.0f;//max range of this kernel will be [-4,4] - scale into [0,1]
            float fV1 = (sumV1 + 16.0f) / 32.0f;
            //float fH2 = ((float)sumH2 + 1024.0f)*div_1;//max range of this kernel will be [-1024,1024] - scale into [0,1]
            //float fV2 = ((float)sumV2 + 1024.0f)*div_1;

            // average sobel in both directions.
            // This doesn't work they smooth out to zero in both directions
            //float fH = (fH1 + fH2) *.5;
            //float fV = (fV1 + fV2) *.5;
            //static Vec3f sum(0,0,0);

            //**Due to the problems with normal mapping the y really can't be any different from 1 or else the
            //filter will skew the bump map in +z or +x
            // Vec3f v(fH1, .67f, fV1);//problem with bump mapping normals being negative forced us to do this. they are negative when you have a high depth magnitude +-1.0 
            //no values below or at .5
            // 1 = little or no bump
            //.58 - .8 
            float vx = fH1;
            float vy = fAmount;// 0.67f;
            float vz = fV1;

            // v = (v * 2.0f) - 1.0f;//untranslate in order to normalize
            vx = (vx * 2.0f) - 1.0f;
            vy = (vy * 2.0f) - 1.0f;
            vz = (vz * 2.0f) - 1.0f;


            //salt
            //v += vec3::normalize(Vec3f(Alg::meft11(x | rand()), 0, Alg::meft11(y | rand()))) * 0.002262058f;

            //v.normalize();
            float len = (float)Math.Sqrt(vx * vx + vy * vy + vz * vz);
            if (len == 0) { len = 0.00001f; }
            vx = vx / len;
            vy = vy / len;
            vz = vz / len;

            //v = (v + 1.0f) / 2.0f;//translate back
            vx = (vx + 1.0f) / 2.0f;
            vy = (vy + 1.0f) / 2.0f;
            vz = (vz + 1.0f) / 2.0f;

            //v *= 255.0f;
            vx = vx * 255.0f;
            vy = vy * 255.0f;
            vz = vz * 255.0f;

            // - swapping g with b doesn't work. Z points into the screen.
            //Pixel4ub pix;
            //pix.r() = (t_byte)(v.x);
            //pix.g() = (t_byte)(v.y);
            //pix.b() = (t_byte)(v.z);
            //pix.a() = pixelAt32(hwrap(x), vwrap(y)).a();//allow for transparency don't change!
            Color ret = Color.Red;
            if (eMapType == BumpMapType.Normal)
            {
                ret = Color.FromArgb((byte)vx, (byte)vy, (byte)vz);
            }
            else if (eMapType == BumpMapType.Bump)
            {
                ret = Color.FromArgb((byte)vx, (byte)vz, (byte)vy);
            }

            return ret;
        }
        Color pixelAt32(int xi, int yi, Bitmap b)
        {
            return b.GetPixel(xi, yi);
        }
        float pixelAverage24(Color inpx)
        {
            float f_13 = (1.0f / 3.0f);
            float c_255 = (1.0f / 255.0f);
            return (
                (float)(inpx.R) * c_255 +
                (float)(inpx.G) * c_255 +
                (float)(inpx.B) * c_255) * f_13; // (r+g+b) /3
        }
        float contrast(float pix, float C)
        {
            return (float)Math.Pow(pix, C);
        }

        private void _lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void _lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void _tbBumpAmount_Scroll(object sender, EventArgs e)
        {
            UpdateUi();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAndLoadImage();
        }
        private void GetAndLoadImage()
        {
            string str = GetValidOpenSaveUserFile(false);
            _txtFileLoc.Text = str;
            try
            {
                if (LoadTex(_txtFileLoc.Text) == TextureLoadResult.Success)
                {
                    _pbLoaded.Image = _loadedImage;
                    _tabControl0.SelectedTab = _tabLoaded;

                }
            }
            catch (Exception ex)
            {
                SetStatus(ex.ToString());
            }
        }

        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string str = GetValidOpenSaveUserFile(true);
                if (str != String.Empty)
                {
                    _pbResult.Image.Save(str);
                }
            }
            catch (Exception ex)
            {
                SetStatus(ex.ToString());
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            saveResultToolStripMenuItem.Enabled = _pbResult.Image != null;
        }

        private void _lblBumpAmount_TextChanged(object sender, EventArgs e)
        {
            float f;
            if(float.TryParse(_lblBumpAmount.Text, out f))
            {
                f = (f + 1.0f) / 2.0f;
                int iVal = (int)(f * (float)_tbBumpAmount.Maximum);
                if(iVal < _tbBumpAmount.Minimum)
                {
                    iVal = _tbBumpAmount.Minimum;
                }
                if(iVal > _tbBumpAmount.Maximum)
                {
                    iVal = _tbBumpAmount.Maximum;
                }
                _tbBumpAmount.Value = iVal;
                UpdateUi();
            }

        }

        private void _lblContrastValue_TextChanged(object sender, EventArgs e)
        {
            float f;
            if(float.TryParse(_lblContrastValue.Text, out f))
            {
                int iVal = (int)(f * (float)_tbContrast.Maximum);
                if (iVal < _tbContrast.Minimum)
                {
                    iVal = _tbContrast.Minimum;
                }
                if (iVal > _tbContrast.Maximum)
                {
                    iVal = _tbContrast.Maximum;
                }
                _tbContrast.Value = iVal;
                UpdateUi();
            }
        }
    }
}
