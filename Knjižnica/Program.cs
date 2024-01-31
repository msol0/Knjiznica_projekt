using Knjižnica.Abstract.Models;
using Knjižnica.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjižnica
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    MainMenuForm userMenuForm = new MainMenuForm(loginForm.Korisnik);
                    if (loginForm.Korisnik.Pravo == Abstract.Enums.PravaEnums.Korisnik)
                    {
                        userMenuForm.SakrijGumb();
                        Application.Run(userMenuForm);
                    }
                    else {
                        userMenuForm.SakrijUsluge();
                        Application.Run(userMenuForm);
                    }
                }
            }
        }
    }
}
