namespace MACRO_52
{
    using MACRO_52.My;
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
    internal class frmNewProject : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Text2")]
        private TextBox _Text2;
        [AccessedThroughProperty("Frame3")]
        private GroupBox _Frame3;
        [AccessedThroughProperty("Text1")]
        private TextBox _Text1;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("Command2")]
        private Button _Command2;
        [AccessedThroughProperty("Command1")]
        private Button _Command1;
        private CfrmMain m_frmMain;

        public frmNewProject(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmNewProject_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.m_frmMain = frm;
        }

        private void Command1_Click(object eventSender, EventArgs eventArgs)
        {
            this.Hide();
        }

        private void Command2_Click(object eventSender, EventArgs eventArgs)
        {
            this.Text1.Text = Strings.Trim(this.Text1.Text);
            if (this.Text1.Text == "")
            {
                MiscFUncs.MsgBox_Renamed("Please enter a name for the project", 0x30, "");
                this.Text1.Focus();
            }
            else
            {
                GlobalVariables.project_name = this.Text1.Text;
                GlobalVariables.Project_dscrpt = this.Text2.Text;
                Cursor.Current = Cursors.WaitCursor;
                this.Refresh();
                ReadSaveFunctions.ReadOptions(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadRun_ID(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadSite(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadSetup(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadIBcond(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadPhysicalParms(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadIrrigation(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadSoilProfile(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadSolute(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadCrop(ref 1, ref this.m_frmMain);
                ReadSaveFunctions.ReadOutput(ref 1, ref this.m_frmMain);
                Cursor.Current = Cursors.Default;
                this.m_frmMain.Editera.Enabled = true;
                this.m_frmMain.SaveProject.Enabled = true;
                this.m_frmMain.SaveAs.Enabled = true;
                this.m_frmMain.SaveToparameterFileToolStripMenuItem.Enabled = true;
                this.m_frmMain.current.Enabled = true;
                this.m_frmMain.NewProject.Enabled = true;
                this.m_frmMain.Text = "Project: " + GlobalVariables.project_name + "    Simulation: " + GlobalVariables.Run_name;
                this.m_frmMain.mnuToolsChangeParameters.Enabled = true;
                GlobalVariables.Rainfall_file = MyProject.Application.Info.DirectoryPath + @"\" + GlobalVariables.Rainfall_file;
                GlobalVariables.Met_file = MyProject.Application.Info.DirectoryPath + @"\" + GlobalVariables.Met_file;
                GlobalVariables.TensionFile = MyProject.Application.Info.DirectoryPath + @"\" + GlobalVariables.TensionFile;
                GlobalVariables.Driving_file = MyProject.Application.Info.DirectoryPath + @"\" + GlobalVariables.Driving_file;
                CfrmMain frmMain = this.m_frmMain;
                frmMain.InitMyForms();
                frmMain.frmParameters.ShowAll();
                frmMain.OutputForm.Show();
                frmMain.OutputForm.Hide();
                frmMain.OutputForm.SaveOutputs();
                frmMain = null;
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

        private void frmNewProject_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.m_frmMain.Icon;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.Frame1 = new GroupBox();
            this.Frame3 = new GroupBox();
            this.Text2 = new TextBox();
            this.Text1 = new TextBox();
            this.Label4 = new Label();
            this.Command2 = new Button();
            this.Command1 = new Button();
            this.Frame1.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.SuspendLayout();
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.Frame3);
            this.Frame1.Controls.Add(this.Text1);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            Point point = new Point(8, 0);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            Size size = new Size(0x189, 0xd1);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 2;
            this.Frame1.TabStop = false;
            this.Frame3.BackColor = SystemColors.Control;
            this.Frame3.Controls.Add(this.Text2);
            this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Frame3.Location = point;
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = RightToLeft.No;
            size = new Size(0x179, 0x89);
            this.Frame3.Size = size;
            this.Frame3.TabIndex = 5;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Description";
            this.Text2.AcceptsReturn = true;
            this.Text2.BackColor = SystemColors.Window;
            this.Text2.Cursor = Cursors.IBeam;
            this.Text2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text2.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x10);
            this.Text2.Location = point;
            this.Text2.MaxLength = 0;
            this.Text2.Multiline = true;
            this.Text2.Name = "Text2";
            this.Text2.RightToLeft = RightToLeft.No;
            this.Text2.ScrollBars = ScrollBars.Both;
            size = new Size(0x161, 0x69);
            this.Text2.Size = size;
            this.Text2.TabIndex = 6;
            this.Text2.Text = "Enter a description of the project here.";
            this.Text2.WordWrap = false;
            this.Text1.AcceptsReturn = true;
            this.Text1.BackColor = SystemColors.Window;
            this.Text1.Cursor = Cursors.IBeam;
            this.Text1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text1.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0x20);
            this.Text1.Location = point;
            this.Text1.MaxLength = 50;
            this.Text1.Name = "Text1";
            this.Text1.RightToLeft = RightToLeft.No;
            size = new Size(0x161, 20);
            this.Text1.Size = size;
            this.Text1.TabIndex = 4;
            this.Text1.Text = "Name of project";
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x10);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Project name:";
            this.Command2.BackColor = SystemColors.Control;
            this.Command2.Cursor = Cursors.Default;
            this.Command2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command2.ForeColor = SystemColors.ControlText;
            point = new Point(0x150, 0xd8);
            this.Command2.Location = point;
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.Command2.Size = size;
            this.Command2.TabIndex = 1;
            this.Command2.Text = "&OK";
            this.Command2.UseVisualStyleBackColor = false;
            this.Command1.BackColor = SystemColors.Control;
            this.Command1.Cursor = Cursors.Default;
            this.Command1.DialogResult = DialogResult.Cancel;
            this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command1.ForeColor = SystemColors.ControlText;
            point = new Point(0x108, 0xd8);
            this.Command1.Location = point;
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.Command1.Size = size;
            this.Command1.TabIndex = 0;
            this.Command1.Text = "Cancel";
            this.Command1.UseVisualStyleBackColor = false;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.Command1;
            size = new Size(0x199, 0xf5);
            this.ClientSize = size;
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Command1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(0x7d, 0x4e);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewProject";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "New Project";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Frame3.ResumeLayout(false);
            this.Frame3.PerformLayout();
            this.ResumeLayout(false);
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

        public virtual GroupBox Frame3
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame3 = value;
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

        public virtual Label Label4
        {
            [DebuggerNonUserCode]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label4 = value;
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
    }
}

