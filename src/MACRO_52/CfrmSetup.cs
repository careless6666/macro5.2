namespace MACRO_52
{
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
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class CfrmSetup : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("txtOutputFileName")]
        private TextBox _txtOutputFileName;
        [AccessedThroughProperty("_optFileName_1")]
        private RadioButton __optFileName_1;
        [AccessedThroughProperty("_optFileName_0")]
        private RadioButton __optFileName_0;
        [AccessedThroughProperty("Drive1")]
        private DriveListBox _Drive1;
        [AccessedThroughProperty("Dir1")]
        private DirListBox _Dir1;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Frame6")]
        private GroupBox _Frame6;
        [AccessedThroughProperty("Command2")]
        private Button _Command2;
        [AccessedThroughProperty("flx_sim")]
        private AxMSFlexGrid _flx_sim;
        [AccessedThroughProperty("Frame9")]
        private GroupBox _Frame9;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Frame4")]
        private GroupBox _Frame4;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Frame7")]
        private GroupBox _Frame7;
        [AccessedThroughProperty("cmdBrowseDateFile")]
        private Button _cmdBrowseDateFile;
        [AccessedThroughProperty("chkSpecOut")]
        private CheckBox _chkSpecOut;
        [AccessedThroughProperty("Option4")]
        private RadioButton _Option4;
        [AccessedThroughProperty("Option3")]
        private RadioButton _Option3;
        [AccessedThroughProperty("Text5")]
        private TextBox _Text5;
        [AccessedThroughProperty("Text4")]
        private TextBox _Text4;
        [AccessedThroughProperty("lblDateFile")]
        private Label _lblDateFile;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label28")]
        private Label _Label28;
        [AccessedThroughProperty("Frame5")]
        private GroupBox _Frame5;
        [AccessedThroughProperty("Command1")]
        private Button _Command1;
        [AccessedThroughProperty("Command4")]
        private Button _Command4;
        [AccessedThroughProperty("optFileName")]
        private RadioButtonArray _optFileName;
        [AccessedThroughProperty("dtStartDate")]
        private DateTimePicker _dtStartDate;
        [AccessedThroughProperty("dtEndDate")]
        private DateTimePicker _dtEndDate;
        private bool IsInitializing;
        private string startdatum;
        private string slutdatum;
        private string sl_ett_ar;
        private int of_Renamed;
        private short st_dat;
        private short sl_dat;
        private string[] variabelnamn;
        private string nm;
        private short svar;
        private int rec_ant;
        private int rec_l;
        private int jalpha;
        private int jul;
        private int ja;
        private int jd;
        private int jb;
        private int jc;
        private int je;
        private int mon;
        private int yea;
        private int da;
        private int ho;
        private int mi;
        private int jy;
        private int jm;
        private int juldate;
        private float var_ant;
        private int oneyear;
        private int start_Renamed;
        private string filepath;
        private string d1;
        private string m1;
        private string H_M;
        private string l1;
        private string l2;
        private string r_rain_file;
        private string r_met_file;
        private string r_driving_file;
        private short r_sw_rainfall;
        private short r_sw_evaporate;
        private short r_sw_metabolite;
        private short r_sw_driving;
        private CfrmAddFile frmAddFile;
        private CfrmMain frmMain;

        public CfrmSetup(ref CfrmMain frm)
        {
            base.Activated += new EventHandler(this.frmSetup_Activated);
            base.Load += new EventHandler(this.frmSetup_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.variabelnamn = new string[0xc9];
            this.IsInitializing = true;
            this.InitializeComponent();
            this.IsInitializing = false;
            this.frmMain = frm;
        }

        private void _optFileName_1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtOutputFileName.Enabled = this._optFileName_1.Checked;
        }

        private bool AddFile(ref string filename, ref CfrmAddFile frm)
        {
            if (frm.optTypeOfFile[0].Checked)
            {
                if (this.frmAddFile.nVariables != 1)
                {
                    this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("More than one variable", 0x10, "Wrong number of variables"));
                }
                else if (this.frmAddFile.dt != 0x5a0)
                {
                    this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Incorrect timestep", 0x30, "Error"));
                }
                else
                {
                    GlobalVariables.sw_rainfall = MACROConstants.Switch.BareSoil;
                    GlobalVariables.Rainfall_file = this.frmAddFile.BinFileName + this.nm;
                    GlobalVariables.RainfallPeriod = MiscFUncs.ConvertJulianDate(this.frmAddFile.startdate, ref "", ref "", ref "", ref "", ref "", ref 4) + "-" + MiscFUncs.ConvertJulianDate(this.frmAddFile.StopDate, ref "", ref "", ref "", ref "", ref "", ref 4);
                }
            }
            else if (frm.optTypeOfFile[1].Checked)
            {
                if (this.frmAddFile.nVariables != 1)
                {
                    this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("More than one variable", 0x30, "Error"));
                }
                else if (this.frmAddFile.dt != 60)
                {
                    this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Incorrect timestep", 0x30, "Error"));
                }
                else
                {
                    GlobalVariables.sw_rainfall = MACROConstants.Switch.Annual;
                    GlobalVariables.Rainfall_file = this.frmAddFile.BinFileName + this.nm;
                    GlobalVariables.RainfallPeriod = MiscFUncs.ConvertJulianDate(this.frmAddFile.startdate, ref "", ref "", ref "", ref "", ref "", ref 4) + "-" + MiscFUncs.ConvertJulianDate(this.frmAddFile.StopDate, ref "", ref "", ref "", ref "", ref "", ref 4);
                }
            }
            else if (frm.optTypeOfFile[2].Checked)
            {
                if (this.frmAddFile.nVariables != 5)
                {
                    this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("File does not have five variables", 0x10, "Wrong number of variables"));
                }
                else
                {
                    GlobalVariables.sw_evaporate = MACROConstants.Switch.Annual;
                    GlobalVariables.Met_file = this.frmAddFile.BinFileName + this.nm;
                    GlobalVariables.MetPeriod = MiscFUncs.ConvertJulianDate(this.frmAddFile.startdate, ref "", ref "", ref "", ref "", ref "", ref 4) + "-" + MiscFUncs.ConvertJulianDate(this.frmAddFile.StopDate, ref "", ref "", ref "", ref "", ref "", ref 4);
                }
            }
            else if (frm.optTypeOfFile[3].Checked)
            {
                if (this.frmAddFile.nVariables != 3)
                {
                    this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("File does not have three variables", 0x10, "Wrong number of variables"));
                }
                else
                {
                    GlobalVariables.sw_evaporate = MACROConstants.Switch.BareSoil;
                    GlobalVariables.Met_file = this.frmAddFile.BinFileName + this.nm;
                    GlobalVariables.MetPeriod = MiscFUncs.ConvertJulianDate(this.frmAddFile.startdate, ref "", ref "", ref "", ref "", ref "", ref 4) + "-" + MiscFUncs.ConvertJulianDate(this.frmAddFile.StopDate, ref "", ref "", ref "", ref "", ref "", ref 4);
                }
            }
            else if (!frm.optTypeOfFile[4].Checked)
            {
                if (frm.optTypeOfFile[5].Checked)
                {
                    GlobalVariables.sw_colloid = MACROConstants.Switch.NoMetabolite;
                    GlobalVariables.sw_driving = MACROConstants.Switch.Annual;
                    GlobalVariables.Driving_file = this.filepath + this.nm;
                    GlobalVariables.DrivingPeriod = MiscFUncs.ConvertJulianDate(this.frmAddFile.startdate, ref "", ref "", ref "", ref "", ref "", ref 4) + "-" + MiscFUncs.ConvertJulianDate(this.frmAddFile.StopDate, ref "", ref "", ref "", ref "", ref "", ref 4);
                }
            }
            else if (this.frmAddFile.nVariables != (GlobalVariables.Nlayer * 2))
            {
                this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Nlayer * 2 not equal to number of variables", 0x10, "Wrong number of variables"));
            }
            else
            {
                GlobalVariables.sw_metabolite = MACROConstants.Switch.NoMetabolite;
                GlobalVariables.sw_driving = MACROConstants.Switch.BareSoil;
                GlobalVariables.Driving_file = this.frmAddFile.BinFileName + this.nm;
                GlobalVariables.DrivingPeriod = MiscFUncs.ConvertJulianDate(this.frmAddFile.startdate, ref "", ref "", ref "", ref "", ref "", ref 4) + "-" + MiscFUncs.ConvertJulianDate(this.frmAddFile.StopDate, ref "", ref "", ref "", ref "", ref "", ref 4);
            }
            return true;
        }

        private void chkSpecOut_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if (this.chkSpecOut.CheckState == CheckState.Checked)
            {
                this.Text4.Enabled = false;
                this.Text5.Enabled = false;
                this.cmdBrowseDateFile.Enabled = true;
                this.lblDateFile.BackColor = Color.White;
                this.lblDateFile.Text = " ";
            }
            else
            {
                this.Text4.Enabled = true;
                this.Text5.Enabled = true;
                this.cmdBrowseDateFile.Enabled = false;
                this.lblDateFile.BackColor = SystemColors.InactiveBorder;
                this.lblDateFile.Text = " ";
            }
        }

        private void chkSpecOut_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            this.Frame4.Visible = true;
            this.Label4.Text = "File specifying the output dates. This file is an already created bin-file.\rIf 'Average for period' is used then the average for the interval will be written \rto the output file at the specified date and time.";
        }

        private void cmdBrowseDateFile_Click(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void Command1_Click(object eventSender, EventArgs eventArgs)
        {
            GlobalVariables.OutputFileDir = this.Dir1.Path;
            if (this.chkSpecOut.CheckState != CheckState.Checked)
            {
                GlobalVariables.sw_specout = MACROConstants.Switch.NoMetabolite;
            }
            else if (!(((Strings.Len(this.lblDateFile.Text) == 0) | (this.lblDateFile.Text == "(none)")) | (this.lblDateFile.Text == " ")))
            {
                GlobalVariables.sw_specout = MACROConstants.Switch.BareSoil;
            }
            else
            {
                MiscFUncs.MsgBox_Renamed("Please specify a file with the output dates", 0x30, "File missing");
                return;
            }
            if (Strings.Len(this.lblDateFile.Text) <= 0x40)
            {
                GlobalVariables.DateFile = this.lblDateFile.Text;
                if (!(this.optFileName[1].Checked & (Strings.Len(this.txtOutputFileName.Text) == 0)))
                {
                    if (!this.optFileName[1].Checked)
                    {
                        GlobalVariables.b_DefaultNaming = true;
                    }
                    else
                    {
                        GlobalVariables.b_DefaultNaming = false;
                        GlobalVariables.MACROOutputFile = this.txtOutputFileName.Text;
                    }
                    if (DateTime.Compare(this.dtEndDate.Value, this.dtStartDate.Value) < 0)
                    {
                        this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Startdate can't be later than(or equal to) ending date\rproceed anyway? ", 20, "Check simulation period"));
                        if (this.svar != 6)
                        {
                            return;
                        }
                    }
                    GlobalVariables.RainfallPeriod = Strings.Trim(GlobalVariables.RainfallPeriod);
                    if (MiscFUncs.JulianDate(Strings.Trim(Strings.Mid(GlobalVariables.RainfallPeriod, 1, 0x10))) > MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.dtStartDate)))
                    {
                        this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Simulation starts before Rainfall file\rproceed anyway? ", 20, "Check simulation period"));
                        if (this.svar != 6)
                        {
                            return;
                        }
                    }
                    string dtm = Strings.Trim(Strings.Mid(GlobalVariables.RainfallPeriod, 0x12, 0x11));
                    if (Strings.Len(this.flx_sim.get_TextMatrix(1, 0)) != 0)
                    {
                        if (MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.dtEndDate)) > (MiscFUncs.JulianDate(dtm) + 0x5a0L))
                        {
                            this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Simulation ends after Rainfall file\rproceed anyway? ", 20, "Check simulation period"));
                            if (this.svar != 6)
                            {
                                return;
                            }
                        }
                    }
                    else if (MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.dtEndDate)) > MiscFUncs.JulianDate(dtm))
                    {
                        this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Simulation ends after Rainfall file\rproceed anyway? ", 20, "Check simulation period"));
                        if (this.svar != 6)
                        {
                            return;
                        }
                    }
                    GlobalVariables.MetPeriod = Strings.Trim(GlobalVariables.MetPeriod);
                    if (MiscFUncs.JulianDate(Strings.Trim(Strings.Mid(GlobalVariables.MetPeriod, 1, 0x10))) > MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.dtStartDate)))
                    {
                        this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Simulation starts before Meterological file\rproceed anyway? ", 20, "Check simulation period"));
                        if (this.svar != 6)
                        {
                            return;
                        }
                    }
                    dtm = Strings.Trim(Strings.Mid(Strings.Trim(GlobalVariables.MetPeriod), 0x12, 0x11));
                    if (Strings.Len(this.flx_sim.get_TextMatrix(4, 0)) != 0)
                    {
                        if (MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.dtEndDate)) > (MiscFUncs.JulianDate(dtm) + 0x5a0L))
                        {
                            this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Simulation ends after Meterological file\rproceed anyway? ", 20, "Check simulation period"));
                            if (this.svar != 6)
                            {
                                return;
                            }
                        }
                    }
                    else if (MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.dtEndDate)) > MiscFUncs.JulianDate(dtm))
                    {
                        this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Simulation ends after Meterological file\rproceed anyway? ", 20, "Check simulation period"));
                        if (this.svar != 6)
                        {
                            return;
                        }
                    }
                    if (((GlobalVariables.sw_metabolite == MACROConstants.Switch.NoMetabolite) & (GlobalVariables.sw_driving == MACROConstants.Switch.BareSoil)) | ((GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite) & (GlobalVariables.sw_driving == MACROConstants.Switch.Annual)))
                    {
                        GlobalVariables.DrivingPeriod = Strings.Trim(GlobalVariables.DrivingPeriod);
                        if (MiscFUncs.JulianDate(Strings.Trim(Strings.Mid(GlobalVariables.DrivingPeriod, 1, 0x10))) > MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.dtStartDate)))
                        {
                            this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Simulation starts before Driving file\rproceed anyway? ", 20, "Check simulation period"));
                            if (this.svar != 6)
                            {
                                return;
                            }
                        }
                        dtm = Strings.Trim(Strings.Mid(GlobalVariables.DrivingPeriod, 0x12, 0x11));
                        if (MiscFUncs.JulianDate(Conversions.ToString(this.dtEndDate.Value)) > MiscFUncs.JulianDate(dtm))
                        {
                            this.svar = Conversions.ToShort(MiscFUncs.MsgBox_Renamed("Simulation ends after Driving file\rproceed anyway? ", 20, "Check simulation period"));
                            if (this.svar != 6)
                            {
                                return;
                            }
                        }
                    }
                    if (this.Option3.Checked)
                    {
                        GlobalVariables.sw_averagex = MACROConstants.Switch.BareSoil;
                    }
                    else if (this.Option4.Checked)
                    {
                        GlobalVariables.sw_averagex = MACROConstants.Switch.Annual;
                    }
                    GlobalVariables.outintd = (short) Math.Round(Conversion.Val(this.Text4.Text));
                    GlobalVariables.outintm = (short) Math.Round(Conversion.Val(this.Text5.Text));
                    if (GlobalVariables.sw_irrigate >= MACROConstants.Switch.BareSoil)
                    {
                        short num;
                        short num12;
                        if (GlobalVariables.b_irrsame)
                        {
                            GlobalVariables.Groups = null;
                            GlobalVariables.Groups = new short[((this.dtEndDate.Value.Year - this.dtStartDate.Value.Year) + 1) + 1, ((this.dtEndDate.Value.Year - this.dtStartDate.Value.Year) + 1) + 1];
                            if ((this.dtEndDate.Value.Year - this.dtStartDate.Value.Year) == 0)
                            {
                                GlobalVariables.IrrYears = 1;
                                GlobalVariables.b_irrsame = true;
                            }
                            short num4 = (short) Information.UBound(GlobalVariables.Groups, 2);
                            num = 1;
                            while (true)
                            {
                                num12 = num4;
                                if (num > num12)
                                {
                                    break;
                                }
                                GlobalVariables.Groups[1, num] = num;
                                num = (short) (num + 1);
                            }
                        }
                        else
                        {
                            short num5 = (short) Information.UBound(GlobalVariables.Groups, 1);
                            num = 1;
                            while (true)
                            {
                                short num2;
                                if (num > num5)
                                {
                                    short num7 = (short) Information.UBound(GlobalVariables.Groups, 1);
                                    num = 1;
                                    while (true)
                                    {
                                        if (num > num7)
                                        {
                                            short num9 = (short) (Information.UBound(GlobalVariables.Groups, 1) - 1);
                                            short num3 = 1;
                                            while (num3 <= num9)
                                            {
                                                short num10 = (short) (Information.UBound(GlobalVariables.Groups, 1) - 1);
                                                num = 1;
                                                while (true)
                                                {
                                                    num12 = num10;
                                                    if (num > num12)
                                                    {
                                                        num3 = (short) (num3 + 1);
                                                        break;
                                                    }
                                                    if (GlobalVariables.Groups[num, 1] == 0)
                                                    {
                                                        short num11 = (short) Information.UBound(GlobalVariables.Groups, 2);
                                                        num2 = 1;
                                                        while (true)
                                                        {
                                                            num12 = num11;
                                                            if (num2 > num12)
                                                            {
                                                                break;
                                                            }
                                                            GlobalVariables.Groups[num, num2] = GlobalVariables.Groups[num + 1, num2];
                                                            GlobalVariables.Groups[num + 1, num2] = 0;
                                                            num2 = (short) (num2 + 1);
                                                        }
                                                    }
                                                    num = (short) (num + 1);
                                                }
                                            }
                                            break;
                                        }
                                        short num8 = (short) (Information.UBound(GlobalVariables.Groups, 2) - 1);
                                        num2 = 1;
                                        while (true)
                                        {
                                            num12 = num8;
                                            if (num2 > num12)
                                            {
                                                num = (short) (num + 1);
                                                break;
                                            }
                                            if (GlobalVariables.Groups[num, num2] == 0)
                                            {
                                                GlobalVariables.Groups[num, num2] = GlobalVariables.Groups[num, num2 + 1];
                                            }
                                            num2 = (short) (num2 + 1);
                                        }
                                    }
                                    break;
                                }
                                short num6 = (short) Information.UBound(GlobalVariables.Groups, 2);
                                num2 = 1;
                                while (true)
                                {
                                    num12 = num6;
                                    if (num2 > num12)
                                    {
                                        num = (short) (num + 1);
                                        break;
                                    }
                                    DateTime time4 = this.dtEndDate.Value;
                                    DateTime time3 = this.dtStartDate.Value;
                                    if (GlobalVariables.Groups[num, num2] > ((time4.Year - time3.Year) + 1))
                                    {
                                        GlobalVariables.Groups[num, num2] = 0;
                                    }
                                    num2 = (short) (num2 + 1);
                                }
                            }
                        }
                    }
                    this.Hide();
                }
                else
                {
                    MiscFUncs.MsgBox_Renamed("Please enter an output filename.", 0x30, "Output filename missing");
                }
            }
            else
            {
                MiscFUncs.MsgBox_Renamed("Filename: " + this.lblDateFile.Text + "\rtoo long. May not exceed 64 characters", 0x30, "Filename too long");
            }
        }

        private void Command4_Click(object eventSender, EventArgs eventArgs)
        {
            this.frmAddFile = new CfrmAddFile(ref this.frmMain);
            this.frmAddFile.ShowDialog();
            if ((this.frmAddFile.BinFileName != "") && this.AddFile(ref this.frmAddFile.BinFileName, ref this.frmAddFile))
            {
                this.ShowFiles();
            }
            this.frmAddFile.Close();
        }

        private void Command4_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            this.Label4.Text = "Add new .bin-files to the simulation.";
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

        private void Drive1_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
        {
            // Invalid method body.
        }

        private void frmSetup_Activated(object eventSender, EventArgs eventArgs)
        {
            if (!this.IsInitializing)
            {
                this.SetBounds((int) Math.Round(Support.TwipsToPixelsX((Support.PixelsToTwipsX((double) Screen.PrimaryScreen.Bounds.Width) - Support.PixelsToTwipsX((double) this.Width)) / 2.0)), (int) Math.Round(Support.TwipsToPixelsY((Support.PixelsToTwipsY((double) Screen.PrimaryScreen.Bounds.Height) - Support.PixelsToTwipsY((double) this.Height)) / 2.0)), 0, 0, BoundsSpecified.Location);
                this.Label4.Text = "";
                if (GlobalVariables.sw_averagex == MACROConstants.Switch.BareSoil)
                {
                    this.Option3.Checked = true;
                }
                else if (GlobalVariables.sw_averagex == MACROConstants.Switch.Annual)
                {
                    this.Option4.Checked = true;
                }
                this.ShowFiles();
                if (GlobalVariables.b_DefaultNaming)
                {
                    this.optFileName[0].Checked = true;
                    this.txtOutputFileName.Text = "MACRO";
                }
                else
                {
                    this.optFileName[1].Checked = true;
                    this.txtOutputFileName.Text = GlobalVariables.MACROOutputFile;
                }
                this.lblDateFile.Text = GlobalVariables.DateFile;
                this.chkSpecOut.CheckState = (GlobalVariables.sw_specout != MACROConstants.Switch.BareSoil) ? CheckState.Unchecked : CheckState.Checked;
                this.Text4.Text = Conversions.ToString((int) GlobalVariables.outintd);
                this.Text5.Text = Conversions.ToString((int) GlobalVariables.outintm);
                if ((((MACROConstants.Switch) -(GlobalVariables.sw_metabolite == MACROConstants.Switch.BareSoil)) | GlobalVariables.sw_specout) == ((MACROConstants.Switch) false))
                {
                    this.Text4.Enabled = true;
                    this.Text5.Enabled = true;
                    this.chkSpecOut.Enabled = true;
                }
                else
                {
                    this.Text4.Enabled = false;
                    this.Text5.Enabled = false;
                    if (GlobalVariables.sw_specout == MACROConstants.Switch.NoMetabolite)
                    {
                        this.chkSpecOut.Enabled = false;
                    }
                }
            }
        }

        private void frmSetup_Load(object eventSender, EventArgs eventArgs)
        {
            this.flx_sim.set_ColWidth(0, 0xe10);
            this.flx_sim.set_ColWidth(1, 0x9c4);
            this.flx_sim.set_ColWidth(2, 0x1388);
            this.flx_sim.set_TextMatrix(0, 0, "Path and filename");
            this.flx_sim.set_TextMatrix(0, 1, "Type of data");
            this.flx_sim.set_TextMatrix(0, 2, "Period");
            this.flx_sim.set_ColWidth(0, 0x4b0);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CfrmSetup));
            this.Frame6 = new GroupBox();
            this.txtOutputFileName = new TextBox();
            this._optFileName_1 = new RadioButton();
            this._optFileName_0 = new RadioButton();
            this.Drive1 = new DriveListBox();
            this.Dir1 = new DirListBox();
            this.Label7 = new Label();
            this.Command2 = new Button();
            this.Frame9 = new GroupBox();
            this.flx_sim = new AxMSFlexGrid();
            this.Frame4 = new GroupBox();
            this.Label4 = new Label();
            this.Frame7 = new GroupBox();
            this.dtEndDate = new DateTimePicker();
            this.dtStartDate = new DateTimePicker();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Frame5 = new GroupBox();
            this.cmdBrowseDateFile = new Button();
            this.chkSpecOut = new CheckBox();
            this.Option4 = new RadioButton();
            this.Option3 = new RadioButton();
            this.Text5 = new TextBox();
            this.Text4 = new TextBox();
            this.lblDateFile = new Label();
            this.Label6 = new Label();
            this.Label5 = new Label();
            this.Label1 = new Label();
            this.Label28 = new Label();
            this.Command1 = new Button();
            this.Command4 = new Button();
            this.optFileName = new RadioButtonArray(this.components);
            this.Frame6.SuspendLayout();
            this.Frame9.SuspendLayout();
            this.flx_sim.BeginInit();
            this.Frame4.SuspendLayout();
            this.Frame7.SuspendLayout();
            this.Frame5.SuspendLayout();
            ((ISupportInitialize) this.optFileName).BeginInit();
            this.SuspendLayout();
            this.Frame6.BackColor = SystemColors.Control;
            this.Frame6.Controls.Add(this.txtOutputFileName);
            this.Frame6.Controls.Add(this._optFileName_1);
            this.Frame6.Controls.Add(this._optFileName_0);
            this.Frame6.Controls.Add(this.Drive1);
            this.Frame6.Controls.Add(this.Dir1);
            this.Frame6.Controls.Add(this.Label7);
            this.Frame6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame6.ForeColor = SystemColors.ControlText;
            Point point = new Point(0x188, 0xe8);
            this.Frame6.Location = point;
            this.Frame6.Name = "Frame6";
            this.Frame6.RightToLeft = RightToLeft.No;
            Size size = new Size(0x141, 0xa9);
            this.Frame6.Size = size;
            this.Frame6.TabIndex = 0x13;
            this.Frame6.TabStop = false;
            this.Frame6.Text = "Output files directory";
            this.txtOutputFileName.AcceptsReturn = true;
            this.txtOutputFileName.BackColor = SystemColors.Window;
            this.txtOutputFileName.Cursor = Cursors.IBeam;
            this.txtOutputFileName.Enabled = false;
            this.txtOutputFileName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtOutputFileName.ForeColor = SystemColors.WindowText;
            point = new Point(0x38, 0x58);
            this.txtOutputFileName.Location = point;
            this.txtOutputFileName.MaxLength = 0;
            this.txtOutputFileName.Name = "txtOutputFileName";
            this.txtOutputFileName.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 20);
            this.txtOutputFileName.Size = size;
            this.txtOutputFileName.TabIndex = 0x1a;
            this.txtOutputFileName.Text = "MACRO";
            this._optFileName_1.BackColor = SystemColors.Control;
            this._optFileName_1.Cursor = Cursors.Default;
            this._optFileName_1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optFileName_1.ForeColor = SystemColors.ControlText;
            this.optFileName.SetIndex(this._optFileName_1, 1);
            point = new Point(8, 0x58);
            this._optFileName_1.Location = point;
            this._optFileName_1.Name = "_optFileName_1";
            this._optFileName_1.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this._optFileName_1.Size = size;
            this._optFileName_1.TabIndex = 0x19;
            this._optFileName_1.TabStop = true;
            this._optFileName_1.Text = "Other:";
            this._optFileName_1.UseVisualStyleBackColor = false;
            this._optFileName_0.BackColor = SystemColors.Control;
            this._optFileName_0.Checked = true;
            this._optFileName_0.Cursor = Cursors.Default;
            this._optFileName_0.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this._optFileName_0.ForeColor = SystemColors.ControlText;
            this.optFileName.SetIndex(this._optFileName_0, 0);
            point = new Point(8, 0x40);
            this._optFileName_0.Location = point;
            this._optFileName_0.Name = "_optFileName_0";
            this._optFileName_0.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x11);
            this._optFileName_0.Size = size;
            this._optFileName_0.TabIndex = 0x18;
            this._optFileName_0.TabStop = true;
            this._optFileName_0.Text = "MACRO + [ID]";
            this._optFileName_0.UseVisualStyleBackColor = false;
            this.Drive1.BackColor = SystemColors.Window;
            this.Drive1.Cursor = Cursors.Default;
            this.Drive1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Drive1.ForeColor = SystemColors.WindowText;
            this.Drive1.FormattingEnabled = true;
            point = new Point(8, 0x10);
            this.Drive1.Location = point;
            this.Drive1.Name = "Drive1";
            size = new Size(0x81, 0x15);
            this.Drive1.Size = size;
            this.Drive1.TabIndex = 0x15;
            this.Dir1.BackColor = SystemColors.Window;
            this.Dir1.Cursor = Cursors.Default;
            this.Dir1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Dir1.ForeColor = SystemColors.WindowText;
            this.Dir1.FormattingEnabled = true;
            this.Dir1.IntegralHeight = false;
            point = new Point(0x90, 0x10);
            this.Dir1.Location = point;
            this.Dir1.Name = "Dir1";
            size = new Size(0xa9, 0x8d);
            this.Dir1.Size = size;
            this.Dir1.TabIndex = 20;
            this.Label7.BackColor = SystemColors.Control;
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x30);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 0x1b;
            this.Label7.Text = "Output file name:";
            this.Command2.BackColor = SystemColors.Control;
            this.Command2.Cursor = Cursors.Default;
            this.Command2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command2.ForeColor = SystemColors.ControlText;
            point = new Point(280, 0x198);
            this.Command2.Location = point;
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command2.Size = size;
            this.Command2.TabIndex = 0x12;
            this.Command2.Text = "&Convert";
            this.Command2.UseVisualStyleBackColor = false;
            this.Command2.Visible = false;
            this.Frame9.BackColor = SystemColors.Control;
            this.Frame9.Controls.Add(this.flx_sim);
            this.Frame9.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame9.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0);
            this.Frame9.Location = point;
            this.Frame9.Name = "Frame9";
            this.Frame9.RightToLeft = RightToLeft.No;
            size = new Size(0x2c1, 0x99);
            this.Frame9.Size = size;
            this.Frame9.TabIndex = 0x10;
            this.Frame9.TabStop = false;
            this.Frame9.Text = "Driving data files :";
            point = new Point(8, 0x10);
            this.flx_sim.Location = point;
            this.flx_sim.Name = "flx_sim";
            this.flx_sim.OcxState = (AxHost.State) manager.GetObject("flx_sim.OcxState");
            size = new Size(0x2b1, 0x81);
            this.flx_sim.Size = size;
            this.flx_sim.TabIndex = 0x11;
            this.Frame4.BackColor = SystemColors.Control;
            this.Frame4.Controls.Add(this.Label4);
            this.Frame4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x130);
            this.Frame4.Location = point;
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = RightToLeft.No;
            size = new Size(0x179, 0x61);
            this.Frame4.Size = size;
            this.Frame4.TabIndex = 2;
            this.Frame4.TabStop = false;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.BorderStyle = BorderStyle.Fixed3D;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x169, 0x41);
            this.Label4.Size = size;
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Label4";
            this.Frame7.BackColor = SystemColors.Control;
            this.Frame7.Controls.Add(this.dtEndDate);
            this.Frame7.Controls.Add(this.dtStartDate);
            this.Frame7.Controls.Add(this.Label3);
            this.Frame7.Controls.Add(this.Label2);
            this.Frame7.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame7.ForeColor = SystemColors.ControlText;
            point = new Point(0x188, 160);
            this.Frame7.Location = point;
            this.Frame7.Name = "Frame7";
            this.Frame7.RightToLeft = RightToLeft.No;
            size = new Size(0x141, 0x41);
            this.Frame7.Size = size;
            this.Frame7.TabIndex = 11;
            this.Frame7.TabStop = false;
            this.dtEndDate.CustomFormat = "yyyy:MM:dd HH:mm";
            this.dtEndDate.Format = DateTimePickerFormat.Custom;
            point = new Point(0xa8, 30);
            this.dtEndDate.Location = point;
            this.dtEndDate.Name = "dtEndDate";
            size = new Size(0x8f, 20);
            this.dtEndDate.Size = size;
            this.dtEndDate.TabIndex = 0x18;
            this.dtStartDate.CustomFormat = "yyyy:MM:dd HH:mm";
            this.dtStartDate.Format = DateTimePickerFormat.Custom;
            point = new Point(11, 30);
            this.dtStartDate.Location = point;
            this.dtStartDate.Name = "dtStartDate";
            size = new Size(0x97, 20);
            this.dtStartDate.Size = size;
            this.dtStartDate.TabIndex = 0x17;
            this.Label3.BackColor = SystemColors.Control;
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.ControlText;
            point = new Point(0xa8, 0x10);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 13;
            this.Label3.Text = "END DATE";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x51, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 12;
            this.Label2.Text = "START DATE";
            this.Frame5.BackColor = SystemColors.Control;
            this.Frame5.Controls.Add(this.cmdBrowseDateFile);
            this.Frame5.Controls.Add(this.chkSpecOut);
            this.Frame5.Controls.Add(this.Option4);
            this.Frame5.Controls.Add(this.Option3);
            this.Frame5.Controls.Add(this.Text5);
            this.Frame5.Controls.Add(this.Text4);
            this.Frame5.Controls.Add(this.lblDateFile);
            this.Frame5.Controls.Add(this.Label6);
            this.Frame5.Controls.Add(this.Label5);
            this.Frame5.Controls.Add(this.Label1);
            this.Frame5.Controls.Add(this.Label28);
            this.Frame5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 160);
            this.Frame5.Location = point;
            this.Frame5.Name = "Frame5";
            this.Frame5.RightToLeft = RightToLeft.No;
            size = new Size(0x179, 0x89);
            this.Frame5.Size = size;
            this.Frame5.TabIndex = 4;
            this.Frame5.TabStop = false;
            this.cmdBrowseDateFile.BackColor = SystemColors.Control;
            this.cmdBrowseDateFile.Cursor = Cursors.Default;
            this.cmdBrowseDateFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdBrowseDateFile.ForeColor = SystemColors.ControlText;
            point = new Point(0x158, 0x68);
            this.cmdBrowseDateFile.Location = point;
            this.cmdBrowseDateFile.Name = "cmdBrowseDateFile";
            this.cmdBrowseDateFile.RightToLeft = RightToLeft.No;
            size = new Size(0x11, 0x11);
            this.cmdBrowseDateFile.Size = size;
            this.cmdBrowseDateFile.TabIndex = 30;
            this.cmdBrowseDateFile.Text = "...";
            this.cmdBrowseDateFile.UseVisualStyleBackColor = false;
            this.chkSpecOut.BackColor = SystemColors.Control;
            this.chkSpecOut.Cursor = Cursors.Default;
            this.chkSpecOut.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.chkSpecOut.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 80);
            this.chkSpecOut.Location = point;
            this.chkSpecOut.Name = "chkSpecOut";
            this.chkSpecOut.RightToLeft = RightToLeft.No;
            size = new Size(0xa1, 0x11);
            this.chkSpecOut.Size = size;
            this.chkSpecOut.TabIndex = 0x1c;
            this.chkSpecOut.Text = "user-specified dates in file:";
            this.chkSpecOut.UseVisualStyleBackColor = false;
            this.Option4.BackColor = SystemColors.Control;
            this.Option4.Cursor = Cursors.Default;
            this.Option4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Option4.ForeColor = SystemColors.ControlText;
            point = new Point(0x98, 0x20);
            this.Option4.Location = point;
            this.Option4.Name = "Option4";
            this.Option4.RightToLeft = RightToLeft.No;
            size = new Size(0x99, 0x11);
            this.Option4.Size = size;
            this.Option4.TabIndex = 15;
            this.Option4.TabStop = true;
            this.Option4.Text = "Average for period";
            this.Option4.UseVisualStyleBackColor = false;
            this.Option3.BackColor = SystemColors.Control;
            this.Option3.Cursor = Cursors.Default;
            this.Option3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Option3.ForeColor = SystemColors.ControlText;
            point = new Point(0x98, 0x38);
            this.Option3.Location = point;
            this.Option3.Name = "Option3";
            this.Option3.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 0x11);
            this.Option3.Size = size;
            this.Option3.TabIndex = 14;
            this.Option3.TabStop = true;
            this.Option3.Text = "Current value";
            this.Option3.UseVisualStyleBackColor = false;
            this.Text5.AcceptsReturn = true;
            this.Text5.BackColor = SystemColors.Window;
            this.Text5.Cursor = Cursors.IBeam;
            this.Text5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text5.ForeColor = SystemColors.WindowText;
            point = new Point(0x40, 0x30);
            this.Text5.Location = point;
            this.Text5.MaxLength = 0;
            this.Text5.Name = "Text5";
            this.Text5.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 20);
            this.Text5.Size = size;
            this.Text5.TabIndex = 7;
            this.Text5.Text = "Text5";
            this.Text4.AcceptsReturn = true;
            this.Text4.BackColor = SystemColors.Window;
            this.Text4.Cursor = Cursors.IBeam;
            this.Text4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text4.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0x30);
            this.Text4.Location = point;
            this.Text4.MaxLength = 0;
            this.Text4.Name = "Text4";
            this.Text4.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 20);
            this.Text4.Size = size;
            this.Text4.TabIndex = 6;
            this.Text4.Text = "Text4";
            this.lblDateFile.BackColor = SystemColors.InactiveBorder;
            this.lblDateFile.BorderStyle = BorderStyle.FixedSingle;
            this.lblDateFile.Cursor = Cursors.Default;
            this.lblDateFile.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblDateFile.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0x68);
            this.lblDateFile.Location = point;
            this.lblDateFile.Name = "lblDateFile";
            this.lblDateFile.RightToLeft = RightToLeft.No;
            size = new Size(0x149, 0x11);
            this.lblDateFile.Size = size;
            this.lblDateFile.TabIndex = 0x1d;
            this.Label6.BackColor = SystemColors.Control;
            this.Label6.Cursor = Cursors.Default;
            this.Label6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label6.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x10);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = RightToLeft.No;
            size = new Size(0x59, 0x11);
            this.Label6.Size = size;
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Output interval:";
            this.Label5.BackColor = SystemColors.Control;
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(0x40, 0x20);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0x29, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Minutes";
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(0x10, 0x20);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Days";
            this.Label28.BackColor = SystemColors.Control;
            this.Label28.Cursor = Cursors.Default;
            this.Label28.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label28.ForeColor = SystemColors.ControlText;
            point = new Point(0x88, 0x10);
            this.Label28.Location = point;
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = RightToLeft.No;
            size = new Size(0x81, 0x11);
            this.Label28.Size = size;
            this.Label28.TabIndex = 5;
            this.Label28.Text = "Representation of output:";
            this.Command1.BackColor = SystemColors.Control;
            this.Command1.Cursor = Cursors.Default;
            this.Command1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command1.ForeColor = SystemColors.ControlText;
            point = new Point(640, 0x198);
            this.Command1.Location = point;
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command1.Size = size;
            this.Command1.TabIndex = 0;
            this.Command1.Text = "&OK";
            this.Command1.UseVisualStyleBackColor = false;
            this.Command4.BackColor = SystemColors.Control;
            this.Command4.Cursor = Cursors.Default;
            this.Command4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command4.ForeColor = SystemColors.ControlText;
            point = new Point(560, 0x198);
            this.Command4.Location = point;
            this.Command4.Name = "Command4";
            this.Command4.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command4.Size = size;
            this.Command4.TabIndex = 1;
            this.Command4.Text = "&Add file(s)";
            this.Command4.UseVisualStyleBackColor = false;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x2cb, 0x1ba);
            this.ClientSize = size;
            this.Controls.Add(this.Frame6);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Frame9);
            this.Controls.Add(this.Frame4);
            this.Controls.Add(this.Frame7);
            this.Controls.Add(this.Frame5);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.Command4);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            point = new Point(0x54, 0x30);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmSetup";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "Simulation set-up";
            this.Frame6.ResumeLayout(false);
            this.Frame6.PerformLayout();
            this.Frame9.ResumeLayout(false);
            this.flx_sim.EndInit();
            this.Frame4.ResumeLayout(false);
            this.Frame7.ResumeLayout(false);
            this.Frame5.ResumeLayout(false);
            this.Frame5.PerformLayout();
            ((ISupportInitialize) this.optFileName).EndInit();
            this.ResumeLayout(false);
        }

        private void Label28_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            if (this.Frame4.Visible)
            {
                this.Label4.Text = "";
            }
        }

        private void Option3_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            this.Frame4.Visible = true;
            this.Label4.Text = "Values of all output variables represent the current value\rat the end of each output interval";
        }

        private void Option4_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            this.Frame4.Visible = true;
            this.Label4.Text = "Values of output variables represent mean values for each output interval.\rThe time in the output file will be the time in the middle of the output interval.";
        }

        public void ShowFiles()
        {
            short num = 1;
            while (true)
            {
                this.flx_sim.Row = num;
                short num2 = 0;
                while (true)
                {
                    this.flx_sim.Col = num2;
                    this.flx_sim.CellBackColor = ColorTranslator.FromOle(Information.QBColor(8));
                    this.flx_sim.Text = "";
                    num2 = (short) (num2 + 1);
                    short num3 = 2;
                    if (num2 > num3)
                    {
                        num = (short) (num + 1);
                        if (num <= 5)
                        {
                            break;
                        }
                        if (GlobalVariables.sw_specout == MACROConstants.Switch.BareSoil)
                        {
                            this.chkSpecOut.CheckState = CheckState.Checked;
                        }
                        if (this.chkSpecOut.CheckState == CheckState.Checked)
                        {
                            this.Text4.Enabled = false;
                            this.Text5.Enabled = false;
                            this.cmdBrowseDateFile.Enabled = true;
                            this.lblDateFile.BackColor = Color.White;
                            this.lblDateFile.Text = GlobalVariables.DateFile;
                        }
                        else
                        {
                            this.Text4.Enabled = true;
                            this.Text5.Enabled = true;
                            this.cmdBrowseDateFile.Enabled = false;
                            this.lblDateFile.BackColor = SystemColors.InactiveBorder;
                            this.lblDateFile.Text = " ";
                        }
                        this.flx_sim.set_TextMatrix(1, 1, "Daily rainfall");
                        this.flx_sim.set_TextMatrix(2, 1, "Hourly rainfall");
                        this.flx_sim.set_TextMatrix(3, 1, "Meterological data");
                        this.flx_sim.set_TextMatrix(4, 1, "Evapotranspiration and temperature");
                        this.flx_sim.set_TextMatrix(5, 1, "Pesticide metabolite");
                        if (GlobalVariables.sw_rainfall == MACROConstants.Switch.BareSoil)
                        {
                            this.flx_sim.set_TextMatrix(1, 0, GlobalVariables.Rainfall_file);
                            this.flx_sim.set_TextMatrix(1, 2, GlobalVariables.RainfallPeriod);
                            this.flx_sim.Row = 1;
                            num2 = 0;
                            do
                            {
                                this.flx_sim.Col = num2;
                                this.flx_sim.CellBackColor = ColorTranslator.FromOle(Information.QBColor(15));
                                num2 = (short) (num2 + 1);
                                num3 = 2;
                            }
                            while (num2 <= num3);
                        }
                        if (GlobalVariables.sw_rainfall == MACROConstants.Switch.Annual)
                        {
                            this.flx_sim.set_TextMatrix(2, 0, GlobalVariables.Rainfall_file);
                            this.flx_sim.set_TextMatrix(2, 2, GlobalVariables.RainfallPeriod);
                            this.flx_sim.Row = 2;
                            num2 = 0;
                            do
                            {
                                this.flx_sim.Col = num2;
                                this.flx_sim.CellBackColor = ColorTranslator.FromOle(Information.QBColor(15));
                                num2 = (short) (num2 + 1);
                                num3 = 2;
                            }
                            while (num2 <= num3);
                        }
                        if (GlobalVariables.sw_evaporate == MACROConstants.Switch.Annual)
                        {
                            this.flx_sim.set_TextMatrix(3, 0, GlobalVariables.Met_file);
                            this.flx_sim.set_TextMatrix(3, 2, GlobalVariables.MetPeriod);
                            this.flx_sim.Row = 3;
                            num2 = 0;
                            do
                            {
                                this.flx_sim.Col = num2;
                                this.flx_sim.CellBackColor = ColorTranslator.FromOle(Information.QBColor(15));
                                num2 = (short) (num2 + 1);
                                num3 = 2;
                            }
                            while (num2 <= num3);
                        }
                        if (GlobalVariables.sw_evaporate == MACROConstants.Switch.BareSoil)
                        {
                            this.flx_sim.set_TextMatrix(4, 0, GlobalVariables.Met_file);
                            this.flx_sim.set_TextMatrix(4, 2, GlobalVariables.MetPeriod);
                            this.flx_sim.Row = 4;
                            num2 = 0;
                            do
                            {
                                this.flx_sim.Col = num2;
                                this.flx_sim.CellBackColor = ColorTranslator.FromOle(Information.QBColor(15));
                                num2 = (short) (num2 + 1);
                                num3 = 2;
                            }
                            while (num2 <= num3);
                        }
                        if ((GlobalVariables.sw_metabolite == MACROConstants.Switch.NoMetabolite) & (GlobalVariables.sw_driving == MACROConstants.Switch.BareSoil))
                        {
                            this.flx_sim.set_TextMatrix(5, 0, GlobalVariables.Driving_file);
                            this.flx_sim.set_TextMatrix(5, 2, GlobalVariables.DrivingPeriod);
                            this.flx_sim.Row = 5;
                            num2 = 0;
                            do
                            {
                                this.flx_sim.Col = num2;
                                this.flx_sim.CellBackColor = ColorTranslator.FromOle(Information.QBColor(15));
                                num2 = (short) (num2 + 1);
                                num3 = 2;
                            }
                            while (num2 <= num3);
                        }
                        if ((GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite) & (GlobalVariables.sw_driving == MACROConstants.Switch.Annual))
                        {
                            this.flx_sim.set_TextMatrix(6, 0, GlobalVariables.Driving_file);
                            this.flx_sim.set_TextMatrix(6, 2, GlobalVariables.DrivingPeriod);
                            this.flx_sim.Row = 6;
                            num2 = 0;
                            do
                            {
                                this.flx_sim.Col = num2;
                                this.flx_sim.CellBackColor = ColorTranslator.FromOle(Information.QBColor(15));
                                num2 = (short) (num2 + 1);
                                num3 = 2;
                            }
                            while (num2 <= num3);
                        }
                        return;
                    }
                }
            }
        }

        private void Text4_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            this.Frame4.Visible = true;
            this.Label4.Text = "Output interval (days)";
        }

        private void Text5_MouseMove(object eventSender, MouseEventArgs eventArgs)
        {
            short num = (short) (eventArgs.Button / MouseButtons.Left);
            short num2 = (short) (Control.ModifierKeys / Keys.Shift);
            float num3 = (float) Support.PixelsToTwipsX((double) eventArgs.X);
            float num4 = (float) Support.PixelsToTwipsY((double) eventArgs.Y);
            this.Frame4.Visible = true;
            this.Label4.Text = "Output interval (minutes)";
        }

        public virtual TextBox txtOutputFileName
        {
            [DebuggerNonUserCode]
            get => 
                this._txtOutputFileName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtOutputFileName = value;
        }

        public virtual RadioButton _optFileName_1
        {
            [DebuggerNonUserCode]
            get => 
                this.__optFileName_1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this._optFileName_1_CheckedChanged);
                if (!ReferenceEquals(this.__optFileName_1, null))
                {
                    this.__optFileName_1.CheckedChanged -= handler;
                }
                this.__optFileName_1 = value;
                if (!ReferenceEquals(this.__optFileName_1, null))
                {
                    this.__optFileName_1.CheckedChanged += handler;
                }
            }
        }

        public virtual RadioButton _optFileName_0
        {
            [DebuggerNonUserCode]
            get => 
                this.__optFileName_0;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this.__optFileName_0 = value;
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

        public virtual DirListBox Dir1
        {
            [DebuggerNonUserCode]
            get => 
                this._Dir1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Dir1 = value;
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

        public virtual GroupBox Frame6
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame6 = value;
        }

        public virtual Button Command2
        {
            [DebuggerNonUserCode]
            get => 
                this._Command2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Command2 = value;
        }

        public virtual AxMSFlexGrid flx_sim
        {
            [DebuggerNonUserCode]
            get => 
                this._flx_sim;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._flx_sim = value;
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

        public virtual Label Label4
        {
            [DebuggerNonUserCode]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label4 = value;
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

        public virtual GroupBox Frame7
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame7 = value;
        }

        public virtual Button cmdBrowseDateFile
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdBrowseDateFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdBrowseDateFile_Click);
                if (!ReferenceEquals(this._cmdBrowseDateFile, null))
                {
                    this._cmdBrowseDateFile.Click -= handler;
                }
                this._cmdBrowseDateFile = value;
                if (!ReferenceEquals(this._cmdBrowseDateFile, null))
                {
                    this._cmdBrowseDateFile.Click += handler;
                }
            }
        }

        public virtual CheckBox chkSpecOut
        {
            [DebuggerNonUserCode]
            get => 
                this._chkSpecOut;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.chkSpecOut_MouseMove);
                EventHandler handler2 = new EventHandler(this.chkSpecOut_CheckStateChanged);
                if (!ReferenceEquals(this._chkSpecOut, null))
                {
                    this._chkSpecOut.MouseMove -= handler;
                    this._chkSpecOut.CheckStateChanged -= handler2;
                }
                this._chkSpecOut = value;
                if (!ReferenceEquals(this._chkSpecOut, null))
                {
                    this._chkSpecOut.MouseMove += handler;
                    this._chkSpecOut.CheckStateChanged += handler2;
                }
            }
        }

        public virtual RadioButton Option4
        {
            [DebuggerNonUserCode]
            get => 
                this._Option4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Option4_MouseMove);
                if (!ReferenceEquals(this._Option4, null))
                {
                    this._Option4.MouseMove -= handler;
                }
                this._Option4 = value;
                if (!ReferenceEquals(this._Option4, null))
                {
                    this._Option4.MouseMove += handler;
                }
            }
        }

        public virtual RadioButton Option3
        {
            [DebuggerNonUserCode]
            get => 
                this._Option3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Option3_MouseMove);
                if (!ReferenceEquals(this._Option3, null))
                {
                    this._Option3.MouseMove -= handler;
                }
                this._Option3 = value;
                if (!ReferenceEquals(this._Option3, null))
                {
                    this._Option3.MouseMove += handler;
                }
            }
        }

        public virtual TextBox Text5
        {
            [DebuggerNonUserCode]
            get => 
                this._Text5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Text5_MouseMove);
                if (!ReferenceEquals(this._Text5, null))
                {
                    this._Text5.MouseMove -= handler;
                }
                this._Text5 = value;
                if (!ReferenceEquals(this._Text5, null))
                {
                    this._Text5.MouseMove += handler;
                }
            }
        }

        public virtual TextBox Text4
        {
            [DebuggerNonUserCode]
            get => 
                this._Text4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Text4_MouseMove);
                if (!ReferenceEquals(this._Text4, null))
                {
                    this._Text4.MouseMove -= handler;
                }
                this._Text4 = value;
                if (!ReferenceEquals(this._Text4, null))
                {
                    this._Text4.MouseMove += handler;
                }
            }
        }

        public virtual Label lblDateFile
        {
            [DebuggerNonUserCode]
            get => 
                this._lblDateFile;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblDateFile = value;
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

        public virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label1 = value;
        }

        public virtual Label Label28
        {
            [DebuggerNonUserCode]
            get => 
                this._Label28;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Label28_MouseMove);
                if (!ReferenceEquals(this._Label28, null))
                {
                    this._Label28.MouseMove -= handler;
                }
                this._Label28 = value;
                if (!ReferenceEquals(this._Label28, null))
                {
                    this._Label28.MouseMove += handler;
                }
            }
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

        public virtual Button Command4
        {
            [DebuggerNonUserCode]
            get => 
                this._Command4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.Command4_MouseMove);
                EventHandler handler2 = new EventHandler(this.Command4_Click);
                if (!ReferenceEquals(this._Command4, null))
                {
                    this._Command4.MouseMove -= handler;
                    this._Command4.Click -= handler2;
                }
                this._Command4 = value;
                if (!ReferenceEquals(this._Command4, null))
                {
                    this._Command4.MouseMove += handler;
                    this._Command4.Click += handler2;
                }
            }
        }

        public virtual RadioButtonArray optFileName
        {
            [DebuggerNonUserCode]
            get => 
                this._optFileName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optFileName = value;
        }

        internal virtual DateTimePicker dtStartDate
        {
            [DebuggerNonUserCode]
            get => 
                this._dtStartDate;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dtStartDate = value;
        }

        internal virtual DateTimePicker dtEndDate
        {
            [DebuggerNonUserCode]
            get => 
                this._dtEndDate;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dtEndDate = value;
        }
    }
}

