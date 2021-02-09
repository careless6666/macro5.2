namespace MACRO_52
{
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
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class CfrmAddFile : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("txtNoVars")]
        private TextBox _txtNoVars;
        [AccessedThroughProperty("_optTypeOfFile_5")]
        private RadioButton __optTypeOfFile_5;
        [AccessedThroughProperty("_optTypeOfFile_4")]
        private RadioButton __optTypeOfFile_4;
        [AccessedThroughProperty("_optTypeOfFile_3")]
        private RadioButton __optTypeOfFile_3;
        [AccessedThroughProperty("_optTypeOfFile_2")]
        private RadioButton __optTypeOfFile_2;
        [AccessedThroughProperty("_optTypeOfFile_1")]
        private RadioButton __optTypeOfFile_1;
        [AccessedThroughProperty("_optTypeOfFile_0")]
        private RadioButton __optTypeOfFile_0;
        [AccessedThroughProperty("lblVariables")]
        private Label _lblVariables;
        [AccessedThroughProperty("lblContent")]
        private Label _lblContent;
        [AccessedThroughProperty("_lblStep_3")]
        private Label __lblStep_3;
        [AccessedThroughProperty("_fraStep_1")]
        private GroupBox __fraStep_1;
        [AccessedThroughProperty("cmdCancel")]
        private Button _cmdCancel;
        [AccessedThroughProperty("cmdPrevious")]
        private Button _cmdPrevious;
        [AccessedThroughProperty("cmdNext")]
        private Button _cmdNext;
        [AccessedThroughProperty("grdBinFile")]
        private AxMSFlexGrid _grdBinFile;
        [AccessedThroughProperty("cmdBrowseForBin")]
        private Button _cmdBrowseForBin;
        [AccessedThroughProperty("txtBinFile")]
        private TextBox _txtBinFile;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("_lblStep_2")]
        private Label __lblStep_2;
        [AccessedThroughProperty("_fraStep_3")]
        private GroupBox __fraStep_3;
        [AccessedThroughProperty("cmdSetVarDesc")]
        private Button _cmdSetVarDesc;
        [AccessedThroughProperty("txtVarDesc")]
        private TextBox _txtVarDesc;
        [AccessedThroughProperty("cmbVarDescs")]
        private ComboBox _cmbVarDescs;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("fraVarDescs")]
        private GroupBox _fraVarDescs;
        [AccessedThroughProperty("_cmbVariable_5")]
        private ComboBox __cmbVariable_5;
        [AccessedThroughProperty("_cmbVariable_4")]
        private ComboBox __cmbVariable_4;
        [AccessedThroughProperty("_cmbVariable_3")]
        private ComboBox __cmbVariable_3;
        [AccessedThroughProperty("_cmbVariable_2")]
        private ComboBox __cmbVariable_2;
        [AccessedThroughProperty("_cmbVariable_1")]
        private ComboBox __cmbVariable_1;
        [AccessedThroughProperty("_cmbVariable_0")]
        private ComboBox __cmbVariable_0;
        [AccessedThroughProperty("grdTextFile")]
        private AxMSFlexGrid _grdTextFile;
        [AccessedThroughProperty("cmdBrowseForText")]
        private Button _cmdBrowseForText;
        [AccessedThroughProperty("txtTextFile")]
        private TextBox _txtTextFile;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("_lblStep_1")]
        private Label __lblStep_1;
        [AccessedThroughProperty("_fraStep_2")]
        private GroupBox __fraStep_2;
        [AccessedThroughProperty("_optAction_1")]
        private RadioButton __optAction_1;
        [AccessedThroughProperty("_optAction_0")]
        private RadioButton __optAction_0;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("_lblStep_0")]
        private Label __lblStep_0;
        [AccessedThroughProperty("_fraStep_0")]
        private GroupBox __fraStep_0;
        [AccessedThroughProperty("cmbVariable")]
        private ComboBoxArray _cmbVariable;
        [AccessedThroughProperty("fraStep")]
        private GroupBoxArray _fraStep;
        [AccessedThroughProperty("lblStep")]
        private LabelArray _lblStep;
        [AccessedThroughProperty("optAction")]
        private RadioButtonArray _optAction;
        [AccessedThroughProperty("optTypeOfFile")]
        private RadioButtonArray _optTypeOfFile;
        private int PreviousFrame;
        private int NextFrame;
        private int ThisFrame;
        public string BinFileName;
        public string TextFileName;
        public int NoVar;
        private string[] VarDesc;
        private int[] Order;
        private int VarsInASCII;
        private string[] BinDates;
        public int startdate;
        public int StopDate;
        public int dt;
        public int nVariables;
        public bool FileConversion;
        private CfrmMain frmMain;

        public CfrmAddFile(ref CfrmMain frm)
        {
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
            this.HideAll();
            this._fraStep_0.Left = 0;
        }

        private void cmbVarDescs_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            this.txtVarDesc.Text = this.cmbVarDescs.Text;
        }

        private void cmbVarDescs_TextChanged(object eventSender, EventArgs eventArgs)
        {
            this.txtVarDesc.Text = this.cmbVarDescs.Text;
        }

        private void cmdBrowseForBin_Click(object eventSender, EventArgs eventArgs)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            OpenFileDialog dialog2 = dlg;
            dialog2.Filter = "bin files (*.bin)|*.bin";
            dialog2.FileName = "";
            dialog2.Title = "Select .bin-file";
            dialog2 = null;
            this.BinFileName = MiscFUncs.BrowseOpen(ref dlg);
            if (this.BinFileName != "")
            {
                this.txtBinFile.Text = dlg.FileName;
                this.cmdNext.Enabled = true;
                this.SetNoVar();
                this.SetUpBinGrid();
                this.DisplayBinFileContent();
            }
        }

        private void cmdBrowseForText_Click(object eventSender, EventArgs eventArgs)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            OpenFileDialog dialog2 = dlg;
            dialog2.Filter = "txt files (*.txt)|*.txt";
            dialog2.FileName = "";
            dialog2.Title = "Select .txt-file";
            dialog2 = null;
            this.TextFileName = MiscFUncs.BrowseOpen(ref dlg);
            if (this.TextFileName != "")
            {
                this.txtTextFile.Text = dlg.FileName;
                this.cmdNext.Enabled = true;
                this.BinFileName = Strings.Left(this.TextFileName, Strings.Len(this.TextFileName) - 4) + ".bin";
                this.DisplayTextFileContent();
            }
        }

        private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            this.Hide();
            this.BinFileName = "";
        }

        private void cmdNext_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void cmdPrevious_Click(object eventSender, EventArgs eventArgs)
        {
            switch (this.ThisFrame)
            {
                case 1:
                    this.PreviousFrame = 0;
                    break;

                case 2:
                {
                    int num3 = this.cmbVariable.Count() - 1;
                    int num = 0;
                    while (true)
                    {
                        int num4 = num3;
                        if (num > num4)
                        {
                            this.grdTextFile.Clear();
                            this.grdTextFile.Rows = 1;
                            this.grdTextFile.Cols = 1;
                            if (this.FileConversion)
                            {
                                this.cmdPrevious.Enabled = false;
                            }
                            this.PreviousFrame = 1;
                            this.cmdNext.Enabled = true;
                            break;
                        }
                        this.cmbVariable[(short) num].Items.Clear();
                        this.cmbVariable[(short) num].Visible = false;
                        num++;
                    }
                    break;
                }
                case 3:
                    this.PreviousFrame = !this.optAction[0].Checked ? 2 : 1;
                    break;

                default:
                    break;
            }
            this.ShowPrevious();
        }

        private void cmdSetVarDesc_Click(object eventSender, EventArgs eventArgs)
        {
            if (Strings.Len(this.txtVarDesc.Text) != 0)
            {
                int selectedIndex = this.cmbVarDescs.SelectedIndex;
                this.VarDesc[selectedIndex + 1] = this.txtVarDesc.Text;
                this.SetUpVarDescCombo();
                int count = this.cmbVarDescs.Items.Count;
                selectedIndex = 1;
                while (true)
                {
                    int num3 = count;
                    if (selectedIndex > num3)
                    {
                        break;
                    }
                    this.grdTextFile.set_TextMatrix(0, selectedIndex, this.VarDesc[selectedIndex]);
                    selectedIndex++;
                }
            }
        }

        private bool ConvertASCIIToBinFile()
        {
            this.Cursor = Cursors.WaitCursor;
            FixedLengthString str2 = new FixedLengthString(60);
            float[] numArray = new float[this.NoVar + 1];
            int num8 = (this.NoVar + 1) * 4;
            int num7 = 0;
            int fileNumber = FileSystem.FreeFile();
            FileSystem.FileOpen(fileNumber, this.BinFileName, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1);
            int num2 = FileSystem.FreeFile();
            this.SetUpFileStart(ref fileNumber, ref num8 + 1, ref num8);
            TextBox txtTextFile = this.txtTextFile;
            string text = txtTextFile.Text;
            txtTextFile.Text = text;
            this.VarsInASCII = this.FileLineCount(ref text);
            FileSystem.FileOpen(num2, this.TextFileName, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);
            int varsInASCII = this.VarsInASCII;
            int num3 = 1;
            while (true)
            {
                int num4;
                int num16;
                if (num3 <= varsInASCII)
                {
                    string expression = FileSystem.LineInput(num2);
                    if (Strings.Len(expression) != 0)
                    {
                        string[] array = Strings.Split(expression, "\t", -1, CompareMethod.Binary);
                        short index = 0;
                        while (true)
                        {
                            bool flag2 = Strings.Len(array[index]) == 0;
                            if (!flag2)
                            {
                                string dtm = array[index];
                                num4 = 1;
                                short num12 = (short) Information.UBound(array, 1);
                                short num6 = (short) (index + 1);
                                while (true)
                                {
                                    short num15 = num12;
                                    if (num6 > num15)
                                    {
                                        FileSystem.FilePut(fileNumber, (int) MiscFUncs.JulianDate(dtm), -1L);
                                        int noVar = this.NoVar;
                                        num4 = 1;
                                        while (true)
                                        {
                                            num16 = noVar;
                                            if (num4 > num16)
                                            {
                                                num7++;
                                                num3++;
                                                break;
                                            }
                                            FileSystem.FilePut(fileNumber, numArray[this.Order[num4]], -1L);
                                            num4++;
                                        }
                                        break;
                                    }
                                    flag2 = Strings.Len(array[num6]) > 0;
                                    if (flag2)
                                    {
                                        numArray[num4] = Conversions.ToSingle(array[num6]);
                                        num4++;
                                    }
                                    num6 = (short) (num6 + 1);
                                }
                                break;
                            }
                            index = (short) (index + 1);
                        }
                        continue;
                    }
                }
                string[] strArray2 = new string[] { "\0\0", Conversions.ToString(Strings.Chr(200)), "B\0\0", Conversions.ToString(Strings.Chr(0x80)), Conversions.ToString(Strings.Chr(0xbf)) };
                string sInsert = string.Concat(strArray2);
                int num14 = Information.UBound(this.VarDesc, 1);
                num4 = Information.LBound(this.VarDesc, 1) + 1;
                while (true)
                {
                    num16 = num14;
                    if (num4 > num16)
                    {
                        FileSystem.FilePut(fileNumber, num7, 1L);
                        FileSystem.FileClose(new int[] { fileNumber });
                        FileSystem.FileClose(new int[] { num2 });
                        return true;
                    }
                    str2.Value = this.VarDesc[num4];
                    FixedLengthString str6 = str2;
                    text = str6.Value;
                    StringType.MidStmtStr(ref text, 0x35, 8, sInsert);
                    str6.Value = text;
                    FileSystem.FilePut(fileNumber, str2.Value, -1L, false);
                    num4++;
                }
            }
        }

        private bool ConvertTextFile()
        {
            this.SetOrder();
            return this.ConvertASCIIToBinFile();
        }

        private void DisplayBinFileContent()
        {
            // Invalid method body.
        }

        private void DisplayTextFileContent()
        {
            // Invalid method body.
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

        public string FileEOLChars(ref string strFile)
        {
            // Invalid method body.
        }

        public int FileLineCount(ref string strFileName) => 
            Information.UBound(Strings.Split(MyProject.Computer.FileSystem.ReadAllText(strFileName), "\r\n", -1, CompareMethod.Binary), 1);

        private void HideAll()
        {
            int num2 = this.fraStep.Count() - 1;
            int num = 0;
            while (true)
            {
                int num3 = num2;
                if (num > num3)
                {
                    return;
                }
                this.fraStep[(short) num].Left = (int) Math.Round(Support.TwipsToPixelsX(-10000.0));
                num++;
            }
        }

        public void Init()
        {
            this.Icon = this.frmMain.Icon;
            this.cmdPrevious.Enabled = false;
            this.NextFrame = 0;
            this.PreviousFrame = -1;
            this.ThisFrame = -1;
            this.HideAll();
            this.cmdNext_Click(this.cmdNext, new EventArgs());
            this.SetUpGrid();
            if (this.FileConversion)
            {
                this.optAction[1].Checked = true;
                this.HideAll();
                this.ThisFrame = 0;
                this.cmdNext_Click(this.cmdNext, new EventArgs());
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmAddFile));
            this._fraStep_1 = new GroupBox();
            this.txtNoVars = new TextBox();
            this._optTypeOfFile_5 = new RadioButton();
            this._optTypeOfFile_4 = new RadioButton();
            this._optTypeOfFile_3 = new RadioButton();
            this._optTypeOfFile_2 = new RadioButton();
            this._optTypeOfFile_1 = new RadioButton();
            this._optTypeOfFile_0 = new RadioButton();
            this.lblVariables = new Label();
            this.lblContent = new Label();
            this._lblStep_3 = new Label();
            this.cmdCancel = new Button();
            this.cmdPrevious = new Button();
            this.cmdNext = new Button();
            this._fraStep_3 = new GroupBox();
            this.grdBinFile = new AxMSFlexGrid();
            this.cmdBrowseForBin = new Button();
            this.txtBinFile = new TextBox();
            this.Label5 = new Label();
            this._lblStep_2 = new Label();
            this._fraStep_2 = new GroupBox();
            this.fraVarDescs = new GroupBox();
            this.cmdSetVarDesc = new Button();
            this.txtVarDesc = new TextBox();
            this.cmbVarDescs = new ComboBox();
            this.Label7 = new Label();
            this._cmbVariable_5 = new ComboBox();
            this._cmbVariable_4 = new ComboBox();
            this._cmbVariable_3 = new ComboBox();
            this._cmbVariable_2 = new ComboBox();
            this._cmbVariable_1 = new ComboBox();
            this._cmbVariable_0 = new ComboBox();
            this.grdTextFile = new AxMSFlexGrid();
            this.cmdBrowseForText = new Button();
            this.txtTextFile = new TextBox();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this._lblStep_1 = new Label();
            this._fraStep_0 = new GroupBox();
            this._optAction_1 = new RadioButton();
            this._optAction_0 = new RadioButton();
            this.Label1 = new Label();
            this._lblStep_0 = new Label();
            this.cmbVariable = new ComboBoxArray(this.components);
            this.fraStep = new GroupBoxArray(this.components);
            this.lblStep = new LabelArray(this.components);
            this.optAction = new RadioButtonArray(this.components);
            this.optTypeOfFile = new RadioButtonArray(this.components);
            this._fraStep_1.SuspendLayout();
            this._fraStep_3.SuspendLayout();
            this.grdBinFile.BeginInit();
            this._fraStep_2.SuspendLayout();
            this.fraVarDescs.SuspendLayout();
            this.grdTextFile.BeginInit();
            this._fraStep_0.SuspendLayout();
            ((ISupportInitialize) this.cmbVariable).BeginInit();
            ((ISupportInitialize) this.fraStep).BeginInit();
            ((ISupportInitialize) this.lblStep).BeginInit();
            ((ISupportInitialize) this.optAction).BeginInit();
            ((ISupportInitialize) this.optTypeOfFile).BeginInit();
            this.SuspendLayout();
            this._fraStep_1.BackColor = SystemColors.Control;
            this._fraStep_1.Controls.Add(this.txtNoVars);
            this._fraStep_1.Controls.Add(this._optTypeOfFile_5);
            this._fraStep_1.Controls.Add(this._optTypeOfFile_4);
            this._fraStep_1.Controls.Add(this._optTypeOfFile_3);
            this._fraStep_1.Controls.Add(this._optTypeOfFile_2);
            this._fraStep_1.Controls.Add(this._optTypeOfFile_1);
            this._fraStep_1.Controls.Add(this._optTypeOfFile_0);
            this._fraStep_1.Controls.Add(this.lblVariables);
            this._fraStep_1.Controls.Add(this.lblContent);
            this._fraStep_1.Controls.Add(this._lblStep_3);
            this._fraStep_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_1.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_1, 1);
            Point point = new Point(-666, 0);
            this._fraStep_1.Location = point;
            this._fraStep_1.Name = "_fraStep_1";
            this._fraStep_1.RightToLeft = RightToLeft.No;
            Size size = new Size(0x233, 0x167);
            this._fraStep_1.Size = size;
            this._fraStep_1.TabIndex = 0x12;
            this._fraStep_1.TabStop = false;
            this._fraStep_1.Text = "Specify type of .bin-file";
            this.txtNoVars.AcceptsReturn = true;
            this.txtNoVars.BackColor = SystemColors.Window;
            this.txtNoVars.Cursor = Cursors.IBeam;
            this.txtNoVars.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNoVars.ForeColor = SystemColors.WindowText;
            point = new Point(0x68, 0xee);
            this.txtNoVars.Location = point;
            this.txtNoVars.MaxLength = 3;
            this.txtNoVars.Name = "txtNoVars";
            this.txtNoVars.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x13);
            this.txtNoVars.Size = size;
            this.txtNoVars.TabIndex = 0x25;
            this.txtNoVars.Text = "1";
            this.txtNoVars.Visible = false;
            this._optTypeOfFile_5.BackColor = SystemColors.Control;
            this._optTypeOfFile_5.Cursor = Cursors.Default;
            this._optTypeOfFile_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optTypeOfFile_5.ForeColor = SystemColors.ControlText;
            this.optTypeOfFile.SetIndex(this._optTypeOfFile_5, 5);
            point = new Point(0x20, 240);
            this._optTypeOfFile_5.Location = point;
            this._optTypeOfFile_5.Name = "_optTypeOfFile_5";
            this._optTypeOfFile_5.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this._optTypeOfFile_5.Size = size;
            this._optTypeOfFile_5.TabIndex = 0x24;
            this._optTypeOfFile_5.TabStop = true;
            this._optTypeOfFile_5.Text = "&other, with ";
            this._optTypeOfFile_5.UseVisualStyleBackColor = false;
            this._optTypeOfFile_5.Visible = false;
            this._optTypeOfFile_4.BackColor = SystemColors.Control;
            this._optTypeOfFile_4.Cursor = Cursors.Default;
            this._optTypeOfFile_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optTypeOfFile_4.ForeColor = SystemColors.ControlText;
            this.optTypeOfFile.SetIndex(this._optTypeOfFile_4, 4);
            point = new Point(0x20, 0xd8);
            this._optTypeOfFile_4.Location = point;
            this._optTypeOfFile_4.Name = "_optTypeOfFile_4";
            this._optTypeOfFile_4.RightToLeft = RightToLeft.No;
            size = new Size(0x141, 0x11);
            this._optTypeOfFile_4.Size = size;
            this._optTypeOfFile_4.TabIndex = 0x19;
            this._optTypeOfFile_4.TabStop = true;
            this._optTypeOfFile_4.Text = "&pesticide metabolite";
            this._optTypeOfFile_4.UseVisualStyleBackColor = false;
            this._optTypeOfFile_3.BackColor = SystemColors.Control;
            this._optTypeOfFile_3.Cursor = Cursors.Default;
            this._optTypeOfFile_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optTypeOfFile_3.ForeColor = SystemColors.ControlText;
            this.optTypeOfFile.SetIndex(this._optTypeOfFile_3, 3);
            point = new Point(0x20, 0xc0);
            this._optTypeOfFile_3.Location = point;
            this._optTypeOfFile_3.Name = "_optTypeOfFile_3";
            this._optTypeOfFile_3.RightToLeft = RightToLeft.No;
            size = new Size(0x149, 0x11);
            this._optTypeOfFile_3.Size = size;
            this._optTypeOfFile_3.TabIndex = 0x18;
            this._optTypeOfFile_3.TabStop = true;
            this._optTypeOfFile_3.Text = "&evapotranspiration and temperature";
            this._optTypeOfFile_3.UseVisualStyleBackColor = false;
            this._optTypeOfFile_2.BackColor = SystemColors.Control;
            this._optTypeOfFile_2.Cursor = Cursors.Default;
            this._optTypeOfFile_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optTypeOfFile_2.ForeColor = SystemColors.ControlText;
            this.optTypeOfFile.SetIndex(this._optTypeOfFile_2, 2);
            point = new Point(0x20, 0xa8);
            this._optTypeOfFile_2.Location = point;
            this._optTypeOfFile_2.Name = "_optTypeOfFile_2";
            this._optTypeOfFile_2.RightToLeft = RightToLeft.No;
            size = new Size(0x151, 0x11);
            this._optTypeOfFile_2.Size = size;
            this._optTypeOfFile_2.TabIndex = 0x17;
            this._optTypeOfFile_2.TabStop = true;
            this._optTypeOfFile_2.Text = "&meteorological data";
            this._optTypeOfFile_2.UseVisualStyleBackColor = false;
            this._optTypeOfFile_1.BackColor = SystemColors.Control;
            this._optTypeOfFile_1.Cursor = Cursors.Default;
            this._optTypeOfFile_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optTypeOfFile_1.ForeColor = SystemColors.ControlText;
            this.optTypeOfFile.SetIndex(this._optTypeOfFile_1, 1);
            point = new Point(0x20, 0x90);
            this._optTypeOfFile_1.Location = point;
            this._optTypeOfFile_1.Name = "_optTypeOfFile_1";
            this._optTypeOfFile_1.RightToLeft = RightToLeft.No;
            size = new Size(0x141, 0x11);
            this._optTypeOfFile_1.Size = size;
            this._optTypeOfFile_1.TabIndex = 0x16;
            this._optTypeOfFile_1.TabStop = true;
            this._optTypeOfFile_1.Text = "&hourly rainfall data";
            this._optTypeOfFile_1.UseVisualStyleBackColor = false;
            this._optTypeOfFile_0.BackColor = SystemColors.Control;
            this._optTypeOfFile_0.Checked = true;
            this._optTypeOfFile_0.Cursor = Cursors.Default;
            this._optTypeOfFile_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optTypeOfFile_0.ForeColor = SystemColors.ControlText;
            this.optTypeOfFile.SetIndex(this._optTypeOfFile_0, 0);
            point = new Point(0x20, 120);
            this._optTypeOfFile_0.Location = point;
            this._optTypeOfFile_0.Name = "_optTypeOfFile_0";
            this._optTypeOfFile_0.RightToLeft = RightToLeft.No;
            size = new Size(0x109, 0x11);
            this._optTypeOfFile_0.Size = size;
            this._optTypeOfFile_0.TabIndex = 0x15;
            this._optTypeOfFile_0.TabStop = true;
            this._optTypeOfFile_0.Text = "&daily rainfall data";
            this._optTypeOfFile_0.UseVisualStyleBackColor = false;
            this.lblVariables.BackColor = SystemColors.Control;
            this.lblVariables.Cursor = Cursors.Default;
            this.lblVariables.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblVariables.ForeColor = SystemColors.ControlText;
            point = new Point(0x90, 240);
            this.lblVariables.Location = point;
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.RightToLeft = RightToLeft.No;
            size = new Size(0x39, 0x11);
            this.lblVariables.Size = size;
            this.lblVariables.TabIndex = 0x26;
            this.lblVariables.Text = "variables";
            this.lblVariables.Visible = false;
            this.lblContent.BackColor = SystemColors.Control;
            this.lblContent.Cursor = Cursors.Default;
            this.lblContent.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblContent.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 0x60);
            this.lblContent.Location = point;
            this.lblContent.Name = "lblContent";
            this.lblContent.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x11);
            this.lblContent.Size = size;
            this.lblContent.TabIndex = 20;
            this.lblContent.Text = "The file to add contains:";
            this._lblStep_3.BackColor = SystemColors.Control;
            this._lblStep_3.Cursor = Cursors.Default;
            this._lblStep_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_3.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_3, 3);
            point = new Point(0x18, 0x18);
            this._lblStep_3.Location = point;
            this._lblStep_3.Name = "_lblStep_3";
            this._lblStep_3.RightToLeft = RightToLeft.No;
            size = new Size(400, 0x21);
            this._lblStep_3.Size = size;
            this._lblStep_3.TabIndex = 0x13;
            this._lblStep_3.Text = "A certain number of different .bin-files can be used in a simulation. Indicate below which type of .bin-file you would like to add to the simulation.";
            this.cmdCancel.BackColor = SystemColors.Control;
            this.cmdCancel.Cursor = Cursors.Default;
            this.cmdCancel.DialogResult = DialogResult.Cancel;
            this.cmdCancel.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdCancel.ForeColor = SystemColors.ControlText;
            point = new Point(0x148, 0x170);
            this.cmdCancel.Location = point;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x19);
            this.cmdCancel.Size = size;
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdPrevious.BackColor = SystemColors.Control;
            this.cmdPrevious.Cursor = Cursors.Default;
            this.cmdPrevious.Enabled = false;
            this.cmdPrevious.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdPrevious.ForeColor = SystemColors.ControlText;
            point = new Point(0x1a0, 0x170);
            this.cmdPrevious.Location = point;
            this.cmdPrevious.Name = "cmdPrevious";
            this.cmdPrevious.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdPrevious.Size = size;
            this.cmdPrevious.TabIndex = 7;
            this.cmdPrevious.Text = "&Previous";
            this.cmdPrevious.UseVisualStyleBackColor = false;
            this.cmdNext.BackColor = SystemColors.Control;
            this.cmdNext.Cursor = Cursors.Default;
            this.cmdNext.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdNext.ForeColor = SystemColors.ControlText;
            point = new Point(0x1e8, 0x170);
            this.cmdNext.Location = point;
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdNext.Size = size;
            this.cmdNext.TabIndex = 6;
            this.cmdNext.Text = "&Next";
            this.cmdNext.UseVisualStyleBackColor = false;
            this._fraStep_3.BackColor = SystemColors.Control;
            this._fraStep_3.Controls.Add(this.grdBinFile);
            this._fraStep_3.Controls.Add(this.cmdBrowseForBin);
            this._fraStep_3.Controls.Add(this.txtBinFile);
            this._fraStep_3.Controls.Add(this.Label5);
            this._fraStep_3.Controls.Add(this._lblStep_2);
            this._fraStep_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_3.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_3, 3);
            point = new Point(0, 0);
            this._fraStep_3.Location = point;
            this._fraStep_3.Name = "_fraStep_3";
            this._fraStep_3.RightToLeft = RightToLeft.No;
            size = new Size(0x233, 0x167);
            this._fraStep_3.Size = size;
            this._fraStep_3.TabIndex = 4;
            this._fraStep_3.TabStop = false;
            this._fraStep_3.Text = "Select bin-file";
            point = new Point(0x18, 0x90);
            this.grdBinFile.Location = point;
            this.grdBinFile.Name = "grdBinFile";
            this.grdBinFile.OcxState = (AxHost.State) manager.GetObject("grdBinFile.OcxState");
            size = new Size(0x1e1, 0xc9);
            this.grdBinFile.Size = size;
            this.grdBinFile.TabIndex = 0x1d;
            this.cmdBrowseForBin.BackColor = SystemColors.Control;
            this.cmdBrowseForBin.Cursor = Cursors.Default;
            this.cmdBrowseForBin.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseForBin.ForeColor = SystemColors.ControlText;
            point = new Point(440, 0x68);
            this.cmdBrowseForBin.Location = point;
            this.cmdBrowseForBin.Name = "cmdBrowseForBin";
            this.cmdBrowseForBin.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 0x13);
            this.cmdBrowseForBin.Size = size;
            this.cmdBrowseForBin.TabIndex = 0x1c;
            this.cmdBrowseForBin.Text = "...";
            this.cmdBrowseForBin.UseVisualStyleBackColor = false;
            this.txtBinFile.AcceptsReturn = true;
            this.txtBinFile.BackColor = SystemColors.Window;
            this.txtBinFile.Cursor = Cursors.IBeam;
            this.txtBinFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBinFile.ForeColor = SystemColors.WindowText;
            point = new Point(0x68, 0x68);
            this.txtBinFile.Location = point;
            this.txtBinFile.MaxLength = 0;
            this.txtBinFile.Name = "txtBinFile";
            this.txtBinFile.RightToLeft = RightToLeft.No;
            size = new Size(0x151, 0x13);
            this.txtBinFile.Size = size;
            this.txtBinFile.TabIndex = 0x1b;
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(0x18, 0x68);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 0x1a;
            this.Label5.Text = ".bin-file to add:";
            this._lblStep_2.BackColor = SystemColors.Control;
            this._lblStep_2.Cursor = Cursors.Default;
            this._lblStep_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_2.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_2, 2);
            point = new Point(0x18, 0x18);
            this._lblStep_2.Location = point;
            this._lblStep_2.Name = "_lblStep_2";
            this._lblStep_2.RightToLeft = RightToLeft.No;
            size = new Size(0x1b0, 0x29);
            this._lblStep_2.Size = size;
            this._lblStep_2.TabIndex = 5;
            this._lblStep_2.Text = "Select the .bin-file to add to the simulation. Make sure that the file actually contain the data that was indicated in the previous step.";
            this._fraStep_2.BackColor = SystemColors.Control;
            this._fraStep_2.Controls.Add(this.fraVarDescs);
            this._fraStep_2.Controls.Add(this._cmbVariable_5);
            this._fraStep_2.Controls.Add(this._cmbVariable_4);
            this._fraStep_2.Controls.Add(this._cmbVariable_3);
            this._fraStep_2.Controls.Add(this._cmbVariable_2);
            this._fraStep_2.Controls.Add(this._cmbVariable_1);
            this._fraStep_2.Controls.Add(this._cmbVariable_0);
            this._fraStep_2.Controls.Add(this.grdTextFile);
            this._fraStep_2.Controls.Add(this.cmdBrowseForText);
            this._fraStep_2.Controls.Add(this.txtTextFile);
            this._fraStep_2.Controls.Add(this.Label4);
            this._fraStep_2.Controls.Add(this.Label3);
            this._fraStep_2.Controls.Add(this.Label2);
            this._fraStep_2.Controls.Add(this._lblStep_1);
            this._fraStep_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_2.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_2, 2);
            point = new Point(-666, 0);
            this._fraStep_2.Location = point;
            this._fraStep_2.Name = "_fraStep_2";
            this._fraStep_2.RightToLeft = RightToLeft.No;
            size = new Size(0x233, 0x167);
            this._fraStep_2.Size = size;
            this._fraStep_2.TabIndex = 2;
            this._fraStep_2.TabStop = false;
            this._fraStep_2.Text = "Select text-file";
            this.fraVarDescs.BackColor = SystemColors.Control;
            this.fraVarDescs.Controls.Add(this.cmdSetVarDesc);
            this.fraVarDescs.Controls.Add(this.txtVarDesc);
            this.fraVarDescs.Controls.Add(this.cmbVarDescs);
            this.fraVarDescs.Controls.Add(this.Label7);
            this.fraVarDescs.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraVarDescs.ForeColor = SystemColors.ControlText;
            point = new Point(8, 240);
            this.fraVarDescs.Location = point;
            this.fraVarDescs.Name = "fraVarDescs";
            this.fraVarDescs.RightToLeft = RightToLeft.No;
            size = new Size(0x1f1, 0x59);
            this.fraVarDescs.Size = size;
            this.fraVarDescs.TabIndex = 0x27;
            this.fraVarDescs.TabStop = false;
            this.fraVarDescs.Text = "Variable descriptions";
            this.fraVarDescs.Visible = false;
            this.cmdSetVarDesc.BackColor = SystemColors.Control;
            this.cmdSetVarDesc.Cursor = Cursors.Default;
            this.cmdSetVarDesc.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdSetVarDesc.ForeColor = SystemColors.ControlText;
            point = new Point(360, 0x38);
            this.cmdSetVarDesc.Location = point;
            this.cmdSetVarDesc.Name = "cmdSetVarDesc";
            this.cmdSetVarDesc.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.cmdSetVarDesc.Size = size;
            this.cmdSetVarDesc.TabIndex = 0x2b;
            this.cmdSetVarDesc.Text = "&Set";
            this.cmdSetVarDesc.UseVisualStyleBackColor = false;
            this.txtVarDesc.AcceptsReturn = true;
            this.txtVarDesc.BackColor = SystemColors.Window;
            this.txtVarDesc.Cursor = Cursors.IBeam;
            this.txtVarDesc.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtVarDesc.ForeColor = SystemColors.WindowText;
            point = new Point(0x40, 0x38);
            this.txtVarDesc.Location = point;
            this.txtVarDesc.MaxLength = 0x34;
            this.txtVarDesc.Name = "txtVarDesc";
            this.txtVarDesc.RightToLeft = RightToLeft.No;
            size = new Size(0x121, 0x13);
            this.txtVarDesc.Size = size;
            this.txtVarDesc.TabIndex = 0x2a;
            this.cmbVarDescs.BackColor = SystemColors.Window;
            this.cmbVarDescs.Cursor = Cursors.Default;
            this.cmbVarDescs.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbVarDescs.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbVarDescs.ForeColor = SystemColors.WindowText;
            point = new Point(8, 20);
            this.cmbVarDescs.Location = point;
            this.cmbVarDescs.Name = "cmbVarDescs";
            this.cmbVarDescs.RightToLeft = RightToLeft.No;
            size = new Size(0x159, 0x16);
            this.cmbVarDescs.Size = size;
            this.cmbVarDescs.TabIndex = 40;
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x38);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 0x29;
            this.Label7.Text = "Enter new:";
            this._cmbVariable_5.BackColor = SystemColors.Window;
            this._cmbVariable_5.Cursor = Cursors.Default;
            this._cmbVariable_5.DropDownStyle = ComboBoxStyle.DropDownList;
            this._cmbVariable_5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmbVariable_5.ForeColor = SystemColors.WindowText;
            this.cmbVariable.SetIndex(this._cmbVariable_5, 5);
            point = new Point(0x178, 160);
            this._cmbVariable_5.Location = point;
            this._cmbVariable_5.Name = "_cmbVariable_5";
            this._cmbVariable_5.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x16);
            this._cmbVariable_5.Size = size;
            this._cmbVariable_5.TabIndex = 0x23;
            this._cmbVariable_4.BackColor = SystemColors.Window;
            this._cmbVariable_4.Cursor = Cursors.Default;
            this._cmbVariable_4.DropDownStyle = ComboBoxStyle.DropDownList;
            this._cmbVariable_4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmbVariable_4.ForeColor = SystemColors.WindowText;
            this.cmbVariable.SetIndex(this._cmbVariable_4, 4);
            point = new Point(0x128, 160);
            this._cmbVariable_4.Location = point;
            this._cmbVariable_4.Name = "_cmbVariable_4";
            this._cmbVariable_4.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x16);
            this._cmbVariable_4.Size = size;
            this._cmbVariable_4.TabIndex = 0x22;
            this._cmbVariable_3.BackColor = SystemColors.Window;
            this._cmbVariable_3.Cursor = Cursors.Default;
            this._cmbVariable_3.DropDownStyle = ComboBoxStyle.DropDownList;
            this._cmbVariable_3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmbVariable_3.ForeColor = SystemColors.WindowText;
            this.cmbVariable.SetIndex(this._cmbVariable_3, 3);
            point = new Point(0xe0, 160);
            this._cmbVariable_3.Location = point;
            this._cmbVariable_3.Name = "_cmbVariable_3";
            this._cmbVariable_3.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x16);
            this._cmbVariable_3.Size = size;
            this._cmbVariable_3.TabIndex = 0x21;
            this._cmbVariable_2.BackColor = SystemColors.Window;
            this._cmbVariable_2.Cursor = Cursors.Default;
            this._cmbVariable_2.DropDownStyle = ComboBoxStyle.DropDownList;
            this._cmbVariable_2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmbVariable_2.ForeColor = SystemColors.WindowText;
            this.cmbVariable.SetIndex(this._cmbVariable_2, 2);
            point = new Point(0x98, 160);
            this._cmbVariable_2.Location = point;
            this._cmbVariable_2.Name = "_cmbVariable_2";
            this._cmbVariable_2.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x16);
            this._cmbVariable_2.Size = size;
            this._cmbVariable_2.TabIndex = 0x20;
            this._cmbVariable_1.BackColor = SystemColors.Window;
            this._cmbVariable_1.Cursor = Cursors.Default;
            this._cmbVariable_1.DropDownStyle = ComboBoxStyle.DropDownList;
            this._cmbVariable_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmbVariable_1.ForeColor = SystemColors.WindowText;
            this.cmbVariable.SetIndex(this._cmbVariable_1, 1);
            point = new Point(80, 160);
            this._cmbVariable_1.Location = point;
            this._cmbVariable_1.Name = "_cmbVariable_1";
            this._cmbVariable_1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x16);
            this._cmbVariable_1.Size = size;
            this._cmbVariable_1.TabIndex = 0x1f;
            this._cmbVariable_0.BackColor = SystemColors.Window;
            this._cmbVariable_0.Cursor = Cursors.Default;
            this._cmbVariable_0.DropDownStyle = ComboBoxStyle.DropDownList;
            this._cmbVariable_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._cmbVariable_0.ForeColor = SystemColors.WindowText;
            this.cmbVariable.SetIndex(this._cmbVariable_0, 0);
            point = new Point(8, 160);
            this._cmbVariable_0.Location = point;
            this._cmbVariable_0.Name = "_cmbVariable_0";
            this._cmbVariable_0.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x16);
            this._cmbVariable_0.Size = size;
            this._cmbVariable_0.TabIndex = 30;
            point = new Point(8, 160);
            this.grdTextFile.Location = point;
            this.grdTextFile.Name = "grdTextFile";
            this.grdTextFile.OcxState = (AxHost.State) manager.GetObject("grdTextFile.OcxState");
            size = new Size(0x221, 0x51);
            this.grdTextFile.Size = size;
            this.grdTextFile.TabIndex = 0x11;
            this.cmdBrowseForText.BackColor = SystemColors.Control;
            this.cmdBrowseForText.Cursor = Cursors.Default;
            this.cmdBrowseForText.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseForText.ForeColor = SystemColors.ControlText;
            point = new Point(0x1c0, 0x80);
            this.cmdBrowseForText.Location = point;
            this.cmdBrowseForText.Name = "cmdBrowseForText";
            this.cmdBrowseForText.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 0x13);
            this.cmdBrowseForText.Size = size;
            this.cmdBrowseForText.TabIndex = 15;
            this.cmdBrowseForText.Text = "...";
            this.cmdBrowseForText.UseVisualStyleBackColor = false;
            this.txtTextFile.AcceptsReturn = true;
            this.txtTextFile.BackColor = SystemColors.Window;
            this.txtTextFile.Cursor = Cursors.IBeam;
            this.txtTextFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTextFile.ForeColor = SystemColors.WindowText;
            point = new Point(0x48, 0x7e);
            this.txtTextFile.Location = point;
            this.txtTextFile.MaxLength = 0;
            this.txtTextFile.Name = "txtTextFile";
            this.txtTextFile.RightToLeft = RightToLeft.No;
            size = new Size(0x179, 0x13);
            this.txtTextFile.Size = size;
            this.txtTextFile.TabIndex = 14;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x58);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x1c9, 0x29);
            this.Label4.Size = size;
            this.Label4.TabIndex = 0x10;
            this.Label4.Text = "The selected text-file will be converted when clicking the 'Next'-button. The name of the created bin-file will be the same as for the text file, but with the extension .bin.";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x80);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Text-file:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x30);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x1f1, 0x21);
            this.Label2.Size = size;
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Select a text-file and select the correct variable heading in the table below. The different possible variables depend on the type of bin-file as specified in the previous step.";
            this._lblStep_1.BackColor = SystemColors.Control;
            this._lblStep_1.Cursor = Cursors.Default;
            this._lblStep_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_1.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_1, 1);
            point = new Point(8, 0x18);
            this._lblStep_1.Location = point;
            this._lblStep_1.Name = "_lblStep_1";
            this._lblStep_1.RightToLeft = RightToLeft.No;
            size = new Size(0x160, 0x21);
            this._lblStep_1.Size = size;
            this._lblStep_1.TabIndex = 3;
            this._lblStep_1.Text = "Text-files can be converted to a certain number of typical .bin-files.";
            this._fraStep_0.BackColor = SystemColors.Control;
            this._fraStep_0.Controls.Add(this._optAction_1);
            this._fraStep_0.Controls.Add(this._optAction_0);
            this._fraStep_0.Controls.Add(this.Label1);
            this._fraStep_0.Controls.Add(this._lblStep_0);
            this._fraStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._fraStep_0.ForeColor = SystemColors.ControlText;
            this.fraStep.SetIndex(this._fraStep_0, 0);
            point = new Point(-666, 0);
            this._fraStep_0.Location = point;
            this._fraStep_0.Name = "_fraStep_0";
            this._fraStep_0.RightToLeft = RightToLeft.No;
            size = new Size(0x233, 0x167);
            this._fraStep_0.Size = size;
            this._fraStep_0.TabIndex = 0;
            this._fraStep_0.TabStop = false;
            this._fraStep_0.Text = "What would you like to do?";
            this._optAction_1.BackColor = SystemColors.Control;
            this._optAction_1.Cursor = Cursors.Default;
            this._optAction_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optAction_1.ForeColor = SystemColors.ControlText;
            this.optAction.SetIndex(this._optAction_1, 1);
            point = new Point(0x20, 0x80);
            this._optAction_1.Location = point;
            this._optAction_1.Name = "_optAction_1";
            this._optAction_1.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0x11);
            this._optAction_1.Size = size;
            this._optAction_1.TabIndex = 11;
            this._optAction_1.TabStop = true;
            this._optAction_1.Text = "&Convert a text-file to bin-format and add it to the simulation";
            this._optAction_1.UseVisualStyleBackColor = false;
            this._optAction_0.BackColor = SystemColors.Control;
            this._optAction_0.Checked = true;
            this._optAction_0.Cursor = Cursors.Default;
            this._optAction_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optAction_0.ForeColor = SystemColors.ControlText;
            this.optAction.SetIndex(this._optAction_0, 0);
            point = new Point(0x20, 0x68);
            this._optAction_0.Location = point;
            this._optAction_0.Name = "_optAction_0";
            this._optAction_0.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0x11);
            this._optAction_0.Size = size;
            this._optAction_0.TabIndex = 10;
            this._optAction_0.TabStop = true;
            this._optAction_0.Text = "&Add an existing .bin-file to the simulation";
            this._optAction_0.UseVisualStyleBackColor = false;
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x48);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x89, 0x19);
            this.Label1.Size = size;
            this.Label1.TabIndex = 9;
            this.Label1.Text = "What would you like to do?";
            this._lblStep_0.BackColor = SystemColors.Control;
            this._lblStep_0.Cursor = Cursors.Default;
            this._lblStep_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._lblStep_0.ForeColor = SystemColors.ControlText;
            this.lblStep.SetIndex(this._lblStep_0, 0);
            point = new Point(0x10, 0x18);
            this._lblStep_0.Location = point;
            this._lblStep_0.Name = "_lblStep_0";
            this._lblStep_0.RightToLeft = RightToLeft.No;
            size = new Size(0x1a8, 0x21);
            this._lblStep_0.Size = size;
            this._lblStep_0.TabIndex = 1;
            this._lblStep_0.Text = "This wizard will guide you through the process of adding a .bin-file or text-file to your simulation.";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            size = new Size(0x237, 400);
            this.ClientSize = size;
            this.Controls.Add(this._fraStep_1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdPrevious);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this._fraStep_3);
            this.Controls.Add(this._fraStep_2);
            this.Controls.Add(this._fraStep_0);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmAddFile";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Add .bin-file";
            this._fraStep_1.ResumeLayout(false);
            this._fraStep_3.ResumeLayout(false);
            this.grdBinFile.EndInit();
            this._fraStep_2.ResumeLayout(false);
            this.fraVarDescs.ResumeLayout(false);
            this.grdTextFile.EndInit();
            this._fraStep_0.ResumeLayout(false);
            ((ISupportInitialize) this.cmbVariable).EndInit();
            ((ISupportInitialize) this.fraStep).EndInit();
            ((ISupportInitialize) this.lblStep).EndInit();
            ((ISupportInitialize) this.optAction).EndInit();
            ((ISupportInitialize) this.optTypeOfFile).EndInit();
            this.ResumeLayout(false);
        }

        private bool SetNoVar()
        {
            if (this.optTypeOfFile[0].Checked | this.optTypeOfFile[1].Checked)
            {
                this.NoVar = 1;
            }
            else if (this.optTypeOfFile[2].Checked)
            {
                this.NoVar = 5;
            }
            else if (this.optTypeOfFile[3].Checked)
            {
                this.NoVar = 3;
            }
            else if (this.optTypeOfFile[4].Checked)
            {
                this.NoVar = GlobalVariables.Nlayer * 2;
            }
            else if (this.optTypeOfFile[5].Checked)
            {
                if (!Versioned.IsNumeric(this.txtNoVars.Text))
                {
                    MiscFUncs.MsgBox_Renamed("Enter a numeric value", 0x30, "Error");
                }
                else
                {
                    this.NoVar = Conversions.ToInteger(this.txtNoVars.Text);
                }
            }
            return true;
        }

        private void SetOrder()
        {
            int num;
            int num4;
            this.Order = new int[this.NoVar + 1];
            if (!this.optTypeOfFile[5].Checked)
            {
                int noVar = this.NoVar;
                num = 1;
                while (true)
                {
                    num4 = noVar;
                    if (num > num4)
                    {
                        break;
                    }
                    this.Order[this.cmbVariable[(short) num].SelectedIndex + 1] = num;
                    num++;
                }
            }
            else
            {
                int noVar = this.NoVar;
                num = 1;
                while (true)
                {
                    num4 = noVar;
                    if (num > num4)
                    {
                        break;
                    }
                    this.Order[num] = num;
                    num++;
                }
            }
        }

        private void SetUpBinGrid()
        {
            AxMSFlexGrid grdBinFile = this.grdBinFile;
            grdBinFile.Cols = 6;
            int num2 = grdBinFile.Cols - 1;
            int col = 0;
            while (true)
            {
                int num4 = num2;
                if (col > num4)
                {
                    grdBinFile.FixedRows = 1;
                    grdBinFile.set_TextMatrix(0, 0, "Date");
                    if (this.optTypeOfFile[0].Checked)
                    {
                        grdBinFile.set_TextMatrix(0, 1, "Rainfall (daily)");
                    }
                    else if (this.optTypeOfFile[1].Checked)
                    {
                        grdBinFile.set_TextMatrix(0, 1, "Rainfall (hourly)");
                        grdBinFile.Cols = 2;
                    }
                    else if (this.optTypeOfFile[2].Checked)
                    {
                        grdBinFile.set_TextMatrix(0, 1, "Max temp");
                        grdBinFile.set_TextMatrix(0, 2, "Min temp");
                        grdBinFile.set_TextMatrix(0, 3, "Solar radiation");
                        grdBinFile.set_TextMatrix(0, 4, "Vapor pressure");
                        grdBinFile.set_TextMatrix(0, 5, "Wind speed");
                        grdBinFile.Cols = 6;
                    }
                    else if (this.optTypeOfFile[3].Checked)
                    {
                        grdBinFile.set_TextMatrix(0, 1, "Pot. evap");
                        grdBinFile.set_TextMatrix(0, 2, "Max temp");
                        grdBinFile.set_TextMatrix(0, 3, "Min temp");
                        grdBinFile.Cols = 4;
                    }
                    else if (this.optTypeOfFile[4].Checked)
                    {
                        grdBinFile.Cols = this.NoVar + 1;
                        int noVar = this.NoVar;
                        col = 1;
                        while (true)
                        {
                            num4 = noVar;
                            if (col > num4)
                            {
                                break;
                            }
                            grdBinFile.set_TextMatrix(0, col, "DEGRATE");
                            col++;
                        }
                    }
                    grdBinFile = null;
                    return;
                }
                grdBinFile.set_ColWidth(col, (int) Math.Round((double) ((Support.PixelsToTwipsX((double) grdBinFile.Width) / ((double) grdBinFile.Cols)) - 100.0)));
                col++;
            }
        }

        private void SetUpFileStart(ref int fp, ref int start, ref int rec_l)
        {
            FileSystem.FilePut((int) fp, (int) rec_l, -1L);
            FileSystem.FilePut((int) fp, (int) rec_l, -1L);
            FileSystem.Seek(fp, (long) start);
        }

        private void SetUpGrid()
        {
            AxMSFlexGrid grdTextFile = this.grdTextFile;
            grdTextFile.Cols = 6;
            int num2 = grdTextFile.Cols - 1;
            int col = 0;
            while (true)
            {
                int num4 = num2;
                if (col > num4)
                {
                    if (this.optTypeOfFile[5].Checked)
                    {
                        grdTextFile.Cols = this.NoVar + 1;
                        grdTextFile.set_TextMatrix(0, 0, "Date:");
                        int noVar = this.NoVar;
                        col = 1;
                        while (true)
                        {
                            num4 = noVar;
                            if (col > num4)
                            {
                                break;
                            }
                            grdTextFile.set_TextMatrix(0, col, this.VarDesc[col]);
                            col++;
                        }
                    }
                    else if (this.optTypeOfFile[0].Checked)
                    {
                        ComboBox box = this.cmbVariable[0];
                        box.Items.Add("Date");
                        box.SelectedIndex = 0;
                        box.Visible = true;
                        box = null;
                        ComboBox box2 = this.cmbVariable[1];
                        box2.Items.Add("Rainfall");
                        box2.SelectedIndex = 0;
                        box2.Visible = true;
                        box2 = null;
                    }
                    else if (this.optTypeOfFile[1].Checked)
                    {
                        ComboBox box3 = this.cmbVariable[0];
                        box3.Items.Add("Date");
                        box3.SelectedIndex = 0;
                        box3.Visible = true;
                        box3 = null;
                        ComboBox box4 = this.cmbVariable[1];
                        box4.Items.Add("Rainfall");
                        box4.SelectedIndex = 0;
                        box4.Visible = true;
                        box4 = null;
                    }
                    else if (!this.optTypeOfFile[2].Checked)
                    {
                        if (!this.optTypeOfFile[3].Checked)
                        {
                            if (this.optTypeOfFile[4].Checked)
                            {
                                ComboBox box15 = this.cmbVariable[0];
                                box15.Items.Add("Date");
                                box15.SelectedIndex = 0;
                                box15.Visible = true;
                                box15 = null;
                                ComboBox box16 = this.cmbVariable[1];
                                box16.Items.Add("Conc.");
                                box16.SelectedIndex = 0;
                                box16.Visible = true;
                                box16 = null;
                            }
                        }
                        else
                        {
                            ComboBox box11 = this.cmbVariable[0];
                            box11.Items.Add("Date");
                            box11.SelectedIndex = 0;
                            box11.Visible = true;
                            box11 = null;
                            ComboBox box12 = this.cmbVariable[1];
                            box12.Items.Add("Pot. evap");
                            box12.Items.Add("Max temp");
                            box12.Items.Add("Min temp");
                            box12.SelectedIndex = 0;
                            box12.Visible = true;
                            box12 = null;
                            ComboBox box13 = this.cmbVariable[2];
                            box13.Items.Add("Pot. evap");
                            box13.Items.Add("Max temp");
                            box13.Items.Add("Min temp");
                            box13.SelectedIndex = 1;
                            box13.Visible = true;
                            box13 = null;
                            ComboBox box14 = this.cmbVariable[3];
                            box14.Items.Add("Pot. evap");
                            box14.Items.Add("Max temp");
                            box14.Items.Add("Min temp");
                            box14.SelectedIndex = 2;
                            box14.Visible = true;
                            box14 = null;
                        }
                    }
                    else
                    {
                        ComboBox box5 = this.cmbVariable[0];
                        box5.Items.Add("Date");
                        box5.SelectedIndex = 0;
                        box5.Visible = true;
                        box5 = null;
                        ComboBox box6 = this.cmbVariable[1];
                        box6.Items.Add("Max temp");
                        box6.Items.Add("Min temp");
                        box6.Items.Add("Solar radiation");
                        box6.Items.Add("Vapor pressure");
                        box6.Items.Add("Wind speed");
                        box6.SelectedIndex = 0;
                        box6.Visible = true;
                        box6 = null;
                        ComboBox box7 = this.cmbVariable[2];
                        box7.Items.Add("Max temp");
                        box7.Items.Add("Min temp");
                        box7.Items.Add("Solar radiation");
                        box7.Items.Add("Vapor pressure");
                        box7.Items.Add("Wind speed");
                        box7.SelectedIndex = 1;
                        box7.Visible = true;
                        box7 = null;
                        ComboBox box8 = this.cmbVariable[3];
                        box8.Items.Add("Max temp");
                        box8.Items.Add("Min temp");
                        box8.Items.Add("Solar radiation");
                        box8.Items.Add("Vapor pressure");
                        box8.Items.Add("Wind speed");
                        box8.SelectedIndex = 2;
                        box8.Visible = true;
                        box8 = null;
                        ComboBox box9 = this.cmbVariable[4];
                        box9.Items.Add("Max temp");
                        box9.Items.Add("Min temp");
                        box9.Items.Add("Solar radiation");
                        box9.Items.Add("Vapor pressure");
                        box9.Items.Add("Wind speed");
                        box9.SelectedIndex = 3;
                        box9.Visible = true;
                        box9 = null;
                        ComboBox box10 = this.cmbVariable[5];
                        box10.Items.Add("Max temp");
                        box10.Items.Add("Min temp");
                        box10.Items.Add("Solar radiation");
                        box10.Items.Add("Vapor pressure");
                        box10.Items.Add("Wind speed");
                        box10.SelectedIndex = 4;
                        box10.Visible = true;
                        box10 = null;
                    }
                    grdTextFile = null;
                    return;
                }
                grdTextFile.set_ColWidth(col, (int) Math.Round((double) ((Support.PixelsToTwipsX((double) grdTextFile.Width) / ((double) grdTextFile.Cols)) - 100.0)));
                this.cmbVariable[(short) col].Visible = false;
                this.cmbVariable[(short) col].Items.Clear();
                this.cmbVariable[(short) col].Width = (int) Math.Round(Support.TwipsToPixelsX((double) grdTextFile.get_ColWidth(col)));
                this.cmbVariable[(short) col].Left = (int) Math.Round(Support.TwipsToPixelsX(Support.PixelsToTwipsX((double) grdTextFile.Left) + (grdTextFile.get_ColWidth(col) * col)));
                col++;
            }
        }

        private void SetUpVarDescCombo()
        {
            ComboBox cmbVarDescs = this.cmbVarDescs;
            cmbVarDescs.Items.Clear();
            int num2 = Information.UBound(this.VarDesc, 1) - 1;
            int index = 1;
            while (true)
            {
                int num3 = num2;
                if (index > num3)
                {
                    cmbVarDescs.SelectedIndex = 0;
                    cmbVarDescs = null;
                    return;
                }
                cmbVarDescs.Items.Add(this.VarDesc[index]);
                index++;
            }
        }

        private void SetVarDesc()
        {
            this.VarDesc = new string[(this.NoVar + 1) + 1];
            if (this.optTypeOfFile[0].Checked | this.optTypeOfFile[1].Checked)
            {
                this.VarDesc[1] = "Rainfall";
            }
            else if (this.optTypeOfFile[2].Checked)
            {
                this.VarDesc[1] = "Max temp";
                this.VarDesc[2] = "Min temp";
                this.VarDesc[3] = "Solar radiation";
                this.VarDesc[4] = "Vapor pressure";
                this.VarDesc[5] = "Wind speed";
            }
            else if (this.optTypeOfFile[3].Checked)
            {
                this.VarDesc[1] = "Pot. evap";
                this.VarDesc[2] = "Max temp";
                this.VarDesc[3] = "Min temp";
            }
            else if (this.optTypeOfFile[4].Checked)
            {
                this.VarDesc[1] = "Date";
                this.VarDesc[2] = "Conc.";
            }
            else
            {
                int noVar = this.NoVar;
                int index = 1;
                while (true)
                {
                    int num3 = noVar;
                    if (index > num3)
                    {
                        break;
                    }
                    this.VarDesc[index] = "Var." + Conversions.ToString(index);
                    index++;
                }
            }
        }

        private void ShowNext()
        {
            this.HideAll();
            this.ThisFrame = this.NextFrame;
            this.fraStep[(short) this.NextFrame].Left = 0;
            this.PreviousFrame = this.ThisFrame - 1;
            this.cmdPrevious.Enabled = true;
            if (this.ThisFrame == 0)
            {
                this.cmdPrevious.Enabled = false;
            }
            if (this.FileConversion & (this.NextFrame == 1))
            {
                this.cmdPrevious.Enabled = false;
            }
            if (this.NextFrame == (this.fraStep.Count() - 1))
            {
                this.cmdNext.Text = "&Finish";
            }
            else
            {
                this.NextFrame = this.ThisFrame + 1;
            }
        }

        private void ShowPrevious()
        {
            this.HideAll();
            this.ThisFrame = this.PreviousFrame;
            this.fraStep[(short) this.PreviousFrame].Left = 0;
            this.NextFrame = this.ThisFrame + 1;
            this.cmdNext.Text = "&Next";
            if (this.PreviousFrame == 0)
            {
                this.cmdPrevious.Enabled = false;
            }
            else
            {
                this.PreviousFrame = this.ThisFrame - 1;
            }
        }

        private bool ValidTextFileSelected() => 
            this.TextFileName == "";

        public virtual TextBox txtNoVars
        {
            [DebuggerNonUserCode]
            get => 
                this._txtNoVars;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtNoVars = value;
        }

        public virtual RadioButton _optTypeOfFile_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__optTypeOfFile_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optTypeOfFile_5 = value;
        }

        public virtual RadioButton _optTypeOfFile_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__optTypeOfFile_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optTypeOfFile_4 = value;
        }

        public virtual RadioButton _optTypeOfFile_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__optTypeOfFile_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optTypeOfFile_3 = value;
        }

        public virtual RadioButton _optTypeOfFile_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__optTypeOfFile_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optTypeOfFile_2 = value;
        }

        public virtual RadioButton _optTypeOfFile_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optTypeOfFile_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optTypeOfFile_1 = value;
        }

        public virtual RadioButton _optTypeOfFile_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optTypeOfFile_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optTypeOfFile_0 = value;
        }

        public virtual Label lblVariables
        {
            [DebuggerNonUserCode]
            get => 
                this._lblVariables;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblVariables = value;
        }

        public virtual Label lblContent
        {
            [DebuggerNonUserCode]
            get => 
                this._lblContent;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblContent = value;
        }

        public virtual Label _lblStep_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblStep_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblStep_3 = value;
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

        public virtual AxMSFlexGrid grdBinFile
        {
            [DebuggerNonUserCode]
            get => 
                this._grdBinFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._grdBinFile = value;
        }

        public virtual Button cmdBrowseForBin
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseForBin;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowseForBin_Click);
                if (!ReferenceEquals(this._cmdBrowseForBin, null))
                {
                    this._cmdBrowseForBin.Click -= handler;
                }
                this._cmdBrowseForBin = value;
                if (!ReferenceEquals(this._cmdBrowseForBin, null))
                {
                    this._cmdBrowseForBin.Click += handler;
                }
            }
        }

        public virtual TextBox txtBinFile
        {
            [DebuggerNonUserCode]
            get => 
                this._txtBinFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtBinFile = value;
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

        public virtual Label _lblStep_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__lblStep_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__lblStep_2 = value;
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

        public virtual Button cmdSetVarDesc
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdSetVarDesc;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdSetVarDesc_Click);
                if (!ReferenceEquals(this._cmdSetVarDesc, null))
                {
                    this._cmdSetVarDesc.Click -= handler;
                }
                this._cmdSetVarDesc = value;
                if (!ReferenceEquals(this._cmdSetVarDesc, null))
                {
                    this._cmdSetVarDesc.Click += handler;
                }
            }
        }

        public virtual TextBox txtVarDesc
        {
            [DebuggerNonUserCode]
            get => 
                this._txtVarDesc;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtVarDesc = value;
        }

        public virtual ComboBox cmbVarDescs
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbVarDescs;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmbVarDescs_SelectedIndexChanged);
                EventHandler handler2 = new EventHandler(this.cmbVarDescs_TextChanged);
                if (!ReferenceEquals(this._cmbVarDescs, null))
                {
                    this._cmbVarDescs.SelectedIndexChanged -= handler;
                    this._cmbVarDescs.TextChanged -= handler2;
                }
                this._cmbVarDescs = value;
                if (!ReferenceEquals(this._cmbVarDescs, null))
                {
                    this._cmbVarDescs.SelectedIndexChanged += handler;
                    this._cmbVarDescs.TextChanged += handler2;
                }
            }
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

        public virtual GroupBox fraVarDescs
        {
            [DebuggerNonUserCode]
            get => 
                this._fraVarDescs;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraVarDescs = value;
        }

        public virtual ComboBox _cmbVariable_5
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbVariable_5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbVariable_5 = value;
        }

        public virtual ComboBox _cmbVariable_4
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbVariable_4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbVariable_4 = value;
        }

        public virtual ComboBox _cmbVariable_3
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbVariable_3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbVariable_3 = value;
        }

        public virtual ComboBox _cmbVariable_2
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbVariable_2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbVariable_2 = value;
        }

        public virtual ComboBox _cmbVariable_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbVariable_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbVariable_1 = value;
        }

        public virtual ComboBox _cmbVariable_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__cmbVariable_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__cmbVariable_0 = value;
        }

        public virtual AxMSFlexGrid grdTextFile
        {
            [DebuggerNonUserCode]
            get => 
                this._grdTextFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._grdTextFile = value;
        }

        public virtual Button cmdBrowseForText
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseForText;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowseForText_Click);
                if (!ReferenceEquals(this._cmdBrowseForText, null))
                {
                    this._cmdBrowseForText.Click -= handler;
                }
                this._cmdBrowseForText = value;
                if (!ReferenceEquals(this._cmdBrowseForText, null))
                {
                    this._cmdBrowseForText.Click += handler;
                }
            }
        }

        public virtual TextBox txtTextFile
        {
            [DebuggerNonUserCode]
            get => 
                this._txtTextFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtTextFile = value;
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

        public virtual ComboBoxArray cmbVariable
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbVariable;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmbVariable = value;
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

        public virtual RadioButtonArray optTypeOfFile
        {
            [DebuggerNonUserCode]
            get => 
                this._optTypeOfFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optTypeOfFile = value;
        }
    }
}

