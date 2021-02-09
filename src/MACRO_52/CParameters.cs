namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;

    internal class CParameters
    {
        private float[,] m_W1;
        private float[,] m_W2;
        private float[] m_Pxx = new float[9];
        private float[] m_P10 = new float[9];
        private float[] m_P01 = new float[9];
        private short m_nWeights;
        private short[] m_Groups;
        private float[] m_W1Avg = new float[9];
        private float[] m_W2Avg = new float[9];

        public void ComputeP(ref CRainfall CurrRainfall, ref CRainfall NewRainfall)
        {
            short[] numArray3 = new short[9];
            short[] numArray2 = new short[9];
            short[] numArray = new short[9];
            short grp = 1;
            CRainfall rainfall = CurrRainfall;
            int timeSteps = rainfall.TimeSteps;
            int index = 1;
            while (true)
            {
                int num5 = timeSteps;
                if (index > num5)
                {
                    grp = 1;
                    grp = 1;
                    while (true)
                    {
                        if (Operators.ConditionalCompareObjectGreater(this.NEvents(ref grp), 0, false))
                        {
                            this.m_Pxx[grp] = Conversions.ToSingle(Operators.DivideObject(numArray3[grp], this.NEvents(ref grp)));
                            this.m_P10[grp] = Conversions.ToSingle(Operators.DivideObject(numArray2[grp], this.NEvents(ref grp)));
                            this.m_P01[grp] = Conversions.ToSingle(Operators.DivideObject(numArray[grp], this.NEvents(ref grp)));
                        }
                        grp = (short) (grp + 1);
                        short num6 = 8;
                        if (grp > num6)
                        {
                            rainfall = null;
                            return;
                        }
                    }
                }
                if (this.m_Groups[grp] > 0)
                {
                    if ((rainfall.get_Rainfall(index) == 0f) & (rainfall.get_Rainfall(index + 1) > 0f))
                    {
                        numArray[this.m_Groups[grp]] = (short) (numArray[this.m_Groups[grp]] + 1);
                    }
                    else if ((rainfall.get_Rainfall(index) > 0f) & (rainfall.get_Rainfall(index + 1) == 0f))
                    {
                        numArray2[this.m_Groups[grp]] = (short) (numArray2[this.m_Groups[grp]] + 1);
                    }
                    else if ((rainfall.get_Rainfall(index) > 0f) & (rainfall.get_Rainfall(index + 1) > 0f))
                    {
                        numArray3[this.m_Groups[grp]] = (short) (numArray3[this.m_Groups[grp]] + 1);
                    }
                    else
                    {
                        short num;
                        num = (short) (num + 1);
                    }
                }
                grp = (short) (grp + 1);
                index += 2;
            }
        }

        public void ComputeW1AndW2(ref CRainfall lower, ref CRainfall upper)
        {
            int index = 1;
            short valno = (short) index;
            int timeSteps = lower.TimeSteps;
            int num = 1;
            while (true)
            {
                int num5 = timeSteps;
                if (num > num5)
                {
                    this.ComputeWAverages();
                    return;
                }
                if ((lower.get_Rainfall(num) > 0f) & (lower.get_Rainfall(num + 1) > 0f))
                {
                    this.set_w1(this.get_WeightGroup(index), valno, lower.get_Rainfall(num) / upper.get_Rainfall(index));
                    this.set_W2(this.get_WeightGroup(index), valno, lower.get_Rainfall(num + 1) / upper.get_Rainfall(index));
                }
                valno = (short) (index + 1);
                num += 2;
            }
        }

        private void ComputeWAverages()
        {
            short index = 1;
            while (true)
            {
                float num5 = 0f;
                float num6 = 0f;
                short num3 = 0;
                short num4 = 0;
                short nWeights = this.m_nWeights;
                short num2 = 1;
                while (true)
                {
                    short num8 = nWeights;
                    if (num2 > num8)
                    {
                        if (num3 > 0)
                        {
                            this.m_W1Avg[index] = num5 / ((float) num3);
                        }
                        if (num4 > 0)
                        {
                            this.m_W2Avg[index] = num6 / ((float) num4);
                        }
                        if (((short) (index + 1)) <= 8)
                        {
                            break;
                        }
                        return;
                    }
                    if (this.m_W1[index, num2] > 0f)
                    {
                        num5 += this.m_W1[index, num2];
                        num3 = (short) (num3 + 1);
                    }
                    if (this.m_W2[index, num2] > 0f)
                    {
                        num6 += this.m_W2[index, num2];
                        num4 = (short) (num4 + 1);
                    }
                    num2 = (short) (num2 + 1);
                }
            }
        }

        public void DetermineWeightGroups(ref CRainfall Rainfall)
        {
            this.m_Groups = new short[Rainfall.TimeSteps + 1];
            float num2 = Rainfall.get_MeanRainfall(false);
            CRainfall rainfall = Rainfall;
            int timeSteps = rainfall.TimeSteps;
            if (timeSteps == 1)
            {
                this.m_Groups[1] = 1;
            }
            else
            {
                this.m_Groups[1] = (rainfall.get_Rainfall(2) != 0f) ? ((rainfall.get_Rainfall(1) != 0f) ? ((rainfall.get_Rainfall(1) >= num2) ? ((short) 1) : ((short) 2)) : ((short) 1)) : ((rainfall.get_Rainfall(1) != 0f) ? ((rainfall.get_Rainfall(1) >= num2) ? ((short) 7) : ((short) 8)) : ((short) (-1)));
                int num4 = timeSteps - 1;
                int index = 2;
                while (true)
                {
                    int num5 = num4;
                    if (index > num5)
                    {
                        if (rainfall.get_Rainfall(timeSteps - 1) == 0f)
                        {
                            if (rainfall.get_Rainfall(index) == 0f)
                            {
                                this.m_Groups[index] = -1;
                            }
                            else
                            {
                                this.m_Groups[timeSteps] = (rainfall.get_Rainfall(timeSteps) <= num2) ? ((short) 8) : ((short) 7);
                            }
                        }
                        else if (rainfall.get_Rainfall(index) == 0f)
                        {
                            this.m_Groups[index] = -1;
                        }
                        else
                        {
                            this.m_Groups[timeSteps] = (rainfall.get_Rainfall(timeSteps) <= num2) ? ((short) 6) : ((short) 5);
                        }
                        break;
                    }
                    if ((rainfall.get_Rainfall(index - 1) == 0f) & (rainfall.get_Rainfall(index + 1) == 0f))
                    {
                        this.m_Groups[index] = (rainfall.get_Rainfall(index) != 0f) ? ((rainfall.get_Rainfall(index) <= num2) ? ((short) 8) : ((short) 7)) : ((short) (-1));
                    }
                    else if ((rainfall.get_Rainfall(index - 1) == 0f) & (rainfall.get_Rainfall(index + 1) > 0f))
                    {
                        this.m_Groups[index] = (rainfall.get_Rainfall(index) != 0f) ? ((rainfall.get_Rainfall(index) <= num2) ? ((short) 2) : ((short) 1)) : ((short) (-1));
                    }
                    else if ((rainfall.get_Rainfall(index - 1) > 0f) & (rainfall.get_Rainfall(index + 1) == 0f))
                    {
                        this.m_Groups[index] = (rainfall.get_Rainfall(index) != 0f) ? ((rainfall.get_Rainfall(index) <= num2) ? ((short) 6) : ((short) 5)) : ((short) (-1));
                    }
                    else if ((rainfall.get_Rainfall(index - 1) > 0f) & (rainfall.get_Rainfall(index + 1) > 0f))
                    {
                        this.m_Groups[index] = (rainfall.get_Rainfall(index) != 0f) ? ((rainfall.get_Rainfall(index) <= num2) ? ((short) 4) : ((short) 3)) : ((short) (-1));
                    }
                    index++;
                }
            }
            rainfall = null;
        }

        public string Heading() => 
            "Level\tStart, above\t\tStart, below\t\tEnclosed, above\t\tEnclosed, below\t\tEnd, above\t\tEnd, below\t\tIsolated, above\t\tIsolated, below";

        private string Heading2()
        {
            string str = "\t";
            short num = 1;
            while (true)
            {
                str = str + "W1\tW2\t";
                num = (short) (num + 1);
                short num2 = 8;
                if (num > num2)
                {
                    return str;
                }
            }
        }

        private string HeadingP() => 
            "Level\tStart, above\t\t\tStart, below\t\t\tEnclosed, above\t\t\tEnclosed, below\t\t\tEnd, above\t\t\tEnd, below\t\t\tIsolated, above\t\t\tIsolated, below";

        public void Init(ref short nweights)
        {
            this.m_W1 = new float[9, nweights + 1];
            this.m_W2 = new float[9, nweights + 1];
            this.m_nWeights = nweights;
        }

        private object NEvents(ref short grp)
        {
            object left = 0;
            short num2 = (short) Information.UBound(this.m_Groups, 1);
            short index = 1;
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    return left;
                }
                if (grp == this.m_Groups[index])
                {
                    left = Operators.AddObject(left, 1);
                }
                index = (short) (index + 1);
            }
        }

        public void PrintAverageWeights(ref short fp, ref short lvl)
        {
            object[] output = new object[] { (short) lvl, "\t" };
            FileSystem.Print(fp, output);
            short index = 1;
            while (true)
            {
                output = new object[] { Conversions.ToString(this.m_W1Avg[index]) + "\t" + Conversions.ToString(this.m_W2Avg[index]) + "\t" };
                FileSystem.Print(fp, output);
                index = (short) (index + 1);
                short num2 = 7;
                if (index > num2)
                {
                    output = new object[] { Conversions.ToString(this.m_W1Avg[index]) + "\t" + Conversions.ToString(this.m_W2Avg[index]) + "\t" };
                    FileSystem.PrintLine(fp, output);
                    return;
                }
            }
        }

        public void PrintParameters(ref short fp, ref short lvl)
        {
            FileSystem.PrintLine(fp, new object[0]);
            object[] output = new object[] { "Aggregation level: " + Conversions.ToString((int) lvl) };
            FileSystem.PrintLine(fp, output);
            FileSystem.PrintLine(fp, new object[0]);
            output = new object[] { "Probabilities" };
            FileSystem.PrintLine(fp, output);
            output = new object[] { "\tP(1/0)\tP(0/1)\tP(x/x)" };
            FileSystem.Print(fp, output);
            FileSystem.PrintLine(fp, new object[0]);
            short index = 1;
            while (true)
            {
                output = new object[1];
                string[] strArray = new string[] { Conversions.ToString((int) index), "\t", Conversions.ToString(this.m_P10[index]), "\t", Conversions.ToString(this.m_P01[index]), "\t", Conversions.ToString(this.m_Pxx[index]) };
                output[0] = string.Concat(strArray);
                FileSystem.PrintLine(fp, output);
                index = (short) (index + 1);
                short num6 = 8;
                if (index > num6)
                {
                    FileSystem.PrintLine(fp, new object[0]);
                    output = new object[] { "Weights" };
                    FileSystem.PrintLine(fp, output);
                    FileSystem.PrintLine(fp, new object[0]);
                    output = new object[] { this.Heading() };
                    FileSystem.PrintLine(fp, output);
                    output = new object[] { this.Heading2() };
                    FileSystem.PrintLine(fp, output);
                    short nWeights = this.m_nWeights;
                    short num2 = 1;
                    while (true)
                    {
                        num6 = nWeights;
                        if (num2 > num6)
                        {
                            output = new object[] { "Averages:\t" };
                            FileSystem.Print(fp, output);
                            num2 = 1;
                            while (true)
                            {
                                output = new object[] { Conversions.ToString(this.m_W1Avg[num2]) + "\t" + Conversions.ToString(this.m_W2Avg[num2]) + "\t" };
                                FileSystem.Print(fp, output);
                                num2 = (short) (num2 + 1);
                                num6 = 8;
                                if (num2 > num6)
                                {
                                    FileSystem.PrintLine(fp, new object[0]);
                                    output = new object[] { "----------------------------" };
                                    FileSystem.PrintLine(fp, output);
                                    return;
                                }
                            }
                        }
                        output = new object[] { (short) lvl };
                        FileSystem.Print(fp, output);
                        if (this.m_Groups[num2] <= 0)
                        {
                            FileSystem.PrintLine(fp, new object[0]);
                        }
                        else
                        {
                            short num5 = (short) (this.m_Groups[num2] - 1);
                            short num3 = 1;
                            while (true)
                            {
                                num6 = num5;
                                if (num3 > num6)
                                {
                                    output = new object[] { "\t" };
                                    FileSystem.Print(fp, output);
                                    output = new object[] { Conversions.ToString(this.m_W1[this.m_Groups[num2], num2]) + "\t" + Conversions.ToString(this.m_W2[this.m_Groups[num2], num2]) };
                                    FileSystem.PrintLine(fp, output);
                                    break;
                                }
                                output = new object[] { "\t\t" };
                                FileSystem.Print(fp, output);
                                num3 = (short) (num3 + 1);
                            }
                        }
                        num2 = (short) (num2 + 1);
                    }
                }
            }
        }

        public void PrintProbabilities(ref short fp, ref short lvl)
        {
            object[] output = new object[] { Conversions.ToString((int) lvl) + "\t" };
            FileSystem.Print(fp, output);
            short index = 1;
            while (true)
            {
                output = new object[] { Conversions.ToString(this.m_P10[index]) + "\t" };
                FileSystem.Print(fp, output);
                index = (short) (index + 1);
                short num2 = 8;
                if (index > num2)
                {
                    index = 1;
                    while (true)
                    {
                        output = new object[] { Conversions.ToString(this.m_P01[index]) + "\t" };
                        FileSystem.Print(fp, output);
                        index = (short) (index + 1);
                        num2 = 8;
                        if (index > num2)
                        {
                            index = 1;
                            while (true)
                            {
                                output = new object[] { Conversions.ToString(this.m_Pxx[index]) + "\t" };
                                FileSystem.Print(fp, output);
                                index = (short) (index + 1);
                                num2 = 7;
                                if (index > num2)
                                {
                                    output = new object[] { this.m_Pxx[index] };
                                    FileSystem.PrintLine(fp, output);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        // Warning: Properties with arguments are not supported in C#. Getter of a WeightGroup property was decompiled as a method.
        public short get_WeightGroup(int Index) => 
            this.m_Groups[Index];


        // Warning: Properties with arguments are not supported in C#. Getter of a w1 property was decompiled as a method.
        public float get_w1(short group, short valno) => 
            this.m_W1[group, valno];

        // Warning: Properties with arguments are not supported in C#. Setter of a w1 property was decompiled as a method.
        public void set_w1(short group, short valno, float Value)
        {
            this.m_W1[group, valno] = Value;
        }


        // Warning: Properties with arguments are not supported in C#. Getter of a W2 property was decompiled as a method.
        public float get_W2(short group, short valno) => 
            this.m_W2[group, valno];

        // Warning: Properties with arguments are not supported in C#. Setter of a W2 property was decompiled as a method.
        public void set_W2(short group, short valno, float Value)
        {
            this.m_W2[group, valno] = Value;
        }


        // Warning: Properties with arguments are not supported in C#. Getter of a p10 property was decompiled as a method.
        public float get_p10(short Index) => 
            this.m_P10[Index];

        // Warning: Properties with arguments are not supported in C#. Setter of a p10 property was decompiled as a method.
        public void set_p10(short Index, float Value)
        {
            this.m_P10[Index] = Value;
        }


        // Warning: Properties with arguments are not supported in C#. Getter of a p01 property was decompiled as a method.
        public float get_p01(short Index) => 
            this.m_P01[Index];

        // Warning: Properties with arguments are not supported in C#. Setter of a p01 property was decompiled as a method.
        public void set_p01(short Index, float Value)
        {
            this.m_P01[Index] = Value;
        }


        // Warning: Properties with arguments are not supported in C#. Getter of a pxx property was decompiled as a method.
        public float get_pxx(short Index) => 
            this.m_Pxx[Index];

        // Warning: Properties with arguments are not supported in C#. Setter of a pxx property was decompiled as a method.
        public void set_pxx(short Index, float Value)
        {
            this.m_Pxx[Index] = Value;
        }

    }
}

