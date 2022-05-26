using System.Diagnostics;

namespace Instalador_de_Apps
{
    public partial class frm_apps : Form
    {
        public frm_apps()
        {
            InitializeComponent();

            chk_All.Text = "Select All";

            btn_cancel.Text = "Cancel";
            btn_start.Text = "Start Installation";


            var list = new List<string>();

            list.Add("Google Chrome");
            list.Add("43222");

            foreach (var item in list)
            {
                clb_apps.Items.Add(item);
            }
        }

        

        private void btn_start_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "Teste";
            process.Start();
            //var getFulPath = Path.GetFullPath("C:/Users/Asus/Documents/Instalador de Apps/Instalador de Apps/Instalador de Apps/Files/apps.txt");
            //StreamReader filesFlow = new StreamReader(getFulPath);
            //string strings = filesFlow.ReadToEnd();
        }
    }
}