namespace projeto4
{
    partial class FormRelatorioProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpb1 = new GroupBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            gpb2 = new GroupBox();
            cboAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            gpb3 = new GroupBox();
            cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            gpb1.SuspendLayout();
            gpb2.SuspendLayout();
            gpb3.SuspendLayout();
            SuspendLayout();
            // 
            // gpb1
            // 
            gpb1.Controls.Add(txtCidade);
            gpb1.Controls.Add(cboEstado);
            gpb1.Location = new Point(32, 81);
            gpb1.Name = "gpb1";
            gpb1.Size = new Size(448, 109);
            gpb1.TabIndex = 1;
            gpb1.TabStop = false;
            gpb1.Text = "Filtros";
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(20, 44);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(235, 48);
            txtCidade.TabIndex = 6;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(261, 43);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(135, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 7;
            // 
            // gpb2
            // 
            gpb2.Controls.Add(cboAgrupamento);
            gpb2.Location = new Point(32, 196);
            gpb2.Name = "gpb2";
            gpb2.Size = new Size(448, 109);
            gpb2.TabIndex = 5;
            gpb2.TabStop = false;
            gpb2.Text = "Agrupamento";
            // 
            // cboAgrupamento
            // 
            cboAgrupamento.AutoResize = false;
            cboAgrupamento.BackColor = Color.FromArgb(255, 255, 255);
            cboAgrupamento.Depth = 0;
            cboAgrupamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboAgrupamento.DropDownHeight = 174;
            cboAgrupamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgrupamento.DropDownWidth = 121;
            cboAgrupamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAgrupamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAgrupamento.FormattingEnabled = true;
            cboAgrupamento.Hint = "Agrupamento";
            cboAgrupamento.IntegralHeight = false;
            cboAgrupamento.ItemHeight = 43;
            cboAgrupamento.Location = new Point(20, 36);
            cboAgrupamento.MaxDropDownItems = 4;
            cboAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAgrupamento.Name = "cboAgrupamento";
            cboAgrupamento.Size = new Size(376, 49);
            cboAgrupamento.StartIndex = 0;
            cboAgrupamento.TabIndex = 0;
            // 
            // gpb3
            // 
            gpb3.Controls.Add(cboImpressora);
            gpb3.Location = new Point(32, 311);
            gpb3.Name = "gpb3";
            gpb3.Size = new Size(448, 109);
            gpb3.TabIndex = 6;
            gpb3.TabStop = false;
            gpb3.Text = "Impressora";
            // 
            // cboImpressora
            // 
            cboImpressora.AutoResize = false;
            cboImpressora.BackColor = Color.FromArgb(255, 255, 255);
            cboImpressora.Depth = 0;
            cboImpressora.DrawMode = DrawMode.OwnerDrawVariable;
            cboImpressora.DropDownHeight = 174;
            cboImpressora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboImpressora.DropDownWidth = 121;
            cboImpressora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboImpressora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboImpressora.FormattingEnabled = true;
            cboImpressora.Hint = "Impressora";
            cboImpressora.IntegralHeight = false;
            cboImpressora.ItemHeight = 43;
            cboImpressora.Location = new Point(20, 32);
            cboImpressora.MaxDropDownItems = 4;
            cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboImpressora.Name = "cboImpressora";
            cboImpressora.Size = new Size(376, 49);
            cboImpressora.StartIndex = 0;
            cboImpressora.TabIndex = 6;
            // 
            // btnImprimir
            // 
            btnImprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImprimir.Depth = 0;
            btnImprimir.HighEmphasis = true;
            btnImprimir.Icon = null;
            btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnImprimir.Location = new Point(143, 447);
            btnImprimir.Margin = new Padding(4, 6, 4, 6);
            btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.NoAccentTextColor = Color.Empty;
            btnImprimir.Size = new Size(87, 36);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImprimir.UseAccentColor = false;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVisualizar.Depth = 0;
            btnVisualizar.HighEmphasis = true;
            btnVisualizar.Icon = null;
            btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVisualizar.Location = new Point(238, 447);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(103, 36);
            btnVisualizar.TabIndex = 8;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // FormRelatorioProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 513);
            Controls.Add(btnVisualizar);
            Controls.Add(btnImprimir);
            Controls.Add(gpb3);
            Controls.Add(gpb2);
            Controls.Add(gpb1);
            Name = "FormRelatorioProfessor";
            Text = "Relatório de Professores";
            gpb1.ResumeLayout(false);
            gpb2.ResumeLayout(false);
            gpb3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private GroupBox gpb2;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgrupamento;
        private GroupBox gpb3;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
    }
}