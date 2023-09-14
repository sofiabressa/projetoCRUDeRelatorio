using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto4
{
    public partial class FormCurso : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=127.0.0.1;" + "uid=root;" + "pwd=;" + "database=academico";

        public FormCurso()
        {
            InitializeComponent();
        }




        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome do curso é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAnoCriado.Text))
            {
                MessageBox.Show("Ano de criação é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnoCriado.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboTipo.Text))
            {
                MessageBox.Show("Tipo do curso é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipo.Focus();
                return false;
            }

            return true;
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

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();//estou abrindo o banco e posso dar inssertion e etc
            var sql = "";
            if (!isAlteracao)
            {
                sql = "INSERT INTO CURSO" + "(nome, tipo, ano_criado) VALUES (@nome, @tipo, @ano_criado)";

            }
            else
            {
                sql = "UPDATE CURSO SET " + "nome = @nome," + "tipo = @tipo," + "ano_criado = @ano_criado" + " WHERE id = @id";

            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@tipo", cboTipo.Text);
            cmd.Parameters.AddWithValue("@ano_criado", txtAnoCriado.Text);

            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txtId.Text);//ele é um auto incremento, então recebe o valor automáticamente depois da primeira vez
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            limpaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                if (ValidarFormulario())
                {
                    Salvar();
                    materialTabControl1.SelectedIndex = 1;//é para mover o tabcontrol 
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
            var sql = "SELECT * FROM CURSO";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM CURSO WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)//verifica se selecionou alguma linha
            {
                if (MessageBox.Show("Deseja realmente deletar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }

            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtAnoCriado.Text = linha.Cells["ano_criado"].Value.ToString();
                cboTipo.Text = linha.Cells["tipo"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
            materialTabControl1.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }
    }
}
