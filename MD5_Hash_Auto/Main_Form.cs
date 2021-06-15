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

            if (lst_files.Items.Count == 0)
            {
                MessageBox.Show("무결성 확인을 위한 파일을 추가해주세요.");
            }
            else
            {
                foreach (string s in lst_files.Items)
                {
                    string filePath = Path.Combine(s);

                    // 실제 MD5 Hash Check
                    string resultText = sg.RunExecute($"certutil -hashfile {s} MD5");

                    //resultText = resultText.Replace(s, string.Empty);
 
                    // 명령어 Path 잘라내기
                    resultText = resultText.Replace(Application.StartupPath.ToString().Substring(0, Application.StartupPath.Length - 1), string.Empty);

                    resultText = resultText.Replace(">", string.Empty);

                    // 테스트 코드 (쓸 때 없는 텍스트를 지워주기 위해 임시로 테스트 )
                    string cutText = resultText;
                    string outputText;
                    outputText = cutText.Substring(cutText.IndexOf("All rights reserved."));
                    outputText = outputText.Replace("All rights reserved.", string.Empty);


                    rtxt_result.AppendText("----------------------------------------------------");
                    rtxt_result.AppendText($"\r\r{outputText}");
                    // rtxt_result.AppendText(string.Format("{0}", "--------------------") );
                    rtxt_result.AppendText("----------------------------------------------------");
                }
            }

        }

    }
}
