<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizarItem))
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblLocal = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picImagem
        '
        Me.picImagem.ErrorImage = Nothing
        Me.picImagem.Image = CType(resources.GetObject("picImagem.Image"), System.Drawing.Image)
        Me.picImagem.InitialImage = Nothing
        Me.picImagem.Location = New System.Drawing.Point(39, 12)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(235, 220)
        Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagem.TabIndex = 36
        Me.picImagem.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Titulo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Valor Aprox:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Tipo do Item:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Data do Cadastro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Local armazenado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Descrição:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(105, 16)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(10, 13)
        Me.lblTitulo.TabIndex = 110
        Me.lblTitulo.Text = "-"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(105, 42)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(10, 13)
        Me.lblTipo.TabIndex = 111
        Me.lblTipo.Text = "-"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(105, 68)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(10, 13)
        Me.lblValor.TabIndex = 112
        Me.lblValor.Text = "-"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(105, 93)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(10, 13)
        Me.lblData.TabIndex = 113
        Me.lblData.Text = "-"
        '
        'lblLocal
        '
        Me.lblLocal.AutoSize = True
        Me.lblLocal.Location = New System.Drawing.Point(105, 120)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(10, 13)
        Me.lblLocal.TabIndex = 114
        Me.lblLocal.Text = "-"
        '
        'lblDesc
        '
        Me.lblDesc.AutoEllipsis = True
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(105, 148)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDesc.Size = New System.Drawing.Size(10, 13)
        Me.lblDesc.TabIndex = 115
        Me.lblDesc.Text = "-"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblDesc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblLocal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblData)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTitulo)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 231)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        '
        'VisualizarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(315, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picImagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "VisualizarItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picImagem As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblLocal As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
