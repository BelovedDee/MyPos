Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmBilling
    Dim con = New SqlConnection("Data Source=(local);Initial Catalog=Pos_System;Integrated Security=True;Encrypt=False")
    Private Sub DisplayProd()
        con.Open()
        Dim Query = "Select * from ProductTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand = New SqlCommand(Query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvProduct.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub frmBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProd()
        GetCustomer()

        ' Add the Add and Subtract columns to the dgvBill
        Dim addCol As New DataGridViewButtonColumn()
        addCol.HeaderText = "Add"
        addCol.Text = "+"
        addCol.UseColumnTextForButtonValue = True
        dgvBill.Columns.Add(addCol)

        Dim subCol As New DataGridViewButtonColumn()
        subCol.HeaderText = "Sub"
        subCol.Text = "-"
        subCol.UseColumnTextForButtonValue = True
        dgvBill.Columns.Add(subCol)
    End Sub

    Private Sub UpdateQty()
        Dim NewQty = Stock - Convert.ToInt32(txtProductQty.Text)
        Try
            con.Open()
            Dim Query = "Update ProductTbl set Pqty = @PQ where PId = @PKey"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, con)
            cmd.Parameters.AddWithValue("@PQ", NewQty)
            cmd.Parameters.AddWithValue("@Pkey", Key)
            cmd.ExecuteNonQuery()
            'MsgBox("Product Updated")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            'DisplayProd()

        End Try
    End Sub

    Dim Key = 0
    Dim Pname As String
    Dim Stock As Integer
    Dim Price As Double
    Dim i = 0, GrdTotal = 0
    Private Sub btnAddToBill_Click(sender As Object, e As EventArgs) Handles btnAddToBill.Click
        If txtProductQty.Text = "" Then
            MsgBox("Enter The Quantity")
        ElseIf Convert.ToInt32(txtProductQty.Text) > Stock Then
            MsgBox("No Enough Stock")

        Else
            Dim rnum As Integer = dgvBill.Rows.Add()
            i = i + 1
            dgvBill.Rows.Item(rnum).Cells("column1").Value = i
            dgvBill.Rows.Item(rnum).Cells("column2").Value = Pname
            dgvBill.Rows.Item(rnum).Cells("column3").Value = txtProductQty.Text
            dgvBill.Rows.Item(rnum).Cells("column4").Value = Price
            dgvBill.Rows.Item(rnum).Cells("column5").Value = Convert.ToInt32(txtProductQty.Text) * Price
            GrdTotal = GrdTotal + (Convert.ToInt32(txtProductQty.Text) * Price)
            'UpdateBillTotal()
            txtSubTotal.Text = GrdTotal
            UpdateQty()
            DisplayProd()
            txtProductQty.Text = ""
            txtProductSearch.Text = ""
        End If
    End Sub

    Private Sub txtTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged
        Dim Tax
        If txtTax.Text = "" Or txtTax.Text = "0" Then
            txtTaxAmt.Text = 0
            txtGrdTotal.Text = Convert.ToDouble(txtSubTotal.Text)
        Else
            Tax = Convert.ToDecimal(txtSubTotal.Text) * (Convert.ToDecimal(txtTax.Text) / 100)
            txtTaxAmt.Text = Tax
            txtGrdTotal.Text = Tax + Convert.ToDouble(txtSubTotal.Text)
        End If
    End Sub

    Private Sub txtDisc_TextChanged(sender As Object, e As EventArgs) Handles txtDisc.TextChanged
        Dim Disc
        If txtDisc.Text = "" Or txtDisc.Text = "0" Then
            txtTaxAmt.Text = 0
            txtGrdTotal.Text = Convert.ToDouble(txtSubTotal.Text)
        Else
            Disc = Convert.ToDecimal(txtSubTotal.Text) * (Convert.ToDecimal(txtDisc.Text) / 100)
            txtDiscAmt.Text = Disc
            txtGrdTotal.Text = Convert.ToDouble(txtSubTotal.Text) - Disc
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set the font and brush for the header
        Dim headerFont As New Font("Averia", 20, FontStyle.Bold)
        Dim headerBrush As New SolidBrush(Color.Black)

        ' Draw the header
        e.Graphics.DrawString("COMPANY NAME", headerFont, headerBrush, 50, 50)

        ' Set the font and brush for the address and other details
        Dim detailsFont As New Font("Averia", 10)
        e.Graphics.DrawString("Address:", detailsFont, headerBrush, 50, 75)
        e.Graphics.DrawString("Date:", detailsFont, headerBrush, 50, 90)
        e.Graphics.DrawString("Manager:", detailsFont, headerBrush, 50, 105)

        ' Set the font and brush for the bill items
        Dim itemFont As New Font("Averia", 10)
        Dim itemBrush As New SolidBrush(Color.Black)
        Dim currentY As Integer = 135

        ' Draw the bill items
        e.Graphics.DrawString("Description", itemFont, itemBrush, 50, 135)
        e.Graphics.DrawString("Price", itemFont, itemBrush, 350, 135)
        currentY += 15

        For i As Integer = 0 To dgvBill.Rows.Count - 1
            e.Graphics.DrawString(dgvBill.Rows(i).Cells("column1").Value, itemFont, itemBrush, 350, currentY)
            e.Graphics.DrawString(dgvBill.Rows(i).Cells("column2").Value, itemFont, itemBrush, 50, currentY)
            currentY += 15
        Next

        ' Set the font and brush for the total amount
        Dim totalFont As New Font("Averia", 12, FontStyle.Bold)
        Dim totalBrush As New SolidBrush(Color.Black)
        e.Graphics.DrawString("Tax", totalFont, totalBrush, 50, currentY + 15)
        e.Graphics.DrawString("TOTAL", totalFont, totalBrush, 350, currentY + 15)
        e.Graphics.DrawString(Convert.ToString(GrdTotal), totalFont, totalBrush, 450, currentY + 15)

        ' Set the font and brush for the barcode
        Dim barcodeFont As New Font("Averia", 8)
        e.Graphics.DrawString("1234567890123456789021", barcodeFont, itemBrush, 50, currentY + 35)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        InsertBill()
        PrintPreviewDialog1.Document = PrintDocument1
        ' Show the print preview dialog
        PrintPreviewDialog1.ShowDialog()
    End Sub


    Private Sub dgvProduct_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProduct.CellMouseClick
        Dim row As DataGridViewRow = dgvProduct.Rows(e.RowIndex)
        Pname = row.Cells(1).Value.ToString
        'cbProductCat.SelectedItem = row.Cells(2).Value.ToString
        If Pname = "" Then
            Key = 0
            Price = 0
            Stock = 0

        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Price = Convert.ToDouble(row.Cells(3).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(4).Value.ToString)
        End If
    End Sub

    Private Sub FetchCustomer()
        con.Open()
        Dim Query = "Select * from CustomerTbl where CustId = '" & cbCustomerId.SelectedValue.ToString & "'"
        Dim cmd As New SqlCommand(Query, con)
        Dim Tbl As New DataTable()
        Dim sda = New SqlDataAdapter(cmd)
        sda.Fill(Tbl)
        For Each dr As DataRow In Tbl.Rows
            txtCustomerName.Text = dr(1).ToString
        Next

        con.Close()
    End Sub

    Private Sub GetCustomer()
        con.Open()
        Dim Query = "Select * from CustomerTbl"
        Dim cmd As New SqlCommand(Query, con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        cbCustomerId.DataSource = Tbl
        cbCustomerId.DisplayMember = "CustId"
        cbCustomerId.ValueMember = "CustId"
        con.Close()
    End Sub

    Private Sub cbCustomerId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCustomerId.SelectionChangeCommitted
        FetchCustomer()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvBill.Rows.Clear()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub SearchProduct()
        con.Open()
        Dim query As String = "SELECT * FROM ProductTbl WHERE PName LIKE @SearchTerm"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtProductSearch.Text + "%")
        adapter = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        adapter.Fill(ds)
        dgvProduct.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub btnProductSearch_Click(sender As Object, e As EventArgs) Handles btnProductSearch.Click
        SearchProduct()
    End Sub

    Private Sub txtProductSearch_TextChanged(sender As Object, e As EventArgs) Handles txtProductSearch.TextChanged
        SearchProduct()
    End Sub

    Private Sub txtProductSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnProductSearch_Click(sender, e)
        End If
    End Sub

    Private Sub txtProductQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddToBill_Click(sender, e)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvBill.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvBill.SelectedRows(0)
            Dim productName As String = selectedRow.Cells("column2").Value.ToString()
            Dim productQuantity As Integer = Convert.ToInt32(selectedRow.Cells("column3").Value)
            Dim productPrice As Double = Convert.ToDouble(selectedRow.Cells("column4").Value)

            ' Update the quantity in the dgvProduct
            Dim productRow As DataGridViewRow = dgvProduct.Rows.Cast(Of DataGridViewRow)().Where(Function(r) r.Cells(1).Value.ToString() = productName).FirstOrDefault()
            If productRow IsNot Nothing Then
                Dim currentStock As Integer = Convert.ToInt32(productRow.Cells(4).Value)
                productRow.Cells(4).Value = currentStock + productQuantity
            End If

            ' Remove the row from the dgvBill
            dgvBill.Rows.Remove(selectedRow)

            ' Update the grand total
            GrdTotal -= (productQuantity * productPrice)
            txtSubTotal.Text = GrdTotal
        End If
    End Sub

    Private Sub dgvBill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBill.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            Dim columnName As String = dgvBill.Columns(e.ColumnIndex).Name
            If columnName = "Add" Then
                ' Handle the "Add" button click
                Dim currentQty As Integer = Convert.ToInt32(dgvBill.Rows(e.RowIndex).Cells("Quantity").Value)
                dgvBill.Rows(e.RowIndex).Cells("Quantity").Value = currentQty + 1
                'UpdateBillTotal()
            ElseIf columnName = "Sub" Then
                ' Handle the "Sub" button click
                Dim currentQty As Integer = Convert.ToInt32(dgvBill.Rows(e.RowIndex).Cells("Quantity").Value)
                If currentQty > 1 Then
                    dgvBill.Rows(e.RowIndex).Cells("Quantity").Value = currentQty - 1
                    'UpdateBillTotal()
                End If
            End If
        End If
    End Sub

    'Private Sub UpdateBillTotal()
    'Dim total As Double = 0
    'For i As Integer = 0 To dgvBill.Rows.Count - 1
    'Dim qty As Integer = Convert.ToInt32(dgvBill.Rows(i).Cells("column3").Value)
    'Dim price As Double = Convert.ToDouble(dgvBill.Rows(i).Cells("column4").Value)
    ' total += qty * price
    'Next
    'txtSubTotal.Text = total.ToString("N2")
    ' txtGrdTotal.Text = total.ToString("N2")
    'End Sub

    'Private Sub dgvBill_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBill.CellContentDoubleClick

    'End Sub

    Private Sub InsertBill()
        If txtCustomerName.Text = "" Or txtGrdTotal.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                con.Open()
                Dim Query = "Insert into BillTbl(BDate, CustId, CustName, Amt)values(@BD,@CI,@CN,@A)"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date)
                cmd.Parameters.AddWithValue("@CI", cbCustomerId.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@CN", txtCustomerName.Text)
                cmd.Parameters.AddWithValue("@A", txtGrdTotal.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Bill Saved")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                cbCustomerId.SelectedValue = -1
                txtCustomerName.Text = ""
                txtGrdTotal.Text = ""

                DisplayProd()

            End Try
        End If
    End Sub
End Class