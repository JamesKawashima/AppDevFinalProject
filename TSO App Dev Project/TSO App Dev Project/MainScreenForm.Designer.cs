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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label currentStudiesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            System.Windows.Forms.Label allUsersLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeFormLabel = new System.Windows.Forms.Label();
            this.studiesFormLabel = new System.Windows.Forms.Label();
            this.miceFormLabel = new System.Windows.Forms.Label();
            this.logsFormLabel = new System.Windows.Forms.Label();
            this.accountFormLabel = new System.Windows.Forms.Label();
            this.settingsFormLabel = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.tSODBDataSet = new TSO_App_Dev_Project.TSODBDataSet();
            this.studiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studiesTableAdapter = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.StudiesTableAdapter();
            this.tableAdapterManager = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.TableAdapterManager();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsodbDataSet1 = new TSO_App_Dev_Project.TSODBDataSet();
            this.currentStudiesListBox = new System.Windows.Forms.ListBox();
            this.allUsersListBox = new System.Windows.Forms.ListBox();
            currentStudiesLabel = new System.Windows.Forms.Label();
            allUsersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsodbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // currentStudiesLabel
            // 
            resources.ApplyResources(currentStudiesLabel, "currentStudiesLabel");
            currentStudiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            currentStudiesLabel.Name = "currentStudiesLabel";
            // 
            // allUsersLabel
            // 
            resources.ApplyResources(allUsersLabel, "allUsersLabel");
            allUsersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            allUsersLabel.Name = "allUsersLabel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::TSO_App_Dev_Project.Properties.Resources.gradiantBar2;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // homeFormLabel
            // 
            resources.ApplyResources(this.homeFormLabel, "homeFormLabel");
            this.homeFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeFormLabel.Name = "homeFormLabel";
            this.homeFormLabel.Click += new System.EventHandler(this.homeFormLabel_Click);
            // 
            // studiesFormLabel
            // 
            resources.ApplyResources(this.studiesFormLabel, "studiesFormLabel");
            this.studiesFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.studiesFormLabel.Name = "studiesFormLabel";
            this.studiesFormLabel.Click += new System.EventHandler(this.studiesFormLabel_Click);
            // 
            // miceFormLabel
            // 
            resources.ApplyResources(this.miceFormLabel, "miceFormLabel");
            this.miceFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.miceFormLabel.Name = "miceFormLabel";
            this.miceFormLabel.Click += new System.EventHandler(this.miceFormLabel_Click);
            // 
            // logsFormLabel
            // 
            resources.ApplyResources(this.logsFormLabel, "logsFormLabel");
            this.logsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.logsFormLabel.Name = "logsFormLabel";
            this.logsFormLabel.Click += new System.EventHandler(this.logsFormLabel_Click);
            // 
            // accountFormLabel
            // 
            resources.ApplyResources(this.accountFormLabel, "accountFormLabel");
            this.accountFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountFormLabel.Name = "accountFormLabel";
            this.accountFormLabel.Click += new System.EventHandler(this.accountFormLabel_Click);
            // 
            // settingsFormLabel
            // 
            resources.ApplyResources(this.settingsFormLabel, "settingsFormLabel");
            this.settingsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsFormLabel.Name = "settingsFormLabel";
            this.settingsFormLabel.Click += new System.EventHandler(this.settingsFormLabel_Click);
            // 
            // monthCalendar
            // 
            resources.ApplyResources(this.monthCalendar, "monthCalendar");
            this.monthCalendar.Name = "monthCalendar";
            // 
            // tSODBDataSet
            // 
            this.tSODBDataSet.DataSetName = "TSODBDataSet";
            this.tSODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studiesBindingSource
            // 
            this.studiesBindingSource.DataMember = "Studies";
            this.studiesBindingSource.DataSource = this.tSODBDataSet;
            // 
            // studiesTableAdapter
            // 
            this.studiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MiceGroupsTableAdapter = null;
            this.tableAdapterManager.MiceTableAdapter = null;
            this.tableAdapterManager.StudiesTableAdapter = this.studiesTableAdapter;
            this.tableAdapterManager.TumorLogsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TSO_App_Dev_Project.TSODBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.welcomeLabel.Name = "welcomeLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tsodbDataSet1
            // 
            this.tsodbDataSet1.DataSetName = "TSODBDataSet";
            this.tsodbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currentStudiesListBox
            // 
            resources.ApplyResources(this.currentStudiesListBox, "currentStudiesListBox");
            this.currentStudiesListBox.FormattingEnabled = true;
            this.currentStudiesListBox.Name = "currentStudiesListBox";
            // 
            // allUsersListBox
            // 
            resources.ApplyResources(this.allUsersListBox, "allUsersListBox");
            this.allUsersListBox.FormattingEnabled = true;
            this.allUsersListBox.Name = "allUsersListBox";
            // 
            // MainScreenForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allUsersListBox);
            this.Controls.Add(allUsersLabel);
            this.Controls.Add(this.currentStudiesListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(currentStudiesLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.settingsFormLabel);
            this.Controls.Add(this.accountFormLabel);
            this.Controls.Add(this.logsFormLabel);
            this.Controls.Add(this.miceFormLabel);
            this.Controls.Add(this.studiesFormLabel);
            this.Controls.Add(this.homeFormLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreenForm";
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsodbDataSet1)).EndInit();
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
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private TSODBDataSet tSODBDataSet;
        private System.Windows.Forms.BindingSource studiesBindingSource;
        private TSODBDataSetTableAdapters.StudiesTableAdapter studiesTableAdapter;
        private TSODBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label2;
        private TSODBDataSet tsodbDataSet1;
        private System.Windows.Forms.ListBox currentStudiesListBox;
        private System.Windows.Forms.ListBox allUsersListBox;
    }
}