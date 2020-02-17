namespace A3DIMS.Common.Forms
{
    partial class frmSearch
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.grdSearch = new Telerik.WinControls.UI.RadGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.txtSearchKeyWord = new Telerik.WinControls.UI.RadTextBox();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnOk = new Telerik.WinControls.UI.RadButton();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKeyWord)).BeginInit();
            this.panelbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSearch
            // 
            this.grdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSearch.AutoSizeRows = true;
            this.grdSearch.Location = new System.Drawing.Point(2, 3);
            // 
            // 
            // 
            this.grdSearch.MasterTemplate.AllowAddNewRow = false;
            this.grdSearch.MasterTemplate.AllowDeleteRow = false;
            this.grdSearch.MasterTemplate.AllowEditRow = false;
            this.grdSearch.MasterTemplate.AllowSearchRow = true;
            this.grdSearch.MasterTemplate.AutoGenerateColumns = false;
            this.grdSearch.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdSearch.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(598, 214);
            this.grdSearch.TabIndex = 8;
            this.grdSearch.Text = "radGridView1";
            this.grdSearch.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdSearch_CellClick);
            this.grdSearch.DoubleClick += new System.EventHandler(this.grdSearch_DoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(1, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchKeyWord);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdSearch);
            this.splitContainer1.Panel2.Controls.Add(this.panelbutton);
            this.splitContainer1.Size = new System.Drawing.Size(605, 303);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search Keyword";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = global::A3DIMS.Properties.Resources.searchicon;
            this.btnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(525, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 24);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKeyWord
            // 
            this.txtSearchKeyWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchKeyWord.Location = new System.Drawing.Point(94, 8);
            this.txtSearchKeyWord.Name = "txtSearchKeyWord";
            this.txtSearchKeyWord.NullText = "Enter keyword for search...";
            this.txtSearchKeyWord.Size = new System.Drawing.Size(427, 20);
            this.txtSearchKeyWord.TabIndex = 12;
            this.txtSearchKeyWord.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearchKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchKeyWord_KeyPress);
            // 
            // panelbutton
            // 
            this.panelbutton.BackColor = System.Drawing.Color.Moccasin;
            this.panelbutton.Controls.Add(this.btnCancel);
            this.panelbutton.Controls.Add(this.btnOk);
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbutton.Location = new System.Drawing.Point(0, 221);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(603, 40);
            this.panelbutton.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::A3DIMS.Properties.Resources.Close16X16;
            this.btnCancel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Location = new System.Drawing.Point(515, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "C a n c e l";
            this.btnCancel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::A3DIMS.Properties.Resources.OK16X16;
            this.btnOk.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Location = new System.Drawing.Point(427, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 29);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.YellowGreen;
            this.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(608, 32);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSearch
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(608, 339);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(608, 339);
            this.Name = "frmSearch";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search ";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKeyWord)).EndInit();
            this.panelbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadTextBox txtSearchKeyWord;
        private System.Windows.Forms.Panel panelbutton;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnOk;
        private System.Windows.Forms.Label lblSearch;
    }
}