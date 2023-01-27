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
            }
            else 
            {
                MessageBox.Show("QR Code was not generated.", "Caption", MessageBoxButtons.OK);
            }
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
    }
}
