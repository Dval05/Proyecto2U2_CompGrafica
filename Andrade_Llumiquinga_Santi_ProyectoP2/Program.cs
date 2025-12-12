using System;
using System.Windows.Forms;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
        static class Program
        {
            /// <summary>
            /// Punto de entrada principal para la aplicación.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Aquí se instancia tu Formulario principal
                Application.Run(new Form1());
            }
        }
    }
