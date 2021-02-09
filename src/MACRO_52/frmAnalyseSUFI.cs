namespace MACRO_52
{
    using ADODB;
    using MACRO_52.My;
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
    internal class frmAnalyseSUFI : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("cmdAggregateTool")]
        private Button _cmdAggregateTool;
        [AccessedThroughProperty("Label24")]
        private Label _Label24;
        [AccessedThroughProperty("fraAggregate")]
        private GroupBox _fraAggregate;
        [AccessedThroughProperty("cmdSetWeight")]
        private Button _cmdSetWeight;
        [AccessedThroughProperty("txtGroupWeight")]
        private TextBox _txtGroupWeight;
        [AccessedThroughProperty("cmdBrowseForSimFile")]
        private Button _cmdBrowseForSimFile;
        [AccessedThroughProperty("cmdSetDetectionLimit")]
        private Button _cmdSetDetectionLimit;
        [AccessedThroughProperty("txtDetectionLimit")]
        private TextBox _txtDetectionLimit;
        [AccessedThroughProperty("cmdResetGroups")]
        private Button _cmdResetGroups;
        [AccessedThroughProperty("cmdAggregate")]
        private Button _cmdAggregate;
        [AccessedThroughProperty("lstGroups")]
        private ListBox _lstGroups;
        [AccessedThroughProperty("lstMeasured")]
        private ListBox _lstMeasured;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("_lblSimFile_1")]
        private Label __lblSimFile_1;
        [AccessedThroughProperty("_lblSimFile_0")]
        private Label __lblSimFile_0;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("Label15")]
        private Label _Label15;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("_lblStep_2")]
        private Label __lblStep_2;
        [AccessedThroughProperty("_fraStep_4")]
        private GroupBox __fraStep_4;
        [AccessedThroughProperty("cmdSet")]
        private Button _cmdSet;
        [AccessedThroughProperty("lstSimulatedVar")]
        private ListBox _lstSimulatedVar;
        [AccessedThroughProperty("lstCondVar")]
        private ListBox _lstCondVar;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Frame3")]
        private GroupBox _Frame3;
        [AccessedThroughProperty("_lblStep_5")]
        private Label __lblStep_5;
        [AccessedThroughProperty("_fraStep_3")]
        private GroupBox __fraStep_3;
        [AccessedThroughProperty("_optMultAdd_1")]
        private RadioButton __optMultAdd_1;
        [AccessedThroughProperty("_optMultAdd_0")]
        private RadioButton __optMultAdd_0;
        [AccessedThroughProperty("Frame5")]
        private GroupBox _Frame5;
        [AccessedThroughProperty("txtOffSet")]
        private TextBox _txtOffSet;
        [AccessedThroughProperty("chkLogValues")]
        private CheckBox _chkLogValues;
        [AccessedThroughProperty("_optGoalFunctionType_3")]
        private RadioButton __optGoalFunctionType_3;
        [AccessedThroughProperty("_optGoalFunctionType_2")]
        private RadioButton __optGoalFunctionType_2;
        [AccessedThroughProperty("_optGoalFunctionType_1")]
        private RadioButton __optGoalFunctionType_1;
        [AccessedThroughProperty("_optGoalFunctionType_0")]
        private RadioButton __optGoalFunctionType_0;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("_lblStep_1")]
        private Label __lblStep_1;
        [AccessedThroughProperty("_fraStep_2")]
        private GroupBox __fraStep_2;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("cmdPrevious")]
        private Button _cmdPrevious;
        [AccessedThroughProperty("cmdNext")]
        private Button _cmdNext;
        [AccessedThroughProperty("_optViewResult_4")]
        private RadioButton __optViewResult_4;
        [AccessedThroughProperty("_optViewResult_3")]
        private RadioButton __optViewResult_3;
        [AccessedThroughProperty("_optViewResult_2")]
        private RadioButton __optViewResult_2;
        [AccessedThroughProperty("_optViewResult_1")]
        private RadioButton __optViewResult_1;
        [AccessedThroughProperty("txtReport")]
        private TextBox _txtReport;
        [AccessedThroughProperty("_optViewResult_0")]
        private RadioButton __optViewResult_0;
        [AccessedThroughProperty("_fraStep_6")]
        private GroupBox __fraStep_6;
        [AccessedThroughProperty("_txtTol_2")]
        private TextBox __txtTol_2;
        [AccessedThroughProperty("_optToleranceInterval_2")]
        private RadioButton __optToleranceInterval_2;
        [AccessedThroughProperty("chkAddVariance")]
        private CheckBox _chkAddVariance;
        [AccessedThroughProperty("_txtTol_1")]
        private TextBox __txtTol_1;
        [AccessedThroughProperty("_txtTol_0")]
        private TextBox __txtTol_0;
        [AccessedThroughProperty("_optToleranceInterval_1")]
        private RadioButton __optToleranceInterval_1;
        [AccessedThroughProperty("_optToleranceInterval_0")]
        private RadioButton __optToleranceInterval_0;
        [AccessedThroughProperty("txtNoTolerances")]
        private TextBox _txtNoTolerances;
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("Frame4")]
        private GroupBox _Frame4;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label22")]
        private Label _Label22;
        [AccessedThroughProperty("Label21")]
        private Label _Label21;
        [AccessedThroughProperty("Label20")]
        private Label _Label20;
        [AccessedThroughProperty("_fraStep_5")]
        private GroupBox __fraStep_5;
        [AccessedThroughProperty("txtMissingData")]
        private TextBox _txtMissingData;
        [AccessedThroughProperty("cmdRemoveAll")]
        private Button _cmdRemoveAll;
        [AccessedThroughProperty("cmdAddAll")]
        private Button _cmdAddAll;
        [AccessedThroughProperty("cmdRemoveVariable")]
        private Button _cmdRemoveVariable;
        [AccessedThroughProperty("cmdAddVariable")]
        private Button _cmdAddVariable;
        [AccessedThroughProperty("lstVariablesInGoalFunction")]
        private ListBox _lstVariablesInGoalFunction;
        [AccessedThroughProperty("lstAvailableVariables")]
        private ListBox _lstAvailableVariables;
        [AccessedThroughProperty("cmdBrowseForCondBinFile")]
        private Button _cmdBrowseForCondBinFile;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("lblCondBinFile")]
        private Label _lblCondBinFile;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("_fraStep_1")]
        private GroupBox __fraStep_1;
        [AccessedThroughProperty("cmdStartScript")]
        private Button _cmdStartScript;
        [AccessedThroughProperty("cmdBrowseForScript")]
        private Button _cmdBrowseForScript;
        [AccessedThroughProperty("txtScriptFile")]
        private TextBox _txtScriptFile;
        [AccessedThroughProperty("Frame6")]
        private GroupBox _Frame6;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("_lblStep_0")]
        private Label __lblStep_0;
        [AccessedThroughProperty("_fraStep_0")]
        private GroupBox __fraStep_0;
        [AccessedThroughProperty("fraStep")]
        private GroupBoxArray _fraStep;
        [AccessedThroughProperty("lblSimFile")]
        private LabelArray _lblSimFile;
        [AccessedThroughProperty("lblStep")]
        private LabelArray _lblStep;
        [AccessedThroughProperty("optGoalFunctionType")]
        private RadioButtonArray _optGoalFunctionType;
        [AccessedThroughProperty("optMultAdd")]
        private RadioButtonArray _optMultAdd;
        [AccessedThroughProperty("optToleranceInterval")]
        private RadioButtonArray _optToleranceInterval;
        [AccessedThroughProperty("optViewResult")]
        private RadioButtonArray _optViewResult;
        [AccessedThroughProperty("txtTol")]
        private TextBoxArray _txtTol;
        [AccessedThroughProperty("lstProjects")]
        private ListBox _lstProjects;
        [AccessedThroughProperty("udIterationNumber")]
        private NumericUpDown _udIterationNumber;
        private short CurStep;
        private short flag;
        private const short STEP_SELECTPROJECT = 0;
        private const short STEP_DEFINEGOAL_I = 1;
        private const short STEP_DEFINEGOAL_II = 2;
        private const short STEP_DEFINEGOAL_III = 3;
        private const short STEP_DEFINEGOAL_IV = 4;
        private const short STEP_SETTOLERANCES = 5;
        private const short STEP_DISPLAYRESULTS = 6;
        private const short OPT_RMSE = 0;
        private const short OPT_LRMSE = 1;
        private const short OPT_ABSERROR = 2;
        private const short OPT_MODELEFF = 3;
        private const short OPT_ABS = 0;
        private const short OPT_REL = 1;
        private const short OPT_PER = 2;
        private const short OPT_MULT = 0;
        private const short OPT_ADD = 1;
        private const short C_MEASURED = 1;
        private const short C_SIMULATED = 2;
        private const short OPT_SENSITIVITY = 0;
        private const short OPT_STRATASCORE = 1;
        private const short OPT_STRATAINFORMATION = 3;
        private const short OPT_ITERATIONSUMMARY = 2;
        private const short OPT_GOALFUNCVALS = 4;
        private const bool OPT_TOLNORMAL = false;
        private const bool OPT_TOLNEW = true;
        public short m_nCondVars;
        public short m_nParameters;
        private int m_nSimulations;
        private string m_sOutputPath;
        private short m_IterationNo;
        public short m_IterationID;
        public int m_ProjectID;
        private string m_ProjectName;
        private int m_BaseSimID;
        private float[,] m_Sensitivity;
        private float[] m_Tolerances;
        private float[] m_tmpgoal;
        private float[] m_Weights;
        private float[] m_GroupWeights;
        private object m_MissingData;
        private string[] m_VarNames;
        private short[] m_nStrata;
        private short m_Index;
        private short m_dT;
        private bool m_bAverage;
        private float m_GoalMean;
        private float m_GoalDev;
        private bool m_bFilesRead;
        private string m_ScriptFile;
        public bool m_bDone;
        private short[,] Groups;
        private float[] DetectionLimit;
        private string m_CondBinFile;
        private string m_SimFile;
        private short[,] m_BinFileIndexes;
        private string[] m_Dates;
        private float[,] m_MeasuredValues;
        private float[,] m_SimulatedValues;
        private float[] m_GoalFunction;
        private bool m_bSingleSimulation;
        private string m_SimFileName;
        private CfrmSUFIMain frmSUFIMain;
        private bool $STATIC$Dispose$20112$fTerminateCalled;

        public frmAnalyseSUFI(ref CfrmSUFIMain frm)
        {
            base.Activated += new EventHandler(this.frmAnalyseSUFI_Activated);
            base.Load += new EventHandler(this.frmAnalyseSUFI_Load);
            base.FormClosed += new FormClosedEventHandler(this.frmAnalyseSUFI_FormClosed);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmSUFIMain = frm;
        }

        private float ABSERR()
        {
            float num;
            if (!this.optMultAdd[1].Checked)
            {
                num = 1f;
            }
            else if (this.SetWeights())
            {
                num = 0f;
            }
            else
            {
                return num;
            }
            short nCondVars = this.m_nCondVars;
            short index = 1;
            while (index <= nCondVars)
            {
                float num3 = 0f;
                short num6 = (short) Information.UBound(this.m_SimulatedValues, 1);
                short num2 = 1;
                while (true)
                {
                    short num7 = num6;
                    if (num2 > num7)
                    {
                        num = !this.optMultAdd[1].Checked ? (num * num3) : (num + (num3 * this.m_Weights[index]));
                        index = (short) (index + 1);
                        break;
                    }
                    if (Operators.ConditionalCompareObjectNotEqual(this.m_MeasuredValues[num2, index], this.m_MissingData, false))
                    {
                        num3 += Math.Abs((float) (this.m_MeasuredValues[num2, index] - this.m_SimulatedValues[num2, index]));
                    }
                    num2 = (short) (num2 + 1);
                }
            }
            return num;
        }

        public bool BrowseForCondBinFile()
        {
            // Invalid method body.
        }

        private void chkLogValues_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            this.txtOffSet.Enabled = this.chkLogValues.CheckState == CheckState.Checked;
        }

        private void cmdAddAll_Click(object eventSender, EventArgs eventArgs)
        {
            short num2 = (short) (this.lstAvailableVariables.Items.Count - 1);
            short num = 0;
            while (true)
            {
                short num3 = num2;
                if (num > num3)
                {
                    return;
                }
                this.lstAvailableVariables.SelectedIndex = num;
                this.cmdAddVariable_Click(this.cmdAddVariable, new EventArgs());
                num = (short) (num + 1);
            }
        }

        private void cmdAddVariable_Click(object eventSender, EventArgs eventArgs)
        {
            short num2 = (short) (this.lstVariablesInGoalFunction.Items.Count - 1);
            short index = 0;
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    this.lstVariablesInGoalFunction.Items.Add(this.lstAvailableVariables.Text);
                    this.lstVariablesInGoalFunction.SelectedIndex = this.lstVariablesInGoalFunction.Items.Count - 1;
                }
                else if (Support.GetItemString(this.lstVariablesInGoalFunction, index) != this.lstAvailableVariables.Text)
                {
                    index = (short) (index + 1);
                    continue;
                }
                return;
            }
        }

        private void cmdAggregate_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.lstGroups.Items.Count >= this.m_nCondVars)
            {
                MiscFUncs.MsgBox_Renamed("Can not create more groups than the number of \rconditioning variables.", 0x30, "Too many groups");
            }
            else
            {
                ListBox lstMeasured = this.lstMeasured;
                string item = "";
                short num2 = (short) (lstMeasured.Items.Count - 1);
                short index = 0;
                while (true)
                {
                    short num4 = num2;
                    if (index > num4)
                    {
                        lstMeasured = null;
                        this.lstGroups.Items.Add(item);
                        this.SetGroupArray();
                        break;
                    }
                    if (lstMeasured.GetSelected(index))
                    {
                        if (this.IsInGroup(ref (short) (index + 1)))
                        {
                            MiscFUncs.MsgBox_Renamed("Variable " + Conversions.ToString((int) (index + 1)) + " is already in a group.\rPlease select another variable.", 0x30, "Variable already in group");
                            break;
                        }
                        item = item + " " + Conversions.ToString((int) (index + 1));
                    }
                    index = (short) (index + 1);
                }
            }
        }

        private void cmdAggregateTool_Click(object eventSender, EventArgs eventArgs)
        {
            frmAggregateOutputs outputs2 = new frmAggregateOutputs(ref this.frmSUFIMain, this.m_ProjectID) {
                lblSUFIProject = { Text = this.lstProjects.Text },
                UpDown1 = { Max = Convert.ToInt32(this.udIterationNumber.Maximum) },
                txtIterationNo = { Text = this.udIterationNumber.Text },
                m_ProjectName = this.lstProjects.Text
            };
            if (outputs2.GetProjectInfo() && outputs2.Update_Renamed())
            {
                outputs2.ShowDialog();
                outputs2 = null;
            }
        }

        private void cmdBrowseForCondBinFile_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.BrowseForCondBinFile())
            {
                string measuredBinFile = this.MeasuredBinFile;
                this.MeasuredBinFile = measuredBinFile;
                if (MiscFUncs.FillVarsList(ref measuredBinFile, ref this.lstAvailableVariables))
                {
                    this.m_BinFileIndexes = new short[3, this.lstAvailableVariables.Items.Count + 1];
                    this.lstVariablesInGoalFunction.Items.Clear();
                    this.cmdNext.Enabled = true;
                }
            }
        }

        private void cmdBrowseForSimFile_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.Hide();
            if (!this.m_bSingleSimulation)
            {
                this.frmSUFIMain.Show();
            }
            this.Close();
        }

        private void cmdNext_Click(object eventSender, EventArgs eventArgs)
        {
            short num2;
            short num15;
            string fname = "";
            string str3 = "";
            string expression = "";
            Recordset recordset = new RecordsetClass();
            switch (this.CurStep)
            {
                case 0:
                    if (this.m_bSingleSimulation)
                    {
                        this.cmdPrevious.Enabled = false;
                        goto TR_0009;
                    }
                    else if (this.lstProjects.Text != "")
                    {
                        this.m_ProjectName = this.lstProjects.Text;
                        if (this.GetProjectInfo())
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            recordset.Open("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString((int) this.m_IterationID), this.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            short num4 = 0;
                            Recordset recordset2 = recordset;
                            short nSimulations = (short) this.m_nSimulations;
                            num2 = 1;
                            while (true)
                            {
                                num15 = nSimulations;
                                if (num2 <= num15)
                                {
                                    fname = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((((this.m_sOutputPath + @"\") + "iter" + "_") + Conversions.ToString((int) this.m_IterationNo) + "_") + Conversions.ToString(this.m_BaseSimID) + "_", recordset2[]["StrataComboNo"][]), ".bin"));
                                    if (!MiscFUncs.FileExists(fname))
                                    {
                                        expression = expression + fname + "\r";
                                        num4 = (short) (num4 + 1);
                                    }
                                    recordset2.MoveNext();
                                    num2 = (short) (num2 + 1);
                                    continue;
                                }
                                recordset2.Close();
                                recordset2 = null;
                                Cursor.Current = Cursors.Default;
                                if (Strings.Len(expression) <= 0)
                                {
                                    this.lstSimulatedVar.Items.Clear();
                                    if (MiscFUncs.FillVarsList(ref fname, ref this.lstSimulatedVar))
                                    {
                                        goto TR_0009;
                                    }
                                }
                                else
                                {
                                    MiscFUncs.MsgBox_Renamed("The following files are missing: \r" + expression + "\r Make sure that the files are in the \rspecified directory (" + this.m_sOutputPath + ") and is \rnot being used by another application.", 0x30, "Missing file");
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        MiscFUncs.MsgBox_Renamed("Please select a project", 0x30, "Select project");
                    }
                    break;

                case 1:
                {
                    if (this.txtMissingData.Text == "")
                    {
                        MiscFUncs.MsgBox_Renamed("Please indicate how missing data is represented", 0x30, "Missing data");
                        break;
                    }
                    if (this.lstVariablesInGoalFunction.Items.Count == 0)
                    {
                        MiscFUncs.MsgBox_Renamed("Select at least one variable for the goal function", 0x30, "Select variable");
                        break;
                    }
                    this.lstCondVar.Items.Clear();
                    this.lstMeasured.Items.Clear();
                    short count = (short) this.lstVariablesInGoalFunction.Items.Count;
                    num2 = 1;
                    while (true)
                    {
                        num15 = count;
                        if (num2 > num15)
                        {
                            this.m_BinFileIndexes = new short[3, this.lstVariablesInGoalFunction.Items.Count + 1];
                            short num8 = (short) (this.lstVariablesInGoalFunction.Items.Count - 1);
                            num2 = 0;
                            while (true)
                            {
                                if (num2 > num8)
                                {
                                    this.m_nCondVars = (short) this.lstVariablesInGoalFunction.Items.Count;
                                    this.m_Weights = new float[this.m_nCondVars + 1];
                                    this.m_MissingData = this.txtMissingData.Text;
                                    break;
                                }
                                this.lstVariablesInGoalFunction.SelectedIndex = num2;
                                short num9 = (short) (this.lstAvailableVariables.Items.Count - 1);
                                short num3 = 0;
                                while (true)
                                {
                                    num15 = num9;
                                    if (num3 <= num15)
                                    {
                                        this.lstAvailableVariables.SelectedIndex = num3;
                                        if (this.lstAvailableVariables.Text != this.lstVariablesInGoalFunction.Text)
                                        {
                                            num3 = (short) (num3 + 1);
                                            continue;
                                        }
                                        this.m_BinFileIndexes[1, num2 + 1] = (short) (num3 + 1);
                                    }
                                    num2 = (short) (num2 + 1);
                                    break;
                                }
                            }
                            break;
                        }
                        this.lstVariablesInGoalFunction.SelectedIndex = num2 - 1;
                        this.lstCondVar.Items.Add(this.lstVariablesInGoalFunction.Text);
                        num2 = (short) (num2 + 1);
                    }
                    goto TR_0005;
                }
                case 3:
                {
                    str3 = "";
                    short count = (short) this.lstCondVar.Items.Count;
                    num2 = 1;
                    while (true)
                    {
                        num15 = count;
                        if (num2 <= num15)
                        {
                            if (this.m_BinFileIndexes[2, num2] == 0)
                            {
                                this.lstCondVar.SelectedIndex = num2 - 1;
                                if (str3 != "")
                                {
                                    str3 = str3 + "\r";
                                }
                                str3 = str3 + this.lstCondVar.Text;
                            }
                            num2 = (short) (num2 + 1);
                            continue;
                        }
                        if (str3 == "")
                        {
                            this.Groups = new short[this.m_nCondVars + 1, this.m_nCondVars + 1];
                            this.DetectionLimit = new float[this.m_nCondVars + 1];
                            this.m_GroupWeights = new float[this.m_nCondVars + 1];
                            short nCondVars = this.m_nCondVars;
                            num2 = 1;
                            while (true)
                            {
                                num15 = nCondVars;
                                if (num2 > num15)
                                {
                                    short num12 = (short) (this.lstCondVar.Items.Count - 1);
                                    num2 = 0;
                                    while (true)
                                    {
                                        num15 = num12;
                                        if (num2 > num15)
                                        {
                                            this.lstGroups.Items.Clear();
                                            if (this.m_bSingleSimulation)
                                            {
                                                this.lblSimFile[0].Visible = true;
                                                this.lblSimFile[1].Visible = true;
                                                this.cmdBrowseForSimFile.Visible = true;
                                            }
                                            break;
                                        }
                                        Support.SetItemString(this.lstMeasured, num2, Conversions.ToString((int) (num2 + 1)) + " " + Support.GetItemString(this.lstCondVar, num2));
                                        num2 = (short) (num2 + 1);
                                    }
                                    break;
                                }
                                this.m_GroupWeights[num2] = 1f;
                                num2 = (short) (num2 + 1);
                            }
                        }
                        else
                        {
                            MiscFUncs.MsgBox_Renamed("The following measured variables have not been matched:\r" + str3, 0x30, "Matching");
                            break;
                        }
                        break;
                    }
                    goto TR_0005;
                }
                case 4:
                    this.FillInGroups();
                    this.RecalcWeights();
                    if (this.m_bSingleSimulation)
                    {
                        if (!this.ComputeGoalFunction())
                        {
                            this.Cursor = Cursors.Default;
                        }
                        else
                        {
                            this.Hide();
                            MiscFUncs.MsgBox_Renamed("Goal function = \r" + Conversions.ToString(this.m_GoalFunction[1]), 0x40, "Results");
                            this.cmdPrevious.Enabled = true;
                            this.Show();
                        }
                        break;
                    }
                    goto TR_0005;

                case 5:
                {
                    if (!Versioned.IsNumeric(this.txtNoTolerances.Text))
                    {
                        MiscFUncs.MsgBox_Renamed("Incorrect number of tolerances (>1)", 0x30, "Error");
                        break;
                    }
                    if (Conversions.ToDouble(this.txtNoTolerances.Text) < 1.0)
                    {
                        MiscFUncs.MsgBox_Renamed("Incorrect number of tolerances (>1)", 0x30, "Error");
                        break;
                    }
                    short num13 = (short) (this.txtTol.Count() - 1);
                    num2 = 0;
                    while (true)
                    {
                        num15 = num13;
                        if (num2 <= num15)
                        {
                            if (Versioned.IsNumeric(this.txtTol[num2].Text))
                            {
                                num2 = (short) (num2 + 1);
                                continue;
                            }
                            MiscFUncs.MsgBox_Renamed("Incorrect tolerance interval", 0x30, "Error");
                            break;
                        }
                        else if (!(this.optToleranceInterval[1].Checked & (Conversions.ToDouble(this.txtTol[1].Text) <= 1.0)) || this.optGoalFunctionType[3].Checked)
                        {
                            if (!(this.optToleranceInterval[0].Checked & (Conversions.ToDouble(this.txtTol[0].Text) == 0.0)))
                            {
                                if (this.optToleranceInterval[2].Checked)
                                {
                                    short num14 = Conversions.ToShort(this.txtNoTolerances.Text);
                                    num2 = 2;
                                    while (true)
                                    {
                                        num15 = num14;
                                        if (num2 <= num15)
                                        {
                                            if (((short) Math.Round((double) (((this.m_nSimulations * (100.0 - Conversions.ToDouble(this.txtTol[2].Text))) * (num2 - 1)) * 0.01))) <= this.m_nSimulations)
                                            {
                                                num2 = (short) (num2 + 1);
                                                continue;
                                            }
                                            MiscFUncs.MsgBox_Renamed("Only " + Conversions.ToString((int) (num2 - 1)) + " tolerances possible.", 0x30, "Number of tolerances");
                                            this.txtNoTolerances.Text = Conversions.ToString((int) (num2 - 1));
                                        }
                                        break;
                                    }
                                }
                                this.m_Tolerances = new float[Conversions.ToInteger(this.txtNoTolerances.Text) + 1];
                                this.Cursor = Cursors.WaitCursor;
                                if (this.ComputeGoalFunction())
                                {
                                    this.Cursor = Cursors.Default;
                                    this.PrintStrataInformation(ref "");
                                    this.PrintIterationSummary(ref "");
                                    this.PrintStrataScore(ref "");
                                    this.optViewResult[2].Checked = true;
                                    this.optViewResult_CheckedChanged(this.optViewResult[2], new EventArgs());
                                    this.m_bDone = true;
                                }
                                else
                                {
                                    this.Cursor = Cursors.Default;
                                    break;
                                }
                            }
                            else
                            {
                                MiscFUncs.MsgBox_Renamed("Incorrect tolerance interval (>0)", 0x30, "Error");
                                break;
                            }
                        }
                        else
                        {
                            MiscFUncs.MsgBox_Renamed("Incorrect tolerance interval (>1)", 0x30, "Error");
                            break;
                        }
                        break;
                    }
                    goto TR_0005;
                }
                case 6:
                    this.m_bDone = false;
                    this.Close();
                    this.frmSUFIMain.Show();
                    break;

                default:
                    goto TR_0005;
            }
            return;
        TR_0005:
            this.cmdPrevious.Enabled = (this.CurStep != -1) ? (this.m_bSingleSimulation ? !((this.CurStep == 0) & this.m_bSingleSimulation) : true) : false;
            if (this.CurStep == this.fraStep.UBound())
            {
                this.Close();
            }
            this.cmdNext.Text = ((this.CurStep + 1) != this.fraStep.UBound()) ? (!((this.CurStep == 3) & this.m_bSingleSimulation) ? "&Next" : "&Finish") : "&Exit";
            this.CurStep = (short) (this.CurStep + 1);
            if (this.CurStep != 7)
            {
                this.DisplayStep();
            }
            return;
        TR_0009:
            this.cmdNext.Enabled = false;
            goto TR_0005;
        }

        private void cmdPrevious_Click(object eventSender, EventArgs eventArgs)
        {
            if ((this.CurStep - 1) == this.fraStep.LBound())
            {
                this.cmdPrevious.Enabled = false;
            }
            if (((this.CurStep - 1) == 1) & this.m_bSingleSimulation)
            {
                this.cmdPrevious.Enabled = false;
            }
            if (this.m_bSingleSimulation)
            {
                this.cmdNext.Text = "&Next";
            }
            switch (this.CurStep)
            {
                case 1:
                    this.cmdNext.Enabled = true;
                    break;

                case 5:
                    this.m_bFilesRead = false;
                    this.Groups = new short[this.m_nCondVars + 1, this.m_nCondVars + 1];
                    this.lstGroups.Items.Clear();
                    break;

                case 6:
                    this.cmdNext.Text = "&Next";
                    break;

                default:
                    break;
            }
            this.CurStep = (short) (this.CurStep - 1);
            this.DisplayStep();
        }

        private void cmdRemoveAll_Click(object eventSender, EventArgs eventArgs)
        {
            this.lstVariablesInGoalFunction.Items.Clear();
        }

        private void cmdRemoveVariable_Click(object eventSender, EventArgs eventArgs)
        {
            if (!((this.lstVariablesInGoalFunction.Items.Count == 0) | (this.lstVariablesInGoalFunction.SelectedIndex < 0)))
            {
                this.lstVariablesInGoalFunction.Items.RemoveAt(this.lstVariablesInGoalFunction.SelectedIndex);
            }
        }

        private void cmdResetGroups_Click(object eventSender, EventArgs eventArgs)
        {
            this.lstGroups.Items.Clear();
            this.Groups = new short[this.m_nCondVars + 1, this.m_nCondVars + 1];
            this.DetectionLimit = new float[this.m_nCondVars + 1];
        }

        public void cmdSet_Click(object eventSender, EventArgs eventArgs)
        {
            this.SetIndexes();
        }

        private void cmdSetDetectionLimit_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.lstGroups.SelectedItems.Count != 1)
            {
                MiscFUncs.MsgBox_Renamed("Please select a group to which this detection limit should apply", 0x40, "Select group");
            }
            else if (!Versioned.IsNumeric(this.txtDetectionLimit.Text))
            {
                MiscFUncs.MsgBox_Renamed("Please supply a numeric value for the detection limit", 0x30, "Numerical value");
            }
            else
            {
                short num2 = (short) (this.lstGroups.Items.Count - 1);
                short index = 0;
                while (true)
                {
                    short num3 = num2;
                    if (index > num3)
                    {
                        break;
                    }
                    if (this.lstGroups.GetSelected(index))
                    {
                        this.DetectionLimit[index + 1] = Conversions.ToSingle(this.txtDetectionLimit.Text);
                    }
                    index = (short) (index + 1);
                }
            }
        }

        private void cmdSetWeight_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.lstGroups.SelectedItems.Count != 1)
            {
                MiscFUncs.MsgBox_Renamed("Please select a group to which this weight should apply", 0x40, "Select group");
            }
            else if (!Versioned.IsNumeric(this.txtGroupWeight.Text))
            {
                MiscFUncs.MsgBox_Renamed("Please supply a numeric value for the weight", 0x30, "Numerical value");
            }
            else
            {
                short num2 = (short) (this.lstGroups.Items.Count - 1);
                short index = 0;
                while (true)
                {
                    short num3 = num2;
                    if (index > num3)
                    {
                        break;
                    }
                    if (this.lstGroups.GetSelected(index))
                    {
                        this.m_GroupWeights[index + 1] = Conversions.ToSingle(this.txtGroupWeight.Text);
                    }
                    index = (short) (index + 1);
                }
            }
        }

        private bool ComputeGoalFunction()
        {
            // Invalid method body.
        }

        private bool ComputeSensitivity()
        {
            // Invalid method body.
        }

        private void dblstProjects_ClickEvent(object eventSender, EventArgs eventArgs)
        {
            if (Strings.Len(this.lstProjects.Text) > 0)
            {
                this.cmdAggregateTool.Enabled = true;
                this.udIterationNumber.Enabled = true;
                this.m_ProjectName = this.lstProjects.Text;
                this.GetProjectInfo();
                this.m_IterationNo = Convert.ToInt16(this.udIterationNumber.Maximum);
                this.udIterationNumber.Value = this.udIterationNumber.Maximum;
            }
        }

        private void DisplayStep()
        {
            this.HideAll();
            this.fraStep[this.CurStep].Left = 0;
            this.fraAggregate.Left = (this.CurStep != 0) ? ((int) Math.Round(Support.TwipsToPixelsX(-10000.0))) : 0;
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

        private void FillGroupListBox()
        {
            string item = "";
            this.lstGroups.Items.Clear();
            short nCondVars = this.m_nCondVars;
            short num = 1;
            while (true)
            {
                if ((num <= nCondVars) && (this.Groups[num, 1] != 0))
                {
                    short num4 = this.m_nCondVars;
                    short num2 = 1;
                    while (true)
                    {
                        short num5 = num4;
                        if (num2 > num5)
                        {
                            this.lstGroups.Items.Add(item);
                            item = "";
                            num = (short) (num + 1);
                            break;
                        }
                        if (this.Groups[num, num2] != 0)
                        {
                            item = item + " " + Conversions.ToString((int) this.Groups[num, num2]);
                        }
                        num2 = (short) (num2 + 1);
                    }
                    continue;
                }
                return;
            }
        }

        private void FillInGroups()
        {
            short count = (short) this.lstGroups.Items.Count;
            short nCondVars = this.m_nCondVars;
            short varno = 1;
            while (true)
            {
                short num9 = nCondVars;
                if (varno > num9)
                {
                    short num2;
                    if (count == 0)
                    {
                        count = this.m_nCondVars;
                    }
                    short[,] numArray = new short[count + 1, this.m_nCondVars + 1];
                    short num5 = count;
                    varno = 1;
                    while (varno <= num5)
                    {
                        short num6 = this.m_nCondVars;
                        num2 = 1;
                        while (true)
                        {
                            num9 = num6;
                            if (num2 > num9)
                            {
                                varno = (short) (varno + 1);
                                break;
                            }
                            numArray[varno, num2] = this.Groups[varno, num2];
                            num2 = (short) (num2 + 1);
                        }
                    }
                    this.Groups = new short[count + 1, this.m_nCondVars + 1];
                    short num7 = count;
                    varno = 1;
                    while (varno <= num7)
                    {
                        short num8 = this.m_nCondVars;
                        num2 = 1;
                        while (true)
                        {
                            num9 = num8;
                            if (num2 > num9)
                            {
                                varno = (short) (varno + 1);
                                break;
                            }
                            this.Groups[varno, num2] = numArray[varno, num2];
                            num2 = (short) (num2 + 1);
                        }
                    }
                    return;
                }
                if (!this.IsInGroup(ref varno))
                {
                    this.Groups[count + 1, 1] = varno;
                    count = (short) (count + 1);
                }
                varno = (short) (varno + 1);
            }
        }

        private void Form_Terminate_Renamed()
        {
            this.flag = 0;
        }

        private void frmAnalyseSUFI_Activated(object eventSender, EventArgs eventArgs)
        {
            if (!this.m_bSingleSimulation & (this.flag == 0))
            {
                this.SetupControls();
                this.HideAll();
                this.CurStep = -1;
                this.cmdNext_Click(this.cmdNext, new EventArgs());
            }
            else if (this.flag == 0)
            {
                this.HideAll();
                MiscFUncs.FillVarsList(ref this.m_SimFileName, ref this.lstSimulatedVar);
                this.CurStep = 0;
                this.cmdNext_Click(this.cmdNext, new EventArgs());
            }
            this.flag = 1;
        }

        private void frmAnalyseSUFI_FormClosed(object eventSender, FormClosedEventArgs eventArgs)
        {
            this.flag = 0;
        }

        private void frmAnalyseSUFI_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmSUFIMain.Icon;
        }

        private bool GetProjectInfo()
        {
            // Invalid method body.
        }

        private void GetStrataCombination(ref short[] StrataNr, ref Recordset rs)
        {
            short start = 1;
            string str = Strings.Trim(Conversions.ToString(rs[]["Combo"][]));
            short nParameters = this.m_nParameters;
            short index = 1;
            while (true)
            {
                short num5 = nParameters;
                if (index > num5)
                {
                    return;
                }
                short num3 = (short) Strings.InStr(start, str, " ", CompareMethod.Binary);
                bool flag = num3 == 0;
                StrataNr[index] = !flag ? ((short) Conversions.ToInteger(Strings.Mid(str, start, (short) (num3 - start)))) : ((short) Conversions.ToInteger(Strings.Mid(str, start, (Strings.Len(str) + 1) - start)));
                start = (short) (num3 + 1);
                index = (short) (index + 1);
            }
        }

        private float GoalDev()
        {
            float num3 = this.GoalMean();
            short num4 = (short) Information.UBound(this.m_GoalFunction, 1);
            short index = (short) Information.LBound(this.m_GoalFunction, 1);
            while (true)
            {
                float num;
                short num5 = num4;
                if (index > num5)
                {
                    return (float) Math.Sqrt((double) (num / ((float) ((Information.UBound(this.m_GoalFunction, 1) - Information.LBound(this.m_GoalFunction, 1)) + 1))));
                }
                num += (this.m_GoalFunction[index] - num3) * (this.m_GoalFunction[index] - num3);
                index = (short) (index + 1);
            }
        }

        private float GoalMean()
        {
            short num3 = (short) Information.UBound(this.m_GoalFunction, 1);
            short index = (short) Information.LBound(this.m_GoalFunction, 1);
            while (true)
            {
                float num;
                short num4 = num3;
                if (index > num4)
                {
                    return (num / ((float) ((Information.UBound(this.m_GoalFunction, 1) - Information.LBound(this.m_GoalFunction, 1)) + 1)));
                }
                num += this.m_GoalFunction[index];
                index = (short) (index + 1);
            }
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
                    this.fraAggregate.Left = (int) Math.Round(Support.TwipsToPixelsX(-10000.0));
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmAnalyseSUFI));
            this.Label18 = new Label();
            this.fraAggregate = new GroupBox();
            this.cmdAggregateTool = new Button();
            this.Label24 = new Label();
            this._fraStep_4 = new GroupBox();
            this.cmdSetWeight = new Button();
            this.txtGroupWeight = new TextBox();
            this.cmdBrowseForSimFile = new Button();
            this.cmdSetDetectionLimit = new Button();
            this.txtDetectionLimit = new TextBox();
            this.cmdResetGroups = new Button();
            this.cmdAggregate = new Button();
            this.lstGroups = new ListBox();
            this.lstMeasured = new ListBox();
            this.Label19 = new Label();
            this._lblSimFile_1 = new Label();
            this._lblSimFile_0 = new Label();
            this.Label17 = new Label();
            this.Label16 = new Label();
            this.Label15 = new Label();
            this.Label14 = new Label();
            this._lblStep_2 = new Label();
            this._fraStep_3 = new GroupBox();
            this.Frame3 = new GroupBox();
            this.cmdSet = new Button();
            this.lstSimulatedVar = new ListBox();
            this.lstCondVar = new ListBox();
            this.Label11 = new Label();
            this.Label10 = new Label();
            this._lblStep_5 = new Label();
            this._fraStep_2 = new GroupBox();
            this.Frame5 = new GroupBox();
            this._optMultAdd_1 = new RadioButton();
            this._optMultAdd_0 = new RadioButton();
            this.Frame2 = new GroupBox();
            this.txtOffSet = new TextBox();
            this.chkLogValues = new CheckBox();
            this._optGoalFunctionType_3 = new RadioButton();
            this._optGoalFunctionType_2 = new RadioButton();
            this._optGoalFunctionType_1 = new RadioButton();
            this._optGoalFunctionType_0 = new RadioButton();
            this._lblStep_1 = new Label();
            this.cmdCancel = new Button();
            this.cmdPrevious = new Button();
            this.cmdNext = new Button();
            this._fraStep_6 = new GroupBox();
            this._optViewResult_4 = new RadioButton();
            this._optViewResult_3 = new RadioButton();
            this._optViewResult_2 = new RadioButton();
            this._optViewResult_1 = new RadioButton();
            this.txtReport = new TextBox();
            this._optViewResult_0 = new RadioButton();
            this._fraStep_5 = new GroupBox();
            this.Frame4 = new GroupBox();
            this._txtTol_2 = new TextBox();
            this._optToleranceInterval_2 = new RadioButton();
            this.chkAddVariance = new CheckBox();
            this._txtTol_1 = new TextBox();
            this._txtTol_0 = new TextBox();
            this._optToleranceInterval_1 = new RadioButton();
            this._optToleranceInterval_0 = new RadioButton();
            this.txtNoTolerances = new TextBox();
            this.Label13 = new Label();
            this.Label12 = new Label();
            this.Label23 = new Label();
            this.Label22 = new Label();
            this.Label21 = new Label();
            this.Label20 = new Label();
            this._fraStep_1 = new GroupBox();
            this.txtMissingData = new TextBox();
            this.Frame1 = new GroupBox();
            this.cmdRemoveAll = new Button();
            this.cmdAddAll = new Button();
            this.cmdRemoveVariable = new Button();
            this.cmdAddVariable = new Button();
            this.lstVariablesInGoalFunction = new ListBox();
            this.lstAvailableVariables = new ListBox();
            this.cmdBrowseForCondBinFile = new Button();
            this.Label8 = new Label();
            this.Label7 = new Label();
            this.lblCondBinFile = new Label();
            this.Label6 = new Label();
            this.Label9 = new Label();
            this.Label5 = new Label();
            this._fraStep_0 = new GroupBox();
            this.udIterationNumber = new NumericUpDown();
            this.lstProjects = new ListBox();
            this.Frame6 = new GroupBox();
            this.cmdStartScript = new Button();
            this.cmdBrowseForScript = new Button();
            this.txtScriptFile = new TextBox();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this._lblStep_0 = new Label();
            this.fraStep = new GroupBoxArray(this.components);
            this.lblSimFile = new LabelArray(this.components);
            this.lblStep = new LabelArray(this.components);
            this.optGoalFunctionType = new RadioButtonArray(this.components);
            this.optMultAdd = new RadioButtonArray(this.components);
            this.optToleranceInterval = new RadioButtonArray(this.components);
            this.optViewResult = new RadioButtonArray(this.components);
            this.txtTol = new TextBoxArray(this.components);
            this.fraAggregate.SuspendLayout();
            this._fraStep_4.SuspendLayout();
            this._fraStep_3.SuspendLayout();
            this.Frame3.SuspendLayout();
            this._fraStep_2.SuspendLayout();
            this.Frame5.SuspendLayout();
            this.Frame2.SuspendLayout();
            this._fraStep_6.SuspendLayout();
            this._fraStep_5.SuspendLayout();
            this.Frame4.SuspendLayout();
            this._fraStep_1.SuspendLayout();
            this.Frame1.SuspendLayout();
            this._fraStep_0.SuspendLayout();
            this.udIterationNumber.BeginInit();
            this.Frame6.SuspendLayout();
            ((ISupportInitialize) this.fraStep).BeginInit();
            ((ISupportInitialize) this.lblSimFile).BeginInit();
            ((ISupportInitialize) this.lblStep).BeginInit();
            ((ISupportInitialize) this.optGoalFunctionType).BeginInit();
            ((ISupportInitialize) this.optMultAdd).BeginInit();
            ((ISupportInitialize) this.optToleranceInterval).BeginInit();
            ((ISupportInitialize) this.optViewResult).BeginInit();
            ((ISupportInitialize) this.txtTol).BeginInit();
            this.SuspendLayout();
            this.Label18.BackColor = SystemColors.Control;
            this.Label18.Cursor = Cursors.Default;
            this.Label18.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label18.ForeColor = SystemColors.ControlText;
            Point point = new Point(0xb0, 0x58);
            this.Label18.Location = point;
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = RightToLeft.No;
            Size size = new Size(0x31, 0x11);
            this.Label18.Size = size;
            this.Label18.TabIndex = 0x52;
            this.Label18.Text = "&Off-set:";
            this.fraAggregate.BackColor = SystemColors.Control;
            this.fraAggregate.Controls.Add(this.cmdAggregateTool);
            this.fraAggregate.Controls.Add(this.Label24);
            this.fraAggregate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraAggregate.ForeColor = SystemColors.ControlText;
            point = new Point(-10000, 0xc0);
            this.fraAggregate.Location = point;
            this.fraAggregate.Name = "fraAggregate";
            this.fraAggregate.RightToLeft = RightToLeft.No;
            size = new Size(0x1d9, 0x79);
            this.fraAggregate.Size = size;
            this.fraAggregate.TabIndex = 0x61;
            this.fraAggregate.TabStop = false;
            this.fraAggregate.Text = "Aggregate output";
            this.cmdAggregateTool.BackColor = SystemColors.Control;
            this.cmdAggregateTool.Cursor = Cursors.Default;
            this.cmdAggregateTool.Enabled = false;
            this.cmdAggregateTool.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdAggregateTool.ForeColor = SystemColors.ControlText;
            point = new Point(8, 40);
            this.cmdAggregateTool.Location = point;
            this.cmdAggregateTool.Name = "cmdAggregateTool";
            this.cmdAggregateTool.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x19);
            this.cmdAggregateTool.Size = size;
            this.cmdAggregateTool.TabIndex = 0x63;
            this.cmdAggregateTool.Text = "&Aggregate";
            this.cmdAggregateTool.UseVisualStyleBackColor = false;
            this.Label24.BackColor = SystemColors.Control;
            this.Label24.Cursor = Cursors.Default;
            this.Label24.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label24.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x1b);
            this.Label24.Location = point;
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = RightToLeft.No;
            size = new Size(0x1c9, 0x39);
            this.Label24.Size = size;
            this.Label24.TabIndex = 0x62;
            this.Label24.Text = "Click below to go to the tool to aggregate the outputs for the above selected iteration. ";
            this._fraStep_4.BackColor = SystemColors.Control;
            this._fraStep_4.Controls.Add(this.cmdSetWeight);
            this._fraStep_4.Controls.Add(this.txtGroupWeight);
            this._fraStep_4.Controls.Add(this.cmdBrowseForSimFile);
            this._fraStep_4.Controls.Add(this.cmdSetDetectionLimit);
            this._fraStep_4.Controls.Add(this.txtDetectionLimit);
            this._fraStep_4.Controls.Add(this.cmdResetGroups);
            this._fraStep_4.Controls.Add(this.cmdAggregate);
            this._fraStep_4.Controls.Add(this.lstGroups);
            this._fraStep_4.Controls.Add(this.lstMeasured);
            this._fraStep_4.Controls.Add(this.Label19);
            this._fraStep_4.Controls.Add(this._lblSimFile_1);
            this._fraStep_4.Controls.Add(this._lblSimFile_0);
            this._fraStep_4.Controls.Add(this.Label17);
            this._fraStep_4.Controls.Add(this.Label16);
            this._fraStep_4.Controls.Add(this.Label15);
            this._fraStep_4.Controls.Add(this.Label14);
            this._fraStep_4.Controls.Add(this._lblStep_2);
            this._fraStep_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_4.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_4, 4);
            point = new Point(-10000, 0);
            this._fraStep_4.Location = point;
            this._fraStep_4.Name = "_fraStep_4";
            this._fraStep_4.RightToLeft = RightToLeft.No;
            size = new Size(0x1dd, 0x127);
            this._fraStep_4.Size = size;
            this._fraStep_4.TabIndex = 0x45;
            this._fraStep_4.TabStop = false;
            this._fraStep_4.Text = "Define goal function IV";
            this.cmdSetWeight.BackColor = SystemColors.Control;
            this.cmdSetWeight.Cursor = Cursors.Default;
            this.cmdSetWeight.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdSetWeight.ForeColor = SystemColors.ControlText;
            point = new Point(400, 0x100);
            this.cmdSetWeight.Location = point;
            this.cmdSetWeight.Name = "cmdSetWeight";
            this.cmdSetWeight.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x15);
            this.cmdSetWeight.Size = size;
            this.cmdSetWeight.TabIndex = 0x5b;
            this.cmdSetWeight.Text = "S&et";
            this.cmdSetWeight.UseVisualStyleBackColor = false;
            this.txtGroupWeight.AcceptsReturn = true;
            this.txtGroupWeight.BackColor = SystemColors.Window;
            this.txtGroupWeight.Cursor = Cursors.IBeam;
            this.txtGroupWeight.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtGroupWeight.ForeColor = SystemColors.WindowText;
            point = new Point(0x160, 0x100);
            this.txtGroupWeight.Location = point;
            this.txtGroupWeight.MaxLength = 0;
            this.txtGroupWeight.Name = "txtGroupWeight";
            this.txtGroupWeight.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this.txtGroupWeight.Size = size;
            this.txtGroupWeight.TabIndex = 90;
            this.txtGroupWeight.Text = "1";
            this.cmdBrowseForSimFile.BackColor = SystemColors.Control;
            this.cmdBrowseForSimFile.Cursor = Cursors.Default;
            this.cmdBrowseForSimFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseForSimFile.ForeColor = SystemColors.ControlText;
            point = new Point(0x128, 0x110);
            this.cmdBrowseForSimFile.Location = point;
            this.cmdBrowseForSimFile.Name = "cmdBrowseForSimFile";
            this.cmdBrowseForSimFile.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.cmdBrowseForSimFile.Size = size;
            this.cmdBrowseForSimFile.TabIndex = 0x56;
            this.cmdBrowseForSimFile.Text = "...";
            this.cmdBrowseForSimFile.UseVisualStyleBackColor = false;
            this.cmdBrowseForSimFile.Visible = false;
            this.cmdSetDetectionLimit.BackColor = SystemColors.Control;
            this.cmdSetDetectionLimit.Cursor = Cursors.Default;
            this.cmdSetDetectionLimit.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdSetDetectionLimit.ForeColor = SystemColors.ControlText;
            point = new Point(400, 0xe8);
            this.cmdSetDetectionLimit.Location = point;
            this.cmdSetDetectionLimit.Name = "cmdSetDetectionLimit";
            this.cmdSetDetectionLimit.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this.cmdSetDetectionLimit.Size = size;
            this.cmdSetDetectionLimit.TabIndex = 80;
            this.cmdSetDetectionLimit.Text = "&Set";
            this.cmdSetDetectionLimit.UseVisualStyleBackColor = false;
            this.txtDetectionLimit.AcceptsReturn = true;
            this.txtDetectionLimit.BackColor = SystemColors.Window;
            this.txtDetectionLimit.Cursor = Cursors.IBeam;
            this.txtDetectionLimit.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtDetectionLimit.ForeColor = SystemColors.WindowText;
            point = new Point(0x160, 0xe8);
            this.txtDetectionLimit.Location = point;
            this.txtDetectionLimit.MaxLength = 0;
            this.txtDetectionLimit.Name = "txtDetectionLimit";
            this.txtDetectionLimit.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this.txtDetectionLimit.Size = size;
            this.txtDetectionLimit.TabIndex = 0x4f;
            this.txtDetectionLimit.Text = "0";
            this.cmdResetGroups.BackColor = SystemColors.Control;
            this.cmdResetGroups.Cursor = Cursors.Default;
            this.cmdResetGroups.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdResetGroups.ForeColor = SystemColors.ControlText;
            point = new Point(0x58, 0xe8);
            this.cmdResetGroups.Location = point;
            this.cmdResetGroups.Name = "cmdResetGroups";
            this.cmdResetGroups.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdResetGroups.Size = size;
            this.cmdResetGroups.TabIndex = 0x4c;
            this.cmdResetGroups.Text = "&Reset";
            this.cmdResetGroups.UseVisualStyleBackColor = false;
            this.cmdAggregate.BackColor = SystemColors.Control;
            this.cmdAggregate.Cursor = Cursors.Default;
            this.cmdAggregate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdAggregate.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xe8);
            this.cmdAggregate.Location = point;
            this.cmdAggregate.Name = "cmdAggregate";
            this.cmdAggregate.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdAggregate.Size = size;
            this.cmdAggregate.TabIndex = 0x4b;
            this.cmdAggregate.Text = "&Aggregate";
            this.cmdAggregate.UseVisualStyleBackColor = false;
            this.lstGroups.BackColor = SystemColors.Window;
            this.lstGroups.Cursor = Cursors.Default;
            this.lstGroups.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstGroups.ForeColor = SystemColors.WindowText;
            this.lstGroups.ItemHeight = 14;
            point = new Point(280, 0x80);
            this.lstGroups.Location = point;
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x58);
            this.lstGroups.Size = size;
            this.lstGroups.TabIndex = 0x48;
            this.lstMeasured.BackColor = SystemColors.Window;
            this.lstMeasured.Cursor = Cursors.Default;
            this.lstMeasured.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstMeasured.ForeColor = SystemColors.WindowText;
            this.lstMeasured.ItemHeight = 14;
            point = new Point(8, 0x80);
            this.lstMeasured.Location = point;
            this.lstMeasured.Name = "lstMeasured";
            this.lstMeasured.RightToLeft = RightToLeft.No;
            this.lstMeasured.SelectionMode = SelectionMode.MultiExtended;
            size = new Size(0x101, 0x58);
            this.lstMeasured.Size = size;
            this.lstMeasured.TabIndex = 0x47;
            this.Label19.BackColor = SystemColors.Control;
            this.Label19.Cursor = Cursors.Default;
            this.Label19.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label19.ForeColor = SystemColors.ControlText;
            point = new Point(280, 0x100);
            this.Label19.Location = point;
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label19.Size = size;
            this.Label19.TabIndex = 0x59;
            this.Label19.Text = "Group &weight:";
            this._lblSimFile_1.BackColor = SystemColors.Window;
            this._lblSimFile_1.BorderStyle = BorderStyle.FixedSingle;
            this._lblSimFile_1.Cursor = Cursors.Default;
            this._lblSimFile_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblSimFile_1.ForeColor = SystemColors.WindowText;
            this.lblSimFile.SetIndex(this._lblSimFile_1, 1);
            point = new Point(0x58, 0x10f);
            this._lblSimFile_1.Location = point;
            this._lblSimFile_1.Name = "_lblSimFile_1";
            this._lblSimFile_1.RightToLeft = RightToLeft.No;
            size = new Size(0xc9, 0x11);
            this._lblSimFile_1.Size = size;
            this._lblSimFile_1.TabIndex = 0x55;
            this._lblSimFile_1.Visible = false;
            this._lblSimFile_0.BackColor = SystemColors.Control;
            this._lblSimFile_0.Cursor = Cursors.Default;
            this._lblSimFile_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblSimFile_0.ForeColor = SystemColors.ControlText;
            this.lblSimFile.SetIndex(this._lblSimFile_0, 0);
            point = new Point(8, 0x110);
            this._lblSimFile_0.Location = point;
            this._lblSimFile_0.Name = "_lblSimFile_0";
            this._lblSimFile_0.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this._lblSimFile_0.Size = size;
            this._lblSimFile_0.TabIndex = 0x54;
            this._lblSimFile_0.Text = "Simulation file:";
            this._lblSimFile_0.Visible = false;
            this.Label17.BackColor = SystemColors.Control;
            this.Label17.Cursor = Cursors.Default;
            this.Label17.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label17.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x48);
            this.Label17.Location = point;
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = RightToLeft.No;
            size = new Size(0x1b1, 0x21);
            this.Label17.Size = size;
            this.Label17.TabIndex = 0x51;
            this.Label17.Text = "Each group can be given a detection limit. Simulated values below this limit will be set to zero when computing the goal function. Detection limits can only be set for defined groups. ";
            this.Label16.BackColor = SystemColors.Control;
            this.Label16.Cursor = Cursors.Default;
            this.Label16.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label16.ForeColor = SystemColors.ControlText;
            point = new Point(280, 0xe8);
            this.Label16.Location = point;
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label16.Size = size;
            this.Label16.TabIndex = 0x4e;
            this.Label16.Text = "&Detection limit:";
            this.Label15.BackColor = SystemColors.Control;
            this.Label15.Cursor = Cursors.Default;
            this.Label15.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label15.ForeColor = SystemColors.ControlText;
            point = new Point(280, 0x70);
            this.Label15.Location = point;
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = RightToLeft.No;
            size = new Size(0xb1, 0x11);
            this.Label15.Size = size;
            this.Label15.TabIndex = 0x4a;
            this.Label15.Text = "Groups (variable numbers)";
            this.Label14.BackColor = SystemColors.Control;
            this.Label14.Cursor = Cursors.Default;
            this.Label14.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label14.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x70);
            this.Label14.Location = point;
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x11);
            this.Label14.Size = size;
            this.Label14.TabIndex = 0x49;
            this.Label14.Text = "Measured variables:";
            this._lblStep_2.BackColor = SystemColors.Control;
            this._lblStep_2.Cursor = Cursors.Default;
            this._lblStep_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_2.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_2, 2);
            point = new Point(8, 0x18);
            this._lblStep_2.Location = point;
            this._lblStep_2.Name = "_lblStep_2";
            this._lblStep_2.RightToLeft = RightToLeft.No;
            size = new Size(440, 0x39);
            this._lblStep_2.Size = size;
            this._lblStep_2.TabIndex = 70;
            this._lblStep_2.Text = manager.GetString("_lblStep_2.Text");
            this._fraStep_3.BackColor = SystemColors.Control;
            this._fraStep_3.Controls.Add(this.Frame3);
            this._fraStep_3.Controls.Add(this._lblStep_5);
            this._fraStep_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_3.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_3, 3);
            point = new Point(-1000, 0);
            this._fraStep_3.Location = point;
            this._fraStep_3.Name = "_fraStep_3";
            this._fraStep_3.RightToLeft = RightToLeft.No;
            size = new Size(0x1d5, 0x137);
            this._fraStep_3.Size = size;
            this._fraStep_3.TabIndex = 0x1c;
            this._fraStep_3.TabStop = false;
            this._fraStep_3.Text = "Define goal function III";
            this.Frame3.BackColor = SystemColors.Control;
            this.Frame3.Controls.Add(this.cmdSet);
            this.Frame3.Controls.Add(this.lstSimulatedVar);
            this.Frame3.Controls.Add(this.lstCondVar);
            this.Frame3.Controls.Add(this.Label11);
            this.Frame3.Controls.Add(this.Label10);
            this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x58);
            this.Frame3.Location = point;
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = RightToLeft.No;
            size = new Size(0x1c9, 0xd9);
            this.Frame3.Size = size;
            this.Frame3.TabIndex = 0x21;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Match measured and simulated variables";
            this.cmdSet.BackColor = SystemColors.Control;
            this.cmdSet.Cursor = Cursors.Default;
            this.cmdSet.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdSet.ForeColor = SystemColors.ControlText;
            point = new Point(0x170, 0xc0);
            this.cmdSet.Location = point;
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x19);
            this.cmdSet.Size = size;
            this.cmdSet.TabIndex = 0x27;
            this.cmdSet.Text = "&Set";
            this.cmdSet.UseVisualStyleBackColor = false;
            this.cmdSet.Visible = false;
            this.lstSimulatedVar.BackColor = SystemColors.Window;
            this.lstSimulatedVar.Cursor = Cursors.Default;
            this.lstSimulatedVar.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstSimulatedVar.ForeColor = SystemColors.WindowText;
            this.lstSimulatedVar.ItemHeight = 14;
            point = new Point(0xc0, 40);
            this.lstSimulatedVar.Location = point;
            this.lstSimulatedVar.Name = "lstSimulatedVar";
            this.lstSimulatedVar.RightToLeft = RightToLeft.No;
            size = new Size(0x101, 0x9e);
            this.lstSimulatedVar.Size = size;
            this.lstSimulatedVar.TabIndex = 0x25;
            this.lstCondVar.BackColor = SystemColors.Window;
            this.lstCondVar.Cursor = Cursors.Default;
            this.lstCondVar.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstCondVar.ForeColor = SystemColors.WindowText;
            this.lstCondVar.ItemHeight = 14;
            point = new Point(8, 40);
            this.lstCondVar.Location = point;
            this.lstCondVar.Name = "lstCondVar";
            this.lstCondVar.RightToLeft = RightToLeft.No;
            size = new Size(0xb1, 0x9e);
            this.lstCondVar.Size = size;
            this.lstCondVar.TabIndex = 0x24;
            this.Label11.BackColor = SystemColors.Control;
            this.Label11.Cursor = Cursors.Default;
            this.Label11.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label11.ForeColor = SystemColors.ControlText;
            point = new Point(0xc0, 0x18);
            this.Label11.Location = point;
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.Label11.Size = size;
            this.Label11.TabIndex = 0x23;
            this.Label11.Text = "Simulated variable:";
            this.Label10.BackColor = SystemColors.Control;
            this.Label10.Cursor = Cursors.Default;
            this.Label10.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label10.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label10.Location = point;
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = RightToLeft.No;
            size = new Size(0x69, 0x11);
            this.Label10.Size = size;
            this.Label10.TabIndex = 0x22;
            this.Label10.Text = "Measured variable:";
            this._lblStep_5.BackColor = SystemColors.Control;
            this._lblStep_5.Cursor = Cursors.Default;
            this._lblStep_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_5.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_5, 5);
            point = new Point(8, 0x18);
            this._lblStep_5.Location = point;
            this._lblStep_5.Name = "_lblStep_5";
            this._lblStep_5.RightToLeft = RightToLeft.No;
            size = new Size(440, 0x41);
            this._lblStep_5.Size = size;
            this._lblStep_5.TabIndex = 0x1d;
            this._lblStep_5.Text = manager.GetString("_lblStep_5.Text");
            this._fraStep_2.BackColor = SystemColors.Control;
            this._fraStep_2.Controls.Add(this.Frame5);
            this._fraStep_2.Controls.Add(this.Frame2);
            this._fraStep_2.Controls.Add(this._lblStep_1);
            this._fraStep_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_2.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_2, 2);
            point = new Point(-1000, 0);
            this._fraStep_2.Location = point;
            this._fraStep_2.Name = "_fraStep_2";
            this._fraStep_2.RightToLeft = RightToLeft.No;
            size = new Size(0x1d5, 0x137);
            this._fraStep_2.Size = size;
            this._fraStep_2.TabIndex = 0x1a;
            this._fraStep_2.TabStop = false;
            this._fraStep_2.Text = "Define goal function II";
            this.Frame5.BackColor = SystemColors.Control;
            this.Frame5.Controls.Add(this._optMultAdd_1);
            this.Frame5.Controls.Add(this._optMultAdd_0);
            this.Frame5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0xb0);
            this.Frame5.Location = point;
            this.Frame5.Name = "Frame5";
            this.Frame5.RightToLeft = RightToLeft.No;
            size = new Size(0x121, 0x49);
            this.Frame5.Size = size;
            this.Frame5.TabIndex = 0x30;
            this.Frame5.TabStop = false;
            this.Frame5.Text = "Settings";
            this._optMultAdd_1.BackColor = SystemColors.Control;
            this._optMultAdd_1.Cursor = Cursors.Default;
            this._optMultAdd_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optMultAdd_1.ForeColor = SystemColors.ControlText;
            this.optMultAdd.SetIndex(this._optMultAdd_1, 1);
            point = new Point(0x10, 0x30);
            this._optMultAdd_1.Location = point;
            this._optMultAdd_1.Name = "_optMultAdd_1";
            this._optMultAdd_1.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this._optMultAdd_1.Size = size;
            this._optMultAdd_1.TabIndex = 50;
            this._optMultAdd_1.TabStop = true;
            this._optMultAdd_1.Text = "additive";
            this._optMultAdd_1.UseVisualStyleBackColor = false;
            this._optMultAdd_0.BackColor = SystemColors.Control;
            this._optMultAdd_0.Checked = true;
            this._optMultAdd_0.Cursor = Cursors.Default;
            this._optMultAdd_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optMultAdd_0.ForeColor = SystemColors.ControlText;
            this.optMultAdd.SetIndex(this._optMultAdd_0, 0);
            point = new Point(0x10, 0x18);
            this._optMultAdd_0.Location = point;
            this._optMultAdd_0.Name = "_optMultAdd_0";
            this._optMultAdd_0.RightToLeft = RightToLeft.No;
            size = new Size(0xd1, 0x11);
            this._optMultAdd_0.Size = size;
            this._optMultAdd_0.TabIndex = 0x31;
            this._optMultAdd_0.TabStop = true;
            this._optMultAdd_0.Text = "multiplicative";
            this._optMultAdd_0.UseVisualStyleBackColor = false;
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this.txtOffSet);
            this.Frame2.Controls.Add(this.chkLogValues);
            this.Frame2.Controls.Add(this._optGoalFunctionType_3);
            this.Frame2.Controls.Add(this._optGoalFunctionType_2);
            this.Frame2.Controls.Add(this._optGoalFunctionType_1);
            this.Frame2.Controls.Add(this._optGoalFunctionType_0);
            this.Frame2.Controls.Add(this.Label18);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0x121, 0x71);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 30;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Select type";
            this.txtOffSet.AcceptsReturn = true;
            this.txtOffSet.BackColor = SystemColors.Window;
            this.txtOffSet.Cursor = Cursors.IBeam;
            this.txtOffSet.Enabled = false;
            this.txtOffSet.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtOffSet.ForeColor = SystemColors.WindowText;
            point = new Point(0xe8, 0x58);
            this.txtOffSet.Location = point;
            this.txtOffSet.MaxLength = 0;
            this.txtOffSet.Name = "txtOffSet";
            this.txtOffSet.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this.txtOffSet.Size = size;
            this.txtOffSet.TabIndex = 0x53;
            this.txtOffSet.Text = "0.01";
            this.chkLogValues.BackColor = SystemColors.Control;
            this.chkLogValues.Cursor = Cursors.Default;
            this.chkLogValues.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkLogValues.ForeColor = SystemColors.ControlText;
            point = new Point(0x60, 0x58);
            this.chkLogValues.Location = point;
            this.chkLogValues.Name = "chkLogValues";
            this.chkLogValues.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.chkLogValues.Size = size;
            this.chkLogValues.TabIndex = 0x4d;
            this.chkLogValues.Text = "&log values";
            this.chkLogValues.UseVisualStyleBackColor = false;
            this._optGoalFunctionType_3.BackColor = SystemColors.Control;
            this._optGoalFunctionType_3.Cursor = Cursors.Default;
            this._optGoalFunctionType_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optGoalFunctionType_3.ForeColor = SystemColors.ControlText;
            this.optGoalFunctionType.SetIndex(this._optGoalFunctionType_3, 3);
            point = new Point(0x10, 0x30);
            this._optGoalFunctionType_3.Location = point;
            this._optGoalFunctionType_3.Name = "_optGoalFunctionType_3";
            this._optGoalFunctionType_3.RightToLeft = RightToLeft.No;
            size = new Size(0x101, 0x19);
            this._optGoalFunctionType_3.Size = size;
            this._optGoalFunctionType_3.TabIndex = 0x44;
            this._optGoalFunctionType_3.TabStop = true;
            this._optGoalFunctionType_3.Text = "&average model efficiency";
            this._optGoalFunctionType_3.UseVisualStyleBackColor = false;
            this._optGoalFunctionType_2.BackColor = SystemColors.Control;
            this._optGoalFunctionType_2.Cursor = Cursors.Default;
            this._optGoalFunctionType_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optGoalFunctionType_2.ForeColor = SystemColors.ControlText;
            this.optGoalFunctionType.SetIndex(this._optGoalFunctionType_2, 2);
            point = new Point(0x10, 0x80);
            this._optGoalFunctionType_2.Location = point;
            this._optGoalFunctionType_2.Name = "_optGoalFunctionType_2";
            this._optGoalFunctionType_2.RightToLeft = RightToLeft.No;
            size = new Size(0x109, 0x11);
            this._optGoalFunctionType_2.Size = size;
            this._optGoalFunctionType_2.TabIndex = 0x26;
            this._optGoalFunctionType_2.TabStop = true;
            this._optGoalFunctionType_2.Text = "absolute error";
            this._optGoalFunctionType_2.UseVisualStyleBackColor = false;
            this._optGoalFunctionType_2.Visible = false;
            this._optGoalFunctionType_1.BackColor = SystemColors.Control;
            this._optGoalFunctionType_1.Cursor = Cursors.Default;
            this._optGoalFunctionType_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optGoalFunctionType_1.ForeColor = SystemColors.ControlText;
            this.optGoalFunctionType.SetIndex(this._optGoalFunctionType_1, 1);
            point = new Point(0x10, 0x80);
            this._optGoalFunctionType_1.Location = point;
            this._optGoalFunctionType_1.Name = "_optGoalFunctionType_1";
            this._optGoalFunctionType_1.RightToLeft = RightToLeft.No;
            size = new Size(0x109, 0x11);
            this._optGoalFunctionType_1.Size = size;
            this._optGoalFunctionType_1.TabIndex = 0x20;
            this._optGoalFunctionType_1.TabStop = true;
            this._optGoalFunctionType_1.Text = "logaritmic RMSE (LRMSE)";
            this._optGoalFunctionType_1.UseVisualStyleBackColor = false;
            this._optGoalFunctionType_0.BackColor = SystemColors.Control;
            this._optGoalFunctionType_0.Checked = true;
            this._optGoalFunctionType_0.Cursor = Cursors.Default;
            this._optGoalFunctionType_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optGoalFunctionType_0.ForeColor = SystemColors.ControlText;
            this.optGoalFunctionType.SetIndex(this._optGoalFunctionType_0, 0);
            point = new Point(0x10, 0x18);
            this._optGoalFunctionType_0.Location = point;
            this._optGoalFunctionType_0.Name = "_optGoalFunctionType_0";
            this._optGoalFunctionType_0.RightToLeft = RightToLeft.No;
            size = new Size(0x101, 0x11);
            this._optGoalFunctionType_0.Size = size;
            this._optGoalFunctionType_0.TabIndex = 0x1f;
            this._optGoalFunctionType_0.TabStop = true;
            this._optGoalFunctionType_0.Text = "&root mean square error (RMSE)";
            this._optGoalFunctionType_0.UseVisualStyleBackColor = false;
            this._lblStep_1.BackColor = SystemColors.Control;
            this._lblStep_1.Cursor = Cursors.Default;
            this._lblStep_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_1.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_1, 1);
            point = new Point(8, 0x18);
            this._lblStep_1.Location = point;
            this._lblStep_1.Name = "_lblStep_1";
            this._lblStep_1.RightToLeft = RightToLeft.No;
            size = new Size(0x198, 0x29);
            this._lblStep_1.Size = size;
            this._lblStep_1.TabIndex = 0x1b;
            this._lblStep_1.Text = "Different forms can be used to compute the goal function. Select below which one you wish to use.";
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(240, 320);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdPrevious.BackColor = SystemColors.Control;
            this.cmdPrevious.Cursor = Cursors.Default;
            this.cmdPrevious.Enabled = false;
            this.cmdPrevious.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdPrevious.ForeColor = SystemColors.ControlText;
            point = new Point(320, 320);
            this.cmdPrevious.Location = point;
            this.cmdPrevious.Name = "cmdPrevious";
            this.cmdPrevious.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdPrevious.Size = size;
            this.cmdPrevious.TabIndex = 6;
            this.cmdPrevious.Text = "&Previous";
            this.cmdPrevious.UseVisualStyleBackColor = false;
            this.cmdNext.BackColor = SystemColors.Control;
            this.cmdNext.Cursor = Cursors.Default;
            this.cmdNext.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdNext.ForeColor = SystemColors.ControlText;
            point = new Point(0x188, 320);
            this.cmdNext.Location = point;
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdNext.Size = size;
            this.cmdNext.TabIndex = 5;
            this.cmdNext.Text = "&Next";
            this.cmdNext.UseVisualStyleBackColor = false;
            this._fraStep_6.BackColor = SystemColors.Control;
            this._fraStep_6.Controls.Add(this._optViewResult_4);
            this._fraStep_6.Controls.Add(this._optViewResult_3);
            this._fraStep_6.Controls.Add(this._optViewResult_2);
            this._fraStep_6.Controls.Add(this._optViewResult_1);
            this._fraStep_6.Controls.Add(this.txtReport);
            this._fraStep_6.Controls.Add(this._optViewResult_0);
            this._fraStep_6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_6.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_6, 6);
            point = new Point(0, 0);
            this._fraStep_6.Location = point;
            this._fraStep_6.Name = "_fraStep_6";
            this._fraStep_6.RightToLeft = RightToLeft.No;
            size = new Size(0x1d7, 0x137);
            this._fraStep_6.Size = size;
            this._fraStep_6.TabIndex = 4;
            this._fraStep_6.TabStop = false;
            this._fraStep_6.Text = "Results";
            this._optViewResult_4.BackColor = SystemColors.Control;
            this._optViewResult_4.Cursor = Cursors.Default;
            this._optViewResult_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optViewResult_4.ForeColor = SystemColors.ControlText;
            this.optViewResult.SetIndex(this._optViewResult_4, 4);
            point = new Point(0x110, 0x30);
            this._optViewResult_4.Location = point;
            this._optViewResult_4.Name = "_optViewResult_4";
            this._optViewResult_4.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x11);
            this._optViewResult_4.Size = size;
            this._optViewResult_4.TabIndex = 0x3a;
            this._optViewResult_4.TabStop = true;
            this._optViewResult_4.Text = "&goal function values";
            this._optViewResult_4.UseVisualStyleBackColor = false;
            this._optViewResult_3.BackColor = SystemColors.Control;
            this._optViewResult_3.Cursor = Cursors.Default;
            this._optViewResult_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optViewResult_3.ForeColor = SystemColors.ControlText;
            this.optViewResult.SetIndex(this._optViewResult_3, 3);
            point = new Point(0x98, 0x18);
            this._optViewResult_3.Location = point;
            this._optViewResult_3.Name = "_optViewResult_3";
            this._optViewResult_3.RightToLeft = RightToLeft.No;
            size = new Size(0x99, 0x11);
            this._optViewResult_3.Size = size;
            this._optViewResult_3.TabIndex = 0x39;
            this._optViewResult_3.TabStop = true;
            this._optViewResult_3.Text = "strata inf&ormation";
            this._optViewResult_3.UseVisualStyleBackColor = false;
            this._optViewResult_2.BackColor = SystemColors.Control;
            this._optViewResult_2.Checked = true;
            this._optViewResult_2.Cursor = Cursors.Default;
            this._optViewResult_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optViewResult_2.ForeColor = SystemColors.ControlText;
            this.optViewResult.SetIndex(this._optViewResult_2, 2);
            point = new Point(0x10, 0x18);
            this._optViewResult_2.Location = point;
            this._optViewResult_2.Name = "_optViewResult_2";
            this._optViewResult_2.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this._optViewResult_2.Size = size;
            this._optViewResult_2.TabIndex = 0x38;
            this._optViewResult_2.TabStop = true;
            this._optViewResult_2.Text = "&iteration summary";
            this._optViewResult_2.UseVisualStyleBackColor = false;
            this._optViewResult_1.BackColor = SystemColors.Control;
            this._optViewResult_1.Cursor = Cursors.Default;
            this._optViewResult_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optViewResult_1.ForeColor = SystemColors.ControlText;
            this.optViewResult.SetIndex(this._optViewResult_1, 1);
            point = new Point(0x10, 0x30);
            this._optViewResult_1.Location = point;
            this._optViewResult_1.Name = "_optViewResult_1";
            this._optViewResult_1.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x11);
            this._optViewResult_1.Size = size;
            this._optViewResult_1.TabIndex = 0x37;
            this._optViewResult_1.TabStop = true;
            this._optViewResult_1.Text = "strata &score";
            this._optViewResult_1.UseVisualStyleBackColor = false;
            this.txtReport.AcceptsReturn = true;
            this.txtReport.BackColor = SystemColors.Window;
            this.txtReport.Cursor = Cursors.IBeam;
            this.txtReport.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x48);
            this.txtReport.Location = point;
            this.txtReport.MaxLength = 0;
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.RightToLeft = RightToLeft.No;
            this.txtReport.ScrollBars = ScrollBars.Both;
            size = new Size(0x1c9, 0xe1);
            this.txtReport.Size = size;
            this.txtReport.TabIndex = 0x36;
            this.txtReport.WordWrap = false;
            this._optViewResult_0.BackColor = SystemColors.Control;
            this._optViewResult_0.Cursor = Cursors.Default;
            this._optViewResult_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optViewResult_0.ForeColor = SystemColors.ControlText;
            this.optViewResult.SetIndex(this._optViewResult_0, 0);
            point = new Point(0x98, 0x30);
            this._optViewResult_0.Location = point;
            this._optViewResult_0.Name = "_optViewResult_0";
            this._optViewResult_0.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x11);
            this._optViewResult_0.Size = size;
            this._optViewResult_0.TabIndex = 0x35;
            this._optViewResult_0.TabStop = true;
            this._optViewResult_0.Text = "s&ensitivity";
            this._optViewResult_0.UseVisualStyleBackColor = false;
            this._fraStep_5.BackColor = SystemColors.Control;
            this._fraStep_5.Controls.Add(this.Frame4);
            this._fraStep_5.Controls.Add(this.Label23);
            this._fraStep_5.Controls.Add(this.Label22);
            this._fraStep_5.Controls.Add(this.Label21);
            this._fraStep_5.Controls.Add(this.Label20);
            this._fraStep_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_5.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_5, 5);
            point = new Point(-1000, 0);
            this._fraStep_5.Location = point;
            this._fraStep_5.Name = "_fraStep_5";
            this._fraStep_5.RightToLeft = RightToLeft.No;
            size = new Size(0x1d7, 0x137);
            this._fraStep_5.Size = size;
            this._fraStep_5.TabIndex = 3;
            this._fraStep_5.TabStop = false;
            this._fraStep_5.Text = "Set tolerances";
            this.Frame4.BackColor = SystemColors.Control;
            this.Frame4.Controls.Add(this._txtTol_2);
            this.Frame4.Controls.Add(this._optToleranceInterval_2);
            this.Frame4.Controls.Add(this.chkAddVariance);
            this.Frame4.Controls.Add(this._txtTol_1);
            this.Frame4.Controls.Add(this._txtTol_0);
            this.Frame4.Controls.Add(this._optToleranceInterval_1);
            this.Frame4.Controls.Add(this._optToleranceInterval_0);
            this.Frame4.Controls.Add(this.txtNoTolerances);
            this.Frame4.Controls.Add(this.Label13);
            this.Frame4.Controls.Add(this.Label12);
            this.Frame4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x98);
            this.Frame4.Location = point;
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = RightToLeft.No;
            size = new Size(0x139, 0x91);
            this.Frame4.Size = size;
            this.Frame4.TabIndex = 40;
            this.Frame4.TabStop = false;
            this._txtTol_2.AcceptsReturn = true;
            this._txtTol_2.BackColor = SystemColors.Window;
            this._txtTol_2.Cursor = Cursors.IBeam;
            this._txtTol_2.Enabled = false;
            this._txtTol_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtTol_2.ForeColor = SystemColors.WindowText;
            this.txtTol.SetIndex(this._txtTol_2, 2);
            point = new Point(0x80, 0x70);
            this._txtTol_2.Location = point;
            this._txtTol_2.MaxLength = 0;
            this._txtTol_2.Name = "_txtTol_2";
            this._txtTol_2.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtTol_2.Size = size;
            this._txtTol_2.TabIndex = 0x58;
            this._txtTol_2.Text = "85";
            this._optToleranceInterval_2.BackColor = SystemColors.Control;
            this._optToleranceInterval_2.Cursor = Cursors.Default;
            this._optToleranceInterval_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optToleranceInterval_2.ForeColor = SystemColors.ControlText;
            this.optToleranceInterval.SetIndex(this._optToleranceInterval_2, 2);
            point = new Point(0x20, 0x70);
            this._optToleranceInterval_2.Location = point;
            this._optToleranceInterval_2.Name = "_optToleranceInterval_2";
            this._optToleranceInterval_2.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this._optToleranceInterval_2.Size = size;
            this._optToleranceInterval_2.TabIndex = 0x57;
            this._optToleranceInterval_2.TabStop = true;
            this._optToleranceInterval_2.Text = "percentile";
            this._optToleranceInterval_2.UseVisualStyleBackColor = false;
            this.chkAddVariance.BackColor = SystemColors.Control;
            this.chkAddVariance.Cursor = Cursors.Default;
            this.chkAddVariance.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkAddVariance.ForeColor = SystemColors.ControlText;
            point = new Point(0xb8, 0x58);
            this.chkAddVariance.Location = point;
            this.chkAddVariance.Name = "chkAddVariance";
            this.chkAddVariance.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this.chkAddVariance.Size = size;
            this.chkAddVariance.TabIndex = 60;
            this.chkAddVariance.Text = "&Add variance";
            this.chkAddVariance.UseVisualStyleBackColor = false;
            this.chkAddVariance.Visible = false;
            this._txtTol_1.AcceptsReturn = true;
            this._txtTol_1.BackColor = SystemColors.Window;
            this._txtTol_1.Cursor = Cursors.IBeam;
            this._txtTol_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtTol_1.ForeColor = SystemColors.WindowText;
            this.txtTol.SetIndex(this._txtTol_1, 1);
            point = new Point(0x80, 0x58);
            this._txtTol_1.Location = point;
            this._txtTol_1.MaxLength = 0;
            this._txtTol_1.Name = "_txtTol_1";
            this._txtTol_1.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtTol_1.Size = size;
            this._txtTol_1.TabIndex = 0x2f;
            this._txtTol_1.Text = "1.5";
            this._txtTol_0.AcceptsReturn = true;
            this._txtTol_0.BackColor = SystemColors.Window;
            this._txtTol_0.Cursor = Cursors.IBeam;
            this._txtTol_0.Enabled = false;
            this._txtTol_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._txtTol_0.ForeColor = SystemColors.WindowText;
            this.txtTol.SetIndex(this._txtTol_0, 0);
            point = new Point(0x80, 0x40);
            this._txtTol_0.Location = point;
            this._txtTol_0.MaxLength = 0;
            this._txtTol_0.Name = "_txtTol_0";
            this._txtTol_0.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this._txtTol_0.Size = size;
            this._txtTol_0.TabIndex = 0x2e;
            this._txtTol_0.Text = "0.1";
            this._optToleranceInterval_1.BackColor = SystemColors.Control;
            this._optToleranceInterval_1.Checked = true;
            this._optToleranceInterval_1.Cursor = Cursors.Default;
            this._optToleranceInterval_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optToleranceInterval_1.ForeColor = SystemColors.ControlText;
            this.optToleranceInterval.SetIndex(this._optToleranceInterval_1, 1);
            point = new Point(0x20, 0x58);
            this._optToleranceInterval_1.Location = point;
            this._optToleranceInterval_1.Name = "_optToleranceInterval_1";
            this._optToleranceInterval_1.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._optToleranceInterval_1.Size = size;
            this._optToleranceInterval_1.TabIndex = 0x2d;
            this._optToleranceInterval_1.TabStop = true;
            this._optToleranceInterval_1.Text = "relative";
            this._optToleranceInterval_1.UseVisualStyleBackColor = false;
            this._optToleranceInterval_0.BackColor = SystemColors.Control;
            this._optToleranceInterval_0.Cursor = Cursors.Default;
            this._optToleranceInterval_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optToleranceInterval_0.ForeColor = SystemColors.ControlText;
            this.optToleranceInterval.SetIndex(this._optToleranceInterval_0, 0);
            point = new Point(0x20, 0x40);
            this._optToleranceInterval_0.Location = point;
            this._optToleranceInterval_0.Name = "_optToleranceInterval_0";
            this._optToleranceInterval_0.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this._optToleranceInterval_0.Size = size;
            this._optToleranceInterval_0.TabIndex = 0x2c;
            this._optToleranceInterval_0.TabStop = true;
            this._optToleranceInterval_0.Text = "absolute";
            this._optToleranceInterval_0.UseVisualStyleBackColor = false;
            this.txtNoTolerances.AcceptsReturn = true;
            this.txtNoTolerances.BackColor = SystemColors.Window;
            this.txtNoTolerances.Cursor = Cursors.IBeam;
            this.txtNoTolerances.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNoTolerances.ForeColor = SystemColors.WindowText;
            point = new Point(0x80, 0x18);
            this.txtNoTolerances.Location = point;
            this.txtNoTolerances.MaxLength = 0;
            this.txtNoTolerances.Name = "txtNoTolerances";
            this.txtNoTolerances.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 20);
            this.txtNoTolerances.Size = size;
            this.txtNoTolerances.TabIndex = 0x2b;
            this.txtNoTolerances.Text = "5";
            this.Label13.BackColor = SystemColors.Control;
            this.Label13.Cursor = Cursors.Default;
            this.Label13.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label13.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x30);
            this.Label13.Location = point;
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this.Label13.Size = size;
            this.Label13.TabIndex = 0x2a;
            this.Label13.Text = "Tolerance interval:";
            this.Label12.BackColor = SystemColors.Control;
            this.Label12.Cursor = Cursors.Default;
            this.Label12.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label12.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x1a);
            this.Label12.Location = point;
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 0x11);
            this.Label12.Size = size;
            this.Label12.TabIndex = 0x29;
            this.Label12.Text = "Number of tolerances:";
            this.Label23.BackColor = SystemColors.Control;
            this.Label23.Cursor = Cursors.Default;
            this.Label23.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label23.ForeColor = SystemColors.ControlText;
            point = new Point(8, 120);
            this.Label23.Location = point;
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = RightToLeft.No;
            size = new Size(0x1c1, 0x19);
            this.Label23.Size = size;
            this.Label23.TabIndex = 0x60;
            this.Label23.Text = "Selecting 'percentile' means that the second tolerance level will be set at the specified percentile.";
            this.Label22.BackColor = SystemColors.Control;
            this.Label22.Cursor = Cursors.Default;
            this.Label22.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label22.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x58);
            this.Label22.Location = point;
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = RightToLeft.No;
            size = new Size(0x1c9, 0x21);
            this.Label22.Size = size;
            this.Label22.TabIndex = 0x5f;
            this.Label22.Text = "Selecting 'relative' means that the second tolerance level is obtained by multiplying the minimum goal function value with the specified factor.";
            this.Label21.BackColor = SystemColors.Control;
            this.Label21.Cursor = Cursors.Default;
            this.Label21.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label21.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Label21.Location = point;
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = RightToLeft.No;
            size = new Size(0x1c9, 0x21);
            this.Label21.Size = size;
            this.Label21.TabIndex = 0x5e;
            this.Label21.Text = "The other tolerance levels are determined by the choice made below. Selecting 'absolute' will add the specified value to the present tolerance level to obtain the next level. ";
            this.Label20.BackColor = SystemColors.Control;
            this.Label20.Cursor = Cursors.Default;
            this.Label20.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label20.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label20.Location = point;
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = RightToLeft.No;
            size = new Size(0x1c9, 0x21);
            this.Label20.Size = size;
            this.Label20.TabIndex = 0x5d;
            this.Label20.Text = "The first tolerance level is always the best value of the goal function (i.e. one hit for the stratas giving the best goal function). ";
            this._fraStep_1.BackColor = SystemColors.Control;
            this._fraStep_1.Controls.Add(this.txtMissingData);
            this._fraStep_1.Controls.Add(this.Frame1);
            this._fraStep_1.Controls.Add(this.Label9);
            this._fraStep_1.Controls.Add(this.Label5);
            this._fraStep_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_1.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_1, 1);
            point = new Point(-1000, 0);
            this._fraStep_1.Location = point;
            this._fraStep_1.Name = "_fraStep_1";
            this._fraStep_1.RightToLeft = RightToLeft.No;
            size = new Size(0x1d5, 0x137);
            this._fraStep_1.Size = size;
            this._fraStep_1.TabIndex = 2;
            this._fraStep_1.TabStop = false;
            this._fraStep_1.Text = "Define goal function I: conditioning variables";
            this.txtMissingData.AcceptsReturn = true;
            this.txtMissingData.BackColor = SystemColors.Window;
            this.txtMissingData.Cursor = Cursors.IBeam;
            this.txtMissingData.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtMissingData.ForeColor = SystemColors.WindowText;
            point = new Point(0xa8, 0x11d);
            this.txtMissingData.Location = point;
            this.txtMissingData.MaxLength = 0;
            this.txtMissingData.Name = "txtMissingData";
            this.txtMissingData.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 20);
            this.txtMissingData.Size = size;
            this.txtMissingData.TabIndex = 0x34;
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.cmdRemoveAll);
            this.Frame1.Controls.Add(this.cmdAddAll);
            this.Frame1.Controls.Add(this.cmdRemoveVariable);
            this.Frame1.Controls.Add(this.cmdAddVariable);
            this.Frame1.Controls.Add(this.lstVariablesInGoalFunction);
            this.Frame1.Controls.Add(this.lstAvailableVariables);
            this.Frame1.Controls.Add(this.cmdBrowseForCondBinFile);
            this.Frame1.Controls.Add(this.Label8);
            this.Frame1.Controls.Add(this.Label7);
            this.Frame1.Controls.Add(this.lblCondBinFile);
            this.Frame1.Controls.Add(this.Label6);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x40);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x1c9, 0xd9);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0x10;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Select *.bin-file with conditioning variables";
            this.cmdRemoveAll.BackColor = SystemColors.Control;
            this.cmdRemoveAll.Cursor = Cursors.Default;
            this.cmdRemoveAll.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.cmdRemoveAll.ForeColor = SystemColors.ControlText;
            point = new Point(0xc0, 0xa8);
            this.cmdRemoveAll.Location = point;
            this.cmdRemoveAll.Name = "cmdRemoveAll";
            this.cmdRemoveAll.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x19);
            this.cmdRemoveAll.Size = size;
            this.cmdRemoveAll.TabIndex = 0x3e;
            this.cmdRemoveAll.Text = "|<-";
            this.cmdRemoveAll.UseVisualStyleBackColor = false;
            this.cmdAddAll.BackColor = SystemColors.Control;
            this.cmdAddAll.Cursor = Cursors.Default;
            this.cmdAddAll.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.cmdAddAll.ForeColor = SystemColors.ControlText;
            point = new Point(0xc0, 0x60);
            this.cmdAddAll.Location = point;
            this.cmdAddAll.Name = "cmdAddAll";
            this.cmdAddAll.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x19);
            this.cmdAddAll.Size = size;
            this.cmdAddAll.TabIndex = 0x3d;
            this.cmdAddAll.Text = "->|";
            this.cmdAddAll.UseVisualStyleBackColor = false;
            this.cmdRemoveVariable.BackColor = SystemColors.Control;
            this.cmdRemoveVariable.Cursor = Cursors.Default;
            this.cmdRemoveVariable.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdRemoveVariable.ForeColor = SystemColors.ControlText;
            point = new Point(0xc0, 0x90);
            this.cmdRemoveVariable.Location = point;
            this.cmdRemoveVariable.Name = "cmdRemoveVariable";
            this.cmdRemoveVariable.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x19);
            this.cmdRemoveVariable.Size = size;
            this.cmdRemoveVariable.TabIndex = 0x19;
            this.cmdRemoveVariable.Text = "&<-";
            this.cmdRemoveVariable.UseVisualStyleBackColor = false;
            this.cmdAddVariable.BackColor = SystemColors.Control;
            this.cmdAddVariable.Cursor = Cursors.Default;
            this.cmdAddVariable.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdAddVariable.ForeColor = SystemColors.ControlText;
            point = new Point(0xc0, 120);
            this.cmdAddVariable.Location = point;
            this.cmdAddVariable.Name = "cmdAddVariable";
            this.cmdAddVariable.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x19);
            this.cmdAddVariable.Size = size;
            this.cmdAddVariable.TabIndex = 0x18;
            this.cmdAddVariable.Text = "-&>";
            this.cmdAddVariable.UseVisualStyleBackColor = false;
            this.lstVariablesInGoalFunction.BackColor = SystemColors.Window;
            this.lstVariablesInGoalFunction.Cursor = Cursors.Default;
            this.lstVariablesInGoalFunction.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstVariablesInGoalFunction.ForeColor = SystemColors.WindowText;
            this.lstVariablesInGoalFunction.ItemHeight = 14;
            point = new Point(240, 0x58);
            this.lstVariablesInGoalFunction.Location = point;
            this.lstVariablesInGoalFunction.Name = "lstVariablesInGoalFunction";
            this.lstVariablesInGoalFunction.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x74);
            this.lstVariablesInGoalFunction.Size = size;
            this.lstVariablesInGoalFunction.TabIndex = 0x17;
            this.lstAvailableVariables.BackColor = SystemColors.Window;
            this.lstAvailableVariables.Cursor = Cursors.Default;
            this.lstAvailableVariables.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstAvailableVariables.ForeColor = SystemColors.WindowText;
            this.lstAvailableVariables.ItemHeight = 14;
            point = new Point(8, 0x58);
            this.lstAvailableVariables.Location = point;
            this.lstAvailableVariables.Name = "lstAvailableVariables";
            this.lstAvailableVariables.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x74);
            this.lstAvailableVariables.Size = size;
            this.lstAvailableVariables.TabIndex = 0x15;
            this.cmdBrowseForCondBinFile.BackColor = SystemColors.Control;
            this.cmdBrowseForCondBinFile.Cursor = Cursors.Default;
            this.cmdBrowseForCondBinFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseForCondBinFile.ForeColor = SystemColors.ControlText;
            point = new Point(0x15f, 40);
            this.cmdBrowseForCondBinFile.Location = point;
            this.cmdBrowseForCondBinFile.Name = "cmdBrowseForCondBinFile";
            this.cmdBrowseForCondBinFile.RightToLeft = RightToLeft.No;
            size = new Size(0x22, 0x11);
            this.cmdBrowseForCondBinFile.Size = size;
            this.cmdBrowseForCondBinFile.TabIndex = 0x12;
            this.cmdBrowseForCondBinFile.Text = "...";
            this.cmdBrowseForCondBinFile.TextAlign = ContentAlignment.MiddleRight;
            this.cmdBrowseForCondBinFile.UseVisualStyleBackColor = false;
            this.Label8.BackColor = SystemColors.Control;
            this.Label8.Cursor = Cursors.Default;
            this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = SystemColors.ControlText;
            point = new Point(240, 0x48);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.Label8.Size = size;
            this.Label8.TabIndex = 0x16;
            this.Label8.Text = "Use these in the goal function:";
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x48);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0xe9, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 20;
            this.Label7.Text = "Variables in selected bin-file:";
            this.lblCondBinFile.BackColor = SystemColors.Window;
            this.lblCondBinFile.BorderStyle = BorderStyle.FixedSingle;
            this.lblCondBinFile.Cursor = Cursors.Default;
            this.lblCondBinFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCondBinFile.ForeColor = SystemColors.WindowText;
            point = new Point(8, 40);
            this.lblCondBinFile.Location = point;
            this.lblCondBinFile.Name = "lblCondBinFile";
            this.lblCondBinFile.RightToLeft = RightToLeft.No;
            size = new Size(0x151, 0x11);
            this.lblCondBinFile.Size = size;
            this.lblCondBinFile.TabIndex = 0x11;
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this.Label6.Size = size;
            this.Label6.TabIndex = 0x13;
            this.Label6.Text = "bin-file with measured values:";
            this.Label9.BackColor = SystemColors.Control;
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x120);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x11);
            this.Label9.Size = size;
            this.Label9.TabIndex = 0x33;
            this.Label9.Text = "Missing data is represented by:";
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x1a9, 0x21);
            this.Label5.Size = size;
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Measured values should be in bin-file format. Select a bin-file below containing your measured values and indicate which of them you wish to use in the goal function.";
            this._fraStep_0.BackColor = SystemColors.Control;
            this._fraStep_0.Controls.Add(this.udIterationNumber);
            this._fraStep_0.Controls.Add(this.lstProjects);
            this._fraStep_0.Controls.Add(this.Frame6);
            this._fraStep_0.Controls.Add(this.Label4);
            this._fraStep_0.Controls.Add(this.Label3);
            this._fraStep_0.Controls.Add(this.Label2);
            this._fraStep_0.Controls.Add(this.Label1);
            this._fraStep_0.Controls.Add(this._lblStep_0);
            this._fraStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_0.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_0, 0);
            point = new Point(-10000, 4);
            this._fraStep_0.Location = point;
            this._fraStep_0.Name = "_fraStep_0";
            this._fraStep_0.RightToLeft = RightToLeft.No;
            size = new Size(0x1d8, 0xbf);
            this._fraStep_0.Size = size;
            this._fraStep_0.TabIndex = 0;
            this._fraStep_0.TabStop = false;
            this._fraStep_0.Text = "Select project and iteration";
            point = new Point(0x90, 0x72);
            this.udIterationNumber.Location = point;
            decimal num = new decimal(new int[] { 1, 0, 0, 0 });
            this.udIterationNumber.Minimum = num;
            this.udIterationNumber.Name = "udIterationNumber";
            size = new Size(0x26, 20);
            this.udIterationNumber.Size = size;
            this.udIterationNumber.TabIndex = 0x42;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.udIterationNumber.Value = num;
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 14;
            point = new Point(11, 0x74);
            this.lstProjects.Location = point;
            this.lstProjects.Name = "lstProjects";
            size = new Size(120, 60);
            this.lstProjects.Size = size;
            this.lstProjects.TabIndex = 0x41;
            this.Frame6.BackColor = SystemColors.Control;
            this.Frame6.Controls.Add(this.cmdStartScript);
            this.Frame6.Controls.Add(this.cmdBrowseForScript);
            this.Frame6.Controls.Add(this.txtScriptFile);
            this.Frame6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame6.ForeColor = SystemColors.ControlText;
            point = new Point(0x90, 0xc0);
            this.Frame6.Location = point;
            this.Frame6.Name = "Frame6";
            this.Frame6.RightToLeft = RightToLeft.No;
            size = new Size(0x141, 0x59);
            this.Frame6.Size = size;
            this.Frame6.TabIndex = 0x40;
            this.Frame6.TabStop = false;
            this.Frame6.Text = "Use script";
            this.Frame6.Visible = false;
            this.cmdStartScript.BackColor = SystemColors.Control;
            this.cmdStartScript.Cursor = Cursors.Default;
            this.cmdStartScript.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdStartScript.ForeColor = SystemColors.ControlText;
            point = new Point(0xd8, 0x38);
            this.cmdStartScript.Location = point;
            this.cmdStartScript.Name = "cmdStartScript";
            this.cmdStartScript.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x19);
            this.cmdStartScript.Size = size;
            this.cmdStartScript.TabIndex = 0x43;
            this.cmdStartScript.Text = "&Start";
            this.cmdStartScript.UseVisualStyleBackColor = false;
            this.cmdBrowseForScript.BackColor = SystemColors.Control;
            this.cmdBrowseForScript.Cursor = Cursors.Default;
            this.cmdBrowseForScript.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseForScript.ForeColor = SystemColors.ControlText;
            point = new Point(280, 0x18);
            this.cmdBrowseForScript.Location = point;
            this.cmdBrowseForScript.Name = "cmdBrowseForScript";
            this.cmdBrowseForScript.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.cmdBrowseForScript.Size = size;
            this.cmdBrowseForScript.TabIndex = 0x42;
            this.cmdBrowseForScript.Text = "...";
            this.cmdBrowseForScript.UseVisualStyleBackColor = false;
            this.txtScriptFile.AcceptsReturn = true;
            this.txtScriptFile.BackColor = SystemColors.Window;
            this.txtScriptFile.Cursor = Cursors.IBeam;
            this.txtScriptFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtScriptFile.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x18);
            this.txtScriptFile.Location = point;
            this.txtScriptFile.MaxLength = 0;
            this.txtScriptFile.Name = "txtScriptFile";
            this.txtScriptFile.ReadOnly = true;
            this.txtScriptFile.RightToLeft = RightToLeft.No;
            size = new Size(0x111, 20);
            this.txtScriptFile.Size = size;
            this.txtScriptFile.TabIndex = 0x41;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(0x90, 0x60);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Iteration number:";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x60);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Project:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x151, 0x19);
            this.Label2.Size = size;
            this.Label2.TabIndex = 9;
            this.Label2.Text = "At the end of this wizard you will be able to view and save the results.";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 80);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x161, 0x21);
            this.Label1.Size = size;
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Start with selecting a project and iteration that you wish to analyse.";
            this._lblStep_0.BackColor = SystemColors.Control;
            this._lblStep_0.Cursor = Cursors.Default;
            this._lblStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_0.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_0, 0);
            point = new Point(8, 0x18);
            this._lblStep_0.Location = point;
            this._lblStep_0.Name = "_lblStep_0";
            this._lblStep_0.RightToLeft = RightToLeft.No;
            size = new Size(0x130, 0x22);
            this._lblStep_0.Size = size;
            this._lblStep_0.TabIndex = 1;
            this._lblStep_0.Text = "This wizard will guide you through the different steps to analyse a SUFI iteration.";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            size = new Size(0x1e5, 350);
            this.ClientSize = size;
            this.Controls.Add(this.fraAggregate);
            this.Controls.Add(this._fraStep_4);
            this.Controls.Add(this._fraStep_3);
            this.Controls.Add(this._fraStep_2);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdPrevious);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this._fraStep_6);
            this.Controls.Add(this._fraStep_5);
            this.Controls.Add(this._fraStep_1);
            this.Controls.Add(this._fraStep_0);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.Name = "frmAnalyseSUFI";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Analyse SUFI iteration";
            this.fraAggregate.ResumeLayout(false);
            this._fraStep_4.ResumeLayout(false);
            this._fraStep_4.PerformLayout();
            this._fraStep_3.ResumeLayout(false);
            this.Frame3.ResumeLayout(false);
            this._fraStep_2.ResumeLayout(false);
            this.Frame5.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this._fraStep_6.ResumeLayout(false);
            this._fraStep_6.PerformLayout();
            this._fraStep_5.ResumeLayout(false);
            this.Frame4.ResumeLayout(false);
            this.Frame4.PerformLayout();
            this._fraStep_1.ResumeLayout(false);
            this._fraStep_1.PerformLayout();
            this.Frame1.ResumeLayout(false);
            this._fraStep_0.ResumeLayout(false);
            this.udIterationNumber.EndInit();
            this.Frame6.ResumeLayout(false);
            this.Frame6.PerformLayout();
            ((ISupportInitialize) this.fraStep).EndInit();
            ((ISupportInitialize) this.lblSimFile).EndInit();
            ((ISupportInitialize) this.lblStep).EndInit();
            ((ISupportInitialize) this.optGoalFunctionType).EndInit();
            ((ISupportInitialize) this.optMultAdd).EndInit();
            ((ISupportInitialize) this.optToleranceInterval).EndInit();
            ((ISupportInitialize) this.optViewResult).EndInit();
            ((ISupportInitialize) this.txtTol).EndInit();
            this.ResumeLayout(false);
        }

        private bool IsInGroup(ref short varno)
        {
            bool flag;
            short nCondVars = this.m_nCondVars;
            short num = 1;
            while (true)
            {
                if (num <= nCondVars)
                {
                    short num4 = this.m_nCondVars;
                    short num2 = 1;
                    while (true)
                    {
                        short num5 = num4;
                        if (num2 <= num5)
                        {
                            if (this.Groups[num, num2] != varno)
                            {
                                num2 = (short) (num2 + 1);
                                continue;
                            }
                            return true;
                        }
                        else
                        {
                            num = (short) (num + 1);
                        }
                        break;
                    }
                    continue;
                }
                else
                {
                    flag = false;
                }
                break;
            }
            return flag;
        }

        private void Label16_Click(object eventSender, EventArgs eventArgs)
        {
            this.txtDetectionLimit.Focus();
        }

        private void Label18_Click(object eventSender, EventArgs eventArgs)
        {
        }

        public float Log10(ref float X) => 
            (float) (Math.Log((double) X) / Math.Log(10.0));

        private void LogValues(ref float[,] vals)
        {
            short nCondVars = this.m_nCondVars;
            short num2 = 1;
            while (num2 <= nCondVars)
            {
                short num4 = (short) Information.UBound(vals, 1);
                short num = 1;
                while (true)
                {
                    short num6 = num4;
                    if (num > num6)
                    {
                        num2 = (short) (num2 + 1);
                        break;
                    }
                    if (Operators.ConditionalCompareObjectNotEqual(vals[num, num2], this.m_MissingData, false))
                    {
                        vals[num, num2] = (vals[num, num2] == 0f) ? this.Log10(ref vals[num, num2] + Conversions.ToSingle(this.txtOffSet.Text)) : this.Log10(ref vals[num, num2]);
                    }
                    num = (short) (num + 1);
                }
            }
        }

        private void lstCondVar_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (this.m_BinFileIndexes[2, this.lstCondVar.SelectedIndex + 1] == 0)
            {
                this.lstSimulatedVar.SelectedIndex = -1;
            }
            else
            {
                this.lstSimulatedVar.SelectedIndex = this.m_BinFileIndexes[2, this.lstCondVar.SelectedIndex + 1] - 1;
                this.lstSimulatedVar.SetSelected(this.lstSimulatedVar.SelectedIndex, true);
            }
        }

        private void lstGroups_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            this.txtDetectionLimit.Text = Conversions.ToString(this.DetectionLimit[this.lstGroups.SelectedIndex + 1]);
            this.txtGroupWeight.Text = Support.Format(this.m_GroupWeights[this.lstGroups.SelectedIndex + 1], "#.###", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
        }

        private void lstProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Strings.Len(this.lstProjects.Text) > 0)
            {
                this.cmdAggregateTool.Enabled = true;
                this.udIterationNumber.Enabled = true;
                this.m_ProjectName = this.lstProjects.Text;
                this.GetProjectInfo();
                this.m_IterationNo = Convert.ToInt16(this.udIterationNumber.Maximum);
                this.udIterationNumber.Value = this.udIterationNumber.Maximum;
            }
        }

        private void lstSimulatedVar_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            if (this.lstCondVar.SelectedItems.Count > 0)
            {
                this.SetIndexes();
            }
        }

        private short min(ref short val1, ref short val2)
        {
            short num = (val1 > val2) ? ref val2 : ref val1;
            return num;
        }

        private float MODELEFF()
        {
            short num10 = (short) Information.UBound(this.Groups, 1);
            short group = 1;
            while (true)
            {
                float num4;
                short num15 = num10;
                if (group > num15)
                {
                    return (num4 / ((float) Information.UBound(this.Groups, 1)));
                }
                double num = 0.0;
                short num5 = 0;
                double num7 = 0.0;
                double num6 = 0.0;
                short num11 = this.NVarsInThisGroup(ref group);
                short num8 = 1;
                while (true)
                {
                    short num3;
                    short num9;
                    if (num8 > num11)
                    {
                        num /= (double) num5;
                        short num13 = this.NVarsInThisGroup(ref group);
                        num8 = 1;
                        while (true)
                        {
                            if (num8 > num13)
                            {
                                num4 += (float) (((num7 - num6) / num7) * this.m_GroupWeights[group]);
                                group = (short) (group + 1);
                                break;
                            }
                            num9 = this.Groups[group, num8];
                            short num14 = (short) Information.UBound(this.m_MeasuredValues, 1);
                            num3 = 1;
                            while (true)
                            {
                                num15 = num14;
                                if (num3 > num15)
                                {
                                    num8 = (short) (num8 + 1);
                                    break;
                                }
                                if (Operators.ConditionalCompareObjectNotEqual(this.m_MeasuredValues[num3, num9], this.m_MissingData, false))
                                {
                                    if (this.m_SimulatedValues[num3, num9] < this.DetectionLimit[group])
                                    {
                                        this.m_SimulatedValues[num3, num9] = 0f;
                                    }
                                    num6 += (this.m_MeasuredValues[num3, num9] - this.m_SimulatedValues[num3, num9]) * (this.m_MeasuredValues[num3, num9] - this.m_SimulatedValues[num3, num9]);
                                    num7 += (this.m_MeasuredValues[num3, num9] - num) * (this.m_MeasuredValues[num3, num9] - num);
                                }
                                num3 = (short) (num3 + 1);
                            }
                        }
                        break;
                    }
                    num9 = this.Groups[group, num8];
                    short num12 = (short) Information.UBound(this.m_MeasuredValues, 1);
                    num3 = 1;
                    while (true)
                    {
                        num15 = num12;
                        if (num3 > num15)
                        {
                            num8 = (short) (num8 + 1);
                            break;
                        }
                        if (Operators.ConditionalCompareObjectNotEqual(this.m_MeasuredValues[num3, num9], this.m_MissingData, false))
                        {
                            num += this.m_MeasuredValues[num3, num9];
                            num5 = (short) (num5 + 1);
                        }
                        num3 = (short) (num3 + 1);
                    }
                }
            }
        }

        private bool ModifyDates(ref string[] Dates)
        {
            // Invalid method body.
        }

        public short NStrata(ref short varno) => 
            this.m_nStrata[varno];

        private short NVarsInThisGroup(ref short group)
        {
            short num3 = (short) Information.UBound(this.Groups, 2);
            short num = 1;
            while (true)
            {
                short num2;
                short num4 = num3;
                if (num > num4)
                {
                    num2 = (short) (num - 1);
                }
                else
                {
                    if (this.Groups[group, num] != 0)
                    {
                        num = (short) (num + 1);
                        continue;
                    }
                    num2 = (short) (num - 1);
                }
                return num2;
            }
        }

        private void optGoalFunctionType_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                if (this.optGoalFunctionType.GetIndex((RadioButton) eventSender) == 3)
                {
                    this.optMultAdd[1].Enabled = false;
                    this.optMultAdd[0].Enabled = false;
                    this.optToleranceInterval[1].Enabled = false;
                    this.optToleranceInterval[0].Checked = true;
                }
                else
                {
                    this.optMultAdd[1].Enabled = true;
                    this.optMultAdd[0].Enabled = true;
                    this.optToleranceInterval[1].Enabled = true;
                    this.optToleranceInterval[0].Checked = true;
                }
            }
        }

        private void optToleranceInterval_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            if (Conversions.ToBoolean(NewLateBinding.LateGet(eventSender, null, "Checked", new object[0], null, null, null)))
            {
                short index = this.optToleranceInterval.GetIndex((RadioButton) eventSender);
                if (index == 1)
                {
                    this.txtTol[0].Enabled = false;
                    this.txtTol[1].Enabled = true;
                    this.txtTol[2].Enabled = false;
                }
                else if (index == 0)
                {
                    this.txtTol[1].Enabled = false;
                    this.txtTol[0].Enabled = true;
                    this.txtTol[2].Enabled = false;
                }
                else if (index == 2)
                {
                    this.txtTol[1].Enabled = false;
                    this.txtTol[0].Enabled = false;
                    this.txtTol[2].Enabled = true;
                }
            }
        }

        private void optViewResult_CheckedChanged(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private bool PrintGoalFunction(ref string fname = "")
        {
            // Invalid method body.
        }

        private bool PrintIterationSummary(ref string fname = "")
        {
            // Invalid method body.
        }

        private bool PrintSensitivity(ref string fname = "")
        {
            // Invalid method body.
        }

        private bool PrintStrataInformation(ref string fname = "")
        {
            // Invalid method body.
        }

        private bool PrintStrataScore(ref string fname = "")
        {
            // Invalid method body.
        }

        private void PrintTolerances()
        {
            short fileNumber = (short) FileSystem.FreeFile();
            FileSystem.FileOpen(fileNumber, MyProject.Application.Info.DirectoryPath + @"\tolerances.txt", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
            short num3 = (short) Information.UBound(this.m_Tolerances, 1);
            short index = 1;
            while (true)
            {
                short num4 = num3;
                if (index > num4)
                {
                    FileSystem.FileClose(new int[] { fileNumber });
                    return;
                }
                object[] output = new object[] { this.m_Tolerances[index] };
                FileSystem.PrintLine(fileNumber, output);
                index = (short) (index + 1);
            }
        }

        private bool ReadAndInterpolateSimulatedData(ref string fname)
        {
            // Invalid method body.
        }

        private bool ReadMeasuredData()
        {
            // Invalid method body.
        }

        private void RecalcWeights()
        {
        }

        private float RMSE()
        {
            float num4;
            if (!this.optMultAdd[1].Checked)
            {
                num4 = 1f;
            }
            else if (!this.SetWeights())
            {
                return num4;
            }
            float[] numArray = new float[Information.UBound(this.Groups, 1) + 1];
            short num8 = (short) Information.UBound(this.Groups, 1);
            short index = 1;
            while (true)
            {
                short num7;
                short num12 = num8;
                if (index > num12)
                {
                    short num11 = (short) Information.UBound(this.Groups, 1);
                    index = 1;
                    while (true)
                    {
                        num12 = num11;
                        if (index > num12)
                        {
                            break;
                        }
                        bool flag2 = this.optMultAdd[1].Checked;
                        num4 = !flag2 ? ((num4 * numArray[index]) * this.m_GroupWeights[index]) : (num4 + ((numArray[index] * this.m_Weights[num7]) * this.m_GroupWeights[index]));
                        index = (short) (index + 1);
                    }
                    break;
                }
                short num9 = this.NVarsInThisGroup(ref index);
                short num6 = 1;
                while (true)
                {
                    short num3;
                    double num5;
                    if (num6 > num9)
                    {
                        num5 = (num3 == 0) ? 0.0 : Math.Sqrt(num5 / ((double) num3));
                        numArray[index] = (float) num5;
                        num5 = 0.0;
                        num3 = 0;
                        index = (short) (index + 1);
                        break;
                    }
                    num7 = this.Groups[index, num6];
                    short num10 = (short) Information.UBound(this.m_MeasuredValues, 1);
                    short num2 = 1;
                    while (true)
                    {
                        num12 = num10;
                        if (num2 > num12)
                        {
                            num6 = (short) (num6 + 1);
                            break;
                        }
                        if (Operators.ConditionalCompareObjectNotEqual(this.m_MeasuredValues[num2, num7], this.m_MissingData, false))
                        {
                            if (this.m_SimulatedValues[num2, num7] < this.DetectionLimit[index])
                            {
                                this.m_SimulatedValues[num2, num7] = 0f;
                            }
                            num5 += (this.m_MeasuredValues[num2, num7] - this.m_SimulatedValues[num2, num7]) * (this.m_MeasuredValues[num2, num7] - this.m_SimulatedValues[num2, num7]);
                            num3 = (short) (num3 + 1);
                        }
                        num2 = (short) (num2 + 1);
                    }
                }
            }
            return num4;
        }

        private bool ScoreStrata()
        {
            // Invalid method body.
        }

        private void SetGroupArray()
        {
            this.Groups = new short[this.m_nCondVars + 1, this.m_nCondVars + 1];
            short count = (short) this.lstGroups.Items.Count;
            short num = 1;
            while (true)
            {
                short num6 = count;
                if (num > num6)
                {
                    return;
                }
                short start = 1;
                this.lstGroups.SelectedIndex = num - 1;
                string str = Strings.Trim(this.lstGroups.Text);
                short num4 = (short) Strings.InStr(start, str, " ", CompareMethod.Binary);
                short num2 = 0;
                while (true)
                {
                    if (num4 == 0)
                    {
                        this.Groups[num, (short) (num2 + 1)] = Conversions.ToShort(Strings.Mid(str, start));
                        num = (short) (num + 1);
                        break;
                    }
                    num2 = (short) (num2 + 1);
                    this.Groups[num, num2] = Conversions.ToShort(Strings.Mid(str, start, (short) (num4 - start)));
                    start = num4;
                    num4 = (short) Strings.InStr(start + 1, str, " ", CompareMethod.Binary);
                }
            }
        }

        public void SetIndexes()
        {
            if (this.lstCondVar.SelectedIndex != -1)
            {
                this.m_BinFileIndexes[2, this.lstCondVar.SelectedIndex + 1] = (short) (this.lstSimulatedVar.SelectedIndex + 1);
            }
        }

        private bool SetTolerances()
        {
            // Invalid method body.
        }

        private void SetupControls()
        {
            Recordset rs = new RecordsetClass();
            rs.Open("select * from SUFIProjects", this.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.lstProjects.Items.Clear();
            while (true)
            {
                if (rs.EOF)
                {
                    rs.Close();
                    rs.Open("select * from SUFIIterations where IterationID=" + Conversions.ToString(this.frmSUFIMain.CurrentIterationID), this.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    this.udIterationNumber.Maximum = new decimal(ReadSaveFunctions.RecordCount(ref rs));
                    rs.Close();
                    if (decimal.Compare(this.udIterationNumber.Maximum, 0M) == 0)
                    {
                        this.udIterationNumber.Maximum = 1M;
                    }
                    return;
                }
                this.lstProjects.Items.Add(rs[]["ProjectName"][]);
                rs.MoveNext();
            }
        }

        private bool SetWeights()
        {
            // Invalid method body.
        }

        private void Sort(ref float[] vals, ref float[] result)
        {
            short num3 = (short) Information.UBound(vals, 1);
            short num5 = num3;
            short index = 1;
            while (true)
            {
                short num10 = num5;
                if (index > num10)
                {
                    short num;
                    if (this.optGoalFunctionType[0].Checked)
                    {
                        short num6 = num3;
                        index = 1;
                        while (index <= num6)
                        {
                            short num7 = (short) (index + 1);
                            num = num3;
                            while (true)
                            {
                                num10 = num7;
                                if (num < num10)
                                {
                                    index = (short) (index + 1);
                                    break;
                                }
                                if (result[num - 1] > result[num])
                                {
                                    result[num - 1] = result[num];
                                    result[num] = result[num - 1];
                                }
                                num = (short) (num + -1);
                            }
                        }
                    }
                    if (this.optGoalFunctionType[3].Checked)
                    {
                        short num8 = num3;
                        index = 1;
                        while (index <= num8)
                        {
                            short num9 = (short) (index + 1);
                            num = num3;
                            while (true)
                            {
                                num10 = num9;
                                if (num < num10)
                                {
                                    index = (short) (index + 1);
                                    break;
                                }
                                if (result[num - 1] < result[num])
                                {
                                    result[num - 1] = result[num];
                                    result[num] = result[num - 1];
                                }
                                num = (short) (num + -1);
                            }
                        }
                    }
                    return;
                }
                result[index] = vals[index];
                index = (short) (index + 1);
            }
        }

        public virtual Button cmdAggregateTool
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdAggregateTool;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdAggregateTool_Click);
                if (!ReferenceEquals(this._cmdAggregateTool, null))
                {
                    this._cmdAggregateTool.Click -= handler;
                }
                this._cmdAggregateTool = value;
                if (!ReferenceEquals(this._cmdAggregateTool, null))
                {
                    this._cmdAggregateTool.Click += handler;
                }
            }
        }

        public virtual Label Label24
        {
            [DebuggerNonUserCode]
            get => 
                this._Label24;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label24 = value;
        }

        public virtual GroupBox fraAggregate
        {
            [DebuggerNonUserCode]
            get => 
                this._fraAggregate;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraAggregate = value;
        }

        public virtual Button cmdSetWeight
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdSetWeight;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdSetWeight_Click);
                if (!ReferenceEquals(this._cmdSetWeight, null))
                {
                    this._cmdSetWeight.Click -= handler;
                }
                this._cmdSetWeight = value;
                if (!ReferenceEquals(this._cmdSetWeight, null))
                {
                    this._cmdSetWeight.Click += handler;
                }
            }
        }

        public virtual TextBox txtGroupWeight
        {
            [DebuggerNonUserCode]
            get => 
                this._txtGroupWeight;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtGroupWeight = value;
        }

        public virtual Button cmdBrowseForSimFile
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseForSimFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowseForSimFile_Click);
                if (!ReferenceEquals(this._cmdBrowseForSimFile, null))
                {
                    this._cmdBrowseForSimFile.Click -= handler;
                }
                this._cmdBrowseForSimFile = value;
                if (!ReferenceEquals(this._cmdBrowseForSimFile, null))
                {
                    this._cmdBrowseForSimFile.Click += handler;
                }
            }
        }

        public virtual Button cmdSetDetectionLimit
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdSetDetectionLimit;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdSetDetectionLimit_Click);
                if (!ReferenceEquals(this._cmdSetDetectionLimit, null))
                {
                    this._cmdSetDetectionLimit.Click -= handler;
                }
                this._cmdSetDetectionLimit = value;
                if (!ReferenceEquals(this._cmdSetDetectionLimit, null))
                {
                    this._cmdSetDetectionLimit.Click += handler;
                }
            }
        }

        public virtual TextBox txtDetectionLimit
        {
            [DebuggerNonUserCode]
            get => 
                this._txtDetectionLimit;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtDetectionLimit = value;
        }

        public virtual Button cmdResetGroups
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdResetGroups;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdResetGroups_Click);
                if (!ReferenceEquals(this._cmdResetGroups, null))
                {
                    this._cmdResetGroups.Click -= handler;
                }
                this._cmdResetGroups = value;
                if (!ReferenceEquals(this._cmdResetGroups, null))
                {
                    this._cmdResetGroups.Click += handler;
                }
            }
        }

        public virtual Button cmdAggregate
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdAggregate;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdAggregate_Click);
                if (!ReferenceEquals(this._cmdAggregate, null))
                {
                    this._cmdAggregate.Click -= handler;
                }
                this._cmdAggregate = value;
                if (!ReferenceEquals(this._cmdAggregate, null))
                {
                    this._cmdAggregate.Click += handler;
                }
            }
        }

        public virtual ListBox lstGroups
        {
            [DebuggerNonUserCode]
            get => 
                this._lstGroups;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lstGroups_SelectedIndexChanged);
                if (!ReferenceEquals(this._lstGroups, null))
                {
                    this._lstGroups.SelectedIndexChanged -= handler;
                }
                this._lstGroups = value;
                if (!ReferenceEquals(this._lstGroups, null))
                {
                    this._lstGroups.SelectedIndexChanged += handler;
                }
            }
        }

        public virtual ListBox lstMeasured
        {
            [DebuggerNonUserCode]
            get => 
                this._lstMeasured;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstMeasured = value;
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

        public virtual Label _lblSimFile_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblSimFile_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblSimFile_1 = value;
        }

        public virtual Label _lblSimFile_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblSimFile_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblSimFile_0 = value;
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
            set
            {
                EventHandler handler = new EventHandler(this.Label16_Click);
                if (!ReferenceEquals(this._Label16, null))
                {
                    this._Label16.Click -= handler;
                }
                this._Label16 = value;
                if (!ReferenceEquals(this._Label16, null))
                {
                    this._Label16.Click += handler;
                }
            }
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

        public virtual Label Label14
        {
            [DebuggerNonUserCode]
            get => 
                this._Label14;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label14 = value;
        }

        public virtual Label _lblStep_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblStep_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblStep_2 = value;
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

        public virtual Button cmdSet
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdSet;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdSet_Click);
                if (!ReferenceEquals(this._cmdSet, null))
                {
                    this._cmdSet.Click -= handler;
                }
                this._cmdSet = value;
                if (!ReferenceEquals(this._cmdSet, null))
                {
                    this._cmdSet.Click += handler;
                }
            }
        }

        public virtual ListBox lstSimulatedVar
        {
            [DebuggerNonUserCode]
            get => 
                this._lstSimulatedVar;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lstSimulatedVar_SelectedIndexChanged);
                if (!ReferenceEquals(this._lstSimulatedVar, null))
                {
                    this._lstSimulatedVar.SelectedIndexChanged -= handler;
                }
                this._lstSimulatedVar = value;
                if (!ReferenceEquals(this._lstSimulatedVar, null))
                {
                    this._lstSimulatedVar.SelectedIndexChanged += handler;
                }
            }
        }

        public virtual ListBox lstCondVar
        {
            [DebuggerNonUserCode]
            get => 
                this._lstCondVar;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lstCondVar_SelectedIndexChanged);
                if (!ReferenceEquals(this._lstCondVar, null))
                {
                    this._lstCondVar.SelectedIndexChanged -= handler;
                }
                this._lstCondVar = value;
                if (!ReferenceEquals(this._lstCondVar, null))
                {
                    this._lstCondVar.SelectedIndexChanged += handler;
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

        public virtual Label Label10
        {
            [DebuggerNonUserCode]
            get => 
                this._Label10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label10 = value;
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

        public virtual Label _lblStep_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblStep_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblStep_5 = value;
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

        public virtual RadioButton _optMultAdd_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optMultAdd_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optMultAdd_1 = value;
        }

        public virtual RadioButton _optMultAdd_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optMultAdd_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optMultAdd_0 = value;
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

        public virtual TextBox txtOffSet
        {
            [DebuggerNonUserCode]
            get => 
                this._txtOffSet;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtOffSet = value;
        }

        public virtual CheckBox chkLogValues
        {
            [DebuggerNonUserCode]
            get => 
                this._chkLogValues;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.chkLogValues_CheckStateChanged);
                if (!ReferenceEquals(this._chkLogValues, null))
                {
                    this._chkLogValues.CheckStateChanged -= handler;
                }
                this._chkLogValues = value;
                if (!ReferenceEquals(this._chkLogValues, null))
                {
                    this._chkLogValues.CheckStateChanged += handler;
                }
            }
        }

        public virtual RadioButton _optGoalFunctionType_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__optGoalFunctionType_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optGoalFunctionType_3 = value;
        }

        public virtual RadioButton _optGoalFunctionType_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__optGoalFunctionType_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optGoalFunctionType_2 = value;
        }

        public virtual RadioButton _optGoalFunctionType_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optGoalFunctionType_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optGoalFunctionType_1 = value;
        }

        public virtual RadioButton _optGoalFunctionType_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optGoalFunctionType_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optGoalFunctionType_0 = value;
        }

        public virtual Label Label18
        {
            [DebuggerNonUserCode]
            get => 
                this._Label18;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Label18_Click);
                if (!ReferenceEquals(this._Label18, null))
                {
                    this._Label18.Click -= handler;
                }
                this._Label18 = value;
                if (!ReferenceEquals(this._Label18, null))
                {
                    this._Label18.Click += handler;
                }
            }
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

        public virtual Label _lblStep_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblStep_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblStep_1 = value;
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

        public virtual RadioButton _optViewResult_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__optViewResult_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optViewResult_4 = value;
        }

        public virtual RadioButton _optViewResult_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__optViewResult_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optViewResult_3 = value;
        }

        public virtual RadioButton _optViewResult_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__optViewResult_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optViewResult_2 = value;
        }

        public virtual RadioButton _optViewResult_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optViewResult_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optViewResult_1 = value;
        }

        public virtual TextBox txtReport
        {
            [DebuggerNonUserCode]
            get => 
                this._txtReport;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtReport = value;
        }

        public virtual RadioButton _optViewResult_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optViewResult_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optViewResult_0 = value;
        }

        public virtual GroupBox _fraStep_6
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_6 = value;
        }

        public virtual TextBox _txtTol_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtTol_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtTol_2 = value;
        }

        public virtual RadioButton _optToleranceInterval_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__optToleranceInterval_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optToleranceInterval_2 = value;
        }

        public virtual CheckBox chkAddVariance
        {
            [DebuggerNonUserCode]
            get => 
                this._chkAddVariance;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkAddVariance = value;
        }

        public virtual TextBox _txtTol_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtTol_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtTol_1 = value;
        }

        public virtual TextBox _txtTol_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__txtTol_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__txtTol_0 = value;
        }

        public virtual RadioButton _optToleranceInterval_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optToleranceInterval_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optToleranceInterval_1 = value;
        }

        public virtual RadioButton _optToleranceInterval_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optToleranceInterval_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optToleranceInterval_0 = value;
        }

        public virtual TextBox txtNoTolerances
        {
            [DebuggerNonUserCode]
            get => 
                this._txtNoTolerances;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtNoTolerances = value;
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

        public virtual Label Label12
        {
            [DebuggerNonUserCode]
            get => 
                this._Label12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label12 = value;
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

        public virtual Label Label23
        {
            [DebuggerNonUserCode]
            get => 
                this._Label23;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label23 = value;
        }

        public virtual Label Label22
        {
            [DebuggerNonUserCode]
            get => 
                this._Label22;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label22 = value;
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

        public virtual GroupBox _fraStep_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__fraStep_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__fraStep_5 = value;
        }

        public virtual TextBox txtMissingData
        {
            [DebuggerNonUserCode]
            get => 
                this._txtMissingData;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtMissingData = value;
        }

        public virtual Button cmdRemoveAll
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdRemoveAll;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdRemoveAll_Click);
                if (!ReferenceEquals(this._cmdRemoveAll, null))
                {
                    this._cmdRemoveAll.Click -= handler;
                }
                this._cmdRemoveAll = value;
                if (!ReferenceEquals(this._cmdRemoveAll, null))
                {
                    this._cmdRemoveAll.Click += handler;
                }
            }
        }

        public virtual Button cmdAddAll
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdAddAll;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdAddAll_Click);
                if (!ReferenceEquals(this._cmdAddAll, null))
                {
                    this._cmdAddAll.Click -= handler;
                }
                this._cmdAddAll = value;
                if (!ReferenceEquals(this._cmdAddAll, null))
                {
                    this._cmdAddAll.Click += handler;
                }
            }
        }

        public virtual Button cmdRemoveVariable
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdRemoveVariable;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdRemoveVariable_Click);
                if (!ReferenceEquals(this._cmdRemoveVariable, null))
                {
                    this._cmdRemoveVariable.Click -= handler;
                }
                this._cmdRemoveVariable = value;
                if (!ReferenceEquals(this._cmdRemoveVariable, null))
                {
                    this._cmdRemoveVariable.Click += handler;
                }
            }
        }

        public virtual Button cmdAddVariable
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdAddVariable;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdAddVariable_Click);
                if (!ReferenceEquals(this._cmdAddVariable, null))
                {
                    this._cmdAddVariable.Click -= handler;
                }
                this._cmdAddVariable = value;
                if (!ReferenceEquals(this._cmdAddVariable, null))
                {
                    this._cmdAddVariable.Click += handler;
                }
            }
        }

        public virtual ListBox lstVariablesInGoalFunction
        {
            [DebuggerNonUserCode]
            get => 
                this._lstVariablesInGoalFunction;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstVariablesInGoalFunction = value;
        }

        public virtual ListBox lstAvailableVariables
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

        public virtual Label Label8
        {
            [DebuggerNonUserCode]
            get => 
                this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label8 = value;
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

        public virtual Label lblCondBinFile
        {
            [DebuggerNonUserCode]
            get => 
                this._lblCondBinFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblCondBinFile = value;
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

        public virtual GroupBox Frame1
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame1 = value;
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

        public virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
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

        public virtual Button cmdStartScript
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdStartScript;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmdStartScript = value;
        }

        public virtual Button cmdBrowseForScript
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseForScript;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmdBrowseForScript = value;
        }

        public virtual TextBox txtScriptFile
        {
            [DebuggerNonUserCode]
            get => 
                this._txtScriptFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtScriptFile = value;
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

        public virtual GroupBoxArray fraStep
        {
            [DebuggerNonUserCode]
            get => 
                this._fraStep;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraStep = value;
        }

        public virtual LabelArray lblSimFile
        {
            [DebuggerNonUserCode]
            get => 
                this._lblSimFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblSimFile = value;
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

        public virtual RadioButtonArray optGoalFunctionType
        {
            [DebuggerNonUserCode]
            get => 
                this._optGoalFunctionType;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optGoalFunctionType_CheckedChanged);
                if (!ReferenceEquals(this._optGoalFunctionType, null))
                {
                    this._optGoalFunctionType.CheckedChanged -= handler;
                }
                this._optGoalFunctionType = value;
                if (!ReferenceEquals(this._optGoalFunctionType, null))
                {
                    this._optGoalFunctionType.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray optMultAdd
        {
            [DebuggerNonUserCode]
            get => 
                this._optMultAdd;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optMultAdd = value;
        }

        public virtual RadioButtonArray optToleranceInterval
        {
            [DebuggerNonUserCode]
            get => 
                this._optToleranceInterval;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optToleranceInterval_CheckedChanged);
                if (!ReferenceEquals(this._optToleranceInterval, null))
                {
                    this._optToleranceInterval.CheckedChanged -= handler;
                }
                this._optToleranceInterval = value;
                if (!ReferenceEquals(this._optToleranceInterval, null))
                {
                    this._optToleranceInterval.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButtonArray optViewResult
        {
            [DebuggerNonUserCode]
            get => 
                this._optViewResult;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.optViewResult_CheckedChanged);
                if (!ReferenceEquals(this._optViewResult, null))
                {
                    this._optViewResult.CheckedChanged -= handler;
                }
                this._optViewResult = value;
                if (!ReferenceEquals(this._optViewResult, null))
                {
                    this._optViewResult.CheckedChanged += handler;
                }
            }
        }

        public virtual TextBoxArray txtTol
        {
            [DebuggerNonUserCode]
            get => 
                this._txtTol;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtTol = value;
        }

        internal virtual ListBox lstProjects
        {
            [DebuggerNonUserCode]
            get => 
                this._lstProjects;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lstProjects_SelectedIndexChanged);
                if (!ReferenceEquals(this._lstProjects, null))
                {
                    this._lstProjects.SelectedIndexChanged -= handler;
                }
                this._lstProjects = value;
                if (!ReferenceEquals(this._lstProjects, null))
                {
                    this._lstProjects.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown udIterationNumber
        {
            [DebuggerNonUserCode]
            get => 
                this._udIterationNumber;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._udIterationNumber = value;
        }

        private string MeasuredBinFile
        {
            get => 
                this.m_CondBinFile;
            set => 
                this.m_CondBinFile = value;
        }

        public string ScriptFile
        {
            get => 
                this.m_ScriptFile;
            set => 
                this.m_ScriptFile = value;
        }

        public bool SingleSimulation
        {
            set => 
                this.m_bSingleSimulation = value;
        }

        public string SimFileName
        {
            set => 
                this.m_SimFileName = value;
        }
    }
}

