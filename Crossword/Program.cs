using System.Runtime.InteropServices;



namespace Crossword
{
    
    internal static class Program
    {
        private static List<Form> activeForms = new List<Form>();
        static extern IntPtr GetForegroundWindow();
        static extern IntPtr GetWindowText();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            

            // setup app, creates menu form, and displays it
            ApplicationConfiguration.Initialize();

            MenuForm menu = new MenuForm();
            menu.Show();
            activeForms.Add(menu);

            Application.Run();
            

        }

        public static void startGame()
        {
            GameForm crosswordForm = new GameForm();

            activeForms.Add(crosswordForm);
            crosswordForm.Show();
        }

        public static void stopGame()
        {
            for (int i = 0; i < activeForms.Count; i++)
            {
                activeForms[i].Dispose();
                Application.Exit();
            }
        }
    }
}