using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroempresa
{
    public partial class Form2 : Form
    {
        List<Metodos> metodos = new List<Metodos>();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_cnpj.Clear();
            tx_cpf.Clear();
            tx_nomefantasia.Clear();
            tx_razao.Clear();
            tx_bairro.Clear();
            tx_cap.Clear();
            tx_nomepro.Clear();
            tx_telefone.Clear();
            tx_rua.Clear();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metodos m = new Metodos();
            m.cnpj = tx_cnpj.Text;
            m.cpf = tx_cpf.Text;
            m.razaosocial = tx_razao.Text;
            m.nomefan = tx_nomefantasia.Text;
            m.data = tx_data.Value;
            m.capitalsocial = Convert.ToDouble(tx_cap.Text);
            m.telefone = tx_telefone.Text;
            m.situacao = tx_situacao.Text;
            m.endereco = tx_est.Text;
            m.bairro = tx_bairro.Text;
            m.rua = tx_rua.Text;
            m.numero = Convert.ToInt32(tx_num.Text);
            m.nomeproprietario = tx_nomepro.Text;
            m.natureza = tx_nat.Text;
            m.Regimetributario = tx_regime.Text;
            m.tipo = tx_tipo.Text;
            m.porte = tx_porte.Text;
            m.cidade = tx_cidade.Text;
            
            metodos.Add(m);


          bool ret =   Valida.Validacao(tx_cpf.Text);
          if(ret == true )
          {
            Form3 form3 = new Form3();
            form3.Refresh();
            form3.dataGridView1.DataSource = metodos;
            form3.ShowDialog();
          }
          else
          {
            MessageBox.Show("Cpf inválido");
          }

            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Close();  
           
        }
    }
}
