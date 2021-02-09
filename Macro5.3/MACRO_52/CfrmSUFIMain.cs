// Decompiled with JetBrains decompiler
// Type: MACRO_52.CfrmSUFIMain
// Assembly: MACRO 5.2, Version=5.1.3985.19397, Culture=neutral, PublicKeyToken=null
// MVID: 47809847-C610-425C-9DB2-DB9591AF0B7D
// Assembly location: C:\Users\alusov\Desktop\MACRO52\MACRO 5.2.exe

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
using System.Windows.Forms;

namespace MACRO_52
{
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
        [SpecialName]
        private bool fTerminateCalled;

    [DebuggerNonUserCode]
        static CfrmSUFIMain()
        {
        }

        [DebuggerNonUserCode]
        public CfrmSUFIMain()
        {
            this.Activated += new EventHandler(this.frmSUFIMain_Activated);
            this.Load += new EventHandler(this.frmSUFIMain_Load);
            this.FormClosed += new FormClosedEventHandler(this.frmSUFIMain_FormClosed);
            lock (CfrmSUFIMain.__ENCList)
                CfrmSUFIMain.__ENCList.Add(new WeakReference((object)this));
            this.dbSUFIProjects = (Recordset)new RecordsetClass();
            this.m_dbParameters = (Recordset)new RecordsetClass();
            this.m_dbParameterValues = (Recordset)new RecordsetClass();
            this.m_dbParameterInfo = (Recordset)new RecordsetClass();
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (!this.fTerminateCalled)
        {
                    this.Form_Terminate_Renamed();
                    this.fTerminateCalled = true;
                }
                if (this.components != null)
                    this.components.Dispose();
            }
            base.Dispose(Disposing);
        }

        public virtual Timer Timer2
        {
            [DebuggerNonUserCode]
            get => this._Timer2;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Timer2 = value;
        }

        public virtual Timer Timer1
        {
            [DebuggerNonUserCode]
            get => this._Timer1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
                if (this._Timer1 != null)
                    this._Timer1.Tick -= eventHandler;
                this._Timer1 = value;
                if (this._Timer1 == null)
                    return;
                this._Timer1.Tick += eventHandler;
            }
        }

        public virtual Button cmdChangeSUFIDatabase
        {
            [DebuggerNonUserCode]
            get => this._cmdChangeSUFIDatabase;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.cmdChangeSUFIDatabase_Click);
                if (this._cmdChangeSUFIDatabase != null)
                    this._cmdChangeSUFIDatabase.Click -= eventHandler;
                this._cmdChangeSUFIDatabase = value;
                if (this._cmdChangeSUFIDatabase == null)
                    return;
                this._cmdChangeSUFIDatabase.Click += eventHandler;
            }
        }

        public virtual Button cmdComplete
        {
            [DebuggerNonUserCode]
            get => this._cmdComplete;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._cmdComplete = value;
        }

        public virtual AxMSFlexGrid grdParameters
        {
            [DebuggerNonUserCode]
            get => this._grdParameters;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._grdParameters = value;
        }

        public virtual DirListBox Dir1
        {
            [DebuggerNonUserCode]
            get => this._Dir1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Dir1_Change);
                if (this._Dir1 != null)
                    this._Dir1.Change -= eventHandler;
                this._Dir1 = value;
                if (this._Dir1 == null)
                    return;
                this._Dir1.Change += eventHandler;
            }
        }

        public virtual DriveListBox Drive1
        {
            [DebuggerNonUserCode]
            get => this._Drive1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Drive1_SelectedIndexChanged);
                if (this._Drive1 != null)
                    this._Drive1.SelectedIndexChanged -= eventHandler;
                this._Drive1 = value;
                if (this._Drive1 == null)
                    return;
                this._Drive1.SelectedIndexChanged += eventHandler;
            }
        }

        public virtual Label Label11
        {
            [DebuggerNonUserCode]
            get => this._Label11;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label11 = value;
        }

        public virtual Label Label8
        {
            [DebuggerNonUserCode]
            get => this._Label8;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label8 = value;
        }

        public virtual Label lblTotNoSimsCurrentIteration
        {
            [DebuggerNonUserCode]
            get => this._lblTotNoSimsCurrentIteration;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblTotNoSimsCurrentIteration = value;
        }

        public virtual Label Label7
        {
            [DebuggerNonUserCode]
            get => this._Label7;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label7 = value;
        }

        public virtual Label lblNoExecutedSims
        {
            [DebuggerNonUserCode]
            get => this._lblNoExecutedSims;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblNoExecutedSims = value;
        }

        public virtual Label lblIterationNumber
        {
            [DebuggerNonUserCode]
            get => this._lblIterationNumber;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblIterationNumber = value;
        }

        public virtual Label Label6
        {
            [DebuggerNonUserCode]
            get => this._Label6;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label6 = value;
        }

        public virtual Panel Frame4
        {
            [DebuggerNonUserCode]
            get => this._Frame4;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Frame4 = value;
        }

        public virtual GroupBox Frame3
        {
            [DebuggerNonUserCode]
            get => this._Frame3;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Frame3 = value;
        }

        public virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => this._Label5;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label5 = value;
        }

        public virtual Label lblProjectComment
        {
            [DebuggerNonUserCode]
            get => this._lblProjectComment;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblProjectComment = value;
        }

        public virtual Label lblBaseSimulation
        {
            [DebuggerNonUserCode]
            get => this._lblBaseSimulation;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblBaseSimulation = value;
        }

        public virtual Label lblBaseProejct
        {
            [DebuggerNonUserCode]
            get => this._lblBaseProejct;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblBaseProejct = value;
        }

        public virtual Label Label4
        {
            [DebuggerNonUserCode]
            get => this._Label4;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label4 = value;
        }

        public virtual Label Label3
        {
            [DebuggerNonUserCode]
            get => this._Label3;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label3 = value;
        }

        public virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => this._Label2;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label2 = value;
        }

        public virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => this._Label1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        public virtual GroupBox Frame2
        {
            [DebuggerNonUserCode]
            get => this._Frame2;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Frame2 = value;
        }

        public virtual GroupBox Frame1
        {
            [DebuggerNonUserCode]
            get => this._Frame1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Frame1 = value;
        }

        public virtual Label lblSUFIDatabaseName
        {
            [DebuggerNonUserCode]
            get => this._lblSUFIDatabaseName;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblSUFIDatabaseName = value;
        }

        public virtual Label Label9
        {
            [DebuggerNonUserCode]
            get => this._Label9;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label9 = value;
        }

        public virtual GroupBox fraMain
        {
            [DebuggerNonUserCode]
            get => this._fraMain;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._fraMain = value;
        }

        public virtual ToolStripMenuItem mnuProjectsNew
        {
            [DebuggerNonUserCode]
            get => this._mnuProjectsNew;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuProjectsNew_Click);
                if (this._mnuProjectsNew != null)
                    this._mnuProjectsNew.Click -= eventHandler;
                this._mnuProjectsNew = value;
                if (this._mnuProjectsNew == null)
                    return;
                this._mnuProjectsNew.Click += eventHandler;
            }
        }

        public virtual ToolStripMenuItem mnuProjectsDelete
        {
            [DebuggerNonUserCode]
            get => this._mnuProjectsDelete;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuProjectsDelete_Click);
                if (this._mnuProjectsDelete != null)
                    this._mnuProjectsDelete.Click -= eventHandler;
                this._mnuProjectsDelete = value;
                if (this._mnuProjectsDelete == null)
                    return;
                this._mnuProjectsDelete.Click += eventHandler;
            }
        }

        public virtual ToolStripSeparator line2
        {
            [DebuggerNonUserCode]
            get => this._line2;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._line2 = value;
        }

        public virtual ToolStripMenuItem mnuProjectsExit
        {
            [DebuggerNonUserCode]
            get => this._mnuProjectsExit;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuProjectsExit_Click);
                if (this._mnuProjectsExit != null)
                    this._mnuProjectsExit.Click -= eventHandler;
                this._mnuProjectsExit = value;
                if (this._mnuProjectsExit == null)
                    return;
                this._mnuProjectsExit.Click += eventHandler;
            }
        }

        public virtual ToolStripMenuItem mnuProjects
        {
            [DebuggerNonUserCode]
            get => this._mnuProjects;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._mnuProjects = value;
        }

        public virtual ToolStripMenuItem mnuIterationNew
        {
            [DebuggerNonUserCode]
            get => this._mnuIterationNew;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuIterationNew_Click);
                if (this._mnuIterationNew != null)
                    this._mnuIterationNew.Click -= eventHandler;
                this._mnuIterationNew = value;
                if (this._mnuIterationNew == null)
                    return;
                this._mnuIterationNew.Click += eventHandler;
            }
        }

        public virtual ToolStripMenuItem mnuAnalyseIteration
        {
            [DebuggerNonUserCode]
            get => this._mnuAnalyseIteration;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuAnalyseIteration_Click);
                if (this._mnuAnalyseIteration != null)
                    this._mnuAnalyseIteration.Click -= eventHandler;
                this._mnuAnalyseIteration = value;
                if (this._mnuAnalyseIteration == null)
                    return;
                this._mnuAnalyseIteration.Click += eventHandler;
            }
        }

        public virtual ToolStripMenuItem mnuIterationEdit
        {
            [DebuggerNonUserCode]
            get => this._mnuIterationEdit;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuIterationEdit_Click);
                if (this._mnuIterationEdit != null)
                    this._mnuIterationEdit.Click -= eventHandler;
                this._mnuIterationEdit = value;
                if (this._mnuIterationEdit == null)
                    return;
                this._mnuIterationEdit.Click += eventHandler;
            }
        }

        public virtual ToolStripMenuItem mnuIterationDeleteCurrent
        {
            [DebuggerNonUserCode]
            get => this._mnuIterationDeleteCurrent;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuIterationDeleteCurrent_Click);
                if (this._mnuIterationDeleteCurrent != null)
                    this._mnuIterationDeleteCurrent.Click -= eventHandler;
                this._mnuIterationDeleteCurrent = value;
                if (this._mnuIterationDeleteCurrent == null)
                    return;
                this._mnuIterationDeleteCurrent.Click += eventHandler;
            }
        }

        public virtual ToolStripSeparator sdfsdf
        {
            [DebuggerNonUserCode]
            get => this._sdfsdf;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._sdfsdf = value;
        }

        public virtual ToolStripMenuItem mnuIterationExecute
        {
            [DebuggerNonUserCode]
            get => this._mnuIterationExecute;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuIterationExecute_Click);
                if (this._mnuIterationExecute != null)
                    this._mnuIterationExecute.Click -= eventHandler;
                this._mnuIterationExecute = value;
                if (this._mnuIterationExecute == null)
                    return;
                this._mnuIterationExecute.Click += eventHandler;
            }
        }

        public virtual ToolStripMenuItem mnuIterationAutoExecute
        {
            [DebuggerNonUserCode]
            get => this._mnuIterationAutoExecute;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._mnuIterationAutoExecute = value;
        }

        public virtual ToolStripMenuItem mnuIteration
        {
            [DebuggerNonUserCode]
            get => this._mnuIteration;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._mnuIteration = value;
        }

        public virtual ToolStripMenuItem mnuToolsWeighOutputs
        {
            [DebuggerNonUserCode]
            get => this._mnuToolsWeighOutputs;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.mnuToolsWeighOutputs_Click);
                if (this._mnuToolsWeighOutputs != null)
                    this._mnuToolsWeighOutputs.Click -= eventHandler;
                this._mnuToolsWeighOutputs = value;
                if (this._mnuToolsWeighOutputs == null)
                    return;
                this._mnuToolsWeighOutputs.Click += eventHandler;
            }
        }

        public virtual ToolStripMenuItem mnuToolsClearCheckedOut
        {
            [DebuggerNonUserCode]
            get => this._mnuToolsClearCheckedOut;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._mnuToolsClearCheckedOut = value;
        }

        public virtual ToolStripMenuItem mnuToolsModifyMeasured
        {
            [DebuggerNonUserCode]
            get => this._mnuToolsModifyMeasured;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._mnuToolsModifyMeasured = value;
        }

        public virtual ToolStripMenuItem mnuTools
        {
            [DebuggerNonUserCode]
            get => this._mnuTools;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._mnuTools = value;
        }

        public virtual MenuStrip MainMenu1
        {
            [DebuggerNonUserCode]
            get => this._MainMenu1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._MainMenu1 = value;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = (IContainer)new System.ComponentModel.Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CfrmSUFIMain));
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
            this.Timer2.Interval = 3000;
            this.Timer1.Interval = 3000;
            this.fraMain.BackColor = SystemColors.Control;
            this.fraMain.Controls.Add((Control)this.cmdChangeSUFIDatabase);
            this.fraMain.Controls.Add((Control)this.Frame3);
            this.fraMain.Controls.Add((Control)this.Frame2);
            this.fraMain.Controls.Add((Control)this.Frame1);
            this.fraMain.Controls.Add((Control)this.lblSUFIDatabaseName);
            this.fraMain.Controls.Add((Control)this.Label9);
            this.fraMain.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.fraMain.ForeColor = SystemColors.ControlText;
            GroupBox fraMain1 = this.fraMain;
            Point point1 = new Point(5, 27);
            Point point2 = point1;
            fraMain1.Location = point2;
            this.fraMain.Name = "fraMain";
            this.fraMain.RightToLeft = RightToLeft.No;
            GroupBox fraMain2 = this.fraMain;
            Size size1 = new Size(606, 524);
            Size size2 = size1;
            fraMain2.Size = size2;
            this.fraMain.TabIndex = 0;
            this.fraMain.TabStop = false;
            this.cmdChangeSUFIDatabase.BackColor = SystemColors.Control;
            this.cmdChangeSUFIDatabase.Cursor = Cursors.Default;
            this.cmdChangeSUFIDatabase.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.cmdChangeSUFIDatabase.ForeColor = SystemColors.ControlText;
            Button changeSufiDatabase1 = this.cmdChangeSUFIDatabase;
            point1 = new Point(479, 496);
            Point point3 = point1;
            changeSufiDatabase1.Location = point3;
            this.cmdChangeSUFIDatabase.Name = "cmdChangeSUFIDatabase";
            this.cmdChangeSUFIDatabase.RightToLeft = RightToLeft.No;
            Button changeSufiDatabase2 = this.cmdChangeSUFIDatabase;
            size1 = new Size(25, 17);
            Size size3 = size1;
            changeSufiDatabase2.Size = size3;
            this.cmdChangeSUFIDatabase.TabIndex = 27;
            this.cmdChangeSUFIDatabase.Text = "...";
            this.cmdChangeSUFIDatabase.UseVisualStyleBackColor = false;
            this.Frame3.BackColor = SystemColors.Control;
            this.Frame3.Controls.Add((Control)this.Frame4);
            this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Frame3.ForeColor = SystemColors.ControlText;
            GroupBox frame3_1 = this.Frame3;
            point1 = new Point(8, 272);
            Point point4 = point1;
            frame3_1.Location = point4;
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = RightToLeft.No;
            GroupBox frame3_2 = this.Frame3;
            size1 = new Size(592, 217);
            Size size4 = size1;
            frame3_2.Size = size4;
            this.Frame3.TabIndex = 10;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Current iteration";
            this.Frame4.BackColor = SystemColors.Control;
            this.Frame4.Controls.Add((Control)this.cmdComplete);
            this.Frame4.Controls.Add((Control)this.grdParameters);
            this.Frame4.Controls.Add((Control)this.Dir1);
            this.Frame4.Controls.Add((Control)this.Drive1);
            this.Frame4.Controls.Add((Control)this.Label11);
            this.Frame4.Controls.Add((Control)this.Label8);
            this.Frame4.Controls.Add((Control)this.lblTotNoSimsCurrentIteration);
            this.Frame4.Controls.Add((Control)this.Label7);
            this.Frame4.Controls.Add((Control)this.lblNoExecutedSims);
            this.Frame4.Controls.Add((Control)this.lblIterationNumber);
            this.Frame4.Controls.Add((Control)this.Label6);
            this.Frame4.Cursor = Cursors.Default;
            this.Frame4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Frame4.ForeColor = SystemColors.ControlText;
            Panel frame4_1 = this.Frame4;
            point1 = new Point(8, 16);
            Point point5 = point1;
            frame4_1.Location = point5;
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = RightToLeft.No;
            Panel frame4_2 = this.Frame4;
            size1 = new Size(578, 193);
            Size size5 = size1;
            frame4_2.Size = size5;
            this.Frame4.TabIndex = 11;
            this.Frame4.Text = "Current";
            this.cmdComplete.BackColor = SystemColors.Control;
            this.cmdComplete.Cursor = Cursors.Default;
            this.cmdComplete.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.cmdComplete.ForeColor = SystemColors.ControlText;
            Button cmdComplete1 = this.cmdComplete;
            point1 = new Point(208, 8);
            Point point6 = point1;
            cmdComplete1.Location = point6;
            this.cmdComplete.Name = "cmdComplete";
            this.cmdComplete.RightToLeft = RightToLeft.No;
            Button cmdComplete2 = this.cmdComplete;
            size1 = new Size(65, 25);
            Size size6 = size1;
            cmdComplete2.Size = size6;
            this.cmdComplete.TabIndex = 28;
            this.cmdComplete.Text = "Complete";
            this.cmdComplete.UseVisualStyleBackColor = false;
            this.cmdComplete.Visible = false;
            AxMSFlexGrid grdParameters1 = this.grdParameters;
            point1 = new Point(8, 64);
            Point point7 = point1;
            grdParameters1.Location = point7;
            this.grdParameters.Name = "grdParameters";
            this.grdParameters.OcxState = (AxHost.State)componentResourceManager.GetObject("grdParameters.OcxState");
            AxMSFlexGrid grdParameters2 = this.grdParameters;
            size1 = new Size(368, 193);
            Size size7 = size1;
            grdParameters2.Size = size7;
            this.grdParameters.TabIndex = 22;
            this.Dir1.BackColor = SystemColors.Window;
            this.Dir1.Cursor = Cursors.Default;
            this.Dir1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Dir1.ForeColor = SystemColors.WindowText;
            this.Dir1.FormattingEnabled = true;
            this.Dir1.IntegralHeight = false;
            DirListBox dir1_1 = this.Dir1;
            point1 = new Point(399, 40);
            Point point8 = point1;
            dir1_1.Location = point8;
            this.Dir1.Name = "Dir1";
            DirListBox dir1_2 = this.Dir1;
            size1 = new Size(161, 141);
            Size size8 = size1;
            dir1_2.Size = size8;
            this.Dir1.TabIndex = 19;
            this.Drive1.BackColor = SystemColors.Window;
            this.Drive1.Cursor = Cursors.Default;
            this.Drive1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Drive1.ForeColor = SystemColors.WindowText;
            this.Drive1.FormattingEnabled = true;
            DriveListBox drive1_1 = this.Drive1;
            point1 = new Point(399, 16);
            Point point9 = point1;
            drive1_1.Location = point9;
            this.Drive1.Name = "Drive1";
            DriveListBox drive1_2 = this.Drive1;
            size1 = new Size(161, 21);
            Size size9 = size1;
            drive1_2.Size = size9;
            this.Drive1.TabIndex = 18;
            this.Label11.BackColor = SystemColors.Control;
            this.Label11.Cursor = Cursors.Default;
            this.Label11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label11.ForeColor = SystemColors.ControlText;
            Label label11_1 = this.Label11;
            point1 = new Point(399, 0);
            Point point10 = point1;
            label11_1.Location = point10;
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = RightToLeft.No;
            Label label11_2 = this.Label11;
            size1 = new Size(89, 17);
            Size size10 = size1;
            label11_2.Size = size10;
            this.Label11.TabIndex = 20;
            this.Label11.Text = "Output path:";
            this.Label8.BackColor = SystemColors.Control;
            this.Label8.Cursor = Cursors.Default;
            this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label8.ForeColor = SystemColors.ControlText;
            Label label8_1 = this.Label8;
            point1 = new Point(120, 40);
            Point point11 = point1;
            label8_1.Location = point11;
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = RightToLeft.No;
            Label label8_2 = this.Label8;
            size1 = new Size(145, 17);
            Size size11 = size1;
            label8_2.Size = size11;
            this.Label8.TabIndex = 17;
            this.Label8.Text = "simulations completed.";
            this.lblTotNoSimsCurrentIteration.BackColor = SystemColors.Window;
            this.lblTotNoSimsCurrentIteration.BorderStyle = BorderStyle.FixedSingle;
            this.lblTotNoSimsCurrentIteration.Cursor = Cursors.Default;
            this.lblTotNoSimsCurrentIteration.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblTotNoSimsCurrentIteration.ForeColor = SystemColors.WindowText;
            Label currentIteration1 = this.lblTotNoSimsCurrentIteration;
            point1 = new Point(80, 40);
            Point point12 = point1;
            currentIteration1.Location = point12;
            this.lblTotNoSimsCurrentIteration.Name = "lblTotNoSimsCurrentIteration";
            this.lblTotNoSimsCurrentIteration.RightToLeft = RightToLeft.No;
            Label currentIteration2 = this.lblTotNoSimsCurrentIteration;
            size1 = new Size(33, 17);
            Size size12 = size1;
            currentIteration2.Size = size12;
            this.lblTotNoSimsCurrentIteration.TabIndex = 16;
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label7.ForeColor = SystemColors.ControlText;
            Label label7_1 = this.Label7;
            point1 = new Point(48, 40);
            Point point13 = point1;
            label7_1.Location = point13;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            Label label7_2 = this.Label7;
            size1 = new Size(33, 17);
            Size size13 = size1;
            label7_2.Size = size13;
            this.Label7.TabIndex = 15;
            this.Label7.Text = "out of";
            this.lblNoExecutedSims.BackColor = SystemColors.Window;
            this.lblNoExecutedSims.BorderStyle = BorderStyle.FixedSingle;
            this.lblNoExecutedSims.Cursor = Cursors.Default;
            this.lblNoExecutedSims.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblNoExecutedSims.ForeColor = SystemColors.WindowText;
            Label lblNoExecutedSims1 = this.lblNoExecutedSims;
            point1 = new Point(8, 40);
            Point point14 = point1;
            lblNoExecutedSims1.Location = point14;
            this.lblNoExecutedSims.Name = "lblNoExecutedSims";
            this.lblNoExecutedSims.RightToLeft = RightToLeft.No;
            Label lblNoExecutedSims2 = this.lblNoExecutedSims;
            size1 = new Size(33, 17);
            Size size14 = size1;
            lblNoExecutedSims2.Size = size14;
            this.lblNoExecutedSims.TabIndex = 14;
            this.lblIterationNumber.BackColor = SystemColors.Window;
            this.lblIterationNumber.BorderStyle = BorderStyle.FixedSingle;
            this.lblIterationNumber.Cursor = Cursors.Default;
            this.lblIterationNumber.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblIterationNumber.ForeColor = SystemColors.WindowText;
            Label lblIterationNumber1 = this.lblIterationNumber;
            point1 = new Point(96, 16);
            Point point15 = point1;
            lblIterationNumber1.Location = point15;
            this.lblIterationNumber.Name = "lblIterationNumber";
            this.lblIterationNumber.RightToLeft = RightToLeft.No;
            Label lblIterationNumber2 = this.lblIterationNumber;
            size1 = new Size(33, 17);
            Size size15 = size1;
            lblIterationNumber2.Size = size15;
            this.lblIterationNumber.TabIndex = 13;
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label6.ForeColor = SystemColors.ControlText;
            Label label6_1 = this.Label6;
            point1 = new Point(8, 16);
            Point point16 = point1;
            label6_1.Location = point16;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            Label label6_2 = this.Label6;
            size1 = new Size(97, 17);
            Size size16 = size1;
            label6_2.Size = size16;
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Iteration number:";
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add((Control)this.lstParameters);
            this.Frame2.Controls.Add((Control)this.Label5);
            this.Frame2.Controls.Add((Control)this.lblProjectComment);
            this.Frame2.Controls.Add((Control)this.lblBaseSimulation);
            this.Frame2.Controls.Add((Control)this.lblBaseProejct);
            this.Frame2.Controls.Add((Control)this.Label4);
            this.Frame2.Controls.Add((Control)this.Label3);
            this.Frame2.Controls.Add((Control)this.Label2);
            this.Frame2.Controls.Add((Control)this.Label1);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            GroupBox frame2_1 = this.Frame2;
            point1 = new Point(240, 16);
            Point point17 = point1;
            frame2_1.Location = point17;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            GroupBox frame2_2 = this.Frame2;
            size1 = new Size(360, 250);
            Size size17 = size1;
            frame2_2.Size = size17;
            this.Frame2.TabIndex = 2;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Project information:";
            this.lstParameters.FormattingEnabled = true;
            this.lstParameters.ItemHeight = 14;
            ListBox lstParameters1 = this.lstParameters;
            point1 = new Point(11, 188);
            Point point18 = point1;
            lstParameters1.Location = point18;
            this.lstParameters.Name = "lstParameters";
            ListBox lstParameters2 = this.lstParameters;
            size1 = new Size(120, 60);
            Size size18 = size1;
            lstParameters2.Size = size18;
            this.lstParameters.TabIndex = 22;
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label5.ForeColor = SystemColors.ControlText;
            Label label5_1 = this.Label5;
            point1 = new Point(8, 168);
            Point point19 = point1;
            label5_1.Location = point19;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            Label label5_2 = this.Label5;
            size1 = new Size(113, 17);
            Size size19 = size1;
            label5_2.Size = size19;
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Parameters:";
            this.lblProjectComment.BackColor = SystemColors.Window;
            this.lblProjectComment.BorderStyle = BorderStyle.FixedSingle;
            this.lblProjectComment.Cursor = Cursors.Default;
            this.lblProjectComment.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblProjectComment.ForeColor = SystemColors.WindowText;
            Label lblProjectComment1 = this.lblProjectComment;
            point1 = new Point(8, 104);
            Point point20 = point1;
            lblProjectComment1.Location = point20;
            this.lblProjectComment.Name = "lblProjectComment";
            this.lblProjectComment.RightToLeft = RightToLeft.No;
            Label lblProjectComment2 = this.lblProjectComment;
            size1 = new Size(346, 57);
            Size size20 = size1;
            lblProjectComment2.Size = size20;
            this.lblProjectComment.TabIndex = 9;
            this.lblBaseSimulation.BackColor = SystemColors.Window;
            this.lblBaseSimulation.BorderStyle = BorderStyle.FixedSingle;
            this.lblBaseSimulation.Cursor = Cursors.Default;
            this.lblBaseSimulation.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblBaseSimulation.ForeColor = SystemColors.WindowText;
            Label lblBaseSimulation1 = this.lblBaseSimulation;
            point1 = new Point(88, 64);
            Point point21 = point1;
            lblBaseSimulation1.Location = point21;
            this.lblBaseSimulation.Name = "lblBaseSimulation";
            this.lblBaseSimulation.RightToLeft = RightToLeft.No;
            Label lblBaseSimulation2 = this.lblBaseSimulation;
            size1 = new Size(193, 17);
            Size size21 = size1;
            lblBaseSimulation2.Size = size21;
            this.lblBaseSimulation.TabIndex = 8;
            this.lblBaseProejct.BackColor = SystemColors.Window;
            this.lblBaseProejct.BorderStyle = BorderStyle.FixedSingle;
            this.lblBaseProejct.Cursor = Cursors.Default;
            this.lblBaseProejct.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblBaseProejct.ForeColor = SystemColors.WindowText;
            Label lblBaseProejct1 = this.lblBaseProejct;
            point1 = new Point(88, 40);
            Point point22 = point1;
            lblBaseProejct1.Location = point22;
            this.lblBaseProejct.Name = "lblBaseProejct";
            this.lblBaseProejct.RightToLeft = RightToLeft.No;
            Label lblBaseProejct2 = this.lblBaseProejct;
            size1 = new Size(193, 17);
            Size size22 = size1;
            lblBaseProejct2.Size = size22;
            this.lblBaseProejct.TabIndex = 7;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label4.ForeColor = SystemColors.ControlText;
            Label label4_1 = this.Label4;
            point1 = new Point(24, 64);
            Point point23 = point1;
            label4_1.Location = point23;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            Label label4_2 = this.Label4;
            size1 = new Size(57, 17);
            Size size23 = size1;
            label4_2.Size = size23;
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Simulation:";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label3.ForeColor = SystemColors.ControlText;
            Label label3_1 = this.Label3;
            point1 = new Point(24, 40);
            Point point24 = point1;
            label3_1.Location = point24;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            Label label3_2 = this.Label3;
            size1 = new Size(73, 17);
            Size size24 = size1;
            label3_2.Size = size24;
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Project:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label2.ForeColor = SystemColors.ControlText;
            Label label2_1 = this.Label2;
            point1 = new Point(8, 88);
            Point point25 = point1;
            label2_1.Location = point25;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            Label label2_2 = this.Label2;
            size1 = new Size(81, 17);
            Size size25 = size1;
            label2_2.Size = size25;
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Comment:";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label1.ForeColor = SystemColors.ControlText;
            Label label1_1 = this.Label1;
            point1 = new Point(8, 24);
            Point point26 = point1;
            label1_1.Location = point26;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            Label label1_2 = this.Label1;
            size1 = new Size(89, 17);
            Size size26 = size1;
            label1_2.Size = size26;
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Base simulation:";
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add((Control)this.lstSUFIProjects);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            GroupBox frame1_1 = this.Frame1;
            point1 = new Point(8, 16);
            Point point27 = point1;
            frame1_1.Location = point27;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            GroupBox frame1_2 = this.Frame1;
            size1 = new Size(217, 161);
            Size size27 = size1;
            frame1_2.Size = size27;
            this.Frame1.TabIndex = 1;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Available SUFI projects:";
            this.lstSUFIProjects.FormattingEnabled = true;
            this.lstSUFIProjects.ItemHeight = 14;
            ListBox lstSufiProjects1 = this.lstSUFIProjects;
            point1 = new Point(8, 19);
            Point point28 = point1;
            lstSufiProjects1.Location = point28;
            this.lstSUFIProjects.Name = "lstSUFIProjects";
            ListBox lstSufiProjects2 = this.lstSUFIProjects;
            size1 = new Size(203, 130);
            Size size28 = size1;
            lstSufiProjects2.Size = size28;
            this.lstSUFIProjects.TabIndex = 0;
            this.lblSUFIDatabaseName.BackColor = SystemColors.Window;
            this.lblSUFIDatabaseName.BorderStyle = BorderStyle.FixedSingle;
            this.lblSUFIDatabaseName.Cursor = Cursors.Default;
            this.lblSUFIDatabaseName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblSUFIDatabaseName.ForeColor = SystemColors.WindowText;
            Label sufiDatabaseName1 = this.lblSUFIDatabaseName;
            point1 = new Point(88, 496);
            Point point29 = point1;
            sufiDatabaseName1.Location = point29;
            this.lblSUFIDatabaseName.Name = "lblSUFIDatabaseName";
            this.lblSUFIDatabaseName.RightToLeft = RightToLeft.No;
            Label sufiDatabaseName2 = this.lblSUFIDatabaseName;
            size1 = new Size(385, 17);
            Size size29 = size1;
            sufiDatabaseName2.Size = size29;
            this.lblSUFIDatabaseName.TabIndex = 26;
            this.Label9.BackColor = SystemColors.Control;
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Label9.ForeColor = SystemColors.ControlText;
            Label label9_1 = this.Label9;
            point1 = new Point(8, 496);
            Point point30 = point1;
            label9_1.Location = point30;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            Label label9_2 = this.Label9;
            size1 = new Size(97, 17);
            Size size30 = size1;
            label9_2.Size = size30;
            this.Label9.TabIndex = 25;
            this.Label9.Text = "SUFI database:";
            this.MainMenu1.Items.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.mnuProjects,
        (ToolStripItem) this.mnuIteration,
        (ToolStripItem) this.mnuTools
            });
            MenuStrip mainMenu1_1 = this.MainMenu1;
            point1 = new Point(0, 0);
            Point point31 = point1;
            mainMenu1_1.Location = point31;
            this.MainMenu1.Name = "MainMenu1";
            MenuStrip mainMenu1_2 = this.MainMenu1;
            size1 = new Size(623, 24);
            Size size31 = size1;
            mainMenu1_2.Size = size31;
            this.MainMenu1.TabIndex = 1;
            this.mnuProjects.DropDownItems.AddRange(new ToolStripItem[4]
            {
        (ToolStripItem) this.mnuProjectsNew,
        (ToolStripItem) this.mnuProjectsDelete,
        (ToolStripItem) this.line2,
        (ToolStripItem) this.mnuProjectsExit
            });
            this.mnuProjects.Name = "mnuProjects";
            ToolStripMenuItem mnuProjects = this.mnuProjects;
            size1 = new Size(35, 20);
            Size size32 = size1;
            mnuProjects.Size = size32;
            this.mnuProjects.Text = "&File";
            this.mnuProjectsNew.Name = "mnuProjectsNew";
            ToolStripMenuItem mnuProjectsNew = this.mnuProjectsNew;
            size1 = new Size(165, 22);
            Size size33 = size1;
            mnuProjectsNew.Size = size33;
            this.mnuProjectsNew.Text = "&New project...";
            this.mnuProjectsDelete.Name = "mnuProjectsDelete";
            ToolStripMenuItem mnuProjectsDelete = this.mnuProjectsDelete;
            size1 = new Size(165, 22);
            Size size34 = size1;
            mnuProjectsDelete.Size = size34;
            this.mnuProjectsDelete.Text = "&Delete project...";
            this.line2.Name = "line2";
            ToolStripSeparator line2 = this.line2;
            size1 = new Size(162, 6);
            Size size35 = size1;
            line2.Size = size35;
            this.mnuProjectsExit.Name = "mnuProjectsExit";
            ToolStripMenuItem mnuProjectsExit = this.mnuProjectsExit;
            size1 = new Size(165, 22);
            Size size36 = size1;
            mnuProjectsExit.Size = size36;
            this.mnuProjectsExit.Text = "E&xit";
            this.mnuIteration.DropDownItems.AddRange(new ToolStripItem[7]
            {
        (ToolStripItem) this.mnuIterationNew,
        (ToolStripItem) this.mnuAnalyseIteration,
        (ToolStripItem) this.mnuIterationEdit,
        (ToolStripItem) this.mnuIterationDeleteCurrent,
        (ToolStripItem) this.sdfsdf,
        (ToolStripItem) this.mnuIterationExecute,
        (ToolStripItem) this.mnuIterationAutoExecute
            });
            this.mnuIteration.Name = "mnuIteration";
            ToolStripMenuItem mnuIteration = this.mnuIteration;
            size1 = new Size(61, 20);
            Size size37 = size1;
            mnuIteration.Size = size37;
            this.mnuIteration.Text = "&Iteration";
            this.mnuIterationNew.Enabled = false;
            this.mnuIterationNew.Name = "mnuIterationNew";
            ToolStripMenuItem mnuIterationNew = this.mnuIterationNew;
            size1 = new Size(174, 22);
            Size size38 = size1;
            mnuIterationNew.Size = size38;
            this.mnuIterationNew.Text = "&New...";
            this.mnuAnalyseIteration.Enabled = false;
            this.mnuAnalyseIteration.Name = "mnuAnalyseIteration";
            ToolStripMenuItem analyseIteration = this.mnuAnalyseIteration;
            size1 = new Size(174, 22);
            Size size39 = size1;
            analyseIteration.Size = size39;
            this.mnuAnalyseIteration.Text = "&Analyze...";
            this.mnuIterationEdit.Enabled = false;
            this.mnuIterationEdit.Name = "mnuIterationEdit";
            ToolStripMenuItem mnuIterationEdit = this.mnuIterationEdit;
            size1 = new Size(174, 22);
            Size size40 = size1;
            mnuIterationEdit.Size = size40;
            this.mnuIterationEdit.Text = "&Edit...";
            this.mnuIterationDeleteCurrent.Enabled = false;
            this.mnuIterationDeleteCurrent.Name = "mnuIterationDeleteCurrent";
            ToolStripMenuItem iterationDeleteCurrent = this.mnuIterationDeleteCurrent;
            size1 = new Size(174, 22);
            Size size41 = size1;
            iterationDeleteCurrent.Size = size41;
            this.mnuIterationDeleteCurrent.Text = "&Delete iteration";
            this.sdfsdf.Name = "sdfsdf";
            ToolStripSeparator sdfsdf = this.sdfsdf;
            size1 = new Size(171, 6);
            Size size42 = size1;
            sdfsdf.Size = size42;
            this.mnuIterationExecute.Enabled = false;
            this.mnuIterationExecute.Name = "mnuIterationExecute";
            ToolStripMenuItem iterationExecute = this.mnuIterationExecute;
            size1 = new Size(174, 22);
            Size size43 = size1;
            iterationExecute.Size = size43;
            this.mnuIterationExecute.Text = "E&xecute current...";
            this.mnuIterationAutoExecute.Enabled = false;
            this.mnuIterationAutoExecute.Name = "mnuIterationAutoExecute";
            ToolStripMenuItem iterationAutoExecute = this.mnuIterationAutoExecute;
            size1 = new Size(174, 22);
            Size size44 = size1;
            iterationAutoExecute.Size = size44;
            this.mnuIterationAutoExecute.Text = "&Auto execute";
            this.mnuIterationAutoExecute.Visible = false;
            this.mnuTools.DropDownItems.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.mnuToolsWeighOutputs,
        (ToolStripItem) this.mnuToolsClearCheckedOut,
        (ToolStripItem) this.mnuToolsModifyMeasured
            });
            this.mnuTools.Name = "mnuTools";
            ToolStripMenuItem mnuTools = this.mnuTools;
            size1 = new Size(44, 20);
            Size size45 = size1;
            mnuTools.Size = size45;
            this.mnuTools.Text = "&Tools";
            this.mnuTools.Visible = false;
            this.mnuToolsWeighOutputs.Enabled = false;
            this.mnuToolsWeighOutputs.Name = "mnuToolsWeighOutputs";
            ToolStripMenuItem toolsWeighOutputs = this.mnuToolsWeighOutputs;
            size1 = new Size(213, 22);
            Size size46 = size1;
            toolsWeighOutputs.Size = size46;
            this.mnuToolsWeighOutputs.Text = "Weight &outputs";
            this.mnuToolsClearCheckedOut.Enabled = false;
            this.mnuToolsClearCheckedOut.Name = "mnuToolsClearCheckedOut";
            ToolStripMenuItem toolsClearCheckedOut = this.mnuToolsClearCheckedOut;
            size1 = new Size(213, 22);
            Size size47 = size1;
            toolsClearCheckedOut.Size = size47;
            this.mnuToolsClearCheckedOut.Text = "Clear c&hecked out";
            this.mnuToolsClearCheckedOut.Visible = false;
            this.mnuToolsModifyMeasured.Enabled = false;
            this.mnuToolsModifyMeasured.Name = "mnuToolsModifyMeasured";
            ToolStripMenuItem toolsModifyMeasured = this.mnuToolsModifyMeasured;
            size1 = new Size(213, 22);
            Size size48 = size1;
            toolsModifyMeasured.Size = size48;
            this.mnuToolsModifyMeasured.Text = "&Modify measured values...";
            this.mnuToolsModifyMeasured.Visible = false;
            this.AutoScaleDimensions = new SizeF(6f, 14f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size1 = new Size(623, 563);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.fraMain);
            this.Controls.Add((Control)this.MainMenu1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            point1 = new Point(3, 41);
            this.Location = point1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(CfrmSUFIMain);
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

        internal virtual ListBox lstSUFIProjects
        {
            [DebuggerNonUserCode]
            get => this._lstSUFIProjects;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.lstSUFIProjects_SelectedIndexChanged);
                if (this._lstSUFIProjects != null)
                    this._lstSUFIProjects.SelectedIndexChanged -= eventHandler;
                this._lstSUFIProjects = value;
                if (this._lstSUFIProjects == null)
                    return;
                this._lstSUFIProjects.SelectedIndexChanged += eventHandler;
            }
        }

        internal virtual ListBox lstParameters
        {
            [DebuggerNonUserCode]
            get => this._lstParameters;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lstParameters = value;
        }

        public int CurrentIterationID => this.CurIterID;

        public int CurrentStrataComboNo => this.m_CurStrataComboNo;

        public Recordset dbParameterInfo
        {
            get => this.m_dbParameterInfo;
            set => this.m_dbParameterInfo = value;
        }

        public Recordset dbParameterValues
        {
            get => this.m_dbParameterValues;
            set => this.m_dbParameterValues = value;
        }

        public int CurrentProjID
        {
            get => this.CurProjID;
            set => this.CurProjID = value;
        }

        public Connection SUFIDatabaseConnection
        {
            get => this.m_SUFIDatabaseConnection;
            set => this.m_SUFIDatabaseConnection = value;
        }

        public Recordset dbParameters
        {
            get => this.m_dbParameters;
            set => this.m_dbParameters = value;
        }

        public CfrmMain MainForm => this.frmMain;

        public CfrmNewSUFIProject NewSUFIProjectForm => this.frmNewSUFIProject;

        public CfrmSUFIMain(ref CfrmMain frm)
        {
            this.Activated += new EventHandler(this.frmSUFIMain_Activated);
            this.Load += new EventHandler(this.frmSUFIMain_Load);
            this.FormClosed += new FormClosedEventHandler(this.frmSUFIMain_FormClosed);
            lock (CfrmSUFIMain.__ENCList)
                CfrmSUFIMain.__ENCList.Add(new WeakReference((object)this));
            this.dbSUFIProjects = (Recordset)new RecordsetClass();
            this.m_dbParameters = (Recordset)new RecordsetClass();
            this.m_dbParameterValues = (Recordset)new RecordsetClass();
            this.m_dbParameterInfo = (Recordset)new RecordsetClass();
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            this.frmMain = frm;
            CfrmSUFIMain frmSufiMain = this.frmMain.frmSUFIMain;
            this.frmAnalyse = new frmAnalyseSUFI(ref frmSufiMain);
            this.frmNewSUFIProject = new CfrmNewSUFIProject(ref this.frmMain);
            this.m_SUFIDatabaseConnection = (Connection)new ConnectionClass();
            ((_Connection)this.m_SUFIDatabaseConnection).Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.SUFIDatabaseName + ";Persist Security Info=False", "", "", -1);
            this.UpdateProjectList();
        }

        private void cmdChangeSUFIDatabase_Click(object eventSender, EventArgs eventArgs)
        {
            OpenFileDialog commonDialog1Open1 = this.CommonDialog1Open;
            commonDialog1Open1.FileName = "";
            commonDialog1Open1.Filter = "ACCESS databases (*.mdb)|*.mdb";
            commonDialog1Open1.Title = "Locate database";
            OpenFileDialog commonDialog1Open2 = this.CommonDialog1Open;
            string Expression = MiscFUncs.BrowseOpen(ref commonDialog1Open2);
            if (Strings.Len(Expression) == 0)
                return;
            GlobalVariables.SUFIDatabaseName = Expression;
            this.ConnectToSUFIDatabase();
            this.UpdateProjectList();
        }

        public void ConnectToSUFIDatabase()
        {
            CfrmSUFIMain cfrmSufiMain = this;
            this.lblSUFIDatabaseName.Text = GlobalVariables.SUFIDatabaseName;
            this.m_SUFIDatabaseConnection = (Connection)null;
            this.m_SUFIDatabaseConnection = (Connection)new ConnectionClass();
            ((_Connection)this.m_SUFIDatabaseConnection).Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.SUFIDatabaseName + ";Persist Security Info=False", "", "", -1);
            this.UpdateProjectList();
            cfrmSufiMain = (CfrmSUFIMain)null;
        }

        private void Dir1_Change(object eventSender, EventArgs eventArgs)
        {
            Recordset recordset1 = (Recordset)new RecordsetClass();
            if (Operators.CompareString(this.lstSUFIProjects.Text, "", false) == 0)
                return;
            Recordset recordset2 = recordset1;
            ((_Recordset)recordset2).Open((object)("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.CurIterID)), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            ((_Recordset)recordset2).Fields[(object)"OutputFilePath"].Value = (object)this.Dir1.Path;
            ((_Recordset)recordset2).Update((object)Missing.Value, (object)Missing.Value);
            ((_Recordset)recordset2).Close();
        }

        public void OpenCurrentIteration(ref Recordset rs) => ((_Recordset)rs).Open((object)("select * from SUFIIterations where IterationNo=" + Conversions.ToString(this.CurIterID) + " AND SUFIProjectID=" + Conversions.ToString(this.CurProjID)), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);

        private void Drive1_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (!this.b_Manual)
                {
                    this.Dir1.Path = this.Drive1.Drive;
                    if (num2 == 0)
                        return;
                    ProjectData.ClearProjectError();
                    return;

                }
                else
                {
                    if (num2 == 0)
                        return;

                    ProjectData.ClearProjectError();
                    return;
                }

            }
            catch (Exception ex) when (ex is Exception & (uint)num1 > 0U & num2 == 0)
            {
                ProjectData.SetProjectError(ex);

                num2 = -1;
                switch (num1)
                {
                    case 2:
                        {
                            MiscFUncs.MsgBox_Renamed(Information.Err().Description, (short)48, "Error accessing drive");

                            if (num2 == 0)
                                return;

                            ProjectData.ClearProjectError();
                            return;
                        }
                }
            }
            throw ProjectData.CreateProjectError(-2146828237);
        }

        private void frmSUFIMain_Activated(object eventSender, EventArgs eventArgs)
        {
            Recordset rs1 = (Recordset)new RecordsetClass();
            Recordset rs2 = (Recordset)new RecordsetClass();
            if (!(!this.IsInitializing & !this.m_IsAnalyzing) || this.CurIterID == 0)
                return;
            Recordset recordset = rs1;
            ((_Recordset)recordset).Open((object)("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.CurIterID)), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            ((_Recordset)rs2).Open((object)("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.CurIterID) + " AND Executed=-1"), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (ReadSaveFunctions.RecordCount(ref rs1) != 0)
            {
                ((_Recordset)recordset).Fields[(object)"NoCompletedSimulations"].Value = (object)ReadSaveFunctions.RecordCount(ref rs2);
                ((_Recordset)recordset).Update((object)Missing.Value, (object)Missing.Value);
            }
          ((_Recordset)recordset).Close();
            ((_Recordset)rs2).Close();
            this.UpdateProjectList();
            this.SetProjectInformation();
            this.ConnectToSUFIDatabase();
            this.SetIterationInformation();
        }

        private void frmSUFIMain_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
            this.ConnectToSUFIDatabase();
        }

        private void Form_Terminate_Renamed() => this.frmMain.Show();

        private void frmSUFIMain_FormClosed(object eventSender, FormClosedEventArgs eventArgs) => this.frmMain.Show();

        public void mnuAnalyseIteration_Click(object eventSender, EventArgs eventArgs)
        {
            this.Hide();
            this.m_IsAnalyzing = true;
            this.ConnectToSUFIDatabase();
            CfrmSUFIMain frm = this;
            this.frmAnalyse = new frmAnalyseSUFI(ref frm);
            int num = (int)this.frmAnalyse.ShowDialog();
            if (!Information.IsDBNull((object)this.frmAnalyse) && !this.frmAnalyse.m_bDone)
                this.Show();
            this.frmAnalyse = (frmAnalyseSUFI)null;
            this.m_IsAnalyzing = false;
        }

        public void mnuIterationDeleteCurrent_Click(object eventSender, EventArgs eventArgs)
        {
            if (Operators.ConditionalCompareObjectEqual(MiscFUncs.MsgBox_Renamed("Are you sure?", (short)36, "Delete iteration"), (object)MsgBoxResult.Yes, false))
            {
                ref int local1 = ref this.CurProjID;
                ref int local2 = ref this.CurIterID;
                bool flag = false;
                ref bool local3 = ref flag;
                this.DeleteIteration(ref local1, ref local2, ref local3);
            }
            this.CurIterID = 0;
        }

        public void mnuIterationEdit_Click(object eventSender, EventArgs eventArgs)
        {
            frmNewSUFIIteration newSufiIteration1 = new frmNewSUFIIteration(ref this.frmMain);
            frmNewSUFIIteration newSufiIteration2 = newSufiIteration1;
            newSufiIteration2.Text = "Edit iteration properties";
            newSufiIteration2.IterationID = (object)this.CurIterID;
            newSufiIteration2.ProjectID = (object)this.CurProjID;
            newSufiIteration2.lblProjectName.Text = this.lstSUFIProjects.Text;
            newSufiIteration2.lblIterationNumber.Text = this.lblIterationNumber.Text;
            newSufiIteration2.Drive1.Drive = this.Drive1.Drive;
            newSufiIteration2.Dir1.Path = this.Dir1.Path;
            newSufiIteration2.SetupTable2();
            newSufiIteration2.bEdit = (object)true;
            int num = (int)newSufiIteration2.ShowDialog();
            newSufiIteration2.bEdit = (object)false;
            newSufiIteration1.Close();
            this.SetIterationInformation();
        }

        public void mnuIterationExecute_Click(object eventSender, EventArgs eventArgs) => this.ExecuteIteration();

        public bool ExecuteIteration()
        {
            Recordset rs = (Recordset)new RecordsetClass();
            Recordset recordset = rs;
            ((_Recordset)recordset).Open((object)("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.CurIterID) + " and Executed=0"), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            short num = checked((short)ReadSaveFunctions.RecordCount(ref rs));
            ((_Recordset)recordset).Close();
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
            this.NextSimulation();
            return true;
        }

        private void UpdateDatabase()
        {
            Recordset recordset = (Recordset)new RecordsetClass();
            CfrmSUFIMain frmSufiMain = this.frmMain.frmSUFIMain;
            Information.Err().Clear();
            int currentStrataComboNo = frmSufiMain.CurrentStrataComboNo;
            currentStrataComboNo = frmSufiMain.CurrentStrataComboNo;
            if (Strings.Len(Information.Err().Description) == 0)
            {
                ((_Recordset)recordset).Open((object)("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentIterationID) + " AND StrataComboNo=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentStrataComboNo)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                ((_Recordset)recordset).Fields[(object)"Executed"].Value = (object)-1;
                ((_Recordset)recordset).Update((object)Missing.Value, (object)Missing.Value);
                ((_Recordset)recordset).Close();
            }
            frmSufiMain.NextSimulation();
        }

        public void NextSimulation()
        {
            Recordset rs = (Recordset)new RecordsetClass();
            string StrataCombination = "";
            Recordset recordset1 = (Recordset)new RecordsetClass();
            Recordset recordset2 = rs;
            ((_Recordset)recordset2).Open((object)("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.CurIterID) + " and Executed=0 and CheckedOut=0"), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (ReadSaveFunctions.RecordCount(ref rs) > 0)
            {
                try
                {
                    ((_Recordset)rs).MoveFirst();
                    ((_Recordset)recordset2).Fields[(object)"CheckedOut"].Value = (object)1;
                    StrataCombination = Conversions.ToString(((_Recordset)recordset2).Fields[(object)"Combo"].Value);
                    this.m_CurStrataComboNo = Conversions.ToInteger(((_Recordset)recordset2).Fields[(object)"StrataComboNo"].Value);
                    ((_Recordset)recordset2).Update((object)Missing.Value, (object)Missing.Value);
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    int num = (int)MessageBox.Show("Error getting strata combination:\r\n" + ex.Message, "Error");
                    ProjectData.ClearProjectError();
                }
            }
            Recordset recordset3 = rs;
            if (ReadSaveFunctions.RecordCount(ref rs) == 0)
            {
                try
                {
                    ((_Recordset)recordset1).Open((object)("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.CurIterID)), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    ((_Recordset)recordset1).Fields[(object)"nocompletedsimulations"].Value = RuntimeHelpers.GetObjectValue(((_Recordset)recordset1).Fields[(object)"nosimulations"].Value);
                    ((_Recordset)recordset1).Update((object)Missing.Value, (object)Missing.Value);
                    ((_Recordset)recordset1).Close();
                    this.lblNoExecutedSims.Text = Conversions.ToString(Conversions.ToDouble(this.lblNoExecutedSims.Text) + 1.0);
                    this.SetIterationInformation();
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    int num = (int)MessageBox.Show("Error updating iteration information: \r\n" + ex.Message, "Error");
                    ProjectData.ClearProjectError();
                }
                MiscFUncs.MsgBox_Renamed("Iteration completed", (short)64);
                this.Exefrm.Close();
                this.Show();
            }
            else
            {
                this.UpdateBaseSimulation(StrataCombination);
                this.Hide();
                GlobalVariables.IDExecute = this.m_BaseRunID;
                this.Exefrm.lblRunName.Text = "Running SUFI iteration";
                this.Exefrm.m_Exe = false;
                this.Exefrm.Show();
                this.Exefrm.frmExecuteMACRO_Activated((object)null, new EventArgs());
            }
            recordset3 = (Recordset)null;
        }

        private string SetParameterName(string name)
        {
            if (Operators.CompareString(name, "BGRAD", false) == 0)
                return "GWFLUX";
            if (Operators.CompareString(name, "N", false) == 0)
                return "ZLAMB";
            if (Operators.CompareString(name, "ALPHA", false) == 0)
                return "SCALEVG";
            if (Operators.CompareString(name, "GAMMA_TILLED", false) == 0)
                return "GAMMA_CH";
            if (Operators.CompareString(name, "XMPOR_TILLED", false) == 0)
                return "MACP_CH";
            if (Operators.CompareString(name, "ZN_TILLED", false) == 0)
                return "MACD_CH";
            if (Operators.CompareString(name, "KSM_TILLED", false) == 0)
                return "KSMTILLE";
            if (Operators.CompareString(name, "CONSOL_STATE", false) == 0)
                return "CONS_STA";
            if (Operators.CompareString(name, "INIT_ASCALE", false) == 0)
                return "I_ASCALE";
            if (Operators.CompareString(name, "SEAL_STATE", false) == 0)
                return "CRUSTSTA";
            if (Operators.CompareString(name, "GAMMA_SEAL", false) == 0)
                return "GAMMASEAL";
            if (Operators.CompareString(name, "ZN_SEAL", false) == 0)
                return "ZNSEAL";
            if (Operators.CompareString(name, "HALFAMOUNT_SEAL", false) == 0)
                return "HALFCRUS";
            if (Operators.CompareString(name, "XMPOR_SEAL", false) == 0)
                return "XMPORSEAL";
            return Operators.CompareString(name, "KSM_SEAL", false) == 0 ? "KSMSEAL" : name;
        }

        private void DetermineLayersToUpdate(
          ref int pos1,
          ref int pos2,
          string[] covary,
          bool bAllHorizons,
          bool bInitCond,
          int HNumOrCropYear)
        {
            Recordset rs = (Recordset)new RecordsetClass();
            Recordset recordset = rs;
            ((_Recordset)recordset).Open((object)("select * from Properties where R_id=" + Conversions.ToString(this.m_BaseRunID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            pos1 = 1;
            pos2 = 0;
            int index = 0;
            ((_Recordset)recordset).MoveFirst();
            int num1 = ReadSaveFunctions.RecordCount(ref rs);
            int num2 = 1;
            while (num2 <= num1)
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(((_Recordset)recordset).Fields[(object)"horiz_no"].Value, (object)HNumOrCropYear, false), (object)bAllHorizons), (object)(Conversions.ToDouble(covary[index]) == 1.0))))
                {
                    covary[index] = Conversions.ToString(0);
                    checked { ++index; }
                    if (!bInitCond)
                        checked { ++pos2; }
                    else
                        pos2 = Conversions.ToInteger(Operators.AddObject((object)pos2, ((_Recordset)recordset).Fields[(object)"Nlayer"].Value));
                    if (!bAllHorizons)
                        break;
                }
                else
                {
                    checked { ++index; }
                    if (!bInitCond)
                    {
                        checked { ++pos1; }
                        checked { ++pos2; }
                    }
                    else
                    {
                        pos1 = Conversions.ToInteger(Operators.AddObject((object)pos1, ((_Recordset)recordset).Fields[(object)"Nlayer"].Value));
                        pos2 = Conversions.ToInteger(Operators.AddObject((object)pos2, ((_Recordset)recordset).Fields[(object)"Nlayer"].Value));
                    }
                }
              ((_Recordset)recordset).MoveNext();
                checked { ++num2; }
            }
          ((_Recordset)recordset).Close();
        }

        private void UpdateBaseSimulation(string StrataCombination)
        {
            string Left1 = "";
            Recordset rs1 = (Recordset)new RecordsetClass();
            Recordset recordset1 = (Recordset)new RecordsetClass();
            Recordset rs2 = (Recordset)new RecordsetClass();
            Recordset recordset2 = (Recordset)new RecordsetClass();
            ((_Recordset)rs1).Open((object)("select * from SUFIParameters where SUFIProjectID=" + Conversions.ToString(this.CurProjID)), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            ((_Recordset)rs1).MoveFirst();
            FileSystem.FileClose();
            this.m_LOGFILE = checked((short)FileSystem.FreeFile());
            short num1 = checked((short)ReadSaveFunctions.RecordCount(ref rs1));
            int[] numArray = new int[checked((int)num1 + 1)];
            StrataCombination = Strings.Trim(StrataCombination);
            short num2 = 1;
            short num3 = num1;
            short num4 = 1;
            short num5 = 0;
            while ((int)num4 <= (int)num3)
            {
                num5 = checked((short)Strings.InStr((int)num2, StrataCombination, " "));
                numArray[(int)num4] = num5 != (short)0 ? Conversions.ToInteger(Strings.Mid(StrataCombination, (int)num2, (int)checked((short)unchecked((int)num5 - (int)num2)))) : Conversions.ToInteger(Strings.Mid(StrataCombination, (int)num2, checked(Strings.Len(StrataCombination) + 1 - (int)num2)));
                num2 = checked((short)((int)num5 + 1));
                checked { ++num4; }
            }
            short num6 = num1;
            short num7 = 1;
            while ((int)num7 <= (int)num6)
            {
                bool flag = false;
                short HNum = 0;
                string CompleteParameterName = Conversions.ToString(((_Recordset)rs1).Fields[(object)"Name"].Value);
                short num8 = Conversions.ToShort(((_Recordset)rs1).Fields[(object)"ParameterID"].Value);
                short num9 = checked((short)Strings.InStr(1, CompleteParameterName, " "));
                if (num9 == (short)0)
                    num9 = checked((short)Strings.Len(CompleteParameterName));
                string ParName = this.SetParameterName(Strings.Trim(Strings.Left(CompleteParameterName, (int)num9)));
                string Left2 = ParName;
                bool AllHorizons = false;
                if (Operators.CompareString(Left2, "KOC", false) == 0)
                {
                    try
                    {
                        this.UpdateZKD(ref numArray[(int)num7]);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num10 = (int)MessageBox.Show("Error when updating ZKD\r\n" + ex.Message, "Error");
                        ProjectData.ClearProjectError();
                    }
                }
                else if (Operators.CompareString(Left2, "DEG", false) == 0)
                {
                    try
                    {
                        ref string local1 = ref CompleteParameterName;
                        string str = "DEGMIL";
                        ref string local2 = ref str;
                        ref int[] local3 = ref numArray;
                        ref short local4 = ref num7;
                        this.UpdateDegradationParameters(ref local1, ref local2, ref local3, ref local4);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num10 = (int)MessageBox.Show("Error when updating degradation parameters\r\n" + ex.Message, "Error");
                        ProjectData.ClearProjectError();
                    }
                }
                else
                {
                    string[] strArray = Strings.Split(Conversions.ToString(((_Recordset)rs1).Fields[(object)"Covary"].Value));
                    float single = 0;
                    try
                    {
                        ((_Recordset)recordset1).Open((object)("select * from SUFIParameterValues where iterationid=" + Conversions.ToString(this.CurIterID) + " AND stratano=" + Conversions.ToString(numArray[(int)num7]) + " AND ParameterID=" + Conversions.ToString((int)num8)), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        ((_Recordset)recordset1).MoveFirst();
                        single = Conversions.ToSingle(((_Recordset)recordset1).Fields[(object)"Value"].Value);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num10 = (int)MessageBox.Show("Error when retreiving record with parameter value\r\n" + ex.Message, "Error");
                        ProjectData.ClearProjectError();
                    }
                    try
                    {
                        this.GetTableAndHorizonInfo(ref Left1, ref AllHorizons, ref HNum, ParName, ref CompleteParameterName);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        int num10 = (int)MessageBox.Show("Error when getting table and horizon info\r\n" + ex.Message, "Error");
                        ProjectData.ClearProjectError();
                    }
                    if (Operators.CompareString(ParName, "FREUND", false) == 0)
                        ParName = "ALPHA";
                    if (Operators.CompareString(Left1, "IB Conditions()", false) == 0)
                        flag = true;
                    Recordset recordset3 = rs2;
                    if (HNum == (short)0 & !AllHorizons)
                    {
                        try
                        {
                            this.UpdateSingleValue(ref ParName, ref single, ref Left1);
                        }
                        catch (Exception ex)
                        {
                            ProjectData.SetProjectError(ex);
                            int num10 = (int)MessageBox.Show("Error when updating single value\r\n" + ex.Message, "Error");
                            ProjectData.ClearProjectError();
                        }
                    }
                    else
                    {
                        short num10 = checked((short)Information.UBound((Array)strArray));
                        short num11 = 0;
                        while ((int)num11 <= (int)num10)
                        {
                            int num12 = (int)num9;
                            ref int local1 = ref num12;
                            int num13 = (int)num5;
                            ref int local2 = ref num13;
                            string[] covary = strArray;
                            int num14 = AllHorizons ? 1 : 0;
                            int num15 = flag ? 1 : 0;
                            int HNumOrCropYear = (int)HNum;
                            this.DetermineLayersToUpdate(ref local1, ref local2, covary, num14 != 0, num15 != 0, HNumOrCropYear);
                            num5 = checked((short)num13);
                            num9 = checked((short)num12);
                            ((_Recordset)recordset3).Open((object)("select * from [" + Left1 + "] where r_id=" + Conversions.ToString(this.m_BaseRunID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            int num16 = ReadSaveFunctions.RecordCount(ref rs2);
                            if (Operators.CompareString(Left1, "Crop", false) == 0)
                            {
                                try
                                {
                                    int num17 = num16;
                                    int num18 = 1;
                                    while (num18 <= num17)
                                    {
                                        if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(((_Recordset)recordset3).Fields[(object)"Year"].Value, (object)HNum, false), (object)AllHorizons)))
                                        {
                                            try
                                            {
                                                ((_Recordset)recordset3).Fields[(object)Strings.Trim(ParName)].Value = (object)single;
                                                ((_Recordset)recordset3).Update((object)Missing.Value, (object)Missing.Value);
                                            }
                                            catch (Exception ex)
                                            {
                                                ProjectData.SetProjectError(ex);
                                                int num19 = (int)MessageBox.Show("Error updating crop parameters (inner loop)\r\n" + ex.Message, "Error");
                                                ProjectData.ClearProjectError();
                                            }
                                        }
                                        try
                                        {
                                            ((_Recordset)recordset3).MoveNext();
                                        }
                                        catch (Exception ex)
                                        {
                                            ProjectData.SetProjectError(ex);
                                            int num19 = (int)MessageBox.Show("Error moving to next record in Crop table:\r\n" + ex.Message, "Error");
                                            ProjectData.ClearProjectError();
                                        }
                                        checked { ++num18; }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    ProjectData.SetProjectError(ex);
                                    int num17 = (int)MessageBox.Show("Error when updating crop parameters\r\n" + ex.Message, "Error when updating crop parameters");
                                    ProjectData.ClearProjectError();
                                }
                            }
                            else
                            {
                                try
                                {
                                    int num17 = num16;
                                    int num18 = 1;
                                    while (num18 <= num17)
                                    {
                                        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(((_Recordset)recordset3).Fields[(object)"Layer_no"].Value, (object)num9, false), Operators.CompareObjectLessEqual(((_Recordset)recordset3).Fields[(object)"Layer_no"].Value, (object)num5, false))))
                                        {
                                            ((_Recordset)recordset3).Fields[(object)Strings.Trim(ParName)].Value = (object)single;
                                            ((_Recordset)recordset3).Update((object)Missing.Value, (object)Missing.Value);
                                        }
                                      ((_Recordset)recordset3).MoveNext();
                                        checked { ++num18; }
                                    }
                                    if (checked((int)num11 + 1) == (int)HNum)
                                        HNum = (short)-1;
                                }
                                catch (Exception ex)
                                {
                                    ProjectData.SetProjectError(ex);
                                    int num17 = (int)MessageBox.Show("Error when updating layered parameter\r\n" + ex.Message, "Error");
                                    ProjectData.ClearProjectError();
                                }
                            }
                          ((_Recordset)recordset3).Close();
                            checked { ++num11; }
                        }
                    }
                }
              ((_Recordset)rs1).MoveNext();
                ((_Recordset)recordset1).Close();
                AllHorizons = false;
                checked { ++num7; }
            }
            try
            {
                Recordset recordset3 = rs2;
                ((_Recordset)recordset3).Open((object)("select * from Run_id where r_id=" + Conversions.ToString(this.m_BaseRunID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                ((_Recordset)recordset3).Fields[(object)"Outputfiledir"].Value = (object)this.Dir1.Path;
                ((_Recordset)recordset3).Update((object)Missing.Value, (object)Missing.Value);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num8 = (int)MessageBox.Show("Error when setting output directory\r\n" + ex.Message, "Error");
                ProjectData.ClearProjectError();
            }
          ((_Recordset)rs1).Close();
        }

        public void mnuIterationNew_Click(object eventSender, EventArgs eventArgs)
        {
            frmNewSUFIIteration newSufiIteration1 = new frmNewSUFIIteration(ref this.frmMain);
            Recordset rs = (Recordset)new RecordsetClass();
            frmNewSUFIIteration newSufiIteration2 = newSufiIteration1;
            newSufiIteration2.lblProjectName.Text = this.lstSUFIProjects.Text;
            ((_Recordset)rs).Open((object)("select * from SUFIIterations where SUFIProjectID=" + Conversions.ToString(this.CurProjID)), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            newSufiIteration2.lblIterationNumber.Text = Conversions.ToString(checked(ReadSaveFunctions.RecordCount(ref rs) + 1));
            ((_Recordset)rs).Close();
            ((_Recordset)rs).Open((object)("select * from Run_ID where R_ID=" + Conversions.ToString(this.m_BaseRunID)), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            try
            {
                newSufiIteration2.Drive1.Drive = Strings.Left(Conversions.ToString(((_Recordset)rs).Fields[(object)"Outputfiledir"].Value), 2);
                newSufiIteration2.Dir1.Path = Conversions.ToString(((_Recordset)rs).Fields[(object)"Outputfiledir"].Value);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                newSufiIteration2.Drive1.Drive = Strings.Left(MyProject.Application.Info.DirectoryPath, 2);
                newSufiIteration2.Dir1.Path = MyProject.Application.Info.DirectoryPath;
                ProjectData.ClearProjectError();
            }
          ((_Recordset)rs).Close();
            int num = (int)newSufiIteration2.ShowDialog();
            newSufiIteration1.Close();
            this.SetIterationInformation();
        }

        private void SetProjectInformation()
        {
            Recordset rs = (Recordset)new RecordsetClass();
            if (Operators.CompareString(this.lstSUFIProjects.Text, "", false) == 0)
                return;
            Recordset recordset = rs;
            ((_Recordset)recordset).Open((object)"select * from SUFIProjects", (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (ReadSaveFunctions.RecordCount(ref rs) > 0)
            {
                ((_Recordset)recordset).MoveFirst();
                ((_Recordset)recordset).Find("ProjectName='" + this.lstSUFIProjects.Text + "'", 0, SearchDirectionEnum.adSearchForward, (object)Missing.Value);
                this.CurProjID = Conversions.ToInteger(((_Recordset)recordset).Fields[(object)"SUFIProjectID"].Value);
                this.lblBaseProejct.Text = Conversions.ToString(((_Recordset)recordset).Fields[(object)"BaseProjectName"].Value);
                this.lblBaseSimulation.Text = Conversions.ToString(((_Recordset)recordset).Fields[(object)"BaseRunName"].Value);
                this.lblProjectComment.Text = Conversions.ToString(((_Recordset)recordset).Fields[(object)"ProjectComment"].Value);
                this.m_BaseRunID = Conversions.ToInteger(((_Recordset)recordset).Fields[(object)"Baserunid"].Value);
                this.FillParameterList();
            }
          ((_Recordset)recordset).Close();
        }

        public void OpenCurrentParameters(ref Recordset rs) => ((_Recordset)rs).Open((object)("select * from SUFIParameters where SUFIProjectID=" + Conversions.ToString(this.CurProjID)), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);

        public void FillParameterList()
        {
            this.lstParameters.Items.Clear();
            Recordset dbParameters = this.dbParameters;
            this.OpenCurrentParameters(ref dbParameters);
            this.dbParameters = dbParameters;
            while (!((_Recordset)this.m_dbParameters).EOF)
            {
                this.lstParameters.Items.Add(RuntimeHelpers.GetObjectValue(((_Recordset)this.m_dbParameters).Fields[(object)"Name"].Value));
                ((_Recordset)this.m_dbParameters).MoveNext();
            }
          ((_Recordset)this.m_dbParameters).Close();
        }

        private void SetIterationInformation()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Recordset rs = (Recordset)new RecordsetClass();
                Recordset recordset = rs;
                ((_Recordset)recordset).Open((object)("select * from SUFIIterations where SUFIProjectID=" + Conversions.ToString(this.CurProjID) + " and Complete=0"), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                this.mnuIterationExecute.Enabled = true;
                this.mnuIterationNew.Enabled = true;
                if (ReadSaveFunctions.RecordCount(ref rs) == 0)
                {
                    this.ClearIterationInformation();
                    this.mnuIterationExecute.Enabled = false;
                    this.mnuToolsWeighOutputs.Enabled = false;
                    this.mnuToolsClearCheckedOut.Enabled = false;
                    if (Strings.Len(this.lstSUFIProjects.Text) == 0)
                        this.mnuIterationNew.Enabled = false;
                    this.Drive1.Enabled = false;
                    this.Dir1.Enabled = false;
                    goto label_30;
                }
                else
                {
                    this.mnuToolsWeighOutputs.Enabled = true;
                    this.mnuToolsClearCheckedOut.Enabled = true;
                    this.mnuIterationDeleteCurrent.Enabled = true;
                    this.mnuAnalyseIteration.Enabled = true;
                    this.Drive1.Enabled = true;
                    this.Dir1.Enabled = true;
                    int num3 = 0;
                    short num4 = 0;
                    ((_Recordset)recordset).MoveFirst();
                    short num5 = checked((short)ReadSaveFunctions.RecordCount(ref rs));
                    short num6 = 1;
                    while ((int)num6 <= (int)num5)
                    {
                        if (Operators.ConditionalCompareObjectGreater(((_Recordset)recordset).Fields[(object)"IterationNO"].Value, (object)num3, false))
                        {
                            num3 = Conversions.ToInteger(((_Recordset)recordset).Fields[(object)"IterationNO"].Value);
                            num4 = num6;
                        }
                      ((_Recordset)recordset).MoveNext();
                        checked { ++num6; }
                    }
                  ((_Recordset)recordset).MoveFirst();
                    short num7 = checked((short)((int)num4 - 1));
                    short num8 = 1;
                    while ((int)num8 <= (int)num7)
                    {
                        ((_Recordset)recordset).MoveNext();
                        checked { ++num8; }
                    }
                    this.CurIterID = Conversions.ToInteger(((_Recordset)recordset).Fields[(object)"IterationID"].Value);
                    this.SetupTable();
                    this.lblIterationNumber.Text = Conversions.ToString(((_Recordset)recordset).Fields[(object)"IterationNo"].Value);
                    this.lblTotNoSimsCurrentIteration.Text = Conversions.ToString(((_Recordset)recordset).Fields[(object)"NoSimulations"].Value);
                    if (Operators.ConditionalCompareObjectGreater(((_Recordset)recordset).Fields[(object)"Nocompletedsimulations"].Value, ((_Recordset)recordset).Fields[(object)"nosimulations"].Value, false))
                    {
                        ((_Recordset)recordset).Fields[(object)"Nocompletedsimulations"].Value = RuntimeHelpers.GetObjectValue(((_Recordset)recordset).Fields[(object)"nosimulations"].Value);
                        ((_Recordset)recordset).Update((object)Missing.Value, (object)Missing.Value);
                    }
                    this.lblNoExecutedSims.Text = Conversions.ToString(((_Recordset)recordset).Fields[(object)"NoCompletedSimulations"].Value);
                    if (Operators.ConditionalCompareObjectNotEqual(((_Recordset)recordset).Fields[(object)"NoCompletedSimulations"].Value, ((_Recordset)recordset).Fields[(object)"NoSimulations"].Value, false))
                    {
                        this.mnuIterationNew.Enabled = false;
                        if (this.CurIterID < 1)
                            this.mnuAnalyseIteration.Enabled = false;
                    }
                    else
                    {
                        this.mnuIteration.Enabled = true;
                        this.mnuAnalyseIteration.Enabled = true;
                    }
                    if (Operators.ConditionalCompareObjectEqual(((_Recordset)recordset).Fields[(object)"NoCompletedSimulations"].Value, ((_Recordset)recordset).Fields[(object)"NoSimulations"].Value, false))
                    {
                        this.mnuIterationExecute.Enabled = false;
                    }
                    else
                    {
                        this.mnuIterationExecute.Enabled = true;
                        this.mnuIterationAutoExecute.Enabled = true;
                    }
                    this.mnuIterationEdit.Enabled = Operators.ConditionalCompareObjectEqual(((_Recordset)recordset).Fields[(object)"Nocompletedsimulations"].Value, (object)0, false);
                    this.Drive1.Drive = Strings.Left(Conversions.ToString(((_Recordset)recordset).Fields[(object)"OutputFilePath"].Value), 2);
                    this.b_Manual = true;
                    this.Dir1.Path = Conversions.ToString(((_Recordset)recordset).Fields[(object)"Outputfilepath"].Value);
                    this.b_Manual = false;
                    goto label_30;
                }

                num2 = -1;
                switch (num1)
                {
                    case 2:
                        if (Information.Err().Number != 76)
                        {
                            MiscFUncs.MsgBox_Renamed(Information.Err().Description + Conversions.ToString(Information.Err().Number), (short)48, "Error");
                            goto label_30;
                        }
                        else
                            goto label_30;
                }
            }
            catch (Exception ex) when (ex is Exception & (uint)num1 > 0U & num2 == 0)
            {
                ProjectData.SetProjectError(ex);

                num2 = -1;
                switch (num1)
                {
                    case 2:
                        if (Information.Err().Number != 76)
                        {
                            MiscFUncs.MsgBox_Renamed(Information.Err().Description + Conversions.ToString(Information.Err().Number), (short)48, "Error");
                            goto label_30;
                        }
                        else
                            goto label_30;
                }
            }
            throw ProjectData.CreateProjectError(-2146828237);
        label_30:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
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

        private void SetupTable()
        {
            Recordset rs = (Recordset)new RecordsetClass();
            Recordset dbParameters1 = this.dbParameters;
            this.OpenCurrentParameters(ref dbParameters1);
            this.dbParameters = dbParameters1;
            AxMSFlexGrid grdParameters = this.grdParameters;
            grdParameters.Cols = 4;
            AxMSFlexGrid axMsFlexGrid = grdParameters;
            Recordset dbParameters2 = this.dbParameters;
            int num1 = ReadSaveFunctions.RecordCount(ref dbParameters2);
            this.dbParameters = dbParameters2;
            int num2 = checked(num1 + 1);
            axMsFlexGrid.Rows = num2;
            grdParameters.set_TextMatrix(0, 0, "Name:");
            grdParameters.set_TextMatrix(0, 1, "Min.:");
            grdParameters.set_TextMatrix(0, 2, "Max.:");
            grdParameters.set_TextMatrix(0, 3, "Strata:");
            grdParameters.Row = 0;
            ((_Recordset)this.dbParameters).MoveFirst();
            if (grdParameters.Rows > 1)
            {
                while (!((_Recordset)this.dbParameters).EOF)
                {
                    ((_Recordset)rs).Open(Operators.ConcatenateObject((object)("select * from SUFIParameterValues where IterationID=" + Conversions.ToString(this.CurIterID) + " and ParameterID="), ((_Recordset)this.dbParameters).Fields[(object)"ParameterID"].Value), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    if (ReadSaveFunctions.RecordCount(ref rs) == 0)
                        return;
                    int row = 0;
                    checked { ++row; }
                    grdParameters.set_TextMatrix(row, 0, Conversions.ToString(((_Recordset)this.dbParameters).Fields[(object)"Name"].Value));
                    grdParameters.set_TextMatrix(row, 1, Conversions.ToString(((_Recordset)rs).Fields[(object)"Min"].Value));
                    grdParameters.set_TextMatrix(row, 2, Conversions.ToString(((_Recordset)rs).Fields[(object)"Max"].Value));
                    grdParameters.set_TextMatrix(row, 3, Conversions.ToString(((_Recordset)rs).Fields[(object)"NoStrata"].Value));
                    ((_Recordset)this.dbParameters).MoveNext();
                    ((_Recordset)rs).Close();
                }
            }
          ((_Recordset)this.dbParameters).Close();
        }

        public void mnuProjectsDelete_Click(object eventSender, EventArgs eventArgs)
        {
            ((_Recordset)this.dbSUFIProjects).Open((object)"select * from sufiprojects", (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (((_Recordset)this.dbSUFIProjects).EOF | ((_Recordset)this.dbSUFIProjects).BOF)
                MiscFUncs.MsgBox_Renamed("No projects defined", (short)64, "Delete");
            else if (Operators.CompareString(this.lstSUFIProjects.Text, "", false) == 0)
            {
                MiscFUncs.MsgBox_Renamed("Select a project", (short)64, "Select project");
            }
            else
            {
                if (Conversions.ToShort(MiscFUncs.MsgBox_Renamed("This will delete currently selected project: " + this.lstSUFIProjects.Text + "\rProceed?", (short)65, "Delete project")) == (short)2)
                    return;
                this.Cursor = Cursors.WaitCursor;
                Recordset dbSufiProjects = this.dbSUFIProjects;
                ((_Recordset)dbSufiProjects).MoveFirst();
                ((_Recordset)dbSufiProjects).Find("ProjectName='" + this.lstSUFIProjects.Text + "'", 0, SearchDirectionEnum.adSearchForward, (object)Missing.Value);
                this.DeleteProject();
                this.grdParameters.Clear();
                ((_Recordset)this.dbSUFIProjects).Close();
                this.Cursor = Cursors.Default;
            }
        }

        private void DeleteProject()
        {
            this.Cursor = Cursors.WaitCursor;
            Recordset recordset = (Recordset)new RecordsetClass();
            CfrmSUFIMain cfrmSufiMain = this;
            ref int local1 = ref this.CurProjID;
            ref int local2 = ref this.CurIterID;
            bool flag = true;
            ref bool local3 = ref flag;
            this.DeleteIteration(ref local1, ref local2, ref local3);
            ((_Recordset)cfrmSufiMain.dbParameters).Open((object)("select * from SUFIParameters where [SUFIProjectID]=" + Conversions.ToString(this.CurProjID)), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (!((_Recordset)cfrmSufiMain.dbParameters).EOF)
            {
                ((_Recordset)cfrmSufiMain.dbParameters).Delete(AffectEnum.adAffectCurrent);
                ((_Recordset)cfrmSufiMain.dbParameters).MoveNext();
            }
          ((_Recordset)cfrmSufiMain.dbParameters).Close();
            ((_Recordset)recordset).Open((object)("Select * from SUFIProjects where SUFIProjectID=" + Conversions.ToString(this.CurProjID)), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            ((_Recordset)recordset).Delete(AffectEnum.adAffectCurrent);
            ((_Recordset)recordset).Close();
            this.UpdateProjectList();
            this.lblBaseProejct.Text = "";
            this.lblBaseSimulation.Text = "";
            this.lblProjectComment.Text = "";
            this.Cursor = Cursors.Default;
        }

        public void mnuProjectsExit_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
            this.frmMain.Show();
        }

        public void mnuProjectsNew_Click(object eventSender, EventArgs eventArgs)
        {
            this.frmNewSUFIProject = new CfrmNewSUFIProject(ref this.frmMain);
            int num = (int)this.frmNewSUFIProject.ShowDialog();
            this.UpdateProjectList();
        }

        private void UpdateProjectList()
        {
            Recordset recordset = (Recordset)new RecordsetClass();
            this.lstSUFIProjects.Items.Clear();
            ((_Recordset)recordset).Open((object)"select * from SUFIProjects", (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (!((_Recordset)recordset).EOF & !((_Recordset)recordset).BOF)
            {
                this.lstSUFIProjects.Items.Add(RuntimeHelpers.GetObjectValue(((_Recordset)recordset).Fields[(object)"ProjectName"].Value));
                ((_Recordset)recordset).MoveNext();
            }
          ((_Recordset)recordset).Close();
        }

        public int SUFIProjID => this.CurProjID;

        public int ProjID => this.CurProjID;

        public bool SUFIAutoExec
        {
            get => Conversions.ToBoolean(this.m_bSUFIAutoExec);
            set => this.m_bSUFIAutoExec = (object)value;
        }

        public void MoveSUFIOutputFiles()
        {
            Recordset recordset = (Recordset)new RecordsetClass();
            ((_Recordset)recordset).Open((object)("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.CurIterID)), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            string str1 = Conversions.ToString(((_Recordset)recordset).Fields[(object)"OutputFilePath"].Value);
            string str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"iter_", ((_Recordset)recordset).Fields[(object)"IterationNo"].Value), (object)"_"), (object)GlobalVariables.IDExecute), (object)"_"), (object)this.m_CurStrataComboNo), (object)".bin"));
            string str3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"iter_", ((_Recordset)recordset).Fields[(object)"IterationNo"].Value), (object)"_"), (object)GlobalVariables.IDExecute), (object)"_"), (object)this.m_CurStrataComboNo), (object)".sum"));
            string str4 = "";
            if (GlobalVariables.IDExecute < 10)
                str4 = "00";
            else if (GlobalVariables.IDExecute < 100)
                str4 = "0";
            string str5 = str4 + Conversions.ToString(GlobalVariables.IDExecute);
            string fname;
            if (MiscFUncs.FileExists(str1 + "\\" + str2))
            {
                fname = str1 + "\\" + str2;
                MiscFUncs.DeleteFile(ref fname);
            }
            if (MiscFUncs.FileExists(str1 + "\\" + str3))
            {
                fname = str1 + "\\" + str3;
                MiscFUncs.DeleteFile(ref fname);
            }
            MyProject.Computer.FileSystem.CopyFile(MyProject.Application.Info.DirectoryPath + "\\macro" + str5 + ".bin", str1 + "\\" + str2, true);
        }

        public bool DeleteIteration(ref int ProjID, ref int itid, ref bool bAllIterations)
        {
            Recordset rs = (Recordset)new RecordsetClass();
            Recordset recordset = (Recordset)new RecordsetClass();
            CfrmSUFIMain cfrmSufiMain = this;
            if (!bAllIterations)
                ((_Recordset)rs).Open((object)("select * from SUFIIterations where SUFIProjectID=" + Conversions.ToString(ProjID) + " and IterationID=" + Conversions.ToString(itid)), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            else
                ((_Recordset)rs).Open((object)("select * from SUFIIterations where SUFIProjectID=" + Conversions.ToString(ProjID)), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (ReadSaveFunctions.RecordCount(ref rs) != 0)
            {
                while (!((_Recordset)rs).EOF)
                {
                    ((_Recordset)recordset).Open(Operators.ConcatenateObject((object)"select * from SUFIStrataCombinations where IterationID=", ((_Recordset)rs).Fields[(object)"IterationID"].Value), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    while (!((_Recordset)recordset).EOF)
                    {
                        ((_Recordset)recordset).Delete(AffectEnum.adAffectCurrent);
                        ((_Recordset)recordset).MoveNext();
                    }
                  ((_Recordset)recordset).Close();
                    ((_Recordset)cfrmSufiMain.dbParameterValues).Open(Operators.ConcatenateObject((object)"select * from SUFIParameterValues where IterationID=", ((_Recordset)rs).Fields[(object)"IterationID"].Value), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    while (!((_Recordset)cfrmSufiMain.dbParameterValues).EOF)
                    {
                        ((_Recordset)cfrmSufiMain.dbParameterValues).Delete(AffectEnum.adAffectCurrent);
                        ((_Recordset)cfrmSufiMain.dbParameterValues).MoveNext();
                    }
                  ((_Recordset)cfrmSufiMain.dbParameterValues).Close();
                    ((_Recordset)rs).Delete(AffectEnum.adAffectCurrent);
                    ((_Recordset)rs).MoveNext();
                }
              ((_Recordset)rs).Close();
            }
            bool flag = true;
            this.SetProjectInformation();
            this.SetIterationInformation();
            return flag;
        }

        public void mnuToolsWeighOutputs_Click(object eventSender, EventArgs eventArgs)
        {
            CfrmSUFIMain frmSufiMain = this.frmMain.frmSUFIMain;
            frmAggregateOutputs aggregateOutputs1 = new frmAggregateOutputs(ref frmSufiMain, this.CurProjID);
            Recordset rs = (Recordset)new RecordsetClass();
            frmAggregateOutputs aggregateOutputs2 = aggregateOutputs1;
            ((_Recordset)rs).Open((object)("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentIterationID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            aggregateOutputs2.lblSUFIProject.Text = this.lstSUFIProjects.Text;
            aggregateOutputs2.UpDown1.Max = ReadSaveFunctions.RecordCount(ref rs);
            aggregateOutputs2.txtIterationNo.Text = this.lblIterationNumber.Text;
            if (!aggregateOutputs2.GetProjectInfo() || !aggregateOutputs2.Update_Renamed())
                return;
            int num = (int)aggregateOutputs2.ShowDialog();
            ((_Recordset)rs).Close();
        }

        private void UpdateDegradationParameters(
          ref string ParNameAll,
          ref string ParName,
          ref int[] StrataNr,
          ref short ParNo)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str = "";
                Recordset recordset1 = (Recordset)new RecordsetClass();
                ProjectData.ClearProjectError();
                num1 = 2;
                Recordset recordset2 = (Recordset)new RecordsetClass();
                ((_Recordset)recordset1).Open((object)("select * from SUFIParameterValues where iterationid=" + Conversions.ToString(this.CurIterID) + " AND stratano=" + Conversions.ToString(StrataNr[(int)ParNo])), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                ((_Recordset)recordset1).MoveFirst();
                float single = Conversions.ToSingle(((_Recordset)recordset1).Fields[(object)"Value"].Value);
                short num3 = 1;
                do
                {
                    string[] strArray = Strings.Split(Conversions.ToString(((_Recordset)this.dbParameters).Fields[(object)"Covary"].Value));
                    bool AllHorizons = false;
                    short HNum = 0;
                    this.GetTableAndHorizonInfo(ref str, ref AllHorizons, ref HNum, ParName, ref ParNameAll);
                    Recordset recordset3 = recordset2;
                    if (HNum == (short)0 & !AllHorizons)
                    {
                        this.UpdateSingleValue(ref ParName, ref single, ref str);
                    }
                    else
                    {
                        short num4 = checked((short)Information.UBound((Array)strArray));
                        short num5 = 0;
                        while ((int)num5 <= (int)num4)
                        {
                            short baseRunId = checked((short)this.m_BaseRunID);
                            ((_Recordset)recordset3).Open((object)("select * from Properties where R_id=" + Conversions.ToString((int)baseRunId)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            short num6 = 1;
                            short num7 = 0;
                            ((_Recordset)recordset3).MoveFirst();
                            while (!((_Recordset)recordset3).EOF)
                            {
                                if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(((_Recordset)recordset3).Fields[(object)"horiz_no"].Value, (object)HNum, false), (object)AllHorizons), (object)(Conversions.ToDouble(strArray[(int)num7]) == 1.0))))
                                {
                                    strArray[(int)num7] = Conversions.ToString(0);
                                    checked { ++num7; }
                                    if (!AllHorizons)
                                        break;
                                }
                                else
                                {
                                    checked { ++num6; }
                                    checked { ++num7; }
                                }
                              ((_Recordset)recordset3).MoveNext();
                            }
                          ((_Recordset)recordset3).Close();
                            ((_Recordset)recordset3).Open((object)("select * from [" + str + "] where r_id=" + Conversions.ToString(this.m_BaseRunID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            while (!((_Recordset)recordset3).EOF)
                            {
                                if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(((_Recordset)recordset3).Fields[(object)"Layer_no"].Value, (object)num6, false), Operators.CompareObjectLessEqual(((_Recordset)recordset3).Fields[(object)"Layer_no"].Value, (object)num7, false))))
                                {
                                    ((_Recordset)recordset3).Fields[(object)Strings.Trim(ParName)].Value = (object)single;
                                    ((_Recordset)recordset3).Update((object)Missing.Value, (object)Missing.Value);
                                }
                              ((_Recordset)recordset3).MoveNext();
                            }
                            if (checked((int)num5 + 1) == (int)HNum)
                                HNum = (short)-1;
                            checked { ++num5; }
                        }
                    }
                    switch (num3)
                    {
                        case 1:
                            ParName = "DEGMAL";
                            break;
                        case 2:
                            ParName = "DEGMAS";
                            break;
                        default:
                            ParName = "DEGMIS";
                            break;
                    }
                    checked { ++num3; }
                }
                while (num3 <= (short)4);
                goto label_31;

                num2 = -1;
                switch (num1)
                {
                    case 2:
                        MiscFUncs.MsgBox_Renamed("An error occured in 'ModifyDEG':\r" + Information.Err().Description, (short)48, "Error");
                        goto label_31;
                }
            }
            catch (Exception ex) when (ex is Exception & (uint)num1 > 0U & num2 == 0)
            {
                ProjectData.SetProjectError(ex);

                num2 = -1;
                switch (num1)
                {
                    case 2:
                        MiscFUncs.MsgBox_Renamed("An error occured in 'ModifyDEG':\r" + Information.Err().Description, (short)48, "Error");
                        goto label_31;
                }
            }
            throw ProjectData.CreateProjectError(-2146828237);
        label_31:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void GetTableAndHorizonInfo(
          ref string DatabaseTable,
          ref bool AllHorizons,
          ref short HNum,
          string ParameterName,
          ref string CompleteParameterName)
        {
            Recordset dbParameterInfo = this.dbParameterInfo;
            if (Operators.CompareString(ParameterName, "GWFLUX", false) == 0)
                ParameterName = "BGRAD";
            if (Operators.CompareString(ParameterName, "ZLAMB", false) == 0)
                ParameterName = "N";
            if (Operators.CompareString(ParameterName, "SCALEVG", false) == 0)
                ParameterName = "ALPHA";
            try
            {
                ((_Recordset)dbParameterInfo).Open((object)("select * from ParameterInfoSUFI where ParameterName='" + ParameterName + "'"), (object)this.m_SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)MessageBox.Show("Error opening table 'ParameterInfoSUFI'\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
            AllHorizons = false;
            DatabaseTable = Conversions.ToString(((_Recordset)dbParameterInfo).Fields[(object)"Table"].Value);
            if (Operators.CompareString(ParameterName, "ALPHA", false) == 0 & Operators.CompareString(DatabaseTable, "Solute()", false) == 0)
                DatabaseTable = "Physical parameters";
            if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(((_Recordset)dbParameterInfo).Fields[(object)"Length"].Value, (object)1, false), (object)(Operators.CompareString(DatabaseTable, "Crop", false) == 0))))
            {
                short num1 = checked((short)(Strings.InStr(1, CompleteParameterName, "(") + 1));
                short num2 = checked((short)Strings.InStr(1, CompleteParameterName, ")"));
                if (Operators.CompareString(Strings.Mid(CompleteParameterName, (int)num1, (int)checked((short)unchecked((int)num2 - (int)num1))), "all", false) == 0)
                    AllHorizons = true;
                else
                    HNum = Conversions.ToShort(Strings.Mid(CompleteParameterName, (int)num1, (int)checked((short)unchecked((int)num2 - (int)num1))));
            }
          ((_Recordset)dbParameterInfo).Close();
        }

        private void UpdateSingleValue(ref string ParName, ref float value, ref string table)
        {
            Recordset recordset = (Recordset)new RecordsetClass();
            try
            {
                ((_Recordset)recordset).Open((object)("select * from [" + table + "] where R_ID=" + Conversions.ToString(this.m_BaseRunID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                ((_Recordset)recordset).Fields[(object)ParName].Value = (object)value;
                ((_Recordset)recordset).Update((object)Missing.Value, (object)Missing.Value);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                MiscFUncs.MsgBox_Renamed("An error occured in function 'UpdateSingleValue':\r" + ex.Message, (short)48, "Error");
                ProjectData.ClearProjectError();
            }
        }

        private void UpdateZKD(ref int StrataNr)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string DatabaseTable = "";
                Recordset recordset1 = (Recordset)new RecordsetClass();
                Recordset recordset2 = (Recordset)new RecordsetClass();
                string[] strArray = Strings.Split(Conversions.ToString(((_Recordset)this.dbParameters).Fields[(object)"Covary"].Value));
                Recordset recordset3 = (Recordset)new RecordsetClass();
                ((_Recordset)recordset3).Open((object)("select * from SUFIParameterValues where iterationid=" + Conversions.ToString(this.CurIterID) + " AND stratano=" + Conversions.ToString(StrataNr)), (object)this.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                ((_Recordset)recordset3).MoveFirst();
                float single1 = Conversions.ToSingle(((_Recordset)recordset3).Fields[(object)"Value"].Value);
                string ParameterName = "ZKD";
                string CompleteParameterName = "ZKD (all)";
                bool AllHorizons = false;
                short HNum = 0;
                this.GetTableAndHorizonInfo(ref DatabaseTable, ref AllHorizons, ref HNum, ParameterName, ref CompleteParameterName);
                string str = "ZKD";
                Recordset recordset4 = recordset1;
                ((_Recordset)recordset4).Open((object)("select * from Properties where R_id=" + Conversions.ToString(this.m_BaseRunID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                short num3 = 1;
                short num4 = 0;
                ((_Recordset)recordset4).MoveFirst();
                while (!((_Recordset)recordset4).EOF)
                {
                    if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(((_Recordset)recordset4).Fields[(object)"horiz_no"].Value, (object)HNum, false), (object)AllHorizons), (object)(Conversions.ToDouble(strArray[(int)num4]) == 1.0))))
                    {
                        strArray[(int)num4] = Conversions.ToString(0);
                        checked { ++num4; }
                        if (!AllHorizons)
                            break;
                    }
                    else
                    {
                        checked { ++num3; }
                        checked { ++num4; }
                    }
                  ((_Recordset)recordset4).MoveNext();
                }
              ((_Recordset)recordset4).Close();
                ((_Recordset)recordset4).Open((object)("select * from [Solute()] where r_id=" + Conversions.ToString(this.m_BaseRunID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                ((_Recordset)recordset2).Open((object)("select [orgc] from [Properties] where r_id=" + Conversions.ToString(this.m_BaseRunID)), (object)this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                ((_Recordset)recordset2).MoveFirst();
                while (!((_Recordset)recordset4).EOF)
                {
                    float single2 = Conversions.ToSingle(((_Recordset)recordset2).Fields[(object)"orgc"].Value);
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(((_Recordset)recordset4).Fields[(object)"Layer_no"].Value, (object)num3, false), Operators.CompareObjectLessEqual(((_Recordset)recordset4).Fields[(object)"Layer_no"].Value, (object)num4, false))))
                    {
                        ((_Recordset)recordset4).Fields[(object)Strings.Trim(str)].Value = (object)(float)((double)single1 * (double)single2 / 100.0);
                        ((_Recordset)recordset4).Update((object)Missing.Value, (object)Missing.Value);
                    }
                  ((_Recordset)recordset2).MoveNext();
                    ((_Recordset)recordset4).MoveNext();
                }
                goto label_19;

                num2 = -1;
                switch (num1)
                {
                    case 2:
                        MiscFUncs.MsgBox_Renamed("An error occured in 'ModifyZKD:\r" + Information.Err().Description, (short)48, "Error");
                        goto label_19;
                }
            }
            catch (Exception ex) when (ex is Exception & (uint)num1 > 0U & num2 == 0)
            {
                ProjectData.SetProjectError(ex);

                num2 = -1;
                switch (num1)
                {
                    case 2:
                        MiscFUncs.MsgBox_Renamed("An error occured in 'ModifyZKD:\r" + Information.Err().Description, (short)48, "Error");
                        goto label_19;
                }
            }
            throw ProjectData.CreateProjectError(-2146828237);
        label_19:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Timer1_Tick(object eventSender, EventArgs eventArgs)
        {
            this.Timer1.Enabled = false;
            this.NextSimulation();
        }

        private void lstSUFIProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetProjectInformation();
            this.SetIterationInformation();
        }
    }
}
