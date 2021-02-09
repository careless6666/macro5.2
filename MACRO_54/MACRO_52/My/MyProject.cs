namespace MACRO_52.My
{
    using MACRO_52;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [GeneratedCode("MyTemplate", "8.0.0.0"), HideModuleName, StandardModule]
    internal sealed class MyProject
    {
        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
        private static readonly ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();
        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer =>
            m_ComputerObjectProvider.GetInstance;

        [HelpKeyword("My.Application")]
        internal static MyApplication Application =>
            m_AppObjectProvider.GetInstance;

        [HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User =>
            m_UserObjectProvider.GetInstance;

        [HelpKeyword("My.Forms")]
        internal static MyForms Forms =>
            m_MyFormsObjectProvider.GetInstance;

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices =>
            m_MyWebServicesObjectProvider.GetInstance;

        [EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        internal sealed class MyForms
        {
            public MACRO_52.CfrmMain m_CfrmMain;
            public MACRO_52.CfrmSave m_CfrmSave;
            public MACRO_52.CfrmSaveAs m_CfrmSaveAs;
            public MACRO_52.CfrmSUFIMain m_CfrmSUFIMain;
            public MACRO_52.frmFOOTPRINTPedotransferInput m_frmFOOTPRINTPedotransferInput;
            public MACRO_52.frmNewSUFIIteration m_frmNewSUFIIteration;
            public MACRO_52.frmPedotransfer m_frmPedotransfer;
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T: Form, new()
            {
                T local;
                if ((((Instance == null) || Instance.IsDisposed) ? 1 : 0) == 0)
                {
                    local = Instance;
                }
                else
                {
                    TargetInvocationException exception;
                    bool flag1;
                    if (ReferenceEquals(m_FormBeingCreated, null))
                    {
                        m_FormBeingCreated = new Hashtable();
                    }
                    else if (m_FormBeingCreated.ContainsKey(typeof(T)))
                    {
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                    }
                    m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        local = Activator.CreateInstance<T>();
                    }
                    catch (TargetInvocationException exception1) when ((() => // NOTE: To create compilable code, filter at IL offset 0096 was represented using lambda expression.
                    {
                        ProjectData.SetProjectError(exception = exception1);
                        flag1 = !ReferenceEquals(exception.InnerException, null);
                        return (T) flag1;
                    })())
                    {
                        string[] args = new string[] { exception.InnerException.Message };
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", args), exception.InnerException);
                    }
                    finally
                    {
                        m_FormBeingCreated.Remove(typeof(T));
                    }
                }
                return local;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T: Form
            {
                instance.Dispose();
                T local = default(T);
                instance = local;
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => 
                base.Equals(o);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => 
                base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType() => 
                typeof(MyProject.MyForms);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => 
                base.ToString();

            public MACRO_52.CfrmMain CfrmMain
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_CfrmMain = Create__Instance__<MACRO_52.CfrmMain>(this.m_CfrmMain);
                    return this.m_CfrmMain;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_CfrmMain))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<MACRO_52.CfrmMain>(ref this.m_CfrmMain);
                    }
                }
            }

            public MACRO_52.CfrmSave CfrmSave
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_CfrmSave = Create__Instance__<MACRO_52.CfrmSave>(this.m_CfrmSave);
                    return this.m_CfrmSave;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_CfrmSave))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<MACRO_52.CfrmSave>(ref this.m_CfrmSave);
                    }
                }
            }

            public MACRO_52.CfrmSaveAs CfrmSaveAs
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_CfrmSaveAs = Create__Instance__<MACRO_52.CfrmSaveAs>(this.m_CfrmSaveAs);
                    return this.m_CfrmSaveAs;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_CfrmSaveAs))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<MACRO_52.CfrmSaveAs>(ref this.m_CfrmSaveAs);
                    }
                }
            }

            public MACRO_52.CfrmSUFIMain CfrmSUFIMain
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_CfrmSUFIMain = Create__Instance__<MACRO_52.CfrmSUFIMain>(this.m_CfrmSUFIMain);
                    return this.m_CfrmSUFIMain;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_CfrmSUFIMain))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<MACRO_52.CfrmSUFIMain>(ref this.m_CfrmSUFIMain);
                    }
                }
            }

            public MACRO_52.frmFOOTPRINTPedotransferInput frmFOOTPRINTPedotransferInput
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_frmFOOTPRINTPedotransferInput = Create__Instance__<MACRO_52.frmFOOTPRINTPedotransferInput>(this.m_frmFOOTPRINTPedotransferInput);
                    return this.m_frmFOOTPRINTPedotransferInput;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_frmFOOTPRINTPedotransferInput))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<MACRO_52.frmFOOTPRINTPedotransferInput>(ref this.m_frmFOOTPRINTPedotransferInput);
                    }
                }
            }

            public MACRO_52.frmNewSUFIIteration frmNewSUFIIteration
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_frmNewSUFIIteration = Create__Instance__<MACRO_52.frmNewSUFIIteration>(this.m_frmNewSUFIIteration);
                    return this.m_frmNewSUFIIteration;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_frmNewSUFIIteration))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<MACRO_52.frmNewSUFIIteration>(ref this.m_frmNewSUFIIteration);
                    }
                }
            }

            public MACRO_52.frmPedotransfer frmPedotransfer
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_frmPedotransfer = Create__Instance__<MACRO_52.frmPedotransfer>(this.m_frmPedotransfer);
                    return this.m_frmPedotransfer;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_frmPedotransfer))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<MACRO_52.frmPedotransfer>(ref this.m_frmPedotransfer);
                    }
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T: new() => 
                (instance != null) ? instance : Activator.CreateInstance<T>();

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                T local = default(T);
                instance = local;
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override bool Equals(object o) => 
                base.Equals(o);

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override int GetHashCode() => 
                base.GetHashCode();

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType() => 
                typeof(MyProject.MyWebServices);

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override string ToString() => 
                base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T: new()
        {
            [CompilerGenerated, ThreadStatic]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }
        }
    }
}

