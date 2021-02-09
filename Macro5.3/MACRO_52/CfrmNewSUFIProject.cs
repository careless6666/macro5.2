namespace MACRO_52
{
    using ADODB;
    using AxDataComboArray;
    using AxMSDataListLib;
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
    internal class CfrmNewSUFIProject : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("_dbParameters_3")]
        private ADODC __dbParameters_3;
        [AccessedThroughProperty("_dbParameters_2")]
        private ADODC __dbParameters_2;
        [AccessedThroughProperty("_dbParameters_1")]
        private ADODC __dbParameters_1;
        [AccessedThroughProperty("_dbParameters_0")]
        private ADODC __dbParameters_0;
        [AccessedThroughProperty("dbSUFIProject")]
        private ADODC _dbSUFIProject;
        [AccessedThroughProperty("txtProjectComment")]
        private TextBox _txtProjectComment;
        [AccessedThroughProperty("txtProjectName")]
        private TextBox _txtProjectName;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Frame4")]
        private GroupBox _Frame4;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("cmdCovariation")]
        private Button _cmdCovariation;
        [AccessedThroughProperty("cmdRemove")]
        private Button _cmdRemove;
        [AccessedThroughProperty("_cmdAdd_3")]
        private Button __cmdAdd_3;
        [AccessedThroughProperty("_cmbParameters_3")]
        private AxDataCombo __cmbParameters_3;
        [AccessedThroughProperty("chkAllHorizonsYears")]
        private CheckBox _chkAllHorizonsYears;
        [AccessedThroughProperty("_cmbParameters_2")]
        private AxDataCombo __cmbParameters_2;
        [AccessedThroughProperty("_cmbParameters_1")]
        private AxDataCombo __cmbParameters_1;
        [AccessedThroughProperty("_cmbParameters_0")]
        private AxDataCombo __cmbParameters_0;
        [AccessedThroughProperty("_cmdAdd_2")]
        private Button __cmdAdd_2;
        [AccessedThroughProperty("_cmdAdd_1")]
        private Button __cmdAdd_1;
        [AccessedThroughProperty("_cmdAdd_0")]
        private Button __cmdAdd_0;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("lblHorizonYear")]
        private Label _lblHorizonYear;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Frame3")]
        private GroupBox _Frame3;
        [AccessedThroughProperty("lstSelectedParameters")]
        private ListBox _lstSelectedParameters;
        [AccessedThroughProperty("lblHelp")]
        private Label _lblHelp;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("dbProjectDatabase")]
        private ADODC _dbProjectDatabase;
        [AccessedThroughProperty("cmdOpenBase")]
        private Button _cmdOpenBase;
        [AccessedThroughProperty("lblBaseSimulation")]
        private Label _lblBaseSimulation;
        [AccessedThroughProperty("lblBaseProject")]
        private Label _lblBaseProject;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("fraMain")]
        private GroupBox _fraMain;
        [AccessedThroughProperty("cmbParameters")]
        private AxDataComboArray.AxDataComboArray _cmbParameters;
        [AccessedThroughProperty("cmdAdd")]
        private ButtonArray _cmdAdd;
        [AccessedThroughProperty("dbParameters")]
        private ADODCArray _dbParameters;
        [AccessedThroughProperty("udHorizon")]
        private NumericUpDown _udHorizon;
        private int ProjID;
        private int rID;
        private short[,] m_Covariation;
        private CfrmMain frmMain;

        public CfrmNewSUFIProject(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmNewSUFIProject_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void cmbParameters_Change(object eventSender, EventArgs eventArgs)
        {
            short index = this.cmbParameters.GetIndex((AxDataCombo) eventSender);
            if (Strings.Len(this.cmbParameters[index].CtlText) != 0)
            {
                ADODC adodc = this.dbParameters[index];
                adodc.Recordset.MoveFirst();
                adodc.Recordset.Find("ParameterName='" + this.cmbParameters[index].CtlText + "'", 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                if (Operators.ConditionalCompareObjectEqual(adodc.Recordset[]["Length"][], (short) 60, false))
                {
                    this.udHorizon.Enabled = true;
                    this.udHorizon.Value = 1M;
                    this.udHorizon.Enabled = true;
                    this.udHorizon.Minimum = 1M;
                    this.udHorizon.Maximum = new decimal(GlobalVariables.Nhorizon);
                    this.lblHorizonYear.Text = "Horizon:";
                    this.chkAllHorizonsYears.Text = "Use all horizons";
                }
                else if (!Operators.ConditionalCompareObjectEqual(adodc.Recordset[]["Table"][], "Crop", false))
                {
                    this.udHorizon.Enabled = false;
                }
                else
                {
                    this.udHorizon.Enabled = true;
                    this.udHorizon.Value = 1M;
                    this.udHorizon.Minimum = 1M;
                    this.udHorizon.Maximum = new decimal(GlobalVariables.NumOfYears);
                    this.lblHorizonYear.Text = "Crop:";
                    this.chkAllHorizonsYears.Text = "Use for all crops";
                }
                adodc = null;
            }
            this.lblHelp.Text = "";
            AxDataCombo combo = this.cmbParameters[index];
            string ctlText = combo.CtlText;
            HelpFunctions.HELP_Crop1(ref ctlText, ref this.lblHelp);
            combo.CtlText = ctlText;
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                combo = this.cmbParameters[index];
                ctlText = combo.CtlText;
                HelpFunctions.Help_IBcond(ref ctlText, ref this.lblHelp);
                combo.CtlText = ctlText;
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                combo = this.cmbParameters[index];
                ctlText = combo.CtlText;
                HelpFunctions.HELP_Irr(ref ctlText, ref this.lblHelp);
                combo.CtlText = ctlText;
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                combo = this.cmbParameters[index];
                ctlText = combo.CtlText;
                HelpFunctions.Help_Management(ref ctlText, ref this.lblHelp);
                combo.CtlText = ctlText;
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                combo = this.cmbParameters[index];
                ctlText = combo.CtlText;
                HelpFunctions.HELP_Numerical(ref ctlText, ref this.lblHelp);
                combo.CtlText = ctlText;
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                combo = this.cmbParameters[index];
                ctlText = combo.CtlText;
                HelpFunctions.HELP_Output(ref ctlText, ref this.lblHelp);
                combo.CtlText = ctlText;
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                combo = this.cmbParameters[index];
                ctlText = combo.CtlText;
                HelpFunctions.Help_Physical(ref ctlText, ref this.lblHelp);
                combo.CtlText = ctlText;
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                combo = this.cmbParameters[index];
                ctlText = combo.CtlText;
                HelpFunctions.HELP_Site(ref 10, ref this.lblHelp, ref ctlText);
                combo.CtlText = ctlText;
            }
            if (Strings.Len(this.lblHelp.Text) == 0)
            {
                combo = this.cmbParameters[index];
                ctlText = combo.CtlText;
                HelpFunctions.Help_Solute(ref ctlText, ref this.lblHelp);
                combo.CtlText = ctlText;
            }
        }

        private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            short index = this.cmdAdd.GetIndex((Button) eventSender);
            string ctlText = this.cmbParameters[index].CtlText;
            if (Strings.Len(ctlText) != 0)
            {
                Recordset recordset = this.dbParameters[index].Recordset;
                recordset.MoveFirst();
                recordset.Find("ParameterName='" + ctlText + "'", 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                recordset = null;
                if (Conversions.ToBoolean(Operators.AndObject(this.udHorizon.Enabled, Operators.OrObject(Operators.CompareObjectEqual(this.dbParameters[index].Recordset[]["Length"][], (short) 60, false), Operators.CompareObjectEqual(this.dbParameters[index].Recordset[]["Table"][], "Crop", false)))))
                {
                    ctlText = (this.chkAllHorizonsYears.CheckState != CheckState.Unchecked) ? (ctlText + " (all)") : (ctlText + " (" + Conversions.ToString(this.udHorizon.Value) + ")");
                }
                ListBox lstSelectedParameters = this.lstSelectedParameters;
                short num6 = (short) (lstSelectedParameters.Items.Count - 1);
                short num = 0;
                while (true)
                {
                    short num11 = num6;
                    if (num <= num11)
                    {
                        lstSelectedParameters.SelectedIndex = num;
                        if (lstSelectedParameters.Text != ctlText)
                        {
                            num = (short) (num + 1);
                            continue;
                        }
                    }
                    else
                    {
                        lstSelectedParameters = null;
                        this.lstSelectedParameters.Items.Add(ctlText);
                        short num4 = (short) Information.UBound(this.m_Covariation, 1);
                        short num5 = (short) Information.UBound(this.m_Covariation, 2);
                        short[,] numArray = new short[num4 + 1, num5 + 1];
                        short num7 = num4;
                        num = 1;
                        while (true)
                        {
                            short num3;
                            if (num > num7)
                            {
                                this.m_Covariation = new short[GlobalVariables.Nhorizon + 1, this.lstSelectedParameters.Items.Count + 1];
                                short num9 = num4;
                                num = 1;
                                while (num <= num9)
                                {
                                    short num10 = num5;
                                    num3 = 1;
                                    while (true)
                                    {
                                        num11 = num10;
                                        if (num3 > num11)
                                        {
                                            num = (short) (num + 1);
                                            break;
                                        }
                                        this.m_Covariation[num, num3] = numArray[num, num3];
                                        num3 = (short) (num3 + 1);
                                    }
                                }
                                break;
                            }
                            short num8 = num5;
                            num3 = 1;
                            while (true)
                            {
                                num11 = num8;
                                if (num3 > num11)
                                {
                                    num = (short) (num + 1);
                                    break;
                                }
                                numArray[num, num3] = this.m_Covariation[num, num3];
                                num3 = (short) (num3 + 1);
                            }
                        }
                    }
                    break;
                }
            }
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void cmdCovariation_Click(object eventSender, EventArgs eventArgs)
        {
            short num2;
            short num8;
            frmSUFICovariation covariation = new frmSUFICovariation(ref this.frmMain) {
                IDOK = false,
                MSFlexGrid1 = { 
                    Rows = Convert.ToInt32(decimal.Add(1M, this.udHorizon.Maximum)),
                    Cols = 1 + this.lstSelectedParameters.Items.Count
                }
            };
            short num3 = (short) (covariation.MSFlexGrid1.Cols - 1);
            short col = 1;
            while (col <= num3)
            {
                covariation.MSFlexGrid1.set_TextMatrix(0, col, Support.GetItemString(this.lstSelectedParameters, col - 1));
                short num4 = (short) (covariation.MSFlexGrid1.Rows - 1);
                num2 = 1;
                while (true)
                {
                    num8 = num4;
                    if (num2 > num8)
                    {
                        col = (short) (col + 1);
                        break;
                    }
                    if (this.m_Covariation[num2, col] == 1)
                    {
                        covariation.MSFlexGrid1.set_TextMatrix(num2, col, "covary");
                    }
                    else
                    {
                        covariation.MSFlexGrid1.set_TextMatrix(num2, col, "");
                    }
                    num2 = (short) (num2 + 1);
                }
            }
            covariation.MSFlexGrid1.set_TextMatrix(0, 0, "Horizon:");
            short num5 = (short) (covariation.MSFlexGrid1.Rows - 1);
            col = 1;
            while (true)
            {
                num8 = num5;
                if (col > num8)
                {
                    covariation.ShowDialog();
                    if (covariation.IDOK)
                    {
                        short num6 = (short) (covariation.MSFlexGrid1.Rows - 1);
                        col = 1;
                        while (true)
                        {
                            if (col > num6)
                            {
                                covariation.Close();
                                break;
                            }
                            short num7 = (short) (covariation.MSFlexGrid1.Cols - 1);
                            num2 = 1;
                            while (true)
                            {
                                num8 = num7;
                                if (num2 > num8)
                                {
                                    col = (short) (col + 1);
                                    break;
                                }
                                bool flag2 = covariation.MSFlexGrid1.get_TextMatrix(col, num2) == "covary";
                                this.m_Covariation[col, num2] = !flag2 ? ((short) 0) : ((short) 1);
                                num2 = (short) (num2 + 1);
                            }
                        }
                    }
                    return;
                }
                covariation.MSFlexGrid1.set_TextMatrix(col, 0, Conversions.ToString((int) col));
                col = (short) (col + 1);
            }
        }

        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.VariableCheck() && this.SaveSUFIProject())
            {
                MiscFUncs.MsgBox_Renamed("New project successfully created", 0x40, "Done");
                this.Close();
            }
        }

        private void cmdOpenBase_Click(object eventSender, EventArgs eventArgs)
        {
            frmOpen open = new frmOpen(ref this.frmMain) {
                bSUFI = true
            };
            open.ShowDialog();
            open.bSUFI = false;
            if (this.SUFIRunID != -1)
            {
                this.EnableParameters(ref true);
            }
            this.dbProjectDatabase.RecordSource = "select r_id from Crop where r_id=" + Conversions.ToString(this.SUFIRunID);
            this.dbProjectDatabase.Refresh();
            GlobalVariables.NumOfYears = (short) this.dbProjectDatabase.Recordset.RecordCount;
            this.dbProjectDatabase.RecordSource = "select r_id from Properties where r_id=" + Conversions.ToString(this.SUFIRunID);
            this.dbProjectDatabase.Refresh();
            GlobalVariables.Nhorizon = (short) this.dbProjectDatabase.Recordset.RecordCount;
            this.m_Covariation = new short[Convert.ToInt32(this.udHorizon.Value) + 1, 2];
        }

        private void cmdRemove_Click(object eventSender, EventArgs eventArgs)
        {
            ListBox lstSelectedParameters = this.lstSelectedParameters;
            if (!((lstSelectedParameters.Items.Count == 0) | (lstSelectedParameters.SelectedIndex == -1)))
            {
                lstSelectedParameters.Items.RemoveAt(lstSelectedParameters.SelectedIndex);
                this.m_Covariation = new short[Convert.ToInt32(this.udHorizon.Maximum) + 1, lstSelectedParameters.Items.Count + 1];
                lstSelectedParameters = null;
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

        private void EnableParameters(ref bool val_Renamed)
        {
            short num2 = (short) (this.cmbParameters.Count() - 1);
            short num = 0;
            while (true)
            {
                short num3 = num2;
                if (num > num3)
                {
                    this.cmdCovariation.Enabled = val_Renamed;
                    this.lstSelectedParameters.Enabled = val_Renamed;
                    this.cmdRemove.Enabled = val_Renamed;
                    return;
                }
                this.cmbParameters[num].Enabled = val_Renamed;
                this.cmdAdd[num].Enabled = val_Renamed;
                num = (short) (num + 1);
            }
        }

        private void frmNewSUFIProject_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
            short num2 = (short) (this.dbParameters.Count() - 1);
            short num = 0;
            while (true)
            {
                short num3 = num2;
                if (num > num3)
                {
                    this.dbProjectDatabase.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
                    this.dbSUFIProject.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.SUFIDatabaseName + ";Persist Security Info=False";
                    AxDataComboArray.AxDataComboArray cmbParameters = this.cmbParameters;
                    cmbParameters[0].ReFill();
                    cmbParameters[1].ReFill();
                    cmbParameters[2].ReFill();
                    cmbParameters[3].ReFill();
                    cmbParameters = null;
                    return;
                }
                CfrmNewSUFIProject project = this;
                project.dbParameters[num].ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
                if (num == 2)
                {
                    project.dbParameters[num].RecordSource = "select * from [ParameterInfoSUFI] where [Group]=6";
                }
                else if (num == 0)
                {
                    project.dbParameters[num].RecordSource = "select * from [ParameterInfoSUFI] where [Group]=4 or [Group]=2";
                }
                else if (num == 1)
                {
                    project.dbParameters[num].RecordSource = "select * from [ParameterInfoSUFI] where [Group]=5 or [Group]=7";
                }
                else if (num == 3)
                {
                    project.dbParameters[num].RecordSource = "select * from [ParameterInfoSUFI] where [Group]=3";
                }
                project.dbParameters[num].Refresh();
                project.cmbParameters[num].RowSource = project.dbParameters[num];
                project.cmbParameters[num].ListField = "ParameterName";
                project = null;
                num = (short) (num + 1);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmNewSUFIProject));
            this.fraMain = new GroupBox();
            this.Frame4 = new GroupBox();
            this.dbSUFIProject = new ADODC();
            this.txtProjectComment = new TextBox();
            this.txtProjectName = new TextBox();
            this.Label9 = new Label();
            this.Label8 = new Label();
            this.cmdCancel = new Button();
            this.cmdOK = new Button();
            this.Frame2 = new GroupBox();
            this.cmdCovariation = new Button();
            this.cmdRemove = new Button();
            this.Frame3 = new GroupBox();
            this.udHorizon = new NumericUpDown();
            this._cmdAdd_3 = new Button();
            this._cmbParameters_3 = new AxDataCombo();
            this.chkAllHorizonsYears = new CheckBox();
            this._cmbParameters_2 = new AxDataCombo();
            this._cmbParameters_1 = new AxDataCombo();
            this._cmbParameters_0 = new AxDataCombo();
            this._cmdAdd_2 = new Button();
            this._cmdAdd_1 = new Button();
            this._cmdAdd_0 = new Button();
            this.Label11 = new Label();
            this.lblHorizonYear = new Label();
            this.Label6 = new Label();
            this.Label5 = new Label();
            this.Label4 = new Label();
            this.lstSelectedParameters = new ListBox();
            this.lblHelp = new Label();
            this.Label10 = new Label();
            this.Label3 = new Label();
            this.Frame1 = new GroupBox();
            this.dbProjectDatabase = new ADODC();
            this.cmdOpenBase = new Button();
            this.lblBaseSimulation = new Label();
            this.lblBaseProject = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this._dbParameters_3 = new ADODC();
            this._dbParameters_2 = new ADODC();
            this._dbParameters_1 = new ADODC();
            this._dbParameters_0 = new ADODC();
            this.cmbParameters = new AxDataComboArray.AxDataComboArray(this.components);
            this.cmdAdd = new ButtonArray(this.components);
            this.dbParameters = new ADODCArray(this.components);
            this.fraMain.SuspendLayout();
            this.Frame4.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.udHorizon.BeginInit();
            this._cmbParameters_3.BeginInit();
            this._cmbParameters_2.BeginInit();
            this._cmbParameters_1.BeginInit();
            this._cmbParameters_0.BeginInit();
            this.Frame1.SuspendLayout();
            ((ISupportInitialize) this.cmbParameters).BeginInit();
            ((ISupportInitialize) this.cmdAdd).BeginInit();
            ((ISupportInitialize) this.dbParameters).BeginInit();
            this.SuspendLayout();
            this.fraMain.BackColor = SystemColors.Control;
            this.fraMain.Controls.Add(this.Frame4);
            this.fraMain.Controls.Add(this.cmdCancel);
            this.fraMain.Controls.Add(this.cmdOK);
            this.fraMain.Controls.Add(this.Frame2);
            this.fraMain.Controls.Add(this.Frame1);
            this.fraMain.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraMain.ForeColor = SystemColors.ControlText;
            Point point = new Point(8, 0);
            this.fraMain.Location = point;
            this.fraMain.Name = "fraMain";
            this.fraMain.RightToLeft = RightToLeft.No;
            Size size = new Size(0x251, 0x1f1);
            this.fraMain.Size = size;
            this.fraMain.TabIndex = 0;
            this.fraMain.TabStop = false;
            this.Frame4.BackColor = SystemColors.Control;
            this.Frame4.Controls.Add(this.dbSUFIProject);
            this.Frame4.Controls.Add(this.txtProjectComment);
            this.Frame4.Controls.Add(this.txtProjectName);
            this.Frame4.Controls.Add(this.Label9);
            this.Frame4.Controls.Add(this.Label8);
            this.Frame4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Frame4.Location = point;
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = RightToLeft.No;
            size = new Size(0x101, 0x69);
            this.Frame4.Size = size;
            this.Frame4.TabIndex = 0x13;
            this.Frame4.TabStop = false;
            this.Frame4.Text = "Project information";
            this.dbSUFIProject.BackColor = SystemColors.Window;
            this.dbSUFIProject.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.dbSUFIProject.CommandTimeout = 0;
            this.dbSUFIProject.CommandType = CommandTypeEnum.adCmdUnknown;
            this.dbSUFIProject.ConnectionString = null;
            this.dbSUFIProject.CursorLocation = CursorLocationEnum.adUseClient;
            this.dbSUFIProject.CursorType = CursorTypeEnum.adOpenStatic;
            this.dbSUFIProject.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.dbSUFIProject.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dbSUFIProject.ForeColor = SystemColors.WindowText;
            point = new Point(80, 40);
            this.dbSUFIProject.Location = point;
            this.dbSUFIProject.LockType = LockTypeEnum.adLockPessimistic;
            this.dbSUFIProject.Mode = ConnectModeEnum.adModeUnknown;
            this.dbSUFIProject.Name = "dbSUFIProject";
            this.dbSUFIProject.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x71, 0x16);
            this.dbSUFIProject.Size = size;
            this.dbSUFIProject.TabIndex = 0;
            this.dbSUFIProject.Text = "Adodc1";
            this.dbSUFIProject.Visible = false;
            this.txtProjectComment.AcceptsReturn = true;
            this.txtProjectComment.BackColor = SystemColors.Window;
            this.txtProjectComment.Cursor = Cursors.IBeam;
            this.txtProjectComment.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtProjectComment.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x38);
            this.txtProjectComment.Location = point;
            this.txtProjectComment.MaxLength = 0xff;
            this.txtProjectComment.Multiline = true;
            this.txtProjectComment.Name = "txtProjectComment";
            this.txtProjectComment.RightToLeft = RightToLeft.No;
            size = new Size(0xf1, 0x29);
            this.txtProjectComment.Size = size;
            this.txtProjectComment.TabIndex = 0x17;
            this.txtProjectName.AcceptsReturn = true;
            this.txtProjectName.BackColor = SystemColors.Window;
            this.txtProjectName.Cursor = Cursors.IBeam;
            this.txtProjectName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtProjectName.ForeColor = SystemColors.WindowText;
            point = new Point(0x38, 0x10);
            this.txtProjectName.Location = point;
            this.txtProjectName.MaxLength = 50;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 20);
            this.txtProjectName.Size = size;
            this.txtProjectName.TabIndex = 0x16;
            this.Label9.BackColor = SystemColors.Control;
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = SystemColors.ControlText;
            point = new Point(8, 40);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label9.Size = size;
            this.Label9.TabIndex = 0x15;
            this.Label9.Text = "Comment:";
            this.Label8.BackColor = SystemColors.Control;
            this.Label8.Cursor = Cursors.Default;
            this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x12);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this.Label8.Size = size;
            this.Label8.TabIndex = 20;
            this.Label8.Text = "Name:";
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(0x201, 0x1b1);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 0x12;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.ForeColor = SystemColors.ControlText;
            point = new Point(0x201, 0x1d0);
            this.cmdOK.Location = point;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdOK.Size = size;
            this.cmdOK.TabIndex = 0x11;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this.cmdCovariation);
            this.Frame2.Controls.Add(this.cmdRemove);
            this.Frame2.Controls.Add(this.Frame3);
            this.Frame2.Controls.Add(this.lstSelectedParameters);
            this.Frame2.Controls.Add(this.lblHelp);
            this.Frame2.Controls.Add(this.Label10);
            this.Frame2.Controls.Add(this.Label3);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x80);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0x1f3, 0x169);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 4;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Parameters";
            this.cmdCovariation.BackColor = SystemColors.Control;
            this.cmdCovariation.Cursor = Cursors.Default;
            this.cmdCovariation.Enabled = false;
            this.cmdCovariation.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCovariation.ForeColor = SystemColors.ControlText;
            point = new Point(420, 0xb7);
            this.cmdCovariation.Location = point;
            this.cmdCovariation.Name = "cmdCovariation";
            this.cmdCovariation.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdCovariation.Size = size;
            this.cmdCovariation.TabIndex = 0x20;
            this.cmdCovariation.Text = "&Covariation";
            this.cmdCovariation.UseVisualStyleBackColor = false;
            this.cmdRemove.BackColor = SystemColors.Control;
            this.cmdRemove.Cursor = Cursors.Default;
            this.cmdRemove.Enabled = false;
            this.cmdRemove.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdRemove.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xb8);
            this.cmdRemove.Location = point;
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdRemove.Size = size;
            this.cmdRemove.TabIndex = 30;
            this.cmdRemove.Text = "&Remove";
            this.cmdRemove.UseVisualStyleBackColor = false;
            this.Frame3.BackColor = SystemColors.Control;
            this.Frame3.Controls.Add(this.udHorizon);
            this.Frame3.Controls.Add(this._cmdAdd_3);
            this.Frame3.Controls.Add(this._cmbParameters_3);
            this.Frame3.Controls.Add(this.chkAllHorizonsYears);
            this.Frame3.Controls.Add(this._cmbParameters_2);
            this.Frame3.Controls.Add(this._cmbParameters_1);
            this.Frame3.Controls.Add(this._cmbParameters_0);
            this.Frame3.Controls.Add(this._cmdAdd_2);
            this.Frame3.Controls.Add(this._cmdAdd_1);
            this.Frame3.Controls.Add(this._cmdAdd_0);
            this.Frame3.Controls.Add(this.Label11);
            this.Frame3.Controls.Add(this.lblHorizonYear);
            this.Frame3.Controls.Add(this.Label6);
            this.Frame3.Controls.Add(this.Label5);
            this.Frame3.Controls.Add(this.Label4);
            this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame3.ForeColor = SystemColors.ControlText;
            point = new Point(0xa8, 0x10);
            this.Frame3.Location = point;
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = RightToLeft.No;
            size = new Size(0x145, 0xa1);
            this.Frame3.Size = size;
            this.Frame3.TabIndex = 7;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Select:";
            this.udHorizon.Enabled = false;
            point = new Point(0x45, 0x84);
            this.udHorizon.Location = point;
            decimal num = new decimal(new int[] { 1, 0, 0, 0 });
            this.udHorizon.Minimum = num;
            this.udHorizon.Name = "udHorizon";
            size = new Size(0x24, 20);
            this.udHorizon.Size = size;
            this.udHorizon.TabIndex = 0x26;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.udHorizon.Value = num;
            this._cmdAdd_3.BackColor = SystemColors.Control;
            this._cmdAdd_3.Cursor = Cursors.Default;
            this._cmdAdd_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmdAdd_3.ForeColor = SystemColors.ControlText;
            this.cmdAdd.SetIndex(this._cmdAdd_3, 3);
            point = new Point(0x108, 0x70);
            this._cmdAdd_3.Location = point;
            this._cmdAdd_3.Name = "_cmdAdd_3";
            this._cmdAdd_3.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x15);
            this._cmdAdd_3.Size = size;
            this._cmdAdd_3.TabIndex = 0x25;
            this._cmdAdd_3.Text = "Add";
            this._cmdAdd_3.UseVisualStyleBackColor = false;
            this.cmbParameters.SetIndex(this._cmbParameters_3, 3);
            point = new Point(0x70, 0x70);
            this._cmbParameters_3.Location = point;
            this._cmbParameters_3.Name = "_cmbParameters_3";
            this._cmbParameters_3.OcxState = (AxHost.State) manager.GetObject("_cmbParameters_3.OcxState");
            this._cmbParameters_3.RowSource = null;
            size = new Size(0x99, 0x16);
            this._cmbParameters_3.Size = size;
            this._cmbParameters_3.TabIndex = 0x23;
            this.chkAllHorizonsYears.BackColor = SystemColors.Control;
            this.chkAllHorizonsYears.Cursor = Cursors.Default;
            this.chkAllHorizonsYears.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkAllHorizonsYears.ForeColor = SystemColors.ControlText;
            point = new Point(120, 0x88);
            this.chkAllHorizonsYears.Location = point;
            this.chkAllHorizonsYears.Name = "chkAllHorizonsYears";
            this.chkAllHorizonsYears.RightToLeft = RightToLeft.No;
            size = new Size(0x89, 0x11);
            this.chkAllHorizonsYears.Size = size;
            this.chkAllHorizonsYears.TabIndex = 0x1f;
            this.chkAllHorizonsYears.Text = "Use all horizons";
            this.chkAllHorizonsYears.UseVisualStyleBackColor = false;
            this.cmbParameters.SetIndex(this._cmbParameters_2, 2);
            point = new Point(0x70, 80);
            this._cmbParameters_2.Location = point;
            this._cmbParameters_2.Name = "_cmbParameters_2";
            this._cmbParameters_2.OcxState = (AxHost.State) manager.GetObject("_cmbParameters_2.OcxState");
            this._cmbParameters_2.RowSource = null;
            size = new Size(0x99, 0x16);
            this._cmbParameters_2.Size = size;
            this._cmbParameters_2.TabIndex = 0x1d;
            this.cmbParameters.SetIndex(this._cmbParameters_1, 1);
            point = new Point(0x70, 0x34);
            this._cmbParameters_1.Location = point;
            this._cmbParameters_1.Name = "_cmbParameters_1";
            this._cmbParameters_1.OcxState = (AxHost.State) manager.GetObject("_cmbParameters_1.OcxState");
            this._cmbParameters_1.RowSource = null;
            size = new Size(0x99, 0x16);
            this._cmbParameters_1.Size = size;
            this._cmbParameters_1.TabIndex = 0x1c;
            this.cmbParameters.SetIndex(this._cmbParameters_0, 0);
            point = new Point(0x70, 0x18);
            this._cmbParameters_0.Location = point;
            this._cmbParameters_0.Name = "_cmbParameters_0";
            this._cmbParameters_0.OcxState = (AxHost.State) manager.GetObject("_cmbParameters_0.OcxState");
            this._cmbParameters_0.RowSource = null;
            size = new Size(0x99, 0x16);
            this._cmbParameters_0.Size = size;
            this._cmbParameters_0.TabIndex = 0x1b;
            this._cmdAdd_2.BackColor = SystemColors.Control;
            this._cmdAdd_2.Cursor = Cursors.Default;
            this._cmdAdd_2.Enabled = false;
            this._cmdAdd_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmdAdd_2.ForeColor = SystemColors.ControlText;
            this.cmdAdd.SetIndex(this._cmdAdd_2, 2);
            point = new Point(0x108, 80);
            this._cmdAdd_2.Location = point;
            this._cmdAdd_2.Name = "_cmdAdd_2";
            this._cmdAdd_2.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x15);
            this._cmdAdd_2.Size = size;
            this._cmdAdd_2.TabIndex = 13;
            this._cmdAdd_2.Text = "Add";
            this._cmdAdd_2.UseVisualStyleBackColor = false;
            this._cmdAdd_1.BackColor = SystemColors.Control;
            this._cmdAdd_1.Cursor = Cursors.Default;
            this._cmdAdd_1.Enabled = false;
            this._cmdAdd_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmdAdd_1.ForeColor = SystemColors.ControlText;
            this.cmdAdd.SetIndex(this._cmdAdd_1, 1);
            point = new Point(0x108, 0x34);
            this._cmdAdd_1.Location = point;
            this._cmdAdd_1.Name = "_cmdAdd_1";
            this._cmdAdd_1.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x15);
            this._cmdAdd_1.Size = size;
            this._cmdAdd_1.TabIndex = 11;
            this._cmdAdd_1.Text = "Add";
            this._cmdAdd_1.UseVisualStyleBackColor = false;
            this._cmdAdd_0.BackColor = SystemColors.Control;
            this._cmdAdd_0.Cursor = Cursors.Default;
            this._cmdAdd_0.Enabled = false;
            this._cmdAdd_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmdAdd_0.ForeColor = SystemColors.ControlText;
            this.cmdAdd.SetIndex(this._cmdAdd_0, 0);
            point = new Point(0x108, 0x18);
            this._cmdAdd_0.Location = point;
            this._cmdAdd_0.Name = "_cmdAdd_0";
            this._cmdAdd_0.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x15);
            this._cmdAdd_0.Size = size;
            this._cmdAdd_0.TabIndex = 10;
            this._cmdAdd_0.Text = "Add";
            this._cmdAdd_0.UseVisualStyleBackColor = false;
            this.Label11.BackColor = SystemColors.Control;
            this.Label11.Cursor = Cursors.Default;
            this.Label11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label11.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x70);
            this.Label11.Location = point;
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label11.Size = size;
            this.Label11.TabIndex = 0x24;
            this.Label11.Text = "Init./boundary:";
            this.lblHorizonYear.BackColor = SystemColors.Control;
            this.lblHorizonYear.Cursor = Cursors.Default;
            this.lblHorizonYear.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblHorizonYear.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x88);
            this.lblHorizonYear.Location = point;
            this.lblHorizonYear.Name = "lblHorizonYear";
            this.lblHorizonYear.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.lblHorizonYear.Size = size;
            this.lblHorizonYear.TabIndex = 14;
            this.lblHorizonYear.Text = "Horizon:";
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x54);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label6.Size = size;
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Phys./Hyd.:";
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Pesticide/crop:";
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x1c);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Solute/site:";
            this.lstSelectedParameters.BackColor = SystemColors.Window;
            this.lstSelectedParameters.Cursor = Cursors.Default;
            this.lstSelectedParameters.Enabled = false;
            this.lstSelectedParameters.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstSelectedParameters.ForeColor = SystemColors.WindowText;
            this.lstSelectedParameters.ItemHeight = 14;
            point = new Point(8, 0x20);
            this.lstSelectedParameters.Location = point;
            this.lstSelectedParameters.Name = "lstSelectedParameters";
            this.lstSelectedParameters.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 130);
            this.lstSelectedParameters.Size = size;
            this.lstSelectedParameters.TabIndex = 5;
            this.lblHelp.BackColor = SystemColors.Control;
            this.lblHelp.BorderStyle = BorderStyle.Fixed3D;
            this.lblHelp.Cursor = Cursors.Default;
            this.lblHelp.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblHelp.ForeColor = SystemColors.ControlText;
            point = new Point(8, 240);
            this.lblHelp.Location = point;
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.RightToLeft = RightToLeft.No;
            size = new Size(0x1d1, 0x71);
            this.lblHelp.Size = size;
            this.lblHelp.TabIndex = 0x22;
            this.Label10.BackColor = SystemColors.Control;
            this.Label10.Cursor = Cursors.Default;
            this.Label10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label10.ForeColor = SystemColors.ControlText;
            point = new Point(0x58, 0xb8);
            this.Label10.Location = point;
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x21);
            this.Label10.Size = size;
            this.Label10.TabIndex = 0x21;
            this.Label10.Text = "Covariation must be redefined if a parameter is removed.";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Selected parameters:";
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.dbProjectDatabase);
            this.Frame1.Controls.Add(this.cmdOpenBase);
            this.Frame1.Controls.Add(this.lblBaseSimulation);
            this.Frame1.Controls.Add(this.lblBaseProject);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(0x110, 0x10);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x109, 0x69);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 1;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Base simulation";
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
            point = new Point(8, 0x48);
            this.dbProjectDatabase.Location = point;
            this.dbProjectDatabase.LockType = LockTypeEnum.adLockPessimistic;
            this.dbProjectDatabase.Mode = ConnectModeEnum.adModeUnknown;
            this.dbProjectDatabase.Name = "dbProjectDatabase";
            this.dbProjectDatabase.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x69, 0x19);
            this.dbProjectDatabase.Size = size;
            this.dbProjectDatabase.TabIndex = 0;
            this.dbProjectDatabase.Text = "Adodc1";
            this.dbProjectDatabase.Visible = false;
            this.cmdOpenBase.BackColor = SystemColors.Control;
            this.cmdOpenBase.Cursor = Cursors.Default;
            this.cmdOpenBase.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOpenBase.ForeColor = SystemColors.ControlText;
            point = new Point(0xa8, 0x48);
            this.cmdOpenBase.Location = point;
            this.cmdOpenBase.Name = "cmdOpenBase";
            this.cmdOpenBase.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x19);
            this.cmdOpenBase.Size = size;
            this.cmdOpenBase.TabIndex = 0x1a;
            this.cmdOpenBase.Text = "&Open";
            this.cmdOpenBase.UseVisualStyleBackColor = false;
            this.lblBaseSimulation.BackColor = SystemColors.Window;
            this.lblBaseSimulation.BorderStyle = BorderStyle.FixedSingle;
            this.lblBaseSimulation.Cursor = Cursors.Default;
            this.lblBaseSimulation.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblBaseSimulation.ForeColor = SystemColors.WindowText;
            point = new Point(0x40, 0x30);
            this.lblBaseSimulation.Location = point;
            this.lblBaseSimulation.Name = "lblBaseSimulation";
            this.lblBaseSimulation.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this.lblBaseSimulation.Size = size;
            this.lblBaseSimulation.TabIndex = 0x19;
            this.lblBaseProject.BackColor = SystemColors.Window;
            this.lblBaseProject.BorderStyle = BorderStyle.FixedSingle;
            this.lblBaseProject.Cursor = Cursors.Default;
            this.lblBaseProject.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblBaseProject.ForeColor = SystemColors.WindowText;
            point = new Point(0x40, 0x10);
            this.lblBaseProject.Location = point;
            this.lblBaseProject.Name = "lblBaseProject";
            this.lblBaseProject.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this.lblBaseProject.Size = size;
            this.lblBaseProject.TabIndex = 0x18;
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x34);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Simulation:";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 20);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Project:";
            this._dbParameters_3.BackColor = SystemColors.Window;
            this._dbParameters_3.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this._dbParameters_3.CommandTimeout = 0;
            this._dbParameters_3.CommandType = CommandTypeEnum.adCmdUnknown;
            this._dbParameters_3.ConnectionString = null;
            this._dbParameters_3.CursorLocation = CursorLocationEnum.adUseClient;
            this._dbParameters_3.CursorType = CursorTypeEnum.adOpenStatic;
            this._dbParameters_3.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this._dbParameters_3.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._dbParameters_3.ForeColor = SystemColors.WindowText;
            this.dbParameters.SetIndex(this._dbParameters_3, 3);
            point = new Point(0x231, 0x138);
            this._dbParameters_3.Location = point;
            this._dbParameters_3.LockType = LockTypeEnum.adLockPessimistic;
            this._dbParameters_3.Mode = ConnectModeEnum.adModeUnknown;
            this._dbParameters_3.Name = "_dbParameters_3";
            this._dbParameters_3.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(80, 0x19);
            this._dbParameters_3.Size = size;
            this._dbParameters_3.TabIndex = 0;
            this._dbParameters_3.Text = "Adodc1";
            this._dbParameters_3.Visible = false;
            this._dbParameters_2.BackColor = SystemColors.Window;
            this._dbParameters_2.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this._dbParameters_2.CommandTimeout = 0;
            this._dbParameters_2.CommandType = CommandTypeEnum.adCmdUnknown;
            this._dbParameters_2.ConnectionString = null;
            this._dbParameters_2.CursorLocation = CursorLocationEnum.adUseClient;
            this._dbParameters_2.CursorType = CursorTypeEnum.adOpenStatic;
            this._dbParameters_2.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this._dbParameters_2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._dbParameters_2.ForeColor = SystemColors.WindowText;
            this.dbParameters.SetIndex(this._dbParameters_2, 2);
            point = new Point(0x23f, 0x10c);
            this._dbParameters_2.Location = point;
            this._dbParameters_2.LockType = LockTypeEnum.adLockPessimistic;
            this._dbParameters_2.Mode = ConnectModeEnum.adModeUnknown;
            this._dbParameters_2.Name = "_dbParameters_2";
            this._dbParameters_2.Orientation = ADODC.OrientationEnum.adHorizontal;
            this._dbParameters_2.RecordSource = "select * from [ParameterInfo] where [Group]=6";
            size = new Size(0x59, 0x16);
            this._dbParameters_2.Size = size;
            this._dbParameters_2.TabIndex = 1;
            this._dbParameters_2.Text = "Adodc3";
            this._dbParameters_2.Visible = false;
            this._dbParameters_1.BackColor = SystemColors.Window;
            this._dbParameters_1.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this._dbParameters_1.CommandTimeout = 0;
            this._dbParameters_1.CommandType = CommandTypeEnum.adCmdUnknown;
            this._dbParameters_1.ConnectionString = null;
            this._dbParameters_1.CursorLocation = CursorLocationEnum.adUseClient;
            this._dbParameters_1.CursorType = CursorTypeEnum.adOpenStatic;
            this._dbParameters_1.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this._dbParameters_1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._dbParameters_1.ForeColor = SystemColors.WindowText;
            this.dbParameters.SetIndex(this._dbParameters_1, 1);
            point = new Point(0x228, 240);
            this._dbParameters_1.Location = point;
            this._dbParameters_1.LockType = LockTypeEnum.adLockPessimistic;
            this._dbParameters_1.Mode = ConnectModeEnum.adModeUnknown;
            this._dbParameters_1.Name = "_dbParameters_1";
            this._dbParameters_1.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x59, 0x16);
            this._dbParameters_1.Size = size;
            this._dbParameters_1.TabIndex = 2;
            this._dbParameters_1.Text = "Adodc2";
            this._dbParameters_1.Visible = false;
            this._dbParameters_0.BackColor = SystemColors.Window;
            this._dbParameters_0.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this._dbParameters_0.CommandTimeout = 0;
            this._dbParameters_0.CommandType = CommandTypeEnum.adCmdUnknown;
            this._dbParameters_0.ConnectionString = null;
            this._dbParameters_0.CursorLocation = CursorLocationEnum.adUseClient;
            this._dbParameters_0.CursorType = CursorTypeEnum.adOpenStatic;
            this._dbParameters_0.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this._dbParameters_0.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._dbParameters_0.ForeColor = SystemColors.WindowText;
            this.dbParameters.SetIndex(this._dbParameters_0, 0);
            point = new Point(0x23f, 200);
            this._dbParameters_0.Location = point;
            this._dbParameters_0.LockType = LockTypeEnum.adLockPessimistic;
            this._dbParameters_0.Mode = ConnectModeEnum.adModeUnknown;
            this._dbParameters_0.Name = "_dbParameters_0";
            this._dbParameters_0.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x59, 0x16);
            this._dbParameters_0.Size = size;
            this._dbParameters_0.TabIndex = 3;
            this._dbParameters_0.Text = "dbParameters";
            this._dbParameters_0.Visible = false;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            size = new Size(0x25f, 0x1ff);
            this.ClientSize = size;
            this.Controls.Add(this._dbParameters_3);
            this.Controls.Add(this.fraMain);
            this.Controls.Add(this._dbParameters_2);
            this.Controls.Add(this._dbParameters_0);
            this.Controls.Add(this._dbParameters_1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmNewSUFIProject";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "New SUFI project";
            this.fraMain.ResumeLayout(false);
            this.Frame4.ResumeLayout(false);
            this.Frame4.PerformLayout();
            this.Frame2.ResumeLayout(false);
            this.Frame3.ResumeLayout(false);
            this.udHorizon.EndInit();
            this._cmbParameters_3.EndInit();
            this._cmbParameters_2.EndInit();
            this._cmbParameters_1.EndInit();
            this._cmbParameters_0.EndInit();
            this.Frame1.ResumeLayout(false);
            ((ISupportInitialize) this.cmbParameters).EndInit();
            ((ISupportInitialize) this.cmdAdd).EndInit();
            ((ISupportInitialize) this.dbParameters).EndInit();
            this.ResumeLayout(false);
        }

        private bool SaveSUFIProject()
        {
            // Invalid method body.
        }

        private bool VariableCheck()
        {
            if ((this.SUFIProjectID == -1) | (this.SUFIRunID == -1))
            {
                MiscFUncs.MsgBox_Renamed("Base simulation not selected", 0x40, "Select base simulation");
            }
            else if (Strings.Len(this.txtProjectName.Text) == 0)
            {
                MiscFUncs.MsgBox_Renamed("Please provide a project name", 0x40, "Project name missing");
            }
            else if (this.lstSelectedParameters.Items.Count == 0)
            {
                MiscFUncs.MsgBox_Renamed("Select at least one parameter", 0x40, "Select parameter");
            }
            else
            {
                short num2 = (short) Strings.Len(this.txtProjectName.Text);
                short num = 1;
                while (true)
                {
                    short num3 = num2;
                    if (num > num3)
                    {
                        break;
                    }
                    num = (short) (num + 1);
                }
            }
            return true;
        }

        public virtual ADODC _dbParameters_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__dbParameters_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__dbParameters_3 = value;
        }

        public virtual ADODC _dbParameters_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__dbParameters_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__dbParameters_2 = value;
        }

        public virtual ADODC _dbParameters_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__dbParameters_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__dbParameters_1 = value;
        }

        public virtual ADODC _dbParameters_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__dbParameters_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__dbParameters_0 = value;
        }

        public virtual ADODC dbSUFIProject
        {
            [DebuggerNonUserCode]
            get => 
                this._dbSUFIProject;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbSUFIProject = value;
        }

        public virtual TextBox txtProjectComment
        {
            [DebuggerNonUserCode]
            get => 
                this._txtProjectComment;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtProjectComment = value;
        }

        public virtual TextBox txtProjectName
        {
            [DebuggerNonUserCode]
            get => 
                this._txtProjectName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtProjectName = value;
        }

        public virtual Label Label9
        {
            [DebuggerNonUserCode]
            get => 
                this._Label9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label9 = value;
        }

        public virtual Label Label8
        {
            [DebuggerNonUserCode]
            get => 
                this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label8 = value;
        }

        public virtual GroupBox Frame4
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame4 = value;
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

        public virtual Button cmdCovariation
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdCovariation;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdCovariation_Click);
                if (!ReferenceEquals(this._cmdCovariation, null))
                {
                    this._cmdCovariation.Click -= handler;
                }
                this._cmdCovariation = value;
                if (!ReferenceEquals(this._cmdCovariation, null))
                {
                    this._cmdCovariation.Click += handler;
                }
            }
        }

        public virtual Button cmdRemove
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdRemove;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdRemove_Click);
                if (!ReferenceEquals(this._cmdRemove, null))
                {
                    this._cmdRemove.Click -= handler;
                }
                this._cmdRemove = value;
                if (!ReferenceEquals(this._cmdRemove, null))
                {
                    this._cmdRemove.Click += handler;
                }
            }
        }

        public virtual Button _cmdAdd_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmdAdd_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmdAdd_3 = value;
        }

        public virtual AxDataCombo _cmbParameters_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbParameters_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbParameters_3 = value;
        }

        public virtual CheckBox chkAllHorizonsYears
        {
            [DebuggerNonUserCode]
            get => 
                this._chkAllHorizonsYears;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkAllHorizonsYears = value;
        }

        public virtual AxDataCombo _cmbParameters_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbParameters_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbParameters_2 = value;
        }

        public virtual AxDataCombo _cmbParameters_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbParameters_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbParameters_1 = value;
        }

        public virtual AxDataCombo _cmbParameters_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbParameters_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbParameters_0 = value;
        }

        public virtual Button _cmdAdd_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmdAdd_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmdAdd_2 = value;
        }

        public virtual Button _cmdAdd_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmdAdd_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmdAdd_1 = value;
        }

        public virtual Button _cmdAdd_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmdAdd_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmdAdd_0 = value;
        }

        public virtual Label Label11
        {
            [DebuggerNonUserCode]
            get => 
                this._Label11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label11 = value;
        }

        public virtual Label lblHorizonYear
        {
            [DebuggerNonUserCode]
            get => 
                this._lblHorizonYear;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblHorizonYear = value;
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

        public virtual GroupBox Frame3
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame3 = value;
        }

        public virtual ListBox lstSelectedParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._lstSelectedParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstSelectedParameters = value;
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

        public virtual Label Label10
        {
            [DebuggerNonUserCode]
            get => 
                this._Label10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label10 = value;
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

        public virtual ADODC dbProjectDatabase
        {
            [DebuggerNonUserCode]
            get => 
                this._dbProjectDatabase;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbProjectDatabase = value;
        }

        public virtual Button cmdOpenBase
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdOpenBase;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdOpenBase_Click);
                if (!ReferenceEquals(this._cmdOpenBase, null))
                {
                    this._cmdOpenBase.Click -= handler;
                }
                this._cmdOpenBase = value;
                if (!ReferenceEquals(this._cmdOpenBase, null))
                {
                    this._cmdOpenBase.Click += handler;
                }
            }
        }

        public virtual Label lblBaseSimulation
        {
            [DebuggerNonUserCode]
            get => 
                this._lblBaseSimulation;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblBaseSimulation = value;
        }

        public virtual Label lblBaseProject
        {
            [DebuggerNonUserCode]
            get => 
                this._lblBaseProject;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblBaseProject = value;
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

        public virtual GroupBox fraMain
        {
            [DebuggerNonUserCode]
            get => 
                this._fraMain;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraMain = value;
        }

        public virtual AxDataComboArray.AxDataComboArray cmbParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                AxDataComboArray.AxDataComboArray.ChangeEventHandler handler = new AxDataComboArray.AxDataComboArray.ChangeEventHandler(this.cmbParameters_Change);
                if (!ReferenceEquals(this._cmbParameters, null))
                {
                    this._cmbParameters.Change -= handler;
                }
                this._cmbParameters = value;
                if (!ReferenceEquals(this._cmbParameters, null))
                {
                    this._cmbParameters.Change += handler;
                }
            }
        }

        public virtual ButtonArray cmdAdd
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

        public virtual ADODCArray dbParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._dbParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbParameters = value;
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

        public int SUFIRunID
        {
            get => 
                this.rID;
            set => 
                this.rID = value;
        }

        public int SUFIProjectID
        {
            get
            {
                int num;
                this.ProjID = this.ProjID;
                return num;
            }
            set => 
                this.ProjID = value;
        }
    }
}

