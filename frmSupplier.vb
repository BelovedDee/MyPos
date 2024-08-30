Imports System.Data.SqlClient

Public Class frmSupplier
    Dim con = New SqlConnection("Data Source=(local);Initial Catalog=Pos_System;Integrated Security=True;Encrypt=False")

    Private Sub DisplaySup()
        con.Open()
        Dim Query = "Select * from SupplierTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(Query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvSupplier.DataSource = ds.Tables(0)
        con.Close
    End Sub

    Private Sub btnSaveSupplier_Click(sender As Object, e As EventArgs) Handles btnSaveSupplier.Click
        If txtSupplierName.Text = "" Or txtSupplierAddress.Text = "" Or txtSupplierPhone.Text = "" Or txtSupplierRemarks.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                con.Open()
                Dim Query = "Insert into SupplierTbl(SupName,SupAddress, SupPhone, SupRemarks)values(@SN,@SA,@SP,@SR)"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@SN", txtSupplierName.Text)
                cmd.Parameters.AddWithValue("@SA", txtSupplierAddress.Text)
                cmd.Parameters.AddWithValue("@SP", txtSupplierPhone.Text)
                cmd.Parameters.AddWithValue("@SR", txtSupplierRemarks.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Supplier Saved")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtSupplierName.Text = ""
                txtSupplierAddress.Text = ""
                txtSupplierPhone.Text = ""
                txtSupplierRemarks.Text = ""

                DisplaySup()
            End Try
        End If
    End Sub

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySup()
    End Sub

    Dim Key = 0
    Private Sub dgvSupplier_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSupplier.CellMouseClick
        Dim row As DataGridViewRow = dgvSupplier.Rows(e.RowIndex)
        txtSupplierName.Text = row.Cells(1).Value.ToString
        txtSupplierAddress.Text = row.Cells(2).Value.ToString
        txtSupplierPhone.Text = row.Cells(3).Value.ToString
        txtSupplierRemarks.Text = row.Cells(4).Value.ToString

        If txtSupplierName.Text = "" Then
            Key = 0

        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub btnEditSupplier_Click(sender As Object, e As EventArgs) Handles btnEditSupplier.Click
        If txtSupplierName.Text = "" Or txtSupplierAddress.Text = "" Or txtSupplierPhone.Text = "" Or txtSupplierRemarks.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                con.Open()
                Dim Query = "Update SupplierTbl set SupName=@SN ,SupAddress=@SA, SupPhone=@SP, SupRemarks=@SR where SupId=@SKey"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@SN", txtSupplierName.Text)
                cmd.Parameters.AddWithValue("@SA", txtSupplierAddress.Text)
                cmd.Parameters.AddWithValue("@SP", txtSupplierPhone.Text)
                cmd.Parameters.AddWithValue("@SR", txtSupplierRemarks.Text)
                cmd.Parameters.AddWithValue("@SKey", Key)
                cmd.ExecuteNonQuery()
                MsgBox("Supplier Updated")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtSupplierName.Text = ""
                txtSupplierAddress.Text = ""
                txtSupplierPhone.Text = ""
                txtSupplierRemarks.Text = ""

                DisplaySup()
            End Try
        End If
    End Sub

    Private Sub btnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles btnDeleteSupplier.Click
        If Key = 0 Then
            MsgBox("Select Supplier")

        Else
            Try
                con.Open()
                Dim Query = "Delete from SupplierTbl where SupId=@SKey"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@SKey", Key)
                cmd.ExecuteNonQuery()
                MsgBox("Supplier Deleted")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtSupplierName.Text = ""
                txtSupplierAddress.Text = ""
                txtSupplierPhone.Text = ""
                txtSupplierRemarks.Text = ""

                DisplaySup()
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
    End Sub
End Class