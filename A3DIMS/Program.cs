using A3DIMS.Common.Classes;
using A3DSQLServices;
using System;
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
                    InfSQLServices._IInfSQLServices.InfSQLConnectionString = GClsProjectProperties._IGClsProjectProperties.CProjectSqlConnection;
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
