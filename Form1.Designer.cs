namespace MalinAstroAPP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxObserved = new System.Windows.Forms.TextBox();
            this.inputStarDistance = new System.Windows.Forms.TextBox();
            this.txtBoxEventHorizon = new System.Windows.Forms.TextBox();
            this.inputTempInKelvin = new System.Windows.Forms.TextBox();
            this.label_TempInKelvin = new System.Windows.Forms.Label();
            this.label_StarVelocity = new System.Windows.Forms.Label();
            this.label_StarDistance = new System.Windows.Forms.Label();
            this.label_EventHorizon = new System.Windows.Forms.Label();
            this.btnCalculateStarVelocity = new System.Windows.Forms.Button();
            this.btnCalculateStarDistance = new System.Windows.Forms.Button();
            this.btnTemperatureInKelvin = new System.Windows.Forms.Button();
            this.btnCalculateEventHorizon = new System.Windows.Forms.Button();
            this.txtBoxRest = new System.Windows.Forms.TextBox();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnFrench = new System.Windows.Forms.Button();
            this.btnGerman = new System.Windows.Forms.Button();
            this.btnDialog = new System.Windows.Forms.Button();
            this.btnDefaultMode = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultUIStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxObserved
            // 
            resources.ApplyResources(this.txtBoxObserved, "txtBoxObserved");
            this.txtBoxObserved.Name = "txtBoxObserved";
            // 
            // inputStarDistance
            // 
            resources.ApplyResources(this.inputStarDistance, "inputStarDistance");
            this.inputStarDistance.Name = "inputStarDistance";
            // 
            // txtBoxEventHorizon
            // 
            resources.ApplyResources(this.txtBoxEventHorizon, "txtBoxEventHorizon");
            this.txtBoxEventHorizon.Name = "txtBoxEventHorizon";
            // 
            // inputTempInKelvin
            // 
            resources.ApplyResources(this.inputTempInKelvin, "inputTempInKelvin");
            this.inputTempInKelvin.Name = "inputTempInKelvin";
            // 
            // label_TempInKelvin
            // 
            resources.ApplyResources(this.label_TempInKelvin, "label_TempInKelvin");
            this.label_TempInKelvin.Name = "label_TempInKelvin";
            // 
            // label_StarVelocity
            // 
            resources.ApplyResources(this.label_StarVelocity, "label_StarVelocity");
            this.label_StarVelocity.Name = "label_StarVelocity";
            // 
            // label_StarDistance
            // 
            resources.ApplyResources(this.label_StarDistance, "label_StarDistance");
            this.label_StarDistance.Name = "label_StarDistance";
            // 
            // label_EventHorizon
            // 
            resources.ApplyResources(this.label_EventHorizon, "label_EventHorizon");
            this.label_EventHorizon.Name = "label_EventHorizon";
            // 
            // btnCalculateStarVelocity
            // 
            resources.ApplyResources(this.btnCalculateStarVelocity, "btnCalculateStarVelocity");
            this.btnCalculateStarVelocity.Name = "btnCalculateStarVelocity";
            this.btnCalculateStarVelocity.UseVisualStyleBackColor = true;
            this.btnCalculateStarVelocity.Click += new System.EventHandler(this.btnCalculateStarVelocity_Click);
            // 
            // btnCalculateStarDistance
            // 
            resources.ApplyResources(this.btnCalculateStarDistance, "btnCalculateStarDistance");
            this.btnCalculateStarDistance.Name = "btnCalculateStarDistance";
            this.btnCalculateStarDistance.UseVisualStyleBackColor = true;
            this.btnCalculateStarDistance.Click += new System.EventHandler(this.btnCalculateStarDistance_Click);
            // 
            // btnTemperatureInKelvin
            // 
            resources.ApplyResources(this.btnTemperatureInKelvin, "btnTemperatureInKelvin");
            this.btnTemperatureInKelvin.Name = "btnTemperatureInKelvin";
            this.btnTemperatureInKelvin.UseVisualStyleBackColor = true;
            this.btnTemperatureInKelvin.Click += new System.EventHandler(this.btnTemperatureInKelvin_Click);
            // 
            // btnCalculateEventHorizon
            // 
            resources.ApplyResources(this.btnCalculateEventHorizon, "btnCalculateEventHorizon");
            this.btnCalculateEventHorizon.Name = "btnCalculateEventHorizon";
            this.btnCalculateEventHorizon.UseVisualStyleBackColor = true;
            this.btnCalculateEventHorizon.Click += new System.EventHandler(this.btnCalculateEventHorizon_Click);
            // 
            // txtBoxRest
            // 
            resources.ApplyResources(this.txtBoxRest, "txtBoxRest");
            this.txtBoxRest.Name = "txtBoxRest";
            // 
            // btnEnglish
            // 
            resources.ApplyResources(this.btnEnglish, "btnEnglish");
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnFrench
            // 
            resources.ApplyResources(this.btnFrench, "btnFrench");
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.UseVisualStyleBackColor = true;
            this.btnFrench.Click += new System.EventHandler(this.btnFrench_Click);
            // 
            // btnGerman
            // 
            resources.ApplyResources(this.btnGerman, "btnGerman");
            this.btnGerman.Name = "btnGerman";
            this.btnGerman.UseVisualStyleBackColor = true;
            this.btnGerman.Click += new System.EventHandler(this.btnGerman_Click);
            // 
            // btnDialog
            // 
            resources.ApplyResources(this.btnDialog, "btnDialog");
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnDefaultMode
            // 
            resources.ApplyResources(this.btnDefaultMode, "btnDefaultMode");
            this.btnDefaultMode.Name = "btnDefaultMode";
            this.btnDefaultMode.UseVisualStyleBackColor = true;
            this.btnDefaultMode.Click += new System.EventHandler(this.btnDefaultMode_Click);
            // 
            // btnDarkMode
            // 
            resources.ApplyResources(this.btnDarkMode, "btnDarkMode");
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.UseVisualStyleBackColor = true;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menuItemEnglish
            // 
            this.menuItemEnglish.Image = global::MalinAstroAPP.Properties.Resources.Flag_of_US;
            this.menuItemEnglish.Name = "menuItemEnglish";
            resources.ApplyResources(this.menuItemEnglish, "menuItemEnglish");
            this.menuItemEnglish.Click += new System.EventHandler(this.menuItemEnglish_Click);
            // 
            // menuItemFrench
            // 
            this.menuItemFrench.Image = global::MalinAstroAPP.Properties.Resources.Flag_of_France;
            this.menuItemFrench.Name = "menuItemFrench";
            resources.ApplyResources(this.menuItemFrench, "menuItemFrench");
            this.menuItemFrench.Click += new System.EventHandler(this.menuItemFrench_Click);
            // 
            // menuItemGerman
            // 
            this.menuItemGerman.Image = global::MalinAstroAPP.Properties.Resources.Flag_of_Germany;
            this.menuItemGerman.Name = "menuItemGerman";
            resources.ApplyResources(this.menuItemGerman, "menuItemGerman");
            this.menuItemGerman.Click += new System.EventHandler(this.menuItemGerman_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEnglish,
            this.menuItemFrench,
            this.menuItemGerman,
            this.darkModeToolStripMenuItem,
            this.defaultUIStyleToolStripMenuItem,
            this.chooseColorToolStripMenuItem,
            this.chooseFontToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            resources.ApplyResources(this.darkModeToolStripMenuItem, "darkModeToolStripMenuItem");
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // defaultUIStyleToolStripMenuItem
            // 
            this.defaultUIStyleToolStripMenuItem.Name = "defaultUIStyleToolStripMenuItem";
            resources.ApplyResources(this.defaultUIStyleToolStripMenuItem, "defaultUIStyleToolStripMenuItem");
            this.defaultUIStyleToolStripMenuItem.Click += new System.EventHandler(this.defaultUIStyleToolStripMenuItem_Click);
            // 
            // chooseColorToolStripMenuItem
            // 
            this.chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
            resources.ApplyResources(this.chooseColorToolStripMenuItem, "chooseColorToolStripMenuItem");
            this.chooseColorToolStripMenuItem.Click += new System.EventHandler(this.chooseColorToolStripMenuItem_Click);
            // 
            // chooseFontToolStripMenuItem
            // 
            this.chooseFontToolStripMenuItem.Name = "chooseFontToolStripMenuItem";
            resources.ApplyResources(this.chooseFontToolStripMenuItem, "chooseFontToolStripMenuItem");
            this.chooseFontToolStripMenuItem.Click += new System.EventHandler(this.chooseFontToolStripMenuItem_Click);
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnFont
            // 
            resources.ApplyResources(this.btnFont, "btnFont");
            this.btnFont.Name = "btnFont";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.btnDefaultMode);
            this.Controls.Add(this.btnDialog);
            this.Controls.Add(this.btnGerman);
            this.Controls.Add(this.btnFrench);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.txtBoxRest);
            this.Controls.Add(this.btnCalculateEventHorizon);
            this.Controls.Add(this.btnTemperatureInKelvin);
            this.Controls.Add(this.btnCalculateStarDistance);
            this.Controls.Add(this.btnCalculateStarVelocity);
            this.Controls.Add(this.label_EventHorizon);
            this.Controls.Add(this.label_StarDistance);
            this.Controls.Add(this.label_StarVelocity);
            this.Controls.Add(this.label_TempInKelvin);
            this.Controls.Add(this.inputTempInKelvin);
            this.Controls.Add(this.txtBoxEventHorizon);
            this.Controls.Add(this.inputStarDistance);
            this.Controls.Add(this.txtBoxObserved);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxObserved;
        private System.Windows.Forms.TextBox inputStarDistance;
        private System.Windows.Forms.TextBox txtBoxEventHorizon;
        private System.Windows.Forms.TextBox inputTempInKelvin;
        private System.Windows.Forms.Label label_TempInKelvin;
        private System.Windows.Forms.Label label_StarVelocity;
        private System.Windows.Forms.Label label_StarDistance;
        private System.Windows.Forms.Label label_EventHorizon;
        private System.Windows.Forms.Button btnCalculateStarVelocity;
        private System.Windows.Forms.Button btnCalculateStarDistance;
        private System.Windows.Forms.Button btnTemperatureInKelvin;
        private System.Windows.Forms.Button btnCalculateEventHorizon;
        private System.Windows.Forms.TextBox txtBoxRest;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnFrench;
        private System.Windows.Forms.Button btnGerman;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.Button btnDefaultMode;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemEnglish;
        private System.Windows.Forms.ToolStripMenuItem menuItemFrench;
        private System.Windows.Forms.ToolStripMenuItem menuItemGerman;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultUIStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFontToolStripMenuItem;
        private System.Windows.Forms.Button btnFont;
    }
}

