namespace A3DIMS.ReferenceForms
{
    partial class FrmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnit));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnExport = new System.Windows.Forms.ToolStripButton();
            this.BtnReload = new System.Windows.Forms.ToolStripButton();
            this.BtnPrint = new System.Windows.Forms.ToolStripButton();
            this.BtnFind = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnMoveLast = new System.Windows.Forms.ToolStripButton();
            this.BtnMoveNext = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TxtPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BtnMovePrevious = new System.Windows.Forms.ToolStripButton();
            this.BtnMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BtnUndo = new System.Windows.Forms.ToolStripButton();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnAddNew = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.RdGrdClass = new Telerik.WinControls.UI.RadGridView();
            this.RdTbpList = new Telerik.WinControls.UI.RadPageViewPage();
            this.RdTxtUnitRemarks = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RdTxtUnitCode = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.RdChkClassStatus = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.RdTbpEntry = new Telerik.WinControls.UI.RadPageViewPage();
            this.RdTxtUnitDescription = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RdPageViewMain = new Telerik.WinControls.UI.RadPageView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdGrdClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdGrdClass.MasterTemplate)).BeginInit();
            this.RdTbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtUnitRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtUnitCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdChkClassStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.RdTbpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtUnitDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdPageViewMain)).BeginInit();
            this.RdPageViewMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnExport
            // 
            this.BtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnExport.Image = global::A3DIMS.Properties.Resources.Excel16X16;
            this.BtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(23, 22);
            this.BtnExport.Text = "Export to Excel";
            this.BtnExport.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnReload
            // 
            this.BtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnReload.Image = global::A3DIMS.Properties.Resources.Reload16X16;
            this.BtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(23, 22);
            this.BtnReload.Text = "Reload / Refresh";
            this.BtnReload.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrint.Image = global::A3DIMS.Properties.Resources.Print16X16;
            this.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(23, 22);
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFind.Image = global::A3DIMS.Properties.Resources.Find16X16;
            this.BtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(23, 22);
            this.BtnFind.Text = "Find";
            this.BtnFind.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnMoveLast
            // 
            this.BtnMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("BtnMoveLast.Image")));
            this.BtnMoveLast.Name = "BtnMoveLast";
            this.BtnMoveLast.RightToLeftAutoMirrorImage = true;
            this.BtnMoveLast.Size = new System.Drawing.Size(23, 22);
            this.BtnMoveLast.Text = "Move last";
            // 
            // BtnMoveNext
            // 
            this.BtnMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnMoveNext.Image")));
            this.BtnMoveNext.Name = "BtnMoveNext";
            this.BtnMoveNext.RightToLeftAutoMirrorImage = true;
            this.BtnMoveNext.Size = new System.Drawing.Size(23, 22);
            this.BtnMoveNext.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TxtPositionItem
            // 
            this.TxtPositionItem.AccessibleName = "Position";
            this.TxtPositionItem.AutoSize = false;
            this.TxtPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPositionItem.Name = "TxtPositionItem";
            this.TxtPositionItem.Size = new System.Drawing.Size(50, 23);
            this.TxtPositionItem.Text = "0";
            this.TxtPositionItem.ToolTipText = "Current position";
            // 
            // BtnMovePrevious
            // 
            this.BtnMovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("BtnMovePrevious.Image")));
            this.BtnMovePrevious.Name = "BtnMovePrevious";
            this.BtnMovePrevious.RightToLeftAutoMirrorImage = true;
            this.BtnMovePrevious.Size = new System.Drawing.Size(23, 22);
            this.BtnMovePrevious.Text = "Move previous";
            // 
            // BtnMoveFirst
            // 
            this.BtnMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("BtnMoveFirst.Image")));
            this.BtnMoveFirst.Name = "BtnMoveFirst";
            this.BtnMoveFirst.RightToLeftAutoMirrorImage = true;
            this.BtnMoveFirst.Size = new System.Drawing.Size(23, 22);
            this.BtnMoveFirst.Text = "Move first";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnUndo
            // 
            this.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnUndo.Image = global::A3DIMS.Properties.Resources.UndoRed16X16;
            this.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(23, 22);
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = global::A3DIMS.Properties.Resources.save_all;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnClose.Image = global::A3DIMS.Properties.Resources.Close16X16;
            this.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(23, 22);
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RightToLeftAutoMirrorImage = true;
            this.BtnDelete.Size = new System.Drawing.Size(23, 22);
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddNew,
            this.BtnEdit,
            this.BtnDelete,
            this.BtnSave,
            this.BtnUndo,
            this.bindingNavigatorSeparator,
            this.BtnMoveFirst,
            this.BtnMovePrevious,
            this.TxtPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.BtnMoveNext,
            this.BtnMoveLast,
            this.bindingNavigatorSeparator2,
            this.BtnFind,
            this.BtnPrint,
            this.BtnReload,
            this.BtnExport,
            this.BtnClose,
            this.toolStripSeparator1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.BtnMoveFirst;
            this.bindingNavigator1.MoveLastItem = this.BtnMoveLast;
            this.bindingNavigator1.MoveNextItem = this.BtnMoveNext;
            this.bindingNavigator1.MovePreviousItem = this.BtnMovePrevious;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.TxtPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAddNew.Image = global::A3DIMS.Properties.Resources.Add16X16;
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.RightToLeftAutoMirrorImage = true;
            this.BtnAddNew.Size = new System.Drawing.Size(23, 22);
            this.BtnAddNew.Text = "Add new";
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEdit.Image = global::A3DIMS.Properties.Resources.Edit16X16;
            this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(23, 22);
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // RdGrdClass
            // 
            this.RdGrdClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.RdGrdClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.RdGrdClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdGrdClass.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RdGrdClass.ForeColor = System.Drawing.Color.Black;
            this.RdGrdClass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RdGrdClass.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.RdGrdClass.MasterTemplate.AllowAddNewRow = false;
            this.RdGrdClass.MasterTemplate.AllowDeleteRow = false;
            this.RdGrdClass.MasterTemplate.AllowEditRow = false;
            this.RdGrdClass.MasterTemplate.AllowSearchRow = true;
            this.RdGrdClass.MasterTemplate.AutoGenerateColumns = false;
            this.RdGrdClass.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "cUnitCode";
            gridViewTextBoxColumn2.HeaderText = "Unit Code";
            gridViewTextBoxColumn2.Name = "cUnitCode";
            gridViewTextBoxColumn2.Width = 256;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "cUnitDesc";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.HeaderText = "Unit Description";
            gridViewDateTimeColumn2.Name = "cUnitDesc";
            gridViewDateTimeColumn2.Width = 336;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "lUnitStatus";
            gridViewCheckBoxColumn2.HeaderText = "Status";
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "lUnitStatus";
            gridViewCheckBoxColumn2.Width = 168;
            this.RdGrdClass.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn2,
            gridViewCheckBoxColumn2});
            this.RdGrdClass.MasterTemplate.EnableFiltering = true;
            this.RdGrdClass.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.RdGrdClass.Name = "RdGrdClass";
            this.RdGrdClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RdGrdClass.Size = new System.Drawing.Size(779, 369);
            this.RdGrdClass.TabIndex = 0;
            this.RdGrdClass.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.RdGrdClass_CellDoubleClick);
            // 
            // RdTbpList
            // 
            this.RdTbpList.Controls.Add(this.RdGrdClass);
            this.RdTbpList.Image = global::A3DIMS.Properties.Resources.ListView25X24;
            this.RdTbpList.ItemSize = new System.Drawing.SizeF(96F, 36F);
            this.RdTbpList.Location = new System.Drawing.Point(10, 45);
            this.RdTbpList.Name = "RdTbpList";
            this.RdTbpList.Size = new System.Drawing.Size(779, 369);
            this.RdTbpList.Text = "Details List";
            // 
            // RdTxtUnitRemarks
            // 
            this.RdTxtUnitRemarks.BackColor = System.Drawing.Color.White;
            this.RdTxtUnitRemarks.Location = new System.Drawing.Point(166, 88);
            this.RdTxtUnitRemarks.MaxLength = 500;
            this.RdTxtUnitRemarks.Multiline = true;
            this.RdTxtUnitRemarks.Name = "RdTxtUnitRemarks";
            this.RdTxtUnitRemarks.NullText = "Enter Unit Remarks";
            // 
            // 
            // 
            this.RdTxtUnitRemarks.RootElement.UseDefaultDisabledPaint = false;
            this.RdTxtUnitRemarks.Size = new System.Drawing.Size(339, 38);
            this.RdTxtUnitRemarks.TabIndex = 2;
            // 
            // RdTxtUnitCode
            // 
            this.RdTxtUnitCode.BackColor = System.Drawing.Color.White;
            this.RdTxtUnitCode.Location = new System.Drawing.Point(166, 36);
            this.RdTxtUnitCode.MaxLength = 10;
            this.RdTxtUnitCode.Name = "RdTxtUnitCode";
            this.RdTxtUnitCode.NullText = "Enter Unit Code";
            // 
            // 
            // 
            this.RdTxtUnitCode.RootElement.UseDefaultDisabledPaint = false;
            this.RdTxtUnitCode.Size = new System.Drawing.Size(141, 20);
            this.RdTxtUnitCode.TabIndex = 0;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(16, 132);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(37, 18);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Status";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(16, 90);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(73, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Unit Remarks";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(16, 64);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(93, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Unit Description";
            // 
            // RdChkClassStatus
            // 
            this.RdChkClassStatus.Location = new System.Drawing.Point(166, 132);
            this.RdChkClassStatus.Name = "RdChkClassStatus";
            this.RdChkClassStatus.Size = new System.Drawing.Size(106, 18);
            this.RdChkClassStatus.TabIndex = 3;
            this.RdChkClassStatus.Text = "Active / In-Active";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(15, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(59, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Unit Code";
            // 
            // RdTbpEntry
            // 
            this.RdTbpEntry.Controls.Add(this.RdTxtUnitRemarks);
            this.RdTbpEntry.Controls.Add(this.RdTxtUnitDescription);
            this.RdTbpEntry.Controls.Add(this.RdTxtUnitCode);
            this.RdTbpEntry.Controls.Add(this.radLabel4);
            this.RdTbpEntry.Controls.Add(this.radLabel3);
            this.RdTbpEntry.Controls.Add(this.radLabel2);
            this.RdTbpEntry.Controls.Add(this.RdChkClassStatus);
            this.RdTbpEntry.Controls.Add(this.radLabel1);
            this.RdTbpEntry.Image = global::A3DIMS.Properties.Resources.CartView25X24;
            this.RdTbpEntry.ItemSize = new System.Drawing.SizeF(67F, 36F);
            this.RdTbpEntry.Location = new System.Drawing.Point(10, 45);
            this.RdTbpEntry.Name = "RdTbpEntry";
            this.RdTbpEntry.Size = new System.Drawing.Size(779, 369);
            this.RdTbpEntry.Text = "Entry";
            // 
            // RdTxtUnitDescription
            // 
            this.RdTxtUnitDescription.BackColor = System.Drawing.Color.White;
            this.RdTxtUnitDescription.Location = new System.Drawing.Point(166, 62);
            this.RdTxtUnitDescription.MaxLength = 200;
            this.RdTxtUnitDescription.Name = "RdTxtUnitDescription";
            this.RdTxtUnitDescription.NullText = "Enter Unit Description";
            // 
            // 
            // 
            this.RdTxtUnitDescription.RootElement.UseDefaultDisabledPaint = false;
            this.RdTxtUnitDescription.Size = new System.Drawing.Size(339, 20);
            this.RdTxtUnitDescription.TabIndex = 1;
            // 
            // RdPageViewMain
            // 
            this.RdPageViewMain.Controls.Add(this.RdTbpEntry);
            this.RdPageViewMain.Controls.Add(this.RdTbpList);
            this.RdPageViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdPageViewMain.Location = new System.Drawing.Point(0, 25);
            this.RdPageViewMain.Name = "RdPageViewMain";
            this.RdPageViewMain.SelectedPage = this.RdTbpEntry;
            this.RdPageViewMain.Size = new System.Drawing.Size(800, 425);
            this.RdPageViewMain.TabIndex = 5;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.RdPageViewMain.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.ItemList;
            // 
            // FrmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RdPageViewMain);
            this.Controls.Add(this.bindingNavigator1);
            this.KeyPreview = true;
            this.Name = "FrmUnit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Unit";
            this.Load += new System.EventHandler(this.FrmUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdGrdClass.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdGrdClass)).EndInit();
            this.RdTbpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtUnitRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtUnitCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdChkClassStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.RdTbpEntry.ResumeLayout(false);
            this.RdTbpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdTxtUnitDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdPageViewMain)).EndInit();
            this.RdPageViewMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnExport;
        private System.Windows.Forms.ToolStripButton BtnReload;
        private System.Windows.Forms.ToolStripButton BtnPrint;
        private System.Windows.Forms.ToolStripButton BtnFind;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton BtnMoveLast;
        private System.Windows.Forms.ToolStripButton BtnMoveNext;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox TxtPositionItem;
        private System.Windows.Forms.ToolStripButton BtnMovePrevious;
        private System.Windows.Forms.ToolStripButton BtnMoveFirst;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton BtnUndo;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton BtnAddNew;
        private System.Windows.Forms.ToolStripButton BtnEdit;
        private Telerik.WinControls.UI.RadGridView RdGrdClass;
        private Telerik.WinControls.UI.RadPageViewPage RdTbpList;
        private Telerik.WinControls.UI.RadTextBoxControl RdTxtUnitRemarks;
        private Telerik.WinControls.UI.RadTextBoxControl RdTxtUnitCode;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox RdChkClassStatus;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageViewPage RdTbpEntry;
        private Telerik.WinControls.UI.RadTextBoxControl RdTxtUnitDescription;
        private Telerik.WinControls.UI.RadPageView RdPageViewMain;
    }
}