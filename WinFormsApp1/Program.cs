namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //GOST2018 mainForm = new GOST2018();
            //Application.Run(new GOST2008(mainForm));
            Application.Run(new GOST2018());
        }
    }
}