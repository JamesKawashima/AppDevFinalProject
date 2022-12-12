namespace TSO_App_Dev_Project
{
    partial class MiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiceForm));
            this.settingsFormLabel = new System.Windows.Forms.Label();
            this.accountFormLabel = new System.Windows.Forms.Label();
            this.logsFormLabel = new System.Windows.Forms.Label();
            this.miceFormLabel = new System.Windows.Forms.Label();
            this.studiesFormLabel = new System.Windows.Forms.Label();
            this.homeFormLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tSODBDataSet = new TSO_App_Dev_Project.TSODBDataSet();
            this.miceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miceTableAdapter = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.MiceTableAdapter();
            this.tableAdapterManager = new TSO_App_Dev_Project.TSODBDataSetTableAdapters.TableAdapterManager();
            this.miceDataGridView = new System.Windows.Forms.DataGridView();
            this.groupIDdataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouseIDdataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose1VolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose1CompletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dose2VolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose2CompletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMouseButton = new System.Windows.Forms.Button();
            this.addMouseGroupBox = new System.Windows.Forms.GroupBox();
            this.createMouseWeightTextBox = new System.Windows.Forms.TextBox();
            this.createMouseWidthTextBox = new System.Windows.Forms.TextBox();
            this.createMouseLengthTextBox = new System.Windows.Forms.TextBox();
            this.createMouseHeightTextBox = new System.Windows.Forms.TextBox();
            this.createMouseDose2TextBox = new System.Windows.Forms.TextBox();
            this.createMouseDose1TextBox = new System.Windows.Forms.TextBox();
            this.createMouseGroupIDTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.dose2Label = new System.Windows.Forms.Label();
            this.dose1Label = new System.Windows.Forms.Label();
            this.groupIdLabel = new System.Windows.Forms.Label();
            this.editMouseGroupBox = new System.Windows.Forms.GroupBox();
            this.editMouseDose2CheckBox = new System.Windows.Forms.CheckBox();
            this.editMouseDose1CheckBox = new System.Windows.Forms.CheckBox();
            this.editMouseButton = new System.Windows.Forms.Button();
            this.editMouseWeightTextBox = new System.Windows.Forms.TextBox();
            this.editMouseCommentsTextBox = new System.Windows.Forms.TextBox();
            this.editMouseWidthTextBox = new System.Windows.Forms.TextBox();
            this.editMouseMouseIDTextBox = new System.Windows.Forms.TextBox();
            this.editMouseLengthTextBox = new System.Windows.Forms.TextBox();
            this.editMouseHeightTextBox = new System.Windows.Forms.TextBox();
            this.mouseIdLabel = new System.Windows.Forms.Label();
            this.editMouseDose2TextBox = new System.Windows.Forms.TextBox();
            this.editMouseDose1TextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.editMouseGroupIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.addGroupGroupBox = new System.Windows.Forms.GroupBox();
            this.addGroupIdTextBox = new System.Windows.Forms.TextBox();
            this.addGroupIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miceDataGridView)).BeginInit();
            this.addMouseGroupBox.SuspendLayout();
            this.editMouseGroupBox.SuspendLayout();
            this.addGroupGroupBox.SuspendLayout();
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
            // miceBindingSource
            // 
            this.miceBindingSource.DataMember = "Mice";
            this.miceBindingSource.DataSource = this.tSODBDataSet;
            // 
            // miceTableAdapter
            // 
            this.miceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MiceGroupsTableAdapter = null;
            this.tableAdapterManager.MiceTableAdapter = this.miceTableAdapter;
            this.tableAdapterManager.StudiesTableAdapter = null;
            this.tableAdapterManager.TumorLogsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TSO_App_Dev_Project.TSODBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // miceDataGridView
            // 
            resources.ApplyResources(this.miceDataGridView, "miceDataGridView");
            this.miceDataGridView.AllowUserToResizeColumns = false;
            this.miceDataGridView.AllowUserToResizeRows = false;
            this.miceDataGridView.AutoGenerateColumns = false;
            this.miceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupIDdataGridViewTextBoxColumn,
            this.mouseIDdataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.dose1VolDataGridViewTextBoxColumn,
            this.dose1CompletedDataGridViewCheckBoxColumn,
            this.dose2VolDataGridViewTextBoxColumn,
            this.dose2CompletedDataGridViewCheckBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.miceDataGridView.DataSource = this.miceBindingSource;
            this.miceDataGridView.Name = "miceDataGridView";
            this.miceDataGridView.RowTemplate.Height = 24;
            // 
            // groupIDdataGridViewTextBoxColumn
            // 
            this.groupIDdataGridViewTextBoxColumn.DataPropertyName = "groupId";
            resources.ApplyResources(this.groupIDdataGridViewTextBoxColumn, "groupIDdataGridViewTextBoxColumn");
            this.groupIDdataGridViewTextBoxColumn.Name = "groupIDdataGridViewTextBoxColumn";
            this.groupIDdataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // mouseIDdataGridViewTextBoxColumn
            // 
            this.mouseIDdataGridViewTextBoxColumn.DataPropertyName = "mouseId";
            resources.ApplyResources(this.mouseIDdataGridViewTextBoxColumn, "mouseIDdataGridViewTextBoxColumn");
            this.mouseIDdataGridViewTextBoxColumn.Name = "mouseIDdataGridViewTextBoxColumn";
            this.mouseIDdataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height_cm";
            resources.ApplyResources(this.heightDataGridViewTextBoxColumn, "heightDataGridViewTextBoxColumn");
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "length_cm";
            resources.ApplyResources(this.lengthDataGridViewTextBoxColumn, "lengthDataGridViewTextBoxColumn");
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width_cm";
            resources.ApplyResources(this.widthDataGridViewTextBoxColumn, "widthDataGridViewTextBoxColumn");
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight_g";
            resources.ApplyResources(this.weightDataGridViewTextBoxColumn, "weightDataGridViewTextBoxColumn");
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // dose1VolDataGridViewTextBoxColumn
            // 
            this.dose1VolDataGridViewTextBoxColumn.DataPropertyName = "dose1Volume_mL";
            resources.ApplyResources(this.dose1VolDataGridViewTextBoxColumn, "dose1VolDataGridViewTextBoxColumn");
            this.dose1VolDataGridViewTextBoxColumn.Name = "dose1VolDataGridViewTextBoxColumn";
            // 
            // dose1CompletedDataGridViewCheckBoxColumn
            // 
            this.dose1CompletedDataGridViewCheckBoxColumn.DataPropertyName = "dose1Completed";
            resources.ApplyResources(this.dose1CompletedDataGridViewCheckBoxColumn, "dose1CompletedDataGridViewCheckBoxColumn");
            this.dose1CompletedDataGridViewCheckBoxColumn.Name = "dose1CompletedDataGridViewCheckBoxColumn";
            // 
            // dose2VolDataGridViewTextBoxColumn
            // 
            this.dose2VolDataGridViewTextBoxColumn.DataPropertyName = "dose2Volume_mL";
            resources.ApplyResources(this.dose2VolDataGridViewTextBoxColumn, "dose2VolDataGridViewTextBoxColumn");
            this.dose2VolDataGridViewTextBoxColumn.Name = "dose2VolDataGridViewTextBoxColumn";
            // 
            // dose2CompletedDataGridViewCheckBoxColumn
            // 
            this.dose2CompletedDataGridViewCheckBoxColumn.DataPropertyName = "dose2Completed";
            resources.ApplyResources(this.dose2CompletedDataGridViewCheckBoxColumn, "dose2CompletedDataGridViewCheckBoxColumn");
            this.dose2CompletedDataGridViewCheckBoxColumn.Name = "dose2CompletedDataGridViewCheckBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "comments";
            resources.ApplyResources(this.commentsDataGridViewTextBoxColumn, "commentsDataGridViewTextBoxColumn");
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // addMouseButton
            // 
            resources.ApplyResources(this.addMouseButton, "addMouseButton");
            this.addMouseButton.Name = "addMouseButton";
            this.addMouseButton.UseVisualStyleBackColor = true;
            this.addMouseButton.Click += new System.EventHandler(this.addMouseButton_Click);
            // 
            // addMouseGroupBox
            // 
            resources.ApplyResources(this.addMouseGroupBox, "addMouseGroupBox");
            this.addMouseGroupBox.Controls.Add(this.createMouseWeightTextBox);
            this.addMouseGroupBox.Controls.Add(this.createMouseWidthTextBox);
            this.addMouseGroupBox.Controls.Add(this.createMouseLengthTextBox);
            this.addMouseGroupBox.Controls.Add(this.createMouseHeightTextBox);
            this.addMouseGroupBox.Controls.Add(this.createMouseDose2TextBox);
            this.addMouseGroupBox.Controls.Add(this.createMouseDose1TextBox);
            this.addMouseGroupBox.Controls.Add(this.createMouseGroupIDTextBox);
            this.addMouseGroupBox.Controls.Add(this.weightLabel);
            this.addMouseGroupBox.Controls.Add(this.widthLabel);
            this.addMouseGroupBox.Controls.Add(this.lengthLabel);
            this.addMouseGroupBox.Controls.Add(this.heightLabel);
            this.addMouseGroupBox.Controls.Add(this.dose2Label);
            this.addMouseGroupBox.Controls.Add(this.dose1Label);
            this.addMouseGroupBox.Controls.Add(this.groupIdLabel);
            this.addMouseGroupBox.Controls.Add(this.addMouseButton);
            this.addMouseGroupBox.Name = "addMouseGroupBox";
            this.addMouseGroupBox.TabStop = false;
            // 
            // createMouseWeightTextBox
            // 
            resources.ApplyResources(this.createMouseWeightTextBox, "createMouseWeightTextBox");
            this.createMouseWeightTextBox.Name = "createMouseWeightTextBox";
            // 
            // createMouseWidthTextBox
            // 
            resources.ApplyResources(this.createMouseWidthTextBox, "createMouseWidthTextBox");
            this.createMouseWidthTextBox.Name = "createMouseWidthTextBox";
            // 
            // createMouseLengthTextBox
            // 
            resources.ApplyResources(this.createMouseLengthTextBox, "createMouseLengthTextBox");
            this.createMouseLengthTextBox.Name = "createMouseLengthTextBox";
            // 
            // createMouseHeightTextBox
            // 
            resources.ApplyResources(this.createMouseHeightTextBox, "createMouseHeightTextBox");
            this.createMouseHeightTextBox.Name = "createMouseHeightTextBox";
            // 
            // createMouseDose2TextBox
            // 
            resources.ApplyResources(this.createMouseDose2TextBox, "createMouseDose2TextBox");
            this.createMouseDose2TextBox.Name = "createMouseDose2TextBox";
            // 
            // createMouseDose1TextBox
            // 
            resources.ApplyResources(this.createMouseDose1TextBox, "createMouseDose1TextBox");
            this.createMouseDose1TextBox.Name = "createMouseDose1TextBox";
            // 
            // createMouseGroupIDTextBox
            // 
            resources.ApplyResources(this.createMouseGroupIDTextBox, "createMouseGroupIDTextBox");
            this.createMouseGroupIDTextBox.Name = "createMouseGroupIDTextBox";
            // 
            // weightLabel
            // 
            resources.ApplyResources(this.weightLabel, "weightLabel");
            this.weightLabel.Name = "weightLabel";
            // 
            // widthLabel
            // 
            resources.ApplyResources(this.widthLabel, "widthLabel");
            this.widthLabel.Name = "widthLabel";
            // 
            // lengthLabel
            // 
            resources.ApplyResources(this.lengthLabel, "lengthLabel");
            this.lengthLabel.Name = "lengthLabel";
            // 
            // heightLabel
            // 
            resources.ApplyResources(this.heightLabel, "heightLabel");
            this.heightLabel.Name = "heightLabel";
            // 
            // dose2Label
            // 
            resources.ApplyResources(this.dose2Label, "dose2Label");
            this.dose2Label.Name = "dose2Label";
            // 
            // dose1Label
            // 
            resources.ApplyResources(this.dose1Label, "dose1Label");
            this.dose1Label.Name = "dose1Label";
            // 
            // groupIdLabel
            // 
            resources.ApplyResources(this.groupIdLabel, "groupIdLabel");
            this.groupIdLabel.Name = "groupIdLabel";
            // 
            // editMouseGroupBox
            // 
            resources.ApplyResources(this.editMouseGroupBox, "editMouseGroupBox");
            this.editMouseGroupBox.Controls.Add(this.editMouseDose2CheckBox);
            this.editMouseGroupBox.Controls.Add(this.editMouseDose1CheckBox);
            this.editMouseGroupBox.Controls.Add(this.editMouseButton);
            this.editMouseGroupBox.Controls.Add(this.editMouseWeightTextBox);
            this.editMouseGroupBox.Controls.Add(this.editMouseCommentsTextBox);
            this.editMouseGroupBox.Controls.Add(this.editMouseWidthTextBox);
            this.editMouseGroupBox.Controls.Add(this.editMouseMouseIDTextBox);
            this.editMouseGroupBox.Controls.Add(this.editMouseLengthTextBox);
            this.editMouseGroupBox.Controls.Add(this.editMouseHeightTextBox);
            this.editMouseGroupBox.Controls.Add(this.mouseIdLabel);
            this.editMouseGroupBox.Controls.Add(this.editMouseDose2TextBox);
            this.editMouseGroupBox.Controls.Add(this.editMouseDose1TextBox);
            this.editMouseGroupBox.Controls.Add(this.commentsLabel);
            this.editMouseGroupBox.Controls.Add(this.editMouseGroupIDTextBox);
            this.editMouseGroupBox.Controls.Add(this.label7);
            this.editMouseGroupBox.Controls.Add(this.label1);
            this.editMouseGroupBox.Controls.Add(this.label6);
            this.editMouseGroupBox.Controls.Add(this.label2);
            this.editMouseGroupBox.Controls.Add(this.label5);
            this.editMouseGroupBox.Controls.Add(this.label4);
            this.editMouseGroupBox.Controls.Add(this.label3);
            this.editMouseGroupBox.Name = "editMouseGroupBox";
            this.editMouseGroupBox.TabStop = false;
            // 
            // editMouseDose2CheckBox
            // 
            resources.ApplyResources(this.editMouseDose2CheckBox, "editMouseDose2CheckBox");
            this.editMouseDose2CheckBox.Name = "editMouseDose2CheckBox";
            this.editMouseDose2CheckBox.UseVisualStyleBackColor = true;
            // 
            // editMouseDose1CheckBox
            // 
            resources.ApplyResources(this.editMouseDose1CheckBox, "editMouseDose1CheckBox");
            this.editMouseDose1CheckBox.Name = "editMouseDose1CheckBox";
            this.editMouseDose1CheckBox.UseVisualStyleBackColor = true;
            // 
            // editMouseButton
            // 
            resources.ApplyResources(this.editMouseButton, "editMouseButton");
            this.editMouseButton.Name = "editMouseButton";
            this.editMouseButton.UseVisualStyleBackColor = true;
            this.editMouseButton.Click += new System.EventHandler(this.editMouseButton_Click);
            // 
            // editMouseWeightTextBox
            // 
            resources.ApplyResources(this.editMouseWeightTextBox, "editMouseWeightTextBox");
            this.editMouseWeightTextBox.Name = "editMouseWeightTextBox";
            // 
            // editMouseCommentsTextBox
            // 
            resources.ApplyResources(this.editMouseCommentsTextBox, "editMouseCommentsTextBox");
            this.editMouseCommentsTextBox.Name = "editMouseCommentsTextBox";
            // 
            // editMouseWidthTextBox
            // 
            resources.ApplyResources(this.editMouseWidthTextBox, "editMouseWidthTextBox");
            this.editMouseWidthTextBox.Name = "editMouseWidthTextBox";
            // 
            // editMouseMouseIDTextBox
            // 
            resources.ApplyResources(this.editMouseMouseIDTextBox, "editMouseMouseIDTextBox");
            this.editMouseMouseIDTextBox.Name = "editMouseMouseIDTextBox";
            // 
            // editMouseLengthTextBox
            // 
            resources.ApplyResources(this.editMouseLengthTextBox, "editMouseLengthTextBox");
            this.editMouseLengthTextBox.Name = "editMouseLengthTextBox";
            // 
            // editMouseHeightTextBox
            // 
            resources.ApplyResources(this.editMouseHeightTextBox, "editMouseHeightTextBox");
            this.editMouseHeightTextBox.Name = "editMouseHeightTextBox";
            // 
            // mouseIdLabel
            // 
            resources.ApplyResources(this.mouseIdLabel, "mouseIdLabel");
            this.mouseIdLabel.Name = "mouseIdLabel";
            // 
            // editMouseDose2TextBox
            // 
            resources.ApplyResources(this.editMouseDose2TextBox, "editMouseDose2TextBox");
            this.editMouseDose2TextBox.Name = "editMouseDose2TextBox";
            // 
            // editMouseDose1TextBox
            // 
            resources.ApplyResources(this.editMouseDose1TextBox, "editMouseDose1TextBox");
            this.editMouseDose1TextBox.Name = "editMouseDose1TextBox";
            // 
            // commentsLabel
            // 
            resources.ApplyResources(this.commentsLabel, "commentsLabel");
            this.commentsLabel.Name = "commentsLabel";
            // 
            // editMouseGroupIDTextBox
            // 
            resources.ApplyResources(this.editMouseGroupIDTextBox, "editMouseGroupIDTextBox");
            this.editMouseGroupIDTextBox.Name = "editMouseGroupIDTextBox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // addGroupButton
            // 
            resources.ApplyResources(this.addGroupButton, "addGroupButton");
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // addGroupGroupBox
            // 
            resources.ApplyResources(this.addGroupGroupBox, "addGroupGroupBox");
            this.addGroupGroupBox.Controls.Add(this.addGroupIdTextBox);
            this.addGroupGroupBox.Controls.Add(this.addGroupIdLabel);
            this.addGroupGroupBox.Controls.Add(this.addGroupButton);
            this.addGroupGroupBox.Name = "addGroupGroupBox";
            this.addGroupGroupBox.TabStop = false;
            // 
            // addGroupIdTextBox
            // 
            resources.ApplyResources(this.addGroupIdTextBox, "addGroupIdTextBox");
            this.addGroupIdTextBox.Name = "addGroupIdTextBox";
            // 
            // addGroupIdLabel
            // 
            resources.ApplyResources(this.addGroupIdLabel, "addGroupIdLabel");
            this.addGroupIdLabel.Name = "addGroupIdLabel";
            // 
            // MiceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addGroupGroupBox);
            this.Controls.Add(this.editMouseGroupBox);
            this.Controls.Add(this.addMouseGroupBox);
            this.Controls.Add(this.miceDataGridView);
            this.Controls.Add(this.settingsFormLabel);
            this.Controls.Add(this.accountFormLabel);
            this.Controls.Add(this.logsFormLabel);
            this.Controls.Add(this.miceFormLabel);
            this.Controls.Add(this.studiesFormLabel);
            this.Controls.Add(this.homeFormLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MiceForm";
            this.Load += new System.EventHandler(this.MiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miceDataGridView)).EndInit();
            this.addMouseGroupBox.ResumeLayout(false);
            this.addMouseGroupBox.PerformLayout();
            this.editMouseGroupBox.ResumeLayout(false);
            this.editMouseGroupBox.PerformLayout();
            this.addGroupGroupBox.ResumeLayout(false);
            this.addGroupGroupBox.PerformLayout();
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
        private System.Windows.Forms.BindingSource miceBindingSource;
        private TSODBDataSetTableAdapters.MiceTableAdapter miceTableAdapter;
        private TSODBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView miceDataGridView;
        private System.Windows.Forms.Button addMouseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDdataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mouseIDdataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose1VolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dose1CompletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose2VolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dose2CompletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox addMouseGroupBox;
        private System.Windows.Forms.TextBox createMouseWeightTextBox;
        private System.Windows.Forms.TextBox createMouseWidthTextBox;
        private System.Windows.Forms.TextBox createMouseLengthTextBox;
        private System.Windows.Forms.TextBox createMouseHeightTextBox;
        private System.Windows.Forms.TextBox createMouseDose2TextBox;
        private System.Windows.Forms.TextBox createMouseDose1TextBox;
        private System.Windows.Forms.TextBox createMouseGroupIDTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label dose2Label;
        private System.Windows.Forms.Label dose1Label;
        private System.Windows.Forms.Label groupIdLabel;
        private System.Windows.Forms.GroupBox editMouseGroupBox;
        private System.Windows.Forms.TextBox editMouseCommentsTextBox;
        private System.Windows.Forms.TextBox editMouseMouseIDTextBox;
        private System.Windows.Forms.Label mouseIdLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.GroupBox addGroupGroupBox;
        private System.Windows.Forms.TextBox addGroupIdTextBox;
        private System.Windows.Forms.Label addGroupIdLabel;
        private System.Windows.Forms.TextBox editMouseWeightTextBox;
        private System.Windows.Forms.TextBox editMouseWidthTextBox;
        private System.Windows.Forms.TextBox editMouseLengthTextBox;
        private System.Windows.Forms.TextBox editMouseHeightTextBox;
        private System.Windows.Forms.TextBox editMouseDose2TextBox;
        private System.Windows.Forms.TextBox editMouseDose1TextBox;
        private System.Windows.Forms.TextBox editMouseGroupIDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox editMouseDose2CheckBox;
        private System.Windows.Forms.CheckBox editMouseDose1CheckBox;
        private System.Windows.Forms.Button editMouseButton;
    }
}