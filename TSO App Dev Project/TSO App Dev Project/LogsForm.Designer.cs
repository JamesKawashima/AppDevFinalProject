namespace TSO_App_Dev_Project
{
    partial class LogsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsForm));
            this.settingsFormLabel = new System.Windows.Forms.Label();
            this.accountFormLabel = new System.Windows.Forms.Label();
            this.logsFormLabel = new System.Windows.Forms.Label();
            this.miceFormLabel = new System.Windows.Forms.Label();
            this.studiesFormLabel = new System.Windows.Forms.Label();
            this.homeFormLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createLogGroupBox = new System.Windows.Forms.GroupBox();
            this.createLogButton = new System.Windows.Forms.Button();
            this.createLogEuthanizedCheckBox = new System.Windows.Forms.CheckBox();
            this.createLogWidthTextBox = new System.Windows.Forms.TextBox();
            this.createLogWidthLabel = new System.Windows.Forms.Label();
            this.createLogLengthTextBox = new System.Windows.Forms.TextBox();
            this.createLogLengthLabel = new System.Windows.Forms.Label();
            this.createLogMouseIDTextBox = new System.Windows.Forms.TextBox();
            this.createLogHeightTextBox = new System.Windows.Forms.TextBox();
            this.createLogMouseIDLabel = new System.Windows.Forms.Label();
            this.createLogHeightLabel = new System.Windows.Forms.Label();
            this.tSODBDataSet = new TSO_App_Dev_Project.TSODBDataSet();
            this.tumorLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tumorLogsTableAdapter = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.TumorLogsTableAdapter();
            this.tableAdapterManager = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.TableAdapterManager();
            this.tumorLogsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createLogCommentsTextBox = new System.Windows.Forms.TextBox();
            this.createLogCommentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.createLogGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumorLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumorLogsDataGridView)).BeginInit();
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
            this.pictureBox1.Image = global::TSO_App_Dev_Project.Properties.Resources.gradiantBar2;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // createLogGroupBox
            // 
            this.createLogGroupBox.Controls.Add(this.createLogCommentsTextBox);
            this.createLogGroupBox.Controls.Add(this.createLogCommentsLabel);
            this.createLogGroupBox.Controls.Add(this.createLogButton);
            this.createLogGroupBox.Controls.Add(this.createLogEuthanizedCheckBox);
            this.createLogGroupBox.Controls.Add(this.createLogWidthTextBox);
            this.createLogGroupBox.Controls.Add(this.createLogWidthLabel);
            this.createLogGroupBox.Controls.Add(this.createLogLengthTextBox);
            this.createLogGroupBox.Controls.Add(this.createLogLengthLabel);
            this.createLogGroupBox.Controls.Add(this.createLogMouseIDTextBox);
            this.createLogGroupBox.Controls.Add(this.createLogHeightTextBox);
            this.createLogGroupBox.Controls.Add(this.createLogMouseIDLabel);
            this.createLogGroupBox.Controls.Add(this.createLogHeightLabel);
            resources.ApplyResources(this.createLogGroupBox, "createLogGroupBox");
            this.createLogGroupBox.Name = "createLogGroupBox";
            this.createLogGroupBox.TabStop = false;
            // 
            // createLogButton
            // 
            resources.ApplyResources(this.createLogButton, "createLogButton");
            this.createLogButton.Name = "createLogButton";
            this.createLogButton.UseVisualStyleBackColor = true;
            this.createLogButton.Click += new System.EventHandler(this.createLogButton_Click);
            // 
            // createLogEuthanizedCheckBox
            // 
            resources.ApplyResources(this.createLogEuthanizedCheckBox, "createLogEuthanizedCheckBox");
            this.createLogEuthanizedCheckBox.Name = "createLogEuthanizedCheckBox";
            this.createLogEuthanizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // createLogWidthTextBox
            // 
            resources.ApplyResources(this.createLogWidthTextBox, "createLogWidthTextBox");
            this.createLogWidthTextBox.Name = "createLogWidthTextBox";
            // 
            // createLogWidthLabel
            // 
            resources.ApplyResources(this.createLogWidthLabel, "createLogWidthLabel");
            this.createLogWidthLabel.Name = "createLogWidthLabel";
            // 
            // createLogLengthTextBox
            // 
            resources.ApplyResources(this.createLogLengthTextBox, "createLogLengthTextBox");
            this.createLogLengthTextBox.Name = "createLogLengthTextBox";
            // 
            // createLogLengthLabel
            // 
            resources.ApplyResources(this.createLogLengthLabel, "createLogLengthLabel");
            this.createLogLengthLabel.Name = "createLogLengthLabel";
            // 
            // createLogMouseIDTextBox
            // 
            resources.ApplyResources(this.createLogMouseIDTextBox, "createLogMouseIDTextBox");
            this.createLogMouseIDTextBox.Name = "createLogMouseIDTextBox";
            // 
            // createLogHeightTextBox
            // 
            resources.ApplyResources(this.createLogHeightTextBox, "createLogHeightTextBox");
            this.createLogHeightTextBox.Name = "createLogHeightTextBox";
            // 
            // createLogMouseIDLabel
            // 
            resources.ApplyResources(this.createLogMouseIDLabel, "createLogMouseIDLabel");
            this.createLogMouseIDLabel.Name = "createLogMouseIDLabel";
            // 
            // createLogHeightLabel
            // 
            resources.ApplyResources(this.createLogHeightLabel, "createLogHeightLabel");
            this.createLogHeightLabel.Name = "createLogHeightLabel";
            // 
            // tSODBDataSet
            // 
            this.tSODBDataSet.DataSetName = "TSODBDataSet";
            this.tSODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tumorLogsBindingSource
            // 
            this.tumorLogsBindingSource.DataMember = "TumorLogs";
            this.tumorLogsBindingSource.DataSource = this.tSODBDataSet;
            // 
            // tumorLogsTableAdapter
            // 
            this.tumorLogsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MiceGroupsTableAdapter = null;
            this.tableAdapterManager.MiceTableAdapter = null;
            this.tableAdapterManager.StudiesTableAdapter = null;
            this.tableAdapterManager.TumorLogsTableAdapter = this.tumorLogsTableAdapter;
            this.tableAdapterManager.UpdateOrder = TSO_App_Dev_Project.TSODBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // tumorLogsDataGridView
            // 
            this.tumorLogsDataGridView.AutoGenerateColumns = false;
            this.tumorLogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tumorLogsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tumorLogsDataGridView.DataSource = this.tumorLogsBindingSource;
            resources.ApplyResources(this.tumorLogsDataGridView, "tumorLogsDataGridView");
            this.tumorLogsDataGridView.Name = "tumorLogsDataGridView";
            this.tumorLogsDataGridView.RowTemplate.Height = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "logId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dateOfLog";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "timeOfLog";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mouseId";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tumorHeight_cm";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tumorLength_cm";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tumorWidth_cm";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tumorVolume_cm3";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "mouseEuthanized";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "comments";
            resources.ApplyResources(this.dataGridViewTextBoxColumn11, "dataGridViewTextBoxColumn11");
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // createLogCommentsTextBox
            // 
            resources.ApplyResources(this.createLogCommentsTextBox, "createLogCommentsTextBox");
            this.createLogCommentsTextBox.Name = "createLogCommentsTextBox";
            // 
            // createLogCommentsLabel
            // 
            resources.ApplyResources(this.createLogCommentsLabel, "createLogCommentsLabel");
            this.createLogCommentsLabel.Name = "createLogCommentsLabel";
            // 
            // LogsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tumorLogsDataGridView);
            this.Controls.Add(this.createLogGroupBox);
            this.Controls.Add(this.settingsFormLabel);
            this.Controls.Add(this.accountFormLabel);
            this.Controls.Add(this.logsFormLabel);
            this.Controls.Add(this.miceFormLabel);
            this.Controls.Add(this.studiesFormLabel);
            this.Controls.Add(this.homeFormLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LogsForm";
            this.Load += new System.EventHandler(this.LogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.createLogGroupBox.ResumeLayout(false);
            this.createLogGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumorLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumorLogsDataGridView)).EndInit();
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
        private System.Windows.Forms.GroupBox createLogGroupBox;
        private System.Windows.Forms.Button createLogButton;
        private System.Windows.Forms.CheckBox createLogEuthanizedCheckBox;
        private System.Windows.Forms.TextBox createLogWidthTextBox;
        private System.Windows.Forms.Label createLogWidthLabel;
        private System.Windows.Forms.TextBox createLogLengthTextBox;
        private System.Windows.Forms.Label createLogLengthLabel;
        private System.Windows.Forms.TextBox createLogMouseIDTextBox;
        private System.Windows.Forms.TextBox createLogHeightTextBox;
        private System.Windows.Forms.Label createLogMouseIDLabel;
        private System.Windows.Forms.Label createLogHeightLabel;
        private TSODBDataSet tSODBDataSet;
        private System.Windows.Forms.BindingSource tumorLogsBindingSource;
        private TSODBDataSetTableAdapters.TumorLogsTableAdapter tumorLogsTableAdapter;
        private TSODBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tumorLogsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox createLogCommentsTextBox;
        private System.Windows.Forms.Label createLogCommentsLabel;
    }
}