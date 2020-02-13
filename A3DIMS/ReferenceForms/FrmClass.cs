using A3DIMS.Common.Classes;
using A3DIMS.Common.Forms;
using A3DSQLServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A3DIMS.Masters
{
    public partial class FrmClass : RadForm
    {
        BindingSource BsClass = new BindingSource();
        ErrorProvider errorProvider1 = new ErrorProvider();
        DataTable DtClass = new DataTable();
        public FrmClass()
        {
            InitializeComponent();
            BindControls();
        }
        private void LoadData()
        {
            DtClass = InfSQLServices._IInfSQLServices.InfExecuteDataTable(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmClassSelectQuery());
            BsClass.DataSource = DtClass.DefaultView;
            bindingNavigator1.BindingSource = BsClass;
            RdGrdClass.DataSource = BsClass;
        }
        private void BindControls()
        {
            try
            {

                LoadData();

                RdTxtClassCode.DataBindings.Add("Text", BsClass, "cClassCode", false, DataSourceUpdateMode.OnPropertyChanged);
                RdTxtClassDescription.DataBindings.Add(new Binding("Text", this.BsClass, "cClassDescription", true, DataSourceUpdateMode.OnPropertyChanged));
                RdTxtClassRemarks.DataBindings.Add(new Binding("Text", this.BsClass, "cClassRemarks", true, DataSourceUpdateMode.OnPropertyChanged));
                RdChkClassStatus.DataBindings.Add(new Binding("Checked", this.BsClass, "lClassStatus", true, DataSourceUpdateMode.OnPropertyChanged, false));
                //RdChkAcademicYearStatus.Checked

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        private void SetEnable(bool lValue)
        {
            RdTxtClassCode.Enabled = lValue;
            RdTxtClassDescription.Enabled = lValue;
            RdTxtClassRemarks.Enabled = lValue;
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
                    RdTxtClassCode.Focus();
                    break;
                case ClsUtility.enmFormMode.EditMode:
                    SetEnable(true);
                    RdTxtClassCode.Enabled = false;
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
        private void FrmClass_Load(object sender, EventArgs e)
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
                if (!ClsUtility._IClsUtility.LValidateTextBox(RdTxtClassCode, errorProvider1, "Class Code Cannot Be Left Blank."))
                {
                    _LValidateSave = false;
                }
                else if (!ClsUtility._IClsUtility.LValidateTextBox(RdTxtClassDescription, errorProvider1, "Class Description Cannot Be Left Blank."))
                {
                    
                    _LValidateSave = false;
                }
                else if (ClsUtility._IClsUtility.IsCodeExists("A3DSchool.dbo.MClass", "cClassCode",RdTxtClassCode.Text.Trim(), "Class Code Already Exists!!"))
                {
                    errorProvider1.SetError(RdTxtClassCode, "Class Code Already Exists!!");
                    RdTxtClassCode.Focus();
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
                BsClass.AllowNew = true;
                BsClass.AddNew();
                BsClass.MoveLast();
                CurrencyManager cm = (CurrencyManager)this.BindingContext[BsClass];
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
                RdTxtClassCode.Enabled = false;


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
                IRowIndex = BsClass.Position;
                DtClass.DefaultView[IRowIndex].Delete();
                InfSQLServices._IInfSQLServices.InfUpdateDataAdapter(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmClassSelectQuery("1=2"), DtClass);
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
                IRowIndex = BsClass.Position;
                DtClass.DefaultView[IRowIndex].BeginEdit();
                DtClass.DefaultView[IRowIndex]["cUpdatedBy"] = GClsProjectProperties._IGClsProjectProperties.CUserID;
                DtClass.DefaultView[IRowIndex]["dUpdatedDate"] = DateTime.Now;
                DtClass.DefaultView[IRowIndex]["lClassStatus"] = RdChkClassStatus.Checked;
                if (ClsUtility._IClsUtility.FormMode == ClsUtility.enmFormMode.AddMode)
                {
                    DtClass.DefaultView[IRowIndex]["cCreatedBy"] = GClsProjectProperties._IGClsProjectProperties.CUserID;
                    DtClass.DefaultView[IRowIndex]["dCreatedDate"] = DateTime.Now;

                }
                DtClass.DefaultView[IRowIndex].EndEdit();
                BsClass.EndEdit();
                InfSQLServices._IInfSQLServices.InfUpdateDataAdapter(ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmClassSelectQuery("1=2"), DtClass);
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
                BsClass.CancelEdit();
                DtClass.RejectChanges();
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
                    frmsrch.InfSqlSelectQuery = ClsProjectSqlQuerys._IClsProjectSqlQuerys.FrmClassSelectQuery();
                    frmsrch.InfSqlWhereCondtion = "";
                    frmsrch.InfSqlOrderBy = "";
                    frmsrch.InfMultiSelect = false;
                    frmsrch.InfSearchFormName = "Search Class Code ....";
                    frmsrch.InfCodeFieldName = "iId";
                    frmsrch.InfDescriptionFieldName = "cClassCode";
                    frmsrch.InfGridFieldName = "iId, cClassCode, cClassDescription, lClassStatus";
                    frmsrch.InfGridFieldCaption = " iId, Class Code ,Class Description,Status";
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
                                int iRow = BsClass.Find("iId", frmsrch.InfCodeFieldText.Trim());
                                BsClass.Position = iRow;
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

        private void RdTbpEntry_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
