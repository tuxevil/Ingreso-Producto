Public Class C_baradmin

    Public Sub add_consumo()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "insert into dbo.CONSUMO (cod_tarjeta, cod_clase, cod_tipo, cod_subtipo, cantidad, status) values (" & codCliente & "," & codClase & "," & codTipo & "," & codSubTipo & "," & cantidadProd & ",'A')"
        cm.ExecuteReader()
        db.Close()
        MessageBox.Show("Producto agregado con exito")
    End Sub
    Public Sub add_mesa()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "insert into dbo.CONSUMO2 (cod_mesa, cod_mesero, cod_clase, cod_tipo, cod_subtipo, cantidad, status) values (" & codMesa & "," & codMesero & "," & codClase & "," & codTipo & "," & codSubTipo & "," & cantidadProd & ",'A')"
        cm.ExecuteReader()
        db.Close()
        MessageBox.Show("Producto agregado con exito")
    End Sub
    Public Sub add_abono()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        If codCliente <> Nothing Then
            cm.CommandText = "insert into dbo.[DETALLE-PAGO] (cod_tarjeta, cod_formapago, valor) values (" & codCliente & "," & codFormaPago & "," & abono & ")"
        ElseIf codMesa <> Nothing Then
            cm.CommandText = "insert into dbo.[DETALLE-PAGO2] (cod_mesa, cod_formapago, valor, status) values (" & codMesa & "," & codFormaPago & "," & abono & ", 'A')"
        End If
        cm.ExecuteReader()
        db.Close()
    End Sub
    Public Sub cerrar_cuenta()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        If codCliente <> Nothing Then
            cm.CommandText = "update dbo.tarjeta set status= 'X' where codigo = " & codCliente
        ElseIf codMesa <> Nothing Then
            cm.CommandText = "update dbo.consumo2 set status= 'X' where cod_mesa = " & codMesa
        End If
        cm.ExecuteReader()
        db.Close()
        MessageBox.Show("Cuenta cerrada con exito")
    End Sub
    Public Sub add_tarjeta()
        Dim db As New SqlClient.SqlConnection()
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "insert into dbo.TARJETA (nombre, hombres, mujeres, cod_formapago, status) values ('" & nombreCliente & "'," & hombresCliente & "," & mujeresCliente & "," & formaPagoCliente & ",'A')"
        cm.ExecuteReader()
        db.Close()
        MessageBox.Show("Cliente creado con exito")
    End Sub
    Public Sub carga_Grupo()
        Dim db As New SqlClient.SqlConnection()
        Dim da As New SqlClient.SqlDataAdapter
        Dim cm As New SqlClient.SqlCommand
        db.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BarDisco2;Persist Security Info=True;User ID=sa;Password=gotechdev"
        cm.Connection = db
        cm.Connection.Open()
        cm.CommandText = "SELECT codigo, descripcion FROM GRUPOS WHERE (status = 'A') ORDER BY orden"
        cm.ExecuteReader()
        db.Close()
        'MessageBox.Show("Cliente creado con exito")
    End Sub

    'Public Function llenarGridGrupo(ByVal txttitulo As String, ByVal txtautor As String, ByVal txtgenero As String, ByRef sql As String) As System.Data.DataSet

    'End Function

End Class


