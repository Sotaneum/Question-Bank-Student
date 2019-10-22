<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.tbl_main = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.btn_copyright = New System.Windows.Forms.Button()
        Me.btn_info = New System.Windows.Forms.Button()
        Me.tm_now = New System.Windows.Forms.Timer(Me.components)
        Me.tbl_main.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Next
        '
        Me.btn_Next.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Next.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btn_Next.Location = New System.Drawing.Point(0, 568)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(925, 30)
        Me.btn_Next.TabIndex = 0
        Me.btn_Next.Text = "NEXT >"
        Me.btn_Next.UseVisualStyleBackColor = True
        '
        'tbl_main
        '
        Me.tbl_main.ColumnCount = 1
        Me.tbl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl_main.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tbl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbl_main.Location = New System.Drawing.Point(0, 0)
        Me.tbl_main.Name = "tbl_main"
        Me.tbl_main.RowCount = 2
        Me.tbl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tbl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl_main.Size = New System.Drawing.Size(925, 568)
        Me.tbl_main.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_help, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_copyright, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_info, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(919, 54)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_help
        '
        Me.btn_help.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_help.Location = New System.Drawing.Point(3, 3)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(300, 48)
        Me.btn_help.TabIndex = 0
        Me.btn_help.Text = "도움말"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'btn_copyright
        '
        Me.btn_copyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_copyright.Location = New System.Drawing.Point(309, 3)
        Me.btn_copyright.Name = "btn_copyright"
        Me.btn_copyright.Size = New System.Drawing.Size(300, 48)
        Me.btn_copyright.TabIndex = 1
        Me.btn_copyright.Text = "ⓒ2018 이동건 (cyydo96@naver.com)"
        Me.btn_copyright.UseVisualStyleBackColor = True
        '
        'btn_info
        '
        Me.btn_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_info.Location = New System.Drawing.Point(615, 3)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(301, 48)
        Me.btn_info.TabIndex = 2
        Me.btn_info.Text = "총 200개의 문항 중 3개 진행 중"
        Me.btn_info.UseVisualStyleBackColor = True
        '
        'tm_now
        '
        Me.tm_now.Enabled = True
        Me.tm_now.Interval = 1000
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 598)
        Me.Controls.Add(Me.tbl_main)
        Me.Controls.Add(Me.btn_Next)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_main"
        Me.Text = "문제은행 ! Beta!"
        Me.tbl_main.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Next As Button
    Friend WithEvents tbl_main As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_help As Button
    Friend WithEvents btn_copyright As Button
    Friend WithEvents btn_info As Button
    Friend WithEvents tm_now As Timer
End Class
