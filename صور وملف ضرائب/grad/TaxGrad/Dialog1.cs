namespace TaxGrad
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using TaxGrad.My.Resources;

    [DesignerGenerated]
    public class Dialog1 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("tsm1")]
        private ToolStripMenuItem _tsm1;
        [AccessedThroughProperty("tsm3")]
        private ToolStripMenuItem _tsm3;
        [AccessedThroughProperty("tsm4")]
        private ToolStripMenuItem _tsm4;
        [AccessedThroughProperty("tsm5")]
        private ToolStripMenuItem _tsm5;
        [AccessedThroughProperty("tsm7")]
        private ToolStripMenuItem _tsm7;
        [AccessedThroughProperty("tsm8")]
        private ToolStripMenuItem _tsm8;
        [AccessedThroughProperty("tsm6")]
        private ToolStripMenuItem _tsm6;
        [AccessedThroughProperty("الأصنافToolStripMenuItem1")]
        private ToolStripMenuItem _الأصنافToolStripMenuItem1;
        [AccessedThroughProperty("المكاتبToolStripMenuItem")]
        private ToolStripMenuItem _المكاتبToolStripMenuItem;
        [AccessedThroughProperty("المدنToolStripMenuItem")]
        private ToolStripMenuItem _المدنToolStripMenuItem;
        [AccessedThroughProperty("الأنشطهToolStripMenuItem")]
        private ToolStripMenuItem _الأنشطهToolStripMenuItem;
        [AccessedThroughProperty("الأصنافToolStripMenuItem")]
        private ToolStripMenuItem _الأصنافToolStripMenuItem;
        [AccessedThroughProperty("طباعهالشهائدToolStripMenuItem")]
        private ToolStripMenuItem _طباعهالشهائدToolStripMenuItem;
        [AccessedThroughProperty("اعداتالطابعهToolStripMenuItem")]
        private ToolStripMenuItem _اعداتالطابعهToolStripMenuItem;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("الخزينةToolStripMenuItem")]
        private ToolStripMenuItem _الخزينةToolStripMenuItem;
        private const long KLF_ACTIVATE = 1L;
        private const long KLF_NOTELLSHELL = 0x80L;
        private const long KLF_REORDER = 8L;
        private const long KLF_REPLACELANG = 0x10L;
        private const long KLF_RESET = 0x40000000L;
        private const long KLF_SETFORPROCESS = 0x100L;
        private const long KLF_SHIFTLOCK = 0x10000L;
        private const long KLF_SUBSTITUTE_OK = 2L;
        private const long KLF_UNLOADPREVIOUS = 4L;
        private Form frm;

        [DebuggerNonUserCode]
        public Dialog1()
        {
            base.Activated += new EventHandler(this.Dialog1_Activated);
            base.Load += new EventHandler(this.Dialog1_Load);
            __ENCAddToList(this);
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                if (__ENCList.Count == __ENCList.Capacity)
                {
                    int index = 0;
                    int num3 = __ENCList.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        int num4 = num3;
                        if (num2 > num4)
                        {
                            __ENCList.RemoveRange(index, __ENCList.Count - index);
                            __ENCList.Capacity = __ENCList.Count;
                            break;
                        }
                        WeakReference reference = __ENCList[num2];
                        if (reference.IsAlive)
                        {
                            if (num2 != index)
                            {
                                __ENCList[index] = __ENCList[num2];
                            }
                            index++;
                        }
                        num2++;
                    }
                }
                __ENCList.Add(new WeakReference(value));
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
        }

        private void Button8_Click(object sender, EventArgs e)
        {
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
        }

        private void Dialog1_Activated(object sender, EventArgs e)
        {
        }

        private void Dialog1_Load(object sender, EventArgs e)
        {
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                int num1;
                if (!disposing || (this.components == null))
                {
                    num1 = 0;
                }
                else
                {
                    num1 = 1;
                }
                if (num1 != 0)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Dialog1));
            this.MenuStrip1 = new MenuStrip();
            this.tsm1 = new ToolStripMenuItem();
            this.الخزينةToolStripMenuItem = new ToolStripMenuItem();
            this.tsm3 = new ToolStripMenuItem();
            this.المدنToolStripMenuItem = new ToolStripMenuItem();
            this.الأصنافToolStripMenuItem1 = new ToolStripMenuItem();
            this.المكاتبToolStripMenuItem = new ToolStripMenuItem();
            this.الأصنافToolStripMenuItem = new ToolStripMenuItem();
            this.الأنشطهToolStripMenuItem = new ToolStripMenuItem();
            this.tsm4 = new ToolStripMenuItem();
            this.طباعهالشهائدToolStripMenuItem = new ToolStripMenuItem();
            this.tsm5 = new ToolStripMenuItem();
            this.tsm6 = new ToolStripMenuItem();
            this.اعداتالطابعهToolStripMenuItem = new ToolStripMenuItem();
            this.tsm7 = new ToolStripMenuItem();
            this.tsm8 = new ToolStripMenuItem();
            this.Panel1 = new Panel();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.Timer1 = new Timer(this.components);
            this.MenuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.tsm1, this.tsm3, this.tsm4, this.tsm5, this.tsm6, this.tsm7, this.tsm8 };
            this.MenuStrip1.Items.AddRange(toolStripItems);
            Point point2 = new Point(0, 0);
            this.MenuStrip1.Location = point2;
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.RightToLeft = RightToLeft.Yes;
            Size size2 = new Size(0x3f9, 0x47);
            this.MenuStrip1.Size = size2;
            this.MenuStrip1.TabIndex = 0x10;
            this.MenuStrip1.Text = "MenuStrip1";
            toolStripItems = new ToolStripItem[] { this.الخزينةToolStripMenuItem };
            this.tsm1.DropDownItems.AddRange(toolStripItems);
            this.tsm1.Image = (Image) manager.GetObject("tsm1.Image");
            this.tsm1.ImageScaling = ToolStripItemImageScaling.None;
            this.tsm1.Name = "tsm1";
            size2 = new Size(0x62, 0x43);
            this.tsm1.Size = size2;
            this.tsm1.Text = "البيانات الأساسية";
            this.tsm1.TextImageRelation = TextImageRelation.ImageAboveText;
            this.الخزينةToolStripMenuItem.Name = "الخزينةToolStripMenuItem";
            size2 = new Size(0x9a, 0x16);
            this.الخزينةToolStripMenuItem.Size = size2;
            this.الخزينةToolStripMenuItem.Text = "نمـــودج الجــــــرد";
            toolStripItems = new ToolStripItem[] { this.المدنToolStripMenuItem, this.الأصنافToolStripMenuItem1, this.المكاتبToolStripMenuItem, this.الأصنافToolStripMenuItem, this.الأنشطهToolStripMenuItem };
            this.tsm3.DropDownItems.AddRange(toolStripItems);
            this.tsm3.Image = (Image) manager.GetObject("tsm3.Image");
            this.tsm3.ImageScaling = ToolStripItemImageScaling.None;
            this.tsm3.Name = "tsm3";
            size2 = new Size(0x61, 0x43);
            this.tsm3.Size = size2;
            this.tsm3.Text = "البيانات المساعدة";
            this.tsm3.TextImageRelation = TextImageRelation.ImageAboveText;
            this.المدنToolStripMenuItem.Name = "المدنToolStripMenuItem";
            size2 = new Size(0x94, 0x16);
            this.المدنToolStripMenuItem.Size = size2;
            this.المدنToolStripMenuItem.Text = "بيانات الموضف";
            this.الأصنافToolStripMenuItem1.Name = "الأصنافToolStripMenuItem1";
            size2 = new Size(0x94, 0x16);
            this.الأصنافToolStripMenuItem1.Size = size2;
            this.الأصنافToolStripMenuItem1.Text = "بيانات الإدارات";
            this.المكاتبToolStripMenuItem.Name = "المكاتبToolStripMenuItem";
            size2 = new Size(0x94, 0x16);
            this.المكاتبToolStripMenuItem.Size = size2;
            this.المكاتبToolStripMenuItem.Text = "بيانات الأقسام";
            this.الأصنافToolStripMenuItem.Name = "الأصنافToolStripMenuItem";
            size2 = new Size(0x94, 0x16);
            this.الأصنافToolStripMenuItem.Size = size2;
            this.الأصنافToolStripMenuItem.Text = "الأصول الرئيسية";
            this.الأنشطهToolStripMenuItem.Name = "الأنشطهToolStripMenuItem";
            size2 = new Size(0x94, 0x16);
            this.الأنشطهToolStripMenuItem.Size = size2;
            this.الأنشطهToolStripMenuItem.Text = "الأصول الفرعية";
            toolStripItems = new ToolStripItem[] { this.طباعهالشهائدToolStripMenuItem };
            this.tsm4.DropDownItems.AddRange(toolStripItems);
            this.tsm4.Image = (Image) manager.GetObject("tsm4.Image");
            this.tsm4.ImageScaling = ToolStripItemImageScaling.None;
            this.tsm4.Name = "tsm4";
            size2 = new Size(60, 0x43);
            this.tsm4.Size = size2;
            this.tsm4.Text = "التقارير";
            this.tsm4.TextImageRelation = TextImageRelation.ImageAboveText;
            this.طباعهالشهائدToolStripMenuItem.Name = "طباعهالشهائدToolStripMenuItem";
            size2 = new Size(0x66, 0x16);
            this.طباعهالشهائدToolStripMenuItem.Size = size2;
            this.طباعهالشهائدToolStripMenuItem.Text = "طباعة";
            this.tsm5.Image = (Image) manager.GetObject("tsm5.Image");
            this.tsm5.ImageScaling = ToolStripItemImageScaling.None;
            this.tsm5.Name = "tsm5";
            size2 = new Size(0x4f, 0x43);
            this.tsm5.Size = size2;
            this.tsm5.Text = "حول المنظومة";
            this.tsm5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripItems = new ToolStripItem[] { this.اعداتالطابعهToolStripMenuItem };
            this.tsm6.DropDownItems.AddRange(toolStripItems);
            this.tsm6.Image = (Image) manager.GetObject("tsm6.Image");
            this.tsm6.ImageScaling = ToolStripItemImageScaling.None;
            this.tsm6.Name = "tsm6";
            size2 = new Size(60, 0x43);
            this.tsm6.Size = size2;
            this.tsm6.Text = "الإعدادات";
            this.tsm6.TextImageRelation = TextImageRelation.ImageAboveText;
            this.اعداتالطابعهToolStripMenuItem.Name = "اعداتالطابعهToolStripMenuItem";
            size2 = new Size(0x87, 0x16);
            this.اعداتالطابعهToolStripMenuItem.Size = size2;
            this.اعداتالطابعهToolStripMenuItem.Text = "اعدات الطابعه";
            this.tsm7.Image = (Image) manager.GetObject("tsm7.Image");
            this.tsm7.ImageScaling = ToolStripItemImageScaling.None;
            this.tsm7.Name = "tsm7";
            size2 = new Size(0x4c, 0x43);
            this.tsm7.Size = size2;
            this.tsm7.Text = "إعادة الدخول";
            this.tsm7.TextImageRelation = TextImageRelation.ImageAboveText;
            this.tsm8.Image = (Image) manager.GetObject("tsm8.Image");
            this.tsm8.ImageScaling = ToolStripItemImageScaling.None;
            this.tsm8.Name = "tsm8";
            size2 = new Size(60, 0x43);
            this.tsm8.Size = size2;
            this.tsm8.Text = "خروج";
            this.tsm8.TextImageRelation = TextImageRelation.ImageAboveText;
            this.Panel1.BackColor = Color.Transparent;
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = DockStyle.Bottom;
            point2 = new Point(0, 0x28c);
            this.Panel1.Location = point2;
            this.Panel1.Name = "Panel1";
            size2 = new Size(0x3f9, 0x3a);
            this.Panel1.Size = size2;
            this.Panel1.TabIndex = 0x11;
            this.Label2.Dock = DockStyle.Right;
            this.Label2.Font = new Font("Simplified Arabic", 14f, FontStyle.Bold);
            this.Label2.ForeColor = Color.White;
            point2 = new Point(0x279, 0);
            this.Label2.Location = point2;
            this.Label2.Name = "Label2";
            size2 = new Size(0x180, 0x3a);
            this.Label2.Size = size2;
            this.Label2.TabIndex = 1;
            this.Label2.TextAlign = ContentAlignment.MiddleLeft;
            this.Label1.Dock = DockStyle.Left;
            this.Label1.Font = new Font("Simplified Arabic", 14f, FontStyle.Bold);
            point2 = new Point(0, 0);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            size2 = new Size(0xcf, 0x3a);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Label1";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 0x3e8;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = TaxGrad.My.Resources.Resources.company1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            size2 = new Size(0x3f9, 710);
            this.ClientSize = size2;
            this.ControlBox = false;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog1";
            this.RightToLeft = RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسية";
            this.WindowState = FormWindowState.Maximized;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        [DllImport("user32.dll", EntryPoint="LoadKeyboardLayoutA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int LoadKeyboardLayout([MarshalAs(UnmanagedType.VBByRefStr)] ref string pwszKLID, int flags);
        private void OK_Button_Click(object sender, EventArgs e)
        {
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Interaction.MsgBox(Strings.Asc(e.KeyChar), (MsgBoxStyle) MsgBoxStyle.ApplicationModal, null);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Label1.Text = Strings.Format(DateAndTime.get_Now(), "hh:mm:ss tt");
        }

        private void tsm5_Click(object sender, EventArgs e)
        {
        }

        private void tsm6_Click(object sender, EventArgs e)
        {
        }

        private void tsm7_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل تريد إعادة الدخول؟", ((MsgBoxStyle) MsgBoxStyle.Question) | ((MsgBoxStyle) MsgBoxStyle.YesNo), "") == ((MsgBoxResult) ((int) MsgBoxResult.Yes)))
            {
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void tsm8_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل تريد الخروج من البرنامج؟", ((MsgBoxStyle) MsgBoxStyle.Question) | ((MsgBoxStyle) MsgBoxStyle.YesNo), "") == ((MsgBoxResult) ((int) MsgBoxResult.Yes)))
            {
                ProjectData.EndApp();
            }
        }

        private void اعداتالطابعهToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void اعدادتالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void الأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frm = new FrmOssol();
            this.frm.ShowDialog();
        }

        private void الأصنافToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.frm = new FrmEdara();
            this.frm.ShowDialog();
        }

        private void الأنشطهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frm = new FrmOssolType();
            this.frm.ShowDialog();
        }

        private void الأنشطهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void البياناتالأساسيةToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void الخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frm = new FrmNmodg();
            this.frm.ShowDialog();
        }

        private void الشكلالقانونيToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void الشهائدToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void الشوارعToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void الضريبةالنوعيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void الفروعToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void المدنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frm = new FrmEmp();
            this.frm.ShowDialog();
        }

        private void المكاتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frm = new FrmKsm();
            this.frm.ShowDialog();
        }

        private void المكاتبToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void تستToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void شهائدممولToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void طباعهالشهائدToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void كميةالشهائدToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        internal virtual MenuStrip MenuStrip1
        {
            [DebuggerNonUserCode]
            get => 
                this._MenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._MenuStrip1 = value);
        }

        internal virtual ToolStripMenuItem tsm1
        {
            [DebuggerNonUserCode]
            get => 
                this._tsm1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._tsm1 = value);
        }

        internal virtual ToolStripMenuItem tsm3
        {
            [DebuggerNonUserCode]
            get => 
                this._tsm3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._tsm3 = value);
        }

        internal virtual ToolStripMenuItem tsm4
        {
            [DebuggerNonUserCode]
            get => 
                this._tsm4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._tsm4 = value);
        }

        internal virtual ToolStripMenuItem tsm5
        {
            [DebuggerNonUserCode]
            get => 
                this._tsm5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.tsm5_Click);
                if (this._tsm5 != null)
                {
                    this._tsm5.Click -= handler;
                }
                this._tsm5 = value;
                if (this._tsm5 != null)
                {
                    this._tsm5.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem tsm7
        {
            [DebuggerNonUserCode]
            get => 
                this._tsm7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.tsm7_Click);
                if (this._tsm7 != null)
                {
                    this._tsm7.Click -= handler;
                }
                this._tsm7 = value;
                if (this._tsm7 != null)
                {
                    this._tsm7.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem tsm8
        {
            [DebuggerNonUserCode]
            get => 
                this._tsm8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.tsm8_Click);
                if (this._tsm8 != null)
                {
                    this._tsm8.Click -= handler;
                }
                this._tsm8 = value;
                if (this._tsm8 != null)
                {
                    this._tsm8.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem tsm6
        {
            [DebuggerNonUserCode]
            get => 
                this._tsm6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.tsm6_Click);
                if (this._tsm6 != null)
                {
                    this._tsm6.Click -= handler;
                }
                this._tsm6 = value;
                if (this._tsm6 != null)
                {
                    this._tsm6.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem الأصنافToolStripMenuItem1
        {
            [DebuggerNonUserCode]
            get => 
                this._الأصنافToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.الأصنافToolStripMenuItem1_Click);
                if (this._الأصنافToolStripMenuItem1 != null)
                {
                    this._الأصنافToolStripMenuItem1.Click -= handler;
                }
                this._الأصنافToolStripMenuItem1 = value;
                if (this._الأصنافToolStripMenuItem1 != null)
                {
                    this._الأصنافToolStripMenuItem1.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem المكاتبToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._المكاتبToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.المكاتبToolStripMenuItem_Click);
                if (this._المكاتبToolStripMenuItem != null)
                {
                    this._المكاتبToolStripMenuItem.Click -= handler;
                }
                this._المكاتبToolStripMenuItem = value;
                if (this._المكاتبToolStripMenuItem != null)
                {
                    this._المكاتبToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem المدنToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._المدنToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.المدنToolStripMenuItem_Click);
                if (this._المدنToolStripMenuItem != null)
                {
                    this._المدنToolStripMenuItem.Click -= handler;
                }
                this._المدنToolStripMenuItem = value;
                if (this._المدنToolStripMenuItem != null)
                {
                    this._المدنToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem الأنشطهToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._الأنشطهToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.الأنشطهToolStripMenuItem_Click);
                if (this._الأنشطهToolStripMenuItem != null)
                {
                    this._الأنشطهToolStripMenuItem.Click -= handler;
                }
                this._الأنشطهToolStripMenuItem = value;
                if (this._الأنشطهToolStripMenuItem != null)
                {
                    this._الأنشطهToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem الأصنافToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._الأصنافToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.الأصنافToolStripMenuItem_Click);
                if (this._الأصنافToolStripMenuItem != null)
                {
                    this._الأصنافToolStripMenuItem.Click -= handler;
                }
                this._الأصنافToolStripMenuItem = value;
                if (this._الأصنافToolStripMenuItem != null)
                {
                    this._الأصنافToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem طباعهالشهائدToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._طباعهالشهائدToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.طباعهالشهائدToolStripMenuItem_Click);
                if (this._طباعهالشهائدToolStripMenuItem != null)
                {
                    this._طباعهالشهائدToolStripMenuItem.Click -= handler;
                }
                this._طباعهالشهائدToolStripMenuItem = value;
                if (this._طباعهالشهائدToolStripMenuItem != null)
                {
                    this._طباعهالشهائدToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem اعداتالطابعهToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._اعداتالطابعهToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.اعداتالطابعهToolStripMenuItem_Click);
                if (this._اعداتالطابعهToolStripMenuItem != null)
                {
                    this._اعداتالطابعهToolStripMenuItem.Click -= handler;
                }
                this._اعداتالطابعهToolStripMenuItem = value;
                if (this._اعداتالطابعهToolStripMenuItem != null)
                {
                    this._اعداتالطابعهToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual Panel Panel1
        {
            [DebuggerNonUserCode]
            get => 
                this._Panel1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Panel1 = value);
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label1 = value);
        }

        internal virtual Timer Timer1
        {
            [DebuggerNonUserCode]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Timer1_Tick);
                if (this._Timer1 != null)
                {
                    this._Timer1.Tick -= handler;
                }
                this._Timer1 = value;
                if (this._Timer1 != null)
                {
                    this._Timer1.Tick += handler;
                }
            }
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label2 = value);
        }

        internal virtual ToolStripMenuItem الخزينةToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._الخزينةToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.الخزينةToolStripMenuItem_Click);
                if (this._الخزينةToolStripMenuItem != null)
                {
                    this._الخزينةToolStripMenuItem.Click -= handler;
                }
                this._الخزينةToolStripMenuItem = value;
                if (this._الخزينةToolStripMenuItem != null)
                {
                    this._الخزينةToolStripMenuItem.Click += handler;
                }
            }
        }
    }
}

