using System.Diagnostics;

namespace RDLC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Debug.WriteLine("Se setean los valores de el data set");
        }
    }
}