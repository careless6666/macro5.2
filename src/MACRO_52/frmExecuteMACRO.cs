namespace MACRO_52
{
    using ADODB;
    using AxComctlLib;
    using MACRO_52.My;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using Microsoft.VisualBasic.FileIO;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class frmExecuteMACRO : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Timer2")]
        private System.Windows.Forms.Timer _Timer2;
        [AccessedThroughProperty("lstSimulations")]
        private ListBox _lstSimulations;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("lblTotNoSims")]
        private Label _lblTotNoSims;
        [AccessedThroughProperty("lblOutOf")]
        private Label _lblOutOf;
        [AccessedThroughProperty("lblNoSimsDone")]
        private Label _lblNoSimsDone;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("fraBatch")]
        private GroupBox _fraBatch;
        [AccessedThroughProperty("lblRunName")]
        private Label _lblRunName;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("Timer1")]
        private System.Windows.Forms.Timer _Timer1;
        [AccessedThroughProperty("ProgressBar1")]
        private AxProgressBar _ProgressBar1;
        [AccessedThroughProperty("lblAction")]
        private Label _lblAction;
        [AccessedThroughProperty("Frame1")]
        private Panel _Frame1;
        [AccessedThroughProperty("dtDate")]
        private DateTimePicker _dtDate;
        private double filesize;
        private double PrevSize;
        public bool m_SUFI;
        public bool m_Batch;
        public bool m_Exe;
        public bool m_ParVar;
        private string Before;
        private string after;
        private bool m_bCrash;
        private string[] m_ErrMsg;
        private string beforebatch;
        public bool m_Error;
        private CfrmMain frmMain;
        private Recordset rec;
        private const int SC_CLOSE = 0xf060;
        private const short WM_SYSCOMMAND = 0x112;
        private const int PROCESS_ALL_ACCESS = 0x1f0fff;
        private const short GW_HWNDFIRST = 0;
        private const short GW_HWNDNEXT = 2;
        private bool $STATIC$Dispose$20112$fTerminateCalled;

        public frmExecuteMACRO(ref CfrmMain frm)
        {
            base.Activated += new EventHandler(this.frmExecuteMACRO_Activated);
            base.Load += new EventHandler(this.frmExecuteMACRO_Load);
            base.FormClosed += new FormClosedEventHandler(this.frmExecuteMACRO_FormClosed);
            base.Disposed += new EventHandler(this.frmExecuteMACRO_Disposed);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.m_ErrMsg = new string[3];
            this.rec = new RecordsetClass();
            this.frmMain = frm;
            this.InitializeComponent();
            this.Timer1.Interval = 0x7d0;
        }

        private void BackupOutputFile(string path, string fname)
        {
            if (MiscFUncs.FileExists(path + fname))
            {
                FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(path + fname);
                MiscFUncs.RenameFile(ref path + fname, ref path + Strings.Replace(Conversions.ToString(fileInfo.LastWriteTime), ":", "_", 1, -1, CompareMethod.Binary) + " " + fname);
            }
        }

        private bool CheckCrash()
        {
            bool flag;
            string str = "";
            if (MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\macro_log.txt") | MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\macro.err"))
            {
                flag = true;
                this.Timer1.Enabled = false;
                short fileNumber = (short) Microsoft.VisualBasic.FileSystem.FreeFile();
                Microsoft.VisualBasic.FileSystem.FileOpen(fileNumber, MyProject.Application.Info.DirectoryPath + @"\macro_log.txt", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);
                Microsoft.VisualBasic.FileSystem.Input(fileNumber, ref str);
                this.m_ErrMsg[1] = str;
                Microsoft.VisualBasic.FileSystem.Input(fileNumber, ref str);
                this.m_ErrMsg[2] = str;
                Microsoft.VisualBasic.FileSystem.FileClose(new int[] { fileNumber });
                try
                {
                    Interaction.Shell("taskkill /PID " + Conversions.ToString(GlobalVariables.ExeId) + " /F", AppWinStyle.Hide, false, -1);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    ProjectData.ClearProjectError();
                }
                this.m_bCrash = true;
                if (this.m_bCrash & !this.m_ParVar)
                {
                    MiscFUncs.MsgBox_Renamed("Simulation ended unsuccessfully:\r" + this.m_ErrMsg[1] + "\rAt time: " + this.m_ErrMsg[2] + "\rIf the problem persists, contact the developer.", 0x10, "Error");
                    this.DeleteLogFile();
                }
                else if (this.m_bCrash & this.m_ParVar)
                {
                    this.LogError(ref MyProject.Application.Info.DirectoryPath + @"\parvar.log", ref this.m_ErrMsg);
                    this.DeleteLogFile();
                    this.lblNoSimsDone.Text = Conversions.ToString((double) (Conversions.ToDouble(this.lblNoSimsDone.Text) + 1.0));
                    this.frmMain.frmExeParWizard.NextSimulation();
                    this.m_bCrash = false;
                }
            }
            return flag;
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int CloseHandle(int hObject);
        public void CloseWindowByHwnd(int hwnd)
        {
            SendMessageTimeout(hwnd, 0x112, 0xf060, 0, 0, 500, ref 0);
            if (IsWindow(hwnd) != 0)
            {
                int num2;
                GetWindowThreadProcessId(hwnd, ref num2);
                int hProcess = OpenProcess(0x1f0fff, 0, num2);
                TerminateProcess(hProcess, 0);
                CloseHandle(hProcess);
            }
        }

        private void DeleteFiles(string tmp)
        {
            this.BackupOutputFile(GlobalVariables.OutputPath, "macro" + tmp + ".bin");
            this.BackupOutputFile(GlobalVariables.OutputPath, GlobalVariables.OutputFileName);
            if (MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\run_time.txt"))
            {
                MiscFUncs.DeleteFile(ref MyProject.Application.Info.DirectoryPath + @"\run_time.txt");
            }
            if (MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\end.txt"))
            {
                MiscFUncs.DeleteFile(ref MyProject.Application.Info.DirectoryPath + @"\end.txt");
            }
            if (MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\macro.sta"))
            {
                MiscFUncs.DeleteFile(ref MyProject.Application.Info.DirectoryPath + @"\macro.sta");
            }
        }

        private void DeleteLogFile()
        {
            object obj2 = Interaction.CreateObject("Scripting.FileSystemObject", "");
            if (MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\macro_log.txt"))
            {
                MyProject.Computer.FileSystem.DeleteFile(MyProject.Application.Info.DirectoryPath + @"\macro_log.txt", UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
            }
            if (MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\macro.err"))
            {
                MyProject.Computer.FileSystem.DeleteFile(MyProject.Application.Info.DirectoryPath + @"\macro.err", UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
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

        public void ExecuteBatch()
        {
            this.beforebatch = Conversions.ToString(DateAndTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay);
            Connection activeConnection = new ConnectionClass();
            activeConnection.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False", "", "", -1);
            this.rec.Open("select * from [Run_ID] where [batch]=-1", activeConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            int num2 = ReadSaveFunctions.RecordCount(ref this.rec);
            if (num2 <= 0)
            {
                this.Hide();
                this.frmMain.Show();
            }
            else
            {
                int num3 = num2;
                int num = 1;
                while (true)
                {
                    int num5 = num3;
                    if (num > num5)
                    {
                        this.rec.MoveFirst();
                        this.lblRunName.Text = Conversions.ToString(this.rec[]["Run_name"][]);
                        GlobalVariables.IDExecute = Conversions.ToInteger(this.rec[]["R_ID"][]);
                        this.lstSimulations.Items.RemoveAt(0);
                        this.ExecuteSimulation(ref 0);
                        break;
                    }
                    this.lstSimulations.Items.Add(this.rec[]["Run_name"][]);
                    this.rec.MoveNext();
                    num++;
                }
            }
        }

        public void ExecuteSimulation(ref short ShowMessage = 0)
        {
            // Invalid method body.
        }

        private void Form_Terminate_Renamed()
        {
            this.Timer1.Enabled = false;
            this.Timer2.Enabled = false;
            try
            {
                if (this.GetWindowHandle(ref GlobalVariables.ExeId, ref 1) != 0)
                {
                    this.CloseWindowByHwnd(this.GetWindowHandle(ref GlobalVariables.ExeId, ref 1));
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
            }
            try
            {
                Recordset recordset = new RecordsetClass();
                if (this.m_SUFI)
                {
                    recordset.Open("select * from SUFIStrataCombinations where IterationID=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentIterationID) + " AND StrataComboNo=" + Conversions.ToString(this.frmMain.frmSUFIMain.CurrentStrataComboNo), this.frmMain.frmSUFIMain.SUFIDatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    recordset[]["CheckedOut"][] = 0;
                    recordset.Update(Missing.Value, Missing.Value);
                    recordset.Close();
                }
            }
            catch (Exception exception2)
            {
                ProjectData.SetProjectError(exception2);
                if (this.m_SUFI)
                {
                    this.frmMain.frmSUFIMain.Show();
                }
                else
                {
                    this.frmMain.Show();
                }
                ProjectData.ClearProjectError();
            }
        }

        public void frmExecuteMACRO_Activated(object eventSender, EventArgs eventArgs)
        {
            if (!this.m_Exe)
            {
                this.RunSimulations();
            }
            this.Refresh();
        }

        private void frmExecuteMACRO_Disposed(object sender, EventArgs e)
        {
            this.Timer1.Enabled = false;
            this.Timer2.Enabled = false;
            try
            {
                if (this.GetWindowHandle(ref GlobalVariables.ExeId, ref 1) != 0)
                {
                    this.CloseWindowByHwnd(this.GetWindowHandle(ref GlobalVariables.ExeId, ref 1));
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
            }
        }

        private void frmExecuteMACRO_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Timer1.Enabled = false;
            this.Timer2.Enabled = false;
            try
            {
                if (this.GetWindowHandle(ref GlobalVariables.ExeId, ref 1) != 0)
                {
                    this.CloseWindowByHwnd(this.GetWindowHandle(ref GlobalVariables.ExeId, ref 1));
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
            }
        }

        private void frmExecuteMACRO_Load(object eventSender, EventArgs eventArgs)
        {
            this.Refresh();
            this.Icon = this.frmMain.Icon;
        }

        [DllImport("kernel32", EntryPoint="GetTempPathA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int GetTempPath(int nBufferLength, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer);
        [DllImport("user32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int GetWindow(int hwnd, int wCmd);
        public int GetWindowHandle(ref int ShellPid, ref short id = 1)
        {
            int hwnd = (id != 1) ? GetWindow(this.Handle.ToInt32(), 0) : GetWindow(this.Handle.ToInt32(), 0);
            while (true)
            {
                if (hwnd != 0)
                {
                    int num;
                    GetWindowThreadProcessId(hwnd, ref num);
                    if (num != ShellPid)
                    {
                        hwnd = GetWindow(hwnd, 2);
                        continue;
                    }
                }
                return hwnd;
            }
        }

        [DllImport("user32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int GetWindowThreadProcessId(int hwnd, ref int lpdwProcessId);
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmExecuteMACRO));
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.fraBatch = new GroupBox();
            this.dtDate = new DateTimePicker();
            this.lstSimulations = new ListBox();
            this.Label4 = new Label();
            this.lblTotNoSims = new Label();
            this.lblOutOf = new Label();
            this.lblNoSimsDone = new Label();
            this.Label1 = new Label();
            this.Frame2 = new GroupBox();
            this.lblRunName = new Label();
            this.Label2 = new Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Frame1 = new Panel();
            this.ProgressBar1 = new AxProgressBar();
            this.lblAction = new Label();
            this.fraBatch.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.ProgressBar1.BeginInit();
            this.SuspendLayout();
            this.fraBatch.BackColor = SystemColors.Control;
            this.fraBatch.Controls.Add(this.dtDate);
            this.fraBatch.Controls.Add(this.lstSimulations);
            this.fraBatch.Controls.Add(this.Label4);
            this.fraBatch.Controls.Add(this.lblTotNoSims);
            this.fraBatch.Controls.Add(this.lblOutOf);
            this.fraBatch.Controls.Add(this.lblNoSimsDone);
            this.fraBatch.Controls.Add(this.Label1);
            this.fraBatch.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.fraBatch.ForeColor = SystemColors.ControlText;
            Point point = new Point(8, 0x60);
            this.fraBatch.Location = point;
            this.fraBatch.Name = "fraBatch";
            this.fraBatch.RightToLeft = RightToLeft.No;
            Size size = new Size(0x151, 0x71);
            this.fraBatch.Size = size;
            this.fraBatch.TabIndex = 6;
            this.fraBatch.TabStop = false;
            this.fraBatch.Text = "Batch mode";
            this.dtDate.CustomFormat = "yyyy:MM:dd HH:mm";
            this.dtDate.Format = DateTimePickerFormat.Custom;
            point = new Point(0xc3, 0x15);
            this.dtDate.Location = point;
            this.dtDate.Name = "dtDate";
            size = new Size(200, 20);
            this.dtDate.Size = size;
            this.dtDate.TabIndex = 14;
            this.dtDate.Visible = false;
            this.lstSimulations.BackColor = SystemColors.Window;
            this.lstSimulations.Cursor = Cursors.Default;
            this.lstSimulations.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lstSimulations.ForeColor = SystemColors.WindowText;
            this.lstSimulations.ItemHeight = 14;
            point = new Point(8, 0x20);
            this.lstSimulations.Location = point;
            this.lstSimulations.Name = "lstSimulations";
            this.lstSimulations.RightToLeft = RightToLeft.No;
            size = new Size(0xe1, 0x4a);
            this.lstSimulations.Size = size;
            this.lstSimulations.TabIndex = 7;
            this.Label4.BackColor = SystemColors.Control;
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.ControlText;
            point = new Point(0x68, 0x10);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 13;
            this.Label4.Text = "completed.";
            this.Label4.Visible = false;
            this.lblTotNoSims.BackColor = SystemColors.Control;
            this.lblTotNoSims.Cursor = Cursors.Default;
            this.lblTotNoSims.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTotNoSims.ForeColor = SystemColors.ControlText;
            point = new Point(0x40, 0x10);
            this.lblTotNoSims.Location = point;
            this.lblTotNoSims.Name = "lblTotNoSims";
            this.lblTotNoSims.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 0x11);
            this.lblTotNoSims.Size = size;
            this.lblTotNoSims.TabIndex = 12;
            this.lblTotNoSims.Text = "Label4";
            this.lblTotNoSims.Visible = false;
            this.lblOutOf.BackColor = SystemColors.Control;
            this.lblOutOf.Cursor = Cursors.Default;
            this.lblOutOf.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblOutOf.ForeColor = SystemColors.ControlText;
            point = new Point(0x20, 0x10);
            this.lblOutOf.Location = point;
            this.lblOutOf.Name = "lblOutOf";
            this.lblOutOf.RightToLeft = RightToLeft.No;
            size = new Size(0x21, 0x11);
            this.lblOutOf.Size = size;
            this.lblOutOf.TabIndex = 11;
            this.lblOutOf.Text = "out of";
            this.lblOutOf.Visible = false;
            this.lblNoSimsDone.BackColor = SystemColors.Control;
            this.lblNoSimsDone.Cursor = Cursors.Default;
            this.lblNoSimsDone.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblNoSimsDone.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.lblNoSimsDone.Location = point;
            this.lblNoSimsDone.Name = "lblNoSimsDone";
            this.lblNoSimsDone.RightToLeft = RightToLeft.No;
            size = new Size(0x19, 0x11);
            this.lblNoSimsDone.Size = size;
            this.lblNoSimsDone.TabIndex = 10;
            this.lblNoSimsDone.Text = "Label3";
            this.lblNoSimsDone.Visible = false;
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x111, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Remaining simulations:";
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this.lblRunName);
            this.Frame2.Controls.Add(this.Label2);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x30);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0x151, 0x29);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 3;
            this.Frame2.TabStop = false;
            this.lblRunName.BackColor = SystemColors.Window;
            this.lblRunName.BorderStyle = BorderStyle.FixedSingle;
            this.lblRunName.Cursor = Cursors.Default;
            this.lblRunName.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblRunName.ForeColor = SystemColors.WindowText;
            point = new Point(0x58, 0x10);
            this.lblRunName.Location = point;
            this.lblRunName.Name = "lblRunName";
            this.lblRunName.RightToLeft = RightToLeft.No;
            size = new Size(0xf1, 0x11);
            this.lblRunName.Size = size;
            this.lblRunName.TabIndex = 5;
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x41, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Simulation:";
            this.Timer1.Interval = 500;
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.ProgressBar1);
            this.Frame1.Controls.Add(this.lblAction);
            this.Frame1.Cursor = Cursors.Default;
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(0, 0);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x159, 0x31);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0;
            point = new Point(8, 0x18);
            this.ProgressBar1.Location = point;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.OcxState = (AxHost.State) manager.GetObject("ProgressBar1.OcxState");
            size = new Size(0x149, 0x11);
            this.ProgressBar1.Size = size;
            this.ProgressBar1.TabIndex = 1;
            this.lblAction.BackColor = SystemColors.Control;
            this.lblAction.Cursor = Cursors.Default;
            this.lblAction.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblAction.ForeColor = SystemColors.ControlText;
            point = new Point(8, 8);
            this.lblAction.Location = point;
            this.lblAction.Name = "lblAction";
            this.lblAction.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x19);
            this.lblAction.Size = size;
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "Action:";
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(350, 0xd6);
            this.ClientSize = size;
            this.Controls.Add(this.fraBatch);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            point = new Point(3, 0x16);
            this.Location = point;
            this.MaximizeBox = false;
            this.Name = "frmExecuteMACRO";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = " Execution";
            this.fraBatch.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.ProgressBar1.EndInit();
            this.ResumeLayout(false);
        }

        [DllImport("user32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int IsWindow(int hwnd);
        [DllImport("user32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int IsWindowVisible(int hwnd);
        private void LogError(ref string fname, ref string[] msg)
        {
            short fileNumber = (short) Microsoft.VisualBasic.FileSystem.FreeFile();
            Microsoft.VisualBasic.FileSystem.FileOpen(fileNumber, fname, OpenMode.Append, OpenAccess.Default, OpenShare.Default, -1);
            object[] output = new object[] { Conversions.ToString(DateAndTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay) };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            if (this.m_ParVar)
            {
                output = new object[] { "Simulation number: " + Conversions.ToString((int) this.frmMain.frmExeParWizard.CurrentSimNo) };
                Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            }
            short num3 = (short) (Information.UBound(msg, 1) - Information.LBound(msg, 1));
            short index = (short) Information.LBound(msg, 1);
            while (true)
            {
                short num4 = num3;
                if (index > num4)
                {
                    output = new object[] { "---------------------------------" };
                    Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
                    Microsoft.VisualBasic.FileSystem.FileClose(new int[] { fileNumber });
                    return;
                }
                output = new object[] { msg[index] };
                Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
                index = (short) (index + 1);
            }
        }

        private void MoveOutputFiles()
        {
            // Invalid method body.
        }

        private void NextSim()
        {
            this.rec.MoveNext();
            if (!this.rec.EOF & (this.lstSimulations.Items.Count != 0))
            {
                this.lblRunName.Text = Conversions.ToString(this.rec[]["Run_name"][]);
                GlobalVariables.IDExecute = Conversions.ToInteger(this.rec[]["R_ID"][]);
                this.lstSimulations.Items.RemoveAt(0);
                this.ExecuteSimulation(ref 0);
            }
            else
            {
                this.after = Conversions.ToString(DateAndTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay);
                this.Timer1.Enabled = false;
                this.Timer2.Enabled = false;
                MiscFUncs.MsgBox_Renamed("Execution of simulations finished.\rSimulations lasted from " + this.beforebatch + "\rto " + this.after + ".", 0x40, "Execution finished");
                this.frmMain.Show();
                this.Close();
            }
        }

        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);
        public void RunSimulations()
        {
            this.Cursor = Cursors.WaitCursor;
            Microsoft.VisualBasic.FileSystem.ChDrive(GlobalVariables.AppDrive);
            Microsoft.VisualBasic.FileSystem.ChDir(MyProject.Application.Info.DirectoryPath);
            this.m_Exe = true;
            Microsoft.VisualBasic.FileSystem.CurDir();
            if (this.m_Batch)
            {
                this.ExecuteBatch();
            }
            else if (this.m_SUFI | this.m_ParVar)
            {
                this.ExecuteSimulation(ref 0);
            }
            else
            {
                this.lblNoSimsDone.Text = Conversions.ToString(0);
                this.lblTotNoSims.Text = Conversions.ToString(1);
                this.ExecuteSimulation(ref 0);
            }
        }

        [DllImport("user32", EntryPoint="SendMessageTimeoutA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int SendMessageTimeout(int hwnd, int msg, int wParam, int lParam, int fuFlags, int uTimeout, ref int lpdwResult);
        private void SetYears(ref short MaxYear, ref short CropYears, ref short[] IrrYears)
        {
            IrrYears = new short[2];
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = rs;
            recordset2.Open("select * from [Options] where R_ID=" + Conversions.ToString(GlobalVariables.IDExecute), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            short num2 = Conversions.ToShort(recordset2[]["IRRIGATE"][]);
            recordset2.Close();
            if (num2 != 1)
            {
                IrrYears = new short[2];
                IrrYears[1] = 0;
            }
            else
            {
                recordset2.Open("select * from [Irrigation] where R_ID=" + Conversions.ToString(GlobalVariables.IDExecute), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                short num3 = Conversions.ToShort(recordset2[]["irryears"][]);
                if (Operators.ConditionalCompareObjectEqual(recordset2[]["irrsame"][], true, false))
                {
                    IrrYears = new short[2];
                    IrrYears[1] = 1;
                }
                else
                {
                    recordset2.Close();
                    recordset2.Open("select * from [Irrigation()] where R_id=" + Conversions.ToString(GlobalVariables.IDExecute) + " order by Irryear", this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    recordset2.MoveFirst();
                    bool flag = true;
                    short num4 = num3;
                    short num = 1;
                    while (true)
                    {
                        short num5 = num4;
                        if (num > num5)
                        {
                            break;
                        }
                        recordset2.Find("IRRYEAR=" + Conversions.ToString((int) num), 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                        if (!recordset2.EOF)
                        {
                            if (!flag)
                            {
                                IrrYears = (short[]) Utils.CopyArray((Array) IrrYears, new short[(Information.UBound(IrrYears, 1) + 1) + 1]);
                            }
                            flag = false;
                            IrrYears[Information.UBound(IrrYears, 1)] = num;
                        }
                        recordset2.MoveFirst();
                        num = (short) (num + 1);
                    }
                }
                recordset2.Close();
            }
            if (GlobalVariables.sw_crop <= MACROConstants.Switch.NoMetabolite)
            {
                CropYears = 0;
            }
            else
            {
                recordset2.Open("select * from [Crop] where r_id=" + Conversions.ToString(GlobalVariables.IDExecute), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                CropYears = (short) ReadSaveFunctions.RecordCount(ref rs);
                recordset2.Close();
            }
            MaxYear = (CropYears < IrrYears[Information.UBound(IrrYears, 1)]) ? IrrYears[Information.UBound(IrrYears, 1)] : CropYears;
            recordset2 = null;
        }

        [DllImport("shell32.dll", EntryPoint="ShellExecuteA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int ShellExecute(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpOperation, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFile, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpParameters, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDirectory, int nShowCmd);
        [DllImport("kernel32", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        private static extern int TerminateProcess(int hProcess, int uExitCode);
        private void Timer1_Tick(object eventSender, EventArgs eventArgs)
        {
            string str2 = "";
            string expression = "0";
            string str3 = "";
            Recordset recordset = new RecordsetClass();
            if (!this.CheckCrash())
            {
                if (!MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\run_time.txt"))
                {
                    expression = "0";
                }
                else
                {
                    try
                    {
                        expression = Strings.Trim(MyProject.Computer.FileSystem.ReadAllText(MyProject.Application.Info.DirectoryPath + @"\run_time.txt"));
                    }
                    catch (Exception exception1)
                    {
                        Exception ex = exception1;
                        ProjectData.SetProjectError(ex);
                        Exception exception = ex;
                        ProjectData.ClearProjectError();
                    }
                }
            }
            else
            {
                this.Timer1.Enabled = false;
                this.Close();
                this.frmMain.Show();
                return;
            }
            if (this.GetWindowHandle(ref GlobalVariables.ExeId, ref 1) != 0)
            {
                if (expression == "0")
                {
                    return;
                }
                else if (Strings.Len(expression) <= 1)
                {
                    this.ProgressBar1.Value = 0f;
                }
                else
                {
                    try
                    {
                        this.ProgressBar1.Value = Conversions.ToSingle(Strings.Mid(expression, 3, 2)) * 10f;
                    }
                    catch (Exception exception2)
                    {
                        ProjectData.SetProjectError(exception2);
                        ProjectData.ClearProjectError();
                    }
                }
            }
            else
            {
                this.ProgressBar1.Value = 1000f;
                this.Refresh();
                this.Timer1.Enabled = false;
                this.ProgressBar1.Value = 0f;
                if ((!this.m_Batch & !this.m_SUFI) & !this.m_ParVar)
                {
                    this.after = Conversions.ToString(DateAndTime.Today) + " " + Conversions.ToString(DateAndTime.TimeOfDay);
                    if (MiscFUncs.FileExists(MyProject.Application.Info.DirectoryPath + @"\balance.txt"))
                    {
                        short fileNumber = (short) Microsoft.VisualBasic.FileSystem.FreeFile();
                        Microsoft.VisualBasic.FileSystem.FileOpen(fileNumber, MyProject.Application.Info.DirectoryPath + @"\balance.txt", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);
                        str2 = Microsoft.VisualBasic.FileSystem.LineInput(fileNumber);
                        str3 = Microsoft.VisualBasic.FileSystem.LineInput(fileNumber);
                        Microsoft.VisualBasic.FileSystem.FileClose(new int[] { fileNumber });
                    }
                    MiscFUncs.MsgBox_Renamed("Execution of simulation finished.\rSimulation lasted from " + this.Before + "\rto " + this.after + ".\rWater balance error: " + str2 + "%\rSolute balance error: " + str3 + "%", 0x40, "Execution finished");
                    this.MoveOutputFiles();
                    this.Close();
                    this.frmMain.Show();
                }
                else if (this.m_Batch)
                {
                    Thread.Sleep(0x7d0);
                    this.MoveOutputFiles();
                    this.NextSim();
                }
                else if (!this.m_SUFI)
                {
                    if (this.m_ParVar)
                    {
                        this.lblNoSimsDone.Text = Conversions.ToString((double) (Conversions.ToDouble(this.lblNoSimsDone.Text) + 1.0));
                        Thread.Sleep(0x3e8);
                        this.frmMain.frmExeParWizard.MoveOutputFiles();
                        this.frmMain.frmExeParWizard.NextSimulation();
                    }
                }
                else if (!this.CheckCrash())
                {
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
                    this.lblNoSimsDone.Text = Conversions.ToString((double) (Conversions.ToDouble(this.lblNoSimsDone.Text) + 1.0));
                    Thread.Sleep(0x7d0);
                    frmSUFIMain.MoveSUFIOutputFiles();
                    frmSUFIMain.NextSimulation();
                    frmSUFIMain = null;
                }
                return;
            }
            this.Refresh();
        }

        private void Timer2_Tick(object eventSender, EventArgs eventArgs)
        {
            this.Timer1.Enabled = true;
            this.Timer2.Enabled = false;
        }

        private void WriteEndOfIndump(ref short fp)
        {
            short num;
            long num6;
            short num10;
            short[] numArray2;
            float[] numArray3;
            object obj2;
            object obj3;
            object obj4;
            int num15;
            short num18;
            Recordset rs = new RecordsetClass();
            cChaparDates dates = new cChaparDates();
            object[] output = new object[] { "24   1" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, new object[0]);
            output = new object[] { "26   0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "            0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "25    0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            GlobalVariables.b_Executing = true;
            ReadSaveFunctions.ReadSetup(ref GlobalVariables.IDExecute, ref this.frmMain);
            GlobalVariables.b_Executing = false;
            this.dtDate.Value = this.frmMain.frmSetup.dtStartDate.Value;
            DateTime time = this.frmMain.frmSetup.dtStartDate.Value;
            DateTime time2 = new DateTime(time.Year, 1, 1);
            this.dtDate.Value = time2;
            long num7 = MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.frmMain.frmSetup.dtEndDate));
            output = new object[] { Indump.rformat(ref obj4, ref "############") + " " + Indump.rformat(ref obj3, ref "############") + Indump.rformat(ref obj2, ref "############") };
            obj4 = MiscFUncs.JulianDate(MiscFUncs.ConvertDate(ref this.frmMain.frmSetup.dtStartDate));
            long num8 = Conversions.ToLong(obj4);
            obj3 = num7;
            num7 = Conversions.ToLong(obj3);
            obj2 = (short) (GlobalVariables.outintm + (GlobalVariables.outintd * 0x5a0));
            short num13 = Conversions.ToShort(obj2);
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            Recordset recordset2 = rs;
            recordset2.Open("Select * from [Run_ID] where R_ID=" + Conversions.ToString(GlobalVariables.IDExecute), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            output = new object[] { "31 " + Conversion.Str(Strings.Len(recordset2[]["rainfall_file"][])) };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { recordset2[]["rainfall_file"][] };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "32 11" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "TESTING.PAR" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "33  9" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "MACRO.TRA" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "34  9" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "MACRO.INI" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "35  9" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "MACRO.FIN" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "36  0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "37  0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "38 " + Conversion.Str(Strings.Len(recordset2[]["met_file"][])) };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { recordset2[]["met_file"][] };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "39 " + Conversions.ToString(Strings.Len(recordset2[]["Period_file10"][])) };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { recordset2[]["Period_file10"][] };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "40 " + Conversion.Str(Strings.Len(recordset2[]["driving_file"][])) };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { recordset2[]["driving_file"][] };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "41 " + Conversion.Str(Strings.Len(recordset2[]["tensionfile"][])) };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { recordset2[]["tensionfile"][] };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "50  0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, new object[0]);
            recordset2.Close();
            recordset2 = null;
            output = new object[] { "60  0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "      -15303" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "61  0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            output = new object[] { "           0" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fp, output);
            short[] irrYears = new short[2];
            string[] parameternames = new string[2];
            Collection collection = new Collection();
            Collection collection2 = new Collection();
            Collection collection3 = new Collection();
            this.SetYears(ref num10, ref num, ref irrYears);
            if (num10 > 1)
            {
                short index = 2;
                bool flag2 = false;
                short num14 = num10;
                short y = 2;
                while (true)
                {
                    num18 = num14;
                    if (y > num18)
                    {
                        break;
                    }
                    numArray2 = new short[2];
                    numArray3 = new float[2];
                    if (y <= num)
                    {
                        flag2 = true;
                        MiscFUncs.SetCropParNames(ref parameternames, ref this.frmMain);
                        MiscFUncs.SetCropParIndex(ref numArray2, ref parameternames, ref false);
                        MiscFUncs.GetCropParameters(ref numArray3, ref y, ref parameternames, ref this.frmMain);
                        if (GlobalVariables.C_HARVESTDAYINDEX <= 0)
                        {
                            time = new DateTime(this.dtDate.Value.Year + 1, 1, 1);
                            this.dtDate.Value = time;
                        }
                        else
                        {
                            if ((numArray3[GlobalVariables.C_HARVESTDAYINDEX] < numArray3[GlobalVariables.C_IDTSTARTINDEX]) & (numArray3[GlobalVariables.C_HARVESTDAYINDEX] >= GlobalVariables.m_Harvestday))
                            {
                                GlobalVariables.m_Harvestday = (short) (GlobalVariables.m_Harvestday + 1);
                            }
                            this.dtDate.Value = this.dtDate.Value.AddDays((double) (GlobalVariables.m_Harvestday + 1));
                            GlobalVariables.m_Harvestday = (short) Math.Round((double) numArray3[GlobalVariables.C_HARVESTDAYINDEX]);
                        }
                        num6 = MiscFUncs.JulianDate(this.dtDate.Value.ToString("yyyy:MM:dd HH:mm"));
                        if (num6 < num8)
                        {
                            num6 = num8 + 1L;
                        }
                        num15 = (int) num6;
                        dates.m_ChaparDates.Add(ref num15, ref numArray2, ref numArray3, ref false, ref "");
                        num6 = num15;
                        numArray2 = null;
                        numArray3 = null;
                        parameternames = null;
                        numArray2 = new short[2];
                        numArray3 = new float[2];
                        if (GlobalVariables.C_HARVESTDAYINDEX > 0)
                        {
                            time = new DateTime(this.dtDate.Value.Year + 1, 1, 1);
                            this.dtDate.Value = time;
                        }
                    }
                    bool flag = false;
                    if ((index <= Information.UBound(irrYears, 1)) && (y == irrYears[index]))
                    {
                        flag = true;
                        MiscFUncs.SetIrrParNames(ref parameternames, ref this.frmMain);
                        MiscFUncs.SetIrrParIndex(ref numArray2, ref parameternames, ref false);
                        MiscFUncs.GetIrrParameters(ref numArray3, ref y, ref parameternames, ref this.frmMain, ref false);
                        short num11 = (short) Math.Round((double) numArray3[Information.UBound(numArray3, 1)]);
                        index = (short) (index + 1);
                        numArray3[Information.UBound(numArray3, 1)] = 0f;
                        num6 = MiscFUncs.JulianDate(Conversion.Str((y + this.frmMain.frmSetup.dtStartDate.Value.Year) - 1) + "0101 00:01");
                        num15 = (int) num6;
                        dates.m_ChaparDates.Add(ref num15, ref numArray2, ref numArray3, ref false, ref "");
                        num6 = num15;
                        numArray3[Information.UBound(numArray3, 1)] = num11;
                        num6 = MiscFUncs.JulianDate(Conversion.Str((y + this.frmMain.frmSetup.dtStartDate.Value.Year) - 1) + "0101 00:01") + ((long) Math.Round((double) (((numArray3[1] - 1f) * 24f) * 60f)));
                        num15 = (int) num6;
                        dates.m_ChaparDates.Add(ref num15, ref numArray2, ref numArray3, ref false, ref "");
                        num6 = num15;
                        numArray2 = null;
                        numArray3 = null;
                        parameternames = null;
                    }
                    y = (short) (y + 1);
                }
            }
            Recordset recordset3 = rs;
            recordset3.Open("select * from Chapar where R_ID=" + Conversions.ToString(GlobalVariables.RunIDno), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (ReadSaveFunctions.RecordCount(ref rs) > 0)
            {
                recordset3.MoveFirst();
                numArray2 = new short[2];
                numArray3 = new float[2];
                while (true)
                {
                    if (recordset3.EOF)
                    {
                        break;
                    }
                    num6 = MiscFUncs.JulianDate(Conversions.ToString(recordset3[]["Date"][]));
                    numArray2 = new short[Conversions.ToInteger(recordset3[]["Length"][]) + 1];
                    numArray3 = new float[Conversions.ToInteger(recordset3[]["Length"][]) + 1];
                    float num9 = Conversions.ToSingle(recordset3[]["Value"][]);
                    string str2 = Conversions.ToString(recordset3[]["ParameterName"][]);
                    int num12 = Strings.InStr(1, str2, "_", CompareMethod.Binary);
                    if (num12 != 0)
                    {
                        str2 = Strings.Left(str2, num12 - 1);
                    }
                    num12 = (MiscFUncs.ParameterIndex(ref str2) + Conversions.ToInteger(recordset3[]["Start"][])) - 1;
                    short num16 = Conversions.ToShort(recordset3[]["Length"][]);
                    short index = 1;
                    while (true)
                    {
                        num18 = num16;
                        if (index > num18)
                        {
                            num15 = (int) num6;
                            dates.m_ChaparDates.Add(ref num15, ref numArray2, ref numArray3, ref false, ref "");
                            num6 = num15;
                            recordset3.MoveNext();
                            break;
                        }
                        numArray2[index] = (short) ((num12 + index) - 1);
                        numArray3[index] = num9;
                        index = (short) (index + 1);
                    }
                }
            }
            recordset3.Close();
            recordset3 = null;
            if (dates.ChaparDates.Count > 0)
            {
                dates.SortByDate();
                num15 = (int) num8;
                int e = (int) num7;
                dates.PrintToIndump(ref fp, ref num15, ref e);
                num7 = e;
                num8 = num15;
            }
            Microsoft.VisualBasic.FileSystem.FileClose(new int[0]);
        }

        public virtual System.Windows.Forms.Timer Timer2
        {
            [DebuggerNonUserCode]
            get => 
                this._Timer2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Timer2_Tick);
                if (!ReferenceEquals(this._Timer2, null))
                {
                    this._Timer2.Tick -= handler;
                }
                this._Timer2 = value;
                if (!ReferenceEquals(this._Timer2, null))
                {
                    this._Timer2.Tick += handler;
                }
            }
        }

        public virtual ListBox lstSimulations
        {
            [DebuggerNonUserCode]
            get => 
                this._lstSimulations;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lstSimulations = value;
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

        public virtual Label lblTotNoSims
        {
            [DebuggerNonUserCode]
            get => 
                this._lblTotNoSims;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblTotNoSims = value;
        }

        public virtual Label lblOutOf
        {
            [DebuggerNonUserCode]
            get => 
                this._lblOutOf;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblOutOf = value;
        }

        public virtual Label lblNoSimsDone
        {
            [DebuggerNonUserCode]
            get => 
                this._lblNoSimsDone;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblNoSimsDone = value;
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

        public virtual GroupBox fraBatch
        {
            [DebuggerNonUserCode]
            get => 
                this._fraBatch;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._fraBatch = value;
        }

        public virtual Label lblRunName
        {
            [DebuggerNonUserCode]
            get => 
                this._lblRunName;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblRunName = value;
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

        public virtual GroupBox Frame2
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame2 = value;
        }

        public virtual System.Windows.Forms.Timer Timer1
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

        public virtual AxProgressBar ProgressBar1
        {
            [DebuggerNonUserCode]
            get => 
                this._ProgressBar1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._ProgressBar1 = value;
        }

        public virtual Label lblAction
        {
            [DebuggerNonUserCode]
            get => 
                this._lblAction;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._lblAction = value;
        }

        public virtual Panel Frame1
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame1 = value;
        }

        internal virtual DateTimePicker dtDate
        {
            [DebuggerNonUserCode]
            get => 
                this._dtDate;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dtDate = value;
        }
    }
}

