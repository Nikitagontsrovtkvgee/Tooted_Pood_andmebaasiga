using System;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Здесь была ошибка CS1729. Исправлено добавлением аргумента "Admin".
            // Это позволит тебе зайти в систему с полными правами при запуске.
            Application.Run(new Tooded("Admin"));
        }
    }
}