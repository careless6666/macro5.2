namespace MACRO_52
{
    using ADODB;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class frmBatch : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("chkSimulations")]
        private CheckedListBox _chkSimulations;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        private CfrmMain frmMain;
        private bool IsInitializing;

        public frmBatch(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmBatch_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            this.frmMain = frm;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Recordset recordset = new RecordsetClass();
            recordset.Open("select * from RUn_ID", this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            recordset.MoveNext();
            int num2 = this.chkSimulations.Items.Count - 1;
            int index = 0;
            while (true)
            {
                int num3 = num2;
                if (index > num3)
                {
                    this.Close();
                    return;
                }
                bool flag = this.chkSimulations.GetItemCheckState(index) == CheckState.Checked;
                recordset[]["batch"][] = !flag ? 0 : -1;
                recordset.MoveNext();
                index++;
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

        private void frmBatch_Load(object sender, EventArgs e)
        {
            Recordset recordset = new RecordsetClass();
            if (!this.IsInitializing)
            {
                Recordset recordset2 = recordset;
                recordset2.Open("select * from Run_ID", this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset.MoveFirst();
                recordset2.MoveNext();
                while (true)
                {
                    bool flag = !recordset.EOF & !recordset.BOF;
                    if (!flag)
                    {
                        recordset.MoveFirst();
                        recordset.MoveNext();
                        int index = 0;
                        while (true)
                        {
                            flag = !recordset.EOF & !recordset.BOF;
                            if (!flag)
                            {
                                recordset2 = null;
                                break;
                            }
                            this.chkSimulations.SelectedIndex = index;
                            if (Operators.ConditionalCompareObjectEqual(recordset[]["batch"][], -1, false))
                            {
                                this.chkSimulations.SetItemCheckState(index, CheckState.Checked);
                            }
                            index++;
                            recordset.MoveNext();
                        }
                        break;
                    }
                    this.chkSimulations.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(recordset[]["Run_name"][], " ("), recordset2[]["R_ID"][]), ")"));
                    recordset.MoveNext();
                }
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.Frame1 = new GroupBox();
            this.chkSimulations = new CheckedListBox();
            this.Label2 = new Label();
            this.cmdOK = new Button();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.chkSimulations);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.cmdOK);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            Point point = new Point(0, 0);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            Size size = new Size(0x1aa, 0x108);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            this.chkSimulations.CheckOnClick = true;
            this.chkSimulations.FormattingEnabled = true;
            point = new Point(12, 0x24);
            this.chkSimulations.Location = point;
            this.chkSimulations.Name = "chkSimulations";
            size = new Size(320, 0xd6);
            this.chkSimulations.Size = size;
            this.chkSimulations.TabIndex = 7;
            this.Label2.AutoSize = true;
            point = new Point(10, 0x10);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            size = new Size(0xb3, 14);
            this.Label2.Size = size;
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Simulations (check to add to batch):";
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.ForeColor = SystemColors.ControlText;
            point = new Point(0x152, 0xe1);
            this.cmdOK.Location = point;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x19);
            this.cmdOK.Size = size;
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x1af, 0x114);
            this.ClientSize = size;
            this.Controls.Add(this.Frame1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBatch";
            this.RightToLeft = RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Setup batch file";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);
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

        public virtual GroupBox Frame1
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame1 = value;
        }

        internal virtual CheckedListBox chkSimulations
        {
            [DebuggerNonUserCode]
            get => 
                this._chkSimulations;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkSimulations = value;
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label2 = value;
        }
    }
}

