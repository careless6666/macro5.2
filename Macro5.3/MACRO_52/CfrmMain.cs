namespace MACRO_52
{
    using ADODB;
    using MACRO_52.My;
    using MACRO5;
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
    internal class CfrmMain : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("db2")]
        private ADODC _db2;
        [AccessedThroughProperty("ProjectDatabase")]
        private ADODC _ProjectDatabase;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("NewProject")]
        private ToolStripMenuItem _NewProject;
        [AccessedThroughProperty("OpenProject")]
        private ToolStripMenuItem _OpenProject;
        [AccessedThroughProperty("bar123")]
        private ToolStripSeparator _bar123;
        [AccessedThroughProperty("SaveProject")]
        private ToolStripMenuItem _SaveProject;
        [AccessedThroughProperty("SaveAs")]
        private ToolStripMenuItem _SaveAs;
        [AccessedThroughProperty("bar23")]
        private ToolStripSeparator _bar23;
        [AccessedThroughProperty("mnuFileChangeDatabase")]
        private ToolStripMenuItem _mnuFileChangeDatabase;
        [AccessedThroughProperty("baris")]
        private ToolStripSeparator _baris;
        [AccessedThroughProperty("mnuProjectDelete")]
        private ToolStripMenuItem _mnuProjectDelete;
        [AccessedThroughProperty("bar24")]
        private ToolStripSeparator _bar24;
        [AccessedThroughProperty("exiting_prog")]
        private ToolStripMenuItem _exiting_prog;
        [AccessedThroughProperty("Definefiles")]
        private ToolStripMenuItem _Definefiles;
        [AccessedThroughProperty("property_Renamed")]
        private ToolStripMenuItem _property_Renamed;
        [AccessedThroughProperty("switches")]
        private ToolStripMenuItem _switches;
        [AccessedThroughProperty("param")]
        private ToolStripMenuItem _param;
        [AccessedThroughProperty("out")]
        private ToolStripMenuItem _out;
        [AccessedThroughProperty("SetupSimulation")]
        private ToolStripMenuItem _SetupSimulation;
        [AccessedThroughProperty("Editera")]
        private ToolStripMenuItem _Editera;
        [AccessedThroughProperty("current")]
        private ToolStripMenuItem _current;
        [AccessedThroughProperty("batch")]
        private ToolStripMenuItem _batch;
        [AccessedThroughProperty("Exec")]
        private ToolStripMenuItem _Exec;
        [AccessedThroughProperty("mnuConvertBinToASCII")]
        private ToolStripMenuItem _mnuConvertBinToASCII;
        [AccessedThroughProperty("mnuConvertASCIIToBin")]
        private ToolStripMenuItem _mnuConvertASCIIToBin;
        [AccessedThroughProperty("mnuToolsDailyToHourlyRainfall")]
        private ToolStripMenuItem _mnuToolsDailyToHourlyRainfall;
        [AccessedThroughProperty("mnuToolsConvert")]
        private ToolStripMenuItem _mnuToolsConvert;
        [AccessedThroughProperty("sdfsd")]
        private ToolStripSeparator _sdfsd;
        [AccessedThroughProperty("mnuToolsChangeParameters")]
        private ToolStripMenuItem _mnuToolsChangeParameters;
        [AccessedThroughProperty("lkjlkj")]
        private ToolStripSeparator _lkjlkj;
        [AccessedThroughProperty("mnuToolsSUFI")]
        private ToolStripMenuItem _mnuToolsSUFI;
        [AccessedThroughProperty("sdfsdfsdf")]
        private ToolStripSeparator _sdfsdfsdf;
        [AccessedThroughProperty("Add_Renamed")]
        private ToolStripMenuItem _Add_Renamed;
        [AccessedThroughProperty("line5")]
        private ToolStripSeparator _line5;
        [AccessedThroughProperty("mnuMCSample")]
        private ToolStripMenuItem _mnuMCSample;
        [AccessedThroughProperty("mnuToolsExecuteVariationFile")]
        private ToolStripMenuItem _mnuToolsExecuteVariationFile;
        [AccessedThroughProperty("mnuMCAnalyze")]
        private ToolStripMenuItem _mnuMCAnalyze;
        [AccessedThroughProperty("mnuToolsLHS")]
        private ToolStripMenuItem _mnuToolsLHS;
        [AccessedThroughProperty("mnuToolsCompactDatabase")]
        private ToolStripMenuItem _mnuToolsCompactDatabase;
        [AccessedThroughProperty("mnuTools")]
        private ToolStripMenuItem _mnuTools;
        [AccessedThroughProperty("about")]
        private ToolStripMenuItem _about;
        [AccessedThroughProperty("mnuHelp")]
        private ToolStripMenuItem _mnuHelp;
        [AccessedThroughProperty("MainMenu1")]
        private MenuStrip _MainMenu1;
        [AccessedThroughProperty("ComputeGoalFunctionToolStripMenuItem")]
        private ToolStripMenuItem _ComputeGoalFunctionToolStripMenuItem;
        [AccessedThroughProperty("SaveToparameterFileToolStripMenuItem")]
        private ToolStripMenuItem _SaveToparameterFileToolStripMenuItem;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        private bool IsInitializing;
        private CfrmLHS m_frmLHS;
        private frmExecuteMACRO ExeForm;
        private CfrmParameters m_frmParameters;
        private CfrmSoilProperties m_frmDefineSoil;
        private CfrmSUFIMain m_frmSUFIMain;
        private CfrmExeParWizard m_frmExeParWizard;
        private CfrmSetup m_frmSetup;
        private frmChapar m_frmCHAPAR;
        private CfrmSaveAs m_frm_SaveAs;
        private CfrmOptions m_frmOptions;
        private CfrmOutput m_frmOutput;
        private Connection m_conn;
        private bool fTerminateCalled;

        public CfrmMain()
        {
            base.Activated += new EventHandler(this.start_Activated);
            base.Load += new EventHandler(this.start_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.m_frmSetup = new CfrmSetup(ref this);
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            GlobalVariables.DatabaseName = MyProject.Application.Info.DirectoryPath + @"\PROJECT_MACRO_5.mdb";
            GlobalVariables.SUFIDatabaseName = GlobalVariables.DatabaseName;
            if (!MiscFUncs.FileExists(GlobalVariables.DatabaseName))
            {
                MiscFUncs.MsgBox_Renamed("Need the default project database to continue.\rThe file: " + GlobalVariables.DatabaseName + " is missing.\rQuitting.", 0x30, "No project database found");
                ProjectData.EndApp();
            }
            this.m_conn = new ConnectionClass();
            this.m_conn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False", "", "", -1);
            this.InitMyForms();
        }

        public void about_Click(object eventSender, EventArgs eventArgs)
        {
            new CAbout(ref this).ShowDialog();
        }

        public void Add_Renamed_Click(object eventSender, EventArgs eventArgs)
        {
            new frmBatch(ref this).ShowDialog();
        }

        public void batch_Click(object eventSender, EventArgs eventArgs)
        {
            this.ExecuteBatch();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MiscFUncs.WriteTOXSWAFile(MyProject.Application.Info.DirectoryPath + @"\apa.m2t", MyProject.Application.Info.DirectoryPath + @"\macro010.bin", 10);
        }

        private bool CheckDrivingDataFiles()
        {
            bool flag;
            if (!MyProject.Computer.FileSystem.FileExists(GlobalVariables.Rainfall_file))
            {
                MiscFUncs.MsgBox_Renamed("The rainfall file: \r" + GlobalVariables.Rainfall_file + "\rcould not be found.", 0x30, "File not found");
                flag = false;
            }
            else if (MyProject.Computer.FileSystem.FileExists(GlobalVariables.Met_file))
            {
                flag = true;
            }
            else
            {
                MiscFUncs.MsgBox_Renamed("The meteorological file: \r" + GlobalVariables.Met_file + "\rcould not be found.", 0x30, "File not found");
                flag = false;
            }
            return flag;
        }

        private void ComputeGoalFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Invalid method body.
        }

        public void current_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.CheckDrivingDataFiles())
            {
                string str;
                string str2;
                string str3;
                if (GlobalVariables.New_Project)
                {
                    this.m_frm_SaveAs.ShowDialog();
                    if (Operators.ConditionalCompareObjectEqual(this.m_frm_SaveAs.IDCANCEL, true, false))
                    {
                        return;
                    }
                }
                GlobalVariables.IDExecute = GlobalVariables.RunIDno;
                if (GlobalVariables.IDExecute < 10)
                {
                    str3 = "00";
                }
                else if (GlobalVariables.IDExecute < 100)
                {
                    str3 = "0";
                }
                str3 = "" + Conversions.ToString(GlobalVariables.IDExecute);
                frmExecuteMACRO emacro = new frmExecuteMACRO(ref this) {
                    m_Batch = false,
                    m_Exe = false,
                    lblRunName = { Text = GlobalVariables.Run_name }
                };
                if (GlobalVariables.b_DefaultNaming)
                {
                    str2 = "MACRO" + str3 + ".bin";
                    str = "MACRO" + str3 + ".sum";
                }
                else
                {
                    str2 = GlobalVariables.MACROOutputFile + ".bin";
                    str = GlobalVariables.MACROOutputFile + ".sum";
                }
                string[] strArray = new string[] { "This will execute the simulation: ", GlobalVariables.Run_name, "\rwith id-number: ", Conversions.ToString(GlobalVariables.IDExecute), "\rin project: ", GlobalVariables.project_name, "\r\rThe following files will be generated during the simulation:\r", str2, "\r" };
                strArray[9] = str;
                strArray[10] = "\r\rIf these files already exist, the existing files will be renamed to:\rbackup";
                strArray[11] = str3;
                strArray[12] = ".bin\rbackup";
                strArray[13] = str3;
                strArray[14] = ".sum\r\rThe simulation that will be executed is the one stored in the database.\rYour simulation will not include any changes since you last saved.\rWould you like to save before executing the simulation?";
                short num = Conversions.ToShort(MiscFUncs.MsgBox_Renamed(string.Concat(strArray), 0x23, "Execute"));
                if (num != 2)
                {
                    if (num == 6)
                    {
                        ReadSaveFunctions.SaveToDatabase(ref GlobalVariables.Project_dscrpt, ref GlobalVariables.Run_dscrpt, ref GlobalVariables.project_name, ref GlobalVariables.IDExecute, ref false, ref this);
                    }
                    this.Hide();
                    emacro.ShowDialog();
                    this.Show();
                }
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!this.fTerminateCalled)
                {
                    this.fTerminateCalled = true;
                }
                if (!ReferenceEquals(this.components, null))
                {
                    this.components.Dispose();
                }
            }
            base.Dispose(Disposing);
        }

        private void ExecuteBatch()
        {
            this.ExeForm = new frmExecuteMACRO(ref this);
            this.ExeForm.m_Batch = true;
            this.ExeForm.m_Exe = false;
            this.Hide();
            this.ExeForm.Show();
        }

        public void exiting_prog_Click(object eventSender, EventArgs eventArgs)
        {
            if (GlobalVariables.RunIDno != 0)
            {
                short num = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Would you like to save first?", 0x23, "Save?"));
                if (num != 6)
                {
                    if (num == 2)
                    {
                        return;
                    }
                }
                else
                {
                    this.SaveProject_Click(this.SaveProject, new EventArgs());
                }
            }
            ProjectData.EndApp();
        }

        public void goal_Click(object eventSender, EventArgs eventArgs)
        {
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmMain));
            this.db2 = new ADODC();
            this.ProjectDatabase = new ADODC();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.MainMenu1 = new MenuStrip();
            this.Definefiles = new ToolStripMenuItem();
            this.NewProject = new ToolStripMenuItem();
            this.OpenProject = new ToolStripMenuItem();
            this.bar123 = new ToolStripSeparator();
            this.SaveProject = new ToolStripMenuItem();
            this.SaveAs = new ToolStripMenuItem();
            this.SaveToparameterFileToolStripMenuItem = new ToolStripMenuItem();
            this.bar23 = new ToolStripSeparator();
            this.mnuFileChangeDatabase = new ToolStripMenuItem();
            this.baris = new ToolStripSeparator();
            this.mnuProjectDelete = new ToolStripMenuItem();
            this.bar24 = new ToolStripSeparator();
            this.exiting_prog = new ToolStripMenuItem();
            this.Editera = new ToolStripMenuItem();
            this.switches = new ToolStripMenuItem();
            this.SetupSimulation = new ToolStripMenuItem();
            this.property_Renamed = new ToolStripMenuItem();
            this.param = new ToolStripMenuItem();
            this.@out = new ToolStripMenuItem();
            this.Exec = new ToolStripMenuItem();
            this.current = new ToolStripMenuItem();
            this.batch = new ToolStripMenuItem();
            this.mnuTools = new ToolStripMenuItem();
            this.mnuToolsConvert = new ToolStripMenuItem();
            this.mnuConvertBinToASCII = new ToolStripMenuItem();
            this.mnuConvertASCIIToBin = new ToolStripMenuItem();
            this.mnuToolsDailyToHourlyRainfall = new ToolStripMenuItem();
            this.sdfsd = new ToolStripSeparator();
            this.mnuToolsChangeParameters = new ToolStripMenuItem();
            this.lkjlkj = new ToolStripSeparator();
            this.mnuToolsSUFI = new ToolStripMenuItem();
            this.sdfsdfsdf = new ToolStripSeparator();
            this.Add_Renamed = new ToolStripMenuItem();
            this.line5 = new ToolStripSeparator();
            this.mnuToolsLHS = new ToolStripMenuItem();
            this.mnuMCSample = new ToolStripMenuItem();
            this.mnuToolsExecuteVariationFile = new ToolStripMenuItem();
            this.mnuMCAnalyze = new ToolStripMenuItem();
            this.mnuToolsCompactDatabase = new ToolStripMenuItem();
            this.ComputeGoalFunctionToolStripMenuItem = new ToolStripMenuItem();
            this.mnuHelp = new ToolStripMenuItem();
            this.about = new ToolStripMenuItem();
            this.Button1 = new Button();
            this.MainMenu1.SuspendLayout();
            this.SuspendLayout();
            this.db2.BackColor = SystemColors.Window;
            this.db2.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.db2.CommandTimeout = 0;
            this.db2.CommandType = CommandTypeEnum.adCmdUnknown;
            this.db2.ConnectionString = null;
            this.db2.CursorLocation = CursorLocationEnum.adUseClient;
            this.db2.CursorType = CursorTypeEnum.adOpenStatic;
            this.db2.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.db2.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.db2.ForeColor = SystemColors.WindowText;
            Point point = new Point(0x10, 0x170);
            this.db2.Location = point;
            this.db2.LockType = LockTypeEnum.adLockPessimistic;
            this.db2.Mode = ConnectModeEnum.adModeUnknown;
            this.db2.Name = "db2";
            this.db2.Orientation = ADODC.OrientationEnum.adHorizontal;
            Size size = new Size(0x69, 0x19);
            this.db2.Size = size;
            this.db2.TabIndex = 3;
            this.db2.Text = "Adodc1";
            this.db2.Visible = false;
            this.ProjectDatabase.BackColor = SystemColors.Window;
            this.ProjectDatabase.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.ProjectDatabase.CommandTimeout = 0;
            this.ProjectDatabase.CommandType = CommandTypeEnum.adCmdUnknown;
            this.ProjectDatabase.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Stenemo\Projects\MACRO 5.0\Master copy code\PROJECT_MACRO_5.mdb;Persist Security Info=False";
            this.ProjectDatabase.CursorLocation = CursorLocationEnum.adUseClient;
            this.ProjectDatabase.CursorType = CursorTypeEnum.adOpenStatic;
            this.ProjectDatabase.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.ProjectDatabase.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ProjectDatabase.ForeColor = SystemColors.WindowText;
            point = new Point(0, 0x1d0);
            this.ProjectDatabase.Location = point;
            this.ProjectDatabase.LockType = LockTypeEnum.adLockPessimistic;
            this.ProjectDatabase.Mode = ConnectModeEnum.adModeUnknown;
            this.ProjectDatabase.Name = "ProjectDatabase";
            this.ProjectDatabase.Orientation = ADODC.OrientationEnum.adHorizontal;
            size = new Size(0x99, 0x16);
            this.ProjectDatabase.Size = size;
            this.ProjectDatabase.TabIndex = 5;
            this.ProjectDatabase.Text = "Adodc1";
            this.ProjectDatabase.Visible = false;
            this.Label2.BackColor = Color.Transparent;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 14f);
            this.Label2.ForeColor = SystemColors.WindowText;
            point = new Point(0xb0, 0x6f);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x1a7, 0x29);
            this.Label2.Size = size;
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Water and solute transport in macroporous soils";
            this.Label2.TextAlign = ContentAlignment.TopCenter;
            this.Label1.BackColor = Color.Transparent;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.WindowText;
            point = new Point(0x9e, 0x3e);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x1b9, 0x31);
            this.Label1.Size = size;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "MACRO 5.2";
            this.Label1.TextAlign = ContentAlignment.TopCenter;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.Definefiles, this.Editera, this.Exec, this.mnuTools, this.mnuHelp };
            this.MainMenu1.Items.AddRange(toolStripItems);
            point = new Point(0, 0);
            this.MainMenu1.Location = point;
            this.MainMenu1.Name = "MainMenu1";
            size = new Size(0x2e3, 0x18);
            this.MainMenu1.Size = size;
            this.MainMenu1.TabIndex = 6;
            toolStripItems = new ToolStripItem[] { this.NewProject, this.OpenProject, this.bar123, this.SaveProject, this.SaveAs, this.SaveToparameterFileToolStripMenuItem, this.bar23, this.mnuFileChangeDatabase, this.baris };
            toolStripItems[9] = this.mnuProjectDelete;
            toolStripItems[10] = this.bar24;
            toolStripItems[11] = this.exiting_prog;
            this.Definefiles.DropDownItems.AddRange(toolStripItems);
            this.Definefiles.Name = "Definefiles";
            size = new Size(0x23, 20);
            this.Definefiles.Size = size;
            this.Definefiles.Text = "&File";
            this.NewProject.Name = "NewProject";
            this.NewProject.ShortcutKeys = Keys.Control | Keys.N;
            size = new Size(0xcc, 0x16);
            this.NewProject.Size = size;
            this.NewProject.Text = "&New...";
            this.OpenProject.Name = "OpenProject";
            this.OpenProject.ShortcutKeys = Keys.Control | Keys.O;
            size = new Size(0xcc, 0x16);
            this.OpenProject.Size = size;
            this.OpenProject.Text = "&Open...";
            this.bar123.Name = "bar123";
            size = new Size(0xc9, 6);
            this.bar123.Size = size;
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.ShortcutKeys = Keys.Control | Keys.S;
            size = new Size(0xcc, 0x16);
            this.SaveProject.Size = size;
            this.SaveProject.Text = "&Save";
            this.SaveAs.Name = "SaveAs";
            size = new Size(0xcc, 0x16);
            this.SaveAs.Size = size;
            this.SaveAs.Text = "Save &as...";
            this.SaveToparameterFileToolStripMenuItem.Name = "SaveToparameterFileToolStripMenuItem";
            size = new Size(0xcc, 0x16);
            this.SaveToparameterFileToolStripMenuItem.Size = size;
            this.SaveToparameterFileToolStripMenuItem.Text = "Save to &parameter file...";
            this.bar23.Name = "bar23";
            size = new Size(0xc9, 6);
            this.bar23.Size = size;
            this.mnuFileChangeDatabase.Name = "mnuFileChangeDatabase";
            size = new Size(0xcc, 0x16);
            this.mnuFileChangeDatabase.Size = size;
            this.mnuFileChangeDatabase.Text = "Change &database...";
            this.baris.Name = "baris";
            size = new Size(0xc9, 6);
            this.baris.Size = size;
            this.mnuProjectDelete.Name = "mnuProjectDelete";
            this.mnuProjectDelete.ShortcutKeys = Keys.Control | Keys.D;
            size = new Size(0xcc, 0x16);
            this.mnuProjectDelete.Size = size;
            this.mnuProjectDelete.Text = "De&lete...";
            this.bar24.Name = "bar24";
            size = new Size(0xc9, 6);
            this.bar24.Size = size;
            this.exiting_prog.Name = "exiting_prog";
            this.exiting_prog.ShortcutKeys = Keys.Control | Keys.Q;
            size = new Size(0xcc, 0x16);
            this.exiting_prog.Size = size;
            this.exiting_prog.Text = "&Exit";
            toolStripItems = new ToolStripItem[] { this.switches, this.SetupSimulation, this.property_Renamed, this.param, this.@out };
            this.Editera.DropDownItems.AddRange(toolStripItems);
            this.Editera.Name = "Editera";
            size = new Size(0x25, 20);
            this.Editera.Size = size;
            this.Editera.Text = "&Edit";
            this.switches.Name = "switches";
            size = new Size(0xaf, 0x16);
            this.switches.Size = size;
            this.switches.Text = "&Options...";
            this.SetupSimulation.Name = "SetupSimulation";
            size = new Size(0xaf, 0x16);
            this.SetupSimulation.Size = size;
            this.SetupSimulation.Text = "&Simulation setup...";
            this.property_Renamed.Name = "property_Renamed";
            size = new Size(0xaf, 0x16);
            this.property_Renamed.Size = size;
            this.property_Renamed.Text = "Soil p&roperties...";
            this.param.Name = "param";
            size = new Size(0xaf, 0x16);
            this.param.Size = size;
            this.param.Text = "&Parameters...";
            this.@out.Name = "out";
            size = new Size(0xaf, 0x16);
            this.@out.Size = size;
            this.@out.Text = "O&utputs...";
            toolStripItems = new ToolStripItem[] { this.current, this.batch };
            this.Exec.DropDownItems.AddRange(toolStripItems);
            this.Exec.Name = "Exec";
            size = new Size(0x3a, 20);
            this.Exec.Size = size;
            this.Exec.Text = "E&xecute";
            this.current.Name = "current";
            this.current.ShortcutKeys = Keys.F5;
            size = new Size(0x8d, 0x16);
            this.current.Size = size;
            this.current.Text = "&Current";
            this.batch.Name = "batch";
            size = new Size(0x8d, 0x16);
            this.batch.Size = size;
            this.batch.Text = "&Batch file...";
            toolStripItems = new ToolStripItem[] { this.mnuToolsConvert, this.sdfsd, this.mnuToolsChangeParameters, this.lkjlkj, this.mnuToolsSUFI, this.sdfsdfsdf, this.Add_Renamed, this.line5, this.mnuToolsLHS };
            toolStripItems[9] = this.mnuToolsCompactDatabase;
            toolStripItems[10] = this.ComputeGoalFunctionToolStripMenuItem;
            this.mnuTools.DropDownItems.AddRange(toolStripItems);
            this.mnuTools.Name = "mnuTools";
            size = new Size(0x2c, 20);
            this.mnuTools.Size = size;
            this.mnuTools.Text = "&Tools";
            toolStripItems = new ToolStripItem[] { this.mnuConvertBinToASCII, this.mnuConvertASCIIToBin, this.mnuToolsDailyToHourlyRainfall };
            this.mnuToolsConvert.DropDownItems.AddRange(toolStripItems);
            this.mnuToolsConvert.Name = "mnuToolsConvert";
            size = new Size(0xc1, 0x16);
            this.mnuToolsConvert.Size = size;
            this.mnuToolsConvert.Text = "&Convert files";
            this.mnuConvertBinToASCII.Name = "mnuConvertBinToASCII";
            size = new Size(0xc9, 0x16);
            this.mnuConvertBinToASCII.Size = size;
            this.mnuConvertBinToASCII.Text = ".bin to ASCII...";
            this.mnuConvertASCIIToBin.Name = "mnuConvertASCIIToBin";
            size = new Size(0xc9, 0x16);
            this.mnuConvertASCIIToBin.Size = size;
            this.mnuConvertASCIIToBin.Text = "ASCII to .bin...";
            this.mnuToolsDailyToHourlyRainfall.Name = "mnuToolsDailyToHourlyRainfall";
            size = new Size(0xc9, 0x16);
            this.mnuToolsDailyToHourlyRainfall.Size = size;
            this.mnuToolsDailyToHourlyRainfall.Text = "&Daily to hourly rainfall...";
            this.sdfsd.Name = "sdfsd";
            size = new Size(190, 6);
            this.sdfsd.Size = size;
            this.mnuToolsChangeParameters.Enabled = false;
            this.mnuToolsChangeParameters.Name = "mnuToolsChangeParameters";
            size = new Size(0xc1, 0x16);
            this.mnuToolsChangeParameters.Size = size;
            this.mnuToolsChangeParameters.Text = "C&hange parameters...";
            this.lkjlkj.Name = "lkjlkj";
            size = new Size(190, 6);
            this.lkjlkj.Size = size;
            this.mnuToolsSUFI.Name = "mnuToolsSUFI";
            size = new Size(0xc1, 0x16);
            this.mnuToolsSUFI.Size = size;
            this.mnuToolsSUFI.Text = "&SUFI...";
            this.sdfsdfsdf.Name = "sdfsdfsdf";
            size = new Size(190, 6);
            this.sdfsdfsdf.Size = size;
            this.Add_Renamed.Name = "Add_Renamed";
            size = new Size(0xc1, 0x16);
            this.Add_Renamed.Size = size;
            this.Add_Renamed.Text = "Setup &batch file...";
            this.line5.Name = "line5";
            size = new Size(190, 6);
            this.line5.Size = size;
            toolStripItems = new ToolStripItem[] { this.mnuMCSample, this.mnuToolsExecuteVariationFile, this.mnuMCAnalyze };
            this.mnuToolsLHS.DropDownItems.AddRange(toolStripItems);
            this.mnuToolsLHS.Name = "mnuToolsLHS";
            size = new Size(0xc1, 0x16);
            this.mnuToolsLHS.Size = size;
            this.mnuToolsLHS.Text = "&Monte-Carlo...";
            this.mnuMCSample.Name = "mnuMCSample";
            size = new Size(0xc6, 0x16);
            this.mnuMCSample.Size = size;
            this.mnuMCSample.Text = "&Sample...";
            this.mnuToolsExecuteVariationFile.Name = "mnuToolsExecuteVariationFile";
            size = new Size(0xc6, 0x16);
            this.mnuToolsExecuteVariationFile.Size = size;
            this.mnuToolsExecuteVariationFile.Text = "E&xecute variation file...";
            this.mnuMCAnalyze.Name = "mnuMCAnalyze";
            size = new Size(0xc6, 0x16);
            this.mnuMCAnalyze.Size = size;
            this.mnuMCAnalyze.Text = "&Analyze...";
            this.mnuToolsCompactDatabase.Name = "mnuToolsCompactDatabase";
            size = new Size(0xc1, 0x16);
            this.mnuToolsCompactDatabase.Size = size;
            this.mnuToolsCompactDatabase.Text = "&Compact database";
            this.mnuToolsCompactDatabase.Visible = false;
            this.ComputeGoalFunctionToolStripMenuItem.Name = "ComputeGoalFunctionToolStripMenuItem";
            size = new Size(0xc1, 0x16);
            this.ComputeGoalFunctionToolStripMenuItem.Size = size;
            this.ComputeGoalFunctionToolStripMenuItem.Text = "Compute &goal function";
            toolStripItems = new ToolStripItem[] { this.about };
            this.mnuHelp.DropDownItems.AddRange(toolStripItems);
            this.mnuHelp.Name = "mnuHelp";
            size = new Size(40, 20);
            this.mnuHelp.Size = size;
            this.mnuHelp.Text = "&Help";
            this.about.Name = "about";
            size = new Size(0x7e, 0x16);
            this.about.Size = size;
            this.about.Text = "&About...";
            point = new Point(0xef, 0xde);
            this.Button1.Location = point;
            this.Button1.Name = "Button1";
            size = new Size(0x4b, 0x17);
            this.Button1.Size = size;
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Visible = false;
            SizeF ef = new SizeF(7f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.BackgroundImage = (Image) manager.GetObject("$this.BackgroundImage");
            this.BackgroundImageLayout = ImageLayout.None;
            size = new Size(0x2e3, 0x1e6);
            this.ClientSize = size;
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.db2);
            this.Controls.Add(this.ProjectDatabase);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.MainMenu1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = SystemColors.WindowText;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            point = new Point(-9, 0x6f);
            this.Location = point;
            this.MaximizeBox = false;
            this.Name = "CfrmMain";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MACRO 5.2";
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void InitMyForms()
        {
            this.m_frmParameters = new CfrmParameters(ref this);
            this.m_frmDefineSoil = new CfrmSoilProperties(ref this);
            this.m_frmSUFIMain = new CfrmSUFIMain(ref this);
            this.m_frmExeParWizard = new CfrmExeParWizard(ref this);
            this.m_frmCHAPAR = new frmChapar(ref this);
            this.m_frm_SaveAs = new CfrmSaveAs(ref this);
            this.m_frmOptions = new CfrmOptions(ref this);
            this.m_frmOutput = new CfrmOutput(ref this);
        }

        public void mnuConvertASCIIToBin_Click(object eventSender, EventArgs eventArgs)
        {
            CfrmAddFile file = new CfrmAddFile(ref this);
            CfrmAddFile file2 = file;
            file.FileConversion = true;
            file.Text = "Convert ASCII-file to .bin-format";
            file.Label4.Text = "The selected text-file will be converted when clicking the 'Finish'-button. The name of the created bin-file will be the same as for the text file, but with the extension .bin.";
            file.lblStep[3].Text = "A certain number of different .bin-files can be used in a simulation. Indicate below which type of .bin-file you would like to create.";
            file.optTypeOfFile[5].Visible = true;
            file.lblVariables.Visible = true;
            file.txtNoVars.Visible = true;
            file.Init();
            file.ShowDialog();
            FileSystem.FileClose(new int[0]);
            file2 = null;
        }

        public void mnuConvertBinToASCII_Click(object eventSender, EventArgs eventArgs)
        {
            if (!MiscFUncs.ConvertBinToASCII(ref new OpenFileDialog()))
            {
                MiscFUncs.MsgBox_Renamed("Failed to convert file", 0x30, "Failure");
            }
        }

        public void mnuFileChangeDatabase_Click(object eventSender, EventArgs eventArgs)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            OpenFileDialog dialog2 = dlg;
            dialog2.FileName = "";
            dialog2.Filter = "ACCESS databases (*.mdb)|*.mdb";
            dialog2.Title = "Locate database";
            string expression = MiscFUncs.BrowseOpen(ref dlg);
            dialog2 = null;
            if (Strings.Len(expression) != 0)
            {
                GlobalVariables.DatabaseName = expression;
                GlobalVariables.SUFIDatabaseName = expression;
                this.m_frmSUFIMain = new CfrmSUFIMain(ref this);
                this.frmSUFIMain.ConnectToSUFIDatabase();
                this.ProjectDatabase.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
                this.db2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
                this.m_conn = new ConnectionClass();
                this.m_conn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False", "", "", -1);
                this.Editera.Enabled = false;
                GlobalVariables.RunIDno = 0;
                GlobalVariables.Re_place = 0;
                this.SaveProject.Enabled = false;
                this.SaveAs.Enabled = false;
                this.SaveToparameterFileToolStripMenuItem.Enabled = false;
                this.current.Enabled = false;
                this.Text = "MACRO 5.2";
            }
        }

        public void mnuMCAnalyze_Click(object eventSender, EventArgs eventArgs)
        {
            CfrmLHS mlhs = new CfrmLHS(ref this);
            this.Hide();
            mlhs.RunID = (short) GlobalVariables.RunIDno;
            mlhs.m_CurStep = 4;
            mlhs.DisplayStep();
            mlhs.ShowDialog();
            this.Show();
        }

        public void mnuMCSample_Click(object eventSender, EventArgs eventArgs)
        {
            CfrmLHS mlhs = new CfrmLHS(ref this);
            this.Hide();
            mlhs.RunID = (short) GlobalVariables.RunIDno;
            mlhs.m_CurStep = 1;
            mlhs.DisplayStep();
            mlhs.ShowDialog();
            this.Show();
        }

        public void mnuProjectDelete_Click(object eventSender, EventArgs eventArgs)
        {
            if ((GlobalVariables.RunIDno == 0) || (((short) Interaction.MsgBox("This will close the current simulation without saving.\rThe current simulation will not be deleted.\rContinue?", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "Continue?")) != 7))
            {
                frmOpen open = new frmOpen(ref this);
                frmOpen open2 = open;
                open2.Text = "Delete";
                open2.lblAction.Text = "&Select a project or a simulation to delete";
                open2.cmdAction.Text = "&Delete";
                open2.cmdAction.Enabled = false;
                open2.bDelete = true;
                open2.ShowDialog();
                open2 = null;
                open.Close();
                this.Text = "MACRO 5.2";
                this.Show();
            }
        }

        public void mnuToolsChangeParameters_Click(object eventSender, EventArgs eventArgs)
        {
            this.m_frmCHAPAR.ShowDialog();
        }

        public void mnuToolsDailyToHourlyRainfall_Click(object eventSender, EventArgs eventArgs)
        {
            new frmRainfallDisagg(ref this).ShowDialog();
        }

        public void mnuToolsExecuteVariationFile_Click(object eventSender, EventArgs eventArgs)
        {
            this.Hide();
            this.m_frmExeParWizard = new CfrmExeParWizard(ref this);
            this.frmExeParWizard.Show();
        }

        public void mnuToolsSUFI_Click(object eventSender, EventArgs eventArgs)
        {
            this.Hide();
            this.m_frmSUFIMain = new CfrmSUFIMain(ref this);
            this.frmSUFIMain.ConnectToSUFIDatabase();
            this.frmSUFIMain.Show();
        }

        public void NewProject_Click(object eventSender, EventArgs eventArgs)
        {
            if ((GlobalVariables.RunIDno != 0) && (((short) Interaction.MsgBox("Would you like to save first?", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "Save?")) == 6))
            {
                this.SaveProject_Click(this.SaveProject, new EventArgs());
            }
            GlobalVariables.New_Project = true;
            GlobalVariables.warning1 = 0;
            new frmNewProject(ref this).ShowDialog();
            this.Show();
        }

        public void OpenProject_Click(object eventSender, EventArgs eventArgs)
        {
            if (GlobalVariables.RunIDno != 0)
            {
                short num = (short) Interaction.MsgBox("Would you like to save first?", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, "Save?");
                if (num != 6)
                {
                    if (num == 2)
                    {
                        return;
                    }
                }
                else
                {
                    this.SaveProject_Click(this.SaveProject, new EventArgs());
                }
            }
            GlobalVariables.warning1 = 0;
            new frmOpen(ref this).ShowDialog();
            this.mnuToolsChangeParameters.Enabled = GlobalVariables.RunIDno != 0;
            this.Show();
        }

        public void out_Click(object eventSender, EventArgs eventArgs)
        {
            this.m_frmOutput = new CfrmOutput(ref this);
            this.m_frmOutput.ShowDialog();
            this.Show();
        }

        public void param_Click(object eventSender, EventArgs eventArgs)
        {
            this.m_frmParameters = new CfrmParameters(ref this);
            this.m_frmParameters.ShowDialog();
            this.m_frmParameters.IsEditing = false;
            this.Show();
        }

        public void property_Renamed_Click(object eventSender, EventArgs eventArgs)
        {
            this.m_frmDefineSoil.ShowDialog();
            this.Show();
        }

        public void SaveAs_Click(object eventSender, EventArgs eventArgs)
        {
            this.m_frm_SaveAs.ShowDialog();
            this.Show();
        }

        public void SaveProject_Click(object eventSender, EventArgs eventArgs)
        {
            if (GlobalVariables.New_Project)
            {
                this.m_frm_SaveAs.ShowDialog();
            }
            else
            {
                GlobalVariables.Re_place = -1;
                this.Cursor = Cursors.WaitCursor;
                ReadSaveFunctions.SaveToDatabase(ref GlobalVariables.Project_dscrpt, ref GlobalVariables.Run_dscrpt, ref GlobalVariables.project_name, ref GlobalVariables.RunIDno, ref false, ref this);
                this.Cursor = Cursors.Default;
            }
            this.Show();
        }

        private void SaveToparameterFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = Conversions.ToInteger(MiscFUncs.MsgBox_Renamed("Would you like to save the simulation first? The version of the simulation saved to the parameter file is the one stored in the database.", 0x23, "Save?"));
            if (num != 6)
            {
                if (num == 2)
                {
                    return;
                }
            }
            else
            {
                this.SaveProject_Click(this.SaveProject, new EventArgs());
            }
            SaveFileDialog dialog = new SaveFileDialog {
                Title = "Save simulation as parameter file",
                Filter = "parameter files (*.par)|*.par",
                DefaultExt = ".par",
                AddExtension = true
            };
            dialog.ShowDialog();
            if (Strings.Len(dialog.FileName) > 0)
            {
                CMACROSimulation simulation = new CMACROSimulation(this.DatabaseConnection) {
                    RunID = (short) GlobalVariables.RunIDno
                };
                if (simulation.Load())
                {
                    simulation.SaveToParameterFile(dialog.FileName);
                }
                else
                {
                    MessageBox.Show("Failed to load simulation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void SetArrayDimensions()
        {
            GlobalVariables.till_day = new short[10];
            GlobalVariables.till_int = new float[10];
            GlobalVariables.till_lay = new short[10];
            GlobalVariables.t_ascale = new float[10];
            GlobalVariables.tillcons = new float[10];
            GlobalVariables.till_day_c = new int[10];
            GlobalVariables.till_int_c = new int[10];
            GlobalVariables.till_lay_c = new int[10];
            GlobalVariables.t_ascale_c = new int[10];
            GlobalVariables.tillcons_c = new int[10];
            GlobalVariables.outpx1 = new GlobalVariables.o_p1[8];
            GlobalVariables.outpt1 = new GlobalVariables.o_p1[0x22];
            GlobalVariables.outpg1 = new GlobalVariables.o_p1[10];
            GlobalVariables.outpd1 = new GlobalVariables.o_p1[0x21];
            GlobalVariables.outpx2 = new GlobalVariables.o_p2[14];
            GlobalVariables.outpg2 = new GlobalVariables.o_p2[0x15];
            GlobalVariables.outpd2 = new GlobalVariables.o_p2[0x16];
            GlobalVariables.grddata_col = new short[8];
            GlobalVariables.grddata_row = new short[8];
        }

        public void SetCaption()
        {
        }

        public void SetupSimulation_Click(object eventSender, EventArgs eventArgs)
        {
            string str = Conversions.ToString(this.frmSetup.dtEndDate.Value);
            this.m_frmSetup.ShowDialog();
            str = Conversions.ToString(this.frmSetup.dtEndDate.Value);
            this.Show();
        }

        private void start_Activated(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                GlobalVariables.AppDrive = Strings.Left(MyProject.Application.Info.DirectoryPath, 2);
                this.@out.Enabled = !((GlobalVariables.sw_metabolite == MACROConstants.Switch.BareSoil) | (GlobalVariables.sw_toxswa == MACROConstants.Switch.BareSoil));
                this.Refresh();
            }
        }

        private void start_Load(object eventSender, EventArgs eventArgs)
        {
            GlobalVariables.Chapar = new string[1, 4];
            GlobalVariables.bFirst = true;
            this.SetArrayDimensions();
            GlobalVariables.b_DefaultNaming = true;
            GlobalVariables.DatabaseName = MyProject.Application.Info.DirectoryPath + @"\PROJECT_MACRO_5.mdb";
            GlobalVariables.SUFIDatabaseName = MyProject.Application.Info.DirectoryPath + @"\PROJECT_MACRO_5.mdb";
            if (!MiscFUncs.FileExists(GlobalVariables.DatabaseName))
            {
                MiscFUncs.MsgBox_Renamed("Need the default project database to continue.\rThe file: " + GlobalVariables.DatabaseName + " is missing.\rQuitting.", 0x30, "No project database found");
                ProjectData.EndApp();
            }
            if (MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\MACRO.ini"))
            {
                short fileNumber = (short) FileSystem.FreeFile();
                FileSystem.FileOpen(fileNumber, MyProject.Application.Info.DirectoryPath + @"\MACRO.ini", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);
                FileSystem.Input(fileNumber, ref GlobalVariables.C_DELAY);
                FileSystem.Input(fileNumber, ref GlobalVariables.C_MINUTESTOWAIT);
                FileSystem.FileClose(new int[] { fileNumber });
            }
            this.ProjectDatabase.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
            this.db2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
            string directoryPath = MyProject.Application.Info.DirectoryPath;
            this.Editera.Enabled = false;
            this.SaveProject.Enabled = false;
            this.SaveAs.Enabled = false;
            this.SaveToparameterFileToolStripMenuItem.Enabled = false;
            this.current.Enabled = false;
        }

        public void switches_Click(object eventSender, EventArgs eventArgs)
        {
            this.m_frmOptions.ShowDialog();
            this.Show();
        }

        public virtual ADODC db2
        {
            [DebuggerNonUserCode]
            get => 
                this._db2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._db2 = value;
        }

        public virtual ADODC ProjectDatabase
        {
            [DebuggerNonUserCode]
            get => 
                this._ProjectDatabase;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._ProjectDatabase = value;
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

        public virtual ToolStripMenuItem NewProject
        {
            [DebuggerNonUserCode]
            get => 
                this._NewProject;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.NewProject_Click);
                if (!ReferenceEquals(this._NewProject, null))
                {
                    this._NewProject.Click -= handler;
                }
                this._NewProject = value;
                if (!ReferenceEquals(this._NewProject, null))
                {
                    this._NewProject.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem OpenProject
        {
            [DebuggerNonUserCode]
            get => 
                this._OpenProject;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.OpenProject_Click);
                if (!ReferenceEquals(this._OpenProject, null))
                {
                    this._OpenProject.Click -= handler;
                }
                this._OpenProject = value;
                if (!ReferenceEquals(this._OpenProject, null))
                {
                    this._OpenProject.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator bar123
        {
            [DebuggerNonUserCode]
            get => 
                this._bar123;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._bar123 = value;
        }

        public virtual ToolStripMenuItem SaveProject
        {
            [DebuggerNonUserCode]
            get => 
                this._SaveProject;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.SaveProject_Click);
                if (!ReferenceEquals(this._SaveProject, null))
                {
                    this._SaveProject.Click -= handler;
                }
                this._SaveProject = value;
                if (!ReferenceEquals(this._SaveProject, null))
                {
                    this._SaveProject.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem SaveAs
        {
            [DebuggerNonUserCode]
            get => 
                this._SaveAs;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.SaveAs_Click);
                if (!ReferenceEquals(this._SaveAs, null))
                {
                    this._SaveAs.Click -= handler;
                }
                this._SaveAs = value;
                if (!ReferenceEquals(this._SaveAs, null))
                {
                    this._SaveAs.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator bar23
        {
            [DebuggerNonUserCode]
            get => 
                this._bar23;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._bar23 = value;
        }

        public virtual ToolStripMenuItem mnuFileChangeDatabase
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuFileChangeDatabase;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuFileChangeDatabase_Click);
                if (!ReferenceEquals(this._mnuFileChangeDatabase, null))
                {
                    this._mnuFileChangeDatabase.Click -= handler;
                }
                this._mnuFileChangeDatabase = value;
                if (!ReferenceEquals(this._mnuFileChangeDatabase, null))
                {
                    this._mnuFileChangeDatabase.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator baris
        {
            [DebuggerNonUserCode]
            get => 
                this._baris;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._baris = value;
        }

        public virtual ToolStripMenuItem mnuProjectDelete
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuProjectDelete;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuProjectDelete_Click);
                if (!ReferenceEquals(this._mnuProjectDelete, null))
                {
                    this._mnuProjectDelete.Click -= handler;
                }
                this._mnuProjectDelete = value;
                if (!ReferenceEquals(this._mnuProjectDelete, null))
                {
                    this._mnuProjectDelete.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator bar24
        {
            [DebuggerNonUserCode]
            get => 
                this._bar24;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._bar24 = value;
        }

        public virtual ToolStripMenuItem exiting_prog
        {
            [DebuggerNonUserCode]
            get => 
                this._exiting_prog;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.exiting_prog_Click);
                if (!ReferenceEquals(this._exiting_prog, null))
                {
                    this._exiting_prog.Click -= handler;
                }
                this._exiting_prog = value;
                if (!ReferenceEquals(this._exiting_prog, null))
                {
                    this._exiting_prog.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem Definefiles
        {
            [DebuggerNonUserCode]
            get => 
                this._Definefiles;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Definefiles = value;
        }

        public virtual ToolStripMenuItem property_Renamed
        {
            [DebuggerNonUserCode]
            get => 
                this._property_Renamed;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.property_Renamed_Click);
                if (!ReferenceEquals(this._property_Renamed, null))
                {
                    this._property_Renamed.Click -= handler;
                }
                this._property_Renamed = value;
                if (!ReferenceEquals(this._property_Renamed, null))
                {
                    this._property_Renamed.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem switches
        {
            [DebuggerNonUserCode]
            get => 
                this._switches;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.switches_Click);
                if (!ReferenceEquals(this._switches, null))
                {
                    this._switches.Click -= handler;
                }
                this._switches = value;
                if (!ReferenceEquals(this._switches, null))
                {
                    this._switches.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem param
        {
            [DebuggerNonUserCode]
            get => 
                this._param;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.param_Click);
                if (!ReferenceEquals(this._param, null))
                {
                    this._param.Click -= handler;
                }
                this._param = value;
                if (!ReferenceEquals(this._param, null))
                {
                    this._param.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem @out
        {
            [DebuggerNonUserCode]
            get => 
                this._out;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.out_Click);
                if (!ReferenceEquals(this._out, null))
                {
                    this._out.Click -= handler;
                }
                this._out = value;
                if (!ReferenceEquals(this._out, null))
                {
                    this._out.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem SetupSimulation
        {
            [DebuggerNonUserCode]
            get => 
                this._SetupSimulation;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.SetupSimulation_Click);
                if (!ReferenceEquals(this._SetupSimulation, null))
                {
                    this._SetupSimulation.Click -= handler;
                }
                this._SetupSimulation = value;
                if (!ReferenceEquals(this._SetupSimulation, null))
                {
                    this._SetupSimulation.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem Editera
        {
            [DebuggerNonUserCode]
            get => 
                this._Editera;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Editera = value;
        }

        public virtual ToolStripMenuItem current
        {
            [DebuggerNonUserCode]
            get => 
                this._current;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.current_Click);
                if (!ReferenceEquals(this._current, null))
                {
                    this._current.Click -= handler;
                }
                this._current = value;
                if (!ReferenceEquals(this._current, null))
                {
                    this._current.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem batch
        {
            [DebuggerNonUserCode]
            get => 
                this._batch;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.batch_Click);
                if (!ReferenceEquals(this._batch, null))
                {
                    this._batch.Click -= handler;
                }
                this._batch = value;
                if (!ReferenceEquals(this._batch, null))
                {
                    this._batch.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem Exec
        {
            [DebuggerNonUserCode]
            get => 
                this._Exec;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Exec = value;
        }

        public virtual ToolStripMenuItem mnuConvertBinToASCII
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuConvertBinToASCII;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuConvertBinToASCII_Click);
                if (!ReferenceEquals(this._mnuConvertBinToASCII, null))
                {
                    this._mnuConvertBinToASCII.Click -= handler;
                }
                this._mnuConvertBinToASCII = value;
                if (!ReferenceEquals(this._mnuConvertBinToASCII, null))
                {
                    this._mnuConvertBinToASCII.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuConvertASCIIToBin
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuConvertASCIIToBin;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuConvertASCIIToBin_Click);
                if (!ReferenceEquals(this._mnuConvertASCIIToBin, null))
                {
                    this._mnuConvertASCIIToBin.Click -= handler;
                }
                this._mnuConvertASCIIToBin = value;
                if (!ReferenceEquals(this._mnuConvertASCIIToBin, null))
                {
                    this._mnuConvertASCIIToBin.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuToolsDailyToHourlyRainfall
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsDailyToHourlyRainfall;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuToolsDailyToHourlyRainfall_Click);
                if (!ReferenceEquals(this._mnuToolsDailyToHourlyRainfall, null))
                {
                    this._mnuToolsDailyToHourlyRainfall.Click -= handler;
                }
                this._mnuToolsDailyToHourlyRainfall = value;
                if (!ReferenceEquals(this._mnuToolsDailyToHourlyRainfall, null))
                {
                    this._mnuToolsDailyToHourlyRainfall.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuToolsConvert
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsConvert;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuToolsConvert = value;
        }

        public virtual ToolStripSeparator sdfsd
        {
            [DebuggerNonUserCode]
            get => 
                this._sdfsd;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._sdfsd = value;
        }

        public virtual ToolStripMenuItem mnuToolsChangeParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsChangeParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuToolsChangeParameters_Click);
                if (!ReferenceEquals(this._mnuToolsChangeParameters, null))
                {
                    this._mnuToolsChangeParameters.Click -= handler;
                }
                this._mnuToolsChangeParameters = value;
                if (!ReferenceEquals(this._mnuToolsChangeParameters, null))
                {
                    this._mnuToolsChangeParameters.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator lkjlkj
        {
            [DebuggerNonUserCode]
            get => 
                this._lkjlkj;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lkjlkj = value;
        }

        public virtual ToolStripMenuItem mnuToolsSUFI
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsSUFI;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuToolsSUFI_Click);
                if (!ReferenceEquals(this._mnuToolsSUFI, null))
                {
                    this._mnuToolsSUFI.Click -= handler;
                }
                this._mnuToolsSUFI = value;
                if (!ReferenceEquals(this._mnuToolsSUFI, null))
                {
                    this._mnuToolsSUFI.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator sdfsdfsdf
        {
            [DebuggerNonUserCode]
            get => 
                this._sdfsdfsdf;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._sdfsdfsdf = value;
        }

        public virtual ToolStripMenuItem Add_Renamed
        {
            [DebuggerNonUserCode]
            get => 
                this._Add_Renamed;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Add_Renamed_Click);
                if (!ReferenceEquals(this._Add_Renamed, null))
                {
                    this._Add_Renamed.Click -= handler;
                }
                this._Add_Renamed = value;
                if (!ReferenceEquals(this._Add_Renamed, null))
                {
                    this._Add_Renamed.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator line5
        {
            [DebuggerNonUserCode]
            get => 
                this._line5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._line5 = value;
        }

        public virtual ToolStripMenuItem mnuMCSample
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuMCSample;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuMCSample_Click);
                if (!ReferenceEquals(this._mnuMCSample, null))
                {
                    this._mnuMCSample.Click -= handler;
                }
                this._mnuMCSample = value;
                if (!ReferenceEquals(this._mnuMCSample, null))
                {
                    this._mnuMCSample.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuToolsExecuteVariationFile
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsExecuteVariationFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuToolsExecuteVariationFile_Click);
                if (!ReferenceEquals(this._mnuToolsExecuteVariationFile, null))
                {
                    this._mnuToolsExecuteVariationFile.Click -= handler;
                }
                this._mnuToolsExecuteVariationFile = value;
                if (!ReferenceEquals(this._mnuToolsExecuteVariationFile, null))
                {
                    this._mnuToolsExecuteVariationFile.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuMCAnalyze
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuMCAnalyze;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuMCAnalyze_Click);
                if (!ReferenceEquals(this._mnuMCAnalyze, null))
                {
                    this._mnuMCAnalyze.Click -= handler;
                }
                this._mnuMCAnalyze = value;
                if (!ReferenceEquals(this._mnuMCAnalyze, null))
                {
                    this._mnuMCAnalyze.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuToolsLHS
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsLHS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuToolsLHS = value;
        }

        public virtual ToolStripMenuItem mnuToolsCompactDatabase
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsCompactDatabase;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuToolsCompactDatabase = value;
        }

        public virtual ToolStripMenuItem mnuTools
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuTools;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuTools = value;
        }

        public virtual ToolStripMenuItem about
        {
            [DebuggerNonUserCode]
            get => 
                this._about;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.about_Click);
                if (!ReferenceEquals(this._about, null))
                {
                    this._about.Click -= handler;
                }
                this._about = value;
                if (!ReferenceEquals(this._about, null))
                {
                    this._about.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuHelp
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuHelp;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuHelp = value;
        }

        public virtual MenuStrip MainMenu1
        {
            [DebuggerNonUserCode]
            get => 
                this._MainMenu1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._MainMenu1 = value;
        }

        internal virtual ToolStripMenuItem ComputeGoalFunctionToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._ComputeGoalFunctionToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.ComputeGoalFunctionToolStripMenuItem_Click);
                if (!ReferenceEquals(this._ComputeGoalFunctionToolStripMenuItem, null))
                {
                    this._ComputeGoalFunctionToolStripMenuItem.Click -= handler;
                }
                this._ComputeGoalFunctionToolStripMenuItem = value;
                if (!ReferenceEquals(this._ComputeGoalFunctionToolStripMenuItem, null))
                {
                    this._ComputeGoalFunctionToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem SaveToparameterFileToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get => 
                this._SaveToparameterFileToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.SaveToparameterFileToolStripMenuItem_Click);
                if (!ReferenceEquals(this._SaveToparameterFileToolStripMenuItem, null))
                {
                    this._SaveToparameterFileToolStripMenuItem.Click -= handler;
                }
                this._SaveToparameterFileToolStripMenuItem = value;
                if (!ReferenceEquals(this._SaveToparameterFileToolStripMenuItem, null))
                {
                    this._SaveToparameterFileToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual Button Button1
        {
            [DebuggerNonUserCode]
            get => 
                this._Button1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click_1);
                if (!ReferenceEquals(this._Button1, null))
                {
                    this._Button1.Click -= handler;
                }
                this._Button1 = value;
                if (!ReferenceEquals(this._Button1, null))
                {
                    this._Button1.Click += handler;
                }
            }
        }

        public Connection DatabaseConnection =>
            this.m_conn;

        public CfrmSetup frmSetup =>
            this.m_frmSetup;

        public CfrmExeParWizard frmExeParWizard =>
            this.m_frmExeParWizard;

        public CfrmSUFIMain frmSUFIMain =>
            this.m_frmSUFIMain;

        public CfrmSoilProperties frmDefineSoil =>
            this.m_frmDefineSoil;

        public CfrmParameters frmParameters =>
            this.m_frmParameters;

        public CfrmOutput OutputForm =>
            this.m_frmOutput;
    }
}

