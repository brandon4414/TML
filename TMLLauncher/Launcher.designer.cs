namespace TML
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.launch = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.changeDir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.modChooser = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.discordLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.discordButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.aboutLogo = new System.Windows.Forms.PictureBox();
            this.commName = new System.Windows.Forms.Label();
            this.commSupport = new System.Windows.Forms.Label();
            this.audixas = new System.Windows.Forms.Label();
            this.polarnf = new System.Windows.Forms.Label();
            this.mfc = new System.Windows.Forms.Label();
            this.testAndFeed = new System.Windows.Forms.Label();
            this.mhnd = new System.Windows.Forms.Label();
            this.dev = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.pageViewer = new System.Windows.Forms.WebBrowser();
            this.reloadButton = new System.Windows.Forms.Button();
            this.modChooser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discordButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // launch
            // 
            this.launch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.launch.BackColor = System.Drawing.Color.Transparent;
            this.launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.launch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launch.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.launch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.launch.Location = new System.Drawing.Point(624, 396);
            this.launch.Margin = new System.Windows.Forms.Padding(2);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(341, 60);
            this.launch.TabIndex = 2;
            this.launch.Text = "Launch Game";
            this.launch.UseVisualStyleBackColor = false;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.titleLabel.Location = new System.Drawing.Point(238, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(468, 65);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "TABG MOD LOADER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changeDir
            // 
            this.changeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeDir.BackColor = System.Drawing.Color.Transparent;
            this.changeDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeDir.Location = new System.Drawing.Point(829, 20);
            this.changeDir.Name = "changeDir";
            this.changeDir.Size = new System.Drawing.Size(136, 47);
            this.changeDir.TabIndex = 15;
            this.changeDir.Text = "Choose Installation Directory";
            this.changeDir.UseVisualStyleBackColor = false;
            this.changeDir.Click += new System.EventHandler(this.Button2_Click);
            // 
            // downloadBar
            // 
            this.downloadBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.downloadBar.Location = new System.Drawing.Point(12, 461);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(953, 10);
            this.downloadBar.TabIndex = 17;
            // 
            // modChooser
            // 
            this.modChooser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modChooser.BackColor = System.Drawing.Color.Transparent;
            this.modChooser.Controls.Add(this.radioButton2);
            this.modChooser.Controls.Add(this.radioButton1);
            this.modChooser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modChooser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modChooser.Location = new System.Drawing.Point(12, 390);
            this.modChooser.Name = "modChooser";
            this.modChooser.Size = new System.Drawing.Size(607, 65);
            this.modChooser.TabIndex = 18;
            this.modChooser.TabStop = false;
            this.modChooser.Text = "Gamemode";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Modded";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 21);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vanilla";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // discordLabel
            // 
            this.discordLabel.AutoSize = true;
            this.discordLabel.BackColor = System.Drawing.Color.Transparent;
            this.discordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.discordLabel.Location = new System.Drawing.Point(60, 35);
            this.discordLabel.Name = "discordLabel";
            this.discordLabel.Size = new System.Drawing.Size(103, 17);
            this.discordLabel.TabIndex = 21;
            this.discordLabel.Text = "Join our Discord!";
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutButton.Location = new System.Drawing.Point(760, 20);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(63, 47);
            this.aboutButton.TabIndex = 23;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // discordButton
            // 
            this.discordButton.BackColor = System.Drawing.Color.Transparent;
            this.discordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discordButton.BackgroundImage")));
            this.discordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordButton.Location = new System.Drawing.Point(12, 25);
            this.discordButton.Name = "discordButton";
            this.discordButton.Size = new System.Drawing.Size(40, 40);
            this.discordButton.TabIndex = 25;
            this.discordButton.TabStop = false;
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(789, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 49);
            this.backButton.TabIndex = 36;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // aboutLogo
            // 
            this.aboutLogo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aboutLogo.BackColor = System.Drawing.Color.Transparent;
            this.aboutLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutLogo.BackgroundImage")));
            this.aboutLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutLogo.Location = new System.Drawing.Point(404, 44);
            this.aboutLogo.Name = "aboutLogo";
            this.aboutLogo.Size = new System.Drawing.Size(350, 350);
            this.aboutLogo.TabIndex = 35;
            this.aboutLogo.TabStop = false;
            // 
            // commName
            // 
            this.commName.AutoSize = true;
            this.commName.BackColor = System.Drawing.Color.Transparent;
            this.commName.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commName.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.commName.Location = new System.Drawing.Point(28, 229);
            this.commName.Name = "commName";
            this.commName.Size = new System.Drawing.Size(136, 20);
            this.commName.TabIndex = 34;
            this.commName.Text = "TABG\'s Last Hope";
            // 
            // commSupport
            // 
            this.commSupport.AutoSize = true;
            this.commSupport.BackColor = System.Drawing.Color.Transparent;
            this.commSupport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commSupport.ForeColor = System.Drawing.SystemColors.Control;
            this.commSupport.Location = new System.Drawing.Point(15, 208);
            this.commSupport.Name = "commSupport";
            this.commSupport.Size = new System.Drawing.Size(154, 21);
            this.commSupport.TabIndex = 33;
            this.commSupport.Text = "Community Support";
            // 
            // audixas
            // 
            this.audixas.AutoSize = true;
            this.audixas.BackColor = System.Drawing.Color.Transparent;
            this.audixas.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audixas.ForeColor = System.Drawing.Color.YellowGreen;
            this.audixas.Location = new System.Drawing.Point(28, 177);
            this.audixas.Name = "audixas";
            this.audixas.Size = new System.Drawing.Size(67, 20);
            this.audixas.TabIndex = 32;
            this.audixas.Text = "Audixas";
            // 
            // polarnf
            // 
            this.polarnf.AutoSize = true;
            this.polarnf.BackColor = System.Drawing.Color.Transparent;
            this.polarnf.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polarnf.ForeColor = System.Drawing.Color.Yellow;
            this.polarnf.Location = new System.Drawing.Point(28, 157);
            this.polarnf.Name = "polarnf";
            this.polarnf.Size = new System.Drawing.Size(67, 20);
            this.polarnf.TabIndex = 31;
            this.polarnf.Text = "PolarNF";
            // 
            // mfc
            // 
            this.mfc.AutoSize = true;
            this.mfc.BackColor = System.Drawing.Color.Transparent;
            this.mfc.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfc.ForeColor = System.Drawing.Color.DarkOrange;
            this.mfc.Location = new System.Drawing.Point(28, 137);
            this.mfc.Name = "mfc";
            this.mfc.Size = new System.Drawing.Size(151, 20);
            this.mfc.TabIndex = 30;
            this.mfc.Text = "Miley Fucking Cyrus";
            // 
            // testAndFeed
            // 
            this.testAndFeed.AutoSize = true;
            this.testAndFeed.BackColor = System.Drawing.Color.Transparent;
            this.testAndFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testAndFeed.ForeColor = System.Drawing.SystemColors.Control;
            this.testAndFeed.Location = new System.Drawing.Point(11, 116);
            this.testAndFeed.Name = "testAndFeed";
            this.testAndFeed.Size = new System.Drawing.Size(164, 21);
            this.testAndFeed.TabIndex = 29;
            this.testAndFeed.Text = "Testing and Feedback";
            // 
            // mhnd
            // 
            this.mhnd.AutoSize = true;
            this.mhnd.BackColor = System.Drawing.Color.Transparent;
            this.mhnd.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mhnd.ForeColor = System.Drawing.Color.Salmon;
            this.mhnd.Location = new System.Drawing.Point(28, 87);
            this.mhnd.Name = "mhnd";
            this.mhnd.Size = new System.Drawing.Size(187, 20);
            this.mhnd.TabIndex = 28;
            this.mhnd.Text = "MichaelHasNoDad#0486";
            // 
            // dev
            // 
            this.dev.AutoSize = true;
            this.dev.BackColor = System.Drawing.Color.Transparent;
            this.dev.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev.ForeColor = System.Drawing.SystemColors.Control;
            this.dev.Location = new System.Drawing.Point(11, 66);
            this.dev.Name = "dev";
            this.dev.Size = new System.Drawing.Size(106, 21);
            this.dev.TabIndex = 27;
            this.dev.Text = "Development";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutLabel.Location = new System.Drawing.Point(8, 17);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(90, 40);
            this.aboutLabel.TabIndex = 26;
            this.aboutLabel.Text = "About";
            // 
            // pageViewer
            // 
            this.pageViewer.AllowWebBrowserDrop = false;
            this.pageViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageViewer.IsWebBrowserContextMenuEnabled = false;
            this.pageViewer.Location = new System.Drawing.Point(12, 76);
            this.pageViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.pageViewer.Name = "pageViewer";
            this.pageViewer.ScriptErrorsSuppressed = true;
            this.pageViewer.Size = new System.Drawing.Size(953, 308);
            this.pageViewer.TabIndex = 37;
            this.pageViewer.Url = new System.Uri("http://api.whatthehe.cc/TML/ftp_root/changelog.php", System.UriKind.Absolute);
            this.pageViewer.WebBrowserShortcutsEnabled = false;
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadButton.BackgroundImage = global::TML.Properties.Resources.reload;
            this.reloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadButton.Location = new System.Drawing.Point(943, 76);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(22, 21);
            this.reloadButton.TabIndex = 38;
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // Launcher
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TML.Properties.Resources.gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 483);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.pageViewer);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.commName);
            this.Controls.Add(this.commSupport);
            this.Controls.Add(this.audixas);
            this.Controls.Add(this.polarnf);
            this.Controls.Add(this.mfc);
            this.Controls.Add(this.testAndFeed);
            this.Controls.Add(this.mhnd);
            this.Controls.Add(this.dev);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.discordButton);
            this.Controls.Add(this.modChooser);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.discordLabel);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.changeDir);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.aboutLogo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(993, 522);
            this.Name = "Launcher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "TML";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.modChooser.ResumeLayout(false);
            this.modChooser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discordButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button changeDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar downloadBar;
        private System.Windows.Forms.GroupBox modChooser;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label discordLabel;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.PictureBox discordButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox aboutLogo;
        private System.Windows.Forms.Label commName;
        private System.Windows.Forms.Label commSupport;
        private System.Windows.Forms.Label audixas;
        private System.Windows.Forms.Label polarnf;
        private System.Windows.Forms.Label mfc;
        private System.Windows.Forms.Label testAndFeed;
        private System.Windows.Forms.Label mhnd;
        private System.Windows.Forms.Label dev;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.WebBrowser pageViewer;
        private System.Windows.Forms.Button reloadButton;
    }
}

