namespace MACRO_52
{
    using ADODB;
    using AxMSFlexGridLib;
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
    internal class frmSetWeights : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("txtVarNo")]
        private TextBox _txtVarNo;
        [AccessedThroughProperty("cmdSetWeightManual")]
        private Button _cmdSetWeightManual;
        [AccessedThroughProperty("txtWeight")]
        private TextBox _txtWeight;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("cmdSet")]
        private Button _cmdSet;
        [AccessedThroughProperty("txtFrom")]
        private TextBox _txtFrom;
        [AccessedThroughProperty("grdWeights")]
        private AxMSFlexGrid _grdWeights;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("lblToLayer")]
        private Label _lblToLayer;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("lblWeightSum")]
        private Label _lblWeightSum;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("txtFromLayer")]
        private GroupBox _txtFromLayer;
        private float[] m_TempWeights;
        private short m_RunID;
        private frmAggregateOutputs m_pMyForm;
        private CfrmMain frmMain;
        private bool IsInitializing;

        public frmSetWeights(ref CfrmMain frm)
        {
            base.Activated += new EventHandler(this.frmSetWeights_Activated);
            base.Load += new EventHandler(this.frmSetWeights_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            this.frmMain = frm;
            this.m_pMyForm = new frmAggregateOutputs(ref this.frmMain.frmSUFIMain, frm.frmSUFIMain.SUFIProjID);
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            this.m_pMyForm.StoreWeights(ref this.m_TempWeights);
            this.Close();
        }

        private void cmdSet_Click(object eventSender, EventArgs eventArgs)
        {
            this.SubWeightsFromLayerThickness();
        }

        private void cmdSetWeightManual_Click(object eventSender, EventArgs eventArgs)
        {
            if (!Versioned.IsNumeric(this.txtWeight.Text) | !Versioned.IsNumeric(this.txtVarNo.Text))
            {
                MiscFUncs.MsgBox_Renamed("Not a number", 0x30, "Not a number");
            }
            else
            {
                this.m_TempWeights[Conversions.ToInteger(this.txtVarNo.Text)] = Conversions.ToSingle(this.txtWeight.Text);
                this.DisplayWeights();
                this.lblWeightSum.Text = Support.Format(Conversions.ToString(this.ComputeWeightSum()), "#.###", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
            }
        }

        public float ComputeWeightSum()
        {
            short num3 = (short) Information.UBound(this.m_TempWeights, 1);
            short index = 1;
            while (true)
            {
                float num;
                short num4 = num3;
                if (index > num4)
                {
                    return num;
                }
                num += this.m_TempWeights[index];
                index = (short) (index + 1);
            }
        }

        public void DisplayWeights()
        {
            short num2 = (short) Information.UBound(this.m_TempWeights, 1);
            short row = 1;
            while (true)
            {
                short num3 = num2;
                if (row > num3)
                {
                    return;
                }
                this.grdWeights.set_TextMatrix(row, 1, Support.Format(Conversions.ToString(this.m_TempWeights[row]), "#.###", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                row = (short) (row + 1);
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

        private void frmSetWeights_Activated(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                this.lblToLayer.Text = Conversions.ToString((int) (((Conversions.ToShort(this.txtFrom.Text) + this.grdWeights.Rows) - 1) - 1));
            }
        }

        private void frmSetWeights_Load(object eventSender, EventArgs eventArgs)
        {
        }

        private void grdWeights_ClickEvent(object eventSender, EventArgs eventArgs)
        {
            if (this.grdWeights.Col > 0)
            {
                this.txtVarNo.Text = Conversions.ToString(this.grdWeights.Row);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmSetWeights));
            this.txtFromLayer = new GroupBox();
            this.txtVarNo = new TextBox();
            this.cmdSetWeightManual = new Button();
            this.txtWeight = new TextBox();
            this.cmdCancel = new Button();
            this.cmdOK = new Button();
            this.cmdSet = new Button();
            this.txtFrom = new TextBox();
            this.grdWeights = new AxMSFlexGrid();
            this.Label6 = new Label();
            this.Label5 = new Label();
            this.Label4 = new Label();
            this.lblToLayer = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.lblWeightSum = new Label();
            this.Label1 = new Label();
            this.txtFromLayer.SuspendLayout();
            this.grdWeights.BeginInit();
            this.SuspendLayout();
            this.txtFromLayer.BackColor = SystemColors.Control;
            this.txtFromLayer.Controls.Add(this.txtVarNo);
            this.txtFromLayer.Controls.Add(this.cmdSetWeightManual);
            this.txtFromLayer.Controls.Add(this.txtWeight);
            this.txtFromLayer.Controls.Add(this.cmdCancel);
            this.txtFromLayer.Controls.Add(this.cmdOK);
            this.txtFromLayer.Controls.Add(this.cmdSet);
            this.txtFromLayer.Controls.Add(this.txtFrom);
            this.txtFromLayer.Controls.Add(this.grdWeights);
            this.txtFromLayer.Controls.Add(this.Label6);
            this.txtFromLayer.Controls.Add(this.Label5);
            this.txtFromLayer.Controls.Add(this.Label4);
            this.txtFromLayer.Controls.Add(this.lblToLayer);
            this.txtFromLayer.Controls.Add(this.Label3);
            this.txtFromLayer.Controls.Add(this.Label2);
            this.txtFromLayer.Controls.Add(this.lblWeightSum);
            this.txtFromLayer.Controls.Add(this.Label1);
            this.txtFromLayer.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtFromLayer.ForeColor = SystemColors.ControlText;
            Point point = new Point(0, 0);
            this.txtFromLayer.Location = point;
            this.txtFromLayer.Name = "txtFromLayer";
            this.txtFromLayer.RightToLeft = RightToLeft.No;
            Size size = new Size(0x1e1, 0x109);
            this.txtFromLayer.Size = size;
            this.txtFromLayer.TabIndex = 0;
            this.txtFromLayer.TabStop = false;
            this.txtVarNo.AcceptsReturn = true;
            this.txtVarNo.BackColor = SystemColors.Window;
            this.txtVarNo.Cursor = Cursors.IBeam;
            this.txtVarNo.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtVarNo.ForeColor = SystemColors.WindowText;
            point = new Point(0xcf, 0x88);
            this.txtVarNo.Location = point;
            this.txtVarNo.MaxLength = 0;
            this.txtVarNo.Name = "txtVarNo";
            this.txtVarNo.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 20);
            this.txtVarNo.Size = size;
            this.txtVarNo.TabIndex = 15;
            this.txtVarNo.Text = "1";
            this.cmdSetWeightManual.BackColor = SystemColors.Control;
            this.cmdSetWeightManual.Cursor = Cursors.Default;
            this.cmdSetWeightManual.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdSetWeightManual.ForeColor = SystemColors.ControlText;
            point = new Point(0xf9, 0x88);
            this.cmdSetWeightManual.Location = point;
            this.cmdSetWeightManual.Name = "cmdSetWeightManual";
            this.cmdSetWeightManual.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x19);
            this.cmdSetWeightManual.Size = size;
            this.cmdSetWeightManual.TabIndex = 13;
            this.cmdSetWeightManual.Text = "&Update";
            this.cmdSetWeightManual.UseVisualStyleBackColor = false;
            this.txtWeight.AcceptsReturn = true;
            this.txtWeight.BackColor = SystemColors.Window;
            this.txtWeight.Cursor = Cursors.IBeam;
            this.txtWeight.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtWeight.ForeColor = SystemColors.WindowText;
            point = new Point(80, 0x88);
            this.txtWeight.Location = point;
            this.txtWeight.MaxLength = 0;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this.txtWeight.Size = size;
            this.txtWeight.TabIndex = 12;
            this.txtWeight.Text = "0";
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(0x150, 0xe8);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.ForeColor = SystemColors.ControlText;
            point = new Point(0x198, 0xe8);
            this.cmdOK.Location = point;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdOK.Size = size;
            this.cmdOK.TabIndex = 9;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdSet.BackColor = SystemColors.Control;
            this.cmdSet.Cursor = Cursors.Default;
            this.cmdSet.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdSet.ForeColor = SystemColors.ControlText;
            point = new Point(0xa8, 0xe8);
            this.cmdSet.Location = point;
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x19);
            this.cmdSet.Size = size;
            this.cmdSet.TabIndex = 8;
            this.cmdSet.Text = "&Set";
            this.cmdSet.UseVisualStyleBackColor = false;
            this.txtFrom.AcceptsReturn = true;
            this.txtFrom.BackColor = SystemColors.Window;
            this.txtFrom.Cursor = Cursors.IBeam;
            this.txtFrom.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtFrom.ForeColor = SystemColors.WindowText;
            point = new Point(0x88, 0xd8);
            this.txtFrom.Location = point;
            this.txtFrom.MaxLength = 0;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 20);
            this.txtFrom.Size = size;
            this.txtFrom.TabIndex = 5;
            this.txtFrom.Text = "1";
            point = new Point(8, 0x10);
            this.grdWeights.Location = point;
            this.grdWeights.Name = "grdWeights";
            this.grdWeights.OcxState = (AxHost.State) manager.GetObject("grdWeights.OcxState");
            size = new Size(0x1c9, 0x71);
            this.grdWeights.Size = size;
            this.grdWeights.TabIndex = 1;
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = Color.Red;
            point = new Point(8, 0xa8);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0x1d1, 0x21);
            this.Label6.Size = size;
            this.Label6.TabIndex = 0x10;
            this.Label6.Text = "Either enter the layer numbers in the text boxes below and press 'Set' to define weights according to layer thicknesses or set weights individually in the text boxes above.";
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(0x80, 0x88);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x20);
            this.Label5.Size = size;
            this.Label5.TabIndex = 14;
            this.Label5.Text = "for variable";
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x88);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x52, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 11;
            this.Label4.Text = "New weight:";
            this.lblToLayer.BackColor = SystemColors.Control;
            this.lblToLayer.BorderStyle = BorderStyle.Fixed3D;
            this.lblToLayer.Cursor = Cursors.Default;
            this.lblToLayer.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblToLayer.ForeColor = SystemColors.ControlText;
            point = new Point(0x88, 240);
            this.lblToLayer.Location = point;
            this.lblToLayer.Name = "lblToLayer";
            this.lblToLayer.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 0x11);
            this.lblToLayer.Size = size;
            this.lblToLayer.TabIndex = 7;
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(0x60, 240);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 6;
            this.Label3.Text = "to layer ";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xd0);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x29);
            this.Label2.Size = size;
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Use layer thickness to compute weight, from layer";
            this.lblWeightSum.BackColor = SystemColors.Window;
            this.lblWeightSum.BorderStyle = BorderStyle.FixedSingle;
            this.lblWeightSum.Cursor = Cursors.Default;
            this.lblWeightSum.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblWeightSum.ForeColor = SystemColors.WindowText;
            point = new Point(0x198, 0x88);
            this.lblWeightSum.Location = point;
            this.lblWeightSum.Name = "lblWeightSum";
            this.lblWeightSum.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x11);
            this.lblWeightSum.Size = size;
            this.lblWeightSum.TabIndex = 3;
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(0x178, 0x88);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Sum:";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            size = new Size(0x1e4, 0x110);
            this.ClientSize = size;
            this.Controls.Add(this.txtFromLayer);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(4, 0x17);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetWeights";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Set weights";
            this.txtFromLayer.ResumeLayout(false);
            this.txtFromLayer.PerformLayout();
            this.grdWeights.EndInit();
            this.ResumeLayout(false);
        }

        public void SetTempWeights(ref float[,] weights, ref short grp)
        {
            this.m_TempWeights = new float[2];
            short num2 = (short) Information.UBound(weights, 1);
            short index = 1;
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    return;
                }
                if (weights[grp, index + 1] != 0f)
                {
                    this.m_TempWeights = (float[]) Utils.CopyArray((Array) this.m_TempWeights, new float[index + 1]);
                    this.m_TempWeights[index] = weights[grp, index + 1];
                }
                index = (short) (index + 1);
            }
        }

        private void SubWeightsFromLayerThickness()
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = rs;
            recordset2.Open("select * from [Soil profile] where R_id=" + Conversions.ToString((int) this.m_RunID), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            int num4 = ReadSaveFunctions.RecordCount(ref rs);
            int num2 = 1;
            while (true)
            {
                float num3;
                int num6 = num4;
                if (num2 > num6)
                {
                    recordset2.MoveFirst();
                    short index = 1;
                    int num5 = ReadSaveFunctions.RecordCount(ref rs);
                    num2 = 1;
                    while (true)
                    {
                        num6 = num5;
                        if (num2 > num6)
                        {
                            recordset2 = null;
                            this.DisplayWeights();
                            return;
                        }
                        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(recordset2[]["layer_no"][], Conversions.ToShort(this.txtFrom.Text), false), Operators.CompareObjectLessEqual(recordset2[]["layer_no"][], Conversions.ToShort(this.lblToLayer.Text), false))))
                        {
                            this.m_TempWeights[index] = Conversions.ToSingle(Operators.DivideObject(recordset2[]["z"][], num3));
                            index = (short) (1 + index);
                        }
                        recordset2.MoveNext();
                        num2++;
                    }
                }
                if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(recordset2[]["layer_no"][], Conversions.ToShort(this.txtFrom.Text), false), Operators.CompareObjectLessEqual(recordset2[]["layer_no"][], Conversions.ToShort(this.lblToLayer.Text), false))))
                {
                    num3 = Conversions.ToSingle(Operators.AddObject(num3, recordset2[]["z"][]));
                }
                recordset2.MoveNext();
                num2++;
            }
        }

        private void txtFrom_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                this.lblToLayer.Text = (this.txtFrom.Text != "") ? Conversions.ToString((int) (((Conversions.ToShort(this.txtFrom.Text) + this.grdWeights.Rows) - 1) - 1)) : Conversions.ToString(1);
            }
        }

        public virtual TextBox txtVarNo
        {
            [DebuggerNonUserCode]
            get => 
                this._txtVarNo;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtVarNo = value;
        }

        public virtual Button cmdSetWeightManual
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdSetWeightManual;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdSetWeightManual_Click);
                if (!ReferenceEquals(this._cmdSetWeightManual, null))
                {
                    this._cmdSetWeightManual.Click -= handler;
                }
                this._cmdSetWeightManual = value;
                if (!ReferenceEquals(this._cmdSetWeightManual, null))
                {
                    this._cmdSetWeightManual.Click += handler;
                }
            }
        }

        public virtual TextBox txtWeight
        {
            [DebuggerNonUserCode]
            get => 
                this._txtWeight;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtWeight = value;
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

        public virtual Button cmdSet
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdSet;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdSet_Click);
                if (!ReferenceEquals(this._cmdSet, null))
                {
                    this._cmdSet.Click -= handler;
                }
                this._cmdSet = value;
                if (!ReferenceEquals(this._cmdSet, null))
                {
                    this._cmdSet.Click += handler;
                }
            }
        }

        public virtual TextBox txtFrom
        {
            [DebuggerNonUserCode]
            get => 
                this._txtFrom;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtFrom_TextChanged);
                if (!ReferenceEquals(this._txtFrom, null))
                {
                    this._txtFrom.TextChanged -= handler;
                }
                this._txtFrom = value;
                if (!ReferenceEquals(this._txtFrom, null))
                {
                    this._txtFrom.TextChanged += handler;
                }
            }
        }

        public virtual AxMSFlexGrid grdWeights
        {
            [DebuggerNonUserCode]
            get => 
                this._grdWeights;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.grdWeights_ClickEvent);
                if (!ReferenceEquals(this._grdWeights, null))
                {
                    this._grdWeights.ClickEvent -= handler;
                }
                this._grdWeights = value;
                if (!ReferenceEquals(this._grdWeights, null))
                {
                    this._grdWeights.ClickEvent += handler;
                }
            }
        }

        public virtual Label Label6
        {
            [DebuggerNonUserCode]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label6 = value;
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

        public virtual Label lblToLayer
        {
            [DebuggerNonUserCode]
            get => 
                this._lblToLayer;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblToLayer = value;
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

        public virtual Label lblWeightSum
        {
            [DebuggerNonUserCode]
            get => 
                this._lblWeightSum;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblWeightSum = value;
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

        public virtual GroupBox txtFromLayer
        {
            [DebuggerNonUserCode]
            get => 
                this._txtFromLayer;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtFromLayer = value;
        }

        public object RunID
        {
            set => 
                this.m_RunID = Conversions.ToShort(value);
        }

        public object pForm
        {
            set => 
                this.m_pMyForm = (frmAggregateOutputs) value;
        }
    }
}

