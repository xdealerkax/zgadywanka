namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxlosowanie = new System.Windows.Forms.GroupBox();
            this.labelzakres = new System.Windows.Forms.Label();
            this.textBoxZakresod = new System.Windows.Forms.TextBox();
            this.buttonwylosuj = new System.Windows.Forms.Button();
            this.label2zakres = new System.Windows.Forms.Label();
            this.textBoxZakresdo = new System.Windows.Forms.TextBox();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.groupBoxPropozycja = new System.Windows.Forms.GroupBox();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.groupBoxlosowanie.SuspendLayout();
            this.groupBoxPropozycja.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(9, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxlosowanie
            // 
            this.groupBoxlosowanie.Controls.Add(this.textBoxZakresdo);
            this.groupBoxlosowanie.Controls.Add(this.label2zakres);
            this.groupBoxlosowanie.Controls.Add(this.buttonwylosuj);
            this.groupBoxlosowanie.Controls.Add(this.textBoxZakresod);
            this.groupBoxlosowanie.Controls.Add(this.labelzakres);
            this.groupBoxlosowanie.Location = new System.Drawing.Point(9, 64);
            this.groupBoxlosowanie.Name = "groupBoxlosowanie";
            this.groupBoxlosowanie.Size = new System.Drawing.Size(253, 127);
            this.groupBoxlosowanie.TabIndex = 1;
            this.groupBoxlosowanie.TabStop = false;
            this.groupBoxlosowanie.Text = "Losowanie";
            this.groupBoxlosowanie.Visible = false;
            // 
            // labelzakres
            // 
            this.labelzakres.AutoSize = true;
            this.labelzakres.Location = new System.Drawing.Point(6, 20);
            this.labelzakres.Name = "labelzakres";
            this.labelzakres.Size = new System.Drawing.Size(61, 13);
            this.labelzakres.TabIndex = 0;
            this.labelzakres.Text = "Zakres od :";
            // 
            // textBoxZakresod
            // 
            this.textBoxZakresod.Location = new System.Drawing.Point(73, 17);
            this.textBoxZakresod.Name = "textBoxZakresod";
            this.textBoxZakresod.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresod.TabIndex = 1;
            this.textBoxZakresod.TextChanged += new System.EventHandler(this.textBoxZakresod_TextChanged);
            // 
            // buttonwylosuj
            // 
            this.buttonwylosuj.Location = new System.Drawing.Point(163, 96);
            this.buttonwylosuj.Name = "buttonwylosuj";
            this.buttonwylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonwylosuj.TabIndex = 2;
            this.buttonwylosuj.Text = "Wylosuj";
            this.buttonwylosuj.UseVisualStyleBackColor = true;
            this.buttonwylosuj.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2zakres
            // 
            this.label2zakres.AutoSize = true;
            this.label2zakres.Location = new System.Drawing.Point(6, 53);
            this.label2zakres.Name = "label2zakres";
            this.label2zakres.Size = new System.Drawing.Size(61, 13);
            this.label2zakres.TabIndex = 3;
            this.label2zakres.Text = "Zakres do :";
            // 
            // textBoxZakresdo
            // 
            this.textBoxZakresdo.Location = new System.Drawing.Point(73, 50);
            this.textBoxZakresdo.Name = "textBoxZakresdo";
            this.textBoxZakresdo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresdo.TabIndex = 4;
            // 
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Location = new System.Drawing.Point(187, 12);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzerwij.TabIndex = 2;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Visible = false;
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(15, 194);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(0, 13);
            this.labelKomunikat1.TabIndex = 3;
            // 
            // groupBoxPropozycja
            // 
            this.groupBoxPropozycja.Controls.Add(this.labelOdpowiedz);
            this.groupBoxPropozycja.Controls.Add(this.buttonZatwierdz);
            this.groupBoxPropozycja.Controls.Add(this.textBoxPropozycja);
            this.groupBoxPropozycja.Location = new System.Drawing.Point(9, 210);
            this.groupBoxPropozycja.Name = "groupBoxPropozycja";
            this.groupBoxPropozycja.Size = new System.Drawing.Size(200, 100);
            this.groupBoxPropozycja.TabIndex = 4;
            this.groupBoxPropozycja.TabStop = false;
            this.groupBoxPropozycja.Text = "Propozycja";
            this.groupBoxPropozycja.Visible = false;
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(9, 31);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropozycja.TabIndex = 0;
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Location = new System.Drawing.Point(119, 31);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(75, 23);
            this.buttonZatwierdz.TabIndex = 1;
            this.buttonZatwierdz.Text = "Zatwierdź";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(29, 63);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(46, 13);
            this.labelOdpowiedz.TabIndex = 2;
            this.labelOdpowiedz.Text = "Trafiono";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 392);
            this.Controls.Add(this.groupBoxPropozycja);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonPrzerwij);
            this.Controls.Add(this.groupBoxlosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Zgadywanka";
            this.groupBoxlosowanie.ResumeLayout(false);
            this.groupBoxlosowanie.PerformLayout();
            this.groupBoxPropozycja.ResumeLayout(false);
            this.groupBoxPropozycja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxlosowanie;
        private System.Windows.Forms.Button buttonwylosuj;
        private System.Windows.Forms.TextBox textBoxZakresod;
        private System.Windows.Forms.Label labelzakres;
        private System.Windows.Forms.TextBox textBoxZakresdo;
        private System.Windows.Forms.Label label2zakres;
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.GroupBox groupBoxPropozycja;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.Button buttonZatwierdz;
        private System.Windows.Forms.TextBox textBoxPropozycja;
    }
}

