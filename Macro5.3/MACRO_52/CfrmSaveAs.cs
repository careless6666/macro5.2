namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class CfrmSaveAs : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        public ToolTip ToolTip1;
        [AccessedThroughProperty("Text1")]
        private TextBox _Text1;
        [AccessedThroughProperty("Text4")]
        private TextBox _Text4;
        [AccessedThroughProperty("Command2")]
        private Button _Command2;
        [AccessedThroughProperty("Text2")]
        private TextBox _Text2;
        [AccessedThroughProperty("Command1")]
        private Button _Command1;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        public object IDCANCEL;
        private CfrmMain frmMain;

        public CfrmSaveAs()
        {
            base.Activated += new EventHandler(this.frm_SaveAs_Activated);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
        }

        public CfrmSaveAs(ref CfrmMain frm)
        {
            base.Activated += new EventHandler(this.frm_SaveAs_Activated);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void Command1_Click(object eventSender, EventArgs eventArgs)
        {
            this.IDCANCEL = true;
            this.Hide();
        }

        private void Command2_Click(object eventSender, EventArgs eventArgs)
        {
            if (Strings.Len(this.Text2.Text) == 0)
            {
                MiscFUncs.MsgBox_Renamed("Enter project description", 0, "");
                this.Text2.Focus();
            }
            else if (Strings.Len(this.Text1.Text) == 0)
            {
                MiscFUncs.MsgBox_Renamed("Enter Run_name", 0, "");
                this.Text1.Focus();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                string text = this.Text2.Text;
                string expression = this.Text4.Text;
                GlobalVariables.Run_name = this.Text1.Text;
                if (Strings.Len(expression) == 0)
                {
                    expression = "No run-description";
                }
                this.Hide();
                this.IDCANCEL = false;
                this.frmMain.Refresh();
                ReadSaveFunctions.SaveToDatabase(ref text, ref expression, ref GlobalVariables.project_name, ref GlobalVariables.ProjectIDno, ref true, ref this.frmMain);
                GlobalVariables.Run_dscrpt = expression;
                Cursor.Current = Cursors.Default;
                this.frmMain.Text = "Project: " + GlobalVariables.project_name + @" \ Simulation: " + GlobalVariables.Run_name;
                GlobalVariables.New_Project = false;
                this.frmMain.mnuToolsChangeParameters.Enabled = true;
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

        private void frm_SaveAs_Activated(object eventSender, EventArgs eventArgs)
        {
            this.Label3.Text = GlobalVariables.project_name;
            this.Text2.Text = GlobalVariables.Project_dscrpt;
            this.Text1.Text = GlobalVariables.Run_name;
            this.Text4.Text = GlobalVariables.Run_dscrpt;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new ToolTip(this.components);
            this.Text1 = new TextBox();
            this.Text4 = new TextBox();
            this.Command2 = new Button();
            this.Text2 = new TextBox();
            this.Command1 = new Button();
            this.Frame1 = new GroupBox();
            this.Label5 = new Label();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            this.Text1.AcceptsReturn = true;
            this.Text1.BackColor = SystemColors.Window;
            this.Text1.Cursor = Cursors.IBeam;
            this.Text1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text1.ForeColor = SystemColors.WindowText;
            Point point = new Point(0x10, 0xb8);
            this.Text1.Location = point;
            this.Text1.MaxLength = 50;
            this.Text1.Name = "Text1";
            this.Text1.RightToLeft = RightToLeft.No;
            Size size = new Size(0x161, 20);
            this.Text1.Size = size;
            this.Text1.TabIndex = 2;
            this.Text4.AcceptsReturn = true;
            this.Text4.BackColor = SystemColors.Window;
            this.Text4.Cursor = Cursors.IBeam;
            this.Text4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text4.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0xe8);
            this.Text4.Location = point;
            this.Text4.MaxLength = 0xff;
            this.Text4.Multiline = true;
            this.Text4.Name = "Text4";
            this.Text4.RightToLeft = RightToLeft.No;
            this.Text4.ScrollBars = ScrollBars.Both;
            size = new Size(0x161, 0x61);
            this.Text4.Size = size;
            this.Text4.TabIndex = 3;
            this.Text4.WordWrap = false;
            this.Command2.BackColor = SystemColors.Control;
            this.Command2.Cursor = Cursors.Default;
            this.Command2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command2.ForeColor = SystemColors.ControlText;
            point = new Point(0x128, 0x150);
            this.Command2.Location = point;
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command2.Size = size;
            this.Command2.TabIndex = 4;
            this.Command2.Text = "&Save";
            this.Command2.UseVisualStyleBackColor = false;
            this.Text2.AcceptsReturn = true;
            this.Text2.BackColor = SystemColors.Window;
            this.Text2.Cursor = Cursors.IBeam;
            this.Text2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text2.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0x48);
            this.Text2.Location = point;
            this.Text2.MaxLength = 0xff;
            this.Text2.Multiline = true;
            this.Text2.Name = "Text2";
            this.Text2.RightToLeft = RightToLeft.No;
            this.Text2.ScrollBars = ScrollBars.Both;
            size = new Size(0x161, 0x59);
            this.Text2.Size = size;
            this.Text2.TabIndex = 1;
            this.Text2.WordWrap = false;
            this.Command1.BackColor = SystemColors.Control;
            this.Command1.Cursor = Cursors.Default;
            this.Command1.DialogResult = DialogResult.Cancel;
            this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command1.ForeColor = SystemColors.ControlText;
            point = new Point(0xd8, 0x150);
            this.Command1.Location = point;
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command1.Size = size;
            this.Command1.TabIndex = 0;
            this.Command1.Text = "Cancel";
            this.Command1.UseVisualStyleBackColor = false;
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x171, 0x171);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 5;
            this.Frame1.TabStop = false;
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xa8);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Simulation name:";
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x109, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Project name:";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.BorderStyle = BorderStyle.Fixed3D;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x20);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x109, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Label3";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xd8);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Simulation description:";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Project description:";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.Command1;
            size = new Size(0x17e, 0x176);
            this.ClientSize = size;
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.Frame1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(2, 0x15);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmSaveAs";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Save as";
            this.Frame1.ResumeLayout(false);
            this.ResumeLayout(false);
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

        public virtual TextBox Text4
        {
            [DebuggerNonUserCode]
            get => 
                this._Text4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text4 = value;
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

        public virtual TextBox Text2
        {
            [DebuggerNonUserCode]
            get => 
                this._Text2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text2 = value;
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

        public virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
        }

        public virtual Label Label4
        {
            [DebuggerNonUserCode]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label4 = value;
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

