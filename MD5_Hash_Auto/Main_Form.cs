using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5_Hash_Auto
{
    public partial class Main_form : Form
    {

        private sg_class sg;

        public Main_form()
        {
            InitializeComponent();

            lst_files.AllowDrop = true;

            init_Event();

            sg = new sg_class();
        }

        private void init_Event()
        {
            this.btn_clear.Click += new EventHandler(this.richText_clear);
            this.btn_exe.Click += new EventHandler(this.executeRun);

            this.lst_files.DragDrop += new DragEventHandler(lstfile_DragDrop);
            this.lst_files.DragEnter += new DragEventHandler(lstfile_DragEnter);

        }

        private void lstfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lstfile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string s in files)
            {
                lst_files.Items.Add(s);
            }
            
        }





        /// <summary>
        /// RichTextBox 내용 초기화 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richText_clear(object sender, EventArgs e)
        {
            rtxt_result.Text = string.Empty;
        }


        private void executeRun(object sender, EventArgs e)
        {
            // 실제 파일 드래그 했을 때 exe 창에 표시 되도록 
            string fciv = sg.GetResourceFileName();

            foreach (string s in lst_files.Items)
            {
                string filePath = Path.Combine(s);
                Debug.Print(s);
               
                string resultText = sg.RunExecute($"{fciv} certutil -hashfile {s} MD5");
                Debug.Print(resultText);

                // 테스트 코드 (쓸 때 없는 텍스트를 지워주기 위해 임시로 테스트 )
                string cutText = resultText;
                string outputText;
                outputText = cutText.Substring(cutText.IndexOf("All rights reserved."));
                outputText = outputText.Replace("All rights reserved.", string.Empty);
                //outputText = cutText.Substring(50, cutText.Length);

                rtxt_result.AppendText(Environment.NewLine + outputText);
                rtxt_result.AppendText(string.Format("{0}", "--------------------") + Environment.NewLine);

            }


        }






    }
}
