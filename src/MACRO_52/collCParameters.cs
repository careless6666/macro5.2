namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;

    internal class collCParameters
    {
        private Collection mCol;

        public collCParameters()
        {
            this.Class_Initialize_Renamed();
        }

        public CParameters Add(ref string sKey = "")
        {
            CParameters item = new CParameters();
            if (Strings.Len((string) sKey) == 0)
            {
                this.mCol.Add(item, null, null, null);
            }
            else
            {
                this.mCol.Add(item, sKey, null, null);
            }
            return null;
        }

        private void Class_Initialize_Renamed()
        {
            this.mCol = new Collection();
        }

        private void Class_Terminate_Renamed()
        {
            this.mCol = null;
        }

        protected override void Finalize()
        {
            this.Class_Terminate_Renamed();
            base.Finalize();
        }

        public void Remove(ref object vntIndexKey)
        {
            object[] arguments = new object[] { vntIndexKey };
            bool[] copyBack = new bool[] { true };
            NewLateBinding.LateCall(this.mCol, null, "Remove", arguments, null, null, copyBack, true);
            if (copyBack[0])
            {
                vntIndexKey = arguments[0];
            }
        }

        public CParameters this[object vntIndexKey] =>
            (CParameters) this.mCol[vntIndexKey];

        public int Count =>
            this.mCol.Count;
    }
}

