using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiegarnia
{

    class MyClass
    {
        void Method()
        {
            System.Console.WriteLine("hello");
        } 
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsKsiegrnia.Autorzy' table. You can move, or remove it, as needed.
            this.autorzyTableAdapter.Fill(this.dsKsiegrnia.Autorzy);
            // TODO: This line of code loads data into the 'dsKsiegrnia.Autorzy' table. You can move, or remove it, as needed.
            this.autorzyTableAdapter.Fill(this.dsKsiegrnia.Autorzy);
            // TODO: This line of code loads data into the 'dsKsiegrnia.Autorzy' table. You can move, or remove it, as needed.
            this.autorzyTableAdapter.Fill(this.dsKsiegrnia.Autorzy);
            // TODO: This line of code loads data into the 'dsKsiegrnia.Autorzy' table. You can move, or remove it, as needed.
            this.autorzyTableAdapter.Fill(this.dsKsiegrnia.Autorzy);
            // TODO: This line of code loads data into the 'dsKsiegrnia.Autorzy' table. You can move, or remove it, as needed.
            this.autorzyTableAdapter.Fill(this.dsKsiegrnia.Autorzy);
            // TODO: This line of code loads data into the 'ksiegrniaDataSet.Ksiazki' table. You can move, or remove it, as needed.
            this.taKsiazki.Fill(this.dsKsiegrnia.Ksiazki);

        }

        private void mniZakoncz_Click(object sender, EventArgs e)
        {
            //dgv.EndEdit();
            taKsiazki.Update(dsKsiegrnia.Ksiazki);
            Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
