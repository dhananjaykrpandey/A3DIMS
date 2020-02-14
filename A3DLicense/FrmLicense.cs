using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A3DIMS
{
    public partial class FrmLicense : RadForm
    {
        ErrorProvider ObjErrorProvider = new ErrorProvider();
        public FrmLicense()
        {
            InitializeComponent();
            ObjErrorProvider.Icon = ArnikaTechnologies.Error;
            ObjErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

        }

        private void FrmLicense_Load(object sender, EventArgs e)
        {

        }

        private void RdBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool LValidate()
        {
            try
            {
                ObjErrorProvider.Clear();
                bool lValidate = true;
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

                return lValidate;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void RdBtnDownload_Click(object sender, EventArgs e)
        {
            try
            {

                if (LValidate() == false) { return; }
                string macAddresses = "";
                string StrLicense = "";
                foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                    {
                        macAddresses += nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }

                StrLicense = GenrateLicense(RdTxtName.Text.Trim(), RdTxtEmail.Text.Trim(), RdTxtContactNo1.Text.Trim(), RdTxtContactNo2.Text.Trim(), macAddresses.Trim());
                using (SaveFileDialog SvDlg = new SaveFileDialog())
                {
                    SvDlg.Filter = "Arnika License Request File(*.arlqc)|*.arlqc";
                    SvDlg.Title = "Arnika License Generator";
                    SvDlg.DefaultExt = "*.arlqc";
                    SvDlg.FileName = "A3DLicense.arlqc";
                    if (SvDlg.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(Path.Combine(Path.GetDirectoryName(SvDlg.FileName), "A3DLicense.arlqc"), StrLicense);
                    }
                }
                ClsLicenseMessage._IClsLicenseMessage.showMessage("License Request File Generated Successfully!!");


            }
            catch (Exception ex)
            {

                ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage(ex);
            }
        }

        private void RdTxtContactNo1_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

        }

        private void RdTxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(RdTxtEmail.Text.Trim()))
            {
                e.Cancel = !ClsLicenseMessage._IClsLicenseMessage.IsValidEmail(RdTxtEmail.Text.Trim());
            }
        }


        private string GenrateLicense(string StrName, string StrEmail, string StrContactNo, string StrContactNo2, string StrMacAddress, bool lTrailRequest = false)
        {
            try
            {
                string StrLicense = "";
                if (lTrailRequest == true)
                {
                    StrLicense = $"Licensed Name :{StrName}~Email ID :{StrEmail}~Contact No -1 :{StrContactNo}~Contact No -2 :{StrContactNo2}~System Address :{StrMacAddress}~Valid Till :{DateTime.Now.AddDays(30).ToString("yyyy-MMM-dd")}~Version :TRAIL";
                }
                else
                {
                    StrLicense = $"Licensed Name :{StrName}~Email ID :{StrEmail}~Contact No -1 :{StrContactNo}~Contact No -2 :{StrContactNo2}~System Address :{StrMacAddress}";
                }
                StrLicense = ClsCrypto._IClsCrypto.Encrypt(StrLicense);
                return StrLicense;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.F12)
            {
                FrmLicenseGenrator ObjfrmLicenseGenrator = new FrmLicenseGenrator();
                ObjfrmLicenseGenrator.StartPosition = FormStartPosition.CenterScreen;
                ObjfrmLicenseGenrator.ShowDialog();

            }
        }

        private void RdBtnTrail_Click(object sender, EventArgs e)
        {
            try
            {
                if (LValidate() == false) { return; }
                string macAddresses = "";
                string StrLicense = "";
                foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                    {
                        macAddresses += nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }
                StrLicense = GenrateLicense(RdTxtName.Text.Trim(), RdTxtEmail.Text.Trim(), RdTxtContactNo1.Text.Trim(), RdTxtContactNo2.Text.Trim(), macAddresses.Trim());

                File.WriteAllText(Path.Combine(Application.StartupPath, "A3DLicense.arlic"), StrLicense);

                File.WriteAllText(Path.Combine(Application.StartupPath, "micor.xdll"), StrLicense);
                File.SetCreationTime(Path.Combine(Application.StartupPath, "micor.xdll"), new DateTime(2020, 02, 29));

                ClsLicenseMessage._IClsLicenseMessage.showMessage("Trail License File Generated Successfully!!");

            }
            catch (Exception ex)
            {

                ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage(ex);
            }

        }

        private void RdBtnUploadLic_Click(object sender, EventArgs e)
        {
            try
            {
                if (LValidate() == false) { return; }
                using (OpenFileDialog OpnDlg = new OpenFileDialog())
                {
                    OpnDlg.Title = "Select License File";
                    OpnDlg.Filter = "Arnika License File(*.arlic)|*.arlic";
                    OpnDlg.FileName = "A3DLicense.arlic";
                    OpnDlg.RestoreDirectory = true;
                    if (OpnDlg.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(Path.Combine(Path.GetDirectoryName(OpnDlg.FileName), "A3DLicense.arlic")))
                        {
                            File.Copy(Path.Combine(Path.GetDirectoryName(OpnDlg.FileName), "A3DLicense.arlic"), Path.Combine(Application.StartupPath, "A3DLicense.arlic"), true);
                        }

                        else
                        {
                            ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("License File Not Found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage(ex);
            }
        }

    }

}

