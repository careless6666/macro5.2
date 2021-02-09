namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;

    internal class cChaparDates
    {
        public collChaparDates m_ChaparDates = new collChaparDates();

        public void Add(ref short FirstDate, ref short SecondDate)
        {
            collChaparDates chaparDates = this.m_ChaparDates;
            float[] vals = new float[((short) (chaparDates[(short) FirstDate].m_Length + chaparDates[(short) SecondDate].m_Length)) + 1];
            short[] indexes = new short[((short) (chaparDates[(short) FirstDate].m_Length + chaparDates[(short) SecondDate].m_Length)) + 1];
            short index = 1;
            short length = chaparDates[(short) FirstDate].m_Length;
            short i = 1;
            while (true)
            {
                short num5 = length;
                if (i > num5)
                {
                    index = i;
                    short num4 = chaparDates[(short) SecondDate].m_Length;
                    i = 1;
                    while (true)
                    {
                        num5 = num4;
                        if (i > num5)
                        {
                            chaparDates[(short) FirstDate].SetArrays2(ref vals, ref indexes);
                            chaparDates = null;
                            return;
                        }
                        vals[index] = (float) chaparDates[(short) SecondDate].get_Value(i);
                        indexes[index] = chaparDates[(short) SecondDate].get_index(i);
                        index = (short) (index + 1);
                        i = (short) (i + 1);
                    }
                }
                vals[i] = (float) chaparDates[(short) FirstDate].get_Value(i);
                indexes[i] = chaparDates[(short) FirstDate].get_index(i);
                i = (short) (i + 1);
            }
        }

        public void Merge()
        {
            int count = this.m_ChaparDates.Count;
        }

        public void PrintToIndump(ref short fp, ref int S, ref int e)
        {
            short count = (short) this.m_ChaparDates.Count;
            short num = 1;
            while (num <= count)
            {
                short[] array = new short[this.m_ChaparDates[num].m_Length + 1];
                float[] numArray2 = new float[this.m_ChaparDates[num].m_Length + 1];
                short num4 = (short) Information.UBound(array, 1);
                short index = 1;
                while (true)
                {
                    short num6 = num4;
                    if (index > num6)
                    {
                        if ((this.m_ChaparDates[num].m_Date >= S) & (this.m_ChaparDates[num].m_Date <= e))
                        {
                            object[] output = new object[] { "23 1" };
                            FileSystem.PrintLine(fp, output);
                            output = new object[] { Indump.rformat(ref this.m_ChaparDates[num].m_Date, ref "############") };
                            FileSystem.PrintLine(fp, output);
                            output = new object[] { "101 " + Conversions.ToString(Information.UBound(array, 1)) };
                            FileSystem.PrintLine(fp, output);
                            Indump.WriteIntegerArray(ref 10, ref array, ref fp);
                            output = new object[] { "102 " + Conversions.ToString(Information.UBound(numArray2, 1)) };
                            FileSystem.PrintLine(fp, output);
                            Indump.WriteParameterArray(ref 10, ref numArray2, ref fp, ref "0.0000E+00");
                        }
                        num = (short) (num + 1);
                        break;
                    }
                    array[index] = this.m_ChaparDates[num].get_index(index);
                    numArray2[index] = (float) this.m_ChaparDates[num].get_Value(index);
                    index = (short) (index + 1);
                }
            }
        }

        private void Sort(ref short[] index, ref float[] vals)
        {
            short num3 = (short) Information.UBound(vals, 1);
            short num6 = num3;
            short num2 = 1;
            while (num2 <= num6)
            {
                short num7 = (short) (num2 + 1);
                short num = num3;
                while (true)
                {
                    short num8 = num7;
                    if (num < num8)
                    {
                        num2 = (short) (num2 + 1);
                        break;
                    }
                    if (index[num - 1] > index[num])
                    {
                        index[num - 1] = index[num];
                        vals[num - 1] = vals[num];
                        index[num] = index[num - 1];
                        vals[num] = vals[num - 1];
                    }
                    num = (short) (num + -1);
                }
            }
        }

        public void SortByDate()
        {
            collChaparDates dates = new collChaparDates();
            int count = this.m_ChaparDates.Count;
            collChaparDates chaparDates = this.m_ChaparDates;
            float[] values = new float[chaparDates[1].m_Length + 1];
            short[] indexes = new short[chaparDates[1].m_Length + 1];
            short length = chaparDates[1].m_Length;
            short index = 1;
            while (true)
            {
                short num13 = length;
                if (index > num13)
                {
                    dates.Add(ref chaparDates[1].m_Date, ref indexes, ref values, ref false, ref "");
                    short num7 = (short) count;
                    index = 2;
                    while (index <= num7)
                    {
                        bool flag = false;
                        values = new float[chaparDates[index].m_Length + 1];
                        indexes = new short[chaparDates[index].m_Length + 1];
                        short num8 = chaparDates[index].m_Length;
                        short num3 = 1;
                        while (true)
                        {
                            num13 = num8;
                            if (num3 > num13)
                            {
                                int num9 = dates.Count;
                                int num2 = 1;
                                while (true)
                                {
                                    int num14 = num9;
                                    if (num2 <= num14)
                                    {
                                        if (chaparDates[index].m_Date < dates[num2].m_Date)
                                        {
                                            dates.Add(ref chaparDates[index].m_Date, ref indexes, ref values, ref false, ref Conversions.ToString(num2));
                                            flag = true;
                                        }
                                        else
                                        {
                                            if (chaparDates[index].m_Date != dates[num2].m_Date)
                                            {
                                                num2++;
                                                continue;
                                            }
                                            values = new float[((short) (chaparDates[index].m_Length + dates[num2].m_Length)) + 1];
                                            indexes = new short[((short) (chaparDates[index].m_Length + dates[num2].m_Length)) + 1];
                                            short num10 = chaparDates[index].m_Length;
                                            num3 = 1;
                                            while (true)
                                            {
                                                num13 = num10;
                                                if (num3 > num13)
                                                {
                                                    short num11 = (short) (chaparDates[index].m_Length + dates[num2].m_Length);
                                                    num3 = (short) (chaparDates[index].m_Length + 1);
                                                    while (true)
                                                    {
                                                        num13 = num11;
                                                        if (num3 > num13)
                                                        {
                                                            dates[num2].Init(ref (short) Information.UBound(values, 1));
                                                            this.Sort(ref indexes, ref values);
                                                            dates[num2].SetArrays(ref values, ref indexes);
                                                            flag = true;
                                                            break;
                                                        }
                                                        values[num3] = (float) dates[num2].get_Value((short) (num3 - chaparDates[index].m_Length));
                                                        indexes[num3] = dates[num2].get_index((short) (num3 - chaparDates[index].m_Length));
                                                        num3 = (short) (num3 + 1);
                                                    }
                                                    break;
                                                }
                                                values[num3] = (float) chaparDates[index].get_Value(num3);
                                                indexes[num3] = chaparDates[index].get_index(num3);
                                                num3 = (short) (num3 + 1);
                                            }
                                        }
                                    }
                                    if (!flag)
                                    {
                                        dates.Add(ref chaparDates[index].m_Date, ref indexes, ref values, ref false, ref "");
                                    }
                                    index = (short) (index + 1);
                                    break;
                                }
                                break;
                            }
                            values[num3] = (float) chaparDates[index].get_Value(num3);
                            indexes[num3] = chaparDates[index].get_index(num3);
                            num3 = (short) (num3 + 1);
                        }
                    }
                    chaparDates = null;
                    this.m_ChaparDates = null;
                    this.m_ChaparDates = dates;
                    dates = null;
                    return;
                }
                values[index] = (float) chaparDates[1].get_Value(index);
                indexes[index] = chaparDates[1].get_index(index);
                index = (short) (index + 1);
            }
        }

        public collChaparDates ChaparDates
        {
            get => 
                this.m_ChaparDates;
            set => 
                this.m_ChaparDates = value;
        }
    }
}

