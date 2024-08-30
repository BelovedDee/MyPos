Imports System.Data.SqlClient

Public Class frmCustomer
    Dim con = New SqlConnection("Data Source=(local);Initial Catalog=Pos_System;Integrated Security=True;Encrypt=False")

    Private Sub DisplayCust()
        con.Open()
        Dim Query = "Select * from CustomerTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(Query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvCustomer.DataSource = ds.Tables(0)
        con.Close
    End Sub
    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        If txtCustomerName.Text = "" Or txtCustomerNumber.Text = "" Or txtCustomerAddress.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                con.Open()
                Dim Query = "Insert into CustomerTbl(CustName, CustPhone, CustAd)values(@CN, @CP, @CA)"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@CN", txtCustomerName.Text)
                cmd.Parameters.AddWithValue("@CP", txtCustomerNumber.Text)
                cmd.Parameters.AddWithValue("@CA", txtCustomerAddress.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Saved")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                txtCustomerName.Text = ""
                txtCustomerNumber.Text = ""
                txtCustomerAddress.Text = ""
                DisplayCust()

            End Try
        End If
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCust()
    End Sub

    Dim Key = 0
    Private Sub dgvCustomer_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomer.CellMouseClick
        Dim row As DataGridViewRow = dgvCustomer.Rows(e.RowIndex)
        txtCustomerName.Text = row.Cells(1).Value.ToString
        txtCustomerNumber.Text = row.Cells(3).Value.ToString
        txtCustomerAddress.Text = row.Cells(2).Value.ToString

        If txtCustomerName.Text = "" Then
            Key = 0

        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click
        If txtCustomerName.Text = "" Or txtCustomerNumber.Text = "" Or txtCustomerAddress.Text = "" Then
            MsgBox("Select Customer")

        Else
            Try
                con.Open()
                Dim Query = "Update CustomerTbl set CustName=@CN, CustPhone=@CP, CustAd=@CA where CustId=@CKey"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@CN", txtCustomerName.Text)
                cmd.Parameters.AddWithValue("@CP", txtCustomerNumber.Text)
                cmd.Parameters.AddWithValue("@CA", txtCustomerAddress.Text)
                cmd.Parameters.AddWithValue("@CKey", Key)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Updated")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                txtCustomerName.Text = ""
                txtCustomerNumber.Text = ""
                txtCustomerAddress.Text = ""
                DisplayCust()

            End Try
        End If
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If Key = 0 Then
            MsgBox("Select Product")

        Else
            Try
                con.Open()
                Dim Query = "Delete from CustomerTbl where CustId=@CKey"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@CKey", Key)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Deleted")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                txtCustomerName.Text = ""
                txtCustomerNumber.Text = ""
                txtCustomerAddress.Text = ""
                DisplayCust()

            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
    End Sub
End Class