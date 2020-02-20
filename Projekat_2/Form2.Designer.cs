namespace Projekat_2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dst = new Projekat_2.dst();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.txtCenaUkupna = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnObrisiArt = new System.Windows.Forms.Button();
            this.btnIzdaj = new System.Windows.Forms.Button();
            this.btnUkloniKol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dst)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 93);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekat_2.Properties.Resources.cart;
            this.pictureBox1.Location = new System.Drawing.Point(644, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(275, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 51);
            this.label6.TabIndex = 14;
            this.label6.Text = "PRODAVNICA";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.dst;
            this.bindingSource2.Position = 0;
            // 
            // dst
            // 
            this.dst.DataSetName = "dst";
            this.dst.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.txtCenaUkupna);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnObrisiArt);
            this.groupBox2.Controls.Add(this.btnIzdaj);
            this.groupBox2.Controls.Add(this.btnUkloniKol);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(560, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 502);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Račun";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Obriši artikal sa liste:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Prikaz računa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Smanji količinu za odabrani artikal:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(40, 292);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(79, 22);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown2_KeyPress);
            // 
            // txtCenaUkupna
            // 
            this.txtCenaUkupna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenaUkupna.Location = new System.Drawing.Point(128, 418);
            this.txtCenaUkupna.Name = "txtCenaUkupna";
            this.txtCenaUkupna.ReadOnly = true;
            this.txtCenaUkupna.Size = new System.Drawing.Size(148, 26);
            this.txtCenaUkupna.TabIndex = 28;
            this.txtCenaUkupna.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(12, 85);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(391, 164);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ukupan iznos:";
            // 
            // btnObrisiArt
            // 
            this.btnObrisiArt.Enabled = false;
            this.btnObrisiArt.Image = global::Projekat_2.Properties.Resources.kanta;
            this.btnObrisiArt.Location = new System.Drawing.Point(320, 289);
            this.btnObrisiArt.Name = "btnObrisiArt";
            this.btnObrisiArt.Size = new System.Drawing.Size(41, 36);
            this.btnObrisiArt.TabIndex = 6;
            this.btnObrisiArt.UseVisualStyleBackColor = true;
            this.btnObrisiArt.Click += new System.EventHandler(this.btnObrisiArt_Click);
            // 
            // btnIzdaj
            // 
            this.btnIzdaj.Image = global::Projekat_2.Properties.Resources.racun;
            this.btnIzdaj.Location = new System.Drawing.Point(301, 377);
            this.btnIzdaj.Name = "btnIzdaj";
            this.btnIzdaj.Size = new System.Drawing.Size(102, 92);
            this.btnIzdaj.TabIndex = 7;
            this.btnIzdaj.UseVisualStyleBackColor = true;
            this.btnIzdaj.Click += new System.EventHandler(this.btnIzdaj_Click);
            // 
            // btnUkloniKol
            // 
            this.btnUkloniKol.Enabled = false;
            this.btnUkloniKol.Image = global::Projekat_2.Properties.Resources.min;
            this.btnUkloniKol.Location = new System.Drawing.Point(144, 289);
            this.btnUkloniKol.Name = "btnUkloniKol";
            this.btnUkloniKol.Size = new System.Drawing.Size(53, 30);
            this.btnUkloniKol.TabIndex = 5;
            this.btnUkloniKol.UseVisualStyleBackColor = true;
            this.btnUkloniKol.Click += new System.EventHandler(this.btnUkloniKol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.lblGrupa);
            this.groupBox1.Controls.Add(this.cmbGrupa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje artikala na račun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Artikli:";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(8, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 400);
            this.panel2.TabIndex = 20;
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Location = new System.Drawing.Point(38, 19);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(95, 16);
            this.lblGrupa.TabIndex = 19;
            this.lblGrupa.Text = "Grupa artikala:";
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(28, 38);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(121, 24);
            this.cmbGrupa.TabIndex = 1;
            this.cmbGrupa.SelectedIndexChanged += new System.EventHandler(this.cmbGrupa_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 604);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dst)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource2;
        private dst dst;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox txtCenaUkupna;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnObrisiArt;
        private System.Windows.Forms.Button btnIzdaj;
        private System.Windows.Forms.Button btnUkloniKol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.ComboBox cmbGrupa;
    }
}