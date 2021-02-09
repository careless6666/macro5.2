namespace MACRO_52
{
    using MACRO_52.My.Resources;
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
    internal class CfrmOptions : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Command1")]
        private Button _Command1;
        [AccessedThroughProperty("chkTempIni")]
        private CheckBox _chkTempIni;
        [AccessedThroughProperty("_Option1_0")]
        private RadioButton __Option1_0;
        [AccessedThroughProperty("_Option1_1")]
        private RadioButton __Option1_1;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("chkVarTension")]
        private CheckBox _chkVarTension;
        [AccessedThroughProperty("_Option2_4")]
        private RadioButton __Option2_4;
        [AccessedThroughProperty("_Option2_3")]
        private RadioButton __Option2_3;
        [AccessedThroughProperty("_Option2_2")]
        private RadioButton __Option2_2;
        [AccessedThroughProperty("_Option2_1")]
        private RadioButton __Option2_1;
        [AccessedThroughProperty("_Option2_0")]
        private RadioButton __Option2_0;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("chkCrust")]
        private CheckBox _chkCrust;
        [AccessedThroughProperty("_optManagement_0")]
        private RadioButton __optManagement_0;
        [AccessedThroughProperty("_optManagement_1")]
        private RadioButton __optManagement_1;
        [AccessedThroughProperty("Frame3")]
        private GroupBox _Frame3;
        [AccessedThroughProperty("_Option7_0")]
        private RadioButton __Option7_0;
        [AccessedThroughProperty("_Option7_1")]
        private RadioButton __Option7_1;
        [AccessedThroughProperty("Frame7")]
        private GroupBox _Frame7;
        [AccessedThroughProperty("_Option3_0")]
        private RadioButton __Option3_0;
        [AccessedThroughProperty("_Option3_1")]
        private RadioButton __Option3_1;
        [AccessedThroughProperty("Frame14")]
        private GroupBox _Frame14;
        [AccessedThroughProperty("_Option6_5")]
        private RadioButton __Option6_5;
        [AccessedThroughProperty("_Option6_6")]
        private RadioButton __Option6_6;
        [AccessedThroughProperty("_Option6_7")]
        private RadioButton __Option6_7;
        [AccessedThroughProperty("_Option6_8")]
        private RadioButton __Option6_8;
        [AccessedThroughProperty("_Option6_9")]
        private RadioButton __Option6_9;
        [AccessedThroughProperty("Frame11")]
        private GroupBox _Frame11;
        [AccessedThroughProperty("_Option4_0")]
        private RadioButton __Option4_0;
        [AccessedThroughProperty("_Option4_1")]
        private RadioButton __Option4_1;
        [AccessedThroughProperty("_Option4_2")]
        private RadioButton __Option4_2;
        [AccessedThroughProperty("Frame4")]
        private GroupBox _Frame4;
        [AccessedThroughProperty("Check1")]
        private CheckBox _Check1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Frame10")]
        private GroupBox _Frame10;
        [AccessedThroughProperty("_Option8_0")]
        private RadioButton __Option8_0;
        [AccessedThroughProperty("_Option8_1")]
        private RadioButton __Option8_1;
        [AccessedThroughProperty("_Option8_2")]
        private RadioButton __Option8_2;
        [AccessedThroughProperty("_Option8_3")]
        private RadioButton __Option8_3;
        [AccessedThroughProperty("Frame9")]
        private GroupBox _Frame9;
        [AccessedThroughProperty("_Option5_0")]
        private RadioButton __Option5_0;
        [AccessedThroughProperty("_Option5_1")]
        private RadioButton __Option5_1;
        [AccessedThroughProperty("_Option5_2")]
        private RadioButton __Option5_2;
        [AccessedThroughProperty("_Option5_3")]
        private RadioButton __Option5_3;
        [AccessedThroughProperty("_Option5_4")]
        private RadioButton __Option5_4;
        [AccessedThroughProperty("_Option5_5")]
        private RadioButton __Option5_5;
        [AccessedThroughProperty("_Option5_6")]
        private RadioButton __Option5_6;
        [AccessedThroughProperty("Frame5")]
        private GroupBox _Frame5;
        [AccessedThroughProperty("_optDegKin_1")]
        private RadioButton __optDegKin_1;
        [AccessedThroughProperty("_optDegKin_0")]
        private RadioButton __optDegKin_0;
        [AccessedThroughProperty("Frame8")]
        private GroupBox _Frame8;
        [AccessedThroughProperty("_optSorption_1")]
        private RadioButton __optSorption_1;
        [AccessedThroughProperty("_optSorption_0")]
        private RadioButton __optSorption_0;
        [AccessedThroughProperty("Frame6")]
        private GroupBox _Frame6;
        [AccessedThroughProperty("Option1")]
        private RadioButtonArray _Option1;
        [AccessedThroughProperty("Option2")]
        private RadioButtonArray _Option2;
        [AccessedThroughProperty("Option3")]
        private RadioButtonArray _Option3;
        [AccessedThroughProperty("Option4")]
        private RadioButtonArray _Option4;
        [AccessedThroughProperty("Option5")]
        private RadioButtonArray _Option5;
        [AccessedThroughProperty("Option6")]
        private RadioButtonArray _Option6;
        [AccessedThroughProperty("Option7")]
        private RadioButtonArray _Option7;
        [AccessedThroughProperty("Option8")]
        private RadioButtonArray _Option8;
        [AccessedThroughProperty("optDegKin")]
        private RadioButtonArray _optDegKin;
        [AccessedThroughProperty("optManagement")]
        private RadioButtonArray _optManagement;
        [AccessedThroughProperty("optSorption")]
        private RadioButtonArray _optSorption;
        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;
        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;
        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;
        [AccessedThroughProperty("TabPage4")]
        private TabPage _TabPage4;
        [AccessedThroughProperty("ToolTip1")]
        private ToolTip _ToolTip1;
        [AccessedThroughProperty("chkTOXSWA")]
        private CheckBox _chkTOXSWA;
        private bool IsInitializing;
        private CfrmMain frmMain;
        private short i;

        public CfrmOptions(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmOptions_Load);
            base.Activated += new EventHandler(this.frmOptions_Activated);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            this.frmMain = frm;
        }

        private void _Option8_0_CheckedChanged(object sender, EventArgs e)
        {
        }

        private bool AddCrust()
        {
            bool flag;
            if (GlobalVariables.Nhorizon == 10)
            {
                MiscFUncs.MsgBox_Renamed("Maximum number of horizons reached.\rCannot add crust.", 0x30, "Max number of horizons reached");
                flag = false;
            }
            else
            {
                CfrmSoilProperties frmDefineSoil = this.frmMain.frmDefineSoil;
                frmDefineSoil.Activate();
                frmDefineSoil.txtAddBefore.Text = "1";
                frmDefineSoil.chkAddBefore.CheckState = CheckState.Checked;
                frmDefineSoil.UpDown1.Value = decimal.Add(frmDefineSoil.UpDown1.Value, 1M);
                frmDefineSoil.chkAddBefore.CheckState = CheckState.Unchecked;
                frmDefineSoil.grdData.set_TextMatrix(1, 0, "seal");
                frmDefineSoil.grdData.set_TextMatrix(1, 7, "0.3");
                frmDefineSoil.bOptionChange = true;
                frmDefineSoil.DefineSoilProperties();
                frmDefineSoil.bOptionChange = false;
                frmDefineSoil = null;
                this.frmMain.frmDefineSoil.Close();
                flag = true;
            }
            return flag;
        }

        private void Command1_Click(object eventSender, EventArgs eventArgs)
        {
            GlobalVariables.sw_tempini = (this.chkTempIni.CheckState != CheckState.Checked) ? MACROConstants.Switch.NoMetabolite : MACROConstants.Switch.BareSoil;
            this.i = 0;
            while (true)
            {
                if (this.Option8[this.i].Checked)
                {
                    GlobalVariables.sw_massunits = (MACROConstants.Switch) (this.i + 1);
                }
                else
                {
                    this.i = (short) (this.i + 1);
                    short num = 3;
                    if (this.i <= num)
                    {
                        continue;
                    }
                }
                if (this.Check1.CheckState != CheckState.Checked)
                {
                    GlobalVariables.sw_metabolite = MACROConstants.Switch.NoMetabolite;
                }
                else
                {
                    GlobalVariables.sw_metabolite = MACROConstants.Switch.BareSoil;
                    GlobalVariables.outintd = 1;
                    GlobalVariables.outintm = 0;
                    GlobalVariables.sw_specout = MACROConstants.Switch.NoMetabolite;
                }
                this.SelectOutputForMetabolite();
                if (!this.chkTOXSWA.Checked)
                {
                    GlobalVariables.sw_toxswa = MACROConstants.Switch.NoMetabolite;
                }
                else
                {
                    GlobalVariables.sw_toxswa = MACROConstants.Switch.BareSoil;
                    this.SelectTOXSWAoutput();
                }
                if (!this.optManagement[1].Checked)
                {
                    if (GlobalVariables.sw_management == MACROConstants.Switch.BareSoil)
                    {
                        GlobalVariables.LayOutputs[this.FindIndex(ref "TMPOR"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "GAMMA"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "Z"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "XMPOR"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "ALPHA"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "KSM"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "ZN"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "ASCALE"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "TRAP_AIR"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "KSATMIN"), 3] = 0;
                        GlobalVariables.LayOutputs[this.FindIndex(ref "TPORV"), 3] = 0;
                    }
                    GlobalVariables.sw_management = MACROConstants.Switch.NoMetabolite;
                }
                else
                {
                    if (GlobalVariables.sw_management == MACROConstants.Switch.NoMetabolite)
                    {
                        GlobalVariables.NTILL = 1;
                        GlobalVariables.gamma_ch = GlobalVariables.gamma[1] - ((float) 0.2);
                        GlobalVariables.macp_ch = GlobalVariables.xmpor[1] + 2f;
                        if (GlobalVariables.macp_ch > GlobalVariables.tporv[1])
                        {
                            GlobalVariables.macp_ch = GlobalVariables.tporv[1] - ((float) 0.1);
                        }
                        GlobalVariables.macd_ch = GlobalVariables.zn[1] + 2f;
                        GlobalVariables.ksmtille = GlobalVariables.ksm[1] + ((float) 0.5);
                        GlobalVariables.t_ascale[0] = 5f;
                        if (GlobalVariables.t_ascale[0] > GlobalVariables.ascale[1])
                        {
                            GlobalVariables.t_ascale[0] = GlobalVariables.ascale[1] - 1f;
                        }
                        if (GlobalVariables.t_ascale[0] == 0f)
                        {
                            GlobalVariables.t_ascale[0] = 1f;
                        }
                    }
                    GlobalVariables.sw_management = MACROConstants.Switch.BareSoil;
                }
                if (this.chkCrust.CheckState != CheckState.Checked)
                {
                    GlobalVariables.sw_crust = MACROConstants.Switch.NoMetabolite;
                }
                else
                {
                    if (GlobalVariables.sw_crust == MACROConstants.Switch.NoMetabolite)
                    {
                        GlobalVariables.gammaseal = GlobalVariables.gamma[1] + ((float) 0.2);
                        GlobalVariables.xmporseal = GlobalVariables.xmpor[1] - 1f;
                        GlobalVariables.znseal = GlobalVariables.zn[1] - 1f;
                        if (GlobalVariables.znseal < 2f)
                        {
                            GlobalVariables.znseal = 2f;
                        }
                        GlobalVariables.ksmseal = GlobalVariables.ksm[1] - (GlobalVariables.ksm[1] / 2f);
                    }
                    GlobalVariables.sw_crust = MACROConstants.Switch.BareSoil;
                }
                GlobalVariables.sw_vartension = (this.chkVarTension.CheckState != CheckState.Checked) ? MACROConstants.Switch.NoMetabolite : MACROConstants.Switch.BareSoil;
                this.Hide();
                return;
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

        private short FindIndex(ref string str_Renamed)
        {
            short num3 = (short) Information.UBound(GlobalVariables.LayOutputs, 1);
            short num2 = 1;
            while (true)
            {
                short num;
                short num4 = num3;
                if (num2 <= num4)
                {
                    num = num2;
                    if (!Operators.ConditionalCompareObjectEqual(GlobalVariables.LayOutputs[num2, 1], str_Renamed, false))
                    {
                        num2 = (short) (num2 + 1);
                        continue;
                    }
                }
                return num;
            }
        }

        private void frmOptions_Activated(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                this.chkCrust.CheckState = (GlobalVariables.sw_crust != MACROConstants.Switch.NoMetabolite) ? CheckState.Checked : CheckState.Unchecked;
                this.chkTempIni.CheckState = (GlobalVariables.sw_tempini != MACROConstants.Switch.BareSoil) ? CheckState.Unchecked : CheckState.Checked;
                this.chkTOXSWA.Checked = GlobalVariables.sw_toxswa == MACROConstants.Switch.BareSoil;
                this.Option1[(short) (GlobalVariables.sw_initial - 1)].Checked = true;
                this.Option2[(short) (GlobalVariables.sw_boundary - 1)].Checked = true;
                this.Option3[(short) (GlobalVariables.sw_tiledrain - 1)].Checked = true;
                this.Option4[(short) (GlobalVariables.sw_crop - 1)].Checked = true;
                this.Option7[(short) GlobalVariables.sw_irrigate].Checked = true;
                this.Option8[(short) (GlobalVariables.sw_massunits - 1)].Checked = true;
                if (GlobalVariables.sw_management == MACROConstants.Switch.BareSoil)
                {
                    this.optManagement[1].Checked = true;
                    this.optManagement[0].Checked = false;
                }
                else
                {
                    this.optManagement[1].Checked = false;
                    this.optManagement[0].Checked = true;
                }
                if (GlobalVariables.sw_metabolite == MACROConstants.Switch.BareSoil)
                {
                    this.Check1.Enabled = true;
                    this.Check1.CheckState = CheckState.Checked;
                }
                else
                {
                    this.Check1.CheckState = CheckState.Unchecked;
                    this.Check1.Enabled = false;
                }
                if (GlobalVariables.sw_driving == MACROConstants.Switch.BareSoil)
                {
                    this.Option5[4].Checked = true;
                }
                else if (GlobalVariables.sw_driving == MACROConstants.Switch.Annual)
                {
                    this.Option5[6].Checked = true;
                }
                else if (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil)
                {
                    this.Option5[5].Checked = true;
                }
                else
                {
                    if (GlobalVariables.sw_kinetic != MACROConstants.Switch.BareSoil)
                    {
                        this.optSorption[0].Checked = true;
                        this.optDegKin[0].Checked = true;
                    }
                    else
                    {
                        short num = (short) GlobalVariables.sw_degkin;
                        this.optSorption[1].Checked = true;
                        GlobalVariables.sw_degkin = (MACROConstants.Switch) num;
                        if (GlobalVariables.sw_degkin != MACROConstants.Switch.NoMetabolite)
                        {
                            this.optDegKin[0].Enabled = true;
                            this.optDegKin[1].Enabled = true;
                            this.optDegKin[0].Checked = false;
                            this.optDegKin[1].Checked = true;
                        }
                    }
                    this.Option5[(short) (GlobalVariables.sw_solute - 1)].Checked = true;
                    if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                    {
                        this.Check1.Enabled = true;
                        this.Check1.CheckState = (GlobalVariables.sw_metabolite != MACROConstants.Switch.BareSoil) ? CheckState.Unchecked : CheckState.Checked;
                    }
                    this.chkVarTension.CheckState = (GlobalVariables.sw_vartension != MACROConstants.Switch.BareSoil) ? CheckState.Unchecked : CheckState.Checked;
                }
            }
        }

        private void frmOptions_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
            ToolTip tip = this.ToolTip1;
            tip.SetToolTip(this._optManagement_0, MACRO_52.My.Resources.Resources.Tooltip_TILLAGE);
            tip.SetToolTip(this._optManagement_1, MACRO_52.My.Resources.Resources.Tooltip_TILLAGE);
            tip.SetToolTip(this._Option7_0, MACRO_52.My.Resources.Resources.Tooltip_IRRIGATION);
            tip.SetToolTip(this._Option7_1, MACRO_52.My.Resources.Resources.Tooltip_IRRIGATION);
            tip.SetToolTip(this._Option4_0, MACRO_52.My.Resources.Resources.Tooltip_CROP);
            tip.SetToolTip(this._Option4_1, MACRO_52.My.Resources.Resources.Tooltip_CROP);
            tip.SetToolTip(this._Option4_2, MACRO_52.My.Resources.Resources.Tooltip_CROP);
            tip = null;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Command1 = new Button();
            this.Frame2 = new GroupBox();
            this.chkTempIni = new CheckBox();
            this._Option1_0 = new RadioButton();
            this._Option1_1 = new RadioButton();
            this.Frame1 = new GroupBox();
            this.chkVarTension = new CheckBox();
            this._Option2_4 = new RadioButton();
            this._Option2_3 = new RadioButton();
            this._Option2_2 = new RadioButton();
            this._Option2_1 = new RadioButton();
            this._Option2_0 = new RadioButton();
            this.Frame3 = new GroupBox();
            this.chkCrust = new CheckBox();
            this._optManagement_0 = new RadioButton();
            this._optManagement_1 = new RadioButton();
            this.Frame7 = new GroupBox();
            this._Option7_0 = new RadioButton();
            this._Option7_1 = new RadioButton();
            this.Frame14 = new GroupBox();
            this._Option3_0 = new RadioButton();
            this._Option3_1 = new RadioButton();
            this.Frame11 = new GroupBox();
            this._Option6_5 = new RadioButton();
            this._Option6_6 = new RadioButton();
            this._Option6_7 = new RadioButton();
            this._Option6_8 = new RadioButton();
            this._Option6_9 = new RadioButton();
            this.Frame4 = new GroupBox();
            this._Option4_0 = new RadioButton();
            this._Option4_1 = new RadioButton();
            this._Option4_2 = new RadioButton();
            this.Frame10 = new GroupBox();
            this.chkTOXSWA = new CheckBox();
            this.Check1 = new CheckBox();
            this.Label1 = new Label();
            this.Frame9 = new GroupBox();
            this._Option8_0 = new RadioButton();
            this._Option8_1 = new RadioButton();
            this._Option8_2 = new RadioButton();
            this._Option8_3 = new RadioButton();
            this.Frame5 = new GroupBox();
            this._Option5_0 = new RadioButton();
            this._Option5_1 = new RadioButton();
            this._Option5_2 = new RadioButton();
            this._Option5_3 = new RadioButton();
            this._Option5_4 = new RadioButton();
            this._Option5_5 = new RadioButton();
            this._Option5_6 = new RadioButton();
            this.Frame6 = new GroupBox();
            this.Frame8 = new GroupBox();
            this._optDegKin_1 = new RadioButton();
            this._optDegKin_0 = new RadioButton();
            this._optSorption_1 = new RadioButton();
            this._optSorption_0 = new RadioButton();
            this.Option1 = new RadioButtonArray(this.components);
            this.Option2 = new RadioButtonArray(this.components);
            this.Option3 = new RadioButtonArray(this.components);
            this.Option4 = new RadioButtonArray(this.components);
            this.Option5 = new RadioButtonArray(this.components);
            this.Option6 = new RadioButtonArray(this.components);
            this.Option7 = new RadioButtonArray(this.components);
            this.Option8 = new RadioButtonArray(this.components);
            this.optDegKin = new RadioButtonArray(this.components);
            this.optManagement = new RadioButtonArray(this.components);
            this.optSorption = new RadioButtonArray(this.components);
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.TabPage2 = new TabPage();
            this.TabPage4 = new TabPage();
            this.ToolTip1 = new ToolTip(this.components);
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.Frame7.SuspendLayout();
            this.Frame14.SuspendLayout();
            this.Frame11.SuspendLayout();
            this.Frame4.SuspendLayout();
            this.Frame10.SuspendLayout();
            this.Frame9.SuspendLayout();
            this.Frame5.SuspendLayout();
            this.Frame6.SuspendLayout();
            this.Frame8.SuspendLayout();
            ((ISupportInitialize) this.Option1).BeginInit();
            ((ISupportInitialize) this.Option2).BeginInit();
            ((ISupportInitialize) this.Option3).BeginInit();
            ((ISupportInitialize) this.Option4).BeginInit();
            ((ISupportInitialize) this.Option5).BeginInit();
            ((ISupportInitialize) this.Option6).BeginInit();
            ((ISupportInitialize) this.Option7).BeginInit();
            ((ISupportInitialize) this.Option8).BeginInit();
            ((ISupportInitialize) this.optDegKin).BeginInit();
            ((ISupportInitialize) this.optManagement).BeginInit();
            ((ISupportInitialize) this.optSorption).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.SuspendLayout();
            this.Command1.BackColor = SystemColors.Control;
            this.Command1.Cursor = Cursors.Default;
            this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command1.ForeColor = SystemColors.ControlText;
            Point point = new Point(0x1b1, 0x176);
            this.Command1.Location = point;
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = RightToLeft.No;
            Size size = new Size(0x49, 0x19);
            this.Command1.Size = size;
            this.Command1.TabIndex = 2;
            this.Command1.Text = "&OK";
            this.Command1.UseVisualStyleBackColor = false;
            this.Frame2.BackColor = Color.Transparent;
            this.Frame2.Controls.Add(this.chkTempIni);
            this.Frame2.Controls.Add(this._Option1_0);
            this.Frame2.Controls.Add(this._Option1_1);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(6, 0x95);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0x1b9, 0x71);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 8;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Initial condition";
            this.chkTempIni.BackColor = Color.Transparent;
            this.chkTempIni.Cursor = Cursors.Default;
            this.chkTempIni.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkTempIni.ForeColor = SystemColors.ControlText;
            point = new Point(8, 80);
            this.chkTempIni.Location = point;
            this.chkTempIni.Name = "chkTempIni";
            this.chkTempIni.RightToLeft = RightToLeft.No;
            size = new Size(0x181, 0x11);
            this.chkTempIni.Size = size;
            this.chkTempIni.TabIndex = 0x35;
            this.chkTempIni.Text = "Calculate initial temperature from analytical solution";
            this.chkTempIni.UseVisualStyleBackColor = false;
            this._Option1_0.BackColor = Color.Transparent;
            this._Option1_0.Cursor = Cursors.Default;
            this._Option1_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option1_0.ForeColor = SystemColors.ControlText;
            this.Option1.SetIndex(this._Option1_0, 0);
            point = new Point(8, 0x18);
            this._Option1_0.Location = point;
            this._Option1_0.Name = "_Option1_0";
            this._Option1_0.RightToLeft = RightToLeft.No;
            size = new Size(0x1a1, 0x19);
            this._Option1_0.Size = size;
            this._Option1_0.TabIndex = 10;
            this._Option1_0.TabStop = true;
            this._Option1_0.Text = "&Drainage equilibrium with a water table at the base of the profile";
            this._Option1_0.UseVisualStyleBackColor = false;
            this._Option1_1.BackColor = Color.Transparent;
            this._Option1_1.Cursor = Cursors.Default;
            this._Option1_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option1_1.ForeColor = SystemColors.ControlText;
            this.Option1.SetIndex(this._Option1_1, 1);
            point = new Point(8, 0x30);
            this._Option1_1.Location = point;
            this._Option1_1.Name = "_Option1_1";
            this._Option1_1.RightToLeft = RightToLeft.No;
            size = new Size(0xf1, 0x19);
            this._Option1_1.Size = size;
            this._Option1_1.TabIndex = 9;
            this._Option1_1.TabStop = true;
            this._Option1_1.Text = "&User-defined water contents";
            this._Option1_1.UseVisualStyleBackColor = false;
            this.Frame1.BackColor = Color.Transparent;
            this.Frame1.Controls.Add(this.chkVarTension);
            this.Frame1.Controls.Add(this._Option2_4);
            this.Frame1.Controls.Add(this._Option2_3);
            this.Frame1.Controls.Add(this._Option2_2);
            this.Frame1.Controls.Add(this._Option2_1);
            this.Frame1.Controls.Add(this._Option2_0);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(6, 6);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x1b9, 0x89);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 1;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Lower boundary condition";
            this.chkVarTension.BackColor = Color.Transparent;
            this.chkVarTension.Cursor = Cursors.Default;
            this.chkVarTension.Enabled = false;
            this.chkVarTension.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkVarTension.ForeColor = SystemColors.ControlText;
            point = new Point(160, 0x48);
            this.chkVarTension.Location = point;
            this.chkVarTension.Name = "chkVarTension";
            this.chkVarTension.RightToLeft = RightToLeft.No;
            size = new Size(0xc9, 0x11);
            this.chkVarTension.Size = size;
            this.chkVarTension.TabIndex = 0x36;
            this.chkVarTension.Text = "&Time-variable";
            this.chkVarTension.UseVisualStyleBackColor = false;
            this._Option2_4.BackColor = Color.Transparent;
            this._Option2_4.Cursor = Cursors.Default;
            this._Option2_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option2_4.ForeColor = SystemColors.ControlText;
            this.Option2.SetIndex(this._Option2_4, 4);
            point = new Point(8, 0x60);
            this._Option2_4.Location = point;
            this._Option2_4.Name = "_Option2_4";
            this._Option2_4.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this._Option2_4.Size = size;
            this._Option2_4.TabIndex = 7;
            this._Option2_4.TabStop = true;
            this._Option2_4.Text = "&Lysimeter with free drainage";
            this._Option2_4.UseVisualStyleBackColor = false;
            this._Option2_3.BackColor = Color.Transparent;
            this._Option2_3.Cursor = Cursors.Default;
            this._Option2_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option2_3.ForeColor = SystemColors.ControlText;
            this.Option2.SetIndex(this._Option2_3, 3);
            point = new Point(8, 0x48);
            this._Option2_3.Location = point;
            this._Option2_3.Name = "_Option2_3";
            this._Option2_3.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this._Option2_3.Size = size;
            this._Option2_3.TabIndex = 6;
            this._Option2_3.TabStop = true;
            this._Option2_3.Text = "&Pressure potential";
            this._Option2_3.UseVisualStyleBackColor = false;
            this._Option2_2.BackColor = Color.Transparent;
            this._Option2_2.Cursor = Cursors.Default;
            this._Option2_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option2_2.ForeColor = SystemColors.ControlText;
            this.Option2.SetIndex(this._Option2_2, 2);
            point = new Point(8, 0x30);
            this._Option2_2.Location = point;
            this._Option2_2.Name = "_Option2_2";
            this._Option2_2.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this._Option2_2.Size = size;
            this._Option2_2.TabIndex = 5;
            this._Option2_2.TabStop = true;
            this._Option2_2.Text = "&Water table in the soil profile";
            this._Option2_2.UseVisualStyleBackColor = false;
            this._Option2_1.BackColor = Color.Transparent;
            this._Option2_1.Cursor = Cursors.Default;
            this._Option2_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option2_1.ForeColor = SystemColors.ControlText;
            this.Option2.SetIndex(this._Option2_1, 1);
            point = new Point(0xd8, 0x10);
            this._Option2_1.Location = point;
            this._Option2_1.Name = "_Option2_1";
            this._Option2_1.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this._Option2_1.Size = size;
            this._Option2_1.TabIndex = 4;
            this._Option2_1.TabStop = true;
            this._Option2_1.Text = "&Zero flux";
            this._Option2_1.UseVisualStyleBackColor = false;
            this._Option2_1.Visible = false;
            this._Option2_0.BackColor = Color.Transparent;
            this._Option2_0.Cursor = Cursors.Default;
            this._Option2_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option2_0.ForeColor = SystemColors.ControlText;
            this.Option2.SetIndex(this._Option2_0, 0);
            point = new Point(8, 0x18);
            this._Option2_0.Location = point;
            this._Option2_0.Name = "_Option2_0";
            this._Option2_0.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this._Option2_0.Size = size;
            this._Option2_0.TabIndex = 3;
            this._Option2_0.TabStop = true;
            this._Option2_0.Text = "Constant &hydraulic gradient";
            this._Option2_0.UseVisualStyleBackColor = false;
            this.Frame3.BackColor = Color.Transparent;
            this.Frame3.Controls.Add(this.chkCrust);
            this.Frame3.Controls.Add(this._optManagement_0);
            this.Frame3.Controls.Add(this._optManagement_1);
            this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame3.ForeColor = SystemColors.ControlText;
            point = new Point(6, 6);
            this.Frame3.Location = point;
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = RightToLeft.No;
            size = new Size(0x1b9, 0x41);
            this.Frame3.Size = size;
            this.Frame3.TabIndex = 0x17;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Tillage";
            this.chkCrust.BackColor = Color.Transparent;
            this.chkCrust.Cursor = Cursors.Default;
            this.chkCrust.Enabled = false;
            this.chkCrust.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkCrust.ForeColor = SystemColors.ControlText;
            point = new Point(160, 40);
            this.chkCrust.Location = point;
            this.chkCrust.Name = "chkCrust";
            this.chkCrust.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.chkCrust.Size = size;
            this.chkCrust.TabIndex = 0x2d;
            this.chkCrust.Text = "Simulate &crust";
            this.chkCrust.UseVisualStyleBackColor = false;
            this.chkCrust.Visible = false;
            this._optManagement_0.BackColor = Color.Transparent;
            this._optManagement_0.Checked = true;
            this._optManagement_0.Cursor = Cursors.Default;
            this._optManagement_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optManagement_0.ForeColor = SystemColors.ControlText;
            this.optManagement.SetIndex(this._optManagement_0, 0);
            point = new Point(8, 0x10);
            this._optManagement_0.Location = point;
            this._optManagement_0.Name = "_optManagement_0";
            this._optManagement_0.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this._optManagement_0.Size = size;
            this._optManagement_0.TabIndex = 0x19;
            this._optManagement_0.TabStop = true;
            this._optManagement_0.Text = "Tillage &not considered";
            this._optManagement_0.UseVisualStyleBackColor = false;
            this._optManagement_1.BackColor = Color.Transparent;
            this._optManagement_1.Cursor = Cursors.Default;
            this._optManagement_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optManagement_1.ForeColor = SystemColors.ControlText;
            this.optManagement.SetIndex(this._optManagement_1, 1);
            point = new Point(8, 40);
            this._optManagement_1.Location = point;
            this._optManagement_1.Name = "_optManagement_1";
            this._optManagement_1.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._optManagement_1.Size = size;
            this._optManagement_1.TabIndex = 0x18;
            this._optManagement_1.TabStop = true;
            this._optManagement_1.Text = "&Tillage considered";
            this._optManagement_1.UseVisualStyleBackColor = false;
            this.Frame7.BackColor = Color.Transparent;
            this.Frame7.Controls.Add(this._Option7_0);
            this.Frame7.Controls.Add(this._Option7_1);
            this.Frame7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame7.ForeColor = SystemColors.ControlText;
            point = new Point(6, 0x4d);
            this.Frame7.Location = point;
            this.Frame7.Name = "Frame7";
            this.Frame7.RightToLeft = RightToLeft.No;
            size = new Size(0x1b9, 0x41);
            this.Frame7.Size = size;
            this.Frame7.TabIndex = 20;
            this.Frame7.TabStop = false;
            this.Frame7.Text = "Irrigation";
            this._Option7_0.BackColor = Color.Transparent;
            this._Option7_0.Cursor = Cursors.Default;
            this._Option7_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option7_0.ForeColor = SystemColors.ControlText;
            this.Option7.SetIndex(this._Option7_0, 0);
            point = new Point(8, 0x10);
            this._Option7_0.Location = point;
            this._Option7_0.Name = "_Option7_0";
            this._Option7_0.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x11);
            this._Option7_0.Size = size;
            this._Option7_0.TabIndex = 0x16;
            this._Option7_0.TabStop = true;
            this._Option7_0.Text = "N&o irrigation";
            this._Option7_0.UseVisualStyleBackColor = false;
            this._Option7_1.BackColor = Color.Transparent;
            this._Option7_1.Cursor = Cursors.Default;
            this._Option7_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option7_1.ForeColor = SystemColors.ControlText;
            this.Option7.SetIndex(this._Option7_1, 1);
            point = new Point(8, 40);
            this._Option7_1.Location = point;
            this._Option7_1.Name = "_Option7_1";
            this._Option7_1.RightToLeft = RightToLeft.No;
            size = new Size(0xb1, 0x11);
            this._Option7_1.Size = size;
            this._Option7_1.TabIndex = 0x15;
            this._Option7_1.TabStop = true;
            this._Option7_1.Text = "&Irrigation is applied";
            this._Option7_1.UseVisualStyleBackColor = false;
            this.Frame14.BackColor = Color.Transparent;
            this.Frame14.Controls.Add(this._Option3_0);
            this.Frame14.Controls.Add(this._Option3_1);
            this.Frame14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame14.ForeColor = SystemColors.ControlText;
            point = new Point(6, 0x94);
            this.Frame14.Location = point;
            this.Frame14.Name = "Frame14";
            this.Frame14.RightToLeft = RightToLeft.No;
            size = new Size(0x1b9, 0x41);
            this.Frame14.Size = size;
            this.Frame14.TabIndex = 0x11;
            this.Frame14.TabStop = false;
            this.Frame14.Text = "Drainage system";
            this._Option3_0.BackColor = Color.Transparent;
            this._Option3_0.Cursor = Cursors.Default;
            this._Option3_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option3_0.ForeColor = SystemColors.ControlText;
            this.Option3.SetIndex(this._Option3_0, 0);
            point = new Point(8, 0x10);
            this._Option3_0.Location = point;
            this._Option3_0.Name = "_Option3_0";
            this._Option3_0.RightToLeft = RightToLeft.No;
            size = new Size(0xd1, 0x11);
            this._Option3_0.Size = size;
            this._Option3_0.TabIndex = 0x13;
            this._Option3_0.TabStop = true;
            this._Option3_0.Text = "&Field drains";
            this._Option3_0.UseVisualStyleBackColor = false;
            this._Option3_1.BackColor = Color.Transparent;
            this._Option3_1.Cursor = Cursors.Default;
            this._Option3_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option3_1.ForeColor = SystemColors.ControlText;
            this.Option3.SetIndex(this._Option3_1, 1);
            point = new Point(8, 40);
            this._Option3_1.Location = point;
            this._Option3_1.Name = "_Option3_1";
            this._Option3_1.RightToLeft = RightToLeft.No;
            size = new Size(0xd1, 0x11);
            this._Option3_1.Size = size;
            this._Option3_1.TabIndex = 0x12;
            this._Option3_1.TabStop = true;
            this._Option3_1.Text = "&No drainage system installed";
            this._Option3_1.UseVisualStyleBackColor = false;
            this.Frame11.BackColor = Color.Transparent;
            this.Frame11.Controls.Add(this._Option6_5);
            this.Frame11.Controls.Add(this._Option6_6);
            this.Frame11.Controls.Add(this._Option6_7);
            this.Frame11.Controls.Add(this._Option6_8);
            this.Frame11.Controls.Add(this._Option6_9);
            this.Frame11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame11.ForeColor = SystemColors.ControlText;
            point = new Point(6, 0xdb);
            this.Frame11.Location = point;
            this.Frame11.Name = "Frame11";
            this.Frame11.RightToLeft = RightToLeft.No;
            size = new Size(0x141, 0x99);
            this.Frame11.Size = size;
            this.Frame11.TabIndex = 11;
            this.Frame11.TabStop = false;
            this.Frame11.Text = "Solute application pattern";
            this.Frame11.Visible = false;
            this._Option6_5.BackColor = SystemColors.Control;
            this._Option6_5.Cursor = Cursors.Default;
            this._Option6_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option6_5.ForeColor = SystemColors.ControlText;
            this.Option6.SetIndex(this._Option6_5, 5);
            point = new Point(8, 120);
            this._Option6_5.Location = point;
            this._Option6_5.Name = "_Option6_5";
            this._Option6_5.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._Option6_5.Size = size;
            this._Option6_5.TabIndex = 0x10;
            this._Option6_5.TabStop = true;
            this._Option6_5.Text = "Application every &third year";
            this._Option6_5.UseVisualStyleBackColor = false;
            this._Option6_6.BackColor = SystemColors.Control;
            this._Option6_6.Cursor = Cursors.Default;
            this._Option6_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option6_6.ForeColor = SystemColors.ControlText;
            this.Option6.SetIndex(this._Option6_6, 6);
            point = new Point(8, 0x60);
            this._Option6_6.Location = point;
            this._Option6_6.Name = "_Option6_6";
            this._Option6_6.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._Option6_6.Size = size;
            this._Option6_6.TabIndex = 15;
            this._Option6_6.TabStop = true;
            this._Option6_6.Text = "Application every &other year";
            this._Option6_6.UseVisualStyleBackColor = false;
            this._Option6_7.BackColor = Color.Transparent;
            this._Option6_7.Cursor = Cursors.Default;
            this._Option6_7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option6_7.ForeColor = SystemColors.ControlText;
            this.Option6.SetIndex(this._Option6_7, 7);
            point = new Point(8, 0x48);
            this._Option6_7.Location = point;
            this._Option6_7.Name = "_Option6_7";
            this._Option6_7.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._Option6_7.Size = size;
            this._Option6_7.TabIndex = 14;
            this._Option6_7.TabStop = true;
            this._Option6_7.Text = "Application &every year";
            this._Option6_7.UseVisualStyleBackColor = false;
            this._Option6_8.BackColor = Color.Transparent;
            this._Option6_8.Cursor = Cursors.Default;
            this._Option6_8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option6_8.ForeColor = SystemColors.ControlText;
            this.Option6.SetIndex(this._Option6_8, 8);
            point = new Point(8, 0x30);
            this._Option6_8.Location = point;
            this._Option6_8.Name = "_Option6_8";
            this._Option6_8.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._Option6_8.Size = size;
            this._Option6_8.TabIndex = 13;
            this._Option6_8.TabStop = true;
            this._Option6_8.Text = "Application in &first year only";
            this._Option6_8.UseVisualStyleBackColor = false;
            this._Option6_9.BackColor = Color.Transparent;
            this._Option6_9.Cursor = Cursors.Default;
            this._Option6_9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option6_9.ForeColor = SystemColors.ControlText;
            this.Option6.SetIndex(this._Option6_9, 9);
            point = new Point(8, 0x18);
            this._Option6_9.Location = point;
            this._Option6_9.Name = "_Option6_9";
            this._Option6_9.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._Option6_9.Size = size;
            this._Option6_9.TabIndex = 12;
            this._Option6_9.TabStop = true;
            this._Option6_9.Text = "&No regular pattern";
            this._Option6_9.UseVisualStyleBackColor = false;
            this.Frame4.BackColor = Color.Transparent;
            this.Frame4.Controls.Add(this._Option4_0);
            this.Frame4.Controls.Add(this._Option4_1);
            this.Frame4.Controls.Add(this._Option4_2);
            this.Frame4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame4.ForeColor = SystemColors.ControlText;
            point = new Point(6, 0xd9);
            this.Frame4.Location = point;
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = RightToLeft.No;
            size = new Size(0x1b9, 0x69);
            this.Frame4.Size = size;
            this.Frame4.TabIndex = 0x1a;
            this.Frame4.TabStop = false;
            this.Frame4.Text = "Crop type";
            this._Option4_0.BackColor = Color.Transparent;
            this._Option4_0.Cursor = Cursors.Default;
            this._Option4_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option4_0.ForeColor = SystemColors.ControlText;
            this.Option4.SetIndex(this._Option4_0, 0);
            point = new Point(8, 0x18);
            this._Option4_0.Location = point;
            this._Option4_0.Name = "_Option4_0";
            this._Option4_0.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._Option4_0.Size = size;
            this._Option4_0.TabIndex = 0x1d;
            this._Option4_0.TabStop = true;
            this._Option4_0.Text = "&Bare soil";
            this._Option4_0.UseVisualStyleBackColor = false;
            this._Option4_1.BackColor = Color.Transparent;
            this._Option4_1.Cursor = Cursors.Default;
            this._Option4_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option4_1.ForeColor = SystemColors.ControlText;
            this.Option4.SetIndex(this._Option4_1, 1);
            point = new Point(8, 0x30);
            this._Option4_1.Location = point;
            this._Option4_1.Name = "_Option4_1";
            this._Option4_1.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._Option4_1.Size = size;
            this._Option4_1.TabIndex = 0x1c;
            this._Option4_1.TabStop = true;
            this._Option4_1.Text = "&Annual crop rotation";
            this._Option4_1.UseVisualStyleBackColor = false;
            this._Option4_2.BackColor = Color.Transparent;
            this._Option4_2.Cursor = Cursors.Default;
            this._Option4_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option4_2.ForeColor = SystemColors.ControlText;
            this.Option4.SetIndex(this._Option4_2, 2);
            point = new Point(8, 0x48);
            this._Option4_2.Location = point;
            this._Option4_2.Name = "_Option4_2";
            this._Option4_2.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._Option4_2.Size = size;
            this._Option4_2.TabIndex = 0x1b;
            this._Option4_2.TabStop = true;
            this._Option4_2.Text = "&Perennial crop";
            this._Option4_2.UseVisualStyleBackColor = false;
            this.Frame10.BackColor = Color.Transparent;
            this.Frame10.Controls.Add(this.chkTOXSWA);
            this.Frame10.Controls.Add(this.Check1);
            this.Frame10.Controls.Add(this.Label1);
            this.Frame10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame10.ForeColor = SystemColors.ControlText;
            point = new Point(0x13a, 8);
            this.Frame10.Location = point;
            this.Frame10.Name = "Frame10";
            this.Frame10.RightToLeft = RightToLeft.No;
            size = new Size(0xa5, 0xb1);
            this.Frame10.Size = size;
            this.Frame10.TabIndex = 30;
            this.Frame10.TabStop = false;
            point = new Point(6, 0x48);
            this.chkTOXSWA.Location = point;
            this.chkTOXSWA.Name = "chkTOXSWA";
            size = new Size(150, 0x29);
            this.chkTOXSWA.Size = size;
            this.chkTOXSWA.TabIndex = 0x35;
            this.chkTOXSWA.Text = "Select output necessary for export to TOXSWA";
            this.chkTOXSWA.UseVisualStyleBackColor = true;
            this.Check1.BackColor = Color.Transparent;
            this.Check1.Cursor = Cursors.Default;
            this.Check1.Enabled = false;
            this.Check1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Check1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Check1.Location = point;
            this.Check1.Name = "Check1";
            this.Check1.RightToLeft = RightToLeft.No;
            size = new Size(150, 0x36);
            this.Check1.Size = size;
            this.Check1.TabIndex = 0x1f;
            this.Check1.Text = "Select only those outputs needed for subsequent metabolite simulation";
            this.Check1.UseVisualStyleBackColor = false;
            this.Label1.BackColor = Color.Transparent;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(6, 0x86);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(150, 40);
            this.Label1.Size = size;
            this.Label1.TabIndex = 0x34;
            this.Label1.Text = "Selecting this option will clear previously selected outputs";
            this.Frame9.BackColor = Color.Transparent;
            this.Frame9.Controls.Add(this._Option8_0);
            this.Frame9.Controls.Add(this._Option8_1);
            this.Frame9.Controls.Add(this._Option8_2);
            this.Frame9.Controls.Add(this._Option8_3);
            this.Frame9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame9.ForeColor = SystemColors.ControlText;
            point = new Point(0x13d, 0xbf);
            this.Frame9.Location = point;
            this.Frame9.Name = "Frame9";
            this.Frame9.RightToLeft = RightToLeft.No;
            size = new Size(0xa6, 0x71);
            this.Frame9.Size = size;
            this.Frame9.TabIndex = 0x20;
            this.Frame9.TabStop = false;
            this.Frame9.Text = "Massunits";
            this._Option8_0.BackColor = Color.Transparent;
            this._Option8_0.Cursor = Cursors.Default;
            this._Option8_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option8_0.ForeColor = SystemColors.ControlText;
            this.Option8.SetIndex(this._Option8_0, 0);
            point = new Point(8, 0x10);
            this._Option8_0.Location = point;
            this._Option8_0.Name = "_Option8_0";
            this._Option8_0.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Option8_0.Size = size;
            this._Option8_0.TabIndex = 0x24;
            this._Option8_0.TabStop = true;
            this._Option8_0.Text = "\x00b5g";
            this._Option8_0.UseVisualStyleBackColor = false;
            this._Option8_1.BackColor = Color.Transparent;
            this._Option8_1.Cursor = Cursors.Default;
            this._Option8_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option8_1.ForeColor = SystemColors.ControlText;
            this.Option8.SetIndex(this._Option8_1, 1);
            point = new Point(8, 40);
            this._Option8_1.Location = point;
            this._Option8_1.Name = "_Option8_1";
            this._Option8_1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Option8_1.Size = size;
            this._Option8_1.TabIndex = 0x23;
            this._Option8_1.TabStop = true;
            this._Option8_1.Text = "mg";
            this._Option8_1.UseVisualStyleBackColor = false;
            this._Option8_2.BackColor = Color.Transparent;
            this._Option8_2.Cursor = Cursors.Default;
            this._Option8_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option8_2.ForeColor = SystemColors.ControlText;
            this.Option8.SetIndex(this._Option8_2, 2);
            point = new Point(8, 0x40);
            this._Option8_2.Location = point;
            this._Option8_2.Name = "_Option8_2";
            this._Option8_2.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._Option8_2.Size = size;
            this._Option8_2.TabIndex = 0x22;
            this._Option8_2.TabStop = true;
            this._Option8_2.Text = "g";
            this._Option8_2.UseVisualStyleBackColor = false;
            this._Option8_3.BackColor = Color.Transparent;
            this._Option8_3.Cursor = Cursors.Default;
            this._Option8_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option8_3.ForeColor = SystemColors.ControlText;
            this.Option8.SetIndex(this._Option8_3, 3);
            point = new Point(8, 0x58);
            this._Option8_3.Location = point;
            this._Option8_3.Name = "_Option8_3";
            this._Option8_3.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this._Option8_3.Size = size;
            this._Option8_3.TabIndex = 0x21;
            this._Option8_3.TabStop = true;
            this._Option8_3.Text = "kg";
            this._Option8_3.UseVisualStyleBackColor = false;
            this.Frame5.BackColor = Color.Transparent;
            this.Frame5.Controls.Add(this._Option5_0);
            this.Frame5.Controls.Add(this._Option5_1);
            this.Frame5.Controls.Add(this._Option5_2);
            this.Frame5.Controls.Add(this._Option5_3);
            this.Frame5.Controls.Add(this._Option5_4);
            this.Frame5.Controls.Add(this._Option5_5);
            this.Frame5.Controls.Add(this._Option5_6);
            this.Frame5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame5.ForeColor = SystemColors.ControlText;
            point = new Point(3, 8);
            this.Frame5.Location = point;
            this.Frame5.Name = "Frame5";
            this.Frame5.RightToLeft = RightToLeft.No;
            size = new Size(0x131, 0x91);
            this.Frame5.Size = size;
            this.Frame5.TabIndex = 0x25;
            this.Frame5.TabStop = false;
            this.Frame5.Text = "Solute to simulate";
            this._Option5_0.BackColor = Color.Transparent;
            this._Option5_0.Cursor = Cursors.Default;
            this._Option5_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option5_0.ForeColor = SystemColors.ControlText;
            this.Option5.SetIndex(this._Option5_0, 0);
            point = new Point(8, 0x18);
            this._Option5_0.Location = point;
            this._Option5_0.Name = "_Option5_0";
            this._Option5_0.RightToLeft = RightToLeft.No;
            size = new Size(0xb1, 0x11);
            this._Option5_0.Size = size;
            this._Option5_0.TabIndex = 0x2c;
            this._Option5_0.TabStop = true;
            this._Option5_0.Text = "&Water (and heat) flow only";
            this._Option5_0.UseVisualStyleBackColor = false;
            this._Option5_1.BackColor = Color.Transparent;
            this._Option5_1.Cursor = Cursors.Default;
            this._Option5_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option5_1.ForeColor = SystemColors.ControlText;
            this.Option5.SetIndex(this._Option5_1, 1);
            point = new Point(8, 0x30);
            this._Option5_1.Location = point;
            this._Option5_1.Name = "_Option5_1";
            this._Option5_1.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x11);
            this._Option5_1.Size = size;
            this._Option5_1.TabIndex = 0x2b;
            this._Option5_1.TabStop = true;
            this._Option5_1.Text = "&Pesticide (parent compound)";
            this._Option5_1.UseVisualStyleBackColor = false;
            this._Option5_2.BackColor = Color.Transparent;
            this._Option5_2.Cursor = Cursors.Default;
            this._Option5_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option5_2.ForeColor = SystemColors.ControlText;
            this.Option5.SetIndex(this._Option5_2, 2);
            point = new Point(8, 0x48);
            this._Option5_2.Location = point;
            this._Option5_2.Name = "_Option5_2";
            this._Option5_2.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x11);
            this._Option5_2.Size = size;
            this._Option5_2.TabIndex = 0x2a;
            this._Option5_2.TabStop = true;
            this._Option5_2.Text = "&Non-reactive (anionic) tracer";
            this._Option5_2.UseVisualStyleBackColor = false;
            this._Option5_3.BackColor = Color.Transparent;
            this._Option5_3.Cursor = Cursors.Default;
            this._Option5_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option5_3.ForeColor = SystemColors.ControlText;
            this.Option5.SetIndex(this._Option5_3, 3);
            point = new Point(8, 0x60);
            this._Option5_3.Location = point;
            this._Option5_3.Name = "_Option5_3";
            this._Option5_3.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this._Option5_3.Size = size;
            this._Option5_3.TabIndex = 0x29;
            this._Option5_3.TabStop = true;
            this._Option5_3.Text = "&Tritium";
            this._Option5_3.UseVisualStyleBackColor = false;
            this._Option5_4.BackColor = Color.Transparent;
            this._Option5_4.Cursor = Cursors.Default;
            this._Option5_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option5_4.ForeColor = SystemColors.ControlText;
            this.Option5.SetIndex(this._Option5_4, 4);
            point = new Point(8, 120);
            this._Option5_4.Location = point;
            this._Option5_4.Name = "_Option5_4";
            this._Option5_4.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this._Option5_4.Size = size;
            this._Option5_4.TabIndex = 40;
            this._Option5_4.TabStop = true;
            this._Option5_4.Text = "Pesticide &metabolite";
            this._Option5_4.UseVisualStyleBackColor = false;
            this._Option5_5.BackColor = SystemColors.Control;
            this._Option5_5.Cursor = Cursors.Default;
            this._Option5_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option5_5.ForeColor = SystemColors.ControlText;
            this.Option5.SetIndex(this._Option5_5, 5);
            point = new Point(0x90, 0x10);
            this._Option5_5.Location = point;
            this._Option5_5.Name = "_Option5_5";
            this._Option5_5.RightToLeft = RightToLeft.No;
            size = new Size(0x99, 0x11);
            this._Option5_5.Size = size;
            this._Option5_5.TabIndex = 0x27;
            this._Option5_5.TabStop = true;
            this._Option5_5.Text = "P&articles";
            this._Option5_5.UseVisualStyleBackColor = false;
            this._Option5_5.Visible = false;
            this._Option5_6.BackColor = SystemColors.Control;
            this._Option5_6.Cursor = Cursors.Default;
            this._Option5_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Option5_6.ForeColor = SystemColors.ControlText;
            this.Option5.SetIndex(this._Option5_6, 6);
            point = new Point(0x58, 0x68);
            this._Option5_6.Location = point;
            this._Option5_6.Name = "_Option5_6";
            this._Option5_6.RightToLeft = RightToLeft.No;
            size = new Size(0xd1, 0x11);
            this._Option5_6.Size = size;
            this._Option5_6.TabIndex = 0x26;
            this._Option5_6.TabStop = true;
            this._Option5_6.Text = "Particle-&faciliated pesticide transport";
            this._Option5_6.UseVisualStyleBackColor = false;
            this._Option5_6.Visible = false;
            this.Frame6.BackColor = Color.Transparent;
            this.Frame6.Controls.Add(this.Frame8);
            this.Frame6.Controls.Add(this._optSorption_1);
            this.Frame6.Controls.Add(this._optSorption_0);
            this.Frame6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame6.ForeColor = SystemColors.ControlText;
            point = new Point(3, 0x9f);
            this.Frame6.Location = point;
            this.Frame6.Name = "Frame6";
            this.Frame6.RightToLeft = RightToLeft.No;
            size = new Size(0x131, 0x91);
            this.Frame6.Size = size;
            this.Frame6.TabIndex = 0x2e;
            this.Frame6.TabStop = false;
            this.Frame6.Text = "Sorption";
            this.Frame8.BackColor = Color.Transparent;
            this.Frame8.Controls.Add(this._optDegKin_1);
            this.Frame8.Controls.Add(this._optDegKin_0);
            this.Frame8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame8.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 0x48);
            this.Frame8.Location = point;
            this.Frame8.Name = "Frame8";
            this.Frame8.RightToLeft = RightToLeft.No;
            size = new Size(0x111, 0x39);
            this.Frame8.Size = size;
            this.Frame8.TabIndex = 0x31;
            this.Frame8.TabStop = false;
            this.Frame8.Text = "Degradation in kinetic pool";
            this._optDegKin_1.BackColor = Color.Transparent;
            this._optDegKin_1.Cursor = Cursors.Default;
            this._optDegKin_1.Enabled = false;
            this._optDegKin_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optDegKin_1.ForeColor = SystemColors.ControlText;
            this.optDegKin.SetIndex(this._optDegKin_1, 1);
            point = new Point(8, 0x20);
            this._optDegKin_1.Location = point;
            this._optDegKin_1.Name = "_optDegKin_1";
            this._optDegKin_1.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this._optDegKin_1.Size = size;
            this._optDegKin_1.TabIndex = 0x33;
            this._optDegKin_1.TabStop = true;
            this._optDegKin_1.Text = "Same as micropores (adsorbed phase)";
            this._optDegKin_1.UseVisualStyleBackColor = false;
            this._optDegKin_0.BackColor = Color.Transparent;
            this._optDegKin_0.Cursor = Cursors.Default;
            this._optDegKin_0.Enabled = false;
            this._optDegKin_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optDegKin_0.ForeColor = SystemColors.ControlText;
            this.optDegKin.SetIndex(this._optDegKin_0, 0);
            point = new Point(8, 0x10);
            this._optDegKin_0.Location = point;
            this._optDegKin_0.Name = "_optDegKin_0";
            this._optDegKin_0.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._optDegKin_0.Size = size;
            this._optDegKin_0.TabIndex = 50;
            this._optDegKin_0.TabStop = true;
            this._optDegKin_0.Text = "Zero";
            this._optDegKin_0.UseVisualStyleBackColor = false;
            this._optSorption_1.BackColor = Color.Transparent;
            this._optSorption_1.Cursor = Cursors.Default;
            this._optSorption_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optSorption_1.ForeColor = SystemColors.ControlText;
            this.optSorption.SetIndex(this._optSorption_1, 1);
            point = new Point(8, 0x30);
            this._optSorption_1.Location = point;
            this._optSorption_1.Name = "_optSorption_1";
            this._optSorption_1.RightToLeft = RightToLeft.No;
            size = new Size(0x109, 0x11);
            this._optSorption_1.Size = size;
            this._optSorption_1.TabIndex = 0x30;
            this._optSorption_1.TabStop = true;
            this._optSorption_1.Text = "&Kinetic sorption";
            this._optSorption_1.UseVisualStyleBackColor = false;
            this._optSorption_0.BackColor = Color.Transparent;
            this._optSorption_0.Checked = true;
            this._optSorption_0.Cursor = Cursors.Default;
            this._optSorption_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optSorption_0.ForeColor = SystemColors.ControlText;
            this.optSorption.SetIndex(this._optSorption_0, 0);
            point = new Point(8, 0x18);
            this._optSorption_0.Location = point;
            this._optSorption_0.Name = "_optSorption_0";
            this._optSorption_0.RightToLeft = RightToLeft.No;
            size = new Size(0xf9, 0x11);
            this._optSorption_0.Size = size;
            this._optSorption_0.TabIndex = 0x2f;
            this._optSorption_0.TabStop = true;
            this._optSorption_0.Text = "No k&inetic sorption";
            this._optSorption_0.UseVisualStyleBackColor = false;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage4);
            point = new Point(12, 12);
            this.TabControl1.Location = point;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            size = new Size(0x1ee, 0x164);
            this.TabControl1.Size = size;
            this.TabControl1.TabIndex = 3;
            this.TabPage1.BackColor = Color.Transparent;
            this.TabPage1.Controls.Add(this.Frame2);
            this.TabPage1.Controls.Add(this.Frame1);
            point = new Point(4, 0x17);
            this.TabPage1.Location = point;
            this.TabPage1.Name = "TabPage1";
            Padding padding = new Padding(3);
            this.TabPage1.Padding = padding;
            size = new Size(0x1e6, 0x149);
            this.TabPage1.Size = size;
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Boundary/initial conditions";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.TabPage2.BackColor = Color.Transparent;
            this.TabPage2.Controls.Add(this.Frame4);
            this.TabPage2.Controls.Add(this.Frame11);
            this.TabPage2.Controls.Add(this.Frame14);
            this.TabPage2.Controls.Add(this.Frame7);
            this.TabPage2.Controls.Add(this.Frame3);
            point = new Point(4, 0x17);
            this.TabPage2.Location = point;
            this.TabPage2.Name = "TabPage2";
            padding = new Padding(3);
            this.TabPage2.Padding = padding;
            size = new Size(0x1e6, 0x149);
            this.TabPage2.Size = size;
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Site management";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.TabPage4.BackColor = Color.Transparent;
            this.TabPage4.Controls.Add(this.Frame10);
            this.TabPage4.Controls.Add(this.Frame5);
            this.TabPage4.Controls.Add(this.Frame9);
            this.TabPage4.Controls.Add(this.Frame6);
            point = new Point(4, 0x17);
            this.TabPage4.Location = point;
            this.TabPage4.Name = "TabPage4";
            size = new Size(0x1e6, 0x149);
            this.TabPage4.Size = size;
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Solute";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.ToolTip1.ToolTipIcon = ToolTipIcon.Info;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x1fd, 0x198);
            this.ClientSize = size;
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Command1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(2, 0x15);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmOptions";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.Frame3.ResumeLayout(false);
            this.Frame7.ResumeLayout(false);
            this.Frame14.ResumeLayout(false);
            this.Frame11.ResumeLayout(false);
            this.Frame4.ResumeLayout(false);
            this.Frame10.ResumeLayout(false);
            this.Frame9.ResumeLayout(false);
            this.Frame5.ResumeLayout(false);
            this.Frame6.ResumeLayout(false);
            this.Frame8.ResumeLayout(false);
            ((ISupportInitialize) this.Option1).EndInit();
            ((ISupportInitialize) this.Option2).EndInit();
            ((ISupportInitialize) this.Option3).EndInit();
            ((ISupportInitialize) this.Option4).EndInit();
            ((ISupportInitialize) this.Option5).EndInit();
            ((ISupportInitialize) this.Option6).EndInit();
            ((ISupportInitialize) this.Option7).EndInit();
            ((ISupportInitialize) this.Option8).EndInit();
            ((ISupportInitialize) this.optDegKin).EndInit();
            ((ISupportInitialize) this.optManagement).EndInit();
            ((ISupportInitialize) this.optSorption).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void optDegKin_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                GlobalVariables.sw_degkin = (MACROConstants.Switch) this.optDegKin.GetIndex((RadioButton) eventSender);
            }
        }

        private void Option1_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                GlobalVariables.sw_initial = (MACROConstants.Switch) (this.Option1.GetIndex((RadioButton) eventSender) + 1);
            }
        }

        private void Option2_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                short index = this.Option2.GetIndex((RadioButton) eventSender);
                GlobalVariables.sw_boundary = (MACROConstants.Switch) (index + 1);
                if (index == 3)
                {
                    this.chkVarTension.Enabled = true;
                    this.chkVarTension.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.chkVarTension.Enabled = false;
                    this.chkVarTension.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void Option3_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                GlobalVariables.sw_tiledrain = (MACROConstants.Switch) (this.Option3.GetIndex((RadioButton) eventSender) + 1);
            }
        }

        private void Option4_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                GlobalVariables.sw_crop = (MACROConstants.Switch) (this.Option4.GetIndex((RadioButton) eventSender) + 1);
            }
        }

        private void Option5_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                short index = this.Option5.GetIndex((RadioButton) eventSender);
                this.i = 0;
                while (true)
                {
                    this.Option8[this.i].Enabled = true;
                    this.i = (short) (this.i + 1);
                    short num2 = 3;
                    if (this.i > num2)
                    {
                        GlobalVariables.sw_metabolite = MACROConstants.Switch.NoMetabolite;
                        if (index != 4)
                        {
                            GlobalVariables.sw_driving = (index != 6) ? MACROConstants.Switch.NoMetabolite : MACROConstants.Switch.Annual;
                        }
                        else
                        {
                            GlobalVariables.sw_driving = MACROConstants.Switch.BareSoil;
                            GlobalVariables.sw_metabolite = MACROConstants.Switch.BareSoil;
                        }
                        GlobalVariables.sw_colloid = (index != 5) ? MACROConstants.Switch.NoMetabolite : MACROConstants.Switch.BareSoil;
                        GlobalVariables.sw_solute = (index <= 3) ? ((MACROConstants.Switch) (index + 1)) : MACROConstants.Switch.Annual;
                        if ((index == 1) | (index == 4))
                        {
                            this.Check1.Enabled = true;
                        }
                        else
                        {
                            this.Check1.CheckState = CheckState.Unchecked;
                            this.Check1.Enabled = false;
                        }
                        if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                        {
                            this.optSorption[0].Enabled = true;
                            this.optSorption[1].Enabled = true;
                            this.optDegKin[0].Enabled = true;
                            this.optDegKin[1].Enabled = true;
                        }
                        else
                        {
                            this.optSorption[0].Enabled = false;
                            this.optSorption[1].Enabled = false;
                            this.optDegKin[0].Enabled = false;
                            this.optDegKin[1].Enabled = false;
                        }
                        break;
                    }
                }
            }
        }

        private void Option6_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                GlobalVariables.icycle = (short) (this.Option6.GetIndex((RadioButton) eventSender) - 1);
            }
        }

        private void Option7_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                GlobalVariables.sw_irrigate = (MACROConstants.Switch) this.Option7.GetIndex((RadioButton) eventSender);
            }
        }

        private void Option8_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                GlobalVariables.sw_massunits = (MACROConstants.Switch) (this.Option8.GetIndex((RadioButton) eventSender) + 1);
            }
        }

        private void optManagement_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                if (this.optManagement.GetIndex((RadioButton) eventSender) == 1)
                {
                    this.chkCrust.Enabled = true;
                }
                else
                {
                    this.chkCrust.CheckState = CheckState.Unchecked;
                    this.chkCrust.Enabled = false;
                }
            }
        }

        private void optSorption_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing && Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                GlobalVariables.sw_kinetic = (MACROConstants.Switch) this.optSorption.GetIndex((RadioButton) eventSender);
                bool flag = GlobalVariables.sw_kinetic == MACROConstants.Switch.BareSoil;
                this.optDegKin[0].Enabled = flag;
                this.optDegKin[1].Enabled = flag;
                this.optDegKin[0].Checked = true;
                this.optDegKin[1].Checked = false;
                GlobalVariables.sw_degkin = MACROConstants.Switch.NoMetabolite;
            }
        }

        private void SelectOutputForMetabolite()
        {
            short num;
            short num2;
            short num7;
            if (GlobalVariables.sw_metabolite != MACROConstants.Switch.BareSoil)
            {
                num = this.FindIndex(ref "DEGMAC");
                GlobalVariables.LayOutputs[num, 3] = 0;
                GlobalVariables.LayOutputs[num, 4] = 1;
                short num5 = (short) Information.UBound(GlobalVariables.LayOutputs, 2);
                num2 = 5;
                while (true)
                {
                    num7 = num5;
                    if (num2 > num7)
                    {
                        num = this.FindIndex(ref "DEGMIC");
                        GlobalVariables.LayOutputs[num, 3] = 0;
                        GlobalVariables.LayOutputs[num, 4] = 1;
                        short num6 = (short) Information.UBound(GlobalVariables.LayOutputs, 2);
                        num2 = 5;
                        while (true)
                        {
                            num7 = num6;
                            if (num2 > num7)
                            {
                                break;
                            }
                            GlobalVariables.LayOutputs[num, num2] = 0;
                            num2 = (short) (num2 + 1);
                        }
                        break;
                    }
                    GlobalVariables.LayOutputs[num, num2] = 0;
                    num2 = (short) (num2 + 1);
                }
            }
            else
            {
                this.UnselectAll();
                num = this.FindIndex(ref "DEGMIC");
                GlobalVariables.LayOutputs[num, 3] = 1;
                GlobalVariables.LayOutputs[num, 4] = -1;
                short num3 = (short) (GlobalVariables.N_NUMERICAL_LAYERS + 4);
                num2 = 5;
                while (true)
                {
                    num7 = num3;
                    if (num2 > num7)
                    {
                        num = this.FindIndex(ref "DEGMAC");
                        GlobalVariables.LayOutputs[num, 3] = 1;
                        GlobalVariables.LayOutputs[num, 4] = -1;
                        short num4 = (short) (GlobalVariables.N_NUMERICAL_LAYERS + 4);
                        num2 = 5;
                        while (true)
                        {
                            num7 = num4;
                            if (num2 > num7)
                            {
                                break;
                            }
                            GlobalVariables.LayOutputs[num, num2] = 1;
                            num2 = (short) (num2 + 1);
                        }
                        break;
                    }
                    GlobalVariables.LayOutputs[num, num2] = 1;
                    num2 = (short) (num2 + 1);
                }
            }
        }

        private void SelectTOXSWAoutput()
        {
            this.UnselectAll();
            short num = GlobalVariables.NUM_OUTPX1;
            this.i = 1;
            while (true)
            {
                short num5 = num;
                if (this.i > num5)
                {
                    short num2 = GlobalVariables.NUM_OUTPT1;
                    this.i = 1;
                    while (true)
                    {
                        num5 = num2;
                        if (this.i > num5)
                        {
                            short num3 = GlobalVariables.NUM_OUTPD1;
                            this.i = 1;
                            while (true)
                            {
                                num5 = num3;
                                if (this.i > num5)
                                {
                                    short num4 = GlobalVariables.NUM_OUTPG1;
                                    this.i = 1;
                                    while (true)
                                    {
                                        num5 = num4;
                                        if (this.i > num5)
                                        {
                                            return;
                                        }
                                        if (GlobalVariables.outpg1[this.i].var == "DSOLTOSS")
                                        {
                                            GlobalVariables.outpg1[this.i].sl = 1;
                                            GlobalVariables.outpg1[this.i].enabled = -1;
                                        }
                                        if (GlobalVariables.outpg1[this.i].var == "SSEEP")
                                        {
                                            GlobalVariables.outpg1[this.i].sl = 1;
                                            GlobalVariables.outpg1[this.i].enabled = -1;
                                        }
                                        this.i = (short) (this.i + 1);
                                    }
                                }
                                if (GlobalVariables.outpd1[this.i].var == "DSOLTOSS")
                                {
                                    GlobalVariables.outpd1[this.i].sl = 1;
                                    GlobalVariables.outpd1[this.i].enabled = -1;
                                }
                                if (GlobalVariables.outpd1[this.i].var == "SSEEP")
                                {
                                    GlobalVariables.outpd1[this.i].sl = 1;
                                    GlobalVariables.outpd1[this.i].enabled = -1;
                                }
                                this.i = (short) (this.i + 1);
                            }
                        }
                        if (GlobalVariables.outpt1[this.i].var == "DSOLTOSS")
                        {
                            GlobalVariables.outpt1[this.i].sl = 1;
                            GlobalVariables.outpt1[this.i].enabled = -1;
                        }
                        if (GlobalVariables.outpt1[this.i].var == "SSEEP")
                        {
                            GlobalVariables.outpt1[this.i].sl = 1;
                            GlobalVariables.outpt1[this.i].enabled = -1;
                        }
                        this.i = (short) (this.i + 1);
                    }
                }
                if ((GlobalVariables.outpx1[this.i].var == "DSOLTOSS") | (GlobalVariables.outpx1[this.i].var == "SSEEP"))
                {
                    GlobalVariables.outpx1[this.i].sl = 1;
                    GlobalVariables.outpx1[this.i].enabled = -1;
                }
                this.i = (short) (this.i + 1);
            }
        }

        private void UnselectAll()
        {
            short num9;
            short num3 = (short) Information.UBound(GlobalVariables.LayOutputs, 1);
            short index = 1;
            while (index <= num3)
            {
                GlobalVariables.LayOutputs[index, 3] = 0;
                short num4 = GlobalVariables.N_NUMERICAL_LAYERS;
                short num2 = 5;
                while (true)
                {
                    num9 = num4;
                    if (num2 > num9)
                    {
                        index = (short) (index + 1);
                        break;
                    }
                    GlobalVariables.LayOutputs[index, num2] = 0;
                    num2 = (short) (num2 + 1);
                }
            }
            short num5 = GlobalVariables.NUM_OUTPX1;
            index = 1;
            while (true)
            {
                num9 = num5;
                if (index > num9)
                {
                    short num6 = GlobalVariables.NUM_OUTPT1;
                    index = 1;
                    while (true)
                    {
                        num9 = num6;
                        if (index > num9)
                        {
                            short num7 = GlobalVariables.NUM_OUTPD1;
                            index = 1;
                            while (true)
                            {
                                num9 = num7;
                                if (index > num9)
                                {
                                    short num8 = GlobalVariables.NUM_OUTPG1;
                                    index = 1;
                                    while (true)
                                    {
                                        num9 = num8;
                                        if (index > num9)
                                        {
                                            return;
                                        }
                                        GlobalVariables.outpg1[index].sl = 0;
                                        index = (short) (index + 1);
                                    }
                                }
                                GlobalVariables.outpd1[index].sl = 0;
                                index = (short) (index + 1);
                            }
                        }
                        GlobalVariables.outpt1[index].sl = 0;
                        index = (short) (index + 1);
                    }
                }
                GlobalVariables.outpx1[index].sl = 0;
                index = (short) (index + 1);
            }
        }

        public virtual Button Command1
        {
            [DebuggerNonUserCode]
            get => 
                this._Command1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command1_Click);
                if (!ReferenceEquals(this._Command1, null))
                {
                    this._Command1.Click -= handler;
                }
                this._Command1 = value;
                if (!ReferenceEquals(this._Command1, null))
                {
                    this._Command1.Click += handler;
                }
            }
        }

        public virtual CheckBox chkTempIni
        {
            [DebuggerNonUserCode]
            get => 
                this._chkTempIni;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkTempIni = value;
        }

        public virtual RadioButton _Option1_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option1_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option1_0 = value;
        }

        public virtual RadioButton _Option1_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option1_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option1_1 = value;
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

        public virtual CheckBox chkVarTension
        {
            [DebuggerNonUserCode]
            get => 
                this._chkVarTension;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkVarTension = value;
        }

        public virtual RadioButton _Option2_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option2_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option2_4 = value;
        }

        public virtual RadioButton _Option2_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option2_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option2_3 = value;
        }

        public virtual RadioButton _Option2_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option2_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option2_2 = value;
        }

        public virtual RadioButton _Option2_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option2_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option2_1 = value;
        }

        public virtual RadioButton _Option2_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option2_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option2_0 = value;
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

        public virtual CheckBox chkCrust
        {
            [DebuggerNonUserCode]
            get => 
                this._chkCrust;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkCrust = value;
        }

        public virtual RadioButton _optManagement_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optManagement_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optManagement_0 = value;
        }

        public virtual RadioButton _optManagement_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optManagement_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optManagement_1 = value;
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

        public virtual RadioButton _Option7_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option7_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option7_0 = value;
        }

        public virtual RadioButton _Option7_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option7_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option7_1 = value;
        }

        public virtual GroupBox Frame7
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame7 = value;
        }

        public virtual RadioButton _Option3_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option3_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option3_0 = value;
        }

        public virtual RadioButton _Option3_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option3_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option3_1 = value;
        }

        public virtual GroupBox Frame14
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame14;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame14 = value;
        }

        public virtual RadioButton _Option6_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option6_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option6_5 = value;
        }

        public virtual RadioButton _Option6_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option6_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option6_6 = value;
        }

        public virtual RadioButton _Option6_7
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option6_7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option6_7 = value;
        }

        public virtual RadioButton _Option6_8
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option6_8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option6_8 = value;
        }

        public virtual RadioButton _Option6_9
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option6_9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option6_9 = value;
        }

        public virtual GroupBox Frame11
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame11 = value;
        }

        public virtual RadioButton _Option4_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option4_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option4_0 = value;
        }

        public virtual RadioButton _Option4_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option4_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option4_1 = value;
        }

        public virtual RadioButton _Option4_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option4_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option4_2 = value;
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

        public virtual CheckBox Check1
        {
            [DebuggerNonUserCode]
            get => 
                this._Check1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Check1 = value;
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

        public virtual GroupBox Frame10
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame10 = value;
        }

        public virtual RadioButton _Option8_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option8_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this._Option8_0_CheckedChanged);
                if (!ReferenceEquals(this.__Option8_0, null))
                {
                    this.__Option8_0.CheckedChanged -= handler;
                }
                this.__Option8_0 = value;
                if (!ReferenceEquals(this.__Option8_0, null))
                {
                    this.__Option8_0.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButton _Option8_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option8_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option8_1 = value;
        }

        public virtual RadioButton _Option8_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option8_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option8_2 = value;
        }

        public virtual RadioButton _Option8_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option8_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option8_3 = value;
        }

        public virtual GroupBox Frame9
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame9 = value;
        }

        public virtual RadioButton _Option5_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option5_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option5_0 = value;
        }

        public virtual RadioButton _Option5_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option5_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option5_1 = value;
        }

        public virtual RadioButton _Option5_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option5_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option5_2 = value;
        }

        public virtual RadioButton _Option5_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option5_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option5_3 = value;
        }

        public virtual RadioButton _Option5_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option5_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option5_4 = value;
        }

        public virtual RadioButton _Option5_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option5_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option5_5 = value;
        }

        public virtual RadioButton _Option5_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__Option5_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Option5_6 = value;
        }

        public virtual GroupBox Frame5
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame5 = value;
        }

        public virtual RadioButton _optDegKin_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optDegKin_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optDegKin_1 = value;
        }

        public virtual RadioButton _optDegKin_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optDegKin_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optDegKin_0 = value;
        }

        public virtual GroupBox Frame8
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame8 = value;
        }

        public virtual RadioButton _optSorption_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optSorption_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optSorption_1 = value;
        }

        public virtual RadioButton _optSorption_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optSorption_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optSorption_0 = value;
        }

        public virtual GroupBox Frame6
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame6 = value;
        }

        public virtual RadioButtonArray Option1
        {
            [DebuggerNonUserCode]
            get => 
                this._Option1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Option1_CheckedChanged);
                if (!ReferenceEquals(this._Option1, null))
                {
                    this._Option1.CheckedChanged -= handler;
                }
                this._Option1 = value;
                if (!ReferenceEquals(this._Option1, null))
                {
                    this._Option1.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray Option2
        {
            [DebuggerNonUserCode]
            get => 
                this._Option2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Option2_CheckedChanged);
                if (!ReferenceEquals(this._Option2, null))
                {
                    this._Option2.CheckedChanged -= handler;
                }
                this._Option2 = value;
                if (!ReferenceEquals(this._Option2, null))
                {
                    this._Option2.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray Option3
        {
            [DebuggerNonUserCode]
            get => 
                this._Option3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Option3_CheckedChanged);
                if (!ReferenceEquals(this._Option3, null))
                {
                    this._Option3.CheckedChanged -= handler;
                }
                this._Option3 = value;
                if (!ReferenceEquals(this._Option3, null))
                {
                    this._Option3.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray Option4
        {
            [DebuggerNonUserCode]
            get => 
                this._Option4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Option4_CheckedChanged);
                if (!ReferenceEquals(this._Option4, null))
                {
                    this._Option4.CheckedChanged -= handler;
                }
                this._Option4 = value;
                if (!ReferenceEquals(this._Option4, null))
                {
                    this._Option4.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray Option5
        {
            [DebuggerNonUserCode]
            get => 
                this._Option5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Option5_CheckedChanged);
                if (!ReferenceEquals(this._Option5, null))
                {
                    this._Option5.CheckedChanged -= handler;
                }
                this._Option5 = value;
                if (!ReferenceEquals(this._Option5, null))
                {
                    this._Option5.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray Option6
        {
            [DebuggerNonUserCode]
            get => 
                this._Option6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Option6_CheckedChanged);
                if (!ReferenceEquals(this._Option6, null))
                {
                    this._Option6.CheckedChanged -= handler;
                }
                this._Option6 = value;
                if (!ReferenceEquals(this._Option6, null))
                {
                    this._Option6.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray Option7
        {
            [DebuggerNonUserCode]
            get => 
                this._Option7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Option7_CheckedChanged);
                if (!ReferenceEquals(this._Option7, null))
                {
                    this._Option7.CheckedChanged -= handler;
                }
                this._Option7 = value;
                if (!ReferenceEquals(this._Option7, null))
                {
                    this._Option7.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray Option8
        {
            [DebuggerNonUserCode]
            get => 
                this._Option8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Option8_CheckedChanged);
                if (!ReferenceEquals(this._Option8, null))
                {
                    this._Option8.CheckedChanged -= handler;
                }
                this._Option8 = value;
                if (!ReferenceEquals(this._Option8, null))
                {
                    this._Option8.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray optDegKin
        {
            [DebuggerNonUserCode]
            get => 
                this._optDegKin;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optDegKin_CheckedChanged);
                if (!ReferenceEquals(this._optDegKin, null))
                {
                    this._optDegKin.CheckedChanged -= handler;
                }
                this._optDegKin = value;
                if (!ReferenceEquals(this._optDegKin, null))
                {
                    this._optDegKin.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray optManagement
        {
            [DebuggerNonUserCode]
            get => 
                this._optManagement;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optManagement_CheckedChanged);
                if (!ReferenceEquals(this._optManagement, null))
                {
                    this._optManagement.CheckedChanged -= handler;
                }
                this._optManagement = value;
                if (!ReferenceEquals(this._optManagement, null))
                {
                    this._optManagement.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray optSorption
        {
            [DebuggerNonUserCode]
            get => 
                this._optSorption;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optSorption_CheckedChanged);
                if (!ReferenceEquals(this._optSorption, null))
                {
                    this._optSorption.CheckedChanged -= handler;
                }
                this._optSorption = value;
                if (!ReferenceEquals(this._optSorption, null))
                {
                    this._optSorption.CheckedChanged += handler;
                }
            }
        }

        internal virtual TabControl TabControl1
        {
            [DebuggerNonUserCode]
            get => 
                this._TabControl1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._TabControl1 = value;
        }

        internal virtual TabPage TabPage1
        {
            [DebuggerNonUserCode]
            get => 
                this._TabPage1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._TabPage1 = value;
        }

        internal virtual TabPage TabPage2
        {
            [DebuggerNonUserCode]
            get => 
                this._TabPage2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._TabPage2 = value;
        }

        internal virtual TabPage TabPage4
        {
            [DebuggerNonUserCode]
            get => 
                this._TabPage4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._TabPage4 = value;
        }

        internal virtual ToolTip ToolTip1
        {
            [DebuggerNonUserCode]
            get => 
                this._ToolTip1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._ToolTip1 = value;
        }

        internal virtual CheckBox chkTOXSWA
        {
            [DebuggerNonUserCode]
            get => 
                this._chkTOXSWA;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkTOXSWA = value;
        }
    }
}

