namespace MACRO_52
{
    using AxMSFlexGridLib;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class frmRainfallDisagg : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Command2")]
        private Button _Command2;
        [AccessedThroughProperty("cmbLocations")]
        private ComboBox _cmbLocations;
        [AccessedThroughProperty("cmdExit")]
        private Button _cmdExit;
        [AccessedThroughProperty("cmdDefault")]
        private Button _cmdDefault;
        [AccessedThroughProperty("Command1")]
        private Button _Command1;
        [AccessedThroughProperty("MSFlexGrid1")]
        private AxMSFlexGrid _MSFlexGrid1;
        [AccessedThroughProperty("txtRainfallFile")]
        private TextBox _txtRainfallFile;
        [AccessedThroughProperty("cmdBrowseInput")]
        private Button _cmdBrowseInput;
        [AccessedThroughProperty("cmdBrowseOutput")]
        private Button _cmdBrowseOutput;
        [AccessedThroughProperty("txtOutputFile")]
        private TextBox _txtOutputFile;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        private string m_InputFile;
        private string m_OutputFile;
        private double m_StartDate;
        private int m_NValues;
        private bool m_InGrid;
        private CfrmMain frmMain;

        public frmRainfallDisagg(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.frmRainfallDisagg_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void cmdBrowseInput_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void cmdBrowseOutput_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void cmdDefault_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.cmbLocations.SelectedIndex == 0)
            {
                this.SetDefaultParametersSkåne();
            }
            else if (this.cmbLocations.SelectedIndex == 1)
            {
                this.SetDefaultParametersUK();
            }
            else if (this.cmbLocations.SelectedIndex == 2)
            {
                this.SetDefaultParametersBrazil();
            }
        }

        private void cmdDisaggregate_Click()
        {
            this.DoDisaggregation();
            MiscFUncs.MsgBox_Renamed("Disaggregation ready", 0, "");
        }

        private void cmdExit_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
        }

        private void Command1_Click(object eventSender, EventArgs eventArgs)
        {
            if ((Strings.Len(this.m_InputFile) == 0) | (Strings.Len(this.m_OutputFile) == 0))
            {
                MiscFUncs.MsgBox_Renamed("Please specify the necessary files", 0x30, "File missing");
            }
            else
            {
                this.DoDisaggregation();
                MiscFUncs.MsgBox_Renamed("Disaggregation ready", 0, "");
            }
        }

        private void Command2_Click(object eventSender, EventArgs eventArgs)
        {
            CDisaggregation disaggregation = new CDisaggregation();
            TextBox txtRainfallFile = this.txtRainfallFile;
            string text = txtRainfallFile.Text;
            disaggregation.ReadParameters(ref this.MSFlexGrid1, ref text, ref this.m_StartDate);
            txtRainfallFile.Text = text;
            this.Cursor = Cursors.WaitCursor;
            disaggregation.Disaggregate(ref false, ref 4);
            disaggregation.PrintRainfallSeries(ref disaggregation.NumberOfRainfallSeries, ref this.m_OutputFile, ref this.m_StartDate);
            this.Convert15To24();
            this.Cursor = Cursors.Default;
        }

        private void Convert15To24()
        {
            CRainfall rainfall = new CRainfall();
            CRainfall rainfall2 = new CRainfall();
            CRainfall rainfall3 = new CRainfall();
            int nValues = this.m_NValues;
            short fileNumber = (short) FileSystem.FreeFile();
            FileSystem.FileOpen(fileNumber, this.m_OutputFile, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1);
            rainfall.ReadRainfallFromBinFile(ref fileNumber, ref 0.0);
            FileSystem.FileClose(new int[] { fileNumber });
            rainfall3.Init(ref rainfall.TimeSteps * 5);
            int index = 1;
            int timeSteps = rainfall.TimeSteps;
            int num2 = 1;
            while (true)
            {
                int num11 = timeSteps;
                if (num2 > num11)
                {
                    rainfall2.Init(ref (int) Math.Round((double) (((double) rainfall3.TimeSteps) / 8.0)));
                    index = 1;
                    int num9 = rainfall3.TimeSteps - 1;
                    num2 = 1;
                    while (num2 <= num9)
                    {
                        int num10 = num2 + 7;
                        int num4 = num2;
                        while (true)
                        {
                            num11 = num10;
                            if (num4 > num11)
                            {
                                index++;
                                num2 += 8;
                                break;
                            }
                            rainfall2.set_Rainfall(index, rainfall2.get_Rainfall(index) + rainfall3.get_Rainfall(num4));
                            num4++;
                        }
                    }
                    FileSystem.FileClose(new int[0]);
                    rainfall2.PrintRainfall(ref this.m_OutputFile, ref this.m_StartDate, ref 0x5a0);
                    return;
                }
                rainfall3.set_Rainfall(index, rainfall.get_Rainfall(num2) / 5f);
                index++;
                rainfall3.set_Rainfall(index, rainfall.get_Rainfall(num2) / 5f);
                index++;
                rainfall3.set_Rainfall(index, rainfall.get_Rainfall(num2) / 5f);
                index++;
                rainfall3.set_Rainfall(index, rainfall.get_Rainfall(num2) / 5f);
                index++;
                rainfall3.set_Rainfall(index, rainfall.get_Rainfall(num2) / 5f);
                index++;
                num2++;
            }
        }

        private void Convert45To60()
        {
            CRainfall rainfall = new CRainfall();
            CRainfall rainfall2 = new CRainfall();
            int nValues = this.m_NValues;
            short fileNumber = (short) FileSystem.FreeFile();
            FileSystem.FileOpen(fileNumber, this.m_OutputFile, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1);
            rainfall.ReadRainfallFromBinFile(ref fileNumber, ref 0.0);
            FileSystem.FileClose(new int[] { fileNumber });
            rainfall2.Init(ref (int) Math.Round((double) (((double) (rainfall.TimeSteps * 3)) / 4.0)));
            int index = 1;
            int timeSteps = rainfall.TimeSteps;
            int num2 = 1;
            while (true)
            {
                int num8 = timeSteps;
                if (num2 > num8)
                {
                    FileSystem.FileClose(new int[0]);
                    rainfall2.PrintRainfall(ref this.m_OutputFile, ref this.m_StartDate, ref 60);
                    return;
                }
                rainfall2.set_Rainfall(index, rainfall.get_Rainfall(num2) + ((float) (0.33333333333333331 * rainfall.get_Rainfall(num2 + 1))));
                index++;
                rainfall2.set_Rainfall(index, (float) (0.66666666666666663 * (rainfall.get_Rainfall(num2 + 1) + rainfall.get_Rainfall(num2 + 2))));
                index++;
                rainfall2.set_Rainfall(index, ((float) (rainfall.get_Rainfall(num2 + 2) * 0.33333333333333331)) + rainfall.get_Rainfall(num2 + 3));
                index++;
                num2 += 4;
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

        private void DoDisaggregation()
        {
            CDisaggregation disaggregation = new CDisaggregation();
            TextBox txtRainfallFile = this.txtRainfallFile;
            string text = txtRainfallFile.Text;
            disaggregation.ReadParameters(ref this.MSFlexGrid1, ref text, ref this.m_StartDate);
            txtRainfallFile.Text = text;
            this.Cursor = Cursors.WaitCursor;
            disaggregation.Disaggregate(ref false, ref 5);
            disaggregation.PrintRainfallSeries(ref disaggregation.NumberOfRainfallSeries, ref this.m_OutputFile, ref this.m_StartDate);
            this.Convert45To60();
            this.Cursor = Cursors.Default;
        }

        private void frmRainfallDisagg_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
            this.SetUpParameterTable();
            this.SetDefaultParametersSkåne();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmRainfallDisagg));
            this.Command2 = new Button();
            this.cmbLocations = new ComboBox();
            this.cmdExit = new Button();
            this.cmdDefault = new Button();
            this.Command1 = new Button();
            this.Frame1 = new GroupBox();
            this.MSFlexGrid1 = new AxMSFlexGrid();
            this.txtRainfallFile = new TextBox();
            this.cmdBrowseInput = new Button();
            this.cmdBrowseOutput = new Button();
            this.txtOutputFile = new TextBox();
            this.Label5 = new Label();
            this.Label4 = new Label();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Frame1.SuspendLayout();
            this.MSFlexGrid1.BeginInit();
            this.SuspendLayout();
            this.Command2.BackColor = SystemColors.Control;
            this.Command2.Cursor = Cursors.Default;
            this.Command2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command2.ForeColor = SystemColors.ControlText;
            Point point = new Point(0x200, 0x88);
            this.Command2.Location = point;
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = RightToLeft.No;
            Size size = new Size(0x51, 0x21);
            this.Command2.Size = size;
            this.Command2.TabIndex = 15;
            this.Command2.Text = "Command2";
            this.Command2.UseVisualStyleBackColor = false;
            this.Command2.Visible = false;
            this.cmbLocations.BackColor = SystemColors.Window;
            this.cmbLocations.Cursor = Cursors.Default;
            this.cmbLocations.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbLocations.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbLocations.ForeColor = SystemColors.WindowText;
            object[] items = new object[] { "Sk\x00e5ne", "U.K. (T)", "Brazil (J)" };
            this.cmbLocations.Items.AddRange(items);
            point = new Point(0x1a3, 0x98);
            this.cmbLocations.Location = point;
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x16);
            this.cmbLocations.Size = size;
            this.cmbLocations.TabIndex = 13;
            this.cmdExit.BackColor = SystemColors.Control;
            this.cmdExit.Cursor = Cursors.Default;
            this.cmdExit.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdExit.ForeColor = SystemColors.ControlText;
            point = new Point(0x2fd, 0x90);
            this.cmdExit.Location = point;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x21);
            this.cmdExit.Size = size;
            this.cmdExit.TabIndex = 12;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdDefault.BackColor = SystemColors.Control;
            this.cmdDefault.Cursor = Cursors.Default;
            this.cmdDefault.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdDefault.ForeColor = SystemColors.ControlText;
            point = new Point(0x243, 0x98);
            this.cmdDefault.Location = point;
            this.cmdDefault.Name = "cmdDefault";
            this.cmdDefault.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x19);
            this.cmdDefault.Size = size;
            this.cmdDefault.TabIndex = 10;
            this.cmdDefault.Text = "&Set";
            this.cmdDefault.UseVisualStyleBackColor = false;
            this.Command1.BackColor = SystemColors.Control;
            this.Command1.Cursor = Cursors.Default;
            this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command1.ForeColor = SystemColors.ControlText;
            point = new Point(0x2fd, 0x69);
            this.Command1.Location = point;
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x21);
            this.Command1.Size = size;
            this.Command1.TabIndex = 1;
            this.Command1.Text = "&Disaggregate";
            this.Command1.UseVisualStyleBackColor = false;
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.MSFlexGrid1);
            this.Frame1.Controls.Add(this.cmbLocations);
            this.Frame1.Controls.Add(this.txtRainfallFile);
            this.Frame1.Controls.Add(this.cmdExit);
            this.Frame1.Controls.Add(this.cmdBrowseInput);
            this.Frame1.Controls.Add(this.cmdDefault);
            this.Frame1.Controls.Add(this.cmdBrowseOutput);
            this.Frame1.Controls.Add(this.Command1);
            this.Frame1.Controls.Add(this.txtOutputFile);
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(0, 0);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x357, 0xb9);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            point = new Point(8, 0x18);
            this.MSFlexGrid1.Location = point;
            this.MSFlexGrid1.Name = "MSFlexGrid1";
            this.MSFlexGrid1.OcxState = (AxHost.State) manager.GetObject("MSFlexGrid1.OcxState");
            size = new Size(0x16f, 0x99);
            this.MSFlexGrid1.Size = size;
            this.MSFlexGrid1.TabIndex = 8;
            this.txtRainfallFile.AcceptsReturn = true;
            this.txtRainfallFile.BackColor = SystemColors.Window;
            this.txtRainfallFile.Cursor = Cursors.IBeam;
            this.txtRainfallFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtRainfallFile.ForeColor = SystemColors.WindowText;
            point = new Point(0x1a3, 0x49);
            this.txtRainfallFile.Location = point;
            this.txtRainfallFile.MaxLength = 0;
            this.txtRainfallFile.Name = "txtRainfallFile";
            this.txtRainfallFile.ReadOnly = true;
            this.txtRainfallFile.RightToLeft = RightToLeft.No;
            size = new Size(0x139, 20);
            this.txtRainfallFile.Size = size;
            this.txtRainfallFile.TabIndex = 7;
            this.cmdBrowseInput.BackColor = SystemColors.Control;
            this.cmdBrowseInput.Cursor = Cursors.Default;
            this.cmdBrowseInput.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseInput.ForeColor = SystemColors.ControlText;
            point = new Point(0x2db, 0x49);
            this.cmdBrowseInput.Location = point;
            this.cmdBrowseInput.Name = "cmdBrowseInput";
            this.cmdBrowseInput.RightToLeft = RightToLeft.No;
            size = new Size(0x1c, 20);
            this.cmdBrowseInput.Size = size;
            this.cmdBrowseInput.TabIndex = 5;
            this.cmdBrowseInput.Text = "&...";
            this.cmdBrowseInput.UseVisualStyleBackColor = false;
            this.cmdBrowseOutput.BackColor = SystemColors.Control;
            this.cmdBrowseOutput.Cursor = Cursors.Default;
            this.cmdBrowseOutput.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseOutput.ForeColor = SystemColors.ControlText;
            point = new Point(0x2dc, 0x70);
            this.cmdBrowseOutput.Location = point;
            this.cmdBrowseOutput.Name = "cmdBrowseOutput";
            this.cmdBrowseOutput.RightToLeft = RightToLeft.No;
            size = new Size(0x1b, 20);
            this.cmdBrowseOutput.Size = size;
            this.cmdBrowseOutput.TabIndex = 4;
            this.cmdBrowseOutput.Text = "&...";
            this.cmdBrowseOutput.UseVisualStyleBackColor = false;
            this.txtOutputFile.AcceptsReturn = true;
            this.txtOutputFile.BackColor = SystemColors.Window;
            this.txtOutputFile.Cursor = Cursors.IBeam;
            this.txtOutputFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtOutputFile.ForeColor = SystemColors.WindowText;
            point = new Point(420, 0x70);
            this.txtOutputFile.Location = point;
            this.txtOutputFile.MaxLength = 0;
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.RightToLeft = RightToLeft.No;
            size = new Size(0x139, 20);
            this.txtOutputFile.Size = size;
            this.txtOutputFile.TabIndex = 3;
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(0x1a0, 0x87);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0xb9, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Use default parameters from:";
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(0x1a3, 0x10);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x1a1, 0x29);
            this.Label4.Size = size;
            this.Label4.TabIndex = 11;
            this.Label4.Text = "This tool disaggregates a daily rainfall series into an hourly rainfall series. Both files specified below are in the MACRO 5.0 .bin-format";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 8);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Parameter values:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(0x1a3, 0x39);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Daily rainfall file:";
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(420, 0x60);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x89, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Output file:";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x361, 190);
            this.ClientSize = size;
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Frame1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRainfallDisagg";
            this.RightToLeft = RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "MACRO 5.2 - Rainfall disaggregation";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.MSFlexGrid1.EndInit();
            this.ResumeLayout(false);
        }

        private void MSFlexGrid1_KeyPressEvent(object eventSender, DMSFlexGridEvents_KeyPressEvent eventArgs)
        {
            AxMSFlexGrid grid = this.MSFlexGrid1;
            if (!this.m_InGrid & (eventArgs.keyAscii != 13))
            {
                grid.set_TextMatrix(grid.Row, grid.Col, "");
            }
            this.m_InGrid = true;
            if ((grid.Col > 0) & (grid.Row > 0))
            {
                if (eventArgs.keyAscii != 8)
                {
                    if (eventArgs.keyAscii != 13)
                    {
                        grid.set_TextMatrix(grid.Row, grid.Col, grid.get_TextMatrix(grid.Row, grid.Col) + Conversions.ToString(Strings.Chr(eventArgs.keyAscii)));
                    }
                    else
                    {
                        if (grid.Row != (grid.Rows - 1))
                        {
                            grid.Row++;
                        }
                        return;
                    }
                }
                else
                {
                    if (Strings.Len(grid.get_TextMatrix(grid.Row, grid.Col)) > 0)
                    {
                        grid.set_TextMatrix(grid.Row, grid.Col, Strings.Left(grid.get_TextMatrix(grid.Row, grid.Col), Strings.Len(grid.get_TextMatrix(grid.Row, grid.Col)) - 1));
                    }
                    return;
                }
            }
            grid = null;
        }

        private void MSFlexGrid1_LeaveCell(object eventSender, EventArgs eventArgs)
        {
            this.m_InGrid = false;
        }

        private void SetDefaultParametersBrazil()
        {
            AxMSFlexGrid grid = this.MSFlexGrid1;
            grid.set_TextMatrix(1, 2, "0.49");
            grid.set_TextMatrix(2, 2, "0.56");
            grid.set_TextMatrix(3, 2, "0.18");
            grid.set_TextMatrix(4, 2, "0.24");
            grid.set_TextMatrix(5, 2, "0.13");
            grid.set_TextMatrix(6, 2, "0.20");
            grid.set_TextMatrix(7, 2, "0.28");
            grid.set_TextMatrix(8, 2, "0.44");
            grid.set_TextMatrix(1, 1, "0.11");
            grid.set_TextMatrix(2, 1, "0.24");
            grid.set_TextMatrix(3, 1, "0.08");
            grid.set_TextMatrix(4, 1, "0.26");
            grid.set_TextMatrix(5, 1, "0.38");
            grid.set_TextMatrix(6, 1, "0.46");
            grid.set_TextMatrix(7, 1, "0.28");
            grid.set_TextMatrix(8, 1, "0.40");
            grid.set_TextMatrix(1, 3, "0.40");
            grid.set_TextMatrix(2, 3, "0.20");
            grid.set_TextMatrix(3, 3, "0.74");
            grid.set_TextMatrix(4, 3, "0.50");
            grid.set_TextMatrix(5, 3, "0.49");
            grid.set_TextMatrix(6, 3, "0.34");
            grid.set_TextMatrix(7, 3, "0.44");
            grid.set_TextMatrix(8, 3, "0.16");
            grid = null;
        }

        private void SetDefaultParametersSkåne()
        {
            AxMSFlexGrid grid = this.MSFlexGrid1;
            grid.set_TextMatrix(1, 2, "0.29");
            grid.set_TextMatrix(2, 2, "0.61");
            grid.set_TextMatrix(3, 2, "0.13");
            grid.set_TextMatrix(4, 2, "0.34");
            grid.set_TextMatrix(5, 2, "0.10");
            grid.set_TextMatrix(6, 2, "0.21");
            grid.set_TextMatrix(7, 2, "0.24");
            grid.set_TextMatrix(8, 2, "0.44");
            grid.set_TextMatrix(1, 1, "0.10");
            grid.set_TextMatrix(2, 1, "0.21");
            grid.set_TextMatrix(3, 1, "0.13");
            grid.set_TextMatrix(4, 1, "0.34");
            grid.set_TextMatrix(5, 1, "0.29");
            grid.set_TextMatrix(6, 1, "0.61");
            grid.set_TextMatrix(7, 1, "0.24");
            grid.set_TextMatrix(8, 1, "0.44");
            grid.set_TextMatrix(1, 3, "0.61");
            grid.set_TextMatrix(2, 3, "0.18");
            grid.set_TextMatrix(3, 3, "0.74");
            grid.set_TextMatrix(4, 3, "0.32");
            grid.set_TextMatrix(5, 3, "0.62");
            grid.set_TextMatrix(6, 3, "0.18");
            grid.set_TextMatrix(7, 3, "0.52");
            grid.set_TextMatrix(8, 3, "0.12");
            grid = null;
        }

        private void SetDefaultParametersUK()
        {
            AxMSFlexGrid grid = this.MSFlexGrid1;
            grid.set_TextMatrix(1, 2, "0.21");
            grid.set_TextMatrix(2, 2, "0.46");
            grid.set_TextMatrix(3, 2, "0.03");
            grid.set_TextMatrix(4, 2, "0.15");
            grid.set_TextMatrix(5, 2, "0.03");
            grid.set_TextMatrix(6, 2, "0.15");
            grid.set_TextMatrix(7, 2, "0.23");
            grid.set_TextMatrix(8, 2, "0.33");
            grid.set_TextMatrix(1, 1, "0.03");
            grid.set_TextMatrix(2, 1, "0.14");
            grid.set_TextMatrix(3, 1, "0.03");
            grid.set_TextMatrix(4, 1, "0.16");
            grid.set_TextMatrix(5, 1, "0.22");
            grid.set_TextMatrix(6, 1, "0.40");
            grid.set_TextMatrix(7, 1, "0.20");
            grid.set_TextMatrix(8, 1, "0.34");
            grid.set_TextMatrix(1, 3, "0.76");
            grid.set_TextMatrix(2, 3, "0.40");
            grid.set_TextMatrix(3, 3, "0.94");
            grid.set_TextMatrix(4, 3, "0.69");
            grid.set_TextMatrix(5, 3, "0.75");
            grid.set_TextMatrix(6, 3, "0.45");
            grid.set_TextMatrix(7, 3, "0.57");
            grid.set_TextMatrix(8, 3, "0.33");
            grid = null;
        }

        private void SetUpParameterTable()
        {
            AxMSFlexGrid grid = this.MSFlexGrid1;
            grid.set_TextMatrix(0, 1, "P(1/0)");
            grid.set_TextMatrix(0, 2, "P(0/1)");
            grid.set_TextMatrix(0, 3, "P(x/x)");
            grid.set_TextMatrix(1, 0, "Start(a)");
            grid.set_TextMatrix(2, 0, "Start(b)");
            grid.set_TextMatrix(3, 0, "Encl.(a)");
            grid.set_TextMatrix(4, 0, "Encl.(b)");
            grid.set_TextMatrix(5, 0, "End(a)");
            grid.set_TextMatrix(6, 0, "End(b)");
            grid.set_TextMatrix(7, 0, "Isol.(a)");
            grid.set_TextMatrix(8, 0, "Isol.(b)");
            grid = null;
        }

        public virtual Button Command2
        {
            [DebuggerNonUserCode]
            get => 
                this._Command2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command2_Click);
                if (!ReferenceEquals(this._Command2, null))
                {
                    this._Command2.Click -= handler;
                }
                this._Command2 = value;
                if (!ReferenceEquals(this._Command2, null))
                {
                    this._Command2.Click += handler;
                }
            }
        }

        public virtual ComboBox cmbLocations
        {
            [DebuggerNonUserCode]
            get => 
                this._cmbLocations;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._cmbLocations = value;
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

        public virtual Button cmdDefault
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdDefault;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdDefault_Click);
                if (!ReferenceEquals(this._cmdDefault, null))
                {
                    this._cmdDefault.Click -= handler;
                }
                this._cmdDefault = value;
                if (!ReferenceEquals(this._cmdDefault, null))
                {
                    this._cmdDefault.Click += handler;
                }
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

        public virtual AxMSFlexGrid MSFlexGrid1
        {
            [DebuggerNonUserCode]
            get => 
                this._MSFlexGrid1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.MSFlexGrid1_LeaveCell);
                DMSFlexGridEvents_KeyPressEventHandler handler2 = new DMSFlexGridEvents_KeyPressEventHandler(this.MSFlexGrid1_KeyPressEvent);
                if (!ReferenceEquals(this._MSFlexGrid1, null))
                {
                    this._MSFlexGrid1.LeaveCell -= handler;
                    this._MSFlexGrid1.KeyPressEvent -= handler2;
                }
                this._MSFlexGrid1 = value;
                if (!ReferenceEquals(this._MSFlexGrid1, null))
                {
                    this._MSFlexGrid1.LeaveCell += handler;
                    this._MSFlexGrid1.KeyPressEvent += handler2;
                }
            }
        }

        public virtual TextBox txtRainfallFile
        {
            [DebuggerNonUserCode]
            get => 
                this._txtRainfallFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtRainfallFile = value;
        }

        public virtual Button cmdBrowseInput
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseInput;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowseInput_Click);
                if (!ReferenceEquals(this._cmdBrowseInput, null))
                {
                    this._cmdBrowseInput.Click -= handler;
                }
                this._cmdBrowseInput = value;
                if (!ReferenceEquals(this._cmdBrowseInput, null))
                {
                    this._cmdBrowseInput.Click += handler;
                }
            }
        }

        public virtual Button cmdBrowseOutput
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseOutput;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowseOutput_Click);
                if (!ReferenceEquals(this._cmdBrowseOutput, null))
                {
                    this._cmdBrowseOutput.Click -= handler;
                }
                this._cmdBrowseOutput = value;
                if (!ReferenceEquals(this._cmdBrowseOutput, null))
                {
                    this._cmdBrowseOutput.Click += handler;
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

        public virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label1 = value;
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

        public virtual Label Label3
        {
            [DebuggerNonUserCode]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label3 = value;
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
    }
}

