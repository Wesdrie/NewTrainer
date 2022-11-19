namespace LibraryTrainer
{
    partial class WindowSort
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
            this.SplitSort = new System.Windows.Forms.SplitContainer();
            this.ButtonComplete = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.TextWords = new System.Windows.Forms.Label();
            this.TextInstructions = new System.Windows.Forms.Label();
            this.ListSort = new System.Windows.Forms.ListBox();
            this.TextScore = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.TextTime = new System.Windows.Forms.Label();
            this.LabelBeat = new System.Windows.Forms.Label();
            this.TextBeat = new System.Windows.Forms.Label();
            this.TimerSort = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplitSort)).BeginInit();
            this.SplitSort.Panel1.SuspendLayout();
            this.SplitSort.Panel2.SuspendLayout();
            this.SplitSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitSort
            // 
            this.SplitSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitSort.Location = new System.Drawing.Point(0, 0);
            this.SplitSort.Margin = new System.Windows.Forms.Padding(0);
            this.SplitSort.Name = "SplitSort";
            // 
            // SplitSort.Panel1
            // 
            this.SplitSort.Panel1.Controls.Add(this.TextWords);
            this.SplitSort.Panel1.Controls.Add(this.TextInstructions);
            this.SplitSort.Panel1.Controls.Add(this.ButtonComplete);
            this.SplitSort.Panel1.Controls.Add(this.ButtonReset);
            this.SplitSort.Panel1.Controls.Add(this.ButtonBack);
            // 
            // SplitSort.Panel2
            // 
            this.SplitSort.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SplitSort.Panel2.Controls.Add(this.ListSort);
            this.SplitSort.Panel2.Controls.Add(this.TextScore);
            this.SplitSort.Panel2.Controls.Add(this.LabelScore);
            this.SplitSort.Panel2.Controls.Add(this.LabelTime);
            this.SplitSort.Panel2.Controls.Add(this.TextTime);
            this.SplitSort.Panel2.Controls.Add(this.LabelBeat);
            this.SplitSort.Panel2.Controls.Add(this.TextBeat);
            this.SplitSort.Size = new System.Drawing.Size(634, 361);
            this.SplitSort.SplitterDistance = 200;
            this.SplitSort.SplitterWidth = 1;
            this.SplitSort.TabIndex = 0;
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
            // TextWords
            // 
            this.TextWords.Location = new System.Drawing.Point(50, 130);
            this.TextWords.Margin = new System.Windows.Forms.Padding(0);
            this.TextWords.Name = "TextWords";
            this.TextWords.Size = new System.Drawing.Size(100, 139);
            this.TextWords.TabIndex = 0;
            this.TextWords.Text = "\"Drag \'n Drop! Sort The Displayed List Of Dewey Decimal Items In Acsending Order!" +
    "\"";
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
            // ListSort
            // 
            this.ListSort.AllowDrop = true;
            this.ListSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ListSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ListSort.FormattingEnabled = true;
            this.ListSort.ItemHeight = 17;
            this.ListSort.Location = new System.Drawing.Point(150, 30);
            this.ListSort.Margin = new System.Windows.Forms.Padding(0);
            this.ListSort.Name = "ListSort";
            this.ListSort.Size = new System.Drawing.Size(120, 289);
            this.ListSort.TabIndex = 0;
            this.ListSort.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListSort_DragDrop);
            this.ListSort.DragOver += new System.Windows.Forms.DragEventHandler(this.ListSort_DragOver);
            this.ListSort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListSort_MouseDown);
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
            // TimerSort
            // 
            this.TimerSort.Interval = 1000;
            this.TimerSort.Tick += new System.EventHandler(this.TimerSort_Tick);
            // 
            // WindowSort
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.SplitSort);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowSort_FormClosing);
            this.Load += new System.EventHandler(this.WindowSort_Load);
            this.SplitSort.Panel1.ResumeLayout(false);
            this.SplitSort.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitSort)).EndInit();
            this.SplitSort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitSort;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonComplete;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label TextScore;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label TextTime;
        private System.Windows.Forms.Label LabelBeat;
        private System.Windows.Forms.Label TextBeat;
        private System.Windows.Forms.ListBox ListSort;
        private System.Windows.Forms.Timer TimerSort;
        private System.Windows.Forms.Label TextInstructions;
        private System.Windows.Forms.Label TextWords;
    }
}