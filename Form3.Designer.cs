namespace LibraryTrainer
{
    partial class WindowAreas
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
            this.SplitAreas = new System.Windows.Forms.SplitContainer();
            this.TextWords = new System.Windows.Forms.Label();
            this.TextInstructions = new System.Windows.Forms.Label();
            this.ButtonComplete = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ListNumbers = new System.Windows.Forms.ListBox();
            this.ListText = new System.Windows.Forms.ListBox();
            this.TextScore = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.TextTime = new System.Windows.Forms.Label();
            this.LabelBeat = new System.Windows.Forms.Label();
            this.TextBeat = new System.Windows.Forms.Label();
            this.TimerAreas = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplitAreas)).BeginInit();
            this.SplitAreas.Panel1.SuspendLayout();
            this.SplitAreas.Panel2.SuspendLayout();
            this.SplitAreas.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitAreas
            // 
            this.SplitAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitAreas.Location = new System.Drawing.Point(0, 0);
            this.SplitAreas.Margin = new System.Windows.Forms.Padding(0);
            this.SplitAreas.Name = "SplitAreas";
            // 
            // SplitAreas.Panel1
            // 
            this.SplitAreas.Panel1.Controls.Add(this.TextWords);
            this.SplitAreas.Panel1.Controls.Add(this.TextInstructions);
            this.SplitAreas.Panel1.Controls.Add(this.ButtonComplete);
            this.SplitAreas.Panel1.Controls.Add(this.ButtonBack);
            this.SplitAreas.Panel1.Controls.Add(this.ButtonReset);
            // 
            // SplitAreas.Panel2
            // 
            this.SplitAreas.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SplitAreas.Panel2.Controls.Add(this.ListNumbers);
            this.SplitAreas.Panel2.Controls.Add(this.ListText);
            this.SplitAreas.Panel2.Controls.Add(this.TextScore);
            this.SplitAreas.Panel2.Controls.Add(this.LabelScore);
            this.SplitAreas.Panel2.Controls.Add(this.LabelTime);
            this.SplitAreas.Panel2.Controls.Add(this.TextTime);
            this.SplitAreas.Panel2.Controls.Add(this.LabelBeat);
            this.SplitAreas.Panel2.Controls.Add(this.TextBeat);
            this.SplitAreas.Size = new System.Drawing.Size(634, 361);
            this.SplitAreas.SplitterDistance = 200;
            this.SplitAreas.SplitterWidth = 1;
            this.SplitAreas.TabIndex = 0;
            // 
            // TextWords
            // 
            this.TextWords.Location = new System.Drawing.Point(50, 130);
            this.TextWords.Margin = new System.Windows.Forms.Padding(0);
            this.TextWords.Name = "TextWords";
            this.TextWords.Size = new System.Drawing.Size(100, 139);
            this.TextWords.TabIndex = 0;
            this.TextWords.Text = "\"Drag \'n Drop! Match The Values In The Right Column To The Values In The Left Col" +
    "umn!\"";
            this.TextWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextInstructions
            // 
            this.TextInstructions.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextInstructions.Location = new System.Drawing.Point(50, 115);
            this.TextInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.TextInstructions.Name = "TextInstructions";
            this.TextInstructions.Size = new System.Drawing.Size(100, 19);
            this.TextInstructions.TabIndex = 0;
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
            this.ButtonComplete.TabIndex = 0;
            this.ButtonComplete.Text = "Complete";
            this.ButtonComplete.UseVisualStyleBackColor = true;
            this.ButtonComplete.Click += new System.EventHandler(this.ButtonComplete_Click);
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
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
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
            this.ButtonReset.TabIndex = 0;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ListNumbers
            // 
            this.ListNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ListNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ListNumbers.FormattingEnabled = true;
            this.ListNumbers.ItemHeight = 17;
            this.ListNumbers.Location = new System.Drawing.Point(150, 30);
            this.ListNumbers.Margin = new System.Windows.Forms.Padding(0);
            this.ListNumbers.Name = "ListNumbers";
            this.ListNumbers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListNumbers.Size = new System.Drawing.Size(60, 289);
            this.ListNumbers.TabIndex = 0;
            // 
            // ListText
            // 
            this.ListText.AllowDrop = true;
            this.ListText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ListText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ListText.FormattingEnabled = true;
            this.ListText.ItemHeight = 17;
            this.ListText.Location = new System.Drawing.Point(250, 30);
            this.ListText.Margin = new System.Windows.Forms.Padding(0);
            this.ListText.Name = "ListText";
            this.ListText.Size = new System.Drawing.Size(145, 289);
            this.ListText.TabIndex = 0;
            this.ListText.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListText_DragDrop);
            this.ListText.DragOver += new System.Windows.Forms.DragEventHandler(this.ListText_DragOver);
            this.ListText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListText_MouseDown);
            // 
            // TextScore
            // 
            this.TextScore.Location = new System.Drawing.Point(30, 300);
            this.TextScore.Margin = new System.Windows.Forms.Padding(0);
            this.TextScore.Name = "TextScore";
            this.TextScore.Size = new System.Drawing.Size(100, 19);
            this.TextScore.TabIndex = 0;
            this.TextScore.Text = "0";
            this.TextScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelScore
            // 
            this.LabelScore.Location = new System.Drawing.Point(30, 280);
            this.LabelScore.Margin = new System.Windows.Forms.Padding(0);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(100, 19);
            this.LabelScore.TabIndex = 0;
            this.LabelScore.Text = "Current Score";
            this.LabelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTime
            // 
            this.LabelTime.Location = new System.Drawing.Point(30, 150);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(100, 19);
            this.LabelTime.TabIndex = 0;
            this.LabelTime.Text = "Current Time";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextTime
            // 
            this.TextTime.Location = new System.Drawing.Point(30, 170);
            this.TextTime.Margin = new System.Windows.Forms.Padding(0);
            this.TextTime.Name = "TextTime";
            this.TextTime.Size = new System.Drawing.Size(100, 19);
            this.TextTime.TabIndex = 0;
            this.TextTime.Text = "0 Seconds";
            this.TextTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBeat
            // 
            this.LabelBeat.Location = new System.Drawing.Point(30, 30);
            this.LabelBeat.Margin = new System.Windows.Forms.Padding(0);
            this.LabelBeat.Name = "LabelBeat";
            this.LabelBeat.Size = new System.Drawing.Size(100, 19);
            this.LabelBeat.TabIndex = 0;
            this.LabelBeat.Text = "Time-To-Beat";
            this.LabelBeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBeat
            // 
            this.TextBeat.Location = new System.Drawing.Point(30, 50);
            this.TextBeat.Margin = new System.Windows.Forms.Padding(0);
            this.TextBeat.Name = "TextBeat";
            this.TextBeat.Size = new System.Drawing.Size(100, 19);
            this.TextBeat.TabIndex = 0;
            this.TextBeat.Text = "0 Seconds";
            this.TextBeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerAreas
            // 
            this.TimerAreas.Interval = 1000;
            this.TimerAreas.Tick += new System.EventHandler(this.TimerAreas_Tick);
            // 
            // WindowAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.SplitAreas);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identify Areas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowAreas_FormClosing);
            this.Load += new System.EventHandler(this.WindowAreas_Load);
            this.SplitAreas.Panel1.ResumeLayout(false);
            this.SplitAreas.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitAreas)).EndInit();
            this.SplitAreas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitAreas;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonComplete;
        private System.Windows.Forms.Label TextScore;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label TextTime;
        private System.Windows.Forms.Label LabelBeat;
        private System.Windows.Forms.Label TextBeat;
        private System.Windows.Forms.Timer TimerAreas;
        private System.Windows.Forms.Label TextWords;
        private System.Windows.Forms.Label TextInstructions;
        private System.Windows.Forms.ListBox ListText;
        private System.Windows.Forms.ListBox ListNumbers;
    }
}