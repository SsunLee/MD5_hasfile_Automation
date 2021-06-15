
namespace MD5_Hash_Auto
{
    partial class Main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_exe = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lst_files = new System.Windows.Forms.ListBox();
            this.rtxt_result = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exe
            // 
            this.btn_exe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exe.Font = new System.Drawing.Font("IBM Plex Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exe.Location = new System.Drawing.Point(517, 39);
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(84, 51);
            this.btn_exe.TabIndex = 1;
            this.btn_exe.Text = "Execute";
            this.btn_exe.UseVisualStyleBackColor = true;
            // 
            // btn_init
            // 
            this.btn_init.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_init.Font = new System.Drawing.Font("IBM Plex Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_init.Location = new System.Drawing.Point(517, 97);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(84, 48);
            this.btn_init.TabIndex = 1;
            this.btn_init.Text = "Delete\r\nAll item";
            this.btn_init.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IBM Plex Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "※ Please Drag && Drop here the files for execute a MD5 Hash";
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("IBM Plex Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(517, 166);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 26);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // lst_files
            // 
            this.lst_files.AllowDrop = true;
            this.lst_files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_files.Font = new System.Drawing.Font("IBM Plex Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_files.FormattingEnabled = true;
            this.lst_files.ItemHeight = 17;
            this.lst_files.Location = new System.Drawing.Point(12, 39);
            this.lst_files.Name = "lst_files";
            this.lst_files.Size = new System.Drawing.Size(497, 104);
            this.lst_files.TabIndex = 5;
            this.lst_files.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_files_KeyDown);
            // 
            // rtxt_result
            // 
            this.rtxt_result.BackColor = System.Drawing.Color.Black;
            this.rtxt_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_result.Font = new System.Drawing.Font("IBM Plex Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxt_result.ForeColor = System.Drawing.Color.White;
            this.rtxt_result.Location = new System.Drawing.Point(12, 166);
            this.rtxt_result.Name = "rtxt_result";
            this.rtxt_result.Size = new System.Drawing.Size(497, 264);
            this.rtxt_result.TabIndex = 6;
            this.rtxt_result.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IBM Plex Sans KR Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Developer by lee.sunbae";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 442);
            this.Controls.Add(this.rtxt_result);
            this.Controls.Add(this.lst_files);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_exe);
            this.Font = new System.Drawing.Font("IBM Plex Sans KR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main_form";
            this.Text = "CheckSum Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exe;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListBox lst_files;
        private System.Windows.Forms.RichTextBox rtxt_result;
        private System.Windows.Forms.Label label2;
    }
}

