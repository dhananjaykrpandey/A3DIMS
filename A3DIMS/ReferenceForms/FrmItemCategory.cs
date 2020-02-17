using A3DIMS.Common.Classes;
using A3DIMS.Common.Forms;
using A3DSQLServices;
using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A3DIMS.Masters
{
    public partial class FrmItemCategory : RadForm
    {
        BindingSource BsItemCategory = new BindingSource();
        ErrorProvider errorProvider1 = new ErrorProvider();
        DataTable DtItemCategory = new DataTable();
    
        public FrmItemCategory()
        {
            InitializeComponent();
            BindControls();
        }
        private void LoadData()
        {
            DtItemCategory = InfSQLServices._IInfSQLServices.InfExecuteDataTable(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmItemCategorySelectQuery());
            BsItemCategory.DataSource = DtItemCategory.DefaultView;
            bindingNavigator1.BindingSource = BsItemCategory;
            RdGrdClass.DataSource = BsItemCategory;
        }
        private void BindControls()
        {
            try
            {

                LoadData();

                RdTxtItemCategoryCode.DataBindings.Add("Text", BsItemCategory, "cItemCategoryCode", false, DataSourceUpdateMode.OnPropertyChanged);
                RdTxtSubjectDescription.DataBindings.Add(new Binding("Text", this.BsItemCategory, "cItemCategoryDesc", true, DataSourceUpdateMode.OnPropertyChanged));
                RdTxtSubjectRemarks.DataBindings.Add(new Binding("Text", this.BsItemCategory, "cItemCategoryRemarks", true, DataSourceUpdateMode.OnPropertyChanged));
                RdChkClassStatus.DataBindings.Add(new Binding("Checked", this.BsItemCategory, "lItemCategoryStatus", true, DataSourceUpdateMode.OnPropertyChanged, false));
                //RdChkAcademicYearStatus.Checked

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        private void SetEnable(bool lValue)
        {
            RdTxtItemCategoryCode.Enabled = lValue;
            RdTxtSubjectDescription.Enabled = lValue;
            RdTxtSubjectRemarks.Enabled = lValue;
            RdChkClassStatus.Enabled = lValue;

            BtnAddNew.Enabled = !lValue;
            BtnEdit.Enabled = !lValue;
            BtnClose.Enabled = !lValue;
            BtnDelete.Enabled = !lValue;
            BtnSave.Enabled = lValue;
            BtnUndo.Enabled = lValue;
            BtnMoveFirst.Enabled = !lValue;
            BtnMoveLast.Enabled = !lValue;
            BtnMoveNext.Enabled = !lValue;
            BtnMovePrevious.Enabled = !lValue;
            TxtPositionItem.Enabled = !lValue;
            BtnFind.Enabled = !lValue;
            BtnPrint.Enabled = !lValue;
            BtnExport.Enabled = !lValue;
            BtnReload.Enabled = !lValue;

            errorProvider1.Clear();

        }
        private void SetFormMode(ClsUtility.enmFormMode _FormMode)
        {
            switch (_FormMode)
            {
                case ClsUtility.enmFormMode.AddMode:
                    SetEnable(true);
                    RdTxtItemCategoryCode.Focus();
                    break;
                case ClsUtility.enmFormMode.EditMode:
                    SetEnable(true);
                    RdTxtItemCategoryCode.Enabled = false;
                    break;
                case ClsUtility.enmFormMode.NormalMode:
                    SetEnable(false);
                    break;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.N):
                    {
                        BtnAddNew.PerformClick(); break;
                    }
                case (Keys.Control | Keys.E):
                    {
                        BtnEdit.PerformClick(); break;
                    }
                case (Keys.Control | Keys.D):
                    {
                        BtnDelete.PerformClick(); break;
                    }
                case (Keys.Control | Keys.S):
                    {
                        BtnSave.PerformClick(); break;
                    }
                case (Keys.Control | Keys.U):
                    {
                        BtnUndo.PerformClick(); break;
                    }
                case (Keys.Control | Keys.F):
                    {
                        BtnFind.PerformClick(); break;
                    }
                case (Keys.Control | Keys.R):
                    {
                        BtnReload.PerformClick(); break;
                    }
                case (Keys.Control | Keys.P):
                    {
                        BtnPrint.PerformClick(); break;
                    }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void FrmSubjects_Load(object sender, EventArgs e)
        {
            try
            {
                ClsUtility._IClsUtility.FormMode = ClsUtility.enmFormMode.NormalMode;
                SetFormMode(ClsUtility.enmFormMode.NormalMode);

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        private bool LValidateSave()
        {
            try
            {
                errorProvider1.Clear();
                bool _LValidateSave = true;
                if (!ClsUtility._IClsUtility.LValidateTextBox(RdTxtItemCategoryCode, errorProvider1, "Item Category Code Cannot Be Left Blank."))
                {
                    _LValidateSave = false;
                }
                else if (!ClsUtility._IClsUtility.LValidateTextBox(RdTxtSubjectDescription, errorProvider1, "Item Category Description Cannot Be Left Blank."))
                {

                    _LValidateSave = false;
                }
                else if (ClsUtility._IClsUtility.FormMode==ClsUtility.enmFormMode.AddMode &&  ClsUtility._IClsUtility.IsCodeExists("A3DIMS.dbo.MItemCategory", "cItemCategoryCode", RdTxtItemCategoryCode.Text.Trim(), "Item Category Code Already Exists!!"))
                {
                    errorProvider1.SetError(RdTxtItemCategoryCode, "Item Category Code Already Exists!!");
                    RdTxtItemCategoryCode.Focus();
                    _LValidateSave = false;
                }
                return _LValidateSave;
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
                return false;
            }
        }
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                BsItemCategory.AllowNew = true;
                BsItemCategory.AddNew();
                BsItemCategory.MoveLast();
                CurrencyManager cm = (CurrencyManager)this.BindingContext[BsItemCategory];
                cm.Refresh();

                ClsUtility._IClsUtility.FormMode = ClsUtility.enmFormMode.AddMode;
                SetFormMode(ClsUtility.enmFormMode.AddMode);

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ClsUtility._IClsUtility.FormMode = ClsUtility.enmFormMode.EditMode;
                SetFormMode(ClsUtility.enmFormMode.EditMode);
                RdTxtItemCategoryCode.Enabled = false;


            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClsMessage._IClsMessage.showAskDeleteMessage() == DialogResult.No) { return; }
                int IRowIndex = 0;
                IRowIndex = BsItemCategory.Position;
                DtItemCategory.DefaultView[IRowIndex].Delete();
                InfSQLServices._IInfSQLServices.InfUpdateDataAdapter(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmItemCategorySelectQuery("1=2"), DtItemCategory);
                ClsMessage._IClsMessage.showDeleteMessage();
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (LValidateSave() == false) { return; }

                int IRowIndex = 0;
                IRowIndex = BsItemCategory.Position;
                DtItemCategory.DefaultView[IRowIndex].BeginEdit();
                DtItemCategory.DefaultView[IRowIndex]["cUpdatedBy"] = GClsProjectProperties._IGClsProjectProperties.CUserID;
                DtItemCategory.DefaultView[IRowIndex]["dUpdatedDate"] = DateTime.Now;
                DtItemCategory.DefaultView[IRowIndex]["lItemCategoryStatus"] = RdChkClassStatus.Checked;
                if (ClsUtility._IClsUtility.FormMode == ClsUtility.enmFormMode.AddMode)
                {
                    DtItemCategory.DefaultView[IRowIndex]["cCreatedBy"] = GClsProjectProperties._IGClsProjectProperties.CUserID;
                    DtItemCategory.DefaultView[IRowIndex]["dCreatedDate"] = DateTime.Now;

                }
                DtItemCategory.DefaultView[IRowIndex].EndEdit();
                BsItemCategory.EndEdit();
                InfSQLServices._IInfSQLServices.InfUpdateDataAdapter(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmItemCategorySelectQuery("1=2"), DtItemCategory);
                ClsMessage._IClsMessage.showSaveMessage();
                LoadData();

                ClsUtility._IClsUtility.FormMode = ClsUtility.enmFormMode.NormalMode;
                SetFormMode(ClsUtility.enmFormMode.NormalMode);

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                BsItemCategory.CancelEdit();
                DtItemCategory.RejectChanges();
                ClsUtility._IClsUtility.FormMode = ClsUtility.enmFormMode.NormalMode;
                SetFormMode(ClsUtility.enmFormMode.NormalMode);
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmSearch frmsrch = new frmSearch())
                {
                    frmsrch.InfSqlSelectQuery = ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmItemCategorySelectQuery();
                    frmsrch.InfSqlWhereCondtion = "";
                    frmsrch.InfSqlOrderBy = "";
                    frmsrch.InfMultiSelect = false;
                    frmsrch.InfSearchFormName = "Search Item Category Code ....";
                    frmsrch.InfCodeFieldName = "Id";
                    frmsrch.InfDescriptionFieldName = "cItemCategoryCode";
                    frmsrch.InfGridFieldName = "Id,cItemCategoryCode,cItemCategoryDesc,lItemCategoryStatus";
                    frmsrch.InfGridFieldCaption = " iId, Item Category Code ,Item Category Description,Status";
                    frmsrch.InfGridFieldSize = "0,100,100,100";
                    frmsrch.ShowDialog(this);
                    //txtDesgCode.Text = frmsrch.infCodeFieldText;
                    //txtDesgName.Text = frmsrch.infDescriptionFieldText;
                    if (frmsrch.DialogResult == DialogResult.OK)
                    {
                        if (frmsrch.InfCodeFieldText != null && !string.IsNullOrEmpty(frmsrch.InfCodeFieldText.Trim()) && frmsrch.InfCodeFieldText.Trim() != "")
                        {
                            DataView dvDesg = new DataView();
                            dvDesg = frmsrch.infSearchReturnDataView;
                            dvDesg.RowFilter = "lSelect=1";
                            //txtDeptCode.Text = string.IsNullOrEmpty(dvDesg[0]["deptcode"].ToString()) == true ? "" : dvDesg[0]["deptcode"].ToString();
                            //txtDeptDesc.Text = string.IsNullOrEmpty(dvDesg[0]["deptname"].ToString()) == true ? "" : dvDesg[0]["deptname"].ToString();
                            if (string.IsNullOrEmpty(frmsrch.InfCodeFieldText.Trim()) == false)
                            {
                                int iRow = BsItemCategory.Find("Id", frmsrch.InfCodeFieldText.Trim());
                                BsItemCategory.Position = iRow;
                                dvDesg.RowFilter = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RdGrdClass_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            RdPageViewMain.SelectedPage = RdTbpEntry;
        }
    }
}
