Public Class frmExtras
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the Form

        Me.Close()
    End Sub

    Private Sub frmExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Get the selected extra products and services as 
        ' input from the user and return to the MainForm form.
        If VerifySelectedExtras() Then
            ' Close the ExtrasForm form.
            Me.Close()
        Else
            ' Display a message to the user indicating that no items were selected.
            MessageBox.Show("Select a product or service.", "Selection Needed")
        End If
    End Sub

    ' The VerifySelectedExtras Function gets the extra products as input from the user.
    ' and stores the price and item names in the global variables. 
    ' It returns True if at least one item is selected, otherwise it returns False.
    Function VerifySelectedExtras() As Boolean

        Dim blnStatus As Boolean = False    ' Flag for the selected item status.

        ' Determine which miscellaneous products and services were selected.
        ' If any one item is selected, then set the status to True.
        If chkLights.Checked And g_strEXTRAS_LIGHTS = String.Empty Then
            g_decEXTRAS += g_decEXTRAS_LIGHTS
            g_strEXTRAS_LIGHTS = "Road Light Kit"
            blnStatus = True
        End If

        If chkPump.Checked And g_strEXTRAS_PUMP = String.Empty Then
            g_decEXTRAS += g_decEXTRAS_PUMP
            g_strEXTRAS_PUMP = "Tire Pump Kit"
            blnStatus = True
        End If

        If chkRegularHelmit.Checked And g_strEXTRAS_REGULARHELMIT = String.Empty Then
            g_decEXTRAS += g_decEXTRAS_REGULARHELMIT
            g_strEXTRAS_REGULARHELMIT = "Regular Helmit"
            blnStatus = True
        End If

        If chkFullHelmit.Checked And g_strEXTRAS_FULLHELMIT = String.Empty Then
            g_decEXTRAS += g_decEXTRAS_FULLHELMIT
            g_strEXTRAS_FULLHELMIT = "Full Face Helmit"
            blnStatus = True
        End If
        ' Return the status.
        Return blnStatus
    End Function


    Private Sub cklstExtras_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub grbxExtras_Enter(sender As Object, e As EventArgs) Handles grbxExtras.Enter

    End Sub

    Private Sub chkLights_CheckedChanged(sender As Object, e As EventArgs) Handles chkLights.CheckedChanged
        Try
            If chkLights.Checked = True Then
                lblDescription.Text = "The Road Light Kit allows for night time road illumination. A must have for the night owls!"
            ElseIf chkLights.Checked = False Then
                lblDescription.Text = ""
            End If
        Catch ex As Exception
            lblDescription.Text = ""
        End Try
    End Sub

    Private Sub chkPump_CheckedChanged(sender As Object, e As EventArgs) Handles chkPump.CheckedChanged
        Try
            If chkPump.Checked = True Then
                lblDescription.Text = "The Tire Pump Kit allows for easy tire pressure maintence. A necessity for any biker!"
            ElseIf chkPump.Checked = False Then
                lblDescription.Text = ""
            End If
        Catch ex As Exception
            lblDescription.Text = ""
        End Try
    End Sub

    Private Sub chkRegularHelmit_CheckedChanged(sender As Object, e As EventArgs) Handles chkRegularHelmit.CheckedChanged
        Try
            If chkRegularHelmit.Checked = True Then
                lblDescription.Text = "Designed with protection in mind, the Regular Helmit is made to keep all bikers safe in regular conditions. A necessity for any rider!"
            ElseIf chkRegularHelmit.Checked = False Then
                lblDescription.Text = ""
            End If
        Catch ex As Exception
            lblDescription.Text = ""
        End Try
    End Sub

    Private Sub chkFullHelmit_CheckedChanged(sender As Object, e As EventArgs) Handles chkFullHelmit.CheckedChanged
        Try
            If chkFullHelmit.Checked = True Then
                lblDescription.Text = "Designed with complete protection in mind, the Full Face Helmit is made to keep all bikers safe in extreme conditions. A must have for the adventurous!"
            ElseIf chkFullHelmit.Checked = False Then
                lblDescription.Text = ""
            End If
        Catch ex As Exception
            lblDescription.Text = ""
        End Try
    End Sub
End Class