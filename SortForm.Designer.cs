namespace MergeSort
{
    partial class SortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortForm));
            this.LowerLabel = new System.Windows.Forms.Label();
            this.Grid_2 = new System.Windows.Forms.DataGridView();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.Grid_1 = new System.Windows.Forms.DataGridView();
            this.UpperLabel = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.MergeSort_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Help_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_1)).BeginInit();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LowerLabel
            // 
            this.LowerLabel.AutoSize = true;
            this.LowerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LowerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowerLabel.Location = new System.Drawing.Point(256, 211);
            this.LowerLabel.Name = "LowerLabel";
            this.LowerLabel.Size = new System.Drawing.Size(156, 25);
            this.LowerLabel.TabIndex = 28;
            this.LowerLabel.Text = "Your sorted array";
            // 
            // Grid_2
            // 
            this.Grid_2.AllowUserToDeleteRows = false;
            this.Grid_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_2.BackgroundColor = System.Drawing.Color.LightBlue;
            this.Grid_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_2.ColumnHeadersVisible = false;
            this.Grid_2.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grid_2.Location = new System.Drawing.Point(140, 239);
            this.Grid_2.Name = "Grid_2";
            this.Grid_2.ReadOnly = true;
            this.Grid_2.RowHeadersVisible = false;
            this.Grid_2.Size = new System.Drawing.Size(393, 51);
            this.Grid_2.TabIndex = 27;
            // 
            // Sort_Button
            // 
            this.Sort_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Sort_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sort_Button.Enabled = false;
            this.Sort_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_Button.Location = new System.Drawing.Point(13, 197);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(116, 93);
            this.Sort_Button.TabIndex = 26;
            this.Sort_Button.Text = "Sort";
            this.Sort_Button.UseVisualStyleBackColor = false;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // Grid_1
            // 
            this.Grid_1.AllowUserToDeleteRows = false;
            this.Grid_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.Grid_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_1.ColumnHeadersVisible = false;
            this.Grid_1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grid_1.Location = new System.Drawing.Point(140, 157);
            this.Grid_1.Name = "Grid_1";
            this.Grid_1.ReadOnly = true;
            this.Grid_1.RowHeadersVisible = false;
            this.Grid_1.Size = new System.Drawing.Size(393, 51);
            this.Grid_1.TabIndex = 25;
            // 
            // UpperLabel
            // 
            this.UpperLabel.AutoSize = true;
            this.UpperLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpperLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpperLabel.Location = new System.Drawing.Point(244, 92);
            this.UpperLabel.Name = "UpperLabel";
            this.UpperLabel.Size = new System.Drawing.Size(168, 25);
            this.UpperLabel.TabIndex = 24;
            this.UpperLabel.Text = "Your entered array\r\n";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1.Location = new System.Drawing.Point(141, 120);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(393, 25);
            this.TextBox1.TabIndex = 23;
            // 
            // Edit_Button
            // 
            this.Edit_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Edit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Button.Location = new System.Drawing.Point(13, 92);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(116, 93);
            this.Edit_Button.TabIndex = 22;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = false;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(130)))), ((int)(((byte)(211)))));
            this.UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperPanel.Controls.Add(this.MergeSort_label);
            this.UpperPanel.Controls.Add(this.pictureBox1);
            this.UpperPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(579, 34);
            this.UpperPanel.TabIndex = 29;
            this.UpperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseDown);
            this.UpperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseMove);
            // 
            // MergeSort_label
            // 
            this.MergeSort_label.AutoSize = true;
            this.MergeSort_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MergeSort_label.Location = new System.Drawing.Point(31, 3);
            this.MergeSort_label.Name = "MergeSort_label";
            this.MergeSort_label.Size = new System.Drawing.Size(103, 23);
            this.MergeSort_label.TabIndex = 2;
            this.MergeSort_label.Text = "Merge Sort";
            this.MergeSort_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MergeSort_label_MouseDown);
            this.MergeSort_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MergeSort_label_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(130)))), ((int)(((byte)(211)))));
            this.pictureBox1.BackgroundImage = global::MergeSort.Properties.Resources.Merge_Sort;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MainPanel.Controls.Add(this.Exit_Button);
            this.MainPanel.Controls.Add(this.Help_Button);
            this.MainPanel.Controls.Add(this.UpperLabel);
            this.MainPanel.Controls.Add(this.Edit_Button);
            this.MainPanel.Controls.Add(this.Back_Button);
            this.MainPanel.Controls.Add(this.Sort_Button);
            this.MainPanel.Controls.Add(this.Grid_2);
            this.MainPanel.Controls.Add(this.LowerLabel);
            this.MainPanel.Controls.Add(this.TextBox1);
            this.MainPanel.Controls.Add(this.Grid_1);
            this.MainPanel.Location = new System.Drawing.Point(12, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(555, 311);
            this.MainPanel.TabIndex = 30;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit_Button.BackgroundImage = global::MergeSort.Properties.Resources.ExitCross;
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit_Button.Location = new System.Drawing.Point(480, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(72, 67);
            this.Exit_Button.TabIndex = 36;
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Help_Button
            // 
            this.Help_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Help_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Help_Button.BackgroundImage = global::MergeSort.Properties.Resources.Help_Button;
            this.Help_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Help_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help_Button.FlatAppearance.BorderSize = 0;
            this.Help_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Help_Button.Location = new System.Drawing.Point(249, 3);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(72, 67);
            this.Help_Button.TabIndex = 37;
            this.Help_Button.UseVisualStyleBackColor = false;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_Button.FlatAppearance.BorderSize = 0;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Back_Button.Image = global::MergeSort.Properties.Resources.Arrow_Back;
            this.Back_Button.Location = new System.Drawing.Point(3, 3);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(72, 67);
            this.Back_Button.TabIndex = 35;
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(130)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(579, 365);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Sort";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_1)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LowerLabel;
        private System.Windows.Forms.DataGridView Grid_2;
        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.DataGridView Grid_1;
        private System.Windows.Forms.Label UpperLabel;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label MergeSort_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Help_Button;
    }
}