Imports System.Data.SqlClient
Imports System.IO

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
            totalizar()
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
        dgItens.Columns(3).HeaderText = "Valor aprox"
        dgItens.Columns(4).HeaderText = "Qtd."
        dgItens.Columns(5).HeaderText = "Local Armazenado"
        dgItens.Columns(6).HeaderText = "Descrição"
        dgItens.Columns(7).HeaderText = "Foto"
        dgItens.Columns(8).HeaderText = "Original"
        dgItens.Columns(9).HeaderText = "Data de Cadastro"
        dgItens.Columns(10).Visible = False
        dgItens.Columns(11).HeaderText = "Valor total"
        dgItens.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

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
        btnVisualizar.Enabled = True
    End Sub

    Private Sub btnAlterarItem_Click(sender As Object, e As EventArgs) Handles btnAlterarItem.Click
        'ABRIR O FORM DE CAD DE item
        CadastroItem.Show()
        'HABILITAR OS CAMPOS PARA PODER ALTERAR
        habilitarCampos()
        CadastroItem.txtIdItem.Text = dgItens.CurrentRow.Cells(0).Value
        CadastroItem.cmbTipo.Text = dgItens.CurrentRow.Cells(1).Value
        CadastroItem.txtTitulo.Text = dgItens.CurrentRow.Cells(2).Value
        CadastroItem.txtValorApx.Text = dgItens.CurrentRow.Cells(3).Value
        CadastroItem.txtQuantidade.Text = dgItens.CurrentRow.Cells(4).Value
        CadastroItem.txtLocalArm.Text = dgItens.CurrentRow.Cells(5).Value
        CadastroItem.txtDesc.Text = dgItens.CurrentRow.Cells(6).Value
        CadastroItem.dtpCadastro.Text = dgItens.CurrentRow.Cells(9).Value

    End Sub

    'habilitar campos
    Private Sub habilitarCampos()
        CadastroItem.cmbTipo.Enabled = True
        CadastroItem.txtTitulo.Enabled = True
        CadastroItem.txtValorApx.Enabled = True
        CadastroItem.txtLocalArm.Enabled = True
        CadastroItem.txtDesc.Enabled = True
        CadastroItem.txtQuantidade.Enabled = True
        CadastroItem.rbOriginal.Enabled = True
        CadastroItem.btnSalvar.Enabled = False
        CadastroItem.btnCarregarFoto.Enabled = True
        CadastroItem.btnCarregarFoto.Enabled = True
        CadastroItem.btnNovo.Enabled = False
        CadastroItem.btnAlterarItem.Enabled = True
    End Sub

    Private Sub Pesquisar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desabilitarCampos()

    End Sub

    Private Sub desabilitarCampos()
        btnAlterarItem.Enabled = False
        btnExcluirItem.Enabled = False
        btnVisualizar.Enabled = False

    End Sub

    Private Sub btnVizualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        'ABRIR O FORM DE visualizar
        VisualizarItem.Show()

        '' PUXAR A IMAGEM DO BANCO DE DADOS
        abrir()
        Using cmd As New SqlCommand("select imagem from Itens where id_item=@id_item", con)
            cmd.Parameters.AddWithValue("@id_item", txtIdItem.Text)
            Dim tempImagem As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            If tempImagem Is Nothing Then
                MessageBox.Show("Imagem não localizada", "Erro")
                Exit Sub
            Else
                Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
                Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
                fs.Write(tempImagem, 0, tempImagem.Length)
                fs.Flush()
                fs.Close()
                VisualizarItem.picImagem.Image = Image.FromFile(strArquivo)
            End If

            'JOGAR OQUE TA NA GRID NOS LABELS
            VisualizarItem.lblTipo.Text = dgItens.CurrentRow.Cells(1).Value
            VisualizarItem.lblTitulo.Text = dgItens.CurrentRow.Cells(2).Value
            VisualizarItem.lblQuantidade.Text = dgItens.CurrentRow.Cells(4).Value
            VisualizarItem.lblValor.Text = dgItens.CurrentRow.Cells(11).Value
            VisualizarItem.lblLocal.Text = dgItens.CurrentRow.Cells(5).Value
            VisualizarItem.lblDesc.Text = dgItens.CurrentRow.Cells(6).Value
            VisualizarItem.lblData.Text = dgItens.CurrentRow.Cells(9).Value
        End Using



    End Sub

    'METODO TOTALIZAR
    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dgItens.Rows
            total = total + lin.Cells(11).Value
        Next

        lblValorTotal.Text = total
    End Sub

    Private Sub cmbTipoItem_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoItem.TextChanged
        If cmbTipoItem.Text = "" Then

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarItemTipoo", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@tipoItem", cmbTipoItem.Text)
                da.Fill(dt)
                dgItens.DataSource = dt
                ContarLinhas()
                totalizar()

            Catch ex As Exception
                MessageBox.Show("erro ao listar" + ex.Message)
                fechar()

            End Try
        End If
    End Sub

    'PESQUISAR PELO TITULO
    Private Sub txtTitulo_TextChanged_1(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged
        If txtTitulo.Text = "" Then

        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarItemNomee", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
                da.Fill(dt)
                dgItens.DataSource = dt


                ContarLinhas()
                totalizar()


            Catch ex As Exception
                MessageBox.Show("erro ao listar" + ex.Message)
                fechar()

            End Try
        End If
    End Sub

    'PESQUISAR PELO LOCAL
    Private Sub txtLocalArm_TextChanged_1(sender As Object, e As EventArgs) Handles txtLocalArm.TextChanged
        If txtLocalArm.Text = "" Then

        Else

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_BuscarItemLocall", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@localArmazenado", txtLocalArm.Text)
                da.Fill(dt)
                dgItens.DataSource = dt

                ContarLinhas()
                totalizar()

            Catch ex As Exception
                MessageBox.Show("erro ao listar" + ex.Message)
                fechar()

            End Try
        End If
    End Sub

    Private Sub CarregaTipoItem()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM Itens", con)
            'PREENCHER A TABELA
            da.Fill(dt)
            cmbTipoItem.DisplayMember = "tipoItem"
            cmbTipoItem.ValueMember = "id_item"
            cmbTipoItem.DataSource = dt
            totalizar()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro no metodo listar" + ex.Message, MsgBoxStyle.Critical, "Erro")
            fechar()
        End Try
    End Sub

    Private Sub CarregaTitulo()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM Itens", con)
            'PREENCHER A TABELA
            da.Fill(dt)
            txtTitulo.DisplayMember = "Titulo"
            txtTitulo.ValueMember = "id_item"
            txtTitulo.DataSource = dt
            totalizar()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro no metodo listar" + ex.Message, MsgBoxStyle.Critical, "Erro")
            fechar()
        End Try
    End Sub


    Private Sub CarregarLocalItem()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM Itens", con)
            'PREENCHER A TABELA
            da.Fill(dt)
            txtLocalArm.DisplayMember = "localArmazenado"
            txtLocalArm.ValueMember = "id_item"
            txtLocalArm.DataSource = dt
            totalizar()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro no metodo listar" + ex.Message, MsgBoxStyle.Critical, "Erro")
            fechar()
        End Try
    End Sub

    'CARREGAR OS ITENS AO CLIKAR NO COMBO BOX
    Private Sub cmbTipoItem_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbTipoItem.MouseClick
        CarregaTipoItem()

    End Sub

    Private Sub txtTitulo_MouseClick(sender As Object, e As MouseEventArgs) Handles txtTitulo.MouseClick
        CarregaTitulo()
    End Sub

    Private Sub txtLocalArm_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLocalArm.MouseClick
        CarregarLocalItem()
    End Sub
End Class
