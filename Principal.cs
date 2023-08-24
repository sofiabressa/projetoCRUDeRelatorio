
using ReaLTaiizor.Forms;
namespace projeto4
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}