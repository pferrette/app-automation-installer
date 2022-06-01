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
            list.Add("Adobe Reader");
            list.Add("WinRar");
            list.Add("7-Zip");
            list.Add("Java");
            list.Add("Office");
            list.Add("TeamViewer");
            list.Add("Microsoft Teams");

            var googleChrome = new AppClass() { AppId = 0, Name = "Google Chrome", Command = "choco install googlechrome -y" };
            var adobeReader = new AppClass() { AppId = 1, Name = "Adobe Reader", Command = "choco install adobereader -y" };
            var winrar = new AppClass() { AppId = 2, Name = "WinRar", Command = "choco install winrar -y" };
            var sevenZip = new AppClass() { AppId = 3, Name = "7-Zip", Command = "choco install 7zip.install -y" };
            var java = new AppClass() { AppId = 4, Name = "Java", Command = "choco install javaruntime -y" };

            foreach (var item in list)
            {
                clb_apps.Items.Add(googleChrome.Name);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_apps.SelectedIndex; i++)
            {

            }
        }

        public void ExecutaComando(int i)
        {
            var teste = new Dictionary<string, int>();
            teste.Add("teste", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process.Start("command.bat");
            label1.Text = clb_apps.Items.Count.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            frm_apps n = new frm_apps();
            n.Close();
        }

        private void chk_All_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_apps.Items.Count; i++)
            {
                clb_apps.SetItemChecked(i, chk_All.Checked);
            }
        }
    }
}