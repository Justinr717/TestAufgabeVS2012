<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tVSumme = New System.Windows.Forms.TextBox()
        Me.tAusgabePrämie = New System.Windows.Forms.TextBox()
        Me.tAusgabeSatz = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tVSumme
        '
        Me.tVSumme.Location = New System.Drawing.Point(13, 66)
        Me.tVSumme.Name = "tVSumme"
        Me.tVSumme.Size = New System.Drawing.Size(100, 20)
        Me.tVSumme.TabIndex = 1
        '
        'tAusgabePrämie
        '
        Me.tAusgabePrämie.Location = New System.Drawing.Point(12, 118)
        Me.tAusgabePrämie.Name = "tAusgabePrämie"
        Me.tAusgabePrämie.ReadOnly = True
        Me.tAusgabePrämie.Size = New System.Drawing.Size(100, 20)
        Me.tAusgabePrämie.TabIndex = 2
        '
        'tAusgabeSatz
        '
        Me.tAusgabeSatz.Location = New System.Drawing.Point(12, 92)
        Me.tAusgabeSatz.Name = "tAusgabeSatz"
        Me.tAusgabeSatz.ReadOnly = True
        Me.tAusgabeSatz.Size = New System.Drawing.Size(100, 20)
        Me.tAusgabeSatz.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 311)
        Me.Controls.Add(Me.tAusgabeSatz)
        Me.Controls.Add(Me.tAusgabePrämie)
        Me.Controls.Add(Me.tVSumme)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tVSumme As System.Windows.Forms.TextBox
    Friend WithEvents tAusgabePrämie As System.Windows.Forms.TextBox
    Friend WithEvents tAusgabeSatz As System.Windows.Forms.TextBox

End Class
