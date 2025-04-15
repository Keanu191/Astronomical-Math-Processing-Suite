using System.Resources;
using System.Windows.Forms;

namespace MalinAstroAPP
{
    /// <summary>
    /// Handles connection testing with the WCF server.
    /// </summary>
    public static class ConnectionTester
    {
        /// <summary>
        /// Tests the connection to the WCF server.
        /// </summary>
        /// <param name="channel">The WCF channel to test.</param>
        /// <param name="statusLabel">The status label to update with the result.</param>
        /// <param name="resourceManager">The resource manager for localized strings.</param>
        /// <returns>True if the connection is successful; otherwise, false.</returns>
        public static bool IsConnected(IAstroContract channel, ToolStripStatusLabel statusLabel, ResourceManager resourceManager)
        {
            try
            {
                channel.tempConversion(1);
                statusLabel.Text = resourceManager.GetString("ConnectionSuccess");
                return true;
            }
            catch
            {
                statusLabel.Text = resourceManager.GetString("ErrorCatch");
                return false;
            }
        }
    }
}