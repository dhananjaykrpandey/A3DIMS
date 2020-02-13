
using A3DIMS.Common.Classes;
using A3DIMSSQLServices;
using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls.UI;
namespace A3DIMS.Common.Forms
{
    public partial class frmSearch : RadForm
    {
        public frmSearch()
        {
            InitializeComponent();
        }


        public string InfSearchFormName { get; set; }
        private string _infCodeFieldName = "";
        public string InfCodeFieldName { get { return _infCodeFieldName; } set { _infCodeFieldName = value; } }
        public string InfDescriptionFieldName { get; set; }

        public string InfGridFieldName { get; set; }
        public string InfGridFieldCaption { get; set; }
        public string InfGridFieldSize { get; set; }

        public string InfSqlSelectQuery { get; set; }
        public string InfSqlWhereCondtion { get; set; }
        public string InfSqlOrderBy { get; set; }

        public string InfCodeFieldText { get; set; }
        public string InfDescriptionFieldText { get; set; }

        private bool _infMultiSelect = false;
        public bool InfMultiSelect { get { return _infMultiSelect; } set { _infMultiSelect = value; } }


        DataTable InfSearchDatatable = new DataTable();

        public DataView infSearchReturnDataView { get; set; }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            try
            {
                //pnlSelect.Visible = _infMultiSelect;
                grdSearch.MultiSelect = _infMultiSelect;
                lblSearch.Text = InfSearchFormName;
                this.Text = lblSearch.Text;
                LoadDataTable();
                BindGrid();

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }

        }
        private void LoadDataTable()
        {
            try
            {

                string SqlQuery = "";
                if (InfSqlSelectQuery != null && InfSqlSelectQuery.Trim() != "")
                {
                    SqlQuery = InfSqlSelectQuery;
                }
                if (InfSqlWhereCondtion != null && InfSqlWhereCondtion.Trim() != "")
                {
                    SqlQuery = SqlQuery.ToUpper().Replace("WHERE","") + " Where " + InfSqlWhereCondtion.Trim();
                }

                if (InfSqlOrderBy != null && InfSqlOrderBy.Trim() != "")
                {
                    SqlQuery = SqlQuery.ToUpper().Replace("ORDER BY", "") + " Order By " + InfSqlOrderBy.Trim();
                }



                InfSearchDatatable = InfSQLServices._IInfSQLServices.InfExecuteDataTable(SqlQuery);




                System.Data.DataColumn newColumn = new System.Data.DataColumn("lSelect", typeof(System.Boolean));
                newColumn.DefaultValue = false;
                InfSearchDatatable.Columns.Add(newColumn);


            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
            finally
            {

            }

        }

        private void BindGrid()
        {
            try
            {
                if (InfSearchDatatable != null && InfSearchDatatable.DefaultView.Count > 0)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = InfSearchDatatable.DefaultView;
                    //
                    grdSearch.AutoGenerateColumns = false;


                    string[] GridColCaption = InfGridFieldCaption.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    string[] GridColName = InfGridFieldName.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    string[] GridColSize = InfGridFieldSize.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                    GridViewCheckBoxColumn gcColChk = new GridViewCheckBoxColumn();
                    gcColChk.Name = "lSelect".Trim();
                    gcColChk.FieldName = "lSelect".Trim();
                    gcColChk.HeaderText = "[ ]";
                    gcColChk.Width = 30;
                    gcColChk.IsVisible = _infMultiSelect;
                    grdSearch.Columns.Add(gcColChk);


                    for (int i = 0; i <= GridColName.Length - 1; i++)
                    {
                        GridViewTextBoxColumn gcCol = new GridViewTextBoxColumn();
                        GridViewTextBoxColumn dataGridViewCell = new GridViewTextBoxColumn();
                        gcCol.Name = GridColName[i].Trim();
                        gcCol.HeaderText = GridColCaption[i].Trim();
                        gcCol.Width = Convert.ToInt32(GridColSize[i].Trim());
                        gcCol.FieldName = GridColName[i].Trim();
                        //gcCol.CellTemplate = dataGridViewCell;
                        gcCol.ReadOnly = true;
                        if (Convert.ToInt32(GridColSize[i].Trim()) == 0)
                        {
                            gcCol.IsVisible = false;
                        }
                        grdSearch.Columns.Add(gcCol);
                    }
                    grdSearch.DataSource = InfSearchDatatable.DefaultView;
                    // var lastColIndex = grdSearch.Columns.Count - 1;
                    // var lastCol = grdSearch.Columns[lastColIndex];
                    //// lastCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }


        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

            try
            {
                if (InfSearchDatatable != null && InfSearchDatatable.DefaultView.Count > 0)
                {
                    foreach (DataRowView drvRow in InfSearchDatatable.DefaultView)
                    {
                        drvRow.BeginEdit();
                        drvRow["lSelect"] = true;
                        drvRow.EndEdit();
                    }
                    InfSearchDatatable.AcceptChanges();
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (InfSearchDatatable != null && InfSearchDatatable.DefaultView.Count > 0)
                {
                    foreach (DataRowView drvRow in InfSearchDatatable.DefaultView)
                    {
                        drvRow.BeginEdit();
                        drvRow["lSelect"] = false;
                        drvRow.EndEdit();
                    }
                    InfSearchDatatable.AcceptChanges();
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
        private void SearchText(bool Searchcol = true, string columnName = "")
        {
            try
            {
                if (InfSearchDatatable != null)
                {
                    InfSearchDatatable.DefaultView.RowFilter = "";
                    bool UseContains = Searchcol;
                    int colCount = InfSearchDatatable.Columns.Count;
                    System.Text.StringBuilder query = new System.Text.StringBuilder();
                    string filterString = "";


                    string likeStatement = (UseContains) ? "Like '%{0}%'" : " Like '{0}%'";

                    if (Searchcol == true && columnName == "")
                    {
                        for (int i = 0; i < colCount; i++)
                        {
                            string colName = InfSearchDatatable.Columns[i].ColumnName;
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
                    string currFilter = string.Format(filterString, txtSearchKeyWord.Text.Trim());
                    DataRow[] tmpRows = InfSearchDatatable.Select(currFilter);
                    InfSearchDatatable.DefaultView.RowFilter = currFilter;
                }
                //MessageBox.Show("");
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            SearchText(true, "");

            //}
            //else
            //{
            //    SearchText(false, cmbColName.SelectedValue.ToString().Trim());
            //}
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (InfSearchDatatable != null && InfSearchDatatable.DefaultView.Count > 0)
                {
                    if (InfMultiSelect == false)
                    {
                        int iRow = 0;
                        iRow = grdSearch.SelectedRows[0].Index;
                        InfSearchDatatable.DefaultView[iRow].BeginEdit();
                        InfSearchDatatable.DefaultView[iRow]["lSelect"] = 1;
                        InfSearchDatatable.DefaultView[iRow].EndEdit();
                        InfCodeFieldText = InfSearchDatatable.DefaultView[iRow][InfCodeFieldName].ToString().Trim();
                        InfDescriptionFieldText = InfSearchDatatable.DefaultView[iRow][InfDescriptionFieldName].ToString().Trim();
                        InfSearchDatatable.AcceptChanges();
                        infSearchReturnDataView = InfSearchDatatable.DefaultView;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        infSearchReturnDataView = InfSearchDatatable.DefaultView;
                        this.DialogResult = DialogResult.OK;
                    }

                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void grdSearch_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (InfMultiSelect == false)
                {
                    int iRow = 0;
                    iRow = grdSearch.SelectedRows[0].Index;
                    InfSearchDatatable.DefaultView[iRow].BeginEdit();
                    InfSearchDatatable.DefaultView[iRow]["lSelect"] = 1;
                    InfSearchDatatable.DefaultView[iRow].EndEdit();

                    InfCodeFieldText = InfSearchDatatable.DefaultView[iRow][InfCodeFieldName].ToString().Trim();
                    InfDescriptionFieldText = InfSearchDatatable.DefaultView[iRow][InfDescriptionFieldName].ToString().Trim();
                    infSearchReturnDataView = InfSearchDatatable.DefaultView;
                    InfSearchDatatable.AcceptChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    //infSearchReturnDataView = InfSearchDatatable.DefaultView;
                    //this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void grdSearch_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                switch (e.Column.FieldName.ToString().ToUpper())
                {
                    case "LSELECT":
                        int iRow = 0;
                        iRow =e.RowIndex;
                        InfSearchDatatable.DefaultView[iRow].BeginEdit();
                        InfSearchDatatable.DefaultView[iRow]["lSelect"] =!Convert.ToBoolean(InfSearchDatatable.DefaultView[iRow]["lSelect"]);
                        InfSearchDatatable.DefaultView[iRow].EndEdit();
                        break;

                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
    }
}
