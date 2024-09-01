<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        WV1 = New Microsoft.Web.WebView2.WinForms.WebView2()
        timRefresh = New Timer(components)
        CType(WV1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WV1
        ' 
        WV1.AllowExternalDrop = True
        WV1.CreationProperties = Nothing
        WV1.DefaultBackgroundColor = Color.White
        WV1.Location = New Point(66, 48)
        WV1.Name = "WV1"
        WV1.Size = New Size(597, 336)
        WV1.Source = New Uri("https://www.google.de", UriKind.Absolute)
        WV1.TabIndex = 0
        WV1.ZoomFactor = 1R
        ' 
        ' timRefresh
        ' 
        timRefresh.Enabled = True
        timRefresh.Interval = 60000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(WV1)
        Name = "Form1"
        Text = "ITSM Browser"
        CType(WV1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents WV1 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents timRefresh As Timer

End Class
