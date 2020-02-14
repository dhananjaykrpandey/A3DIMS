using System;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using Telerik.WinControls.UI;
using System.Reflection;
using Telerik.WinControls.UI.Docking;
using A3DSQLServices;
using System.Data.SqlClient;

namespace A3DIMS.Common.Classes
{
    public class ClsUtility
    {
        private static ClsUtility _iClsUtility = null;
        public ClsUtility()

        {

        }
        public static ClsUtility _IClsUtility
        {
            get
            {
                if (_iClsUtility == null)
                {
                    _iClsUtility = new ClsUtility();
                }
                return _iClsUtility;
            }

        }
        public bool CheckLicense()
        {
            try
            {
                bool IsValidLicense = false;
                string StrLicensePath = "";
                string StrLicenseText = "";
                List<string> LstLicense = new List<string>();
                StrLicensePath = Path.Combine(Application.StartupPath, "A3DLicense.arlic");
                if (!File.Exists(StrLicensePath))
                {
                    GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                    return IsValidLicense;
                }
                else
                {
                    StrLicenseText = File.ReadAllText(StrLicensePath);
                    StrLicenseText = A3DLicense.ClsCrypto._IClsCrypto.Decrypt(StrLicenseText);
                    LstLicense = StrLicenseText.Trim().Split('~').ToList();
                    if (LstLicense.Count > 0 && (LstLicense[0] != null && string.IsNullOrEmpty(LstLicense[0]) == false && LstLicense[0].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CName = LstLicense[0].Trim().Replace("Licensed Name :", "");
                    }
                    if (LstLicense.Count > 1 && (LstLicense[1] != null && string.IsNullOrEmpty(LstLicense[1]) == false && LstLicense[1].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CEmail = LstLicense[1].Trim().Replace("Email ID :", "");
                    }
                    if (LstLicense.Count > 2 && (LstLicense[2] != null && string.IsNullOrEmpty(LstLicense[2]) == false && LstLicense[2].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CContactNo1 = LstLicense[2].Trim().Replace("Contact No -1 :", "");
                    }
                    if (LstLicense.Count > 3 && (LstLicense[3] != null && string.IsNullOrEmpty(LstLicense[3]) == false && LstLicense[3].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CContactNo2 = LstLicense[3].Trim().Replace("Contact No -2 :", "");
                    }
                    if (LstLicense.Count > 4 && (LstLicense[4] != null && string.IsNullOrEmpty(LstLicense[4]) == false && LstLicense[4].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CSystemAddress = LstLicense[4].Trim().Replace("System Address :", "");
                    }
                    if (LstLicense.Count > 5 && (LstLicense[5] != null && string.IsNullOrEmpty(LstLicense[5]) == false && LstLicense[5].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.dValidityDate = Convert.ToDateTime(LstLicense[5].Trim().Replace("Valid Till :", ""));
                    }
                    if (LstLicense.Count > 6 && (LstLicense[6] != null && string.IsNullOrEmpty(LstLicense[6]) == false && LstLicense[6].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.cVersion = LstLicense[6].Trim().Replace("Version :", "");
                    }
                    string macAddresses = string.Empty;

                    foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                    {
                        if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                        {
                            macAddresses += nic.GetPhysicalAddress().ToString();
                            break;
                        }
                    }
                    if (GClsProjectProperties._IGClsProjectProperties.CSystemAddress == null || string.IsNullOrEmpty(GClsProjectProperties._IGClsProjectProperties.CSystemAddress.Trim()))
                    {
                        GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                        return IsValidLicense;
                    }
                    if (GClsProjectProperties._IGClsProjectProperties.dValidityDate == null)
                    {
                        GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                        return IsValidLicense;
                    }


                    DateTime dSystemDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    DateTime dLicenseDate = new DateTime(GClsProjectProperties._IGClsProjectProperties.dValidityDate.Value.Year, GClsProjectProperties._IGClsProjectProperties.dValidityDate.Value.Month, GClsProjectProperties._IGClsProjectProperties.dValidityDate.Value.Day);
                    if (macAddresses != GClsProjectProperties._IGClsProjectProperties.CSystemAddress)
                    {
                        GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                        return IsValidLicense;
                    }
                    else if (dSystemDate > dLicenseDate)
                    {
                        GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                        return IsValidLicense;
                    }


                }
                IsValidLicense = true;
                return IsValidLicense;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool CheckLicensexDLL()
        {
            try
            {
                bool IsValidLicense = false;
                string StrLicensePath = "";
                string StrLicenseText = "";
                List<string> LstLicense = new List<string>();
                StrLicensePath = Path.Combine(Application.StartupPath, "micor.xdll");
                if (!File.Exists(StrLicensePath))
                {
                    GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                    return IsValidLicense;
                }
                else
                {
                    StrLicenseText = File.ReadAllText(StrLicensePath);
                    LstLicense = StrLicenseText.Trim().Split('~').ToList();
                    if (LstLicense.Count > 0 && (LstLicense[0] != null && string.IsNullOrEmpty(LstLicense[0]) == false && LstLicense[0].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CName = LstLicense[0].Trim().Replace("Licensed Name :", "");
                    }
                    if (LstLicense.Count > 1 && (LstLicense[1] != null && string.IsNullOrEmpty(LstLicense[1]) == false && LstLicense[1].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CEmail = LstLicense[1].Trim().Replace("Email ID :", "");
                    }
                    if (LstLicense.Count > 2 && (LstLicense[2] != null && string.IsNullOrEmpty(LstLicense[2]) == false && LstLicense[2].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CContactNo1 = LstLicense[2].Trim().Replace("Contact No -1 :", "");
                    }
                    if (LstLicense.Count > 3 && (LstLicense[3] != null && string.IsNullOrEmpty(LstLicense[3]) == false && LstLicense[3].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CContactNo2 = LstLicense[3].Trim().Replace("Contact No -2 :", "");
                    }
                    if (LstLicense.Count > 4 && (LstLicense[4] != null && string.IsNullOrEmpty(LstLicense[4]) == false && LstLicense[4].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.CSystemAddress = LstLicense[4].Trim().Replace("System Address :", "");
                    }
                    if (LstLicense.Count > 5 && (LstLicense[5] != null && string.IsNullOrEmpty(LstLicense[5]) == false && LstLicense[5].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.dValidityDate = Convert.ToDateTime(LstLicense[5].Trim().Replace("Valid Till :", ""));
                    }
                    if (LstLicense.Count > 6 && (LstLicense[6] != null && string.IsNullOrEmpty(LstLicense[6]) == false && LstLicense[6].Trim() != ""))
                    {
                        GClsProjectProperties._IGClsProjectProperties.cVersion = LstLicense[6].Trim().Replace("Version :", "");
                    }
                    string macAddresses = string.Empty;

                    foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
                    {
                        if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                        {
                            macAddresses += nic.GetPhysicalAddress().ToString();
                            break;
                        }
                    }
                    if (GClsProjectProperties._IGClsProjectProperties.CSystemAddress == null || string.IsNullOrEmpty(GClsProjectProperties._IGClsProjectProperties.CSystemAddress.Trim()))
                    {
                        GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                        return IsValidLicense;
                    }
                    if (GClsProjectProperties._IGClsProjectProperties.dValidityDate == null)
                    {
                        GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                        return IsValidLicense;
                    }


                    DateTime dSystemDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    DateTime dLicenseDate = new DateTime(GClsProjectProperties._IGClsProjectProperties.dValidityDate.Value.Year, GClsProjectProperties._IGClsProjectProperties.dValidityDate.Value.Month, GClsProjectProperties._IGClsProjectProperties.dValidityDate.Value.Day);
                    if (macAddresses != GClsProjectProperties._IGClsProjectProperties.CSystemAddress)
                    {
                        GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                        return IsValidLicense;
                    }
                    else if (dSystemDate > dLicenseDate)
                    {
                        GClsProjectProperties._IGClsProjectProperties.LIsValidLicense = false;
                        return IsValidLicense;
                    }


                }
                IsValidLicense = true;
                return IsValidLicense;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Form IsFormAlreadyOpen(Form frm)
        {
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType().Name == frm.Name)
                    return OpenForm;
            }

            return null;
        }

        public bool IsFormOpen(Type frm)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == frm.Name)
                    return true;
            return false;
        }
        public bool IsFormOpen(Type frm, RadDock _RadMDIDock, out HostWindow _HostWindow)
        {

            var vObjForm = _RadMDIDock.DocumentManager.DocumentArray;

            foreach (var item in vObjForm)
            {
                var vItem = (HostWindow)item;
                if (vItem.MdiChild.GetType().Name.ToUpper() == frm.Name.ToUpper())
                {
                    _HostWindow = vItem;
                    return true;
                }

            }
            _HostWindow = null;
            return false;

        }
        public void NumericKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

        }
        public void DecilmalKeyPress(string strValue, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (strValue.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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

                ClsMessage._IClsMessage.ProjectExceptionMessage("Invalid Email!");
                return false;
            }

        }
        public bool IsValidWebAddress(string s)
        {
            try
            {

                //bool result = Uri.TryCreate(s, UriKind.RelativeOrAbsolute, out uriResult)
                //    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                bool result = (Regex.IsMatch(s, @"(((([a-z]|\d|-|.||~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'()*+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]).(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]).(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]).(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|.||~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))).)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))).?)(:\d*)?)(/((([a-z]|\d|-|.||~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'()*+,;=]|:|@)+(/(([a-z]|\d|-|.||~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'()*+,;=]|:|@)))?)?(\?((([a-z]|\d|-|.||~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'()*+,;=]|:|@)|[\uE000-\uF8FF]|/|\?)*)?(#((([a-z]|\d|-|.||~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'()*+,;=]|:|@)|/|\?)*)?$"));
                if (result == false) { ClsMessage._IClsMessage.ProjectExceptionMessage("Invalid Web Address!"); return result; } else return result;
            }
            catch (Exception)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage("Invalid Web Address!");
                return false;
            }

        }
        public bool IsValidDate(string s)
        {
            DateTime output;
            return DateTime.TryParse(s, out output);

        }
        public double Val(string value)
        {
            String result = String.Empty;
            foreach (char c in value)
            {
                if (Char.IsNumber(c) || (c.Equals('.') && result.Count(x => x.Equals('.')) == 0))
                    result += c;
                else if (!c.Equals(' '))
                    return String.IsNullOrEmpty(result) ? 0 : Convert.ToDouble(result);
            }
            return String.IsNullOrEmpty(result) ? 0 : Convert.ToDouble(result);
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
        public enum _formMode
        {
            Add_EditMode,
            NoramlMode

        }

        public enum enmFormMode
        {
            AddMode, EditMode, NormalMode

        }
        private static enmFormMode _enmFormMode = ClsUtility.enmFormMode.NormalMode;
        public enmFormMode FormMode
        {
            get
            {
                return _enmFormMode;
            }
            set
            {
                _enmFormMode = value;
            }
        }
        public byte[] GetByteArray(String strFileName)
        {
            GC.Collect();
            byte[] imgbyte = null;
            if (File.Exists(strFileName))
            {
                string newfilelocation = Path.GetTempPath();
                newfilelocation = newfilelocation + Path.GetFileName(strFileName);
                File.Copy(strFileName, newfilelocation, true);

                using (var fs = new FileStream(newfilelocation, FileMode.Open))
                {
                    // initialise the binary reader from file streamobject
                    System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                    // define the byte array of filelength

                    imgbyte = new byte[fs.Length + 1];
                    // read the bytes from the binary reader

                    imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)));
                    // add the image in bytearray

                    br.Close();
                    // close the binary reader

                    fs.Close();
                    // close the file stream

                }

                File.Delete(newfilelocation);

            }
            return imgbyte;
        }
        public System.Drawing.Image GetImageFormFile(String strFileName)
        {
            GC.Collect();
            byte[] imgbyte = null;
            if (File.Exists(strFileName))
            {
                string newfilelocation = Path.GetTempPath();
                newfilelocation = newfilelocation + Path.GetFileName(strFileName);
                File.Copy(strFileName, newfilelocation, true);

                using (var fs = new FileStream(newfilelocation, FileMode.Open))
                {
                    // initialise the binary reader from file streamobject
                    System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                    // define the byte array of filelength

                    imgbyte = new byte[fs.Length + 1];
                    // read the bytes from the binary reader

                    imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)));
                    // add the image in bytearray

                    br.Close();
                    // close the binary reader

                    fs.Close();
                    // close the file stream

                }

                File.Delete(newfilelocation);

            }
            using (var ms = new MemoryStream(imgbyte))
            {
                return System.Drawing.Image.FromStream(ms);
            }

        }
        public void SearchText(DataTable infSearchDatatable, string strSearchKeyword, bool Searchcol = true, string columnName = "")
        {
            try
            {
                if (infSearchDatatable != null)
                {
                    infSearchDatatable.DefaultView.RowFilter = "";
                    bool UseContains = Searchcol;
                    int colCount = infSearchDatatable.Columns.Count;
                    System.Text.StringBuilder query = new System.Text.StringBuilder();
                    string filterString = "";


                    string likeStatement = (UseContains) ? "Like '%{0}%'" : " Like '{0}%'";

                    if (Searchcol == true && columnName == "")
                    {
                        for (int i = 0; i < colCount; i++)
                        {
                            string colName = infSearchDatatable.Columns[i].ColumnName;
                            query.Append(string.Concat("Convert(", colName, ", 'System.String')", likeStatement));


                            if (i != colCount - 1)
                                query.Append(" OR ");
                        }
                    }
                    else
                    {
                        query.Append(string.Concat("Convert(", columnName, ", 'System.String')", likeStatement));
                    }



                    filterString = query.ToString();
                    string currFilter = string.Format(filterString, strSearchKeyword.Trim());
                    DataRow[] tmpRows = infSearchDatatable.Select(currFilter);
                    infSearchDatatable.DefaultView.RowFilter = currFilter;
                }
                //MessageBox.Show("");
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }

        }
        public DataTable NewTable<T>(string name, IEnumerable<T> list)
        {
            PropertyInfo[] propInfo = typeof(T).GetProperties();
            DataTable table = Table<T>(name, list, propInfo);
            IEnumerator<T> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
                table.Rows.Add(CreateRow<T>(table.NewRow(), enumerator.Current, propInfo));
            return table;
        }
        public static DataRow CreateRow<T>(DataRow row, T listItem, PropertyInfo[] pi)
        {
            foreach (PropertyInfo p in pi)
                row[p.Name.ToString()] = p.GetValue(listItem, null);
            return row;
        }
        public DataTable Table<T>(string name, IEnumerable<T> list, PropertyInfo[] pi)
        {
            DataTable table = new DataTable(name);
            foreach (PropertyInfo p in pi)
                table.Columns.Add(p.Name, p.PropertyType);
            return table;
        }

        public bool LValidateTextBox(RadTextBox _RadTextBox, ErrorProvider errorProvider1, string StrMessage)
        {
            if (string.IsNullOrEmpty(_RadTextBox.Text.Trim()))
            {
                ClsMessage._IClsMessage.ProjectExceptionMessage(StrMessage);
                errorProvider1.SetError(_RadTextBox, StrMessage);
                _RadTextBox.Focus();
                return false;
            }
            return true;
        }
        public bool LValidateTextBox(RadTextBoxControl _RadTextBox, ErrorProvider errorProvider1, string StrMessage)
        {
            if (string.IsNullOrEmpty(_RadTextBox.Text.Trim()))
            {
                ClsMessage._IClsMessage.ProjectExceptionMessage(StrMessage);
                errorProvider1.SetError(_RadTextBox, StrMessage);
                _RadTextBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsCodeExists(string StrTableName, string StrCodeColumnName, string StrCodeValue, string StrMessage)
        {
            try
            {
                bool IsCodeExists = false;
                DataTable DtResult = new DataTable();
                DtResult = InfSQLServices._IInfSQLServices.InfExecuteDataTable("Select TOP 1 1 From " + StrTableName + " Where " + StrCodeColumnName + "='" + StrCodeValue + "'");
                if (DtResult.DefaultView.Count > 0)
                {
                    ClsMessage._IClsMessage.ProjectExceptionMessage(StrMessage);
                    IsCodeExists = true;
                }
                return IsCodeExists;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool IsCodeExists(string StrTableName, string StrCodeColumnName, string StrCodeValue, string StrMessage, SqlConnection SQLConn, SqlTransaction SQLTrans)
        {
            try
            {
                bool IsCodeExists = false;
                DataTable DtResult = new DataTable();
                DtResult = InfSQLServices._IInfSQLServices.InfExecuteDataTable("Select TOP 1 1 From " + StrTableName + " Where " + StrCodeColumnName + "='" + StrCodeValue + "'", SQLConn, SQLTrans);
                if (DtResult.DefaultView.Count > 0)
                {
                    ClsMessage._IClsMessage.ProjectExceptionMessage(StrMessage);
                    IsCodeExists = true;
                }
                return IsCodeExists;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
