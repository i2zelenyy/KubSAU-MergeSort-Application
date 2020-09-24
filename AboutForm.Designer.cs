namespace MergeSort
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UpperPanel_1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MergeSort_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpperPanel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 189);
            this.label1.TabIndex = 33;
            this.label1.Text = "_____________\r\nCourse Paper\r\n\r\nMerge Sort\r\nDivide and Conquer method\r\n\r\nMade by I" +
    "van Zelenyy \r\n_____________\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Back_Button.FlatAppearance.BorderSize = 0;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Back_Button.Image = global::MergeSort.Properties.Resources.Arrow_Back;
            this.Back_Button.Location = new System.Drawing.Point(3, 3);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(72, 67);
            this.Back_Button.TabIndex = 34;
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitButton.BackgroundImage = global::MergeSort.Properties.Resources.ExitCross;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(236, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(72, 67);
            this.ExitButton.TabIndex = 35;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // UpperPanel_1
            // 
            this.UpperPanel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(130)))), ((int)(((byte)(211)))));
            this.UpperPanel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperPanel_1.Controls.Add(this.pictureBox1);
            this.UpperPanel_1.Controls.Add(this.MergeSort_label);
            this.UpperPanel_1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.UpperPanel_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel_1.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel_1.Name = "UpperPanel_1";
            this.UpperPanel_1.Size = new System.Drawing.Size(335, 33);
            this.UpperPanel_1.TabIndex = 36;
            this.UpperPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.UpperPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(130)))), ((int)(((byte)(211)))));
            this.pictureBox1.BackgroundImage = global::MergeSort.Properties.Resources.Merge_Sort;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MergeSort_label
            // 
            this.MergeSort_label.AutoSize = true;
            this.MergeSort_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MergeSort_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MergeSort_label.Location = new System.Drawing.Point(36, 8);
            this.MergeSort_label.Name = "MergeSort_label";
            this.MergeSort_label.Size = new System.Drawing.Size(103, 23);
            this.MergeSort_label.TabIndex = 2;
            this.MergeSort_label.Text = "Merge Sort";
            this.MergeSort_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MergeSort_label_MouseDown);
            this.MergeSort_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MergeSort_label_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Back_Button);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 303);
            this.panel1.TabIndex = 37;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(130)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(335, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpperPanel_1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Sort";
            this.UpperPanel_1.ResumeLayout(false);
            this.UpperPanel_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel UpperPanel_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MergeSort_label;
        private System.Windows.Forms.Panel panel1;
    }
}