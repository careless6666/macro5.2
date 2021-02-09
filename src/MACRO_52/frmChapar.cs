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
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class frmChapar : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("cmdClearAll")]
        private Button _cmdClearAll;
        [AccessedThroughProperty("_optHowToChange_1")]
        private RadioButton __optHowToChange_1;
        [AccessedThroughProperty("grdParameters")]
        private AxMSFlexGrid _grdParameters;
        [AccessedThroughProperty("cmdAdd")]
        private Button _cmdAdd;
        [AccessedThroughProperty("dbProjectDatabase")]
        private ADODC _dbProjectDatabase;
        [AccessedThroughProperty("dbParameters")]
        private ADODC _dbParameters;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("_optHowToChange_0")]
        private RadioButton __optHowToChange_0;
        [AccessedThroughProperty("cmbParameters")]
        private ComboBox _cmbParameters;
        [AccessedThroughProperty("txtNewValue")]
        private TextBox _txtNewValue;
        [AccessedThroughProperty("chkAllHorizons")]
        private CheckBox _chkAllHorizons;
        [AccessedThroughProperty("lblHelp")]
        private Label _lblHelp;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("optHowToChange")]
        private RadioButtonArray _optHowToChange;
        [AccessedThroughProperty("udHorizon")]
        private NumericUpDown _udHorizon;
        [AccessedThroughProperty("dtChangeDate")]
        private DateTimePicker _dtChangeDate;
        private CfrmMain frmMain;

        public frmChapar(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmChapar_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void cmbParameters_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            Recordset recordset = new RecordsetClass();
            if (Strings.Len(this.cmbParameters.Text) != 0)
            {
                Recordset recordset2 = recordset;
                recordset2.Open("select * from ParameterInfo", this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset2.Find("ParameterName='" + this.cmbParameters.Text + "'", 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                if (Operators.ConditionalCompareObjectEqual(recordset2[]["Length"][], (short) 60, false))
                {
                    this.udHorizon.Value = 1M;
                    this.udHorizon.Enabled = true;
                    this.udHorizon.Minimum = 1M;
                }
                recordset2.Close();
                recordset2 = null;
            }
            this.lblHelp.Text = "";
            HelpFunctions.HELP_Crop1(ref this.cmbParameters.Text, ref this.lblHelp);
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.Help_IBcond(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.HELP_Irr(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.Help_Management(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.HELP_Numerical(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.HELP_Output(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.Help_Physical(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.HELP_Site(ref 10, ref this.lblHelp, ref this.cmbParameters.Text);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.Help_Solute(ref this.cmbParameters.Text, ref this.lblHelp);
            }
        }

        private void cmbParameters_TextChanged(object eventSender, EventArgs eventArgs)
        {
            Recordset recordset = new RecordsetClass();
            if (Strings.Len(this.cmbParameters.Text) != 0)
            {
                Recordset recordset2 = recordset;
                recordset2.Open("select * from ParameterInfo", this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset2.Find("ParameterName='" + this.cmbParameters.Text + "'", 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                if (Operators.ConditionalCompareObjectEqual(recordset2[]["Length"][], (short) 60, false))
                {
                    this.udHorizon.Value = 1M;
                    this.udHorizon.Enabled = true;
                    this.udHorizon.Minimum = 1M;
                }
                recordset2.Close();
                recordset2 = null;
            }
            this.lblHelp.Text = "";
            HelpFunctions.HELP_Crop1(ref this.cmbParameters.Text, ref this.lblHelp);
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.Help_IBcond(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.HELP_Irr(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.Help_Management(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.HELP_Numerical(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.HELP_Output(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.Help_Physical(ref this.cmbParameters.Text, ref this.lblHelp);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.HELP_Site(ref 10, ref this.lblHelp, ref this.cmbParameters.Text);
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                HelpFunctions.Help_Solute(ref this.cmbParameters.Text, ref this.lblHelp);
            }
        }

        private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void cmdClearAll_Click(object eventSender, EventArgs eventArgs)
        {
            this.grdParameters.Rows = 1;
        }

        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.grdParameters.Rows == 1)
            {
                GlobalVariables.Chapar = new string[1, 4];
                GlobalVariables.sw_chapar = MACROConstants.Switch.NoMetabolite;
            }
            else
            {
                GlobalVariables.Chapar = new string[(this.grdParameters.Rows - 1) + 1, 4];
                GlobalVariables.sw_chapar = MACROConstants.Switch.BareSoil;
            }
            short num2 = (short) (this.grdParameters.Rows - 1);
            short row = 1;
            while (true)
            {
                short num3 = num2;
                if (row > num3)
                {
                    this.Close();
                    return;
                }
                GlobalVariables.Chapar[row, 1] = this.grdParameters.get_TextMatrix(row, 0);
                GlobalVariables.Chapar[row, 2] = this.grdParameters.get_TextMatrix(row, 1);
                GlobalVariables.Chapar[row, 3] = this.grdParameters.get_TextMatrix(row, 2);
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

        private void frmChapar_Load(object eventSender, EventArgs eventArgs)
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = rs;
            recordset2.Open("select * from [ParameterInfoSUFI] order by [ParameterName]", this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            recordset2.MoveFirst();
            if (ReadSaveFunctions.RecordCount(ref rs) > 0)
            {
                while (true)
                {
                    if (recordset2.EOF)
                    {
                        break;
                    }
                    bool flag2 = !Information.IsDBNull(recordset2[]["Table"][]) & !Information.IsDBNull(recordset2[]["Table"][]);
                    if (flag2 && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(recordset2[]["Table"][], "Crop", false), Operators.CompareObjectNotEqual(recordset2[]["Table"][], "Excluded", false))))
                    {
                        this.cmbParameters.Items.Add(recordset2[]["ParameterName"][]);
                    }
                    recordset2.MoveNext();
                }
            }
            recordset2.Close();
            recordset2 = null;
            this.cmbParameters.SelectedIndex = 0;
            this.dbProjectDatabase.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
            rs.Open("select r_id from Properties where r_id=" + Conversions.ToString(GlobalVariables.RunIDno), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.udHorizon.Maximum = new decimal(ReadSaveFunctions.RecordCount(ref rs));
            rs.Close();
            this.dtChangeDate.Value = this.frmMain.frmSetup.dtStartDate.Value;
            this.dtChangeDate.MinDate = this.frmMain.frmSetup.dtStartDate.Value;
            this.dtChangeDate.MaxDate = this.frmMain.frmSetup.dtEndDate.Value;
            this.SetupTable();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmChapar));
            this.cmdClearAll = new Button();
            this._optHowToChange_1 = new RadioButton();
            this.grdParameters = new AxMSFlexGrid();
            this.cmdAdd = new Button();
            this.dbProjectDatabase = new ADODC();
            this.dbParameters = new ADODC();
            this.cmdCancel = new Button();
            this.cmdOK = new Button();
            this.Frame1 = new GroupBox();
            this.dtChangeDate = new DateTimePicker();
            this.udHorizon = new NumericUpDown();
            this._optHowToChange_0 = new RadioButton();
            this.cmbParameters = new ComboBox();
            this.txtNewValue = new TextBox();
            this.chkAllHorizons = new CheckBox();
            this.lblHelp = new Label();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.Label7 = new Label();
            this.optHowToChange = new RadioButtonArray(this.components);
            this.grdParameters.BeginInit();
            this.Frame1.SuspendLayout();
            this.udHorizon.BeginInit();
            ((ISupportInitialize) this.optHowToChange).BeginInit();
            this.SuspendLayout();
            this.cmdClearAll.BackColor = SystemColors.Control;
            this.cmdClearAll.Cursor = Cursors.Default;
            this.cmdClearAll.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdClearAll.ForeColor = SystemColors.ControlText;
            Point point = new Point(0x180, 0x160);
            this.cmdClearAll.Location = point;
            this.cmdClearAll.Name = "cmdClearAll";
            this.cmdClearAll.RightToLeft = RightToLeft.No;
            Size size = new Size(0x51, 0x21);
            this.cmdClearAll.Size = size;
            this.cmdClearAll.TabIndex = 0x12;
            this.cmdClearAll.Text = "&Clear all";
            this.cmdClearAll.UseVisualStyleBackColor = false;
            this._optHowToChange_1.BackColor = SystemColors.Control;
            this._optHowToChange_1.Cursor = Cursors.Default;
            this._optHowToChange_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optHowToChange_1.ForeColor = SystemColors.ControlText;
            this.optHowToChange.SetIndex(this._optHowToChange_1, 1);
            point = new Point(0x18, 0x88);
            this._optHowToChange_1.Location = point;
            this._optHowToChange_1.Name = "_optHowToChange_1";
            this._optHowToChange_1.RightToLeft = RightToLeft.No;
            size = new Size(0x1b9, 0x31);
            this._optHowToChange_1.Size = size;
            this._optHowToChange_1.TabIndex = 0x11;
            this._optHowToChange_1.TabStop = true;
            this._optHowToChange_1.Text = "Read time-series from file (tab separated file with dates in the first column, and parameter values in the second column. Date format: YYYY:MM:DD hh:mm)";
            this._optHowToChange_1.UseVisualStyleBackColor = false;
            point = new Point(0x10, 240);
            this.grdParameters.Location = point;
            this.grdParameters.Name = "grdParameters";
            this.grdParameters.OcxState = (AxHost.State) manager.GetObject("grdParameters.OcxState");
            size = new Size(0x169, 0xe1);
            this.grdParameters.Size = size;
            this.grdParameters.TabIndex = 13;
            this.cmdAdd.BackColor = SystemColors.Control;
            this.cmdAdd.Cursor = Cursors.Default;
            this.cmdAdd.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdAdd.ForeColor = SystemColors.ControlText;
            point = new Point(0x128, 0xc0);
            this.cmdAdd.Location = point;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x21);
            this.cmdAdd.Size = size;
            this.cmdAdd.TabIndex = 12;
            this.cmdAdd.Text = "&Add";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.dbProjectDatabase.BackColor = SystemColors.Window;
            this.dbProjectDatabase.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.dbProjectDatabase.CommandTimeout = 0;
            this.dbProjectDatabase.CommandType = CommandTypeEnum.adCmdUnknown;
            this.dbProjectDatabase.ConnectionString = null;
            this.dbProjectDatabase.CursorLocation = CursorLocationEnum.adUseClient;
            this.dbProjectDatabase.CursorType = CursorTypeEnum.adOpenStatic;
            this.dbProjectDatabase.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.dbProjectDatabase.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dbProjectDatabase.ForeColor = SystemColors.WindowText;
            point = new Point(0x1f8, 0x30);
            this.dbProjectDatabase.Location = point;
            this.dbProjectDatabase.LockType = LockTypeEnum.adLockPessimistic;
            this.dbProjectDatabase.Mode = ConnectModeEnum.adModeUnknown;
            this.dbProjectDatabase.Name = "dbProjectDatabase";
            this.dbProjectDatabase.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x61, 0x31);
            this.dbProjectDatabase.Size = size;
            this.dbProjectDatabase.TabIndex = 0x13;
            this.dbProjectDatabase.Text = "Adodc1";
            this.dbProjectDatabase.Visible = false;
            this.dbParameters.BackColor = SystemColors.Window;
            this.dbParameters.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.dbParameters.CommandTimeout = 0;
            this.dbParameters.CommandType = CommandTypeEnum.adCmdUnknown;
            this.dbParameters.ConnectionString = null;
            this.dbParameters.CursorLocation = CursorLocationEnum.adUseClient;
            this.dbParameters.CursorType = CursorTypeEnum.adOpenStatic;
            this.dbParameters.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.dbParameters.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dbParameters.ForeColor = SystemColors.WindowText;
            point = new Point(0x1f0, 80);
            this.dbParameters.Location = point;
            this.dbParameters.LockType = LockTypeEnum.adLockPessimistic;
            this.dbParameters.Mode = ConnectModeEnum.adModeUnknown;
            this.dbParameters.Name = "dbParameters";
            this.dbParameters.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x61, 0x31);
            this.dbParameters.Size = size;
            this.dbParameters.TabIndex = 20;
            this.dbParameters.Text = "Adodc1";
            this.dbParameters.Visible = false;
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(0x180, 0x188);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x21);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.ForeColor = SystemColors.ControlText;
            point = new Point(0x180, 0x1b0);
            this.cmdOK.Location = point;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x21);
            this.cmdOK.Size = size;
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.dtChangeDate);
            this.Frame1.Controls.Add(this.udHorizon);
            this.Frame1.Controls.Add(this._optHowToChange_0);
            this.Frame1.Controls.Add(this.cmbParameters);
            this.Frame1.Controls.Add(this.txtNewValue);
            this.Frame1.Controls.Add(this.chkAllHorizons);
            this.Frame1.Controls.Add(this.lblHelp);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Controls.Add(this.Label7);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x1d1, 0x1d9);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            this.dtChangeDate.CustomFormat = "yyyy:MM:dd HH:mm";
            this.dtChangeDate.Format = DateTimePickerFormat.Custom;
            point = new Point(0x3b, 110);
            this.dtChangeDate.Location = point;
            this.dtChangeDate.Name = "dtChangeDate";
            size = new Size(0x77, 20);
            this.dtChangeDate.Size = size;
            this.dtChangeDate.TabIndex = 0x15;
            point = new Point(0xc7, 30);
            this.udHorizon.Location = point;
            decimal num = new decimal(new int[] { 10, 0, 0, 0 });
            this.udHorizon.Maximum = num;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.udHorizon.Minimum = num;
            this.udHorizon.Name = "udHorizon";
            size = new Size(0x30, 20);
            this.udHorizon.Size = size;
            this.udHorizon.TabIndex = 20;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.udHorizon.Value = num;
            this._optHowToChange_0.BackColor = SystemColors.Control;
            this._optHowToChange_0.Checked = true;
            this._optHowToChange_0.Cursor = Cursors.Default;
            this._optHowToChange_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optHowToChange_0.ForeColor = SystemColors.ControlText;
            this.optHowToChange.SetIndex(this._optHowToChange_0, 0);
            point = new Point(0x10, 0x48);
            this._optHowToChange_0.Location = point;
            this._optHowToChange_0.Name = "_optHowToChange_0";
            this._optHowToChange_0.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this._optHowToChange_0.Size = size;
            this._optHowToChange_0.TabIndex = 0x10;
            this._optHowToChange_0.TabStop = true;
            this._optHowToChange_0.Text = "Single date";
            this._optHowToChange_0.UseVisualStyleBackColor = false;
            this.cmbParameters.BackColor = SystemColors.Window;
            this.cmbParameters.Cursor = Cursors.Default;
            this.cmbParameters.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbParameters.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbParameters.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0x20);
            this.cmbParameters.Location = point;
            this.cmbParameters.Name = "cmbParameters";
            this.cmbParameters.RightToLeft = RightToLeft.No;
            size = new Size(0xb1, 0x16);
            this.cmbParameters.Size = size;
            this.cmbParameters.TabIndex = 11;
            this.txtNewValue.AcceptsReturn = true;
            this.txtNewValue.BackColor = SystemColors.Window;
            this.txtNewValue.Cursor = Cursors.IBeam;
            this.txtNewValue.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNewValue.ForeColor = SystemColors.WindowText;
            point = new Point(0xb8, 0x70);
            this.txtNewValue.Location = point;
            this.txtNewValue.MaxLength = 0;
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this.txtNewValue.Size = size;
            this.txtNewValue.TabIndex = 10;
            this.chkAllHorizons.BackColor = SystemColors.Control;
            this.chkAllHorizons.Cursor = Cursors.Default;
            this.chkAllHorizons.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkAllHorizons.ForeColor = SystemColors.ControlText;
            point = new Point(0xf8, 0x20);
            this.chkAllHorizons.Location = point;
            this.chkAllHorizons.Name = "chkAllHorizons";
            this.chkAllHorizons.RightToLeft = RightToLeft.No;
            size = new Size(0x89, 0x11);
            this.chkAllHorizons.Size = size;
            this.chkAllHorizons.TabIndex = 3;
            this.chkAllHorizons.Text = "Use all horizons";
            this.chkAllHorizons.UseVisualStyleBackColor = false;
            this.lblHelp.BackColor = SystemColors.Control;
            this.lblHelp.BorderStyle = BorderStyle.Fixed3D;
            this.lblHelp.Cursor = Cursors.Default;
            this.lblHelp.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblHelp.ForeColor = SystemColors.ControlText;
            point = new Point(0x210, 0xd8);
            this.lblHelp.Location = point;
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.RightToLeft = RightToLeft.No;
            size = new Size(0x101, 0x91);
            this.lblHelp.Size = size;
            this.lblHelp.TabIndex = 0x13;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0xe0);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x101, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Changing parameters:";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(0xb8, 0x60);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 9;
            this.Label3.Text = "New value:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(0x38, 0x60);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 0x19);
            this.Label2.Size = size;
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Change at: ";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x10);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Parameter:";
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = SystemColors.ControlText;
            point = new Point(200, 0x10);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Horizon:";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            size = new Size(0x1df, 0x1dd);
            this.ClientSize = size;
            this.Controls.Add(this.cmdClearAll);
            this.Controls.Add(this._optHowToChange_1);
            this.Controls.Add(this.grdParameters);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.dbProjectDatabase);
            this.Controls.Add(this.dbParameters);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.Frame1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChapar";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Change parameters";
            this.grdParameters.EndInit();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.udHorizon.EndInit();
            ((ISupportInitialize) this.optHowToChange).EndInit();
            this.ResumeLayout(false);
        }

        private int NumberOfDates(ref string fname)
        {
            // Invalid method body.
        }

        private void optHowToChange_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                if (this.optHowToChange.GetIndex((RadioButton) eventSender) == 0)
                {
                    this.optHowToChange[1].Checked = !this.optHowToChange[0].Checked;
                }
                else
                {
                    this.optHowToChange[0].Checked = !this.optHowToChange[1].Checked;
                }
            }
        }

        private void SetupTable()
        {
            AxMSFlexGrid grdParameters = this.grdParameters;
            grdParameters.set_TextMatrix(0, 0, "Parameter");
            grdParameters.set_TextMatrix(0, 1, "Date");
            grdParameters.set_TextMatrix(0, 2, "Value");
            grdParameters.Rows = Information.UBound(GlobalVariables.Chapar, 1) + 1;
            short num2 = (short) (grdParameters.Rows - 1);
            short row = 1;
            while (true)
            {
                short num3 = num2;
                if (row > num3)
                {
                    grdParameters.set_ColWidth(1, grdParameters.get_ColWidth(1) * 2);
                    grdParameters.set_ColAlignment(1, 1);
                    grdParameters = null;
                    return;
                }
                grdParameters.set_TextMatrix(row, 0, GlobalVariables.Chapar[row, 1]);
                grdParameters.set_TextMatrix(row, 1, GlobalVariables.Chapar[row, 2]);
                grdParameters.set_TextMatrix(row, 2, GlobalVariables.Chapar[row, 3]);
                row = (short) (row + 1);
            }
        }

        public virtual Button cmdClearAll
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdClearAll;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdClearAll_Click);
                if (!ReferenceEquals(this._cmdClearAll, null))
                {
                    this._cmdClearAll.Click -= handler;
                }
                this._cmdClearAll = value;
                if (!ReferenceEquals(this._cmdClearAll, null))
                {
                    this._cmdClearAll.Click += handler;
                }
            }
        }

        public virtual RadioButton _optHowToChange_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optHowToChange_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optHowToChange_1 = value;
        }

        public virtual AxMSFlexGrid grdParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._grdParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._grdParameters = value;
        }

        public virtual Button cmdAdd
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdAdd;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdAdd_Click);
                if (!ReferenceEquals(this._cmdAdd, null))
                {
                    this._cmdAdd.Click -= handler;
                }
                this._cmdAdd = value;
                if (!ReferenceEquals(this._cmdAdd, null))
                {
                    this._cmdAdd.Click += handler;
                }
            }
        }

        public virtual ADODC dbProjectDatabase
        {
            [DebuggerNonUserCode]
            get => 
                this._dbProjectDatabase;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbProjectDatabase = value;
        }

        public virtual ADODC dbParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._dbParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbParameters = value;
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

        public virtual RadioButton _optHowToChange_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optHowToChange_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optHowToChange_0 = value;
        }

        public virtual ComboBox cmbParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbParameters_TextChanged);
                EventHandler handler2 = new EventHandler(this.cmbParameters_SelectedIndexChanged);
                if (!ReferenceEquals(this._cmbParameters, null))
                {
                    this._cmbParameters.TextChanged -= handler;
                    this._cmbParameters.SelectedIndexChanged -= handler2;
                }
                this._cmbParameters = value;
                if (!ReferenceEquals(this._cmbParameters, null))
                {
                    this._cmbParameters.TextChanged += handler;
                    this._cmbParameters.SelectedIndexChanged += handler2;
                }
            }
        }

        public virtual TextBox txtNewValue
        {
            [DebuggerNonUserCode]
            get => 
                this._txtNewValue;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtNewValue = value;
        }

        public virtual CheckBox chkAllHorizons
        {
            [DebuggerNonUserCode]
            get => 
                this._chkAllHorizons;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkAllHorizons = value;
        }

        public virtual Label lblHelp
        {
            [DebuggerNonUserCode]
            get => 
                this._lblHelp;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblHelp = value;
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

        public virtual Label Label7
        {
            [DebuggerNonUserCode]
            get => 
                this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label7 = value;
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

        public virtual RadioButtonArray optHowToChange
        {
            [DebuggerNonUserCode]
            get => 
                this._optHowToChange;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optHowToChange_CheckedChanged);
                if (!ReferenceEquals(this._optHowToChange, null))
                {
                    this._optHowToChange.CheckedChanged -= handler;
                }
                this._optHowToChange = value;
                if (!ReferenceEquals(this._optHowToChange, null))
                {
                    this._optHowToChange.CheckedChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown udHorizon
        {
            [DebuggerNonUserCode]
            get => 
                this._udHorizon;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._udHorizon = value;
        }

        internal virtual DateTimePicker dtChangeDate
        {
            [DebuggerNonUserCode]
            get => 
                this._dtChangeDate;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dtChangeDate = value;
        }
    }
}

