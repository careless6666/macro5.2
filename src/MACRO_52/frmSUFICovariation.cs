namespace MACRO_52
{
    using AxMSFlexGridLib;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Resources;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class frmSUFICovariation : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        public ToolTip ToolTip1;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("MSFlexGrid1")]
        private AxMSFlexGrid _MSFlexGrid1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        public bool IDOK;
        private CfrmMain frmMain;

        public frmSUFICovariation(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmSUFICovariation_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.IDOK = false;
            this.Hide();
        }

        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            this.IDOK = true;
            this.Hide();
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

        private void frmSUFICovariation_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ResourceManager manager = new ResourceManager(typeof(frmSUFICovariation));
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new ToolTip(this.components);
            this.Frame1 = new GroupBox();
            this.cmdCancel = new Button();
            this.cmdOK = new Button();
            this.MSFlexGrid1 = new AxMSFlexGrid();
            this.Label1 = new Label();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            this.ToolTip1.Active = true;
            this.MSFlexGrid1.BeginInit();
            this.Text = "Define SUFI covariation";
            Size size = new Size(0x1df, 0xdd);
            this.ClientSize = size;
            Point point = new Point(4, 0x17);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.Enabled = true;
            this.KeyPreview = false;
            this.Cursor = Cursors.Default;
            this.RightToLeft = RightToLeft.No;
            this.ShowInTaskbar = true;
            this.HelpButton = false;
            this.WindowState = FormWindowState.Normal;
            this.Name = "frmSUFICovariation";
            size = new Size(0x1d9, 0xd9);
            this.Frame1.Size = size;
            point = new Point(0, 0);
            this.Frame1.Location = point;
            this.Frame1.TabIndex = 0;
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Enabled = true;
            this.Frame1.ForeColor = SystemColors.ControlText;
            this.Frame1.RightToLeft = RightToLeft.No;
            this.Frame1.Visible = true;
            this.Frame1.Name = "Frame1";
            this.cmdCancel.TextAlign = ContentAlignment.MiddleCenter;
            this.CancelButton = this.cmdCancel;
            this.cmdCancel.Text = "Cancel";
            size = new Size(0x41, 0x19);
            this.cmdCancel.Size = size;
            point = new Point(320, 0xb8);
            this.cmdCancel.Location = point;
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.CausesValidation = true;
            this.cmdCancel.Enabled = true;
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.RightToLeft = RightToLeft.No;
            this.cmdCancel.TabStop = true;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdOK.TextAlign = ContentAlignment.MiddleCenter;
            this.cmdOK.Text = "&OK";
            size = new Size(0x41, 0x19);
            this.cmdOK.Size = size;
            point = new Point(0x188, 0xb8);
            this.cmdOK.Location = point;
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.CausesValidation = true;
            this.cmdOK.Enabled = true;
            this.cmdOK.ForeColor = SystemColors.ControlText;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.RightToLeft = RightToLeft.No;
            this.cmdOK.TabStop = true;
            this.cmdOK.Name = "cmdOK";
            this.MSFlexGrid1.OcxState = (AxHost.State) manager.GetObject("MSFlexGrid1.OcxState");
            size = new Size(0x1c1, 0x71);
            this.MSFlexGrid1.Size = size;
            point = new Point(0x10, 0x18);
            this.MSFlexGrid1.Location = point;
            this.MSFlexGrid1.TabIndex = 1;
            this.MSFlexGrid1.Name = "MSFlexGrid1";
            this.Label1.Text = "Click in the table to indicate that parameter values covary between horizons.";
            size = new Size(0x131, 0x21);
            this.Label1.Size = size;
            point = new Point(0x10, 0x98);
            this.Label1.Location = point;
            this.Label1.TabIndex = 2;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.TextAlign = ContentAlignment.TopLeft;
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Enabled = true;
            this.Label1.ForeColor = SystemColors.ControlText;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.RightToLeft = RightToLeft.No;
            this.Label1.UseMnemonic = true;
            this.Label1.Visible = true;
            this.Label1.AutoSize = false;
            this.Label1.BorderStyle = BorderStyle.None;
            this.Label1.Name = "Label1";
            this.Controls.Add(this.Frame1);
            this.Frame1.Controls.Add(this.cmdCancel);
            this.Frame1.Controls.Add(this.cmdOK);
            this.Frame1.Controls.Add(this.MSFlexGrid1);
            this.Frame1.Controls.Add(this.Label1);
            this.MSFlexGrid1.EndInit();
            this.Frame1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void MSFlexGrid1_ClickEvent(object eventSender, EventArgs eventArgs)
        {
            if ((this.MSFlexGrid1.Row > 0) & (this.MSFlexGrid1.Col > 0))
            {
                this.MSFlexGrid1.Text = (this.MSFlexGrid1.Text != "covary") ? "covary" : "";
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

        public virtual AxMSFlexGrid MSFlexGrid1
        {
            [DebuggerNonUserCode]
            get => 
                this._MSFlexGrid1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.MSFlexGrid1_ClickEvent);
                if (!ReferenceEquals(this._MSFlexGrid1, null))
                {
                    this._MSFlexGrid1.ClickEvent -= handler;
                }
                this._MSFlexGrid1 = value;
                if (!ReferenceEquals(this._MSFlexGrid1, null))
                {
                    this._MSFlexGrid1.ClickEvent += handler;
                }
            }
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

        public virtual GroupBox Frame1
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame1 = value;
        }
    }
}

