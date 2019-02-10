Public Class frmTires

    Private Sub lstTires_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTires.SelectedIndexChanged
        Try


            If lstTires.SelectedItem.ToString = "Knobby    $30" Then
                lblDescription.Text = "The Knobby tires are purpose built for off-road applications. Dirt, gravel, and sand friendly!"
            ElseIf lstTires.SelectedItem.ToString = "Slick          $40" Then
                lblDescription.Text = "The Slick tires are purpose built for on-road applications. Asphalt, concrete, and cement friendly!"
            ElseIf lstTires.SelectedItem.ToString = "Hybrid      $50" Then
                lblDescription.Text = "The Hybrid tires are made to take on a variety of surfaces. Ride on dirt and pavement with ease!"
            ElseIf lstTires.SelectedItem.ToString = "Racing      $60" Then
                lblDescription.Text = "The Racing tires are purpose built for BMX and Road racing applications. Ride in race or training conditions only!"
            End If
        Catch ex As Exception
            lblDescription.Text = ""
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the Form

        Me.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get the selected tires as input from the user 
        ' and return to the MainForm form.
        If VerifySelectedTires() Then
            ' Close the TiresForm form.
            Me.Close()
        Else
            'Display a message to the user indicating that a selection is needed.
            MessageBox.Show("Select an item from the list.", "Selection Needed")
        End If
    End Sub
    ' The VerifySelectedTires Function gets the selected tires as input from the user.
    ' and stores the price and item name in the global variables. It returns True if 
    ' an item is selected, otherwise it returns False.
    Function VerifySelectedTires() As Boolean

        Dim blnStatus As Boolean = True ' Intialize the status flag to True.

        ' Determine which Tire Set was selected and set the variables.
        Select Case lstTires.SelectedIndex
            Case 0
                g_decTIRES = g_decTIRES_KNOBBY
                g_strTIRES = "Knobby"
            Case 1
                g_decTIRES = g_decTIRES_SLICK
                g_strTIRES = "Slick"
            Case 2
                g_decTIRES = g_decTIRES_HYBRID
                g_strTIRES = "Hybrid"
            Case 3
                g_decTIRES = g_decTIRES_RACING
                g_strTIRES = "Racing"
            Case Else

                ' Set the status flag to False
                blnStatus = False
        End Select

        ' Return the status.
        Return blnStatus
    End Function

End Class