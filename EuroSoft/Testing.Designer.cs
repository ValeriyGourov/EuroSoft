namespace EuroSoft
{
    partial class Testing
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
            this.Title = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Answer = new System.Windows.Forms.Button();
            this.Decision = new System.Windows.Forms.TextBox();
            this.DecisionLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Answers = new System.Windows.Forms.FlowLayoutPanel();
            this.Abort = new System.Windows.Forms.Button();
            this.QuestionPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.QuestionPageBindingSource, "Title", true));
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(693, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Image
            // 
            this.Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Image.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.QuestionPageBindingSource, "Image", true));
            this.Image.Location = new System.Drawing.Point(12, 48);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(693, 197);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 1;
            this.Image.TabStop = false;
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Answer.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.QuestionPageBindingSource, "AnswerIsNotGiven", true));
            this.Answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer.Location = new System.Drawing.Point(12, 612);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(140, 32);
            this.Answer.TabIndex = 3;
            this.Answer.Text = "Answer";
            this.Answer.UseVisualStyleBackColor = false;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // Decision
            // 
            this.Decision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decision.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.QuestionPageBindingSource, "Decision", true));
            this.Decision.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.QuestionPageBindingSource, "AnswerIsGiven", true));
            this.Decision.Location = new System.Drawing.Point(12, 489);
            this.Decision.Multiline = true;
            this.Decision.Name = "Decision";
            this.Decision.ReadOnly = true;
            this.Decision.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Decision.Size = new System.Drawing.Size(693, 81);
            this.Decision.TabIndex = 4;
            // 
            // DecisionLabel
            // 
            this.DecisionLabel.AutoSize = true;
            this.DecisionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.QuestionPageBindingSource, "AnswerIsGiven", true));
            this.DecisionLabel.Location = new System.Drawing.Point(8, 463);
            this.DecisionLabel.Name = "DecisionLabel";
            this.DecisionLabel.Size = new System.Drawing.Size(78, 23);
            this.DecisionLabel.TabIndex = 5;
            this.DecisionLabel.Text = "Decision:";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.QuestionPageBindingSource, "Description", true));
            this.Description.Location = new System.Drawing.Point(12, 251);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description.Size = new System.Drawing.Size(693, 81);
            this.Description.TabIndex = 4;
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.BackColor = System.Drawing.Color.Gold;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(280, 612);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(140, 32);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Answers
            // 
            this.Answers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Answers.AutoScroll = true;
            this.Answers.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.QuestionPageBindingSource, "AnswerIsNotGiven", true));
            this.Answers.Location = new System.Drawing.Point(12, 338);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(693, 103);
            this.Answers.TabIndex = 8;
            // 
            // Abort
            // 
            this.Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Abort.BackColor = System.Drawing.Color.Crimson;
            this.Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abort.Location = new System.Drawing.Point(565, 612);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(140, 32);
            this.Abort.TabIndex = 9;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = false;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // QuestionPageBindingSource
            // 
            this.QuestionPageBindingSource.DataSource = typeof(EuroSoft.Models.QuestionPage);
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 658);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.DecisionLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Decision);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Testing";
            this.Text = "Testing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Testing_FormClosing);
            this.Load += new System.EventHandler(this.Testing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource QuestionPageBindingSource;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.TextBox Decision;
        private System.Windows.Forms.Label DecisionLabel;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.FlowLayoutPanel Answers;
        private System.Windows.Forms.Button Abort;
    }
}