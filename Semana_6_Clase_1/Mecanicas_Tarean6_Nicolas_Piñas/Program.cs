namespace Mecanicas_Tarean6_Nicolas_Piñas
{
    public static class Program
    {
        public static int idCliente = 0;
        public static DialogResult resultado_Dialog = DialogResult.None;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}