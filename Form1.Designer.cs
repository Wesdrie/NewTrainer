namespace LibraryTrainer
{
    partial class WindowMain
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
            this.SplitMain = new System.Windows.Forms.SplitContainer();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonCall = new System.Windows.Forms.Button();
            this.ButtonArea = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitMain)).BeginInit();
            this.SplitMain.Panel1.SuspendLayout();
            this.SplitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitMain
            // 
            this.SplitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitMain.Location = new System.Drawing.Point(0, 0);
            this.SplitMain.Margin = new System.Windows.Forms.Padding(0);
            this.SplitMain.Name = "SplitMain";
            // 
            // SplitMain.Panel1
            // 
            this.SplitMain.Panel1.Controls.Add(this.ButtonExit);
            this.SplitMain.Panel1.Controls.Add(this.ButtonCall);
            this.SplitMain.Panel1.Controls.Add(this.ButtonArea);
            this.SplitMain.Panel1.Controls.Add(this.ButtonSort);
            // 
            // SplitMain.Panel2
            // 
            this.SplitMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SplitMain.Size = new System.Drawing.Size(634, 361);
            this.SplitMain.SplitterDistance = 200;
            this.SplitMain.SplitterWidth = 1;
            this.SplitMain.TabIndex = 0;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Location = new System.Drawing.Point(0, 316);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(200, 45);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonCall
            // 
            this.ButtonCall.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCall.Enabled = false;
            this.ButtonCall.FlatAppearance.BorderSize = 0;
            this.ButtonCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCall.Location = new System.Drawing.Point(0, 90);
            this.ButtonCall.Name = "ButtonCall";
            this.ButtonCall.Size = new System.Drawing.Size(200, 45);
            this.ButtonCall.TabIndex = 0;
            this.ButtonCall.Text = "Call Numbers";
            this.ButtonCall.UseVisualStyleBackColor = true;
            this.ButtonCall.Click += new System.EventHandler(this.ButtonCall_Click);
            // 
            // ButtonArea
            // 
            this.ButtonArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonArea.FlatAppearance.BorderSize = 0;
            this.ButtonArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
            this.ButtonArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonArea.Location = new System.Drawing.Point(0, 45);
            this.ButtonArea.Name = "ButtonArea";
            this.ButtonArea.Size = new System.Drawing.Size(200, 45);
            this.ButtonArea.TabIndex = 0;
            this.ButtonArea.Text = "Identifying Areas";
            this.ButtonArea.UseVisualStyleBackColor = true;
            this.ButtonArea.Click += new System.EventHandler(this.ButtonArea_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSort.FlatAppearance.BorderSize = 0;
            this.ButtonSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
            this.ButtonSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSort.Location = new System.Drawing.Point(0, 0);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(200, 45);
            this.ButtonSort.TabIndex = 0;
            this.ButtonSort.Text = "Book Sorting";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // WindowMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.SplitMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Trainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowMain_FormClosing);
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.SplitMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitMain)).EndInit();
            this.SplitMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitMain;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonCall;
        private System.Windows.Forms.Button ButtonArea;
    }
}

