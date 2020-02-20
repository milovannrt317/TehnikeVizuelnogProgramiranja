namespace Projekat_2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajNaRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajArtikalUBazuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napustiProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNaRačunToolStripMenuItem,
            this.dodajArtikalUBazuToolStripMenuItem,
            this.prikazRačunaToolStripMenuItem,
            this.napustiProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajNaRačunToolStripMenuItem
            // 
            this.dodajNaRačunToolStripMenuItem.Name = "dodajNaRačunToolStripMenuItem";
            this.dodajNaRačunToolStripMenuItem.Size = new System.Drawing.Size(148, 21);
            this.dodajNaRačunToolStripMenuItem.Text = "Dodaj artikle na račun";
            this.dodajNaRačunToolStripMenuItem.Click += new System.EventHandler(this.dodajNaRačunToolStripMenuItem_Click);
            // 
            // dodajArtikalUBazuToolStripMenuItem
            // 
            this.dodajArtikalUBazuToolStripMenuItem.Name = "dodajArtikalUBazuToolStripMenuItem";
            this.dodajArtikalUBazuToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.dodajArtikalUBazuToolStripMenuItem.Text = "Dodaj artikal u bazu";
            this.dodajArtikalUBazuToolStripMenuItem.Click += new System.EventHandler(this.dodajArtikalUBazuToolStripMenuItem_Click);
            // 
            // prikazRačunaToolStripMenuItem
            // 
            this.prikazRačunaToolStripMenuItem.Name = "prikazRačunaToolStripMenuItem";
            this.prikazRačunaToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.prikazRačunaToolStripMenuItem.Text = "Pretraga računa";
            this.prikazRačunaToolStripMenuItem.Click += new System.EventHandler(this.prikazRačunaToolStripMenuItem_Click);
            // 
            // napustiProgramToolStripMenuItem
            // 
            this.napustiProgramToolStripMenuItem.Name = "napustiProgramToolStripMenuItem";
            this.napustiProgramToolStripMenuItem.Size = new System.Drawing.Size(121, 21);
            this.napustiProgramToolStripMenuItem.Text = "Napusti program";
            this.napustiProgramToolStripMenuItem.Click += new System.EventHandler(this.napustiProgramToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 641);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodavnica";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajNaRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajArtikalUBazuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napustiProgramToolStripMenuItem;
    }
}