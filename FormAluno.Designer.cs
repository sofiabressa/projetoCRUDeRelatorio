namespace projeto4
{
    partial class FormAluno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            this.mmtbDtNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            this.btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(684, 451);
            this.materialTabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.cboEstado);
            this.tabPage1.Controls.Add(this.mmtbDtNascimento);
            this.tabPage1.Controls.Add(this.txtSenha);
            this.tabPage1.Controls.Add(this.txtCidade);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtMatricula);
            this.tabPage1.ImageKey = "form.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "ID";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(456, 21);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(135, 48);
            this.txtId.TabIndex = 100;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSalvar.Location = new System.Drawing.Point(343, 336);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(76, 36);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(239, 336);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.cboEstado.Location = new System.Drawing.Point(456, 150);
            this.cboEstado.MaxDropDownItems = 4;
            this.cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(135, 49);
            this.cboEstado.StartIndex = 0;
            this.cboEstado.TabIndex = 6;
            // 
            // mmtbDtNascimento
            // 
            this.mmtbDtNascimento.AllowPromptAsInput = true;
            this.mmtbDtNascimento.AnimateReadOnly = false;
            this.mmtbDtNascimento.AsciiOnly = false;
            this.mmtbDtNascimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmtbDtNascimento.BeepOnError = false;
            this.mmtbDtNascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtbDtNascimento.Depth = 0;
            this.mmtbDtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mmtbDtNascimento.HidePromptOnLeave = false;
            this.mmtbDtNascimento.HideSelection = true;
            this.mmtbDtNascimento.Hint = "Data de nascimento";
            this.mmtbDtNascimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mmtbDtNascimento.LeadingIcon = null;
            this.mmtbDtNascimento.Location = new System.Drawing.Point(456, 85);
            this.mmtbDtNascimento.Mask = "99/99/9999";
            this.mmtbDtNascimento.MaxLength = 32767;
            this.mmtbDtNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mmtbDtNascimento.Name = "mmtbDtNascimento";
            this.mmtbDtNascimento.PasswordChar = '\0';
            this.mmtbDtNascimento.PrefixSuffixText = null;
            this.mmtbDtNascimento.PromptChar = '_';
            this.mmtbDtNascimento.ReadOnly = false;
            this.mmtbDtNascimento.RejectInputOnFirstFailure = false;
            this.mmtbDtNascimento.ResetOnPrompt = true;
            this.mmtbDtNascimento.ResetOnSpace = true;
            this.mmtbDtNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmtbDtNascimento.SelectedText = "";
            this.mmtbDtNascimento.SelectionLength = 0;
            this.mmtbDtNascimento.SelectionStart = 0;
            this.mmtbDtNascimento.ShortcutsEnabled = true;
            this.mmtbDtNascimento.Size = new System.Drawing.Size(135, 48);
            this.mmtbDtNascimento.SkipLiterals = true;
            this.mmtbDtNascimento.TabIndex = 2;
            this.mmtbDtNascimento.TabStop = false;
            this.mmtbDtNascimento.Text = "  /  /";
            this.mmtbDtNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmtbDtNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mmtbDtNascimento.TrailingIcon = null;
            this.mmtbDtNascimento.UseSystemPasswordChar = false;
            this.mmtbDtNascimento.ValidatingType = null;
            // 
            // txtSenha
            // 
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.HideSelection = true;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.LeadingIcon = global::projeto4.Properties.Resources.baseline_fingerprint_black_24dp;
            this.txtSenha.Location = new System.Drawing.Point(17, 266);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.PrefixSuffixText = null;
            this.txtSenha.ReadOnly = false;
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(574, 48);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.TabStop = false;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.UseSystemPasswordChar = false;
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
            this.txtCidade.Location = new System.Drawing.Point(356, 212);
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
            this.txtCidade.TabIndex = 5;
            this.txtCidade.TabStop = false;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCidade.TrailingIcon = null;
            this.txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            this.txtBairro.AnimateReadOnly = false;
            this.txtBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.HideSelection = true;
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.LeadingIcon = null;
            this.txtBairro.Location = new System.Drawing.Point(17, 212);
            this.txtBairro.MaxLength = 32767;
            this.txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.PrefixSuffixText = null;
            this.txtBairro.ReadOnly = false;
            this.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(331, 48);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.TabStop = false;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBairro.TrailingIcon = null;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AnimateReadOnly = false;
            this.txtEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndereco.HideSelection = true;
            this.txtEndereco.Hint = "Endereço";
            this.txtEndereco.LeadingIcon = null;
            this.txtEndereco.Location = new System.Drawing.Point(17, 150);
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PrefixSuffixText = null;
            this.txtEndereco.ReadOnly = false;
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.ShortcutsEnabled = true;
            this.txtEndereco.Size = new System.Drawing.Size(433, 48);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEndereco.TrailingIcon = null;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(17, 85);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(433, 48);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.AnimateReadOnly = false;
            this.txtMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatricula.Depth = 0;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatricula.HideSelection = true;
            this.txtMatricula.Hint = "Matrícula";
            this.txtMatricula.LeadingIcon = null;
            this.txtMatricula.Location = new System.Drawing.Point(17, 21);
            this.txtMatricula.MaxLength = 32767;
            this.txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PasswordChar = '\0';
            this.txtMatricula.PrefixSuffixText = null;
            this.txtMatricula.ReadOnly = false;
            this.txtMatricula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMatricula.SelectedText = "";
            this.txtMatricula.SelectionLength = 0;
            this.txtMatricula.SelectionStart = 0;
            this.txtMatricula.ShortcutsEnabled = true;
            this.txtMatricula.Size = new System.Drawing.Size(433, 48);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TabStop = false;
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatricula.TrailingIcon = null;
            this.txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnNovo);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.ImageKey = "search.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnExcluir.Location = new System.Drawing.Point(385, 328);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcluir.Size = new System.Drawing.Size(89, 36);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEditar.Location = new System.Drawing.Point(285, 328);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(81, 36);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNovo.Depth = 0;
            this.btnNovo.HighEmphasis = true;
            this.btnNovo.Icon = null;
            this.btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnNovo.Location = new System.Drawing.Point(203, 328);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNovo.Size = new System.Drawing.Size(64, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNovo.UseAccentColor = false;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.png");
            this.imageList1.Images.SetKeyName(1, "search.png");
            this.imageList1.Images.SetKeyName(2, "form.png");
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 518);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FormAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Aluno";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbDtNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private TabPage tabPage2;
        private ImageList imageList1;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}