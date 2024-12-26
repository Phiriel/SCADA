<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicTrendChart2 = New AdvancedHMIControls.BasicTrendChart()
        Me.BasicTrendChart1 = New AdvancedHMIControls.BasicTrendChart()
        Me.BreakerStatus = New AdvancedHMIControls.BasicLabel()
        Me.Current = New AdvancedHMIControls.BasicLabel()
        Me.Voltage = New AdvancedHMIControls.BasicLabel()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 636)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ModbusTCPCom1
        '
        Me.ModbusTCPCom1.DisableSubscriptions = False
        Me.ModbusTCPCom1.IniFileName = ""
        Me.ModbusTCPCom1.IniFileSection = Nothing
        Me.ModbusTCPCom1.IPAddress = "127.0.0.1"
        Me.ModbusTCPCom1.MaxReadGroupSize = 20
        Me.ModbusTCPCom1.PollRateOverride = 500
        Me.ModbusTCPCom1.SwapBytes = True
        Me.ModbusTCPCom1.SwapWords = True
        Me.ModbusTCPCom1.TcpipPort = CType(502US, UShort)
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.ModbusTCPCom1
        Me.BasicIndicator1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicIndicator1.Location = New System.Drawing.Point(511, 307)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "00001"
        Me.BasicIndicator1.SelectColor2 = False
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator1.Size = New System.Drawing.Size(201, 55)
        Me.BasicIndicator1.TabIndex = 9
        Me.BasicIndicator1.Text = "BasicIndicator1"
        '
        'BasicTrendChart2
        '
        Me.BasicTrendChart2.BackColor = System.Drawing.Color.Black
        Me.BasicTrendChart2.ComComponent = Me.ModbusTCPCom1
        Me.BasicTrendChart2.Location = New System.Drawing.Point(322, 220)
        Me.BasicTrendChart2.MaxPoints = 100
        Me.BasicTrendChart2.Name = "BasicTrendChart2"
        Me.BasicTrendChart2.PLCAddressValue = "40002"
        Me.BasicTrendChart2.PLCAddressVisible = ""
        Me.BasicTrendChart2.Size = New System.Drawing.Size(149, 141)
        Me.BasicTrendChart2.TabIndex = 8
        Me.BasicTrendChart2.Text = "BasicTrendChart2"
        Me.BasicTrendChart2.Value = ""
        Me.BasicTrendChart2.YMaximum = 32767
        Me.BasicTrendChart2.YMinimum = 0
        '
        'BasicTrendChart1
        '
        Me.BasicTrendChart1.BackColor = System.Drawing.Color.Black
        Me.BasicTrendChart1.ComComponent = Me.ModbusTCPCom1
        Me.BasicTrendChart1.Location = New System.Drawing.Point(89, 220)
        Me.BasicTrendChart1.MaxPoints = 100
        Me.BasicTrendChart1.Name = "BasicTrendChart1"
        Me.BasicTrendChart1.PLCAddressValue = "40001"
        Me.BasicTrendChart1.PLCAddressVisible = ""
        Me.BasicTrendChart1.Size = New System.Drawing.Size(155, 142)
        Me.BasicTrendChart1.TabIndex = 7
        Me.BasicTrendChart1.Text = "BasicTrendChart1"
        Me.BasicTrendChart1.Value = ""
        Me.BasicTrendChart1.YMaximum = 32767
        Me.BasicTrendChart1.YMinimum = 0
        '
        'BreakerStatus
        '
        Me.BreakerStatus.AutoSize = True
        Me.BreakerStatus.BackColor = System.Drawing.Color.Black
        Me.BreakerStatus.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BreakerStatus.ComComponent = Me.ModbusTCPCom1
        Me.BreakerStatus.DisplayAsTime = False
        Me.BreakerStatus.ForeColor = System.Drawing.Color.White
        Me.BreakerStatus.Highlight = False
        Me.BreakerStatus.HighlightColor = System.Drawing.Color.Red
        Me.BreakerStatus.HighlightForeColor = System.Drawing.Color.White
        Me.BreakerStatus.HighlightKeyCharacter = "!"
        Me.BreakerStatus.InterpretValueAsBCD = False
        Me.BreakerStatus.KeypadAlphaNumeric = False
        Me.BreakerStatus.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BreakerStatus.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BreakerStatus.KeypadMaxValue = 0R
        Me.BreakerStatus.KeypadMinValue = 0R
        Me.BreakerStatus.KeypadScaleFactor = 1.0R
        Me.BreakerStatus.KeypadShowCurrentValue = False
        Me.BreakerStatus.KeypadText = Nothing
        Me.BreakerStatus.KeypadWidth = 300
        Me.BreakerStatus.Location = New System.Drawing.Point(531, 386)
        Me.BreakerStatus.Name = "BreakerStatus"
        Me.BreakerStatus.NumericFormat = Nothing
        Me.BreakerStatus.PLCAddressKeypad = ""
        Me.BreakerStatus.PLCAddressValue = "00001"
        Me.BreakerStatus.PollRate = 0
        Me.BreakerStatus.Size = New System.Drawing.Size(164, 27)
        Me.BreakerStatus.TabIndex = 6
        Me.BreakerStatus.Text = "BreakerStatus"
        Me.BreakerStatus.Value = "BreakerStatus"
        Me.BreakerStatus.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BreakerStatus.ValueLeftPadLength = 0
        Me.BreakerStatus.ValuePrefix = Nothing
        Me.BreakerStatus.ValueScaleFactor = 1.0R
        Me.BreakerStatus.ValueSuffix = Nothing
        Me.BreakerStatus.ValueToSubtractFrom = 0!
        '
        'Current
        '
        Me.Current.AutoSize = True
        Me.Current.BackColor = System.Drawing.Color.Black
        Me.Current.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.Current.ComComponent = Me.ModbusTCPCom1
        Me.Current.DisplayAsTime = False
        Me.Current.ForeColor = System.Drawing.Color.White
        Me.Current.Highlight = False
        Me.Current.HighlightColor = System.Drawing.Color.Red
        Me.Current.HighlightForeColor = System.Drawing.Color.White
        Me.Current.HighlightKeyCharacter = "!"
        Me.Current.InterpretValueAsBCD = False
        Me.Current.KeypadAlphaNumeric = False
        Me.Current.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.Current.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Current.KeypadMaxValue = 0R
        Me.Current.KeypadMinValue = 0R
        Me.Current.KeypadScaleFactor = 1.0R
        Me.Current.KeypadShowCurrentValue = False
        Me.Current.KeypadText = Nothing
        Me.Current.KeypadWidth = 300
        Me.Current.Location = New System.Drawing.Point(317, 386)
        Me.Current.Name = "Current"
        Me.Current.NumericFormat = Nothing
        Me.Current.PLCAddressKeypad = ""
        Me.Current.PLCAddressValue = "40002"
        Me.Current.PollRate = 0
        Me.Current.Size = New System.Drawing.Size(93, 27)
        Me.Current.TabIndex = 5
        Me.Current.Text = "Current"
        Me.Current.Value = "Current"
        Me.Current.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Current.ValueLeftPadLength = 0
        Me.Current.ValuePrefix = Nothing
        Me.Current.ValueScaleFactor = 1.0R
        Me.Current.ValueSuffix = Nothing
        Me.Current.ValueToSubtractFrom = 0!
        '
        'Voltage
        '
        Me.Voltage.AutoSize = True
        Me.Voltage.BackColor = System.Drawing.Color.Black
        Me.Voltage.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.Voltage.ComComponent = Me.ModbusTCPCom1
        Me.Voltage.DisplayAsTime = False
        Me.Voltage.ForeColor = System.Drawing.Color.White
        Me.Voltage.Highlight = False
        Me.Voltage.HighlightColor = System.Drawing.Color.Red
        Me.Voltage.HighlightForeColor = System.Drawing.Color.White
        Me.Voltage.HighlightKeyCharacter = "!"
        Me.Voltage.InterpretValueAsBCD = False
        Me.Voltage.KeypadAlphaNumeric = False
        Me.Voltage.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.Voltage.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Voltage.KeypadMaxValue = 0R
        Me.Voltage.KeypadMinValue = 0R
        Me.Voltage.KeypadScaleFactor = 1.0R
        Me.Voltage.KeypadShowCurrentValue = False
        Me.Voltage.KeypadText = Nothing
        Me.Voltage.KeypadWidth = 300
        Me.Voltage.Location = New System.Drawing.Point(84, 386)
        Me.Voltage.Name = "Voltage"
        Me.Voltage.NumericFormat = Nothing
        Me.Voltage.PLCAddressKeypad = ""
        Me.Voltage.PLCAddressValue = "40001"
        Me.Voltage.PollRate = 0
        Me.Voltage.Size = New System.Drawing.Size(92, 27)
        Me.Voltage.TabIndex = 4
        Me.Voltage.Text = "Voltage"
        Me.Voltage.Value = "Voltage"
        Me.Voltage.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Voltage.ValueLeftPadLength = 0
        Me.Voltage.ValuePrefix = Nothing
        Me.Voltage.ValueScaleFactor = 1.0R
        Me.Voltage.ValueSuffix = Nothing
        Me.Voltage.ValueToSubtractFrom = 0!
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1271, 561)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.BasicTrendChart2)
        Me.Controls.Add(Me.BasicTrendChart1)
        Me.Controls.Add(Me.BreakerStatus)
        Me.Controls.Add(Me.Current)
        Me.Controls.Add(Me.Voltage)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents Voltage As AdvancedHMIControls.BasicLabel
    Friend WithEvents Current As AdvancedHMIControls.BasicLabel
    Friend WithEvents BreakerStatus As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicTrendChart2 As AdvancedHMIControls.BasicTrendChart
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicTrendChart1 As AdvancedHMIControls.BasicTrendChart
End Class
