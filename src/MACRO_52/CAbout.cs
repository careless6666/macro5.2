namespace MACRO_52
{
    using MACRO_52.My.Resources;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    internal class CAbout : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Command1")]
        private Button _Command1;
        [AccessedThroughProperty("Image1")]
        private PictureBox _Image1;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("lnkMailtoNick")]
        private LinkLabel _lnkMailtoNick;
        private CfrmMain frmMain;

        public CAbout(ref CfrmMain frm)
        {
            base.Load += new EventHandler(this.Form63_Load);
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.InitializeComponent();
            this.frmMain = frm;
        }

        private void Command1_Click(object eventSender, EventArgs eventArgs)
        {
            this.Close();
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

        private void Form63_Load(object eventSender, EventArgs eventArgs)
        {
            this.Icon = this.frmMain.Icon;
            this.lnkMailtoNick.Text = MACRO_52.My.Resources.Resources.Mail_NicholasJarvis;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CAbout));
            this.Command1 = new Button();
            this.Image1 = new PictureBox();
            this.Label5 = new Label();
            this.Label9 = new Label();
            this.Label2 = new Label();
            this.Label7 = new Label();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.lnkMailtoNick = new LinkLabel();
            ((ISupportInitialize) this.Image1).BeginInit();
            this.SuspendLayout();
            this.Command1.BackColor = SystemColors.Control;
            this.Command1.Cursor = Cursors.Default;
            this.Command1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Command1.ForeColor = SystemColors.ControlText;
            Point point = new Point(0x178, 0x108);
            this.Command1.Location = point;
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = RightToLeft.No;
            Size size = new Size(0x59, 0x19);
            this.Command1.Size = size;
            this.Command1.TabIndex = 7;
            this.Command1.Text = "OK";
            this.Command1.UseVisualStyleBackColor = false;
            this.Image1.Cursor = Cursors.Default;
            this.Image1.Image = (Image) manager.GetObject("Image1.Image");
            point = new Point(0x110, 0x40);
            this.Image1.Location = point;
            this.Image1.Name = "Image1";
            size = new Size(0xc3, 190);
            this.Image1.Size = size;
            this.Image1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image1.TabIndex = 8;
            this.Image1.TabStop = false;
            this.Label5.BackColor = Color.FromArgb(0xc0, 0xc0, 0xc0);
            this.Label5.Cursor = Cursors.Default;
            this.Label5.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.ForeColor = SystemColors.ControlText;
            point = new Point(8, 0x98);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            size = new Size(0xa9, 0x11);
            this.Label5.Size = size;
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Telephone: +46 18 672465";
            this.Label9.BackColor = Color.FromArgb(0xc0, 0xc0, 0xc0);
            this.Label9.Cursor = Cursors.Default;
            this.Label9.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = SystemColors.WindowText;
            point = new Point(8, 8);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = RightToLeft.No;
            size = new Size(0x199, 0x31);
            this.Label9.Size = size;
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Background information, latest news, a technical description, and lots more about the MACRO model can all be accessed via the MACRO Web site. ";
            this.Label2.BackColor = Color.FromArgb(0xc0, 0xc0, 0xc0);
            this.Label2.Cursor = Cursors.Default;
            this.Label2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x40);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            size = new Size(0x101, 0x19);
            this.Label2.Size = size;
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Background art courtesy of \x00a9Eastman Kodak ";
            this.Label7.BackColor = Color.FromArgb(0xc0, 0xc0, 0xc0);
            this.Label7.Cursor = Cursors.Default;
            this.Label7.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0xb0);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = RightToLeft.No;
            size = new Size(0x79, 0x11);
            this.Label7.Size = size;
            this.Label7.TabIndex = 2;
            this.Label7.Text = "FAX: +46 18 672795";
            this.Label4.BackColor = Color.FromArgb(0xc0, 0xc0, 0xc0);
            this.Label4.Cursor = Cursors.Default;
            this.Label4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x88);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            size = new Size(0xc1, 0x11);
            this.Label4.Size = size;
            this.Label4.TabIndex = 1;
            this.Label4.Text = "SLU, Box 7014, 750 07 Uppsala";
            this.Label3.BackColor = Color.FromArgb(0xc0, 0xc0, 0xc0);
            this.Label3.Cursor = Cursors.Default;
            this.Label3.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = SystemColors.WindowText;
            point = new Point(8, 0x60);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            size = new Size(0x71, 0x11);
            this.Label3.Size = size;
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Contact person :";
            this.lnkMailtoNick.AutoSize = true;
            point = new Point(8, 0x7a);
            this.lnkMailtoNick.Location = point;
            this.lnkMailtoNick.Name = "lnkMailtoNick";
            size = new Size(0x23, 14);
            this.lnkMailtoNick.Size = size;
            this.lnkMailtoNick.TabIndex = 10;
            this.lnkMailtoNick.TabStop = true;
            this.lnkMailtoNick.Text = "none";
            SizeF ef = new SizeF(7f, 14f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(0xc0, 0xc0, 0xc0);
            size = new Size(0x1da, 0x126);
            this.ClientSize = size;
            this.Controls.Add(this.lnkMailtoNick);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Cursor = Cursors.Default;
            this.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ForeColor = SystemColors.WindowText;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            point = new Point(0x2e, 0x58);
            this.Location = point;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CAbout";
            this.RightToLeft = RightToLeft.No;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "About MACRO 5.2";
            ((ISupportInitialize) this.Image1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void lnkMACROWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://bgf.mv.slu.se/macro");
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                MessageBox.Show("Unable to open link that was clicked.");
                ProjectData.ClearProjectError();
            }
        }

        private void lnkMailtoNick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("mailto:nicholas.jarvis@mv.slu.se");
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                MessageBox.Show("Unable to open link that was clicked.");
                ProjectData.ClearProjectError();
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

        public virtual PictureBox Image1
        {
            [DebuggerNonUserCode]
            get => 
                this._Image1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Image1 = value;
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

        public virtual Label Label9
        {
            [DebuggerNonUserCode]
            get => 
                this._Label9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label9 = value;
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

        public virtual Label Label7
        {
            [DebuggerNonUserCode]
            get => 
                this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label7 = value;
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

        internal virtual LinkLabel lnkMailtoNick
        {
            [DebuggerNonUserCode]
            get => 
                this._lnkMailtoNick;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.lnkMailtoNick_LinkClicked);
                if (!ReferenceEquals(this._lnkMailtoNick, null))
                {
                    this._lnkMailtoNick.LinkClicked -= handler;
                }
                this._lnkMailtoNick = value;
                if (!ReferenceEquals(this._lnkMailtoNick, null))
                {
                    this._lnkMailtoNick.LinkClicked += handler;
                }
            }
        }
    }
}

