<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnCargar = New Button()
        cmbProductos = New ComboBox()
        txtDescripcion = New TextBox()
        txtStock = New TextBox()
        txtPrecio = New TextBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 15)
        Label1.TabIndex = 0
        Label1.Text = "Boton de carga C.Box"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 15)
        Label2.TabIndex = 1
        Label2.Text = "Seleccionar id producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(239, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 15)
        Label3.TabIndex = 2
        Label3.Text = "Detalle producto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 15)
        Label4.TabIndex = 3
        Label4.Text = "Nombre del producto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(264, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 15)
        Label5.TabIndex = 4
        Label5.Text = "Precio del producto"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(402, 290)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 15)
        Label6.TabIndex = 5
        Label6.Text = "Stock del producto"
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(223, 90)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(164, 23)
        btnCargar.TabIndex = 6
        btnCargar.Text = "Cargar archivo excel"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(223, 138)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(241, 23)
        cmbProductos.TabIndex = 7
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(33, 327)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(198, 23)
        txtDescripcion.TabIndex = 8
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(402, 327)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 9
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(264, 327)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(156, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(262, 15)
        Label7.TabIndex = 11
        Label7.Text = "___________________________________________________"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(txtPrecio)
        Controls.Add(txtStock)
        Controls.Add(txtDescripcion)
        Controls.Add(cmbProductos)
        Controls.Add(btnCargar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        Text = "EPE_1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCargar As Button
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label7 As Label

End Class
