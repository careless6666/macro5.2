namespace MACRO_52
{
    using AxComctlLib;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class frmProgress : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Progress")]
        private AxProgressBar _Progress;
        [AccessedThroughProperty("lblAction")]
        private Label _lblAction;
        private CfrmMain frmMain;

        public frmProgress(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmProgress_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
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

        private void frmProgress_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmProgress));
            this.Progress = new AxProgressBar();
            this.lblAction = new Label();
            this.Progress.BeginInit();
            this.SuspendLayout();
            Point point = new Point(8, 40);
            this.Progress.Location = point;
            this.Progress.Name = "Progress";
            this.Progress.OcxState = (AxHost.State) manager.GetObject("Progress.OcxState");
            Size size = new Size(0x1a1, 0x19);
            this.Progress.Size = size;
            this.Progress.TabIndex = 1;
            this.lblAction.BackColor = SystemColors.Control;
            this.lblAction.Cursor = Cursors.Default;
            this.lblAction.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblAction.ForeColor = SystemColors.ControlText;
            point = new Point(8, 8);
            this.lblAction.Location = point;
            this.lblAction.Name = "lblAction";
            this.lblAction.RightToLeft = RightToLeft.No;
            size = new Size(0x199, 0x19);
            this.lblAction.Size = size;
            this.lblAction.TabIndex = 0;
            this.lblAction.Text = "Action";
            this.lblAction.TextAlign = ContentAlignment.TopCenter;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x1b0, 0x49);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.lblAction);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProgress";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Action";
            this.Progress.EndInit();
            this.ResumeLayout(false);
        }

        public virtual AxProgressBar Progress
        {
            [DebuggerNonUserCode]
            get => 
                this._Progress;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Progress = value;
        }

        public virtual Label lblAction
        {
            [DebuggerNonUserCode]
            get => 
                this._lblAction;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblAction = value;
        }
    }
}

