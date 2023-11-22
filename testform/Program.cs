namespace testform
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Initialize your FormController
            FormController formController = new FormController();

            // Run the FormController instead of FormMain
            formController.Run();
        }
    }
}
