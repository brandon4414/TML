using System;
using System.IO;
using System.Windows.Forms;

namespace TML
{
    public partial class FolderChooser : Form
    {
        public FolderChooser()
        {
            InitializeComponent();
        }

        public string gamePath = "";

        private void launch_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TABG Executable|TotallyAccurateBattlegrounds.exe";
            openFileDialog1.InitialDirectory = gamePath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gamePath = openFileDialog1.FileName;
                gamePath = Path.GetDirectoryName(gamePath);

                button1.Enabled = false;
                File.WriteAllText(Path.GetTempPath() + @"\.TML", gamePath);
                button2.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}