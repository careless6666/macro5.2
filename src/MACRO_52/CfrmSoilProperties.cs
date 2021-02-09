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
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class CfrmSoilProperties : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("lblCurHor")]
        private Label _lblCurHor;
        [AccessedThroughProperty("_lblHelpExists_0")]
        private Label __lblHelpExists_0;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("cmdExit")]
        private Button _cmdExit;
        [AccessedThroughProperty("txtProfileName")]
        private TextBox _txtProfileName;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("txtLocation")]
        private TextBox _txtLocation;
        [AccessedThroughProperty("txtMaxNumLayers")]
        private TextBox _txtMaxNumLayers;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("_Label11_0")]
        private Label __Label11_0;
        [AccessedThroughProperty("UpDown1")]
        private NumericUpDown _UpDown1;
        [AccessedThroughProperty("txtAddBefore")]
        private TextBox _txtAddBefore;
        [AccessedThroughProperty("_lblHelpExists_2")]
        private Label __lblHelpExists_2;
        [AccessedThroughProperty("chkAddBefore")]
        private CheckBox _chkAddBefore;
        [AccessedThroughProperty("grdData")]
        private AxMSFlexGrid _grdData;
        [AccessedThroughProperty("GroupBox2")]
        private GroupBox _GroupBox2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("txtBox")]
        private TextBox _txtBox;
        [AccessedThroughProperty("cmbStructure")]
        private ComboBox _cmbStructure;
        [AccessedThroughProperty("cmbShape")]
        private ComboBox _cmbShape;
        [AccessedThroughProperty("cmbStrength")]
        private ComboBox _cmbStrength;
        [AccessedThroughProperty("cmbDesignations")]
        private ComboBox _cmbDesignations;
        public bool SoilDefined;
        public Collection Horizons;
        private bool IsDisplaying;
        private short CurHorizon;
        private short id;
        private bool Saving;
        private bool Selecting;
        private Control ThisControl;
        private bool m_bNoCopy;
        private Recordset rec;
        public bool Editing;
        public bool OrigExpAss;
        public short CurCol;
        public short CurRow;
        public bool bOptionChange;
        private bool bLoading;
        private float m_PThickness;
        private float[] m_HThickness;
        private CfrmMain frmMain;
        private ToolTip m_tooltip;

        public CfrmSoilProperties(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmDefineSoil_Load);
            base.FormClosed += new FormClosedEventHandler(this.frmDefineSoil_FormClosed);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.Horizons = new Collection();
            this.m_tooltip = new ToolTip();
            this.InitializeComponent();
            this.frmMain = frm;
            this.bLoading = true;
            this.Icon = this.frmMain.Icon;
            this.SoilDefined = false;
            this.Selecting = false;
            this.SetupTable();
            this.CurHorizon = 1;
            this.InitForm();
            this.lblCurHor.Text = Conversions.ToString((int) this.CurHorizon);
            this.UpDown1.Minimum = 1M;
            this.UpDown1.Maximum = new decimal((long) 10);
            this.m_tooltip.AutoPopDelay = 0x1388;
            this.m_tooltip.InitialDelay = 0x3e8;
            this.m_tooltip.ReshowDelay = 500;
            this.m_tooltip.ToolTipIcon = ToolTipIcon.Info;
        }

        private void AddHorizon()
        {
            Horizon item = new Horizon();
            item.Init();
            this.Horizons.Add(item, null, null, null);
        }

        public void AddHorizons()
        {
            int nhorizon = GlobalVariables.Nhorizon;
            int num = 1;
            while (true)
            {
                int num3 = nhorizon;
                if (num > num3)
                {
                    return;
                }
                this.UpDown1.Value = new decimal(num);
                num++;
            }
        }

        private void CalculateThickness()
        {
            CfrmSoilProperties properties = this;
            this.m_PThickness = 0f;
            this.m_HThickness = new float[(properties.grdData.Rows - 1) + 1];
            short num2 = (short) (properties.grdData.Rows - 1);
            short row = 1;
            while (true)
            {
                short num3 = num2;
                if (row > num3)
                {
                    properties = null;
                    return;
                }
                this.m_PThickness += (float) Conversions.ToDouble(properties.grdData.get_TextMatrix(row, 7));
                this.m_HThickness[row] = Conversions.ToSingle(properties.grdData.get_TextMatrix(row, 7));
                row = (short) (row + 1);
            }
        }

        public bool CheckSoilData()
        {
            bool flag = true;
            this.grdData.Col = 1;
            this.grdData.Col = 2;
            this.Saving = true;
            if (Conversions.ToDouble(this.txtMaxNumLayers.Text) > 200.0)
            {
                MiscFUncs.MsgBox_Renamed("Maximum " + Conversions.ToString(200) + " numerical layers is allowed.", 0x30, "Error");
                flag = false;
            }
            else if (Conversions.ToDouble(this.txtMaxNumLayers.Text) < 60.0)
            {
                MiscFUncs.MsgBox_Renamed("Minimum " + Conversions.ToString(60) + " numerical layers is allowed.", 0x30, "Error");
                flag = false;
            }
            else
            {
                short count = (short) this.Horizons.Count;
                short num = 1;
                while (true)
                {
                    short num7 = count;
                    if (num > num7)
                    {
                        short num5 = Convert.ToInt16(this.UpDown1.Value);
                        num = 1;
                        while (true)
                        {
                            num7 = num5;
                            if (num > num7)
                            {
                                short num6 = (short) this.Horizons.Count;
                                num = 1;
                                while (true)
                                {
                                    float num2;
                                    num7 = num6;
                                    if (num > num7)
                                    {
                                        this.SoilDefined = flag;
                                        break;
                                    }
                                    this.grdData.Row = num;
                                    int num3 = 0;
                                    object instance = this.Horizons[num];
                                    this.grdData.Col = 0;
                                    object[] arguments = new object[] { this.grdData.Text };
                                    NewLateBinding.LateSetComplex(instance, null, "Designation", arguments, null, null, false, true);
                                    this.grdData.Col = 1;
                                    if (!Versioned.IsNumeric(this.grdData.Text))
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        arguments = new object[] { Conversions.ToSingle(Support.Format(this.grdData.Text, "##.####0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) };
                                        NewLateBinding.LateSetComplex(instance, null, "clay", arguments, null, null, false, true);
                                        num3 = (int) Math.Round((double) (num3 + (Conversions.ToSingle(Support.Format(this.grdData.Text, "##.####0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) * 10000f)));
                                    }
                                    this.grdData.Col = 2;
                                    if (!Versioned.IsNumeric(this.grdData.Text))
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        arguments = new object[] { Conversions.ToSingle(Support.Format(this.grdData.Text, "##.####0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) };
                                        NewLateBinding.LateSetComplex(instance, null, "silt", arguments, null, null, false, true);
                                        num3 = (int) Math.Round((double) (num3 + (Conversions.ToSingle(Support.Format(this.grdData.Text, "##.####0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) * 10000f)));
                                    }
                                    this.grdData.Col = 3;
                                    if (!Versioned.IsNumeric(this.grdData.Text))
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        arguments = new object[] { Conversions.ToSingle(Support.Format(this.grdData.Text, "##.####0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) };
                                        NewLateBinding.LateSetComplex(instance, null, "sand", arguments, null, null, false, true);
                                        num3 = (int) Math.Round((double) (num3 + (Conversions.ToSingle(Support.Format(this.grdData.Text, "##.####0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) * 10000f)));
                                    }
                                    this.grdData.Col = 4;
                                    if (!Versioned.IsNumeric(this.grdData.Text))
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        arguments = new object[] { this.grdData.Text };
                                        NewLateBinding.LateSetComplex(instance, null, "bd", arguments, null, null, false, true);
                                    }
                                    this.grdData.Col = 5;
                                    if (!Versioned.IsNumeric(this.grdData.Text))
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        arguments = new object[] { this.grdData.Text };
                                        NewLateBinding.LateSetComplex(instance, null, "oc", arguments, null, null, false, true);
                                    }
                                    this.grdData.Col = 6;
                                    if (!Versioned.IsNumeric(this.grdData.Text))
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        arguments = new object[] { this.grdData.Text };
                                        NewLateBinding.LateSetComplex(instance, null, "th", arguments, null, null, false, true);
                                    }
                                    num2 = Conversions.ToSingle(Operators.AddObject(num2, NewLateBinding.LateGet(instance, null, "th", new object[0], null, null, null)));
                                    this.grdData.Col = 7;
                                    arguments = new object[] { this.grdData.Text };
                                    NewLateBinding.LateSetComplex(instance, null, "Texture", arguments, null, null, false, true);
                                    this.grdData.Col = 8;
                                    arguments = new object[] { 0, this.grdData.Text };
                                    NewLateBinding.LateSetComplex(instance, null, "struct", arguments, null, null, false, true);
                                    this.grdData.Col = 9;
                                    arguments = new object[] { 1, this.grdData.Text };
                                    NewLateBinding.LateSetComplex(instance, null, "struct", arguments, null, null, false, true);
                                    this.grdData.Col = 10;
                                    arguments = new object[] { 2, this.grdData.Text };
                                    NewLateBinding.LateSetComplex(instance, null, "struct", arguments, null, null, false, true);
                                    this.grdData.Col = 11;
                                    instance = null;
                                    if (num3 != 0xf4240)
                                    {
                                        MiscFUncs.MsgBox_Renamed("Percentage of silt, sand, clay for horizon " + Conversions.ToString((int) num) + " does not add up to 100% (currently " + Conversions.ToString((double) (((double) num3) / 10000.0)) + "%).", 0x30, "Error");
                                        flag = false;
                                    }
                                    num = (short) (num + 1);
                                }
                                break;
                            }
                            this.AddHorizon();
                            num = (short) (num + 1);
                        }
                        break;
                    }
                    this.Horizons.Remove(1);
                    num = (short) (num + 1);
                }
            }
            return flag;
        }

        private void ClearStructureCombos()
        {
            this.grdData.Col++;
            this.grdData.Text = "";
            this.grdData.Col++;
            this.grdData.Text = "";
            this.grdData.Col -= 2;
        }

        private void cmbDesignations_LostFocus(object sender, EventArgs e)
        {
            this.cmbDesignations.Visible = false;
        }

        private void cmbDesignations_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.grdData.Text = this.cmbDesignations.Text;
            ComboBox cmbDesignations = this.cmbDesignations;
            this.HideCombo(ref cmbDesignations);
            this.cmbDesignations = cmbDesignations;
            this.grdData.Focus();
        }

        private void cmbShape_LostFocus(object sender, EventArgs e)
        {
            this.cmbShape.Visible = false;
        }

        private void cmbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.grdData.Text = this.cmbShape.Text;
            ComboBox cmbShape = this.cmbShape;
            this.HideCombo(ref cmbShape);
            this.cmbShape = cmbShape;
            this.grdData.Focus();
        }

        private void cmbStrength_LostFocus(object sender, EventArgs e)
        {
            this.cmbStrength.Visible = false;
        }

        private void cmbStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.grdData.Text = this.cmbStrength.Text;
            ComboBox cmbStrength = this.cmbStrength;
            this.HideCombo(ref cmbStrength);
            this.cmbStrength = cmbStrength;
            this.grdData.Focus();
        }

        private void cmbStructure_LostFocus(object sender, EventArgs e)
        {
            this.cmbStructure.Visible = false;
        }

        private void cmdExit_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        public void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            this.DefineSoilProperties();
        }

        private void cmdStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Selecting)
            {
                if (this.cmbStructure.SelectedIndex == 0)
                {
                    this.ClearStructureCombos();
                }
                this.grdData.Text = this.cmbStructure.Text;
                ComboBox cmbStructure = this.cmbStructure;
                this.HideCombo(ref cmbStructure);
                this.cmbStructure = cmbStructure;
                this.grdData.Focus();
            }
        }

        private bool CompareThickness()
        {
            CfrmSoilProperties properties = this;
            if (Information.UBound(this.m_HThickness, 1) == (properties.grdData.Rows - 1))
            {
                short num2 = (short) (properties.grdData.Rows - 1);
                short row = 1;
                while (true)
                {
                    short num3 = num2;
                    if (row > num3)
                    {
                        if (this.m_PThickness == 0f)
                        {
                            properties = null;
                        }
                    }
                    else
                    {
                        this.m_PThickness -= (float) Conversions.ToDouble(properties.grdData.get_TextMatrix(row, 7));
                        this.m_HThickness[row] -= (float) Conversions.ToDouble(properties.grdData.get_TextMatrix(row, 7));
                        if (this.m_HThickness[row] == 0f)
                        {
                            row = (short) (row + 1);
                            continue;
                        }
                    }
                    break;
                }
            }
            return true;
        }

        private void CopyLast()
        {
            short num;
            short num9;
            short num3 = (short) (this.grdData.Rows - 2);
            short row = (short) (this.grdData.Rows - 2);
            while (row <= num3)
            {
                short num4 = (short) (this.grdData.Cols - 1);
                num = 0;
                while (true)
                {
                    num9 = num4;
                    if (num > num9)
                    {
                        row = (short) (row + 1);
                        break;
                    }
                    this.grdData.set_TextMatrix(row + 1, num, this.grdData.get_TextMatrix(row, num));
                    num = (short) (num + 1);
                }
            }
            AxMSFlexGrid grid = this.frmMain.frmParameters._flx_Parameters_4;
            grid.Rows = this.grdData.Rows;
            short num5 = (short) (grid.Rows - 2);
            row = (short) (grid.Rows - 2);
            while (row <= num5)
            {
                short num6 = (short) (grid.Cols - 1);
                num = 0;
                while (true)
                {
                    num9 = num6;
                    if (num > num9)
                    {
                        row = (short) (row + 1);
                        break;
                    }
                    grid.set_TextMatrix(row + 1, num, grid.get_TextMatrix(row, num));
                    num = (short) (num + 1);
                }
            }
            grid = null;
            AxMSFlexGrid grid2 = this.frmMain.frmParameters._flx_Parameters_5;
            grid2.Rows = this.grdData.Rows;
            short num7 = (short) (grid2.Rows - 2);
            row = (short) (grid2.Rows - 2);
            while (row <= num7)
            {
                short num8 = (short) (grid2.Cols - 1);
                num = 0;
                while (true)
                {
                    num9 = num8;
                    if (num > num9)
                    {
                        row = (short) (row + 1);
                        break;
                    }
                    grid2.set_TextMatrix(row + 1, num, grid2.get_TextMatrix(row, num));
                    num = (short) (num + 1);
                }
            }
            grid2 = null;
        }

        public void DefineSoilProperties()
        {
            if (!this.CheckSoilData())
            {
                MiscFUncs.MsgBox_Renamed("Error in soildata, please check.", 0x30, "Error");
            }
            else
            {
                ChecksAndAssignments.AssignSoilValues(ref this.frmMain, ref true, ref !this.CompareThickness());
                GlobalVariables.profilnamn = Strings.Left(this.txtProfileName.Text, 20);
                if (!this.bOptionChange)
                {
                    this.Hide();
                }
                GlobalVariables.LayOutputs = (object[,]) Utils.CopyArray((Array) GlobalVariables.LayOutputs, new object[Information.UBound(GlobalVariables.LayOutputs, 1) + 1, ((int) Math.Round((double) (Conversions.ToDouble(this.txtMaxNumLayers.Text) + 4.0))) + 1]);
                if (!this.bOptionChange)
                {
                    this.Close();
                }
            }
        }

        public void DisplayHorizons()
        {
            AxMSFlexGrid grdData = this.grdData;
            this.m_bNoCopy = true;
            this.AddHorizons();
            short nhorizon = GlobalVariables.Nhorizon;
            short index = 1;
            while (true)
            {
                short num4 = nhorizon;
                if (index > num4)
                {
                    this.m_bNoCopy = false;
                    grdData = null;
                    return;
                }
                grdData.Row = index;
                grdData.Col = 0;
                grdData.Text = GlobalVariables.designat[index];
                grdData.Col = 1;
                grdData.Text = Conversions.ToString(GlobalVariables.clay[index]);
                grdData.Col = 2;
                grdData.Text = Conversions.ToString(GlobalVariables.silt[index]);
                grdData.Col = 3;
                grdData.Text = Conversions.ToString(GlobalVariables.sand[index]);
                grdData.Col = 4;
                grdData.Text = Conversions.ToString(GlobalVariables.pH[index]);
                grdData.Col = 5;
                grdData.Text = Conversions.ToString(GlobalVariables.bulk[index]);
                grdData.Col = 6;
                grdData.Text = Conversions.ToString(GlobalVariables.orgc[index]);
                grdData.Col = 7;
                grdData.Text = Conversions.ToString(GlobalVariables.Hthick[index]);
                grdData.Col = 8;
                grdData.Text = GlobalVariables.Texture[index];
                grdData.Col = 9;
                if ((GlobalVariables.structur[index] == "none") | (Strings.Len(Strings.Trim(GlobalVariables.structur[index])) == 0))
                {
                    grdData.Text = "none";
                }
                else
                {
                    string str = GlobalVariables.structur[index];
                    int start = Strings.InStr(1, str, " ", CompareMethod.Text);
                    grdData.Text = Strings.Mid(str, start, Strings.InStr(start + 1, str, " ", CompareMethod.Binary) - start);
                    grdData.Col++;
                    grdData.Text = Strings.Left(str, start - 1);
                    grdData.Col++;
                    grdData.Text = Strings.Right(str, Strings.Len(str) - Strings.InStr(start + 1, str, " ", CompareMethod.Binary));
                    start = 1;
                }
                index = (short) (index + 1);
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

        private void frmDefineSoil_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            short count = (short) this.Horizons.Count;
            short num = 1;
            while (true)
            {
                short num3 = count;
                if (num > num3)
                {
                    return;
                }
                this.Horizons.Remove(1);
                num = (short) (num + 1);
            }
        }

        private void frmDefineSoil_Load(object eventSender, EventArgs eventArgs)
        {
            this.txtProfileName.Text = GlobalVariables.profilnamn;
            this.txtMaxNumLayers.Text = Conversions.ToString((int) GlobalVariables.N_NUMERICAL_LAYERS);
            this.bLoading = true;
            this.DisplayHorizons();
            this.CalculateThickness();
            this.bLoading = false;
            this.bLoading = false;
        }

        private void grdData_KeyPressEvent(object eventSender, DMSFlexGridEvents_KeyPressEvent eventArgs)
        {
            if (((this.grdData.Col < 9) & (this.grdData.Row > 0)) & (this.grdData.Col > 0))
            {
                if (this.grdData.Col != 8)
                {
                    this.txtBox.Text = Conversions.ToString(Strings.Chr(eventArgs.keyAscii));
                    this.ShowTextBox(ref Conversions.ToString(Strings.Chr(eventArgs.keyAscii)));
                }
            }
            else if (this.grdData.Row > 0)
            {
                ComboBox cmbStructure;
                if ((this.grdData.Col - 9) == 0)
                {
                    cmbStructure = this.cmbStructure;
                    this.ShowCombo(ref cmbStructure);
                    this.cmbStructure = cmbStructure;
                }
                else if ((this.grdData.Col - 9) == 1)
                {
                    cmbStructure = this.cmbStrength;
                    this.ShowCombo(ref cmbStructure);
                    this.cmbStrength = cmbStructure;
                }
                else if (this.grdData.Col == 0)
                {
                    cmbStructure = this.cmbDesignations;
                    this.ShowCombo(ref cmbStructure);
                    this.cmbDesignations = cmbStructure;
                }
                else
                {
                    cmbStructure = this.cmbShape;
                    this.ShowCombo(ref cmbStructure);
                    this.cmbShape = cmbStructure;
                }
            }
        }

        private void grdData_MouseDownEvent(object sender, DMSFlexGridEvents_MouseDownEvent e)
        {
            if (this.grdData.get_RowIsVisible(this.grdData.Row))
            {
                ComboBox cmbDesignations;
                if (((this.grdData.Col < 9) & (this.grdData.Col >= this.grdData.FixedCols)) & (this.grdData.Row >= this.grdData.FixedRows))
                {
                    if (this.grdData.Col != 8)
                    {
                        if (this.grdData.Col > 0)
                        {
                            this.ShowTextBox(ref "");
                        }
                        else
                        {
                            cmbDesignations = this.cmbDesignations;
                            this.ShowCombo(ref cmbDesignations);
                            this.cmbDesignations = cmbDesignations;
                        }
                    }
                }
                else if ((this.grdData.Col >= this.grdData.FixedCols) & (this.grdData.Row >= this.grdData.FixedRows))
                {
                    if ((this.grdData.Col - 9) == 0)
                    {
                        cmbDesignations = this.cmbStructure;
                        this.ShowCombo(ref cmbDesignations);
                        this.cmbStructure = cmbDesignations;
                    }
                    else if (((this.grdData.Col - 9) == 1) & (this.cmbStructure.SelectedIndex != 0))
                    {
                        cmbDesignations = this.cmbStrength;
                        this.ShowCombo(ref cmbDesignations);
                        this.cmbStrength = cmbDesignations;
                    }
                    else if (this.cmbStructure.SelectedIndex != 0)
                    {
                        cmbDesignations = this.cmbShape;
                        this.ShowCombo(ref cmbDesignations);
                        this.cmbShape = cmbDesignations;
                    }
                }
            }
        }

        private void grdData_Scroll(object eventSender, EventArgs eventArgs)
        {
            if (this.txtBox.Visible)
            {
                this.MoveTextBox();
            }
            if (this.grdData.Col > 8)
            {
                ComboBox cmbStructure;
                if ((this.grdData.Col - 9) == 0)
                {
                    if (this.cmbStructure.Visible)
                    {
                        cmbStructure = this.cmbStructure;
                        this.MoveCombo(ref cmbStructure);
                        this.cmbStructure = cmbStructure;
                    }
                }
                else if ((this.grdData.Col - 9) == 1)
                {
                    if (this.cmbStrength.Visible)
                    {
                        cmbStructure = this.cmbStrength;
                        this.MoveCombo(ref cmbStructure);
                        this.cmbStrength = cmbStructure;
                    }
                }
                else if (this.cmbShape.Visible)
                {
                    cmbStructure = this.cmbShape;
                    this.MoveCombo(ref cmbStructure);
                    this.cmbShape = cmbStructure;
                }
            }
        }

        private void HideCombo(ref ComboBox cmb)
        {
            cmb.Visible = false;
            this.Selecting = false;
        }

        private void InitForm()
        {
            this.cmbStructure.SelectedIndex = 0;
            this.cmbStrength.SelectedIndex = 0;
            this.cmbShape.SelectedIndex = 0;
            this.UpDown1.Value = 1M;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmSoilProperties));
            this.lblCurHor = new Label();
            this._lblHelpExists_0 = new Label();
            this.Label2 = new Label();
            this.Label5 = new Label();
            this.Label6 = new Label();
            this.Label7 = new Label();
            this.Label8 = new Label();
            this.Label9 = new Label();
            this.Label16 = new Label();
            this.cmdExit = new Button();
            this.txtProfileName = new TextBox();
            this.cmdOK = new Button();
            this.txtLocation = new TextBox();
            this.txtMaxNumLayers = new TextBox();
            this.Label17 = new Label();
            this._Label11_0 = new Label();
            this.UpDown1 = new NumericUpDown();
            this.txtAddBefore = new TextBox();
            this._lblHelpExists_2 = new Label();
            this.chkAddBefore = new CheckBox();
            this.grdData = new AxMSFlexGrid();
            this.GroupBox2 = new GroupBox();
            this.cmbDesignations = new ComboBox();
            this.Label3 = new Label();
            this.Label12 = new Label();
            this.cmbShape = new ComboBox();
            this.cmbStrength = new ComboBox();
            this.cmbStructure = new ComboBox();
            this.txtBox = new TextBox();
            this.Label4 = new Label();
            this.Label1 = new Label();
            this.UpDown1.BeginInit();
            this.grdData.BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            this.lblCurHor.BackColor = SystemColors.Control;
            this.lblCurHor.Cursor = Cursors.Default;
            this.lblCurHor.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCurHor.ForeColor = SystemColors.ControlText;
            Point point = new Point(0x220, 80);
            this.lblCurHor.Location = point;
            this.lblCurHor.Name = "lblCurHor";
            this.lblCurHor.RightToLeft = RightToLeft.No;
            Size size = new Size(0x19, 0x19);
            this.lblCurHor.Size = size;
            this.lblCurHor.TabIndex = 1;
            this.lblCurHor.Text = "0";
            this.lblCurHor.Visible = false;
            this._lblHelpExists_0.BackColor = SystemColors.Control;
            this._lblHelpExists_0.Cursor = Cursors.Default;
            this._lblHelpExists_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelpExists_0.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10f);
            this._lblHelpExists_0.Location = point;
            this._lblHelpExists_0.Name = "_lblHelpExists_0";
            this._lblHelpExists_0.RightToLeft = RightToLeft.No;
            size = new Size(0x4c, 0x11);
            this._lblHelpExists_0.Size = size;
            this._lblHelpExists_0.TabIndex = 11;
            this._lblHelpExists_0.Text = "Profile name:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(0x121, 0x10f);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Location:";
            this.Label2.Visible = false;
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x124);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0xb1, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 0x1a;
            this.Label5.Text = "Number of numerical layers:";
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = SystemColors.ControlText;
            point = new Point(0xd7, 0x124);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0x9a, 0x11);
            this.Label6.Size = size;
            this.Label6.TabIndex = 0x1c;
            this.Label6.Text = "(between 60 and 200)";
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = Color.Red;
            point = new Point(8, 250);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 0x1d;
            this.Label7.Text = "Clay: < 2 ";
            this.Label8.BackColor = SystemColors.Control;
            this.Label8.Cursor = Cursors.Default;
            this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = Color.Red;
            point = new Point(80, 250);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label8.Size = size;
            this.Label8.TabIndex = 30;
            this.Label8.Text = "Silt: 2-50";
            this.Label9.BackColor = SystemColors.Control;
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = Color.Red;
            point = new Point(0x9f, 0xf9);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            size = new Size(0x56, 0x11);
            this.Label9.Size = size;
            this.Label9.TabIndex = 0x1f;
            this.Label9.Text = "Sand: 50-2000";
            this.Label16.BackColor = SystemColors.Control;
            this.Label16.Cursor = Cursors.Default;
            this.Label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label16.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x13c);
            this.Label16.Location = point;
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = RightToLeft.No;
            size = new Size(0x209, 0x11);
            this.Label16.Size = size;
            this.Label16.TabIndex = 40;
            this.Label16.Text = "Changing the number of numerical layers will affect the defined initial conditions and the selected outputs.";
            this.cmdExit.BackColor = SystemColors.Control;
            this.cmdExit.Cursor = Cursors.Default;
            this.cmdExit.DialogResult = DialogResult.Cancel;
            this.cmdExit.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdExit.ForeColor = SystemColors.ControlText;
            point = new Point(0x22c, 0x167);
            this.cmdExit.Location = point;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdExit.Size = size;
            this.cmdExit.TabIndex = 10;
            this.cmdExit.TabStop = false;
            this.cmdExit.Text = "Cancel";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.txtProfileName.AcceptsReturn = true;
            this.txtProfileName.BackColor = SystemColors.Window;
            this.txtProfileName.Cursor = Cursors.IBeam;
            this.txtProfileName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtProfileName.ForeColor = SystemColors.WindowText;
            point = new Point(90, 0x10d);
            this.txtProfileName.Location = point;
            this.txtProfileName.MaxLength = 0;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 20);
            this.txtProfileName.Size = size;
            this.txtProfileName.TabIndex = 12;
            this.txtProfileName.TabStop = false;
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.ForeColor = SystemColors.ControlText;
            point = new Point(0x273, 0x167);
            this.cmdOK.Location = point;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdOK.Size = size;
            this.cmdOK.TabIndex = 13;
            this.cmdOK.TabStop = false;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.txtLocation.AcceptsReturn = true;
            this.txtLocation.BackColor = SystemColors.Window;
            this.txtLocation.Cursor = Cursors.IBeam;
            this.txtLocation.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtLocation.ForeColor = SystemColors.WindowText;
            point = new Point(0x160, 0x10d);
            this.txtLocation.Location = point;
            this.txtLocation.MaxLength = 0;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 20);
            this.txtLocation.Size = size;
            this.txtLocation.TabIndex = 0x10;
            this.txtLocation.TabStop = false;
            this.txtLocation.Visible = false;
            this.txtMaxNumLayers.AcceptsReturn = true;
            this.txtMaxNumLayers.BackColor = SystemColors.Window;
            this.txtMaxNumLayers.Cursor = Cursors.IBeam;
            this.txtMaxNumLayers.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtMaxNumLayers.ForeColor = SystemColors.WindowText;
            point = new Point(160, 0x124);
            this.txtMaxNumLayers.Location = point;
            this.txtMaxNumLayers.MaxLength = 0;
            this.txtMaxNumLayers.Name = "txtMaxNumLayers";
            this.txtMaxNumLayers.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 20);
            this.txtMaxNumLayers.Size = size;
            this.txtMaxNumLayers.TabIndex = 0x1b;
            this.txtMaxNumLayers.TabStop = false;
            this.txtMaxNumLayers.Text = "60";
            this.Label17.BackColor = SystemColors.Control;
            this.Label17.Cursor = Cursors.Default;
            this.Label17.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 2);
            this.Label17.ForeColor = Color.Red;
            point = new Point(0xe9, 250);
            this.Label17.Location = point;
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.Label17.Size = size;
            this.Label17.TabIndex = 0x2b;
            this.Label17.Text = "m";
            this._Label11_0.BackColor = SystemColors.Control;
            this._Label11_0.Cursor = Cursors.Default;
            this._Label11_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._Label11_0.ForeColor = Color.Red;
            point = new Point(0xf3, 250);
            this._Label11_0.Location = point;
            this._Label11_0.Name = "_Label11_0";
            this._Label11_0.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this._Label11_0.Size = size;
            this._Label11_0.TabIndex = 0x21;
            this._Label11_0.Text = "m";
            point = new Point(0x7b, 20);
            this.UpDown1.Location = point;
            this.UpDown1.Name = "UpDown1";
            size = new Size(0x2e, 20);
            this.UpDown1.Size = size;
            this.UpDown1.TabIndex = 0x29;
            this.txtAddBefore.AcceptsReturn = true;
            this.txtAddBefore.BackColor = SystemColors.Window;
            this.txtAddBefore.Cursor = Cursors.IBeam;
            this.txtAddBefore.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtAddBefore.ForeColor = SystemColors.WindowText;
            point = new Point(0x1b3, 20);
            this.txtAddBefore.Location = point;
            this.txtAddBefore.MaxLength = 0;
            this.txtAddBefore.Name = "txtAddBefore";
            this.txtAddBefore.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 20);
            this.txtAddBefore.Size = size;
            this.txtAddBefore.TabIndex = 0x19;
            this.txtAddBefore.TabStop = false;
            this.txtAddBefore.Text = "1";
            this._lblHelpExists_2.BackColor = SystemColors.Control;
            this._lblHelpExists_2.Cursor = Cursors.Default;
            this._lblHelpExists_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblHelpExists_2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x16);
            this._lblHelpExists_2.Location = point;
            this._lblHelpExists_2.Name = "_lblHelpExists_2";
            this._lblHelpExists_2.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x13);
            this._lblHelpExists_2.Size = size;
            this._lblHelpExists_2.TabIndex = 7;
            this._lblHelpExists_2.Text = "Number of horizons:";
            this.chkAddBefore.BackColor = SystemColors.Control;
            this.chkAddBefore.Cursor = Cursors.Default;
            this.chkAddBefore.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkAddBefore.ForeColor = SystemColors.ControlText;
            point = new Point(0xbb, 0x15);
            this.chkAddBefore.Location = point;
            this.chkAddBefore.Name = "chkAddBefore";
            this.chkAddBefore.RightToLeft = RightToLeft.No;
            size = new Size(0xf2, 0x13);
            this.chkAddBefore.Size = size;
            this.chkAddBefore.TabIndex = 0x18;
            this.chkAddBefore.TabStop = false;
            this.chkAddBefore.Text = "Add/remove horizon before horizon number";
            this.chkAddBefore.UseVisualStyleBackColor = false;
            point = new Point(6, 0x2c);
            this.grdData.Location = point;
            this.grdData.Name = "grdData";
            this.grdData.OcxState = (AxHost.State) manager.GetObject("grdData.OcxState");
            size = new Size(650, 0xc9);
            this.grdData.Size = size;
            this.grdData.TabIndex = 0;
            this.GroupBox2.Controls.Add(this.cmbDesignations);
            this.GroupBox2.Controls.Add(this._Label11_0);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.cmbShape);
            this.GroupBox2.Controls.Add(this.cmbStrength);
            this.GroupBox2.Controls.Add(this.cmbStructure);
            this.GroupBox2.Controls.Add(this.txtBox);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.grdData);
            this.GroupBox2.Controls.Add(this.chkAddBefore);
            this.GroupBox2.Controls.Add(this._lblHelpExists_2);
            this.GroupBox2.Controls.Add(this.txtMaxNumLayers);
            this.GroupBox2.Controls.Add(this.txtAddBefore);
            this.GroupBox2.Controls.Add(this.Label17);
            this.GroupBox2.Controls.Add(this.Label16);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.UpDown1);
            this.GroupBox2.Controls.Add(this._lblHelpExists_0);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.txtLocation);
            this.GroupBox2.Controls.Add(this.txtProfileName);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            point = new Point(12, 12);
            this.GroupBox2.Location = point;
            this.GroupBox2.Name = "GroupBox2";
            size = new Size(680, 0x155);
            this.GroupBox2.Size = size;
            this.GroupBox2.TabIndex = 0x2d;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Soil profile";
            this.cmbDesignations.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDesignations.FormattingEnabled = true;
            object[] items = new object[] { "A", "Ap", "At", "B", "E", "C", "R", "BC", "H" };
            items[9] = "O";
            this.cmbDesignations.Items.AddRange(items);
            point = new Point(300, 0xbb);
            this.cmbDesignations.Location = point;
            this.cmbDesignations.Name = "cmbDesignations";
            size = new Size(80, 0x16);
            this.cmbDesignations.Size = size;
            this.cmbDesignations.TabIndex = 0x34;
            this.cmbDesignations.Visible = false;
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = Color.Red;
            point = new Point(0x87, 250);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 0x2c;
            this.Label3.Text = "m";
            this.Label12.BackColor = SystemColors.Control;
            this.Label12.Cursor = Cursors.Default;
            this.Label12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label12.ForeColor = Color.Red;
            point = new Point(0x3f, 0xf9);
            this.Label12.Location = point;
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.Label12.Size = size;
            this.Label12.TabIndex = 0x2e;
            this.Label12.Text = "m";
            this.cmbShape.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbShape.FormattingEnabled = true;
            items = new object[] { "granular", "platy", "blocky", "prismatic" };
            this.cmbShape.Items.AddRange(items);
            point = new Point(300, 0x83);
            this.cmbShape.Location = point;
            this.cmbShape.Name = "cmbShape";
            size = new Size(80, 0x16);
            this.cmbShape.Size = size;
            this.cmbShape.TabIndex = 0x33;
            this.cmbShape.Visible = false;
            this.cmbStrength.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStrength.FormattingEnabled = true;
            items = new object[] { "weak", "moderate", "strong" };
            this.cmbStrength.Items.AddRange(items);
            point = new Point(300, 0x9f);
            this.cmbStrength.Location = point;
            this.cmbStrength.Name = "cmbStrength";
            size = new Size(80, 0x16);
            this.cmbStrength.Size = size;
            this.cmbStrength.TabIndex = 50;
            this.cmbStrength.Visible = false;
            this.cmbStructure.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStructure.FormattingEnabled = true;
            items = new object[] { "none", "fine", "medium", "coarse" };
            this.cmbStructure.Items.AddRange(items);
            point = new Point(0x1d1, 0xa5);
            this.cmbStructure.Location = point;
            this.cmbStructure.Name = "cmbStructure";
            size = new Size(80, 0x16);
            this.cmbStructure.Size = size;
            this.cmbStructure.TabIndex = 0x31;
            this.cmbStructure.Visible = false;
            point = new Point(340, 0x12d);
            this.txtBox.Location = point;
            this.txtBox.Name = "txtBox";
            size = new Size(0x44, 20);
            this.txtBox.Size = size;
            this.txtBox.TabIndex = 0x30;
            this.txtBox.Visible = false;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 2);
            this.Label4.ForeColor = Color.Red;
            point = new Point(0x34, 0xf9);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 0x2f;
            this.Label4.Text = "m";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 2);
            this.Label1.ForeColor = Color.Red;
            point = new Point(0x7d, 250);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 0x2d;
            this.Label1.Text = "m";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdExit;
            size = new Size(700, 0x185);
            this.ClientSize = size;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblCurHor);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            point = new Point(2, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmSoilProperties";
            this.RightToLeft = RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.UpDown1.EndInit();
            this.grdData.EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private void InsertHorizon(ref bool Add_Renamed)
        {
            short num;
            int[,] numArray;
            short num2;
            short num25;
            if (!Add_Renamed)
            {
                short num15 = (short) (this.grdData.Rows - 2);
                num2 = (short) Math.Round((double) (Conversions.ToDouble(this.txtAddBefore.Text) - 1.0));
                while (true)
                {
                    if (num2 > num15)
                    {
                        AxMSFlexGrid grid3 = this.frmMain.frmParameters._flx_Parameters_4;
                        grid3.Rows = this.grdData.Rows;
                        numArray = new int[(grid3.Rows - 1) + 1, (grid3.Cols - 1) + 1];
                        short num17 = (short) (grid3.Rows - 1);
                        num2 = 1;
                        while (true)
                        {
                            if (num2 > num17)
                            {
                                short num19 = (short) (grid3.Rows - 2);
                                num2 = (short) Math.Round((double) (Conversions.ToDouble(this.txtAddBefore.Text) - 1.0));
                                while (true)
                                {
                                    if (num2 > num19)
                                    {
                                        grid3 = null;
                                        AxMSFlexGrid grid4 = this.frmMain.frmParameters._flx_Parameters_5;
                                        grid4.Rows = this.grdData.Rows;
                                        numArray = new int[(grid4.Rows - 1) + 1, (grid4.Cols - 1) + 1];
                                        short num21 = (short) (grid4.Rows - 1);
                                        num2 = 1;
                                        while (true)
                                        {
                                            if (num2 > num21)
                                            {
                                                short num23 = (short) (grid4.Rows - 2);
                                                num2 = (short) Math.Round((double) (Conversions.ToDouble(this.txtAddBefore.Text) - 1.0));
                                                while (true)
                                                {
                                                    if (num2 > num23)
                                                    {
                                                        grid4 = null;
                                                        break;
                                                    }
                                                    short num24 = (short) (grid4.Cols - 1);
                                                    num = 0;
                                                    while (true)
                                                    {
                                                        num25 = num24;
                                                        if (num > num25)
                                                        {
                                                            num2 = (short) (num2 + 1);
                                                            break;
                                                        }
                                                        grid4.set_TextMatrix(num2, num, grid4.get_TextMatrix(num2 + 1, num));
                                                        grid4.Col = num;
                                                        grid4.Row = num2;
                                                        grid4.CellForeColor = ColorTranslator.FromOle(numArray[num2 + 1, num]);
                                                        num = (short) (num + 1);
                                                    }
                                                }
                                                break;
                                            }
                                            short num22 = (short) (grid4.Cols - 1);
                                            num = 0;
                                            while (true)
                                            {
                                                num25 = num22;
                                                if (num > num25)
                                                {
                                                    num2 = (short) (num2 + 1);
                                                    break;
                                                }
                                                grid4.Row = num2;
                                                grid4.Col = num;
                                                numArray[num2, num] = ColorTranslator.ToOle(grid4.CellForeColor);
                                                num = (short) (num + 1);
                                            }
                                        }
                                        break;
                                    }
                                    short num20 = (short) (grid3.Cols - 1);
                                    num = 0;
                                    while (true)
                                    {
                                        num25 = num20;
                                        if (num > num25)
                                        {
                                            num2 = (short) (num2 + 1);
                                            break;
                                        }
                                        grid3.set_TextMatrix(num2, num, grid3.get_TextMatrix(num2 + 1, num));
                                        grid3.Col = num;
                                        grid3.Row = num2;
                                        grid3.CellForeColor = ColorTranslator.FromOle(numArray[num2 + 1, num]);
                                        num = (short) (num + 1);
                                    }
                                }
                                break;
                            }
                            short num18 = (short) (grid3.Cols - 1);
                            num = 0;
                            while (true)
                            {
                                num25 = num18;
                                if (num > num25)
                                {
                                    num2 = (short) (num2 + 1);
                                    break;
                                }
                                grid3.Row = num2;
                                grid3.Col = num;
                                numArray[num2, num] = ColorTranslator.ToOle(grid3.CellForeColor);
                                num = (short) (num + 1);
                            }
                        }
                        break;
                    }
                    short num16 = (short) (this.grdData.Cols - 1);
                    num = 0;
                    while (true)
                    {
                        num25 = num16;
                        if (num > num25)
                        {
                            num2 = (short) (num2 + 1);
                            break;
                        }
                        this.grdData.set_TextMatrix(num2, num, this.grdData.get_TextMatrix(num2 + 1, num));
                        num = (short) (num + 1);
                    }
                }
            }
            else
            {
                short num3 = (short) Conversions.ToInteger(this.txtAddBefore.Text);
                num2 = (short) (this.grdData.Rows - 2);
                while (true)
                {
                    if (num2 < num3)
                    {
                        AxMSFlexGrid grid = this.frmMain.frmParameters._flx_Parameters_4;
                        grid.Rows = this.grdData.Rows;
                        numArray = new int[(grid.Rows - 1) + 1, (grid.Cols - 1) + 1];
                        short num5 = (short) (grid.Rows - 1);
                        num2 = 1;
                        while (true)
                        {
                            if (num2 > num5)
                            {
                                short num7 = (short) Conversions.ToInteger(this.txtAddBefore.Text);
                                num2 = (short) (grid.Rows - 2);
                                while (true)
                                {
                                    if (num2 < num7)
                                    {
                                        grid.Row = Conversions.ToShort(this.txtAddBefore.Text);
                                        short num9 = (short) (grid.Cols - 1);
                                        num = 0;
                                        while (true)
                                        {
                                            num25 = num9;
                                            if (num > num25)
                                            {
                                                grid = null;
                                                AxMSFlexGrid grid2 = this.frmMain.frmParameters._flx_Parameters_5;
                                                grid2.Rows = this.grdData.Rows;
                                                numArray = new int[(grid2.Rows - 1) + 1, (grid2.Cols - 1) + 1];
                                                short num10 = (short) (grid2.Rows - 1);
                                                num2 = 1;
                                                while (true)
                                                {
                                                    if (num2 > num10)
                                                    {
                                                        short num12 = (short) Conversions.ToInteger(this.txtAddBefore.Text);
                                                        num2 = (short) (grid2.Rows - 2);
                                                        while (true)
                                                        {
                                                            if (num2 < num12)
                                                            {
                                                                grid2.Row = Conversions.ToShort(this.txtAddBefore.Text);
                                                                short num14 = (short) (grid2.Cols - 1);
                                                                num = 0;
                                                                while (true)
                                                                {
                                                                    num25 = num14;
                                                                    if (num > num25)
                                                                    {
                                                                        grid2 = null;
                                                                        break;
                                                                    }
                                                                    grid2.Col = num;
                                                                    grid2.CellForeColor = Color.Black;
                                                                    num = (short) (num + 1);
                                                                }
                                                                break;
                                                            }
                                                            short num13 = (short) (grid2.Cols - 1);
                                                            num = 0;
                                                            while (true)
                                                            {
                                                                num25 = num13;
                                                                if (num > num25)
                                                                {
                                                                    num2 = (short) (num2 + -1);
                                                                    break;
                                                                }
                                                                grid2.set_TextMatrix(num2 + 1, num, grid2.get_TextMatrix(num2, num));
                                                                grid2.Col = num;
                                                                grid2.Row = num2 + 1;
                                                                grid2.CellForeColor = ColorTranslator.FromOle(numArray[num2, num]);
                                                                num = (short) (num + 1);
                                                            }
                                                        }
                                                        break;
                                                    }
                                                    short num11 = (short) (grid2.Cols - 1);
                                                    num = 0;
                                                    while (true)
                                                    {
                                                        num25 = num11;
                                                        if (num > num25)
                                                        {
                                                            num2 = (short) (num2 + 1);
                                                            break;
                                                        }
                                                        grid2.Row = num2;
                                                        grid2.Col = num;
                                                        numArray[num2, num] = ColorTranslator.ToOle(grid2.CellForeColor);
                                                        num = (short) (num + 1);
                                                    }
                                                }
                                                break;
                                            }
                                            grid.Col = num;
                                            grid.CellForeColor = Color.Black;
                                            num = (short) (num + 1);
                                        }
                                        break;
                                    }
                                    short num8 = (short) (grid.Cols - 1);
                                    num = 0;
                                    while (true)
                                    {
                                        num25 = num8;
                                        if (num > num25)
                                        {
                                            num2 = (short) (num2 + -1);
                                            break;
                                        }
                                        grid.set_TextMatrix(num2 + 1, num, grid.get_TextMatrix(num2, num));
                                        grid.Col = num;
                                        grid.Row = num2 + 1;
                                        grid.CellForeColor = ColorTranslator.FromOle(numArray[num2, num]);
                                        num = (short) (num + 1);
                                    }
                                }
                                break;
                            }
                            short num6 = (short) (grid.Cols - 1);
                            num = 0;
                            while (true)
                            {
                                num25 = num6;
                                if (num > num25)
                                {
                                    num2 = (short) (num2 + 1);
                                    break;
                                }
                                grid.Row = num2;
                                grid.Col = num;
                                numArray[num2, num] = ColorTranslator.ToOle(grid.CellForeColor);
                                num = (short) (num + 1);
                            }
                        }
                        break;
                    }
                    short num4 = (short) (this.grdData.Cols - 1);
                    num = 0;
                    while (true)
                    {
                        num25 = num4;
                        if (num > num25)
                        {
                            num2 = (short) (num2 + -1);
                            break;
                        }
                        this.grdData.set_TextMatrix(num2 + 1, num, this.grdData.get_TextMatrix(num2, num));
                        num = (short) (num + 1);
                    }
                }
            }
        }

        private void MoveCombo(ref ComboBox cmb)
        {
            if (!(this.grdData.get_RowIsVisible(this.grdData.Row) & this.grdData.get_ColIsVisible(this.grdData.Col)))
            {
                cmb.Visible = false;
            }
            else
            {
                ComboBox box = cmb;
                box.Visible = true;
                box.Left = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.grdData.Left) + this.grdData.get_ColPos(this.grdData.Col)));
                box.Top = (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) this.grdData.Top) + this.grdData.get_RowPos(this.grdData.Row)));
                box = null;
            }
        }

        private void MoveTextBox()
        {
            if (!(this.grdData.get_RowIsVisible(this.grdData.Row) & this.grdData.get_ColIsVisible(this.grdData.Col)))
            {
                this.txtBox.Visible = false;
            }
            else
            {
                this.txtBox.Visible = true;
                this.txtBox.SetBounds((int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.grdData.Left) + this.grdData.get_ColPos(this.grdData.Col))), (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) this.grdData.Top) + this.grdData.get_RowPos(this.grdData.Row))), 0, 0, BoundsSpecified.Location);
            }
        }

        private void SetupTable()
        {
            this.Saving = false;
            short num2 = (short) (this.grdData.Cols - 1);
            short index = 0;
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    AxMSFlexGrid grdData = this.grdData;
                    grdData.Row = 0;
                    grdData.Col = 0;
                    grdData.Text = "Horizon:";
                    grdData.Col = 1;
                    grdData.set_ColWidth(1, 700);
                    grdData.Text = "Clay %";
                    grdData.Col = 2;
                    grdData.set_ColWidth(2, 700);
                    grdData.Text = "Silt %";
                    grdData.Col = 3;
                    grdData.set_ColWidth(3, 700);
                    grdData.Text = "Sand %";
                    grdData.Col = 4;
                    grdData.set_ColWidth(4, 500);
                    grdData.Text = "pH";
                    grdData.Col = 5;
                    grdData.Text = "Bulk dens.";
                    grdData.Col = 6;
                    grdData.Text = "Org. C %";
                    grdData.Col = 7;
                    grdData.set_ColWidth(7, 850);
                    grdData.Text = "Thickness";
                    grdData.Col = 8;
                    grdData.Text = "Texture";
                    grdData.Col = 9;
                    grdData.Text = "Structure";
                    grdData.Col = 10;
                    grdData.Text = "Strength";
                    grdData.Col = 11;
                    grdData.Text = "Shape";
                    grdData.Col = 0;
                    grdData.Row = 1;
                    grdData = null;
                    return;
                }
                this.grdData.set_ColWidth(index, (int) Math.Round((double) ((Support.PixelsToTwipsX((double) this.grdData.Width) / ((double) this.grdData.Cols)) + ((Support.PixelsToTwipsX((double) this.grdData.Width) / ((double) this.grdData.Cols)) / ((double) this.grdData.Cols)))));
                index = (short) (index + 1);
            }
        }

        private void ShowCombo(ref ComboBox cmb)
        {
            if ((this.grdData.Col >= this.grdData.FixedCols) & (this.grdData.Row >= this.grdData.FixedRows))
            {
                this.Selecting = true;
                ComboBox box = cmb;
                box.Left = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.grdData.Left) + this.grdData.get_ColPos(this.grdData.Col)));
                box.Top = (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) this.grdData.Top) + this.grdData.get_RowPos(this.grdData.Row)));
                box.Visible = true;
                box.Focus();
                box = null;
                cmb.SelectedIndex = cmb.FindStringExact(Strings.Trim(this.grdData.Text));
            }
        }

        private void ShowTextBox(ref string str_Renamed = "")
        {
            if ((this.grdData.Col >= this.grdData.FixedCols) & (this.grdData.Row >= this.grdData.FixedRows))
            {
                this.txtBox.SetBounds((int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) this.grdData.Left) + this.grdData.get_ColPos(this.grdData.Col))), (int) Math.Round(Support.TwipsToPixelsY(Support.PixelsToTwipsY((double) this.grdData.Top) + this.grdData.get_RowPos(this.grdData.Row))), 0, 0, BoundsSpecified.Location);
                this.txtBox.Text = this.grdData.Text;
                this.txtBox.Visible = true;
                this.txtBox.Focus();
                if (Strings.Len((string) str_Renamed) == 0)
                {
                    this.txtBox.SelectionLength = Strings.Len(this.txtBox.Text);
                    this.txtBox.Visible = true;
                    this.txtBox.Focus();
                }
                if (Strings.Len((string) str_Renamed) > 0)
                {
                    this.txtBox.Text = str_Renamed;
                    this.txtBox.SelectionStart = 2;
                    this.txtBox.SelectionLength = 0;
                    this.txtBox.Visible = true;
                    this.txtBox.Focus();
                }
            }
        }

        public string TextureClass()
        {
            AxMSFlexGrid grdData = this.grdData;
            grdData.Col = 1;
            float num = !((grdData.Text == "") | !Versioned.IsNumeric(grdData.Text)) ? Conversions.ToSingle(grdData.Text) : 0f;
            grdData.Col = 2;
            float num3 = !((grdData.Text == "") | !Versioned.IsNumeric(grdData.Text)) ? Conversions.ToSingle(grdData.Text) : 0f;
            grdData.Col = 3;
            float num2 = !((grdData.Text == "") | !Versioned.IsNumeric(grdData.Text)) ? Conversions.ToSingle(grdData.Text) : 0f;
            string str = !((num >= 40f) & (num2 <= 45f)) ? (!((num >= 27f) & (num2 <= 45f)) ? (!((num >= 20f) & (num3 <= 28f)) ? ((num3 < 50f) ? (!((num >= 7f) & (num2 <= 52f)) ? ((num2 > (85.0 - (0.5 * num3))) ? ((num2 > (90.0 - (0.3333 * num3))) ? "sand" : "loamy sand") : "sandy loam") : "loam") : (!((num3 > 80f) & (num < 12f)) ? "silt loam" : "silt")) : ((num <= 35f) ? "sandy clay loam" : "sandy clay")) : ((num2 >= 20f) ? "clay loam" : "silty clay loam")) : ((num3 >= 40f) ? "silty clay" : "clay");
            grdData = null;
            return str;
        }

        private void txtBox_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.txtBox.Visible = false;
                this.CurCol = (short) this.grdData.Col;
                this.CurRow = (short) this.grdData.Row;
                this.grdData.Col = this.CurCol;
                this.grdData.Row = this.CurRow;
            }
            else if (e.KeyChar == '\x001b')
            {
                this.txtBox.Visible = false;
                this.CurCol = (short) this.grdData.Col;
                this.CurRow = (short) this.grdData.Row;
                this.grdData.Col = this.CurCol;
                this.grdData.Row = this.CurRow;
            }
        }

        private void txtBox_Leave1(object sender, EventArgs e)
        {
            short col;
            short row;
            if ((this.CurCol >= 1) & (this.CurCol <= 3))
            {
                row = (short) this.grdData.Row;
                col = (short) this.grdData.Col;
                this.grdData.Row = this.CurRow;
                this.grdData.Col = this.CurCol;
                string str = this.TextureClass();
                this.grdData.Col = 8;
                this.grdData.Row = this.CurRow;
                this.grdData.Text = str;
            }
            this.grdData.Col = col;
            this.grdData.Row = row;
            this.txtBox.Visible = false;
            this.txtBox.Visible = false;
            this.CurCol = (short) this.grdData.Col;
            this.CurRow = (short) this.grdData.Row;
            this.grdData.Col = this.CurCol;
            this.grdData.Row = this.CurRow;
        }

        private void txtBox_TextChanged1(object sender, EventArgs e)
        {
            this.CurCol = (short) this.grdData.Col;
            this.CurRow = (short) this.grdData.Row;
            this.grdData.Text = this.txtBox.Text;
            this.txtBox.ForeColor = ColorTranslator.FromOle(Information.QBColor(2));
        }

        public void UpDown1_Change()
        {
            short col = (short) this.grdData.Col;
            if (decimal.Compare(this.UpDown1.Value, new decimal(this.grdData.Rows - 1)) <= 0)
            {
                if ((decimal.Compare(this.UpDown1.Value, this.UpDown1.Maximum) < 0) & (decimal.Compare(this.UpDown1.Value, 1M) >= 0))
                {
                    if (!((decimal.Compare(this.UpDown1.Value, 1M) == 0) & (this.grdData.Rows == 2)))
                    {
                        if ((this.chkAddBefore.CheckState == CheckState.Checked) && (this.txtAddBefore.Text != "1"))
                        {
                            this.InsertHorizon(ref false);
                        }
                        this.grdData.Rows--;
                        this.CurHorizon = (short) (this.CurHorizon - 1);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                this.grdData.Rows = Convert.ToInt32(decimal.Add(this.UpDown1.Value, 1M));
                this.CurHorizon = (short) (this.CurHorizon + 1);
                this.grdData.Row = Convert.ToInt32(this.UpDown1.Value);
                if (this.chkAddBefore.CheckState == CheckState.Checked)
                {
                    if (Conversions.ToDouble(this.txtAddBefore.Text) != this.grdData.Rows)
                    {
                        this.InsertHorizon(ref true);
                    }
                }
                else if (!this.m_bNoCopy)
                {
                    this.CopyLast();
                }
            }
            this.grdData.Col = col;
        }

        private void UpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!this.IsDisplaying)
            {
                short col = (short) this.grdData.Col;
                if (decimal.Compare(this.UpDown1.Value, new decimal(this.grdData.Rows - 1)) <= 0)
                {
                    if ((decimal.Compare(this.UpDown1.Value, this.UpDown1.Maximum) < 0) & (decimal.Compare(this.UpDown1.Value, 1M) >= 0))
                    {
                        if (!((decimal.Compare(this.UpDown1.Value, 1M) == 0) & (this.grdData.Rows == 2)))
                        {
                            if ((this.chkAddBefore.CheckState == CheckState.Checked) && (this.txtAddBefore.Text != "1"))
                            {
                                this.InsertHorizon(ref false);
                            }
                            this.grdData.Rows--;
                            this.CurHorizon = (short) (this.CurHorizon - 1);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    this.grdData.Rows = Convert.ToInt32(decimal.Add(this.UpDown1.Value, 1M));
                    this.CurHorizon = (short) (this.CurHorizon + 1);
                    this.grdData.Row = Convert.ToInt32(this.UpDown1.Value);
                    if (this.chkAddBefore.CheckState == CheckState.Checked)
                    {
                        if (Conversions.ToDouble(this.txtAddBefore.Text) != this.grdData.Rows)
                        {
                            this.InsertHorizon(ref true);
                        }
                    }
                    else if (!this.m_bNoCopy)
                    {
                        this.CopyLast();
                    }
                }
                this.grdData.Col = col;
            }
        }

        public virtual Label lblCurHor
        {
            [DebuggerNonUserCode]
            get => 
                this._lblCurHor;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblCurHor = value;
        }

        public virtual Label _lblHelpExists_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelpExists_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelpExists_0 = value;
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

        public virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
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

        public virtual Label Label7
        {
            [DebuggerNonUserCode]
            get => 
                this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label7 = value;
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

        public virtual Label Label9
        {
            [DebuggerNonUserCode]
            get => 
                this._Label9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label9 = value;
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

        public virtual TextBox txtProfileName
        {
            [DebuggerNonUserCode]
            get => 
                this._txtProfileName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtProfileName = value;
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

        public virtual TextBox txtLocation
        {
            [DebuggerNonUserCode]
            get => 
                this._txtLocation;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtLocation = value;
        }

        public virtual TextBox txtMaxNumLayers
        {
            [DebuggerNonUserCode]
            get => 
                this._txtMaxNumLayers;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtMaxNumLayers = value;
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

        public virtual Label _Label11_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__Label11_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__Label11_0 = value;
        }

        internal virtual NumericUpDown UpDown1
        {
            [DebuggerNonUserCode]
            get => 
                this._UpDown1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.UpDown1_ValueChanged);
                if (!ReferenceEquals(this._UpDown1, null))
                {
                    this._UpDown1.ValueChanged -= handler;
                }
                this._UpDown1 = value;
                if (!ReferenceEquals(this._UpDown1, null))
                {
                    this._UpDown1.ValueChanged += handler;
                }
            }
        }

        public virtual TextBox txtAddBefore
        {
            [DebuggerNonUserCode]
            get => 
                this._txtAddBefore;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtAddBefore = value;
        }

        public virtual Label _lblHelpExists_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblHelpExists_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblHelpExists_2 = value;
        }

        public virtual CheckBox chkAddBefore
        {
            [DebuggerNonUserCode]
            get => 
                this._chkAddBefore;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkAddBefore = value;
        }

        public virtual AxMSFlexGrid grdData
        {
            [DebuggerNonUserCode]
            get => 
                this._grdData;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.grdData_Scroll);
                DMSFlexGridEvents_MouseDownEventHandler handler2 = new DMSFlexGridEvents_MouseDownEventHandler(this.grdData_MouseDownEvent);
                DMSFlexGridEvents_KeyPressEventHandler handler3 = new DMSFlexGridEvents_KeyPressEventHandler(this.grdData_KeyPressEvent);
                if (!ReferenceEquals(this._grdData, null))
                {
                    this._grdData.Scroll -= handler;
                    this._grdData.MouseDownEvent -= handler2;
                    this._grdData.KeyPressEvent -= handler3;
                }
                this._grdData = value;
                if (!ReferenceEquals(this._grdData, null))
                {
                    this._grdData.Scroll += handler;
                    this._grdData.MouseDownEvent += handler2;
                    this._grdData.KeyPressEvent += handler3;
                }
            }
        }

        internal virtual GroupBox GroupBox2
        {
            [DebuggerNonUserCode]
            get => 
                this._GroupBox2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._GroupBox2 = value;
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

        public virtual Label Label12
        {
            [DebuggerNonUserCode]
            get => 
                this._Label12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label12 = value;
        }

        internal virtual TextBox txtBox
        {
            [DebuggerNonUserCode]
            get => 
                this._txtBox;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.txtBox_TextChanged1);
                EventHandler handler2 = new EventHandler(this.txtBox_Leave1);
                KeyPressEventHandler handler3 = new KeyPressEventHandler(this.txtBox_KeyPress1);
                if (!ReferenceEquals(this._txtBox, null))
                {
                    this._txtBox.TextChanged -= handler;
                    this._txtBox.Leave -= handler2;
                    this._txtBox.KeyPress -= handler3;
                }
                this._txtBox = value;
                if (!ReferenceEquals(this._txtBox, null))
                {
                    this._txtBox.TextChanged += handler;
                    this._txtBox.Leave += handler2;
                    this._txtBox.KeyPress += handler3;
                }
            }
        }

        internal virtual ComboBox cmbStructure
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbStructure;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdStructure_SelectedIndexChanged);
                EventHandler handler2 = new EventHandler(this.cmbStructure_LostFocus);
                if (!ReferenceEquals(this._cmbStructure, null))
                {
                    this._cmbStructure.SelectedIndexChanged -= handler;
                    this._cmbStructure.LostFocus -= handler2;
                }
                this._cmbStructure = value;
                if (!ReferenceEquals(this._cmbStructure, null))
                {
                    this._cmbStructure.SelectedIndexChanged += handler;
                    this._cmbStructure.LostFocus += handler2;
                }
            }
        }

        internal virtual ComboBox cmbShape
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbShape;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbShape_SelectedIndexChanged);
                EventHandler handler2 = new EventHandler(this.cmbShape_LostFocus);
                if (!ReferenceEquals(this._cmbShape, null))
                {
                    this._cmbShape.SelectedIndexChanged -= handler;
                    this._cmbShape.LostFocus -= handler2;
                }
                this._cmbShape = value;
                if (!ReferenceEquals(this._cmbShape, null))
                {
                    this._cmbShape.SelectedIndexChanged += handler;
                    this._cmbShape.LostFocus += handler2;
                }
            }
        }

        internal virtual ComboBox cmbStrength
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbStrength;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbStrength_SelectedIndexChanged);
                EventHandler handler2 = new EventHandler(this.cmbStrength_LostFocus);
                if (!ReferenceEquals(this._cmbStrength, null))
                {
                    this._cmbStrength.SelectedIndexChanged -= handler;
                    this._cmbStrength.LostFocus -= handler2;
                }
                this._cmbStrength = value;
                if (!ReferenceEquals(this._cmbStrength, null))
                {
                    this._cmbStrength.SelectedIndexChanged += handler;
                    this._cmbStrength.LostFocus += handler2;
                }
            }
        }

        internal virtual ComboBox cmbDesignations
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbDesignations;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbDesignations_SelectedIndexChanged);
                EventHandler handler2 = new EventHandler(this.cmbDesignations_LostFocus);
                if (!ReferenceEquals(this._cmbDesignations, null))
                {
                    this._cmbDesignations.SelectedIndexChanged -= handler;
                    this._cmbDesignations.LostFocus -= handler2;
                }
                this._cmbDesignations = value;
                if (!ReferenceEquals(this._cmbDesignations, null))
                {
                    this._cmbDesignations.SelectedIndexChanged += handler;
                    this._cmbDesignations.LostFocus += handler2;
                }
            }
        }
    }
}

