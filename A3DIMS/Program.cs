using A3DIMS.Common.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3DIMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (ClsUtility._IClsUtility.CheckLicense() == false)
                {
                    A3DLicense.FrmLicense ObjLic = new A3DLicense.FrmLicense();
                    ObjLic.StartPosition = FormStartPosition.CenterScreen;
                    ObjLic.ShowDialog();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FrmA3DIMSMainMdi());
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
