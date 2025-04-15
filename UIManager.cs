using System.Drawing;
using System.Windows.Forms;

namespace MalinAstroAPP
{
    /// <summary>
    /// Handles UI appearance management.
    /// </summary>
    public static class UIManager
    {
        public static void ApplyDarkMode(Form form)
        {
            form.BackColor = Color.Black;
            foreach (Control control in form.Controls)
            {
                control.BackColor = Color.Black;
                control.ForeColor = Color.White;
            }
        }

        public static void ResetUI(Form form)
        {
            form.BackColor = Color.White;
            foreach (Control control in form.Controls)
            {
                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
            }
        }

        public static void OpenColorDialog(Form form)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    form.BackColor = colorDialog.Color;
                    foreach (Control control in form.Controls)
                    {
                        control.BackColor = colorDialog.Color;
                        control.ForeColor = Color.Black;
                    }
                }
            }
        }

        public static void OpenFontDialog(Form form)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control control in form.Controls)
                    {
                        control.Font = fontDialog.Font;
                    }
                }
            }
        }
    }
}