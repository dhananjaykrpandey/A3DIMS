namespace A3DLicense
{
    partial class FrmLicense
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicense));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.RdTxtName = new Telerik.WinControls.UI.RadTextBox();
            this.RdTxtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.RdTxtContactNo2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.RdTxtContactNo1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.RdBtnDownload = new Telerik.WinControls.UI.RadButton();
            this.RdBtnRegister = new Telerik.WinControls.UI.RadButton();
            this.RdBtnClose = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtContactNo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtContactNo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdBtnDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdBtnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(0, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(36, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Name";
            // 
            // RdTxtName
            // 
            this.RdTxtName.Location = new System.Drawing.Point(81, 10);
            this.RdTxtName.MaxLength = 50;
            this.RdTxtName.Name = "RdTxtName";
            this.RdTxtName.NullText = "Enter Name (Compnay Name/User Name)";
            this.RdTxtName.Size = new System.Drawing.Size(338, 20);
            this.RdTxtName.TabIndex = 1;
            // 
            // RdTxtEmail
            // 
            this.RdTxtEmail.Location = new System.Drawing.Point(81, 36);
            this.RdTxtEmail.MaxLength = 50;
            this.RdTxtEmail.Name = "RdTxtEmail";
            this.RdTxtEmail.NullText = "Enter Email-ID (Email-ID For Registration)";
            this.RdTxtEmail.Size = new System.Drawing.Size(338, 20);
            this.RdTxtEmail.TabIndex = 3;
            this.RdTxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.RdTxtEmail_Validating);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(0, 38);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(48, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Email-ID";
            // 
            // RdTxtContactNo2
            // 
            this.RdTxtContactNo2.Location = new System.Drawing.Point(81, 88);
            this.RdTxtContactNo2.MaxLength = 13;
            this.RdTxtContactNo2.Name = "RdTxtContactNo2";
            this.RdTxtContactNo2.NullText = "Enter Contact No. - 2";
            this.RdTxtContactNo2.Size = new System.Drawing.Size(187, 20);
            this.RdTxtContactNo2.TabIndex = 7;
            this.RdTxtContactNo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RdTxtContactNo1_KeyPress);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(0, 90);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(79, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Contact No. -2";
            // 
            // RdTxtContactNo1
            // 
            this.RdTxtContactNo1.Location = new System.Drawing.Point(81, 62);
            this.RdTxtContactNo1.MaxLength = 13;
            this.RdTxtContactNo1.Name = "RdTxtContactNo1";
            this.RdTxtContactNo1.NullText = "Enter Contact No. - 1";
            this.RdTxtContactNo1.Size = new System.Drawing.Size(187, 20);
            this.RdTxtContactNo1.TabIndex = 5;
            this.RdTxtContactNo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RdTxtContactNo1_KeyPress);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(0, 64);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(79, 18);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Contact No. -1";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.RdBtnDownload);
            this.radPanel1.Controls.Add(this.RdBtnRegister);
            this.radPanel1.Controls.Add(this.RdBtnClose);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 139);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(441, 39);
            this.radPanel1.TabIndex = 8;
            // 
            // RdBtnDownload
            // 
            this.RdBtnDownload.BackColor = System.Drawing.Color.Transparent;
            this.RdBtnDownload.Image = ((System.Drawing.Image)(resources.GetObject("RdBtnDownload.Image")));
            this.RdBtnDownload.Location = new System.Drawing.Point(2, 5);
            this.RdBtnDownload.Name = "RdBtnDownload";
            this.RdBtnDownload.Size = new System.Drawing.Size(110, 28);
            this.RdBtnDownload.TabIndex = 1;
            this.RdBtnDownload.Text = "&Download File";
            this.RdBtnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RdBtnDownload.Click += new System.EventHandler(this.RdBtnDownload_Click);
            // 
            // RdBtnRegister
            // 
            this.RdBtnRegister.BackColor = System.Drawing.Color.Transparent;
            this.RdBtnRegister.Image = global::A3DLicense.ArnikaTechnologies.OK16X16;
            this.RdBtnRegister.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdBtnRegister.Location = new System.Drawing.Point(236, 5);
            this.RdBtnRegister.Name = "RdBtnRegister";
            this.RdBtnRegister.Size = new System.Drawing.Size(89, 28);
            this.RdBtnRegister.TabIndex = 1;
            this.RdBtnRegister.Text = "&Register";
            this.RdBtnRegister.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.RdBtnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // RdBtnClose
            // 
            this.RdBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.RdBtnClose.Image = global::A3DLicense.ArnikaTechnologies.Close16X16;
            this.RdBtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdBtnClose.Location = new System.Drawing.Point(331, 5);
            this.RdBtnClose.Name = "RdBtnClose";
            this.RdBtnClose.Size = new System.Drawing.Size(89, 28);
            this.RdBtnClose.TabIndex = 0;
            this.RdBtnClose.Text = "&Close";
            this.RdBtnClose.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.RdBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RdBtnClose.Click += new System.EventHandler(this.RdBtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 178);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.RdTxtContactNo2);
            this.Controls.Add(this.RdTxtEmail);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.RdTxtContactNo1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.RdTxtName);
            this.Controls.Add(this.radLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLicense";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "A3D License System";
            this.Load += new System.EventHandler(this.FrmLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtContactNo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtContactNo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RdBtnDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdBtnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox RdTxtName;
        private Telerik.WinControls.UI.RadTextBox RdTxtEmail;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox RdTxtContactNo2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox RdTxtContactNo1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton RdBtnDownload;
        private Telerik.WinControls.UI.RadButton RdBtnRegister;
        private Telerik.WinControls.UI.RadButton RdBtnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}