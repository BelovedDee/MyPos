Imports System.Data.SqlClient
Imports System.Data

Public Class frmProduct
    Dim con = New SqlConnection("Data Source=(local);Initial Catalog=Pos_System;Integrated Security=True;Encrypt=False")

    Private Sub FetchSupplier()
        con.Open()
        Dim Query = "Select * from SupplierTbl where SupId = '" & cbProdSupID.SelectedValue.ToString & "'"
        Dim cmd As New SqlCommand(Query, con)
        Dim Tbl As New DataTable()
        Dim sda = New SqlDataAdapter(cmd)
        sda.Fill(Tbl)
        For Each dr As DataRow In Tbl.Rows
            txtSupplierName.Text = dr(1).ToString
        Next

        con.Close()
    End Sub

    Private Sub GetSupplier()
        con.Open()
        Dim Query = "Select * from SupplierTbl"
        Dim cmd As New SqlCommand(Query, con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        cbProdSupID.DataSource = Tbl
        cbProdSupID.DisplayMember = "SupId"
        cbProdSupID.ValueMember = "SupId"
        con.Close()
    End Sub

    Private Sub DisplayProd()
        con.Open()
        Dim Query = "Select * from ProductTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(Query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvProduct.DataSource = ds.Tables(0)
        con.Close
    End Sub
    Private Sub GetCategory()
        con.Open()
        Dim Query = "Select * from CategoryTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd As New SqlCommand(Query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        cbProductCat.DataSource = Tbl
        cbProductCat.DisplayMember = "CategoryName"
        cbProductCat.ValueMember = "CategoryName"
        con.Close()
    End Sub
    Private Sub btnSaveProduct_Click(sender As Object, e As EventArgs) Handles btnSaveProduct.Click
        If txtProductName.Text = "" Or txtProductPrice.Text = "" Or txtProductQty.Text = "" Or cbProdSupID.SelectedIndex = -1 Or txtSupplierName.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                con.Open()
                Dim Query = "Insert into ProductTbl(PName, PCat, Pprice, Pqty, Supplier, SupName)values(@PN,@PC,@PP,@PQ,@Sup, @SupN)"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@PN", txtProductName.Text)
                cmd.Parameters.AddWithValue("@PC", cbProductCat.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@PP", txtProductPrice.Text)
                cmd.Parameters.AddWithValue("@PQ", txtProductQty.Text)
                cmd.Parameters.AddWithValue("@Sup", cbProdSupID.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@SupN", txtSupplierName.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Product Saved")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtProductName.Text = ""
                cbProductCat.SelectedValue = -1
                txtProductPrice.Text = ""
                txtProductQty.Text = ""
                cbProdSupID.SelectedValue = -1
                txtSupplierName.Text = ""
                DisplayProd()

            End Try
        End If
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSupplier()
        DisplayProd()
        GetCategory()
    End Sub

    Private Sub cbProdSupID_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbProdSupID.SelectionChangeCommitted
        FetchSupplier()
    End Sub

    Dim Key = 0
    Private Sub gvProduct_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProduct.CellMouseClick
        Dim row As DataGridViewRow = dgvProduct.Rows(e.RowIndex)
        txtProductName.Text = row.Cells(1).Value.ToString
        cbProductCat.SelectedItem = row.Cells(2).Value.ToString
        txtProductPrice.Text = row.Cells(3).Value.ToString
        txtProductQty.Text = row.Cells(4).Value.ToString
        cbProdSupID.SelectedValue = row.Cells(5).Value.ToString
        txtSupplierName.Text = row.Cells(6).Value.ToString


        If txtSupplierName.Text = "" Then
            Key = 0

        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnEditProduct_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click
        If txtProductName.Text = "" Or txtProductPrice.Text = "" Or txtProductQty.Text = "" Or cbProdSupID.SelectedIndex = -1 Or txtSupplierName.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                con.Open()
                Dim Query = "Update ProductTbl set PName=@PN, PCat=@PC, Pprice=@PP, Pqty=@PQ, Supplier=@Sup, SupName=@SupN where PId=@PKey"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@PN", txtProductName.Text)
                cmd.Parameters.AddWithValue("@PC", cbProductCat.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@PP", txtProductPrice.Text)
                cmd.Parameters.AddWithValue("@PQ", txtProductQty.Text)
                cmd.Parameters.AddWithValue("@Sup", cbProdSupID.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@SupN", txtSupplierName.Text)
                cmd.Parameters.AddWithValue("@Pkey", Key)
                cmd.ExecuteNonQuery()
                MsgBox("Product Updated")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtProductName.Text = ""
                cbProductCat.SelectedValue = -1
                txtProductPrice.Text = ""
                txtProductQty.Text = ""
                cbProdSupID.SelectedIndex = -1
                txtSupplierName.Text = ""
                DisplayProd()

            End Try
        End If
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        If Key = 0 Then
            MsgBox("Select Product")

        Else
            Try
                con.Open()
                Dim Query = "Delete from ProductTbl where PId=@PKey"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@PKey", Key)
                cmd.ExecuteNonQuery()
                MsgBox("Product Deleted")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtProductName.Text = ""
                cbProductCat.SelectedValue = -1
                txtProductPrice.Text = ""
                txtProductQty.Text = ""
                cbProdSupID.SelectedIndex = -1
                txtSupplierName.Text = ""
                DisplayProd()

            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
    End Sub

    Private Sub btnEditCat_Click(sender As Object, e As EventArgs) Handles btnEditCat.Click
        Dim obj = New frmCategory()
        'Me.Hide()
        obj.Show()
    End Sub
End Class