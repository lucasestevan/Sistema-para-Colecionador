Imports System.Data.SqlClient

Public Class Pesquisar
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
End Class