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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miceDataGridView)).BeginInit();
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
            // MiceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}