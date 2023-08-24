using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace projeto4
{
    public partial class FormAluno : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=127.0.0.1;" + "uid=root;" + "pwd=;" + "database=academico";//Estou iniciando o banco na string -> string de conexão
        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {

        }

        private void txtMatricula_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereco é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }
            if (!DateTime.TryParse(mmtbDtNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de nascimento é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mmtbDtNascimento.Focus();
                return false;
            }

            return true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
            
        }

        private void limpaCampos()
        {
            isAlteracao = false;

            foreach (var control in tabPage1.Controls) // vai percorrer todos os meus componentes da page 1
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }


            }
        }

        private void CarregaGrid()
        {
            //ativar as seguintes´propriedades:
            //ALLOW USER TO ADD ROWS -> False
            //ALLOW USER TO DELETE ROWS -> False
            //SELECTION MODE -> FullRowSelect
            //MULTISELECT -> False
            //READY ONLY -> True
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();//estou abrindo o banco e posso dar inssertion e etc
            if (!isAlteracao)
            {
                var sql = "INSERT INTO aluno" + "(matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha) VALUES (@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
                var cmd = new MySqlCommand(sql, con);
                DateTime.TryParse(mmtbDtNascimento.Text, out var dtNascimento);
                cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                cmd.Parameters.AddWithValue("@dt_nascimento", dtNascimento);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@estado", cboEstado.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
            limpaCampos();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
