namespace EuroSoft
{
    partial class TestResultView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.AnswersPercentageRatio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.IncorrectLabel = new System.Windows.Forms.Label();
            this.MissedLabel = new System.Windows.Forms.Label();
            this.AnswersCount = new System.Windows.Forms.GroupBox();
            this.Missed = new System.Windows.Forms.TextBox();
            this.TestResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Incorrect = new System.Windows.Forms.TextBox();
            this.Correct = new System.Windows.Forms.TextBox();
            this.SaveResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersPercentageRatio)).BeginInit();
            this.AnswersCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AnswersPercentageRatio
            // 
            this.AnswersPercentageRatio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswersPercentageRatio.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "MainArea";
            this.AnswersPercentageRatio.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.AnswersPercentageRatio.Legends.Add(legend2);
            this.AnswersPercentageRatio.Location = new System.Drawing.Point(227, 12);
            this.AnswersPercentageRatio.Name = "AnswersPercentageRatio";
            series4.ChartArea = "MainArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series4.Color = System.Drawing.Color.LimeGreen;
            series4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Correct";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series5.ChartArea = "MainArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series5.Color = System.Drawing.Color.OrangeRed;
            series5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Incorrect";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series6.ChartArea = "MainArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series6.Color = System.Drawing.Color.Silver;
            series6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Missed";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.AnswersPercentageRatio.Series.Add(series4);
            this.AnswersPercentageRatio.Series.Add(series5);
            this.AnswersPercentageRatio.Series.Add(series6);
            this.AnswersPercentageRatio.Size = new System.Drawing.Size(492, 141);
            this.AnswersPercentageRatio.TabIndex = 0;
            title2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "AnswersPercentageRatio";
            title2.Text = "Answers percentage ratio";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.AnswersPercentageRatio.Titles.Add(title2);
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.AutoSize = true;
            this.CorrectLabel.Location = new System.Drawing.Point(6, 32);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(70, 23);
            this.CorrectLabel.TabIndex = 1;
            this.CorrectLabel.Text = "Correct:";
            // 
            // IncorrectLabel
            // 
            this.IncorrectLabel.AutoSize = true;
            this.IncorrectLabel.Location = new System.Drawing.Point(6, 68);
            this.IncorrectLabel.Name = "IncorrectLabel";
            this.IncorrectLabel.Size = new System.Drawing.Size(82, 23);
            this.IncorrectLabel.TabIndex = 2;
            this.IncorrectLabel.Text = "Incorrect:";
            // 
            // MissedLabel
            // 
            this.MissedLabel.AutoSize = true;
            this.MissedLabel.Location = new System.Drawing.Point(6, 104);
            this.MissedLabel.Name = "MissedLabel";
            this.MissedLabel.Size = new System.Drawing.Size(66, 23);
            this.MissedLabel.TabIndex = 3;
            this.MissedLabel.Text = "Missed:";
            // 
            // AnswersCount
            // 
            this.AnswersCount.Controls.Add(this.Missed);
            this.AnswersCount.Controls.Add(this.Incorrect);
            this.AnswersCount.Controls.Add(this.Correct);
            this.AnswersCount.Controls.Add(this.IncorrectLabel);
            this.AnswersCount.Controls.Add(this.MissedLabel);
            this.AnswersCount.Controls.Add(this.CorrectLabel);
            this.AnswersCount.Location = new System.Drawing.Point(12, 12);
            this.AnswersCount.Name = "AnswersCount";
            this.AnswersCount.Size = new System.Drawing.Size(209, 141);
            this.AnswersCount.TabIndex = 4;
            this.AnswersCount.TabStop = false;
            this.AnswersCount.Text = "Answers count";
            // 
            // Missed
            // 
            this.Missed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TestResultBindingSource, "MissedAnswersCount", true));
            this.Missed.Location = new System.Drawing.Point(95, 97);
            this.Missed.Name = "Missed";
            this.Missed.ReadOnly = true;
            this.Missed.Size = new System.Drawing.Size(100, 30);
            this.Missed.TabIndex = 6;
            // 
            // TestResultBindingSource
            // 
            this.TestResultBindingSource.DataSource = typeof(EuroSoft.Models.TestResult);
            // 
            // Incorrect
            // 
            this.Incorrect.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TestResultBindingSource, "IncorrectAnswersCount", true));
            this.Incorrect.Location = new System.Drawing.Point(95, 61);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.ReadOnly = true;
            this.Incorrect.Size = new System.Drawing.Size(100, 30);
            this.Incorrect.TabIndex = 5;
            // 
            // Correct
            // 
            this.Correct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TestResultBindingSource, "CorrectAnswersCount", true));
            this.Correct.Location = new System.Drawing.Point(95, 25);
            this.Correct.Name = "Correct";
            this.Correct.ReadOnly = true;
            this.Correct.Size = new System.Drawing.Size(100, 30);
            this.Correct.TabIndex = 4;
            // 
            // SaveResult
            // 
            this.SaveResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveResult.Location = new System.Drawing.Point(12, 181);
            this.SaveResult.Name = "SaveResult";
            this.SaveResult.Size = new System.Drawing.Size(707, 32);
            this.SaveResult.TabIndex = 5;
            this.SaveResult.Text = "Save result";
            this.SaveResult.UseVisualStyleBackColor = true;
            this.SaveResult.Click += new System.EventHandler(this.SaveResult_Click);
            // 
            // TestResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 229);
            this.Controls.Add(this.SaveResult);
            this.Controls.Add(this.AnswersCount);
            this.Controls.Add(this.AnswersPercentageRatio);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestResultView";
            this.Text = "Test result";
            this.Load += new System.EventHandler(this.TestResultView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnswersPercentageRatio)).EndInit();
            this.AnswersCount.ResumeLayout(false);
            this.AnswersCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart AnswersPercentageRatio;
        private System.Windows.Forms.Label CorrectLabel;
        private System.Windows.Forms.Label IncorrectLabel;
        private System.Windows.Forms.Label MissedLabel;
        private System.Windows.Forms.GroupBox AnswersCount;
        private System.Windows.Forms.TextBox Missed;
        private System.Windows.Forms.TextBox Incorrect;
        private System.Windows.Forms.TextBox Correct;
        private System.Windows.Forms.BindingSource TestResultBindingSource;
        private System.Windows.Forms.Button SaveResult;
    }
}