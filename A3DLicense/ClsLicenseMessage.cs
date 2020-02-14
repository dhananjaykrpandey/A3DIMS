using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3DIMS
{
    class ClsLicenseMessage
    {
        private static ClsLicenseMessage _iClsLicenseMessage = null;
        public ClsLicenseMessage()

        {

        }
        public static ClsLicenseMessage _IClsLicenseMessage
        {
            get
            {
                if (_iClsLicenseMessage == null)
                {
                    _iClsLicenseMessage = new ClsLicenseMessage();
                }
                return _iClsLicenseMessage;
            }

        }

        readonly string ProjectName = "A3D License Management System";

        public void showMessage(string msg, MessageBoxIcon Icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(msg, ProjectName, MessageBoxButtons.OK, Icon);
        }
        public void ProjectExceptionMessage(string msg)
        {
            MessageBox.Show(msg, ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ProjectExceptionMessage(Exception msg)
        {
            string innerex = "";
            if (msg.InnerException != null)
            {
                innerex = msg.InnerException.ToString();
            }
            MessageBox.Show(msg + Environment.NewLine + innerex, ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult showQuestionMessage(string msg)
        {
            return MessageBox.Show(msg, ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void showSaveMessage()
        {
            MessageBox.Show("Record save successfully!", ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void showDeleteMessage()
        {
            MessageBox.Show("Record deleted successfully!", ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult showAskDeleteMessage()
        {
            return MessageBox.Show("Are you sure want to delete this record?", ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult showAskExitMessage()
        {
            return MessageBox.Show("Are you sure want to exit?", ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult showAskDiscardMessage()
        {
            return MessageBox.Show("Are you sure want to discard changes?", ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public bool IsValidEmail(string s)
        {
            try
            {
                var address = new MailAddress(s);
                return true;
            }
            catch (Exception)
            {

                ProjectExceptionMessage("Invalid Email-ID");
                return false;
            }

        }
        public bool IsNumeric(object Expression)
        {
            if (Expression == null || Expression is DateTime)
                return false;

            if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
                return true;

            try
            {
                if (Expression is string)
                    Double.Parse(Expression as string);
                else
                    Double.Parse(Expression.ToString());
                return true;
            }
            catch { return false; } // just dismiss errors but return false

        }
        public string IsoLated(string StrLic)
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            string StrLicCode = "";
            if (isoStore.FileExists("micor.xdll"))
            {
                Console.WriteLine("The file already exists!");
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("micor.xdll", FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        StrLicCode=(reader.ReadToEnd());
                    }
                }
            }
            else
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("micor.xdll", FileMode.CreateNew, isoStore))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                    {
                        writer.WriteLine(StrLic);
                        StrLicCode=("You have written to the file.");
                    }
                }
            }
            return StrLicCode;
        }
    }
}
