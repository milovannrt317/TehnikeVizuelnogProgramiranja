﻿namespace Projekat_2
{
    partial class frmPrikazRacuna
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPretragaDt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDoVr = new System.Windows.Forms.DateTimePicker();
            this.dtOdVr = new System.Windows.Forms.DateTimePicker();
            this.btnPretragaVr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(669, 240);
            this.dataGridView1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(220, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 171);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPretragaDt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtDo);
            this.tabPage1.Controls.Add(this.dtOd);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pretraga po datumu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPretragaDt
            // 
            this.btnPretragaDt.Image = global::Projekat_2.Properties.Resources.magn;
            this.btnPretragaDt.Location = new System.Drawing.Point(384, 32);
            this.btnPretragaDt.Name = "btnPretragaDt";
            this.btnPretragaDt.Size = new System.Drawing.Size(113, 70);
            this.btnPretragaDt.TabIndex = 3;
            this.btnPretragaDt.UseVisualStyleBackColor = true;
            this.btnPretragaDt.Click += new System.EventHandler(this.btnPretragaDt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum od:";
            // 
            // dtDo
            // 
            this.dtDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDo.Location = new System.Drawing.Point(194, 60);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(126, 22);
            this.dtDo.TabIndex = 2;
            // 
            // dtOd
            // 
            this.dtOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOd.Location = new System.Drawing.Point(36, 60);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(126, 22);
            this.dtOd.TabIndex = 1;
            this.dtOd.ValueChanged += new System.EventHandler(this.dtOd_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtDoVr);
            this.tabPage2.Controls.Add(this.dtOdVr);
            this.tabPage2.Controls.Add(this.btnPretragaVr);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pretraga po vremenu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Izaberite datum za koji ce te pretraziti odredjeno vreme:";
            // 
            // dt
            // 
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(136, 27);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(126, 22);
            this.dt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vreme do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vreme od:";
            // 
            // dtDoVr
            // 
            this.dtDoVr.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtDoVr.Location = new System.Drawing.Point(224, 89);
            this.dtDoVr.Name = "dtDoVr";
            this.dtDoVr.Size = new System.Drawing.Size(126, 22);
            this.dtDoVr.TabIndex = 6;
            // 
            // dtOdVr
            // 
            this.dtOdVr.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtOdVr.Location = new System.Drawing.Point(23, 89);
            this.dtOdVr.Name = "dtOdVr";
            this.dtOdVr.Size = new System.Drawing.Size(126, 22);
            this.dtOdVr.TabIndex = 5;
            this.dtOdVr.ValueChanged += new System.EventHandler(this.dtOdVr_ValueChanged);
            // 
            // btnPretragaVr
            // 
            this.btnPretragaVr.Image = global::Projekat_2.Properties.Resources.magn;
            this.btnPretragaVr.Location = new System.Drawing.Point(385, 41);
            this.btnPretragaVr.Name = "btnPretragaVr";
            this.btnPretragaVr.Size = new System.Drawing.Size(113, 70);
            this.btnPretragaVr.TabIndex = 7;
            this.btnPretragaVr.UseVisualStyleBackColor = true;
            this.btnPretragaVr.Click += new System.EventHandler(this.btnPretragaVr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 93);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekat_2.Properties.Resources.srch;
            this.pictureBox1.Location = new System.Drawing.Point(731, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(211, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(491, 51);
            this.label6.TabIndex = 7;
            this.label6.Text = "PRETRAGA RAČUNA";
            // 
            // frmPrikazRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrikazRacuna";
            this.Text = "frmPrikazRacuna";
            this.Load += new System.EventHandler(this.frmPrikazRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPretragaDt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.DateTimePicker dtOd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPretragaVr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDoVr;
        private System.Windows.Forms.DateTimePicker dtOdVr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}