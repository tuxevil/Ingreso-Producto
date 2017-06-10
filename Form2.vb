Public Class NuevoCliente

    Private Sub NuevoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FormadePago._FORMA_PAGO' table. You can move, or remove it, as needed.
        Me.FORMA_PAGOTableAdapter.Fill(Me.FormadePago._FORMA_PAGO)

    End Sub


    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGrabar.Click
        nombreCliente = tbNombre.Text
        fechaCliente = dtpFecha.Value
        hombresCliente = CType(tbHombres.Text, Integer)
        mujeresCliente = CType(tbMujeres.Text, Integer)
        formaPagoCliente = cbFormaPago.SelectedValue
        'valorCliente = CType(tbValor.Text, Integer)

        Dim cc As New C_baradmin
        cc.add_tarjeta()
    End Sub
End Class