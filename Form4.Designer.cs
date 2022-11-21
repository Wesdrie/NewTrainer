namespace LibraryTrainer
{
    partial class WindowCall
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
            this.SplitCall = new System.Windows.Forms.SplitContainer();
            this.TextWords = new System.Windows.Forms.Label();
            this.TextInstructions = new System.Windows.Forms.Label();
            this.ButtonComplete = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ComboCalls = new System.Windows.Forms.ComboBox();
            this.LabelSelectedCall = new System.Windows.Forms.Label();
            this.TextSelectedCall = new System.Windows.Forms.Label();
            this.TextMatch = new System.Windows.Forms.Label();
            this.LabelMatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitCall)).BeginInit();
            this.SplitCall.Panel1.SuspendLayout();
            this.SplitCall.Panel2.SuspendLayout();
            this.SplitCall.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitCall
            // 
            this.SplitCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitCall.Location = new System.Drawing.Point(0, 0);
            this.SplitCall.Name = "SplitCall";
            // 
            // SplitCall.Panel1
            // 
            this.SplitCall.Panel1.Controls.Add(this.TextWords);
            this.SplitCall.Panel1.Controls.Add(this.TextInstructions);
            this.SplitCall.Panel1.Controls.Add(this.ButtonComplete);
            this.SplitCall.Panel1.Controls.Add(this.ButtonBack);
            this.SplitCall.Panel1.Controls.Add(this.ButtonReset);
            // 
            // SplitCall.Panel2
            // 
            this.SplitCall.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SplitCall.Panel2.Controls.Add(this.TextMatch);
            this.SplitCall.Panel2.Controls.Add(this.LabelMatch);
            this.SplitCall.Panel2.Controls.Add(this.TextSelectedCall);
            this.SplitCall.Panel2.Controls.Add(this.LabelSelectedCall);
            this.SplitCall.Panel2.Controls.Add(this.ComboCalls);
            this.SplitCall.Size = new System.Drawing.Size(634, 361);
            this.SplitCall.SplitterDistance = 200;
            this.SplitCall.TabIndex = 0;
            // 
            // TextWords
            // 
            this.TextWords.Location = new System.Drawing.Point(50, 118);
            this.TextWords.Margin = new System.Windows.Forms.Padding(0);
            this.TextWords.Name = "TextWords";
            this.TextWords.Size = new System.Drawing.Size(100, 139);
            this.TextWords.TabIndex = 4;
            this.TextWords.Text = "\" \"";
            this.TextWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextInstructions
            // 
            this.TextInstructions.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextInstructions.Location = new System.Drawing.Point(50, 103);
            this.TextInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.TextInstructions.Name = "TextInstructions";
            this.TextInstructions.Size = new System.Drawing.Size(100, 19);
            this.TextInstructions.TabIndex = 5;
            this.TextInstructions.Text = "Instructions";
            this.TextInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonComplete
            // 
            this.ButtonComplete.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonComplete.FlatAppearance.BorderSize = 0;
            this.ButtonComplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
            this.ButtonComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonComplete.Location = new System.Drawing.Point(0, 45);
            this.ButtonComplete.Name = "ButtonComplete";
            this.ButtonComplete.Size = new System.Drawing.Size(200, 45);
            this.ButtonComplete.TabIndex = 1;
            this.ButtonComplete.Text = "Complete";
            this.ButtonComplete.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Location = new System.Drawing.Point(0, 316);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 45);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonReset.FlatAppearance.BorderSize = 0;
            this.ButtonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
            this.ButtonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReset.Location = new System.Drawing.Point(0, 0);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(200, 45);
            this.ButtonReset.TabIndex = 3;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            // 
            // ComboCalls
            // 
            this.ComboCalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ComboCalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCalls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ComboCalls.FormattingEnabled = true;
            this.ComboCalls.Location = new System.Drawing.Point(124, 136);
            this.ComboCalls.Margin = new System.Windows.Forms.Padding(0);
            this.ComboCalls.Name = "ComboCalls";
            this.ComboCalls.Size = new System.Drawing.Size(186, 25);
            this.ComboCalls.TabIndex = 5;
            // 
            // LabelSelectedCall
            // 
            this.LabelSelectedCall.AutoSize = true;
            this.LabelSelectedCall.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.LabelSelectedCall.Location = new System.Drawing.Point(124, 14);
            this.LabelSelectedCall.Name = "LabelSelectedCall";
            this.LabelSelectedCall.Size = new System.Drawing.Size(186, 21);
            this.LabelSelectedCall.TabIndex = 6;
            this.LabelSelectedCall.Text = "3rd Level Call Description";
            // 
            // TextSelectedCall
            // 
            this.TextSelectedCall.Location = new System.Drawing.Point(124, 45);
            this.TextSelectedCall.Name = "TextSelectedCall";
            this.TextSelectedCall.Size = new System.Drawing.Size(186, 19);
            this.TextSelectedCall.TabIndex = 7;
            this.TextSelectedCall.Text = "Call Description";
            this.TextSelectedCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextMatch
            // 
            this.TextMatch.Location = new System.Drawing.Point(122, 106);
            this.TextMatch.Name = "TextMatch";
            this.TextMatch.Size = new System.Drawing.Size(186, 19);
            this.TextMatch.TabIndex = 9;
            this.TextMatch.Text = "Call Level To Match";
            this.TextMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMatch
            // 
            this.LabelMatch.AutoSize = true;
            this.LabelMatch.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.LabelMatch.Location = new System.Drawing.Point(122, 75);
            this.LabelMatch.Name = "LabelMatch";
            this.LabelMatch.Size = new System.Drawing.Size(185, 21);
            this.LabelMatch.TabIndex = 8;
            this.LabelMatch.Text = "Match To Displayed Level\r\n";
            // 
            // WindowCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.SplitCall);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Numbers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowCall_FormClosing);
            this.Load += new System.EventHandler(this.WindowCall_Load);
            this.SplitCall.Panel1.ResumeLayout(false);
            this.SplitCall.Panel2.ResumeLayout(false);
            this.SplitCall.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitCall)).EndInit();
            this.SplitCall.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitCall;
        private System.Windows.Forms.Button ButtonComplete;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label TextWords;
        private System.Windows.Forms.Label TextInstructions;
        private System.Windows.Forms.ComboBox ComboCalls;
        private System.Windows.Forms.Label LabelSelectedCall;
        private System.Windows.Forms.Label TextSelectedCall;
        private System.Windows.Forms.Label TextMatch;
        private System.Windows.Forms.Label LabelMatch;
    }
}