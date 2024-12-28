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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.BreakerStatus = New AdvancedHMIControls.BasicLabel()
        Me.Current = New AdvancedHMIControls.BasicLabel()
        Me.Voltage = New AdvancedHMIControls.BasicLabel()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter2 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.ChartBySampling1 = New AdvancedHMIControls.ChartBySampling()
        Me.DataSubscriber1 = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.DataSubscriber2 = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.DataSubscriber3 = New AdvancedHMIControls.DataSubscriber(Me.components)
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartBySampling1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriber3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BasicIndicator1.Location = New System.Drawing.Point(175, 459)
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
        Me.BreakerStatus.Location = New System.Drawing.Point(224, 517)
        Me.BreakerStatus.Name = "BreakerStatus"
        Me.BreakerStatus.NumericFormat = Nothing
        Me.BreakerStatus.PLCAddressKeypad = ""
        Me.BreakerStatus.PLCAddressValue = "00001"
        Me.BreakerStatus.PollRate = 0
        Me.BreakerStatus.Size = New System.Drawing.Size(108, 18)
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
        Me.Current.Size = New System.Drawing.Size(59, 18)
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
        Me.Voltage.Size = New System.Drawing.Size(61, 18)
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
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.ModbusTCPCom1
        Me.DigitalPanelMeter1.DecimalPosition = 0
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(87, 350)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = ""
        Me.DigitalPanelMeter1.PLCAddressValue = "40001"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(76, 33)
        Me.DigitalPanelMeter1.TabIndex = 10
        Me.DigitalPanelMeter1.Text = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter2
        '
        Me.DigitalPanelMeter2.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter2.ComComponent = Me.ModbusTCPCom1
        Me.DigitalPanelMeter2.DecimalPosition = 0
        Me.DigitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter2.KeypadMaxValue = 0R
        Me.DigitalPanelMeter2.KeypadMinValue = 0R
        Me.DigitalPanelMeter2.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter2.KeypadText = Nothing
        Me.DigitalPanelMeter2.KeypadWidth = 300
        Me.DigitalPanelMeter2.Location = New System.Drawing.Point(320, 350)
        Me.DigitalPanelMeter2.Name = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.NumberOfDigits = 5
        Me.DigitalPanelMeter2.PLCAddressKeypad = ""
        Me.DigitalPanelMeter2.PLCAddressValue = "40002"
        Me.DigitalPanelMeter2.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.Size = New System.Drawing.Size(76, 33)
        Me.DigitalPanelMeter2.TabIndex = 11
        Me.DigitalPanelMeter2.Text = "DigitalPanelMeter2"
        Me.DigitalPanelMeter2.Value = 0R
        Me.DigitalPanelMeter2.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter2.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ChartBySampling1
        '
        ChartArea1.AxisX.Title = "Time (Seconds)"
        ChartArea1.AxisY.Title = "Values"
        ChartArea1.Name = "ChartArea1"
        Me.ChartBySampling1.ChartAreas.Add(ChartArea1)
        Me.ChartBySampling1.ComComponent = Me.ModbusTCPCom1
        Legend1.Name = "Legend1"
        Me.ChartBySampling1.Legends.Add(Legend1)
        Me.ChartBySampling1.Location = New System.Drawing.Point(485, 235)
        Me.ChartBySampling1.MaximumActivePoints = 100
        Me.ChartBySampling1.Name = "ChartBySampling1"
        Me.ChartBySampling1.PLCAddressItems.Add(CType(resources.GetObject("ChartBySampling1.PLCAddressItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.ChartBySampling1.PLCAddressItems.Add(CType(resources.GetObject("ChartBySampling1.PLCAddressItems1"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.ChartBySampling1.PLCAddressYAxisMax = Nothing
        Me.ChartBySampling1.PLCAddressYAxisMin = Nothing
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Voltage"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Current"
        Me.ChartBySampling1.Series.Add(Series1)
        Me.ChartBySampling1.Series.Add(Series2)
        Me.ChartBySampling1.Size = New System.Drawing.Size(300, 300)
        Me.ChartBySampling1.TabIndex = 12
        Me.ChartBySampling1.Text = "ChartBySampling1"
        Title1.Name = "Title1"
        Title1.Text = "Voltage and Current Trends"
        Me.ChartBySampling1.Titles.Add(Title1)
        Me.ChartBySampling1.YAxisMax = Double.NaN
        Me.ChartBySampling1.YAxisMin = Double.NaN
        '
        'DataSubscriber1
        '
        Me.DataSubscriber1.ComComponent = Me.ModbusTCPCom1
        Me.DataSubscriber1.PLCAddressValue = CType(resources.GetObject("DataSubscriber1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.DataSubscriber1.Value = Nothing
        '
        'DataSubscriber2
        '
        Me.DataSubscriber2.ComComponent = Me.ModbusTCPCom1
        Me.DataSubscriber2.PLCAddressValue = CType(resources.GetObject("DataSubscriber2.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.DataSubscriber2.Value = Nothing
        '
        'DataSubscriber3
        '
        Me.DataSubscriber3.ComComponent = Me.ModbusTCPCom1
        Me.DataSubscriber3.PLCAddressValue = CType(resources.GetObject("DataSubscriber3.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.DataSubscriber3.Value = Nothing
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1271, 561)
        Me.Controls.Add(Me.ChartBySampling1)
        Me.Controls.Add(Me.DigitalPanelMeter2)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.BasicIndicator1)
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
        CType(Me.ChartBySampling1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriber3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DigitalPanelMeter2 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents ChartBySampling1 As AdvancedHMIControls.ChartBySampling
    Friend WithEvents DataSubscriber1 As AdvancedHMIControls.DataSubscriber
    Friend WithEvents DataSubscriber2 As AdvancedHMIControls.DataSubscriber
    Friend WithEvents DataSubscriber3 As AdvancedHMIControls.DataSubscriber
End Class
