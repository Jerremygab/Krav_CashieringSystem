Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Red_wine_but_Click(sender As Object, e As EventArgs) Handles Red_wine_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Red_wine_qty.Text
        description = Red_wine.Text

        price = Val(Red_wine_qty.Text) * Val(Red_wine_price.Text)
        orders.Items.Add(price)
        orders.Items.Add(qty & vbTab & Red_wine_qty.Text & Space(1) & description & vbTab & vbTab & price)

    End Sub
End Class
