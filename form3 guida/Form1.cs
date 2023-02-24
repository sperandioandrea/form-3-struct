using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form3_guida
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
            visualizza(p);

        }
        public string prodString(prodotto p)
        {
            return "Nome: " + p.nome + " prezzo: " + p.prezzo.ToString();
        }
        public void visualizza(prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }

        }

        //funzione cancella e sostituisci

        public void Cancella(prodotto[] pp)
        {

        }

        private void nuovonome_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuovoprezzo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifica(p);
            visualizza(p);
        }
       
        //funzione ricerca elemento

        public void Modifica(prodotto[] pp)
        {
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == textBox1.Text)
                {
                    p[i].nome = nuovonome.Text;
                    p[i].prezzo = float.Parse(nuovoprezzo.Text);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
