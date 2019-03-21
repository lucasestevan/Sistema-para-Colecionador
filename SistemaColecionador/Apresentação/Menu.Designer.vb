<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.btnCadastro = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCadastro
        '
        Me.btnCadastro.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastro.BackgroundImage = CType(resources.GetObject("btnCadastro.BackgroundImage"), System.Drawing.Image)
        Me.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastro.FlatAppearance.BorderSize = 0
        Me.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastro.ForeColor = System.Drawing.Color.Transparent
        Me.btnCadastro.Location = New System.Drawing.Point(34, 40)
        Me.btnCadastro.Name = "btnCadastro"
        Me.btnCadastro.Size = New System.Drawing.Size(183, 225)
        Me.btnCadastro.TabIndex = 1
        Me.btnCadastro.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisar.BackgroundImage = CType(resources.GetObject("btnPesquisar.BackgroundImage"), System.Drawing.Image)
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.FlatAppearance.BorderSize = 0
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.ForeColor = System.Drawing.Color.Transparent
        Me.btnPesquisar.Location = New System.Drawing.Point(260, 30)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(204, 235)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(476, 292)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnCadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCadastro As Button
    Friend WithEvents btnPesquisar As Button
End Class
