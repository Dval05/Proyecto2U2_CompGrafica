using System.Drawing;
using System.Windows.Forms;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    /// <summary>
    /// Gestiona los temas visuales de la aplicación (Claro/Oscuro)
    /// </summary>
    public class ThemeManager
    {
        // Colores del tema oscuro
        private static class DarkTheme
        {
            public static readonly Color Background = Color.FromArgb(30, 30, 35);
            public static readonly Color Surface = Color.FromArgb(40, 40, 48);
            public static readonly Color SurfaceLight = Color.FromArgb(50, 50, 60);
            public static readonly Color Primary = Color.FromArgb(100, 150, 255);
            public static readonly Color TextPrimary = Color.FromArgb(240, 240, 245);
            public static readonly Color TextSecondary = Color.FromArgb(180, 180, 190);
            public static readonly Color Border = Color.FromArgb(60, 60, 70);
            public static readonly Color Accent = Color.FromArgb(120, 180, 255);
        }

        // Colores del tema claro
        private static class LightTheme
        {
            public static readonly Color Background = Color.FromArgb(245, 245, 250);
            public static readonly Color Surface = Color.White;
            public static readonly Color SurfaceLight = Color.FromArgb(250, 250, 252);
            public static readonly Color Primary = Color.FromArgb(40, 80, 200);
            public static readonly Color TextPrimary = Color.FromArgb(30, 30, 35);
            public static readonly Color TextSecondary = Color.FromArgb(100, 100, 110);
            public static readonly Color Border = Color.FromArgb(220, 220, 225);
            public static readonly Color Accent = Color.FromArgb(60, 120, 255);
        }

        public void ApplyTheme(Form form, bool darkMode)
        {
            // Aplicar colores al formulario principal
            form.BackColor = darkMode ? DarkTheme.Background : LightTheme.Background;
            form.ForeColor = darkMode ? DarkTheme.TextPrimary : LightTheme.TextPrimary;

            // Aplicar recursivamente a todos los controles
            ApplyThemeToControls(form.Controls, darkMode);
        }

        private void ApplyThemeToControls(Control.ControlCollection controls, bool darkMode)
        {
            foreach (Control control in controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = darkMode ? DarkTheme.Surface : LightTheme.Surface;
                    panel.ForeColor = darkMode ? DarkTheme.TextPrimary : LightTheme.TextPrimary;
                }
                else if (control is GroupBox groupBox)
                {
                    groupBox.BackColor = darkMode ? DarkTheme.Surface : LightTheme.Surface;
                    groupBox.ForeColor = darkMode ? DarkTheme.Primary : LightTheme.Primary;
                }
                else if (control is Label label)
                {
                    label.ForeColor = darkMode ? DarkTheme.TextPrimary : LightTheme.TextPrimary;

                    // Labels secundarios (más pequeños)
                    if (label.Font.Size < 10)
                    {
                        label.ForeColor = darkMode ? DarkTheme.TextSecondary : LightTheme.TextSecondary;
                    }
                }
                else if (control is Button button)
                {
                    // No cambiar el color del botón de color
                    if (button.Name != "btnColor")
                    {
                        button.BackColor = darkMode ? DarkTheme.SurfaceLight : LightTheme.SurfaceLight;
                        button.ForeColor = darkMode ? DarkTheme.TextPrimary : LightTheme.TextPrimary;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderColor = darkMode ? DarkTheme.Border : LightTheme.Border;
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.BackColor = darkMode ? DarkTheme.SurfaceLight : LightTheme.Surface;
                    comboBox.ForeColor = darkMode ? DarkTheme.TextPrimary : LightTheme.TextPrimary;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.ForeColor = darkMode ? DarkTheme.TextPrimary : LightTheme.TextPrimary;
                }
                else if (control is TrackBar trackBar)
                {
                    trackBar.BackColor = darkMode ? DarkTheme.Surface : LightTheme.Surface;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = darkMode ? DarkTheme.SurfaceLight : LightTheme.Surface;
                    textBox.ForeColor = darkMode ? DarkTheme.TextPrimary : LightTheme.TextPrimary;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }

                // Aplicar recursivamente a controles hijos
                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls, darkMode);
                }
            }
        }

        public static Color GetBackgroundColor(bool darkMode)
        {
            return darkMode ? DarkTheme.Background : LightTheme.Background;
        }

        public static Color GetSurfaceColor(bool darkMode)
        {
            return darkMode ? DarkTheme.Surface : LightTheme.Surface;
        }

        public static Color GetTextColor(bool darkMode)
        {
            return darkMode ? DarkTheme.TextPrimary : LightTheme.TextPrimary;
        }

        public static Color GetAccentColor(bool darkMode)
        {
            return darkMode ? DarkTheme.Accent : LightTheme.Accent;
        }
    }
}