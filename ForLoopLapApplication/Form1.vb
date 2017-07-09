Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'ColorBox(1, 1, Color.Red)
        'ColorBox(1, 2, Color.Red)
        'ColorBox(1, 3, Color.Red)
        'ColorBox(1, 4, Color.Red)

        Dim intColumn As Integer
        'Dim intRow As Integer
        'For intRow = 1 To 9 Step 2
        For intColumn = 1 To 9
            'ColorBox(intRow, 6, Color.Blue)
            ColorBox(1, intColumn, Color.DarkRed)
            ColorBox(2, intColumn, Color.Red)
            ColorBox(3, intColumn, Color.Orange)
            ColorBox(4, intColumn, Color.Yellow)
            ColorBox(5, intColumn, Color.Lime)
            ColorBox(6, intColumn, Color.Cyan)
            ColorBox(7, intColumn, Color.LightBlue)
            ColorBox(8, intColumn, Color.Magenta)
            ColorBox(9, intColumn, Color.Purple)
        Next
        ' Next

    End Sub
    ' Magic Code :-)
    ' Do not change anything beyond this line

    Private Const C_MARGIN As Integer = 10
    Private Const C_SIZE As Integer = 20
    Private Const C_GRID_SIZE As Integer = 9
    Private m_picBoxes(C_GRID_SIZE - 1, C_GRID_SIZE - 1) As PictureBox

    Private Sub Init()
        Dim Row As Integer = 0
        Dim Column As Integer = 0
        For X As Integer = C_MARGIN To (C_SIZE + C_MARGIN) * C_GRID_SIZE Step C_MARGIN + C_SIZE
            For Y As Integer = C_MARGIN To (C_SIZE + C_MARGIN) * C_GRID_SIZE Step C_MARGIN + C_SIZE
                Dim picNew As PictureBox = New PictureBox()
                picNew.BorderStyle = BorderStyle.FixedSingle
                picNew.Location = New Point(X, Y)
                picNew.Size = New Size(C_SIZE, C_SIZE)
                Me.Controls.Add(picNew)
                m_picBoxes(Row, Column) = picNew
                Row += 1
            Next ' Y

            Row = 0
            Column += 1
        Next ' X
    End Sub

    Private Sub ColorBox(row As Integer, column As Integer, color As Color)
        m_picBoxes(row - 1, column - 1).BackColor = color
    End Sub

    ' End of magic code

End Class
