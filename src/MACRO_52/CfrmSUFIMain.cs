namespace MACRO_52
{
    using ADODB;
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
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class CfrmSUFIMain : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        public ToolTip ToolTip1;
        [AccessedThroughProperty("Timer2")]
        private Timer _Timer2;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        public OpenFileDialog CommonDialog1Open;
        public SaveFileDialog CommonDialog1Save;
        public FontDialog CommonDialog1Font;
        public ColorDialog CommonDialog1Color;
        public PrintDialog CommonDialog1Print;
        [AccessedThroughProperty("cmdChangeSUFIDatabase")]
        private Button _cmdChangeSUFIDatabase;
        [AccessedThroughProperty("cmdComplete")]
        private Button _cmdComplete;
        [AccessedThroughProperty("grdParameters")]
        private AxMSFlexGrid _grdParameters;
        [AccessedThroughProperty("Dir1")]
        private DirListBox _Dir1;
        [AccessedThroughProperty("Drive1")]
        private DriveListBox _Drive1;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("lblTotNoSimsCurrentIteration")]
        private Label _lblTotNoSimsCurrentIteration;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("lblNoExecutedSims")]
        private Label _lblNoExecutedSims;
        [AccessedThroughProperty("lblIterationNumber")]
        private Label _lblIterationNumber;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Frame4")]
        private Panel _Frame4;
        [AccessedThroughProperty("Frame3")]
        private GroupBox _Frame3;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("lblProjectComment")]
        private Label _lblProjectComment;
        [AccessedThroughProperty("lblBaseSimulation")]
        private Label _lblBaseSimulation;
        [AccessedThroughProperty("lblBaseProejct")]
        private Label _lblBaseProejct;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("lblSUFIDatabaseName")]
        private Label _lblSUFIDatabaseName;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("fraMain")]
        private GroupBox _fraMain;
        [AccessedThroughProperty("mnuProjectsNew")]
        private ToolStripMenuItem _mnuProjectsNew;
        [AccessedThroughProperty("mnuProjectsDelete")]
        private ToolStripMenuItem _mnuProjectsDelete;
        [AccessedThroughProperty("line2")]
        private ToolStripSeparator _line2;
        [AccessedThroughProperty("mnuProjectsExit")]
        private ToolStripMenuItem _mnuProjectsExit;
        [AccessedThroughProperty("mnuProjects")]
        private ToolStripMenuItem _mnuProjects;
        [AccessedThroughProperty("mnuIterationNew")]
        private ToolStripMenuItem _mnuIterationNew;
        [AccessedThroughProperty("mnuAnalyseIteration")]
        private ToolStripMenuItem _mnuAnalyseIteration;
        [AccessedThroughProperty("mnuIterationEdit")]
        private ToolStripMenuItem _mnuIterationEdit;
        [AccessedThroughProperty("mnuIterationDeleteCurrent")]
        private ToolStripMenuItem _mnuIterationDeleteCurrent;
        [AccessedThroughProperty("sdfsdf")]
        private ToolStripSeparator _sdfsdf;
        [AccessedThroughProperty("mnuIterationExecute")]
        private ToolStripMenuItem _mnuIterationExecute;
        [AccessedThroughProperty("mnuIterationAutoExecute")]
        private ToolStripMenuItem _mnuIterationAutoExecute;
        [AccessedThroughProperty("mnuIteration")]
        private ToolStripMenuItem _mnuIteration;
        [AccessedThroughProperty("mnuToolsWeighOutputs")]
        private ToolStripMenuItem _mnuToolsWeighOutputs;
        [AccessedThroughProperty("mnuToolsClearCheckedOut")]
        private ToolStripMenuItem _mnuToolsClearCheckedOut;
        [AccessedThroughProperty("mnuToolsModifyMeasured")]
        private ToolStripMenuItem _mnuToolsModifyMeasured;
        [AccessedThroughProperty("mnuTools")]
        private ToolStripMenuItem _mnuTools;
        [AccessedThroughProperty("MainMenu1")]
        private MenuStrip _MainMenu1;
        [AccessedThroughProperty("lstSUFIProjects")]
        private ListBox _lstSUFIProjects;
        [AccessedThroughProperty("lstParameters")]
        private ListBox _lstParameters;
        private int CurProjID;
        private bool b_Manual;
        private int CurIterID;
        private frmExecuteMACRO Exefrm;
        private frmAnalyseSUFI frmAnalyse;
        public object m_bSUFIAutoExec;
        private short m_LOGFILE;
        private CfrmMain frmMain;
        private bool IsInitializing;
        private CfrmNewSUFIProject frmNewSUFIProject;
        private Connection m_SUFIDatabaseConnection;
        public Recordset dbSUFIProjects;
        private Recordset m_dbParameters;
        private Recordset m_dbParameterValues;
        private Recordset m_dbParameterInfo;
        private int m_BaseRunID;
        private int m_CurStrataComboNo;
        private bool m_IsAnalyzing;
        private bool $STATIC$Dispose$20112$fTerminateCalled;

        [DebuggerNonUserCode]
        public CfrmSUFIMain()
        {
            base.Activated += new EventHandler(this.frmSUFIMain_Activated);
            base.Load += new EventHandler(this.frmSUFIMain_Load);
            base.FormClosed += new FormClosedEventHandler(this.frmSUFIMain_FormClosed);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.dbSUFIProjects = new RecordsetClass();
            this.m_dbParameters = new RecordsetClass();
            this.m_dbParameterValues = new RecordsetClass();
            this.m_dbParameterInfo = new RecordsetClass();
            this.InitializeComponent();
        }

        public CfrmSUFIMain(ref CfrmMain frm)
        {
            base.Activated += new EventHandler(this.frmSUFIMain_Activated);
            base.Load += new EventHandler(this.frmSUFIMain_Load);
            base.FormClosed += new FormClosedEventHandler(this.frmSUFIMain_FormClosed);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.dbSUFIProjects = new RecordsetClass();
            this.m_dbParameters = new RecordsetClass();
            this.m_dbParameterValues = new RecordsetClass();
            this.m_dbParameterInfo = new RecordsetClass();
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            this.frmMain = frm;
            this.frmAnalyse = new frmAnalyseSUFI(ref this.frmMain.frmSUFIMain);
            this.frmNewSUFIProject = new CfrmNewSUFIProject(ref this.frmMain);
            this.m_SUFIDatabaseConnection = new ConnectionClass();
            this.m_SUFIDatabaseConnection.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.SUFIDatabaseName + ";Persist Security Info=False", "", "", -1);
            this.UpdateProjectList();
        }

        private void ClearIterationInformation()
        {
            this.lblIterationNumber.Text = "";
            this.lblTotNoSimsCurrentIteration.Text = "";
            this.lblNoExecutedSims.Text = "";
            this.grdParameters.Clear();
            this.mnuAnalyseIteration.Enabled = false;
            this.mnuIterationEdit.Enabled = false;
            this.mnuIterationDeleteCurrent.Enabled = false;
        }

        private void cmdChangeSUFIDatabase_Click(object eventSender, EventArgs eventArgs)
        {
            OpenFileDialog dialog = this.CommonDialog1Open;
            dialog.FileName = "";
            dialog.Filter = "ACCESS databases (*.mdb)|*.mdb";
            dialog.Title = "Locate database";
            string expression = MiscFUncs.BrowseOpen(ref this.CommonDialog1Open);
            dialog = null;
            if (Strings.Len(expression) != 0)
            {
                GlobalVariables.SUFIDatabaseName = expression;
                this.ConnectToSUFIDatabase();
                this.UpdateProjectList();
            }
        }

        public void ConnectToSUFIDatabase()
        {
            CfrmSUFIMain main = this;
            this.lblSUFIDatabaseName.Text = GlobalVariables.SUFIDatabaseName;
            this.m_SUFIDatabaseConnection = null;
            this.m_SUFIDatabaseConnection = new ConnectionClass();
            this.m_SUFIDatabaseConnection.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.SUFIDatabaseName + ";Persist Security Info=False", "", "", -1);
            this.UpdateProjectList();
            main = null;
        }

        public bool DeleteIteration(ref int ProjID, ref int itid, ref bool bAllIterations = true)
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = new RecordsetClass();
            CfrmSUFIMain main = this;
            if (!bAllIterations)
            {
                rs.Open("select * from SUFIIterations where SUFIProjectID=" + Conversions.ToString((int) ProjID) + " and IterationID=" + Conversions.ToString((int) itid), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            }
            else
            {
                rs.Open("select * from SUFIIterations where SUFIProjectID=" + Conversions.ToString((int) ProjID), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            }
            if (ReadSaveFunctions.RecordCount(ref rs) != 0)
            {
                while (true)
                {
                    if (rs.EOF)
                    {
                        rs.Close();
                        break;
                    }
                    recordset2.Open(Operators.ConcatenateObject("select * from SUFIStrataCombinations where IterationID=", rs[]["IterationID"][]), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    while (true)
                    {
                        bool flag2 = !recordset2.EOF;
                        if (!flag2)
                        {
                            recordset2.Close();
                            main.dbParameterValues.Open(Operators.ConcatenateObject("select * from SUFIParameterValues where IterationID=", rs[]["IterationID"][]), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            while (true)
                            {
                                flag2 = !main.dbParameterValues.EOF;
                                if (!flag2)
                                {
                                    main.dbParameterValues.Close();
                                    rs.Delete(AffectEnum.adAffectCurrent);
                                    rs.MoveNext();
                                    break;
                                }
                                main.dbParameterValues.Delete(AffectEnum.adAffectCurrent);
                                main.dbParameterValues.MoveNext();
                            }
                            break;
                        }
                        recordset2.Delete(AffectEnum.adAffectCurrent);
                        recordset2.MoveNext();
                    }
                }
            }
            main = null;
            this.SetProjectInformation();
            this.SetIterationInformation();
            return true;
        }

        private void DeleteProject()
        {
            this.Cursor = Cursors.WaitCursor;
            Recordset recordset = new RecordsetClass();
            CfrmSUFIMain main = this;
            this.DeleteIteration(ref this.CurProjID, ref this.CurIterID, ref true);
            main.dbParameters.Open("select * from SUFIParameters where [SUFIProjectID]=" + Conversions.ToString(this.CurProjID), this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                if (main.dbParameters.EOF)
                {
                    main.dbParameters.Close();
                    recordset.Open("Select * from SUFIProjects where SUFIProjectID=" + Conversions.ToString(this.CurProjID), this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    recordset.Delete(AffectEnum.adAffectCurrent);
                    recordset.Close();
                    this.UpdateProjectList();
                    this.lblBaseProejct.Text = "";
                    this.lblBaseSimulation.Text = "";
                    this.lblProjectComment.Text = "";
                    this.Cursor = Cursors.Default;
                    main = null;
                    return;
                }
                main.dbParameters.Delete(AffectEnum.adAffectCurrent);
                main.dbParameters.MoveNext();
            }
        }

        private void DetermineLayersToUpdate(ref int pos1, ref int pos2, string[] covary, bool bAllHorizons, bool bInitCond, int HNumOrCropYear)
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = rs;
            recordset2.Open("select * from Properties where R_id=" + Conversions.ToString(this.m_BaseRunID), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            pos1 = 1;
            pos2 = 0;
            int index = 0;
            recordset2.MoveFirst();
            int num4 = ReadSaveFunctions.RecordCount(ref rs);
            int num2 = 1;
            while (true)
            {
                int num5 = num4;
                if (num2 > num5)
                {
                    break;
                }
                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(recordset2[]["horiz_no"][], HNumOrCropYear, false), bAllHorizons), Conversions.ToDouble(covary[index]) == 1.0)))
                {
                    covary[index] = Conversions.ToString(0);
                    index++;
                    pos2 = bInitCond ? Conversions.ToInteger(Operators.AddObject((int) pos2, recordset2[]["Nlayer"][])) : (pos2 + 1);
                    if (!bAllHorizons)
                    {
                        break;
                    }
                }
                else
                {
                    index++;
                    if (!bInitCond)
                    {
                        pos1++;
                        pos2++;
                    }
                    else
                    {
                        pos1 = Conversions.ToInteger(Operators.AddObject((int) pos1, recordset2[]["Nlayer"][]));
                        pos2 = Conversions.ToInteger(Operators.AddObject((int) pos2, recordset2[]["Nlayer"][]));
                    }
                }
                recordset2.MoveNext();
                num2++;
            }
            recordset2.Close();
            recordset2 = null;
        }

        private void Dir1_Change(object eventSender, EventArgs eventArgs)
        {
            Recordset recordset = new RecordsetClass();
            if (this.lstSUFIProjects.Text != "")
            {
                Recordset recordset2 = recordset;
                recordset2.Open("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.CurIterID), this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset2[]["OutputFilePath"][] = this.Dir1.Path;
                recordset2.Update(Missing.Value, Missing.Value);
                recordset2.Close();
                recordset2 = null;
            }
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

        private void Drive1_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        public bool ExecuteIteration()
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = rs;
            recordset2.Open("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.CurIterID) + " and Executed=0", this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            short num = (short) ReadSaveFunctions.RecordCount(ref rs);
            recordset2.Close();
            recordset2 = null;
            this.Exefrm = new frmExecuteMACRO(ref this.frmMain);
            frmExecuteMACRO exefrm = this.Exefrm;
            exefrm.Text = "MACRO 5.2 - Executing SUFI iteration";
            exefrm.fraBatch.Text = "Iteration status";
            exefrm.lstSimulations.Visible = false;
            exefrm.lblNoSimsDone.Visible = true;
            exefrm.lblNoSimsDone.Text = this.lblNoExecutedSims.Text;
            exefrm.lblTotNoSims.Visible = true;
            exefrm.lblTotNoSims.Text = this.lblTotNoSimsCurrentIteration.Text;
            exefrm.lblOutOf.Visible = true;
            exefrm.Label1.Visible = false;
            exefrm.Label4.Visible = true;
            exefrm.m_SUFI = true;
            exefrm = null;
            this.NextSimulation();
            return true;
        }

        public void FillParameterList()
        {
            this.lstParameters.Items.Clear();
            Recordset dbParameters = this.dbParameters;
            this.OpenCurrentParameters(ref dbParameters);
            this.dbParameters = dbParameters;
            while (true)
            {
                if (this.m_dbParameters.EOF)
                {
                    this.m_dbParameters.Close();
                    return;
                }
                this.lstParameters.Items.Add(this.m_dbParameters[]["Name"][]);
                this.m_dbParameters.MoveNext();
            }
        }

        private void Form_Terminate_Renamed()
        {
            this.frmMain.Show();
        }

        private void frmSUFIMain_Activated(object eventSender, EventArgs eventArgs)
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = new RecordsetClass();
            if ((!this.IsInitializing & !this.m_IsAnalyzing) && (this.CurIterID != 0))
            {
                Recordset recordset3 = rs;
                recordset3.Open("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.CurIterID), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset2.Open("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.CurIterID) + " AND Executed=-1", this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                if (ReadSaveFunctions.RecordCount(ref rs) != 0)
                {
                    recordset3[]["NoCompletedSimulations"][] = ReadSaveFunctions.RecordCount(ref recordset2);
                    recordset3.Update(Missing.Value, Missing.Value);
                }
                recordset3.Close();
                recordset2.Close();
                recordset3 = null;
                this.UpdateProjectList();
                this.SetProjectInformation();
                this.ConnectToSUFIDatabase();
                this.SetIterationInformation();
            }
        }

        private void frmSUFIMain_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            this.frmMain.Show();
        }

        private void frmSUFIMain_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
            this.ConnectToSUFIDatabase();
        }

        private void GetTableAndHorizonInfo(ref string DatabaseTable, ref bool AllHorizons, ref short HNum, string ParameterName, ref string CompleteParameterName)
        {
            Recordset dbParameterInfo = this.dbParameterInfo;
            if (ParameterName == "GWFLUX")
            {
                ParameterName = "BGRAD";
            }
            if (ParameterName == "ZLAMB")
            {
                ParameterName = "N";
            }
            if (ParameterName == "SCALEVG")
            {
                ParameterName = "ALPHA";
            }
            try
            {
                dbParameterInfo.Open("select * from ParameterInfoSUFI where ParameterName='" + ParameterName + "'", this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                MessageBox.Show("Error opening table 'ParameterInfoSUFI'\r\n" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
            AllHorizons = false;
            DatabaseTable = Conversions.ToString(dbParameterInfo[]["Table"][]);
            if ((ParameterName == "ALPHA") & (DatabaseTable == "Solute()"))
            {
                DatabaseTable = "Physical parameters";
            }
            if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(dbParameterInfo[]["Length"][], 1, false), DatabaseTable == "Crop")))
            {
                short start = (short) (Strings.InStr(1, CompleteParameterName, "(", CompareMethod.Binary) + 1);
                short num2 = (short) Strings.InStr(1, CompleteParameterName, ")", CompareMethod.Binary);
                if (Strings.Mid(CompleteParameterName, start, (short) (num2 - start)) == "all")
                {
                    AllHorizons = true;
                }
                else
                {
                    HNum = Conversions.ToShort(Strings.Mid(CompleteParameterName, start, (short) (num2 - start)));
                }
            }
            dbParameterInfo.Close();
            dbParameterInfo = null;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmSUFIMain));
            this.ToolTip1 = new ToolTip(this.components);
            this.Timer2 = new Timer(this.components);
            this.Timer1 = new Timer(this.components);
            this.CommonDialog1Open = new OpenFileDialog();
            this.CommonDialog1Save = new SaveFileDialog();
            this.CommonDialog1Font = new FontDialog();
            this.CommonDialog1Color = new ColorDialog();
            this.CommonDialog1Print = new PrintDialog();
            this.fraMain = new GroupBox();
            this.cmdChangeSUFIDatabase = new Button();
            this.Frame3 = new GroupBox();
            this.Frame4 = new Panel();
            this.cmdComplete = new Button();
            this.grdParameters = new AxMSFlexGrid();
            this.Dir1 = new DirListBox();
            this.Drive1 = new DriveListBox();
            this.Label11 = new Label();
            this.Label8 = new Label();
            this.lblTotNoSimsCurrentIteration = new Label();
            this.Label7 = new Label();
            this.lblNoExecutedSims = new Label();
            this.lblIterationNumber = new Label();
            this.Label6 = new Label();
            this.Frame2 = new GroupBox();
            this.lstParameters = new ListBox();
            this.Label5 = new Label();
            this.lblProjectComment = new Label();
            this.lblBaseSimulation = new Label();
            this.lblBaseProejct = new Label();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.Frame1 = new GroupBox();
            this.lstSUFIProjects = new ListBox();
            this.lblSUFIDatabaseName = new Label();
            this.Label9 = new Label();
            this.MainMenu1 = new MenuStrip();
            this.mnuProjects = new ToolStripMenuItem();
            this.mnuProjectsNew = new ToolStripMenuItem();
            this.mnuProjectsDelete = new ToolStripMenuItem();
            this.line2 = new ToolStripSeparator();
            this.mnuProjectsExit = new ToolStripMenuItem();
            this.mnuIteration = new ToolStripMenuItem();
            this.mnuIterationNew = new ToolStripMenuItem();
            this.mnuAnalyseIteration = new ToolStripMenuItem();
            this.mnuIterationEdit = new ToolStripMenuItem();
            this.mnuIterationDeleteCurrent = new ToolStripMenuItem();
            this.sdfsdf = new ToolStripSeparator();
            this.mnuIterationExecute = new ToolStripMenuItem();
            this.mnuIterationAutoExecute = new ToolStripMenuItem();
            this.mnuTools = new ToolStripMenuItem();
            this.mnuToolsWeighOutputs = new ToolStripMenuItem();
            this.mnuToolsClearCheckedOut = new ToolStripMenuItem();
            this.mnuToolsModifyMeasured = new ToolStripMenuItem();
            this.fraMain.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.Frame4.SuspendLayout();
            this.grdParameters.BeginInit();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.MainMenu1.SuspendLayout();
            this.SuspendLayout();
            this.Timer2.Enabled = true;
            this.Timer2.Interval = 0xbb8;
            this.Timer1.Interval = 0xbb8;
            this.fraMain.BackColor = SystemColors.Control;
            this.fraMain.Controls.Add(this.cmdChangeSUFIDatabase);
            this.fraMain.Controls.Add(this.Frame3);
            this.fraMain.Controls.Add(this.Frame2);
            this.fraMain.Controls.Add(this.Frame1);
            this.fraMain.Controls.Add(this.lblSUFIDatabaseName);
            this.fraMain.Controls.Add(this.Label9);
            this.fraMain.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraMain.ForeColor = SystemColors.ControlText;
            Point point = new Point(5, 0x1b);
            this.fraMain.Location = point;
            this.fraMain.Name = "fraMain";
            this.fraMain.RightToLeft = RightToLeft.No;
            Size size = new Size(0x25e, 0x20c);
            this.fraMain.Size = size;
            this.fraMain.TabIndex = 0;
            this.fraMain.TabStop = false;
            this.cmdChangeSUFIDatabase.BackColor = SystemColors.Control;
            this.cmdChangeSUFIDatabase.Cursor = Cursors.Default;
            this.cmdChangeSUFIDatabase.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdChangeSUFIDatabase.ForeColor = SystemColors.ControlText;
            point = new Point(0x1df, 0x1f0);
            this.cmdChangeSUFIDatabase.Location = point;
            this.cmdChangeSUFIDatabase.Name = "cmdChangeSUFIDatabase";
            this.cmdChangeSUFIDatabase.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 0x11);
            this.cmdChangeSUFIDatabase.Size = size;
            this.cmdChangeSUFIDatabase.TabIndex = 0x1b;
            this.cmdChangeSUFIDatabase.Text = "...";
            this.cmdChangeSUFIDatabase.UseVisualStyleBackColor = false;
            this.Frame3.BackColor = SystemColors.Control;
            this.Frame3.Controls.Add(this.Frame4);
            this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x110);
            this.Frame3.Location = point;
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = RightToLeft.No;
            size = new Size(0x250, 0xd9);
            this.Frame3.Size = size;
            this.Frame3.TabIndex = 10;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Current iteration";
            this.Frame4.BackColor = SystemColors.Control;
            this.Frame4.Controls.Add(this.cmdComplete);
            this.Frame4.Controls.Add(this.grdParameters);
            this.Frame4.Controls.Add(this.Dir1);
            this.Frame4.Controls.Add(this.Drive1);
            this.Frame4.Controls.Add(this.Label11);
            this.Frame4.Controls.Add(this.Label8);
            this.Frame4.Controls.Add(this.lblTotNoSimsCurrentIteration);
            this.Frame4.Controls.Add(this.Label7);
            this.Frame4.Controls.Add(this.lblNoExecutedSims);
            this.Frame4.Controls.Add(this.lblIterationNumber);
            this.Frame4.Controls.Add(this.Label6);
            this.Frame4.Cursor = Cursors.Default;
            this.Frame4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Frame4.Location = point;
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = RightToLeft.No;
            size = new Size(0x242, 0xc1);
            this.Frame4.Size = size;
            this.Frame4.TabIndex = 11;
            this.Frame4.Text = "Current";
            this.cmdComplete.BackColor = SystemColors.Control;
            this.cmdComplete.Cursor = Cursors.Default;
            this.cmdComplete.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdComplete.ForeColor = SystemColors.ControlText;
            point = new Point(0xd0, 8);
            this.cmdComplete.Location = point;
            this.cmdComplete.Name = "cmdComplete";
            this.cmdComplete.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdComplete.Size = size;
            this.cmdComplete.TabIndex = 0x1c;
            this.cmdComplete.Text = "Complete";
            this.cmdComplete.UseVisualStyleBackColor = false;
            this.cmdComplete.Visible = false;
            point = new Point(8, 0x40);
            this.grdParameters.Location = point;
            this.grdParameters.Name = "grdParameters";
            this.grdParameters.OcxState = (AxHost.State) manager.GetObject("grdParameters.OcxState");
            size = new Size(0x170, 0xc1);
            this.grdParameters.Size = size;
            this.grdParameters.TabIndex = 0x16;
            this.Dir1.BackColor = SystemColors.Window;
            this.Dir1.Cursor = Cursors.Default;
            this.Dir1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Dir1.ForeColor = SystemColors.WindowText;
            this.Dir1.FormattingEnabled = true;
            this.Dir1.IntegralHeight = false;
            point = new Point(0x18f, 40);
            this.Dir1.Location = point;
            this.Dir1.Name = "Dir1";
            size = new Size(0xa1, 0x8d);
            this.Dir1.Size = size;
            this.Dir1.TabIndex = 0x13;
            this.Drive1.BackColor = SystemColors.Window;
            this.Drive1.Cursor = Cursors.Default;
            this.Drive1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Drive1.ForeColor = SystemColors.WindowText;
            this.Drive1.FormattingEnabled = true;
            point = new Point(0x18f, 0x10);
            this.Drive1.Location = point;
            this.Drive1.Name = "Drive1";
            size = new Size(0xa1, 0x15);
            this.Drive1.Size = size;
            this.Drive1.TabIndex = 0x12;
            this.Label11.BackColor = SystemColors.Control;
            this.Label11.Cursor = Cursors.Default;
            this.Label11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label11.ForeColor = SystemColors.ControlText;
            point = new Point(0x18f, 0);
            this.Label11.Location = point;
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this.Label11.Size = size;
            this.Label11.TabIndex = 20;
            this.Label11.Text = "Output path:";
            this.Label8.BackColor = SystemColors.Control;
            this.Label8.Cursor = Cursors.Default;
            this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = SystemColors.ControlText;
            point = new Point(120, 40);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.Label8.Size = size;
            this.Label8.TabIndex = 0x11;
            this.Label8.Text = "simulations completed.";
            this.lblTotNoSimsCurrentIteration.BackColor = SystemColors.Window;
            this.lblTotNoSimsCurrentIteration.BorderStyle = BorderStyle.FixedSingle;
            this.lblTotNoSimsCurrentIteration.Cursor = Cursors.Default;
            this.lblTotNoSimsCurrentIteration.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTotNoSimsCurrentIteration.ForeColor = SystemColors.WindowText;
            point = new Point(80, 40);
            this.lblTotNoSimsCurrentIteration.Location = point;
            this.lblTotNoSimsCurrentIteration.Name = "lblTotNoSimsCurrentIteration";
            this.lblTotNoSimsCurrentIteration.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x11);
            this.lblTotNoSimsCurrentIteration.Size = size;
            this.lblTotNoSimsCurrentIteration.TabIndex = 0x10;
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = SystemColors.ControlText;
            point = new Point(0x30, 40);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 15;
            this.Label7.Text = "out of";
            this.lblNoExecutedSims.BackColor = SystemColors.Window;
            this.lblNoExecutedSims.BorderStyle = BorderStyle.FixedSingle;
            this.lblNoExecutedSims.Cursor = Cursors.Default;
            this.lblNoExecutedSims.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblNoExecutedSims.ForeColor = SystemColors.WindowText;
            point = new Point(8, 40);
            this.lblNoExecutedSims.Location = point;
            this.lblNoExecutedSims.Name = "lblNoExecutedSims";
            this.lblNoExecutedSims.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x11);
            this.lblNoExecutedSims.Size = size;
            this.lblNoExecutedSims.TabIndex = 14;
            this.lblIterationNumber.BackColor = SystemColors.Window;
            this.lblIterationNumber.BorderStyle = BorderStyle.FixedSingle;
            this.lblIterationNumber.Cursor = Cursors.Default;
            this.lblIterationNumber.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblIterationNumber.ForeColor = SystemColors.WindowText;
            point = new Point(0x60, 0x10);
            this.lblIterationNumber.Location = point;
            this.lblIterationNumber.Name = "lblIterationNumber";
            this.lblIterationNumber.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x11);
            this.lblIterationNumber.Size = size;
            this.lblIterationNumber.TabIndex = 13;
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x11);
            this.Label6.Size = size;
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Iteration number:";
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this.lstParameters);
            this.Frame2.Controls.Add(this.Label5);
            this.Frame2.Controls.Add(this.lblProjectComment);
            this.Frame2.Controls.Add(this.lblBaseSimulation);
            this.Frame2.Controls.Add(this.lblBaseProejct);
            this.Frame2.Controls.Add(this.Label4);
            this.Frame2.Controls.Add(this.Label3);
            this.Frame2.Controls.Add(this.Label2);
            this.Frame2.Controls.Add(this.Label1);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(240, 0x10);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(360, 250);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 2;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Project information:";
            this.lstParameters.FormattingEnabled = true;
            this.lstParameters.ItemHeight = 14;
            point = new Point(11, 0xbc);
            this.lstParameters.Location = point;
            this.lstParameters.Name = "lstParameters";
            size = new Size(120, 60);
            this.lstParameters.Size = size;
            this.lstParameters.TabIndex = 0x16;
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xa8);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 0x15;
            this.Label5.Text = "Parameters:";
            this.lblProjectComment.BackColor = SystemColors.Window;
            this.lblProjectComment.BorderStyle = BorderStyle.FixedSingle;
            this.lblProjectComment.Cursor = Cursors.Default;
            this.lblProjectComment.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblProjectComment.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x68);
            this.lblProjectComment.Location = point;
            this.lblProjectComment.Name = "lblProjectComment";
            this.lblProjectComment.RightToLeft = RightToLeft.No;
            size = new Size(0x15a, 0x39);
            this.lblProjectComment.Size = size;
            this.lblProjectComment.TabIndex = 9;
            this.lblBaseSimulation.BackColor = SystemColors.Window;
            this.lblBaseSimulation.BorderStyle = BorderStyle.FixedSingle;
            this.lblBaseSimulation.Cursor = Cursors.Default;
            this.lblBaseSimulation.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblBaseSimulation.ForeColor = SystemColors.WindowText;
            point = new Point(0x58, 0x40);
            this.lblBaseSimulation.Location = point;
            this.lblBaseSimulation.Name = "lblBaseSimulation";
            this.lblBaseSimulation.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this.lblBaseSimulation.Size = size;
            this.lblBaseSimulation.TabIndex = 8;
            this.lblBaseProejct.BackColor = SystemColors.Window;
            this.lblBaseProejct.BorderStyle = BorderStyle.FixedSingle;
            this.lblBaseProejct.Cursor = Cursors.Default;
            this.lblBaseProejct.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblBaseProejct.ForeColor = SystemColors.WindowText;
            point = new Point(0x58, 40);
            this.lblBaseProejct.Location = point;
            this.lblBaseProejct.Name = "lblBaseProejct";
            this.lblBaseProejct.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this.lblBaseProejct.Size = size;
            this.lblBaseProejct.TabIndex = 7;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 0x40);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Simulation:";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 40);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Project:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x58);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Comment:";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Base simulation:";
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.lstSUFIProjects);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0xd9, 0xa1);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 1;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Available SUFI projects:";
            this.lstSUFIProjects.FormattingEnabled = true;
            this.lstSUFIProjects.ItemHeight = 14;
            point = new Point(8, 0x13);
            this.lstSUFIProjects.Location = point;
            this.lstSUFIProjects.Name = "lstSUFIProjects";
            size = new Size(0xcb, 130);
            this.lstSUFIProjects.Size = size;
            this.lstSUFIProjects.TabIndex = 0;
            this.lblSUFIDatabaseName.BackColor = SystemColors.Window;
            this.lblSUFIDatabaseName.BorderStyle = BorderStyle.FixedSingle;
            this.lblSUFIDatabaseName.Cursor = Cursors.Default;
            this.lblSUFIDatabaseName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblSUFIDatabaseName.ForeColor = SystemColors.WindowText;
            point = new Point(0x58, 0x1f0);
            this.lblSUFIDatabaseName.Location = point;
            this.lblSUFIDatabaseName.Name = "lblSUFIDatabaseName";
            this.lblSUFIDatabaseName.RightToLeft = RightToLeft.No;
            size = new Size(0x181, 0x11);
            this.lblSUFIDatabaseName.Size = size;
            this.lblSUFIDatabaseName.TabIndex = 0x1a;
            this.Label9.BackColor = SystemColors.Control;
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x1f0);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            size = new Size(0x61, 0x11);
            this.Label9.Size = size;
            this.Label9.TabIndex = 0x19;
            this.Label9.Text = "SUFI database:";
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.mnuProjects, this.mnuIteration, this.mnuTools };
            this.MainMenu1.Items.AddRange(toolStripItems);
            point = new Point(0, 0);
            this.MainMenu1.Location = point;
            this.MainMenu1.Name = "MainMenu1";
            size = new Size(0x26f, 0x18);
            this.MainMenu1.Size = size;
            this.MainMenu1.TabIndex = 1;
            toolStripItems = new ToolStripItem[] { this.mnuProjectsNew, this.mnuProjectsDelete, this.line2, this.mnuProjectsExit };
            this.mnuProjects.DropDownItems.AddRange(toolStripItems);
            this.mnuProjects.Name = "mnuProjects";
            size = new Size(0x23, 20);
            this.mnuProjects.Size = size;
            this.mnuProjects.Text = "&File";
            this.mnuProjectsNew.Name = "mnuProjectsNew";
            size = new Size(0xa5, 0x16);
            this.mnuProjectsNew.Size = size;
            this.mnuProjectsNew.Text = "&New project...";
            this.mnuProjectsDelete.Name = "mnuProjectsDelete";
            size = new Size(0xa5, 0x16);
            this.mnuProjectsDelete.Size = size;
            this.mnuProjectsDelete.Text = "&Delete project...";
            this.line2.Name = "line2";
            size = new Size(0xa2, 6);
            this.line2.Size = size;
            this.mnuProjectsExit.Name = "mnuProjectsExit";
            size = new Size(0xa5, 0x16);
            this.mnuProjectsExit.Size = size;
            this.mnuProjectsExit.Text = "E&xit";
            toolStripItems = new ToolStripItem[] { this.mnuIterationNew, this.mnuAnalyseIteration, this.mnuIterationEdit, this.mnuIterationDeleteCurrent, this.sdfsdf, this.mnuIterationExecute, this.mnuIterationAutoExecute };
            this.mnuIteration.DropDownItems.AddRange(toolStripItems);
            this.mnuIteration.Name = "mnuIteration";
            size = new Size(0x3d, 20);
            this.mnuIteration.Size = size;
            this.mnuIteration.Text = "&Iteration";
            this.mnuIterationNew.Enabled = false;
            this.mnuIterationNew.Name = "mnuIterationNew";
            size = new Size(0xae, 0x16);
            this.mnuIterationNew.Size = size;
            this.mnuIterationNew.Text = "&New...";
            this.mnuAnalyseIteration.Enabled = false;
            this.mnuAnalyseIteration.Name = "mnuAnalyseIteration";
            size = new Size(0xae, 0x16);
            this.mnuAnalyseIteration.Size = size;
            this.mnuAnalyseIteration.Text = "&Analyze...";
            this.mnuIterationEdit.Enabled = false;
            this.mnuIterationEdit.Name = "mnuIterationEdit";
            size = new Size(0xae, 0x16);
            this.mnuIterationEdit.Size = size;
            this.mnuIterationEdit.Text = "&Edit...";
            this.mnuIterationDeleteCurrent.Enabled = false;
            this.mnuIterationDeleteCurrent.Name = "mnuIterationDeleteCurrent";
            size = new Size(0xae, 0x16);
            this.mnuIterationDeleteCurrent.Size = size;
            this.mnuIterationDeleteCurrent.Text = "&Delete iteration";
            this.sdfsdf.Name = "sdfsdf";
            size = new Size(0xab, 6);
            this.sdfsdf.Size = size;
            this.mnuIterationExecute.Enabled = false;
            this.mnuIterationExecute.Name = "mnuIterationExecute";
            size = new Size(0xae, 0x16);
            this.mnuIterationExecute.Size = size;
            this.mnuIterationExecute.Text = "E&xecute current...";
            this.mnuIterationAutoExecute.Enabled = false;
            this.mnuIterationAutoExecute.Name = "mnuIterationAutoExecute";
            size = new Size(0xae, 0x16);
            this.mnuIterationAutoExecute.Size = size;
            this.mnuIterationAutoExecute.Text = "&Auto execute";
            this.mnuIterationAutoExecute.Visible = false;
            toolStripItems = new ToolStripItem[] { this.mnuToolsWeighOutputs, this.mnuToolsClearCheckedOut, this.mnuToolsModifyMeasured };
            this.mnuTools.DropDownItems.AddRange(toolStripItems);
            this.mnuTools.Name = "mnuTools";
            size = new Size(0x2c, 20);
            this.mnuTools.Size = size;
            this.mnuTools.Text = "&Tools";
            this.mnuTools.Visible = false;
            this.mnuToolsWeighOutputs.Enabled = false;
            this.mnuToolsWeighOutputs.Name = "mnuToolsWeighOutputs";
            size = new Size(0xd5, 0x16);
            this.mnuToolsWeighOutputs.Size = size;
            this.mnuToolsWeighOutputs.Text = "Weight &outputs";
            this.mnuToolsClearCheckedOut.Enabled = false;
            this.mnuToolsClearCheckedOut.Name = "mnuToolsClearCheckedOut";
            size = new Size(0xd5, 0x16);
            this.mnuToolsClearCheckedOut.Size = size;
            this.mnuToolsClearCheckedOut.Text = "Clear c&hecked out";
            this.mnuToolsClearCheckedOut.Visible = false;
            this.mnuToolsModifyMeasured.Enabled = false;
            this.mnuToolsModifyMeasured.Name = "mnuToolsModifyMeasured";
            size = new Size(0xd5, 0x16);
            this.mnuToolsModifyMeasured.Size = size;
            this.mnuToolsModifyMeasured.Text = "&Modify measured values...";
            this.mnuToolsModifyMeasured.Visible = false;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x26f, 0x233);
            this.ClientSize = size;
            this.Controls.Add(this.fraMain);
            this.Controls.Add(this.MainMenu1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            point = new Point(3, 0x29);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmSUFIMain";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SUFI";
            this.fraMain.ResumeLayout(false);
            this.Frame3.ResumeLayout(false);
            this.Frame4.ResumeLayout(false);
            this.grdParameters.EndInit();
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void lstSUFIProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetProjectInformation();
            this.SetIterationInformation();
        }

        public void mnuAnalyseIteration_Click(object eventSender, EventArgs eventArgs)
        {
            this.Hide();
            this.m_IsAnalyzing = true;
            this.ConnectToSUFIDatabase();
            this.frmAnalyse = new frmAnalyseSUFI(ref this);
            this.frmAnalyse.ShowDialog();
            if (!Information.IsDBNull(this.frmAnalyse) && !this.frmAnalyse.m_bDone)
            {
                this.Show();
            }
            this.frmAnalyse = null;
            this.m_IsAnalyzing = false;
        }

        public void mnuIterationDeleteCurrent_Click(object eventSender, EventArgs eventArgs)
        {
            if (Operators.ConditionalCompareObjectEqual(MiscFUncs.MsgBox_Renamed("Are you sure?", 0x24, "Delete iteration"), MsgBoxResult.Yes, false))
            {
                this.DeleteIteration(ref this.CurProjID, ref this.CurIterID, ref false);
            }
            this.CurIterID = 0;
        }

        public void mnuIterationEdit_Click(object eventSender, EventArgs eventArgs)
        {
            frmNewSUFIIteration iteration = new frmNewSUFIIteration(ref this.frmMain);
            frmNewSUFIIteration iteration2 = iteration;
            iteration2.Text = "Edit iteration properties";
            iteration2.IterationID = this.CurIterID;
            iteration2.ProjectID = this.CurProjID;
            iteration2.lblProjectName.Text = this.lstSUFIProjects.Text;
            iteration2.lblIterationNumber.Text = this.lblIterationNumber.Text;
            iteration2.Drive1.Drive = this.Drive1.Drive;
            iteration2.Dir1.Path = this.Dir1.Path;
            iteration2.SetupTable2();
            iteration2.bEdit = true;
            iteration2.ShowDialog();
            iteration2.bEdit = false;
            iteration2 = null;
            iteration.Close();
            this.SetIterationInformation();
        }

        public void mnuIterationExecute_Click(object eventSender, EventArgs eventArgs)
        {
            this.ExecuteIteration();
        }

        public void mnuIterationNew_Click(object eventSender, EventArgs eventArgs)
        {
            frmNewSUFIIteration iteration = new frmNewSUFIIteration(ref this.frmMain);
            Recordset rs = new RecordsetClass();
            frmNewSUFIIteration iteration2 = iteration;
            iteration2.lblProjectName.Text = this.lstSUFIProjects.Text;
            rs.Open("select * from SUFIIterations where SUFIProjectID=" + Conversions.ToString(this.CurProjID), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            iteration2.lblIterationNumber.Text = Conversions.ToString((int) (ReadSaveFunctions.RecordCount(ref rs) + 1));
            rs.Close();
            rs.Open("select * from Run_ID where R_ID=" + Conversions.ToString(this.m_BaseRunID), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            try
            {
                iteration2.Drive1.Drive = Strings.Left(Conversions.ToString(rs[]["Outputfiledir"][]), 2);
                iteration2.Dir1.Path = Conversions.ToString(rs[]["Outputfiledir"][]);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                iteration2.Drive1.Drive = Strings.Left(MyProject.Application.Info.DirectoryPath, 2);
                iteration2.Dir1.Path = MyProject.Application.Info.DirectoryPath;
                ProjectData.ClearProjectError();
            }
            rs.Close();
            iteration2.ShowDialog();
            iteration2 = null;
            iteration.Close();
            this.SetIterationInformation();
        }

        public void mnuProjectsDelete_Click(object eventSender, EventArgs eventArgs)
        {
            this.dbSUFIProjects.Open("select * from sufiprojects", this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (this.dbSUFIProjects.EOF | this.dbSUFIProjects.BOF)
            {
                MiscFUncs.MsgBox_Renamed("No projects defined", 0x40, "Delete");
            }
            else if (this.lstSUFIProjects.Text == "")
            {
                MiscFUncs.MsgBox_Renamed("Select a project", 0x40, "Select project");
            }
            else if (Conversions.ToShort(MiscFUncs.MsgBox_Renamed("This will delete currently selected project: " + this.lstSUFIProjects.Text + "\rProceed?", 0x41, "Delete project")) != 2)
            {
                this.Cursor = Cursors.WaitCursor;
                Recordset dbSUFIProjects = this.dbSUFIProjects;
                dbSUFIProjects.MoveFirst();
                dbSUFIProjects.Find("ProjectName='" + this.lstSUFIProjects.Text + "'", 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                this.DeleteProject();
                this.grdParameters.Clear();
                dbSUFIProjects = null;
                this.dbSUFIProjects.Close();
                this.Cursor = Cursors.Default;
            }
        }

        public void mnuProjectsExit_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
            this.frmMain.Show();
        }

        public void mnuProjectsNew_Click(object eventSender, EventArgs eventArgs)
        {
            this.frmNewSUFIProject = new CfrmNewSUFIProject(ref this.frmMain);
            this.frmNewSUFIProject.ShowDialog();
            this.UpdateProjectList();
        }

        public void mnuToolsWeighOutputs_Click(object eventSender, EventArgs eventArgs)
        {
            Recordset rs = new RecordsetClass();
            frmAggregateOutputs outputs2 = new frmAggregateOutputs(ref this.frmMain.frmSUFIMain, this.CurProjID);
            rs.Open("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentIterationID), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            outputs2.lblSUFIProject.Text = this.lstSUFIProjects.Text;
            outputs2.UpDown1.Max = ReadSaveFunctions.RecordCount(ref rs);
            outputs2.txtIterationNo.Text = this.lblIterationNumber.Text;
            if (outputs2.GetProjectInfo() && outputs2.Update_Renamed())
            {
                outputs2.ShowDialog();
                rs.Close();
                outputs2 = null;
            }
        }

        public void MoveSUFIOutputFiles()
        {
            Recordset recordset = new RecordsetClass();
            recordset.Open("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.CurIterID), this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            string str = Conversions.ToString(recordset[]["OutputFilePath"][]);
            string str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("iter_", recordset[]["IterationNo"][]), "_"), GlobalVariables.IDExecute), "_"), this.m_CurStrataComboNo), ".bin"));
            string str3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("iter_", recordset[]["IterationNo"][]), "_"), GlobalVariables.IDExecute), "_"), this.m_CurStrataComboNo), ".sum"));
            string str4 = "";
            if (GlobalVariables.IDExecute < 10)
            {
                str4 = "00";
            }
            else if (GlobalVariables.IDExecute < 100)
            {
                str4 = "0";
            }
            str4 = str4 + Conversions.ToString(GlobalVariables.IDExecute);
            if (MiscFUncs.FileExists(str + @"\" + str2))
            {
                MiscFUncs.DeleteFile(ref str + @"\" + str2);
            }
            if (MiscFUncs.FileExists(str + @"\" + str3))
            {
                MiscFUncs.DeleteFile(ref str + @"\" + str3);
            }
            MyProject.Computer.FileSystem.CopyFile(MyProject.Application.Info.DirectoryPath + @"\macro" + str4 + ".bin", str + @"\" + str2, true);
        }

        public void NextSimulation()
        {
            Recordset rs = new RecordsetClass();
            string strataCombination = "";
            Recordset recordset2 = new RecordsetClass();
            Recordset recordset3 = rs;
            recordset3.Open("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.CurIterID) + " and Executed=0 and CheckedOut=0", this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (ReadSaveFunctions.RecordCount(ref rs) > 0)
            {
                try
                {
                    rs.MoveFirst();
                    recordset3[]["CheckedOut"][] = 1;
                    strataCombination = Conversions.ToString(recordset3[]["Combo"][]);
                    this.m_CurStrataComboNo = Conversions.ToInteger(recordset3[]["StrataComboNo"][]);
                    recordset3.Update(Missing.Value, Missing.Value);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    MessageBox.Show("Error getting strata combination:\r\n" + exception.Message, "Error");
                    ProjectData.ClearProjectError();
                }
            }
            recordset3 = null;
            Recordset recordset4 = rs;
            if (ReadSaveFunctions.RecordCount(ref rs) != 0)
            {
                this.UpdateBaseSimulation(strataCombination);
                this.Hide();
                GlobalVariables.IDExecute = this.m_BaseRunID;
                this.Exefrm.lblRunName.Text = "Running SUFI iteration";
                this.Exefrm.m_Exe = false;
                this.Exefrm.Show();
                this.Exefrm.frmExecuteMACRO_Activated(null, new EventArgs());
            }
            else
            {
                try
                {
                    recordset2.Open("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.CurIterID), this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    recordset2[]["nocompletedsimulations"][] = recordset2[]["nosimulations"][];
                    recordset2.Update(Missing.Value, Missing.Value);
                    recordset2.Close();
                    this.lblNoExecutedSims.Text = Conversions.ToString((double) (Conversions.ToDouble(this.lblNoExecutedSims.Text) + 1.0));
                    this.SetIterationInformation();
                }
                catch (Exception exception3)
                {
                    Exception ex = exception3;
                    ProjectData.SetProjectError(ex);
                    Exception exception2 = ex;
                    MessageBox.Show("Error updating iteration information: \r\n" + exception2.Message, "Error");
                    ProjectData.ClearProjectError();
                }
                MiscFUncs.MsgBox_Renamed("Iteration completed", 0x40, "");
                this.Exefrm.Close();
                this.Show();
            }
            recordset4 = null;
        }

        public void OpenCurrentIteration(ref Recordset rs)
        {
            rs.Open("select * from SUFIIterations where IterationNo=" + Conversions.ToString(this.CurIterID) + " AND SUFIProjectID=" + Conversions.ToString(this.CurProjID), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
        }

        public void OpenCurrentParameters(ref Recordset rs)
        {
            rs.Open("select * from SUFIParameters where SUFIProjectID=" + Conversions.ToString(this.CurProjID), this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
        }

        private void SetIterationInformation()
        {
            // Invalid method body.
        }

        private string SetParameterName(string name) => 
            (name != "BGRAD") ? ((name != "N") ? ((name != "ALPHA") ? ((name != "GAMMA_TILLED") ? ((name != "XMPOR_TILLED") ? ((name != "ZN_TILLED") ? ((name != "KSM_TILLED") ? ((name != "CONSOL_STATE") ? ((name != "INIT_ASCALE") ? ((name != "SEAL_STATE") ? ((name != "GAMMA_SEAL") ? ((name != "ZN_SEAL") ? ((name != "HALFAMOUNT_SEAL") ? ((name != "XMPOR_SEAL") ? ((name != "KSM_SEAL") ? name : "KSMSEAL") : "XMPORSEAL") : "HALFCRUS") : "ZNSEAL") : "GAMMASEAL") : "CRUSTSTA") : "I_ASCALE") : "CONS_STA") : "KSMTILLE") : "MACD_CH") : "MACP_CH") : "GAMMA_CH") : "SCALEVG") : "ZLAMB") : "GWFLUX";

        private void SetProjectInformation()
        {
            Recordset rs = new RecordsetClass();
            if (this.lstSUFIProjects.Text != "")
            {
                Recordset recordset2 = rs;
                recordset2.Open("select * from SUFIProjects", this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                if (ReadSaveFunctions.RecordCount(ref rs) > 0)
                {
                    recordset2.MoveFirst();
                    recordset2.Find("ProjectName='" + this.lstSUFIProjects.Text + "'", 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                    this.CurProjID = Conversions.ToInteger(recordset2[]["SUFIProjectID"][]);
                    this.lblBaseProejct.Text = Conversions.ToString(recordset2[]["BaseProjectName"][]);
                    this.lblBaseSimulation.Text = Conversions.ToString(recordset2[]["BaseRunName"][]);
                    this.lblProjectComment.Text = Conversions.ToString(recordset2[]["ProjectComment"][]);
                    this.m_BaseRunID = Conversions.ToInteger(recordset2[]["Baserunid"][]);
                    this.FillParameterList();
                }
                recordset2.Close();
                recordset2 = null;
            }
        }

        private void SetupTable()
        {
            Recordset rs = new RecordsetClass();
            Recordset dbParameters = this.dbParameters;
            this.OpenCurrentParameters(ref dbParameters);
            this.dbParameters = dbParameters;
            AxMSFlexGrid grdParameters = this.grdParameters;
            grdParameters.Cols = 4;
            dbParameters = this.dbParameters;
            this.dbParameters = dbParameters;
            grdParameters.Rows = ReadSaveFunctions.RecordCount(ref dbParameters) + 1;
            grdParameters.set_TextMatrix(0, 0, "Name:");
            grdParameters.set_TextMatrix(0, 1, "Min.:");
            grdParameters.set_TextMatrix(0, 2, "Max.:");
            grdParameters.set_TextMatrix(0, 3, "Strata:");
            grdParameters.Row = 0;
            this.dbParameters.MoveFirst();
            if (grdParameters.Rows > 1)
            {
                while (true)
                {
                    if (this.dbParameters.EOF)
                    {
                        break;
                    }
                    rs.Open(Operators.ConcatenateObject("select * from SUFIParameterValues where IterationID=" + Conversions.ToString(this.CurIterID) + " and ParameterID=", this.dbParameters[]["ParameterID"][]), this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    if (ReadSaveFunctions.RecordCount(ref rs) != 0)
                    {
                        int num;
                        num++;
                        grdParameters.set_TextMatrix(num, 0, Conversions.ToString(this.dbParameters[]["Name"][]));
                        grdParameters.set_TextMatrix(num, 1, Conversions.ToString(rs[]["Min"][]));
                        grdParameters.set_TextMatrix(num, 2, Conversions.ToString(rs[]["Max"][]));
                        grdParameters.set_TextMatrix(num, 3, Conversions.ToString(rs[]["NoStrata"][]));
                        this.dbParameters.MoveNext();
                        rs.Close();
                        continue;
                    }
                    return;
                }
            }
            this.dbParameters.Close();
            grdParameters = null;
        }

        private void Timer1_Tick(object eventSender, EventArgs eventArgs)
        {
            this.Timer1.Enabled = false;
            this.NextSimulation();
        }

        private void UpdateBaseSimulation(string StrataCombination)
        {
            short num9;
            short num12;
            Recordset recordset5;
            short num18;
            string databaseTable = "";
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = new RecordsetClass();
            Recordset recordset = new RecordsetClass();
            Recordset recordset3 = new RecordsetClass();
            rs.Open("select * from SUFIParameters where SUFIProjectID=" + Conversions.ToString(this.CurProjID), this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            rs.MoveFirst();
            FileSystem.FileClose(new int[0]);
            this.m_LOGFILE = (short) FileSystem.FreeFile();
            short num4 = (short) ReadSaveFunctions.RecordCount(ref rs);
            int[] strataNr = new int[num4 + 1];
            StrataCombination = Strings.Trim(StrataCombination);
            short start = 1;
            short num11 = num4;
            short index = 1;
            while (true)
            {
                num18 = num11;
                if (index > num18)
                {
                    num12 = num4;
                    index = 1;
                    break;
                }
                num9 = (short) Strings.InStr(start, StrataCombination, " ", CompareMethod.Binary);
                bool flag3 = num9 == 0;
                strataNr[index] = !flag3 ? Conversions.ToInteger(Strings.Mid(StrataCombination, start, (short) (num9 - start))) : Conversions.ToInteger(Strings.Mid(StrataCombination, start, (Strings.Len(StrataCombination) + 1) - start));
                start = (short) (num9 + 1);
                index = (short) (index + 1);
            }
            goto TR_0046;
        TR_0004:
            rs.MoveNext();
            recordset2.Close();
            bool allHorizons = false;
            index = (short) (index + 1);
            goto TR_0046;
        TR_000B:
            recordset5 = null;
            goto TR_0004;
        TR_0046:
            while (true)
            {
                num18 = num12;
                if (index > num18)
                {
                    try
                    {
                        Recordset recordset6 = recordset;
                        recordset6.Open("select * from Run_id where r_id=" + Conversions.ToString(this.m_BaseRunID), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        recordset6[]["Outputfiledir"][] = this.Dir1.Path;
                        recordset6.Update(Missing.Value, Missing.Value);
                        recordset6 = null;
                    }
                    catch (Exception exception19)
                    {
                        Exception ex = exception19;
                        ProjectData.SetProjectError(ex);
                        Exception exception10 = ex;
                        MessageBox.Show("Error when setting output directory\r\n" + exception10.Message, "Error");
                        ProjectData.ClearProjectError();
                    }
                    rs.Close();
                    return;
                }
                bool bInitCond = false;
                short hNum = 0;
                string str = Conversions.ToString(rs[]["Name"][]);
                short num6 = Conversions.ToShort(rs[]["ParameterID"][]);
                start = (short) Strings.InStr(1, str, " ", CompareMethod.Binary);
                if (start == 0)
                {
                    start = (short) Strings.Len(str);
                }
                string parameterName = this.SetParameterName(Strings.Trim(Strings.Left(str, start)));
                string str4 = parameterName;
                if (str4 != "KOC")
                {
                    if (str4 != "DEG")
                    {
                        short num2;
                        float num5;
                        short num13;
                        string[] array = Strings.Split(Conversions.ToString(rs[]["Covary"][]), " ", -1, CompareMethod.Binary);
                        try
                        {
                            recordset2.Open("select * from SUFIParameterValues where iterationid=" + Conversions.ToString(this.CurIterID) + " AND stratano=" + Conversions.ToString(strataNr[index]) + " AND ParameterID=" + Conversions.ToString((int) num6), this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            recordset2.MoveFirst();
                            num5 = Conversions.ToSingle(recordset2[]["Value"][]);
                        }
                        catch (Exception exception12)
                        {
                            Exception ex = exception12;
                            ProjectData.SetProjectError(ex);
                            Exception exception3 = ex;
                            MessageBox.Show("Error when retreiving record with parameter value\r\n" + exception3.Message, "Error");
                            ProjectData.ClearProjectError();
                        }
                        try
                        {
                            this.GetTableAndHorizonInfo(ref databaseTable, ref allHorizons, ref hNum, parameterName, ref str);
                        }
                        catch (Exception exception13)
                        {
                            Exception ex = exception13;
                            ProjectData.SetProjectError(ex);
                            Exception exception4 = ex;
                            MessageBox.Show("Error when getting table and horizon info\r\n" + exception4.Message, "Error");
                            ProjectData.ClearProjectError();
                        }
                        if (parameterName == "FREUND")
                        {
                            parameterName = "ALPHA";
                        }
                        if (databaseTable == "IB Conditions()")
                        {
                            bInitCond = true;
                        }
                        recordset5 = recordset;
                        if (!((hNum == 0) & !allHorizons))
                        {
                            num13 = (short) Information.UBound(array, 1);
                            num2 = 0;
                        }
                        else
                        {
                            try
                            {
                                this.UpdateSingleValue(ref parameterName, ref num5, ref databaseTable);
                            }
                            catch (Exception exception14)
                            {
                                Exception ex = exception14;
                                ProjectData.SetProjectError(ex);
                                Exception exception5 = ex;
                                MessageBox.Show("Error when updating single value\r\n" + exception5.Message, "Error");
                                ProjectData.ClearProjectError();
                            }
                            goto TR_000B;
                        }
                        while (true)
                        {
                            while (true)
                            {
                                num18 = num13;
                                if (num2 <= num18)
                                {
                                    int num3;
                                    int num19;
                                    int num14 = start;
                                    int num15 = num9;
                                    this.DetermineLayersToUpdate(ref num14, ref num15, array, allHorizons, bInitCond, hNum);
                                    num9 = (short) num15;
                                    start = (short) num14;
                                    recordset5.Open("select * from [" + databaseTable + "] where r_id=" + Conversions.ToString(this.m_BaseRunID), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                    int num10 = ReadSaveFunctions.RecordCount(ref recordset);
                                    if (databaseTable == "Crop")
                                    {
                                        try
                                        {
                                            int num16 = num10;
                                            num3 = 1;
                                            goto TR_001C;
                                        TR_0014:
                                            try
                                            {
                                                recordset5.MoveNext();
                                            }
                                            catch (Exception exception16)
                                            {
                                                Exception ex = exception16;
                                                ProjectData.SetProjectError(ex);
                                                Exception exception7 = ex;
                                                MessageBox.Show("Error moving to next record in Crop table:\r\n" + exception7.Message, "Error");
                                                ProjectData.ClearProjectError();
                                            }
                                            num3++;
                                        TR_001C:
                                            while (true)
                                            {
                                                num19 = num16;
                                                if (num3 > num19)
                                                {
                                                    break;
                                                }
                                                if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(recordset5[]["Year"][], hNum, false), allHorizons)))
                                                {
                                                    try
                                                    {
                                                        recordset5[][Strings.Trim(parameterName)][] = num5;
                                                        recordset5.Update(Missing.Value, Missing.Value);
                                                    }
                                                    catch (Exception exception15)
                                                    {
                                                        Exception ex = exception15;
                                                        ProjectData.SetProjectError(ex);
                                                        Exception exception6 = ex;
                                                        MessageBox.Show("Error updating crop parameters (inner loop)\r\n" + exception6.Message, "Error");
                                                        ProjectData.ClearProjectError();
                                                    }
                                                }
                                                goto TR_0014;
                                            }
                                            break;
                                        }
                                        catch (Exception exception17)
                                        {
                                            Exception ex = exception17;
                                            ProjectData.SetProjectError(ex);
                                            Exception exception8 = ex;
                                            MessageBox.Show("Error when updating crop parameters\r\n" + exception8.Message, "Error when updating crop parameters");
                                            ProjectData.ClearProjectError();
                                        }
                                    }
                                    else
                                    {
                                        try
                                        {
                                            int num17 = num10;
                                            num3 = 1;
                                            while (true)
                                            {
                                                num19 = num17;
                                                if (num3 > num19)
                                                {
                                                    if ((num2 + 1) == hNum)
                                                    {
                                                        hNum = -1;
                                                    }
                                                    break;
                                                }
                                                if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(recordset5[]["Layer_no"][], start, false), Operators.CompareObjectLessEqual(recordset5[]["Layer_no"][], num9, false))))
                                                {
                                                    recordset5[][Strings.Trim(parameterName)][] = num5;
                                                    recordset5.Update(Missing.Value, Missing.Value);
                                                }
                                                recordset5.MoveNext();
                                                num3++;
                                            }
                                        }
                                        catch (Exception exception18)
                                        {
                                            Exception ex = exception18;
                                            ProjectData.SetProjectError(ex);
                                            Exception exception9 = ex;
                                            MessageBox.Show("Error when updating layered parameter\r\n" + exception9.Message, "Error");
                                            ProjectData.ClearProjectError();
                                        }
                                    }
                                }
                                else
                                {
                                    goto TR_000B;
                                }
                                break;
                            }
                            recordset5.Close();
                            num2 = (short) (num2 + 1);
                        }
                    }
                    else
                    {
                        try
                        {
                            this.UpdateDegradationParameters(ref str, ref "DEGMIL", ref strataNr, ref index);
                        }
                        catch (Exception exception11)
                        {
                            Exception ex = exception11;
                            ProjectData.SetProjectError(ex);
                            Exception exception2 = ex;
                            MessageBox.Show("Error when updating degradation parameters\r\n" + exception2.Message, "Error");
                            ProjectData.ClearProjectError();
                        }
                    }
                }
                else
                {
                    try
                    {
                        this.UpdateZKD(ref strataNr[index]);
                    }
                    catch (Exception exception1)
                    {
                        Exception ex = exception1;
                        ProjectData.SetProjectError(ex);
                        Exception exception = ex;
                        MessageBox.Show("Error when updating ZKD\r\n" + exception.Message, "Error");
                        ProjectData.ClearProjectError();
                    }
                }
                break;
            }
            goto TR_0004;
        }

        private void UpdateDatabase()
        {
            Recordset recordset = new RecordsetClass();
            CfrmSUFIMain frmSUFIMain = this.frmMain.frmSUFIMain;
            Information.Err().Clear();
            int currentStrataComboNo = frmSUFIMain.CurrentStrataComboNo;
            currentStrataComboNo = frmSUFIMain.CurrentStrataComboNo;
            if (Strings.Len(Information.Err().Description) == 0)
            {
                recordset.Open("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentIterationID) + " AND StrataComboNo=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentStrataComboNo), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset[]["Executed"][] = -1;
                recordset.Update(Missing.Value, Missing.Value);
                recordset.Close();
            }
            frmSUFIMain.NextSimulation();
            frmSUFIMain = null;
        }

        private void UpdateDegradationParameters(ref string ParNameAll, ref string ParName, ref int[] StrataNr, ref short ParNo)
        {
            // Invalid method body.
        }

        private void UpdateProjectList()
        {
            Recordset recordset = new RecordsetClass();
            this.lstSUFIProjects.Items.Clear();
            recordset.Open("select * from SUFIProjects", this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                if (!(!recordset.EOF & !recordset.BOF))
                {
                    recordset.Close();
                    return;
                }
                this.lstSUFIProjects.Items.Add(recordset[]["ProjectName"][]);
                recordset.MoveNext();
            }
        }

        private void UpdateSingleValue(ref string ParName, ref float value, ref string table)
        {
            Recordset recordset = new RecordsetClass();
            try
            {
                recordset.Open("select * from [" + table + "] where R_ID=" + Conversions.ToString(this.m_BaseRunID), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset[][ParName][] = (float) value;
                recordset.Update(Missing.Value, Missing.Value);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                MiscFUncs.MsgBox_Renamed("An error occured in function 'UpdateSingleValue':\r" + exception.Message, 0x30, "Error");
                ProjectData.ClearProjectError();
            }
        }

        private void UpdateZKD(ref int StrataNr)
        {
            // Invalid method body.
        }

        public virtual Timer Timer2
        {
            [DebuggerNonUserCode]
            get => 
                this._Timer2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Timer2 = value;
        }

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

        public virtual Button cmdChangeSUFIDatabase
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdChangeSUFIDatabase;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdChangeSUFIDatabase_Click);
                if (!ReferenceEquals(this._cmdChangeSUFIDatabase, null))
                {
                    this._cmdChangeSUFIDatabase.Click -= handler;
                }
                this._cmdChangeSUFIDatabase = value;
                if (!ReferenceEquals(this._cmdChangeSUFIDatabase, null))
                {
                    this._cmdChangeSUFIDatabase.Click += handler;
                }
            }
        }

        public virtual Button cmdComplete
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdComplete;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmdComplete = value;
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

        public virtual DirListBox Dir1
        {
            [DebuggerNonUserCode]
            get => 
                this._Dir1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Dir1_Change);
                if (!ReferenceEquals(this._Dir1, null))
                {
                    this._Dir1.Change -= handler;
                }
                this._Dir1 = value;
                if (!ReferenceEquals(this._Dir1, null))
                {
                    this._Dir1.Change += handler;
                }
            }
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

        public virtual Label Label11
        {
            [DebuggerNonUserCode]
            get => 
                this._Label11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label11 = value;
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

        public virtual Label lblTotNoSimsCurrentIteration
        {
            [DebuggerNonUserCode]
            get => 
                this._lblTotNoSimsCurrentIteration;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblTotNoSimsCurrentIteration = value;
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

        public virtual Label lblNoExecutedSims
        {
            [DebuggerNonUserCode]
            get => 
                this._lblNoExecutedSims;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblNoExecutedSims = value;
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

        public virtual Label Label6
        {
            [DebuggerNonUserCode]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label6 = value;
        }

        public virtual Panel Frame4
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame4 = value;
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

        public virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
        }

        public virtual Label lblProjectComment
        {
            [DebuggerNonUserCode]
            get => 
                this._lblProjectComment;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblProjectComment = value;
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

        public virtual Label lblBaseProejct
        {
            [DebuggerNonUserCode]
            get => 
                this._lblBaseProejct;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblBaseProejct = value;
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

        public virtual GroupBox Frame2
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame2 = value;
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

        public virtual Label lblSUFIDatabaseName
        {
            [DebuggerNonUserCode]
            get => 
                this._lblSUFIDatabaseName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblSUFIDatabaseName = value;
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

        public virtual GroupBox fraMain
        {
            [DebuggerNonUserCode]
            get => 
                this._fraMain;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraMain = value;
        }

        public virtual ToolStripMenuItem mnuProjectsNew
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuProjectsNew;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuProjectsNew_Click);
                if (!ReferenceEquals(this._mnuProjectsNew, null))
                {
                    this._mnuProjectsNew.Click -= handler;
                }
                this._mnuProjectsNew = value;
                if (!ReferenceEquals(this._mnuProjectsNew, null))
                {
                    this._mnuProjectsNew.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuProjectsDelete
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuProjectsDelete;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuProjectsDelete_Click);
                if (!ReferenceEquals(this._mnuProjectsDelete, null))
                {
                    this._mnuProjectsDelete.Click -= handler;
                }
                this._mnuProjectsDelete = value;
                if (!ReferenceEquals(this._mnuProjectsDelete, null))
                {
                    this._mnuProjectsDelete.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator line2
        {
            [DebuggerNonUserCode]
            get => 
                this._line2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._line2 = value;
        }

        public virtual ToolStripMenuItem mnuProjectsExit
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuProjectsExit;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuProjectsExit_Click);
                if (!ReferenceEquals(this._mnuProjectsExit, null))
                {
                    this._mnuProjectsExit.Click -= handler;
                }
                this._mnuProjectsExit = value;
                if (!ReferenceEquals(this._mnuProjectsExit, null))
                {
                    this._mnuProjectsExit.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuProjects
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuProjects;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuProjects = value;
        }

        public virtual ToolStripMenuItem mnuIterationNew
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuIterationNew;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuIterationNew_Click);
                if (!ReferenceEquals(this._mnuIterationNew, null))
                {
                    this._mnuIterationNew.Click -= handler;
                }
                this._mnuIterationNew = value;
                if (!ReferenceEquals(this._mnuIterationNew, null))
                {
                    this._mnuIterationNew.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuAnalyseIteration
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuAnalyseIteration;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuAnalyseIteration_Click);
                if (!ReferenceEquals(this._mnuAnalyseIteration, null))
                {
                    this._mnuAnalyseIteration.Click -= handler;
                }
                this._mnuAnalyseIteration = value;
                if (!ReferenceEquals(this._mnuAnalyseIteration, null))
                {
                    this._mnuAnalyseIteration.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuIterationEdit
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuIterationEdit;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuIterationEdit_Click);
                if (!ReferenceEquals(this._mnuIterationEdit, null))
                {
                    this._mnuIterationEdit.Click -= handler;
                }
                this._mnuIterationEdit = value;
                if (!ReferenceEquals(this._mnuIterationEdit, null))
                {
                    this._mnuIterationEdit.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuIterationDeleteCurrent
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuIterationDeleteCurrent;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuIterationDeleteCurrent_Click);
                if (!ReferenceEquals(this._mnuIterationDeleteCurrent, null))
                {
                    this._mnuIterationDeleteCurrent.Click -= handler;
                }
                this._mnuIterationDeleteCurrent = value;
                if (!ReferenceEquals(this._mnuIterationDeleteCurrent, null))
                {
                    this._mnuIterationDeleteCurrent.Click += handler;
                }
            }
        }

        public virtual ToolStripSeparator sdfsdf
        {
            [DebuggerNonUserCode]
            get => 
                this._sdfsdf;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._sdfsdf = value;
        }

        public virtual ToolStripMenuItem mnuIterationExecute
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuIterationExecute;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuIterationExecute_Click);
                if (!ReferenceEquals(this._mnuIterationExecute, null))
                {
                    this._mnuIterationExecute.Click -= handler;
                }
                this._mnuIterationExecute = value;
                if (!ReferenceEquals(this._mnuIterationExecute, null))
                {
                    this._mnuIterationExecute.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuIterationAutoExecute
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuIterationAutoExecute;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuIterationAutoExecute = value;
        }

        public virtual ToolStripMenuItem mnuIteration
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuIteration;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuIteration = value;
        }

        public virtual ToolStripMenuItem mnuToolsWeighOutputs
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsWeighOutputs;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.mnuToolsWeighOutputs_Click);
                if (!ReferenceEquals(this._mnuToolsWeighOutputs, null))
                {
                    this._mnuToolsWeighOutputs.Click -= handler;
                }
                this._mnuToolsWeighOutputs = value;
                if (!ReferenceEquals(this._mnuToolsWeighOutputs, null))
                {
                    this._mnuToolsWeighOutputs.Click += handler;
                }
            }
        }

        public virtual ToolStripMenuItem mnuToolsClearCheckedOut
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsClearCheckedOut;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuToolsClearCheckedOut = value;
        }

        public virtual ToolStripMenuItem mnuToolsModifyMeasured
        {
            [DebuggerNonUserCode]
            get => 
                this._mnuToolsModifyMeasured;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._mnuToolsModifyMeasured = value;
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

        public virtual MenuStrip MainMenu1
        {
            [DebuggerNonUserCode]
            get => 
                this._MainMenu1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._MainMenu1 = value;
        }

        internal virtual ListBox lstSUFIProjects
        {
            [DebuggerNonUserCode]
            get => 
                this._lstSUFIProjects;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lstSUFIProjects_SelectedIndexChanged);
                if (!ReferenceEquals(this._lstSUFIProjects, null))
                {
                    this._lstSUFIProjects.SelectedIndexChanged -= handler;
                }
                this._lstSUFIProjects = value;
                if (!ReferenceEquals(this._lstSUFIProjects, null))
                {
                    this._lstSUFIProjects.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ListBox lstParameters
        {
            [DebuggerNonUserCode]
            get => 
                this._lstParameters;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstParameters = value;
        }

        public int CurrentIterationID =>
            this.CurIterID;

        public int CurrentStrataComboNo =>
            this.m_CurStrataComboNo;

        public Recordset dbParameterInfo
        {
            get => 
                this.m_dbParameterInfo;
            set => 
                this.m_dbParameterInfo = value;
        }

        public Recordset dbParameterValues
        {
            get => 
                this.m_dbParameterValues;
            set => 
                this.m_dbParameterValues = value;
        }

        public int CurrentProjID
        {
            get => 
                this.CurProjID;
            set => 
                this.CurProjID = value;
        }

        public Connection SUFIDatabaseConnection
        {
            get => 
                this.m_SUFIDatabaseConnection;
            set => 
                this.m_SUFIDatabaseConnection = value;
        }

        public Recordset dbParameters
        {
            get => 
                this.m_dbParameters;
            set => 
                this.m_dbParameters = value;
        }

        public CfrmMain MainForm =>
            this.frmMain;

        public CfrmNewSUFIProject NewSUFIProjectForm =>
            this.frmNewSUFIProject;

        public int SUFIProjID =>
            this.CurProjID;

        public int ProjID =>
            this.CurProjID;

        public bool SUFIAutoExec
        {
            get => 
                Conversions.ToBoolean(this.m_bSUFIAutoExec);
            set => 
                this.m_bSUFIAutoExec = value;
        }
    }
}

