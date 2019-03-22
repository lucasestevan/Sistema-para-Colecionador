<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnCarregarfoto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(btnCarregarfoto))
        Me.btnPesquisarItem = New System.Windows.Forms.Button()
        Me.btnAlterarItem = New System.Windows.Forms.Button()
        Me.btnExcluirItem = New System.Windows.Forms.Button()
        Me.dgItens = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQtdTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdItem = New System.Windows.Forms.TextBox()
        Me.cmbTipoItem = New System.Windows.Forms.ComboBox()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.ComboBox()
        Me.txtLocalArm = New System.Windows.Forms.ComboBox()
        CType(Me.dgItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPesquisarItem
        '
        Me.btnPesquisarItem.BackColor = System.Drawing.Color.LightGray
        Me.btnPesquisarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPesquisarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisarItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPesquisarItem.Location = New System.Drawing.Point(512, 12)
        Me.btnPesquisarItem.Name = "btnPesquisarItem"
        Me.btnPesquisarItem.Size = New System.Drawing.Size(97, 37)
        Me.btnPesquisarItem.TabIndex = 95
        Me.btnPesquisarItem.Text = "Pesquisar"
        Me.btnPesquisarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisarItem.UseVisualStyleBackColor = False
        '
        'btnAlterarItem
        '
        Me.btnAlterarItem.BackColor = System.Drawing.Color.LightGray
        Me.btnAlterarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAlterarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterarItem.Location = New System.Drawing.Point(512, 61)
        Me.btnAlterarItem.Name = "btnAlterarItem"
        Me.btnAlterarItem.Size = New System.Drawing.Size(97, 37)
        Me.btnAlterarItem.TabIndex = 94
        Me.btnAlterarItem.Text = "Alterar"
        Me.btnAlterarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlterarItem.UseVisualStyleBackColor = False
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.BackColor = System.Drawing.Color.LightGray
        Me.btnExcluirItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirItem.Location = New System.Drawing.Point(512, 110)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Size = New System.Drawing.Size(97, 37)
        Me.btnExcluirItem.TabIndex = 93
        Me.btnExcluirItem.Text = "Excluir"
        Me.btnExcluirItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluirItem.UseVisualStyleBackColor = False
        '
        'dgItens
        '
        Me.dgItens.AllowUserToAddRows = False
        Me.dgItens.AllowUserToDeleteRows = False
        Me.dgItens.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItens.Location = New System.Drawing.Point(12, 138)
        Me.dgItens.MultiSelect = False
        Me.dgItens.Name = "dgItens"
        Me.dgItens.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItens.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgItens.Size = New System.Drawing.Size(483, 232)
        Me.dgItens.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Local armazenado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Titulo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Tipo do Item:"
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotal.Location = New System.Drawing.Point(456, 376)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(11, 13)
        Me.lblValorTotal.TabIndex = 104
        Me.lblValorTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(391, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Valor total:"
        '
        'lblQtdTotal
        '
        Me.lblQtdTotal.AutoSize = True
        Me.lblQtdTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblQtdTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdTotal.Location = New System.Drawing.Point(88, 377)
        Me.lblQtdTotal.Name = "lblQtdTotal"
        Me.lblQtdTotal.Size = New System.Drawing.Size(11, 13)
        Me.lblQtdTotal.TabIndex = 106
        Me.lblQtdTotal.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Quantidade:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(384, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Id Item"
        Me.Label7.Visible = False
        '
        'txtIdItem
        '
        Me.txtIdItem.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtIdItem.Enabled = False
        Me.txtIdItem.Location = New System.Drawing.Point(426, 19)
        Me.txtIdItem.Name = "txtIdItem"
        Me.txtIdItem.Size = New System.Drawing.Size(69, 20)
        Me.txtIdItem.TabIndex = 107
        Me.txtIdItem.Visible = False
        '
        'cmbTipoItem
        '
        Me.cmbTipoItem.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbTipoItem.FormattingEnabled = True
        Me.cmbTipoItem.Items.AddRange(New Object() {""})
        Me.cmbTipoItem.Location = New System.Drawing.Point(122, 18)
        Me.cmbTipoItem.Name = "cmbTipoItem"
        Me.cmbTipoItem.Size = New System.Drawing.Size(161, 21)
        Me.cmbTipoItem.TabIndex = 109
        '
        'btnVisualizar
        '
        Me.btnVisualizar.BackColor = System.Drawing.Color.LightGray
        Me.btnVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisualizar.Location = New System.Drawing.Point(512, 162)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(97, 37)
        Me.btnVisualizar.TabIndex = 110
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVisualizar.UseVisualStyleBackColor = False
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTitulo.FormattingEnabled = True
        Me.txtTitulo.Location = New System.Drawing.Point(122, 54)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(210, 21)
        Me.txtTitulo.TabIndex = 111
        '
        'txtLocalArm
        '
        Me.txtLocalArm.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtLocalArm.FormattingEnabled = True
        Me.txtLocalArm.Location = New System.Drawing.Point(122, 96)
        Me.txtLocalArm.Name = "txtLocalArm"
        Me.txtLocalArm.Size = New System.Drawing.Size(210, 21)
        Me.txtLocalArm.TabIndex = 112
        '
        'btnCarregarfoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 399)
        Me.Controls.Add(Me.txtLocalArm)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.cmbTipoItem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdItem)
        Me.Controls.Add(Me.lblQtdTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblValorTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgItens)
        Me.Controls.Add(Me.btnPesquisarItem)
        Me.Controls.Add(Me.btnAlterarItem)
        Me.Controls.Add(Me.btnExcluirItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "btnCarregarfoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPesquisarItem As Button
    Friend WithEvents btnAlterarItem As Button
    Friend WithEvents btnExcluirItem As Button
    Friend WithEvents dgItens As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblValorTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblQtdTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdItem As TextBox
    Friend WithEvents cmbTipoItem As ComboBox
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents txtTitulo As ComboBox
    Friend WithEvents txtLocalArm As ComboBox
End Class
