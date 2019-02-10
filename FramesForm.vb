Public Class frmFrames

    Private Sub lstFrames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFrames.SelectedIndexChanged
        Try


            If lstFrames.SelectedItem.ToString = "BMX Ripper                 $125" Then
                lblDescription.Text = "The BMX Ripper is the ultimate stunt bike for both dirt and concrete parks. Shred on!"
            ElseIf lstFrames.SelectedItem.ToString = "Mountain Crusher    $250" Then
                lblDescription.Text = "The Mountain Crusher is built to take on the most extreme terrains. Push yourself to the next level with the Crusher!"
            ElseIf lstFrames.SelectedItem.ToString = "Beach Cruiser             $175" Then
                lblDescription.Text = "The Beach Cruiser is designed to be a leisurely bike, allowing you to enjoy your surroundings as you breeze around. Take it easy with the Cruiser!"
            ElseIf lstFrames.SelectedItem.ToString = "Road Master               $325" Then
                lblDescription.Text = "The Road Master is carefully crafted from Carbon Fiber to achieve the lightest and strongest frame on the market. Be the next Road Bike Champion with the Road Master!"
            End If

        Catch ex As Exception
            lblDescription.Text = ""
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get the selected frame as input from the user 
        ' and return to the MainForm form.
        If VerifySelectedFrame() Then
            ' Close the FramesForm form.
            Me.Close()
        Else
            'Display a message to the user indicating that a selection is needed.
            MessageBox.Show("Select an item from the list.", "Selection Needed")
        End If
    End Sub
    ' The VerifySelectedFrame Function gets the selected frame as input from the user.
    ' and stores the price and item name in the global variables. It returns True if 
    ' an item is selected, otherwise it returns False.
    Function VerifySelectedFrame() As Boolean

        Dim blnStatus As Boolean = True ' Intialize the status flag to True.

        ' Determine which Frame was selected and set the variables.
        Select Case lstFrames.SelectedIndex
            Case 0
                g_decFRAME = g_decFRAMES_BMX
                g_strFRAME = "BMX Ripper"
            Case 1
                g_decFRAME = g_decFRAMES_MOUNTAIN
                g_strFRAME = "Mountain Crusher"
            Case 2
                g_decFRAME = g_decFRAMES_BEACH
                g_strFRAME = "Beach Cruiser"
            Case 3
                g_decFRAME = g_decFRAMES_ROAD
                g_strFRAME = "Road Master"
            Case Else

                ' Set the status flag to False
                blnStatus = False
        End Select

        ' Return the status.
        Return blnStatus
    End Function

    Function DisplayDescription()

        'Declare variables
        Dim strBMX As String

        'Determine which Frame is selected and provide appropriate description
        If lstFrames.SelectedItem.ToString = "BMX Ripper                 $125" Then
            lblDescription.Text = "BMX"
        End If


    End Function
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the Form

        Me.Close()

    End Sub

    Private Sub lblDescription_Click(sender As Object, e As EventArgs) Handles lblDescription.Click

    End Sub

    Private Sub frmFrames_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class