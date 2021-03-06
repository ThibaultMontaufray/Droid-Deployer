﻿namespace Droid_deployer
{
    partial class DemoSyncany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label = new System.Windows.Forms.Label();
            this.textBoxConfigPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseConfigPath = new System.Windows.Forms.Button();
            this.buttonBrowseOriginPath = new System.Windows.Forms.Button();
            this.textBoxOriginPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.buttonCreateCloud = new System.Windows.Forms.Button();
            this.groupBoxCreation = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxConnectionAddedRepo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewRepo = new System.Windows.Forms.DataGridView();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonAddRepo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRepoToAssociate = new System.Windows.Forms.TextBox();
            this.buttonBrowseAddRepository = new System.Windows.Forms.Button();
            this.groupBoxCreation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(6, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Cloud config path";
            // 
            // textBoxConfigPath
            // 
            this.textBoxConfigPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfigPath.Location = new System.Drawing.Point(125, 26);
            this.textBoxConfigPath.Name = "textBoxConfigPath";
            this.textBoxConfigPath.Size = new System.Drawing.Size(206, 20);
            this.textBoxConfigPath.TabIndex = 1;
            // 
            // buttonBrowseConfigPath
            // 
            this.buttonBrowseConfigPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseConfigPath.Location = new System.Drawing.Point(337, 24);
            this.buttonBrowseConfigPath.Name = "buttonBrowseConfigPath";
            this.buttonBrowseConfigPath.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseConfigPath.TabIndex = 2;
            this.buttonBrowseConfigPath.Text = "Browse";
            this.buttonBrowseConfigPath.UseVisualStyleBackColor = true;
            this.buttonBrowseConfigPath.Click += new System.EventHandler(this.buttonBrowseConfigPath_Click);
            // 
            // buttonBrowseOriginPath
            // 
            this.buttonBrowseOriginPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseOriginPath.Location = new System.Drawing.Point(337, 53);
            this.buttonBrowseOriginPath.Name = "buttonBrowseOriginPath";
            this.buttonBrowseOriginPath.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseOriginPath.TabIndex = 5;
            this.buttonBrowseOriginPath.Text = "Browse";
            this.buttonBrowseOriginPath.UseVisualStyleBackColor = true;
            this.buttonBrowseOriginPath.Click += new System.EventHandler(this.buttonBrowseOriginPath_Click);
            // 
            // textBoxOriginPath
            // 
            this.textBoxOriginPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginPath.Location = new System.Drawing.Point(125, 55);
            this.textBoxOriginPath.Name = "textBoxOriginPath";
            this.textBoxOriginPath.Size = new System.Drawing.Size(206, 20);
            this.textBoxOriginPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origin path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cloud connection type";
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConnectionType.FormattingEnabled = true;
            this.comboBoxConnectionType.Location = new System.Drawing.Point(125, 81);
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.Size = new System.Drawing.Size(206, 21);
            this.comboBoxConnectionType.TabIndex = 7;
            // 
            // buttonCreateCloud
            // 
            this.buttonCreateCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateCloud.Location = new System.Drawing.Point(337, 79);
            this.buttonCreateCloud.Name = "buttonCreateCloud";
            this.buttonCreateCloud.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateCloud.TabIndex = 8;
            this.buttonCreateCloud.Text = "Create cloud";
            this.buttonCreateCloud.UseVisualStyleBackColor = true;
            this.buttonCreateCloud.Click += new System.EventHandler(this.buttonCreateCloud_Click);
            // 
            // groupBoxCreation
            // 
            this.groupBoxCreation.Controls.Add(this.label);
            this.groupBoxCreation.Controls.Add(this.buttonCreateCloud);
            this.groupBoxCreation.Controls.Add(this.textBoxConfigPath);
            this.groupBoxCreation.Controls.Add(this.comboBoxConnectionType);
            this.groupBoxCreation.Controls.Add(this.buttonBrowseConfigPath);
            this.groupBoxCreation.Controls.Add(this.label2);
            this.groupBoxCreation.Controls.Add(this.label1);
            this.groupBoxCreation.Controls.Add(this.buttonBrowseOriginPath);
            this.groupBoxCreation.Controls.Add(this.textBoxOriginPath);
            this.groupBoxCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCreation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCreation.Name = "groupBoxCreation";
            this.groupBoxCreation.Size = new System.Drawing.Size(421, 111);
            this.groupBoxCreation.TabIndex = 9;
            this.groupBoxCreation.TabStop = false;
            this.groupBoxCreation.Text = "Cloud creation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxConnectionAddedRepo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridViewRepo);
            this.groupBox1.Controls.Add(this.buttonAddRepo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxRepoToAssociate);
            this.groupBox1.Controls.Add(this.buttonBrowseAddRepository);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 311);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cloud management";
            // 
            // comboBoxConnectionAddedRepo
            // 
            this.comboBoxConnectionAddedRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionAddedRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConnectionAddedRepo.FormattingEnabled = true;
            this.comboBoxConnectionAddedRepo.Location = new System.Drawing.Point(129, 55);
            this.comboBoxConnectionAddedRepo.Name = "comboBoxConnectionAddedRepo";
            this.comboBoxConnectionAddedRepo.Size = new System.Drawing.Size(202, 21);
            this.comboBoxConnectionAddedRepo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cloud connection type";
            // 
            // dataGridViewRepo
            // 
            this.dataGridViewRepo.AllowUserToAddRows = false;
            this.dataGridViewRepo.AllowUserToDeleteRows = false;
            this.dataGridViewRepo.AllowUserToResizeColumns = false;
            this.dataGridViewRepo.AllowUserToResizeRows = false;
            this.dataGridViewRepo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIcon,
            this.ColumnId,
            this.ColumnPath,
            this.ColumnTypeName,
            this.ColumnEnabled});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRepo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRepo.Location = new System.Drawing.Point(9, 82);
            this.dataGridViewRepo.Name = "dataGridViewRepo";
            this.dataGridViewRepo.RowHeadersVisible = false;
            this.dataGridViewRepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepo.Size = new System.Drawing.Size(403, 219);
            this.dataGridViewRepo.TabIndex = 8;
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ColumnIcon.HeaderText = "";
            this.ColumnIcon.Name = "ColumnIcon";
            this.ColumnIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnIcon.Width = 5;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 41;
            // 
            // ColumnPath
            // 
            this.ColumnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            // 
            // ColumnTypeName
            // 
            this.ColumnTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTypeName.HeaderText = "Type";
            this.ColumnTypeName.Name = "ColumnTypeName";
            this.ColumnTypeName.Width = 56;
            // 
            // ColumnEnabled
            // 
            this.ColumnEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEnabled.HeaderText = "Synchronised";
            this.ColumnEnabled.Name = "ColumnEnabled";
            this.ColumnEnabled.Width = 77;
            // 
            // buttonAddRepo
            // 
            this.buttonAddRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRepo.Location = new System.Drawing.Point(337, 53);
            this.buttonAddRepo.Name = "buttonAddRepo";
            this.buttonAddRepo.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRepo.TabIndex = 6;
            this.buttonAddRepo.Text = "Add repo";
            this.buttonAddRepo.UseVisualStyleBackColor = true;
            this.buttonAddRepo.Click += new System.EventHandler(this.buttonAddRepo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add cloud repository";
            // 
            // textBoxRepoToAssociate
            // 
            this.textBoxRepoToAssociate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepoToAssociate.Location = new System.Drawing.Point(129, 26);
            this.textBoxRepoToAssociate.Name = "textBoxRepoToAssociate";
            this.textBoxRepoToAssociate.Size = new System.Drawing.Size(202, 20);
            this.textBoxRepoToAssociate.TabIndex = 4;
            // 
            // buttonBrowseAddRepository
            // 
            this.buttonBrowseAddRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseAddRepository.Location = new System.Drawing.Point(337, 24);
            this.buttonBrowseAddRepository.Name = "buttonBrowseAddRepository";
            this.buttonBrowseAddRepository.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseAddRepository.TabIndex = 5;
            this.buttonBrowseAddRepository.Text = "Browse";
            this.buttonBrowseAddRepository.UseVisualStyleBackColor = true;
            this.buttonBrowseAddRepository.Click += new System.EventHandler(this.buttonBrowseAddRepository_Click);
            // 
            // DemoSyncany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCreation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DemoSyncany";
            this.Text = "Demo";
            this.groupBoxCreation.ResumeLayout(false);
            this.groupBoxCreation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxConfigPath;
        private System.Windows.Forms.Button buttonBrowseConfigPath;
        private System.Windows.Forms.Button buttonBrowseOriginPath;
        private System.Windows.Forms.TextBox textBoxOriginPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.Button buttonCreateCloud;
        private System.Windows.Forms.GroupBox groupBoxCreation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRepoToAssociate;
        private System.Windows.Forms.Button buttonBrowseAddRepository;
        private System.Windows.Forms.Button buttonAddRepo;
        private System.Windows.Forms.DataGridView dataGridViewRepo;
        private System.Windows.Forms.ComboBox comboBoxConnectionAddedRepo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEnabled;
    }
}