using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace A3DIMS.Common.Classes
{
    class ClsButtonEvents
    {
        private static ClsButtonEvents _iClsButtonEvents = null;
        public ClsButtonEvents()

        {

        }
        public static ClsButtonEvents _IClsButtonEvents
        {
            get
            {
                if (_iClsButtonEvents == null)
                {
                    _iClsButtonEvents = new ClsButtonEvents();
                }
                return _iClsButtonEvents;
            }

        }

        public string FormButtonsEvents(Object Sender)
        {
            try
            {
                string EventName = "";
                ToolStripButton toolStripButton = (ToolStripButton)Sender;

                switch (toolStripButton.Name)
                {
                    case "BtnAddNew":
                        EventName = "AddNew";
                        break;
                    case "BtnEdit":
                        EventName = "Edit";
                        break;
                    case "BtnDelete":
                        EventName = "Delete";
                        break;
                    case "BtnSave":
                        EventName = "Save";
                        break;
                    case "BtnUndo":
                        EventName = "Undo";
                        break;
                    case "BtnFind":
                        EventName = "Find";
                        break;
                    case "BtnPrint":
                        EventName = "Print";
                        break;
                    case "BtnReload":
                        EventName = "Reload";
                        break;
                    case "BtnExport":
                        EventName = "Export";
                        break;
                    case "BtnClose":
                        EventName = "CloseForm";
                        break;
                    default:
                        EventName = "None";
                        break;

                }
                return EventName;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string ButtonName(Keys keyData)
        {
            try
            {
                string ButtonName = "None";
                switch (keyData)
                {
                    case (Keys.Control | Keys.N):
                        {
                            ButtonName = "BtnAddNew"; break;
                        }
                    case (Keys.Control | Keys.E):
                        {
                            ButtonName = "BtnEdit"; break;
                        }
                    case (Keys.Control | Keys.D):
                        {
                            ButtonName = "BtnDelete"; break;
                        }
                    case (Keys.Control | Keys.S):
                        {
                            ButtonName = "BtnSave"; break;
                        }
                    case (Keys.Control | Keys.U):
                        {
                            ButtonName = "BtnUndo"; break;
                        }
                    case (Keys.Control | Keys.F):
                        {
                            ButtonName = "BtnFind"; break;
                        }
                    case (Keys.Control | Keys.R):
                        {
                            ButtonName = "BtnReload"; break;
                        }
                    case (Keys.Control | Keys.P):
                        {
                            ButtonName = "BtnPrint"; break;
                        }
                }
                return ButtonName;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
