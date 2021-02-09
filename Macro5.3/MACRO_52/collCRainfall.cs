namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;

    internal class collCRainfall
    {
        private Collection mCol;

        public collCRainfall()
        {
            this.Class_Initialize_Renamed();
        }

        public CRainfall Add(ref string sKey = "")
        {
            CRainfall item = new CRainfall();
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

        public CRainfall this[object vntIndexKey] =>
            (CRainfall) this.mCol[vntIndexKey];

        public int Count =>
            this.mCol.Count;
    }
}

