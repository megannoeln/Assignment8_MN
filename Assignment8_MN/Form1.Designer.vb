<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfall
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstRainfallData = New System.Windows.Forms.ListBox()
        Me.lstStatistics = New System.Windows.Forms.ListBox()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstRainfallData
        '
        Me.lstRainfallData.FormattingEnabled = True
        Me.lstRainfallData.Location = New System.Drawing.Point(17, 16)
        Me.lstRainfallData.Name = "lstRainfallData"
        Me.lstRainfallData.Size = New System.Drawing.Size(233, 199)
        Me.lstRainfallData.TabIndex = 0
        '
        'lstStatistics
        '
        Me.lstStatistics.FormattingEnabled = True
        Me.lstStatistics.Location = New System.Drawing.Point(281, 16)
        Me.lstStatistics.Name = "lstStatistics"
        Me.lstStatistics.Size = New System.Drawing.Size(313, 199)
        Me.lstStatistics.TabIndex = 1
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(124, 243)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(92, 35)
        Me.btnGetData.TabIndex = 2
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Enabled = False
        Me.btnDisplay.Location = New System.Drawing.Point(265, 243)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(92, 35)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(401, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 35)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 308)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.lstStatistics)
        Me.Controls.Add(Me.lstRainfallData)
        Me.Name = "frmRainfall"
        Me.Text = "Rainfall"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstRainfallData As ListBox
    Friend WithEvents lstStatistics As ListBox
    Friend WithEvents btnGetData As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
End Class
