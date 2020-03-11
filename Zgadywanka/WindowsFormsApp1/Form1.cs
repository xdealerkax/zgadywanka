using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form // partial częściowa klasa
    {
       private Gra g = null;  // g referencja do obiektu typu gra



        public Form1()
        {
            InitializeComponent();
        }

        // przecisk nowa gra
        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxlosowanie.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPrzerwij.Visible = true;
        }
        // przycisk wylosuj
        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxZakresod.Text);
            int b = int.Parse(textBoxZakresdo.Text);

            g = new Gra(a, b); // uruchomienie konstruktora
            // wypisz komunikat, żeby odgadywać
            labelKomunikat1.Text = $"Wylosowano liczbę od {a} do {b}.";
            groupBoxlosowanie.Enabled = false;
            groupBoxPropozycja.Visible = true;
        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPropozycja.Text);
            var odp = g.Odpowiedz(propozycja); // odp to zmienna 
            switch (odp)
            {
                case Odp.ZaMalo: // Odp to enum
                    labelOdpowiedz.ForeColor = Color.Red;
                    labelOdpowiedz.Text = "Za mało";
                    break;
                case Odp.ZaDuzo:
                    labelOdpowiedz.ForeColor = Color.Red;
                    labelOdpowiedz.Text = "Za dużo";
                    break;
                case Odp.Trafiono:
                    labelOdpowiedz.ForeColor = Color.Green;
                    labelOdpowiedz.Text = "Trafiono";
                    groupBoxPropozycja.Enabled = false;
                    buttonNowaGra.Enabled = true;
                    break;

            }
        }

        private void textBoxZakresod_TextChanged(object sender, EventArgs e) // zmiana zawartości pola
        {
            int wynik = 0;

            if (int.TryParse(textBoxZakresod.Text, out wynik))
            {
                textBoxZakresod.BackColor = Color.LightGreen;
                buttonwylosuj.Enabled = true;
            }
            else
            {
                textBoxZakresod.BackColor = Color.PaleVioletRed;
                buttonwylosuj.Enabled = false;
            }
        }
    }
}
