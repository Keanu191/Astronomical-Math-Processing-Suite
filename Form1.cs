using MalinAstroAPP;
using MalinAstroAPP.Properties;
using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace MalinAstroAPP
{
    /// <summary>
    /// Main form for the MalinAstroAPP application.
    /// Provides a user interface for astronomical calculations using a WCF service.
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly DataGridView FromWCFDataGridView = new DataGridView();
        private readonly ResourceManager rm = new ResourceManager("MalinAstroApp.Form1", typeof(Form1).Assembly);

        private static readonly string address = "net.pipe://localhost/AstroServer";
        private static readonly NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
        private static readonly EndpointAddress ep = new EndpointAddress(address);
        private readonly IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Placeholder for any initialization logic.
        }

        private void btnEnglish_Click(object sender, EventArgs e) => LanguageManager.ChangeLanguage("English", this);
        private void btnFrench_Click(object sender, EventArgs e) => LanguageManager.ChangeLanguage("French", this);
        private void btnGerman_Click(object sender, EventArgs e) => LanguageManager.ChangeLanguage("German", this);

        private void btnConnect_Click(object sender, EventArgs e) =>
            ConnectionTester.IsConnected(channel, toolStripStatusLabel1, rm);

        private void btnTemperatureInKelvin_Click(object sender, EventArgs e) =>
            Calculator.CalculateTemperatureInKelvin(channel, inputTempInKelvin, dataGridView1, toolStripStatusLabel1, rm);

        private void btnCalculateStarDistance_Click(object sender, EventArgs e) =>
            Calculator.CalculateStarDistance(channel, inputStarDistance, dataGridView1, toolStripStatusLabel1, rm);

        private void btnCalculateStarVelocity_Click(object sender, EventArgs e) =>
            Calculator.CalculateStarVelocity(channel, txtBoxObserved, txtBoxRest, dataGridView1, toolStripStatusLabel1, rm);

        private void btnCalculateEventHorizon_Click(object sender, EventArgs e) =>
            Calculator.CalculateEventHorizon(channel, txtBoxEventHorizon, dataGridView1, toolStripStatusLabel1, rm);

        private void btnDarkMode_Click(object sender, EventArgs e) => UIManager.ApplyDarkMode(this);
        private void btnDefaultMode_Click(object sender, EventArgs e) => UIManager.ResetUI(this);
        private void btnDialog_Click(object sender, EventArgs e) => UIManager.OpenColorDialog(this);
        private void btnFont_Click(object sender, EventArgs e) => UIManager.OpenFontDialog(this);

        private void menuItemEnglish_Click(object sender, EventArgs e)
        {
            LanguageManager.ChangeLanguage("English", this);
        }

        private void menuItemFrench_Click(object sender, EventArgs e)
        {
            LanguageManager.ChangeLanguage("French", this);
        }

        private void menuItemGerman_Click(object sender, EventArgs e)
        {
            LanguageManager.ChangeLanguage("German", this);
        }

        private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIManager.OpenColorDialog(this);
        }

        private void chooseFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIManager.OpenFontDialog(this);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIManager.ApplyDarkMode(this);
        }

        private void defaultUIStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIManager.ResetUI(this);
        }
    }
}
