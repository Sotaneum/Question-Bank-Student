<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cb_F = New System.Windows.Forms.CheckBox()
        Me.cb_E = New System.Windows.Forms.CheckBox()
        Me.cb_D = New System.Windows.Forms.CheckBox()
        Me.cb_C = New System.Windows.Forms.CheckBox()
        Me.cb_B = New System.Windows.Forms.CheckBox()
        Me.lb_Question = New System.Windows.Forms.Label()
        Me.cb_A = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lb_Num = New System.Windows.Forms.Label()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.lb_copy = New System.Windows.Forms.Label()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cb_F, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_E, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_D, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_C, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_B, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_Question, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_A, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 30)
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.03303!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.66139!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.66139!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.66139!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.66139!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.66139!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.66002!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(925, 598)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cb_F
        '
        Me.cb_F.AutoSize = True
        Me.cb_F.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_F.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cb_F.Location = New System.Drawing.Point(9, 495)
        Me.cb_F.Name = "cb_F"
        Me.cb_F.Size = New System.Drawing.Size(907, 70)
        Me.cb_F.TabIndex = 7
        Me.cb_F.UseVisualStyleBackColor = True
        '
        'cb_E
        '
        Me.cb_E.AutoSize = True
        Me.cb_E.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_E.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cb_E.Location = New System.Drawing.Point(9, 422)
        Me.cb_E.Name = "cb_E"
        Me.cb_E.Size = New System.Drawing.Size(907, 67)
        Me.cb_E.TabIndex = 6
        Me.cb_E.UseVisualStyleBackColor = True
        '
        'cb_D
        '
        Me.cb_D.AutoSize = True
        Me.cb_D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_D.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cb_D.Location = New System.Drawing.Point(9, 349)
        Me.cb_D.Name = "cb_D"
        Me.cb_D.Size = New System.Drawing.Size(907, 67)
        Me.cb_D.TabIndex = 5
        Me.cb_D.Text = "transport"
        Me.cb_D.UseVisualStyleBackColor = True
        '
        'cb_C
        '
        Me.cb_C.AutoSize = True
        Me.cb_C.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_C.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cb_C.Location = New System.Drawing.Point(9, 276)
        Me.cb_C.Name = "cb_C"
        Me.cb_C.Size = New System.Drawing.Size(907, 67)
        Me.cb_C.TabIndex = 4
        Me.cb_C.Text = "network"
        Me.cb_C.UseVisualStyleBackColor = True
        '
        'cb_B
        '
        Me.cb_B.AutoSize = True
        Me.cb_B.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_B.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cb_B.Location = New System.Drawing.Point(9, 203)
        Me.cb_B.Name = "cb_B"
        Me.cb_B.Size = New System.Drawing.Size(907, 67)
        Me.cb_B.TabIndex = 3
        Me.cb_B.Text = "internet"
        Me.cb_B.UseVisualStyleBackColor = True
        '
        'lb_Question
        '
        Me.lb_Question.AutoSize = True
        Me.lb_Question.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_Question.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lb_Question.Location = New System.Drawing.Point(9, 31)
        Me.lb_Question.Name = "lb_Question"
        Me.lb_Question.Size = New System.Drawing.Size(907, 96)
        Me.lb_Question.TabIndex = 1
        Me.lb_Question.Text = "Where does routing occur within the DoD TCP/IP reference model?"
        '
        'cb_A
        '
        Me.cb_A.AutoSize = True
        Me.cb_A.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_A.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cb_A.Location = New System.Drawing.Point(9, 130)
        Me.cb_A.Name = "cb_A"
        Me.cb_A.Size = New System.Drawing.Size(907, 67)
        Me.cb_A.TabIndex = 2
        Me.cb_A.Text = "1"
        Me.cb_A.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lb_Num)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_help)
        Me.FlowLayoutPanel1.Controls.Add(Me.lb_copy)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(913, 25)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'lb_Num
        '
        Me.lb_Num.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lb_Num.Location = New System.Drawing.Point(0, 0)
        Me.lb_Num.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_Num.Name = "lb_Num"
        Me.lb_Num.Size = New System.Drawing.Size(161, 25)
        Me.lb_Num.TabIndex = 1
        Me.lb_Num.Text = "1"
        '
        'btn_help
        '
        Me.btn_help.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_help.Location = New System.Drawing.Point(164, 3)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(153, 19)
        Me.btn_help.TabIndex = 2
        Me.btn_help.Text = "도움말"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'lb_copy
        '
        Me.lb_copy.Location = New System.Drawing.Point(323, 0)
        Me.lb_copy.Name = "lb_copy"
        Me.lb_copy.Size = New System.Drawing.Size(297, 25)
        Me.lb_copy.TabIndex = 3
        Me.lb_copy.Text = "ⓒ2018 이동건(cyydo96@naver.com)"
        Me.lb_copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 598)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_main"
        Me.Text = "문제은행 ! Beta!"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cb_E As CheckBox
    Friend WithEvents cb_D As CheckBox
    Friend WithEvents cb_C As CheckBox
    Friend WithEvents cb_B As CheckBox
    Friend WithEvents lb_Question As Label
    Friend WithEvents cb_A As CheckBox
    Friend WithEvents btn_Next As Button
    Friend WithEvents cb_F As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lb_Num As Label
    Friend WithEvents btn_help As Button
    Friend WithEvents lb_copy As Label
End Class
