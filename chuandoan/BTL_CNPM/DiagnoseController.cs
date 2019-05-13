using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
namespace T_chuandoan
{
    class chuandoanController
    {
        public string get_Diagnosis_Result(string sym1, string sym2, string sym3, string sym4)
        {
            string input_file_name = @"Input.txt";
            System.IO.StreamWriter obj;
            obj = new System.IO.StreamWriter(input_file_name);
            obj.WriteLine(sym1);
            obj.WriteLine(sym2);
            obj.WriteLine(sym3);
            obj.WriteLine(sym4);
            obj.Close();
            string path_to_dat = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"test.bat");
            var processInfo = new ProcessStartInfo("cmd.exe", "/c" + path_to_dat);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            var process = Process.Start(processInfo);
            process.Start();
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            string output_file_name = @"Output.txt";
            string result = File.ReadAllText(output_file_name);
            return result;
        }
    }
}
