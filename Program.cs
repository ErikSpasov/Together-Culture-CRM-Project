using System;
using System.Windows.Forms;

namespace ProjectGui
{
    internal static class Program
    {
        /// <summary>
        /// 
        /// NAME: Erik Spasov
        /// SID: 2279588
        /// 
        /// Admin account is hard coded and comes with the app
        /// Admin details for login Email: Admin@gmail.com , password Admin123@
        /// 
        /// 
        /// 
        /// 
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());
        }
    }
}
