<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastroItem
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroItem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.dtpCadastro = New System.Windows.Forms.DateTimePicker()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        Me.rbOriginal = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLocalArm = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSalvarFoto = New System.Windows.Forms.Button()
        Me.btnAlterarFoto = New System.Windows.Forms.Button()
        Me.txtIdItem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAlterarItem = New System.Windows.Forms.Button()
        Me.txtQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.txtValorApx = New System.Windows.Forms.MaskedTextBox()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo do Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Titulo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valor Aprox:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data do Cadastro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descrição:"
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(123, 70)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(288, 20)
        Me.txtTitulo.TabIndex = 6
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.Color.White
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Camisa", "Copo", "Bandeira"})
        Me.cmbTipo.Location = New System.Drawing.Point(123, 34)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(236, 21)
        Me.cmbTipo.TabIndex = 31
        '
        'dtpCadastro
        '
        Me.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCadastro.Location = New System.Drawing.Point(123, 166)
        Me.dtpCadastro.Name = "dtpCadastro"
        Me.dtpCadastro.Size = New System.Drawing.Size(98, 20)
        Me.dtpCadastro.TabIndex = 33
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.Location = New System.Drawing.Point(122, 232)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(289, 77)
        Me.txtDesc.TabIndex = 34
        '
        'pbImagem
        '
        Me.pbImagem.ErrorImage = Nothing
        Me.pbImagem.Image = CType(resources.GetObject("pbImagem.Image"), System.Drawing.Image)
        Me.pbImagem.InitialImage = Nothing
        Me.pbImagem.Location = New System.Drawing.Point(466, 33)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(261, 235)
        Me.pbImagem.TabIndex = 35
        Me.pbImagem.TabStop = False
        '
        'rbOriginal
        '
        Me.rbOriginal.AutoSize = True
        Me.rbOriginal.Location = New System.Drawing.Point(123, 316)
        Me.rbOriginal.Name = "rbOriginal"
        Me.rbOriginal.Size = New System.Drawing.Size(74, 17)
        Me.rbOriginal.TabIndex = 38
        Me.rbOriginal.TabStop = True
        Me.rbOriginal.Text = "É original?"
        Me.rbOriginal.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Local armazenado:"
        '
        'txtLocalArm
        '
        Me.txtLocalArm.BackColor = System.Drawing.Color.White
        Me.txtLocalArm.Location = New System.Drawing.Point(122, 198)
        Me.txtLocalArm.Name = "txtLocalArm"
        Me.txtLocalArm.Size = New System.Drawing.Size(289, 20)
        Me.txtLocalArm.TabIndex = 40
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.LightGray
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(240, 372)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(97, 30)
        Me.btnSalvar.TabIndex = 41
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.LightGray
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNovo.Location = New System.Drawing.Point(83, 372)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(97, 30)
        Me.btnNovo.TabIndex = 42
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnSalvarFoto
        '
        Me.btnSalvarFoto.BackColor = System.Drawing.Color.LightGray
        Me.btnSalvarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalvarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarFoto.Location = New System.Drawing.Point(466, 276)
        Me.btnSalvarFoto.Name = "btnSalvarFoto"
        Me.btnSalvarFoto.Size = New System.Drawing.Size(97, 30)
        Me.btnSalvarFoto.TabIndex = 43
        Me.btnSalvarFoto.Text = "Salvar Foto"
        Me.btnSalvarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarFoto.UseVisualStyleBackColor = False
        '
        'btnAlterarFoto
        '
        Me.btnAlterarFoto.BackColor = System.Drawing.Color.LightGray
        Me.btnAlterarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlterarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterarFoto.Location = New System.Drawing.Point(630, 276)
        Me.btnAlterarFoto.Name = "btnAlterarFoto"
        Me.btnAlterarFoto.Size = New System.Drawing.Size(97, 30)
        Me.btnAlterarFoto.TabIndex = 44
        Me.btnAlterarFoto.Text = "Alterar Foto"
        Me.btnAlterarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlterarFoto.UseVisualStyleBackColor = False
        '
        'txtIdItem
        '
        Me.txtIdItem.BackColor = System.Drawing.Color.White
        Me.txtIdItem.Enabled = False
        Me.txtIdItem.Location = New System.Drawing.Point(608, 398)
        Me.txtIdItem.Name = "txtIdItem"
        Me.txtIdItem.Size = New System.Drawing.Size(69, 20)
        Me.txtIdItem.TabIndex = 45
        Me.txtIdItem.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(566, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Id Item"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Quantidade"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(240, 136)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(44, 20)
        Me.txtTotal.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(206, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Total:"
        '
        'btnAlterarItem
        '
        Me.btnAlterarItem.BackColor = System.Drawing.Color.LightGray
        Me.btnAlterarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlterarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterarItem.Location = New System.Drawing.Point(386, 372)
        Me.btnAlterarItem.Name = "btnAlterarItem"
        Me.btnAlterarItem.Size = New System.Drawing.Size(97, 30)
        Me.btnAlterarItem.TabIndex = 95
        Me.btnAlterarItem.Text = "Alterar"
        Me.btnAlterarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlterarItem.UseVisualStyleBackColor = False
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(123, 137)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(47, 20)
        Me.txtQuantidade.TabIndex = 96
        '
        'txtValorApx
        '
        Me.txtValorApx.Location = New System.Drawing.Point(122, 109)
        Me.txtValorApx.Mask = "000,00"
        Me.txtValorApx.Name = "txtValorApx"
        Me.txtValorApx.Size = New System.Drawing.Size(43, 20)
        Me.txtValorApx.TabIndex = 97
        '
        'CadastroItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 446)
        Me.Controls.Add(Me.txtValorApx)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.btnAlterarItem)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdItem)
        Me.Controls.Add(Me.btnAlterarFoto)
        Me.Controls.Add(Me.btnSalvarFoto)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtLocalArm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbOriginal)
        Me.Controls.Add(Me.pbImagem)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.dtpCadastro)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CadastroItem"
        Me.Text = "CadastroItem"
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents dtpCadastro As DateTimePicker
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents rbOriginal As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLocalArm As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSalvarFoto As Button
    Friend WithEvents btnAlterarFoto As Button
    Friend WithEvents txtIdItem As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAlterarItem As Button
    Friend WithEvents txtQuantidade As NumericUpDown
    Friend WithEvents txtValorApx As MaskedTextBox
End Class
