namespace MACRO_52
{
    using ADODB;
    using AxComctlLib;
    using ComctlLib;
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
    internal class frmOpen : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("dbSimulations")]
        private ADODC _dbSimulations;
        [AccessedThroughProperty("cmdAction")]
        private System.Windows.Forms.Button _cmdAction;
        [AccessedThroughProperty("Command3")]
        private System.Windows.Forms.Button _Command3;
        [AccessedThroughProperty("Text3")]
        private TextBox _Text3;
        [AccessedThroughProperty("Frame3")]
        private GroupBox _Frame3;
        [AccessedThroughProperty("Text4")]
        private TextBox _Text4;
        [AccessedThroughProperty("Text2")]
        private TextBox _Text2;
        [AccessedThroughProperty("Text1")]
        private TextBox _Text1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Frame6")]
        private GroupBox _Frame6;
        [AccessedThroughProperty("Frame2")]
        private GroupBox _Frame2;
        [AccessedThroughProperty("tvProjects")]
        private AxTreeView _tvProjects;
        [AccessedThroughProperty("lblAction")]
        private Label _lblAction;
        [AccessedThroughProperty("Frame1")]
        private GroupBox _Frame1;
        [AccessedThroughProperty("imglstTreeview")]
        private AxImageList _imglstTreeview;
        private short i;
        private int r;
        private int[] r_ids;
        public bool bDelete;
        public bool bAdd;
        public bool bSUFI;
        public bool OpeningBaseSimulation;
        private CfrmMain frmMain;
        private bool IsOpening;
        private int m_selectedRunID;

        public frmOpen(ref CfrmMain frm)
        {
            base.Activated += new EventHandler(this.frmOpen_Activated);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.r_ids = new int[0x65];
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void cmdAction_Click(object eventSender, EventArgs eventArgs)
        {
            Recordset recordset2 = new RecordsetClass();
            Recordset recordset = new RecordsetClass();
            if (!(((!this.bDelete & !this.bAdd) & !this.bSUFI) & !this.OpeningBaseSimulation))
            {
                if (!this.bDelete)
                {
                    if (this.bAdd)
                    {
                        if (this.tvProjects.SelectedItem.Children == 0)
                        {
                            Recordset recordset3 = recordset2;
                            recordset3.Open("select * from Run_id where r_id=" + Conversions.ToString(this.m_selectedRunID), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            recordset3[]["Batch"][] = -1;
                            recordset3.Update(Missing.Value, Missing.Value);
                            recordset3.Close();
                            recordset3 = null;
                        }
                        else
                        {
                            Recordset recordset4 = recordset;
                            short num = Conversions.ToShort(Strings.Left(this.tvProjects.SelectedItem.Key, Strings.Len(this.tvProjects.SelectedItem.Key) - 1));
                            recordset4.Open("select * from [RUN_ID] where ID_no=" + Conversions.ToString((int) num), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            recordset4.MoveFirst();
                            while (true)
                            {
                                if (recordset4.EOF)
                                {
                                    recordset4.Close();
                                    recordset4 = null;
                                    break;
                                }
                                recordset4[]["Batch"][] = -1;
                                recordset4.Update(Missing.Value, Missing.Value);
                                recordset4.MoveNext();
                            }
                        }
                    }
                }
                else if (this.Delete())
                {
                    this.frmMain.Editera.Enabled = false;
                    GlobalVariables.RunIDno = 0;
                    GlobalVariables.Re_place = 0;
                    this.frmMain.SaveProject.Enabled = false;
                    this.frmMain.SaveAs.Enabled = false;
                    this.frmMain.SaveToparameterFileToolStripMenuItem.Enabled = false;
                    this.frmMain.current.Enabled = false;
                    this.frmMain.Text = "";
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    this.ShowDialog();
                    this.Refresh();
                    return;
                }
            }
            else
            {
                this.ReadSimulation();
                this.frmMain.InitMyForms();
                this.frmMain.frmParameters.ShowAll();
            }
            GlobalVariables.New_Project = false;
            this.Close();
        }

        private void Command3_Click(object eventSender, EventArgs eventArgs)
        {
            if (this.bSUFI)
            {
                CfrmNewSUFIProject newSUFIProjectForm = this.frmMain.frmSUFIMain.NewSUFIProjectForm;
                newSUFIProjectForm.lblBaseProject.Text = "";
                newSUFIProjectForm.lblBaseSimulation.Text = "";
                newSUFIProjectForm.SUFIProjectID = -1;
                newSUFIProjectForm.SUFIRunID = -1;
                newSUFIProjectForm = null;
            }
            if (this.OpeningBaseSimulation)
            {
                CfrmExeParWizard frmExeParWizard = this.frmMain.frmExeParWizard;
                frmExeParWizard.lblBaseProject.Text = "";
                frmExeParWizard.lblBaseSimulation.Text = "";
                frmExeParWizard.ParVarProjID = -1;
                frmExeParWizard.ParVarRunID = -1;
                frmExeParWizard = null;
            }
            this.Hide();
        }

        private bool Delete()
        {
            this.Hide();
            this.frmMain.Refresh();
            this.Cursor = Cursors.WaitCursor;
            if (this.tvProjects.SelectedItem.Children != 0)
            {
                if (!Operators.ConditionalCompareObjectEqual(MiscFUncs.MsgBox_Renamed("This will delete the entire project. Continue?", 0x34, "Deleting"), MsgBoxResult.Yes, false))
                {
                    return false;
                }
                else
                {
                    this.DeleteProject(ref Strings.Left(this.tvProjects.SelectedItem.Key, Strings.Len(this.tvProjects.SelectedItem.Key) - 1));
                }
            }
            else if (this.tvProjects.SelectedItem.Parent.Children != 1)
            {
                string id = Strings.Left(this.tvProjects.SelectedItem.Key, Strings.Len(this.tvProjects.SelectedItem.Key) - 1);
                this.DeleteSimulation(ref id);
            }
            else if (!Operators.ConditionalCompareObjectEqual(MiscFUncs.MsgBox_Renamed("This will delete the entire project. Continue?", 0x34, "Deleting"), MsgBoxResult.Yes, false))
            {
                return false;
            }
            else
            {
                this.DeleteProject(ref Strings.Left(this.tvProjects.SelectedItem.Parent.Key, Strings.Len(this.tvProjects.SelectedItem.Parent.Key) - 1));
            }
            this.Cursor = Cursors.Default;
            return true;
        }

        private void DeleteProject(ref string id)
        {
            Recordset rs = new RecordsetClass();
            rs.Open("select * from [Projects] where ID_no=" + id, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            rs.Close();
            bool flag = true;
            while (true)
            {
                if (!flag)
                {
                    return;
                }
                rs.Open("select * from [RUN_ID] where ID_no=" + id, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                if (!(!rs.EOF & !rs.BOF))
                {
                    flag = false;
                    continue;
                }
                flag = true;
                int num = Conversions.ToInteger(rs[]["R_ID"][]);
                rs.Close();
                string str = Conversions.ToString(num);
                this.DeleteSimulation(ref str);
                num = Conversions.ToInteger(str);
            }
        }

        private void DeleteRecordset(ref Recordset rs)
        {
            Recordset recordset = rs;
            while (true)
            {
                if (recordset.EOF)
                {
                    recordset = null;
                    return;
                }
                recordset.Delete(AffectEnum.adAffectCurrent);
                recordset.MoveNext();
            }
        }

        private void DeleteRecordset2()
        {
            Recordset recordset = this.frmMain.db2.Recordset;
            if (recordset.RecordCount != 0)
            {
                recordset.MoveFirst();
                while (true)
                {
                    if (recordset.EOF)
                    {
                        break;
                    }
                    recordset.Delete(AffectEnum.adAffectCurrent);
                    recordset.MoveNext();
                }
            }
            recordset = null;
        }

        private void DeleteSimulation(ref string id)
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = new RecordsetClass();
            frmProgress progress = new frmProgress(ref this.frmMain) {
                Text = "Deleting..."
            };
            string str2 = " WHERE R_ID=" + id;
            Recordset recordset3 = rs;
            recordset3.Open("select * from [RUN_ID]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            string str = Conversions.ToString(recordset3[]["Run_name"][]);
            progress.lblAction.Text = "Deleting simulation: " + str;
            progress.Progress.Max = 18f;
            progress.Show();
            progress.Refresh();
            this.DeleteRecordset(ref rs);
            rs.Close();
            progress.Progress.Value = 1f;
            progress.lblAction.Text = "Deleting simulation: " + str + " (set up)";
            progress.Refresh();
            recordset3.Open("select * from [Set-up]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (general information)";
            progress.Refresh();
            recordset3.Open("select * from [General]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (init. and boundary conditions)";
            progress.Refresh();
            recordset3.Open("select * from [IB conditions]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            recordset3.Open("select * from [IB conditions()]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (soil properties)";
            progress.Refresh();
            recordset3.Open("select * from [Properties]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (physical parameters)";
            progress.Refresh();
            recordset3.Open("select * from [Physical parameters]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (soil profile)";
            progress.Refresh();
            recordset3.Open("select * from [soil profile]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (crop data)";
            progress.Refresh();
            recordset3.Open("select * from [Crop]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (irrigation settings)";
            progress.Refresh();
            recordset3.Open("select * from [Irrigation]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            recordset3.Open("select * from [Irrigation()]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (options)";
            progress.Refresh();
            recordset3.Open("select * from [Options]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            progress.lblAction.Text = "Deleting simulation: " + str + " (output settings)";
            progress.Refresh();
            recordset3.Open("select * from [Output]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            this.DeleteRecordset(ref rs);
            recordset3.Close();
            progress.Progress.Value++;
            recordset3.Open("select * from [Output()]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                if (recordset3.EOF)
                {
                    this.DeleteRecordset(ref rs);
                    recordset3.Close();
                    progress.Progress.Value++;
                    progress.lblAction.Text = "Deleting simulation: " + str + " (site specific information)";
                    progress.Refresh();
                    recordset3.Open("select * from [Site()]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    this.DeleteRecordset(ref rs);
                    recordset3.Close();
                    progress.Progress.Value++;
                    recordset3.Open("select * from [Site]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    this.DeleteRecordset(ref rs);
                    recordset3.Close();
                    progress.Progress.Value++;
                    progress.lblAction.Text = "Deleting simulation: " + str + " (solute)";
                    progress.Refresh();
                    recordset3.Open("select * from [Solute]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    this.DeleteRecordset(ref rs);
                    recordset3.Close();
                    progress.Progress.Value++;
                    recordset3.Open("select * from [Solute()]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    this.DeleteRecordset(ref rs);
                    recordset3.Close();
                    progress.Progress.Value++;
                    recordset3.Open("select * from [Chapar]" + str2, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    this.DeleteRecordset(ref rs);
                    recordset3.Close();
                    recordset3 = null;
                    progress.Close();
                    return;
                }
                recordset2.Open(Operators.ConcatenateObject("select * from OutputLayers where [Output()ID]=", recordset3[]["Output()ID"][]), this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                this.DeleteRecordset(ref recordset2);
                recordset2.Close();
                recordset3.MoveNext();
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

        private void frmOpen_Activated(object eventSender, EventArgs eventArgs)
        {
            Recordset recordset = new RecordsetClass();
            if (!this.IsOpening)
            {
                this.tvProjects.Nodes.Clear();
                this.dbSimulations.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + GlobalVariables.DatabaseName + ";Persist Security Info=False";
                this.Refresh();
                this.Text1.Text = "";
                this.Text2.Text = "";
                this.Text3.Text = "";
                Recordset recordset2 = recordset;
                recordset2.Open("select * from Projects", this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset2.MoveFirst();
                recordset2.MoveNext();
                while (true)
                {
                    if (recordset.EOF)
                    {
                        recordset.Close();
                        recordset2 = null;
                        this.IsOpening = true;
                        break;
                    }
                    object relative = Missing.Value;
                    object relationship = Missing.Value;
                    object key = Conversion.Str(recordset2[]["id_no"][]) + "a";
                    object text = recordset2[]["project_name"];
                    object image = "Project";
                    object selectedImage = Missing.Value;
                    this.tvProjects.Nodes.Add(ref relative, ref relationship, ref key, ref text, ref image, ref selectedImage);
                    string str = Conversions.ToString(key);
                    str = "ID_no = " + Conversion.Str(recordset2[]["ID_no"][]);
                    this.dbSimulations.RecordSource = "select * from Run_ID where " + str + "";
                    this.dbSimulations.Refresh();
                    int num = 0;
                    while (true)
                    {
                        if (!(!this.dbSimulations.EOF & ((num + 1) <= this.dbSimulations.Recordset.RecordCount)))
                        {
                            recordset2.MoveNext();
                            break;
                        }
                        num++;
                        str = Conversion.Str(recordset2[]["id_no"][]) + "a";
                        selectedImage = str;
                        image = TreeRelationshipConstants.tvwChild;
                        text = Missing.Value;
                        key = Missing.Value;
                        relationship = "Simulation";
                        relative = Missing.Value;
                        str = Conversions.ToString(selectedImage);
                        ComctlLib.Node node = this.tvProjects.Nodes.Add(ref selectedImage, ref image, ref text, ref key, ref relationship, ref relative);
                        node.Key = Conversion.Str(this.dbSimulations.Recordset[]["r_id"][]) + "b";
                        node.Text = Conversions.ToString(this.dbSimulations.Recordset[]["run_name"][]);
                        this.dbSimulations.Recordset.MoveNext();
                    }
                }
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmOpen));
            this.dbSimulations = new ADODC();
            this.Frame2 = new GroupBox();
            this.cmdAction = new System.Windows.Forms.Button();
            this.Command3 = new System.Windows.Forms.Button();
            this.Text3 = new TextBox();
            this.Frame3 = new GroupBox();
            this.Frame6 = new GroupBox();
            this.Text4 = new TextBox();
            this.Text2 = new TextBox();
            this.Text1 = new TextBox();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Frame1 = new GroupBox();
            this.tvProjects = new AxTreeView();
            this.lblAction = new Label();
            this.imglstTreeview = new AxImageList();
            this.Frame2.SuspendLayout();
            this.Frame6.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.tvProjects.BeginInit();
            this.imglstTreeview.BeginInit();
            this.SuspendLayout();
            this.dbSimulations.BackColor = SystemColors.Window;
            this.dbSimulations.BOFAction = ADODC.BOFActionEnum.adDoMoveFirst;
            this.dbSimulations.CommandTimeout = 0;
            this.dbSimulations.CommandType = CommandTypeEnum.adCmdUnknown;
            this.dbSimulations.ConnectionString = null;
            this.dbSimulations.CursorLocation = CursorLocationEnum.adUseClient;
            this.dbSimulations.CursorType = CursorTypeEnum.adOpenStatic;
            this.dbSimulations.EOFAction = ADODC.EOFActionEnum.adDoMoveLast;
            this.dbSimulations.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dbSimulations.ForeColor = SystemColors.WindowText;
            Point point = new Point(0x98, 400);
            this.dbSimulations.Location = point;
            this.dbSimulations.LockType = LockTypeEnum.adLockPessimistic;
            this.dbSimulations.Mode = ConnectModeEnum.adModeUnknown;
            this.dbSimulations.Name = "dbSimulations";
            this.dbSimulations.Orientation = ADODC.OrientationEnum.adHorizontal;
            Size size = new Size(0x61, 0x19);
            this.dbSimulations.Size = size;
            this.dbSimulations.TabIndex = 0;
            this.dbSimulations.Text = "Adodc1";
            this.dbSimulations.Visible = false;
            this.Frame2.BackColor = SystemColors.Control;
            this.Frame2.Controls.Add(this.Text3);
            this.Frame2.Controls.Add(this.Frame3);
            this.Frame2.Controls.Add(this.Frame6);
            this.Frame2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame2.ForeColor = SystemColors.ControlText;
            point = new Point(0x125, 0);
            this.Frame2.Location = point;
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = RightToLeft.No;
            size = new Size(0x139, 0x127);
            this.Frame2.Size = size;
            this.Frame2.TabIndex = 1;
            this.Frame2.TabStop = false;
            this.cmdAction.BackColor = SystemColors.Control;
            this.cmdAction.Cursor = Cursors.Default;
            this.cmdAction.Enabled = false;
            this.cmdAction.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdAction.ForeColor = SystemColors.ControlText;
            point = new Point(0x215, 0x12d);
            this.cmdAction.Location = point;
            this.cmdAction.Name = "cmdAction";
            this.cmdAction.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.cmdAction.Size = size;
            this.cmdAction.TabIndex = 11;
            this.cmdAction.Text = "&Open";
            this.cmdAction.UseVisualStyleBackColor = false;
            this.Command3.BackColor = SystemColors.Control;
            this.Command3.Cursor = Cursors.Default;
            this.Command3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command3.ForeColor = SystemColors.ControlText;
            point = new Point(0x1c5, 0x12d);
            this.Command3.Location = point;
            this.Command3.Name = "Command3";
            this.Command3.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x19);
            this.Command3.Size = size;
            this.Command3.TabIndex = 10;
            this.Command3.Text = "Cancel";
            this.Command3.UseVisualStyleBackColor = false;
            this.Text3.AcceptsReturn = true;
            this.Text3.BackColor = SystemColors.Window;
            this.Text3.Cursor = Cursors.IBeam;
            this.Text3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text3.ForeColor = SystemColors.WindowText;
            point = new Point(0x10, 0x20);
            this.Text3.Location = point;
            this.Text3.MaxLength = 0;
            this.Text3.Multiline = true;
            this.Text3.Name = "Text3";
            this.Text3.RightToLeft = RightToLeft.No;
            this.Text3.ScrollBars = ScrollBars.Vertical;
            size = new Size(0x119, 0x4d);
            this.Text3.Size = size;
            this.Text3.TabIndex = 9;
            this.Frame3.BackColor = SystemColors.Control;
            this.Frame3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame3.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.Frame3.Location = point;
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0x67);
            this.Frame3.Size = size;
            this.Frame3.TabIndex = 8;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Project description";
            this.Frame6.BackColor = SystemColors.Control;
            this.Frame6.Controls.Add(this.Text4);
            this.Frame6.Controls.Add(this.Text2);
            this.Frame6.Controls.Add(this.Text1);
            this.Frame6.Controls.Add(this.Label1);
            this.Frame6.Controls.Add(this.Label2);
            this.Frame6.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame6.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x7d);
            this.Frame6.Location = point;
            this.Frame6.Name = "Frame6";
            this.Frame6.RightToLeft = RightToLeft.No;
            size = new Size(0x129, 0xa1);
            this.Frame6.Size = size;
            this.Frame6.TabIndex = 2;
            this.Frame6.TabStop = false;
            this.Frame6.Text = "Simulation description";
            this.Text4.AcceptsReturn = true;
            this.Text4.BackColor = SystemColors.Window;
            this.Text4.Cursor = Cursors.IBeam;
            this.Text4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text4.ForeColor = SystemColors.WindowText;
            point = new Point(80, 0x88);
            this.Text4.Location = point;
            this.Text4.MaxLength = 0;
            this.Text4.Name = "Text4";
            this.Text4.ReadOnly = true;
            this.Text4.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 20);
            this.Text4.Size = size;
            this.Text4.TabIndex = 13;
            this.Text2.AcceptsReturn = true;
            this.Text2.BackColor = SystemColors.Window;
            this.Text2.Cursor = Cursors.IBeam;
            this.Text2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text2.ForeColor = SystemColors.WindowText;
            point = new Point(80, 0x70);
            this.Text2.Location = point;
            this.Text2.MaxLength = 0;
            this.Text2.Name = "Text2";
            this.Text2.ReadOnly = true;
            this.Text2.RightToLeft = RightToLeft.No;
            size = new Size(0x91, 20);
            this.Text2.Size = size;
            this.Text2.TabIndex = 5;
            this.Text1.AcceptsReturn = true;
            this.Text1.BackColor = SystemColors.Window;
            this.Text1.Cursor = Cursors.IBeam;
            this.Text1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text1.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x10);
            this.Text1.Location = point;
            this.Text1.MaxLength = 0;
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.ReadOnly = true;
            this.Text1.RightToLeft = RightToLeft.No;
            this.Text1.ScrollBars = ScrollBars.Vertical;
            size = new Size(0x119, 0x59);
            this.Text1.Size = size;
            this.Text1.TabIndex = 3;
            this.Label1.BackColor = SystemColors.Control;
            this.Label1.Cursor = Cursors.Default;
            this.Label1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x88);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            size = new Size(0x31, 0x11);
            this.Label1.Size = size;
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Run ID:";
            this.Label2.BackColor = SystemColors.Control;
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x70);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x49, 0x11);
            this.Label2.Size = size;
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Last modified:";
            this.Frame1.BackColor = SystemColors.Control;
            this.Frame1.Controls.Add(this.tvProjects);
            this.Frame1.Controls.Add(this.lblAction);
            this.Frame1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Frame1.ForeColor = SystemColors.ControlText;
            point = new Point(12, 0);
            this.Frame1.Location = point;
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = RightToLeft.No;
            size = new Size(0x113, 0x127);
            this.Frame1.Size = size;
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            point = new Point(11, 0x20);
            this.tvProjects.Location = point;
            this.tvProjects.Name = "tvProjects";
            this.tvProjects.OcxState = (AxHost.State) manager.GetObject("tvProjects.OcxState");
            size = new Size(0xfc, 0xfe);
            this.tvProjects.Size = size;
            this.tvProjects.TabIndex = 7;
            this.lblAction.BackColor = SystemColors.Control;
            this.lblAction.Cursor = Cursors.Default;
            this.lblAction.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblAction.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x10);
            this.lblAction.Location = point;
            this.lblAction.Name = "lblAction";
            this.lblAction.RightToLeft = RightToLeft.No;
            size = new Size(0xf9, 0x21);
            this.lblAction.Size = size;
            this.lblAction.TabIndex = 6;
            this.lblAction.Text = "Select a project and a simulation to open.";
            this.imglstTreeview.Enabled = true;
            point = new Point(0x108, 400);
            this.imglstTreeview.Location = point;
            this.imglstTreeview.Name = "imglstTreeview";
            this.imglstTreeview.OcxState = (AxHost.State) manager.GetObject("imglstTreeview.OcxState");
            size = new Size(0x26, 0x26);
            this.imglstTreeview.Size = size;
            this.imglstTreeview.TabIndex = 2;
            SizeF ef = new SizeF(6f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size = new Size(0x263, 0x14b);
            this.ClientSize = size;
            this.Controls.Add(this.cmdAction);
            this.Controls.Add(this.dbSimulations);
            this.Controls.Add(this.Command3);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.imglstTreeview);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            point = new Point(0xa5, 0x86);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpen";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Open";
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.Frame6.ResumeLayout(false);
            this.Frame6.PerformLayout();
            this.Frame1.ResumeLayout(false);
            this.tvProjects.EndInit();
            this.imglstTreeview.EndInit();
            this.ResumeLayout(false);
        }

        private void ReadSimulation()
        {
            ReadSaveFunctions.ZeroVariables();
            this.Cursor = Cursors.WaitCursor;
            this.r = Conversions.ToInteger(Strings.Left(this.tvProjects.SelectedItem.Key, Strings.Len(this.tvProjects.SelectedItem.Key) - 1));
            GlobalVariables.RunIDno = this.r;
            ReadSaveFunctions.ReadOptions(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadRun_ID(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadSite(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadSetup(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadIBcond(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadPhysicalParms(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadIrrigation(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadSoilProfile(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadSolute(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadCrop(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadOutput(ref this.r, ref this.frmMain);
            ReadSaveFunctions.ReadChapar(ref this.r, ref this.frmMain);
            Cursor.Current = Cursors.Default;
            this.frmMain.Editera.Enabled = true;
            this.frmMain.SaveProject.Enabled = true;
            this.frmMain.SaveAs.Enabled = true;
            this.frmMain.current.Enabled = true;
            this.frmMain.SaveToparameterFileToolStripMenuItem.Enabled = true;
            this.SetStartCaption();
            this.Text1.Text = "";
        }

        public void SetStartCaption()
        {
            this.frmMain.Text = "Project: " + GlobalVariables.project_name + @" \ Simulation: " + GlobalVariables.Run_name;
        }

        private void tvProjects_DblClick(object eventSender, EventArgs eventArgs)
        {
        }

        private void tvProjects_KeyPressEvent(object eventSender, ITreeViewEvents_KeyPressEvent eventArgs)
        {
            if (eventArgs.keyAscii == 13)
            {
                ComctlLib.Node selectedItem = this.tvProjects.SelectedItem;
                if (selectedItem.Children == 0)
                {
                    string str = Strings.Trim(Strings.Left(selectedItem.Key, Strings.Len(selectedItem.Key) - 1));
                    this.m_selectedRunID = Conversions.ToInteger(str);
                    this.frmMain.ProjectDatabase.RecordSource = "select * from Run_ID where R_id=" + str;
                    this.frmMain.ProjectDatabase.Refresh();
                    this.Text1.Text = Conversions.ToString(this.frmMain.ProjectDatabase.Recordset[]["Run_description"][]);
                    this.Text2.Text = Conversions.ToString(this.frmMain.ProjectDatabase.Recordset[]["Modified_date"][]);
                    this.cmdAction.Enabled = true;
                    this.cmdAction_Click(this.cmdAction, new EventArgs());
                }
                selectedItem = null;
            }
        }

        private void tvProjects_NodeClick(object eventSender, ITreeViewEvents_NodeClickEvent eventArgs)
        {
            string str;
            Recordset recordset = new RecordsetClass();
            if (eventArgs.node.Children <= 0)
            {
                str = Strings.Trim(Strings.Left(eventArgs.node.Key, Strings.Len(eventArgs.node.Key) - 1));
                this.m_selectedRunID = Conversions.ToInteger(str);
                recordset.Open("select * from Run_ID where R_id=" + str, this.frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                if (((!this.bDelete & !this.bAdd) & !this.bSUFI) & !this.OpeningBaseSimulation)
                {
                    this.r = Conversions.ToInteger(str);
                }
                if (!recordset.EOF & !recordset.BOF)
                {
                    this.Text1.Text = Conversions.ToString(recordset[]["Run_description"][]);
                    this.Text2.Text = Conversions.ToString(recordset[]["Modified_date"][]);
                    this.Text4.Text = Conversions.ToString(recordset[]["R_ID"][]);
                    recordset.Close();
                    this.cmdAction.Enabled = true;
                    if (this.bSUFI)
                    {
                        CfrmNewSUFIProject newSUFIProjectForm = this.frmMain.frmSUFIMain.NewSUFIProjectForm;
                        newSUFIProjectForm.lblBaseSimulation.Text = eventArgs.node.Text;
                        newSUFIProjectForm.SUFIRunID = Conversions.ToInteger(Strings.Trim(Strings.Left(eventArgs.node.Key, Strings.Len(eventArgs.node.Key) - 1)));
                        newSUFIProjectForm = null;
                    }
                    if (this.OpeningBaseSimulation)
                    {
                        CfrmExeParWizard frmExeParWizard = this.frmMain.frmExeParWizard;
                        frmExeParWizard.lblBaseSimulation.Text = eventArgs.node.Text;
                        frmExeParWizard.ParVarRunID = Conversions.ToInteger(Strings.Trim(Strings.Left(eventArgs.node.Key, Strings.Len(eventArgs.node.Key) - 1)));
                        frmExeParWizard = null;
                    }
                }
            }
            else
            {
                this.cmdAction.Enabled = false;
                eventArgs.node.Expanded = !eventArgs.node.Expanded;
                str = Strings.Trim(Strings.Left(eventArgs.node.Key, Strings.Len(eventArgs.node.Key) - 1));
                this.frmMain.ProjectDatabase.RecordSource = "select * from Projects where id_no=" + str;
                this.frmMain.ProjectDatabase.Refresh();
                this.Text3.Text = Conversions.ToString(this.frmMain.ProjectDatabase.Recordset[]["Proj_description"][]);
                GlobalVariables.Project_dscrpt = this.Text3.Text;
                GlobalVariables.ProjectIDno = Conversions.ToInteger(this.frmMain.ProjectDatabase.Recordset[]["ID_no"][]);
                this.Text1.Text = "";
                this.Text2.Text = "";
                this.Text4.Text = "";
                GlobalVariables.project_name = eventArgs.node.Text;
                if (this.bSUFI)
                {
                    CfrmNewSUFIProject newSUFIProjectForm = this.frmMain.frmSUFIMain.NewSUFIProjectForm;
                    newSUFIProjectForm.lblBaseProject.Text = eventArgs.node.Text;
                    newSUFIProjectForm.SUFIProjectID = Conversions.ToInteger(Strings.Trim(Strings.Left(eventArgs.node.Key, Strings.Len(eventArgs.node.Key) - 1)));
                    newSUFIProjectForm = null;
                }
                if (this.OpeningBaseSimulation)
                {
                    CfrmExeParWizard frmExeParWizard = this.frmMain.frmExeParWizard;
                    frmExeParWizard.lblBaseProject.Text = eventArgs.node.Text;
                    frmExeParWizard.ParVarProjID = Conversions.ToInteger(Strings.Trim(Strings.Left(eventArgs.node.Key, Strings.Len(eventArgs.node.Key) - 1)));
                    frmExeParWizard = null;
                }
                if (this.bDelete)
                {
                    this.cmdAction.Enabled = this.bDelete;
                }
                if (this.bAdd)
                {
                    this.cmdAction.Enabled = this.bAdd;
                }
            }
        }

        public virtual ADODC dbSimulations
        {
            [DebuggerNonUserCode]
            get => 
                this._dbSimulations;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._dbSimulations = value;
        }

        public virtual System.Windows.Forms.Button cmdAction
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdAction;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdAction_Click);
                if (!ReferenceEquals(this._cmdAction, null))
                {
                    this._cmdAction.Click -= handler;
                }
                this._cmdAction = value;
                if (!ReferenceEquals(this._cmdAction, null))
                {
                    this._cmdAction.Click += handler;
                }
            }
        }

        public virtual System.Windows.Forms.Button Command3
        {
            [DebuggerNonUserCode]
            get => 
                this._Command3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Command3_Click);
                if (!ReferenceEquals(this._Command3, null))
                {
                    this._Command3.Click -= handler;
                }
                this._Command3 = value;
                if (!ReferenceEquals(this._Command3, null))
                {
                    this._Command3.Click += handler;
                }
            }
        }

        public virtual TextBox Text3
        {
            [DebuggerNonUserCode]
            get => 
                this._Text3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text3 = value;
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

        public virtual TextBox Text4
        {
            [DebuggerNonUserCode]
            get => 
                this._Text4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text4 = value;
        }

        public virtual TextBox Text2
        {
            [DebuggerNonUserCode]
            get => 
                this._Text2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text2 = value;
        }

        public virtual TextBox Text1
        {
            [DebuggerNonUserCode]
            get => 
                this._Text1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Text1 = value;
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

        public virtual GroupBox Frame6
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame6 = value;
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

        public virtual AxTreeView tvProjects
        {
            [DebuggerNonUserCode]
            get => 
                this._tvProjects;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                AxComctlLib.ITreeViewEvents_NodeClickEventHandler handler = new AxComctlLib.ITreeViewEvents_NodeClickEventHandler(this.tvProjects_NodeClick);
                AxComctlLib.ITreeViewEvents_KeyPressEventHandler handler2 = new AxComctlLib.ITreeViewEvents_KeyPressEventHandler(this.tvProjects_KeyPressEvent);
                EventHandler handler3 = new EventHandler(this.tvProjects_DblClick);
                if (!ReferenceEquals(this._tvProjects, null))
                {
                    this._tvProjects.NodeClick -= handler;
                    this._tvProjects.KeyPressEvent -= handler2;
                    this._tvProjects.DblClick -= handler3;
                }
                this._tvProjects = value;
                if (!ReferenceEquals(this._tvProjects, null))
                {
                    this._tvProjects.NodeClick += handler;
                    this._tvProjects.KeyPressEvent += handler2;
                    this._tvProjects.DblClick += handler3;
                }
            }
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

        public virtual GroupBox Frame1
        {
            [DebuggerNonUserCode]
            get => 
                this._Frame1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Frame1 = value;
        }

        public virtual AxImageList imglstTreeview
        {
            [DebuggerNonUserCode]
            get => 
                this._imglstTreeview;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._imglstTreeview = value;
        }
    }
}

