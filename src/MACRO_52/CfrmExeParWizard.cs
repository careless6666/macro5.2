namespace MACRO_52
{
    using ADODB;
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
    internal class CfrmExeParWizard : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("_fraStep_0")]
        private GroupBox __fraStep_0;
        [AccessedThroughProperty("_cmdStep_2")]
        private Button __cmdStep_2;
        [AccessedThroughProperty("_cmdStep_0")]
        private Button __cmdStep_0;
        [AccessedThroughProperty("_cmdStep_1")]
        private Button __cmdStep_1;
        [AccessedThroughProperty("txtPrefix")]
        private TextBox _txtPrefix;
        [AccessedThroughProperty("Dir1")]
        private DirListBox _Dir1;
        [AccessedThroughProperty("Drive1")]
        private DriveListBox _Drive1;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("_Label8_0")]
        private Label __Label8_0;
        [AccessedThroughProperty("_Label5_1")]
        private Label __Label5_1;
        [AccessedThroughProperty("_fraStep_3")]
        private GroupBox __fraStep_3;
        [AccessedThroughProperty("lstAvailableVariables")]
        private CheckedListBox _lstAvailableVariables;
        [AccessedThroughProperty("cmdBrowseForCondBinFile")]
        private Button _cmdBrowseForCondBinFile;
        [AccessedThroughProperty("txtOutputNames")]
        private TextBox _txtOutputNames;
        [AccessedThroughProperty("_Label7_1")]
        private Label __Label7_1;
        [AccessedThroughProperty("lblCondBinFile")]
        private Label _lblCondBinFile;
        [AccessedThroughProperty("_Label6_1")]
        private Label __Label6_1;
        [AccessedThroughProperty("_Label8_1")]
        private Label __Label8_1;
        [AccessedThroughProperty("_fraStep_4")]
        private GroupBox __fraStep_4;
        [AccessedThroughProperty("cmdOpenBase")]
        private Button _cmdOpenBase;
        [AccessedThroughProperty("dbProjectDatabase")]
        private ADODC _dbProjectDatabase;
        [AccessedThroughProperty("lblBaseSimulation")]
        private Label _lblBaseSimulation;
        [AccessedThroughProperty("lblBaseProject")]
        private Label _lblBaseProject;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("_lblStep_0")]
        private Label __lblStep_0;
        [AccessedThroughProperty("_fraStep_1")]
        private GroupBox __fraStep_1;
        [AccessedThroughProperty("_optFileFormat_1")]
        private RadioButton __optFileFormat_1;
        [AccessedThroughProperty("_optFileFormat_0")]
        private RadioButton __optFileFormat_0;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("cmdBrowse")]
        private Button _cmdBrowse;
        [AccessedThroughProperty("lblFileName")]
        private Label _lblFileName;
        [AccessedThroughProperty("_Label7_0")]
        private Label __Label7_0;
        [AccessedThroughProperty("_Label6_0")]
        private Label __Label6_0;
        [AccessedThroughProperty("_Label5_0")]
        private Label __Label5_0;
        [AccessedThroughProperty("_fraStep_2")]
        private GroupBox __fraStep_2;
        [AccessedThroughProperty("dbParameterInfo")]
        private ADODC _dbParameterInfo;
        [AccessedThroughProperty("dbMACROSimulation")]
        private ADODC _dbMACROSimulation;
        [AccessedThroughProperty("Label5")]
        private LabelArray _Label5;
        [AccessedThroughProperty("Label6")]
        private LabelArray _Label6;
        [AccessedThroughProperty("Label7")]
        private LabelArray _Label7;
        [AccessedThroughProperty("Label8")]
        private LabelArray _Label8;
        [AccessedThroughProperty("cmdStep")]
        private ButtonArray _cmdStep;
        [AccessedThroughProperty("fraStep")]
        private GroupBoxArray _fraStep;
        [AccessedThroughProperty("lblStep")]
        private LabelArray _lblStep;
        [AccessedThroughProperty("optFileFormat")]
        private RadioButtonArray _optFileFormat;
        private const short STEP_BASESIMULATION = 1;
        private const short STEP_PARVARFILE = 2;
        private const short STEP_UNCSAMOUTPUT = 4;
        private const short STEP_OUTPUTSETTINGS = 3;
        private const short STEP_INTRODUCTION = 0;
        private const short CMD_NEXT = 1;
        private const short CMD_PREV = 0;
        private const short CMD_CANCEL = 2;
        private const short OPT_MACROFILE = 0;
        private const short OPT_UNCSAMFILE = 1;
        private short CUR_STEP;
        private string m_BinFile;
        private short[] m_OutputIndexes;
        private short SUFIRunID;
        private string ParVarFileName;
        public int ParVarProjID;
        public int ParVarRunID;
        private string[] ParNames;
        private double[] ParValues;
        private double[,] ParFAMValues;
        private int nSimulations;
        private frmExecuteMACRO m_frm;
        public short CurrentSimNo;
        private int m_nSimulations;
        private short m_nParameters;
        private bool m_bNormalized;
        private short m_WaitedMinutes;
        private CfrmMain frmMain;
        private bool $STATIC$Dispose$20112$fTerminateCalled;

        public CfrmExeParWizard(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmExeParWizard_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
            this.m_frm = new frmExecuteMACRO(ref this.frmMain);
        }

        public bool BrowseForCondBinFile()
        {
            // Invalid method body.
        }

        private void cmdBrowse_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void cmdBrowseForCondBinFile_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.BrowseForCondBinFile() && this.FillVarsList(ref this.m_BinFile, ref this.lstAvailableVariables))
            {
            }
        }

        private void cmdOpenBase_Click(object eventSender, EventArgs eventArgs)
        {
            new frmOpen(ref this.frmMain) { OpeningBaseSimulation = true }.ShowDialog();
        }

        private void cmdStep_Click(object eventSender, EventArgs eventArgs)
        {
            switch (this.cmdStep.GetIndex((Button) eventSender))
            {
                case 0:
                    this.PreviousStep(ref this.CUR_STEP);
                    break;

                case 1:
                    this.NextStep(ref this.CUR_STEP);
                    break;

                case 2:
                    this.frmMain.Show();
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        private bool ControlStepData(ref short step_Renamed)
        {
            // Invalid method body.
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!this.$STATIC$Dispose$20112$fTerminateCalled)
                {
                    this.Form_Terminate_Renamed();
                    this.$STATIC$Dispose$20112$fTerminateCalled = true;
                }
                if (!ReferenceEquals(this.components, null))
                {
                    this.components.Dispose();
                }
            }
            base.Dispose(Disposing);
        }

        private void DoNext()
        {
            // Invalid method body.
        }

        private void Drive1_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        public bool ExecuteSimulations()
        {
            // Invalid method body.
        }

        private bool FillVarsList(ref string file, ref ListBox lst)
        {
            // Invalid method body.
        }

        private void Form_Terminate_Renamed()
        {
        }

        private void frmExeParWizard_Load(object eventSender, EventArgs eventArgs)
        {
            this.m_WaitedMinutes = 0;
            this.ParVarRunID = -1;
            this.dbProjectDatabase.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
            this.dbParameterInfo.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
            this.dbMACROSimulation.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
            this.Icon = this.frmMain.Icon;
            this.CUR_STEP = -1;
            this.NextStep(ref -1);
        }

        private void HideAll()
        {
            short num2 = (short) (this.fraStep.Count() - 1);
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmExeParWizard));
            this.Timer1 = new Timer(this.components);
            this._fraStep_0 = new GroupBox();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this._cmdStep_2 = new Button();
            this._cmdStep_0 = new Button();
            this._cmdStep_1 = new Button();
            this._fraStep_3 = new GroupBox();
            this.txtPrefix = new TextBox();
            this.Dir1 = new DirListBox();
            this.Drive1 = new DriveListBox();
            this.Label9 = new Label();
            this._Label8_0 = new Label();
            this._Label5_1 = new Label();
            this._fraStep_4 = new GroupBox();
            this.lstAvailableVariables = new CheckedListBox();
            this.cmdBrowseForCondBinFile = new Button();
            this.txtOutputNames = new TextBox();
            this._Label7_1 = new Label();
            this.lblCondBinFile = new Label();
            this._Label6_1 = new Label();
            this._Label8_1 = new Label();
            this._fraStep_1 = new GroupBox();
            this.Frame2 = new GroupBox();
            this.cmdOpenBase = new Button();
            this.dbProjectDatabase = new ADODC();
            this.lblBaseSimulation = new Label();
            this.lblBaseProject = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this._lblStep_0 = new Label();
            this._fraStep_2 = new GroupBox();
            this.Frame1 = new GroupBox();
            this._optFileFormat_1 = new RadioButton();
            this._optFileFormat_0 = new RadioButton();
            this.cmdBrowse = new Button();
            this.lblFileName = new Label();
            this._Label7_0 = new Label();
            this._Label6_0 = new Label();
            this._Label5_0 = new Label();
            this.dbParameterInfo = new ADODC();
            this.dbMACROSimulation = new ADODC();
            this.Label5 = new LabelArray(this.components);
            this.Label6 = new LabelArray(this.components);
            this.Label7 = new LabelArray(this.components);
            this.Label8 = new LabelArray(this.components);
            this.cmdStep = new ButtonArray(this.components);
            this.fraStep = new GroupBoxArray(this.components);
            this.lblStep = new LabelArray(this.components);
            this.optFileFormat = new RadioButtonArray(this.components);
            this._fraStep_0.SuspendLayout();
            this._fraStep_3.SuspendLayout();
            this._fraStep_4.SuspendLayout();
            this._fraStep_1.SuspendLayout();
            this.Frame2.SuspendLayout();
            this._fraStep_2.SuspendLayout();
            this.Frame1.SuspendLayout();
            ((ISupportInitialize) this.Label5).BeginInit();
            ((ISupportInitialize) this.Label6).BeginInit();
            ((ISupportInitialize) this.Label7).BeginInit();
            ((ISupportInitialize) this.Label8).BeginInit();
            ((ISupportInitialize) this.cmdStep).BeginInit();
            ((ISupportInitialize) this.fraStep).BeginInit();
            ((ISupportInitialize) this.lblStep).BeginInit();
            ((ISupportInitialize) this.optFileFormat).BeginInit();
            this.SuspendLayout();
            this.Timer1.Interval = 0xea60;
            this._fraStep_0.BackColor = SystemColors.Control;
            this._fraStep_0.Controls.Add(this.Label2);
            this._fraStep_0.Controls.Add(this.Label1);
            this._fraStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_0.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_0, 0);
            Point point = new Point(-666, 0);
            this._fraStep_0.Location = point;
            this._fraStep_0.Name = "_fraStep_0";
            this._fraStep_0.RightToLeft = RightToLeft.No;
            Size size = new Size(0x198, 0xef);
            this._fraStep_0.Size = size;
            this._fraStep_0.TabIndex = 14;
            this._fraStep_0.TabStop = false;
            this._fraStep_0.Text = "Introduction";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 0x48);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x121, 0x31);
            this.Label2.Size = size;
            this.Label2.TabIndex = 0x10;
            this.Label2.Text = "The pvf specifies the parameters, and their values, for a certain number of simulations. This file can be either in UNCSAM-format or a MACRO-default format.";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 0x20);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x121, 0x21);
            this.Label1.Size = size;
            this.Label1.TabIndex = 15;
            this.Label1.Text = "This wizard will guide you through the process of executing a parameter variation file (pvf). ";
            this._cmdStep_2.BackColor = SystemColors.Control;
            this._cmdStep_2.Cursor = Cursors.Default;
            this._cmdStep_2.DialogResult = DialogResult.Cancel;
            this._cmdStep_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmdStep_2.ForeColor = SystemColors.ControlText;
            this.cmdStep.SetIndex(this._cmdStep_2, 2);
            point = new Point(0xb8, 0xf8);
            this._cmdStep_2.Location = point;
            this._cmdStep_2.Name = "_cmdStep_2";
            this._cmdStep_2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x21);
            this._cmdStep_2.Size = size;
            this._cmdStep_2.TabIndex = 13;
            this._cmdStep_2.Text = "Cancel";
            this._cmdStep_2.UseVisualStyleBackColor = false;
            this._cmdStep_0.BackColor = SystemColors.Control;
            this._cmdStep_0.Cursor = Cursors.Default;
            this._cmdStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmdStep_0.ForeColor = SystemColors.ControlText;
            this.cmdStep.SetIndex(this._cmdStep_0, 0);
            point = new Point(0x108, 0xf8);
            this._cmdStep_0.Location = point;
            this._cmdStep_0.Name = "_cmdStep_0";
            this._cmdStep_0.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x21);
            this._cmdStep_0.Size = size;
            this._cmdStep_0.TabIndex = 12;
            this._cmdStep_0.Text = "&Previous";
            this._cmdStep_0.UseVisualStyleBackColor = false;
            this._cmdStep_1.BackColor = SystemColors.Control;
            this._cmdStep_1.Cursor = Cursors.Default;
            this._cmdStep_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmdStep_1.ForeColor = SystemColors.ControlText;
            this.cmdStep.SetIndex(this._cmdStep_1, 1);
            point = new Point(0x150, 0xf8);
            this._cmdStep_1.Location = point;
            this._cmdStep_1.Name = "_cmdStep_1";
            this._cmdStep_1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x21);
            this._cmdStep_1.Size = size;
            this._cmdStep_1.TabIndex = 11;
            this._cmdStep_1.Text = "&Next";
            this._cmdStep_1.UseVisualStyleBackColor = false;
            this._fraStep_3.BackColor = SystemColors.Control;
            this._fraStep_3.Controls.Add(this.txtPrefix);
            this._fraStep_3.Controls.Add(this.Dir1);
            this._fraStep_3.Controls.Add(this.Drive1);
            this._fraStep_3.Controls.Add(this.Label9);
            this._fraStep_3.Controls.Add(this._Label8_0);
            this._fraStep_3.Controls.Add(this._Label5_1);
            this._fraStep_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_3.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_3, 3);
            point = new Point(-666, 0);
            this._fraStep_3.Location = point;
            this._fraStep_3.Name = "_fraStep_3";
            this._fraStep_3.RightToLeft = RightToLeft.No;
            size = new Size(0x198, 0xef);
            this._fraStep_3.Size = size;
            this._fraStep_3.TabIndex = 3;
            this._fraStep_3.TabStop = false;
            this._fraStep_3.Text = "Output settings";
            this.txtPrefix.AcceptsReturn = true;
            this.txtPrefix.BackColor = SystemColors.Window;
            this.txtPrefix.Cursor = Cursors.IBeam;
            this.txtPrefix.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPrefix.ForeColor = SystemColors.WindowText;
            point = new Point(240, 0x26);
            this.txtPrefix.Location = point;
            this.txtPrefix.MaxLength = 0;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 20);
            this.txtPrefix.Size = size;
            this.txtPrefix.TabIndex = 0x1d;
            this.txtPrefix.Text = "MACRO";
            this.Dir1.BackColor = SystemColors.Window;
            this.Dir1.Cursor = Cursors.Default;
            this.Dir1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Dir1.ForeColor = SystemColors.WindowText;
            this.Dir1.FormattingEnabled = true;
            this.Dir1.IntegralHeight = false;
            point = new Point(8, 0x40);
            this.Dir1.Location = point;
            this.Dir1.Name = "Dir1";
            size = new Size(0x99, 0x60);
            this.Dir1.Size = size;
            this.Dir1.TabIndex = 0x1a;
            this.Drive1.BackColor = SystemColors.Window;
            this.Drive1.Cursor = Cursors.Default;
            this.Drive1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Drive1.ForeColor = SystemColors.WindowText;
            this.Drive1.FormattingEnabled = true;
            point = new Point(8, 40);
            this.Drive1.Location = point;
            this.Drive1.Name = "Drive1";
            size = new Size(0x99, 0x15);
            this.Drive1.Size = size;
            this.Drive1.TabIndex = 0x19;
            this.Label9.BackColor = SystemColors.Control;
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = SystemColors.ControlText;
            point = new Point(0xb8, 0x48);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            size = new Size(0xd9, 0x59);
            this.Label9.Size = size;
            this.Label9.TabIndex = 30;
            this.Label9.Text = "The generated output files will be moved to the selected directory and named according to <file prefix>_<simulation number>.";
            this._Label8_0.BackColor = SystemColors.Control;
            this._Label8_0.Cursor = Cursors.Default;
            this._Label8_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label8_0.ForeColor = SystemColors.ControlText;
            this.Label8.SetIndex(this._Label8_0, 0);
            point = new Point(0xb8, 40);
            this._Label8_0.Location = point;
            this._Label8_0.Name = "_Label8_0";
            this._Label8_0.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this._Label8_0.Size = size;
            this._Label8_0.TabIndex = 0x1c;
            this._Label8_0.Text = "File prefix:";
            this._Label5_1.BackColor = SystemColors.Control;
            this._Label5_1.Cursor = Cursors.Default;
            this._Label5_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label5_1.ForeColor = SystemColors.ControlText;
            this.Label5.SetIndex(this._Label5_1, 1);
            point = new Point(8, 0x18);
            this._Label5_1.Location = point;
            this._Label5_1.Name = "_Label5_1";
            this._Label5_1.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this._Label5_1.Size = size;
            this._Label5_1.TabIndex = 0x1b;
            this._Label5_1.Text = "Output file location:";
            this._fraStep_4.BackColor = SystemColors.Control;
            this._fraStep_4.Controls.Add(this.lstAvailableVariables);
            this._fraStep_4.Controls.Add(this.cmdBrowseForCondBinFile);
            this._fraStep_4.Controls.Add(this.txtOutputNames);
            this._fraStep_4.Controls.Add(this._Label7_1);
            this._fraStep_4.Controls.Add(this.lblCondBinFile);
            this._fraStep_4.Controls.Add(this._Label6_1);
            this._fraStep_4.Controls.Add(this._Label8_1);
            this._fraStep_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_4.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_4, 4);
            point = new Point(0, 0);
            this._fraStep_4.Location = point;
            this._fraStep_4.Name = "_fraStep_4";
            this._fraStep_4.RightToLeft = RightToLeft.No;
            size = new Size(0x1c8, 0xef);
            this._fraStep_4.Size = size;
            this._fraStep_4.TabIndex = 2;
            this._fraStep_4.TabStop = false;
            this._fraStep_4.Text = "Creating output files in UNCSAM format";
            this.lstAvailableVariables.BackColor = SystemColors.Window;
            this.lstAvailableVariables.Cursor = Cursors.Default;
            this.lstAvailableVariables.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstAvailableVariables.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0x60);
            this.lstAvailableVariables.Location = point;
            this.lstAvailableVariables.Name = "lstAvailableVariables";
            this.lstAvailableVariables.RightToLeft = RightToLeft.No;
            size = new Size(0x131, 0x40);
            this.lstAvailableVariables.Size = size;
            this.lstAvailableVariables.TabIndex = 0x21;
            this.cmdBrowseForCondBinFile.BackColor = SystemColors.Control;
            this.cmdBrowseForCondBinFile.Cursor = Cursors.Default;
            this.cmdBrowseForCondBinFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseForCondBinFile.ForeColor = SystemColors.ControlText;
            point = new Point(0x13f, 0x38);
            this.cmdBrowseForCondBinFile.Location = point;
            this.cmdBrowseForCondBinFile.Name = "cmdBrowseForCondBinFile";
            this.cmdBrowseForCondBinFile.RightToLeft = RightToLeft.No;
            size = new Size(0x25, 0x19);
            this.cmdBrowseForCondBinFile.Size = size;
            this.cmdBrowseForCondBinFile.TabIndex = 0x20;
            this.cmdBrowseForCondBinFile.Text = "...";
            this.cmdBrowseForCondBinFile.UseVisualStyleBackColor = false;
            this.txtOutputNames.AcceptsReturn = true;
            this.txtOutputNames.BackColor = SystemColors.Window;
            this.txtOutputNames.Cursor = Cursors.IBeam;
            this.txtOutputNames.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtOutputNames.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0xc0);
            this.txtOutputNames.Location = point;
            this.txtOutputNames.MaxLength = 0;
            this.txtOutputNames.Multiline = true;
            this.txtOutputNames.Name = "txtOutputNames";
            this.txtOutputNames.RightToLeft = RightToLeft.No;
            this.txtOutputNames.ScrollBars = ScrollBars.Vertical;
            size = new Size(0xb9, 0x2b);
            this.txtOutputNames.Size = size;
            this.txtOutputNames.TabIndex = 0x1f;
            this._Label7_1.BackColor = SystemColors.Control;
            this._Label7_1.Cursor = Cursors.Default;
            this._Label7_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label7_1.ForeColor = SystemColors.ControlText;
            this.Label7.SetIndex(this._Label7_1, 1);
            point = new Point(0x10, 80);
            this._Label7_1.Location = point;
            this._Label7_1.Name = "_Label7_1";
            this._Label7_1.RightToLeft = RightToLeft.No;
            size = new Size(0x181, 0x21);
            this._Label7_1.Size = size;
            this._Label7_1.TabIndex = 0x25;
            this._Label7_1.Text = "Check the output variables you want to write to UNCSAM's *.sgn-file:";
            this.lblCondBinFile.BackColor = SystemColors.Window;
            this.lblCondBinFile.BorderStyle = BorderStyle.FixedSingle;
            this.lblCondBinFile.Cursor = Cursors.Default;
            this.lblCondBinFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCondBinFile.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0x3f);
            this.lblCondBinFile.Location = point;
            this.lblCondBinFile.Name = "lblCondBinFile";
            this.lblCondBinFile.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0x11);
            this.lblCondBinFile.Size = size;
            this.lblCondBinFile.TabIndex = 0x24;
            this._Label6_1.BackColor = SystemColors.Control;
            this._Label6_1.Cursor = Cursors.Default;
            this._Label6_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label6_1.ForeColor = SystemColors.ControlText;
            this.Label6.SetIndex(this._Label6_1, 1);
            point = new Point(0x10, 0x10);
            this._Label6_1.Location = point;
            this._Label6_1.Name = "_Label6_1";
            this._Label6_1.RightToLeft = RightToLeft.No;
            size = new Size(0x1b2, 0x39);
            this._Label6_1.Size = size;
            this._Label6_1.TabIndex = 0x23;
            this._Label6_1.Text = manager.GetString("_Label6_1.Text");
            this._Label8_1.BackColor = SystemColors.Control;
            this._Label8_1.Cursor = Cursors.Default;
            this._Label8_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label8_1.ForeColor = SystemColors.ControlText;
            this.Label8.SetIndex(this._Label8_1, 1);
            point = new Point(0x10, 160);
            this._Label8_1.Location = point;
            this._Label8_1.Name = "_Label8_1";
            this._Label8_1.RightToLeft = RightToLeft.No;
            size = new Size(0x179, 0x29);
            this._Label8_1.Size = size;
            this._Label8_1.TabIndex = 0x22;
            this._Label8_1.Text = "Specify MACRO variable names (in a space separated list; these names are written to the *.sgn file and should correspond to the above selected outputs):";
            this._fraStep_1.BackColor = SystemColors.Control;
            this._fraStep_1.Controls.Add(this.Frame2);
            this._fraStep_1.Controls.Add(this._lblStep_0);
            this._fraStep_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_1.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_1, 1);
            point = new Point(-666, 0);
            this._fraStep_1.Location = point;
            this._fraStep_1.Name = "_fraStep_1";
            this._fraStep_1.RightToLeft = RightToLeft.No;
            size = new Size(0x198, 0xef);
            this._fraStep_1.Size = size;
            this._fraStep_1.TabIndex = 1;
            this._fraStep_1.TabStop = false;
            this._fraStep_1.Text = "Base simulation";
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this.cmdOpenBase);
            this.Frame2.Controls.Add(this.dbProjectDatabase);
            this.Frame2.Controls.Add(this.lblBaseSimulation);
            this.Frame2.Controls.Add(this.lblBaseProject);
            this.Frame2.Controls.Add(this.Label3);
            this.Frame2.Controls.Add(this.Label4);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x40);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0x69);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 5;
            this.Frame2.TabStop = false;
            this.cmdOpenBase.BackColor = SystemColors.Control;
            this.cmdOpenBase.Cursor = Cursors.Default;
            this.cmdOpenBase.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOpenBase.ForeColor = SystemColors.ControlText;
            point = new Point(0xb8, 0x48);
            this.cmdOpenBase.Location = point;
            this.cmdOpenBase.Name = "cmdOpenBase";
            this.cmdOpenBase.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x19);
            this.cmdOpenBase.Size = size;
            this.cmdOpenBase.TabIndex = 6;
            this.cmdOpenBase.Text = "&Open";
            this.cmdOpenBase.UseVisualStyleBackColor = false;
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
            this.dbProjectDatabase.TabIndex = 7;
            this.dbProjectDatabase.Text = "Adodc1";
            this.dbProjectDatabase.Visible = false;
            this.lblBaseSimulation.BackColor = SystemColors.Window;
            this.lblBaseSimulation.BorderStyle = BorderStyle.FixedSingle;
            this.lblBaseSimulation.Cursor = Cursors.Default;
            this.lblBaseSimulation.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblBaseSimulation.ForeColor = SystemColors.WindowText;
            point = new Point(0x58, 0x30);
            this.lblBaseSimulation.Location = point;
            this.lblBaseSimulation.Name = "lblBaseSimulation";
            this.lblBaseSimulation.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this.lblBaseSimulation.Size = size;
            this.lblBaseSimulation.TabIndex = 10;
            this.lblBaseProject.BackColor = SystemColors.Window;
            this.lblBaseProject.BorderStyle = BorderStyle.FixedSingle;
            this.lblBaseProject.Cursor = Cursors.Default;
            this.lblBaseProject.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblBaseProject.ForeColor = SystemColors.WindowText;
            point = new Point(0x58, 0x10);
            this.lblBaseProject.Location = point;
            this.lblBaseProject.Name = "lblBaseProject";
            this.lblBaseProject.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this.lblBaseProject.Size = size;
            this.lblBaseProject.TabIndex = 9;
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x34);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Simulation:";
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 20);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Project:";
            this._lblStep_0.BackColor = SystemColors.Control;
            this._lblStep_0.Cursor = Cursors.Default;
            this._lblStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_0.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_0, 0);
            point = new Point(0x10, 0x18);
            this._lblStep_0.Location = point;
            this._lblStep_0.Name = "_lblStep_0";
            this._lblStep_0.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x19);
            this._lblStep_0.Size = size;
            this._lblStep_0.TabIndex = 4;
            this._lblStep_0.Text = "Select the base simulation to use. It is the base simulation's parameter values that will be varied.";
            this._fraStep_2.BackColor = SystemColors.Control;
            this._fraStep_2.Controls.Add(this.Frame1);
            this._fraStep_2.Controls.Add(this.cmdBrowse);
            this._fraStep_2.Controls.Add(this.lblFileName);
            this._fraStep_2.Controls.Add(this._Label7_0);
            this._fraStep_2.Controls.Add(this._Label6_0);
            this._fraStep_2.Controls.Add(this._Label5_0);
            this._fraStep_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_2.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_2, 2);
            point = new Point(-666, 0);
            this._fraStep_2.Location = point;
            this._fraStep_2.Name = "_fraStep_2";
            this._fraStep_2.RightToLeft = RightToLeft.No;
            size = new Size(0x198, 0xef);
            this._fraStep_2.Size = size;
            this._fraStep_2.TabIndex = 0;
            this._fraStep_2.TabStop = false;
            this._fraStep_2.Text = "Parameter variation file";
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this._optFileFormat_1);
            this.Frame1.Controls.Add(this._optFileFormat_0);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x98);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0xd1, 0x49);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0x16;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "File format";
            this._optFileFormat_1.BackColor = SystemColors.Control;
            this._optFileFormat_1.Cursor = Cursors.Default;
            this._optFileFormat_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optFileFormat_1.ForeColor = SystemColors.ControlText;
            this.optFileFormat.SetIndex(this._optFileFormat_1, 1);
            point = new Point(8, 40);
            this._optFileFormat_1.Location = point;
            this._optFileFormat_1.Name = "_optFileFormat_1";
            this._optFileFormat_1.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x11);
            this._optFileFormat_1.Size = size;
            this._optFileFormat_1.TabIndex = 0x18;
            this._optFileFormat_1.TabStop = true;
            this._optFileFormat_1.Text = "UNCSAM format";
            this._optFileFormat_1.UseVisualStyleBackColor = false;
            this._optFileFormat_0.BackColor = SystemColors.Control;
            this._optFileFormat_0.Checked = true;
            this._optFileFormat_0.Cursor = Cursors.Default;
            this._optFileFormat_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optFileFormat_0.ForeColor = SystemColors.ControlText;
            this.optFileFormat.SetIndex(this._optFileFormat_0, 0);
            point = new Point(8, 0x10);
            this._optFileFormat_0.Location = point;
            this._optFileFormat_0.Name = "_optFileFormat_0";
            this._optFileFormat_0.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x11);
            this._optFileFormat_0.Size = size;
            this._optFileFormat_0.TabIndex = 0x17;
            this._optFileFormat_0.TabStop = true;
            this._optFileFormat_0.Text = "MACRO default";
            this._optFileFormat_0.UseVisualStyleBackColor = false;
            this.cmdBrowse.BackColor = SystemColors.Control;
            this.cmdBrowse.Cursor = Cursors.Default;
            this.cmdBrowse.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowse.ForeColor = SystemColors.ControlText;
            point = new Point(360, 120);
            this.cmdBrowse.Location = point;
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.cmdBrowse.Size = size;
            this.cmdBrowse.TabIndex = 0x15;
            this.cmdBrowse.Text = "&...";
            this.cmdBrowse.UseVisualStyleBackColor = false;
            this.lblFileName.BackColor = SystemColors.Window;
            this.lblFileName.BorderStyle = BorderStyle.FixedSingle;
            this.lblFileName.Cursor = Cursors.Default;
            this.lblFileName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblFileName.ForeColor = SystemColors.WindowText;
            point = new Point(0x80, 120);
            this.lblFileName.Location = point;
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this.lblFileName.Size = size;
            this.lblFileName.TabIndex = 20;
            this._Label7_0.BackColor = SystemColors.Control;
            this._Label7_0.Cursor = Cursors.Default;
            this._Label7_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label7_0.ForeColor = SystemColors.ControlText;
            this.Label7.SetIndex(this._Label7_0, 0);
            point = new Point(8, 120);
            this._Label7_0.Location = point;
            this._Label7_0.Name = "_Label7_0";
            this._Label7_0.RightToLeft = RightToLeft.No;
            size = new Size(0x89, 0x11);
            this._Label7_0.Size = size;
            this._Label7_0.TabIndex = 0x13;
            this._Label7_0.Text = "Parameter variation file:";
            this._Label6_0.BackColor = SystemColors.Control;
            this._Label6_0.Cursor = Cursors.Default;
            this._Label6_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label6_0.ForeColor = SystemColors.ControlText;
            this.Label6.SetIndex(this._Label6_0, 0);
            point = new Point(8, 0x38);
            this._Label6_0.Location = point;
            this._Label6_0.Name = "_Label6_0";
            this._Label6_0.RightToLeft = RightToLeft.No;
            size = new Size(0x189, 0x29);
            this._Label6_0.Size = size;
            this._Label6_0.TabIndex = 0x12;
            this._Label6_0.Text = manager.GetString("_Label6_0.Text");
            this._Label5_0.BackColor = SystemColors.Control;
            this._Label5_0.Cursor = Cursors.Default;
            this._Label5_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label5_0.ForeColor = SystemColors.ControlText;
            this.Label5.SetIndex(this._Label5_0, 0);
            point = new Point(8, 0x10);
            this._Label5_0.Location = point;
            this._Label5_0.Name = "_Label5_0";
            this._Label5_0.RightToLeft = RightToLeft.No;
            size = new Size(0x119, 0x21);
            this._Label5_0.Size = size;
            this._Label5_0.TabIndex = 0x11;
            this._Label5_0.Text = "Select the file to be used as parameter variation file and indicate in which format the file is.";
            this.dbParameterInfo.BackColor = SystemColors.Window;
            this.dbParameterInfo.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.dbParameterInfo.CommandTimeout = 0;
            this.dbParameterInfo.CommandType = CommandTypeEnum.adCmdUnknown;
            this.dbParameterInfo.ConnectionString = null;
            this.dbParameterInfo.CursorLocation = CursorLocationEnum.adUseClient;
            this.dbParameterInfo.CursorType = CursorTypeEnum.adOpenStatic;
            this.dbParameterInfo.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.dbParameterInfo.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dbParameterInfo.ForeColor = SystemColors.WindowText;
            point = new Point(0, 0);
            this.dbParameterInfo.Location = point;
            this.dbParameterInfo.LockType = LockTypeEnum.adLockPessimistic;
            this.dbParameterInfo.Mode = ConnectModeEnum.adModeUnknown;
            this.dbParameterInfo.Name = "dbParameterInfo";
            this.dbParameterInfo.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x81, 0x19);
            this.dbParameterInfo.Size = size;
            this.dbParameterInfo.TabIndex = 15;
            this.dbParameterInfo.Text = "Adodc1";
            this.dbParameterInfo.Visible = false;
            this.dbMACROSimulation.BackColor = SystemColors.Window;
            this.dbMACROSimulation.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.dbMACROSimulation.CommandTimeout = 0;
            this.dbMACROSimulation.CommandType = CommandTypeEnum.adCmdUnknown;
            this.dbMACROSimulation.ConnectionString = null;
            this.dbMACROSimulation.CursorLocation = CursorLocationEnum.adUseClient;
            this.dbMACROSimulation.CursorType = CursorTypeEnum.adOpenStatic;
            this.dbMACROSimulation.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.dbMACROSimulation.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dbMACROSimulation.ForeColor = SystemColors.WindowText;
            point = new Point(0, 0);
            this.dbMACROSimulation.Location = point;
            this.dbMACROSimulation.LockType = LockTypeEnum.adLockPessimistic;
            this.dbMACROSimulation.Mode = ConnectModeEnum.adModeUnknown;
            this.dbMACROSimulation.Name = "dbMACROSimulation";
            this.dbMACROSimulation.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x69, 0x16);
            this.dbMACROSimulation.Size = size;
            this.dbMACROSimulation.TabIndex = 0x10;
            this.dbMACROSimulation.Text = "Adodc1";
            this.dbMACROSimulation.Visible = false;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this._cmdStep_2;
            size = new Size(0x1d4, 0x11e);
            this.ClientSize = size;
            this.Controls.Add(this._fraStep_0);
            this.Controls.Add(this._cmdStep_2);
            this.Controls.Add(this._cmdStep_0);
            this.Controls.Add(this._cmdStep_1);
            this.Controls.Add(this._fraStep_3);
            this.Controls.Add(this._fraStep_4);
            this.Controls.Add(this._fraStep_1);
            this.Controls.Add(this._fraStep_2);
            this.Controls.Add(this.dbParameterInfo);
            this.Controls.Add(this.dbMACROSimulation);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmExeParWizard";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Execute parameter variation file";
            this._fraStep_0.ResumeLayout(false);
            this._fraStep_3.ResumeLayout(false);
            this._fraStep_3.PerformLayout();
            this._fraStep_4.ResumeLayout(false);
            this._fraStep_4.PerformLayout();
            this._fraStep_1.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this._fraStep_2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            ((ISupportInitialize) this.Label5).EndInit();
            ((ISupportInitialize) this.Label6).EndInit();
            ((ISupportInitialize) this.Label7).EndInit();
            ((ISupportInitialize) this.Label8).EndInit();
            ((ISupportInitialize) this.cmdStep).EndInit();
            ((ISupportInitialize) this.fraStep).EndInit();
            ((ISupportInitialize) this.lblStep).EndInit();
            ((ISupportInitialize) this.optFileFormat).EndInit();
            this.ResumeLayout(false);
        }

        private bool ModifyBaseSimulation()
        {
            // Invalid method body.
        }

        private void ModifyZKD(ref float value)
        {
            // Invalid method body.
        }

        public void MoveOutputFiles()
        {
            // Invalid method body.
        }

        public void NextSimulation()
        {
            // Invalid method body.
        }

        private void NextStep(ref short step_Renamed)
        {
            if (this.ControlStepData(ref step_Renamed))
            {
                this.cmdStep[0].Enabled = step_Renamed >= 0;
                short num = step_Renamed;
                if (num != ((short) (this.fraStep.Count() - 1)))
                {
                    if ((num != 0) && (num == -1))
                    {
                        this.cmdStep[0].Enabled = false;
                    }
                    this.cmdStep[1].Text = (step_Renamed != (this.fraStep.Count() - 2)) ? "&Next" : "E&xecute";
                    this.CUR_STEP = (short) (this.CUR_STEP + 1);
                    this.HideAll();
                    this.fraStep[this.CUR_STEP].Left = 0;
                }
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (!this.ReadParVarFile())
                    {
                        this.Cursor = Cursors.Default;
                    }
                    else
                    {
                        this.SetOutputIndexes();
                        FileSystem.FileClose(new int[0]);
                        this.Cursor = Cursors.Default;
                        this.ExecuteSimulations();
                    }
                }
            }
        }

        private int NumberOfSimulations(ref string fname)
        {
            // Invalid method body.
        }

        private void PreviousStep(ref short step_Renamed)
        {
            this.HideAll();
            this.cmdStep[0].Enabled = step_Renamed != 1;
            this.cmdStep[1].Text = "&Next";
            this.CUR_STEP = (short) (this.CUR_STEP - 1);
            this.fraStep[this.CUR_STEP].Left = 0;
        }

        private bool ReadParVarFile()
        {
            // Invalid method body.
        }

        private void SetButtons()
        {
            if (this.CUR_STEP == 0)
            {
                this.cmdStep[0].Enabled = false;
            }
            if (this.CUR_STEP == this.fraStep.Count())
            {
                this.cmdStep[1].Text = "E&xecute";
            }
        }

        private void SetOutputIndexes()
        {
            short index = 1;
            CheckedListBox lstAvailableVariables = this.lstAvailableVariables;
            this.m_OutputIndexes = new short[lstAvailableVariables.CheckedIndices.Count + 1];
            short num3 = (short) (lstAvailableVariables.Items.Count - 1);
            short num = 0;
            while (true)
            {
                short num4 = num3;
                if (num > num4)
                {
                    lstAvailableVariables = null;
                    return;
                }
                if (lstAvailableVariables.GetItemChecked(num))
                {
                    this.m_OutputIndexes[index] = (short) (num + 1);
                    index = (short) (index + 1);
                }
                num = (short) (num + 1);
            }
        }

        private void Timer1_Tick(object eventSender, EventArgs eventArgs)
        {
            this.Timer1.Enabled = false;
            this.DoNext();
        }

        private bool WriteFAMFile()
        {
            // Invalid method body.
        }

        private void WriteFAMFileHeading(ref short fp)
        {
            object[] output = new object[] { "#1 " + Conversions.ToString(DateAndTime.Today) };
            FileSystem.PrintLine(fp, output);
            output = new object[] { "#2 UNCSAM-CONVER [RIVM] Version 1.1a" };
            FileSystem.PrintLine(fp, output);
            output = new object[] { "#3  Copyright (c) RIVM/CWM, 1992" };
            FileSystem.PrintLine(fp, output);
            output = new object[] { this.txtPrefix.Text };
            FileSystem.PrintLine(fp, output);
            output = new object[1];
            string[] strArray = new string[] { Strings.Space(12 - Strings.Len(Conversions.ToString((int) this.m_nParameters))), Conversions.ToString(this.m_nSimulations), Strings.Space(11), "0", Strings.Space(12 - Strings.Len(Conversions.ToString((int) this.m_nParameters))), Conversions.ToString((int) this.m_nParameters), Strings.Space(12 - Strings.Len(Conversions.ToString(-16453))), "-16453" };
            output[0] = string.Concat(strArray);
            FileSystem.PrintLine(fp, output);
        }

        private void WriteFAMFileParameterNames(ref short fp)
        {
            object[] output = new object[] { Strings.Space(6) };
            FileSystem.Print(fp, output);
            short nParameters = this.m_nParameters;
            short index = 1;
            while (index <= nParameters)
            {
                string expression = "";
                if (this.m_bNormalized)
                {
                    expression = "n";
                }
                expression = expression + this.ParNames[index];
                short num4 = (short) (8 - Strings.Len(expression));
                short num2 = 1;
                while (true)
                {
                    short num5 = num4;
                    if (num2 > num5)
                    {
                        if (Strings.Len(expression) > 8)
                        {
                            expression = Strings.Mid(expression, 1, 7) + Strings.Mid(expression, Strings.Len(expression));
                        }
                        if (index == this.m_nParameters)
                        {
                            FileSystem.PrintLine(fp, new object[] { expression });
                        }
                        else
                        {
                            FileSystem.Print(fp, new object[] { expression });
                            output = new object[] { Strings.Space(0x10) };
                            FileSystem.Print(fp, output);
                        }
                        index = (short) (index + 1);
                        break;
                    }
                    expression = expression + "#";
                    num2 = (short) (num2 + 1);
                }
            }
        }

        private void WriteParameterArrayFAM(ref short ItemsPerLine, ref double[,] Values, ref short fp, ref string fm)
        {
            short num3 = (short) Information.UBound(Values, 1);
            short num = 1;
            while (num <= num3)
            {
                object[] output = new object[] { Strings.Space(3) };
                FileSystem.Print(fp, output);
                short num4 = (short) (Information.UBound(Values, 2) - 1);
                short num2 = 1;
                while (true)
                {
                    short num5 = num4;
                    if (num2 > num5)
                    {
                        output = new object[] { Strings.Replace(Support.Format(Values[num, num2], fm, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1), ",", ".", 1, -1, CompareMethod.Binary) };
                        FileSystem.PrintLine(fp, output);
                        num = (short) (num + 1);
                        break;
                    }
                    output = new object[] { Strings.Replace(Support.Format(Values[num, num2], fm, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1), ",", ".", 1, -1, CompareMethod.Binary) + Strings.Space(3) };
                    FileSystem.Print(fp, output);
                    num2 = (short) (num2 + 1);
                }
            }
        }

        private void WriteParameterArraySGN(ref short ItemsPerLine, ref double[] Values, ref short fp, ref string fm)
        {
            short num2 = (short) (Information.UBound(Values, 1) - 1);
            short num = 1;
            while (true)
            {
                int num3;
                object obj2;
                object[] objArray;
                short num4 = num2;
                if (num > num4)
                {
                    objArray = new object[] { Strings.Replace(Indump.rformat(ref obj2, ref fm), ",", ".", 1, -1, CompareMethod.Binary) };
                    num3 = num;
                    obj2 = Values[num3];
                    Values[num3] = Conversions.ToDouble(obj2);
                    FileSystem.Print(fp, objArray);
                    objArray = new object[] { "\tF" };
                    FileSystem.PrintLine(fp, objArray);
                    return;
                }
                objArray = new object[] { Strings.Replace(Indump.rformat(ref obj2, ref fm), ",", ".", 1, -1, CompareMethod.Binary) + " " };
                num3 = num;
                obj2 = Values[num3];
                Values[num3] = Conversions.ToDouble(obj2);
                FileSystem.Print(fp, objArray);
                num = (short) (num + 1);
            }
        }

        private bool WriteSGNFile(ref short simno)
        {
            // Invalid method body.
        }

        private void WriteSGNFileHeader()
        {
            short fileNumber = (short) FileSystem.FreeFile();
            FileSystem.FileOpen(fileNumber, this.Dir1.Path + @"\" + this.txtPrefix.Text + ".sgn", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
            FileSystem.PrintLine(fileNumber, new object[0]);
            FileSystem.PrintLine(fileNumber, new object[0]);
            FileSystem.PrintLine(fileNumber, new object[0]);
            object[] output = new object[] { this.txtOutputNames.Text };
            FileSystem.PrintLine(fileNumber, output);
            FileSystem.FileClose(new int[] { fileNumber });
        }

        public bool WriteUNCSAMOutputFiles(ref short simno) => 
            this.WriteSGNFile(ref simno);

        public virtual Timer Timer1
        {
            [DebuggerNonUserCode]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Timer1_Tick);
                if (!ReferenceEquals(this._Timer1, null))
                {
                    this._Timer1.Tick -= handler;
                }
                this._Timer1 = value;
                if (!ReferenceEquals(this._Timer1, null))
                {
                    this._Timer1.Tick += handler;
                }
            }
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

        public virtual GroupBox _fraStep_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_0 = value;
        }

        public virtual Button _cmdStep_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmdStep_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmdStep_2 = value;
        }

        public virtual Button _cmdStep_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmdStep_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmdStep_0 = value;
        }

        public virtual Button _cmdStep_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmdStep_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmdStep_1 = value;
        }

        public virtual TextBox txtPrefix
        {
            [DebuggerNonUserCode]
            get => 
                this._txtPrefix;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtPrefix = value;
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

        public virtual Label Label9
        {
            [DebuggerNonUserCode]
            get => 
                this._Label9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label9 = value;
        }

        public virtual Label _Label8_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label8_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label8_0 = value;
        }

        public virtual Label _Label5_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label5_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label5_1 = value;
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

        public virtual CheckedListBox lstAvailableVariables
        {
            [DebuggerNonUserCode]
            get => 
                this._lstAvailableVariables;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstAvailableVariables = value;
        }

        public virtual Button cmdBrowseForCondBinFile
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseForCondBinFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowseForCondBinFile_Click);
                if (!ReferenceEquals(this._cmdBrowseForCondBinFile, null))
                {
                    this._cmdBrowseForCondBinFile.Click -= handler;
                }
                this._cmdBrowseForCondBinFile = value;
                if (!ReferenceEquals(this._cmdBrowseForCondBinFile, null))
                {
                    this._cmdBrowseForCondBinFile.Click += handler;
                }
            }
        }

        public virtual TextBox txtOutputNames
        {
            [DebuggerNonUserCode]
            get => 
                this._txtOutputNames;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtOutputNames = value;
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

        public virtual Label lblCondBinFile
        {
            [DebuggerNonUserCode]
            get => 
                this._lblCondBinFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblCondBinFile = value;
        }

        public virtual Label _Label6_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label6_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label6_1 = value;
        }

        public virtual Label _Label8_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label8_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label8_1 = value;
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

        public virtual ADODC dbProjectDatabase
        {
            [DebuggerNonUserCode]
            get => 
                this._dbProjectDatabase;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbProjectDatabase = value;
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

        public virtual Label Label3
        {
            [DebuggerNonUserCode]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label3 = value;
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

        public virtual GroupBox Frame2
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame2 = value;
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

        public virtual GroupBox _fraStep_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_1 = value;
        }

        public virtual RadioButton _optFileFormat_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optFileFormat_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optFileFormat_1 = value;
        }

        public virtual RadioButton _optFileFormat_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optFileFormat_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optFileFormat_0 = value;
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

        public virtual Label lblFileName
        {
            [DebuggerNonUserCode]
            get => 
                this._lblFileName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblFileName = value;
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

        public virtual Label _Label6_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label6_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label6_0 = value;
        }

        public virtual Label _Label5_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label5_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label5_0 = value;
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

        public virtual ADODC dbParameterInfo
        {
            [DebuggerNonUserCode]
            get => 
                this._dbParameterInfo;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbParameterInfo = value;
        }

        public virtual ADODC dbMACROSimulation
        {
            [DebuggerNonUserCode]
            get => 
                this._dbMACROSimulation;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbMACROSimulation = value;
        }

        public virtual LabelArray Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
        }

        public virtual LabelArray Label6
        {
            [DebuggerNonUserCode]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label6 = value;
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

        public virtual LabelArray Label8
        {
            [DebuggerNonUserCode]
            get => 
                this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label8 = value;
        }

        public virtual ButtonArray cmdStep
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdStep;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdStep_Click);
                if (!ReferenceEquals(this._cmdStep, null))
                {
                    this._cmdStep.Click -= handler;
                }
                this._cmdStep = value;
                if (!ReferenceEquals(this._cmdStep, null))
                {
                    this._cmdStep.Click += handler;
                }
            }
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

        public virtual RadioButtonArray optFileFormat
        {
            [DebuggerNonUserCode]
            get => 
                this._optFileFormat;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optFileFormat = value;
        }
    }
}

