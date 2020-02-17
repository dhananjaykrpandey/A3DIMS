using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3DIMS.Common.Classes
{
    interface IA3DFormSettings
    {
        void LoadData();
        void BindControls();
        void SetEnable(bool lValue);
        void SetFormMode(ClsUtility.enmFormMode _FormMode);
        void AddNew();
        void Edit();
        void Delete();
        void Save();
        void Undo();
        void Find();
        void Print();
        void Reload();
        void Export();
        void CloseForm();
        bool LValidateSave();
    }
}
