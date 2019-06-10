using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TML
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            mods = false;
            gamePath = "";
            radioButton1.Checked = true;
            mhnd.Hide();
            testAndFeed.Hide();
            mfc.Hide();
            polarnf.Hide();
            audixas.Hide();
            commSupport.Hide();
            commName.Hide();
            dev.Hide();
            aboutLabel.Hide();
            backButton.Hide();
            aboutLogo.Hide();
        }

        public bool mods = false;
        public string gamePath = "";

        private void launch_Click(object sender, EventArgs e)
        {
            launch.Enabled = false;
            if (radioButton1.Checked)
            {
                mods = false;
            }
            else
            {
                mods = true;
            }

            try
            {
                if (File.Exists(Path.GetTempPath() + @"dl.dll"))
                {
                    File.Delete(Path.GetTempPath() + @"dl.dll");
                }

                if (mods)
                {
                    DownloadFile(@"http://api.whatthehe.cc/TML/latest_mod.dll", Path.GetTempPath() + @"dl.dll");
                }
                else
                {
                    DownloadFile(@"http://api.whatthehe.cc/TML/latest.dll", Path.GetTempPath() + @"dl.dll");
                }

                gamePath = System.IO.File.ReadAllText(Path.GetTempPath() + ".TML").ToString();
            }
            catch (Exception excp1)
            {
                MessageBox.Show(excp1.ToString(), "Frickin heck. Report this to the Discord!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            FolderChooser f = new FolderChooser();
            try
            {
                if (!File.Exists(Path.GetTempPath() + @"\.TML"))
                {
                    f.ShowDialog();
                }
                gamePath = File.ReadAllText(Path.GetTempPath() + @"\.TML");
            }
            catch (Exception excp1)
            {
                MessageBox.Show(excp1.ToString(), "Frickin heck. Report this to the Discord!");
                System.Diagnostics.Process.Start("https://discord.gg/CwrNugT");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            File.Delete(Path.GetTempPath() + @"\.TML");
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\TML.exe");
            Application.Exit();
        }

        public void DownloadFile(string urlAddress, string location)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progressbar percentage only when the value is not the same.
            downloadBar.Value = e.ProgressPercentage;
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                try
                {
                    System.IO.File.Copy(Path.GetTempPath() + @"dl.dll", gamePath + @"\TotallyAccurateBattlegrounds_Data\Managed\Assembly-CSharp.dll", true);
                    File.Delete(Path.GetTempPath() + @"dl.dll");
                    try
                    {
                        System.Diagnostics.Process.Start(@"steam://rungameid/823130");
                        Application.Exit();
                    }
                    catch
                    {
                        MessageBox.Show("Error :c", "Couldn't launch game.\nIs Steam installed?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Unable to copy DLL file\n" + x, "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/CwrNugT");
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            // hide launcher
            titleLabel.Hide();
            changeDir.Hide();
            aboutButton.Hide();
            modChooser.Hide();
            discordLabel.Hide();
            downloadBar.Hide();
            discordButton.Hide();
            launch.Hide();
            pageViewer.Hide();
            reloadButton.Hide();

            //show about
            mhnd.Show();
            testAndFeed.Show();
            mfc.Show();
            polarnf.Show();
            audixas.Show();
            commSupport.Show();
            commName.Show();
            dev.Show();
            aboutLabel.Show();
            backButton.Show();
            aboutLogo.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Show launcher
            titleLabel.Show();
            changeDir.Show();
            aboutButton.Show();
            modChooser.Show();
            discordLabel.Show();
            downloadBar.Show();
            discordButton.Show();
            launch.Show();
            pageViewer.Show();
            reloadButton.Show();

            //Hide about
            mhnd.Hide();
            testAndFeed.Hide();
            mfc.Hide();
            polarnf.Hide();
            audixas.Hide();
            commSupport.Hide();
            commName.Hide();
            dev.Hide();
            aboutLabel.Hide();
            backButton.Hide();
            aboutLogo.Hide();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            pageViewer.Refresh();
        }
    }
}