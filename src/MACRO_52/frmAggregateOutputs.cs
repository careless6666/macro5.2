namespace MACRO_52
{
    using ADODB;
    using AxComCtl2;
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
    internal class frmAggregateOutputs : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("cmdSetWeights")]
        private Button _cmdSetWeights;
        [AccessedThroughProperty("lstDummy")]
        private ListBox _lstDummy;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("cmdOK")]
        private Button _cmdOK;
        [AccessedThroughProperty("cmdStore")]
        private Button _cmdStore;
        [AccessedThroughProperty("txtGroupThickness")]
        private TextBox _txtGroupThickness;
        [AccessedThroughProperty("txtGroupUnits")]
        private TextBox _txtGroupUnits;
        [AccessedThroughProperty("txtGroupDescription")]
        private TextBox _txtGroupDescription;
        [AccessedThroughProperty("txtGroupName")]
        private TextBox _txtGroupName;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("cmdClear")]
        private Button _cmdClear;
        [AccessedThroughProperty("lstDefinedGroups")]
        private ListBox _lstDefinedGroups;
        [AccessedThroughProperty("cmdGroup")]
        private Button _cmdGroup;
        [AccessedThroughProperty("cmdUpdate")]
        private Button _cmdUpdate;
        [AccessedThroughProperty("UpDown1")]
        private AxUpDown _UpDown1;
        [AccessedThroughProperty("txtIterationNo")]
        private TextBox _txtIterationNo;
        [AccessedThroughProperty("lstAvailableOutputs")]
        private ListBox _lstAvailableOutputs;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("lblSUFIProject")]
        private Label _lblSUFIProject;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        public string m_ProjectName;
        private int m_ProjectID;
        private int m_BaseSimID;
        private string m_sOutputPath;
        private string m_IterationID;
        public int m_IterationNo;
        private int m_nSimulations;
        private object[,] m_Groups;
        private float[,] m_Weights;
        private short m_CurGroup;
        private int m_ProjID;
        private CfrmSUFIMain frmSUFIMain;

        public frmAggregateOutputs(ref CfrmSUFIMain frm, int projid)
        {
            base.Load += new EventHandler(this.frmAggregateOutputs_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmSUFIMain = frm;
            this.m_ProjID = projid;
        }

        private void ClearGroups()
        {
            this.lstDefinedGroups.Items.Clear();
            short num3 = (short) Information.UBound(this.m_Groups, 1);
            short num = 1;
            while (num <= num3)
            {
                short num4 = (short) Information.UBound(this.m_Groups, 2);
                short num2 = 1;
                while (true)
                {
                    short num5 = num4;
                    if (num2 > num5)
                    {
                        num = (short) (num + 1);
                        break;
                    }
                    this.m_Groups[num, num2] = 0;
                    num2 = (short) (num2 + 1);
                }
            }
            this.txtGroupDescription.Text = "";
            this.txtGroupName.Text = "";
            this.txtGroupThickness.Text = "";
            this.txtGroupUnits.Text = "";
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void cmdClear_Click(object eventSender, EventArgs eventArgs)
        {
            this.ClearGroups();
        }

        private void cmdGroup_Click(object eventSender, EventArgs eventArgs)
        {
            ListBox lstAvailableOutputs = this.lstAvailableOutputs;
            string item = "";
            short num2 = (short) (lstAvailableOutputs.Items.Count - 1);
            short index = 0;
            while (true)
            {
                short num5 = num2;
                if (index > num5)
                {
                    lstAvailableOutputs = null;
                    this.lstDefinedGroups.Items.Add(item);
                    this.SetGroupArray();
                    this.txtGroupDescription.Text = " - ";
                    this.txtGroupName.Text = " Group" + Conversions.ToString(this.lstDefinedGroups.Items.Count);
                    this.txtGroupThickness.Text = " - ";
                    this.txtGroupUnits.Text = " - ";
                    short count = (short) this.lstAvailableOutputs.SelectedItems.Count;
                    index = 1;
                    while (true)
                    {
                        num5 = count;
                        if (index > num5)
                        {
                            this.m_CurGroup = (short) this.lstDefinedGroups.Items.Count;
                            this.Store();
                            break;
                        }
                        this.m_Weights[this.lstDefinedGroups.Items.Count, index + 1] = (float) (1.0 / ((double) this.lstAvailableOutputs.SelectedItems.Count));
                        index = (short) (index + 1);
                    }
                    break;
                }
                if (lstAvailableOutputs.GetSelected(index))
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

        private void cmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            this.CreateNewFiles();
            this.Close();
        }

        private void cmdSetWeights_Click(object eventSender, EventArgs eventArgs)
        {
            frmSetWeights weights = new frmSetWeights(ref this.frmSUFIMain.MainForm);
            if (this.lstDefinedGroups.Items.Count <= 0)
            {
                MiscFUncs.MsgBox_Renamed("Please define at least one group first", 0x40, "Define a group");
            }
            else
            {
                frmSetWeights weights2 = weights;
                weights2.grdWeights.set_ColWidth(0, 0x1388);
                weights2.grdWeights.set_TextMatrix(0, 0, "Variable name:");
                weights2.grdWeights.set_TextMatrix(0, 1, "Weight:");
                weights2.grdWeights.CellAlignment = 4;
                weights2.grdWeights.Rows = 1;
                short num2 = (short) Information.UBound(this.m_Groups, 1);
                short row = 1;
                while (true)
                {
                    short num4 = num2;
                    if (row > num4)
                    {
                        weights.SetTempWeights(ref this.m_Weights, ref (short) (this.lstDefinedGroups.SelectedIndex + 1));
                        weights.DisplayWeights();
                        weights.lblWeightSum.Text = Support.Format(Conversions.ToString(weights2.ComputeWeightSum()), "#.###", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
                        weights.RunID = this.m_BaseSimID;
                        weights.pForm = this;
                        weights2.ShowDialog();
                        weights2 = null;
                        break;
                    }
                    if (Operators.ConditionalCompareObjectNotEqual(this.m_Groups[this.lstDefinedGroups.SelectedIndex + 1, row + 5], 0, false))
                    {
                        weights2.grdWeights.Rows++;
                        weights2.grdWeights.set_TextMatrix(row, 0, Support.GetItemString(this.lstAvailableOutputs, Conversions.ToShort(this.m_Groups[this.lstDefinedGroups.SelectedIndex + 1, row + 5]) - 1));
                    }
                    row = (short) (row + 1);
                }
            }
        }

        public void cmdStore_Click(object eventSender, EventArgs eventArgs)
        {
            this.Store();
        }

        private void cmdUpdate_Click(object eventSender, EventArgs eventArgs)
        {
            this.GetProjectInfo();
            this.Update_Renamed();
        }

        private void CreateNewFiles()
        {
            // Invalid method body.
        }

        private void DisplayGroup(ref short grp)
        {
            if (grp >= 0)
            {
                frmAggregateOutputs outputs = this;
                outputs.txtGroupDescription.Text = Conversions.ToString(this.m_Groups[grp, 1]);
                outputs.txtGroupName.Text = Conversions.ToString(this.m_Groups[grp, 2]);
                outputs.txtGroupThickness.Text = Conversions.ToString(this.m_Groups[grp, 3]);
                outputs.txtGroupUnits.Text = Conversions.ToString(this.m_Groups[grp, 4]);
                outputs = null;
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

        private void FillGroupListBox()
        {
            string item = "";
            this.lstDefinedGroups.Items.Clear();
            short num3 = (short) Information.UBound(this.m_Groups, 1);
            short num = 1;
            while (true)
            {
                if ((num <= num3) && (GlobalVariables.Groups[num, 6] != 0))
                {
                    short num4 = (short) Information.UBound(this.m_Groups, 2);
                    short num2 = 1;
                    while (true)
                    {
                        short num5 = num4;
                        if (num2 > num5)
                        {
                            this.lstDefinedGroups.Items.Add(item);
                            item = "";
                            num = (short) (num + 1);
                            break;
                        }
                        if (GlobalVariables.Groups[num, num2 + 5] != 0)
                        {
                            item = item + " " + Conversions.ToString((int) GlobalVariables.Groups[num, num2 + 5]);
                        }
                        num2 = (short) (num2 + 1);
                    }
                    continue;
                }
                return;
            }
        }

        private void frmAggregateOutputs_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmSUFIMain.Icon;
        }

        public bool GetProjectInfo()
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = rs;
            recordset2.Open("select * from sufiprojects where ProjectName='" + this.m_ProjectName + "'", this.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.m_ProjectID = Conversions.ToInteger(recordset2[]["SUFIProjectID"][]);
            this.m_BaseSimID = Conversions.ToInteger(recordset2[]["BaseRunID"][]);
            this.frmSUFIMain.dbParameters = new RecordsetClass();
            this.frmSUFIMain.dbParameters.Open(Operators.ConcatenateObject("select * from SUFIParameters where SUFIProjectID=", recordset2[]["SUFIProjectID"][]), this.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            CfrmSUFIMain frmSUFIMain = this.frmSUFIMain;
            Recordset dbParameters = frmSUFIMain.dbParameters;
            frmSUFIMain.dbParameters = dbParameters;
            if (ReadSaveFunctions.RecordCount(ref dbParameters) == 0)
            {
                MiscFUncs.MsgBox_Renamed("Parameter information for the selected project not found", 0x30, "Error");
            }
            else
            {
                recordset2.Close();
                recordset2 = null;
                Recordset recordset4 = rs;
                this.m_IterationNo = Conversions.ToInteger(this.txtIterationNo.Text);
                recordset4.Open("select * from SUFIIterations where IterationNO=" + Conversions.ToString(this.m_IterationNo) + " and SUFIProjectID=" + Conversions.ToString(this.m_ProjID), this.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                if (ReadSaveFunctions.RecordCount(ref rs) == 0)
                {
                    MiscFUncs.MsgBox_Renamed("No iterations were found for this project!", 0x30, "Iterations missing");
                }
                else
                {
                    recordset4.MoveFirst();
                    this.m_nSimulations = Conversions.ToInteger(recordset4[]["Nosimulations"][]);
                    recordset4.Find("IterationNO=" + Conversions.ToString(this.m_IterationNo), 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                    this.m_sOutputPath = Conversions.ToString(recordset4[]["outputfilepath"][]);
                    this.m_IterationID = Conversions.ToString(recordset4[]["IterationID"][]);
                    recordset4.Close();
                    recordset4 = null;
                }
            }
            return true;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmAggregateOutputs));
            this.cmdClear = new Button();
            this.cmdGroup = new Button();
            this.Frame1 = new GroupBox();
            this.cmdSetWeights = new Button();
            this.lstDummy = new ListBox();
            this.cmdCancel = new Button();
            this.cmdOK = new Button();
            this.Frame2 = new GroupBox();
            this.cmdStore = new Button();
            this.txtGroupThickness = new TextBox();
            this.txtGroupUnits = new TextBox();
            this.txtGroupDescription = new TextBox();
            this.txtGroupName = new TextBox();
            this.Label8 = new Label();
            this.Label7 = new Label();
            this.Label6 = new Label();
            this.Label5 = new Label();
            this.lstDefinedGroups = new ListBox();
            this.cmdUpdate = new Button();
            this.UpDown1 = new AxUpDown();
            this.txtIterationNo = new TextBox();
            this.lstAvailableOutputs = new ListBox();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.lblSUFIProject = new Label();
            this.Label1 = new Label();
            this.Frame1.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.UpDown1.BeginInit();
            this.SuspendLayout();
            this.cmdClear.BackColor = SystemColors.Control;
            this.cmdClear.Cursor = Cursors.Default;
            this.cmdClear.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdClear.ForeColor = SystemColors.ControlText;
            Point point = new Point(0x180, 0x128);
            this.cmdClear.Location = point;
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.RightToLeft = RightToLeft.No;
            Size size = new Size(0x49, 0x19);
            this.cmdClear.Size = size;
            this.cmdClear.TabIndex = 12;
            this.cmdClear.Text = "&Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdGroup.BackColor = SystemColors.Control;
            this.cmdGroup.Cursor = Cursors.Default;
            this.cmdGroup.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdGroup.ForeColor = SystemColors.ControlText;
            point = new Point(200, 0x128);
            this.cmdGroup.Location = point;
            this.cmdGroup.Name = "cmdGroup";
            this.cmdGroup.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x19);
            this.cmdGroup.Size = size;
            this.cmdGroup.TabIndex = 9;
            this.cmdGroup.Text = "&Group";
            this.cmdGroup.UseVisualStyleBackColor = false;
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.cmdSetWeights);
            this.Frame1.Controls.Add(this.lstDummy);
            this.Frame1.Controls.Add(this.cmdCancel);
            this.Frame1.Controls.Add(this.cmdOK);
            this.Frame1.Controls.Add(this.Frame2);
            this.Frame1.Controls.Add(this.cmdClear);
            this.Frame1.Controls.Add(this.lstDefinedGroups);
            this.Frame1.Controls.Add(this.cmdGroup);
            this.Frame1.Controls.Add(this.cmdUpdate);
            this.Frame1.Controls.Add(this.UpDown1);
            this.Frame1.Controls.Add(this.txtIterationNo);
            this.Frame1.Controls.Add(this.lstAvailableOutputs);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.lblSUFIProject);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(0, 0);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x2a9, 0x149);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            this.cmdSetWeights.BackColor = SystemColors.Control;
            this.cmdSetWeights.Cursor = Cursors.Default;
            this.cmdSetWeights.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdSetWeights.ForeColor = SystemColors.ControlText;
            point = new Point(0x11b, 0x128);
            this.cmdSetWeights.Location = point;
            this.cmdSetWeights.Name = "cmdSetWeights";
            this.cmdSetWeights.RightToLeft = RightToLeft.No;
            size = new Size(0x5f, 0x19);
            this.cmdSetWeights.Size = size;
            this.cmdSetWeights.TabIndex = 0x1c;
            this.cmdSetWeights.Text = "&Set weights";
            this.cmdSetWeights.UseVisualStyleBackColor = false;
            this.lstDummy.BackColor = SystemColors.Window;
            this.lstDummy.Cursor = Cursors.Default;
            this.lstDummy.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstDummy.ForeColor = SystemColors.WindowText;
            this.lstDummy.ItemHeight = 14;
            point = new Point(40, 0x130);
            this.lstDummy.Location = point;
            this.lstDummy.Name = "lstDummy";
            this.lstDummy.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x20);
            this.lstDummy.Size = size;
            this.lstDummy.TabIndex = 0x1a;
            this.lstDummy.Visible = false;
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(600, 0x108);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 0x19;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdOK.BackColor = SystemColors.Control;
            this.cmdOK.Cursor = Cursors.Default;
            this.cmdOK.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK.ForeColor = SystemColors.ControlText;
            point = new Point(600, 0x128);
            this.cmdOK.Location = point;
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdOK.Size = size;
            this.cmdOK.TabIndex = 0x18;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this.cmdStore);
            this.Frame2.Controls.Add(this.txtGroupThickness);
            this.Frame2.Controls.Add(this.txtGroupUnits);
            this.Frame2.Controls.Add(this.txtGroupDescription);
            this.Frame2.Controls.Add(this.txtGroupName);
            this.Frame2.Controls.Add(this.Label8);
            this.Frame2.Controls.Add(this.Label7);
            this.Frame2.Controls.Add(this.Label6);
            this.Frame2.Controls.Add(this.Label5);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(0x1d0, 0x58);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0xc9, 0xa1);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 13;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Settings for selected group:";
            this.cmdStore.BackColor = SystemColors.Control;
            this.cmdStore.Cursor = Cursors.Default;
            this.cmdStore.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdStore.ForeColor = SystemColors.ControlText;
            point = new Point(120, 120);
            this.cmdStore.Location = point;
            this.cmdStore.Name = "cmdStore";
            this.cmdStore.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdStore.Size = size;
            this.cmdStore.TabIndex = 0x1b;
            this.cmdStore.Text = "&Store";
            this.cmdStore.UseVisualStyleBackColor = false;
            this.txtGroupThickness.AcceptsReturn = true;
            this.txtGroupThickness.BackColor = SystemColors.Window;
            this.txtGroupThickness.Cursor = Cursors.IBeam;
            this.txtGroupThickness.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtGroupThickness.ForeColor = SystemColors.WindowText;
            point = new Point(0x48, 0x60);
            this.txtGroupThickness.Location = point;
            this.txtGroupThickness.MaxLength = 4;
            this.txtGroupThickness.Name = "txtGroupThickness";
            this.txtGroupThickness.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 20);
            this.txtGroupThickness.Size = size;
            this.txtGroupThickness.TabIndex = 0x15;
            this.txtGroupThickness.Visible = false;
            this.txtGroupUnits.AcceptsReturn = true;
            this.txtGroupUnits.BackColor = SystemColors.Window;
            this.txtGroupUnits.Cursor = Cursors.IBeam;
            this.txtGroupUnits.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtGroupUnits.ForeColor = SystemColors.WindowText;
            point = new Point(0x48, 0x30);
            this.txtGroupUnits.Location = point;
            this.txtGroupUnits.MaxLength = 8;
            this.txtGroupUnits.Name = "txtGroupUnits";
            this.txtGroupUnits.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 20);
            this.txtGroupUnits.Size = size;
            this.txtGroupUnits.TabIndex = 20;
            this.txtGroupDescription.AcceptsReturn = true;
            this.txtGroupDescription.BackColor = SystemColors.Window;
            this.txtGroupDescription.Cursor = Cursors.IBeam;
            this.txtGroupDescription.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtGroupDescription.ForeColor = SystemColors.WindowText;
            point = new Point(0x48, 0x18);
            this.txtGroupDescription.Location = point;
            this.txtGroupDescription.MaxLength = 20;
            this.txtGroupDescription.Name = "txtGroupDescription";
            this.txtGroupDescription.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 20);
            this.txtGroupDescription.Size = size;
            this.txtGroupDescription.TabIndex = 0x13;
            this.txtGroupDescription.Text = "Text1";
            this.txtGroupName.AcceptsReturn = true;
            this.txtGroupName.BackColor = SystemColors.Window;
            this.txtGroupName.Cursor = Cursors.IBeam;
            this.txtGroupName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtGroupName.ForeColor = SystemColors.WindowText;
            point = new Point(0x48, 0x48);
            this.txtGroupName.Location = point;
            this.txtGroupName.MaxLength = 20;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 20);
            this.txtGroupName.Size = size;
            this.txtGroupName.TabIndex = 0x12;
            this.txtGroupName.Visible = false;
            this.Label8.BackColor = SystemColors.Control;
            this.Label8.Cursor = Cursors.Default;
            this.Label8.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x60);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.Label8.Size = size;
            this.Label8.TabIndex = 0x11;
            this.Label8.Text = "Position:";
            this.Label8.Visible = false;
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x30);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 0x10;
            this.Label7.Text = "Units:";
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x18);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.Label6.Size = size;
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Description:";
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x48);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Identification:";
            this.Label5.Visible = false;
            this.lstDefinedGroups.BackColor = SystemColors.Window;
            this.lstDefinedGroups.Cursor = Cursors.Default;
            this.lstDefinedGroups.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstDefinedGroups.ForeColor = SystemColors.WindowText;
            this.lstDefinedGroups.ItemHeight = 14;
            point = new Point(280, 0x68);
            this.lstDefinedGroups.Location = point;
            this.lstDefinedGroups.Name = "lstDefinedGroups";
            this.lstDefinedGroups.RightToLeft = RightToLeft.No;
            size = new Size(0xb1, 0xba);
            this.lstDefinedGroups.Size = size;
            this.lstDefinedGroups.TabIndex = 11;
            this.cmdUpdate.BackColor = SystemColors.Control;
            this.cmdUpdate.Cursor = Cursors.Default;
            this.cmdUpdate.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdUpdate.ForeColor = SystemColors.ControlText;
            point = new Point(0x90, 0x30);
            this.cmdUpdate.Location = point;
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdUpdate.Size = size;
            this.cmdUpdate.TabIndex = 7;
            this.cmdUpdate.Text = "&Update";
            this.cmdUpdate.UseVisualStyleBackColor = false;
            point = new Point(0x75, 0x38);
            this.UpDown1.Location = point;
            this.UpDown1.Name = "UpDown1";
            this.UpDown1.OcxState = (AxHost.State) manager.GetObject("UpDown1.OcxState");
            size = new Size(0x11, 0x13);
            this.UpDown1.Size = size;
            this.UpDown1.TabIndex = 6;
            this.txtIterationNo.AcceptsReturn = true;
            this.txtIterationNo.BackColor = SystemColors.Window;
            this.txtIterationNo.Cursor = Cursors.IBeam;
            this.txtIterationNo.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtIterationNo.ForeColor = SystemColors.WindowText;
            point = new Point(0x68, 0x38);
            this.txtIterationNo.Location = point;
            this.txtIterationNo.MaxLength = 0;
            this.txtIterationNo.Name = "txtIterationNo";
            this.txtIterationNo.RightToLeft = RightToLeft.No;
            size = new Size(12, 20);
            this.txtIterationNo.Size = size;
            this.txtIterationNo.TabIndex = 5;
            this.lstAvailableOutputs.BackColor = SystemColors.Window;
            this.lstAvailableOutputs.Cursor = Cursors.Default;
            this.lstAvailableOutputs.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstAvailableOutputs.ForeColor = SystemColors.WindowText;
            this.lstAvailableOutputs.ItemHeight = 14;
            point = new Point(0x10, 0x68);
            this.lstAvailableOutputs.Location = point;
            this.lstAvailableOutputs.Name = "lstAvailableOutputs";
            this.lstAvailableOutputs.RightToLeft = RightToLeft.No;
            this.lstAvailableOutputs.SelectionMode = SelectionMode.MultiExtended;
            size = new Size(0xf9, 0xba);
            this.lstAvailableOutputs.Size = size;
            this.lstAvailableOutputs.TabIndex = 1;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(280, 0x58);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x89, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Currently defined groups:";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x58);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Available outputs for selected iteration:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x38);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Iteration number:";
            this.lblSUFIProject.BackColor = SystemColors.Window;
            this.lblSUFIProject.BorderStyle = BorderStyle.FixedSingle;
            this.lblSUFIProject.Cursor = Cursors.Default;
            this.lblSUFIProject.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblSUFIProject.ForeColor = SystemColors.WindowText;
            point = new Point(0x60, 0x18);
            this.lblSUFIProject.Location = point;
            this.lblSUFIProject.Name = "lblSUFIProject";
            this.lblSUFIProject.RightToLeft = RightToLeft.No;
            size = new Size(0x131, 0x11);
            this.lblSUFIProject.Size = size;
            this.lblSUFIProject.TabIndex = 3;
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x18);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 2;
            this.Label1.Text = "SUFI project:";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            size = new Size(0x2ad, 0x14d);
            this.ClientSize = size;
            this.Controls.Add(this.Frame1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(4, 0x17);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAggregateOutputs";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Aggregate outputs";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.UpDown1.EndInit();
            this.ResumeLayout(false);
        }

        private bool IsInGroup(ref short varno)
        {
            bool flag;
            short count = (short) this.lstAvailableOutputs.Items.Count;
            short num = 1;
            while (true)
            {
                if (num <= count)
                {
                    short num4 = (short) this.lstAvailableOutputs.Items.Count;
                    short num2 = 1;
                    while (true)
                    {
                        short num5 = num4;
                        if (num2 <= num5)
                        {
                            if (!Operators.ConditionalCompareObjectEqual(this.m_Groups[num, num2 + 5], (short) varno, false))
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

        private void lstDefinedGroups_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            this.m_CurGroup = (short) (this.lstDefinedGroups.SelectedIndex + 1);
            this.DisplayGroup(ref this.m_CurGroup);
        }

        private void SetGroupArray()
        {
            short count = (short) this.lstDefinedGroups.Items.Count;
            short num = 1;
            while (true)
            {
                short num2;
                short num8 = count;
                if (num > num8)
                {
                    short num6 = (short) this.lstAvailableOutputs.Items.Count;
                    num = (short) (this.lstDefinedGroups.Items.Count + 1);
                    while (num <= num6)
                    {
                        short num7 = (short) Information.UBound(this.m_Groups, 1);
                        num2 = 1;
                        while (true)
                        {
                            num8 = num7;
                            if (num2 > num8)
                            {
                                num = (short) (num + 1);
                                break;
                            }
                            this.m_Groups[num, num2] = 0;
                            num2 = (short) (num2 + 1);
                        }
                    }
                    return;
                }
                short start = 1;
                this.lstDefinedGroups.SelectedIndex = num - 1;
                string str = Strings.Trim(this.lstDefinedGroups.Text);
                short num4 = (short) Strings.InStr(start, str, " ", CompareMethod.Binary);
                num2 = 0;
                bool flag = num4 == 0;
                if (flag)
                {
                    this.m_Groups[num, (num2 + 1) + 5] = str;
                }
                else
                {
                    while (true)
                    {
                        flag = num4 != 0;
                        if (!flag)
                        {
                            this.m_Groups[num, ((short) (num2 + 1)) + 5] = Strings.Mid(str, start);
                            break;
                        }
                        num2 = (short) (num2 + 1);
                        this.m_Groups[num, num2 + 5] = Strings.Mid(str, start, (short) (num4 - start));
                        start = num4;
                        num4 = (short) Strings.InStr(start + 1, str, " ", CompareMethod.Binary);
                    }
                }
                num = (short) (num + 1);
            }
        }

        public void Store()
        {
            FixedLengthString str = new FixedLengthString(60);
            FixedLengthString str2 = str;
            string sDest = str2.Value;
            StringType.MidStmtStr(ref sDest, 1, 20, this.txtGroupDescription.Text + Strings.Space(20 - Strings.Len(this.txtGroupDescription.Text)));
            str2.Value = sDest;
            str2 = str;
            sDest = str2.Value;
            StringType.MidStmtStr(ref sDest, 0x15, 8, this.txtGroupUnits.Text + Strings.Space(9 - Strings.Len(this.txtGroupUnits.Text)));
            str2.Value = sDest;
            str2 = str;
            sDest = str2.Value;
            StringType.MidStmtStr(ref sDest, 0x1d, 20, this.txtGroupName.Text + Strings.Space(20 - Strings.Len(this.txtGroupName.Text)));
            str2.Value = sDest;
            str2 = str;
            sDest = str2.Value;
            StringType.MidStmtStr(ref sDest, 0x31, 4, this.txtGroupThickness.Text + Strings.Space(4 - Strings.Len(this.txtGroupThickness.Text)));
            str2.Value = sDest;
            this.m_Groups[this.lstDefinedGroups.SelectedIndex + 1, 1] = this.txtGroupDescription.Text;
            this.m_Groups[this.lstDefinedGroups.SelectedIndex + 1, 2] = this.txtGroupName.Text;
            this.m_Groups[this.lstDefinedGroups.SelectedIndex + 1, 5] = str.Value;
            this.m_Groups[this.lstDefinedGroups.SelectedIndex + 1, 4] = this.txtGroupUnits.Text;
            this.m_Groups[this.lstDefinedGroups.SelectedIndex + 1, 3] = this.txtGroupThickness.Text;
        }

        public void StoreWeights(ref float[] weights)
        {
            short num2 = (short) Information.UBound(weights, 1);
            short index = 1;
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    return;
                }
                this.m_Weights[this.m_CurGroup, index + 1] = weights[index];
                index = (short) (index + 1);
            }
        }

        public bool Update_Renamed()
        {
            string fname = "";
            Recordset recordset = new RecordsetClass();
            recordset.Open("select * from SUFIStrataCombinations where IterationID=" + this.m_IterationID, this.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            short nSimulations = (short) this.m_nSimulations;
            short index = 1;
            while (true)
            {
                bool flag;
                short num4 = nSimulations;
                if (index <= num4)
                {
                    Recordset recordset2 = recordset;
                    fname = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((((this.m_sOutputPath + @"\") + "iter" + "_") + Conversions.ToString(this.m_IterationNo) + "_") + Conversions.ToString(this.m_BaseSimID) + "_", recordset2[]["StrataComboNo"][]), ".bin"));
                    if (MiscFUncs.FileExists(fname))
                    {
                        recordset2.MoveNext();
                        recordset2 = null;
                        index = (short) (index + 1);
                        continue;
                    }
                    MiscFUncs.MsgBox_Renamed("One of the outputfiles: " + fname + "\rcould not be found. Make sure that the file is in the \rspecified directory (" + this.m_sOutputPath + ") and is \rnot being used by another application.", 0x30, "Missing file");
                }
                else
                {
                    recordset.Close();
                    this.lstDummy.Items.Clear();
                    this.lstAvailableOutputs.Items.Clear();
                    this.lstDefinedGroups.Items.Clear();
                    if (MiscFUncs.FillVarsList(ref fname, ref this.lstDummy))
                    {
                        short num3 = (short) (this.lstDummy.Items.Count - 1);
                        index = 0;
                        while (true)
                        {
                            num4 = num3;
                            if (index > num4)
                            {
                                this.m_Groups = new object[this.lstAvailableOutputs.Items.Count + 1, (this.lstAvailableOutputs.Items.Count + 5) + 1];
                                this.m_Weights = new float[this.lstAvailableOutputs.Items.Count + 1, (this.lstAvailableOutputs.Items.Count + 1) + 1];
                                flag = true;
                                break;
                            }
                            Support.SetItemString(this.lstAvailableOutputs, index, Conversions.ToString((int) (index + 1)) + " " + Support.GetItemString(this.lstDummy, index));
                            index = (short) (index + 1);
                        }
                    }
                }
                return flag;
            }
        }

        private void UpDown1_Change(object eventSender, EventArgs eventArgs)
        {
            this.m_IterationNo = Conversions.ToInteger(this.txtIterationNo.Text);
        }

        private short VarsInThisGroup(ref short grp)
        {
            short num;
            if (Strings.Len(this.m_Groups[grp, 5]) == 0)
            {
                num = 0;
            }
            else
            {
                num = 1;
                while (true)
                {
                    if (!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(this.m_Groups[grp, num + 5], 0, false), !Information.IsNothing(this.m_Groups[grp, num + 5]))))
                    {
                        if (num != 1)
                        {
                            num = (short) (num - 1);
                        }
                        break;
                    }
                    num = (short) (num + 1);
                }
            }
            return num;
        }

        private float WeightedAverage(ref float[] vals, ref float[,] weights, ref short grp)
        {
            short num3 = (short) Information.UBound(vals, 1);
            short index = 1;
            while (true)
            {
                float num2;
                short num4 = num3;
                if (index > num4)
                {
                    return num2;
                }
                num2 += vals[index] * weights[grp, index + 1];
                index = (short) (index + 1);
            }
        }

        public virtual Button cmdSetWeights
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdSetWeights;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdSetWeights_Click);
                if (!ReferenceEquals(this._cmdSetWeights, null))
                {
                    this._cmdSetWeights.Click -= handler;
                }
                this._cmdSetWeights = value;
                if (!ReferenceEquals(this._cmdSetWeights, null))
                {
                    this._cmdSetWeights.Click += handler;
                }
            }
        }

        public virtual ListBox lstDummy
        {
            [DebuggerNonUserCode]
            get => 
                this._lstDummy;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstDummy = value;
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

        public virtual Button cmdStore
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdStore;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdStore_Click);
                if (!ReferenceEquals(this._cmdStore, null))
                {
                    this._cmdStore.Click -= handler;
                }
                this._cmdStore = value;
                if (!ReferenceEquals(this._cmdStore, null))
                {
                    this._cmdStore.Click += handler;
                }
            }
        }

        public virtual TextBox txtGroupThickness
        {
            [DebuggerNonUserCode]
            get => 
                this._txtGroupThickness;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtGroupThickness = value;
        }

        public virtual TextBox txtGroupUnits
        {
            [DebuggerNonUserCode]
            get => 
                this._txtGroupUnits;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtGroupUnits = value;
        }

        public virtual TextBox txtGroupDescription
        {
            [DebuggerNonUserCode]
            get => 
                this._txtGroupDescription;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtGroupDescription = value;
        }

        public virtual TextBox txtGroupName
        {
            [DebuggerNonUserCode]
            get => 
                this._txtGroupName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtGroupName = value;
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

        public virtual GroupBox Frame2
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame2 = value;
        }

        public virtual Button cmdClear
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdClear;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdClear_Click);
                if (!ReferenceEquals(this._cmdClear, null))
                {
                    this._cmdClear.Click -= handler;
                }
                this._cmdClear = value;
                if (!ReferenceEquals(this._cmdClear, null))
                {
                    this._cmdClear.Click += handler;
                }
            }
        }

        public virtual ListBox lstDefinedGroups
        {
            [DebuggerNonUserCode]
            get => 
                this._lstDefinedGroups;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.lstDefinedGroups_SelectedIndexChanged);
                if (!ReferenceEquals(this._lstDefinedGroups, null))
                {
                    this._lstDefinedGroups.SelectedIndexChanged -= handler;
                }
                this._lstDefinedGroups = value;
                if (!ReferenceEquals(this._lstDefinedGroups, null))
                {
                    this._lstDefinedGroups.SelectedIndexChanged += handler;
                }
            }
        }

        public virtual Button cmdGroup
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdGroup;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdGroup_Click);
                if (!ReferenceEquals(this._cmdGroup, null))
                {
                    this._cmdGroup.Click -= handler;
                }
                this._cmdGroup = value;
                if (!ReferenceEquals(this._cmdGroup, null))
                {
                    this._cmdGroup.Click += handler;
                }
            }
        }

        public virtual Button cmdUpdate
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdUpdate;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdUpdate_Click);
                if (!ReferenceEquals(this._cmdUpdate, null))
                {
                    this._cmdUpdate.Click -= handler;
                }
                this._cmdUpdate = value;
                if (!ReferenceEquals(this._cmdUpdate, null))
                {
                    this._cmdUpdate.Click += handler;
                }
            }
        }

        public virtual AxUpDown UpDown1
        {
            [DebuggerNonUserCode]
            get => 
                this._UpDown1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.UpDown1_Change);
                if (!ReferenceEquals(this._UpDown1, null))
                {
                    this._UpDown1.Change -= handler;
                }
                this._UpDown1 = value;
                if (!ReferenceEquals(this._UpDown1, null))
                {
                    this._UpDown1.Change += handler;
                }
            }
        }

        public virtual TextBox txtIterationNo
        {
            [DebuggerNonUserCode]
            get => 
                this._txtIterationNo;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtIterationNo = value;
        }

        public virtual ListBox lstAvailableOutputs
        {
            [DebuggerNonUserCode]
            get => 
                this._lstAvailableOutputs;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstAvailableOutputs = value;
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

        public virtual Label lblSUFIProject
        {
            [DebuggerNonUserCode]
            get => 
                this._lblSUFIProject;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblSUFIProject = value;
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

        public object RunID =>
            this.m_BaseSimID;
    }
}

