Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports alfathNET

Module Module1
    Public conn As New OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String
    Public db As Database
    Public Sub koneksi()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=db_penjualan;server=localhost;uid=root"
        conn = New OdbcConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()


    End Sub

    
End Module
