using WinFormsApp_Araba.model;
using WinFormsApp_Araba.Windows;

namespace WinFormsApp_Araba
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_anasayfa());
        }
    }
}