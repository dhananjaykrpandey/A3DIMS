namespace A3DIMS.Common.Classes
{
    class ClsProjectSqlQuerys
    {
        private static ClsProjectSqlQuerys _iClsProjectSqlQuerys = null;
        public ClsProjectSqlQuerys()

        {

        }
        public static ClsProjectSqlQuerys _IClsProjectSqlQuerys
        {
            get
            {
                if (_iClsProjectSqlQuerys == null)
                {
                    _iClsProjectSqlQuerys = new ClsProjectSqlQuerys();
                }
                return _iClsProjectSqlQuerys;
            }

        }
        public string FrmUnitSelectQuery(string StrWhereCondtion = "")
        {
            string SelectQuery = "";
            SelectQuery = "SELECT  iId ,cUnitCode ,cUnitDesc ,lUnitStatus ,cUnitRemarks ,cCreatedBy ,dCreatedDate ,cUpdatedBy ,dUpdatedDate FROM A3DIMS.dbo.MUnit";
            if (StrWhereCondtion != null && StrWhereCondtion != "")
            {
                SelectQuery += " Where " + StrWhereCondtion;
            }
            SelectQuery += " Order By  cUnitCode";
            return SelectQuery;

        }

        public string FrmItemCategorySelectQuery(string StrWhereCondtion="")
        {
            string SelectQuery = "";
            SelectQuery= "SELECT Id,cItemCategoryCode,cItemCategoryDesc,lItemCategoryStatus,cItemCategoryRemarks,cCreatedBy,dCreatedDate,cUpdatedBy,dUpdatedDate FROM A3DIMS.dbo.MItemCategory";
            if (StrWhereCondtion!=null && StrWhereCondtion!="")
            {
                SelectQuery += " Where " + StrWhereCondtion;
            }
            SelectQuery += " Order By  cItemCategoryCode";
            return SelectQuery;

        }
        public string FrmClassSelectQuery(string StrWhereCondtion = "")
        {
            string SelectQuery = "";
            SelectQuery = "SELECT iId, cClassCode, cClassDescription, cClassRemarks, lClassStatus, cCreatedBy, dCreatedDate, cUpdatedBy, dUpdatedDate FROM A3DSchool.dbo.MClass";
            if (StrWhereCondtion != null && StrWhereCondtion != "")
            {
                SelectQuery += " Where " + StrWhereCondtion;
            }
            SelectQuery += " Order By  cClassCode";
            return SelectQuery;

        }
        public string FrmSubjectsSelectQuery(string StrWhereCondtion = "")
        {
            string SelectQuery = "";
            SelectQuery = "SELECT iId, cSubjectCode, cSubjectDescription, cSubjectRemarks, lSubjectStatus, cCreatedBy, dCreatedDate, cUpdatedBy, dUpdatedDate FROM A3DSchool.dbo.MSubject";
            if (StrWhereCondtion != null && StrWhereCondtion != "")
            {
                SelectQuery += " Where " + StrWhereCondtion;
            }
            SelectQuery += " Order By  cSubjectCode";
            return SelectQuery;

        }
        public string FrmFeeTypeSelectQuery(string StrWhereCondtion = "")
        {
            string SelectQuery = "";
            SelectQuery = "SELECT iId, cFeeCode, cFeeDescription, cFeeRemarks, lFeeStatus, cCreatedBy, dCreatedDate, cUpdatedBy, dUpdatedDate FROM A3DSchool.dbo.MFeeType";
            if (StrWhereCondtion != null && StrWhereCondtion != "")
            {
                SelectQuery += " Where " + StrWhereCondtion;
            }
            SelectQuery += " Order By  cFeeCode";
            return SelectQuery;

        }
    }
}
