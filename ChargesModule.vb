Module ChargesModule

    'Global Constants
    Public g_decSALES_TAX As Decimal = 0.06D                                 'A 6% Sales Tax applicable to all items
    Public g_decFRAMES_BMX As Decimal = 125D                                 'The BMX Ripper Frame is $125
    Public g_decFRAMES_MOUNTAIN As Decimal = 250D                            'The Mountain Crusher Frame is $250
    Public g_decFRAMES_BEACH As Decimal = 175D                               'The Beach Cruiser Frame is $175
    Public g_decFRAMES_ROAD As Decimal = 325D                                'The Road Master Frame is $325
    Public g_decPEDALS_PLASTIC As Decimal = 25D                              'The Plastic Pedals are $25
    Public g_decPEDALS_METAL As Decimal = 50D                                'The Metal Pedals are $50
    Public g_decPEDALS_COMPOSITE As Decimal = 75D                            'The Composite Pedals are $75
    Public g_decPEDALS_CARBON As Decimal = 100D                              'The Carbon Fiber Pedals are $100
    Public g_decTIRES_KNOBBY As Decimal = 30D                                'The Knobby Tires are $30
    Public g_decTIRES_SLICK As Decimal = 40D                                 'The Slick Tires are $40
    Public g_decTIRES_HYBRID As Decimal = 50D                                'The Hybrid Tires are $50
    Public g_decTIRES_RACING As Decimal = 60D                                'The Racing Tires are $60
    Public g_decEXTRAS_LIGHTS As Decimal = 25D                               'The Road Light Kit is $25
    Public g_decEXTRAS_PUMP As Decimal = 25D                                 'The Tire Pump Kit is $25
    Public g_decEXTRAS_REGULARHELMIT As Decimal = 50D                        'The Regular Helmit is $50
    Public g_decEXTRAS_FULLHELMIT As Decimal = 100D                          'The Full Face Helmit is $100
    Public g_decASSEMBLYTRUE As Decimal = 20D                                'The Assembly charge is $20

    'Global Variables
    Public g_decFRAME As Decimal = 0D                                        'To hold the charge for the selected frame
    Public g_decPEDALS As Decimal = 0D                                       'To hold the charge for the selected pedals
    Public g_decTIRES As Decimal = 0D                                        'To hold the charge for the selected tires
    Public g_decEXTRAS As Decimal = 0D                                       'To hold the charge for the selected extras
    Public g_decASSEMBLY As Decimal = 0D                                     'To hold the charge for the assembly fee
    Public g_strFRAME As String = String.Empty                               'To hold the name of the selected frame
    Public g_strPEDALS As String = String.Empty                              'To hold the name of the selected pedals
    Public g_strTIRES As String = String.Empty                               'To hold the name of the selected tires
    Public g_strEXTRAS As String = String.Empty                              'To hold the name of the selected extras
    Public g_strEXTRAS_LIGHTS As String = String.Empty                       'To hold the name of the Road Light Kit, if selected
    Public g_strEXTRAS_PUMP As String = String.Empty                         'To hold the name of the Tire Pump Kit, if selected
    Public g_strEXTRAS_REGULARHELMIT = String.Empty                          'To hold the name of the Regular Helmit, if selected
    Public g_strEXTRAS_FULLHELMIT = String.Empty                             'To hold the name of the Full Face Helmit, if selected

    ' The CalcSubTotal function calculates and returns the subtotal.
    Public Function CalcSubTotal() As Decimal

        ' Calculate and return the subtotal
        Return g_decFRAME + g_decPEDALS + g_decTIRES + g_decEXTRAS + g_decASSEMBLY
    End Function

    ' The CalcTax function calculates and returns the sales tax.
    Public Function CalcTax() As Decimal

        ' Calculate and return the sales tax minus the assembly charge, if any.
        Return CalcSubTotal() * g_decSALES_TAX
    End Function

    ' The CalcTotal function calculates and returns the grand total.
    Public Function CalcTotal() As Decimal

        ' Calculate and return the grand total
        Return CalcSubTotal() + CalcTax()
    End Function

    ' The ResetMiscCharges procedure resets the names and charges for the miscellaneous products and services.
    Public Sub ResetExtraCharges()

        ' Reset the extra products and services names
        g_strEXTRAS_LIGHTS = String.Empty
        g_strEXTRAS_PUMP = String.Empty
        g_strEXTRAS_REGULARHELMIT = String.Empty
        g_strEXTRAS_FULLHELMIT = String.Empty

        ' Reset the miscellaneous charges
        g_decEXTRAS = 0D
        g_decASSEMBLY = 0D
    End Sub

    ' The ResetCharges procedure resets the names and charges for the products.
    Public Sub ResetCharges()

        ' Reset the product names
        g_strFRAME = String.Empty
        g_strPEDALS = String.Empty
        g_strTIRES = String.Empty

        ' Reset the product charges
        g_decFRAME = 0D
        g_decPEDALS = 0D
        g_decTIRES = 0D
    End Sub




End Module
