namespace ChapeauUI
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
            BillViewForm billViewForm = new BillViewForm();
            billViewForm.Size = new Size(414, 736);


            Application.Run(billViewForm);
        }
    }
}