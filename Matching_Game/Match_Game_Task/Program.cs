using System;
using System.Windows.Forms;

namespace Matching_Game_Task
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

            //Giving controls to Game logic:

            var presenter = new Presenter.Logic();
        }
    }
}
