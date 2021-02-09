namespace MACRO_52
{
    using ADODB;
    using AxMSDataListLib;
    using AxMSFlexGridLib;
    using MACRO_52.My;
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
    internal class CfrmLHS : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("tmrConvert")]
        private Timer _tmrConvert;
        [AccessedThroughProperty("tmrTabReg")]
        private Timer _tmrTabReg;
        [AccessedThroughProperty("tmrUncert")]
        private Timer _tmrUncert;
        [AccessedThroughProperty("txtOutput")]
        private ListBox _txtOutput;
        [AccessedThroughProperty("cmdBrowse")]
        private Button _cmdBrowse;
        [AccessedThroughProperty("txtOutputFile")]
        private TextBox _txtOutputFile;
        [AccessedThroughProperty("cmdAnalyse")]
        private Button _cmdAnalyse;
        [AccessedThroughProperty("txtPrefix")]
        private TextBox _txtPrefix;
        [AccessedThroughProperty("Label21")]
        private Label _Label21;
        [AccessedThroughProperty("Label20")]
        private Label _Label20;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("_fraStep_4")]
        private GroupBox __fraStep_4;
        [AccessedThroughProperty("_optAction_1")]
        private RadioButton __optAction_1;
        [AccessedThroughProperty("_optAction_0")]
        private RadioButton __optAction_0;
        [AccessedThroughProperty("_lblStep_0")]
        private Label __lblStep_0;
        [AccessedThroughProperty("_fraStep_0")]
        private GroupBox __fraStep_0;
        [AccessedThroughProperty("cmdExit")]
        private Button _cmdExit;
        [AccessedThroughProperty("dbProjectDatabase")]
        private ADODC _dbProjectDatabase;
        [AccessedThroughProperty("cmdPrevious")]
        private Button _cmdPrevious;
        [AccessedThroughProperty("cmdNext")]
        private Button _cmdNext;
        [AccessedThroughProperty("dbParameters")]
        private ADODC _dbParameters;
        [AccessedThroughProperty("txtCorrelation")]
        private TextBox _txtCorrelation;
        [AccessedThroughProperty("grdCorrelations")]
        private AxMSFlexGrid _grdCorrelations;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("lblPar2")]
        private Label _lblPar2;
        [AccessedThroughProperty("Label15")]
        private Label _Label15;
        [AccessedThroughProperty("lblPar1")]
        private Label _lblPar1;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("_fraStep_3")]
        private GroupBox __fraStep_3;
        [AccessedThroughProperty("cmdRemove")]
        private Button _cmdRemove;
        [AccessedThroughProperty("lstSelectedParameters")]
        private ListBox _lstSelectedParameters;
        [AccessedThroughProperty("cmdAdd")]
        private Button _cmdAdd;
        [AccessedThroughProperty("chkAllHorizons")]
        private CheckBox _chkAllHorizons;
        [AccessedThroughProperty("cmdDistributions")]
        private ComboBox _cmdDistributions;
        [AccessedThroughProperty("txtMax")]
        private TextBox _txtMax;
        [AccessedThroughProperty("txtMin")]
        private TextBox _txtMin;
        [AccessedThroughProperty("txtVariance")]
        private TextBox _txtVariance;
        [AccessedThroughProperty("txtMean")]
        private TextBox _txtMean;
        [AccessedThroughProperty("cmbParameters")]
        private AxDataCombo _cmbParameters;
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("_Label7_1")]
        private Label __Label7_1;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("_Label7_0")]
        private Label __Label7_0;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("_fraStep_2")]
        private GroupBox __fraStep_2;
        [AccessedThroughProperty("txtFilePrefix")]
        private TextBox _txtFilePrefix;
        [AccessedThroughProperty("txtNSims")]
        private TextBox _txtNSims;
        [AccessedThroughProperty("cmdRandomize")]
        private Button _cmdRandomize;
        [AccessedThroughProperty("txtSeed")]
        private TextBox _txtSeed;
        [AccessedThroughProperty("txtTitle")]
        private TextBox _txtTitle;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("_Label3_0")]
        private Label __Label3_0;
        [AccessedThroughProperty("_Label1_0")]
        private Label __Label1_0;
        [AccessedThroughProperty("_fraStep_1")]
        private GroupBox __fraStep_1;
        [AccessedThroughProperty("Label1")]
        private LabelArray _Label1;
        [AccessedThroughProperty("Label3")]
        private LabelArray _Label3;
        [AccessedThroughProperty("Label7")]
        private LabelArray _Label7;
        [AccessedThroughProperty("fraStep")]
        private GroupBoxArray _fraStep;
        [AccessedThroughProperty("lblStep")]
        private LabelArray _lblStep;
        [AccessedThroughProperty("optAction")]
        private RadioButtonArray _optAction;
        [AccessedThroughProperty("udHorizon")]
        private NumericUpDown _udHorizon;
        private bool IsInitializing;
        private const short STEP_SELECTACTION = 0;
        private const short STEP_PROJINFO = 1;
        private const short STEP_ADDPARAMETER = 2;
        private const short STEP_CORRELATIONS = 3;
        private const short STEP_ANALYSE = 4;
        public short m_CurStep;
        private short m_RunID;
        private Collection m_Parameters;
        private short[] m_CorrPars;
        private int SIMGENID;
        private int UNCERTID;
        private int SAMPLEID;
        private int CONVERTID;
        private CfrmMain frmMain;
        private Recordset rs;

        public CfrmLHS(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmWizard_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.m_Parameters = new Collection();
            this.m_CorrPars = new short[3];
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            this.frmMain = frm;
        }

        private bool CheckParameter()
        {
            if (Strings.Len(this.cmbParameters.CtlText) == 0)
            {
                MiscFUncs.MsgBox_Renamed("Please select a parameter to add", 0x30, "Select parameter");
            }
            else if (Strings.Len(this.cmdDistributions.Text) == 0)
            {
                MiscFUncs.MsgBox_Renamed("Please select a distribution", 0x30, "Select distribution");
            }
            else if (((!Versioned.IsNumeric(this.txtMax.Text) | !Versioned.IsNumeric(this.txtMean.Text)) | !Versioned.IsNumeric(this.txtVariance.Text)) | !Versioned.IsNumeric(this.txtMin.Text))
            {
                MiscFUncs.MsgBox_Renamed("Non numeric value", 0x30, "Non numeric value");
            }
            else if (Conversions.ToSingle(this.txtMax.Text) < Conversions.ToSingle(this.txtMin.Text))
            {
                MiscFUncs.MsgBox_Renamed("Max < min", 0x30, "Max < min");
            }
            return true;
        }

        private void cmbParameters_Change(object eventSender, EventArgs eventArgs)
        {
            if (Strings.Len(this.cmbParameters.Text) != 0)
            {
                ADODC dbParameters = this.dbParameters;
                dbParameters.Recordset.MoveFirst();
                dbParameters.Recordset.Find("ParameterName='" + this.cmbParameters.CtlText + "'", 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                if (Operators.ConditionalCompareObjectEqual(dbParameters.Recordset[]["Length"][], (short) 60, false))
                {
                    this.udHorizon.Value = 1M;
                    this.udHorizon.Enabled = true;
                    this.udHorizon.Minimum = 1M;
                }
                dbParameters = null;
            }
        }

        private void cmdAdd_Click(object eventSender, EventArgs eventArgs)
        {
            string ctlText = this.cmbParameters.CtlText;
            if (this.CheckParameter())
            {
                clsLHSParameters item = new clsLHSParameters();
                if (Strings.Len(ctlText) != 0)
                {
                    Recordset recordset = this.dbParameters.Recordset;
                    recordset.MoveFirst();
                    recordset.Find("ParameterName='" + ctlText + "'", 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                    recordset = null;
                    if (Conversions.ToBoolean(Operators.AndObject(this.udHorizon.Enabled, Operators.CompareObjectEqual(this.dbParameters.Recordset[]["Length"][], (short) 60, false))))
                    {
                        ctlText = (this.chkAllHorizons.CheckState != CheckState.Unchecked) ? (ctlText + "_all") : (ctlText + "_" + Conversions.ToString(this.udHorizon.Value));
                    }
                    ListBox lstSelectedParameters = this.lstSelectedParameters;
                    short num2 = (short) (lstSelectedParameters.Items.Count - 1);
                    short num = 0;
                    while (true)
                    {
                        short num3 = num2;
                        if (num <= num3)
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
                            item.Min = Conversions.ToSingle(this.txtMin.Text);
                            item.Max = Conversions.ToSingle(this.txtMax.Text);
                            item.mean = Conversions.ToSingle(this.txtMean.Text);
                            item.Variance = Conversions.ToSingle(this.txtVariance.Text);
                            item.ParameterName = ctlText;
                            item.Distribution = (short) this.cmdDistributions.SelectedIndex;
                            this.m_Parameters.Add(item, null, null, null);
                            this.cmdRemove.Enabled = true;
                        }
                        break;
                    }
                }
            }
        }

        private void cmdAnalyse_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.SIMGEN())
            {
                this.tmrUncert.Enabled = true;
            }
        }

        private void cmdBrowse_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void cmdConvert_Click()
        {
            FileSystem.ChDir(MyProject.Application.Info.DirectoryPath);
            if (Interaction.Shell(MyProject.Application.Info.DirectoryPath + @"\conver.exe ", AppWinStyle.MinimizedNoFocus, false, -1) == 0)
            {
                MiscFUncs.MsgBox_Renamed("Error executing conver.exe", 0x30, "Error");
            }
        }

        private void cmdDistributions_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            bool flag = this.cmdDistributions.Text != "Uniform";
            this.txtMean.Enabled = flag;
            this.txtVariance.Enabled = flag;
        }

        private void cmdDistributions_TextChanged(object eventSender, EventArgs eventArgs)
        {
            bool flag = this.cmdDistributions.Text != "Uniform";
            this.txtMean.Enabled = flag;
            this.txtVariance.Enabled = flag;
        }

        private void cmdExit_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void cmdmcsamp_Click()
        {
            this.Sample();
        }

        private void cmdNext_Click(object eventSender, EventArgs eventArgs)
        {
            this.cmdNext.Text = "&Next";
            this.cmdNext.Enabled = true;
            this.cmdPrevious.Enabled = true;
            switch (this.m_CurStep)
            {
                case 0:
                    if (this.optAction[1].Checked)
                    {
                        this.m_CurStep = 3;
                    }
                    break;

                case 2:
                    if (this.lstSelectedParameters.Items.Count != 0)
                    {
                        this.FillCorrelationTable();
                        this.cmdNext.Text = "&Generate";
                    }
                    else
                    {
                        MiscFUncs.MsgBox_Renamed("Select at least one parameter", 0x40, "Select parameter");
                        return;
                    }
                    break;

                case 3:
                    if (!this.GenerateInput())
                    {
                        this.cmdNext.Text = "&Generate";
                    }
                    else if (!this.Sample())
                    {
                        this.cmdNext.Text = "&Generate";
                    }
                    return;

                default:
                    break;
            }
            if (this.m_CurStep != 3)
            {
                this.m_CurStep = (short) (this.m_CurStep + 1);
                this.DisplayStep();
            }
            if ((this.m_CurStep == 3) & this.optAction[1].Checked)
            {
                this.cmdNext.Enabled = false;
                this.Width = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.Width) * 1.5));
                this.fraStep[4].Width = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.fraStep[4].Width) * 1.5));
                this.txtOutput.Width = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.txtOutput.Width) * 1.5));
                this.m_CurStep = (short) (this.m_CurStep + 1);
                this.DisplayStep();
            }
        }

        private void cmdPrevious_Click(object eventSender, EventArgs eventArgs)
        {
            this.cmdNext.Enabled = true;
            switch (this.m_CurStep)
            {
                case 2:
                    this.cmdPrevious.Enabled = false;
                    break;

                case 3:
                    this.cmdNext.Text = "&Next";
                    break;

                default:
                    break;
            }
            if (this.m_CurStep != 4)
            {
                this.m_CurStep = (short) (this.m_CurStep - 1);
            }
            else
            {
                this.m_CurStep = 0;
                this.Width = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.Width) / 1.5));
                this.fraStep[4].Width = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.fraStep[4].Width) / 1.5));
                this.txtOutput.Width = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.txtOutput.Width) / 1.5));
            }
            this.DisplayStep();
        }

        private void cmdRandomize_Click(object eventSender, EventArgs eventArgs)
        {
            VBMath.Randomize();
            this.txtSeed.Text = "-" + Conversions.ToString(Conversion.Int((float) ((32769f * VBMath.Rnd()) + 0f)));
        }

        private void cmdRemove_Click(object eventSender, EventArgs eventArgs)
        {
            ListBox lstSelectedParameters = this.lstSelectedParameters;
            if (!((lstSelectedParameters.Items.Count == 0) | (lstSelectedParameters.SelectedIndex == -1)))
            {
                this.m_Parameters.Remove((int) (this.lstSelectedParameters.SelectedIndex + 1));
                lstSelectedParameters.Items.RemoveAt(lstSelectedParameters.SelectedIndex);
                lstSelectedParameters = null;
                if (this.m_Parameters.Count == 0)
                {
                    this.cmdRemove.Enabled = false;
                }
            }
        }

        private bool convert()
        {
            // Invalid method body.
        }

        public void DisplayStep()
        {
            this.HideAll();
            this.fraStep[this.m_CurStep].Left = 0;
            if (this.m_CurStep == 4)
            {
                this.cmdNext.Enabled = false;
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

        private void FillCorrelationTable()
        {
            clsLHSParameters parameters = new clsLHSParameters();
            AxMSFlexGrid grdCorrelations = this.grdCorrelations;
            grdCorrelations.Rows = this.m_Parameters.Count + 1;
            grdCorrelations.Cols = this.m_Parameters.Count + 1;
            short count = (short) this.m_Parameters.Count;
            short row = 1;
            while (true)
            {
                short num9 = count;
                if (row > num9)
                {
                    short num4 = (short) this.m_Parameters.Count;
                    row = 1;
                    while (true)
                    {
                        num9 = num4;
                        if (row > num9)
                        {
                            short num2;
                            short num5 = (short) (grdCorrelations.Rows - 1);
                            row = 1;
                            while (row <= num5)
                            {
                                short num6 = (short) (grdCorrelations.Cols - 1);
                                num2 = row;
                                while (true)
                                {
                                    num9 = num6;
                                    if (num2 > num9)
                                    {
                                        row = (short) (row + 1);
                                        break;
                                    }
                                    grdCorrelations.Col = num2;
                                    grdCorrelations.Row = row;
                                    grdCorrelations.CellBackColor = ColorTranslator.FromOle(2);
                                    num2 = (short) (num2 + 1);
                                }
                            }
                            short num7 = (short) (grdCorrelations.Rows - 1);
                            row = 1;
                            while (row <= num7)
                            {
                                short num8 = row;
                                num2 = 1;
                                while (true)
                                {
                                    num9 = num8;
                                    if (num2 > num9)
                                    {
                                        row = (short) (row + 1);
                                        break;
                                    }
                                    grdCorrelations.set_TextMatrix(row, num2, Conversions.ToString(0));
                                    num2 = (short) (num2 + 1);
                                }
                            }
                            grdCorrelations = null;
                            return;
                        }
                        grdCorrelations.set_TextMatrix(row, 0, Conversions.ToString(NewLateBinding.LateGet(this.m_Parameters[row], null, "ParameterName", new object[0], null, null, null)));
                        row = (short) (row + 1);
                    }
                }
                grdCorrelations.set_TextMatrix(0, row, Conversions.ToString(NewLateBinding.LateGet(this.m_Parameters[row], null, "ParameterName", new object[0], null, null, null)));
                row = (short) (row + 1);
            }
        }

        private void frmWizard_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
            this.dbParameters.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
            this.dbParameters.RecordSource = "select * from [ParameterInfoSUFI] order by [ParameterName]";
            this.dbParameters.Refresh();
            this.cmbParameters.RowSource = this.dbParameters;
            this.cmbParameters.ListField = "ParameterName";
            this.dbProjectDatabase.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
            this.cmbParameters.ReFill();
            this.cmdPrevious.Enabled = false;
        }

        private bool GenerateInput()
        {
            // Invalid method body.
        }

        private short GetNumberOfCorrelations()
        {
            short cols = (short) this.grdCorrelations.Cols;
            short num3 = 0;
            short num6 = (short) (((short) this.grdCorrelations.Rows) - 1);
            short row = 1;
            while (row <= num6)
            {
                short num7 = (short) (cols - 1);
                short col = 1;
                while (true)
                {
                    short num8 = num7;
                    if (col > num8)
                    {
                        row = (short) (row + 1);
                        break;
                    }
                    if ((this.grdCorrelations.get_TextMatrix(row, col) != "0") & (Strings.Len(this.grdCorrelations.get_TextMatrix(row, col)) != 0))
                    {
                        num3 = (short) (num3 + 1);
                    }
                    col = (short) (col + 1);
                }
            }
            return num3;
        }

        private void grdCorrelations_ClickEvent(object eventSender, EventArgs eventArgs)
        {
            AxMSFlexGrid grdCorrelations = this.grdCorrelations;
            if (((grdCorrelations.Row > 0) & (grdCorrelations.Col > 0)) & (grdCorrelations.Row > grdCorrelations.Col))
            {
                this.lblPar1.Text = grdCorrelations.get_TextMatrix(0, grdCorrelations.Col);
                this.lblPar2.Text = grdCorrelations.get_TextMatrix(grdCorrelations.Row, 0);
                this.m_CorrPars[1] = (short) grdCorrelations.Row;
                this.m_CorrPars[2] = (short) grdCorrelations.Col;
                this.txtCorrelation.Text = grdCorrelations.get_TextMatrix(grdCorrelations.Row, grdCorrelations.Col);
            }
            grdCorrelations = null;
        }

        private void HideAll()
        {
            short num2 = this.fraStep.UBound();
            short num = 0;
            while (true)
            {
                short num3 = num2;
                if (num > num3)
                {
                    return;
                }
                this.fraStep[num].Left = (int) Math.Round(Support.TwipsToPixelsX(-10000.0));
                num = (short) (num + 1);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmLHS));
            this.tmrConvert = new Timer(this.components);
            this.tmrTabReg = new Timer(this.components);
            this.tmrUncert = new Timer(this.components);
            this._fraStep_4 = new GroupBox();
            this.txtOutput = new ListBox();
            this.cmdBrowse = new Button();
            this.txtOutputFile = new TextBox();
            this.cmdAnalyse = new Button();
            this.txtPrefix = new TextBox();
            this.Label21 = new Label();
            this.Label20 = new Label();
            this.Label19 = new Label();
            this.Label18 = new Label();
            this.Label12 = new Label();
            this._fraStep_0 = new GroupBox();
            this._optAction_1 = new RadioButton();
            this._optAction_0 = new RadioButton();
            this._lblStep_0 = new Label();
            this.cmdExit = new Button();
            this.dbProjectDatabase = new ADODC();
            this.cmdPrevious = new Button();
            this.cmdNext = new Button();
            this.dbParameters = new ADODC();
            this._fraStep_3 = new GroupBox();
            this.txtCorrelation = new TextBox();
            this.grdCorrelations = new AxMSFlexGrid();
            this.Label11 = new Label();
            this.Label17 = new Label();
            this.Label16 = new Label();
            this.lblPar2 = new Label();
            this.Label15 = new Label();
            this.lblPar1 = new Label();
            this.Label14 = new Label();
            this._fraStep_2 = new GroupBox();
            this.udHorizon = new NumericUpDown();
            this.cmdRemove = new Button();
            this.lstSelectedParameters = new ListBox();
            this.cmdAdd = new Button();
            this.chkAllHorizons = new CheckBox();
            this.cmdDistributions = new ComboBox();
            this.txtMax = new TextBox();
            this.txtMin = new TextBox();
            this.txtVariance = new TextBox();
            this.txtMean = new TextBox();
            this.cmbParameters = new AxDataCombo();
            this.Label13 = new Label();
            this._Label7_1 = new Label();
            this.Label9 = new Label();
            this.Label8 = new Label();
            this._Label7_0 = new Label();
            this.Label6 = new Label();
            this.Label5 = new Label();
            this.Label4 = new Label();
            this._fraStep_1 = new GroupBox();
            this.txtFilePrefix = new TextBox();
            this.txtNSims = new TextBox();
            this.cmdRandomize = new Button();
            this.txtSeed = new TextBox();
            this.txtTitle = new TextBox();
            this.Label10 = new Label();
            this.Label2 = new Label();
            this._Label3_0 = new Label();
            this._Label1_0 = new Label();
            this.Label1 = new LabelArray(this.components);
            this.Label3 = new LabelArray(this.components);
            this.Label7 = new LabelArray(this.components);
            this.fraStep = new GroupBoxArray(this.components);
            this.lblStep = new LabelArray(this.components);
            this.optAction = new RadioButtonArray(this.components);
            this._fraStep_4.SuspendLayout();
            this._fraStep_0.SuspendLayout();
            this._fraStep_3.SuspendLayout();
            this.grdCorrelations.BeginInit();
            this._fraStep_2.SuspendLayout();
            this.udHorizon.BeginInit();
            this.cmbParameters.BeginInit();
            this._fraStep_1.SuspendLayout();
            ((ISupportInitialize) this.Label1).BeginInit();
            ((ISupportInitialize) this.Label3).BeginInit();
            ((ISupportInitialize) this.Label7).BeginInit();
            ((ISupportInitialize) this.fraStep).BeginInit();
            ((ISupportInitialize) this.lblStep).BeginInit();
            ((ISupportInitialize) this.optAction).BeginInit();
            this.SuspendLayout();
            this.tmrConvert.Interval = 0xbb8;
            this.tmrTabReg.Interval = 0xbb8;
            this.tmrUncert.Interval = 0xbb8;
            this._fraStep_4.BackColor = SystemColors.Control;
            this._fraStep_4.Controls.Add(this.txtOutput);
            this._fraStep_4.Controls.Add(this.cmdBrowse);
            this._fraStep_4.Controls.Add(this.txtOutputFile);
            this._fraStep_4.Controls.Add(this.cmdAnalyse);
            this._fraStep_4.Controls.Add(this.txtPrefix);
            this._fraStep_4.Controls.Add(this.Label21);
            this._fraStep_4.Controls.Add(this.Label20);
            this._fraStep_4.Controls.Add(this.Label19);
            this._fraStep_4.Controls.Add(this.Label18);
            this._fraStep_4.Controls.Add(this.Label12);
            this._fraStep_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_4.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_4, 4);
            Point point = new Point(-666, 0);
            this._fraStep_4.Location = point;
            this._fraStep_4.Name = "_fraStep_4";
            this._fraStep_4.RightToLeft = RightToLeft.No;
            Size size = new Size(0x22d, 0x127);
            this._fraStep_4.Size = size;
            this._fraStep_4.TabIndex = 0x30;
            this._fraStep_4.TabStop = false;
            this._fraStep_4.Text = "Analyse";
            this.txtOutput.BackColor = SystemColors.Window;
            this.txtOutput.Cursor = Cursors.Default;
            this.txtOutput.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtOutput.ForeColor = SystemColors.WindowText;
            this.txtOutput.ItemHeight = 14;
            point = new Point(8, 0x98);
            this.txtOutput.Location = point;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.RightToLeft = RightToLeft.No;
            size = new Size(0x219, 130);
            this.txtOutput.Size = size;
            this.txtOutput.TabIndex = 0x38;
            this.cmdBrowse.BackColor = SystemColors.Control;
            this.cmdBrowse.Cursor = Cursors.Default;
            this.cmdBrowse.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowse.ForeColor = SystemColors.ControlText;
            point = new Point(0xe0, 0x80);
            this.cmdBrowse.Location = point;
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.cmdBrowse.Size = size;
            this.cmdBrowse.TabIndex = 0x37;
            this.cmdBrowse.Text = "...";
            this.cmdBrowse.UseVisualStyleBackColor = false;
            this.txtOutputFile.AcceptsReturn = true;
            this.txtOutputFile.BackColor = SystemColors.Window;
            this.txtOutputFile.Cursor = Cursors.IBeam;
            this.txtOutputFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtOutputFile.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x80);
            this.txtOutputFile.Location = point;
            this.txtOutputFile.MaxLength = 0;
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.RightToLeft = RightToLeft.No;
            size = new Size(0xd9, 20);
            this.txtOutputFile.Size = size;
            this.txtOutputFile.TabIndex = 0x36;
            this.cmdAnalyse.BackColor = SystemColors.Control;
            this.cmdAnalyse.Cursor = Cursors.Default;
            this.cmdAnalyse.Enabled = false;
            this.cmdAnalyse.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdAnalyse.ForeColor = SystemColors.ControlText;
            point = new Point(0xa8, 0x30);
            this.cmdAnalyse.Location = point;
            this.cmdAnalyse.Name = "cmdAnalyse";
            this.cmdAnalyse.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdAnalyse.Size = size;
            this.cmdAnalyse.TabIndex = 0x34;
            this.cmdAnalyse.Text = "&Analyse";
            this.cmdAnalyse.UseVisualStyleBackColor = false;
            this.txtPrefix.AcceptsReturn = true;
            this.txtPrefix.BackColor = SystemColors.Window;
            this.txtPrefix.Cursor = Cursors.IBeam;
            this.txtPrefix.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPrefix.ForeColor = SystemColors.WindowText;
            point = new Point(0x40, 0x18);
            this.txtPrefix.Location = point;
            this.txtPrefix.MaxLength = 0;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.RightToLeft = RightToLeft.No;
            size = new Size(0xb1, 20);
            this.txtPrefix.Size = size;
            this.txtPrefix.TabIndex = 50;
            this.Label21.BackColor = SystemColors.Control;
            this.Label21.Cursor = Cursors.Default;
            this.Label21.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label21.ForeColor = SystemColors.ControlText;
            point = new Point(0xf8, 8);
            this.Label21.Location = point;
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0x29);
            this.Label21.Size = size;
            this.Label21.TabIndex = 0x3a;
            this.Label21.Text = "The file prefix is the prefix you specified when sampling the parameter values. This is also the prefix of the UNCSAM *.sgn file.";
            this.Label20.BackColor = SystemColors.Control;
            this.Label20.Cursor = Cursors.Default;
            this.Label20.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label20.ForeColor = SystemColors.ControlText;
            point = new Point(0xf8, 0x60);
            this.Label20.Location = point;
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0x39);
            this.Label20.Size = size;
            this.Label20.TabIndex = 0x39;
            this.Label20.Text = manager.GetString("Label20.Text");
            this.Label19.BackColor = SystemColors.Control;
            this.Label19.Cursor = Cursors.Default;
            this.Label19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label19.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x70);
            this.Label19.Location = point;
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = RightToLeft.No;
            size = new Size(0xd9, 0x11);
            this.Label19.Size = size;
            this.Label19.TabIndex = 0x35;
            this.Label19.Text = "View output in file:";
            this.Label18.BackColor = SystemColors.Control;
            this.Label18.Cursor = Cursors.Default;
            this.Label18.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label18.ForeColor = SystemColors.ControlText;
            point = new Point(0xf8, 0x30);
            this.Label18.Location = point;
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = RightToLeft.No;
            size = new Size(0x131, 0x31);
            this.Label18.Size = size;
            this.Label18.TabIndex = 0x33;
            this.Label18.Text = "Please make sure that all the necessary files to run the UNCSAM programs SIMGEN, UNCERT and TABREG are in the MACRO 5.0 directory. These are executed when pressing 'Analyze'.";
            this.Label12.BackColor = SystemColors.Control;
            this.Label12.Cursor = Cursors.Default;
            this.Label12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label12.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label12.Location = point;
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label12.Size = size;
            this.Label12.TabIndex = 0x31;
            this.Label12.Text = "File prefix:";
            this._fraStep_0.BackColor = SystemColors.Control;
            this._fraStep_0.Controls.Add(this._optAction_1);
            this._fraStep_0.Controls.Add(this._optAction_0);
            this._fraStep_0.Controls.Add(this._lblStep_0);
            this._fraStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_0.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_0, 0);
            point = new Point(-666, 0);
            this._fraStep_0.Location = point;
            this._fraStep_0.Name = "_fraStep_0";
            this._fraStep_0.RightToLeft = RightToLeft.No;
            size = new Size(0x22d, 0x127);
            this._fraStep_0.Size = size;
            this._fraStep_0.TabIndex = 0x2c;
            this._fraStep_0.TabStop = false;
            this._fraStep_0.Text = "Select action:";
            this._optAction_1.BackColor = SystemColors.Control;
            this._optAction_1.Cursor = Cursors.Default;
            this._optAction_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optAction_1.ForeColor = SystemColors.ControlText;
            this.optAction.SetIndex(this._optAction_1, 1);
            point = new Point(8, 0x48);
            this._optAction_1.Location = point;
            this._optAction_1.Name = "_optAction_1";
            this._optAction_1.RightToLeft = RightToLeft.No;
            size = new Size(0x131, 0x11);
            this._optAction_1.Size = size;
            this._optAction_1.TabIndex = 0x2f;
            this._optAction_1.TabStop = true;
            this._optAction_1.Text = "analyse simulation results";
            this._optAction_1.UseVisualStyleBackColor = false;
            this._optAction_0.BackColor = SystemColors.Control;
            this._optAction_0.Checked = true;
            this._optAction_0.Cursor = Cursors.Default;
            this._optAction_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optAction_0.ForeColor = SystemColors.ControlText;
            this.optAction.SetIndex(this._optAction_0, 0);
            point = new Point(8, 0x30);
            this._optAction_0.Location = point;
            this._optAction_0.Name = "_optAction_0";
            this._optAction_0.RightToLeft = RightToLeft.No;
            size = new Size(0x139, 0x11);
            this._optAction_0.Size = size;
            this._optAction_0.TabIndex = 0x2e;
            this._optAction_0.TabStop = true;
            this._optAction_0.Text = "sample parameter values";
            this._optAction_0.UseVisualStyleBackColor = false;
            this._lblStep_0.BackColor = SystemColors.Control;
            this._lblStep_0.Cursor = Cursors.Default;
            this._lblStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_0.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_0, 0);
            point = new Point(8, 0x10);
            this._lblStep_0.Location = point;
            this._lblStep_0.Name = "_lblStep_0";
            this._lblStep_0.RightToLeft = RightToLeft.No;
            size = new Size(0x108, 0x11);
            this._lblStep_0.Size = size;
            this._lblStep_0.TabIndex = 0x2d;
            this._lblStep_0.Text = "What would you like to do:";
            this.cmdExit.BackColor = SystemColors.Control;
            this.cmdExit.Cursor = Cursors.Default;
            this.cmdExit.DialogResult = DialogResult.Cancel;
            this.cmdExit.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdExit.ForeColor = SystemColors.ControlText;
            point = new Point(330, 0x130);
            this.cmdExit.Location = point;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdExit.Size = size;
            this.cmdExit.TabIndex = 0x2a;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = false;
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
            point = new Point(0x170, 0x58);
            this.dbProjectDatabase.Location = point;
            this.dbProjectDatabase.LockType = LockTypeEnum.adLockPessimistic;
            this.dbProjectDatabase.Mode = ConnectModeEnum.adModeUnknown;
            this.dbProjectDatabase.Name = "dbProjectDatabase";
            this.dbProjectDatabase.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x69, 0x31);
            this.dbProjectDatabase.Size = size;
            this.dbProjectDatabase.TabIndex = 0x31;
            this.dbProjectDatabase.Text = "Adodc1";
            this.dbProjectDatabase.Visible = false;
            this.cmdPrevious.BackColor = SystemColors.Control;
            this.cmdPrevious.Cursor = Cursors.Default;
            this.cmdPrevious.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdPrevious.ForeColor = SystemColors.ControlText;
            point = new Point(0x199, 0x130);
            this.cmdPrevious.Location = point;
            this.cmdPrevious.Name = "cmdPrevious";
            this.cmdPrevious.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdPrevious.Size = size;
            this.cmdPrevious.TabIndex = 0x1a;
            this.cmdPrevious.Text = "&Previous";
            this.cmdPrevious.UseVisualStyleBackColor = false;
            this.cmdNext.BackColor = SystemColors.Control;
            this.cmdNext.Cursor = Cursors.Default;
            this.cmdNext.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdNext.ForeColor = SystemColors.ControlText;
            point = new Point(0x1e8, 0x130);
            this.cmdNext.Location = point;
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdNext.Size = size;
            this.cmdNext.TabIndex = 0x19;
            this.cmdNext.Text = "&Next";
            this.cmdNext.UseVisualStyleBackColor = false;
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
            point = new Point(40, 360);
            this.dbParameters.Location = point;
            this.dbParameters.LockType = LockTypeEnum.adLockPessimistic;
            this.dbParameters.Mode = ConnectModeEnum.adModeUnknown;
            this.dbParameters.Name = "dbParameters";
            this.dbParameters.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x61, 0x19);
            this.dbParameters.Size = size;
            this.dbParameters.TabIndex = 50;
            this.dbParameters.Text = "Adodc1";
            this.dbParameters.Visible = false;
            this._fraStep_3.BackColor = SystemColors.Control;
            this._fraStep_3.Controls.Add(this.txtCorrelation);
            this._fraStep_3.Controls.Add(this.grdCorrelations);
            this._fraStep_3.Controls.Add(this.Label11);
            this._fraStep_3.Controls.Add(this.Label17);
            this._fraStep_3.Controls.Add(this.Label16);
            this._fraStep_3.Controls.Add(this.lblPar2);
            this._fraStep_3.Controls.Add(this.Label15);
            this._fraStep_3.Controls.Add(this.lblPar1);
            this._fraStep_3.Controls.Add(this.Label14);
            this._fraStep_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_3.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_3, 3);
            point = new Point(3, 8);
            this._fraStep_3.Location = point;
            this._fraStep_3.Name = "_fraStep_3";
            this._fraStep_3.RightToLeft = RightToLeft.No;
            size = new Size(550, 0x119);
            this._fraStep_3.Size = size;
            this._fraStep_3.TabIndex = 2;
            this._fraStep_3.TabStop = false;
            this._fraStep_3.Text = "Correlations";
            this.txtCorrelation.AcceptsReturn = true;
            this.txtCorrelation.BackColor = SystemColors.Window;
            this.txtCorrelation.Cursor = Cursors.IBeam;
            this.txtCorrelation.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCorrelation.ForeColor = SystemColors.WindowText;
            point = new Point(0xf8, 0xc0);
            this.txtCorrelation.Location = point;
            this.txtCorrelation.MaxLength = 0;
            this.txtCorrelation.Name = "txtCorrelation";
            this.txtCorrelation.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 20);
            this.txtCorrelation.Size = size;
            this.txtCorrelation.TabIndex = 0x26;
            this.txtCorrelation.Text = "0";
            point = new Point(8, 0x18);
            this.grdCorrelations.Location = point;
            this.grdCorrelations.Name = "grdCorrelations";
            this.grdCorrelations.OcxState = (AxHost.State) manager.GetObject("grdCorrelations.OcxState");
            size = new Size(0x161, 0x91);
            this.grdCorrelations.Size = size;
            this.grdCorrelations.TabIndex = 0x18;
            this.Label11.BackColor = SystemColors.Control;
            this.Label11.Cursor = Cursors.Default;
            this.Label11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label11.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x100);
            this.Label11.Location = point;
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = RightToLeft.No;
            size = new Size(0x161, 0x21);
            this.Label11.Size = size;
            this.Label11.TabIndex = 0x2b;
            this.Label11.Text = "Click \"Generate\" to create the *.par file, the *.fam file and the *.sam file.";
            this.Label17.BackColor = SystemColors.Control;
            this.Label17.Cursor = Cursors.Default;
            this.Label17.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label17.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xe0);
            this.Label17.Location = point;
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = RightToLeft.No;
            size = new Size(0x171, 0x21);
            this.Label17.Size = size;
            this.Label17.TabIndex = 0x27;
            this.Label17.Text = "(click in table to change parameters, going back one step will erase the correlations)";
            this.Label16.BackColor = SystemColors.Control;
            this.Label16.Cursor = Cursors.Default;
            this.Label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label16.ForeColor = SystemColors.ControlText;
            point = new Point(240, 0xc0);
            this.Label16.Location = point;
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.Label16.Size = size;
            this.Label16.TabIndex = 0x25;
            this.Label16.Text = ":";
            this.lblPar2.BackColor = SystemColors.Window;
            this.lblPar2.BorderStyle = BorderStyle.FixedSingle;
            this.lblPar2.Cursor = Cursors.Default;
            this.lblPar2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblPar2.ForeColor = SystemColors.WindowText;
            point = new Point(0x70, 200);
            this.lblPar2.Location = point;
            this.lblPar2.Name = "lblPar2";
            this.lblPar2.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this.lblPar2.Size = size;
            this.lblPar2.TabIndex = 0x24;
            this.Label15.BackColor = SystemColors.Control;
            this.Label15.Cursor = Cursors.Default;
            this.Label15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label15.ForeColor = SystemColors.ControlText;
            point = new Point(0x48, 200);
            this.Label15.Location = point;
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x11);
            this.Label15.Size = size;
            this.Label15.TabIndex = 0x23;
            this.Label15.Text = "and";
            this.lblPar1.BackColor = SystemColors.Window;
            this.lblPar1.BorderStyle = BorderStyle.FixedSingle;
            this.lblPar1.Cursor = Cursors.Default;
            this.lblPar1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblPar1.ForeColor = SystemColors.WindowText;
            point = new Point(0x70, 0xb0);
            this.lblPar1.Location = point;
            this.lblPar1.Name = "lblPar1";
            this.lblPar1.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this.lblPar1.Size = size;
            this.lblPar1.TabIndex = 0x22;
            this.Label14.BackColor = SystemColors.Control;
            this.Label14.Cursor = Cursors.Default;
            this.Label14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label14.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xb0);
            this.Label14.Location = point;
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this.Label14.Size = size;
            this.Label14.TabIndex = 0x21;
            this.Label14.Text = "Correlation between ";
            this._fraStep_2.BackColor = SystemColors.Control;
            this._fraStep_2.Controls.Add(this.udHorizon);
            this._fraStep_2.Controls.Add(this.cmdRemove);
            this._fraStep_2.Controls.Add(this.lstSelectedParameters);
            this._fraStep_2.Controls.Add(this.cmdAdd);
            this._fraStep_2.Controls.Add(this.chkAllHorizons);
            this._fraStep_2.Controls.Add(this.cmdDistributions);
            this._fraStep_2.Controls.Add(this.txtMax);
            this._fraStep_2.Controls.Add(this.txtMin);
            this._fraStep_2.Controls.Add(this.txtVariance);
            this._fraStep_2.Controls.Add(this.txtMean);
            this._fraStep_2.Controls.Add(this.cmbParameters);
            this._fraStep_2.Controls.Add(this.Label13);
            this._fraStep_2.Controls.Add(this._Label7_1);
            this._fraStep_2.Controls.Add(this.Label9);
            this._fraStep_2.Controls.Add(this.Label8);
            this._fraStep_2.Controls.Add(this._Label7_0);
            this._fraStep_2.Controls.Add(this.Label6);
            this._fraStep_2.Controls.Add(this.Label5);
            this._fraStep_2.Controls.Add(this.Label4);
            this._fraStep_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_2.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_2, 2);
            point = new Point(0, 0);
            this._fraStep_2.Location = point;
            this._fraStep_2.Name = "_fraStep_2";
            this._fraStep_2.RightToLeft = RightToLeft.No;
            size = new Size(0x231, 0x127);
            this._fraStep_2.Size = size;
            this._fraStep_2.TabIndex = 1;
            this._fraStep_2.TabStop = false;
            this._fraStep_2.Text = "Add Parameter";
            point = new Point(320, 0x18);
            this.udHorizon.Location = point;
            decimal num = new decimal(new int[] { 10, 0, 0, 0 });
            this.udHorizon.Maximum = num;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.udHorizon.Minimum = num;
            this.udHorizon.Name = "udHorizon";
            size = new Size(0x29, 20);
            this.udHorizon.Size = size;
            this.udHorizon.TabIndex = 0x21;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.udHorizon.Value = num;
            this.cmdRemove.BackColor = SystemColors.Control;
            this.cmdRemove.Cursor = Cursors.Default;
            this.cmdRemove.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdRemove.ForeColor = SystemColors.ControlText;
            point = new Point(160, 0x108);
            this.cmdRemove.Location = point;
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x19);
            this.cmdRemove.Size = size;
            this.cmdRemove.TabIndex = 0x20;
            this.cmdRemove.Text = "&Remove";
            this.cmdRemove.UseVisualStyleBackColor = false;
            this.lstSelectedParameters.BackColor = SystemColors.Window;
            this.lstSelectedParameters.Cursor = Cursors.Default;
            this.lstSelectedParameters.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstSelectedParameters.ForeColor = SystemColors.WindowText;
            this.lstSelectedParameters.ItemHeight = 14;
            point = new Point(8, 0xa8);
            this.lstSelectedParameters.Location = point;
            this.lstSelectedParameters.Name = "lstSelectedParameters";
            this.lstSelectedParameters.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x74);
            this.lstSelectedParameters.Size = size;
            this.lstSelectedParameters.TabIndex = 30;
            this.cmdAdd.BackColor = SystemColors.Control;
            this.cmdAdd.Cursor = Cursors.Default;
            this.cmdAdd.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdAdd.ForeColor = SystemColors.ControlText;
            point = new Point(0x120, 0x70);
            this.cmdAdd.Location = point;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x21);
            this.cmdAdd.Size = size;
            this.cmdAdd.TabIndex = 0x1d;
            this.cmdAdd.Text = "&Add";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.chkAllHorizons.BackColor = SystemColors.Control;
            this.chkAllHorizons.Cursor = Cursors.Default;
            this.chkAllHorizons.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkAllHorizons.ForeColor = SystemColors.ControlText;
            point = new Point(0x110, 0x30);
            this.chkAllHorizons.Location = point;
            this.chkAllHorizons.Name = "chkAllHorizons";
            this.chkAllHorizons.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this.chkAllHorizons.Size = size;
            this.chkAllHorizons.TabIndex = 20;
            this.chkAllHorizons.Text = "Use all horizons";
            this.chkAllHorizons.UseVisualStyleBackColor = false;
            this.cmdDistributions.BackColor = SystemColors.Window;
            this.cmdDistributions.Cursor = Cursors.Default;
            this.cmdDistributions.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmdDistributions.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdDistributions.ForeColor = SystemColors.WindowText;
            object[] items = new object[] { "Normal", "Log-normal", "Uniform" };
            this.cmdDistributions.Items.AddRange(items);
            point = new Point(0x60, 0x38);
            this.cmdDistributions.Location = point;
            this.cmdDistributions.Name = "cmdDistributions";
            this.cmdDistributions.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x16);
            this.cmdDistributions.Size = size;
            this.cmdDistributions.TabIndex = 0x13;
            this.txtMax.AcceptsReturn = true;
            this.txtMax.BackColor = SystemColors.Window;
            this.txtMax.Cursor = Cursors.IBeam;
            this.txtMax.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtMax.ForeColor = SystemColors.WindowText;
            point = new Point(0x40, 120);
            this.txtMax.Location = point;
            this.txtMax.MaxLength = 0;
            this.txtMax.Name = "txtMax";
            this.txtMax.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this.txtMax.Size = size;
            this.txtMax.TabIndex = 0x12;
            this.txtMax.Text = "1";
            this.txtMin.AcceptsReturn = true;
            this.txtMin.BackColor = SystemColors.Window;
            this.txtMin.Cursor = Cursors.IBeam;
            this.txtMin.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtMin.ForeColor = SystemColors.WindowText;
            point = new Point(0xb0, 120);
            this.txtMin.Location = point;
            this.txtMin.MaxLength = 0;
            this.txtMin.Name = "txtMin";
            this.txtMin.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this.txtMin.Size = size;
            this.txtMin.TabIndex = 0x11;
            this.txtMin.Text = "-1";
            this.txtVariance.AcceptsReturn = true;
            this.txtVariance.BackColor = SystemColors.Window;
            this.txtVariance.Cursor = Cursors.IBeam;
            this.txtVariance.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtVariance.ForeColor = SystemColors.WindowText;
            point = new Point(0xb0, 0x60);
            this.txtVariance.Location = point;
            this.txtVariance.MaxLength = 0;
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this.txtVariance.Size = size;
            this.txtVariance.TabIndex = 0x10;
            this.txtVariance.Text = "1";
            this.txtMean.AcceptsReturn = true;
            this.txtMean.BackColor = SystemColors.Window;
            this.txtMean.Cursor = Cursors.IBeam;
            this.txtMean.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtMean.ForeColor = SystemColors.WindowText;
            point = new Point(0x40, 0x60);
            this.txtMean.Location = point;
            this.txtMean.MaxLength = 0;
            this.txtMean.Name = "txtMean";
            this.txtMean.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this.txtMean.Size = size;
            this.txtMean.TabIndex = 15;
            this.txtMean.Text = "0";
            point = new Point(0x60, 0x18);
            this.cmbParameters.Location = point;
            this.cmbParameters.Name = "cmbParameters";
            this.cmbParameters.OcxState = (AxHost.State) manager.GetObject("cmbParameters.OcxState");
            this.cmbParameters.RowSource = null;
            size = new Size(0x9e, 0x16);
            this.cmbParameters.Size = size;
            this.cmbParameters.TabIndex = 9;
            this.Label13.BackColor = SystemColors.Control;
            this.Label13.Cursor = Cursors.Default;
            this.Label13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label13.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x98);
            this.Label13.Location = point;
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 0x11);
            this.Label13.Size = size;
            this.Label13.TabIndex = 0x1f;
            this.Label13.Text = "Parameters added:";
            this._Label7_1.BackColor = SystemColors.Control;
            this._Label7_1.Cursor = Cursors.Default;
            this._Label7_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label7_1.ForeColor = SystemColors.ControlText;
            this.Label7.SetIndex(this._Label7_1, 1);
            point = new Point(0x110, 0x18);
            this._Label7_1.Location = point;
            this._Label7_1.Name = "_Label7_1";
            this._Label7_1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Label7_1.Size = size;
            this._Label7_1.TabIndex = 0x17;
            this._Label7_1.Text = "Horizon:";
            this.Label9.BackColor = SystemColors.Control;
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x7a);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label9.Size = size;
            this.Label9.TabIndex = 14;
            this.Label9.Text = "Maximum:";
            this.Label8.BackColor = SystemColors.Control;
            this.Label8.Cursor = Cursors.Default;
            this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = SystemColors.ControlText;
            point = new Point(120, 120);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label8.Size = size;
            this.Label8.TabIndex = 13;
            this.Label8.Text = "Minimum:";
            this._Label7_0.BackColor = SystemColors.Control;
            this._Label7_0.Cursor = Cursors.Default;
            this._Label7_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label7_0.ForeColor = SystemColors.ControlText;
            this.Label7.SetIndex(this._Label7_0, 0);
            point = new Point(120, 0x62);
            this._Label7_0.Location = point;
            this._Label7_0.Name = "_Label7_0";
            this._Label7_0.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Label7_0.Size = size;
            this._Label7_0.TabIndex = 12;
            this._Label7_0.Text = "Variance:";
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x62);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.Label6.Size = size;
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Mean:";
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Distribution:";
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Parameter name:";
            this._fraStep_1.BackColor = SystemColors.Control;
            this._fraStep_1.Controls.Add(this.txtFilePrefix);
            this._fraStep_1.Controls.Add(this.txtNSims);
            this._fraStep_1.Controls.Add(this.cmdRandomize);
            this._fraStep_1.Controls.Add(this.txtSeed);
            this._fraStep_1.Controls.Add(this.txtTitle);
            this._fraStep_1.Controls.Add(this.Label10);
            this._fraStep_1.Controls.Add(this.Label2);
            this._fraStep_1.Controls.Add(this._Label3_0);
            this._fraStep_1.Controls.Add(this._Label1_0);
            this._fraStep_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_1.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_1, 1);
            point = new Point(-666, 0);
            this._fraStep_1.Location = point;
            this._fraStep_1.Name = "_fraStep_1";
            this._fraStep_1.RightToLeft = RightToLeft.No;
            size = new Size(0x231, 0x127);
            this._fraStep_1.Size = size;
            this._fraStep_1.TabIndex = 0;
            this._fraStep_1.TabStop = false;
            this._fraStep_1.Text = "Project Information";
            this.txtFilePrefix.AcceptsReturn = true;
            this.txtFilePrefix.BackColor = SystemColors.Window;
            this.txtFilePrefix.Cursor = Cursors.IBeam;
            this.txtFilePrefix.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtFilePrefix.ForeColor = SystemColors.WindowText;
            point = new Point(0x40, 120);
            this.txtFilePrefix.Location = point;
            this.txtFilePrefix.MaxLength = 8;
            this.txtFilePrefix.Name = "txtFilePrefix";
            this.txtFilePrefix.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 20);
            this.txtFilePrefix.Size = size;
            this.txtFilePrefix.TabIndex = 0x29;
            this.txtFilePrefix.Text = "MACRO";
            this.txtNSims.AcceptsReturn = true;
            this.txtNSims.BackColor = SystemColors.Window;
            this.txtNSims.Cursor = Cursors.IBeam;
            this.txtNSims.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNSims.ForeColor = SystemColors.WindowText;
            point = new Point(120, 0x38);
            this.txtNSims.Location = point;
            this.txtNSims.MaxLength = 0;
            this.txtNSims.Name = "txtNSims";
            this.txtNSims.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 20);
            this.txtNSims.Size = size;
            this.txtNSims.TabIndex = 0x1c;
            this.txtNSims.Text = "50";
            this.cmdRandomize.BackColor = SystemColors.Control;
            this.cmdRandomize.Cursor = Cursors.Default;
            this.cmdRandomize.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdRandomize.ForeColor = SystemColors.ControlText;
            point = new Point(0xb0, 0x58);
            this.cmdRandomize.Location = point;
            this.cmdRandomize.Name = "cmdRandomize";
            this.cmdRandomize.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x13);
            this.cmdRandomize.Size = size;
            this.cmdRandomize.TabIndex = 7;
            this.cmdRandomize.Text = "&Randomize";
            this.cmdRandomize.UseVisualStyleBackColor = false;
            this.txtSeed.AcceptsReturn = true;
            this.txtSeed.BackColor = SystemColors.Window;
            this.txtSeed.Cursor = Cursors.IBeam;
            this.txtSeed.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtSeed.ForeColor = SystemColors.WindowText;
            point = new Point(80, 0x58);
            this.txtSeed.Location = point;
            this.txtSeed.MaxLength = 0;
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 20);
            this.txtSeed.Size = size;
            this.txtSeed.TabIndex = 6;
            this.txtSeed.Text = "-123456";
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.BackColor = SystemColors.Window;
            this.txtTitle.Cursor = Cursors.IBeam;
            this.txtTitle.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTitle.ForeColor = SystemColors.WindowText;
            point = new Point(0x30, 0x20);
            this.txtTitle.Location = point;
            this.txtTitle.MaxLength = 0x48;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = RightToLeft.No;
            size = new Size(0x149, 20);
            this.txtTitle.Size = size;
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "(project title)";
            this.Label10.BackColor = SystemColors.Control;
            this.Label10.Cursor = Cursors.Default;
            this.Label10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label10.ForeColor = SystemColors.ControlText;
            point = new Point(8, 120);
            this.Label10.Location = point;
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label10.Size = size;
            this.Label10.TabIndex = 40;
            this.Label10.Text = "File prefix:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 0x1b;
            this.Label2.Text = "Number of simulations:";
            this._Label3_0.BackColor = SystemColors.Control;
            this._Label3_0.Cursor = Cursors.Default;
            this._Label3_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label3_0.ForeColor = SystemColors.ControlText;
            this.Label3.SetIndex(this._Label3_0, 0);
            point = new Point(8, 0x58);
            this._Label3_0.Location = point;
            this._Label3_0.Name = "_Label3_0";
            this._Label3_0.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x11);
            this._Label3_0.Size = size;
            this._Label3_0.TabIndex = 5;
            this._Label3_0.Text = "Random seed:";
            this._Label1_0.BackColor = SystemColors.Control;
            this._Label1_0.Cursor = Cursors.Default;
            this._Label1_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label1_0.ForeColor = SystemColors.ControlText;
            this.Label1.SetIndex(this._Label1_0, 0);
            point = new Point(8, 0x20);
            this._Label1_0.Location = point;
            this._Label1_0.Name = "_Label1_0";
            this._Label1_0.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Label1_0.Size = size;
            this._Label1_0.TabIndex = 3;
            this._Label1_0.Text = "Title:";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdExit;
            size = new Size(0x23c, 0x151);
            this.ClientSize = size;
            this.Controls.Add(this._fraStep_2);
            this.Controls.Add(this._fraStep_4);
            this.Controls.Add(this._fraStep_0);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.dbProjectDatabase);
            this.Controls.Add(this.cmdPrevious);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.dbParameters);
            this.Controls.Add(this._fraStep_3);
            this.Controls.Add(this._fraStep_1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.Name = "CfrmLHS";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Monte-Carlo";
            this._fraStep_4.ResumeLayout(false);
            this._fraStep_4.PerformLayout();
            this._fraStep_0.ResumeLayout(false);
            this._fraStep_3.ResumeLayout(false);
            this._fraStep_3.PerformLayout();
            this.grdCorrelations.EndInit();
            this._fraStep_2.ResumeLayout(false);
            this._fraStep_2.PerformLayout();
            this.udHorizon.EndInit();
            this.cmbParameters.EndInit();
            this._fraStep_1.ResumeLayout(false);
            this._fraStep_1.PerformLayout();
            ((ISupportInitialize) this.Label1).EndInit();
            ((ISupportInitialize) this.Label3).EndInit();
            ((ISupportInitialize) this.Label7).EndInit();
            ((ISupportInitialize) this.fraStep).EndInit();
            ((ISupportInitialize) this.lblStep).EndInit();
            ((ISupportInitialize) this.optAction).EndInit();
            this.ResumeLayout(false);
        }

        private bool Sample()
        {
            // Invalid method body.
        }

        private bool SIMGEN()
        {
            // Invalid method body.
        }

        private bool TABREG()
        {
            // Invalid method body.
        }

        private void tmrConvert_Tick(object eventSender, EventArgs eventArgs)
        {
            this.tmrConvert.Enabled = false;
            this.convert();
        }

        private void tmrTabReg_Tick(object eventSender, EventArgs eventArgs)
        {
            this.TABREG();
            this.tmrTabReg.Enabled = false;
        }

        private void tmrUncert_Tick(object eventSender, EventArgs eventArgs)
        {
            this.UNCERT();
            this.tmrTabReg.Enabled = true;
            this.tmrUncert.Enabled = false;
        }

        private void txtCorrelation_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                this.grdCorrelations.set_TextMatrix(this.m_CorrPars[1], this.m_CorrPars[2], this.txtCorrelation.Text);
            }
        }

        private void txtPrefix_TextChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                this.cmdAnalyse.Enabled = Strings.Len(this.txtPrefix.Text) > 0;
            }
        }

        private bool UNCERT()
        {
            // Invalid method body.
        }

        public virtual Timer tmrConvert
        {
            [DebuggerNonUserCode]
            get => 
                this._tmrConvert;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.tmrConvert_Tick);
                if (!ReferenceEquals(this._tmrConvert, null))
                {
                    this._tmrConvert.Tick -= handler;
                }
                this._tmrConvert = value;
                if (!ReferenceEquals(this._tmrConvert, null))
                {
                    this._tmrConvert.Tick += handler;
                }
            }
        }

        public virtual Timer tmrTabReg
        {
            [DebuggerNonUserCode]
            get => 
                this._tmrTabReg;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.tmrTabReg_Tick);
                if (!ReferenceEquals(this._tmrTabReg, null))
                {
                    this._tmrTabReg.Tick -= handler;
                }
                this._tmrTabReg = value;
                if (!ReferenceEquals(this._tmrTabReg, null))
                {
                    this._tmrTabReg.Tick += handler;
                }
            }
        }

        public virtual Timer tmrUncert
        {
            [DebuggerNonUserCode]
            get => 
                this._tmrUncert;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.tmrUncert_Tick);
                if (!ReferenceEquals(this._tmrUncert, null))
                {
                    this._tmrUncert.Tick -= handler;
                }
                this._tmrUncert = value;
                if (!ReferenceEquals(this._tmrUncert, null))
                {
                    this._tmrUncert.Tick += handler;
                }
            }
        }

        public virtual ListBox txtOutput
        {
            [DebuggerNonUserCode]
            get => 
                this._txtOutput;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtOutput = value;
        }

        public virtual Button cmdBrowse
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowse;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowse_Click);
                if (!ReferenceEquals(this._cmdBrowse, null))
                {
                    this._cmdBrowse.Click -= handler;
                }
                this._cmdBrowse = value;
                if (!ReferenceEquals(this._cmdBrowse, null))
                {
                    this._cmdBrowse.Click += handler;
                }
            }
        }

        public virtual TextBox txtOutputFile
        {
            [DebuggerNonUserCode]
            get => 
                this._txtOutputFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtOutputFile = value;
        }

        public virtual Button cmdAnalyse
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdAnalyse;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdAnalyse_Click);
                if (!ReferenceEquals(this._cmdAnalyse, null))
                {
                    this._cmdAnalyse.Click -= handler;
                }
                this._cmdAnalyse = value;
                if (!ReferenceEquals(this._cmdAnalyse, null))
                {
                    this._cmdAnalyse.Click += handler;
                }
            }
        }

        public virtual TextBox txtPrefix
        {
            [DebuggerNonUserCode]
            get => 
                this._txtPrefix;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtPrefix_TextChanged);
                if (!ReferenceEquals(this._txtPrefix, null))
                {
                    this._txtPrefix.TextChanged -= handler;
                }
                this._txtPrefix = value;
                if (!ReferenceEquals(this._txtPrefix, null))
                {
                    this._txtPrefix.TextChanged += handler;
                }
            }
        }

        public virtual Label Label21
        {
            [DebuggerNonUserCode]
            get => 
                this._Label21;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label21 = value;
        }

        public virtual Label Label20
        {
            [DebuggerNonUserCode]
            get => 
                this._Label20;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label20 = value;
        }

        public virtual Label Label19
        {
            [DebuggerNonUserCode]
            get => 
                this._Label19;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label19 = value;
        }

        public virtual Label Label18
        {
            [DebuggerNonUserCode]
            get => 
                this._Label18;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label18 = value;
        }

        public virtual Label Label12
        {
            [DebuggerNonUserCode]
            get => 
                this._Label12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label12 = value;
        }

        public virtual GroupBox _fraStep_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_4 = value;
        }

        public virtual RadioButton _optAction_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optAction_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optAction_1 = value;
        }

        public virtual RadioButton _optAction_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optAction_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optAction_0 = value;
        }

        public virtual Label _lblStep_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblStep_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblStep_0 = value;
        }

        public virtual GroupBox _fraStep_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_0 = value;
        }

        public virtual Button cmdExit
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdExit;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdExit_Click);
                if (!ReferenceEquals(this._cmdExit, null))
                {
                    this._cmdExit.Click -= handler;
                }
                this._cmdExit = value;
                if (!ReferenceEquals(this._cmdExit, null))
                {
                    this._cmdExit.Click += handler;
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

        public virtual Button cmdPrevious
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdPrevious;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdPrevious_Click);
                if (!ReferenceEquals(this._cmdPrevious, null))
                {
                    this._cmdPrevious.Click -= handler;
                }
                this._cmdPrevious = value;
                if (!ReferenceEquals(this._cmdPrevious, null))
                {
                    this._cmdPrevious.Click += handler;
                }
            }
        }

        public virtual Button cmdNext
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdNext;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdNext_Click);
                if (!ReferenceEquals(this._cmdNext, null))
                {
                    this._cmdNext.Click -= handler;
                }
                this._cmdNext = value;
                if (!ReferenceEquals(this._cmdNext, null))
                {
                    this._cmdNext.Click += handler;
                }
            }
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

        public virtual TextBox txtCorrelation
        {
            [DebuggerNonUserCode]
            get => 
                this._txtCorrelation;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtCorrelation_TextChanged);
                if (!ReferenceEquals(this._txtCorrelation, null))
                {
                    this._txtCorrelation.TextChanged -= handler;
                }
                this._txtCorrelation = value;
                if (!ReferenceEquals(this._txtCorrelation, null))
                {
                    this._txtCorrelation.TextChanged += handler;
                }
            }
        }

        public virtual AxMSFlexGrid grdCorrelations
        {
            [DebuggerNonUserCode]
            get => 
                this._grdCorrelations;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.grdCorrelations_ClickEvent);
                if (!ReferenceEquals(this._grdCorrelations, null))
                {
                    this._grdCorrelations.ClickEvent -= handler;
                }
                this._grdCorrelations = value;
                if (!ReferenceEquals(this._grdCorrelations, null))
                {
                    this._grdCorrelations.ClickEvent += handler;
                }
            }
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

        public virtual Label Label17
        {
            [DebuggerNonUserCode]
            get => 
                this._Label17;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label17 = value;
        }

        public virtual Label Label16
        {
            [DebuggerNonUserCode]
            get => 
                this._Label16;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label16 = value;
        }

        public virtual Label lblPar2
        {
            [DebuggerNonUserCode]
            get => 
                this._lblPar2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblPar2 = value;
        }

        public virtual Label Label15
        {
            [DebuggerNonUserCode]
            get => 
                this._Label15;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label15 = value;
        }

        public virtual Label lblPar1
        {
            [DebuggerNonUserCode]
            get => 
                this._lblPar1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblPar1 = value;
        }

        public virtual Label Label14
        {
            [DebuggerNonUserCode]
            get => 
                this._Label14;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label14 = value;
        }

        public virtual GroupBox _fraStep_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_3 = value;
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

        public virtual ListBox lstSelectedParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._lstSelectedParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstSelectedParameters = value;
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

        public virtual CheckBox chkAllHorizons
        {
            [DebuggerNonUserCode]
            get => 
                this._chkAllHorizons;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkAllHorizons = value;
        }

        public virtual ComboBox cmdDistributions
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdDistributions;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdDistributions_SelectedIndexChanged);
                EventHandler handler2 = new EventHandler(this.cmdDistributions_TextChanged);
                if (!ReferenceEquals(this._cmdDistributions, null))
                {
                    this._cmdDistributions.SelectedIndexChanged -= handler;
                    this._cmdDistributions.TextChanged -= handler2;
                }
                this._cmdDistributions = value;
                if (!ReferenceEquals(this._cmdDistributions, null))
                {
                    this._cmdDistributions.SelectedIndexChanged += handler;
                    this._cmdDistributions.TextChanged += handler2;
                }
            }
        }

        public virtual TextBox txtMax
        {
            [DebuggerNonUserCode]
            get => 
                this._txtMax;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtMax = value;
        }

        public virtual TextBox txtMin
        {
            [DebuggerNonUserCode]
            get => 
                this._txtMin;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtMin = value;
        }

        public virtual TextBox txtVariance
        {
            [DebuggerNonUserCode]
            get => 
                this._txtVariance;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtVariance = value;
        }

        public virtual TextBox txtMean
        {
            [DebuggerNonUserCode]
            get => 
                this._txtMean;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtMean = value;
        }

        public virtual AxDataCombo cmbParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbParameters_Change);
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

        public virtual Label Label13
        {
            [DebuggerNonUserCode]
            get => 
                this._Label13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label13 = value;
        }

        public virtual Label _Label7_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label7_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label7_1 = value;
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

        public virtual Label _Label7_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label7_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label7_0 = value;
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

        public virtual GroupBox _fraStep_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_2 = value;
        }

        public virtual TextBox txtFilePrefix
        {
            [DebuggerNonUserCode]
            get => 
                this._txtFilePrefix;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtFilePrefix = value;
        }

        public virtual TextBox txtNSims
        {
            [DebuggerNonUserCode]
            get => 
                this._txtNSims;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtNSims = value;
        }

        public virtual Button cmdRandomize
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdRandomize;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdRandomize_Click);
                if (!ReferenceEquals(this._cmdRandomize, null))
                {
                    this._cmdRandomize.Click -= handler;
                }
                this._cmdRandomize = value;
                if (!ReferenceEquals(this._cmdRandomize, null))
                {
                    this._cmdRandomize.Click += handler;
                }
            }
        }

        public virtual TextBox txtSeed
        {
            [DebuggerNonUserCode]
            get => 
                this._txtSeed;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtSeed = value;
        }

        public virtual TextBox txtTitle
        {
            [DebuggerNonUserCode]
            get => 
                this._txtTitle;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtTitle = value;
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

        public virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label2 = value;
        }

        public virtual Label _Label3_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label3_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label3_0 = value;
        }

        public virtual Label _Label1_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label1_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label1_0 = value;
        }

        public virtual GroupBox _fraStep_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_1 = value;
        }

        public virtual LabelArray Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label1 = value;
        }

        public virtual LabelArray Label3
        {
            [DebuggerNonUserCode]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label3 = value;
        }

        public virtual LabelArray Label7
        {
            [DebuggerNonUserCode]
            get => 
                this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label7 = value;
        }

        public virtual GroupBoxArray fraStep
        {
            [DebuggerNonUserCode]
            get => 
                this._fraStep;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraStep = value;
        }

        public virtual LabelArray lblStep
        {
            [DebuggerNonUserCode]
            get => 
                this._lblStep;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblStep = value;
        }

        public virtual RadioButtonArray optAction
        {
            [DebuggerNonUserCode]
            get => 
                this._optAction;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optAction = value;
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

        public short RunID
        {
            set
            {
                this.m_RunID = value;
                this.rs = new RecordsetClass();
                this.rs.Open("select r_id from Properties where r_id=" + Conversions.ToString((int) this.m_RunID), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                this.udHorizon.Maximum = new decimal(ReadSaveFunctions.RecordCount(ref this.rs));
                if (decimal.Compare(this.udHorizon.Maximum, 0M) == 0)
                {
                    this.udHorizon.Maximum = 1M;
                }
                object[,] objArray = new object[Convert.ToInt32(this.udHorizon.Value) + 1, 2];
            }
        }
    }
}

