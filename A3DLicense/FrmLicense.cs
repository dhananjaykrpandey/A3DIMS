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

namespace A3DLicense
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
                    ObjErrorProvider.SetError(RdTxtName, "Please Enter Name (Company Name/User Name)");
                    ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter Name (Company Name/User Name)");
                    RdTxtName.Focus();
                }
                else if (string.IsNullOrEmpty(RdTxtEmail.Text.Trim()))
                {
                    ObjErrorProvider.SetError(RdTxtEmail, "Please Enter Email-ID");
                    ClsLicenseMessage._IClsLicenseMessage.ProjectExceptionMessage("Please Enter Email-ID");
                    RdTxtEmail.Focus();
                }
                else if (string.IsNullOrEmpty(RdTxtContactNo1.Text.Trim()) && string.IsNullOrEmpty(RdTxtContactNo2.Text.Trim()))
                {
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
                foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                    {
                        macAddresses += nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }





            }
            catch (Exception)
            {

                throw;
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
               e.Cancel= !ClsLicenseMessage._IClsLicenseMessage.IsValidEmail(RdTxtEmail.Text.Trim());
            }
        }
    }
}
