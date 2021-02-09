namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.Compatibility.VB6;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class frmPedotransfer : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("_Check6_2")]
        private CheckBox __Check6_2;
        [AccessedThroughProperty("_Check5_9")]
        private CheckBox __Check5_9;
        [AccessedThroughProperty("_Check5_0")]
        private CheckBox __Check5_0;
        [AccessedThroughProperty("_Check5_1")]
        private CheckBox __Check5_1;
        [AccessedThroughProperty("_Check5_2")]
        private CheckBox __Check5_2;
        [AccessedThroughProperty("_Check5_3")]
        private CheckBox __Check5_3;
        [AccessedThroughProperty("_Check5_4")]
        private CheckBox __Check5_4;
        [AccessedThroughProperty("_Check5_5")]
        private CheckBox __Check5_5;
        [AccessedThroughProperty("_Check5_6")]
        private CheckBox __Check5_6;
        [AccessedThroughProperty("_Check5_7")]
        private CheckBox __Check5_7;
        [AccessedThroughProperty("_Check5_8")]
        private CheckBox __Check5_8;
        [AccessedThroughProperty("_Check6_1")]
        private CheckBox __Check6_1;
        [AccessedThroughProperty("_Check6_3")]
        private CheckBox __Check6_3;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("_Check6_4")]
        private CheckBox __Check6_4;
        [AccessedThroughProperty("_Check6_0")]
        private CheckBox __Check6_0;
        [AccessedThroughProperty("Label30")]
        private Label _Label30;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label29")]
        private Label _Label29;
        [AccessedThroughProperty("Frame15")]
        private GroupBox _Frame15;
        [AccessedThroughProperty("Check5")]
        private CheckBoxArray _Check5;
        [AccessedThroughProperty("Check6")]
        private CheckBoxArray _Check6;
        private CfrmMain frmMain;
        public bool IDOK;

        [DebuggerNonUserCode]
        public frmPedotransfer()
        {
            base.Load += new EventHandler(this.frmPedotransfer_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
        }

        public frmPedotransfer(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmPedotransfer_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void Check5_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            short index = this.Check5.GetIndex((CheckBox) eventSender);
            this.cmdOK.Enabled = this.CheckCheck();
        }

        private void Check6_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            short index = this.Check6.GetIndex((CheckBox) eventSender);
            this.cmdOK.Enabled = this.CheckCheck();
        }

        private bool CheckCheck()
        {
            bool flag2 = false;
            bool flag3 = false;
            bool flag4 = false;
            bool flag = false;
            CheckBoxArray array = this.Check5;
            short num2 = (short) (array.Count() - 1);
            short num = 0;
            while (true)
            {
                short num4 = num2;
                if (num > num4)
                {
                    array = null;
                    CheckBoxArray array2 = this.Check6;
                    short num3 = (short) (array2.Count() - 1);
                    num = 0;
                    while (true)
                    {
                        num4 = num3;
                        if (num > num4)
                        {
                            if (array2[(short) (array2.Count() - 1)].CheckState != CheckState.Unchecked)
                            {
                                flag2 = true;
                            }
                            array2 = null;
                            if ((flag3 & flag4) | flag2)
                            {
                                flag = true;
                            }
                            return flag;
                        }
                        if (array2[num].CheckState != CheckState.Unchecked)
                        {
                            flag4 = true;
                        }
                        num = (short) (num + 1);
                    }
                }
                if (array[num].CheckState != CheckState.Unchecked)
                {
                    flag3 = true;
                }
                num = (short) (num + 1);
            }
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.IDOK = false;
            this.Hide();
        }

        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            int num = (int) Interaction.MsgBox("This will overwrite current parameter values. Do you wish to continue?", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null);
            if (num == 6)
            {
                this.IDOK = true;
                this.Hide();
            }
            else if (num == 7)
            {
                this.IDOK = false;
                this.Hide();
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing && !ReferenceEquals(this.components, null))
            {
                this.components.Dispose();
            }
            base.Dispose(Disposing);
        }

        private void frmPedotransfer_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Frame15 = new GroupBox();
            this._Check6_2 = new CheckBox();
            this._Check5_9 = new CheckBox();
            this._Check5_0 = new CheckBox();
            this._Check5_1 = new CheckBox();
            this._Check5_2 = new CheckBox();
            this._Check5_3 = new CheckBox();
            this._Check5_4 = new CheckBox();
            this._Check5_5 = new CheckBox();
            this._Check5_6 = new CheckBox();
            this._Check5_7 = new CheckBox();
            this._Check5_8 = new CheckBox();
            this._Check6_1 = new CheckBox();
            this._Check6_3 = new CheckBox();
            this.cmdOK = new Button();
            this.cmdCancel = new Button();
            this._Check6_4 = new CheckBox();
            this._Check6_0 = new CheckBox();
            this.Label30 = new Label();
            this.Label1 = new Label();
            this.Label29 = new Label();
            this.Check5 = new CheckBoxArray(this.components);
            this.Check6 = new CheckBoxArray(this.components);
            this.Frame15.SuspendLayout();
            ((ISupportInitialize) this.Check5).BeginInit();
            ((ISupportInitialize) this.Check6).BeginInit();
            this.SuspendLayout();
            this.Frame15.BackColor = SystemColors.Control;
            this.Frame15.Controls.Add(this._Check6_2);
            this.Frame15.Controls.Add(this._Check5_9);
            this.Frame15.Controls.Add(this._Check5_0);
            this.Frame15.Controls.Add(this._Check5_1);
            this.Frame15.Controls.Add(this._Check5_2);
            this.Frame15.Controls.Add(this._Check5_3);
            this.Frame15.Controls.Add(this._Check5_4);
            this.Frame15.Controls.Add(this._Check5_5);
            this.Frame15.Controls.Add(this._Check5_6);
            this.Frame15.Controls.Add(this._Check5_7);
            this.Frame15.Controls.Add(this._Check5_8);
            this.Frame15.Controls.Add(this._Check6_1);
            this.Frame15.Controls.Add(this._Check6_3);
            this.Frame15.Controls.Add(this.cmdOK);
            this.Frame15.Controls.Add(this.cmdCancel);
            this.Frame15.Controls.Add(this._Check6_4);
            this.Frame15.Controls.Add(this._Check6_0);
            this.Frame15.Controls.Add(this.Label30);
            this.Frame15.Controls.Add(this.Label1);
            this.Frame15.Controls.Add(this.Label29);
            this.Frame15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame15.ForeColor = SystemColors.ControlText;
            Point point = new Point(0, 0);
            this.Frame15.Location = point;
            this.Frame15.Name = "Frame15";
            this.Frame15.RightToLeft = RightToLeft.No;
            Size size = new Size(0x119, 0xe9);
            this.Frame15.Size = size;
            this.Frame15.TabIndex = 0;
            this.Frame15.TabStop = false;
            this._Check6_2.BackColor = SystemColors.Control;
            this._Check6_2.Cursor = Cursors.Default;
            this._Check6_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check6_2.ForeColor = SystemColors.ControlText;
            this.Check6.SetIndex(this._Check6_2, 2);
            point = new Point(0x68, 0x70);
            this._Check6_2.Location = point;
            this._Check6_2.Name = "_Check6_2";
            this._Check6_2.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 0x11);
            this._Check6_2.Size = size;
            this._Check6_2.TabIndex = 20;
            this._Check6_2.Text = "KSATMIN";
            this._Check6_2.UseVisualStyleBackColor = false;
            this._Check5_9.BackColor = SystemColors.Control;
            this._Check5_9.Cursor = Cursors.Default;
            this._Check5_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_9.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_9, 9);
            point = new Point(0x10, 0xb0);
            this._Check5_9.Location = point;
            this._Check5_9.Name = "_Check5_9";
            this._Check5_9.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this._Check5_9.Size = size;
            this._Check5_9.TabIndex = 0x13;
            this._Check5_9.Text = "Check1";
            this._Check5_9.UseVisualStyleBackColor = false;
            this._Check5_0.BackColor = SystemColors.Control;
            this._Check5_0.Cursor = Cursors.Default;
            this._Check5_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_0.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_0, 0);
            point = new Point(0x10, 0x20);
            this._Check5_0.Location = point;
            this._Check5_0.Name = "_Check5_0";
            this._Check5_0.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_0.Size = size;
            this._Check5_0.TabIndex = 15;
            this._Check5_0.Text = "Check5";
            this._Check5_0.UseVisualStyleBackColor = false;
            this._Check5_1.BackColor = SystemColors.Control;
            this._Check5_1.Cursor = Cursors.Default;
            this._Check5_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_1.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_1, 1);
            point = new Point(0x10, 0x30);
            this._Check5_1.Location = point;
            this._Check5_1.Name = "_Check5_1";
            this._Check5_1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_1.Size = size;
            this._Check5_1.TabIndex = 14;
            this._Check5_1.Text = "Check5";
            this._Check5_1.UseVisualStyleBackColor = false;
            this._Check5_2.BackColor = SystemColors.Control;
            this._Check5_2.Cursor = Cursors.Default;
            this._Check5_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_2.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_2, 2);
            point = new Point(0x10, 0x40);
            this._Check5_2.Location = point;
            this._Check5_2.Name = "_Check5_2";
            this._Check5_2.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_2.Size = size;
            this._Check5_2.TabIndex = 13;
            this._Check5_2.Text = "Check5";
            this._Check5_2.UseVisualStyleBackColor = false;
            this._Check5_3.BackColor = SystemColors.Control;
            this._Check5_3.Cursor = Cursors.Default;
            this._Check5_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_3.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_3, 3);
            point = new Point(0x10, 80);
            this._Check5_3.Location = point;
            this._Check5_3.Name = "_Check5_3";
            this._Check5_3.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_3.Size = size;
            this._Check5_3.TabIndex = 12;
            this._Check5_3.Text = "Check5";
            this._Check5_3.UseVisualStyleBackColor = false;
            this._Check5_4.BackColor = SystemColors.Control;
            this._Check5_4.Cursor = Cursors.Default;
            this._Check5_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_4.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_4, 4);
            point = new Point(0x10, 0x60);
            this._Check5_4.Location = point;
            this._Check5_4.Name = "_Check5_4";
            this._Check5_4.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_4.Size = size;
            this._Check5_4.TabIndex = 11;
            this._Check5_4.Text = "Check5";
            this._Check5_4.UseVisualStyleBackColor = false;
            this._Check5_5.BackColor = SystemColors.Control;
            this._Check5_5.Cursor = Cursors.Default;
            this._Check5_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_5.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_5, 5);
            point = new Point(0x10, 0x70);
            this._Check5_5.Location = point;
            this._Check5_5.Name = "_Check5_5";
            this._Check5_5.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_5.Size = size;
            this._Check5_5.TabIndex = 10;
            this._Check5_5.Text = "Check5";
            this._Check5_5.UseVisualStyleBackColor = false;
            this._Check5_6.BackColor = SystemColors.Control;
            this._Check5_6.Cursor = Cursors.Default;
            this._Check5_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_6.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_6, 6);
            point = new Point(0x10, 0x80);
            this._Check5_6.Location = point;
            this._Check5_6.Name = "_Check5_6";
            this._Check5_6.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_6.Size = size;
            this._Check5_6.TabIndex = 9;
            this._Check5_6.Text = "Check5";
            this._Check5_6.UseVisualStyleBackColor = false;
            this._Check5_7.BackColor = SystemColors.Control;
            this._Check5_7.Cursor = Cursors.Default;
            this._Check5_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_7.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_7, 7);
            point = new Point(0x10, 0x90);
            this._Check5_7.Location = point;
            this._Check5_7.Name = "_Check5_7";
            this._Check5_7.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_7.Size = size;
            this._Check5_7.TabIndex = 8;
            this._Check5_7.Text = "Check5";
            this._Check5_7.UseVisualStyleBackColor = false;
            this._Check5_8.BackColor = SystemColors.Control;
            this._Check5_8.Cursor = Cursors.Default;
            this._Check5_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check5_8.ForeColor = SystemColors.ControlText;
            this.Check5.SetIndex(this._Check5_8, 8);
            point = new Point(0x10, 160);
            this._Check5_8.Location = point;
            this._Check5_8.Name = "_Check5_8";
            this._Check5_8.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Check5_8.Size = size;
            this._Check5_8.TabIndex = 7;
            this._Check5_8.Text = "Check5";
            this._Check5_8.UseVisualStyleBackColor = false;
            this._Check6_1.BackColor = SystemColors.Control;
            this._Check6_1.Cursor = Cursors.Default;
            this._Check6_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check6_1.ForeColor = SystemColors.ControlText;
            this.Check6.SetIndex(this._Check6_1, 1);
            point = new Point(0x68, 80);
            this._Check6_1.Location = point;
            this._Check6_1.Name = "_Check6_1";
            this._Check6_1.RightToLeft = RightToLeft.No;
            size = new Size(0x89, 0x21);
            this._Check6_1.Size = size;
            this._Check6_1.TabIndex = 5;
            this._Check6_1.Text = "KSM";
            this._Check6_1.UseVisualStyleBackColor = false;
            this._Check6_3.BackColor = SystemColors.Control;
            this._Check6_3.Cursor = Cursors.Default;
            this._Check6_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check6_3.ForeColor = SystemColors.ControlText;
            this.Check6.SetIndex(this._Check6_3, 3);
            point = new Point(0x68, 0x88);
            this._Check6_3.Location = point;
            this._Check6_3.Name = "_Check6_3";
            this._Check6_3.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 0x19);
            this._Check6_3.Size = size;
            this._Check6_3.TabIndex = 4;
            this._Check6_3.Text = "ASCALE";
            this._Check6_3.UseVisualStyleBackColor = false;
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.Enabled = false;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.ForeColor = SystemColors.ControlText;
            point = new Point(0xd0, 200);
            this.cmdOK.Location = point;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdOK.Size = size;
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(0x88, 200);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this._Check6_4.BackColor = SystemColors.Control;
            this._Check6_4.Cursor = Cursors.Default;
            this._Check6_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check6_4.ForeColor = SystemColors.ControlText;
            this.Check6.SetIndex(this._Check6_4, 4);
            point = new Point(0x68, 160);
            this._Check6_4.Location = point;
            this._Check6_4.Name = "_Check6_4";
            this._Check6_4.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x22);
            this._Check6_4.Size = size;
            this._Check6_4.TabIndex = 1;
            this._Check6_4.Text = "All parameters and horizons";
            this._Check6_4.UseVisualStyleBackColor = false;
            this._Check6_4.Visible = false;
            this._Check6_0.BackColor = SystemColors.Control;
            this._Check6_0.Cursor = Cursors.Default;
            this._Check6_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Check6_0.ForeColor = SystemColors.ControlText;
            this.Check6.SetIndex(this._Check6_0, 0);
            point = new Point(0x68, 0x20);
            this._Check6_0.Location = point;
            this._Check6_0.Name = "_Check6_0";
            this._Check6_0.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x41);
            this._Check6_0.Size = size;
            this._Check6_0.TabIndex = 6;
            this._Check6_0.Text = "ALPHA, N, TPORV, XMPOR, WILT, CTEN";
            this._Check6_0.UseVisualStyleBackColor = false;
            this.Label30.BackColor = SystemColors.Control;
            this.Label30.Cursor = Cursors.Default;
            this.Label30.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label30.ForeColor = SystemColors.ControlText;
            point = new Point(0x68, 0x10);
            this.Label30.Location = point;
            this.Label30.Name = "Label30";
            this.Label30.RightToLeft = RightToLeft.No;
            size = new Size(0x99, 0x11);
            this.Label30.Size = size;
            this.Label30.TabIndex = 0x10;
            this.Label30.Text = "Parameters to estimate:";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(6, 0xc0);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x7c, 0x21);
            this.Label1.Size = size;
            this.Label1.TabIndex = 0x12;
            this.Label1.Text = "Calculations cannot be undone.";
            this.Label29.BackColor = SystemColors.Control;
            this.Label29.Cursor = Cursors.Default;
            this.Label29.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label29.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x10);
            this.Label29.Location = point;
            this.Label29.Name = "Label29";
            this.Label29.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label29.Size = size;
            this.Label29.TabIndex = 0x11;
            this.Label29.Text = "Horizon:";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x11d, 0xee);
            this.ClientSize = size;
            this.Controls.Add(this.Frame15);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedotransfer";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Pedotransfer";
            this.Frame15.ResumeLayout(false);
            ((ISupportInitialize) this.Check5).EndInit();
            ((ISupportInitialize) this.Check6).EndInit();
            this.ResumeLayout(false);
        }

        public virtual CheckBox _Check6_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check6_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check6_2 = value;
        }

        public virtual CheckBox _Check5_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_9 = value;
        }

        public virtual CheckBox _Check5_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_0 = value;
        }

        public virtual CheckBox _Check5_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_1 = value;
        }

        public virtual CheckBox _Check5_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_2 = value;
        }

        public virtual CheckBox _Check5_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_3 = value;
        }

        public virtual CheckBox _Check5_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_4 = value;
        }

        public virtual CheckBox _Check5_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_5 = value;
        }

        public virtual CheckBox _Check5_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_6 = value;
        }

        public virtual CheckBox _Check5_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_7 = value;
        }

        public virtual CheckBox _Check5_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check5_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check5_8 = value;
        }

        public virtual CheckBox _Check6_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check6_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check6_1 = value;
        }

        public virtual CheckBox _Check6_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check6_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check6_3 = value;
        }

        public virtual Button cmdOK
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdOK;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdOK_Click);
                if (!ReferenceEquals(this._cmdOK, null))
                {
                    this._cmdOK.Click -= handler;
                }
                this._cmdOK = value;
                if (!ReferenceEquals(this._cmdOK, null))
                {
                    this._cmdOK.Click += handler;
                }
            }
        }

        public virtual Button cmdCancel
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdCancel;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdCancel_Click);
                if (!ReferenceEquals(this._cmdCancel, null))
                {
                    this._cmdCancel.Click -= handler;
                }
                this._cmdCancel = value;
                if (!ReferenceEquals(this._cmdCancel, null))
                {
                    this._cmdCancel.Click += handler;
                }
            }
        }

        public virtual CheckBox _Check6_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check6_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check6_4 = value;
        }

        public virtual CheckBox _Check6_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Check6_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Check6_0 = value;
        }

        public virtual Label Label30
        {
            [DebuggerNonUserCode]
            get => 
                this._Label30;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label30 = value;
        }

        public virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label1 = value;
        }

        public virtual Label Label29
        {
            [DebuggerNonUserCode]
            get => 
                this._Label29;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label29 = value;
        }

        public virtual GroupBox Frame15
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame15;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame15 = value;
        }

        public virtual CheckBoxArray Check5
        {
            [DebuggerNonUserCode]
            get => 
                this._Check5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Check5_CheckStateChanged);
                if (!ReferenceEquals(this._Check5, null))
                {
                    this._Check5.CheckStateChanged -= handler;
                }
                this._Check5 = value;
                if (!ReferenceEquals(this._Check5, null))
                {
                    this._Check5.CheckStateChanged += handler;
                }
            }
        }

        public virtual CheckBoxArray Check6
        {
            [DebuggerNonUserCode]
            get => 
                this._Check6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Check6_CheckStateChanged);
                if (!ReferenceEquals(this._Check6, null))
                {
                    this._Check6.CheckStateChanged -= handler;
                }
                this._Check6 = value;
                if (!ReferenceEquals(this._Check6, null))
                {
                    this._Check6.CheckStateChanged += handler;
                }
            }
        }
    }
}

