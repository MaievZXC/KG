namespace KgLab1_1_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ColorSwaps form = new ColorSwaps();
            ColorSystemLogic brain = new ColorSystemLogic(form);
            Application.Run(form);
        }
    }
}