Public Class frmPedals
    Private Sub lstPedals_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPedals.SelectedIndexChanged
        Try


            If lstPedals.SelectedItem.ToString = "Plastic Standard          $25" Then
            lblDescription.Text = "The Plastic Standard pedals are inexpensive and easily replacable. A beginner's go-to!"
        ElseIf lstPedals.SelectedItem.ToString = "Metal Studded              $50" Then
            lblDescription.Text = "The Metal Studded pedals are a common standard for both amateur and professional riders. Built to last!"
        ElseIf lstPedals.SelectedItem.ToString = "Composite Studded   $75" Then
            lblDescription.Text = "The Composite Studded pedals are the top tier studded pedals. With increased strength and reduced weight, these pedals are a win-win!"
        ElseIf lstPedals.SelectedItem.ToString = "Carbon Fiber Clip-in   $100" Then
            lblDescription.Text = "The Carbon Fiber Clip-in pedals are designed for professional riders looking to get a competetive edge in every way possible. Click into high gear with these high-end pedals!"
        End If

        Catch ex As Exception
            lblDescription.Text = ""
        End Try
    End Sub

    Private Sub grbxFrames_Enter(sender As Object, e As EventArgs) Handles grbxPedals.Enter

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the Form

        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get the selected pedals as input from the user 
        ' and return to the MainForm form.
        If VerifySelectedPedals() Then
            ' Close the PedalsForm form.
            Me.Close()
        Else
            'Display a message to the user indicating that a selection is needed.
            MessageBox.Show("Select an item from the list.", "Selection Needed")
        End If
    End Sub
    ' The VerifySelectedPedals Function gets the selected pedals as input from the user.
    ' and stores the price and item name in the global variables. It returns True if 
    ' an item is selected, otherwise it returns False.
    Function VerifySelectedPedals() As Boolean

        Dim blnStatus As Boolean = True ' Intialize the status flag to True.

        ' Determine which Pedal Set was selected and set the variables.
        Select Case lstPedals.SelectedIndex
            Case 0
                g_decPEDALS = g_decPEDALS_PLASTIC
                g_strPEDALS = "Plastic Standard"
            Case 1
                g_decPEDALS = g_decPEDALS_METAL
                g_strPEDALS = "Metal Studded"
            Case 2
                g_decPEDALS = g_decPEDALS_COMPOSITE
                g_strPEDALS = "Composite Studded"
            Case 3
                g_decPEDALS = g_decPEDALS_CARBON
                g_strPEDALS = "Carbon Fiber Clip-in"
            Case Else

                ' Set the status flag to False
                blnStatus = False
        End Select

        ' Return the status.
        Return blnStatus
    End Function
End Class