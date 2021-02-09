namespace MACRO_52
{
    using ADODB;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.Compatibility.VB6;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Diagnostics;
    using System.Reflection;

    [StandardModule]
    internal sealed class Indump
    {
        private static string str_Renamed;
        private static short nparameters;
        private static short nparameter_names;
        private static short[] plength;
        private static short j;
        private static short k;
        private static short i;
        private static short Length;
        private static float[] P;
        private static short[] pgroup;
        private static string search_data_string;
        private static short remain;
        private static short nrows;
        private static short S;
        private static string[] OutXNames;
        private static string[] OutDNames;
        private static string[] OutGNames;
        private static string[] OutTNames;
        private static short[] FirstPosX;
        private static short[] FirstPosG;
        private static short[] FirstPosT;
        private static short[] FirstPosD;
        private static short[] SelPosX;
        private static short[] SelPosG;
        private static short[] SelPosT;
        private static short[] SelPosD;
        private static short[] XPossible;
        private static short[] GPossible;
        private static short[] TPossible;
        private static short[] DPossible;
        private static short NumLayers;
        private static short NHori;
        private static int NTillage;
        private static string[] SwitchNames;
        private static short[] SwitchNo;

        private static void ClearArrays()
        {
            OutXNames = null;
            OutDNames = null;
            OutTNames = null;
            OutGNames = null;
            FirstPosX = null;
            FirstPosT = null;
            FirstPosD = null;
            FirstPosG = null;
            SelPosG = null;
            SelPosX = null;
            SelPosT = null;
            SelPosD = null;
            XPossible = null;
            DPossible = null;
            TPossible = null;
            GPossible = null;
            SwitchNames = null;
            SwitchNo = null;
            nparameters = 0;
            nparameter_names = 0;
        }

        private static void PrepareOutputArrays(ref CfrmMain frmMain)
        {
            CfrmMain main = frmMain;
            main.ProjectDatabase.RecordSource = "select * from [OutputInfo] where [Group]='G'";
            main.ProjectDatabase.Refresh();
            short recordCount = (short) main.ProjectDatabase.Recordset.RecordCount;
            OutGNames = new string[recordCount + 1];
            FirstPosG = new short[(recordCount + 1) + 1];
            ReadOutputNames(ref main.ProjectDatabase.Recordset, ref OutGNames, ref FirstPosG);
            SetSelAndPossible(ref main.ProjectDatabase.Recordset, ref FirstPosG, ref SelPosG, ref GPossible, ref frmMain);
            main.ProjectDatabase.RecordSource = "select * from OutputInfo where [Group]='X'";
            main.ProjectDatabase.Refresh();
            recordCount = (short) main.ProjectDatabase.Recordset.RecordCount;
            OutXNames = new string[recordCount + 1];
            FirstPosX = new short[(recordCount + 1) + 1];
            ReadOutputNames(ref main.ProjectDatabase.Recordset, ref OutXNames, ref FirstPosX);
            SetSelAndPossible(ref main.ProjectDatabase.Recordset, ref FirstPosX, ref SelPosX, ref XPossible, ref frmMain);
            main.ProjectDatabase.RecordSource = "select * from OutputInfo where [Group]='T'";
            main.ProjectDatabase.Refresh();
            recordCount = (short) main.ProjectDatabase.Recordset.RecordCount;
            OutTNames = new string[recordCount + 1];
            FirstPosT = new short[(recordCount + 1) + 1];
            ReadOutputNames(ref main.ProjectDatabase.Recordset, ref OutTNames, ref FirstPosT);
            SetSelAndPossible(ref main.ProjectDatabase.Recordset, ref FirstPosT, ref SelPosT, ref TPossible, ref frmMain);
            main.ProjectDatabase.RecordSource = "select * from OutputInfo where [Group]='D'";
            main.ProjectDatabase.Refresh();
            recordCount = (short) main.ProjectDatabase.Recordset.RecordCount;
            OutDNames = new string[recordCount + 1];
            FirstPosD = new short[(recordCount + 1) + 1];
            ReadOutputNames(ref main.ProjectDatabase.Recordset, ref OutDNames, ref FirstPosD);
            SetSelAndPossible(ref main.ProjectDatabase.Recordset, ref FirstPosD, ref SelPosD, ref DPossible, ref frmMain);
            main = null;
        }

        private static void PrepareParameterArrays(ref CfrmMain frmMain)
        {
            string str = "";
            string str2 = "";
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = new RecordsetClass();
            CfrmMain main = frmMain;
            rs.Open("select * from ParameterInfo order by [Order]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            nparameter_names = (short) ReadSaveFunctions.RecordCount(ref rs);
            while (true)
            {
                int num6;
                bool flag = !rs.EOF;
                if (!flag)
                {
                    rs.MoveFirst();
                    GlobalVariables.pname = new string[nparameter_names + 1];
                    GlobalVariables.FirstPos = new short[(nparameter_names + 1) + 1];
                    P = new float[nparameters + 1];
                    pgroup = new short[nparameter_names + 1];
                    plength = new short[nparameter_names + 1];
                    GlobalVariables.FirstPos[1] = 1;
                    i = 1;
                    short num8 = (short) ReadSaveFunctions.RecordCount(ref rs);
                    i = 1;
                    while (true)
                    {
                        short num4;
                        short num14 = num8;
                        if (i > num14)
                        {
                            GlobalVariables.FirstPos[i] = (short) (nparameters + 1);
                            main = null;
                            return;
                        }
                        GlobalVariables.pname[i] = Conversions.ToString(rs[]["ParameterName"][]);
                        if (Strings.UCase(GlobalVariables.pname[i]) == "FAWC")
                        {
                            GlobalVariables.pname[i] = "WATEN";
                        }
                        pgroup[i] = Conversions.ToShort(rs[]["Group"][]);
                        num6 = Conversions.ToInteger(rs[]["Length"][]);
                        plength[i] = (num6 != 60) ? ((num6 != 10) ? ((num6 != 100) ? ((short) 1) : ((short) 100)) : ((short) 10)) : NumLayers;
                        switch (pgroup[i])
                        {
                            case 1:
                                str = "Soil profile";
                                break;

                            case 2:
                                str = (plength[i] <= 1) ? "Site" : "Site()";
                                break;

                            case 3:
                                str = (plength[i] <= 1) ? "IB conditions" : "IB conditions()";
                                break;

                            case 4:
                                str = (plength[i] <= 1) ? "Solute" : "Solute()";
                                break;

                            case 5:
                                str = (plength[i] <= 1) ? "Solute" : "Solute()";
                                break;

                            case 6:
                                str = "Physical parameters";
                                break;

                            case 7:
                                str = "Crop";
                                break;

                            case 8:
                                str = (plength[i] <= 1) ? "Irrigation" : "Irrigation()";
                                break;

                            case 9:
                                str = "General";
                                break;

                            case 10:
                                str = "Properties";
                                break;

                            default:
                                break;
                        }
                        recordset2.Open("select * from [" + str + "] where R_id=" + Conversions.ToString(GlobalVariables.IDExecute), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        recordset2.MoveFirst();
                        str2 = str;
                        if (GlobalVariables.pname[i] == "NIRR")
                        {
                            num4 = 0;
                        }
                        string str3 = GlobalVariables.pname[i];
                        short num = 0;
                        if ((((((str != "IB conditions()") & (str != "Irrigation()")) & (str != "Site()")) & (str != "Site")) & (plength[i] > 1)) & (str != "Soil profile"))
                        {
                            short nhorizon = GlobalVariables.Nhorizon;
                            short index = 1;
                            while (index <= nhorizon)
                            {
                                float num7 = Conversions.ToSingle(recordset2[][str3][]);
                                short num11 = (short) (GlobalVariables.N_Layer[index] - 1);
                                num4 = 0;
                                while (true)
                                {
                                    num14 = num11;
                                    if (num4 > num14)
                                    {
                                        num = (short) (num + num4);
                                        recordset2.MoveNext();
                                        index = (short) (index + 1);
                                        break;
                                    }
                                    P[(short) (((short) (GlobalVariables.FirstPos[i] + num4)) + num)] = num7;
                                    num4 = (short) (num4 + 1);
                                }
                            }
                        }
                        else if (str == "Irrigation()")
                        {
                            recordset2.Close();
                            recordset2.Open("select " + GlobalVariables.pname[i] + " from [" + str + "] where R_id=" + Conversions.ToString(GlobalVariables.IDExecute) + " AND IRRYEAR = 1 ORDER BY IRRIG_NO", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            short num12 = (short) (((short) ReadSaveFunctions.RecordCount(ref recordset2)) - 1);
                            num4 = 0;
                            while (true)
                            {
                                num14 = num12;
                                if (num4 > num14)
                                {
                                    break;
                                }
                                P[(short) (((short) (GlobalVariables.FirstPos[i] + num4)) + num)] = Conversions.ToSingle(recordset2[][str3][]);
                                recordset2.MoveNext();
                                num4 = (short) (num4 + 1);
                            }
                        }
                        else
                        {
                            short num13 = (short) (((short) ReadSaveFunctions.RecordCount(ref recordset2)) - 1);
                            num4 = 0;
                            while (true)
                            {
                                num14 = num13;
                                if (num4 > num14)
                                {
                                    break;
                                }
                                if (Information.IsDBNull(recordset2[][str3][]))
                                {
                                    P[(short) (((short) (GlobalVariables.FirstPos[i] + num4)) + num)] = 0f;
                                }
                                else
                                {
                                    P[(short) (((short) (GlobalVariables.FirstPos[i] + num4)) + num)] = Conversions.ToSingle(recordset2[][str3][]);
                                    if ((str3 == "IHARV") & (num4 == 0))
                                    {
                                        GlobalVariables.m_Harvestday = (short) Math.Round((double) P[(short) (((short) (GlobalVariables.FirstPos[i] + num4)) + num)]);
                                    }
                                }
                                recordset2.MoveNext();
                                flag = GlobalVariables.pname[i] == "FREUND";
                                if (flag)
                                {
                                    P[(short) (((short) (GlobalVariables.FirstPos[i] + num4)) + num)] = 1f;
                                }
                                num4 = (short) (num4 + 1);
                            }
                        }
                        flag = i < nparameter_names;
                        if (flag)
                        {
                            GlobalVariables.FirstPos[i + 1] = (short) (GlobalVariables.FirstPos[i] + plength[i]);
                        }
                        rs.MoveNext();
                        recordset2.Close();
                        i = (short) (i + 1);
                    }
                }
                num6 = Conversions.ToInteger(rs[]["Length"][]);
                nparameters = (num6 != 60) ? (!((num6 == 10) | (num6 == 100)) ? ((short) (nparameters + 1)) : ((short) (nparameters + num6))) : ((short) (nparameters + NumLayers));
                rs.MoveNext();
            }
        }

        private static void PrepareSwitchArrays(ref CfrmMain frmMain)
        {
            Recordset recordset = new RecordsetClass();
            short index = 0;
            CfrmMain main = frmMain;
            main.ProjectDatabase.RecordSource = "select * from SwitchInfo";
            main.ProjectDatabase.Refresh();
            SwitchNames = new string[main.ProjectDatabase.Recordset.RecordCount + 1];
            SwitchNo = new short[main.ProjectDatabase.Recordset.RecordCount + 1];
            short recordCount = (short) main.ProjectDatabase.Recordset.RecordCount;
            short num2 = 1;
            while (true)
            {
                short num4 = recordCount;
                if (num2 > num4)
                {
                    main = null;
                    return;
                }
                index = (short) (index + 1);
                SwitchNames[index] = Conversions.ToString(main.ProjectDatabase.Recordset[][0][]);
                recordset.Open(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select [", main.ProjectDatabase.Recordset[][0][]), "] from Options where R_id="), GlobalVariables.IDExecute), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                SwitchNo[index] = Conversions.ToShort(recordset[][0][]);
                if (SwitchNames[index] == "nitrate")
                {
                    SwitchNo[index] = 0;
                }
                recordset.Close();
                main.ProjectDatabase.Recordset.MoveNext();
                num2 = (short) (num2 + 1);
            }
        }

        private static void ReadOutputNames(ref Recordset rec, ref string[] str_Renamed, ref short[] pos)
        {
            short index = 1;
            short recordCount = (short) rec.RecordCount;
            index = 1;
            while (true)
            {
                short num5 = recordCount;
                if (index > num5)
                {
                    pos[1] = 1;
                    rec.MoveFirst();
                    short num4 = (short) (((short) rec.RecordCount) - 1);
                    index = 1;
                    while (true)
                    {
                        num5 = num4;
                        if (index > num5)
                        {
                            rec.MoveLast();
                            pos[rec.RecordCount + 1] = !Operators.ConditionalCompareObjectEqual(rec[]["Length"][], 1, false) ? ((short) (pos[rec.RecordCount] + 200)) : Conversions.ToShort(Operators.AddObject(pos[rec.RecordCount], rec[]["Length"][]));
                            rec.MoveFirst();
                            return;
                        }
                        bool flag = Operators.ConditionalCompareObjectEqual(rec[]["Length"][], 1, false);
                        pos[index + 1] = !flag ? ((short) (pos[index] + 200)) : Conversions.ToShort(Operators.AddObject(pos[index], rec[]["Length"][]));
                        rec.MoveNext();
                        index = (short) (index + 1);
                    }
                }
                str_Renamed[index] = Conversions.ToString(rec[]["VarName"][]);
                if (str_Renamed[index] == "ALPHA")
                {
                    str_Renamed[index] = "ZLAMB";
                }
                rec.MoveNext();
                index = (short) (index + 1);
            }
        }

        private static void ReadParameterValues(ref string VarName, ref short group, ref short startpos, ref short ArrayLength, ref CfrmMain frmMain)
        {
            short num3;
            string str = "";
            Recordset rs = new RecordsetClass();
            switch (group)
            {
                case 1:
                    str = "Soil profile";
                    break;

                case 2:
                    str = (ArrayLength <= 1) ? "Site" : "Site()";
                    break;

                case 3:
                    str = (ArrayLength <= 1) ? "IB conditions" : "IB conditions()";
                    break;

                case 4:
                    str = (ArrayLength <= 1) ? "Solute" : "Solute()";
                    break;

                case 5:
                    str = (ArrayLength <= 1) ? "Solute" : "Solute()";
                    break;

                case 6:
                    str = "Physical parameters";
                    break;

                case 7:
                    str = "Crop";
                    break;

                case 8:
                    str = (ArrayLength <= 1) ? "Irrigation" : "Irrigation()";
                    break;

                case 9:
                    str = "General";
                    break;

                default:
                    break;
            }
            Recordset recordset2 = rs;
            string[] strArray = new string[] { "select ", VarName, " from [", str, "] where R_id=", Conversions.ToString(GlobalVariables.IDExecute) };
            recordset2.Open(string.Concat(strArray), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (VarName == "NIRR")
            {
                num3 = 0;
            }
            if (ReadSaveFunctions.RecordCount(ref rs) == 0)
            {
                object[] args = new object[] { VarName + " not found in table " + str, MsgBoxStyle.Critical, "Error" };
                Debug.Print(Support.TabLayout(args));
            }
            else
            {
                short num10;
                short num = 0;
                if ((((((str != "IB conditions()") & (str != "Irrigation()")) & (str != "Site()")) & (str != "Site")) & (ArrayLength > 1)) & (str != "Soil profile"))
                {
                    short nhorizon = GlobalVariables.Nhorizon;
                    short index = 1;
                    while (index <= nhorizon)
                    {
                        short num7 = (short) (GlobalVariables.N_Layer[index] - 1);
                        num3 = 0;
                        while (true)
                        {
                            num10 = num7;
                            if (num3 > num10)
                            {
                                num = (short) (num + num3);
                                recordset2.MoveNext();
                                index = (short) (index + 1);
                                break;
                            }
                            P[(short) (((short) (startpos + num3)) + num)] = Conversions.ToSingle(recordset2[][0][]);
                            num3 = (short) (num3 + 1);
                        }
                    }
                }
                else if (str != "Irrigation()")
                {
                    short num9 = (short) (((short) ReadSaveFunctions.RecordCount(ref rs)) - 1);
                    num3 = 0;
                    while (true)
                    {
                        num10 = num9;
                        if (num3 > num10)
                        {
                            break;
                        }
                        P[(short) (((short) (startpos + num3)) + num)] = Conversions.ToSingle(recordset2[][0][]);
                        recordset2.MoveNext();
                        num3 = (short) (num3 + 1);
                    }
                }
                else
                {
                    recordset2.Close();
                    recordset2.Open("select " + VarName + " from [" + str + "] where R_id=" + Conversions.ToString(GlobalVariables.IDExecute) + " AND IRRYEAR = 1 ORDER BY IRRIG_NO", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    short num8 = (short) (((short) ReadSaveFunctions.RecordCount(ref rs)) - 1);
                    num3 = 0;
                    while (true)
                    {
                        num10 = num8;
                        if (num3 > num10)
                        {
                            break;
                        }
                        P[(short) (((short) (startpos + num3)) + num)] = Conversions.ToSingle(recordset2[][0][]);
                        recordset2.MoveNext();
                        num3 = (short) (num3 + 1);
                    }
                }
                recordset2 = null;
            }
        }

        public static string rformat(ref object Value, ref string fmt) => 
            Support.Format(Support.Format(Value, fmt, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1), new string('@', Strings.Len((string) fmt)), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);

        private static void SetSelAndPossible(ref Recordset rec, ref short[] startpos, ref short[] sel, ref short[] possible, ref CfrmMain frmMain)
        {
            string str = "";
            Recordset rs = new RecordsetClass();
            Recordset recordset = new RecordsetClass();
            bool flag = true;
            bool flag3 = false;
            sel = new short[2];
            possible = new short[2];
            short index = 0;
            short recordCount = (short) rec.RecordCount;
            short num3 = 1;
            while (true)
            {
                bool flag2;
                short num10 = recordCount;
                if (num3 > num10)
                {
                    if (!flag3)
                    {
                        sel = new short[1];
                    }
                    return;
                }
                index = (short) (index + 1);
                Recordset recordset3 = recordset;
                if (Operators.ConditionalCompareObjectGreater(rec[]["Length"][], 1, false))
                {
                    recordset3.Open("select * from [Output()] where R_ID=" + Conversions.ToString(GlobalVariables.IDExecute), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    flag2 = true;
                }
                else
                {
                    recordset3.Open("select * from [Output] where R_ID=" + Conversions.ToString(GlobalVariables.IDExecute), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    flag2 = false;
                }
                str = Conversions.ToString(rec[]["VarName"][]);
                recordset3.MoveFirst();
                recordset3.Find(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Var ='", rec[]["VarName"][]), "'")), 0, SearchDirectionEnum.adSearchForward, Missing.Value);
                if (!recordset3.EOF)
                {
                    short num = (short) Information.UBound(sel, 1);
                    short num5 = (short) Information.UBound(possible, 1);
                    if (!flag3)
                    {
                        num = 0;
                    }
                    if (flag)
                    {
                        num5 = 0;
                    }
                    if (!Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(flag2, Operators.CompareObjectEqual(recordset3[]["Selected"][], MACROConstants.OutputState.Selected, false)), Operators.CompareObjectEqual(recordset3[]["Enabled"][], MACROConstants.OutputState.Enabled, false))))
                    {
                        if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(recordset3[]["Selected"][], MACROConstants.OutputState.Selected, false), Operators.CompareObjectEqual(recordset3[]["Enabled"][], MACROConstants.OutputState.Enabled, false))))
                        {
                            flag3 = true;
                            GlobalVariables.NumberOfSelectedOutputs++;
                            sel = (short[]) Utils.CopyArray((Array) sel, new short[(num + 1) + 1]);
                            sel[num + 1] = startpos[index];
                            flag = false;
                        }
                    }
                    else
                    {
                        flag3 = true;
                        rs.Open(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from [OutputLayers] where [Output()ID]=", recordset3[]["Output()ID"][]), "AND [Selected]=1 ORDER BY LayerNO"), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        int num8 = ReadSaveFunctions.RecordCount(ref rs);
                        int num4 = 1;
                        while (true)
                        {
                            int num9 = num8;
                            if (num4 > num9)
                            {
                                rs.Close();
                                flag = false;
                                break;
                            }
                            num = (short) (num + 1);
                            GlobalVariables.NumberOfSelectedOutputs++;
                            sel = (short[]) Utils.CopyArray((Array) sel, new short[num + 1]);
                            sel[num] = Conversions.ToShort(Operators.SubtractObject(Operators.AddObject(startpos[index], rs[]["Layerno"][]), 1));
                            rs.MoveNext();
                            num4++;
                        }
                    }
                    if (!Conversions.ToBoolean(Operators.AndObject(flag2, Operators.CompareObjectEqual(recordset3[]["Enabled"][], MACROConstants.OutputState.Enabled, false))))
                    {
                        if (Operators.ConditionalCompareObjectEqual(recordset3[]["Enabled"][], MACROConstants.OutputState.Enabled, false))
                        {
                            possible = (short[]) Utils.CopyArray((Array) possible, new short[(num5 + 1) + 1]);
                            possible[num5 + 1] = startpos[index];
                            flag = false;
                        }
                    }
                    else
                    {
                        possible = (short[]) Utils.CopyArray((Array) possible, new short[(num5 + 200) + 1]);
                        short num2 = 1;
                        while (true)
                        {
                            possible[(short) (num5 + num2)] = (short) (((short) (startpos[index] + num2)) - 1);
                            num2 = (short) (num2 + 1);
                            num10 = 200;
                            if (num2 > num10)
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                }
                recordset3.Close();
                recordset3 = null;
                rec.MoveNext();
                num3 = (short) (num3 + 1);
            }
        }

        public static void WriteIndump(ref short fp, ref CfrmMain frmMain)
        {
            Recordset rs = new RecordsetClass();
            ADODC projectDatabase = frmMain.ProjectDatabase;
            projectDatabase.RecordSource = "select * from Run_ID where R_id=" + Conversions.ToString(GlobalVariables.IDExecute);
            projectDatabase.Refresh();
            GlobalVariables.OutputPath = Conversions.ToString(projectDatabase.Recordset[]["OutputFileDir"][]);
            NumLayers = Conversions.ToShort(projectDatabase.Recordset[]["NumLayers"][]);
            GlobalVariables.Nhorizon = Conversions.ToShort(projectDatabase.Recordset[]["NHori"][]);
            NTillage = Conversions.ToInteger(projectDatabase.Recordset[]["NTill"][]);
            projectDatabase = null;
            Recordset recordset2 = rs;
            recordset2.Open("Select * from Properties where R_id=" + Conversions.ToString(GlobalVariables.IDExecute), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            short index = 1;
            short num3 = (short) ReadSaveFunctions.RecordCount(ref rs);
            index = 1;
            while (true)
            {
                short num6 = num3;
                if (index > num6)
                {
                    object iDExecute;
                    recordset2.Close();
                    recordset2 = null;
                    GlobalVariables.NumberOfSelectedOutputs = 0.0;
                    ClearArrays();
                    PrepareParameterArrays(ref frmMain);
                    PrepareOutputArrays(ref frmMain);
                    PrepareSwitchArrays(ref frmMain);
                    object[] output = new object[] { "1    0" };
                    FileSystem.PrintLine(fp, output);
                    output = new object[] { "MACRO" };
                    FileSystem.PrintLine(fp, output);
                    output = new object[] { "2    0" };
                    FileSystem.PrintLine(fp, output);
                    output = new object[] { "5.2" };
                    FileSystem.PrintLine(fp, output);
                    output = new object[] { "3    0" };
                    FileSystem.PrintLine(fp, output);
                    output = new object[] { rformat(ref iDExecute, ref "######") };
                    iDExecute = GlobalVariables.IDExecute;
                    GlobalVariables.IDExecute = Conversions.ToInteger(iDExecute);
                    FileSystem.PrintLine(fp, output);
                    output = new object[] { NumLayers };
                    FileSystem.PrintLine(fp, output);
                    WriteParameters(ref fp);
                    WriteOutput(ref fp);
                    output = new object[] { 5, Information.UBound(SwitchNo, 1) - Information.LBound(SwitchNo, 1) };
                    FileSystem.PrintLine(fp, output);
                    WriteIntegerArray(ref (short) Information.UBound(SwitchNo, 1), ref SwitchNo, ref fp);
                    output = new object[] { 6, Information.UBound(SwitchNo, 1) - Information.LBound(SwitchNo, 1) };
                    FileSystem.PrintLine(fp, output);
                    WriteStringArray(ref 8, ref SwitchNames, ref fp, ref 9);
                    ClearArrays();
                    return;
                }
                GlobalVariables.N_Layer[index] = Conversions.ToShort(recordset2[]["NLayer"][]);
                recordset2.MoveNext();
                index = (short) (index + 1);
            }
        }

        public static void WriteIntegerArray(ref short ItemsPerLine, ref short[] Values, ref short fp)
        {
            if ((Information.LBound(Values, 1) == 0) && (Information.UBound(Values, 1) == Information.LBound(Values, 1)))
            {
                Debug.Print("Not an array!");
            }
            else
            {
                short num3 = (short) Math.Round(Conversion.Int((double) (((double) (Information.UBound(Values, 1) - Information.LBound(Values, 1))) / ((double) ItemsPerLine))));
                short num4 = (short) ((Information.UBound(Values, 1) - Information.LBound(Values, 1)) - ((short) (num3 * ItemsPerLine)));
                short num6 = num3;
                short num = 1;
                while (true)
                {
                    short num2;
                    short num5;
                    object[] objArray;
                    short num9;
                    if (num > num6)
                    {
                        if (num4 > 0)
                        {
                            num5 = (short) (num3 * ItemsPerLine);
                            short num8 = (short) (num4 - 1);
                            num2 = 1;
                            while (true)
                            {
                                num9 = num8;
                                if (num2 > num9)
                                {
                                    objArray = new object[] { Values[((short) (num5 + num4)) + Information.LBound(Values, 1)] };
                                    FileSystem.PrintLine(fp, objArray);
                                    break;
                                }
                                objArray = new object[] { Values[((short) (num5 + num2)) + Information.LBound(Values, 1)] };
                                FileSystem.Print(fp, objArray);
                                num2 = (short) (num2 + 1);
                            }
                        }
                        break;
                    }
                    num5 = (short) (ItemsPerLine * (num - 1));
                    short num7 = (short) (ItemsPerLine - 1);
                    num2 = 1;
                    while (true)
                    {
                        num9 = num7;
                        if (num2 > num9)
                        {
                            objArray = new object[] { Values[((short) (num5 + ItemsPerLine)) + Information.LBound(Values, 1)] };
                            FileSystem.PrintLine(fp, objArray);
                            num = (short) (num + 1);
                            break;
                        }
                        objArray = new object[] { Values[((short) (num5 + num2)) + Information.LBound(Values, 1)] };
                        FileSystem.Print(fp, objArray);
                        num2 = (short) (num2 + 1);
                    }
                }
            }
        }

        private static void WriteOutput(ref short fp)
        {
            WriteOutputSet(ref 10, ref 11, ref 0x13, ref 0x33, ref OutXNames, ref FirstPosX, ref SelPosX, ref XPossible, ref fp);
            WriteOutputSet(ref 12, ref 13, ref 20, ref 0x34, ref OutTNames, ref FirstPosT, ref SelPosT, ref TPossible, ref fp);
            WriteOutputSet(ref 14, ref 15, ref 0x15, ref 0x35, ref OutGNames, ref FirstPosG, ref SelPosG, ref GPossible, ref fp);
            WriteOutputSet(ref 0x10, ref 0x11, ref 0x16, ref 0x36, ref OutDNames, ref FirstPosD, ref SelPosD, ref DPossible, ref fp);
        }

        private static void WriteOutputSet(ref short g1, ref short g2, ref short g3, ref short g4, ref string[] names, ref short[] start, ref short[] selpos, ref short[] possible, ref short fp)
        {
            object[] output = new object[] { (short) g1, Information.UBound(names, 1) };
            FileSystem.PrintLine(fp, output);
            WriteStringArray(ref 8, ref names, ref fp, ref 9);
            output = new object[] { (short) g2, Information.UBound(names, 1) + 1 };
            FileSystem.PrintLine(fp, output);
            WriteIntegerArray(ref 8, ref start, ref fp);
            output = new object[] { (short) g3, Information.UBound(selpos, 1) };
            FileSystem.PrintLine(fp, output);
            WriteIntegerArray(ref 8, ref selpos, ref fp);
            output = new object[] { (short) g4, Information.UBound(possible, 1) };
            FileSystem.PrintLine(fp, output);
            WriteIntegerArray(ref 8, ref possible, ref fp);
        }

        public static void WriteParameterArray(ref short ItemsPerLine, ref float[] Values, ref short fp, ref string fm)
        {
            short num2;
            short num5;
            int num8;
            object obj2;
            object[] objArray;
            short num10;
            short num3 = (short) Math.Round(Conversion.Int((double) (((double) (Information.UBound(Values, 1) - Information.LBound(Values, 1))) / ((double) ItemsPerLine))));
            short num4 = (short) ((Information.UBound(Values, 1) - Information.LBound(Values, 1)) - ((short) (num3 * ItemsPerLine)));
            short num6 = num3;
            short num = 1;
            while (num <= num6)
            {
                num5 = (short) (ItemsPerLine * (num - 1));
                short num7 = (short) (ItemsPerLine - 1);
                num2 = 1;
                while (true)
                {
                    num10 = num7;
                    if (num2 > num10)
                    {
                        objArray = new object[] { Strings.Replace(rformat(ref obj2, ref fm), ",", ".", 1, -1, CompareMethod.Binary) };
                        num8 = ((short) (num5 + ItemsPerLine)) + Information.LBound(Values, 1);
                        obj2 = Values[num8];
                        Values[num8] = Conversions.ToSingle(obj2);
                        FileSystem.PrintLine(fp, objArray);
                        num = (short) (num + 1);
                        break;
                    }
                    objArray = new object[] { Strings.Replace(rformat(ref obj2, ref fm), ",", ".", 1, -1, CompareMethod.Binary) + " " };
                    num8 = ((short) (num5 + num2)) + Information.LBound(Values, 1);
                    obj2 = Values[num8];
                    Values[num8] = Conversions.ToSingle(obj2);
                    FileSystem.Print(fp, objArray);
                    num2 = (short) (num2 + 1);
                }
            }
            if (num4 > 0)
            {
                num5 = (short) (num3 * ItemsPerLine);
                short num9 = (short) (num4 - 1);
                num2 = 1;
                while (true)
                {
                    num10 = num9;
                    if (num2 > num10)
                    {
                        objArray = new object[] { Strings.Replace(rformat(ref obj2, ref fm), ",", ".", 1, -1, CompareMethod.Binary) };
                        num8 = ((short) (num5 + num4)) + Information.LBound(Values, 1);
                        obj2 = Values[num8];
                        Values[num8] = Conversions.ToSingle(obj2);
                        FileSystem.PrintLine(fp, objArray);
                        break;
                    }
                    objArray = new object[] { Strings.Replace(rformat(ref obj2, ref fm) + " ", ",", ".", 1, -1, CompareMethod.Binary) };
                    num8 = ((short) (num5 + num2)) + Information.LBound(Values, 1);
                    obj2 = Values[num8];
                    Values[num8] = Conversions.ToSingle(obj2);
                    FileSystem.Print(fp, objArray);
                    num2 = (short) (num2 + 1);
                }
            }
        }

        private static void WriteParameters(ref short fp)
        {
            object[] output = new object[] { "4", FileSystem.TAB(8), nparameters };
            FileSystem.PrintLine(fp, output);
            WriteParameterArray(ref 6, ref P, ref fp, ref "0.0000E+00");
            output = new object[] { "8", FileSystem.TAB(10), nparameter_names + 1 };
            FileSystem.PrintLine(fp, output);
            WriteIntegerArray(ref 8, ref GlobalVariables.FirstPos, ref fp);
            output = new object[] { "7", FileSystem.TAB(10), nparameter_names };
            FileSystem.PrintLine(fp, output);
            WriteStringArray(ref 8, ref GlobalVariables.pname, ref fp, ref 9);
            output = new object[] { "9", FileSystem.TAB(10), nparameter_names };
            FileSystem.PrintLine(fp, output);
            WriteIntegerArray(ref 8, ref pgroup, ref fp);
            P = null;
            pgroup = null;
        }

        private static void WriteStringArray(ref short ItemsPerLine, ref string[] Values, ref short fp, ref short width)
        {
            short num2;
            short num3;
            short num6;
            object[] objArray;
            bool flag;
            short num10;
            short num4 = (short) Math.Round(Conversion.Int((double) (((double) (Information.UBound(Values, 1) - Information.LBound(Values, 1))) / ((double) ItemsPerLine))));
            short num5 = (short) ((Information.UBound(Values, 1) - Information.LBound(Values, 1)) - ((short) (num4 * ItemsPerLine)));
            short num7 = num4;
            short num = 1;
            while (num <= num7)
            {
                num6 = (short) (ItemsPerLine * (num - 1));
                short num8 = (short) (ItemsPerLine - 1);
                num2 = 1;
                while (true)
                {
                    num10 = num8;
                    if (num2 > num10)
                    {
                        num3 = (short) Strings.Len(Values[(short) (num6 + num2)]);
                        Values[(short) (num6 + num2)] = (num3 >= width) ? Strings.Left(Values[(short) (num6 + num2)], width) : (Values[(short) (num6 + num2)] + Strings.Space((short) (width - num3)));
                        objArray = new object[] { Values[(short) (num6 + ItemsPerLine)] };
                        FileSystem.PrintLine(fp, objArray);
                        num = (short) (num + 1);
                        break;
                    }
                    num3 = (short) Strings.Len(Values[(short) (num6 + num2)]);
                    flag = num3 < width;
                    Values[(short) (num6 + num2)] = !flag ? Strings.Left(Values[(short) (num6 + num2)], width) : (Values[(short) (num6 + num2)] + Strings.Space((short) (width - num3)));
                    objArray = new object[] { Values[(short) (num6 + num2)] };
                    FileSystem.Print(fp, objArray);
                    num2 = (short) (num2 + 1);
                }
            }
            if (num5 > 0)
            {
                num6 = (short) (num4 * ItemsPerLine);
                short num9 = (short) (num5 - 1);
                num2 = 1;
                while (true)
                {
                    num10 = num9;
                    if (num2 > num10)
                    {
                        num3 = (short) Strings.Len(Values[(short) (num6 + num5)]);
                        Values[(short) (num6 + num2)] = (num3 >= width) ? Strings.Left(Values[(short) (num6 + num2)], width) : (Values[(short) (num6 + num2)] + Strings.Space((short) (width - num3)));
                        objArray = new object[] { Values[(short) (num6 + num5)] };
                        FileSystem.PrintLine(fp, objArray);
                        break;
                    }
                    num3 = (short) Strings.Len(Values[(short) (num6 + num2)]);
                    flag = num3 < width;
                    Values[(short) (num6 + num2)] = !flag ? Strings.Left(Values[(short) (num6 + num2)], width) : (Values[(short) (num6 + num2)] + Strings.Space((short) (width - num3)));
                    objArray = new object[] { Values[(short) (num6 + num2)] };
                    FileSystem.Print(fp, objArray);
                    num2 = (short) (num2 + 1);
                }
            }
        }
    }
}

