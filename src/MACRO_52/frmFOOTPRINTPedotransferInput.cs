namespace MACRO_52
{
    using MACRO_52.My.Resources;
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
    public class frmFOOTPRINTPedotransferInput : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;
        [AccessedThroughProperty("grpAdditionalInput")]
        private GroupBox _grpAdditionalInput;
        [AccessedThroughProperty("txtStonePorosity")]
        private TextBox _txtStonePorosity;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("chkCryicPergelic")]
        private CheckBox _chkCryicPergelic;
        [AccessedThroughProperty("chkAridicTorric")]
        private CheckBox _chkAridicTorric;
        [AccessedThroughProperty("chkZeroTillOrManure")]
        private CheckBox _chkZeroTillOrManure;
        [AccessedThroughProperty("grpLandUse")]
        private GroupBox _grpLandUse;
        [AccessedThroughProperty("optPerennial")]
        private RadioButton _optPerennial;
        [AccessedThroughProperty("cmdSetInformation")]
        private Button _cmdSetInformation;
        [AccessedThroughProperty("chkPloughPan")]
        private CheckBox _chkPloughPan;
        [AccessedThroughProperty("optNoTillPerennial")]
        private RadioButton _optNoTillPerennial;
        [AccessedThroughProperty("optReducedTilled")]
        private RadioButton _optReducedTilled;
        [AccessedThroughProperty("optConventionalTill")]
        private RadioButton _optConventionalTill;
        [AccessedThroughProperty("grpIntroduction")]
        private GroupBox _grpIntroduction;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("btnPrevious")]
        private Button _btnPrevious;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("chkTrafficked")]
        private CheckBox _chkTrafficked;
        private ToolTip m_tooltip;
        private MACROConstants.FootprintPedotransferStep m_Step;

        public frmFOOTPRINTPedotransferInput()
        {
            base.Load += new EventHandler(this.frmFOOTPRINTPedotransferInput_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.m_tooltip = new ToolTip();
            this.InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.m_Step -= 1;
            this.DisplayStep();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdSetInformation_Click(object sender, EventArgs e)
        {
            this.m_Step += 1;
            if (this.m_Step == MACROConstants.FootprintPedotransferStep.Finish)
            {
                this.Finish();
            }
            this.DisplayStep();
        }

        private void DisplayStep()
        {
            Point point;
            this.HideAll();
            frmFOOTPRINTPedotransferInput input = this;
            switch (this.m_Step)
            {
                case MACROConstants.FootprintPedotransferStep.Introduction:
                    input.grpIntroduction.Visible = true;
                    point = new Point(12, 12);
                    input.grpIntroduction.Location = point;
                    this.btnPrevious.Enabled = false;
                    this.cmdSetInformation.Enabled = true;
                    break;

                case MACROConstants.FootprintPedotransferStep.LandUse:
                    input.grpLandUse.Visible = true;
                    point = new Point(12, 12);
                    input.grpLandUse.Location = point;
                    this.btnPrevious.Enabled = true;
                    break;

                case MACROConstants.FootprintPedotransferStep.AdditionalInput:
                    input.grpAdditionalInput.Visible = true;
                    point = new Point(12, 12);
                    input.grpAdditionalInput.Location = point;
                    input.cmdSetInformation.Text = "&Finish";
                    break;

                default:
                    break;
            }
            input = null;
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (((!disposing || (this.components == null)) ? 0 : 1) != 0)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void Finish()
        {
            int num = (int) Interaction.MsgBox("This will overwrite current parameter values. Do you wish to continue?", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null);
            if (num == 6)
            {
                this.DialogResult = DialogResult.OK;
                GlobalVariables.sw_landuse = !this.optConventionalTill.Checked ? (!this.optReducedTilled.Checked ? (!this.optNoTillPerennial.Checked ? MACROConstants.Switch.Tritium : MACROConstants.Switch.Perennial) : MACROConstants.Switch.Annual) : MACROConstants.Switch.BareSoil;
                this.Close();
            }
            else if (num == 7)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                this.m_Step = MACROConstants.FootprintPedotransferStep.AdditionalInput;
                this.DisplayStep();
            }
        }

        private void frmFOOTPRINTPedotransferInput_Load(object sender, EventArgs e)
        {
            this.m_tooltip.SetToolTip(this.optConventionalTill, MACRO_52.My.Resources.Resources.Tooltip_CONVENTIONALTILL);
            this.m_tooltip.SetToolTip(this.optReducedTilled, MACRO_52.My.Resources.Resources.Tooltip_REDUCEDTILL);
            this.m_tooltip.SetToolTip(this.optPerennial, MACRO_52.My.Resources.Resources.Tooltip_PERENNIAL);
            this.m_Step = MACROConstants.FootprintPedotransferStep.Introduction;
            if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
            {
                this.chkTrafficked.Visible = true;
                this.chkTrafficked.Checked = false;
            }
            else
            {
                this.chkTrafficked.Visible = false;
                this.chkTrafficked.Checked = false;
            }
            this.DisplayStep();
        }

        private void HideAll()
        {
            frmFOOTPRINTPedotransferInput input = this;
            input.grpAdditionalInput.Visible = false;
            input.grpIntroduction.Visible = false;
            input.grpLandUse.Visible = false;
            input = null;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmFOOTPRINTPedotransferInput));
            this.Cancel_Button = new Button();
            this.grpAdditionalInput = new GroupBox();
            this.chkTrafficked = new CheckBox();
            this.chkZeroTillOrManure = new CheckBox();
            this.chkCryicPergelic = new CheckBox();
            this.chkAridicTorric = new CheckBox();
            this.txtStonePorosity = new TextBox();
            this.Label2 = new Label();
            this.grpLandUse = new GroupBox();
            this.optPerennial = new RadioButton();
            this.chkPloughPan = new CheckBox();
            this.optNoTillPerennial = new RadioButton();
            this.optReducedTilled = new RadioButton();
            this.optConventionalTill = new RadioButton();
            this.cmdSetInformation = new Button();
            this.grpIntroduction = new GroupBox();
            this.Label8 = new Label();
            this.Label6 = new Label();
            this.Label5 = new Label();
            this.Label1 = new Label();
            this.btnPrevious = new Button();
            this.grpAdditionalInput.SuspendLayout();
            this.grpLandUse.SuspendLayout();
            this.grpIntroduction.SuspendLayout();
            this.SuspendLayout();
            this.Cancel_Button.Anchor = AnchorStyles.None;
            this.Cancel_Button.DialogResult = DialogResult.Cancel;
            Point point = new Point(0x153, 0xea);
            this.Cancel_Button.Location = point;
            this.Cancel_Button.Name = "Cancel_Button";
            Size size = new Size(0x43, 0x17);
            this.Cancel_Button.Size = size;
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.grpAdditionalInput.Controls.Add(this.chkTrafficked);
            this.grpAdditionalInput.Controls.Add(this.chkZeroTillOrManure);
            this.grpAdditionalInput.Controls.Add(this.chkCryicPergelic);
            this.grpAdditionalInput.Controls.Add(this.chkAridicTorric);
            this.grpAdditionalInput.Controls.Add(this.txtStonePorosity);
            this.grpAdditionalInput.Controls.Add(this.Label2);
            point = new Point(0x24b, 220);
            this.grpAdditionalInput.Location = point;
            this.grpAdditionalInput.Name = "grpAdditionalInput";
            size = new Size(0x22c, 0xc7);
            this.grpAdditionalInput.Size = size;
            this.grpAdditionalInput.TabIndex = 1;
            this.grpAdditionalInput.TabStop = false;
            this.grpAdditionalInput.Text = "Additional input";
            this.chkTrafficked.AutoSize = true;
            this.chkTrafficked.Checked = true;
            this.chkTrafficked.CheckState = CheckState.Checked;
            point = new Point(9, 0x68);
            this.chkTrafficked.Location = point;
            this.chkTrafficked.Name = "chkTrafficked";
            size = new Size(0x4a, 0x11);
            this.chkTrafficked.Size = size;
            this.chkTrafficked.TabIndex = 10;
            this.chkTrafficked.Text = "Trafficked";
            this.chkTrafficked.UseVisualStyleBackColor = true;
            this.chkZeroTillOrManure.AutoSize = true;
            point = new Point(9, 0x51);
            this.chkZeroTillOrManure.Location = point;
            this.chkZeroTillOrManure.Name = "chkZeroTillOrManure";
            size = new Size(0x71, 0x11);
            this.chkZeroTillOrManure.Size = size;
            this.chkZeroTillOrManure.TabIndex = 9;
            this.chkZeroTillOrManure.Text = "Manure additions?";
            this.chkZeroTillOrManure.UseVisualStyleBackColor = true;
            this.chkCryicPergelic.AutoSize = true;
            point = new Point(9, 0x3a);
            this.chkCryicPergelic.Location = point;
            this.chkCryicPergelic.Name = "chkCryicPergelic";
            size = new Size(0x8f, 0x11);
            this.chkCryicPergelic.Size = size;
            this.chkCryicPergelic.TabIndex = 5;
            this.chkCryicPergelic.Text = "Climate cryic or pergelic?";
            this.chkCryicPergelic.UseVisualStyleBackColor = true;
            this.chkAridicTorric.AutoSize = true;
            point = new Point(9, 0x23);
            this.chkAridicTorric.Location = point;
            this.chkAridicTorric.Name = "chkAridicTorric";
            size = new Size(0x84, 0x11);
            this.chkAridicTorric.Size = size;
            this.chkAridicTorric.TabIndex = 4;
            this.chkAridicTorric.Text = "Climate aridic or torric?";
            this.chkAridicTorric.UseVisualStyleBackColor = true;
            point = new Point(0x59, 9);
            this.txtStonePorosity.Location = point;
            this.txtStonePorosity.Name = "txtStonePorosity";
            size = new Size(0x25, 20);
            this.txtStonePorosity.Size = size;
            this.txtStonePorosity.TabIndex = 3;
            this.txtStonePorosity.Text = "0";
            this.Label2.AutoSize = true;
            point = new Point(6, 0x10);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            size = new Size(0x4d, 13);
            this.Label2.Size = size;
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Stone porosity:";
            this.grpLandUse.Controls.Add(this.optPerennial);
            this.grpLandUse.Controls.Add(this.chkPloughPan);
            this.grpLandUse.Controls.Add(this.optNoTillPerennial);
            this.grpLandUse.Controls.Add(this.optReducedTilled);
            this.grpLandUse.Controls.Add(this.optConventionalTill);
            point = new Point(12, 12);
            this.grpLandUse.Location = point;
            this.grpLandUse.Name = "grpLandUse";
            size = new Size(0x22c, 0xca);
            this.grpLandUse.Size = size;
            this.grpLandUse.TabIndex = 0x2d;
            this.grpLandUse.TabStop = false;
            this.grpLandUse.Text = "Land use";
            this.optPerennial.AutoSize = true;
            point = new Point(13, 0x59);
            this.optPerennial.Location = point;
            this.optPerennial.Name = "optPerennial";
            size = new Size(0x45, 0x11);
            this.optPerennial.Size = size;
            this.optPerennial.TabIndex = 6;
            this.optPerennial.Text = "Perennial";
            this.optPerennial.UseVisualStyleBackColor = true;
            this.chkPloughPan.AutoSize = true;
            this.chkPloughPan.Enabled = false;
            point = new Point(0xa9, 0x13);
            this.chkPloughPan.Location = point;
            this.chkPloughPan.Name = "chkPloughPan";
            size = new Size(80, 0x11);
            this.chkPloughPan.Size = size;
            this.chkPloughPan.TabIndex = 4;
            this.chkPloughPan.Text = "Plough pan";
            this.chkPloughPan.UseVisualStyleBackColor = true;
            this.optNoTillPerennial.AutoSize = true;
            this.optNoTillPerennial.Checked = true;
            point = new Point(13, 0x43);
            this.optNoTillPerennial.Location = point;
            this.optNoTillPerennial.Name = "optNoTillPerennial";
            size = new Size(0x53, 0x11);
            this.optNoTillPerennial.Size = size;
            this.optNoTillPerennial.TabIndex = 2;
            this.optNoTillPerennial.TabStop = true;
            this.optNoTillPerennial.Text = "No-till arable";
            this.optNoTillPerennial.UseVisualStyleBackColor = true;
            this.optReducedTilled.AutoSize = true;
            point = new Point(13, 0x2b);
            this.optReducedTilled.Location = point;
            this.optReducedTilled.Name = "optReducedTilled";
            size = new Size(0x71, 0x11);
            this.optReducedTilled.Size = size;
            this.optReducedTilled.TabIndex = 1;
            this.optReducedTilled.Text = "Reduced till arable";
            this.optReducedTilled.UseVisualStyleBackColor = true;
            this.optConventionalTill.AutoSize = true;
            point = new Point(13, 0x13);
            this.optConventionalTill.Location = point;
            this.optConventionalTill.Name = "optConventionalTill";
            size = new Size(150, 0x11);
            this.optConventionalTill.Size = size;
            this.optConventionalTill.TabIndex = 0;
            this.optConventionalTill.Text = "Conventionally-tilled arable";
            this.optConventionalTill.UseVisualStyleBackColor = true;
            this.cmdSetInformation.Enabled = false;
            point = new Point(0x1ed, 0xea);
            this.cmdSetInformation.Location = point;
            this.cmdSetInformation.Name = "cmdSetInformation";
            size = new Size(0x4b, 0x17);
            this.cmdSetInformation.Size = size;
            this.cmdSetInformation.TabIndex = 5;
            this.cmdSetInformation.Text = "&Next";
            this.cmdSetInformation.UseVisualStyleBackColor = true;
            this.grpIntroduction.Controls.Add(this.Label8);
            this.grpIntroduction.Controls.Add(this.Label6);
            this.grpIntroduction.Controls.Add(this.Label5);
            this.grpIntroduction.Controls.Add(this.Label1);
            point = new Point(0x19, 0x116);
            this.grpIntroduction.Location = point;
            this.grpIntroduction.Name = "grpIntroduction";
            size = new Size(0x22c, 0xca);
            this.grpIntroduction.Size = size;
            this.grpIntroduction.TabIndex = 0x2f;
            this.grpIntroduction.TabStop = false;
            this.grpIntroduction.Text = "Introduction";
            this.Label8.AutoSize = true;
            point = new Point(6, 0xad);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            size = new Size(0x16b, 13);
            this.Label8.Size = size;
            this.Label8.TabIndex = 3;
            this.Label8.Text = "For a complete description of the FOOTPRINT pedotransfer functions see...";
            this.Label8.Visible = false;
            point = new Point(6, 0x7b);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            size = new Size(0x220, 50);
            this.Label6.Size = size;
            this.Label6.TabIndex = 2;
            this.Label6.Text = manager.GetString("Label6.Text");
            point = new Point(6, 0x45);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            size = new Size(0x220, 0x2b);
            this.Label5.Size = size;
            this.Label5.TabIndex = 1;
            this.Label5.Text = manager.GetString("Label5.Text");
            point = new Point(6, 12);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            size = new Size(0x220, 0x34);
            this.Label1.Size = size;
            this.Label1.TabIndex = 0;
            this.Label1.Text = manager.GetString("Label1.Text");
            this.Label1.TextAlign = ContentAlignment.MiddleLeft;
            this.btnPrevious.Enabled = false;
            point = new Point(0x19c, 0xea);
            this.btnPrevious.Location = point;
            this.btnPrevious.Name = "btnPrevious";
            size = new Size(0x4b, 0x17);
            this.btnPrevious.Size = size;
            this.btnPrevious.TabIndex = 0x30;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            SizeF ef = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size = new Size(0x240, 0x109);
            this.ClientSize = size;
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.grpIntroduction);
            this.Controls.Add(this.grpAdditionalInput);
            this.Controls.Add(this.grpLandUse);
            this.Controls.Add(this.cmdSetInformation);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFOOTPRINTPedotransferInput";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FOOTPRINT pedotransfer input";
            this.grpAdditionalInput.ResumeLayout(false);
            this.grpAdditionalInput.PerformLayout();
            this.grpLandUse.ResumeLayout(false);
            this.grpLandUse.PerformLayout();
            this.grpIntroduction.ResumeLayout(false);
            this.grpIntroduction.PerformLayout();
            this.ResumeLayout(false);
        }

        private void SetSetButton()
        {
            if (GlobalVariables.Nhorizon <= 2)
            {
                this.cmdSetInformation.Enabled = false;
            }
            else if (!(this.optConventionalTill.Checked & (GlobalVariables.Nhorizon > 3)))
            {
                this.cmdSetInformation.Enabled = !(this.optReducedTilled.Checked & (GlobalVariables.Nhorizon > 3)) ? ((this.optNoTillPerennial.Checked | this.optPerennial.Checked) & (GlobalVariables.Nhorizon > 2)) : true;
            }
            else
            {
                this.cmdSetInformation.Enabled = !(this.chkPloughPan.Checked & (GlobalVariables.Nhorizon < 5));
                this.chkPloughPan.Enabled = GlobalVariables.Nhorizon >= 5;
            }
        }

        internal virtual Button Cancel_Button
        {
            [DebuggerNonUserCode]
            get => 
                this._Cancel_Button;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Cancel_Button_Click);
                if (!ReferenceEquals(this._Cancel_Button, null))
                {
                    this._Cancel_Button.Click -= handler;
                }
                this._Cancel_Button = value;
                if (!ReferenceEquals(this._Cancel_Button, null))
                {
                    this._Cancel_Button.Click += handler;
                }
            }
        }

        internal virtual GroupBox grpAdditionalInput
        {
            [DebuggerNonUserCode]
            get => 
                this._grpAdditionalInput;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._grpAdditionalInput = value;
        }

        internal virtual TextBox txtStonePorosity
        {
            [DebuggerNonUserCode]
            get => 
                this._txtStonePorosity;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._txtStonePorosity = value;
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label2 = value;
        }

        internal virtual CheckBox chkCryicPergelic
        {
            [DebuggerNonUserCode]
            get => 
                this._chkCryicPergelic;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkCryicPergelic = value;
        }

        internal virtual CheckBox chkAridicTorric
        {
            [DebuggerNonUserCode]
            get => 
                this._chkAridicTorric;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkAridicTorric = value;
        }

        internal virtual CheckBox chkZeroTillOrManure
        {
            [DebuggerNonUserCode]
            get => 
                this._chkZeroTillOrManure;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkZeroTillOrManure = value;
        }

        internal virtual GroupBox grpLandUse
        {
            [DebuggerNonUserCode]
            get => 
                this._grpLandUse;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._grpLandUse = value;
        }

        internal virtual RadioButton optPerennial
        {
            [DebuggerNonUserCode]
            get => 
                this._optPerennial;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optPerennial = value;
        }

        internal virtual Button cmdSetInformation
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdSetInformation;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdSetInformation_Click);
                if (!ReferenceEquals(this._cmdSetInformation, null))
                {
                    this._cmdSetInformation.Click -= handler;
                }
                this._cmdSetInformation = value;
                if (!ReferenceEquals(this._cmdSetInformation, null))
                {
                    this._cmdSetInformation.Click += handler;
                }
            }
        }

        internal virtual CheckBox chkPloughPan
        {
            [DebuggerNonUserCode]
            get => 
                this._chkPloughPan;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkPloughPan = value;
        }

        internal virtual RadioButton optNoTillPerennial
        {
            [DebuggerNonUserCode]
            get => 
                this._optNoTillPerennial;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optNoTillPerennial = value;
        }

        internal virtual RadioButton optReducedTilled
        {
            [DebuggerNonUserCode]
            get => 
                this._optReducedTilled;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optReducedTilled = value;
        }

        internal virtual RadioButton optConventionalTill
        {
            [DebuggerNonUserCode]
            get => 
                this._optConventionalTill;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._optConventionalTill = value;
        }

        internal virtual GroupBox grpIntroduction
        {
            [DebuggerNonUserCode]
            get => 
                this._grpIntroduction;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._grpIntroduction = value;
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label1 = value;
        }

        internal virtual Button btnPrevious
        {
            [DebuggerNonUserCode]
            get => 
                this._btnPrevious;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.btnPrevious_Click);
                if (!ReferenceEquals(this._btnPrevious, null))
                {
                    this._btnPrevious.Click -= handler;
                }
                this._btnPrevious = value;
                if (!ReferenceEquals(this._btnPrevious, null))
                {
                    this._btnPrevious.Click += handler;
                }
            }
        }

        internal virtual Label Label6
        {
            [DebuggerNonUserCode]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label6 = value;
        }

        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
        }

        internal virtual Label Label8
        {
            [DebuggerNonUserCode]
            get => 
                this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label8 = value;
        }

        internal virtual CheckBox chkTrafficked
        {
            [DebuggerNonUserCode]
            get => 
                this._chkTrafficked;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._chkTrafficked = value;
        }
    }
}

