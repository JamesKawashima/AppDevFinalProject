namespace TSO_App_Dev_Project
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.logoutButton = new System.Windows.Forms.Button();
            this.createUserButton = new System.Windows.Forms.Button();
            this.aboutUsButton = new System.Windows.Forms.Button();
            this.mouseDanceButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // createUserButton
            // 
            resources.ApplyResources(this.createUserButton, "createUserButton");
            this.createUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // aboutUsButton
            // 
            resources.ApplyResources(this.aboutUsButton, "aboutUsButton");
            this.aboutUsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.UseVisualStyleBackColor = false;
            this.aboutUsButton.Click += new System.EventHandler(this.aboutUsButton_Click);
            // 
            // mouseDanceButton
            // 
            resources.ApplyResources(this.mouseDanceButton, "mouseDanceButton");
            this.mouseDanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.mouseDanceButton.Name = "mouseDanceButton";
            this.mouseDanceButton.UseVisualStyleBackColor = false;
            this.mouseDanceButton.Click += new System.EventHandler(this.mouseDanceButton_Click);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.mouseDanceButton);
            this.Controls.Add(this.aboutUsButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button aboutUsButton;
        private System.Windows.Forms.Button mouseDanceButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}