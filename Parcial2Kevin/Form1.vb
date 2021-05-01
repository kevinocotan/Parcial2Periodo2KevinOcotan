Public Class Productos

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'arreglo:
        Dim producto() As String = {"Camisa Negra", "Pantalon Jeans", "Sudadera Cafe", "Zapatos Tennis", "Gorra Negra"}
        ComboBox1.Items.AddRange(producto)

        'ejemplo visto en clase:
        'ComboBox1.Items.Add("Camisa Negra")
        'ComboBox1.Items.Add("Pantalon")
        'ComboBox1.Items.Add("Sudadera")
        'ComboBox1.Items.Add("Zapatos")
        'ComboBox1.Items.Add("Gorra")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.SelectedItem.ToString()

        'nota
        'idea tomada de la clase del dia 22 de abril 
        'clase formularios en powerpoint:

        If (ComboBox1.SelectedItem.ToString.Equals("Camisa Negra")) Then
            TextBox2.Text = "50"
            TextBox2.Focus()
            TextBox3.Text = "70"
            TextBox3.Focus()
            TextBox4.Text = "5"
            TextBox4.Focus()

        ElseIf (ComboBox1.SelectedItem.ToString.Equals("Pantalon Jeans")) Then
            TextBox2.Text = "30"
            TextBox2.Focus()
            TextBox3.Text = "50"
            TextBox3.Focus()
            TextBox4.Text = "6"
            TextBox4.Focus()

        ElseIf (ComboBox1.SelectedItem.ToString.Equals("Sudadera Cafe")) Then
            TextBox2.Text = "60"
            TextBox2.Focus()
            TextBox3.Text = "75"
            TextBox3.Focus()
            TextBox4.Text = "3"
            TextBox4.Focus()

        ElseIf (ComboBox1.SelectedItem.ToString.Equals("Zapatos Tennis")) Then
            TextBox2.Text = "100"
            TextBox2.Focus()
            TextBox3.Text = "120"
            TextBox3.Focus()
            TextBox4.Text = "2"
            TextBox4.Focus()

        ElseIf (ComboBox1.SelectedItem.ToString.Equals("Gorra Negra")) Then
            TextBox2.Text = "10"
            TextBox2.Focus()
            TextBox3.Text = "15"
            TextBox3.Focus()
            TextBox4.Text = "8"
            TextBox4.Focus()
        End If
    End Sub


    'para mostrar los resultados en una listbox (algo extra)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prod As New C_Productos
        prod.P_Nombre = TextBox1.Text.Trim
        prod.P_Valor = Convert.ToDouble(TextBox2.Text)
        prod.P_Precio = Convert.ToDouble(TextBox3.Text)
        prod.P_Cantidad = Convert.ToDouble(TextBox4.Text)

        With ListBox1.Items
            .Add("El nombre del producto es: " & prod.P_Nombre.ToString)
            .Add("")
            .Add("El Valor de producto es: " & prod.P_Valor.ToString)
            .Add("")
            .Add("El Precio del producto es: " & prod.P_Precio.ToString)
            .Add("")
            .Add("La cantidad en inventario es: " & prod.P_Cantidad.ToString)
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(TextBox2.Text * 0.13)
        ListBox3.Items.Add(TextBox2.Text.ToString * TextBox5.Text.ToString)
    End Sub


    'para limpiar los textbox y listbox 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
    End Sub
End Class
