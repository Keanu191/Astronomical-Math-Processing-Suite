using System;
using System.Resources;
using System.Windows.Forms;

namespace MalinAstroAPP
{
    /// <summary>
    /// Handles astronomical calculations.
    /// </summary>
    public static class Calculator
    {
        public static void CalculateTemperatureInKelvin(IAstroContract channel, TextBox input, DataGridView grid, ToolStripStatusLabel statusLabel, ResourceManager resourceManager)
        {
            if (double.TryParse(input.Text, out double celsiusInput))
            {
                try
                {
                    double kelvin = channel.tempConversion(celsiusInput);
                    grid.Rows.Add(kelvin);
                }
                catch (Exception ex)
                {
                    statusLabel.Text = $"{resourceManager.GetString("ErrorCatch")}: {ex.Message}";
                }
            }
            else
            {
                statusLabel.Text = resourceManager.GetString("InvalidInput");
            }
        }

        public static void CalculateStarDistance(IAstroContract channel, TextBox input, DataGridView grid, ToolStripStatusLabel statusLabel, ResourceManager resourceManager)
        {
            if (double.TryParse(input.Text, out double arcSecondsInput))
            {
                try
                {
                    double distance = channel.calculateStarDistance(arcSecondsInput);
                    grid.Rows.Add(distance);
                }
                catch (Exception ex)
                {
                    statusLabel.Text = $"{resourceManager.GetString("ErrorCatch")}: {ex.Message}";
                }
            }
            else
            {
                statusLabel.Text = resourceManager.GetString("InvalidInput");
            }
        }

        public static void CalculateStarVelocity(IAstroContract channel, TextBox observedInput, TextBox restInput, DataGridView grid, ToolStripStatusLabel statusLabel, ResourceManager resourceManager)
        {
            if (double.TryParse(observedInput.Text, out double observed) &&
                double.TryParse(restInput.Text, out double rest))
            {
                try
                {
                    double velocity = channel.measureVelocity(observed, rest);
                    grid.Rows.Add(velocity);
                }
                catch (Exception ex)
                {
                    statusLabel.Text = $"{resourceManager.GetString("ErrorCatch")}: {ex.Message}";
                }
            }
            else
            {
                statusLabel.Text = resourceManager.GetString("InvalidInput");
            }
        }

        public static void CalculateEventHorizon(IAstroContract channel, TextBox input, DataGridView grid, ToolStripStatusLabel statusLabel, ResourceManager resourceManager)
        {
            if (double.TryParse(input.Text, out double mass))
            {
                try
                {
                    double eventHorizon = channel.calculateEventHorizon(mass);
                    grid.Rows.Add(eventHorizon);
                }
                catch (Exception ex)
                {
                    statusLabel.Text = $"{resourceManager.GetString("ErrorCatch")}: {ex.Message}";
                }
            }
            else
            {
                statusLabel.Text = resourceManager.GetString("InvalidInput");
            }
        }
    }
}