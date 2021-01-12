using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projMedicamento
{
    public partial class Form1 : Form
    {
        private Medicamentos meusMedicamentos;

        public Form1()
        {
            InitializeComponent();
            meusMedicamentos = new Medicamentos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meusMedicamentos.adicionar(new Medicamento(
                int.Parse(txtIdMedicamento.Text),
                txtNomeMedicamento.Text,
                txtLabMedicamento.Text));
            atualizaCombo();
        }

        public void atualizaCombo()
        {
            cboMedicamentos.Items.Clear();
            lstMedicamentos.Items.Clear();
            foreach (Medicamento med in meusMedicamentos.ListaMedicamentos)
            {
                cboMedicamentos.Items.Add(med.Id.ToString());
                lstMedicamentos.Items.Add(med.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Medicamento medicamentoProcurado = new Medicamento(int.Parse(cboMedicamentos.Text), "", "");
            meusMedicamentos.pesquisar(medicamentoProcurado).comprar(new Lote(int.Parse(txtIdLote.Text), int.Parse(txtQtdeLote.Text), txtVencLote.Value));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Medicamento medicamentoProcurado = new Medicamento(int.Parse(cboMedicamentos.Text), "", "");
            lstLotes.Items.Clear();
            foreach (Lote lote in meusMedicamentos.pesquisar(medicamentoProcurado).Lotes)
                lstLotes.Items.Add(lote.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Medicamento medicamentoProcurado = new Medicamento(int.Parse(cboMedicamentos.Text), "", "");
            if (meusMedicamentos.pesquisar(medicamentoProcurado).Id == 0)
                MessageBox.Show("Medicamento não encontrado");
            else
                if (meusMedicamentos.pesquisar(medicamentoProcurado).vender(int.Parse(txtQtdeVender.Text)))
                    MessageBox.Show("Venda realizada com sucesso!");
                else
                    MessageBox.Show("Qtde insuficiente!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medicamento medicamentoProcurado = new Medicamento(int.Parse(cboMedicamentos.Text), "", "");
            if (meusMedicamentos.deletar(medicamentoProcurado))
                MessageBox.Show("Medicamento deletado");
            else
                MessageBox.Show("Medicamento não pode ser deletado");
            atualizaCombo();
        }

    }
}
