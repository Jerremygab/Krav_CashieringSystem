Imports System.Buffers
Imports System.Windows.Forms.ListViewItem
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.View = View.Details
    End Sub

    Private Sub Red_wine_but_Click(sender As Object, e As EventArgs) Handles Red_wine_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Red_wine_qty.Text
        description = Red_wine.Text

        price = Val(Red_wine_qty.Text) * Val(Red_wine_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)

    End Sub

    Private Sub White_wine_but_Click(sender As Object, e As EventArgs) Handles White_wine_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = White_wine_qty.Text
        description = White_wine.Text

        price = Val(White_wine_qty.Text) * Val(White_wine_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Gin_Tonic_but_Click(sender As Object, e As EventArgs) Handles Gin_Tonic_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Gin_Tonic_qty.Text
        description = Gin_Tonic.Text

        price = Val(Gin_Tonic_qty.Text) * Val(Gin_Tonic_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Pancake_but_Click(sender As Object, e As EventArgs) Handles Pancake_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Pancake_qty.Text
        description = Pancake.Text

        price = Val(Pancake_qty.Text) * Val(Pancake_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Breakfast_but_Click(sender As Object, e As EventArgs) Handles Breakfast_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Breakfast_qty.Text
        description = Breakfast.Text

        price = Val(Breakfast_qty.Text) * Val(Breakfast_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub French_toast_but_Click(sender As Object, e As EventArgs) Handles French_toast_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = French_toast_qty.Text
        description = French_toast_.Text

        price = Val(French_toast_qty.Text) * Val(French_toast_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Tocilog_but_Click(sender As Object, e As EventArgs) Handles Tocilog_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Tocilog_qty.Text
        description = Tocilog.Text

        price = Val(Tocilog_qty.Text) * Val(Tocilog_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Tapsilog_but_Click(sender As Object, e As EventArgs) Handles Tapsilog_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Tapsilog_qty.Text
        description = Tapsilog.Text

        price = Val(Tapsilog_qty.Text) * Val(Tapsilog_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Longsilog_but_Click(sender As Object, e As EventArgs) Handles Longsilog_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Longsilog_qty.Text
        description = Longsilog.Text

        price = Val(Longsilog_qty.Text) * Val(Longsilog_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Carbonara_but_Click(sender As Object, e As EventArgs) Handles Carbonara_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Carbonara_qty.Text
        description = Carbonara.Text

        price = Val(Carbonara_qty.Text) * Val(Carbonara_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Aglio_but_Click(sender As Object, e As EventArgs) Handles Aglio_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Aglio_qty.Text
        description = Aglio.Text

        price = Val(Aglio_qty.Text) * Val(Aglio_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Pesto_but_Click(sender As Object, e As EventArgs) Handles Pesto_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Pesto_qty.Text
        description = Pesto.Text

        price = Val(Pesto_qty.Text) * Val(Pesto_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Bolognese_but_Click(sender As Object, e As EventArgs) Handles Bolognese_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Bolognese_qty.Text
        description = Bolognese.Text

        price = Val(Bolognese_qty.Text) * Val(Bolognese_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Spicy_Spanish_but_Click(sender As Object, e As EventArgs) Handles Spicy_Spanish_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Spicy_Spanish_qty.Text
        description = Spicy_Spanish.Text

        price = Val(Spicy_Spanish_qty.Text) * Val(Spicy_Spanish_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Classic_tuna_but_Click(sender As Object, e As EventArgs) Handles Classic_tuna_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Classic_tuna_qty.Text
        description = Classic_tuna.Text

        price = Val(Classic_tuna_qty.Text) * Val(Classic_tuna_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Clubhouse_but_Click(sender As Object, e As EventArgs) Handles Clubhouse_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Clubhouse_qty.Text
        description = Clubhouse.Text

        price = Val(Clubhouse_qty.Text) * Val(Clubhouse_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Avocado_toast_but_Click(sender As Object, e As EventArgs) Handles Avocado_toast_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Avocado_toast_qty.Text
        description = Avocado_toast.Text

        price = Val(Avocado_toast_qty.Text) * Val(Avocado_toast_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Grilled_Cheese_but_Click(sender As Object, e As EventArgs) Handles Grilled_Cheese_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Grilled_Cheese_qty.Text
        description = Grilled_Cheese.Text

        price = Val(Grilled_Cheese_qty.Text) * Val(Grilled_Cheese_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Tuna_Melt_but_Click(sender As Object, e As EventArgs) Handles Tuna_Melt_but.Click
        Dim qty, price As Integer
        Dim description As String
        qty = Tuna_Melt_qty.Text
        description = Tuna_Melt.Text

        price = Val(Tuna_Melt_qty.Text) * Val(Tuna_Melt_price.Text)
        Dim otherItems As String() = {description, price}
        Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
    End Sub

    Private Sub Hot_americano_but_Click(sender As Object, e As EventArgs) Handles Hot_americano_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_americano_qty.Text
        description = Hot_americano.Text
        category = hot.Text

        If Hot_americano_8oz.Checked Then
            price = Val(Hot_americano_qty.Text) * Val(Hot_americano_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_americano_12oz.Checked Then
            price = Val(Hot_americano_qty.Text) * Val(Hot_americano_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If

    End Sub

    Private Sub Hot_cappucino_but_Click(sender As Object, e As EventArgs) Handles Hot_cappucino_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_cappucino_qty.Text
        description = Hot_cappucino.Text
        category = hot.Text

        If Hot_cappucino_8oz.Checked Then
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_cappucino_12oz.Checked Then
            price = Val(Hot_cappucino_qty.Text) * Val(Hot_cappucino_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_flatwhite_but_Click(sender As Object, e As EventArgs) Handles Hot_flatwhite_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_flatwhite_qty.Text
        description = Hot_flatwhite.Text
        category = hot.Text

        If Hot_flatwhite_8oz.Checked Then
            price = Val(Hot_flatwhite_qty.Text) * Val(Hot_flatwhite_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_flatwhite_12oz.Checked Then
            price = Val(Hot_flatwhite_qty.Text) * Val(Hot_flatwhite_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_latte_but_Click(sender As Object, e As EventArgs) Handles Hot_latte_but.Click
        Dim qty, price, description As Integer
        Dim category As String
        qty = Hot_latte_qty.Text
        description = Hot_latte.Text
        category = hot.Text

        If Hot_latte_8oz.Checked Then
            price = Val(Hot_latte_qty.Text) * Val(Hot_latte_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_latte_12oz.Checked Then
            price = Val(Hot_latte_qty.Text) * Val(Hot_latte_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_blacklatte_but_Click(sender As Object, e As EventArgs) Handles Hot_blacklatte_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_blacklatte_qty.Text
        description = Hot_blacklatte.Text
        category = hot.Text

        If Hot_blacklatte_8oz.Checked Then
            price = Val(Hot_blacklatte_qty.Text) * Val(Hot_blacklatte_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_blacklatte_12oz.Checked Then
            price = Val(Hot_blacklatte_qty.Text) * Val(Hot_blacklatte_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_spanishlatte_but_Click(sender As Object, e As EventArgs) Handles Hot_spanishlatte_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_spanishlatte_qty.Text
        description = Hot_spanishlatte.Text
        category = hot.Text

        If Hot_spanishlatte_8oz.Checked Then
            price = Val(Hot_spanishlatte_qty.Text) * Val(Hot_spanishlatte_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_spanishlatte_12oz.Checked Then
            price = Val(Hot_spanishlatte_qty.Text) * Val(Hot_spanishlatte_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_matchalatte_but_Click(sender As Object, e As EventArgs) Handles Hot_matchalatte_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_matchalatte_qty.Text
        description = Hot_matchalatte.Text
        category = hot.Text

        If Hot_matchalatte_8oz.Checked Then
            price = Val(Hot_matchalatte_qty.Text) * Val(Hot_matchalatte_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_matchalatte_12oz.Checked Then
            price = Val(Hot_matchalatte_qty.Text) * Val(Hot_matchalatte_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_pistachio_but_Click(sender As Object, e As EventArgs) Handles Hot_pistachio_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_pistachio_qty.Text
        description = Hot_pistachio.Text
        category = hot.Text

        If Hot_pistachio_8oz.Checked Then
            price = Val(Hot_pistachio_qty.Text) * Val(Hot_pistachio_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_pistachio_12oz.Checked Then
            price = Val(Hot_pistachio_qty.Text) * Val(Hot_pistachio_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_caramel_but_Click(sender As Object, e As EventArgs) Handles Hot_caramel_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_caramel_qty.Text
        description = Hot_caramel.Text
        category = hot.Text

        If Hot_caramel_8oz.Checked Then
            price = Val(Hot_caramel_qty.Text) * Val(Hot_caramel_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_caramel_12oz.Checked Then
            price = Val(Hot_caramel_qty.Text) * Val(Hot_caramel_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_krav_but_Click(sender As Object, e As EventArgs) Handles Hot_krav_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_krav_qty.Text
        description = Hot_krav.Text
        category = hot.Text

        If Hot_krav_8oz.Checked Then
            price = Val(Hot_krav_qty.Text) * Val(Hot_krav_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_krav_12oz.Checked Then
            price = Val(Hot_krav_qty.Text) * Val(Hot_krav_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_classicmocha_but_Click(sender As Object, e As EventArgs) Handles Hot_classicmocha_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_classicmocha_qty.Text
        description = Hot_classicmocha.Text
        category = hot.Text

        If Hot_classicmocha_8oz.Checked Then
            price = Val(Hot_classicmocha_qty.Text) * Val(Hot_classicmocha_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_classicmocha_12oz.Checked Then
            price = Val(Hot_classicmocha_qty.Text) * Val(Hot_classicmocha_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_whitemocha_but_Click(sender As Object, e As EventArgs) Handles Hot_whitemocha_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_whitemocha_qty.Text
        description = Hot_whitemocha.Text
        category = hot.Text

        If Hot_whitemocha_8oz.Checked Then
            price = Val(Hot_whitemocha_qty.Text) * Val(Hot_whitemocha_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_whitemocha_12oz.Checked Then
            price = Val(Hot_whitemocha_qty.Text) * Val(Hot_whitemocha_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Hot_chocolate_but_Click(sender As Object, e As EventArgs) Handles Hot_chocolate_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Hot_chocolate_qty.Text
        description = Hot_chocolate.Text
        category = hot.Text

        If Hot_chocolate_8oz.Checked Then
            price = Val(Hot_chocolate_qty.Text) * Val(Hot_chocolate_8oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Hot_chocolate_12oz.Checked Then
            price = Val(Hot_chocolate_qty.Text) * Val(Hot_chocolate_12oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_americano_but_Click(sender As Object, e As EventArgs) Handles Iced_americano_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_americano_qty.Text
        description = Iced_americano.Text
        category = Iced.Text

        If Iced_americano_16oz.Checked Then
            price = Val(Iced_americano_qty.Text) * Val(Iced_americano_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_americano_22oz.Checked Then
            price = Val(Iced_americano_qty.Text) * Val(Iced_americano_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_latte_but_Click(sender As Object, e As EventArgs) Handles Iced_latte_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_latte_qty.Text
        description = Iced_latte.Text
        category = Iced.Text

        If Iced_latte_16oz.Checked Then
            price = Val(Iced_latte_qty.Text) * Val(Iced_latte_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_latte_22oz.Checked Then
            price = Val(Iced_latte_qty.Text) * Val(Iced_latte_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_blacklatte_but_Click(sender As Object, e As EventArgs) Handles Iced_blacklatte_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_blacklatte_qty.Text
        description = Iced_blacklatte.Text
        category = Iced.Text

        If Iced_blacklatte_16oz.Checked Then
            price = Val(Iced_blacklatte_qty.Text) * Val(Iced_blacklatte_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_blacklatte_22oz.Checked Then
            price = Val(Iced_blacklatte_qty.Text) * Val(Iced_blacklatte_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_spanishlatte_but_Click(sender As Object, e As EventArgs) Handles Iced_spanishlatte_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_spanishlatte_qty.Text
        description = Iced_spanishlatte.Text
        category = Iced.Text

        If Iced_spanishlatte_16oz.Checked Then
            price = Val(Iced_spanishlatte_qty.Text) * Val(Iced_spanishlatte_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_spanishlatte_22oz.Checked Then
            price = Val(Iced_spanishlatte_qty.Text) * Val(Iced_spanishlatte_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_matchalatte_but_Click(sender As Object, e As EventArgs) Handles Iced_matchalatte_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_matchalatte_qty.Text
        description = Iced_matchalatte.Text
        category = Iced.Text

        If Iced_matchalatte_16oz.Checked Then
            price = Val(Iced_matchalatte_qty.Text) * Val(Iced_matchalatte_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_matchalatte_22oz.Checked Then
            price = Val(Iced_matchalatte_qty.Text) * Val(Iced_matchalatte_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_pistachio_but_Click(sender As Object, e As EventArgs) Handles Iced_pistachio_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_pistachio_qty.Text
        description = Iced_pistachio.Text
        category = Iced.Text

        If Iced_pistachio_16oz.Checked Then
            price = Val(Iced_pistachio_qty.Text) * Val(Iced_pistachio_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_pistachio_22oz.Checked Then
            price = Val(Iced_pistachio_qty.Text) * Val(Iced_pistachio_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_caramel_but_Click(sender As Object, e As EventArgs) Handles Iced_caramel_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_caramel_qty.Text
        description = Iced_caramel.Text
        category = Iced.Text

        If Iced_caramel_16oz.Checked Then
            price = Val(Iced_caramel_qty.Text) * Val(Iced_caramel_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_caramel_22oz.Checked Then
            price = Val(Iced_caramel_qty.Text) * Val(Iced_caramel_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_krav_but_Click(sender As Object, e As EventArgs) Handles Iced_krav_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_krav_qty.Text
        description = Iced_krav.Text
        category = Iced.Text

        If Iced_krav_16oz.Checked Then
            price = Val(Iced_krav_qty.Text) * Val(Iced_krav_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_krav_22oz.Checked Then
            price = Val(Iced_krav_qty.Text) * Val(Iced_krav_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_strcheesecake_but_Click(sender As Object, e As EventArgs) Handles Iced_strcheesecake_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_strcheesecake_qty.Text
        description = Iced_strcheesecake.Text
        category = Iced.Text

        If Iced_strcheesecake_16oz.Checked Then
            price = Val(Iced_strcheesecake_qty.Text) * Val(Iced_strcheesecake_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_strcheesecake_22oz.Checked Then
            price = Val(Iced_strcheesecake_qty.Text) * Val(Iced_strcheesecake_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_classicmocha_but_Click(sender As Object, e As EventArgs) Handles Iced_classicmocha_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_classicmocha_qty.Text
        description = Iced_classicmocha.Text
        category = Iced.Text

        If Iced_classicmocha_16oz.Checked Then
            price = Val(Iced_classicmocha_qty.Text) * Val(Iced_classicmocha_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_classicmocha_22oz.Checked Then
            price = Val(Iced_classicmocha_qty.Text) * Val(Iced_classicmocha_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_whitemocha_but_Click(sender As Object, e As EventArgs) Handles Iced_whitemocha_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_whitemocha_qty.Text
        description = Iced_whitemocha.Text
        category = Iced.Text

        If Iced_whitemocha_16oz.Checked Then
            price = Val(Iced_whitemocha_qty.Text) * Val(Iced_whitemocha_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_whitemocha_22oz.Checked Then
            price = Val(Iced_whitemocha_qty.Text) * Val(Iced_whitemocha_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_milo_but_Click(sender As Object, e As EventArgs) Handles Iced_milo_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_milo_qty.Text
        description = Iced_milo.Text
        category = Iced.Text

        If Iced_milo_16oz.Checked Then
            price = Val(Iced_milo_qty.Text) * Val(Iced_milo_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_milo_22oz.Checked Then
            price = Val(Iced_milo_qty.Text) * Val(Iced_milo_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Iced_chocolate_but_Click(sender As Object, e As EventArgs) Handles Iced_chocolate_but.Click
        Dim qty, price As Integer
        Dim description, category As String
        qty = Iced_chocolate_qty.Text
        description = Iced_chocolate.Text
        category = Iced.Text

        If Iced_chocolate_16oz.Checked Then
            price = Val(Iced_chocolate_qty.Text) * Val(Iced_chocolate_16oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        If Iced_chocolate_22oz.Checked Then
            price = Val(Iced_chocolate_qty.Text) * Val(Iced_chocolate_22oz.Text)
            Dim otherItems As String() = {description, price}
            Me.ListView1.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
    End Sub

    Private Sub Proceed_but_Click(sender As Object, e As EventArgs) Handles Proceed_but.Click
        Dim Index As Integer
        Dim TotalValue As Double

        For Index = 1 To Me.ListView1.Items.Count - 1
            Dim X As Double = CDbl(Me.ListView1.Items.Item(Index).SubItems(2).Text)
            TotalValue = TotalValue + X
        Next

        Dim vats, tot_vat As Single

        vats = (TotalValue * 12) / 100
        tot_vat = TotalValue + vats

        sub_tot.Text = TotalValue
        tot_due.Text = tot_vat
        vat.Text = vats
    End Sub



    Private Sub Done_but_Click(sender As Object, e As EventArgs) Handles Done_but.Click
        MsgBox(vbTab & Space(10) & "Krav Cafe" & vbCrLf & vbTab & "Lamar Village Sabang" & vbCrLf & vbTab & Space(3) & "Lipa City, Batangas" & vbCrLf & vbCrLf &
               "Name:" & vbTab & vbTab & Val(Costumer_name.Text) & vbCrLf &
               "Subtotal:" & vbTab & vbTab & Val(sub_tot.Text) & vbCrLf &
               "VAT:" & vbTab & vbTab & Val(vat.Text) & vbCrLf &
               "Discounted:" & vbTab & Val(num_discounted.Text) & Space(3) & Val(discounted_amount.Text) & vbCrLf &
               "Total Due:" & vbTab & Val(tot_due.Text) & vbCrLf &
               "Paid:" & vbTab & vbTab & Val(bayad.Text) & vbCrLf &
               "Change:" & vbTab & vbTab & Val(sukli.Text) & vbCrLf & vbCrLf &
               "Date:" & vbTab & vbTab & My.Computer.Clock.LocalTime & vbCrLf & vbCrLf & Space(7) &
               "THANK YOU FOR DINING WITH US! " & vbCrLf & vbTab & Space(2) & "PLEASE COME AGAIN")
        Me.Close()

    End Sub
    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint
        If dc1.Checked Or dc2.Checked Then
            Panel28.Visible = True
        End If
    End Sub
    Private Sub no_discounted_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num_discounted.KeyPress

        Dim noD, noC As Integer
        noC = Val(num_customer.Text)
        noD = Val(num_discounted.Text)

        If noD > noC Then
            MsgBox("Invalid Number")
        End If

        Dim disc, due As Single
        Dim no_discount As Integer

        due = Val(tot_due.Text)
        no_discount = Val(num_discounted.Text)

        If dc1.Checked Or dc2.Checked Then
            disc = ((due * 0.2) - Val(vat.Text)) * no_discount
        End If


        discounted_amount.Text = disc
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        For Each item As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(item)
        Next

    End Sub

    Private Sub bayad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bayad.KeyPress
        Dim due, binayad As Single
        due = Val(tot_due.Text)
        binayad = Val(bayad.Text)
        If due > binayad Then
            MsgBox("Invalid Amount")
        End If
        sukli.Text = (Val(bayad.Text) - Val(tot_due.Text)) + Val(discounted_amount.Text)
    End Sub
End Class
