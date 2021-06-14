
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
            this.SuspendLayout();
            // 
            // btn_exe
            // 
            this.btn_exe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exe.Location = new System.Drawing.Point(517, 34);
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(84, 45);
            this.btn_exe.TabIndex = 1;
            this.btn_exe.Text = "Execute";
            this.btn_exe.UseVisualStyleBackColor = true;
            // 
            // btn_init
            // 
            this.btn_init.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_init.Location = new System.Drawing.Point(517, 86);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(84, 42);
            this.btn_init.TabIndex = 1;
            this.btn_init.Text = "init Path";
            this.btn_init.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "※ MD5 Hash 검사 할 file을 Drag & Drop 해주세요.\r\n Please Drag & Drop here the files for e" +
    "xecute a MD5 Hash";
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(12, 437);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // lst_files
            // 
            this.lst_files.AllowDrop = true;
            this.lst_files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_files.FormattingEnabled = true;
            this.lst_files.ItemHeight = 15;
            this.lst_files.Location = new System.Drawing.Point(12, 34);
            this.lst_files.Name = "lst_files";
            this.lst_files.Size = new System.Drawing.Size(497, 92);
            this.lst_files.TabIndex = 5;
            // 
            // rtxt_result
            // 
            this.rtxt_result.BackColor = System.Drawing.Color.Black;
            this.rtxt_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_result.ForeColor = System.Drawing.Color.White;
            this.rtxt_result.Location = new System.Drawing.Point(12, 187);
            this.rtxt_result.Name = "rtxt_result";
            this.rtxt_result.Size = new System.Drawing.Size(497, 244);
            this.rtxt_result.TabIndex = 6;
            this.rtxt_result.Text = "";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 478);
            this.Controls.Add(this.rtxt_result);
            this.Controls.Add(this.lst_files);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_exe);
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
    }
}

