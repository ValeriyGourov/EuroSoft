namespace EuroSoft
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UserStatistics = new System.Windows.Forms.DataGridView();
            this.testResultsDataSet = new EuroSoft.TestResultsDataSet();
            this.testResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testResultsTableAdapter = new EuroSoft.TestResultsDataSetTableAdapters.TestResultsTableAdapter();
            this.UserStatisticsLabel = new System.Windows.Forms.Label();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswersCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorrectAnswersCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missedAnswersCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(12, 16);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(96, 23);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User name:";
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.Location = new System.Drawing.Point(114, 13);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(539, 30);
            this.UserName.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(12, 267);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(641, 32);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // UserStatistics
            // 
            this.UserStatistics.AllowUserToAddRows = false;
            this.UserStatistics.AllowUserToDeleteRows = false;
            this.UserStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserStatistics.AutoGenerateColumns = false;
            this.UserStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserStatistics.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UserStatistics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.correctAnswersCountDataGridViewTextBoxColumn,
            this.incorrectAnswersCountDataGridViewTextBoxColumn,
            this.missedAnswersCountDataGridViewTextBoxColumn});
            this.UserStatistics.DataSource = this.testResultsBindingSource;
            this.UserStatistics.Location = new System.Drawing.Point(12, 86);
            this.UserStatistics.Name = "UserStatistics";
            this.UserStatistics.ReadOnly = true;
            this.UserStatistics.RowTemplate.Height = 24;
            this.UserStatistics.Size = new System.Drawing.Size(641, 150);
            this.UserStatistics.TabIndex = 3;
            // 
            // testResultsDataSet
            // 
            this.testResultsDataSet.DataSetName = "TestResultsDataSet";
            this.testResultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testResultsBindingSource
            // 
            this.testResultsBindingSource.DataMember = "TestResults";
            this.testResultsBindingSource.DataSource = this.testResultsDataSet;
            // 
            // testResultsTableAdapter
            // 
            this.testResultsTableAdapter.ClearBeforeFill = true;
            // 
            // UserStatisticsLabel
            // 
            this.UserStatisticsLabel.AutoSize = true;
            this.UserStatisticsLabel.Location = new System.Drawing.Point(16, 63);
            this.UserStatisticsLabel.Name = "UserStatisticsLabel";
            this.UserStatisticsLabel.Size = new System.Drawing.Size(117, 23);
            this.UserStatisticsLabel.TabIndex = 4;
            this.UserStatisticsLabel.Text = "User statistics:";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctAnswersCountDataGridViewTextBoxColumn
            // 
            this.correctAnswersCountDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswersCount";
            this.correctAnswersCountDataGridViewTextBoxColumn.HeaderText = "Correct";
            this.correctAnswersCountDataGridViewTextBoxColumn.Name = "correctAnswersCountDataGridViewTextBoxColumn";
            this.correctAnswersCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incorrectAnswersCountDataGridViewTextBoxColumn
            // 
            this.incorrectAnswersCountDataGridViewTextBoxColumn.DataPropertyName = "IncorrectAnswersCount";
            this.incorrectAnswersCountDataGridViewTextBoxColumn.HeaderText = "Incorrect";
            this.incorrectAnswersCountDataGridViewTextBoxColumn.Name = "incorrectAnswersCountDataGridViewTextBoxColumn";
            this.incorrectAnswersCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // missedAnswersCountDataGridViewTextBoxColumn
            // 
            this.missedAnswersCountDataGridViewTextBoxColumn.DataPropertyName = "MissedAnswersCount";
            this.missedAnswersCountDataGridViewTextBoxColumn.HeaderText = "Missed";
            this.missedAnswersCountDataGridViewTextBoxColumn.Name = "missedAnswersCountDataGridViewTextBoxColumn";
            this.missedAnswersCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 311);
            this.Controls.Add(this.UserStatisticsLabel);
            this.Controls.Add(this.UserStatistics);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DataGridView UserStatistics;
        private TestResultsDataSet testResultsDataSet;
        private System.Windows.Forms.BindingSource testResultsBindingSource;
        private TestResultsDataSetTableAdapters.TestResultsTableAdapter testResultsTableAdapter;
        private System.Windows.Forms.Label UserStatisticsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswersCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorrectAnswersCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missedAnswersCountDataGridViewTextBoxColumn;
    }
}

