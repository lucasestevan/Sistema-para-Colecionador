Imports System.Data.SqlClient

Module Conexao
    'CRIAR CONEXAO COM BD SERVER
    Public con As New SqlConnection("Data Source = DESKTOP-LVOTD2H\SQLEXPRESS; INITIAL CATALOG = SistemaColecionador; Integrated Security = SSPI")

    'METODO ABRIR CONEXAO
    Sub abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    'METODO FECHAR CONEXAO
    Sub fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub
End Module
