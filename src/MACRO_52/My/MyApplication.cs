namespace MACRO_52.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows.Forms;

    [EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("MyTemplate", "8.0.0.0")]
    internal class MyApplication : WindowsFormsApplicationBase
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();

        [DebuggerStepThrough]
        public MyApplication() : base(AuthenticationMode.Windows)
        {
            lock (__ENCList)
            {
                __ENCList.Add(new WeakReference(this));
            }
            this.IsSingleInstance = false;
            this.EnableVisualStyles = true;
            this.SaveMySettingsOnExit = false;
            this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Advanced), STAThread]
        internal static void Main(string[] Args)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            }
            finally
            {
            }
            MyProject.Application.Run(Args);
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            this.MainForm = MyProject.Forms.CfrmMain;
        }
    }
}

