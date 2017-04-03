Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.IO
Imports System.Collections.ObjectModel
Imports System.Text
Imports System.Windows.Forms


Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim base_dir As String = CombinePath(Application.StartupPath, "..\..")

        txtDir1.Text = base_dir & "\"
        txtDir2.Text = base_dir & "\"

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim wid As Integer = (dgvFiles.Width - 50) \ 4
        If wid < 10 Then wid = 10
        dgvFiles.Columns(0).Width = wid
        dgvFiles.Columns(1).Width = wid
        dgvFiles.Columns(2).Width = wid
        dgvFiles.Columns(3).Width = wid
    End Sub

    ' List the files in each directory.
    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        ' Get sorted lists of files in the directories.
        Dim files1 As ReadOnlyCollection(Of String) = _
            My.Computer.FileSystem.GetFiles(txtDir1.Text)
        Dim file_names1() As String = SortCollection(files1)

        Dim files2 As ReadOnlyCollection(Of String) = _
            My.Computer.FileSystem.GetFiles(txtDir2.Text)
        Dim file_names2() As String = SortCollection(files2)

        ' Compare.
        Dim i1 As Integer = 0
        Dim i2 As Integer = 0
        Do While (i1 < file_names1.Length) AndAlso (i2 < file_names2.Length)
            If file_names1(i1) = file_names2(i2) Then
                ' They match.
                dgvFiles.Rows.Add(New Object() {file_names1(i1), file_names2(i2), System.IO.File.GetLastWriteTime(txtDir1.Text & "\" & file_names1(i1)).ToString, System.IO.File.GetLastWriteTime(txtDir2.Text & "\" & file_names2(i2)).ToString})
                If Not System.IO.File.GetLastWriteTime(txtDir1.Text & "\" & file_names1(i1)).ToString = System.IO.File.GetLastWriteTime(txtDir2.Text & "\" & file_names2(i2)).ToString Then
                    dgvFiles.Rows.Item(i1).DefaultCellStyle.BackColor = Color.Red

                End If

                i1 += 1
                    i2 += 1
                ElseIf file_names1(i1) < file_names2(i2) Then
                    ' Display the directory 1 file.
                    dgvFiles.Rows.Add(New Object() {file_names1(i1), Nothing})
                    i1 += 1
                ElseIf file_names1(i1) > file_names2(i2) Then
                    ' Display the directory 2 file.
                    dgvFiles.Rows.Add(New Object() {Nothing, file_names2(i2)})
                i2 += 1
            End If
        Loop

        ' Display remaining directory 1 files.
        For i As Integer = i1 To file_names1.Length - 1
            dgvFiles.Rows.Add(New Object() {file_names1(i), Nothing})
        Next i

        ' Display remaining directory 2 files.
        For i As Integer = i2 To file_names2.Length - 1
            dgvFiles.Rows.Add(New Object() {Nothing, file_names2(i)})
        Next i
    End Sub

    ' Build an array holding the sorted values in
    ' the ReadOnlyCollection(Of String).
    Public Function SortCollection(ByVal coll As ReadOnlyCollection(Of String)) As String()
        ' Move the items into an array.
        Dim result(coll.Count - 1) As String
        For i As Integer = 0 To coll.Count - 1
            ' Get just the file title.
            Dim file_info As New FileInfo(coll(i))
            result(i) = file_info.Name
        Next i

        ' Sort the array.
        Quicksort(result, 0, coll.Count - 1)

        ' return the result.
        Return result
    End Function

    ' Sort the array of Strings.
    Public Sub Quicksort(ByVal list() As String, ByVal min As Long, ByVal max As Long)
        Dim med_value As String
        Dim hi As Long
        Dim lo As Long
        Dim i As Long

        ' If min >= max, the list contains 0 or 1 items so it is sorted.
        If min >= max Then Exit Sub

        ' Pick the dividing value.
        i = Int((max - min + 1) * Rnd() + min)
        med_value = list(i)

        ' Swap it to the front.
        list(i) = list(min)

        lo = min
        hi = max
        Do
            ' Look down from hi for a value < med_value.
            Do While list(hi) >= med_value
                hi = hi - 1
                If hi <= lo Then Exit Do
            Loop
            If hi <= lo Then
                list(lo) = med_value
                Exit Do
            End If

            ' Swap the lo and hi values.
            list(lo) = list(hi)

            ' Look up from lo for a value >= med_value.
            lo = lo + 1
            Do While list(lo) < med_value
                lo = lo + 1
                If lo >= hi Then Exit Do
            Loop
            If lo >= hi Then
                lo = hi
                list(hi) = med_value
                Exit Do
            End If

            ' Swap the lo and hi values.
            list(hi) = list(lo)
        Loop

        ' Sort the two sublists.
        Quicksort(list, min, lo - 1)
        Quicksort(list, lo + 1, max)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvFiles.DataSource = Nothing
        dgvFiles.Rows.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '    Dim headers = (From header As DataGridViewColumn In dgvFiles.Columns.cast(Of DataGridViewColumn)()
        '                   Select header.HeaderText).ToArray
        '    Dim rows = From row As DataGridViewRow In dgvFiles.Rows.Cast(Of DataGridViewRow)()
        '               Where Not row.IsNewRow
        '               Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        '    Using sw As New IO.StreamWriter("csv.txt")
        '        sw.WriteLine(String.Join(",", headers))
        '        For Each r In rows
        '            sw.WriteLine(String.Join(",", r))
        '        Next
        '    End Using
        '    Process.Start("csv.txt")
    End Sub

End Class
