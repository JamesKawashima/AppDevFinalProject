namespace TSO_App_Dev_Project
{
    partial class StudiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudiesForm));
            this.settingsFormLabel = new System.Windows.Forms.Label();
            this.accountFormLabel = new System.Windows.Forms.Label();
            this.logsFormLabel = new System.Windows.Forms.Label();
            this.miceFormLabel = new System.Windows.Forms.Label();
            this.studiesFormLabel = new System.Windows.Forms.Label();
            this.homeFormLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tSODBDataSet = new TSO_App_Dev_Project.TSODBDataSet();
            this.studiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studiesTableAdapter = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.StudiesTableAdapter();
            this.tableAdapterManager = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.TableAdapterManager();
            this.studiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editStudyGroupBox = new System.Windows.Forms.GroupBox();
            this.editStudyStatusComboBox = new System.Windows.Forms.ComboBox();
            this.editStudyStatusLabel = new System.Windows.Forms.Label();
            this.editStudyDoseVolTextBox = new System.Windows.Forms.TextBox();
            this.editStudyCommentsTextBox = new System.Windows.Forms.TextBox();
            this.editStudyDoseVolLabel = new System.Windows.Forms.Label();
            this.editStudyStudyIDTextBox = new System.Windows.Forms.TextBox();
            this.editStudyDoseNameTextBox = new System.Windows.Forms.TextBox();
            this.editStudyButton = new System.Windows.Forms.Button();
            this.editStudyStudyIdLabel = new System.Windows.Forms.Label();
            this.editStudyDoseNameLabel = new System.Windows.Forms.Label();
            this.editStudyUserIdTextBox = new System.Windows.Forms.TextBox();
            this.editStudyCommentsLabel = new System.Windows.Forms.Label();
            this.editStudyGroupIdTextBox = new System.Windows.Forms.TextBox();
            this.editStudyUserIdLabel = new System.Windows.Forms.Label();
            this.editStudyGroupIdLabel = new System.Windows.Forms.Label();
            this.createStudyGroupBox = new System.Windows.Forms.GroupBox();
            this.createStudyDoseVolumeTextBox = new System.Windows.Forms.TextBox();
            this.doseVolLabel = new System.Windows.Forms.Label();
            this.createStudyDoseNameTextBox = new System.Windows.Forms.TextBox();
            this.doseNameLabel = new System.Windows.Forms.Label();
            this.createStudyUserIDTextBox = new System.Windows.Forms.TextBox();
            this.createStudyGroupIDTextBox = new System.Windows.Forms.TextBox();
            this.leadUserIDLabel = new System.Windows.Forms.Label();
            this.groupIdLabel = new System.Windows.Forms.Label();
            this.addStudyButton = new System.Windows.Forms.Button();
            this.assignMyselfToStudyGroupBox = new System.Windows.Forms.GroupBox();
            this.assignMyselfToStudyStudyIDTextBox = new System.Windows.Forms.TextBox();
            this.assignMyselfToStudyStudyIDLabel = new System.Windows.Forms.Label();
            this.assignMyselfToStudyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiesDataGridView)).BeginInit();
            this.editStudyGroupBox.SuspendLayout();
            this.createStudyGroupBox.SuspendLayout();
            this.assignMyselfToStudyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsFormLabel
            // 
            resources.ApplyResources(this.settingsFormLabel, "settingsFormLabel");
            this.settingsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsFormLabel.Name = "settingsFormLabel";
            this.settingsFormLabel.Click += new System.EventHandler(this.settingsFormLabel_Click);
            // 
            // accountFormLabel
            // 
            resources.ApplyResources(this.accountFormLabel, "accountFormLabel");
            this.accountFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountFormLabel.Name = "accountFormLabel";
            this.accountFormLabel.Click += new System.EventHandler(this.accountFormLabel_Click);
            // 
            // logsFormLabel
            // 
            resources.ApplyResources(this.logsFormLabel, "logsFormLabel");
            this.logsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.logsFormLabel.Name = "logsFormLabel";
            this.logsFormLabel.Click += new System.EventHandler(this.logsFormLabel_Click);
            // 
            // miceFormLabel
            // 
            resources.ApplyResources(this.miceFormLabel, "miceFormLabel");
            this.miceFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.miceFormLabel.Name = "miceFormLabel";
            this.miceFormLabel.Click += new System.EventHandler(this.miceFormLabel_Click);
            // 
            // studiesFormLabel
            // 
            resources.ApplyResources(this.studiesFormLabel, "studiesFormLabel");
            this.studiesFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.studiesFormLabel.Name = "studiesFormLabel";
            this.studiesFormLabel.Click += new System.EventHandler(this.studiesFormLabel_Click);
            // 
            // homeFormLabel
            // 
            resources.ApplyResources(this.homeFormLabel, "homeFormLabel");
            this.homeFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeFormLabel.Name = "homeFormLabel";
            this.homeFormLabel.Click += new System.EventHandler(this.homeFormLabel_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::TSO_App_Dev_Project.Properties.Resources.gradiantBar2;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
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
            // studiesDataGridView
            // 
            resources.ApplyResources(this.studiesDataGridView, "studiesDataGridView");
            this.studiesDataGridView.AutoGenerateColumns = false;
            this.studiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.studiesDataGridView.DataSource = this.studiesBindingSource;
            this.studiesDataGridView.Name = "studiesDataGridView";
            this.studiesDataGridView.RowTemplate.Height = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "studyId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "leadUser";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "groupId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "doseName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dose_mL_Per_g";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "date";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "status";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "comments";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // editStudyGroupBox
            // 
            resources.ApplyResources(this.editStudyGroupBox, "editStudyGroupBox");
            this.editStudyGroupBox.Controls.Add(this.editStudyStatusComboBox);
            this.editStudyGroupBox.Controls.Add(this.editStudyStatusLabel);
            this.editStudyGroupBox.Controls.Add(this.editStudyDoseVolTextBox);
            this.editStudyGroupBox.Controls.Add(this.editStudyCommentsTextBox);
            this.editStudyGroupBox.Controls.Add(this.editStudyDoseVolLabel);
            this.editStudyGroupBox.Controls.Add(this.editStudyStudyIDTextBox);
            this.editStudyGroupBox.Controls.Add(this.editStudyDoseNameTextBox);
            this.editStudyGroupBox.Controls.Add(this.editStudyButton);
            this.editStudyGroupBox.Controls.Add(this.editStudyStudyIdLabel);
            this.editStudyGroupBox.Controls.Add(this.editStudyDoseNameLabel);
            this.editStudyGroupBox.Controls.Add(this.editStudyUserIdTextBox);
            this.editStudyGroupBox.Controls.Add(this.editStudyCommentsLabel);
            this.editStudyGroupBox.Controls.Add(this.editStudyGroupIdTextBox);
            this.editStudyGroupBox.Controls.Add(this.editStudyUserIdLabel);
            this.editStudyGroupBox.Controls.Add(this.editStudyGroupIdLabel);
            this.editStudyGroupBox.Name = "editStudyGroupBox";
            this.editStudyGroupBox.TabStop = false;
            // 
            // editStudyStatusComboBox
            // 
            resources.ApplyResources(this.editStudyStatusComboBox, "editStudyStatusComboBox");
            this.editStudyStatusComboBox.FormattingEnabled = true;
            this.editStudyStatusComboBox.Items.AddRange(new object[] {
            resources.GetString("editStudyStatusComboBox.Items"),
            resources.GetString("editStudyStatusComboBox.Items1"),
            resources.GetString("editStudyStatusComboBox.Items2")});
            this.editStudyStatusComboBox.Name = "editStudyStatusComboBox";
            // 
            // editStudyStatusLabel
            // 
            resources.ApplyResources(this.editStudyStatusLabel, "editStudyStatusLabel");
            this.editStudyStatusLabel.Name = "editStudyStatusLabel";
            // 
            // editStudyDoseVolTextBox
            // 
            resources.ApplyResources(this.editStudyDoseVolTextBox, "editStudyDoseVolTextBox");
            this.editStudyDoseVolTextBox.Name = "editStudyDoseVolTextBox";
            // 
            // editStudyCommentsTextBox
            // 
            resources.ApplyResources(this.editStudyCommentsTextBox, "editStudyCommentsTextBox");
            this.editStudyCommentsTextBox.Name = "editStudyCommentsTextBox";
            // 
            // editStudyDoseVolLabel
            // 
            resources.ApplyResources(this.editStudyDoseVolLabel, "editStudyDoseVolLabel");
            this.editStudyDoseVolLabel.Name = "editStudyDoseVolLabel";
            // 
            // editStudyStudyIDTextBox
            // 
            resources.ApplyResources(this.editStudyStudyIDTextBox, "editStudyStudyIDTextBox");
            this.editStudyStudyIDTextBox.Name = "editStudyStudyIDTextBox";
            // 
            // editStudyDoseNameTextBox
            // 
            resources.ApplyResources(this.editStudyDoseNameTextBox, "editStudyDoseNameTextBox");
            this.editStudyDoseNameTextBox.Name = "editStudyDoseNameTextBox";
            // 
            // editStudyButton
            // 
            resources.ApplyResources(this.editStudyButton, "editStudyButton");
            this.editStudyButton.Name = "editStudyButton";
            this.editStudyButton.UseVisualStyleBackColor = true;
            // 
            // editStudyStudyIdLabel
            // 
            resources.ApplyResources(this.editStudyStudyIdLabel, "editStudyStudyIdLabel");
            this.editStudyStudyIdLabel.Name = "editStudyStudyIdLabel";
            // 
            // editStudyDoseNameLabel
            // 
            resources.ApplyResources(this.editStudyDoseNameLabel, "editStudyDoseNameLabel");
            this.editStudyDoseNameLabel.Name = "editStudyDoseNameLabel";
            // 
            // editStudyUserIdTextBox
            // 
            resources.ApplyResources(this.editStudyUserIdTextBox, "editStudyUserIdTextBox");
            this.editStudyUserIdTextBox.Name = "editStudyUserIdTextBox";
            // 
            // editStudyCommentsLabel
            // 
            resources.ApplyResources(this.editStudyCommentsLabel, "editStudyCommentsLabel");
            this.editStudyCommentsLabel.Name = "editStudyCommentsLabel";
            // 
            // editStudyGroupIdTextBox
            // 
            resources.ApplyResources(this.editStudyGroupIdTextBox, "editStudyGroupIdTextBox");
            this.editStudyGroupIdTextBox.Name = "editStudyGroupIdTextBox";
            // 
            // editStudyUserIdLabel
            // 
            resources.ApplyResources(this.editStudyUserIdLabel, "editStudyUserIdLabel");
            this.editStudyUserIdLabel.Name = "editStudyUserIdLabel";
            // 
            // editStudyGroupIdLabel
            // 
            resources.ApplyResources(this.editStudyGroupIdLabel, "editStudyGroupIdLabel");
            this.editStudyGroupIdLabel.Name = "editStudyGroupIdLabel";
            // 
            // createStudyGroupBox
            // 
            resources.ApplyResources(this.createStudyGroupBox, "createStudyGroupBox");
            this.createStudyGroupBox.Controls.Add(this.createStudyDoseVolumeTextBox);
            this.createStudyGroupBox.Controls.Add(this.doseVolLabel);
            this.createStudyGroupBox.Controls.Add(this.createStudyDoseNameTextBox);
            this.createStudyGroupBox.Controls.Add(this.doseNameLabel);
            this.createStudyGroupBox.Controls.Add(this.createStudyUserIDTextBox);
            this.createStudyGroupBox.Controls.Add(this.createStudyGroupIDTextBox);
            this.createStudyGroupBox.Controls.Add(this.leadUserIDLabel);
            this.createStudyGroupBox.Controls.Add(this.groupIdLabel);
            this.createStudyGroupBox.Controls.Add(this.addStudyButton);
            this.createStudyGroupBox.Name = "createStudyGroupBox";
            this.createStudyGroupBox.TabStop = false;
            // 
            // createStudyDoseVolumeTextBox
            // 
            resources.ApplyResources(this.createStudyDoseVolumeTextBox, "createStudyDoseVolumeTextBox");
            this.createStudyDoseVolumeTextBox.Name = "createStudyDoseVolumeTextBox";
            // 
            // doseVolLabel
            // 
            resources.ApplyResources(this.doseVolLabel, "doseVolLabel");
            this.doseVolLabel.Name = "doseVolLabel";
            // 
            // createStudyDoseNameTextBox
            // 
            resources.ApplyResources(this.createStudyDoseNameTextBox, "createStudyDoseNameTextBox");
            this.createStudyDoseNameTextBox.Name = "createStudyDoseNameTextBox";
            // 
            // doseNameLabel
            // 
            resources.ApplyResources(this.doseNameLabel, "doseNameLabel");
            this.doseNameLabel.Name = "doseNameLabel";
            // 
            // createStudyUserIDTextBox
            // 
            resources.ApplyResources(this.createStudyUserIDTextBox, "createStudyUserIDTextBox");
            this.createStudyUserIDTextBox.Name = "createStudyUserIDTextBox";
            // 
            // createStudyGroupIDTextBox
            // 
            resources.ApplyResources(this.createStudyGroupIDTextBox, "createStudyGroupIDTextBox");
            this.createStudyGroupIDTextBox.Name = "createStudyGroupIDTextBox";
            // 
            // leadUserIDLabel
            // 
            resources.ApplyResources(this.leadUserIDLabel, "leadUserIDLabel");
            this.leadUserIDLabel.Name = "leadUserIDLabel";
            // 
            // groupIdLabel
            // 
            resources.ApplyResources(this.groupIdLabel, "groupIdLabel");
            this.groupIdLabel.Name = "groupIdLabel";
            // 
            // addStudyButton
            // 
            resources.ApplyResources(this.addStudyButton, "addStudyButton");
            this.addStudyButton.Name = "addStudyButton";
            this.addStudyButton.UseVisualStyleBackColor = true;
            // 
            // assignMyselfToStudyGroupBox
            // 
            resources.ApplyResources(this.assignMyselfToStudyGroupBox, "assignMyselfToStudyGroupBox");
            this.assignMyselfToStudyGroupBox.Controls.Add(this.assignMyselfToStudyStudyIDTextBox);
            this.assignMyselfToStudyGroupBox.Controls.Add(this.assignMyselfToStudyStudyIDLabel);
            this.assignMyselfToStudyGroupBox.Controls.Add(this.assignMyselfToStudyButton);
            this.assignMyselfToStudyGroupBox.Name = "assignMyselfToStudyGroupBox";
            this.assignMyselfToStudyGroupBox.TabStop = false;
            // 
            // assignMyselfToStudyStudyIDTextBox
            // 
            resources.ApplyResources(this.assignMyselfToStudyStudyIDTextBox, "assignMyselfToStudyStudyIDTextBox");
            this.assignMyselfToStudyStudyIDTextBox.Name = "assignMyselfToStudyStudyIDTextBox";
            // 
            // assignMyselfToStudyStudyIDLabel
            // 
            resources.ApplyResources(this.assignMyselfToStudyStudyIDLabel, "assignMyselfToStudyStudyIDLabel");
            this.assignMyselfToStudyStudyIDLabel.Name = "assignMyselfToStudyStudyIDLabel";
            // 
            // assignMyselfToStudyButton
            // 
            resources.ApplyResources(this.assignMyselfToStudyButton, "assignMyselfToStudyButton");
            this.assignMyselfToStudyButton.Name = "assignMyselfToStudyButton";
            this.assignMyselfToStudyButton.UseVisualStyleBackColor = true;
            // 
            // StudiesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignMyselfToStudyGroupBox);
            this.Controls.Add(this.editStudyGroupBox);
            this.Controls.Add(this.createStudyGroupBox);
            this.Controls.Add(this.studiesDataGridView);
            this.Controls.Add(this.settingsFormLabel);
            this.Controls.Add(this.accountFormLabel);
            this.Controls.Add(this.logsFormLabel);
            this.Controls.Add(this.miceFormLabel);
            this.Controls.Add(this.studiesFormLabel);
            this.Controls.Add(this.homeFormLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudiesForm";
            this.Load += new System.EventHandler(this.StudiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiesDataGridView)).EndInit();
            this.editStudyGroupBox.ResumeLayout(false);
            this.editStudyGroupBox.PerformLayout();
            this.createStudyGroupBox.ResumeLayout(false);
            this.createStudyGroupBox.PerformLayout();
            this.assignMyselfToStudyGroupBox.ResumeLayout(false);
            this.assignMyselfToStudyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsFormLabel;
        private System.Windows.Forms.Label accountFormLabel;
        private System.Windows.Forms.Label logsFormLabel;
        private System.Windows.Forms.Label miceFormLabel;
        private System.Windows.Forms.Label studiesFormLabel;
        private System.Windows.Forms.Label homeFormLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TSODBDataSet tSODBDataSet;
        private System.Windows.Forms.BindingSource studiesBindingSource;
        private TSODBDataSetTableAdapters.StudiesTableAdapter studiesTableAdapter;
        private TSODBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView studiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox editStudyGroupBox;
        private System.Windows.Forms.TextBox editStudyCommentsTextBox;
        private System.Windows.Forms.TextBox editStudyStudyIDTextBox;
        private System.Windows.Forms.Label editStudyStudyIdLabel;
        private System.Windows.Forms.Button editStudyButton;
        private System.Windows.Forms.Label editStudyCommentsLabel;
        private System.Windows.Forms.GroupBox createStudyGroupBox;
        private System.Windows.Forms.TextBox createStudyUserIDTextBox;
        private System.Windows.Forms.TextBox createStudyGroupIDTextBox;
        private System.Windows.Forms.Label leadUserIDLabel;
        private System.Windows.Forms.Label groupIdLabel;
        private System.Windows.Forms.Button addStudyButton;
        private System.Windows.Forms.TextBox createStudyDoseVolumeTextBox;
        private System.Windows.Forms.Label doseVolLabel;
        private System.Windows.Forms.TextBox createStudyDoseNameTextBox;
        private System.Windows.Forms.Label doseNameLabel;
        private System.Windows.Forms.Label editStudyStatusLabel;
        private System.Windows.Forms.TextBox editStudyDoseVolTextBox;
        private System.Windows.Forms.Label editStudyDoseVolLabel;
        private System.Windows.Forms.TextBox editStudyDoseNameTextBox;
        private System.Windows.Forms.Label editStudyDoseNameLabel;
        private System.Windows.Forms.TextBox editStudyUserIdTextBox;
        private System.Windows.Forms.TextBox editStudyGroupIdTextBox;
        private System.Windows.Forms.Label editStudyUserIdLabel;
        private System.Windows.Forms.Label editStudyGroupIdLabel;
        private System.Windows.Forms.ComboBox editStudyStatusComboBox;
        private System.Windows.Forms.GroupBox assignMyselfToStudyGroupBox;
        private System.Windows.Forms.TextBox assignMyselfToStudyStudyIDTextBox;
        private System.Windows.Forms.Label assignMyselfToStudyStudyIDLabel;
        private System.Windows.Forms.Button assignMyselfToStudyButton;
    }
}