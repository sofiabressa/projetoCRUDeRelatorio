namespace projeto4
{
    partial class FormRelatorioAluno
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
            this.gpb1 = new System.Windows.Forms.GroupBox();
            this.txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            this.gpb2 = new System.Windows.Forms.GroupBox();
            this.cboAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            this.gpb3 = new System.Windows.Forms.GroupBox();
            this.cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            this.btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            this.gpb1.SuspendLayout();
            this.gpb2.SuspendLayout();
            this.gpb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb1
            // 
            this.gpb1.Controls.Add(this.txtCidade);
            this.gpb1.Controls.Add(this.cboEstado);
            this.gpb1.Location = new System.Drawing.Point(34, 94);
            this.gpb1.Name = "gpb1";
            this.gpb1.Size = new System.Drawing.Size(448, 109);
            this.gpb1.TabIndex = 0;
            this.gpb1.TabStop = false;
            this.gpb1.Text = "Filtros";
            // 
            // txtCidade
            // 
            this.txtCidade.AnimateReadOnly = false;
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCidade.Depth = 0;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.HideSelection = true;
            this.txtCidade.Hint = "Cidade";
            this.txtCidade.LeadingIcon = null;
            this.txtCidade.Location = new System.Drawing.Point(20, 44);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.PrefixSuffixText = null;
            this.txtCidade.ReadOnly = false;
            this.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(235, 48);
            this.txtCidade.TabIndex = 6;
            this.txtCidade.TabStop = false;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCidade.TrailingIcon = null;
            this.txtCidade.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            this.cboEstado.AutoResize = false;
            this.cboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboEstado.Depth = 0;
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboEstado.DropDownHeight = 174;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.DropDownWidth = 121;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Hint = "Estado";
            this.cboEstado.IntegralHeight = false;
            this.cboEstado.ItemHeight = 43;
            this.cboEstado.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(261, 43);
            this.cboEstado.MaxDropDownItems = 4;
            this.cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(135, 49);
            this.cboEstado.StartIndex = 0;
            this.cboEstado.TabIndex = 7;
            // 
            // gpb2
            // 
            this.gpb2.Controls.Add(this.cboAgrupamento);
            this.gpb2.Location = new System.Drawing.Point(34, 209);
            this.gpb2.Name = "gpb2";
            this.gpb2.Size = new System.Drawing.Size(448, 109);
            this.gpb2.TabIndex = 4;
            this.gpb2.TabStop = false;
            this.gpb2.Text = "Agrupamento";
            // 
            // cboAgrupamento
            // 
            this.cboAgrupamento.AutoResize = false;
            this.cboAgrupamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboAgrupamento.Depth = 0;
            this.cboAgrupamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAgrupamento.DropDownHeight = 174;
            this.cboAgrupamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgrupamento.DropDownWidth = 121;
            this.cboAgrupamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboAgrupamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboAgrupamento.FormattingEnabled = true;
            this.cboAgrupamento.Hint = "Agrupamento";
            this.cboAgrupamento.IntegralHeight = false;
            this.cboAgrupamento.ItemHeight = 43;
            this.cboAgrupamento.Location = new System.Drawing.Point(20, 36);
            this.cboAgrupamento.MaxDropDownItems = 4;
            this.cboAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboAgrupamento.Name = "cboAgrupamento";
            this.cboAgrupamento.Size = new System.Drawing.Size(376, 49);
            this.cboAgrupamento.StartIndex = 0;
            this.cboAgrupamento.TabIndex = 0;
            // 
            // gpb3
            // 
            this.gpb3.Controls.Add(this.cboImpressora);
            this.gpb3.Location = new System.Drawing.Point(34, 324);
            this.gpb3.Name = "gpb3";
            this.gpb3.Size = new System.Drawing.Size(448, 109);
            this.gpb3.TabIndex = 5;
            this.gpb3.TabStop = false;
            this.gpb3.Text = "Impressora";
            // 
            // cboImpressora
            // 
            this.cboImpressora.AutoResize = false;
            this.cboImpressora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboImpressora.Depth = 0;
            this.cboImpressora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboImpressora.DropDownHeight = 174;
            this.cboImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpressora.DropDownWidth = 121;
            this.cboImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboImpressora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboImpressora.FormattingEnabled = true;
            this.cboImpressora.Hint = "Impressora";
            this.cboImpressora.IntegralHeight = false;
            this.cboImpressora.ItemHeight = 43;
            this.cboImpressora.Location = new System.Drawing.Point(20, 32);
            this.cboImpressora.MaxDropDownItems = 4;
            this.cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboImpressora.Name = "cboImpressora";
            this.cboImpressora.Size = new System.Drawing.Size(376, 49);
            this.cboImpressora.StartIndex = 0;
            this.cboImpressora.TabIndex = 6;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.HighEmphasis = true;
            this.btnImprimir.Icon = null;
            this.btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnImprimir.Location = new System.Drawing.Point(151, 467);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImprimir.Size = new System.Drawing.Size(87, 36);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImprimir.UseAccentColor = false;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVisualizar.Depth = 0;
            this.btnVisualizar.HighEmphasis = true;
            this.btnVisualizar.Icon = null;
            this.btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVisualizar.Location = new System.Drawing.Point(246, 467);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVisualizar.Size = new System.Drawing.Size(103, 36);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVisualizar.UseAccentColor = false;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // FormRelatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 528);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gpb3);
            this.Controls.Add(this.gpb2);
            this.Controls.Add(this.gpb1);
            this.Name = "FormRelatorioAluno";
            this.Text = "Relatório de Alunos";
            this.gpb1.ResumeLayout(false);
            this.gpb2.ResumeLayout(false);
            this.gpb3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gpb1;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private GroupBox gpb2;
        private GroupBox gpb3;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
    }
}