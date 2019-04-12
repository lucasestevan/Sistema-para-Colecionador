Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO


Public Class CadastroItem

    Private Sub CadastroItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitarCampos()


    End Sub


    'DESABILITAR CAMPOS
    Private Sub desabilitarCampos()
        cmbTipo.Enabled = False
        txtTitulo.Enabled = False
        txtValorApx.Enabled = False
        txtQuantidade.Enabled = False
        dtpCadastro.Enabled = False
        txtLocalArm.Enabled = False
        txtTotal.Enabled = False
        txtDesc.Enabled = False
        rbOriginal.Enabled = False
        btnSalvar.Enabled = False

        btnCarregarFoto.Enabled = False
        btnAlterarItem.Enabled = False
    End Sub


    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        habilitarCampos()
        LimparCampos()
    End Sub

    'LIMPAR CAMPOS
    Private Sub LimparCampos()
        cmbTipo.Text = ""
        txtTitulo.Text = ""
        txtValorApx.Text = ""
        txtLocalArm.Text = ""
        txtTotal.Text = ""
        txtDesc.Text = ""
        txtQuantidade.Text = ""
        rbOriginal.Checked = False

    End Sub

    'habilitar campos
    Private Sub habilitarCampos()
        cmbTipo.Enabled = True
        txtTitulo.Enabled = True
        txtValorApx.Enabled = True
        txtLocalArm.Enabled = True
        txtDesc.Enabled = True
        txtQuantidade.Enabled = True
        rbOriginal.Enabled = True
        btnSalvar.Enabled = True

        btnCarregarFoto.Enabled = True
    End Sub

    Private Sub btnSalvarFoto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand


        'SE OS CAMPOS NÃO ESTIVEREM VAZIO FACA
        If cmbTipo.Text <> "" And
            txtTitulo.Text <> "" And
            txtQuantidade.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_salvarItem", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@tipoItem", cmbTipo.Text)
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
                cmd.Parameters.AddWithValue("@valor", txtValorApx.Text)
                cmd.Parameters.AddWithValue("@valorTotal", txtTotal.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@localArmazenado", txtLocalArm.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDesc.Text)
                cmd.Parameters.AddWithValue("@original", rbOriginal.Checked = "1")
                cmd.Parameters.AddWithValue("@data_cadastro", dtpCadastro.Text)
                Using ms As New IO.MemoryStream
                    ImageAUsar.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim picImagem = ms.ToArray
                    cmd.Parameters.AddWithValue("@imagem", picImagem)

                    cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2

                    cmd.ExecuteNonQuery()

                    Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                    LimparCampos()
                    desabilitarCampos()
                    btnSalvar.Enabled = False
                End Using
            Catch ex As Exception
                MessageBox.Show("Erro ao Salvar os dados" + ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show("Insira os dados nos campos vazios")
        End If
    End Sub


    'BOTAO ALTERAR item
    Private Sub btnAlterarItem_Click(sender As Object, e As EventArgs) Handles btnAlterarItem.Click
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("sp_editarItem", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_item", txtIdItem.Text)
            cmd.Parameters.AddWithValue("@tipoItem", cmbTipo.Text)
            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
            cmd.Parameters.AddWithValue("@valor", txtValorApx.Text)
            cmd.Parameters.AddWithValue("@valorTotal", txtTotal.Text)
            cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
            cmd.Parameters.AddWithValue("@localArmazenado", txtLocalArm.Text)
            cmd.Parameters.AddWithValue("@descricao", txtDesc.Text)
            cmd.Parameters.AddWithValue("@original", rbOriginal.Text)
            Using ms As New IO.MemoryStream
                ImageAUsar.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picImagem = ms.ToArray
                cmd.Parameters.AddWithValue("@imagem", picImagem)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2

                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar os dados" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub txtQuantidade_ValueChanged(sender As Object, e As EventArgs)



    End Sub

    Dim ImageAUsar As Image

    'CAREEGAR IMAGEM
    Private Sub CarregarImagem()
        'ABRIR CAIXA DE DIALOGO 

        Using OFD As New OpenFileDialog With {.Filter = "image file(*.jpg; *.bmp; *.gif; *.png) |*.jpg; *.bmp; *.gif; *.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImageAUsar = Image.FromFile(OFD.FileName)
                picImagem.Image = ImageAUsar

            End If

        End Using

    End Sub

    Private Sub btnCarregarFoto_Click(sender As Object, e As EventArgs) Handles btnCarregarFoto.Click
        CarregarImagem()
    End Sub

    Private Sub cmbTipo_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbTipo.MouseClick
        CarregaTipoItem()
    End Sub

    Private Sub CarregaTipoItem()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM Itens", con)
            'PREENCHER A TABELA
            da.Fill(dt)
            cmbTipo.DisplayMember = "tipoItem"
            cmbTipo.ValueMember = "id_item"
            cmbTipo.DataSource = dt


        Catch ex As Exception
            MsgBox("Erro no metodo listar" + ex.Message, MsgBoxStyle.Critical, "Erro")
            fechar()
        End Try
    End Sub


    Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged

        If txtQuantidade.Text = "" Then

        Else
            Dim numero1, numero2, soma As Integer
            numero1 = txtValorApx.Text
            numero2 = txtQuantidade.Text
            soma = numero1 * numero2
            txtTotal.Text = soma
        End If

    End Sub

End Class