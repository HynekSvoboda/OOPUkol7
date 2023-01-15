using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPUkol7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt(textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value,checkBox1.Checked);
            label5.Text= produkt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořte třídu Zboží, která bude obsahovat:\r\n Soukromý atribut název\r\n Soukromý atribut cena\r\n Soukromý atribut Datum výroby\r\n Soukromý atribut Minimální trvanlivost – počet dní (např. 30)\r\nTřída bude obsahovat jediný konstruktor\r\n Nastaví název, cenu, datum výroby a minimální trvanlivost\r\nTřída bude obsahovat metody:\r\n Splňuje minimální trvanlivost – zjistí, zda zboží k aktuálnímu datu ještě\r\nnepřekročilo minimální trvanlivost.\r\n Cena s DPH – zjistí cenu zboží navýšenou o daň z přidané hodnoty 21%\r\n Přepsanou metodu ToString – vrátí text se všemi údaji, včetně Ceny s DPH a\r\ninformace, zda zboží ještě nepřekročilo minimální trvanlivost.\r\nVytvořte třídu Produkt odvozenou od třídy Zboží.\r\nTřída zdědí všechny atributy, a metody od třídy Zboží a navíc bude obsahovat:\r\n Soukromý atribut lze zlevnit – údaj, zda je možné snížit cenu zboží\r\nKonstruktor nastaví stejné údaje jako předek a navíc nastaví atribut lze slevit. Využijte\r\nkonstruktor předka.\r\nPřepište metodu Cena s DPH, která využije metodu předka, a navíc sníží tuto\r\nvypočítanou výslednou cenu o 40%, pokud produkt již překročil minimální trvanlivost\r\n(Zavolejte zděděnou metodu (Minimální Trvanlivost))\r\nVytvořte instanci třídy Produkt a vyzkoušejte v programu.");
        }
    }
}
