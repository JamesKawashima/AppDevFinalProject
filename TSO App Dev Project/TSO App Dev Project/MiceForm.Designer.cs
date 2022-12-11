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
            this.settingsFormLabel.AutoSize = true;
            this.settingsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsFormLabel.Location = new System.Drawing.Point(709, 17);
            this.settingsFormLabel.Name = "settingsFormLabel";
            this.settingsFormLabel.Size = new System.Drawing.Size(123, 36);
            this.settingsFormLabel.TabIndex = 13;
            this.settingsFormLabel.Text = "Settings";
            this.settingsFormLabel.Click += new System.EventHandler(this.settingsFormLabel_Click);
            // 
            // accountFormLabel
            // 
            this.accountFormLabel.AutoSize = true;
            this.accountFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountFormLabel.Location = new System.Drawing.Point(571, 17);
            this.accountFormLabel.Name = "accountFormLabel";
            this.accountFormLabel.Size = new System.Drawing.Size(124, 36);
            this.accountFormLabel.TabIndex = 12;
            this.accountFormLabel.Text = "Account";
            this.accountFormLabel.Click += new System.EventHandler(this.accountFormLabel_Click);
            // 
            // logsFormLabel
            // 
            this.logsFormLabel.AutoSize = true;
            this.logsFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.logsFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsFormLabel.Location = new System.Drawing.Point(479, 17);
            this.logsFormLabel.Name = "logsFormLabel";
            this.logsFormLabel.Size = new System.Drawing.Size(78, 36);
            this.logsFormLabel.TabIndex = 11;
            this.logsFormLabel.Text = "Logs";
            this.logsFormLabel.Click += new System.EventHandler(this.logsFormLabel_Click);
            // 
            // miceFormLabel
            // 
            this.miceFormLabel.AutoSize = true;
            this.miceFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.miceFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miceFormLabel.Location = new System.Drawing.Point(387, 17);
            this.miceFormLabel.Name = "miceFormLabel";
            this.miceFormLabel.Size = new System.Drawing.Size(78, 36);
            this.miceFormLabel.TabIndex = 10;
            this.miceFormLabel.Text = "Mice";
            this.miceFormLabel.Click += new System.EventHandler(this.miceFormLabel_Click);
            // 
            // studiesFormLabel
            // 
            this.studiesFormLabel.AutoSize = true;
            this.studiesFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.studiesFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studiesFormLabel.Location = new System.Drawing.Point(260, 17);
            this.studiesFormLabel.Name = "studiesFormLabel";
            this.studiesFormLabel.Size = new System.Drawing.Size(113, 36);
            this.studiesFormLabel.TabIndex = 9;
            this.studiesFormLabel.Text = "Studies";
            this.studiesFormLabel.Click += new System.EventHandler(this.studiesFormLabel_Click);
            // 
            // homeFormLabel
            // 
            this.homeFormLabel.AutoSize = true;
            this.homeFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeFormLabel.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeFormLabel.Location = new System.Drawing.Point(150, 17);
            this.homeFormLabel.Name = "homeFormLabel";
            this.homeFormLabel.Size = new System.Drawing.Size(96, 36);
            this.homeFormLabel.TabIndex = 8;
            this.homeFormLabel.Text = "Home";
            this.homeFormLabel.Click += new System.EventHandler(this.homeFormLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TSO_App_Dev_Project.Properties.Resources.gradiantBar2;
            this.pictureBox1.Location = new System.Drawing.Point(-142, -71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1267, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
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
            this.miceDataGridView.Location = new System.Drawing.Point(33, 119);
            this.miceDataGridView.Name = "miceDataGridView";
            this.miceDataGridView.RowHeadersWidth = 51;
            this.miceDataGridView.RowTemplate.Height = 24;
            this.miceDataGridView.Size = new System.Drawing.Size(951, 429);
            this.miceDataGridView.TabIndex = 14;
            // 
            // groupIDdataGridViewTextBoxColumn
            // 
            this.groupIDdataGridViewTextBoxColumn.DataPropertyName = "groupId";
            this.groupIDdataGridViewTextBoxColumn.HeaderText = "Group ID";
            this.groupIDdataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupIDdataGridViewTextBoxColumn.Name = "groupIDdataGridViewTextBoxColumn";
            this.groupIDdataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.groupIDdataGridViewTextBoxColumn.Width = 65;
            // 
            // mouseIDdataGridViewTextBoxColumn
            // 
            this.mouseIDdataGridViewTextBoxColumn.DataPropertyName = "mouseId";
            this.mouseIDdataGridViewTextBoxColumn.HeaderText = "Mouse ID";
            this.mouseIDdataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mouseIDdataGridViewTextBoxColumn.Name = "mouseIDdataGridViewTextBoxColumn";
            this.mouseIDdataGridViewTextBoxColumn.ReadOnly = true;
            this.mouseIDdataGridViewTextBoxColumn.Width = 65;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height_cm";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height (cm)";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.Width = 80;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "length_cm";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length (cm)";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.Width = 80;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width_cm";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width (cm)";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.Width = 80;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight_g";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight (g)";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 80;
            // 
            // dose1VolDataGridViewTextBoxColumn
            // 
            this.dose1VolDataGridViewTextBoxColumn.DataPropertyName = "dose1Volume_mL";
            this.dose1VolDataGridViewTextBoxColumn.HeaderText = "Dose 1 (mL)";
            this.dose1VolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dose1VolDataGridViewTextBoxColumn.Name = "dose1VolDataGridViewTextBoxColumn";
            this.dose1VolDataGridViewTextBoxColumn.Width = 80;
            // 
            // dose1CompletedDataGridViewCheckBoxColumn
            // 
            this.dose1CompletedDataGridViewCheckBoxColumn.DataPropertyName = "dose1Completed";
            this.dose1CompletedDataGridViewCheckBoxColumn.HeaderText = "Completed";
            this.dose1CompletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dose1CompletedDataGridViewCheckBoxColumn.Name = "dose1CompletedDataGridViewCheckBoxColumn";
            this.dose1CompletedDataGridViewCheckBoxColumn.Width = 80;
            // 
            // dose2VolDataGridViewTextBoxColumn
            // 
            this.dose2VolDataGridViewTextBoxColumn.DataPropertyName = "dose2Volume_mL";
            this.dose2VolDataGridViewTextBoxColumn.HeaderText = "Dose 2 (mL)";
            this.dose2VolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dose2VolDataGridViewTextBoxColumn.Name = "dose2VolDataGridViewTextBoxColumn";
            this.dose2VolDataGridViewTextBoxColumn.Width = 80;
            // 
            // dose2CompletedDataGridViewCheckBoxColumn
            // 
            this.dose2CompletedDataGridViewCheckBoxColumn.DataPropertyName = "dose2Completed";
            this.dose2CompletedDataGridViewCheckBoxColumn.HeaderText = "Completed";
            this.dose2CompletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dose2CompletedDataGridViewCheckBoxColumn.Name = "dose2CompletedDataGridViewCheckBoxColumn";
            this.dose2CompletedDataGridViewCheckBoxColumn.Width = 80;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // MiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 603);
            this.Controls.Add(this.miceDataGridView);
            this.Controls.Add(this.settingsFormLabel);
            this.Controls.Add(this.accountFormLabel);
            this.Controls.Add(this.logsFormLabel);
            this.Controls.Add(this.miceFormLabel);
            this.Controls.Add(this.studiesFormLabel);
            this.Controls.Add(this.homeFormLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSO - Mice";
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