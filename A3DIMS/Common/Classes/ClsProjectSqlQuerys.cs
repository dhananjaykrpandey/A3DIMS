using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public string FrmAcademicCalanderSelectQuery(string StrWhereCondtion="")
        {
            string SelectQuery = "";
            SelectQuery= "SELECT IID, CAcademicYear, dAcademicYearStart, dAcademicYearEnd, lAcademincYearStatus, cCreatedBy, dCreatedDate, cUpdatedBy, dUpdatedDate FROM[A3DSchool].dbo.MAcademicYear";
            if (StrWhereCondtion!=null && StrWhereCondtion!="")
            {
                SelectQuery += " Where " + StrWhereCondtion;
            }
            SelectQuery += " Order By  CAcademicYear" ;
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
