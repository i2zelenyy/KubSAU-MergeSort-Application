namespace MergeSort
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.About_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Exit_Picture = new System.Windows.Forms.PictureBox();
            this.Start_Picture = new System.Windows.Forms.PictureBox();
            this.About_Picture = new System.Windows.Forms.PictureBox();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.MergeSort_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.About_Picture)).BeginInit();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // About_Button
            // 
            this.About_Button.BackColor = System.Drawing.Color.LightBlue;
            this.About_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About_Button.Location = new System.Drawing.Point(85, 106);
            this.About_Button.Name = "About_Button";
            this.About_Button.Size = new System.Drawing.Size(169, 60);
            this.About_Button.TabIndex = 1;
            this.About_Button.Text = "About";
            this.About_Button.UseVisualStyleBackColor = false;
            this.About_Button.Click += new System.EventHandler(this.About_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Button.Location = new System.Drawing.Point(85, 19);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(169, 60);
            this.Start_Button.TabIndex = 5;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.Location = new System.Drawing.Point(85, 193);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(169, 60);
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MainPanel.Controls.Add(this.Exit_Picture);
            this.MainPanel.Controls.Add(this.Exit_Button);
            this.MainPanel.Controls.Add(this.Start_Picture);
            this.MainPanel.Controls.Add(this.Start_Button);
            this.MainPanel.Controls.Add(this.About_Picture);
            this.MainPanel.Controls.Add(this.About_Button);
            this.MainPanel.Location = new System.Drawing.Point(12, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(276, 272);
            this.MainPanel.TabIndex = 9;
            // 
            // Exit_Picture
            // 
            this.Exit_Picture.Image = global::MergeSort.Properties.Resources.ExitButton;
            this.Exit_Picture.Location = new System.Drawing.Point(23, 193);
            this.Exit_Picture.Name = "Exit_Picture";
            this.Exit_Picture.Size = new System.Drawing.Size(56, 60);
            this.Exit_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_Picture.TabIndex = 8;
            this.Exit_Picture.TabStop = false;
            // 
            // Start_Picture
            // 
            this.Start_Picture.Image = global::MergeSort.Properties.Resources.StartButton;
            this.Start_Picture.Location = new System.Drawing.Point(23, 19);
            this.Start_Picture.Name = "Start_Picture";
            this.Start_Picture.Size = new System.Drawing.Size(56, 60);
            this.Start_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Start_Picture.TabIndex = 6;
            this.Start_Picture.TabStop = false;
            this.Start_Picture.Click += new System.EventHandler(this.Start_Picture_Click);
            // 
            // About_Picture
            // 
            this.About_Picture.Image = global::MergeSort.Properties.Resources.AboutButton;
            this.About_Picture.Location = new System.Drawing.Point(23, 106);
            this.About_Picture.Name = "About_Picture";
            this.About_Picture.Size = new System.Drawing.Size(56, 60);
            this.About_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.About_Picture.TabIndex = 4;
            this.About_Picture.TabStop = false;
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
            this.UpperPanel.Size = new System.Drawing.Size(300, 34);
            this.UpperPanel.TabIndex = 10;
            this.UpperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseDown);
            this.UpperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperPanel_MouseMove);
            // 
            // MergeSort_label
            // 
            this.MergeSort_label.AutoSize = true;
            this.MergeSort_label.Cursor = System.Windows.Forms.Cursors.SizeAll;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(130)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(300, 324);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Sort";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.About_Picture)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button About_Button;
        private System.Windows.Forms.PictureBox About_Picture;
        private System.Windows.Forms.PictureBox Start_Picture;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.PictureBox Exit_Picture;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MergeSort_label;
    }
}

