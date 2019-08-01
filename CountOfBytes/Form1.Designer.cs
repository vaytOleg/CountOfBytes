namespace CountOfBytes
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
            this.bt_folder = new System.Windows.Forms.Button();
            this.lb_path = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_folder
            // 
            this.bt_folder.Location = new System.Drawing.Point(12, 12);
            this.bt_folder.Name = "bt_folder";
            this.bt_folder.Size = new System.Drawing.Size(75, 23);
            this.bt_folder.TabIndex = 0;
            this.bt_folder.Text = "Folder";
            this.bt_folder.UseVisualStyleBackColor = true;
            this.bt_folder.Click += new System.EventHandler(this.bt_folder_Click);
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(93, 17);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(29, 13);
            this.lb_path.TabIndex = 1;
            this.lb_path.Text = "Path";
            // 
            // lb_result
            // 
            this.lb_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.Location = new System.Drawing.Point(12, 79);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(260, 329);
            this.lb_result.TabIndex = 2;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(12, 41);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 4;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.bt_folder);
            this.Name = "Form1";
            this.Text = "Count Of Bytes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_folder;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.Button bt_start;
    }
}

