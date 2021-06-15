using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MD5_Hash_Auto
{
    class sg_class
    {

        public void main()
        { 
            
        }

        public string RunExecute(string strKey)
        {
            ProcessStartInfo pri = new ProcessStartInfo();
            Process pro = new Process();

            pri.FileName = @"cmd.exe";
            pri.CreateNoWindow = true;
            pri.UseShellExecute = false;

            pri.RedirectStandardInput = true;                //표준 출력을 리다이렉트
            pri.RedirectStandardOutput = true;
            pri.RedirectStandardError = true;

            pro.StartInfo = pri;
            pro.Start();   //어플리케이션 실

            pro.StandardInput.Write(strKey + Environment.NewLine);
            pro.StandardInput.Close();

            System.IO.StreamReader sr = pro.StandardOutput;

            string resultValue = sr.ReadToEnd();

            Debug.Print(resultValue + "  <--- 메서드 내 결과");
            
            pro.WaitForExit();
            pro.Close();

            return resultValue == "" ? "" : resultValue;

        }
        
        public string GetResourceFileName()
        {
            String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            String strFilePath = Path.Combine(strAppPath, "Resources");
            String strFullFilename = Path.Combine(strFilePath, "fciv.exe"); // Resource에 담겨진 allpair의 경로를 exe 에서 바로 가져오기 위해 path를 가져옴..
            Debug.Print(strFullFilename);

            return strFullFilename == "" ? "" : strFullFilename;
            
        }

    }

}
