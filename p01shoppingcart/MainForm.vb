Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHombres.Click
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black
    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnMujeres.ForeColor = Color.SteelBlue
        btnHombres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black
    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click
        btnCalzado.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnHombres.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black
    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click
        btnAccesorios.ForeColor = Color.SteelBlue
        btnCalzado.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnHombres.ForeColor = Color.Black
    End Sub

    Private Sub btnVer1_Click(sender As Object, e As EventArgs) Handles btnVer1.Click
        lblTituloProducto.Text = "Camisa de Algodon"
        lblProduc1.Text = "Camisa de Algodon"
        lblPrecio1.Text = "$120"
        PicBox.Image = iProductos.Images.Item(0)

    End Sub

    Private Sub btnVer2_Click(sender As Object, e As EventArgs) Handles btnVer2.Click
        lblTituloProducto.Text = "Blazer Mescla de Lana"
        lblProduc2.Text = "Blazer Mescla de Lana"
        lblPrecio2.Text = "$240"
        PicBox.Image = iProductos.Images.Item(1)
    End Sub

    Private Sub btnVer3_Click(sender As Object, e As EventArgs) Handles btnVer3.Click
        lblTituloProducto.Text = "Jersey Cuello Pico"
        lblProduc3.Text = "Jersey Cuello Pico"
        lblPrecio3.Text = "$160"
        PicBox.Image = iProductos.Images.Item(3)
    End Sub

    Private Sub btnVer4_Click(sender As Object, e As EventArgs) Handles btnVer4.Click
        lblTituloProducto.Text = "Polo Cuello Redondo"
        lblProduc4.Text = "Polo Cuello Redondo"
        lblPrecio4.Text = "$70"
        PicBox.Image = iProductos.Images.Item(4)
    End Sub
End Class