namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Runtime.InteropServices;

    internal class CRainfall
    {
        private float[] m_Rainfall;
        private int m_nTimeSteps;
        private object m_MeanRainfall;

        private float ComputeMeanRainfall(ref bool bOnlyRainyDays)
        {
            float num2;
            int num3;
            float num4;
            int num7;
            if (!bOnlyRainyDays)
            {
                int nTimeSteps = this.m_nTimeSteps;
                num3 = 1;
                while (true)
                {
                    num7 = nTimeSteps;
                    if (num3 > num7)
                    {
                        num2 = num4 / ((float) this.m_nTimeSteps);
                        break;
                    }
                    num4 += this.m_Rainfall[num3];
                    num3++;
                }
            }
            else
            {
                int nTimeSteps = this.m_nTimeSteps;
                num3 = 1;
                while (true)
                {
                    int num;
                    num7 = nTimeSteps;
                    if (num3 > num7)
                    {
                        num2 = num4 / ((float) num);
                        break;
                    }
                    if (this.m_Rainfall[num3] > 0f)
                    {
                        num4 += this.m_Rainfall[num3];
                        num++;
                    }
                    num3++;
                }
            }
            return num2;
        }

        public string ConvertJulianDate(int juldate, ref string year_Renamed = "", ref string month_Renamed = "", ref string day_Renamed = "", ref string Hour_Renamed = "", ref string Minute_Renamed = "", ref short DateFormat = 0)
        {
            string[] strArray;
            short number = (short) (juldate % 0x5a0);
            short num2 = (short) Math.Round((double) (((double) number) / 60.0));
            number = (short) (number - (num2 * 60));
            juldate = (int) Math.Round((double) (((((double) ((juldate - number) - (num2 * 60))) / 60.0) / 24.0) + 1721424.0));
            int num3 = juldate;
            if (juldate >= 0x231519)
            {
                int num4 = (int) Math.Round(Conversion.Int((double) (((juldate - 0x1c7dd0) - 0.25) / 36524.25)));
                num3 = (int) Math.Round((double) (((juldate + 1) + num4) - Conversion.Int((double) (num4 * 0.25))));
            }
            int num5 = num3 + 0x5f4;
            int num6 = (int) Math.Round(Conversion.Int((double) (6680.0 + (((num5 - 0x253abe) - 122.1) / 365.25))));
            int num7 = (int) Math.Round((double) ((0x16d * num6) + Conversion.Int((double) (0.25 * num6))));
            int num8 = (int) Math.Round(Conversion.Int((double) (((double) (num5 - num7)) / 30.6001)));
            int num = (int) Math.Round((double) ((num5 - num7) - Conversion.Int((double) (30.6001 * num8))));
            int num10 = num8 - 1;
            if (num10 > 12)
            {
                num10 -= 12;
            }
            int num11 = num6 - 0x126b;
            if (num10 > 2)
            {
                num11--;
            }
            if (num11 <= 0)
            {
                num11--;
            }
            string sDest = Conversion.Str(num10);
            if (num10 < 10)
            {
                StringType.MidStmtStr(ref sDest, 1, 0x7fffffff, "0");
            }
            else
            {
                sDest = Strings.Trim(sDest);
            }
            string str2 = Conversion.Str(num);
            if (Conversions.ToDouble(str2) < 10.0)
            {
                StringType.MidStmtStr(ref str2, 1, 0x7fffffff, "0");
            }
            else
            {
                str2 = Strings.Trim(str2);
            }
            if (number < 0)
            {
                number = (short) (60 - ((short) (number * -1)));
                num2 = (short) (num2 - 1);
            }
            string str5 = Conversion.Str(num2);
            if (Conversions.ToDouble(str5) < 10.0)
            {
                StringType.MidStmtStr(ref str5, 1, 0x7fffffff, "0");
            }
            else
            {
                str5 = Strings.Trim(str5);
            }
            string str4 = Conversion.Str(number);
            if (Conversions.ToDouble(str4) < 10.0)
            {
                StringType.MidStmtStr(ref str4, 1, 0x7fffffff, "0");
            }
            else
            {
                str4 = Strings.Trim(str4);
            }
            if (!Information.IsNothing(year_Renamed))
            {
                year_Renamed = Conversions.ToString(num11);
            }
            if (!Information.IsNothing(month_Renamed))
            {
                month_Renamed = sDest;
            }
            if (!Information.IsNothing(day_Renamed))
            {
                day_Renamed = str2;
            }
            if (!Information.IsNothing(Hour_Renamed))
            {
                Hour_Renamed = str5;
            }
            if (!Information.IsNothing(Minute_Renamed))
            {
                Minute_Renamed = str4;
            }
            string str = "";
            switch (DateFormat)
            {
                case 0:
                    strArray = new string[] { Conversion.Str(num11), sDest, str2, " ", str5, ":", str4 };
                    str = string.Concat(strArray);
                    break;

                case 1:
                    strArray = new string[] { Conversion.Str(num11), sDest, str2, str5, str4 };
                    str = string.Concat(strArray);
                    break;

                case 2:
                    strArray = new string[] { Conversion.Str(num11), sDest, str2, " ", str5, ":", str4, ":00" };
                    str = string.Concat(strArray);
                    break;

                case 3:
                    strArray = new string[] { Conversion.Str(num11), sDest, str2, ":", str5, ":", str4 };
                    str = string.Concat(strArray);
                    break;

                case 4:
                    strArray = new string[] { Conversion.Str(num11), "-", sDest, "-", str2, " ", str5, ":", str4 };
                    str = string.Concat(strArray);
                    break;

                default:
                    break;
            }
            return str;
        }

        public void Init(ref int nTimeSteps)
        {
            this.m_nTimeSteps = nTimeSteps;
            this.m_Rainfall = new float[this.m_nTimeSteps + 1];
            this.m_MeanRainfall = -1;
        }

        public int JulianDate(string dtm)
        {
            int num5;
            int num7;
            dtm = Strings.Trim(dtm);
            dtm = Strings.Replace(dtm, " ", "", 1, -1, CompareMethod.Binary);
            dtm = Strings.Replace(dtm, ":", "", 1, -1, CompareMethod.Binary);
            dtm = Strings.Replace(dtm, "-", "", 1, -1, CompareMethod.Binary);
            int num12 = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 1, 4)));
            int num9 = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 5, 2)));
            int num = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 7, 2)));
            int num2 = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 9, 2)));
            int num8 = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 11, 2)));
            if (num12 < 0)
            {
                num12++;
            }
            if (num9 > 2)
            {
                num7 = num12;
                num5 = num9 + 1;
            }
            else
            {
                num7 = num12 - 1;
                num5 = num9 + 13;
            }
            int num4 = (int) Math.Round((double) (((Conversion.Int((double) (365.25 * num7)) + Conversion.Int((double) (30.6001 * num5))) + num) + 1720995.0));
            if ((num + (0x1f * (num9 + (12 * num12)))) > 0x8fc1d)
            {
                int num3 = (int) Math.Round((double) (0.01 * num7));
                num4 = (int) Math.Round((double) (((num4 + 2) - num3) + Conversion.Int((double) (0.25 * num3))));
            }
            return (((((num4 - 0x1a4450) * 0x18) * 60) + (num2 * 60)) + num8);
        }

        private int JulianMonth(ref int juldate)
        {
            int left = juldate;
            object obj10 = left % 0x5a0;
            object obj3 = Operators.DivideObject(obj10, (int) 60);
            obj10 = Operators.SubtractObject(obj10, Operators.MultiplyObject(obj3, (int) 60));
            left = Conversions.ToInteger(Operators.AddObject(Operators.DivideObject(Operators.DivideObject(Operators.SubtractObject(Operators.SubtractObject(left, obj10), Operators.MultiplyObject(obj3, (int) 60)), (int) 60), (int) 0x18), 0x1a4450));
            object obj4 = left;
            if (left >= 0x231519)
            {
                object obj5 = Conversion.Int((double) (((left - 0x1c7dd0) - 0.25) / 36524.25));
                obj4 = Operators.SubtractObject(Operators.AddObject(left + 1, obj5), Conversion.Int(Operators.MultiplyObject(obj5, 0.25)));
            }
            object obj6 = Operators.AddObject(obj4, 0x5f4);
            object right = Conversion.Int(Operators.AddObject(6680.0, Operators.DivideObject(Operators.SubtractObject(Operators.SubtractObject(obj6, 0x253abe), 122.1), 365.25)));
            object obj8 = Operators.AddObject(Operators.MultiplyObject(0x16d, right), Conversion.Int(Operators.MultiplyObject(0.25, right)));
            object obj9 = Conversion.Int(Operators.DivideObject(Operators.SubtractObject(obj6, obj8), 30.6001));
            object obj2 = Operators.SubtractObject(Operators.SubtractObject(obj6, obj8), Conversion.Int(Operators.MultiplyObject(30.6001, obj9)));
            object obj11 = Operators.SubtractObject(obj9, 1);
            if (Operators.ConditionalCompareObjectGreater(obj11, (int) 12, false))
            {
                obj11 = Operators.SubtractObject(obj11, (int) 12);
            }
            object obj12 = Operators.SubtractObject(right, 0x126b);
            if (Operators.ConditionalCompareObjectGreater(obj11, 2, false))
            {
                obj12 = Operators.SubtractObject(obj12, 1);
            }
            if (Operators.ConditionalCompareObjectLessEqual(obj12, 0, false))
            {
                obj12 = Operators.SubtractObject(obj12, 1);
            }
            return Conversions.ToInteger(obj11);
        }

        private int JulianYear(ref int juldate)
        {
            int left = juldate;
            object obj10 = left % 0x5a0;
            object obj3 = Operators.DivideObject(obj10, (int) 60);
            obj10 = Operators.SubtractObject(obj10, Operators.MultiplyObject(obj3, (int) 60));
            left = Conversions.ToInteger(Operators.AddObject(Operators.DivideObject(Operators.DivideObject(Operators.SubtractObject(Operators.SubtractObject(left, obj10), Operators.MultiplyObject(obj3, (int) 60)), (int) 60), (int) 0x18), 0x1a4450));
            object obj4 = left;
            if (left >= 0x231519)
            {
                object obj5 = Conversion.Int((double) (((left - 0x1c7dd0) - 0.25) / 36524.25));
                obj4 = Operators.SubtractObject(Operators.AddObject(left + 1, obj5), Conversion.Int(Operators.MultiplyObject(obj5, 0.25)));
            }
            object obj6 = Operators.AddObject(obj4, 0x5f4);
            object right = Conversion.Int(Operators.AddObject(6680.0, Operators.DivideObject(Operators.SubtractObject(Operators.SubtractObject(obj6, 0x253abe), 122.1), 365.25)));
            object obj8 = Operators.AddObject(Operators.MultiplyObject(0x16d, right), Conversion.Int(Operators.MultiplyObject(0.25, right)));
            object obj9 = Conversion.Int(Operators.DivideObject(Operators.SubtractObject(obj6, obj8), 30.6001));
            object obj2 = Operators.SubtractObject(Operators.SubtractObject(obj6, obj8), Conversion.Int(Operators.MultiplyObject(30.6001, obj9)));
            object obj11 = Operators.SubtractObject(obj9, 1);
            if (Operators.ConditionalCompareObjectGreater(obj11, (int) 12, false))
            {
                obj11 = Operators.SubtractObject(obj11, (int) 12);
            }
            object obj12 = Operators.SubtractObject(right, 0x126b);
            if (Operators.ConditionalCompareObjectGreater(obj11, 2, false))
            {
                obj12 = Operators.SubtractObject(obj12, 1);
            }
            if (Operators.ConditionalCompareObjectLessEqual(obj12, 0, false))
            {
                obj12 = Operators.SubtractObject(obj12, 1);
            }
            return Conversions.ToInteger(obj12);
        }

        public void PrintRainfall(ref string filename, ref double startdate, ref int timestep = 60)
        {
            // Invalid method body.
        }

        public void PrintRainfallWithDates(ref short fp)
        {
            int juldate = this.JulianDate("197001010000");
            int nTimeSteps = this.m_nTimeSteps;
            int index = 1;
            while (true)
            {
                string str;
                string str2;
                string str3;
                string str4;
                string str5;
                short num4;
                int num5 = nTimeSteps;
                if (index > num5)
                {
                    return;
                }
                object[] output = new object[] { Strings.Trim(this.ConvertJulianDate(juldate, ref str, ref str2, ref str3, ref str4, ref str5, ref num4)) + " " + Conversions.ToString(this.m_Rainfall[index]) };
                str = "";
                str2 = "";
                str3 = "";
                str4 = "";
                str5 = "";
                num4 = 1;
                FileSystem.PrintLine(fp, output);
                juldate += 60;
                index++;
            }
        }

        public void ReadRainfallFromBinFile(ref short fp, ref double startdate = 0.0)
        {
            int num4;
            int num5;
            FileSystem.FileGet(fp, ref num4, 1L);
            FileSystem.FileGet(fp, ref num5, -1L);
            int num6 = num5 + 1;
            this.m_Rainfall = new float[num4 + 1];
            this.m_nTimeSteps = num4;
            int num7 = num4;
            int index = 1;
            while (true)
            {
                float num;
                int num2;
                int num8 = num7;
                if (index > num8)
                {
                    int[] fileNumbers = new int[] { fp };
                    FileSystem.FileClose(fileNumbers);
                    return;
                }
                FileSystem.Seek(fp, (long) num6);
                FileSystem.FileGet(fp, ref num2, -1L);
                if (index == 1)
                {
                    startdate = num2;
                }
                FileSystem.FileGet(fp, ref num, -1L);
                this.m_Rainfall[index] = num;
                num6 += num5;
                index++;
            }
        }

        public void ReadRainfallFromFile(ref short fp, ref int novals)
        {
            this.m_Rainfall = new float[novals + 1];
            this.m_nTimeSteps = novals;
            int nTimeSteps = this.m_nTimeSteps;
            int index = 1;
            while (true)
            {
                int num3 = nTimeSteps;
                if (index > num3)
                {
                    return;
                }
                FileSystem.Input(fp, ref this.m_Rainfall[index]);
                index++;
            }
        }

        private void SetUpFileStart(ref int fp, ref int start, ref int rec_l)
        {
            FileSystem.FilePut((int) fp, (int) rec_l, -1L);
            FileSystem.FilePut((int) fp, (int) rec_l, -1L);
            FileSystem.Seek(fp, (long) start);
        }

        public float TotalRainfall
        {
            get
            {
                int nTimeSteps = this.m_nTimeSteps;
                int index = 1;
                while (true)
                {
                    float num2;
                    int num4 = nTimeSteps;
                    if (index > num4)
                    {
                        return num2;
                    }
                    num2 += this.m_Rainfall[index];
                    index++;
                }
            }
        }

        public float MaxRainfall
        {
            get
            {
                float num2 = 0f;
                int nTimeSteps = this.m_nTimeSteps;
                int index = 1;
                while (true)
                {
                    int num4 = nTimeSteps;
                    if (index > num4)
                    {
                        return num2;
                    }
                    if (num2 < this.m_Rainfall[index])
                    {
                        num2 = this.m_Rainfall[index];
                    }
                    index++;
                }
            }
        }

        public float MinRainfall
        {
            get
            {
                float num2 = 0f;
                int nTimeSteps = this.m_nTimeSteps;
                int index = 1;
                while (true)
                {
                    int num4 = nTimeSteps;
                    if (index > num4)
                    {
                        return num2;
                    }
                    if (num2 > this.m_Rainfall[index])
                    {
                        num2 = this.m_Rainfall[index];
                    }
                    index++;
                }
            }
        }

        // Warning: Properties with arguments are not supported in C#. Getter of a Rainfall property was decompiled as a method.
        public float get_Rainfall(int Index) => 
            this.m_Rainfall[Index];

        // Warning: Properties with arguments are not supported in C#. Setter of a Rainfall property was decompiled as a method.
        public void set_Rainfall(int Index, float Value)
        {
            this.m_Rainfall[Index] = Value;
        }


        public int TimeSteps
        {
            get => 
                this.m_nTimeSteps;
            set => 
                this.m_nTimeSteps = value;
        }

        // Warning: Properties with arguments are not supported in C#. Getter of a MeanRainfall property was decompiled as a method.
        public float get_MeanRainfall(bool bOnlyRainyDays = false)
        {
            this.m_MeanRainfall = this.ComputeMeanRainfall(ref bOnlyRainyDays);
            return Conversions.ToSingle(this.m_MeanRainfall);
        }

    }
}

