using System.Runtime.InteropServices;



namespace Crossword
{
    
    internal static class Program
    {
        static extern IntPtr GetForegroundWindow();
        static extern IntPtr GetWindowText();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ENTRY POINT HERE

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuForm());

        }


        public static void startGame( )
        {
            GameForm crosswordForm = new GameForm();
            crosswordForm.Show();
        }
    }
}