Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports TaxGrad.My.Resources

Namespace TaxGrad
    <DesignerGenerated> _
    Public Class Dialog1
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Activated, New EventHandler(AddressOf Me.Dialog1_Activated)
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Dialog1_Load)
            Dialog1.__ENCAddToList(Me)
            Me.InitializeComponent
        End Sub

        <DebuggerNonUserCode> _
        Private Shared Sub __ENCAddToList(ByVal value As Object)
            Dim list As List(Of WeakReference) = Dialog1.__ENCList
            SyncLock list
                If (Dialog1.__ENCList.Count = Dialog1.__ENCList.Capacity) Then
                    Dim index As Integer = 0
                    Dim num3 As Integer = (Dialog1.__ENCList.Count - 1)
                    Dim num2 As Integer = 0
                    Do While True
                        Dim num4 As Integer = num3
                        If (num2 > num4) Then
                            Dialog1.__ENCList.RemoveRange(index, (Dialog1.__ENCList.Count - index))
                            Dialog1.__ENCList.Capacity = Dialog1.__ENCList.Count
                            Exit Do
                        End If
                        Dim reference As WeakReference = Dialog1.__ENCList.Item(num2)
                        If reference.IsAlive Then
                            If (num2 <> index) Then
                                Dialog1.__ENCList.Item(index) = Dialog1.__ENCList.Item(num2)
                            End If
                            index += 1
                        End If
                        num2 += 1
                    Loop
                End If
                Dialog1.__ENCList.Add(New WeakReference(value))
            End SyncLock
        End Sub

        Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub Button7_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub Dialog1_Activated(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub Dialog1_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try 
                Dim num1 As Integer
                If (Not disposing OrElse (Me.components Is Nothing)) Then
                    num1 = 0
                Else
                    num1 = 1
                End If
                If (num1 <> 0) Then
                    Me.components.Dispose
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(Dialog1))
            Me.MenuStrip1 = New MenuStrip
            Me.tsm1 = New ToolStripMenuItem
            Me.الخزينةToolStripMenuItem = New ToolStripMenuItem
            Me.tsm3 = New ToolStripMenuItem
            Me.المدنToolStripMenuItem = New ToolStripMenuItem
            Me.الأصنافToolStripMenuItem1 = New ToolStripMenuItem
            Me.المكاتبToolStripMenuItem = New ToolStripMenuItem
            Me.الأصنافToolStripMenuItem = New ToolStripMenuItem
            Me.الأنشطهToolStripMenuItem = New ToolStripMenuItem
            Me.tsm4 = New ToolStripMenuItem
            Me.طباعهالشهائدToolStripMenuItem = New ToolStripMenuItem
            Me.tsm5 = New ToolStripMenuItem
            Me.tsm6 = New ToolStripMenuItem
            Me.اعداتالطابعهToolStripMenuItem = New ToolStripMenuItem
            Me.tsm7 = New ToolStripMenuItem
            Me.tsm8 = New ToolStripMenuItem
            Me.Panel1 = New Panel
            Me.Label2 = New Label
            Me.Label1 = New Label
            Me.Timer1 = New Timer(Me.components)
            Me.MenuStrip1.SuspendLayout
            Me.Panel1.SuspendLayout
            Me.SuspendLayout
            Dim toolStripItems As ToolStripItem() = New ToolStripItem() { Me.tsm1, Me.tsm3, Me.tsm4, Me.tsm5, Me.tsm6, Me.tsm7, Me.tsm8 }
            Me.MenuStrip1.Items.AddRange(toolStripItems)
            Dim point2 As New Point(0, 0)
            Me.MenuStrip1.Location = point2
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.RightToLeft = RightToLeft.Yes
            Dim size2 As New Size(&H3F9, &H47)
            Me.MenuStrip1.Size = size2
            Me.MenuStrip1.TabIndex = &H10
            Me.MenuStrip1.Text = "MenuStrip1"
            toolStripItems = New ToolStripItem() { Me.الخزينةToolStripMenuItem }
            Me.tsm1.DropDownItems.AddRange(toolStripItems)
            Me.tsm1.Image = DirectCast(manager.GetObject("tsm1.Image"), Image)
            Me.tsm1.ImageScaling = ToolStripItemImageScaling.None
            Me.tsm1.Name = "tsm1"
            size2 = New Size(&H62, &H43)
            Me.tsm1.Size = size2
            Me.tsm1.Text = "البيانات الأساسية"
            Me.tsm1.TextImageRelation = TextImageRelation.ImageAboveText
            Me.الخزينةToolStripMenuItem.Name = "الخزينةToolStripMenuItem"
            size2 = New Size(&H9A, &H16)
            Me.الخزينةToolStripMenuItem.Size = size2
            Me.الخزينةToolStripMenuItem.Text = "نمـــودج الجــــــرد"
            toolStripItems = New ToolStripItem() { Me.المدنToolStripMenuItem, Me.الأصنافToolStripMenuItem1, Me.المكاتبToolStripMenuItem, Me.الأصنافToolStripMenuItem, Me.الأنشطهToolStripMenuItem }
            Me.tsm3.DropDownItems.AddRange(toolStripItems)
            Me.tsm3.Image = DirectCast(manager.GetObject("tsm3.Image"), Image)
            Me.tsm3.ImageScaling = ToolStripItemImageScaling.None
            Me.tsm3.Name = "tsm3"
            size2 = New Size(&H61, &H43)
            Me.tsm3.Size = size2
            Me.tsm3.Text = "البيانات المساعدة"
            Me.tsm3.TextImageRelation = TextImageRelation.ImageAboveText
            Me.المدنToolStripMenuItem.Name = "المدنToolStripMenuItem"
            size2 = New Size(&H94, &H16)
            Me.المدنToolStripMenuItem.Size = size2
            Me.المدنToolStripMenuItem.Text = "بيانات الموضف"
            Me.الأصنافToolStripMenuItem1.Name = "الأصنافToolStripMenuItem1"
            size2 = New Size(&H94, &H16)
            Me.الأصنافToolStripMenuItem1.Size = size2
            Me.الأصنافToolStripMenuItem1.Text = "بيانات الإدارات"
            Me.المكاتبToolStripMenuItem.Name = "المكاتبToolStripMenuItem"
            size2 = New Size(&H94, &H16)
            Me.المكاتبToolStripMenuItem.Size = size2
            Me.المكاتبToolStripMenuItem.Text = "بيانات الأقسام"
            Me.الأصنافToolStripMenuItem.Name = "الأصنافToolStripMenuItem"
            size2 = New Size(&H94, &H16)
            Me.الأصنافToolStripMenuItem.Size = size2
            Me.الأصنافToolStripMenuItem.Text = "الأصول الرئيسية"
            Me.الأنشطهToolStripMenuItem.Name = "الأنشطهToolStripMenuItem"
            size2 = New Size(&H94, &H16)
            Me.الأنشطهToolStripMenuItem.Size = size2
            Me.الأنشطهToolStripMenuItem.Text = "الأصول الفرعية"
            toolStripItems = New ToolStripItem() { Me.طباعهالشهائدToolStripMenuItem }
            Me.tsm4.DropDownItems.AddRange(toolStripItems)
            Me.tsm4.Image = DirectCast(manager.GetObject("tsm4.Image"), Image)
            Me.tsm4.ImageScaling = ToolStripItemImageScaling.None
            Me.tsm4.Name = "tsm4"
            size2 = New Size(60, &H43)
            Me.tsm4.Size = size2
            Me.tsm4.Text = "التقارير"
            Me.tsm4.TextImageRelation = TextImageRelation.ImageAboveText
            Me.طباعهالشهائدToolStripMenuItem.Name = "طباعهالشهائدToolStripMenuItem"
            size2 = New Size(&H66, &H16)
            Me.طباعهالشهائدToolStripMenuItem.Size = size2
            Me.طباعهالشهائدToolStripMenuItem.Text = "طباعة"
            Me.tsm5.Image = DirectCast(manager.GetObject("tsm5.Image"), Image)
            Me.tsm5.ImageScaling = ToolStripItemImageScaling.None
            Me.tsm5.Name = "tsm5"
            size2 = New Size(&H4F, &H43)
            Me.tsm5.Size = size2
            Me.tsm5.Text = "حول المنظومة"
            Me.tsm5.TextImageRelation = TextImageRelation.ImageAboveText
            toolStripItems = New ToolStripItem() { Me.اعداتالطابعهToolStripMenuItem }
            Me.tsm6.DropDownItems.AddRange(toolStripItems)
            Me.tsm6.Image = DirectCast(manager.GetObject("tsm6.Image"), Image)
            Me.tsm6.ImageScaling = ToolStripItemImageScaling.None
            Me.tsm6.Name = "tsm6"
            size2 = New Size(60, &H43)
            Me.tsm6.Size = size2
            Me.tsm6.Text = "الإعدادات"
            Me.tsm6.TextImageRelation = TextImageRelation.ImageAboveText
            Me.اعداتالطابعهToolStripMenuItem.Name = "اعداتالطابعهToolStripMenuItem"
            size2 = New Size(&H87, &H16)
            Me.اعداتالطابعهToolStripMenuItem.Size = size2
            Me.اعداتالطابعهToolStripMenuItem.Text = "اعدات الطابعه"
            Me.tsm7.Image = DirectCast(manager.GetObject("tsm7.Image"), Image)
            Me.tsm7.ImageScaling = ToolStripItemImageScaling.None
            Me.tsm7.Name = "tsm7"
            size2 = New Size(&H4C, &H43)
            Me.tsm7.Size = size2
            Me.tsm7.Text = "إعادة الدخول"
            Me.tsm7.TextImageRelation = TextImageRelation.ImageAboveText
            Me.tsm8.Image = DirectCast(manager.GetObject("tsm8.Image"), Image)
            Me.tsm8.ImageScaling = ToolStripItemImageScaling.None
            Me.tsm8.Name = "tsm8"
            size2 = New Size(60, &H43)
            Me.tsm8.Size = size2
            Me.tsm8.Text = "خروج"
            Me.tsm8.TextImageRelation = TextImageRelation.ImageAboveText
            Me.Panel1.BackColor = Color.Transparent
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = DockStyle.Bottom
            point2 = New Point(0, &H28C)
            Me.Panel1.Location = point2
            Me.Panel1.Name = "Panel1"
            size2 = New Size(&H3F9, &H3A)
            Me.Panel1.Size = size2
            Me.Panel1.TabIndex = &H11
            Me.Label2.Dock = DockStyle.Right
            Me.Label2.Font = New Font("Simplified Arabic", 14!, FontStyle.Bold)
            Me.Label2.ForeColor = Color.White
            point2 = New Point(&H279, 0)
            Me.Label2.Location = point2
            Me.Label2.Name = "Label2"
            size2 = New Size(&H180, &H3A)
            Me.Label2.Size = size2
            Me.Label2.TabIndex = 1
            Me.Label2.TextAlign = ContentAlignment.MiddleLeft
            Me.Label1.Dock = DockStyle.Left
            Me.Label1.Font = New Font("Simplified Arabic", 14!, FontStyle.Bold)
            point2 = New Point(0, 0)
            Me.Label1.Location = point2
            Me.Label1.Name = "Label1"
            size2 = New Size(&HCF, &H3A)
            Me.Label1.Size = size2
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Label1"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = &H3E8
            Dim ef2 As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef2
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackgroundImage = Resources.company1
            Me.BackgroundImageLayout = ImageLayout.Stretch
            size2 = New Size(&H3F9, 710)
            Me.ClientSize = size2
            Me.ControlBox = False
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Dialog1"
            Me.RightToLeft = RightToLeft.Yes
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "الشاشة الرئيسية"
            Me.WindowState = FormWindowState.Maximized
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        <DllImport("user32.dll", EntryPoint:="LoadKeyboardLayoutA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
        Private Shared Function LoadKeyboardLayout(<MarshalAs(UnmanagedType.VBByRefStr)> ByRef pwszKLID As String, ByVal flags As Integer) As Integer
        End Function

        Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            Interaction.MsgBox(Strings.Asc(e.KeyChar), DirectCast(MsgBoxStyle.ApplicationModal, MsgBoxStyle), Nothing)
        End Sub

        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Me.Label1.Text = Strings.Format(DateAndTime.get_Now, "hh:mm:ss tt")
        End Sub

        Private Sub tsm5_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub tsm6_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub tsm7_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Interaction.MsgBox("هل تريد إعادة الدخول؟", (DirectCast(MsgBoxStyle.Question, MsgBoxStyle) Or DirectCast(MsgBoxStyle.YesNo, MsgBoxStyle)), "") = DirectCast(CInt(MsgBoxResult.Yes), MsgBoxResult)) Then
            End If
        End Sub

        <MethodImpl((MethodImplOptions.NoOptimization Or MethodImplOptions.NoInlining))> _
        Private Sub tsm8_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Interaction.MsgBox("هل تريد الخروج من البرنامج؟", (DirectCast(MsgBoxStyle.Question, MsgBoxStyle) Or DirectCast(MsgBoxStyle.YesNo, MsgBoxStyle)), "") = DirectCast(CInt(MsgBoxResult.Yes), MsgBoxResult)) Then
                ProjectData.EndApp
            End If
        End Sub

        Private Sub اعداتالطابعهToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub اعدادتالمستخدمينToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub الأصنافToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.frm = New FrmOssol
            Me.frm.ShowDialog
        End Sub

        Private Sub الأصنافToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.frm = New FrmEdara
            Me.frm.ShowDialog
        End Sub

        Private Sub الأنشطهToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.frm = New FrmOssolType
            Me.frm.ShowDialog
        End Sub

        Private Sub الأنشطهToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub البياناتالأساسيةToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub الخزينةToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.frm = New FrmNmodg
            Me.frm.ShowDialog
        End Sub

        Private Sub الشكلالقانونيToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub الشهائدToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub الشوارعToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub الضريبةالنوعيةToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub الفروعToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub المدنToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.frm = New FrmEmp
            Me.frm.ShowDialog
        End Sub

        Private Sub المكاتبToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.frm = New FrmKsm
            Me.frm.ShowDialog
        End Sub

        Private Sub المكاتبToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub تستToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub شهائدممولToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub طباعهالشهائدToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub كميةالشهائدToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub


        ' Properties
        Friend Overridable Property MenuStrip1 As MenuStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._MenuStrip1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As MenuStrip)
                Me._MenuStrip1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tsm1 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._tsm1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._tsm1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tsm3 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._tsm3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._tsm3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tsm4 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._tsm4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._tsm4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tsm5 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._tsm5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.tsm5_Click)
                If (Not Me._tsm5 Is Nothing) Then
                    RemoveHandler Me._tsm5.Click, handler
                End If
                Me._tsm5 = WithEventsValue
                If (Not Me._tsm5 Is Nothing) Then
                    AddHandler Me._tsm5.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property tsm7 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._tsm7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.tsm7_Click)
                If (Not Me._tsm7 Is Nothing) Then
                    RemoveHandler Me._tsm7.Click, handler
                End If
                Me._tsm7 = WithEventsValue
                If (Not Me._tsm7 Is Nothing) Then
                    AddHandler Me._tsm7.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property tsm8 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._tsm8
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.tsm8_Click)
                If (Not Me._tsm8 Is Nothing) Then
                    RemoveHandler Me._tsm8.Click, handler
                End If
                Me._tsm8 = WithEventsValue
                If (Not Me._tsm8 Is Nothing) Then
                    AddHandler Me._tsm8.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property tsm6 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._tsm6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.tsm6_Click)
                If (Not Me._tsm6 Is Nothing) Then
                    RemoveHandler Me._tsm6.Click, handler
                End If
                Me._tsm6 = WithEventsValue
                If (Not Me._tsm6 Is Nothing) Then
                    AddHandler Me._tsm6.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property الأصنافToolStripMenuItem1 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._الأصنافToolStripMenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.الأصنافToolStripMenuItem1_Click)
                If (Not Me._الأصنافToolStripMenuItem1 Is Nothing) Then
                    RemoveHandler Me._الأصنافToolStripMenuItem1.Click, handler
                End If
                Me._الأصنافToolStripMenuItem1 = WithEventsValue
                If (Not Me._الأصنافToolStripMenuItem1 Is Nothing) Then
                    AddHandler Me._الأصنافToolStripMenuItem1.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property المكاتبToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._المكاتبToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.المكاتبToolStripMenuItem_Click)
                If (Not Me._المكاتبToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._المكاتبToolStripMenuItem.Click, handler
                End If
                Me._المكاتبToolStripMenuItem = WithEventsValue
                If (Not Me._المكاتبToolStripMenuItem Is Nothing) Then
                    AddHandler Me._المكاتبToolStripMenuItem.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property المدنToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._المدنToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.المدنToolStripMenuItem_Click)
                If (Not Me._المدنToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._المدنToolStripMenuItem.Click, handler
                End If
                Me._المدنToolStripMenuItem = WithEventsValue
                If (Not Me._المدنToolStripMenuItem Is Nothing) Then
                    AddHandler Me._المدنToolStripMenuItem.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property الأنشطهToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._الأنشطهToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.الأنشطهToolStripMenuItem_Click)
                If (Not Me._الأنشطهToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._الأنشطهToolStripMenuItem.Click, handler
                End If
                Me._الأنشطهToolStripMenuItem = WithEventsValue
                If (Not Me._الأنشطهToolStripMenuItem Is Nothing) Then
                    AddHandler Me._الأنشطهToolStripMenuItem.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property الأصنافToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._الأصنافToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.الأصنافToolStripMenuItem_Click)
                If (Not Me._الأصنافToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._الأصنافToolStripMenuItem.Click, handler
                End If
                Me._الأصنافToolStripMenuItem = WithEventsValue
                If (Not Me._الأصنافToolStripMenuItem Is Nothing) Then
                    AddHandler Me._الأصنافToolStripMenuItem.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property طباعهالشهائدToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._طباعهالشهائدToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.طباعهالشهائدToolStripMenuItem_Click)
                If (Not Me._طباعهالشهائدToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._طباعهالشهائدToolStripMenuItem.Click, handler
                End If
                Me._طباعهالشهائدToolStripMenuItem = WithEventsValue
                If (Not Me._طباعهالشهائدToolStripMenuItem Is Nothing) Then
                    AddHandler Me._طباعهالشهائدToolStripMenuItem.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property اعداتالطابعهToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._اعداتالطابعهToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.اعداتالطابعهToolStripMenuItem_Click)
                If (Not Me._اعداتالطابعهToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._اعداتالطابعهToolStripMenuItem.Click, handler
                End If
                Me._اعداتالطابعهToolStripMenuItem = WithEventsValue
                If (Not Me._اعداتالطابعهToolStripMenuItem Is Nothing) Then
                    AddHandler Me._اعداتالطابعهToolStripMenuItem.Click, handler
                End If
            End Set
        End Property

        Friend Overridable Property Panel1 As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._Panel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._Panel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Timer1 As Timer
            <DebuggerNonUserCode> _
            Get
                Return Me._Timer1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Timer)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.Timer1_Tick)
                If (Not Me._Timer1 Is Nothing) Then
                    RemoveHandler Me._Timer1.Tick, handler
                End If
                Me._Timer1 = WithEventsValue
                If (Not Me._Timer1 Is Nothing) Then
                    AddHandler Me._Timer1.Tick, handler
                End If
            End Set
        End Property

        Friend Overridable Property Label2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property الخزينةToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._الخزينةToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Dim handler As EventHandler = New EventHandler(AddressOf Me.الخزينةToolStripMenuItem_Click)
                If (Not Me._الخزينةToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._الخزينةToolStripMenuItem.Click, handler
                End If
                Me._الخزينةToolStripMenuItem = WithEventsValue
                If (Not Me._الخزينةToolStripMenuItem Is Nothing) Then
                    AddHandler Me._الخزينةToolStripMenuItem.Click, handler
                End If
            End Set
        End Property


        ' Fields
        Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)
        Private components As IContainer
        <AccessedThroughProperty("MenuStrip1")> _
        Private _MenuStrip1 As MenuStrip
        <AccessedThroughProperty("tsm1")> _
        Private _tsm1 As ToolStripMenuItem
        <AccessedThroughProperty("tsm3")> _
        Private _tsm3 As ToolStripMenuItem
        <AccessedThroughProperty("tsm4")> _
        Private _tsm4 As ToolStripMenuItem
        <AccessedThroughProperty("tsm5")> _
        Private _tsm5 As ToolStripMenuItem
        <AccessedThroughProperty("tsm7")> _
        Private _tsm7 As ToolStripMenuItem
        <AccessedThroughProperty("tsm8")> _
        Private _tsm8 As ToolStripMenuItem
        <AccessedThroughProperty("tsm6")> _
        Private _tsm6 As ToolStripMenuItem
        <AccessedThroughProperty("الأصنافToolStripMenuItem1")> _
        Private _الأصنافToolStripMenuItem1 As ToolStripMenuItem
        <AccessedThroughProperty("المكاتبToolStripMenuItem")> _
        Private _المكاتبToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("المدنToolStripMenuItem")> _
        Private _المدنToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("الأنشطهToolStripMenuItem")> _
        Private _الأنشطهToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("الأصنافToolStripMenuItem")> _
        Private _الأصنافToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("طباعهالشهائدToolStripMenuItem")> _
        Private _طباعهالشهائدToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("اعداتالطابعهToolStripMenuItem")> _
        Private _اعداتالطابعهToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("Panel1")> _
        Private _Panel1 As Panel
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("الخزينةToolStripMenuItem")> _
        Private _الخزينةToolStripMenuItem As ToolStripMenuItem
        Private Const KLF_ACTIVATE As Long = 1
        Private Const KLF_NOTELLSHELL As Long = &H80
        Private Const KLF_REORDER As Long = 8
        Private Const KLF_REPLACELANG As Long = &H10
        Private Const KLF_RESET As Long = &H40000000
        Private Const KLF_SETFORPROCESS As Long = &H100
        Private Const KLF_SHIFTLOCK As Long = &H10000
        Private Const KLF_SUBSTITUTE_OK As Long = 2
        Private Const KLF_UNLOADPREVIOUS As Long = 4
        Private frm As Form
    End Class
End Namespace

