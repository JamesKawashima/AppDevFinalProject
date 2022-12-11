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
            System.Windows.Forms.Label studyIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeFormLabel = new System.Windows.Forms.Label();
            this.studiesFormLabel = new System.Windows.Forms.Label();
            this.miceFormLabel = new System.Windows.Forms.Label();
            this.logsFormLabel = new System.Windows.Forms.Label();
            this.accountFormLabel = new System.Windows.Forms.Label();
            this.settingsFormLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tSODBDataSet = new TSO_App_Dev_Project.TSODBDataSet();
            this.studiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studiesTableAdapter = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.StudiesTableAdapter();
            this.tableAdapterManager = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.TableAdapterManager();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.studyIdListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            studyIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TSO_App_Dev_Project.Properties.Resources.gradiantBar2;
            this.pictureBox1.Location = new System.Drawing.Point(-247, -86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1425, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homeFormLabel
            // 
            this.homeFormLabel.AutoSize = true;
            this.homeFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeFormLabel.Location = new System.Drawing.Point(82, 24);
            this.homeFormLabel.Name = "homeFormLabel";
            this.homeFormLabel.Size = new System.Drawing.Size(113, 40);
            this.homeFormLabel.TabIndex = 1;
            this.homeFormLabel.Text = "Home";
            this.homeFormLabel.Click += new System.EventHandler(this.homeFormLabel_Click);
            // 
            // studiesFormLabel
            // 
            this.studiesFormLabel.AutoSize = true;
            this.studiesFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.studiesFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studiesFormLabel.Location = new System.Drawing.Point(205, 24);
            this.studiesFormLabel.Name = "studiesFormLabel";
            this.studiesFormLabel.Size = new System.Drawing.Size(137, 40);
            this.studiesFormLabel.TabIndex = 2;
            this.studiesFormLabel.Text = "Studies";
            this.studiesFormLabel.Click += new System.EventHandler(this.studiesFormLabel_Click);
            // 
            // miceFormLabel
            // 
            this.miceFormLabel.AutoSize = true;
            this.miceFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.miceFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miceFormLabel.Location = new System.Drawing.Point(348, 24);
            this.miceFormLabel.Name = "miceFormLabel";
            this.miceFormLabel.Size = new System.Drawing.Size(93, 40);
            this.miceFormLabel.TabIndex = 3;
            this.miceFormLabel.Text = "Mice";
            this.miceFormLabel.Click += new System.EventHandler(this.miceFormLabel_Click);
            // 
            // logsFormLabel
            // 
            this.logsFormLabel.AutoSize = true;
            this.logsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.logsFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsFormLabel.Location = new System.Drawing.Point(452, 24);
            this.logsFormLabel.Name = "logsFormLabel";
            this.logsFormLabel.Size = new System.Drawing.Size(95, 40);
            this.logsFormLabel.TabIndex = 4;
            this.logsFormLabel.Text = "Logs";
            this.logsFormLabel.Click += new System.EventHandler(this.logsFormLabel_Click);
            // 
            // accountFormLabel
            // 
            this.accountFormLabel.AutoSize = true;
            this.accountFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountFormLabel.Location = new System.Drawing.Point(555, 24);
            this.accountFormLabel.Name = "accountFormLabel";
            this.accountFormLabel.Size = new System.Drawing.Size(147, 40);
            this.accountFormLabel.TabIndex = 5;
            this.accountFormLabel.Text = "Account";
            this.accountFormLabel.Click += new System.EventHandler(this.accountFormLabel_Click);
            // 
            // settingsFormLabel
            // 
            this.settingsFormLabel.AutoSize = true;
            this.settingsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsFormLabel.Location = new System.Drawing.Point(711, 24);
            this.settingsFormLabel.Name = "settingsFormLabel";
            this.settingsFormLabel.Size = new System.Drawing.Size(147, 40);
            this.settingsFormLabel.TabIndex = 6;
            this.settingsFormLabel.Text = "Settings";
            this.settingsFormLabel.Click += new System.EventHandler(this.settingsFormLabel_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(19, 192);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 134);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(453, 49);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Welcome to the TSO";
            // 
            // studyIdLabel
            // 
            studyIdLabel.Location = new System.Drawing.Point(360, 163);
            studyIdLabel.Name = "studyIdLabel";
            studyIdLabel.Size = new System.Drawing.Size(137, 20);
            studyIdLabel.TabIndex = 9;
            studyIdLabel.Text = "Current Studies";
            // 
            // studyIdListBox
            // 
            this.studyIdListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studiesBindingSource, "studyId", true));
            this.studyIdListBox.FormattingEnabled = true;
            this.studyIdListBox.ItemHeight = 20;
            this.studyIdListBox.Location = new System.Drawing.Point(364, 201);
            this.studyIdListBox.Name = "studyIdListBox";
            this.studyIdListBox.Size = new System.Drawing.Size(361, 244);
            this.studyIdListBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 11;
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(studyIdLabel);
            this.Controls.Add(this.studyIdListBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.settingsFormLabel);
            this.Controls.Add(this.accountFormLabel);
            this.Controls.Add(this.logsFormLabel);
            this.Controls.Add(this.miceFormLabel);
            this.Controls.Add(this.studiesFormLabel);
            this.Controls.Add(this.homeFormLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSO - Home";
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiesBindingSource)).EndInit();
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private TSODBDataSet tSODBDataSet;
        private System.Windows.Forms.BindingSource studiesBindingSource;
        private TSODBDataSetTableAdapters.StudiesTableAdapter studiesTableAdapter;
        private TSODBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ListBox studyIdListBox;
        private System.Windows.Forms.Label label2;
    }
}