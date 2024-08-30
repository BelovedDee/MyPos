Imports System.Data.SqlClient

Public Class frmCategory
    Dim con = New SqlConnection("Data Source=(local);Initial Catalog=Pos_System;Integrated Security=True;Encrypt=False")

    Private Sub DisplayCategory()
        con.Open()
        Dim Query = "Select * from CategoryTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(Query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvCategory.DataSource = ds.Tables(0)
        con.Close
    End Sub
    Dim Key = 0
    Private Sub btnSaveCategory_Click(sender As Object, e As EventArgs) Handles btnSaveCategory.Click
        If txtProductCategory.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                con.Open()
                Dim Query = "Insert into CategoryTbl(CategoryName)values(@CatN)"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@CatN", txtProductCategory.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Category Saved")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtProductCategory.Text = ""
                DisplayCategory()

            End Try
        End If
    End Sub

    Private Sub btnEditCategory_Click(sender As Object, e As EventArgs) Handles btnEditCategory.Click
        If txtProductCategory.Text = "" Then
            MsgBox("Select Category")

        Else
            Try
                con.Open()
                Dim Query = "Update CategoryTbl set CategoryName=@CatN where CatId=@CatKey"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@CatN", txtProductCategory.Text)
                cmd.Parameters.AddWithValue("@Catkey", Key)
                cmd.ExecuteNonQuery()
                MsgBox("Category Updated")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtProductCategory.Text = ""
                DisplayCategory()

            End Try
        End If
    End Sub

    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        If Key = 0 Then
            MsgBox("Select Category")

        Else
            Try
                con.Open()
                Dim Query = "Delete from CategoryTbl where CatId=@CatKey"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@CatKey", Key)
                cmd.ExecuteNonQuery()
                MsgBox("Category Deleted")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()

                txtProductCategory.Text = ""
                DisplayCategory()
            End Try
        End If
    End Sub

    Private Sub dgvCategory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCategory.CellMouseClick
        Dim row As DataGridViewRow = dgvCategory.Rows(e.RowIndex)
        txtProductCategory.Text = row.Cells(1).Value.ToString

        If txtProductCategory.Text = "" Then
            Key = 0

        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCategory()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
    End Sub
End Class