namespace DMOFileMerge
{
    partial class Form1
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
            this.Export = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.outputFileLocation_btn = new System.Windows.Forms.Button();
            this.outputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(264, 12);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 0;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(345, 13);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(75, 23);
            this.Preview.TabIndex = 1;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            this.Preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 433);
            this.listBox1.TabIndex = 2;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(12, 482);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(25, 25);
            this.upButton.TabIndex = 3;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(38, 482);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(25, 25);
            this.downButton.TabIndex = 4;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(345, 483);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // outputFileLocation_btn
            // 
            this.outputFileLocation_btn.Location = new System.Drawing.Point(148, 12);
            this.outputFileLocation_btn.Name = "outputFileLocation_btn";
            this.outputFileLocation_btn.Size = new System.Drawing.Size(110, 23);
            this.outputFileLocation_btn.TabIndex = 6;
            this.outputFileLocation_btn.Text = "Output File Location";
            this.outputFileLocation_btn.UseVisualStyleBackColor = true;
            this.outputFileLocation_btn.Click += new System.EventHandler(this.outputFileLocation_btn_Click);
            // 
            // outputFileNameTextBox
            // 
            this.outputFileNameTextBox.Location = new System.Drawing.Point(13, 13);
            this.outputFileNameTextBox.Name = "outputFileNameTextBox";
            this.outputFileNameTextBox.Size = new System.Drawing.Size(129, 20);
            this.outputFileNameTextBox.TabIndex = 7;
            this.outputFileNameTextBox.Text = "Output File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.outputFileNameTextBox);
            this.Controls.Add(this.outputFileLocation_btn);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.Export);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DMO Text File Merger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Preview;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button outputFileLocation_btn;
        private System.Windows.Forms.TextBox outputFileNameTextBox;
    }
}

