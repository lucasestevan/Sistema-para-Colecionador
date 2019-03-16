Imports System.Data.SqlClient

Public Class CadastroItem
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged

    End Sub

    Private Sub cmbSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged

    End Sub


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
        btnSalvarFoto.Enabled = False
        btnAlterarFoto.Enabled = False
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
        rbOriginal.Checked = False
    End Sub

    'habilitar campos
    Private Sub habilitarCampos()
        cmbTipo.Enabled = True
        txtTitulo.Enabled = True
        txtValorApx.Enabled = True
        txtLocalArm.Enabled = True
        txtDesc.Enabled = True
        txtTotal.Enabled = True
        txtQuantidade.Enabled = True
        rbOriginal.Enabled = True
        btnSalvar.Enabled = True
        btnSalvarFoto.Enabled = True
        btnAlterarFoto.Enabled = True
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
                cmd = New SqlCommand("sp_salvarItemm", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@tipoItem", cmbTipo.Text)
                cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
                cmd.Parameters.AddWithValue("@valor", txtValorApx.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@localArmazenado", txtLocalArm.Text)
                cmd.Parameters.AddWithValue("@descricao", txtDesc.Text)
                cmd.Parameters.AddWithValue("@original", rbOriginal.Checked = "1")
                cmd.Parameters.AddWithValue("@data_cadastro", dtpCadastro.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                LimparCampos()
                desabilitarCampos()
                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao Salvar os dados" + ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show("Insira os dados nos campos vazios")
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    'BOTAO ALTERAR item
    Private Sub btnAlterarItem_Click(sender As Object, e As EventArgs) Handles btnAlterarItem.Click
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("sp_editarItemm", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_item", txtIdItem.Text)
            cmd.Parameters.AddWithValue("@tipoItem", cmbTipo.Text)
            cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
            cmd.Parameters.AddWithValue("@valor", txtValorApx.Text)
            cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
            cmd.Parameters.AddWithValue("@localArmazenado", txtLocalArm.Text)
            cmd.Parameters.AddWithValue("@descricao", txtDesc.Text)
            cmd.Parameters.AddWithValue("@original", rbOriginal.Text)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao alterar os dados" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub txtQuantidade_ValueChanged(sender As Object, e As EventArgs) Handles txtQuantidade.ValueChanged

    End Sub
End Class