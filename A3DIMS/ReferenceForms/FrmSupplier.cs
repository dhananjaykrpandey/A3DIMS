using A3DIMS.Common.Classes;
using A3DIMS.Common.Forms;
using A3DSQLServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A3DIMS.ReferenceForms
{
    public partial class FrmSupplier : RadForm, IA3DFormSettings
    {
        BindingSource BsUnit = new BindingSource();
        ErrorProvider errorProvider1 = new ErrorProvider();
        DataTable DtUnit = new DataTable();
        public FrmSupplier()
        {
            InitializeComponent();
            BindControls();
        }
        public void LoadData()
        {
            DtUnit = InfSQLServices._IInfSQLServices.InfExecuteDataTable(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmUnitSelectQuery());
            BsUnit.DataSource = DtUnit.DefaultView;
            bindingNavigator1.BindingSource = BsUnit;
            RdGrdClass.DataSource = BsUnit;
        }

        public void BindControls()
        {
            try
            {

                LoadData();

                RdTxtSuppCode.DataBindings.Add("Text", BsUnit, "cUnitCode", false, DataSourceUpdateMode.OnPropertyChanged);
                RdTxtSuppName.DataBindings.Add(new Binding("Text", this.BsUnit, "cUnitDesc", true, DataSourceUpdateMode.OnPropertyChanged));
                RdTxtSuppRemarks.DataBindings.Add(new Binding("Text", this.BsUnit, "cUnitRemarks", true, DataSourceUpdateMode.OnPropertyChanged));
                RdChkSuppStatus.DataBindings.Add(new Binding("Checked", this.BsUnit, "lUnitStatus", true, DataSourceUpdateMode.OnPropertyChanged, false));
                //RdChkAcademicYearStatus.Checked

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ToolStripItem[] Ctrl = bindingNavigator1.Items.Find(ClsButtonEvents._IClsButtonEvents.ButtonName(keyData), true);
            if (Ctrl != null && Ctrl.Length > 0)
            {
                ToolStripButton toolStripButton = (ToolStripButton)Ctrl[0];
                toolStripButton.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string methodName = ClsButtonEvents._IClsButtonEvents.FormButtonsEvents(sender);
                MethodInfo mi = this.GetType().GetMethod(methodName);
                mi.Invoke(this, null);
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        public bool LValidateSave()
        {
            try
            {
                errorProvider1.Clear();
                bool _LValidateSave = true;
                if (!ClsUtility._IClsUtility.LValidateTextBox(RdTxtSuppCode, errorProvider1, "Unit Code Cannot Be Left Blank."))
                {
                    _LValidateSave = false;
                }
                else if (!ClsUtility._IClsUtility.LValidateTextBox(RdTxtSuppName, errorProvider1, "Unit Description Cannot Be Left Blank."))
                {

                    _LValidateSave = false;
                }
                else if (ClsUtility._IClsUtility.FormMode == ClsUtility.enmFormMode.AddMode && ClsUtility._IClsUtility.IsCodeExists("A3DIMS.dbo.MUnit", "cUnitCode", RdTxtSuppCode.Text.Trim(), "Unit Code Already Exists!!"))
                {
                    errorProvider1.SetError(RdTxtSuppCode, "Unit Code Already Exists!!");
                    RdTxtSuppCode.Focus();
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
        public void AddNew()
        {
            try
            {
                BsUnit.AllowNew = true;
                BsUnit.AddNew();
                BsUnit.MoveLast();
                CurrencyManager cm = (CurrencyManager)this.BindingContext[BsUnit];
                cm.Refresh();

                ClsUtility._IClsUtility.FormMode = ClsUtility.enmFormMode.AddMode;
                SetFormMode(ClsUtility.enmFormMode.AddMode);

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        public void Edit()
        {
            try
            {
                ClsUtility._IClsUtility.FormMode = ClsUtility.enmFormMode.EditMode;
                SetFormMode(ClsUtility.enmFormMode.EditMode);
                RdTxtSuppCode.Enabled = false;


            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        public void Delete()
        {
            try
            {
                if (ClsMessage._IClsMessage.showAskDeleteMessage() == DialogResult.No) { return; }
                int IRowIndex = 0;
                IRowIndex = BsUnit.Position;
                DtUnit.DefaultView[IRowIndex].Delete();
                InfSQLServices._IInfSQLServices.InfUpdateDataAdapter(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmUnitSelectQuery("1=2"), DtUnit);
                ClsMessage._IClsMessage.showDeleteMessage();
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        public void Save()
        {
            try
            {
                if (LValidateSave() == false) { return; }

                int IRowIndex = 0;
                IRowIndex = BsUnit.Position;
                DtUnit.DefaultView[IRowIndex].BeginEdit();
                DtUnit.DefaultView[IRowIndex]["cUpdatedBy"] = GClsProjectProperties._IGClsProjectProperties.CUserID;
                DtUnit.DefaultView[IRowIndex]["dUpdatedDate"] = DateTime.Now;
                DtUnit.DefaultView[IRowIndex]["lUnitStatus"] = RdChkSuppStatus.Checked;
                if (ClsUtility._IClsUtility.FormMode == ClsUtility.enmFormMode.AddMode)
                {
                    DtUnit.DefaultView[IRowIndex]["cCreatedBy"] = GClsProjectProperties._IGClsProjectProperties.CUserID;
                    DtUnit.DefaultView[IRowIndex]["dCreatedDate"] = DateTime.Now;

                }
                DtUnit.DefaultView[IRowIndex].EndEdit();
                BsUnit.EndEdit();
                InfSQLServices._IInfSQLServices.InfUpdateDataAdapter(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmUnitSelectQuery("1=2"), DtUnit);
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
        public void Undo()
        {
            try
            {
                BsUnit.CancelEdit();
                DtUnit.RejectChanges();
                ClsUtility._IClsUtility.FormMode = ClsUtility.enmFormMode.NormalMode;
                SetFormMode(ClsUtility.enmFormMode.NormalMode);
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        public void Find()
        {
            try
            {
                using (frmSearch frmsrch = new frmSearch())
                {
                    frmsrch.InfSqlSelectQuery = ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmUnitSelectQuery();
                    frmsrch.InfSqlWhereCondtion = "";
                    frmsrch.InfSqlOrderBy = "";
                    frmsrch.InfMultiSelect = false;
                    frmsrch.InfSearchFormName = "Search Unit Code ....";
                    frmsrch.InfCodeFieldName = "iId";
                    frmsrch.InfDescriptionFieldName = "cUnitCode";
                    frmsrch.InfGridFieldName = " iId ,cUnitCode ,cUnitDesc ,lUnitStatus";
                    frmsrch.InfGridFieldCaption = " iId, Unit Code ,Unit Description,Status";
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
                                int iRow = BsUnit.Find("iId", frmsrch.InfCodeFieldText.Trim());
                                BsUnit.Position = iRow;
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
        public void Print()
        {

        }
        public void Reload()
        {
            LoadData();
        }
        public void Export()
        {

        }
        public void CloseForm()
        {
            Close();
        }
        private void RdGrdClass_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            RdPageViewMain.SelectedPage = RdTbpEntry;
        }
        public void SetEnable(bool lValue)
        {
            RdTxtSuppCode.Enabled = lValue;
            RdTxtSuppName.Enabled = lValue;
            RdTxtSuppRemarks.Enabled = lValue;
            RdChkSuppStatus.Enabled = lValue;

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
        public void SetFormMode(ClsUtility.enmFormMode _FormMode)
        {
            switch (_FormMode)
            {
                case ClsUtility.enmFormMode.AddMode:
                    SetEnable(true);
                    RdTxtSuppCode.Focus();
                    break;
                case ClsUtility.enmFormMode.EditMode:
                    SetEnable(true);
                    RdTxtSuppCode.Enabled = false;
                    break;
                case ClsUtility.enmFormMode.NormalMode:
                    SetEnable(false);
                    break;
            }
        }
        private void FrmSupplier_Load(object sender, EventArgs e)
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

        private void RdTxtSuppPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled =!ClsUtility._IClsUtility.IsNumeric(e.KeyChar);
                                              
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void RdTxtSuppPhoneNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 43 && e.KeyChar != 45 && !ClsUtility._IClsUtility.IsNumeric(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void RdTxtSuppEmailID_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!ClsUtility._IClsUtility.IsValidEmail(RdTxtSuppEmailID.Text.Trim()))
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void RdTxtSuppWebSite_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!ClsUtility._IClsUtility.IsValidWebAddress(RdTxtSuppWebSite.Text.Trim()))
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
    }
}
