using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A3DLicense
{
    public partial class FrmLicenseGenrator : RadForm
    {
        ErrorProvider ObjErrorProvider = new ErrorProvider();
        public FrmLicenseGenrator()
        {
            InitializeComponent();
            ObjErrorProvider.Icon = ArnikaTechnologies.Error;
            ObjErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }

        private void FrmLicenseGenrator_Load(object sender, EventArgs e)
        {

        }
        private void RdBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RdBtnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog OpnDlg = new OpenFileDialog())
                {
                    OpnDlg.Title = "Select Request File";
                    OpnDlg.Filter = "Arnika License Request File(*.arlqc)|*.arlqc";
                    OpnDlg.RestoreDirectory = true;
                    if (OpnDlg.ShowDialog() == DialogResult.OK)
                    {
                        string StrLicense = "";
                        StrLicense = File.ReadAllText(OpnDlg.FileName);
                        StrLicense = ClsCrypto._IClsCrypto.Decrypt(StrLicense);
                        List<string> LstLic = new List<string>();
                        LstLic = StrLicense.Split('~').ToList();
                        RdTxtReadFileName.Text = LstLic[0].Trim().Replace("Licensed Name :", "");
                        RdTxtReadFileEmail.Text = LstLic[1].Trim().Replace("Email ID :", "");
                        RdTxtReadFileContactNo1.Text = LstLic[2].Trim().Replace("Contact No -1 :", "");
                        RdTxtReadFileContactNo2.Text = LstLic[3].Trim().Replace("Contact No -2 :", "");
                        RdTxtReadFileSystemAddress.Text = LstLic[4].Trim().Replace("System Address :", "");
                    }
                }
            }
            catch (Exception ex)
            {

                ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage(ex);
            }
        }
        private bool LValidate()
        {
            try
            {
                bool lValidate = true;
                ObjErrorProvider.Clear();
                switch (TabMain.SelectedPage.Name)
                {
                    case "RdTbpFirst":

                        if (string.IsNullOrEmpty(RdTxtName.Text.Trim()))
                        {
                            lValidate = false;
                            ObjErrorProvider.SetError(RdTxtName, "Please Enter Name (Company Name/User Name)");
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter Name (Company Name/User Name)");
                            RdTxtName.Focus();
                        }
                        else if (string.IsNullOrEmpty(RdTxtEmail.Text.Trim()))
                        {
                            lValidate = false;
                            ObjErrorProvider.SetError(RdTxtEmail, "Please Enter Email-ID");
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter Email-ID");
                            RdTxtEmail.Focus();
                        }
                        else if (string.IsNullOrEmpty(RdTxtContactNo1.Text.Trim()) && string.IsNullOrEmpty(RdTxtContactNo2.Text.Trim()))
                        {
                            lValidate = false;
                            ObjErrorProvider.SetError(RdTxtContactNo1, "Please Enter Contact No");
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter Contact No");
                            RdTxtContactNo1.Focus();
                        }
                        else if (string.IsNullOrEmpty(RdTxtSystemAddress.Text.Trim()))
                        {
                            lValidate = false;
                            ObjErrorProvider.SetError(RdTxtContactNo1, "Please Enter System Address");
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter System Address");
                            RdTxtSystemAddress.Focus();
                        }
                        break;

                    case "RdTbpSecond":

                        if (string.IsNullOrEmpty(RdTxtReadFileName.Text.Trim()))
                        {
                            lValidate = false;
                            ObjErrorProvider.SetError(RdTxtReadFileName, "Please Enter Name (Company Name/User Name)");
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter Name (Company Name/User Name)");
                            RdTxtReadFileName.Focus();
                        }
                        else if (string.IsNullOrEmpty(RdTxtReadFileEmail.Text.Trim()))
                        {
                            lValidate = false;
                            ObjErrorProvider.SetError(RdTxtReadFileEmail, "Please Enter Email-ID");
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter Email-ID");
                            RdTxtReadFileEmail.Focus();
                        }
                        else if (string.IsNullOrEmpty(RdTxtReadFileContactNo1.Text.Trim()) && string.IsNullOrEmpty(RdTxtReadFileContactNo2.Text.Trim()))
                        {
                            lValidate = false;
                            ObjErrorProvider.SetError(RdTxtReadFileContactNo1, "Please Enter Contact No");
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter Contact No");
                            RdTxtReadFileContactNo1.Focus();
                        }
                        else if (string.IsNullOrEmpty(RdTxtReadFileSystemAddress.Text.Trim()))
                        {
                            lValidate = false;
                            ObjErrorProvider.SetError(RdTxtReadFileSystemAddress, "Please Enter System Address");
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter System Address");
                            RdTxtReadFileSystemAddress.Focus();
                        }
                        break;
                }
                lValidate = true;
                return lValidate;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void RdBtnGenrateFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (LValidate() == false) { return; }
                string StrLicense = "";
                switch (TabMain.SelectedPage.Name)
                {
                    case "RdTbpFirst":
                        StrLicense = GenrateLicense(RdTxtName.Text.Trim(), RdTxtEmail.Text.Trim(), RdTxtContactNo1.Text.Trim(), RdTxtContactNo2.Text.Trim(), RdTxtSystemAddress.Text.Trim(), RdDtpValidTill.Value);
                        break;

                    case "RdTbpSecond":
                        StrLicense = GenrateLicense(RdTxtReadFileName.Text.Trim(), RdTxtReadFileEmail.Text.Trim(), RdTxtReadFileContactNo1.Text.Trim(), RdTxtReadFileContactNo2.Text.Trim(), RdTxtReadFileSystemAddress.Text.Trim(), RdDtpReadFileValidTill.Value);
                        break;
                }
                using (SaveFileDialog SvDlg = new SaveFileDialog())
                {
                    SvDlg.Filter = "Arnika License File(*.arlic)|*.arlic"; 
                    SvDlg.Title = "Arnika License Generator";
                    SvDlg.DefaultExt = "*.arlic";
                    SvDlg.FileName = "A3DLicense.arlic";
                    if (SvDlg.ShowDialog() == DialogResult.OK)
                    {
                        
                        File.WriteAllText(Path.Combine(Path.GetDirectoryName(SvDlg.FileName), "A3DLicense.arlic"), StrLicense);
                    }
                }
                ClsLicenseMessage._IClsLicenseMessage.showMessage("License File Generated Successfully!!");
            }
            catch (Exception ex)
            {

                ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage(ex);
            }
        }

        private string GenrateLicense(string StrName, string StrEmail, string StrContactNo, string StrContactNo2, string StrMacAddress, DateTime DValidTill)
        {
            try
            {
                string StrLicense = "";

                StrLicense = $"Licensed Name :{StrName}~Email ID :{StrEmail}~Contact No -1 :{StrContactNo}~Contact No -2 :{StrContactNo2}~System Address :{StrMacAddress}~Valid Till :{DValidTill.ToString("yyyy-MMM-dd")}~Version :FULL";
                StrLicense = ClsCrypto._IClsCrypto.Encrypt(StrLicense);
                return StrLicense;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
