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
    public partial class FormRelatorioAluno : MaterialForm
    {
        public FormRelatorioAluno()
        {
            InitializeComponent();
            CarregaImpressoras();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregaImpressoras()
        {
            foreach (string printer in 
                System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }
    }
}
