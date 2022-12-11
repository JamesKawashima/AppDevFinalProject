namespace TSO_App_Dev_Project
{
    partial class MainScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeFormLabel = new System.Windows.Forms.Label();
            this.studiesFormLabel = new System.Windows.Forms.Label();
            this.miceFormLabel = new System.Windows.Forms.Label();
            this.logsFormLabel = new System.Windows.Forms.Label();
            this.accountFormLabel = new System.Windows.Forms.Label();
            this.settingsFormLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TSO_App_Dev_Project.Properties.Resources.gradiantBar2;
            this.pictureBox1.Location = new System.Drawing.Point(-142, -76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1267, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeFormLabel
            // 
            this.homeFormLabel.AutoSize = true;
            this.homeFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeFormLabel.Location = new System.Drawing.Point(150, 12);
            this.homeFormLabel.Name = "homeFormLabel";
            this.homeFormLabel.Size = new System.Drawing.Size(96, 36);
            this.homeFormLabel.TabIndex = 1;
            this.homeFormLabel.Text = "Home";
            this.homeFormLabel.Click += new System.EventHandler(this.homeFormLabel_Click);
            // 
            // studiesFormLabel
            // 
            this.studiesFormLabel.AutoSize = true;
            this.studiesFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.studiesFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studiesFormLabel.Location = new System.Drawing.Point(260, 12);
            this.studiesFormLabel.Name = "studiesFormLabel";
            this.studiesFormLabel.Size = new System.Drawing.Size(113, 36);
            this.studiesFormLabel.TabIndex = 2;
            this.studiesFormLabel.Text = "Studies";
            this.studiesFormLabel.Click += new System.EventHandler(this.studiesFormLabel_Click);
            // 
            // miceFormLabel
            // 
            this.miceFormLabel.AutoSize = true;
            this.miceFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.miceFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miceFormLabel.Location = new System.Drawing.Point(387, 12);
            this.miceFormLabel.Name = "miceFormLabel";
            this.miceFormLabel.Size = new System.Drawing.Size(78, 36);
            this.miceFormLabel.TabIndex = 3;
            this.miceFormLabel.Text = "Mice";
            this.miceFormLabel.Click += new System.EventHandler(this.miceFormLabel_Click);
            // 
            // logsFormLabel
            // 
            this.logsFormLabel.AutoSize = true;
            this.logsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.logsFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsFormLabel.Location = new System.Drawing.Point(479, 12);
            this.logsFormLabel.Name = "logsFormLabel";
            this.logsFormLabel.Size = new System.Drawing.Size(78, 36);
            this.logsFormLabel.TabIndex = 4;
            this.logsFormLabel.Text = "Logs";
            this.logsFormLabel.Click += new System.EventHandler(this.logsFormLabel_Click);
            // 
            // accountFormLabel
            // 
            this.accountFormLabel.AutoSize = true;
            this.accountFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountFormLabel.Location = new System.Drawing.Point(571, 12);
            this.accountFormLabel.Name = "accountFormLabel";
            this.accountFormLabel.Size = new System.Drawing.Size(124, 36);
            this.accountFormLabel.TabIndex = 5;
            this.accountFormLabel.Text = "Account";
            this.accountFormLabel.Click += new System.EventHandler(this.accountFormLabel_Click);
            // 
            // settingsFormLabel
            // 
            this.settingsFormLabel.AutoSize = true;
            this.settingsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsFormLabel.Location = new System.Drawing.Point(709, 12);
            this.settingsFormLabel.Name = "settingsFormLabel";
            this.settingsFormLabel.Size = new System.Drawing.Size(123, 36);
            this.settingsFormLabel.TabIndex = 6;
            this.settingsFormLabel.Text = "Settings";
            this.settingsFormLabel.Click += new System.EventHandler(this.settingsFormLabel_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.settingsFormLabel);
            this.Controls.Add(this.accountFormLabel);
            this.Controls.Add(this.logsFormLabel);
            this.Controls.Add(this.miceFormLabel);
            this.Controls.Add(this.studiesFormLabel);
            this.Controls.Add(this.homeFormLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSO - Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label homeFormLabel;
        private System.Windows.Forms.Label studiesFormLabel;
        private System.Windows.Forms.Label miceFormLabel;
        private System.Windows.Forms.Label logsFormLabel;
        private System.Windows.Forms.Label accountFormLabel;
        private System.Windows.Forms.Label settingsFormLabel;
    }
}