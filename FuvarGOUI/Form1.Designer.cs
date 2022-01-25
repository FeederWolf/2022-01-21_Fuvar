
namespace FuvarGOUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKilepes = new System.Windows.Forms.Button();
            this.T_Indulas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBetolt = new System.Windows.Forms.Button();
            this.btnRendez = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Indulas = new System.Windows.Forms.Label();
            this.T_TaxiID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.T_Idotartalom = new System.Windows.Forms.TextBox();
            this.Idotartalom = new System.Windows.Forms.Label();
            this.T_Tavolsag = new System.Windows.Forms.TextBox();
            this.Tavolsag = new System.Windows.Forms.Label();
            this.T_Viteldij = new System.Windows.Forms.TextBox();
            this.Viteldij = new System.Windows.Forms.Label();
            this.T_Borravalo = new System.Windows.Forms.TextBox();
            this.Borravalo = new System.Windows.Forms.Label();
            this.T_Forras_mod = new System.Windows.Forms.TextBox();
            this.Forras_mod = new System.Windows.Forms.Label();
            this.bntClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKilepes
            // 
            this.btnKilepes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKilepes.BackgroundImage")));
            this.btnKilepes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKilepes.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKilepes.ForeColor = System.Drawing.Color.Red;
            this.btnKilepes.Location = new System.Drawing.Point(12, 388);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(140, 50);
            this.btnKilepes.TabIndex = 0;
            this.btnKilepes.Text = "kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // T_Indulas
            // 
            this.T_Indulas.Location = new System.Drawing.Point(321, 92);
            this.T_Indulas.Name = "T_Indulas";
            this.T_Indulas.Size = new System.Drawing.Size(126, 23);
            this.T_Indulas.TabIndex = 1;
            this.T_Indulas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fuvar Adatai";
            // 
            // btnBetolt
            // 
            this.btnBetolt.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBetolt.Cursor = System.Windows.Forms.Cursors.No;
            this.btnBetolt.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBetolt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBetolt.Location = new System.Drawing.Point(12, 325);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(75, 23);
            this.btnBetolt.TabIndex = 3;
            this.btnBetolt.Text = "Betöltés";
            this.btnBetolt.UseVisualStyleBackColor = false;
            this.btnBetolt.Click += new System.EventHandler(this.btnBetolt_Click);
            // 
            // btnRendez
            // 
            this.btnRendez.BackColor = System.Drawing.Color.Blue;
            this.btnRendez.Cursor = System.Windows.Forms.Cursors.No;
            this.btnRendez.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRendez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRendez.Location = new System.Drawing.Point(154, 325);
            this.btnRendez.Name = "btnRendez";
            this.btnRendez.Size = new System.Drawing.Size(75, 23);
            this.btnRendez.TabIndex = 4;
            this.btnRendez.Text = "Rendezés";
            this.btnRendez.UseVisualStyleBackColor = false;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(217, 289);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Indulas
            // 
            this.Indulas.AutoSize = true;
            this.Indulas.Location = new System.Drawing.Point(267, 100);
            this.Indulas.Name = "Indulas";
            this.Indulas.Size = new System.Drawing.Size(48, 15);
            this.Indulas.TabIndex = 6;
            this.Indulas.Text = "Indulás:";
            // 
            // T_TaxiID
            // 
            this.T_TaxiID.Location = new System.Drawing.Point(321, 46);
            this.T_TaxiID.Name = "T_TaxiID";
            this.T_TaxiID.Size = new System.Drawing.Size(100, 23);
            this.T_TaxiID.TabIndex = 1;
            this.T_TaxiID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "TaxiID:";
            // 
            // T_Idotartalom
            // 
            this.T_Idotartalom.Location = new System.Drawing.Point(321, 136);
            this.T_Idotartalom.Name = "T_Idotartalom";
            this.T_Idotartalom.Size = new System.Drawing.Size(100, 23);
            this.T_Idotartalom.TabIndex = 1;
            this.T_Idotartalom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Idotartalom
            // 
            this.Idotartalom.AutoSize = true;
            this.Idotartalom.Location = new System.Drawing.Point(267, 144);
            this.Idotartalom.Name = "Idotartalom";
            this.Idotartalom.Size = new System.Drawing.Size(48, 15);
            this.Idotartalom.TabIndex = 6;
            this.Idotartalom.Text = "Idotart.:";
            // 
            // T_Tavolsag
            // 
            this.T_Tavolsag.Location = new System.Drawing.Point(321, 182);
            this.T_Tavolsag.Name = "T_Tavolsag";
            this.T_Tavolsag.Size = new System.Drawing.Size(100, 23);
            this.T_Tavolsag.TabIndex = 1;
            this.T_Tavolsag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tavolsag
            // 
            this.Tavolsag.AutoSize = true;
            this.Tavolsag.Location = new System.Drawing.Point(260, 190);
            this.Tavolsag.Name = "Tavolsag";
            this.Tavolsag.Size = new System.Drawing.Size(55, 15);
            this.Tavolsag.TabIndex = 6;
            this.Tavolsag.Text = "Távolság:";
            // 
            // T_Viteldij
            // 
            this.T_Viteldij.Location = new System.Drawing.Point(321, 228);
            this.T_Viteldij.Name = "T_Viteldij";
            this.T_Viteldij.Size = new System.Drawing.Size(100, 23);
            this.T_Viteldij.TabIndex = 1;
            this.T_Viteldij.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Viteldij
            // 
            this.Viteldij.AutoSize = true;
            this.Viteldij.Location = new System.Drawing.Point(269, 236);
            this.Viteldij.Name = "Viteldij";
            this.Viteldij.Size = new System.Drawing.Size(46, 15);
            this.Viteldij.TabIndex = 6;
            this.Viteldij.Text = "Viteldíj:";
            // 
            // T_Borravalo
            // 
            this.T_Borravalo.Location = new System.Drawing.Point(321, 275);
            this.T_Borravalo.Name = "T_Borravalo";
            this.T_Borravalo.Size = new System.Drawing.Size(100, 23);
            this.T_Borravalo.TabIndex = 1;
            this.T_Borravalo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Borravalo
            // 
            this.Borravalo.AutoSize = true;
            this.Borravalo.Location = new System.Drawing.Point(255, 283);
            this.Borravalo.Name = "Borravalo";
            this.Borravalo.Size = new System.Drawing.Size(60, 15);
            this.Borravalo.TabIndex = 6;
            this.Borravalo.Text = "Borravaló:";
            // 
            // T_Forras_mod
            // 
            this.T_Forras_mod.Location = new System.Drawing.Point(321, 325);
            this.T_Forras_mod.Name = "T_Forras_mod";
            this.T_Forras_mod.Size = new System.Drawing.Size(100, 23);
            this.T_Forras_mod.TabIndex = 1;
            this.T_Forras_mod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Forras_mod
            // 
            this.Forras_mod.AutoSize = true;
            this.Forras_mod.Location = new System.Drawing.Point(236, 333);
            this.Forras_mod.Name = "Forras_mod";
            this.Forras_mod.Size = new System.Drawing.Size(79, 15);
            this.Forras_mod.TabIndex = 6;
            this.Forras_mod.Text = "Forrás módja:";
            // 
            // bntClear
            // 
            this.bntClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntClear.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bntClear.ForeColor = System.Drawing.Color.Aqua;
            this.bntClear.Location = new System.Drawing.Point(90, 324);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(58, 23);
            this.bntClear.TabIndex = 7;
            this.bntClear.Text = "Törlés";
            this.bntClear.UseVisualStyleBackColor = false;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Forras_mod);
            this.Controls.Add(this.Borravalo);
            this.Controls.Add(this.Viteldij);
            this.Controls.Add(this.Tavolsag);
            this.Controls.Add(this.Idotartalom);
            this.Controls.Add(this.Indulas);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnRendez);
            this.Controls.Add(this.btnBetolt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_TaxiID);
            this.Controls.Add(this.T_Forras_mod);
            this.Controls.Add(this.T_Borravalo);
            this.Controls.Add(this.T_Viteldij);
            this.Controls.Add(this.T_Tavolsag);
            this.Controls.Add(this.T_Idotartalom);
            this.Controls.Add(this.T_Indulas);
            this.Controls.Add(this.btnKilepes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Esemény kezelő metódus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.TextBox T_Indulas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBetolt;
        private System.Windows.Forms.Button btnRendez;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label Indulas;
        private System.Windows.Forms.TextBox T_TaxiID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_Idotartalom;
        private System.Windows.Forms.Label Idotartalom;
        private System.Windows.Forms.TextBox T_Tavolsag;
        private System.Windows.Forms.Label Tavolsag;
        private System.Windows.Forms.TextBox T_Viteldij;
        private System.Windows.Forms.Label Viteldij;
        private System.Windows.Forms.TextBox T_Borravalo;
        private System.Windows.Forms.Label Borravalo;
        private System.Windows.Forms.TextBox T_Forras_mod;
        private System.Windows.Forms.Label Forras_mod;
        private System.Windows.Forms.Button bntClear;
    }
}

