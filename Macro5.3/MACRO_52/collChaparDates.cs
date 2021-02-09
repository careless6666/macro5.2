namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;

    internal class collChaparDates
    {
        private Collection mCol;

        public collChaparDates()
        {
            this.Class_Initialize_Renamed();
        }

        public cChaparDate Add(ref int m_Date, ref short[] indexes, ref float[] Values, ref bool Repeat = false, ref string Before = "")
        {
            cChaparDate item = new cChaparDate {
                m_Date = m_Date,
                m_Repeat = Repeat
            };
            int num2 = Information.UBound(indexes, 1);
            item.Init(ref (short) num2);
            short num4 = (short) num2;
            short i = 1;
            while (true)
            {
                short num5 = num4;
                if (i > num5)
                {
                    if (Strings.Len((string) Before) == 0)
                    {
                        this.mCol.Add(item, null, null, null);
                    }
                    else
                    {
                        this.mCol.Add(item, null, Conversions.ToShort((string) Before), null);
                    }
                    return null;
                }
                item.set_index(i, indexes[i]);
                item.set_Value(i, (double) Values[i]);
                i = (short) (i + 1);
            }
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

        public cChaparDate this[object vntIndexKey] =>
            (cChaparDate) this.mCol[vntIndexKey];

        public int Count =>
            this.mCol.Count;
    }
}

