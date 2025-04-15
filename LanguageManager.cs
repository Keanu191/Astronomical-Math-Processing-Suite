using MalinAstroAPP.Properties;
using System;
using System.Globalization;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace MalinAstroAPP
{
    /// <summary>
    /// Handles language management for the application.
    /// </summary>
    public static class LanguageManager
    {
        /// <summary>
        /// Changes the application language and updates the UI.
        /// </summary>
        /// <param name="language">The language to switch to (e.g., "English", "French", "German").</param>
        /// <param name="form">The form to update after changing the language.</param>
        public static void ChangeLanguage(string language, Form form)
        {
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
                    break;
                default:
                    throw new ArgumentException("Unsupported language", nameof(language));
            }

            foreach (Control control in form.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
                resources.ApplyResources(control, control.Name);
            }
        }
    }
}