namespace MACRO_52
{
    using ADODB;
    using MACRO_52.My;
    using MACRO5;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.Compatibility.VB6;
    using Microsoft.VisualBasic.CompilerServices;
    using Microsoft.VisualBasic.FileIO;
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [StandardModule]
    internal sealed class MiscFUncs
    {
        public static string BrowseOpen(ref OpenFileDialog Dlg) => 
            (Dlg.ShowDialog() != DialogResult.Cancel) ? Dlg.FileName : "";

        public static string BrowseSave(ref SaveFileDialog Dlg) => 
            (Dlg.ShowDialog() != DialogResult.Cancel) ? Dlg.FileName : "";

        public static void ComputeLayerThickness()
        {
            short[] numArray = new short[11];
            Array.Clear(GlobalVariables.Z, 0, GlobalVariables.Z.Length);
            Array.Clear(GlobalVariables.Hthick, 0, GlobalVariables.Hthick.Length);
            short nlayer = GlobalVariables.Nlayer;
            float num12 = 0f;
            float left = 0f;
            float num7 = 0f;
            float num6 = 1f;
            short nhorizon = GlobalVariables.Nhorizon;
            short index = 1;
            while (true)
            {
                short num22 = nhorizon;
                if (index > num22)
                {
                    num7 = 0f;
                    float num3 = 1f;
                    short num14 = GlobalVariables.Nhorizon;
                    index = 1;
                    while (true)
                    {
                        num22 = num14;
                        if (index > num22)
                        {
                            short num15 = GlobalVariables.Nhorizon;
                            index = 1;
                            while (true)
                            {
                                num22 = num15;
                                if (index > num22)
                                {
                                    GlobalVariables.TotPhys_layer = GlobalVariables.N_NUMERICAL_LAYERS;
                                    GlobalVariables.TotalLayers = GlobalVariables.N_NUMERICAL_LAYERS;
                                    GlobalVariables.Nlayer = GlobalVariables.N_NUMERICAL_LAYERS;
                                    short num8 = 0;
                                    Array.Clear(GlobalVariables.Z, 0, GlobalVariables.Z.Length);
                                    short num10 = (GlobalVariables.sw_crust != MACROConstants.Switch.BareSoil) ? 2 : 1;
                                    short num16 = GlobalVariables.Nhorizon;
                                    short num5 = num10;
                                    while (true)
                                    {
                                        int num2;
                                        int num11;
                                        num22 = num16;
                                        if (num5 > num22)
                                        {
                                            if (GlobalVariables.sw_crust == MACROConstants.Switch.NoMetabolite)
                                            {
                                                GlobalVariables.Hthick[1] = Conversions.ToSingle(GlobalVariables.thickness[1]);
                                                GlobalVariables.N_Layer[1] = numArray[1];
                                                num11 = 0;
                                                num2 = Conversions.ToInteger(Operators.SubtractObject(Operators.MultiplyObject(GlobalVariables.thickness[1], (int) 100), 0));
                                                num10 = 1;
                                                if (num2 <= 100)
                                                {
                                                    while (true)
                                                    {
                                                        if (num11 == num2)
                                                        {
                                                            break;
                                                        }
                                                        short num20 = numArray[1];
                                                        index = 1;
                                                        while (true)
                                                        {
                                                            num22 = num20;
                                                            if (index <= num22)
                                                            {
                                                                GlobalVariables.Z[index]++;
                                                                num11++;
                                                                if (num11 != num2)
                                                                {
                                                                    index = (short) (index + 1);
                                                                    continue;
                                                                }
                                                            }
                                                            break;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    while (true)
                                                    {
                                                        if ((numArray[1] >= (num10 + 2)) & (num10 < 5))
                                                        {
                                                            num22 = (short) (num10 - 1);
                                                            switch (num22)
                                                            {
                                                                case 0:
                                                                    GlobalVariables.Z[num10] = 30f;
                                                                    break;

                                                                case 1:
                                                                    GlobalVariables.Z[2] = 40f;
                                                                    break;

                                                                case 2:
                                                                    GlobalVariables.Z[3] = 60f;
                                                                    break;

                                                                case 3:
                                                                    GlobalVariables.Z[4] = 70f;
                                                                    break;

                                                                default:
                                                                    break;
                                                            }
                                                            num10 = (short) (num10 + 1);
                                                            num11 = (int) Math.Round((double) (num11 + GlobalVariables.Z[num10 - 1]));
                                                            if (num11 <= num2)
                                                            {
                                                                continue;
                                                            }
                                                            GlobalVariables.Z[num10 - 1] = (GlobalVariables.Z[num10 - 1] - num11) + num2;
                                                            num11 = num2;
                                                        }
                                                        break;
                                                    }
                                                }
                                                while (true)
                                                {
                                                    if (num11 == num2)
                                                    {
                                                        break;
                                                    }
                                                    short num21 = numArray[1];
                                                    index = num10;
                                                    while (true)
                                                    {
                                                        num22 = num21;
                                                        if (index <= num22)
                                                        {
                                                            GlobalVariables.Z[index]++;
                                                            num11++;
                                                            if (num11 != num2)
                                                            {
                                                                index = (short) (index + 1);
                                                                continue;
                                                            }
                                                        }
                                                        break;
                                                    }
                                                }
                                            }
                                            index = 1;
                                            while (true)
                                            {
                                                GlobalVariables.Z[index] /= 100f;
                                                index = (short) (index + 1);
                                                num22 = 200;
                                                if (index > num22)
                                                {
                                                    return;
                                                }
                                            }
                                        }
                                        GlobalVariables.Hthick[num5] = Conversions.ToSingle(GlobalVariables.thickness[num5]);
                                        GlobalVariables.N_Layer[num5] = numArray[num5];
                                        num8 = (short) (num8 + numArray[num5 - 1]);
                                        num11 = 0;
                                        num2 = Conversions.ToInteger(Operators.MultiplyObject(GlobalVariables.thickness[num5], (int) 100));
                                        while (true)
                                        {
                                            if (num11 == num2)
                                            {
                                                num5 = (short) (num5 + 1);
                                                break;
                                            }
                                            if ((GlobalVariables.sw_crust == MACROConstants.Switch.NoMetabolite) | (num5 > 1))
                                            {
                                                short num17 = numArray[num5];
                                                index = 1;
                                                while (true)
                                                {
                                                    num22 = num17;
                                                    if (index <= num22)
                                                    {
                                                        GlobalVariables.Z[(short) (index + num8)]++;
                                                        num11++;
                                                        if (num11 != num2)
                                                        {
                                                            index = (short) (index + 1);
                                                            continue;
                                                        }
                                                    }
                                                    break;
                                                }
                                                continue;
                                            }
                                            if ((GlobalVariables.sw_crust & ((MACROConstants.Switch) -(num5 == 1))) != MACROConstants.Switch.NoMetabolite)
                                            {
                                                GlobalVariables.Z[1] = 10f;
                                                GlobalVariables.Z[2] = 10f;
                                                GlobalVariables.Z[3] = 10f;
                                                if (num11 == 0)
                                                {
                                                    num11 = 30;
                                                }
                                                short num18 = numArray[num5];
                                                index = 4;
                                                while (true)
                                                {
                                                    num22 = num18;
                                                    if (index <= num22)
                                                    {
                                                        GlobalVariables.Z[(short) (index + num8)]++;
                                                        num11++;
                                                        if (num11 != num2)
                                                        {
                                                            index = (short) (index + 1);
                                                            continue;
                                                        }
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                                if (numArray[index] <= 1)
                                {
                                    numArray[(int) Math.Round((double) num3)] = (short) (numArray[(int) Math.Round((double) num3)] - (2 - numArray[index]));
                                    numArray[index] = 2;
                                    GlobalVariables.N_Layer[index] = numArray[index];
                                }
                                index = (short) (index + 1);
                            }
                        }
                        if (numArray[index] <= 1)
                        {
                            numArray[(int) Math.Round((double) num6)] = (short) (numArray[(int) Math.Round((double) num6)] - (2 - numArray[index]));
                            numArray[index] = 2;
                        }
                        if ((numArray[index] >= num7) & (index != 1))
                        {
                            num3 = index;
                            num7 = numArray[index];
                        }
                        GlobalVariables.N_Layer[index] = numArray[index];
                        index = (short) (index + 1);
                    }
                }
                if (index == GlobalVariables.Nhorizon)
                {
                    numArray[index] = (short) Math.Round((double) (GlobalVariables.N_NUMERICAL_LAYERS - num12));
                }
                else
                {
                    numArray[index] = Conversions.ToShort(Conversion.Int(Operators.DivideObject(Operators.MultiplyObject(GlobalVariables.N_NUMERICAL_LAYERS - num12, GlobalVariables.thickness[index]), GlobalVariables.profiledepth - left)));
                    if (index == 1)
                    {
                        if (Operators.ConditionalCompareObjectGreaterEqual(GlobalVariables.thickness[index], (int) 20, false))
                        {
                            if (numArray[index] < 15)
                            {
                                numArray[index] = 15;
                            }
                        }
                        else if (numArray[index] < 3)
                        {
                            numArray[index] = 3;
                        }
                    }
                    num12 += numArray[index];
                    left = Conversions.ToSingle(Operators.AddObject(left, GlobalVariables.thickness[index]));
                }
                if ((numArray[index] >= num7) & (index != 1))
                {
                    num6 = index;
                    num7 = numArray[index];
                }
                index = (short) (index + 1);
            }
        }

        public static bool ConvertBinToASCII(ref OpenFileDialog Dlg)
        {
            // Invalid method body.
        }

        public static string ConvertDate(ref DateTimePicker dp)
        {
            DateTime time = dp.Value;
            string str2 = (time.Hour >= 10) ? Conversions.ToString(time.Hour) : ("0" + Conversions.ToString(time.Hour));
            string str4 = (time.Minute >= 10) ? Conversions.ToString(time.Minute) : ("0" + Conversions.ToString(time.Minute));
            string str5 = (time.Month >= 10) ? Conversions.ToString(time.Month) : ("0" + Conversions.ToString(time.Month));
            string str3 = (time.Day >= 10) ? Conversions.ToString(time.Day) : ("0" + Conversions.ToString(time.Day));
            string[] strArray = new string[] { Conversions.ToString(time.Year), ":", str5, ":", str3, " ", str2, ":", str4 };
            return string.Concat(strArray);
        }

        public static string ConvertJulianDate(int juldate, ref string theYear = "", ref string month_Renamed = "", ref string day_Renamed = "", ref string Hour_Renamed = "", ref string Minute_Renamed = "", ref short DateFormat = 0)
        {
            string str;
            string[] strArray;
            short number = (short) (juldate % 0x5a0);
            short num2 = (short) Math.Round((double) (((double) number) / 60.0));
            number = (short) (number - (num2 * 60));
            juldate = (int) Math.Round((double) (((((double) ((juldate - number) - (num2 * 60))) / 60.0) / 24.0) + 1721424.0));
            long num3 = juldate;
            if (juldate >= 0x231519)
            {
                int num4 = (int) Math.Round(Conversion.Int((double) (((juldate - 0x1c7dd0) - 0.25) / 36524.25)));
                num3 = (long) Math.Round((double) (((juldate + 1) + num4) - Conversion.Int((double) (num4 * 0.25))));
            }
            int num5 = (int) (num3 + 0x5f4L);
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
            if (!Information.IsNothing(theYear))
            {
                theYear = Conversions.ToString(num11);
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
                    str = "";
                    break;
            }
            return str;
        }

        public static void DeleteFile(ref string fname)
        {
            MyProject.Computer.FileSystem.DeleteFile(fname, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
        }

        public static bool FileExists(string fname) => 
            MyProject.Computer.FileSystem.FileExists(fname);

        public static bool FillVarsList(ref string file, ref ListBox lst)
        {
            // Invalid method body.
        }

        public static void GetCropParameters(ref float[] vals, ref short Y, ref string[] names, ref CfrmMain frmMain)
        {
            short num2 = (short) Information.UBound(vals, 1);
            Recordset recordset = new RecordsetClass();
            vals = (float[]) Utils.CopyArray((Array) vals, new float[(num2 + Information.UBound(names, 1)) + 1]);
            Recordset recordset2 = recordset;
            short num3 = (short) Information.UBound(names, 1);
            short index = 1;
            while (true)
            {
                short num4 = num3;
                if (index > num4)
                {
                    recordset2 = null;
                    return;
                }
                recordset2.Open("select [" + names[index] + "] from Crop where year=" + Conversions.ToString((int) Y) + " AND R_ID=" + Conversions.ToString(GlobalVariables.IDExecute), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                vals[((short) (num2 + index)) - 1] = Conversions.ToSingle(recordset2[][0][]);
                recordset2.Close();
                index = (short) (index + 1);
            }
        }

        public static void GetIrrParameters(ref float[] vals, ref short Y, ref string[] names, ref CfrmMain frmMain, ref bool second_Renamed = false)
        {
            Recordset rs = new RecordsetClass();
            short index = second_Renamed ? ((short) (Information.UBound(vals, 1) + 1)) : ((short) Information.UBound(vals, 1));
            vals = (float[]) Utils.CopyArray((Array) vals, new float[(((index + ((Information.UBound(names, 1) - 1) * 100)) - 1) + 1) + 1]);
            Recordset recordset2 = rs;
            short num5 = (short) Information.UBound(names, 1);
            for (short i = 1; i <= num5; i = (short) (i + 1))
            {
                if (names[i] != "NIRR")
                {
                    string[] strArray = new string[] { "select [", names[i], "] from [Irrigation()] where IRRYEAR=", Conversions.ToString((int) Y), " AND R_id=", Conversions.ToString(GlobalVariables.IDExecute), " order by irrig_no" };
                    recordset2.Open(string.Concat(strArray), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                }
                else
                {
                    recordset2.Open("select * from [Irrigation()] where IRRYEAR=" + Conversions.ToString((int) Y) + " AND R_id=" + Conversions.ToString(GlobalVariables.IDExecute) + " order by irrig_no", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                }
                if (names[i] == "NIRR")
                {
                    vals[index] = !Operators.ConditionalCompareObjectGreater(recordset2[]["irrig_no"][], 0, false) ? 0f : ((float) ReadSaveFunctions.RecordCount(ref rs));
                }
                else
                {
                    short num6 = (short) (((short) ReadSaveFunctions.RecordCount(ref rs)) - 1);
                    short num2 = 0;
                    while (true)
                    {
                        short num7 = num6;
                        if (num2 > num7)
                        {
                            break;
                        }
                        vals[(short) (index + num2)] = Conversions.ToSingle(recordset2[][0][]);
                        recordset2.MoveNext();
                        num2 = (short) (num2 + 1);
                    }
                }
                bool flag = names[i] != "NIRR";
                index = !flag ? ((short) (index + 1)) : ((short) (index + 100));
                recordset2.Close();
            }
            recordset2 = null;
        }

        public static object GetTemporaryPath()
        {
            string lpBuffer = new string('\0', 260);
            return ((GetTempPath(260, ref lpBuffer) == 0) ? "" : Strings.Left(lpBuffer, Strings.InStr(lpBuffer, "\0", CompareMethod.Binary) - 1));
        }

        [DllImport("kernel32", EntryPoint="GetTempPathA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int GetTempPath(int nBufferLength, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer);
        public static void GotoWeb(ref string URL)
        {
            int num = ShellExecute(0, ref (string) ref null, ref URL, ref (string) ref null, ref @"C:\", 1);
        }

        public static bool IsInGroupNo(ref short grp, ref short Y)
        {
            short num2 = (short) Information.UBound(GlobalVariables.Groups, 2);
            short num = 1;
            while (true)
            {
                bool flag;
                short num3 = num2;
                if (num <= num3)
                {
                    if (GlobalVariables.Groups[grp, num] != Y)
                    {
                        num = (short) (num + 1);
                        continue;
                    }
                    flag = true;
                }
                return flag;
            }
        }

        public static long JulianDate(string dtm)
        {
            int num5;
            int num7;
            dtm = Strings.Trim(dtm);
            dtm = Strings.Replace(dtm, " ", "", 1, -1, CompareMethod.Binary);
            dtm = Strings.Replace(dtm, ":", "", 1, -1, CompareMethod.Binary);
            dtm = Strings.Replace(dtm, "-", "", 1, -1, CompareMethod.Binary);
            dtm = Strings.Replace(dtm, "/", "", 1, -1, CompareMethod.Binary);
            int num11 = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 1, 4)));
            int num9 = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 5, 2)));
            int num = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 7, 2)));
            int num2 = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 9, 2)));
            int num8 = (int) Math.Round(Conversion.Val(Strings.Mid(dtm, 11, 2)));
            if (num11 < 0)
            {
                num11++;
            }
            if (num9 > 2)
            {
                num7 = num11;
                num5 = num9 + 1;
            }
            else
            {
                num7 = num11 - 1;
                num5 = num9 + 13;
            }
            int num4 = (int) Math.Round((double) (((Conversion.Int((double) (365.25 * num7)) + Conversion.Int((double) (30.6001 * num5))) + num) + 1720995.0));
            if ((num + (0x1f * (num9 + (12 * num11)))) > 0x8fc1d)
            {
                int num3 = (int) Math.Round((double) (0.01 * num7));
                num4 = (int) Math.Round((double) (((num4 + 2) - num3) + Conversion.Int((double) (0.25 * num3))));
            }
            return (long) (((((num4 - 0x1a4450) * 0x18) * 60) + (num2 * 60)) + num8);
        }

        public static int LCD(ref int value1, ref int value2)
        {
            int num;
            int num2;
            int num3;
            if (value1 > value2)
            {
                num2 = value1;
                num3 = value2;
            }
            else
            {
                num3 = value1;
                num2 = value2;
            }
            if ((num2 % num3) == 0)
            {
                num = num3;
            }
            else
            {
                int num4 = num3;
                while (true)
                {
                    if ((num2 % num4) >= 0)
                    {
                        int num5 = num2 % num4;
                        if (num5 != 0)
                        {
                            num4 = num5;
                            continue;
                        }
                        num = num4;
                    }
                    break;
                }
            }
            return num;
        }

        public static float LinearInterpol(ref int x1, ref int x2, ref float y1, ref float y2, ref int x3)
        {
            float num2 = y1 + (((y2 - y1) / ((float) (x2 - x1))) * (x3 - x1));
            short fileNumber = (short) Microsoft.VisualBasic.FileSystem.FreeFile();
            Microsoft.VisualBasic.FileSystem.FileOpen(fileNumber, "interpol.txt", OpenMode.Append, OpenAccess.Default, OpenShare.Default, -1);
            object[] output = new object[1];
            string[] strArray = new string[] { Conversions.ToString((int) x1), " ", Conversions.ToString((int) x2), " ", Conversions.ToString((float) y1), " ", Conversions.ToString((float) y2), " ", Conversions.ToString((int) x3) };
            strArray[9] = Conversions.ToString(num2);
            output[0] = string.Concat(strArray);
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            Microsoft.VisualBasic.FileSystem.FileClose(new int[] { fileNumber });
            return num2;
        }

        public static void Logger(ref string msg, ref bool Clear = false)
        {
            short fileNumber = (short) Microsoft.VisualBasic.FileSystem.FreeFile();
            if (Clear)
            {
                Microsoft.VisualBasic.FileSystem.FileOpen(fileNumber, MyProject.Application.Info.DirectoryPath + @"\log.log", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
            }
            else
            {
                Microsoft.VisualBasic.FileSystem.FileOpen(fileNumber, MyProject.Application.Info.DirectoryPath + @"\log.log", OpenMode.Append, OpenAccess.Default, OpenShare.Default, -1);
            }
            object[] output = new object[] { msg };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            Microsoft.VisualBasic.FileSystem.FileClose(new int[] { fileNumber });
        }

        public static object MsgBox_Renamed(string isText, short inButtons = 0, string isTitle = "")
        {
            isTitle = (isTitle == "") ? "MACRO 5.2" : ("MACRO 5.2 - " + isTitle);
            return (short) Interaction.MsgBox(isText, (MsgBoxStyle) inButtons, isTitle);
        }

        public static bool Numeric(ref TextBox txt)
        {
            if (!Versioned.IsNumeric(txt.Text))
            {
                MsgBox_Renamed("A non-numeric value has been entered", 0x30, "Error");
                TextBox box = txt;
                box.SelectionStart = 0;
                box.SelectionLength = 10;
                box.Focus();
                box = null;
            }
            return true;
        }

        public static int ParameterIndex(ref string ParName)
        {
            short num3 = (short) Information.UBound(GlobalVariables.pname, 1);
            short index = 1;
            while (true)
            {
                int num2;
                short num4 = num3;
                if (index > num4)
                {
                    num2 = -1;
                }
                else
                {
                    if (Strings.Trim(GlobalVariables.pname[index]) != ParName)
                    {
                        index = (short) (index + 1);
                        continue;
                    }
                    num2 = GlobalVariables.FirstPos[index];
                }
                return num2;
            }
        }

        public static bool ReadDates(ref string[] Dates, ref short fp, ref bool rdim = false, ref bool KeepAsJulian = true)
        {
            // Invalid method body.
        }

        public static void RedimIrrigationArrays(ref int Y)
        {
            if (Y > 0)
            {
                GlobalVariables.amir = (float[,]) Utils.CopyArray((Array) GlobalVariables.amir, new float[0x65, Y + 1]);
                GlobalVariables.irrstart = (float[,]) Utils.CopyArray((Array) GlobalVariables.irrstart, new float[0x65, Y + 1]);
                GlobalVariables.irrend = (float[,]) Utils.CopyArray((Array) GlobalVariables.irrend, new float[0x65, Y + 1]);
                GlobalVariables.z_fint = (float[,]) Utils.CopyArray((Array) GlobalVariables.z_fint, new float[0x65, Y + 1]);
                GlobalVariables.c_onci = (float[,]) Utils.CopyArray((Array) GlobalVariables.c_onci, new float[0x65, Y + 1]);
                GlobalVariables.i_rrday = (float[,]) Utils.CopyArray((Array) GlobalVariables.i_rrday, new float[0x65, Y + 1]);
                GlobalVariables.irrig_no = (short[,]) Utils.CopyArray((Array) GlobalVariables.irrig_no, new short[0x65, Y + 1]);
            }
            else if (Y == 0)
            {
                GlobalVariables.amir = (float[,]) Utils.CopyArray((Array) GlobalVariables.amir, new float[0x65, 2]);
                GlobalVariables.irrstart = (float[,]) Utils.CopyArray((Array) GlobalVariables.irrstart, new float[0x65, 2]);
                GlobalVariables.irrend = (float[,]) Utils.CopyArray((Array) GlobalVariables.irrend, new float[0x65, 2]);
                GlobalVariables.z_fint = (float[,]) Utils.CopyArray((Array) GlobalVariables.z_fint, new float[0x65, 2]);
                GlobalVariables.c_onci = (float[,]) Utils.CopyArray((Array) GlobalVariables.c_onci, new float[0x65, 2]);
                GlobalVariables.i_rrday = (float[,]) Utils.CopyArray((Array) GlobalVariables.i_rrday, new float[0x65, 2]);
                GlobalVariables.irrig_no = (short[,]) Utils.CopyArray((Array) GlobalVariables.irrig_no, new short[0x65, 2]);
            }
        }

        public static void RenameFile(ref string FromName, ref string ToName)
        {
            if (FromName != ToName)
            {
                object[] arguments = new object[] { FromName, ToName };
                bool[] copyBack = new bool[] { true, true };
                NewLateBinding.LateCall(Interaction.CreateObject("Scripting.FileSystemObject", ""), null, "copyfile", arguments, null, null, copyBack, true);
                if (copyBack[0])
                {
                    FromName = (string) Conversions.ChangeType(arguments[0], typeof(string));
                }
                if (copyBack[1])
                {
                    ToName = (string) Conversions.ChangeType(arguments[1], typeof(string));
                }
                DeleteFile(ref FromName);
            }
        }

        public static void SendEmail(ref string email)
        {
            int num = ShellExecute(0, ref (string) ref null, ref "mailto:" + email, ref (string) ref null, ref @"C:\", 1);
        }

        public static void SetCropParIndex(ref short[] ind, ref string[] values, ref bool second_Renamed = false)
        {
            short num3 = second_Renamed ? ((short) (Information.UBound(ind, 1) + 1)) : ((short) Information.UBound(ind, 1));
            ind = (short[]) Utils.CopyArray((Array) ind, new short[((num3 + Information.UBound(values, 1)) - 1) + 1]);
            short num4 = (short) Information.UBound(values, 1);
            short index = 1;
            while (index <= num4)
            {
                short num5 = (short) Information.UBound(GlobalVariables.pname, 1);
                short num2 = 1;
                while (true)
                {
                    short num6 = num5;
                    if (num2 <= num6)
                    {
                        if (Strings.Trim(GlobalVariables.pname[num2]) != values[index])
                        {
                            num2 = (short) (num2 + 1);
                            continue;
                        }
                        ind[((short) (num3 + index)) - 1] = GlobalVariables.FirstPos[num2];
                    }
                    index = (short) (index + 1);
                    break;
                }
            }
        }

        public static void SetCropParNames(ref string[] Parameternames, ref CfrmMain frmMain)
        {
            ADODC projectDatabase = frmMain.ProjectDatabase;
            projectDatabase.RecordSource = "select * from [Options] where R_id=" + Conversions.ToString(GlobalVariables.IDExecute);
            projectDatabase.Refresh();
            short num = Conversions.ToShort(projectDatabase.Recordset[]["Crop"][]);
            short num2 = Conversions.ToShort(projectDatabase.Recordset[]["Evaporate"][]);
            projectDatabase = null;
            Parameternames = new string[0x17];
            if (num != 2)
            {
                if (num2 == 2)
                {
                }
                Parameternames[1] = "RPIN";
                Parameternames[2] = "WATEN";
                Parameternames[3] = "CRITAIR";
                Parameternames[4] = "BETA";
                Parameternames[5] = "CANCAP";
                Parameternames[6] = "ZALP";
                Parameternames[7] = "LAIC";
                if (num2 != 2)
                {
                    Parameternames = (string[]) Utils.CopyArray((Array) Parameternames, new string[8]);
                }
                else
                {
                    Parameternames[8] = "ATTEN";
                    Parameternames[9] = "HCROP";
                    Parameternames[10] = "RSURF";
                    Parameternames = (string[]) Utils.CopyArray((Array) Parameternames, new string[11]);
                }
                GlobalVariables.C_HARVESTDAYINDEX = -1;
            }
            else
            {
                if (num2 == 2)
                {
                }
                Parameternames[1] = "ROOTINIT";
                Parameternames[2] = "ROOTMAX";
                Parameternames[3] = "ROOTDEP";
                Parameternames[4] = "CFORM";
                Parameternames[5] = "RPIN";
                Parameternames[6] = "WATEN";
                Parameternames[7] = "CRITAIR";
                Parameternames[8] = "BETA";
                Parameternames[9] = "CANCAP";
                Parameternames[10] = "ZALP";
                Parameternames[11] = "IDSTART";
                GlobalVariables.C_IDTSTARTINDEX = 11;
                Parameternames[12] = "IDMAX";
                Parameternames[13] = "IHARV";
                GlobalVariables.C_HARVESTDAYINDEX = 13;
                Parameternames[14] = "ZHMIN";
                Parameternames[15] = "LAIMIN";
                Parameternames[0x10] = "LAIMAX";
                Parameternames[0x11] = "ZDATEMIN";
                Parameternames[0x12] = "DFORM";
                Parameternames[0x13] = "LAIHAR";
                if (num2 != 2)
                {
                    Parameternames = (string[]) Utils.CopyArray((Array) Parameternames, new string[20]);
                }
                else
                {
                    Parameternames[20] = "HMAX";
                    Parameternames[0x15] = "RSMIN";
                    Parameternames[0x16] = "ATTEN";
                }
            }
        }

        public static void SetIrrParIndex(ref short[] ind, ref string[] values, ref bool second_Renamed = false)
        {
            short num4 = second_Renamed ? ((short) ((Information.UBound(ind, 1) + 1) - 1)) : ((short) (Information.UBound(ind, 1) - 1));
            short num5 = (short) Information.UBound(values, 1);
            short index = 1;
            while (index <= num5)
            {
                short num6 = (short) Information.UBound(GlobalVariables.pname, 1);
                short num2 = 1;
                while (true)
                {
                    short num7 = num6;
                    if (num2 <= num7)
                    {
                        if (Strings.Trim(GlobalVariables.pname[num2]) != values[index])
                        {
                            num2 = (short) (num2 + 1);
                            continue;
                        }
                        if (Strings.Trim(GlobalVariables.pname[num2]) == "NIRR")
                        {
                            if (!second_Renamed)
                            {
                                num4 = (short) Information.UBound(ind, 1);
                                ind = (short[]) Utils.CopyArray((Array) ind, new short[1]);
                            }
                            else
                            {
                                num4 = (short) (Information.UBound(ind, 1) + 1);
                                ind = (short[]) Utils.CopyArray((Array) ind, new short[(Information.UBound(ind, 1) + 1) + 1]);
                            }
                            second_Renamed = true;
                            ind[Information.UBound(ind, 1)] = GlobalVariables.FirstPos[num2];
                        }
                        else
                        {
                            if (!second_Renamed)
                            {
                                num4 = (short) Information.UBound(ind, 1);
                                ind = (short[]) Utils.CopyArray((Array) ind, new short[0x65]);
                            }
                            else
                            {
                                num4 = (short) (Information.UBound(ind, 1) + 1);
                                ind = (short[]) Utils.CopyArray((Array) ind, new short[(Information.UBound(ind, 1) + 100) + 1]);
                            }
                            short num3 = 0;
                            while (true)
                            {
                                ind[(short) (num4 + num3)] = (short) (GlobalVariables.FirstPos[num2] + num3);
                                num3 = (short) (num3 + 1);
                                num7 = 0x63;
                                if (num3 > num7)
                                {
                                    second_Renamed = true;
                                    break;
                                }
                            }
                        }
                    }
                    index = (short) (index + 1);
                    break;
                }
            }
        }

        public static void SetIrrParNames(ref string[] values, ref CfrmMain frmMain)
        {
            ADODC projectDatabase = frmMain.ProjectDatabase;
            projectDatabase.RecordSource = "select * from Options where r_id=" + Conversions.ToString(GlobalVariables.IDExecute);
            projectDatabase.Refresh();
            short num = Conversions.ToShort(projectDatabase.Recordset[]["Crop"][]);
            short num2 = Conversions.ToShort(projectDatabase.Recordset[]["Solute"][]);
            projectDatabase = null;
            values = new string[6];
            values = new string[7];
            values = new string[8];
            if (!((num2 > 1) & (num > 1)) && ((num2 > 1) | (num > 1)))
            {
            }
            values[1] = "IRRDAY";
            values[2] = "AMIR";
            values[3] = "IRRSTART";
            values[4] = "IRREND";
            if ((num > 1) & (num2 > 1))
            {
                values[5] = "ZFINT";
                values[6] = "CONCI";
            }
            else if (num > 1)
            {
                values[5] = "ZFINT";
            }
            else if (num2 > 1)
            {
                values[5] = "CONCI";
            }
            values[Information.UBound(values, 1)] = "NIRR";
        }

        [DllImport("shell32.dll", EntryPoint="ShellExecuteA", CharSet=CharSet.Ansi, SetLastError=true, ExactSpelling=true)]
        public static extern int ShellExecute(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpOperation, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFile, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpParameters, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDirectory, int nShowCmd);
        public static bool WriteASCIIFile(ref string BinFile, ref string txtFile, ref bool NoVariableNames = false)
        {
            // Invalid method body.
        }

        public static bool WriteFile(ref string BinFile, ref SaveFileDialog Dlg, ref bool NoVariableNames)
        {
            // Invalid method body.
        }

        public static void WriteTOXSWAFile(string file_to_write, string binfile, int id)
        {
            float num;
            int num5;
            int num9;
            int num10;
            float num11;
            int num23;
            string str2 = "";
            CMACROSimulation simulation = new CMACROSimulation(MyProject.Forms.CfrmMain.DatabaseConnection) {
                RunID = (short) id
            };
            simulation.Load();
            Cursor.Current = Cursors.WaitCursor;
            object[] output = new object[] { 0, (int) 0x1f, (int) 0x3b, (int) 90, (int) 120, 0x97, 0xb5, 0xd4, 0xf3 };
            output[9] = 0x111;
            output[10] = 0x130;
            output[11] = 0x14e;
            output[12] = 0x16d;
            object obj2 = output;
            output = new object[] { 0, (int) 0x1f, (int) 60, (int) 0x5b, (int) 0x79, 0x98, 0xb6, 0xd5, 0xf4 };
            output[9] = 0x112;
            output[10] = 0x131;
            output[11] = 0x14f;
            output[12] = 0x16e;
            object obj3 = output;
            output = new object[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" };
            output[9] = "Oct";
            output[10] = "Nov";
            output[11] = "Dec";
            object obj4 = output;
            short fileNumber = (short) Microsoft.VisualBasic.FileSystem.FreeFile();
            Microsoft.VisualBasic.FileSystem.FileOpen(fileNumber, file_to_write, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
            string str3 = Conversions.ToString(DateAndTime.Now);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "Results from the user interface MACRO 5.2" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "MACRO kernel version 5.2" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "Run ID =" + Conversions.ToString(id) };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "Compound: (no name available) " };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "Crop: " + simulation.CropParameters.Crops[1].CropName };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5) };
            string[] strArray = new string[] { "Drainage to surface water: drains at ", Conversions.ToString(simulation.SiteParameters.Draindep), " m depth and ", Conversions.ToString(simulation.SiteParameters.Space_Renamed), " m spacing" };
            output[2] = string.Concat(strArray);
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "Simulation period MACRO from " + simulation.Setup.StartDate.ToString("yyyyMMdd") + " to " + simulation.Setup.EndDate.ToString("yyyyMMdd") };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), " " };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "Period of TOXSWA output from " + simulation.Setup.StartDate.ToString("yyyyMMdd") + " to " + simulation.Setup.EndDate.ToString("yyyyMMdd") };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "Number of applications (-)" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            int num8 = 0;
            int count = simulation.Irrigation.IrrigationYears.Count;
            int index = 1;
            while (index <= count)
            {
                int num14 = simulation.Irrigation.IrrigationYears[index].Irrigations.Count;
                num5 = 1;
                while (true)
                {
                    num23 = num14;
                    if (num5 > num23)
                    {
                        index++;
                        break;
                    }
                    if (simulation.Irrigation.IrrigationYears[index].Irrigations[num5].Conci > 0f)
                    {
                        num8++;
                    }
                    num5++;
                }
            }
            output = new object[] { "# ", Microsoft.VisualBasic.FileSystem.TAB(5), num8 };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(5), "Application (-)", Microsoft.VisualBasic.FileSystem.TAB(0x19), "Date (-)", Microsoft.VisualBasic.FileSystem.TAB(40), "Mass (g ai/ha)" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            DateTime time = new DateTime(simulation.Setup.StartDate.Year, 1, 1);
            switch (simulation.Options.sw_massunits)
            {
                case 1:
                    num = 0.01f;
                    num11 = 0.001f;
                    break;

                case 2:
                    num = 10f;
                    num11 = 1f;
                    break;

                case 3:
                    num = 10000f;
                    num11 = 1000f;
                    break;

                case 4:
                    num = 1E+07f;
                    num11 = 1000000f;
                    break;

                default:
                    break;
            }
            num8 = 0;
            if (!simulation.Irrigation.Irrsame)
            {
                int num16 = simulation.Irrigation.IrrigationYears.Count;
                index = 1;
                while (index <= num16)
                {
                    DateTime startDate = simulation.Setup.StartDate;
                    str2 = Conversions.ToString((int) ((startDate.Year + index) - 1));
                    CIrrigationYear year = simulation.Irrigation.IrrigationYears[index];
                    int num17 = year.Irrigations.Count;
                    num5 = 1;
                    while (true)
                    {
                        num23 = num17;
                        if (num5 > num23)
                        {
                            year = null;
                            index++;
                            break;
                        }
                        startDate = simulation.Setup.StartDate;
                        time = new DateTime((startDate.Year + index) - 1, 1, 1);
                        num8++;
                        time = time.AddDays((double) (year.Irrigations[num5].Irrday - 1));
                        if (year.Irrigations[num5].Conci <= 0f)
                        {
                            num8--;
                        }
                        else
                        {
                            output = new object[] { "#", Microsoft.VisualBasic.FileSystem.TAB(5), num8, Microsoft.VisualBasic.FileSystem.TAB(0x19), time.ToString("dd-MMM-yyyy"), Microsoft.VisualBasic.FileSystem.TAB(40), ((num * year.Irrigations[num5].Conci) * year.Irrigations[num5].Amir) / 1000f };
                            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
                        }
                        num5++;
                    }
                }
            }
            else
            {
                int num18 = (simulation.Setup.EndDate.Year - simulation.Setup.StartDate.Year) + 1;
                index = 1;
                while (index <= num18)
                {
                    DateTime startDate = simulation.Setup.StartDate;
                    str2 = Conversions.ToString((int) ((startDate.Year + index) - 1));
                    CIrrigationYear year2 = simulation.Irrigation.IrrigationYears[1];
                    int num19 = year2.Irrigations.Count;
                    num5 = 1;
                    while (true)
                    {
                        num23 = num19;
                        if (num5 > num23)
                        {
                            year2 = null;
                            index++;
                            break;
                        }
                        startDate = simulation.Setup.StartDate;
                        time = new DateTime((startDate.Year + index) - 1, 1, 1);
                        num8++;
                        time = time.AddDays((double) (year2.Irrigations[num5].Irrday - 1));
                        if (year2.Irrigations[num5].Conci <= 0f)
                        {
                            num8--;
                        }
                        else
                        {
                            output = new object[] { "#", Microsoft.VisualBasic.FileSystem.TAB(5), num8, Microsoft.VisualBasic.FileSystem.TAB(0x19), time.ToString("dd-MMM-yyyy"), Microsoft.VisualBasic.FileSystem.TAB(40), ((num * year2.Irrigations[num5].Conci) * year2.Irrigations[num5].Amir) / 1000f };
                            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
                        }
                        num5++;
                    }
                }
            }
            output = new object[] { "*" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            output = new object[] { "*", Microsoft.VisualBasic.FileSystem.TAB(2), "Time (YYYYMMDDHHMM)", Microsoft.VisualBasic.FileSystem.TAB(0x19), "Drainage_mm/h", Microsoft.VisualBasic.FileSystem.TAB(40), "Pest._flux_to_drains_mg/m2/h" };
            Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
            FixedLengthString str4 = new FixedLengthString(0x34);
            float[] numArray = new float[3];
            short num3 = (short) Microsoft.VisualBasic.FileSystem.FreeFile();
            Microsoft.VisualBasic.FileSystem.FileOpen(num3, binfile, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1);
            Microsoft.VisualBasic.FileSystem.FileGet(num3, ref num9, 1L);
            Microsoft.VisualBasic.FileSystem.FileGet(num3, ref num10, -1L);
            short num12 = (short) Math.Round((double) ((((double) num10) / 4.0) - 1.0));
            Microsoft.VisualBasic.FileSystem.Seek(num3, (long) (num10 + 1));
            int num20 = num9;
            num5 = 1;
            while (num5 <= num20)
            {
                int num6;
                Microsoft.VisualBasic.FileSystem.FileGet(num3, ref num6, -1L);
                string theYear = "";
                string str6 = "";
                string str7 = "";
                string str8 = "";
                string str9 = "";
                short dateFormat = 1;
                string str = ConvertJulianDate(num6, ref theYear, ref str6, ref str7, ref str8, ref str9, ref dateFormat);
                int num22 = num12;
                index = 1;
                while (true)
                {
                    num23 = num22;
                    if (index > num23)
                    {
                        output = new object[] { Microsoft.VisualBasic.FileSystem.TAB(2), str, Microsoft.VisualBasic.FileSystem.TAB(0x19), Math.Round((double) numArray[1], 4, MidpointRounding.ToEven), Microsoft.VisualBasic.FileSystem.TAB(40), Math.Round((double) (numArray[2] * num11), 5, MidpointRounding.ToEven) };
                        Microsoft.VisualBasic.FileSystem.PrintLine(fileNumber, output);
                        num5++;
                        break;
                    }
                    Microsoft.VisualBasic.FileSystem.FileGet(num3, ref numArray[index], -1L);
                    index++;
                }
            }
            Microsoft.VisualBasic.FileSystem.FileClose(new int[] { fileNumber });
        }
    }
}

