Public Class frmMain

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        'Closes the form

        Me.Close()

    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        'Shows message box describing program

        MessageBox.Show("Pat's Bike Shack V1.0" & vbCrLf & "by Patrick C. Carroll", "Pat's Bike Shack V1.0")


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuParts.Click

    End Sub

    Private Sub mnuPartsFrame_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form

        Me.Close()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFrames_Click(sender As Object, e As EventArgs) Handles btnFrames.Click
        'Create an instance of the FramesForm
        Dim frmFrames As New frmFrames

        'Display the FramesForm in modal style
        frmFrames.ShowDialog()

    End Sub

    Private Sub btnPedals_Click(sender As Object, e As EventArgs) Handles btnPedals.Click
        'Create an instance of the PedalsForm
        Dim frmPedals As New frmPedals

        'Display the PedalsForm in modal style
        frmPedals.ShowDialog()
    End Sub

    Private Sub btnTires_Click(sender As Object, e As EventArgs) Handles btnTires.Click
        'Create an instance of the TiresForm
        Dim frmTires As New frmTires

        'Display the TiresForm in modal style
        frmTires.ShowDialog()
    End Sub

    Private Sub btnExtras_Click(sender As Object, e As EventArgs) Handles btnExtras.Click
        'Create an instance of the ExtrasForm
        Dim frmExtras As New frmExtras

        'Display the ExtrasForm in modal style
        frmExtras.ShowDialog()
    End Sub
    Private Sub MainForm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ' When the form is activated, update and display any changes made by the user.
        UpdateDisplayProducts()
        UpdateDisplayExtras()
        UpdateDisplayCharges()
    End Sub

    ' The UpdateDisplayCharges procedure updates and displays the charges, if any, 
    ' otherwise it sets the Text in the subtotal, tax, and total labels to an empty string.
    Sub UpdateDisplayCharges()

        If CalcSubTotal() > 0D Then
            lblSubtotal.Text = CalcSubTotal.ToString("c")
            lblTax.Text = CalcTax.ToString("c")
            lblTotal.Text = CalcTotal.ToString("c")
        Else
            lblSubtotal.Text = String.Empty
            lblTax.Text = String.Empty
            lblTotal.Text = String.Empty
        End If

    End Sub

    ' The UpdateDisplayMisc function checks for names of miscellaneous
    ' products and services and displays them in the lstExtras list box.
    Sub UpdateDisplayExtras()

        ' Clear the list box.
        lstExtras.Items.Clear()

        ' Add names of miscellaneous products and services, 
        ' if they do not contain an empty string.
        If Not g_strEXTRAS_LIGHTS = String.Empty Then
            lstExtras.Items.Add(g_strEXTRAS_LIGHTS)
        End If

        If Not g_strEXTRAS_PUMP = String.Empty Then
            lstExtras.Items.Add(g_strEXTRAS_PUMP)
        End If

        If Not g_strEXTRAS_REGULARHELMIT = String.Empty Then
            lstExtras.Items.Add(g_strEXTRAS_REGULARHELMIT)
        End If

        If Not g_strEXTRAS_FULLHELMIT = String.Empty Then
            lstExtras.Items.Add(g_strEXTRAS_FULLHELMIT)
        End If
    End Sub

    ' The UpdateDisplayProducts procedure updates and displays
    ' the names of products
    Sub UpdateDisplayProducts()
        lblFrame.Text = g_strFRAME
        lblPedals.Text = g_strPEDALS
        lblTires.Text = g_strTIRES
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ' Reset all names and charges
        ResetCharges()
        ResetExtraCharges()
        UpdateDisplayExtras()
        UpdateDisplayProducts()
        UpdateDisplayCharges()
        btnFrames.Focus()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnClearExtras_Click(sender As Object, e As EventArgs) Handles btnClearExtras.Click
        'Clear lstExtras listbox, reset the extra charges and update and display the charges
        lstExtras.Items.Clear()
        ResetExtraCharges()
        UpdateDisplayCharges()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuPartsFrameBMX_Click(sender As Object, e As EventArgs) Handles mnuPartsFrameBMX.Click
        'Shows message box describing BMX Frame

        MessageBox.Show("The BMX Ripper is the ultimate stunt bike for both dirt and concrete parks." & vbCrLf & "Shred on!", "The BMX Ripper")
    End Sub

    Private Sub mnuPartsFrameMountain_Click(sender As Object, e As EventArgs) Handles mnuPartsFrameMountain.Click
        'Shows message box describing Mountain Frame

        MessageBox.Show("The Mountain Crusher is built to take on the most extreme terrains." & vbCrLf & "Push yourself to the next level with the Crusher!", "The Mountain Crusher")
    End Sub

    Private Sub mnuPartsFrameBeach_Click(sender As Object, e As EventArgs) Handles mnuPartsFrameBeach.Click
        'Shows message box describing BMX Frame

        MessageBox.Show("The Beach Cruiser is designed to be a leisurely bike, allowing you to enjoy your surroundings as you breeze around." & vbCrLf & "Take it easy with the Cruiser!", "The Beach Cruiser")
    End Sub

    Private Sub mnuPartsFrameRoad_Click(sender As Object, e As EventArgs) Handles mnuPartsFrameRoad.Click
        'Shows message box describing Road Frame

        MessageBox.Show("The Road Master is carefully crafted from Carbon Fiber to achieve the lightest and strongest frame on the market." & vbCrLf & "Be the next Road Bike Champion with the Road Master!", "The Road Master")
    End Sub

    Private Sub mnuPartsPedalsPlastic_Click(sender As Object, e As EventArgs) Handles mnuPartsPedalsPlastic.Click
        'Shows message box describing Plastic Pedals

        MessageBox.Show("The Plastic Standard pedals are inexpensive and easily replacable." & vbCrLf & "A beginner's go-to!", "The Plastic Standard")

    End Sub

    Private Sub mnuPartsPedalsMetal_Click(sender As Object, e As EventArgs) Handles mnuPartsPedalsMetal.Click
        'Shows message box describing Metal Pedals

        MessageBox.Show("The Metal Studded pedals are a common standard for both amateur and professional riders." & vbCrLf & "Built to last!", "The Metal Studded")
    End Sub

    Private Sub mnuPartsPedalsComposite_Click(sender As Object, e As EventArgs) Handles mnuPartsPedalsComposite.Click
        'Shows message box describing

        MessageBox.Show("The Composite Studded pedals are the top tier studded pedals." & vbCrLf & "With increased strength and reduced weight, these pedals are a win-win!", "The Composite Studded")
    End Sub

    Private Sub mnuPartsPedalsCarbon_Click(sender As Object, e As EventArgs) Handles mnuPartsPedalsCarbon.Click
        'Shows message box describing

        MessageBox.Show("The Carbon Fiber Clip-in pedals are designed for professional riders looking to get a competetive edge in every way possible." & vbCrLf & "Click into high gear with these high-end pedals!", "The Carbon Fiber Clip-in")
    End Sub

    Private Sub mnuPartsTiresKnobby_Click(sender As Object, e As EventArgs) Handles mnuPartsTiresKnobby.Click
        'Shows message box describing

        MessageBox.Show("The Knobby tires are purpose built for off-road applications." & vbCrLf & "Dirt, gravel, and sand friendly!", "The Knobby Tires")
    End Sub

    Private Sub mnuPartsTiresSlick_Click(sender As Object, e As EventArgs) Handles mnuPartsTiresSlick.Click
        'Shows message box describing

        MessageBox.Show("The Slick tires are purpose built for on-road applications." & vbCrLf & "Asphalt, concrete, and cement friendly!", "The Slick Tires")
    End Sub

    Private Sub mnuPartsTiresHybrid_Click(sender As Object, e As EventArgs) Handles mnuPartsTiresHybrid.Click
        'Shows message box describing

        MessageBox.Show("The Hybrid tires are made to take on a variety of surfaces." & vbCrLf & "Ride on dirt and pavement with ease!", "The Hybrid Tires")
    End Sub

    Private Sub mnuPartsTiresRacing_Click(sender As Object, e As EventArgs) Handles mnuPartsTiresRacing.Click
        'Shows message box describing

        MessageBox.Show("The Racing tires are purpose built for BMX and Road racing applications." & vbCrLf & "Ride in race or training conditions only!", "The Racing Tires")
    End Sub

    Private Sub mnuPartsExtrasLights_Click(sender As Object, e As EventArgs) Handles mnuPartsExtrasLights.Click
        'Shows message box describing

        MessageBox.Show("The Road Light Kit allows for night time road illumination." & vbCrLf & "A must have for the night owls!", "The Road Light Kit")
    End Sub

    Private Sub mnuPartsExtrasPump_Click(sender As Object, e As EventArgs) Handles mnuPartsExtrasPump.Click
        'Shows message box describing

        MessageBox.Show("The Tire Pump Kit allows for easy tire pressure maintence." & vbCrLf & "A necessity for any biker!", "The Tire Pump Kit")
    End Sub

    Private Sub mnuPartsExtrasRegularHelmit_Click(sender As Object, e As EventArgs) Handles mnuPartsExtrasRegularHelmit.Click
        'Shows message box describing

        MessageBox.Show("Designed with protection in mind, the Regular Helmit is made to keep all bikers safe in regular conditions." & vbCrLf & "A necessity for any rider!", "The Regular Helmit")
    End Sub

    Private Sub mnuPartsExtrasFullHelmit_Click(sender As Object, e As EventArgs) Handles mnuPartsExtrasFullHelmit.Click
        'Shows message box describing

        MessageBox.Show("Designed with complete protection in mind, the Full Face Helmit is made to keep all bikers safe in extreme conditions." & vbCrLf & "A must have for the adventurous!", "The Full Face Helmit")
    End Sub

    Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged
        Try
            If radYes.Checked = True Then
                g_decASSEMBLY = g_decASSEMBLYTRUE
            ElseIf radYes.Checked = False Then
                g_decASSEMBLY = 0
            End If
        Catch ex As Exception
            g_decASSEMBLY = 0
        End Try
    End Sub

    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        Try
            If radYes.Checked = True Then
                g_decASSEMBLY = 0
            ElseIf radYes.Checked = False Then
                g_decASSEMBLY = 0
            End If
        Catch ex As Exception
            g_decASSEMBLY = 0
        End Try
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        MessageBox.Show("Please Call 1-800-123-4567 for more information", "Contact Us")
    End Sub
End Class
