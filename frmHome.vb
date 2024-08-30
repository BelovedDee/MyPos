Public Class frmHome
    Private Sub lblProduct_Click(sender As Object, e As EventArgs) Handles lblProduct.Click
        Dim obj = New frmProduct()
        'Me.Hide()
        obj.Show()
    End Sub

    Private Sub lblSupplier_Click(sender As Object, e As EventArgs) Handles lblSupplier.Click
        Dim obj = New frmSupplier()
        'Me.Hide()
        obj.Show()
    End Sub

    Private Sub lblCustomer_Click(sender As Object, e As EventArgs) Handles lblCustomer.Click
        Dim obj = New frmCustomer()
        'Me.Hide()
        obj.Show()
    End Sub

    Private Sub lblBilling_Click(sender As Object, e As EventArgs) Handles lblBilling.Click
        Dim obj = New frmBilling()
        'Me.Hide()
        obj.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim obj = New Form1()
        Me.Hide()
        obj.Show()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim obj = New frmProduct()
        'Me.Hide()
        obj.Show()
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        Dim obj = New frmSupplier()
        'Me.Hide()
        obj.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim obj = New frmCustomer()
        'Me.Hide()
        obj.Show()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click, btnBilling.MouseCaptureChanged
        Dim obj = New frmBilling()
        'Me.Hide()
        obj.Show()
    End Sub
End Class