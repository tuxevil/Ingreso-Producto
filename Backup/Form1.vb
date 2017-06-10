Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daProductos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents dgProductos As System.Windows.Forms.DataGrid
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daGrupo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.daProductos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.dgProductos = New System.Windows.Forms.DataGrid
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daGrupo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'daProductos
        '
        Me.daProductos.SelectCommand = Me.SqlSelectCommand1
        Me.daProductos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CLASE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Grupo", "Grupo"), New System.Data.Common.DataColumnMapping("Clase", "Clase"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Subtipo", "Subtipo")})})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MONSTRITO;packet size=4096;user id=sa;data source=""monstrito\sqlex" & _
        "press"";persist security info=True;initial catalog=BarDisco2;password=gotechdev"
        '
        'dgProductos
        '
        Me.dgProductos.DataMember = ""
        Me.dgProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProductos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProductos.Location = New System.Drawing.Point(0, 0)
        Me.dgProductos.Name = "dgProductos"
        Me.dgProductos.PreferredColumnWidth = 150
        Me.dgProductos.ReadOnly = True
        Me.dgProductos.RowHeadersVisible = False
        Me.dgProductos.Size = New System.Drawing.Size(592, 324)
        Me.dgProductos.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GRUPOS.descripcion AS Grupo, CLASE.descripcion AS Clase, TIPO.descripcion " & _
        "AS Tipo, ""SUB-TIPO"".descripcion AS Subtipo FROM CLASE INNER JOIN GRUPOS ON CLASE" & _
        ".cod_grupo = GRUPOS.codigo INNER JOIN TIPO ON CLASE.codigo = TIPO.cod_clase INNE" & _
        "R JOIN ""SUB-TIPO"" ON TIPO.codigo = ""SUB-TIPO"".cod_tipo ORDER BY GRUPOS.orden, CL" & _
        "ASE.descripcion, TIPO.descripcion"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'daGrupo
        '
        Me.daGrupo.SelectCommand = Me.SqlSelectCommand2
        Me.daGrupo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GRUPOS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT descripcion FROM GRUPOS ORDER BY orden"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 324)
        Me.Controls.Add(Me.dgProductos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsProductos As New DataSet
        dsProductos.Tables.Add(New DataTable("Grupo"))

        dsProductos.Tables(0).BeginLoadData()
        daGrupo.Fill(dsProductos, "Grupo")
        dsProductos.Tables(0).EndLoadData()

        dgProductos.DataSource = dsProductos.Tables(0).DefaultView



        'dsProductos.Tables.Add(New DataTable("Clase"))
        'dsProductos.Tables.Add(New DataTable("Tipo"))
        'dsProductos.Tables.Add(New DataTable("Subtipo"))
        'dsProductos.Tables(1).BeginLoadData()
        'daProductos.Fill(dsProductos, "Clase")
        'dsProductos.Tables(1).EndLoadData()
        'dsProductos.Tables(2).BeginLoadData()
        'daProductos.Fill(dsProductos, "Tipo")
        'dsProductos.Tables(2).EndLoadData()
        'dsProductos.Tables(3).BeginLoadData()
        'daProductos.Fill(dsProductos, "Subtipo")
        'dsProductos.Tables(3).EndLoadData()



    End Sub

End Class
