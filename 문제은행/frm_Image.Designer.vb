<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Image
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Image))
        Me.pb_image = New System.Windows.Forms.PictureBox()
        CType(Me.pb_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_image
        '
        Me.pb_image.BackColor = System.Drawing.Color.White
        Me.pb_image.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_image.Location = New System.Drawing.Point(0, 0)
        Me.pb_image.Name = "pb_image"
        Me.pb_image.Size = New System.Drawing.Size(596, 357)
        Me.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_image.TabIndex = 0
        Me.pb_image.TabStop = False
        '
        'frm_Image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 357)
        Me.Controls.Add(Me.pb_image)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Image"
        Me.Text = "Refer to the exhibit"
        CType(Me.pb_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb_image As PictureBox
End Class
