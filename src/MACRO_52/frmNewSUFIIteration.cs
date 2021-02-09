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
    internal class frmNewSUFIIteration : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("dbSUFIIterations")]
        private ADODC _dbSUFIIterations;
        [AccessedThroughProperty("txtPercent")]
        private TextBox _txtPercent;
        [AccessedThroughProperty("_optSampling_1")]
        private RadioButton __optSampling_1;
        [AccessedThroughProperty("_optSampling_0")]
        private RadioButton __optSampling_0;
        [AccessedThroughProperty("Dir1")]
        private DirListBox _Dir1;
        [AccessedThroughProperty("Drive1")]
        private DriveListBox _Drive1;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("lblTotSims")]
        private Label _lblTotSims;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("txtBox")]
        private TextBox _txtBox;
        [AccessedThroughProperty("grdParameters")]
        private AxMSFlexGrid _grdParameters;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("lblProjectName")]
        private Label _lblProjectName;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("lblIterationNumber")]
        private Label _lblIterationNumber;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("fraMain")]
        private GroupBox _fraMain;
        [AccessedThroughProperty("optSampling")]
        private RadioButtonArray _optSampling;
        private int itid;
        private bool m_bEdit;
        private int m_IterationID;
        private int m_ProjectID;
        private Collection m_Combinations;
        private bool m_IsEditing;
        private CfrmMain frmMain;

        [DebuggerNonUserCode]
        public frmNewSUFIIteration()
        {
            base.Load += new EventHandler(this.frmNewSUFIIteration_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.m_Combinations = new Collection();
            this.InitializeComponent();
        }

        public frmNewSUFIIteration(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmNewSUFIIteration_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.m_Combinations = new Collection();
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            this.Cursor = Cursors.WaitCursor;
            if (this.m_bEdit)
            {
                this.DeleteIteration();
            }
            if (!this.SaveIteration())
            {
                this.Cursor = Cursors.Default;
            }
            else
            {
                this.RandomSampling();
                if (!this.SaveStrataCombinations())
                {
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    this.Hide();
                    this.frmMain.frmSUFIMain.Refresh();
                }
            }
        }

        public int ComputeNumberOfSims()
        {
            AxMSFlexGrid grdParameters = this.grdParameters;
            int num = 1;
            short num3 = (short) (grdParameters.Rows - 1);
            short row = 1;
            while (true)
            {
                short num4 = num3;
                if (row > num4)
                {
                    grdParameters = null;
                    return num;
                }
                if (!Versioned.IsNumeric(grdParameters.get_TextMatrix(row, 3)))
                {
                    grdParameters.set_TextMatrix(row, 3, Conversions.ToString(1));
                }
                num *= Conversions.ToShort(grdParameters.get_TextMatrix(row, 3));
                row = (short) (row + 1);
            }
        }

        private void DeleteIteration()
        {
            this.frmMain.frmSUFIMain.DeleteIteration(ref this.m_ProjectID, ref this.m_IterationID, ref false);
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

        private void Drive1_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void frmNewSUFIIteration_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
            this.dbSUFIIterations.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.SUFIDatabaseName + ";Persist Security Info=False";
            this.dbSUFIIterations.RecordSource = "select * from SUFIIterations";
            this.dbSUFIIterations.Refresh();
            this.SetupTable();
            this.lblTotSims.Text = Conversions.ToString(this.ComputeNumberOfSims());
        }

        private void grdParameters_ClickEvent(object eventSender, EventArgs eventArgs)
        {
            AxMSFlexGrid grdParameters = this.grdParameters;
            if ((grdParameters.MouseRow > (grdParameters.FixedRows - 1)) & (grdParameters.MouseCol > (grdParameters.FixedCols - 1)))
            {
                this.txtBox.Height = (int) Math.Round(Support.TwipsToPixelsY((double) grdParameters.CellHeight));
                this.txtBox.Left = (int) Math.Round(Support.TwipsToPixelsX(grdParameters.CellLeft + Support.PixelsToTwipsX((double) grdParameters.Left)));
                this.txtBox.Top = (int) Math.Round(Support.TwipsToPixelsY(grdParameters.CellTop + Support.PixelsToTwipsY((double) grdParameters.Top)));
                this.txtBox.Width = (int) Math.Round(Support.TwipsToPixelsX((double) grdParameters.CellWidth));
                this.ShowTextBox();
            }
            grdParameters = null;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmNewSUFIIteration));
            this.fraMain = new GroupBox();
            this.dbSUFIIterations = new ADODC();
            this.Frame2 = new GroupBox();
            this.txtPercent = new TextBox();
            this._optSampling_1 = new RadioButton();
            this._optSampling_0 = new RadioButton();
            this.Dir1 = new DirListBox();
            this.Drive1 = new DriveListBox();
            this.Label4 = new Label();
            this.Label5 = new Label();
            this.lblTotSims = new Label();
            this.Label3 = new Label();
            this.cmdCancel = new Button();
            this.cmdOK = new Button();
            this.Frame1 = new GroupBox();
            this.txtBox = new TextBox();
            this.grdParameters = new AxMSFlexGrid();
            this.lblProjectName = new Label();
            this.Label2 = new Label();
            this.lblIterationNumber = new Label();
            this.Label1 = new Label();
            this.optSampling = new RadioButtonArray(this.components);
            this.fraMain.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.grdParameters.BeginInit();
            ((ISupportInitialize) this.optSampling).BeginInit();
            this.SuspendLayout();
            this.fraMain.BackColor = SystemColors.Control;
            this.fraMain.Controls.Add(this.dbSUFIIterations);
            this.fraMain.Controls.Add(this.Frame2);
            this.fraMain.Controls.Add(this.cmdCancel);
            this.fraMain.Controls.Add(this.cmdOK);
            this.fraMain.Controls.Add(this.Frame1);
            this.fraMain.Controls.Add(this.lblProjectName);
            this.fraMain.Controls.Add(this.Label2);
            this.fraMain.Controls.Add(this.lblIterationNumber);
            this.fraMain.Controls.Add(this.Label1);
            this.fraMain.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraMain.ForeColor = SystemColors.ControlText;
            Point point = new Point(0, 0);
            this.fraMain.Location = point;
            this.fraMain.Name = "fraMain";
            this.fraMain.RightToLeft = RightToLeft.No;
            Size size = new Size(0x2b5, 0x121);
            this.fraMain.Size = size;
            this.fraMain.TabIndex = 0;
            this.fraMain.TabStop = false;
            this.dbSUFIIterations.BackColor = SystemColors.Window;
            this.dbSUFIIterations.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.dbSUFIIterations.CommandTimeout = 0;
            this.dbSUFIIterations.CommandType = CommandTypeEnum.adCmdUnknown;
            this.dbSUFIIterations.ConnectionString = null;
            this.dbSUFIIterations.CursorLocation = CursorLocationEnum.adUseClient;
            this.dbSUFIIterations.CursorType = CursorTypeEnum.adOpenStatic;
            this.dbSUFIIterations.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.dbSUFIIterations.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dbSUFIIterations.ForeColor = SystemColors.WindowText;
            point = new Point(320, 240);
            this.dbSUFIIterations.Location = point;
            this.dbSUFIIterations.LockType = LockTypeEnum.adLockPessimistic;
            this.dbSUFIIterations.Mode = ConnectModeEnum.adModeUnknown;
            this.dbSUFIIterations.Name = "dbSUFIIterations";
            this.dbSUFIIterations.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x69, 0x16);
            this.dbSUFIIterations.Size = size;
            this.dbSUFIIterations.TabIndex = 0;
            this.dbSUFIIterations.Text = "Adodc1";
            this.dbSUFIIterations.Visible = false;
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this.txtPercent);
            this.Frame2.Controls.Add(this._optSampling_1);
            this.Frame2.Controls.Add(this._optSampling_0);
            this.Frame2.Controls.Add(this.Dir1);
            this.Frame2.Controls.Add(this.Drive1);
            this.Frame2.Controls.Add(this.Label4);
            this.Frame2.Controls.Add(this.Label5);
            this.Frame2.Controls.Add(this.lblTotSims);
            this.Frame2.Controls.Add(this.Label3);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 40);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0x121, 0xf1);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 10;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Simulations";
            this.txtPercent.AcceptsReturn = true;
            this.txtPercent.BackColor = SystemColors.Window;
            this.txtPercent.Cursor = Cursors.IBeam;
            this.txtPercent.Enabled = false;
            this.txtPercent.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPercent.ForeColor = SystemColors.WindowText;
            point = new Point(120, 80);
            this.txtPercent.Location = point;
            this.txtPercent.MaxLength = 0;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this.txtPercent.Size = size;
            this.txtPercent.TabIndex = 0x12;
            this._optSampling_1.BackColor = SystemColors.Control;
            this._optSampling_1.Cursor = Cursors.Default;
            this._optSampling_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optSampling_1.ForeColor = SystemColors.ControlText;
            this.optSampling.SetIndex(this._optSampling_1, 1);
            point = new Point(8, 80);
            this._optSampling_1.Location = point;
            this._optSampling_1.Name = "_optSampling_1";
            this._optSampling_1.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 0x11);
            this._optSampling_1.Size = size;
            this._optSampling_1.TabIndex = 0x11;
            this._optSampling_1.TabStop = true;
            this._optSampling_1.Text = "Random sampling:";
            this._optSampling_1.UseVisualStyleBackColor = false;
            this._optSampling_0.BackColor = SystemColors.Control;
            this._optSampling_0.Checked = true;
            this._optSampling_0.Cursor = Cursors.Default;
            this._optSampling_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optSampling_0.ForeColor = SystemColors.ControlText;
            this.optSampling.SetIndex(this._optSampling_0, 0);
            point = new Point(8, 0x38);
            this._optSampling_0.Location = point;
            this._optSampling_0.Name = "_optSampling_0";
            this._optSampling_0.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x11);
            this._optSampling_0.Size = size;
            this._optSampling_0.TabIndex = 0x10;
            this._optSampling_0.TabStop = true;
            this._optSampling_0.Text = "Exhaustive sampling";
            this._optSampling_0.UseVisualStyleBackColor = false;
            this.Dir1.BackColor = SystemColors.Window;
            this.Dir1.Cursor = Cursors.Default;
            this.Dir1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Dir1.ForeColor = SystemColors.WindowText;
            this.Dir1.FormattingEnabled = true;
            this.Dir1.IntegralHeight = false;
            point = new Point(120, 0x88);
            this.Dir1.Location = point;
            this.Dir1.Name = "Dir1";
            size = new Size(0x99, 0x60);
            this.Dir1.Size = size;
            this.Dir1.TabIndex = 15;
            this.Drive1.BackColor = SystemColors.Window;
            this.Drive1.Cursor = Cursors.Default;
            this.Drive1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Drive1.ForeColor = SystemColors.WindowText;
            this.Drive1.FormattingEnabled = true;
            point = new Point(8, 0x88);
            this.Drive1.Location = point;
            this.Drive1.Name = "Drive1";
            size = new Size(0x61, 0x15);
            this.Drive1.Size = size;
            this.Drive1.TabIndex = 14;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(160, 0x52);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 0x13;
            this.Label4.Text = "%";
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 120);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Output file location:";
            this.lblTotSims.BackColor = SystemColors.Window;
            this.lblTotSims.BorderStyle = BorderStyle.FixedSingle;
            this.lblTotSims.Cursor = Cursors.Default;
            this.lblTotSims.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTotSims.ForeColor = SystemColors.WindowText;
            point = new Point(0xa8, 0x18);
            this.lblTotSims.Location = point;
            this.lblTotSims.Name = "lblTotSims";
            this.lblTotSims.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.lblTotSims.Size = size;
            this.lblTotSims.TabIndex = 12;
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Total number of simulations:";
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(550, 0x100);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.ForeColor = SystemColors.ControlText;
            point = new Point(0x26e, 0x100);
            this.cmdOK.Location = point;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdOK.Size = size;
            this.cmdOK.TabIndex = 7;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.txtBox);
            this.Frame1.Controls.Add(this.grdParameters);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(0x130, 40);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x17f, 0xc9);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 5;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Parameters";
            this.txtBox.AcceptsReturn = true;
            this.txtBox.BackColor = SystemColors.Window;
            this.txtBox.Cursor = Cursors.IBeam;
            this.txtBox.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBox.ForeColor = SystemColors.WindowText;
            point = new Point(0x48, 40);
            this.txtBox.Location = point;
            this.txtBox.MaxLength = 0;
            this.txtBox.Name = "txtBox";
            this.txtBox.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this.txtBox.Size = size;
            this.txtBox.TabIndex = 9;
            this.txtBox.Visible = false;
            point = new Point(8, 0x18);
            this.grdParameters.Location = point;
            this.grdParameters.Name = "grdParameters";
            this.grdParameters.OcxState = (AxHost.State) manager.GetObject("grdParameters.OcxState");
            size = new Size(0x171, 0xa9);
            this.grdParameters.Size = size;
            this.grdParameters.TabIndex = 6;
            this.lblProjectName.BackColor = SystemColors.Control;
            this.lblProjectName.Cursor = Cursors.Default;
            this.lblProjectName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblProjectName.ForeColor = SystemColors.ControlText;
            point = new Point(0xb8, 0x10);
            this.lblProjectName.Location = point;
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.RightToLeft = RightToLeft.No;
            size = new Size(0x121, 0x11);
            this.lblProjectName.Size = size;
            this.lblProjectName.TabIndex = 4;
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(0x88, 0x10);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 3;
            this.Label2.Text = "in project";
            this.lblIterationNumber.BackColor = SystemColors.Window;
            this.lblIterationNumber.BorderStyle = BorderStyle.FixedSingle;
            this.lblIterationNumber.Cursor = Cursors.Default;
            this.lblIterationNumber.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblIterationNumber.ForeColor = SystemColors.WindowText;
            point = new Point(0x60, 0x10);
            this.lblIterationNumber.Location = point;
            this.lblIterationNumber.Name = "lblIterationNumber";
            this.lblIterationNumber.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 0x11);
            this.lblIterationNumber.Size = size;
            this.lblIterationNumber.TabIndex = 2;
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Iteration number";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            size = new Size(0x2c1, 0x129);
            this.ClientSize = size;
            this.Controls.Add(this.fraMain);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewSUFIIteration";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "New SUFI iteration";
            this.fraMain.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.grdParameters.EndInit();
            ((ISupportInitialize) this.optSampling).EndInit();
            this.ResumeLayout(false);
        }

        private void optSampling_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                this.txtPercent.Enabled = this.optSampling.GetIndex((RadioButton) eventSender) == 1;
            }
        }

        private void RandomSampling()
        {
            // Invalid method body.
        }

        public bool SaveIteration()
        {
            // Invalid method body.
        }

        public bool SaveStrataCombinations()
        {
            // Invalid method body.
        }

        public void SetupTable()
        {
            if (!this.m_bEdit)
            {
                AxMSFlexGrid grdParameters = this.grdParameters;
                CfrmSUFIMain frmSUFIMain = this.frmMain.frmSUFIMain;
                Recordset dbParameters = frmSUFIMain.dbParameters;
                this.frmMain.frmSUFIMain.OpenCurrentParameters(ref dbParameters);
                frmSUFIMain.dbParameters = dbParameters;
                grdParameters.Cols = 4;
                frmSUFIMain = this.frmMain.frmSUFIMain;
                dbParameters = frmSUFIMain.dbParameters;
                frmSUFIMain.dbParameters = dbParameters;
                grdParameters.Rows = ReadSaveFunctions.RecordCount(ref dbParameters) + 1;
                grdParameters.FixedCols = 1;
                grdParameters.FixedRows = 1;
                grdParameters.set_TextMatrix(0, 0, "Name:");
                grdParameters.set_TextMatrix(0, 1, "Min.:");
                grdParameters.set_TextMatrix(0, 2, "Max.:");
                grdParameters.set_TextMatrix(0, 3, "Strata:");
                grdParameters.Row = 0;
                this.frmMain.frmSUFIMain.dbParameters.MoveFirst();
                while (true)
                {
                    if (this.frmMain.frmSUFIMain.dbParameters.EOF)
                    {
                        this.frmMain.frmSUFIMain.dbParameters.Close();
                        grdParameters = null;
                        break;
                    }
                    grdParameters.Row++;
                    grdParameters.set_TextMatrix(grdParameters.Row, 0, Conversions.ToString(this.frmMain.frmSUFIMain.dbParameters[]["Name"][]));
                    grdParameters.set_TextMatrix(grdParameters.Row, 1, Conversions.ToString(0));
                    grdParameters.set_TextMatrix(grdParameters.Row, 2, Conversions.ToString(0));
                    grdParameters.set_TextMatrix(grdParameters.Row, 3, Conversions.ToString(1));
                    this.frmMain.frmSUFIMain.dbParameters.MoveNext();
                }
            }
        }

        public void SetupTable2()
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = new RecordsetClass();
            rs.Open("select * from SUFIParameters where SUFIProjectID=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentProjID), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            AxMSFlexGrid grdParameters = this.grdParameters;
            grdParameters.Cols = 4;
            grdParameters.Rows = ReadSaveFunctions.RecordCount(ref rs) + 1;
            grdParameters.FixedCols = 1;
            grdParameters.FixedRows = 1;
            grdParameters.set_TextMatrix(0, 0, "Name:");
            grdParameters.set_TextMatrix(0, 1, "Min.:");
            grdParameters.set_TextMatrix(0, 2, "Max.:");
            grdParameters.set_TextMatrix(0, 3, "Strata:");
            grdParameters.Row = 0;
            rs.MoveFirst();
            while (true)
            {
                if (rs.EOF)
                {
                    rs.Close();
                    grdParameters = null;
                    return;
                }
                recordset2.Open(Operators.ConcatenateObject("select * from SUFIParameterValues where IterationID=" + Conversions.ToString(this.m_IterationID) + " and ParameterID=", rs[]["ParameterID"][]), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                grdParameters.Row++;
                grdParameters.set_TextMatrix(grdParameters.Row, 0, Conversions.ToString(rs[]["Name"][]));
                grdParameters.set_TextMatrix(grdParameters.Row, 1, Conversions.ToString(recordset2[]["Min"][]));
                grdParameters.set_TextMatrix(grdParameters.Row, 2, Conversions.ToString(recordset2[]["Max"][]));
                grdParameters.set_TextMatrix(grdParameters.Row, 3, Conversions.ToString(recordset2[]["NoStrata"][]));
                recordset2.Close();
                rs.MoveNext();
            }
        }

        private void ShowTextBox()
        {
            AxMSFlexGrid grdParameters = this.grdParameters;
            if ((grdParameters.Col >= 0) & (grdParameters.Row >= 0))
            {
                this.txtBox.SetBounds((int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) grdParameters.Left) + grdParameters.get_ColPos(grdParameters.Col))), (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) grdParameters.Top) + grdParameters.get_RowPos(grdParameters.Row))), 0, 0, BoundsSpecified.Location);
                this.txtBox.Text = grdParameters.Text;
                this.txtBox.Visible = true;
                this.txtBox.Focus();
                this.txtBox.SelectionLength = Strings.Len(this.txtBox.Text);
            }
            grdParameters = null;
        }

        private void txtBox_KeyPress(object eventSender, KeyPressEventArgs eventArgs)
        {
            short charCode = (short) Strings.Asc(eventArgs.KeyChar);
            if (charCode == 13)
            {
                this.lblTotSims.Text = Conversions.ToString(this.ComputeNumberOfSims());
                this.txtBox.Visible = false;
            }
            else if (charCode == 0x1b)
            {
                this.txtBox.Visible = false;
            }
            eventArgs.KeyChar = Strings.Chr(charCode);
            if (charCode == 0)
            {
                eventArgs.Handled = true;
            }
        }

        private void txtBox_Leave(object eventSender, EventArgs eventArgs)
        {
            this.lblTotSims.Text = Conversions.ToString(this.ComputeNumberOfSims());
            this.txtBox.Visible = false;
        }

        private void txtBox_TextChanged(object eventSender, EventArgs eventArgs)
        {
            this.grdParameters.Text = this.txtBox.Text;
        }

        public virtual ADODC dbSUFIIterations
        {
            [DebuggerNonUserCode]
            get => 
                this._dbSUFIIterations;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbSUFIIterations = value;
        }

        public virtual TextBox txtPercent
        {
            [DebuggerNonUserCode]
            get => 
                this._txtPercent;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtPercent = value;
        }

        public virtual RadioButton _optSampling_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optSampling_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optSampling_1 = value;
        }

        public virtual RadioButton _optSampling_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optSampling_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optSampling_0 = value;
        }

        public virtual DirListBox Dir1
        {
            [DebuggerNonUserCode]
            get => 
                this._Dir1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Dir1 = value;
        }

        public virtual DriveListBox Drive1
        {
            [DebuggerNonUserCode]
            get => 
                this._Drive1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Drive1_SelectedIndexChanged);
                if (!ReferenceEquals(this._Drive1, null))
                {
                    this._Drive1.SelectedIndexChanged -= handler;
                }
                this._Drive1 = value;
                if (!ReferenceEquals(this._Drive1, null))
                {
                    this._Drive1.SelectedIndexChanged += handler;
                }
            }
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

        public virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
        }

        public virtual Label lblTotSims
        {
            [DebuggerNonUserCode]
            get => 
                this._lblTotSims;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblTotSims = value;
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

        public virtual GroupBox Frame2
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame2 = value;
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

        public virtual TextBox txtBox
        {
            [DebuggerNonUserCode]
            get => 
                this._txtBox;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.txtBox_KeyPress);
                EventHandler handler2 = new EventHandler(this.txtBox_TextChanged);
                EventHandler handler3 = new EventHandler(this.txtBox_Leave);
                if (!ReferenceEquals(this._txtBox, null))
                {
                    this._txtBox.KeyPress -= handler;
                    this._txtBox.TextChanged -= handler2;
                    this._txtBox.Leave -= handler3;
                }
                this._txtBox = value;
                if (!ReferenceEquals(this._txtBox, null))
                {
                    this._txtBox.KeyPress += handler;
                    this._txtBox.TextChanged += handler2;
                    this._txtBox.Leave += handler3;
                }
            }
        }

        public virtual AxMSFlexGrid grdParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._grdParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.grdParameters_ClickEvent);
                if (!ReferenceEquals(this._grdParameters, null))
                {
                    this._grdParameters.ClickEvent -= handler;
                }
                this._grdParameters = value;
                if (!ReferenceEquals(this._grdParameters, null))
                {
                    this._grdParameters.ClickEvent += handler;
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

        public virtual Label lblProjectName
        {
            [DebuggerNonUserCode]
            get => 
                this._lblProjectName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblProjectName = value;
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

        public virtual Label lblIterationNumber
        {
            [DebuggerNonUserCode]
            get => 
                this._lblIterationNumber;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblIterationNumber = value;
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

        public virtual GroupBox fraMain
        {
            [DebuggerNonUserCode]
            get => 
                this._fraMain;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraMain = value;
        }

        public virtual RadioButtonArray optSampling
        {
            [DebuggerNonUserCode]
            get => 
                this._optSampling;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optSampling_CheckedChanged);
                if (!ReferenceEquals(this._optSampling, null))
                {
                    this._optSampling.CheckedChanged -= handler;
                }
                this._optSampling = value;
                if (!ReferenceEquals(this._optSampling, null))
                {
                    this._optSampling.CheckedChanged += handler;
                }
            }
        }

        public object bEdit
        {
            set => 
                this.m_bEdit = Conversions.ToBoolean(value);
        }

        public object IterationID
        {
            set => 
                this.m_IterationID = Conversions.ToInteger(value);
        }

        public object ProjectID
        {
            set => 
                this.m_ProjectID = Conversions.ToInteger(value);
        }
    }
}

