namespace MACRO_52
{
    using Microsoft.VisualBasic.Compatibility.VB6;
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
    internal class CfrmSave : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        public ToolTip ToolTip1;
        [AccessedThroughProperty("Command2")]
        private Button _Command2;
        [AccessedThroughProperty("Text1")]
        private TextBox _Text1;
        [AccessedThroughProperty("Command1")]
        private Button _Command1;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        private string prjkt;
        private int idnr;
        private short i;

        [DebuggerNonUserCode]
        public CfrmSave()
        {
            base.Activated += new EventHandler(this.frm_Save_Activated);
            base.Load += new EventHandler(this.frm_Save_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
        }

        private void Command1_Click(object eventSender, EventArgs eventArgs)
        {
            GlobalVariables.Run_dscrpt = this.Text1.Text;
            if (this.Text1.Text == "")
            {
                GlobalVariables.Run_dscrpt = "No run description";
            }
            this.Hide();
        }

        private void Command2_Click(object eventSender, EventArgs eventArgs)
        {
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

        private void frm_Save_Activated(object eventSender, EventArgs eventArgs)
        {
            this.Label3.Text = GlobalVariables.project_name;
            this.Text1.Text = GlobalVariables.New_Project ? "" : GlobalVariables.Run_dscrpt;
        }

        private void frm_Save_Load(object eventSender, EventArgs eventArgs)
        {
            this.SetBounds((int) Math.Round(Support.TwipsToPixelsX((Support.PixelsToTwipsX((double) Screen.PrimaryScreen.Bounds.Width) - Support.PixelsToTwipsX((double) this.Width)) / 2.0)), (int) Math.Round(Support.TwipsToPixelsY((Support.PixelsToTwipsY((double) Screen.PrimaryScreen.Bounds.Height) - Support.PixelsToTwipsY((double) this.Height)) / 2.0)), 0, 0, BoundsSpecified.Location);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ResourceManager manager = new ResourceManager(typeof(CfrmSave));
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new ToolTip(this.components);
            this.Command2 = new Button();
            this.Text1 = new TextBox();
            this.Command1 = new Button();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.SuspendLayout();
            this.ToolTip1.Active = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Save";
            Size size = new Size(0x157, 230);
            this.ClientSize = size;
            Point point = new Point(2, 0x15);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.ControlBox = true;
            this.Enabled = true;
            this.KeyPreview = false;
            this.Cursor = Cursors.Default;
            this.RightToLeft = RightToLeft.No;
            this.ShowInTaskbar = true;
            this.HelpButton = false;
            this.WindowState = FormWindowState.Normal;
            this.Name = "frm_Save";
            this.Command2.TextAlign = ContentAlignment.MiddleCenter;
            this.Command2.Text = "Cancel";
            size = new Size(0x41, 0x19);
            this.Command2.Size = size;
            point = new Point(200, 200);
            this.Command2.Location = point;
            this.Command2.TabIndex = 5;
            this.Command2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command2.BackColor = SystemColors.Control;
            this.Command2.CausesValidation = true;
            this.Command2.Enabled = true;
            this.Command2.ForeColor = SystemColors.ControlText;
            this.Command2.Cursor = Cursors.Default;
            this.Command2.RightToLeft = RightToLeft.No;
            this.Command2.TabStop = true;
            this.Command2.Name = "Command2";
            this.Text1.AutoSize = false;
            size = new Size(0x141, 0x69);
            this.Text1.Size = size;
            point = new Point(8, 0x58);
            this.Text1.Location = point;
            this.Text1.Multiline = true;
            this.Text1.ScrollBars = ScrollBars.Both;
            this.Text1.WordWrap = false;
            this.Text1.TabIndex = 4;
            this.Text1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text1.AcceptsReturn = true;
            this.Text1.TextAlign = HorizontalAlignment.Left;
            this.Text1.BackColor = SystemColors.Window;
            this.Text1.CausesValidation = true;
            this.Text1.Enabled = true;
            this.Text1.ForeColor = SystemColors.WindowText;
            this.Text1.HideSelection = true;
            this.Text1.ReadOnly = false;
            this.Text1.MaxLength = 0;
            this.Text1.Cursor = Cursors.IBeam;
            this.Text1.RightToLeft = RightToLeft.No;
            this.Text1.TabStop = true;
            this.Text1.Visible = true;
            this.Text1.BorderStyle = BorderStyle.Fixed3D;
            this.Text1.Name = "Text1";
            this.Command1.TextAlign = ContentAlignment.MiddleCenter;
            this.Command1.Text = "OK";
            size = new Size(0x41, 0x19);
            this.Command1.Size = size;
            point = new Point(0x110, 200);
            this.Command1.Location = point;
            this.Command1.TabIndex = 0;
            this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command1.BackColor = SystemColors.Control;
            this.Command1.CausesValidation = true;
            this.Command1.Enabled = true;
            this.Command1.ForeColor = SystemColors.ControlText;
            this.Command1.Cursor = Cursors.Default;
            this.Command1.RightToLeft = RightToLeft.No;
            this.Command1.TabStop = true;
            this.Command1.Name = "Command1";
            this.Label3.Text = "Label3";
            size = new Size(0xe9, 0x11);
            this.Label3.Size = size;
            point = new Point(8, 0x20);
            this.Label3.Location = point;
            this.Label3.TabIndex = 3;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.TextAlign = ContentAlignment.TopLeft;
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Enabled = true;
            this.Label3.ForeColor = SystemColors.ControlText;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.RightToLeft = RightToLeft.No;
            this.Label3.UseMnemonic = true;
            this.Label3.Visible = true;
            this.Label3.AutoSize = false;
            this.Label3.BorderStyle = BorderStyle.Fixed3D;
            this.Label3.Name = "Label3";
            this.Label2.Text = "Run description:";
            size = new Size(0xb1, 0x11);
            this.Label2.Size = size;
            point = new Point(8, 0x40);
            this.Label2.Location = point;
            this.Label2.TabIndex = 2;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.TextAlign = ContentAlignment.TopLeft;
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Enabled = true;
            this.Label2.ForeColor = SystemColors.ControlText;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.RightToLeft = RightToLeft.No;
            this.Label2.UseMnemonic = true;
            this.Label2.Visible = true;
            this.Label2.AutoSize = false;
            this.Label2.BorderStyle = BorderStyle.None;
            this.Label2.Name = "Label2";
            this.Label1.Text = "Project name";
            size = new Size(0x51, 0x11);
            this.Label1.Size = size;
            point = new Point(8, 8);
            this.Label1.Location = point;
            this.Label1.TabIndex = 1;
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
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public virtual Button Command2
        {
            [DebuggerNonUserCode]
            get => 
                this._Command2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command2_Click);
                if (!ReferenceEquals(this._Command2, null))
                {
                    this._Command2.Click -= handler;
                }
                this._Command2 = value;
                if (!ReferenceEquals(this._Command2, null))
                {
                    this._Command2.Click += handler;
                }
            }
        }

        public virtual TextBox Text1
        {
            [DebuggerNonUserCode]
            get => 
                this._Text1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text1 = value;
        }

        public virtual Button Command1
        {
            [DebuggerNonUserCode]
            get => 
                this._Command1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command1_Click);
                if (!ReferenceEquals(this._Command1, null))
                {
                    this._Command1.Click -= handler;
                }
                this._Command1 = value;
                if (!ReferenceEquals(this._Command1, null))
                {
                    this._Command1.Click += handler;
                }
            }
        }

        public virtual Label Label3
        {
            [DebuggerNonUserCode]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label3 = value;
        }

        public virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label2 = value;
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
    }
}

