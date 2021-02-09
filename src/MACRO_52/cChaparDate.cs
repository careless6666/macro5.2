namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;

    internal class cChaparDate
    {
        private int mvarm_Date;
        private short[] m_Indexes;
        private double[] Values;
        private object m_RepeatPrevious;

        public void Init(ref short nvals)
        {
            this.m_Indexes = new short[nvals + 1];
            this.Values = new double[nvals + 1];
        }

        public void SetArrays(ref float[] vals, ref short[] indexes)
        {
            short num2 = (short) Information.UBound(this.Values, 1);
            short index = 1;
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    return;
                }
                this.Values[index] = vals[index];
                this.m_Indexes[index] = indexes[index];
                index = (short) (index + 1);
            }
        }

        public void SetArrays2(ref float[] vals, ref short[] indexes)
        {
            this.Values = new double[Information.UBound(vals, 1) + 1];
            this.m_Indexes = new short[Information.UBound(indexes, 1) + 1];
            short num2 = (short) Information.UBound(vals, 1);
            short index = 1;
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    return;
                }
                this.Values[index] = vals[index];
                this.m_Indexes[index] = indexes[index];
                index = (short) (index + 1);
            }
        }

        public bool m_Repeat
        {
            get => 
                Conversions.ToBoolean(this.m_RepeatPrevious);
            set => 
                this.m_RepeatPrevious = value;
        }

        public int m_Date
        {
            get => 
                this.mvarm_Date;
            set => 
                this.mvarm_Date = value;
        }

        public short m_Length =>
            (short) Information.UBound(this.m_Indexes, 1);

        // Warning: Properties with arguments are not supported in C#. Getter of a index property was decompiled as a method.
        public short get_index(short i) => 
            this.m_Indexes[i];

        // Warning: Properties with arguments are not supported in C#. Setter of a index property was decompiled as a method.
        public void set_index(short i, short Value)
        {
            this.m_Indexes[i] = Value;
        }


        // Warning: Properties with arguments are not supported in C#. Getter of a Value property was decompiled as a method.
        public double get_Value(short i) => 
            this.Values[i];

        // Warning: Properties with arguments are not supported in C#. Setter of a Value property was decompiled as a method.
        public void set_Value(short i, double Value)
        {
            this.Values[i] = Value;
        }

    }
}

