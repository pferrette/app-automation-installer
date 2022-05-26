using System.Diagnostics;

namespace Instalador_de_Apps
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var fileExist = File.Exists("C:/ProgramData/chocolatey/choco.exe");
            if (fileExist == true)
            {
                Application.Run(new frm_apps());

                //Process process = new Process();
                //string strCommand1 = $"@{'\u0022'}%SystemRoot%\\System32\\WindowsPowerShell\\v1.0\\powershell.exe{'\u0022'}";
                //string strCommand2 = " -NoProfile - InputFormat None - ExecutionPolicy Bypass - Command ";
                //string strCommand3 = "iex((New - Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))";
                //string strCommand4 = $" & SET {'\u0022'}PATH =% PATH %;% ALLUSERSPROFILE %\\chocolatey\bin{'\u0022'}";
                //process.Start("notepad.exe", strCommand1+ strCommand2+ strCommand3+ strCommand4);
            }
            else
            {
                Application.Run(new frm_first());
            }
        }
    }
}