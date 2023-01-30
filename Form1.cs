using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using QRCoder;
using ZXing;

namespace Barcode_Application
{
    //Generate QR Code: https://www.youtube.com/watch?v=32u7kb9DYEk
    //Scan QR Code: https://www.youtube.com/watch?v=pKjct-DXL0w
    public partial class frmBarcodeApplication : Form
    {
        List<Image> QRImages = new List<Image>();
        List<String> QRCodes = new List<String>();
        public frmBarcodeApplication()
        {
            InitializeComponent();
        }

        #region Welcome
        private void btnWelSale_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void btnWelGenerate_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            //Clear QR Lists
            QRImages.Clear();
            QRCodes.Clear();
        }

        private void btnWelScan_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }
        #endregion

        #region Generate QR Code
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to create a QR Code for : " /*MAKE TEXT BOLD*/+ txtGenQRCode.Text, "Confirmation", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(txtGenQRCode.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                picbxGenImage.Image = code.GetGraphic(5);
                AddToPrintQueue(picbxGenImage.Image, txtGenQRCode.Text); //Uses BitMap: (code.GetGraphic(5), code) //Uses Image: (picbxGenImage.Image, code)
            }
            else 
            {
                MessageBox.Show("QR Code was not generated.", "Abort Generate", MessageBoxButtons.OK);
            }
        }

        private void AddToPrintQueue(Image image, String code)
        {
            QRImages.Add(image);
            QRCodes.Add(code);
        }

        private void btnGenBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
        #endregion

        #region Scan QR Code
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void frmBarcodeApplication_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach(FilterInfo device in filterInfoCollection) 
            {
                cbbScanCameraList.Items.Add(device.Name);
                cbbScanCameraList.SelectedIndex = 0;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbScanCameraList.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if(result != null) 
            {
                txtScanQRCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtScanQRCode.Text = result.ToString();
                }));
            }
            picbxScanImage.Image = bitmap;
        }

        private void frmBarcodeApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null) 
            {
                if(videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }

        private void btnScanBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        #endregion

        #region Sale


        #endregion
        #region Printing
        Bitmap bmp;
        Image printedImage;
        private void prntDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, 0, 0)
            e.Graphics.DrawImageUnscaled(printedImage, 10, 10);//Print QR Image
            e.Graphics.DrawString(QRCodes[0], new Font("Arial", 40, FontStyle.Regular), Brushes.Black, 150, 125);

        }

        private void btnGenPrint_Click(object sender, EventArgs e)
        {
            prntDlg.Document = prntDoc;
            printedImage = QRImages[0];
            if(prntDlg.ShowDialog() == DialogResult.OK) 
            {
                prntDoc.Print();
            }
            //FoxLearnCode
            /*Graphics g = picbxGenImage.CreateGraphics();
            bmp = new Bitmap(picbxGenImage.Size.Height, picbxGenImage.Size.Width, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(picbxGenImage.Location.X, picbxGenImage.Location.Y, 0, 0, picbxGenImage.Size);
            prntPrvDlg.ShowDialog();*/
            return;
            if(QRImages.Count > 0) 
            {
                for (int i = 0; i < QRImages.Count - 1; i++)
                {
                    //Print QRImages[i]
                    printedImage = QRImages[i];
                    prntPrvDlg.ShowDialog();
                    //Print QRCodes[i]


                }
            }
            else 
            {
                MessageBox.Show("QR Code(s) was not printed.", "Abort Print", MessageBoxButtons.OK);
            }

            /*//FoxLearnCode
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Height, this.Size.Width, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            prntPrvDlg.ShowDialog(); */
        }
        #endregion
    }
}
