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

                Process process = new Process();
                string strCommand = @"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex((New - Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))" && SET "PATH =% PATH %;% ALLUSERSPROFILE %\chocolatey\bin"
                process.Start("cmd.exe", strCommand);
            }
            else
            {
                Application.Run(new frm_first());
            }
        }
    }
}