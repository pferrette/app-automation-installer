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


            var list = new Dictionary<string,int>();
            list.Add("Google Chrome",0);
            list.Add("Adobe Reader",1);
            list.Add("WinRar",2);
            list.Add("7-Zip",3);
            list.Add("Java",4);
            list.Add("Office",5);
            list.Add("TeamViewer",6);
            list.Add("Microsoft Teams",7);

            var apps = new AppClass();

            foreach (var item in list)
            {
                clb_apps.Items.Add(item.Key);
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