using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilaDinamica
{
    public partial class Form1 : Form
    {
        private FilaDinamica fila = new FilaDinamica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnfileirar_Click(object sender, EventArgs e)
        {
            int ra = 0;
            if (String.IsNullOrWhiteSpace(txtRa.Text) || String.IsNullOrWhiteSpace(txtNome.Text))
                MessageBox.Show("Os campos são obrigatórios!");

            if (int.TryParse(txtRa.Text, out ra))
            {
                Aluno aluno = new Aluno();
                aluno.Ra = ra;
                aluno.Nome = txtNome.Text;
                fila.Enfileirar(aluno);
                txtNome.Clear();
                txtRa.Clear();
                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            else
                MessageBox.Show("O RA deve conter apenas números!");
        }

        private void btnDesenfileirar_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultado.Clear();
                Aluno aluno = fila.Desenfileira();
                txtResultado.Text = "RA: " + aluno.Ra + " | Nome: " + aluno.Nome;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnListarFila_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultado.Text = fila.ListarItems();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
