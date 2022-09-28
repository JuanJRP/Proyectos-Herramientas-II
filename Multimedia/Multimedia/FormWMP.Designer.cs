namespace Multimedia
{
    partial class FormWMP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWMP));
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.tsm = new System.Windows.Forms.MenuStrip();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Lista = new System.Windows.Forms.ListBox();
            this.tsm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.FileName = "open";
            // 
            // tsm
            // 
            this.tsm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.StopToolStripMenuItem,
            this.PreviusToolStripMenuItem,
            this.advanceToolStripMenuItem});
            this.tsm.Location = new System.Drawing.Point(0, 0);
            this.tsm.Name = "tsm";
            this.tsm.Size = new System.Drawing.Size(800, 24);
            this.tsm.TabIndex = 2;
            this.tsm.Text = "menuStrip1";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Enabled = false;
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.StopToolStripMenuItem.Text = "Stop";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // PreviusToolStripMenuItem
            // 
            this.PreviusToolStripMenuItem.Enabled = false;
            this.PreviusToolStripMenuItem.Name = "PreviusToolStripMenuItem";
            this.PreviusToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.PreviusToolStripMenuItem.Text = "Previus";
            this.PreviusToolStripMenuItem.Click += new System.EventHandler(this.delayToolStripMenuItem_Click);
            // 
            // advanceToolStripMenuItem
            // 
            this.advanceToolStripMenuItem.Enabled = false;
            this.advanceToolStripMenuItem.Name = "advanceToolStripMenuItem";
            this.advanceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.advanceToolStripMenuItem.Text = "Advance";
            this.advanceToolStripMenuItem.Click += new System.EventHandler(this.advanceToolStripMenuItem_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(0, 0);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(800, 339);
            this.Player.TabIndex = 0;
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(0, 339);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(802, 121);
            this.Lista.TabIndex = 3;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // FormWMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.tsm);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.tsm;
            this.Name = "FormWMP";
            this.Text = "Reproductor WMP";
            this.tsm.ResumeLayout(false);
            this.tsm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.MenuStrip tsm;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreviusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ListBox Lista;
    }
}

