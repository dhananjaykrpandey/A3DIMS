using System.Collections.Generic;
using System.Data;
using Telerik.WinControls.UI;

namespace A3DIMS.Common.Classes
{
    public class GClsProjectProperties
    {
        private static GClsProjectProperties _iGClsProjectProperties = null;
        public GClsProjectProperties()

        {

        }
        public static GClsProjectProperties _IGClsProjectProperties
        {
            get
            {
                if (_iGClsProjectProperties == null)
                {
                    _iGClsProjectProperties = new GClsProjectProperties();
                }
                return _iGClsProjectProperties;
            }

        }

        public string CdbSeverName { get; set; }
        public string CdbName { get; set; }
        public string CdbUserName { get; set; }
        public string CdbUserPassword { get; set; }
        public string StrSQLConnection { get; set; } = default;
        public List<RadTreeNode> LstSelectedTreeNode { get; set; }
        public string CProjectFileName { get; set; }
        public string StrFolderLocation { get; set; }
        public DataSet MdsCreateDataView { get; internal set; }
        public string CUserID { get; set; } = "Admin";
        public string CUserName { get; set; } = "Administrator";
        public string CUserType { get; set; } = "Administrator";
        public bool CUserStatus { get; set; } = true;
    }
}
