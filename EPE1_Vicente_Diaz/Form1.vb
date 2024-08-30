Imports System.Data
Imports System.IO
Imports ExcelDataReader

Public Class Form1

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim filePath As String = "C:\Users\seba\Desktop\Bicho\Visualstudio\Lista.xls" ' Verifica la ruta del archivo

            If Not File.Exists(filePath) Then
                MessageBox.Show("El archivo Excel no se encuentra en la ruta especificada.")
                Return
            End If

            ' Registrar el proveedor de codificación, error que me lanzo al cargar el archivo de excel al presionar el boton
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)

            Dim dataTable As DataTable
            Dim productNames As New List(Of String)

            Using stream = File.Open(filePath, FileMode.Open, FileAccess.Read)

                Using reader = ExcelReaderFactory.CreateReader(stream)
                    ' Leer la hoja de cálculo
                    Dim result = reader.AsDataSet()
                    ' Suponiendo que los datos están en la primera hoja
                    dataTable = result.Tables(0)

                    ' Leer la columna de nombres de productos (primera columna al ser valor 0)
                    For Each row As DataRow In dataTable.Rows
                        productNames.Add(row(0).ToString())
                    Next
                End Using
            End Using

            cmbProductos.Items.Clear()
            cmbProductos.Items.AddRange(productNames.ToArray())

            ' Deshabilitar el botón después de cargar
            btnCargar.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error al cargar el archivo Excel: " & ex.Message)
        End Try
    End Sub
    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        Dim selectedProduct As String = cmbProductos.SelectedItem.ToString()

        Try
            Dim filePath As String = "C:\Users\seba\Desktop\Bicho\Visualstudio\Lista.xls" ' Asegúrate de que la ruta del archivo sea correcta

            Dim dataTable As DataTable

            Using stream = File.Open(filePath, FileMode.Open, FileAccess.Read)
                ' Crear un lector de Excel
                Using reader = ExcelReaderFactory.CreateReader(stream)
                    ' Leer la hoja de cálculo
                    Dim result = reader.AsDataSet()
                    ' Suponiendo que los datos están en la primera hoja
                    dataTable = result.Tables(0)
                End Using
            End Using

            ' Buscar el producto en la tabla
            For Each row As DataRow In dataTable.Rows
                If row(0).ToString() = selectedProduct Then
                    txtDescripcion.Text = row(1).ToString() ' Valor encontrado en la columba B del documento
                    txtPrecio.Text = row(5).ToString() ' el valor de precio está en la columna F
                    txtStock.Text = row(6).ToString() ' El valor de stock está en la columna G
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error al mostrar los detalles del producto: " & ex.Message)
        End Try
    End Sub
End Class