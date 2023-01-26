
namespace Barcode_Application
{
    partial class frmBarcodeApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabsheet1 = new System.Windows.Forms.TabControl();
            this.tbsWelcome = new System.Windows.Forms.TabPage();
            this.tbsGenerateQR = new System.Windows.Forms.TabPage();
            this.lblGenProductCode = new System.Windows.Forms.Label();
            this.picbxGenImage = new System.Windows.Forms.PictureBox();
            this.txtGenQRCode = new System.Windows.Forms.TextBox();
            this.lblGenQRCodeHead = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbsScanQR = new System.Windows.Forms.TabPage();
            this.cbbScanCameraList = new System.Windows.Forms.ComboBox();
            this.lblScanProductCode = new System.Windows.Forms.Label();
            this.txtScanQRCode = new System.Windows.Forms.TextBox();
            this.picbxScanImage = new System.Windows.Forms.PictureBox();
            this.lblScanCameraHead = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.tabsheet1.SuspendLayout();
            this.tbsGenerateQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGenImage)).BeginInit();
            this.tbsScanQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxScanImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsheet1
            // 
            this.tabsheet1.Controls.Add(this.tbsWelcome);
            this.tabsheet1.Controls.Add(this.tbsGenerateQR);
            this.tabsheet1.Controls.Add(this.tbsScanQR);
            this.tabsheet1.Location = new System.Drawing.Point(12, 12);
            this.tabsheet1.Name = "tabsheet1";
            this.tabsheet1.SelectedIndex = 0;
            this.tabsheet1.Size = new System.Drawing.Size(393, 606);
            this.tabsheet1.TabIndex = 4;
            // 
            // tbsWelcome
            // 
            this.tbsWelcome.Location = new System.Drawing.Point(4, 22);
            this.tbsWelcome.Name = "tbsWelcome";
            this.tbsWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tbsWelcome.Size = new System.Drawing.Size(385, 580);
            this.tbsWelcome.TabIndex = 0;
            this.tbsWelcome.Text = "Welcome";
            this.tbsWelcome.UseVisualStyleBackColor = true;
            // 
            // tbsGenerateQR
            // 
            this.tbsGenerateQR.Controls.Add(this.lblGenProductCode);
            this.tbsGenerateQR.Controls.Add(this.picbxGenImage);
            this.tbsGenerateQR.Controls.Add(this.txtGenQRCode);
            this.tbsGenerateQR.Controls.Add(this.lblGenQRCodeHead);
            this.tbsGenerateQR.Controls.Add(this.btnGenerate);
            this.tbsGenerateQR.Location = new System.Drawing.Point(4, 22);
            this.tbsGenerateQR.Name = "tbsGenerateQR";
            this.tbsGenerateQR.Padding = new System.Windows.Forms.Padding(3);
            this.tbsGenerateQR.Size = new System.Drawing.Size(385, 580);
            this.tbsGenerateQR.TabIndex = 1;
            this.tbsGenerateQR.Text = "Generate QR";
            this.tbsGenerateQR.UseVisualStyleBackColor = true;
            // 
            // lblGenProductCode
            // 
            this.lblGenProductCode.AutoSize = true;
            this.lblGenProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenProductCode.Location = new System.Drawing.Point(15, 401);
            this.lblGenProductCode.Name = "lblGenProductCode";
            this.lblGenProductCode.Size = new System.Drawing.Size(171, 22);
            this.lblGenProductCode.TabIndex = 12;
            this.lblGenProductCode.Text = "Type Product Code:";
            // 
            // picbxGenImage
            // 
            this.picbxGenImage.BackColor = System.Drawing.Color.White;
            this.picbxGenImage.Location = new System.Drawing.Point(19, 38);
            this.picbxGenImage.Name = "picbxGenImage";
            this.picbxGenImage.Size = new System.Drawing.Size(345, 345);
            this.picbxGenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbxGenImage.TabIndex = 11;
            this.picbxGenImage.TabStop = false;
            // 
            // txtGenQRCode
            // 
            this.txtGenQRCode.Location = new System.Drawing.Point(19, 426);
            this.txtGenQRCode.Multiline = true;
            this.txtGenQRCode.Name = "txtGenQRCode";
            this.txtGenQRCode.Size = new System.Drawing.Size(345, 61);
            this.txtGenQRCode.TabIndex = 10;
            // 
            // lblGenQRCodeHead
            // 
            this.lblGenQRCodeHead.AutoSize = true;
            this.lblGenQRCodeHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenQRCodeHead.Location = new System.Drawing.Point(15, 13);
            this.lblGenQRCodeHead.Name = "lblGenQRCodeHead";
            this.lblGenQRCodeHead.Size = new System.Drawing.Size(90, 22);
            this.lblGenQRCodeHead.TabIndex = 9;
            this.lblGenQRCodeHead.Text = "QR Code:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(19, 503);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(345, 58);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbsScanQR
            // 
            this.tbsScanQR.Controls.Add(this.cbbScanCameraList);
            this.tbsScanQR.Controls.Add(this.lblScanProductCode);
            this.tbsScanQR.Controls.Add(this.txtScanQRCode);
            this.tbsScanQR.Controls.Add(this.picbxScanImage);
            this.tbsScanQR.Controls.Add(this.lblScanCameraHead);
            this.tbsScanQR.Controls.Add(this.btnScan);
            this.tbsScanQR.Location = new System.Drawing.Point(4, 22);
            this.tbsScanQR.Name = "tbsScanQR";
            this.tbsScanQR.Padding = new System.Windows.Forms.Padding(3);
            this.tbsScanQR.Size = new System.Drawing.Size(385, 580);
            this.tbsScanQR.TabIndex = 2;
            this.tbsScanQR.Text = "Scan QR";
            this.tbsScanQR.UseVisualStyleBackColor = true;
            // 
            // cbbScanCameraList
            // 
            this.cbbScanCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbScanCameraList.FormattingEnabled = true;
            this.cbbScanCameraList.Location = new System.Drawing.Point(114, 18);
            this.cbbScanCameraList.Name = "cbbScanCameraList";
            this.cbbScanCameraList.Size = new System.Drawing.Size(253, 21);
            this.cbbScanCameraList.TabIndex = 18;
            // 
            // lblScanProductCode
            // 
            this.lblScanProductCode.AutoSize = true;
            this.lblScanProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanProductCode.Location = new System.Drawing.Point(18, 414);
            this.lblScanProductCode.Name = "lblScanProductCode";
            this.lblScanProductCode.Size = new System.Drawing.Size(125, 22);
            this.lblScanProductCode.TabIndex = 17;
            this.lblScanProductCode.Text = "Product Code:";
            // 
            // txtScanQRCode
            // 
            this.txtScanQRCode.Location = new System.Drawing.Point(22, 439);
            this.txtScanQRCode.Multiline = true;
            this.txtScanQRCode.Name = "txtScanQRCode";
            this.txtScanQRCode.Size = new System.Drawing.Size(345, 61);
            this.txtScanQRCode.TabIndex = 16;
            // 
            // picbxScanImage
            // 
            this.picbxScanImage.BackColor = System.Drawing.Color.White;
            this.picbxScanImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxScanImage.Location = new System.Drawing.Point(22, 44);
            this.picbxScanImage.Name = "picbxScanImage";
            this.picbxScanImage.Size = new System.Drawing.Size(345, 345);
            this.picbxScanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbxScanImage.TabIndex = 14;
            this.picbxScanImage.TabStop = false;
            // 
            // lblScanCameraHead
            // 
            this.lblScanCameraHead.AutoSize = true;
            this.lblScanCameraHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanCameraHead.Location = new System.Drawing.Point(18, 16);
            this.lblScanCameraHead.Name = "lblScanCameraHead";
            this.lblScanCameraHead.Size = new System.Drawing.Size(78, 22);
            this.lblScanCameraHead.TabIndex = 13;
            this.lblScanCameraHead.Text = "Camera:";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(22, 506);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(345, 58);
            this.btnScan.TabIndex = 12;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // frmBarcodeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 630);
            this.Controls.Add(this.tabsheet1);
            this.Name = "frmBarcodeApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBarcodeApplication_FormClosing);
            this.Load += new System.EventHandler(this.frmBarcodeApplication_Load);
            this.tabsheet1.ResumeLayout(false);
            this.tbsGenerateQR.ResumeLayout(false);
            this.tbsGenerateQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGenImage)).EndInit();
            this.tbsScanQR.ResumeLayout(false);
            this.tbsScanQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxScanImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsheet1;
        private System.Windows.Forms.TabPage tbsWelcome;
        private System.Windows.Forms.TabPage tbsGenerateQR;
        private System.Windows.Forms.PictureBox picbxGenImage;
        private System.Windows.Forms.TextBox txtGenQRCode;
        private System.Windows.Forms.Label lblGenQRCodeHead;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblGenProductCode;
        private System.Windows.Forms.TabPage tbsScanQR;
        private System.Windows.Forms.ComboBox cbbScanCameraList;
        private System.Windows.Forms.Label lblScanProductCode;
        private System.Windows.Forms.TextBox txtScanQRCode;
        private System.Windows.Forms.PictureBox picbxScanImage;
        private System.Windows.Forms.Label lblScanCameraHead;
        private System.Windows.Forms.Button btnScan;
    }
}

