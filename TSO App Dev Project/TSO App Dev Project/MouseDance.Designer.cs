namespace TSO_App_Dev_Project
{
    partial class MouseDance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseDance));
            this.dancingMouseGifPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dancingMouseGifPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dancingMouseGifPictureBox
            // 
            resources.ApplyResources(this.dancingMouseGifPictureBox, "dancingMouseGifPictureBox");
            this.dancingMouseGifPictureBox.Image = global::TSO_App_Dev_Project.Properties.Resources.dancingMouse;
            this.dancingMouseGifPictureBox.Name = "dancingMouseGifPictureBox";
            this.dancingMouseGifPictureBox.TabStop = false;
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // MouseDance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dancingMouseGifPictureBox);
            this.Name = "MouseDance";
            ((System.ComponentModel.ISupportInitialize)(this.dancingMouseGifPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dancingMouseGifPictureBox;
        private System.Windows.Forms.Button closeButton;
    }
}