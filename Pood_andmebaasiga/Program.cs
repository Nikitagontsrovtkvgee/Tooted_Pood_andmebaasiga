using System;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Запускаем с ролью Admin, чтобы кнопки были активны
            Application.Run(new Tooded("Admin"));
        }
    }
}