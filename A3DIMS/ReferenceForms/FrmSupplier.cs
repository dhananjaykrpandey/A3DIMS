using A3DIMS.Common.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A3DIMS.ReferenceForms
{
    public partial class FrmSupplier : RadForm, IA3DFormSettings
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }

        public void AddNew()
        {

        }

        public void BindControls()
        {

        }

        public void CloseForm()
        {

        }

        public void Delete()
        {

        }

        public void Edit()
        {

        }

        public void Export()
        {

        }

        public void Find()
        {

        }

        public void LoadData()
        {

        }

        public bool LValidateSave()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {

        }

        public void Reload()
        {

        }

        public void Save()
        {

        }

        public void SetEnable(bool lValue)
        {

        }

        public void SetFormMode(ClsUtility.enmFormMode _FormMode)
        {

        }

        public void Undo()
        {

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string methodName = ClsButtonEvents._IClsButtonEvents.FormButtonsEvents(sender);
                MethodInfo mi = this.GetType().GetMethod(methodName);
                mi.Invoke(this, null);
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }
    }
}
