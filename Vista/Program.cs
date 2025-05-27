using System;

using System.Windows.Forms;
using Vista.Principal;

namespace Vista
{
    internal static class Program
    {
        public static string UserRolGlobal { get; set; }
        public static string CurrentUsername { get; set; } // <- Añade esta propiedad

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
            Application.Run(new Loading());
        }
    }
}
