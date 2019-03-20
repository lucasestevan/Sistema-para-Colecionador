Imports System.Data.SqlClient

Public Class btnCarregarfoto
    Private Sub btnPesquisarItem_Click(sender As Object, e As EventArgs) Handles btnPesquisarItem.Click
        Listar()
    End Sub

    'METODO LISTAR
    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM Itens", con)
            'PREENCHER A TABELA
            da.Fill(dt)
            dgItens.DataSource = dt

            ContarLinhas()
            FormatarDgPaciente()
        Catch ex As Exception
            MsgBox("Erro no metodo listar" + ex.Message, MsgBoxStyle.Critical, "Erro")
            fechar()
        End Try
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgItens.Rows.Count
        lblQtdTotal.Text = CInt(total)
    End Sub

    'METODO FORMATAR DATA GRID
    Private Sub FormatarDgPaciente()
        dgItens.Columns(0).Visible = False
        dgItens.Columns(1).HeaderText = "Tipo"
        dgItens.Columns(2).HeaderText = "Titulo"
        dgItens.Columns(3).HeaderText = "Valor"
        dgItens.Columns(4).HeaderText = "Qtd."
        dgItens.Columns(5).HeaderText = "Local Armazenado"
        dgItens.Columns(6).HeaderText = "Descrição"
        dgItens.Columns(7).Visible = False
        dgItens.Columns(8).HeaderText = "Original"
        dgItens.Columns(9).HeaderText = "Data de Cadastro"
        dgItens.Columns(10).Visible = False
    End Sub

    'BOTAO EXCLUIR ITEM
    Private Sub btnExcluirItem_Click(sender As Object, e As EventArgs) Handles btnExcluirItem.Click
        Dim cmd As SqlCommand

        If txtIdItem.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_excluirItemm", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_item", txtIdItem.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

                Listar()

                btnAlterarItem.Enabled = False
                btnExcluirItem.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao Excluir os dados " + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    'AO CLIKAR NA GRID JOGAR PARA O CAMPO ID ITEM PARA EXCLUIR
    Private Sub dgItens_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItens.CellClick
        txtIdItem.Text = dgItens.CurrentRow.Cells(0).Value
        btnAlterarItem.Enabled = True
        btnExcluirItem.Enabled = True
    End Sub

    Private Sub btnAlterarItem_Click(sender As Object, e As EventArgs) Handles btnAlterarItem.Click
        'ABRIR O FORM DE CAD DE item
        CadastroItem.Show()
        'HABILITAR OS CAMPOS PARA PODER ALTERAR
        habilitarCampos()
        CadastroItem.cmbTipo.Text = dgItens.CurrentRow.Cells(1).Value
        CadastroItem.txtTitulo.Text = dgItens.CurrentRow.Cells(2).Value
        CadastroItem.txtValorApx.Text = dgItens.CurrentRow.Cells(3).Value
        CadastroItem.txtQuantidade.Text = dgItens.CurrentRow.Cells(4).Value
        CadastroItem.txtLocalArm.Text = dgItens.CurrentRow.Cells(5).Value
        CadastroItem.txtDesc.Text = dgItens.CurrentRow.Cells(6).Value

        CadastroItem.rbOriginal.Text = dgItens.CurrentRow.Cells(8).Value
        CadastroItem.dtpCadastro.Text = dgItens.CurrentRow.Cells(9).Value

    End Sub

    'habilitar campos
    Private Sub habilitarCampos()
        CadastroItem.cmbTipo.Enabled = True
        CadastroItem.txtTitulo.Enabled = True
        CadastroItem.txtValorApx.Enabled = True
        CadastroItem.dtpCadastro.Enabled = True
        CadastroItem.txtLocalArm.Enabled = True
        CadastroItem.txtDesc.Enabled = True
        CadastroItem.txtTotal.Enabled = True
        CadastroItem.rbOriginal.Enabled = True
        CadastroItem.btnSalvar.Enabled = False
        CadastroItem.btnSalvarFoto.Enabled = True
        CadastroItem.btnCarregarFoto.Enabled = True
        CadastroItem.btnCarregarFoto.Enabled = True
        CadastroItem.btnNovo.Enabled = False
        CadastroItem.btnAlterarItem.Enabled = True
    End Sub

    Private Sub Pesquisar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitarCampos()
        Listar()
    End Sub

    Private Sub desabilitarCampos()
        btnAlterarItem.Enabled = False
        btnExcluirItem.Enabled = False
    End Sub
End Class