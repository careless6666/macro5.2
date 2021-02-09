namespace MACRO_52
{
    using ADODB;
    using MACRO_52.My;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.Compatibility.VB6;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Reflection;
    using System.Windows.Forms;

    [StandardModule]
    internal sealed class ReadSaveFunctions
    {
        private static string msg;
        private static string S;
        private static short j;

        private static bool IsInGroup(ref short Y)
        {
            bool flag;
            short num3 = (short) Information.UBound(GlobalVariables.Groups, 1);
            short num2 = 1;
            while (true)
            {
                if (num2 > num3)
                {
                    break;
                }
                short num4 = (short) Information.UBound(GlobalVariables.Groups, 2);
                short num = 1;
                while (true)
                {
                    short num5 = num4;
                    if (num <= num5)
                    {
                        if (GlobalVariables.Groups[num2, num] != Y)
                        {
                            num = (short) (num + 1);
                            continue;
                        }
                        return true;
                    }
                    else
                    {
                        num2 = (short) (num2 + 1);
                    }
                    break;
                }
            }
            return flag;
        }

        public static void ReadChapar(ref int id, ref CfrmMain frmMain)
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = rs;
            recordset2.Open("select * from [Chapar] where R_ID=" + Conversions.ToString((int) id), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            if (rs.EOF)
            {
                GlobalVariables.Chapar = new string[1, 4];
            }
            else
            {
                recordset2.MoveFirst();
                GlobalVariables.Chapar = new string[RecordCount(ref rs) + 1, 4];
                int num = 1;
                while (true)
                {
                    if (recordset2.EOF)
                    {
                        break;
                    }
                    GlobalVariables.Chapar[num, 1] = Conversions.ToString(recordset2[]["ParameterName"][]);
                    GlobalVariables.Chapar[num, 2] = Conversions.ToString(recordset2[]["Date"][]);
                    GlobalVariables.Chapar[num, 3] = Conversions.ToString(recordset2[]["Value"][]);
                    num++;
                    recordset2.MoveNext();
                }
            }
            recordset2 = null;
            rs.Close();
        }

        public static void ReadCrop(ref int id, ref CfrmMain frmMain)
        {
            j = 0;
            S = "R_ID = " + Conversion.Str((int) id);
            Recordset recordset = new RecordsetClass();
            Recordset recordset2 = recordset;
            recordset2.Open("SELECT * FROM Crop WHERE " + S + " ORDER BY year", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                if (recordset.EOF)
                {
                    GlobalVariables.NumOfYears = j;
                    recordset2 = null;
                    recordset.Close();
                    return;
                }
                j = (short) (j + 1);
                GlobalVariables.Y_ear[j] = Conversions.ToShort(recordset2[]["year"][]);
                GlobalVariables.ncrop[j] = Conversions.ToShort(recordset2[]["ncrop"][]);
                GlobalVariables.cropname[j] = Conversions.ToString(recordset2[]["cropname"][]);
                GlobalVariables.rootinit[j] = Conversions.ToSingle(recordset2[]["rootinit"][]);
                GlobalVariables.rootinit_c[j] = Conversions.ToShort(recordset2[]["rootinit_c"][]);
                GlobalVariables.rootmax[j] = Conversions.ToSingle(recordset2[]["rootmax"][]);
                GlobalVariables.rootmax_c[j] = Conversions.ToShort(recordset2[]["rootmax_c"][]);
                GlobalVariables.rootdep[j] = Conversions.ToSingle(recordset2[]["rootdep"][]);
                GlobalVariables.rootdep_c[j] = Conversions.ToShort(recordset2[]["rootdep_c"][]);
                GlobalVariables.cform[j] = Conversions.ToSingle(recordset2[]["cform"][]);
                GlobalVariables.cform_c[j] = Conversions.ToShort(recordset2[]["cform_c"][]);
                GlobalVariables.rpin[j] = Conversions.ToSingle(recordset2[]["rpin"][]);
                GlobalVariables.rpin_c[j] = Conversions.ToShort(recordset2[]["rpin_c"][]);
                GlobalVariables.fawc[j] = Conversions.ToSingle(recordset2[]["fawc"][]);
                GlobalVariables.fawc_c[j] = Conversions.ToShort(recordset2[]["fawc_c"][]);
                GlobalVariables.critair[j] = Conversions.ToSingle(recordset2[]["critair"][]);
                GlobalVariables.critair_c[j] = Conversions.ToShort(recordset2[]["critair_c"][]);
                GlobalVariables.beta[j] = Conversions.ToSingle(recordset2[]["beta"][]);
                GlobalVariables.beta_c[j] = Conversions.ToShort(recordset2[]["beta_c"][]);
                GlobalVariables.cancap[j] = Conversions.ToSingle(recordset2[]["cancap"][]);
                GlobalVariables.cancap_c[j] = Conversions.ToShort(recordset2[]["cancap_c"][]);
                GlobalVariables.zalp[j] = Conversions.ToSingle(recordset2[]["zalp"][]);
                GlobalVariables.zalp_c[j] = Conversions.ToShort(recordset2[]["zalp_c"][]);
                GlobalVariables.idstart[j] = Conversions.ToShort(recordset2[]["idstart"][]);
                GlobalVariables.idstart_c[j] = Conversions.ToShort(recordset2[]["idstart_c"][]);
                GlobalVariables.idmax[j] = Conversions.ToShort(recordset2[]["idmax"][]);
                GlobalVariables.idmax_c[j] = Conversions.ToShort(recordset2[]["idmax_c"][]);
                GlobalVariables.iharv[j] = Conversions.ToShort(recordset2[]["iharv"][]);
                GlobalVariables.iharv_c[j] = Conversions.ToShort(recordset2[]["iharv_c"][]);
                GlobalVariables.zhmin[j] = Conversions.ToSingle(recordset2[]["zhmin"][]);
                GlobalVariables.zhmin_c[j] = Conversions.ToShort(recordset2[]["zhmin_c"][]);
                GlobalVariables.laic[j] = Conversions.ToSingle(recordset2[]["laic"][]);
                GlobalVariables.laic_c[j] = Conversions.ToShort(recordset2[]["laic_c"][]);
                GlobalVariables.laimin[j] = Conversions.ToSingle(recordset2[]["laimin"][]);
                GlobalVariables.laimin_c[j] = Conversions.ToShort(recordset2[]["laimin_c"][]);
                GlobalVariables.laimax[j] = Conversions.ToSingle(recordset2[]["laimax"][]);
                GlobalVariables.laimax_c[j] = Conversions.ToShort(recordset2[]["laimax_c"][]);
                GlobalVariables.zdatemin[j] = Conversions.ToShort(recordset2[]["zdatemin"][]);
                GlobalVariables.zdatemin_c[j] = Conversions.ToShort(recordset2[]["zdatemin_c"][]);
                GlobalVariables.dform[j] = Conversions.ToSingle(recordset2[]["dform"][]);
                GlobalVariables.dform_c[j] = Conversions.ToShort(recordset2[]["dform_c"][]);
                GlobalVariables.laihar[j] = Conversions.ToSingle(recordset2[]["laihar"][]);
                GlobalVariables.laihar_c[j] = Conversions.ToShort(recordset2[]["laihar_c"][]);
                GlobalVariables.hmax[j] = Conversions.ToSingle(recordset2[]["hmax"][]);
                GlobalVariables.hmax_c[j] = Conversions.ToShort(recordset2[]["hmax_c"][]);
                GlobalVariables.rsmin[j] = Conversions.ToSingle(recordset2[]["rsmin"][]);
                GlobalVariables.rsmin_c[j] = Conversions.ToShort(recordset2[]["rsmin_c"][]);
                GlobalVariables.atten[j] = Conversions.ToSingle(recordset2[]["atten"][]);
                GlobalVariables.atten_c[j] = Conversions.ToShort(recordset2[]["atten_c"][]);
                GlobalVariables.hcrop[j] = Conversions.ToSingle(recordset2[]["hcrop"][]);
                GlobalVariables.hcrop_c[j] = Conversions.ToShort(recordset2[]["hcrop_c"][]);
                GlobalVariables.rsurf[j] = Conversions.ToSingle(recordset2[]["rsurf"][]);
                GlobalVariables.rsurf_c[j] = Conversions.ToShort(recordset2[]["rsurf_c"][]);
                GlobalVariables.waten[1] = Conversions.ToSingle(recordset2[]["waten"][]);
                GlobalVariables.ri50[j] = Conversions.ToSingle(recordset2[]["ri50"][]);
                GlobalVariables.ri50_c[j] = Conversions.ToShort(recordset2[]["ri50_c"][]);
                GlobalVariables.vpd50[j] = Conversions.ToSingle(recordset2[]["vpd50"][]);
                GlobalVariables.vpd50_c[j] = Conversions.ToShort(recordset2[]["vpd50_c"][]);
                if (GlobalVariables.ncrop[j] == 2)
                {
                    GlobalVariables.idstart2[j] = Conversions.ToShort(recordset2[]["idstart2"][]);
                    GlobalVariables.idstart2_c[j] = Conversions.ToShort(recordset2[]["idstart2_c"][]);
                    GlobalVariables.idmax2[j] = Conversions.ToShort(recordset2[]["idmax2"][]);
                    GlobalVariables.idmax2_c[j] = Conversions.ToShort(recordset2[]["idmax2_c"][]);
                    GlobalVariables.iharv2[j] = Conversions.ToShort(recordset2[]["iharv2"][]);
                    GlobalVariables.iharv2_c[j] = Conversions.ToShort(recordset2[]["iharv2_c"][]);
                    GlobalVariables.zdatemin2[j] = Conversions.ToShort(recordset2[]["zdatemin2"][]);
                    GlobalVariables.zdatemin2_c[j] = Conversions.ToShort(recordset2[]["zdatemin2_c"][]);
                }
                recordset2.MoveNext();
            }
        }

        public static void ReadIBcond(ref int id, ref CfrmMain frmMain)
        {
            Recordset recordset = new RecordsetClass();
            Recordset recordset2 = recordset;
            recordset2.Open("select * from [IB conditions]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                bool flag = !recordset2.EOF;
                if (flag)
                {
                    if (!Operators.ConditionalCompareObjectEqual((int) id, recordset2[]["R_ID"][], false))
                    {
                        recordset2.MoveNext();
                        continue;
                    }
                    GlobalVariables.bgrad = Conversions.ToSingle(recordset2[]["bgrad"][]);
                    GlobalVariables.bgrad_c = Conversions.ToShort(recordset2[]["bgrad_c"][]);
                    GlobalVariables.concin = Conversions.ToSingle(recordset2[]["concin"][]);
                    GlobalVariables.concin_c = Conversions.ToShort(recordset2[]["concin_c"][]);
                    GlobalVariables.Area = Conversions.ToSingle(recordset2[]["Area"][]);
                    GlobalVariables.area_c = Conversions.ToShort(recordset2[]["area_c"][]);
                    GlobalVariables.gwflux = Conversions.ToSingle(recordset2[]["gwflux"][]);
                    GlobalVariables.gwflux_c = Conversions.ToShort(recordset2[]["gwflux_c"][]);
                    GlobalVariables.boten = Conversions.ToSingle(recordset2[]["boten"][]);
                    GlobalVariables.boten_c = Conversions.ToShort(recordset2[]["boten_c"][]);
                    GlobalVariables.partinit = Conversions.ToSingle(recordset2[]["partinit"][]);
                    GlobalVariables.partinit_c = Conversions.ToShort(recordset2[]["partinit_c"][]);
                    GlobalVariables.cons_sta = Conversions.ToSingle(recordset2[]["cons_sta"][]);
                    GlobalVariables.cons_sta_c = Conversions.ToInteger(recordset2[]["cons_sta_c"][]);
                    GlobalVariables.i_ascale = Conversions.ToSingle(recordset2[]["i_ascale"][]);
                    GlobalVariables.i_ascale_c = Conversions.ToInteger(recordset2[]["i_ascale_c"][]);
                }
                recordset2 = null;
                recordset.Close();
                Recordset recordset3 = recordset;
                recordset3.Open("select * from [General]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                while (true)
                {
                    flag = !recordset3.EOF;
                    if (flag)
                    {
                        if (!Operators.ConditionalCompareObjectEqual((int) id, recordset3[]["R_ID"][], false))
                        {
                            recordset3.MoveNext();
                            continue;
                        }
                        GlobalVariables.Nlayer = Conversions.ToShort(recordset3[]["Nlayer"][]);
                        GlobalVariables.Nhorizon = Conversions.ToShort(recordset3[]["Nhorizon"][]);
                        GlobalVariables.profilnamn = Conversions.ToString(recordset3[]["profilnamn"][]);
                        GlobalVariables.location = Conversions.ToString(recordset3[]["location"][]);
                        GlobalVariables.landusage = Conversions.ToString(recordset3[]["landusage"][]);
                        GlobalVariables.classify = Conversions.ToString(recordset3[]["classify"][]);
                    }
                    recordset3 = null;
                    recordset.Close();
                    GlobalVariables.profiledepth = 0f;
                    GlobalVariables.TotalLayers = 0;
                    j = 0;
                    S = "R_ID = " + Conversion.Str((int) id);
                    ADODC projectDatabase = frmMain.ProjectDatabase;
                    projectDatabase.RecordSource = "SELECT * FROM [Properties] WHERE " + S + " ORDER BY horiz_no";
                    projectDatabase.Refresh();
                    while (true)
                    {
                        flag = Operators.ConditionalCompareObjectEqual(projectDatabase.Recordset[]["R_ID"][], (int) id, false);
                        if (flag)
                        {
                            j = (short) (j + 1);
                            if (j <= projectDatabase.Recordset.RecordCount)
                            {
                                GlobalVariables.designat[j] = Conversions.ToString(projectDatabase.Recordset[]["designat"][]);
                                GlobalVariables.N_Layer[j] = Conversions.ToShort(projectDatabase.Recordset[]["Nlayer"][]);
                                GlobalVariables.TotalLayers = (short) (GlobalVariables.TotalLayers + GlobalVariables.N_Layer[j]);
                                GlobalVariables.Hthick[j] = Conversions.ToSingle(projectDatabase.Recordset[]["thick"][]);
                                GlobalVariables.thickness[j] = projectDatabase.Recordset[]["thick"][];
                                GlobalVariables.profiledepth += GlobalVariables.Hthick[j];
                                GlobalVariables.sand[j] = Conversions.ToSingle(projectDatabase.Recordset[]["sand"][]);
                                GlobalVariables.silt[j] = Conversions.ToSingle(projectDatabase.Recordset[]["silt"][]);
                                GlobalVariables.clay[j] = Conversions.ToSingle(projectDatabase.Recordset[]["clay"][]);
                                GlobalVariables.structur[j] = Conversions.ToString(projectDatabase.Recordset[]["structur"][]);
                                GlobalVariables.bulk[j] = Conversions.ToSingle(projectDatabase.Recordset[]["bulk"][]);
                                GlobalVariables.orgc[j] = Conversions.ToSingle(projectDatabase.Recordset[]["orgc"][]);
                                GlobalVariables.Texture[j] = Conversions.ToString(projectDatabase.Recordset[]["Texture"][]);
                                GlobalVariables.pH[j] = Conversions.ToSingle(projectDatabase.Recordset[]["pH"][]);
                                GlobalVariables.stone[j] = Information.IsDBNull(projectDatabase.Recordset[]["macro1"][]) ? 0f : Conversions.ToSingle(projectDatabase.Recordset[]["macro1"][]);
                                projectDatabase.Recordset.MoveNext();
                                continue;
                            }
                        }
                        projectDatabase = null;
                        j = 0;
                        S = "R_ID = " + Conversion.Str((int) id);
                        ADODC adodc2 = frmMain.ProjectDatabase;
                        adodc2.RecordSource = "SELECT * FROM [Soil profile] WHERE " + S + " ORDER BY Layer_no";
                        adodc2.Refresh();
                        while (true)
                        {
                            flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(adodc2.Recordset[]["R_ID"][], (int) id, false), (j + 1) <= adodc2.Recordset.RecordCount));
                            if (!flag)
                            {
                                adodc2 = null;
                                j = 0;
                                S = "R_ID = " + Conversion.Str((int) id);
                                Recordset recordset4 = recordset;
                                j = 0;
                                recordset4.Open("SELECT * FROM [IB conditions()] WHERE " + S + " ORDER BY Layer_no", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockUnspecified, -1);
                                while (true)
                                {
                                    flag = !recordset.EOF;
                                    if (!flag)
                                    {
                                        recordset4 = null;
                                        return;
                                    }
                                    j = (short) (j + 1);
                                    GlobalVariables.tempini[j] = Conversions.ToSingle(recordset4[]["tempini"][]);
                                    GlobalVariables.tempini_c[j] = Conversions.ToShort(recordset4[]["tempini_c"][]);
                                    GlobalVariables.thetaini[j] = Conversions.ToSingle(recordset4[]["thetaini"][]);
                                    GlobalVariables.thetaini_c[j] = Conversions.ToShort(recordset4[]["thetaini_c"][]);
                                    GlobalVariables.solinit[j] = Conversions.ToSingle(recordset4[]["solinit"][]);
                                    GlobalVariables.solinit_c[j] = Conversions.ToShort(recordset4[]["solinit_c"][]);
                                    recordset4.MoveNext();
                                }
                            }
                            j = (short) (j + 1);
                            GlobalVariables.Zthick[j] = Conversions.ToSingle(adodc2.Recordset[]["Z"][]);
                            adodc2.Recordset.MoveNext();
                        }
                    }
                }
            }
        }

        public static void ReadIrrigation(ref int id, ref CfrmMain frmMain)
        {
            j = 0;
            S = "R_ID = " + Conversion.Str((int) id);
            Recordset recordset = new RecordsetClass();
            Recordset rs = new RecordsetClass();
            Recordset recordset3 = recordset;
            recordset3.Open("SELECT * FROM [Irrigation] where R_ID=" + Conversions.ToString((int) id), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                short num2;
                short num11;
                bool flag2 = !recordset.EOF;
                if (!flag2)
                {
                    MiscFUncs.RedimIrrigationArrays(ref GlobalVariables.IrrYears);
                    recordset3 = null;
                    recordset.Close();
                    short num = 1;
                    Recordset recordset4 = recordset;
                    recordset4.Open("SELECT * FROM [Irrigation()] WHERE " + S + " ORDER BY IRRIG_no", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    if (GlobalVariables.b_irrsame)
                    {
                        short num8 = (short) ((frmMain.frmSetup.dtEndDate.Value.Year - frmMain.frmSetup.dtStartDate.Value.Year) + 1);
                        num2 = 1;
                        while (true)
                        {
                            num11 = num8;
                            if (num2 > num11)
                            {
                                short num9 = (short) Math.Round((double) GlobalVariables.nirr[1]);
                                j = 1;
                                while (j <= num9)
                                {
                                    short num10 = GlobalVariables.IrrYears;
                                    num2 = 1;
                                    while (true)
                                    {
                                        num11 = num10;
                                        if (num2 > num11)
                                        {
                                            recordset4.MoveNext();
                                            j = (short) (j + 1);
                                            break;
                                        }
                                        GlobalVariables.irrig_no[j, num2] = j;
                                        GlobalVariables.i_rrday[j, num2] = Conversions.ToSingle(recordset4[]["irrday"][]);
                                        GlobalVariables.irrday_c[j] = Conversions.ToShort(recordset4[]["irrday_c"][]);
                                        GlobalVariables.amir[j, num2] = Conversions.ToSingle(recordset4[]["amir"][]);
                                        GlobalVariables.amir_c[j] = Conversions.ToShort(recordset4[]["amir_c"][]);
                                        GlobalVariables.irrstart[j, num2] = Conversions.ToSingle(recordset4[]["irrstart"][]);
                                        GlobalVariables.irrstart_c[j] = Conversions.ToShort(recordset4[]["irrstart_c"][]);
                                        GlobalVariables.irrend[j, num2] = Conversions.ToSingle(recordset4[]["irrend"][]);
                                        GlobalVariables.irrend_c[j] = Conversions.ToShort(recordset4[]["irrend_c"][]);
                                        GlobalVariables.z_fint[j, num2] = Conversions.ToSingle(recordset4[]["zfint"][]);
                                        GlobalVariables.zfint_c[j] = Conversions.ToShort(recordset4[]["zfint_c"][]);
                                        GlobalVariables.c_onci[j, num2] = Conversions.ToSingle(recordset4[]["conci"][]);
                                        GlobalVariables.conci_c[j] = Conversions.ToShort(recordset4[]["conci_c"][]);
                                        num2 = (short) (num2 + 1);
                                    }
                                }
                                break;
                            }
                            GlobalVariables.Groups[1, num2] = num2;
                            num2 = (short) (num2 + 1);
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            flag2 = !recordset4.EOF;
                            if (!flag2)
                            {
                                break;
                            }
                            int index = Conversions.ToInteger(recordset4[]["IRRYEAR"][]);
                            short y = (short) index;
                            if (!IsInGroup(ref y))
                            {
                                string[] array = Strings.Split(Strings.Trim(Conversions.ToString(recordset4[]["irrgroup"][])), " ", -1, CompareMethod.Binary);
                                short num7 = (short) Information.UBound(array, 1);
                                num2 = 0;
                                while (true)
                                {
                                    num11 = num7;
                                    if (num2 > num11)
                                    {
                                        num = (short) (num + 1);
                                        break;
                                    }
                                    GlobalVariables.Groups[num, num2 + 1] = Conversions.ToShort(array[num2]);
                                    num2 = (short) (num2 + 1);
                                }
                            }
                            if (GlobalVariables.nirr[index] > 0f)
                            {
                                GlobalVariables.irrig_no[Conversions.ToInteger(recordset4[]["irrig_no"][]), Conversions.ToInteger(recordset4[]["irryear"][])] = Conversions.ToShort(recordset4[]["irrig_no"][]);
                                GlobalVariables.i_rrday[Conversions.ToInteger(recordset4[]["irrig_no"][]), Conversions.ToInteger(recordset4[]["irryear"][])] = Conversions.ToSingle(recordset4[]["irrday"][]);
                                GlobalVariables.irrday_c[Conversions.ToInteger(recordset4[]["irrig_no"][])] = Conversions.ToShort(recordset4[]["irrday_c"][]);
                                GlobalVariables.amir[Conversions.ToInteger(recordset4[]["irrig_no"][]), Conversions.ToInteger(recordset4[]["irryear"][])] = Conversions.ToSingle(recordset4[]["amir"][]);
                                GlobalVariables.amir_c[Conversions.ToInteger(recordset4[]["irrig_no"][])] = Conversions.ToShort(recordset4[]["amir_c"][]);
                                GlobalVariables.irrstart[Conversions.ToInteger(recordset4[]["irrig_no"][]), Conversions.ToInteger(recordset4[]["irryear"][])] = Conversions.ToSingle(recordset4[]["irrstart"][]);
                                GlobalVariables.irrstart_c[Conversions.ToInteger(recordset4[]["irrig_no"][])] = Conversions.ToShort(recordset4[]["irrstart_c"][]);
                                GlobalVariables.irrend[Conversions.ToInteger(recordset4[]["irrig_no"][]), Conversions.ToInteger(recordset4[]["irryear"][])] = Conversions.ToSingle(recordset4[]["irrend"][]);
                                GlobalVariables.irrend_c[Conversions.ToInteger(recordset4[]["irrig_no"][])] = Conversions.ToShort(recordset4[]["irrend_c"][]);
                                GlobalVariables.z_fint[Conversions.ToInteger(recordset4[]["irrig_no"][]), Conversions.ToInteger(recordset4[]["irryear"][])] = Conversions.ToSingle(recordset4[]["zfint"][]);
                                GlobalVariables.zfint_c[Conversions.ToInteger(recordset4[]["irrig_no"][])] = Conversions.ToShort(recordset4[]["zfint_c"][]);
                                GlobalVariables.c_onci[Conversions.ToInteger(recordset4[]["irrig_no"][]), Conversions.ToInteger(recordset4[]["irryear"][])] = Conversions.ToSingle(recordset4[]["conci"][]);
                                GlobalVariables.conci_c[Conversions.ToInteger(recordset4[]["irrig_no"][])] = Conversions.ToShort(recordset4[]["conci_c"][]);
                            }
                            recordset4.MoveNext();
                        }
                    }
                    recordset4 = null;
                    return;
                }
                GlobalVariables.IrrYears = Conversions.ToShort(recordset3[]["IRRYEARS"][]);
                short irrYears = GlobalVariables.IrrYears;
                num2 = 1;
                while (true)
                {
                    num11 = irrYears;
                    if (num2 > num11)
                    {
                        GlobalVariables.critdef = Conversions.ToSingle(recordset3[]["critdef"][]);
                        GlobalVariables.critdef_c = Conversions.ToShort(recordset3[]["critdef_c"][]);
                        GlobalVariables.b_irrsame = Conversions.ToBoolean(recordset3[]["irrsame"][]);
                        recordset3.MoveNext();
                        break;
                    }
                    if (!Conversions.ToBoolean(Operators.NotObject(recordset3[]["irrsame"][])))
                    {
                        GlobalVariables.nirr[num2] = Conversions.ToSingle(recordset3[]["nirr"][]);
                    }
                    else
                    {
                        rs.Open("select * from [Irrigation()] where R_ID=" + Conversions.ToString((int) id) + " And irryear=" + Conversions.ToString((int) num2), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        bool flag = RecordCount(ref rs) > 0;
                        if (flag)
                        {
                            GlobalVariables.nirr[num2] = !Operators.ConditionalCompareObjectGreater(rs[]["irrig_no"][], 0, false) ? 0f : ((float) RecordCount(ref rs));
                        }
                        rs.Close();
                    }
                    GlobalVariables.nirr_c[num2] = Conversions.ToShort(recordset3[]["nirr_c"][]);
                    num2 = (short) (num2 + 1);
                }
            }
        }

        public static void ReadOptions(ref int id, ref CfrmMain frmMain)
        {
            Recordset recordset = new RecordsetClass();
            Recordset recordset2 = recordset;
            recordset2.Open("select * from Options where R_id=" + Conversions.ToString((int) id), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            GlobalVariables.sw_averagex = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["averagex"][]);
            GlobalVariables.sw_averaget = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["averaget"][]);
            GlobalVariables.sw_averageg = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["averageg"][]);
            GlobalVariables.sw_averaged = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["averaged"][]);
            GlobalVariables.sw_outforn = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["outforn"][]);
            GlobalVariables.sw_instate = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["instate"][]);
            GlobalVariables.sw_outstate = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["outstate"][]);
            GlobalVariables.sw_drivpg = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["drivpg"][]);
            GlobalVariables.sw_toxswa = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["lisallv"][]);
            GlobalVariables.sw_chapar = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["Chapar"][]);
            GlobalVariables.sw_addsim = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["addsim"][]);
            GlobalVariables.sw_validpg = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["validpg"][]);
            GlobalVariables.sw_solute = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["solute"][]);
            GlobalVariables.sw_rainfall = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["Rainfall"][]);
            GlobalVariables.sw_landuse = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["nitrate"][]);
            if (GlobalVariables.sw_landuse == MACROConstants.Switch.NoMetabolite)
            {
                GlobalVariables.sw_landuse = MACROConstants.Switch.BareSoil;
            }
            GlobalVariables.sw_irrigate = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["irrigate"][]);
            GlobalVariables.sw_crop = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["crop"][]);
            GlobalVariables.sw_tiledrain = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["tiledrain"][]);
            GlobalVariables.sw_boundary = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["boundary"][]);
            GlobalVariables.sw_initial = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["initial"][]);
            GlobalVariables.sw_evaporate = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["evaporate"][]);
            GlobalVariables.sw_driving = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["driving"][]);
            GlobalVariables.sw_metabolite = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["metabolit"][]);
            GlobalVariables.sw_colloid = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["colloid"][]);
            GlobalVariables.sw_immobile = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["immobile"][]);
            GlobalVariables.sw_massunits = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["massunits"][]);
            GlobalVariables.sw_hysteres = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["hysteres"][]);
            GlobalVariables.sw_hydraulic = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["Hydraulic"][]);
            GlobalVariables.sw_management = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["Managemen"][]);
            GlobalVariables.sw_kinetic = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["Kinetic"][]);
            GlobalVariables.sw_upstream = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["upstream"][]);
            GlobalVariables.sw_degkin = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["degkin"][]);
            GlobalVariables.sw_tempini = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["tempini"][]);
            GlobalVariables.sw_vartension = (MACROConstants.Switch) Conversions.ToInteger(recordset2[]["varten"][]);
            GlobalVariables.sw_specout = Information.IsDBNull(recordset2[]["specout"][]) ? MACROConstants.Switch.NoMetabolite : ((MACROConstants.Switch) Conversions.ToInteger(recordset2[]["specout"][]));
            GlobalVariables.sw_crust = Information.IsDBNull(recordset2[]["crust"][]) ? MACROConstants.Switch.NoMetabolite : ((MACROConstants.Switch) Conversions.ToInteger(recordset2[]["crust"][]));
            recordset2 = null;
            recordset.Close();
        }

        public static void ReadOutput(ref int id, ref CfrmMain frmMain)
        {
            short index = 0;
            short num4 = 0;
            short num5 = 0;
            short num6 = 0;
            j = 0;
            S = "R_ID = " + Conversion.Str((int) id);
            Recordset recordset = new RecordsetClass();
            Recordset recordset3 = recordset;
            recordset3.Open("SELECT * FROM [Output] WHERE " + S, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                bool flag = !recordset.EOF;
                if (!flag)
                {
                    recordset3 = null;
                    recordset.Close();
                    index = 0;
                    num4 = 0;
                    num5 = 0;
                    Recordset rs = new RecordsetClass();
                    Recordset recordset4 = recordset;
                    recordset4.Open("SELECT * FROM [Output()] WHERE " + S, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    while (true)
                    {
                        short num7;
                        flag = !recordset.EOF;
                        if (!flag)
                        {
                            recordset.MoveFirst();
                            GlobalVariables.LayOutputs = new object[num7 + 1, (GlobalVariables.N_NUMERICAL_LAYERS + 4) + 1];
                            num7 = 1;
                            while (true)
                            {
                                flag = !recordset.EOF;
                                if (!flag)
                                {
                                    recordset4 = null;
                                    recordset.Close();
                                    return;
                                }
                                GlobalVariables.LayOutputs[num7, 1] = recordset4[]["Var"][];
                                GlobalVariables.LayOutputs[num7, 2] = recordset4[]["Group"][];
                                GlobalVariables.LayOutputs[num7, 3] = recordset4[]["Selected"][];
                                GlobalVariables.LayOutputs[num7, 4] = recordset4[]["Enabled"][];
                                if (Operators.ConditionalCompareObjectEqual(recordset4[]["Selected"][], MACROConstants.OutputState.Selected, false))
                                {
                                    rs.Open(Operators.ConcatenateObject("select * from OutputLayers where [Output()ID]=", recordset4[]["Output()ID"][]), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                    int num8 = RecordCount(ref rs);
                                    int num2 = 1;
                                    while (true)
                                    {
                                        int num9 = num8;
                                        if (num2 > num9)
                                        {
                                            rs.Close();
                                            break;
                                        }
                                        flag = !Information.IsDBNull(rs[]["Selected"][]);
                                        GlobalVariables.LayOutputs[num7, Conversions.ToInteger(Operators.AddObject(rs[]["LayerNO"][], 4))] = !flag ? 0 : rs[]["Selected"][];
                                        rs.MoveNext();
                                        num2++;
                                    }
                                }
                                string str3 = Conversions.ToString(recordset4[]["group"][]);
                                if (str3 == "X")
                                {
                                    index = (short) (index + 1);
                                    GlobalVariables.outpx2[index].var = Conversions.ToString(recordset4[]["var"][]);
                                    GlobalVariables.outpx2[index].l1 = Conversions.ToShort(recordset4[]["first_layer"][]);
                                    GlobalVariables.outpx2[index].l2 = Conversions.ToShort(recordset4[]["last_layer"][]);
                                    GlobalVariables.outpx2[index].sl = Conversions.ToShort(recordset4[]["selected"][]);
                                    if (!Information.IsDBNull(recordset4[]["Enabled"][]))
                                    {
                                        GlobalVariables.outpx2[index].enabled = Conversions.ToShort(recordset4[]["enabled"][]);
                                    }
                                }
                                else if (str3 == "G")
                                {
                                    num4 = (short) (num4 + 1);
                                    GlobalVariables.outpg2[num4].var = Conversions.ToString(recordset4[]["var"][]);
                                    GlobalVariables.outpg2[num4].l1 = Conversions.ToShort(recordset4[]["first_layer"][]);
                                    GlobalVariables.outpg2[num4].l2 = Conversions.ToShort(recordset4[]["last_layer"][]);
                                    GlobalVariables.outpg2[num4].sl = Conversions.ToShort(recordset4[]["selected"][]);
                                    if (!Information.IsDBNull(recordset4[]["Enabled"][]))
                                    {
                                        GlobalVariables.outpg2[num4].enabled = Conversions.ToShort(recordset4[]["enabled"][]);
                                    }
                                }
                                else if (str3 == "D")
                                {
                                    num5 = (short) (num5 + 1);
                                    GlobalVariables.outpd2[num5].var = Conversions.ToString(recordset4[]["var"][]);
                                    GlobalVariables.outpd2[num5].l1 = Conversions.ToShort(recordset4[]["first_layer"][]);
                                    GlobalVariables.outpd2[num5].l2 = Conversions.ToShort(recordset4[]["last_layer"][]);
                                    GlobalVariables.outpd2[num5].sl = Conversions.ToShort(recordset4[]["selected"][]);
                                    if (!Information.IsDBNull(recordset4[]["Enabled"][]))
                                    {
                                        GlobalVariables.outpd2[num5].enabled = Conversions.ToShort(recordset4[]["enabled"][]);
                                    }
                                }
                                num7 = (short) (num7 + 1);
                                recordset4.MoveNext();
                            }
                        }
                        num7 = (short) (num7 + 1);
                        recordset.MoveNext();
                    }
                }
                string str2 = Conversions.ToString(recordset3[]["group"][]);
                if (str2 == "X")
                {
                    index = (short) (index + 1);
                    GlobalVariables.outpx1[index].var = Conversions.ToString(recordset3[]["var"][]);
                    GlobalVariables.outpx1[index].sl = Conversions.ToShort(recordset3[]["selected"][]);
                    if (!Information.IsDBNull(recordset3[]["Enabled"][]))
                    {
                        GlobalVariables.outpx1[index].enabled = Conversions.ToShort(recordset3[]["enabled"][]);
                    }
                }
                else if (str2 == "T")
                {
                    num4 = (short) (num4 + 1);
                    GlobalVariables.outpt1[num4].var = Conversions.ToString(recordset3[]["var"][]);
                    GlobalVariables.outpt1[num4].sl = Conversions.ToShort(recordset3[]["selected"][]);
                    if (!Information.IsDBNull(recordset3[]["Enabled"][]))
                    {
                        GlobalVariables.outpt1[num4].enabled = Conversions.ToShort(recordset3[]["enabled"][]);
                    }
                }
                else if (str2 == "G")
                {
                    num5 = (short) (num5 + 1);
                    GlobalVariables.outpg1[num5].var = Conversions.ToString(recordset3[]["var"][]);
                    GlobalVariables.outpg1[num5].sl = Conversions.ToShort(recordset3[]["selected"][]);
                    if (!Information.IsDBNull(recordset3[]["Enabled"][]))
                    {
                        GlobalVariables.outpg1[num5].enabled = Conversions.ToShort(recordset3[]["enabled"][]);
                    }
                }
                else if (str2 == "D")
                {
                    num6 = (short) (num6 + 1);
                    GlobalVariables.outpd1[num6].var = Conversions.ToString(recordset3[]["var"][]);
                    GlobalVariables.outpd1[num6].sl = Conversions.ToShort(recordset3[]["selected"][]);
                    if (!Information.IsDBNull(recordset3[]["Enabled"][]))
                    {
                        GlobalVariables.outpd1[num6].enabled = Conversions.ToShort(recordset3[]["enabled"][]);
                    }
                }
                GlobalVariables.NUM_OUTPD1 = num6;
                GlobalVariables.NUM_OUTPX1 = index;
                GlobalVariables.NUM_OUTPT1 = num4;
                GlobalVariables.NUM_OUTPG1 = num5;
                recordset3.MoveNext();
            }
        }

        public static void ReadPhysicalParms(ref int id, ref CfrmMain frmMain)
        {
            // Invalid method body.
        }

        public static void ReadRun_ID(ref int id, ref CfrmMain frmMain)
        {
            Recordset recordset = new RecordsetClass();
            Recordset recordset2 = recordset;
            recordset2.Open("select * from Run_ID where r_id=" + Conversions.ToString((int) id), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            GlobalVariables.ProjectIDno = Conversions.ToInteger(recordset2[]["id_no"][]);
            FileSystem.ChDir(MyProject.Application.Info.DirectoryPath);
            GlobalVariables.Run_name = Conversions.ToString(recordset2[]["Run_name"][]);
            GlobalVariables.Modified_date = Conversions.ToString(recordset2[]["Modified_date"][]);
            GlobalVariables.Run_dscrpt = Conversions.ToString(recordset2[]["Run_description"][]);
            GlobalVariables.Rainfall_file = Conversions.ToString(recordset2[]["Rainfall_file"][]);
            GlobalVariables.RainfallPeriod = Conversions.ToString(recordset2[]["Period_file1"][]);
            GlobalVariables.Met_file = Conversions.ToString(recordset2[]["Met_file"][]);
            GlobalVariables.MetPeriod = Conversions.ToString(recordset2[]["Period_file8"][]);
            GlobalVariables.DateFile = Information.IsDBNull(recordset2[]["period_file10"][]) ? "\"" : Conversions.ToString(recordset2[]["period_file10"][]);
            GlobalVariables.TensionFile = Conversions.ToString(recordset2[]["TensionFile"][]);
            GlobalVariables.Driving_file = Conversions.ToString(recordset2[]["Driving_file"][]);
            GlobalVariables.DrivingPeriod = Conversions.ToString(recordset2[]["PeriodMetab"][]);
            GlobalVariables.TotPhys_layer = Conversions.ToShort(recordset2[]["Numlayers"][]);
            GlobalVariables.N_NUMERICAL_LAYERS = Conversions.ToShort(recordset2[]["MaxNumLayers"][]);
            try
            {
                frmMain.frmSetup.Drive1.Drive = Strings.Left(Conversions.ToString(recordset2[]["Outputfiledir"][]), 2);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                frmMain.frmSetup.Drive1.Drive = "C:";
                ProjectData.ClearProjectError();
            }
            object[] arguments = new object[] { recordset2[]["outputfiledir"] };
            if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(Interaction.CreateObject("Scripting.FileSystemObject", ""), null, "folderexists", arguments, null, null, null))))
            {
                MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Output file path ", recordset2[]["outputfiledir"][]), " not found")), 0x40, "");
            }
            else
            {
                frmMain.frmSetup.Dir1.Path = Conversions.ToString(recordset2[]["outputfiledir"][]);
            }
            recordset2 = null;
            recordset.Close();
        }

        public static void ReadSetup(ref int id, ref CfrmMain frmMain)
        {
            Recordset recordset = new RecordsetClass();
            Recordset recordset2 = recordset;
            recordset2.Open("select * from [Set-up] where R_ID=" + Conversions.ToString((int) id), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            frmMain.frmSetup.dtStartDate.Value = Conversions.ToDate(recordset2[]["startdat"][]);
            frmMain.frmSetup.dtEndDate.Value = Conversions.ToDate(recordset2[]["enddat"][]);
            if (!GlobalVariables.b_Executing)
            {
                GlobalVariables.Groups = new short[((frmMain.frmSetup.dtEndDate.Value.Year - frmMain.frmSetup.dtStartDate.Value.Year) + 1) + 1, ((frmMain.frmSetup.dtEndDate.Value.Year - frmMain.frmSetup.dtStartDate.Value.Year) + 1) + 1];
            }
            GlobalVariables.outintd = Conversions.ToShort(recordset2[]["outintd"][]);
            GlobalVariables.outintm = Conversions.ToShort(recordset2[]["outintm"][]);
            GlobalVariables.b_DefaultNaming = Conversions.ToBoolean(recordset2[]["Defaultname"][]);
            if (!GlobalVariables.b_DefaultNaming)
            {
                GlobalVariables.MACROOutputFile = Conversions.ToString(recordset2[]["OutputFileName"][]);
            }
            recordset2 = null;
            recordset.Close();
        }

        public static void ReadSite(ref int id, ref CfrmMain frmMain)
        {
            Recordset rs = new RecordsetClass();
            Recordset recordset2 = rs;
            recordset2.Open("select * from Site", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                if (!recordset2.EOF)
                {
                    if (!Operators.ConditionalCompareObjectEqual((int) id, recordset2[]["R_ID"][], false))
                    {
                        recordset2.MoveNext();
                        continue;
                    }
                    GlobalVariables.annamp = Conversions.ToSingle(recordset2[]["annamp"][]);
                    GlobalVariables.annamp_c = Conversions.ToShort(recordset2[]["annamp_c"][]);
                    GlobalVariables.anntav = Conversions.ToSingle(recordset2[]["anntav"][]);
                    GlobalVariables.anntav_c = Conversions.ToShort(recordset2[]["anntav_c"][]);
                    GlobalVariables.rainco = Conversions.ToSingle(recordset2[]["rainco"][]);
                    GlobalVariables.rainco_c = Conversions.ToShort(recordset2[]["rainco_c"][]);
                    GlobalVariables.snowco = Conversions.ToSingle(recordset2[]["snowco"][]);
                    GlobalVariables.snowco_c = Conversions.ToShort(recordset2[]["snowco_c"][]);
                    GlobalVariables.snowmf = Conversions.ToSingle(recordset2[]["snowmf"][]);
                    GlobalVariables.snowmf_c = Conversions.ToShort(recordset2[]["snowmf_c"][]);
                    GlobalVariables.dwrl = Conversions.ToSingle(recordset2[]["dwrl"][]);
                    GlobalVariables.dwrl_c = Conversions.ToShort(recordset2[]["dwrl_c"][]);
                    GlobalVariables.albedo = Conversions.ToSingle(recordset2[]["albedo"][]);
                    GlobalVariables.albedo_c = Conversions.ToShort(recordset2[]["albedo_c"][]);
                    GlobalVariables.zmet = Conversions.ToSingle(recordset2[]["zmet"][]);
                    GlobalVariables.zmet_c = Conversions.ToShort(recordset2[]["zmet_c"][]);
                    GlobalVariables.rgwflow = Conversions.ToSingle(recordset2[]["rgwflow"][]);
                    GlobalVariables.rgwflow_c = Conversions.ToShort(recordset2[]["rgwflow_c"][]);
                    GlobalVariables.rinten = Conversions.ToSingle(recordset2[]["rinten"][]);
                    GlobalVariables.rinten_c = Conversions.ToShort(recordset2[]["rinten_c"][]);
                    GlobalVariables.layerd = Conversions.ToSingle(recordset2[]["layerd"][]);
                    GlobalVariables.layerd_c = Conversions.ToShort(recordset2[]["layerd_c"][]);
                    GlobalVariables.draindep = Conversions.ToSingle(recordset2[]["draindep"][]);
                    GlobalVariables.draindep_c = Conversions.ToShort(recordset2[]["draindep_c"][]);
                    GlobalVariables.s_pace = Conversions.ToSingle(recordset2[]["Space"][]);
                    GlobalVariables.space_c = Conversions.ToShort(recordset2[]["space_c"][]);
                    GlobalVariables.phi = Conversions.ToSingle(recordset2[]["phi"][]);
                    GlobalVariables.phi_c = Conversions.ToShort(recordset2[]["phi_c"][]);
                    GlobalVariables.gamma_ch = Conversions.ToSingle(recordset2[]["gammatill"][]);
                    GlobalVariables.macp_ch = Conversions.ToSingle(recordset2[]["macptill"][]);
                    GlobalVariables.macd_ch = Conversions.ToSingle(recordset2[]["MACDTILL"][]);
                    GlobalVariables.halfrain = Conversions.ToSingle(recordset2[]["halfrain"][]);
                    GlobalVariables.gamma_ch_c = Conversions.ToInteger(recordset2[]["gamma_ch_c"][]);
                    GlobalVariables.macp_ch_c = Conversions.ToInteger(recordset2[]["macp_ch_c"][]);
                    GlobalVariables.macd_ch_c = Conversions.ToInteger(recordset2[]["MACD_CH_c"][]);
                    GlobalVariables.halfrain_c = Conversions.ToInteger(recordset2[]["halfrain_c"][]);
                    GlobalVariables.halfcrus = Conversions.ToSingle(recordset2[]["halfcrus"][]);
                    GlobalVariables.halfcrus_c = Conversions.ToInteger(recordset2[]["halfcrus_c"][]);
                    GlobalVariables.cruststa = Conversions.ToSingle(recordset2[]["cruststa"][]);
                    GlobalVariables.cruststa_c = Conversions.ToInteger(recordset2[]["cruststa_c"][]);
                    GlobalVariables.ksmtille = Conversions.ToSingle(recordset2[]["ksmtille"][]);
                    GlobalVariables.ksmtille_c = Conversions.ToInteger(recordset2[]["ksmtille_c"][]);
                    GlobalVariables.dummy = Conversions.ToSingle(recordset2[]["dummy"][]);
                    GlobalVariables.dummy_c = Conversions.ToInteger(recordset2[]["dummy_c"][]);
                    GlobalVariables.NTILL = Conversions.ToShort(recordset2[]["NTILL"][]);
                }
                rs.Close();
                Recordset recordset3 = rs;
                recordset3.Open("SELECT * FROM [Site()] WHERE r_id=" + Conversions.ToString((int) id), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                if (!(recordset3.EOF | recordset3.BOF))
                {
                    recordset3.MoveFirst();
                    short num3 = (short) (((short) RecordCount(ref rs)) - 1);
                    short index = 0;
                    while (true)
                    {
                        short num4 = num3;
                        if (index > num4)
                        {
                            recordset3 = null;
                            rs.Close();
                            recordset2 = null;
                            break;
                        }
                        GlobalVariables.till_day[index] = Conversions.ToShort(recordset3[]["till_day"][]);
                        GlobalVariables.till_day_c[index] = Conversions.ToInteger(recordset3[]["till_day_c"][]);
                        GlobalVariables.till_int[index] = Conversions.ToSingle(recordset3[]["till_int"][]);
                        GlobalVariables.till_int_c[index] = Conversions.ToInteger(recordset3[]["till_int_c"][]);
                        GlobalVariables.till_lay[index] = Conversions.ToShort(recordset3[]["till_lay"][]);
                        GlobalVariables.till_lay_c[index] = Conversions.ToInteger(recordset3[]["till_lay_c"][]);
                        GlobalVariables.t_ascale[index] = Conversions.ToSingle(recordset3[]["t_ascale"][]);
                        GlobalVariables.t_ascale_c[index] = Conversions.ToInteger(recordset3[]["t_ascale_c"][]);
                        GlobalVariables.tillcons[index] = Conversions.ToSingle(recordset3[]["tillcons"][]);
                        GlobalVariables.tillcons_c[index] = Conversions.ToInteger(recordset3[]["tillcons_c"][]);
                        recordset3.MoveNext();
                        index = (short) (index + 1);
                    }
                }
                return;
            }
        }

        public static void ReadSoilProfile(ref int id, ref CfrmMain frmMain)
        {
            j = 0;
            S = "R_ID = " + Conversion.Str((int) id);
            Recordset recordset = new RecordsetClass();
            Recordset recordset2 = recordset;
            recordset2.Open("SELECT * FROM [Soil profile] WHERE " + S + " ORDER BY Layer_no", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            while (true)
            {
                if (recordset.EOF)
                {
                    recordset2 = null;
                    recordset.Close();
                    return;
                }
                j = (short) (j + 1);
                GlobalVariables.Z[j] = Conversions.ToSingle(recordset2[]["Z"][]);
                GlobalVariables.z_c[j] = Conversions.ToShort(recordset2[]["z_c"][]);
                recordset2.MoveNext();
            }
        }

        public static void ReadSolute(ref int id, ref CfrmMain frmMain)
        {
            // Invalid method body.
        }

        public static int RecordCount(ref Recordset rs)
        {
            int num2;
            try
            {
                if (!(!rs.EOF & !rs.BOF))
                {
                    num2 = 0;
                }
                else
                {
                    rs.MoveFirst();
                    while (true)
                    {
                        int num;
                        if (rs.EOF)
                        {
                            rs.MoveFirst();
                            num2 = num;
                            break;
                        }
                        num++;
                        rs.MoveNext();
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                MessageBox.Show(ex.Message, "Error in function 'RecordCount'");
                ProjectData.ClearProjectError();
            }
            return num2;
        }

        public static void SaveToDatabase(ref string ProjectDescription, ref string RunDescription, ref string p_name, ref int idnr, ref bool SaveAs, ref CfrmMain frmMain)
        {
            int num3;
            Recordset rs = new RecordsetClass();
            Recordset recordset = new RecordsetClass();
            frmProgress progress = new frmProgress(ref frmMain) {
                Progress = { 
                    Min = 0f,
                    Max = 14f
                },
                Text = "Saving..."
            };
            progress.Show();
            progress.Refresh();
            string str = Conversions.ToString(DateAndTime.Today);
            string str6 = Conversions.ToString(DateAndTime.Year(Conversions.ToDate(str)));
            string expression = Conversions.ToString(DateAndTime.Month(Conversions.ToDate(str)));
            string str2 = Conversions.ToString(DateAndTime.Day(Conversions.ToDate(str)));
            if (Strings.Len(expression) < 2)
            {
                expression = "0" + expression;
            }
            if (Strings.Len(str2) < 2)
            {
                str2 = "0" + str2;
            }
            str = "";
            string[] strArray = new string[] { str6, "-", expression, "-", str2 };
            str = string.Concat(strArray);
            progress.lblAction.Text = "Saving project information...";
            progress.Progress.Value = 1f;
            progress.Refresh();
            Recordset recordset3 = new RecordsetClass();
            Recordset recordset4 = recordset3;
            if (!GlobalVariables.New_Project)
            {
                num3 = idnr;
            }
            else
            {
                SaveAs = true;
                recordset4.Open("select * from [Projects]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset4.AddNew(Missing.Value, Missing.Value);
                recordset4[]["project_name"][] = p_name;
                recordset4[]["Proj_description"][] = ProjectDescription + " ";
                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                recordset4.MoveFirst();
                recordset4.MoveLast();
                num3 = Conversions.ToInteger(recordset4[]["id_no"][]);
                GlobalVariables.ProjectIDno = num3;
                recordset4.Close();
            }
            if (!SaveAs)
            {
                recordset4.Open("select * from [Run_ID] where ID_No=" + Conversions.ToString(GlobalVariables.ProjectIDno) + " and R_ID=" + Conversions.ToString((int) idnr), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
            }
            else
            {
                recordset4.Open("select * from [Projects] where id_no=" + Conversions.ToString(num3), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset4[]["Proj_description"][] = ProjectDescription + " ";
                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                recordset4.Close();
                recordset4.Open("select * from [Run_ID]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                recordset4.AddNew(Missing.Value, Missing.Value);
            }
            recordset4[]["id_no"][] = GlobalVariables.ProjectIDno;
            recordset4[]["Run_name"][] = GlobalVariables.Run_name;
            recordset4[]["Modified_date"][] = str;
            recordset4[]["Run_description"][] = RunDescription;
            recordset4[]["Rainfall_file"][] = GlobalVariables.Rainfall_file;
            recordset4[]["Period_file1"][] = GlobalVariables.RainfallPeriod;
            recordset4[]["Met_file"][] = GlobalVariables.Met_file;
            recordset4[]["Period_file8"][] = GlobalVariables.MetPeriod;
            recordset4[]["period_file10"][] = GlobalVariables.DateFile;
            recordset4[]["Driving_file"][] = GlobalVariables.Driving_file;
            recordset4[]["PeriodMetab"][] = GlobalVariables.DrivingPeriod;
            recordset4[]["Outputfiledir"][] = frmMain.frmSetup.Dir1.Path;
            recordset4[]["MaxNumLayers"][] = GlobalVariables.N_NUMERICAL_LAYERS;
            recordset4[]["TensionFile"][] = GlobalVariables.TensionFile;
            short nhorizon = GlobalVariables.Nhorizon;
            short index = 1;
            while (true)
            {
                short num9;
                short num36 = nhorizon;
                if (index > num36)
                {
                    recordset4[]["NumLayers"][] = num9;
                    recordset4[]["NHori"][] = GlobalVariables.Nhorizon;
                    if (GlobalVariables.sw_management == MACROConstants.Switch.BareSoil)
                    {
                        recordset4[]["NTill"][] = GlobalVariables.NTILL;
                    }
                    else
                    {
                        recordset4[]["Ntill"][] = 0;
                    }
                    recordset4.UpdateBatch(AffectEnum.adAffectAll);
                    int num8 = !SaveAs ? idnr : Conversions.ToInteger(recordset4[]["R_ID"][]);
                    recordset4.Close();
                    string str4 = "where R_ID =" + Conversions.ToString(num8);
                    progress.lblAction.Text = "Saving simulation set-up...";
                    progress.Progress.Value = 2f;
                    progress.Refresh();
                    if (!SaveAs)
                    {
                        recordset4.Open("select * from [Set-up] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    }
                    else
                    {
                        recordset4.Open("select * from [Set-up]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        recordset4.AddNew(Missing.Value, Missing.Value);
                    }
                    recordset4[]["R_ID"][] = num8;
                    GlobalVariables.RunIDno = num8;
                    recordset4[]["startdat"][] = frmMain.frmSetup.dtStartDate.Value;
                    recordset4[]["enddat"][] = frmMain.frmSetup.dtEndDate.Value;
                    recordset4[]["outintd"][] = GlobalVariables.outintd;
                    recordset4[]["outintm"][] = GlobalVariables.outintm;
                    recordset4[]["defaultname"][] = GlobalVariables.b_DefaultNaming;
                    if (GlobalVariables.MACROOutputFile != "")
                    {
                        recordset4[]["OutputFileName"][] = GlobalVariables.MACROOutputFile;
                    }
                    recordset4.UpdateBatch(AffectEnum.adAffectAll);
                    recordset4.Close();
                    progress.lblAction.Text = "Saving general settings...";
                    progress.Progress.Value = 3f;
                    progress.Refresh();
                    if (!SaveAs)
                    {
                        recordset4.Open("select * from [General] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    }
                    else
                    {
                        recordset4.Open("select * from [General]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        recordset4.AddNew(Missing.Value, Missing.Value);
                    }
                    recordset4[]["R_ID"][] = num8;
                    recordset4[]["Nlayer"][] = GlobalVariables.Nlayer;
                    recordset4[]["Nhorizon"][] = GlobalVariables.Nhorizon;
                    recordset4[]["profilnamn"][] = GlobalVariables.profilnamn;
                    recordset4[]["location"][] = GlobalVariables.location;
                    recordset4[]["landusage"][] = GlobalVariables.landusage;
                    recordset4[]["classify"][] = GlobalVariables.classify;
                    recordset4.UpdateBatch(AffectEnum.adAffectAll);
                    recordset4.Close();
                    progress.lblAction.Text = "Saving initial and boundary conditions...";
                    progress.Progress.Value = 4f;
                    progress.Refresh();
                    if (!SaveAs)
                    {
                        recordset4.Open("select * from [IB conditions] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    }
                    else
                    {
                        recordset4.Open("select * from [IB conditions]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        recordset4.AddNew(Missing.Value, Missing.Value);
                    }
                    recordset4[]["R_ID"][] = num8;
                    recordset4[]["bgrad"][] = GlobalVariables.bgrad;
                    recordset4[]["bgrad_c"][] = GlobalVariables.bgrad_c;
                    recordset4[]["concin"][] = GlobalVariables.concin;
                    recordset4[]["concin_c"][] = GlobalVariables.concin_c;
                    recordset4[]["Area"][] = GlobalVariables.Area;
                    recordset4[]["area_c"][] = GlobalVariables.area_c;
                    recordset4[]["gwflux"][] = GlobalVariables.gwflux;
                    recordset4[]["gwflux_c"][] = GlobalVariables.gwflux_c;
                    recordset4[]["boten"][] = GlobalVariables.boten;
                    recordset4[]["boten_c"][] = GlobalVariables.boten_c;
                    recordset4[]["partinit"][] = GlobalVariables.partinit;
                    recordset4[]["partinit_c"][] = GlobalVariables.partinit_c;
                    recordset4[]["cons_sta"][] = GlobalVariables.cons_sta;
                    recordset4[]["cons_sta_c"][] = GlobalVariables.cons_sta_c;
                    recordset4[]["i_ascale"][] = GlobalVariables.i_ascale;
                    recordset4[]["i_ascale_c"][] = GlobalVariables.i_ascale_c;
                    recordset4.UpdateBatch(AffectEnum.adAffectAll);
                    recordset4.Close();
                    if (SaveAs)
                    {
                        recordset4.Open("select * from [IB conditions()]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                    }
                    else
                    {
                        recordset4.Open("select * from [IB conditions()] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                        recordset4.MoveFirst();
                    }
                    int num7 = RecordCount(ref recordset3);
                    if ((num7 > GlobalVariables.Nlayer) & !SaveAs)
                    {
                        recordset4.MoveLast();
                        short num12 = (short) (num7 - GlobalVariables.Nlayer);
                        index = 1;
                        while (true)
                        {
                            num36 = num12;
                            if (index > num36)
                            {
                                break;
                            }
                            recordset4.Delete(AffectEnum.adAffectCurrent);
                            recordset4.MoveLast();
                            index = (short) (index + 1);
                        }
                    }
                    recordset4.MoveFirst();
                    short nlayer = GlobalVariables.Nlayer;
                    index = 1;
                    while (true)
                    {
                        num36 = nlayer;
                        if (index > num36)
                        {
                            recordset3.Close();
                            progress.lblAction.Text = "Saving soil properties...";
                            progress.Progress.Value = 5f;
                            progress.Refresh();
                            if (SaveAs)
                            {
                                recordset4.Open("select * from [Properties]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            }
                            else
                            {
                                recordset4.Open("select * from [Properties] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                            }
                            num7 = RecordCount(ref recordset3);
                            if ((num7 > GlobalVariables.Nhorizon) & !SaveAs)
                            {
                                recordset4.MoveLast();
                                short num14 = (short) (num7 - GlobalVariables.Nhorizon);
                                index = 1;
                                while (true)
                                {
                                    num36 = num14;
                                    if (index > num36)
                                    {
                                        break;
                                    }
                                    recordset4.Delete(AffectEnum.adAffectCurrent);
                                    recordset4.MoveLast();
                                    index = (short) (index + 1);
                                }
                            }
                            recordset4.MoveFirst();
                            num7 = RecordCount(ref recordset3);
                            short num15 = GlobalVariables.Nhorizon;
                            index = 1;
                            while (true)
                            {
                                num36 = num15;
                                if (index > num36)
                                {
                                    recordset4.Close();
                                    progress.lblAction.Text = "Saving soil profile information...";
                                    progress.Progress.Value = 6f;
                                    progress.Refresh();
                                    if (SaveAs)
                                    {
                                        recordset4.Open("select * from [Physical parameters]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                    }
                                    else
                                    {
                                        recordset4.Open("select * from [Physical parameters] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                    }
                                    num7 = RecordCount(ref recordset3);
                                    if ((num7 > GlobalVariables.Nhorizon) & !SaveAs)
                                    {
                                        recordset4.MoveLast();
                                        short num16 = (short) (num7 - GlobalVariables.Nhorizon);
                                        index = 1;
                                        while (true)
                                        {
                                            num36 = num16;
                                            if (index > num36)
                                            {
                                                break;
                                            }
                                            recordset4.Delete(AffectEnum.adAffectCurrent);
                                            recordset4.MoveLast();
                                            index = (short) (index + 1);
                                        }
                                    }
                                    recordset4.MoveFirst();
                                    num7 = RecordCount(ref recordset3);
                                    short num17 = GlobalVariables.Nhorizon;
                                    index = 1;
                                    while (true)
                                    {
                                        num36 = num17;
                                        if (index > num36)
                                        {
                                            recordset4.Close();
                                            if (SaveAs)
                                            {
                                                recordset4.Open("select * from [soil profile]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                            }
                                            else
                                            {
                                                recordset4.Open("select * from [soil profile] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                            }
                                            num7 = RecordCount(ref recordset3);
                                            if ((num7 > GlobalVariables.Nlayer) & !SaveAs)
                                            {
                                                recordset4.MoveLast();
                                                short num18 = (short) (num7 - GlobalVariables.Nlayer);
                                                index = 1;
                                                while (true)
                                                {
                                                    num36 = num18;
                                                    if (index > num36)
                                                    {
                                                        break;
                                                    }
                                                    recordset4.Delete(AffectEnum.adAffectCurrent);
                                                    recordset4.MoveLast();
                                                    index = (short) (index + 1);
                                                }
                                            }
                                            recordset4.MoveFirst();
                                            num7 = RecordCount(ref recordset3);
                                            short num19 = GlobalVariables.Nlayer;
                                            index = 1;
                                            while (true)
                                            {
                                                num36 = num19;
                                                if (index > num36)
                                                {
                                                    recordset4.Close();
                                                    progress.lblAction.Text = "Saving crop properties...";
                                                    progress.Progress.Value = 7f;
                                                    progress.Refresh();
                                                    if (SaveAs)
                                                    {
                                                        recordset4.Open("select * from [Crop]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                    }
                                                    else
                                                    {
                                                        recordset4.Open("select * from [Crop] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                    }
                                                    num7 = RecordCount(ref recordset3);
                                                    if ((num7 > GlobalVariables.NumOfYears) & !SaveAs)
                                                    {
                                                        recordset4.MoveLast();
                                                        short num20 = (short) (num7 - GlobalVariables.NumOfYears);
                                                        index = 1;
                                                        while (true)
                                                        {
                                                            num36 = num20;
                                                            if (index > num36)
                                                            {
                                                                break;
                                                            }
                                                            recordset4.Delete(AffectEnum.adAffectCurrent);
                                                            recordset4.MoveLast();
                                                            index = (short) (index + 1);
                                                        }
                                                    }
                                                    recordset4.MoveFirst();
                                                    num7 = RecordCount(ref recordset3);
                                                    short numOfYears = GlobalVariables.NumOfYears;
                                                    index = 1;
                                                    while (true)
                                                    {
                                                        num36 = numOfYears;
                                                        if (index > num36)
                                                        {
                                                            short num2;
                                                            string str5;
                                                            short num10;
                                                            bool flag3;
                                                            recordset4.Close();
                                                            progress.lblAction.Text = "Saving irrigation settings...";
                                                            progress.Progress.Value = 8f;
                                                            progress.Refresh();
                                                            if (!SaveAs)
                                                            {
                                                                recordset4.Open("select * from [Irrigation] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                            }
                                                            else
                                                            {
                                                                recordset4.Open("select * from [Irrigation]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                recordset4.AddNew(Missing.Value, Missing.Value);
                                                            }
                                                            recordset4[]["irrsame"][] = GlobalVariables.b_irrsame;
                                                            recordset4[]["IrrYears"][] = GlobalVariables.IrrYears;
                                                            recordset4[]["R_ID"][] = num8;
                                                            recordset4[]["nirr"][] = GlobalVariables.nirr[1];
                                                            recordset4[]["nirr_c"][] = GlobalVariables.nirr_c[1];
                                                            recordset4[]["critdef"][] = GlobalVariables.critdef;
                                                            recordset4[]["critdef_c"][] = GlobalVariables.critdef_c;
                                                            recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                            recordset4.Close();
                                                            if (SaveAs)
                                                            {
                                                                recordset4.Open("select * from [Irrigation()]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                            }
                                                            else
                                                            {
                                                                recordset4.Open("select * from [Irrigation()] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                            }
                                                            if ((RecordCount(ref recordset3) > 0) & !SaveAs)
                                                            {
                                                                recordset4.MoveFirst();
                                                                while (true)
                                                                {
                                                                    if (recordset4.EOF)
                                                                    {
                                                                        break;
                                                                    }
                                                                    recordset4.Delete(AffectEnum.adAffectCurrent);
                                                                    recordset4.MoveNext();
                                                                }
                                                            }
                                                            recordset3.Close();
                                                            if (SaveAs)
                                                            {
                                                                recordset4.Open("select * from [Irrigation()]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                            }
                                                            else
                                                            {
                                                                recordset4.Open("select * from [Irrigation()] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                            }
                                                            if (GlobalVariables.b_irrsame)
                                                            {
                                                                num10 = 1;
                                                                str5 = "";
                                                                short num26 = (short) Information.UBound(GlobalVariables.Groups, 2);
                                                                num2 = 1;
                                                                while (true)
                                                                {
                                                                    num36 = num26;
                                                                    if (num2 > num36)
                                                                    {
                                                                        if (GlobalVariables.nirr[num10] == 0f)
                                                                        {
                                                                            recordset4.AddNew(Missing.Value, Missing.Value);
                                                                            recordset4[]["R_ID"][] = num8;
                                                                            recordset4[]["irrgroup"][] = Strings.Trim(str5);
                                                                            recordset4[]["irryear"][] = num10;
                                                                            recordset4[]["irrig_no"][] = 0;
                                                                            recordset4[]["irrday"][] = 0;
                                                                            recordset4[]["irrday_c"][] = 0;
                                                                            recordset4[]["amir"][] = 0;
                                                                            recordset4[]["amir_c"][] = 0;
                                                                            recordset4[]["irrstart"][] = 0;
                                                                            recordset4[]["irrstart_c"][] = 0;
                                                                            recordset4[]["irrend"][] = 0;
                                                                            recordset4[]["irrend_c"][] = 0;
                                                                            recordset4[]["zfint"][] = 0;
                                                                            recordset4[]["zfint_c"][] = 0;
                                                                            recordset4[]["conci"][] = 0;
                                                                            recordset4[]["conci_c"][] = 0;
                                                                            recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                        }
                                                                        else
                                                                        {
                                                                            short num27 = (short) Math.Round((double) GlobalVariables.nirr[num10]);
                                                                            index = 1;
                                                                            while (true)
                                                                            {
                                                                                num36 = num27;
                                                                                if (index > num36)
                                                                                {
                                                                                    break;
                                                                                }
                                                                                if (SaveAs | (index > recordset4.RecordCount))
                                                                                {
                                                                                    recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                }
                                                                                recordset4[]["R_ID"][] = num8;
                                                                                recordset4[]["irrgroup"][] = str5;
                                                                                recordset4[]["irryear"][] = num10;
                                                                                recordset4[]["irrig_no"][] = GlobalVariables.irrig_no[index, num10];
                                                                                recordset4[]["irrday"][] = GlobalVariables.i_rrday[index, num10];
                                                                                recordset4[]["irrday_c"][] = GlobalVariables.irrday_c[index];
                                                                                recordset4[]["amir"][] = GlobalVariables.amir[index, num10];
                                                                                recordset4[]["amir_c"][] = GlobalVariables.amir_c[index];
                                                                                recordset4[]["irrstart"][] = GlobalVariables.irrstart[index, num10];
                                                                                recordset4[]["irrstart_c"][] = GlobalVariables.irrstart_c[index];
                                                                                recordset4[]["irrend"][] = GlobalVariables.irrend[index, num10];
                                                                                recordset4[]["irrend_c"][] = GlobalVariables.irrend_c[index];
                                                                                recordset4[]["zfint"][] = GlobalVariables.z_fint[index, num10];
                                                                                recordset4[]["zfint_c"][] = GlobalVariables.zfint_c[index];
                                                                                recordset4[]["conci"][] = GlobalVariables.c_onci[index, num10];
                                                                                recordset4[]["conci_c"][] = GlobalVariables.conci_c[index];
                                                                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                flag3 = !SaveAs;
                                                                                if (flag3)
                                                                                {
                                                                                    recordset4.MoveNext();
                                                                                }
                                                                                index = (short) (index + 1);
                                                                            }
                                                                        }
                                                                        break;
                                                                    }
                                                                    flag3 = GlobalVariables.Groups[1, num2] > 0;
                                                                    if (flag3)
                                                                    {
                                                                        str5 = str5 + Conversions.ToString((int) GlobalVariables.Groups[1, num2]) + " ";
                                                                    }
                                                                    num2 = (short) (num2 + 1);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                short irrYears = GlobalVariables.IrrYears;
                                                                num10 = 1;
                                                                while (num10 <= irrYears)
                                                                {
                                                                    str5 = "";
                                                                    short num23 = (short) Information.UBound(GlobalVariables.Groups, 1);
                                                                    short grp = 1;
                                                                    while (true)
                                                                    {
                                                                        num36 = num23;
                                                                        if ((grp <= num36) && !MiscFUncs.IsInGroupNo(ref grp, ref num10))
                                                                        {
                                                                            grp = (short) (grp + 1);
                                                                            continue;
                                                                        }
                                                                        if (grp != (Information.UBound(GlobalVariables.Groups, 1) + 1))
                                                                        {
                                                                            short num24 = (short) Information.UBound(GlobalVariables.Groups, 2);
                                                                            index = 1;
                                                                            while (true)
                                                                            {
                                                                                num36 = num24;
                                                                                if (index > num36)
                                                                                {
                                                                                    if (GlobalVariables.nirr[num10] == 0f)
                                                                                    {
                                                                                        recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                        recordset4[]["R_ID"][] = num8;
                                                                                        recordset4[]["irrgroup"][] = Strings.Trim(str5);
                                                                                        recordset4[]["irryear"][] = num10;
                                                                                        recordset4[]["irrig_no"][] = 0;
                                                                                        recordset4[]["irrday"][] = 0;
                                                                                        recordset4[]["irrday_c"][] = 0;
                                                                                        recordset4[]["amir"][] = 0;
                                                                                        recordset4[]["amir_c"][] = 0;
                                                                                        recordset4[]["irrstart"][] = 0;
                                                                                        recordset4[]["irrstart_c"][] = 0;
                                                                                        recordset4[]["irrend"][] = 0;
                                                                                        recordset4[]["irrend_c"][] = 0;
                                                                                        recordset4[]["zfint"][] = 0;
                                                                                        recordset4[]["zfint_c"][] = 0;
                                                                                        recordset4[]["conci"][] = 0;
                                                                                        recordset4[]["conci_c"][] = 0;
                                                                                        recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                    }
                                                                                    short num25 = (short) Math.Round((double) GlobalVariables.nirr[num10]);
                                                                                    index = 1;
                                                                                    while (true)
                                                                                    {
                                                                                        num36 = num25;
                                                                                        if (index > num36)
                                                                                        {
                                                                                            break;
                                                                                        }
                                                                                        recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                        recordset4[]["R_ID"][] = num8;
                                                                                        recordset4[]["irrgroup"][] = Strings.Trim(str5);
                                                                                        recordset4[]["irryear"][] = num10;
                                                                                        recordset4[]["irrig_no"][] = GlobalVariables.irrig_no[index, num10];
                                                                                        recordset4[]["irrday"][] = GlobalVariables.i_rrday[index, num10];
                                                                                        recordset4[]["irrday_c"][] = GlobalVariables.irrday_c[index];
                                                                                        recordset4[]["amir"][] = GlobalVariables.amir[index, num10];
                                                                                        recordset4[]["amir_c"][] = GlobalVariables.amir_c[index];
                                                                                        recordset4[]["irrstart"][] = GlobalVariables.irrstart[index, num10];
                                                                                        recordset4[]["irrstart_c"][] = GlobalVariables.irrstart_c[index];
                                                                                        recordset4[]["irrend"][] = GlobalVariables.irrend[index, num10];
                                                                                        recordset4[]["irrend_c"][] = GlobalVariables.irrend_c[index];
                                                                                        recordset4[]["zfint"][] = GlobalVariables.z_fint[index, num10];
                                                                                        recordset4[]["zfint_c"][] = GlobalVariables.zfint_c[index];
                                                                                        recordset4[]["conci"][] = GlobalVariables.c_onci[index, num10];
                                                                                        recordset4[]["conci_c"][] = GlobalVariables.conci_c[index];
                                                                                        recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                        flag3 = !SaveAs;
                                                                                        if (flag3)
                                                                                        {
                                                                                            recordset4.MoveNext();
                                                                                        }
                                                                                        index = (short) (index + 1);
                                                                                    }
                                                                                    break;
                                                                                }
                                                                                flag3 = GlobalVariables.Groups[grp, index] > 0;
                                                                                if (flag3)
                                                                                {
                                                                                    str5 = str5 + Conversions.ToString((int) GlobalVariables.Groups[grp, index]) + " ";
                                                                                }
                                                                                index = (short) (index + 1);
                                                                            }
                                                                        }
                                                                        num10 = (short) (num10 + 1);
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            recordset4.Close();
                                                            progress.lblAction.Text = "Saving options...";
                                                            progress.Progress.Value = 9f;
                                                            progress.Refresh();
                                                            if (!SaveAs)
                                                            {
                                                                recordset4.Open("select * from [Options] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                            }
                                                            else
                                                            {
                                                                recordset4.Open("select * from [Options]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                recordset4.AddNew(Missing.Value, Missing.Value);
                                                            }
                                                            recordset4[]["R_ID"][] = num8;
                                                            recordset4[]["averagex"][] = GlobalVariables.sw_averagex;
                                                            recordset4[]["averaget"][] = GlobalVariables.sw_averaget;
                                                            recordset4[]["averageg"][] = GlobalVariables.sw_averageg;
                                                            recordset4[]["averaged"][] = GlobalVariables.sw_averaged;
                                                            recordset4[]["outforn"][] = GlobalVariables.sw_outforn;
                                                            recordset4[]["instate"][] = GlobalVariables.sw_instate;
                                                            recordset4[]["outstate"][] = GlobalVariables.sw_outstate;
                                                            recordset4[]["drivpg"][] = GlobalVariables.sw_drivpg;
                                                            recordset4[]["lisallv"][] = GlobalVariables.sw_toxswa;
                                                            recordset4[]["Chapar"][] = GlobalVariables.sw_chapar;
                                                            recordset4[]["addsim"][] = GlobalVariables.sw_addsim;
                                                            recordset4[]["validpg"][] = GlobalVariables.sw_validpg;
                                                            recordset4[]["solute"][] = GlobalVariables.sw_solute;
                                                            recordset4[]["Rainfall"][] = GlobalVariables.sw_rainfall;
                                                            recordset4[]["nitrate"][] = GlobalVariables.sw_landuse;
                                                            recordset4[]["irrigate"][] = GlobalVariables.sw_irrigate;
                                                            recordset4[]["crop"][] = GlobalVariables.sw_crop;
                                                            recordset4[]["tiledrain"][] = GlobalVariables.sw_tiledrain;
                                                            recordset4[]["boundary"][] = GlobalVariables.sw_boundary;
                                                            recordset4[]["initial"][] = GlobalVariables.sw_initial;
                                                            recordset4[]["evaporate"][] = GlobalVariables.sw_evaporate;
                                                            recordset4[]["driving"][] = GlobalVariables.sw_driving;
                                                            recordset4[]["metabolit"][] = GlobalVariables.sw_metabolite;
                                                            recordset4[]["colloid"][] = GlobalVariables.sw_colloid;
                                                            recordset4[]["immobile"][] = GlobalVariables.sw_immobile;
                                                            recordset4[]["massunits"][] = GlobalVariables.sw_massunits;
                                                            recordset4[]["hysteres"][] = GlobalVariables.sw_hysteres;
                                                            recordset4[]["Hydraulic"][] = GlobalVariables.sw_hydraulic;
                                                            recordset4[]["Managemen"][] = GlobalVariables.sw_management;
                                                            recordset4[]["Kinetic"][] = GlobalVariables.sw_kinetic;
                                                            recordset4[]["crust"][] = GlobalVariables.sw_crust;
                                                            recordset4[]["upstream"][] = GlobalVariables.sw_upstream;
                                                            recordset4[]["specout"][] = GlobalVariables.sw_specout;
                                                            recordset4[]["degkin"][] = GlobalVariables.sw_degkin;
                                                            recordset4[]["tempini"][] = GlobalVariables.sw_tempini;
                                                            recordset4[]["varten"][] = GlobalVariables.sw_vartension;
                                                            recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                            recordset4.Close();
                                                            progress.lblAction.Text = "Saving output settings...";
                                                            progress.Progress.Value = 10f;
                                                            progress.Refresh();
                                                            if (SaveAs)
                                                            {
                                                                recordset4.Open("select * from [Output]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                            }
                                                            else
                                                            {
                                                                recordset4.Open("select * from [Output] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                            }
                                                            index = 1;
                                                            while (true)
                                                            {
                                                                if (SaveAs)
                                                                {
                                                                    recordset4.AddNew(Missing.Value, Missing.Value);
                                                                }
                                                                recordset4[]["R_ID"][] = num8;
                                                                recordset4[]["var"][] = GlobalVariables.outpx1[index].var;
                                                                recordset4[]["selected"][] = GlobalVariables.outpx1[index].sl;
                                                                recordset4[]["enabled"][] = GlobalVariables.outpx1[index].enabled;
                                                                recordset4[]["group"][] = "X";
                                                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                flag3 = !SaveAs;
                                                                if (flag3)
                                                                {
                                                                    recordset4.MoveNext();
                                                                }
                                                                index = (short) (index + 1);
                                                                num36 = 7;
                                                                if (index > num36)
                                                                {
                                                                    index = 1;
                                                                    while (true)
                                                                    {
                                                                        if (SaveAs)
                                                                        {
                                                                            recordset4.AddNew(Missing.Value, Missing.Value);
                                                                        }
                                                                        recordset4[]["R_ID"][] = num8;
                                                                        if (Strings.Len(GlobalVariables.outpt1[index].var) == 0)
                                                                        {
                                                                            GlobalVariables.outpt1[index].var = "WATEREQ";
                                                                        }
                                                                        recordset4[]["var"][] = GlobalVariables.outpt1[index].var;
                                                                        recordset4[]["selected"][] = GlobalVariables.outpt1[index].sl;
                                                                        recordset4[]["enabled"][] = GlobalVariables.outpt1[index].enabled;
                                                                        recordset4[]["group"][] = "T";
                                                                        recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                        flag3 = !SaveAs;
                                                                        if (flag3)
                                                                        {
                                                                            recordset4.MoveNext();
                                                                        }
                                                                        index = (short) (index + 1);
                                                                        num36 = 0x21;
                                                                        if (index > num36)
                                                                        {
                                                                            index = 1;
                                                                            while (true)
                                                                            {
                                                                                if (SaveAs)
                                                                                {
                                                                                    recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                }
                                                                                recordset4[]["R_ID"][] = num8;
                                                                                recordset4[]["var"][] = GlobalVariables.outpg1[index].var;
                                                                                recordset4[]["selected"][] = GlobalVariables.outpg1[index].sl;
                                                                                recordset4[]["enabled"][] = GlobalVariables.outpg1[index].enabled;
                                                                                recordset4[]["group"][] = "G";
                                                                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                flag3 = !SaveAs;
                                                                                if (flag3)
                                                                                {
                                                                                    recordset4.MoveNext();
                                                                                }
                                                                                index = (short) (index + 1);
                                                                                num36 = 9;
                                                                                if (index > num36)
                                                                                {
                                                                                    index = 1;
                                                                                    while (true)
                                                                                    {
                                                                                        if (SaveAs)
                                                                                        {
                                                                                            recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                        }
                                                                                        recordset4[]["R_ID"][] = num8;
                                                                                        recordset4[]["var"][] = GlobalVariables.outpd1[index].var;
                                                                                        recordset4[]["selected"][] = GlobalVariables.outpd1[index].sl;
                                                                                        recordset4[]["enabled"][] = GlobalVariables.outpd1[index].enabled;
                                                                                        recordset4[]["group"][] = "D";
                                                                                        recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                        flag3 = !SaveAs | (index == 0x20);
                                                                                        if (flag3)
                                                                                        {
                                                                                            recordset4.MoveNext();
                                                                                        }
                                                                                        index = (short) (index + 1);
                                                                                        num36 = 0x20;
                                                                                        if (index > num36)
                                                                                        {
                                                                                            recordset4.Close();
                                                                                            if (SaveAs)
                                                                                            {
                                                                                                recordset4.Open("select * from [Output()]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                recordset4.Open("select * from [Output()] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                            }
                                                                                            short num28 = (short) Information.UBound(GlobalVariables.LayOutputs, 1);
                                                                                            index = 1;
                                                                                            while (index <= num28)
                                                                                            {
                                                                                                if (SaveAs)
                                                                                                {
                                                                                                    recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                                }
                                                                                                recordset4[]["R_ID"][] = num8;
                                                                                                recordset4[]["var"][] = GlobalVariables.LayOutputs[index, 1];
                                                                                                recordset4[]["selected"][] = GlobalVariables.LayOutputs[index, 3];
                                                                                                recordset4[]["enabled"][] = GlobalVariables.LayOutputs[index, 4];
                                                                                                recordset4[]["group"][] = GlobalVariables.LayOutputs[index, 2];
                                                                                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                                if (Operators.ConditionalCompareObjectEqual(GlobalVariables.LayOutputs[index, 3], 1, false))
                                                                                                {
                                                                                                    rs.Open(Operators.ConcatenateObject("select * from OutputLayers where [Output()ID]=", recordset4[]["Output()ID"][]), frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                    if (RecordCount(ref rs) > 0)
                                                                                                    {
                                                                                                        while (true)
                                                                                                        {
                                                                                                            flag3 = !rs.EOF;
                                                                                                            if (!flag3)
                                                                                                            {
                                                                                                                break;
                                                                                                            }
                                                                                                            rs.Delete(AffectEnum.adAffectCurrent);
                                                                                                            rs.MoveNext();
                                                                                                        }
                                                                                                    }
                                                                                                    rs.Close();
                                                                                                    rs.Open("select * from OutputLayers", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                    short num29 = (short) (Information.UBound(GlobalVariables.LayOutputs, 2) - 4);
                                                                                                    num2 = 1;
                                                                                                    while (true)
                                                                                                    {
                                                                                                        num36 = num29;
                                                                                                        if (num2 > num36)
                                                                                                        {
                                                                                                            rs.Close();
                                                                                                            break;
                                                                                                        }
                                                                                                        rs.AddNew(Missing.Value, Missing.Value);
                                                                                                        rs[]["Output()ID"][] = recordset4[]["Output()ID"][];
                                                                                                        rs[]["LayerNO"][] = num2;
                                                                                                        rs[]["Selected"][] = GlobalVariables.LayOutputs[index, num2 + 4];
                                                                                                        rs.UpdateBatch(AffectEnum.adAffectAll);
                                                                                                        num2 = (short) (num2 + 1);
                                                                                                    }
                                                                                                }
                                                                                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                                flag3 = !SaveAs;
                                                                                                if (flag3)
                                                                                                {
                                                                                                    recordset4.MoveNext();
                                                                                                }
                                                                                                index = (short) (index + 1);
                                                                                            }
                                                                                            recordset4.Close();
                                                                                            progress.lblAction.Text = "Saving site specific information...";
                                                                                            progress.Progress.Value = 12f;
                                                                                            progress.Refresh();
                                                                                            if (SaveAs)
                                                                                            {
                                                                                                recordset4.Open("select * from [Site()]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                recordset4.Open("select * from [Site()] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                            }
                                                                                            num7 = RecordCount(ref recordset3);
                                                                                            if ((num7 > GlobalVariables.NTILL) & !SaveAs)
                                                                                            {
                                                                                                recordset4.MoveLast();
                                                                                                short num30 = (short) (num7 - GlobalVariables.NTILL);
                                                                                                index = 1;
                                                                                                while (true)
                                                                                                {
                                                                                                    num36 = num30;
                                                                                                    if (index > num36)
                                                                                                    {
                                                                                                        break;
                                                                                                    }
                                                                                                    recordset4.Delete(AffectEnum.adAffectCurrent);
                                                                                                    recordset4.MoveLast();
                                                                                                    index = (short) (index + 1);
                                                                                                }
                                                                                            }
                                                                                            bool flag = SaveAs;
                                                                                            if (RecordCount(ref recordset3) == 0)
                                                                                            {
                                                                                                SaveAs = true;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                recordset4.MoveFirst();
                                                                                            }
                                                                                            recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                            num7 = RecordCount(ref recordset3);
                                                                                            short num31 = (short) (GlobalVariables.NTILL - 1);
                                                                                            num2 = 0;
                                                                                            while (true)
                                                                                            {
                                                                                                num36 = num31;
                                                                                                if (num2 > num36)
                                                                                                {
                                                                                                    recordset4.Close();
                                                                                                    SaveAs = flag;
                                                                                                    if (!SaveAs)
                                                                                                    {
                                                                                                        recordset4.Open("select * from [Site] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        recordset4.Open("select * from [Site]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                        recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                                    }
                                                                                                    recordset4[]["R_ID"][] = num8;
                                                                                                    recordset4[]["annamp"][] = GlobalVariables.annamp;
                                                                                                    recordset4[]["annamp_c"][] = GlobalVariables.annamp_c;
                                                                                                    recordset4[]["anntav"][] = GlobalVariables.anntav;
                                                                                                    recordset4[]["anntav_c"][] = GlobalVariables.anntav_c;
                                                                                                    recordset4[]["rainco"][] = GlobalVariables.rainco;
                                                                                                    recordset4[]["rainco_c"][] = GlobalVariables.rainco_c;
                                                                                                    recordset4[]["snowco"][] = GlobalVariables.snowco;
                                                                                                    recordset4[]["snowco_c"][] = GlobalVariables.snowco_c;
                                                                                                    recordset4[]["snowmf"][] = GlobalVariables.snowmf;
                                                                                                    recordset4[]["snowmf_c"][] = GlobalVariables.snowmf_c;
                                                                                                    recordset4[]["dwrl"][] = GlobalVariables.dwrl;
                                                                                                    recordset4[]["dwrl_c"][] = GlobalVariables.dwrl_c;
                                                                                                    recordset4[]["albedo"][] = GlobalVariables.albedo;
                                                                                                    recordset4[]["albedo_c"][] = GlobalVariables.albedo_c;
                                                                                                    recordset4[]["zmet"][] = GlobalVariables.zmet;
                                                                                                    recordset4[]["zmet_c"][] = GlobalVariables.zmet_c;
                                                                                                    recordset4[]["rgwflow"][] = GlobalVariables.rgwflow;
                                                                                                    recordset4[]["rgwflow_c"][] = GlobalVariables.rgwflow_c;
                                                                                                    recordset4[]["rinten"][] = GlobalVariables.rinten;
                                                                                                    recordset4[]["rinten_c"][] = GlobalVariables.rinten_c;
                                                                                                    recordset4[]["layerd"][] = GlobalVariables.layerd;
                                                                                                    recordset4[]["layerd_c"][] = GlobalVariables.layerd_c;
                                                                                                    recordset4[]["draindep"][] = GlobalVariables.draindep;
                                                                                                    recordset4[]["draindep_c"][] = GlobalVariables.draindep_c;
                                                                                                    recordset4[]["Space"][] = GlobalVariables.s_pace;
                                                                                                    recordset4[]["space_c"][] = GlobalVariables.space_c;
                                                                                                    recordset4[]["phi"][] = GlobalVariables.phi;
                                                                                                    recordset4[]["phi_c"][] = GlobalVariables.phi_c;
                                                                                                    recordset4[]["gammatill"][] = GlobalVariables.gamma_ch;
                                                                                                    recordset4[]["macptill"][] = GlobalVariables.macp_ch;
                                                                                                    recordset4[]["macdtill"][] = GlobalVariables.macd_ch;
                                                                                                    recordset4[]["halfrain"][] = GlobalVariables.halfrain;
                                                                                                    recordset4[]["gamma_ch_c"][] = GlobalVariables.gamma_ch_c;
                                                                                                    recordset4[]["macp_ch_c"][] = GlobalVariables.macp_ch_c;
                                                                                                    recordset4[]["macd_ch_c"][] = GlobalVariables.macd_ch_c;
                                                                                                    recordset4[]["halfrain_c"][] = GlobalVariables.halfrain_c;
                                                                                                    recordset4[]["halfcrus"][] = GlobalVariables.halfcrus;
                                                                                                    recordset4[]["halfcrus_c"][] = GlobalVariables.halfcrus_c;
                                                                                                    recordset4[]["cruststa"][] = GlobalVariables.cruststa;
                                                                                                    recordset4[]["cruststa_c"][] = GlobalVariables.cruststa_c;
                                                                                                    recordset4[]["ksmtille"][] = GlobalVariables.ksmtille;
                                                                                                    recordset4[]["ksmtille_c"][] = GlobalVariables.ksmtille_c;
                                                                                                    recordset4[]["dummy"][] = GlobalVariables.dummy;
                                                                                                    recordset4[]["dummy_c"][] = GlobalVariables.dummy_c;
                                                                                                    recordset4[]["NTILL"][] = GlobalVariables.NTILL;
                                                                                                    recordset4[]["ksmseal"][] = GlobalVariables.ksmseal;
                                                                                                    recordset4[]["ksmseal_c"][] = GlobalVariables.ksmseal_c;
                                                                                                    recordset4[]["xmporseal"][] = GlobalVariables.xmporseal;
                                                                                                    recordset4[]["xmporseal_c"][] = GlobalVariables.xmporseal_c;
                                                                                                    recordset4[]["znseal"][] = GlobalVariables.znseal;
                                                                                                    recordset4[]["znseal_c"][] = GlobalVariables.znseal_c;
                                                                                                    recordset4[]["gammaseal"][] = GlobalVariables.gammaseal;
                                                                                                    recordset4[]["gammaseal_c"][] = GlobalVariables.gammaseal_c;
                                                                                                    recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                                    recordset4.Close();
                                                                                                    progress.lblAction.Text = "Saving solute information...";
                                                                                                    progress.Progress.Value = 13f;
                                                                                                    progress.Refresh();
                                                                                                    if (!SaveAs)
                                                                                                    {
                                                                                                        recordset4.Open("select * from [Solute] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        recordset4.Open("select * from [Solute]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                        recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                                    }
                                                                                                    recordset4[]["R_ID"][] = num8;
                                                                                                    recordset4[]["diff"][] = GlobalVariables.d_iff;
                                                                                                    recordset4[]["diff_c"][] = GlobalVariables.diff_c;
                                                                                                    recordset4[]["refilter"][] = GlobalVariables.Koc;
                                                                                                    recordset4[]["dv"][] = GlobalVariables.dv;
                                                                                                    recordset4[]["dv_c"][] = GlobalVariables.dv_c;
                                                                                                    recordset4[]["pmax"][] = GlobalVariables.pmax;
                                                                                                    recordset4[]["pmax_c"][] = GlobalVariables.pmax_c;
                                                                                                    recordset4[]["fstar"][] = GlobalVariables.fstar;
                                                                                                    recordset4[]["fstar_c"][] = GlobalVariables.fstar_c;
                                                                                                    recordset4[]["zmix"][] = GlobalVariables.zmix;
                                                                                                    recordset4[]["zmix_c"][] = GlobalVariables.zmix_c;
                                                                                                    recordset4[]["conc"][] = GlobalVariables.conc;
                                                                                                    recordset4[]["conc_c"][] = GlobalVariables.conc_c;
                                                                                                    recordset4[]["genkd"][] = GlobalVariables.genkd;
                                                                                                    recordset4[]["genkd_c"][] = GlobalVariables.genkd_c;
                                                                                                    recordset4[]["vref"][] = GlobalVariables.vref;
                                                                                                    recordset4[]["vref_c"][] = GlobalVariables.vref_c;
                                                                                                    recordset4[]["settle"][] = GlobalVariables.settle;
                                                                                                    recordset4[]["settle_c"][] = GlobalVariables.settle_c;
                                                                                                    recordset4[]["filtermi"][] = GlobalVariables.filtermi;
                                                                                                    recordset4[]["filtermi_c"][] = GlobalVariables.filtermi_c;
                                                                                                    recordset4[]["refilter"][] = GlobalVariables.refilter;
                                                                                                    recordset4[]["refilter_c"][] = GlobalVariables.refilter_c;
                                                                                                    recordset4[]["replen"][] = GlobalVariables.replen;
                                                                                                    recordset4[]["replen_c"][] = GlobalVariables.replen_c;
                                                                                                    recordset4[]["pf1"][] = GlobalVariables.pf1;
                                                                                                    recordset4[]["pf1_c"][] = GlobalVariables.pf1_c;
                                                                                                    recordset4[]["pf2"][] = GlobalVariables.pf2;
                                                                                                    recordset4[]["pf2_c"][] = GlobalVariables.pf2_c;
                                                                                                    recordset4[]["frack"][] = GlobalVariables.frack;
                                                                                                    recordset4[]["frack_c"][] = GlobalVariables.frack_c;
                                                                                                    recordset4[]["gravit"][] = GlobalVariables.gravit;
                                                                                                    recordset4[]["gravit_c"][] = GlobalVariables.gravit_c;
                                                                                                    recordset4[]["sorp_rate"][] = GlobalVariables.sorp_rate;
                                                                                                    recordset4[]["sorp_rate_c"][] = GlobalVariables.sorp_rate_c;
                                                                                                    recordset4[]["frac_eq"][] = GlobalVariables.frac_eq;
                                                                                                    recordset4[]["frac_eq_c"][] = GlobalVariables.frac_eq_c;
                                                                                                    recordset4[]["fracmac"][] = GlobalVariables.fracmac;
                                                                                                    recordset4[]["fracmac_c"][] = GlobalVariables.fracmac_c;
                                                                                                    recordset4[]["candeg"][] = GlobalVariables.candeg;
                                                                                                    recordset4[]["candeg_c"][] = GlobalVariables.candeg_c;
                                                                                                    recordset4[]["fext"][] = GlobalVariables.fext;
                                                                                                    recordset4[]["fext_c"][] = GlobalVariables.fext_c;
                                                                                                    recordset4[]["zkdpc"][] = GlobalVariables.zkdpc;
                                                                                                    recordset4[]["zkdpc_c"][] = GlobalVariables.zkdpc_c;
                                                                                                    recordset4[]["expb"][] = GlobalVariables.expb;
                                                                                                    recordset4[]["expb_c"][] = GlobalVariables.expb_c;
                                                                                                    recordset4[]["tresp"][] = GlobalVariables.tresp;
                                                                                                    recordset4[]["tresp_c"][] = GlobalVariables.tresp_c;
                                                                                                    recordset4[]["tref"][] = GlobalVariables.tref;
                                                                                                    recordset4[]["tref_c"][] = GlobalVariables.tref_c;
                                                                                                    recordset4[]["fconvert"][] = GlobalVariables.f_convert;
                                                                                                    recordset4[]["fconvert_c"][] = GlobalVariables.fconvert_c;
                                                                                                    recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                                    recordset4.Close();
                                                                                                    if (SaveAs)
                                                                                                    {
                                                                                                        recordset4.Open("select * from [Solute()]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        recordset4.Open("select * from [Solute()] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                    }
                                                                                                    num7 = RecordCount(ref recordset3);
                                                                                                    if ((num7 > GlobalVariables.Nhorizon) & !SaveAs)
                                                                                                    {
                                                                                                        recordset4.MoveLast();
                                                                                                        short num32 = (short) (num7 - GlobalVariables.Nhorizon);
                                                                                                        index = 1;
                                                                                                        while (true)
                                                                                                        {
                                                                                                            num36 = num32;
                                                                                                            if (index > num36)
                                                                                                            {
                                                                                                                break;
                                                                                                            }
                                                                                                            recordset4.Delete(AffectEnum.adAffectCurrent);
                                                                                                            recordset4.MoveLast();
                                                                                                            index = (short) (index + 1);
                                                                                                        }
                                                                                                    }
                                                                                                    recordset4.MoveFirst();
                                                                                                    num7 = RecordCount(ref recordset3);
                                                                                                    short num33 = GlobalVariables.Nhorizon;
                                                                                                    index = 1;
                                                                                                    while (true)
                                                                                                    {
                                                                                                        num36 = num33;
                                                                                                        if (index > num36)
                                                                                                        {
                                                                                                            recordset4.Close();
                                                                                                            if (SaveAs)
                                                                                                            {
                                                                                                                recordset4.Open("select * from [Chapar]", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                recordset4.Open("select * from [Chapar] " + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                                if (((short) RecordCount(ref recordset3)) > 0)
                                                                                                                {
                                                                                                                    recordset4.MoveFirst();
                                                                                                                    while (true)
                                                                                                                    {
                                                                                                                        flag3 = !recordset4.EOF & !recordset4.BOF;
                                                                                                                        if (!flag3)
                                                                                                                        {
                                                                                                                            break;
                                                                                                                        }
                                                                                                                        recordset4.Delete(AffectEnum.adAffectCurrent);
                                                                                                                        recordset4.MoveFirst();
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                            short num34 = (short) Information.UBound(GlobalVariables.Chapar, 1);
                                                                                                            index = 1;
                                                                                                            while (true)
                                                                                                            {
                                                                                                                num36 = num34;
                                                                                                                if (index > num36)
                                                                                                                {
                                                                                                                    recordset4.Close();
                                                                                                                    recordset4 = null;
                                                                                                                    progress.Close();
                                                                                                                    return;
                                                                                                                }
                                                                                                                recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                                                recordset4[]["ParameterName"][] = GlobalVariables.Chapar[index, 1];
                                                                                                                recordset4[]["Date"][] = GlobalVariables.Chapar[index, 2];
                                                                                                                recordset4[]["Value"][] = GlobalVariables.Chapar[index, 3];
                                                                                                                recordset4[]["R_ID"][] = num3;
                                                                                                                short num6 = (short) Strings.InStr(1, GlobalVariables.Chapar[index, 1], "_", CompareMethod.Binary);
                                                                                                                flag3 = num6 == 0;
                                                                                                                if (flag3)
                                                                                                                {
                                                                                                                    recordset4[]["Start"][] = 1;
                                                                                                                    recordset4[]["Length"][] = 1;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    str5 = Strings.Right(GlobalVariables.Chapar[index, 1], Strings.Len(GlobalVariables.Chapar[index, 1]) - num6);
                                                                                                                    recordset.Open("select * from [Properties]" + str4, frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                                                                                                                    short left = 1;
                                                                                                                    if (Strings.UCase(str5) == "ALL")
                                                                                                                    {
                                                                                                                        recordset4[]["Start"][] = 1;
                                                                                                                        while (true)
                                                                                                                        {
                                                                                                                            flag3 = !recordset.EOF;
                                                                                                                            if (!flag3)
                                                                                                                            {
                                                                                                                                recordset4[]["Length"][] = left;
                                                                                                                                break;
                                                                                                                            }
                                                                                                                            left = Conversions.ToShort(Operators.AddObject(left, recordset[]["Nlayer"][]));
                                                                                                                            recordset.MoveNext();
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        short num35 = Conversions.ToShort(str5);
                                                                                                                        num2 = 1;
                                                                                                                        while (true)
                                                                                                                        {
                                                                                                                            num36 = num35;
                                                                                                                            if (num2 <= num36)
                                                                                                                            {
                                                                                                                                left = Conversions.ToShort(Operators.AddObject(left, recordset[]["Nlayer"][]));
                                                                                                                                flag3 = num2 == Conversions.ToShort(str5);
                                                                                                                                if (!flag3)
                                                                                                                                {
                                                                                                                                    recordset.MoveNext();
                                                                                                                                    num2 = (short) (num2 + 1);
                                                                                                                                    continue;
                                                                                                                                }
                                                                                                                                recordset4[]["Start"][] = Operators.SubtractObject(left, recordset[]["Nlayer"][]);
                                                                                                                                recordset4[]["Length"][] = recordset[]["Nlayer"][];
                                                                                                                            }
                                                                                                                            break;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                                                index = (short) (index + 1);
                                                                                                            }
                                                                                                        }
                                                                                                        if (SaveAs | (index > num7))
                                                                                                        {
                                                                                                            recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                                            recordset4.Update(Missing.Value, Missing.Value);
                                                                                                        }
                                                                                                        recordset4[]["R_ID"][] = num8;
                                                                                                        recordset4[]["Layer_no"][] = index;
                                                                                                        recordset4[]["fmobile"][] = GlobalVariables.fmobile[index];
                                                                                                        recordset4[]["fmobile_c"][] = GlobalVariables.fmobile_c[index];
                                                                                                        recordset4[]["aexc"][] = GlobalVariables.aexc[index];
                                                                                                        recordset4[]["aexc_c"][] = GlobalVariables.aexc_c[index];
                                                                                                        recordset4[]["psexc"][] = GlobalVariables.psexc[index];
                                                                                                        recordset4[]["psexc_c"][] = GlobalVariables.psexc_c[index];
                                                                                                        recordset4[]["alpha"][] = GlobalVariables.a_lpha[index];
                                                                                                        recordset4[]["alpha_c"][] = GlobalVariables.alpha_c[index];
                                                                                                        recordset4[]["zkd"][] = GlobalVariables.zkd[index];
                                                                                                        recordset4[]["zkd_c"][] = GlobalVariables.zkd_c[index];
                                                                                                        recordset4[]["degmil"][] = GlobalVariables.degmil[index];
                                                                                                        recordset4[]["degmil_c"][] = GlobalVariables.degmil_c[index];
                                                                                                        recordset4[]["degmal"][] = GlobalVariables.degmal[index];
                                                                                                        recordset4[]["degmal_c"][] = GlobalVariables.degmal_c[index];
                                                                                                        recordset4[]["degmis"][] = GlobalVariables.degmis[index];
                                                                                                        recordset4[]["degmis_c"][] = GlobalVariables.degmis_c[index];
                                                                                                        recordset4[]["degmas"][] = GlobalVariables.degmas[index];
                                                                                                        recordset4[]["degmas_c"][] = GlobalVariables.degmas_c[index];
                                                                                                        if (true)
                                                                                                        {
                                                                                                            recordset4[]["alpha"][] = GlobalVariables.f_reund[index];
                                                                                                            recordset4[]["alpha_c"][] = GlobalVariables.freund_c[index];
                                                                                                        }
                                                                                                        recordset4.Update(Missing.Value, Missing.Value);
                                                                                                        flag3 = !SaveAs;
                                                                                                        if (flag3)
                                                                                                        {
                                                                                                            recordset4.MoveNext();
                                                                                                        }
                                                                                                        index = (short) (index + 1);
                                                                                                    }
                                                                                                }
                                                                                                if (SaveAs | ((num2 + 1) > num7))
                                                                                                {
                                                                                                    recordset4.AddNew(Missing.Value, Missing.Value);
                                                                                                }
                                                                                                recordset4[]["R_ID"][] = num8;
                                                                                                recordset4[]["till_day"][] = GlobalVariables.till_day[num2];
                                                                                                recordset4[]["till_int"][] = GlobalVariables.till_int[num2];
                                                                                                recordset4[]["till_lay"][] = GlobalVariables.till_lay[num2];
                                                                                                recordset4[]["t_ascale"][] = GlobalVariables.t_ascale[num2];
                                                                                                recordset4[]["tillcons"][] = GlobalVariables.tillcons[num2];
                                                                                                recordset4[]["till_day_c"][] = GlobalVariables.till_day_c[num2];
                                                                                                recordset4[]["till_int_c"][] = GlobalVariables.till_int_c[num2];
                                                                                                recordset4[]["till_lay_c"][] = GlobalVariables.till_lay_c[num2];
                                                                                                recordset4[]["t_ascale_c"][] = GlobalVariables.t_ascale_c[num2];
                                                                                                recordset4[]["tillcons_c"][] = GlobalVariables.tillcons_c[num2];
                                                                                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                                                                flag3 = !SaveAs;
                                                                                                if (flag3)
                                                                                                {
                                                                                                    recordset4.MoveNext();
                                                                                                }
                                                                                                num2 = (short) (num2 + 1);
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (SaveAs | (index > num7))
                                                        {
                                                            recordset4.AddNew(Missing.Value, Missing.Value);
                                                        }
                                                        recordset4[]["R_ID"][] = num8;
                                                        recordset4[]["year"][] = GlobalVariables.Y_ear[index];
                                                        recordset4[]["ncrop"][] = GlobalVariables.ncrop[index];
                                                        recordset4[]["cropname"][] = GlobalVariables.cropname[index];
                                                        recordset4[]["rootinit"][] = GlobalVariables.rootinit[index];
                                                        recordset4[]["rootinit_c"][] = GlobalVariables.rootinit_c[index];
                                                        recordset4[]["rootmax"][] = GlobalVariables.rootmax[index];
                                                        recordset4[]["rootmax_c"][] = GlobalVariables.rootmax_c[index];
                                                        recordset4[]["rootdep"][] = GlobalVariables.rootdep[index];
                                                        recordset4[]["rootdep_c"][] = GlobalVariables.rootdep_c[index];
                                                        recordset4[]["cform"][] = GlobalVariables.cform[index];
                                                        recordset4[]["cform_c"][] = GlobalVariables.cform_c[index];
                                                        recordset4[]["rpin"][] = GlobalVariables.rpin[index];
                                                        recordset4[]["rpin_c"][] = GlobalVariables.rpin_c[index];
                                                        recordset4[]["fawc"][] = GlobalVariables.fawc[index];
                                                        recordset4[]["fawc_c"][] = GlobalVariables.fawc_c[index];
                                                        recordset4[]["critair"][] = GlobalVariables.critair[index];
                                                        recordset4[]["critair_c"][] = GlobalVariables.critair_c[index];
                                                        recordset4[]["beta"][] = GlobalVariables.beta[index];
                                                        recordset4[]["beta_c"][] = GlobalVariables.beta_c[index];
                                                        recordset4[]["cancap"][] = GlobalVariables.cancap[index];
                                                        recordset4[]["cancap_c"][] = GlobalVariables.cancap_c[index];
                                                        recordset4[]["zalp"][] = GlobalVariables.zalp[index];
                                                        recordset4[]["zalp_c"][] = GlobalVariables.zalp_c[index];
                                                        recordset4[]["idstart"][] = GlobalVariables.idstart[index];
                                                        recordset4[]["idstart_c"][] = GlobalVariables.idstart_c[index];
                                                        recordset4[]["idmax"][] = GlobalVariables.idmax[index];
                                                        recordset4[]["idmax_c"][] = GlobalVariables.idmax_c[index];
                                                        recordset4[]["iharv"][] = GlobalVariables.iharv[index];
                                                        recordset4[]["iharv_c"][] = GlobalVariables.iharv_c[index];
                                                        recordset4[]["zhmin"][] = GlobalVariables.zhmin[index];
                                                        recordset4[]["zhmin_c"][] = GlobalVariables.zhmin_c[index];
                                                        recordset4[]["laic"][] = GlobalVariables.laic[index];
                                                        recordset4[]["laic_c"][] = GlobalVariables.laic_c[index];
                                                        recordset4[]["laimin"][] = GlobalVariables.laimin[index];
                                                        recordset4[]["laimin_c"][] = GlobalVariables.laimin_c[index];
                                                        recordset4[]["laimax"][] = GlobalVariables.laimax[index];
                                                        recordset4[]["laimax_c"][] = GlobalVariables.laimax_c[index];
                                                        recordset4[]["zdatemin"][] = GlobalVariables.zdatemin[index];
                                                        recordset4[]["zdatemin_c"][] = GlobalVariables.zdatemin_c[index];
                                                        recordset4[]["dform"][] = GlobalVariables.dform[index];
                                                        recordset4[]["dform_c"][] = GlobalVariables.dform_c[index];
                                                        recordset4[]["laihar"][] = GlobalVariables.laihar[index];
                                                        recordset4[]["laihar_c"][] = GlobalVariables.laihar_c[index];
                                                        recordset4[]["hmax"][] = GlobalVariables.hmax[index];
                                                        recordset4[]["hmax_c"][] = GlobalVariables.hmax_c[index];
                                                        recordset4[]["rsmin"][] = GlobalVariables.rsmin[index];
                                                        recordset4[]["rsmin_c"][] = GlobalVariables.rsmin_c[index];
                                                        recordset4[]["atten"][] = GlobalVariables.atten[index];
                                                        recordset4[]["atten_c"][] = GlobalVariables.atten_c[index];
                                                        recordset4[]["hcrop"][] = GlobalVariables.hcrop[index];
                                                        recordset4[]["hcrop_c"][] = GlobalVariables.hcrop_c[index];
                                                        recordset4[]["rsurf"][] = GlobalVariables.rsurf[index];
                                                        recordset4[]["rsurf_c"][] = GlobalVariables.rsurf_c[index];
                                                        recordset4[]["waten"][] = GlobalVariables.waten[1];
                                                        recordset4[]["vpd50"][] = GlobalVariables.vpd50[index];
                                                        recordset4[]["vpd50_c"][] = GlobalVariables.vpd50_c[index];
                                                        recordset4[]["ri50"][] = GlobalVariables.ri50[index];
                                                        recordset4[]["ri50_c"][] = GlobalVariables.ri50_c[index];
                                                        if (GlobalVariables.ncrop[index] == 2)
                                                        {
                                                            recordset4[]["idstart2"][] = GlobalVariables.idstart2[index];
                                                            recordset4[]["idstart2_c"][] = GlobalVariables.idstart2_c[index];
                                                            recordset4[]["idmax2"][] = GlobalVariables.idmax2[index];
                                                            recordset4[]["idmax2_c"][] = GlobalVariables.idmax2_c[index];
                                                            recordset4[]["iharv2"][] = GlobalVariables.iharv2[index];
                                                            recordset4[]["iharv2_c"][] = GlobalVariables.iharv2_c[index];
                                                            recordset4[]["zdatemin2"][] = GlobalVariables.zdatemin2[index];
                                                            recordset4[]["zdatemin2_c"][] = GlobalVariables.zdatemin2_c[index];
                                                        }
                                                        recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                        if (!SaveAs)
                                                        {
                                                            recordset4.MoveNext();
                                                        }
                                                        index = (short) (index + 1);
                                                    }
                                                }
                                                if (SaveAs | (index > num7))
                                                {
                                                    recordset4.AddNew(Missing.Value, Missing.Value);
                                                }
                                                recordset4[]["R_ID"][] = num8;
                                                recordset4[]["Layer_no"][] = index;
                                                recordset4[]["Z"][] = GlobalVariables.Z[index];
                                                recordset4[]["z_c"][] = GlobalVariables.z_c[index];
                                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                                if (!SaveAs)
                                                {
                                                    recordset4.MoveNext();
                                                }
                                                index = (short) (index + 1);
                                            }
                                        }
                                        if (SaveAs | (index > num7))
                                        {
                                            recordset4.AddNew(Missing.Value, Missing.Value);
                                        }
                                        recordset4[]["R_ID"][] = num8;
                                        recordset4[]["Layer_no"][] = index;
                                        recordset4[]["xmpor"][] = GlobalVariables.xmpor[index];
                                        recordset4[]["xmpor_c"][] = GlobalVariables.xmpor_c[index];
                                        recordset4[]["tporv"][] = GlobalVariables.tporv[index];
                                        recordset4[]["tporv_c"][] = GlobalVariables.tporv_c[index];
                                        recordset4[]["wilt"][] = GlobalVariables.wilt[index];
                                        recordset4[]["wilt_c"][] = GlobalVariables.wilt_c[index];
                                        recordset4[]["gamma"][] = GlobalVariables.gamma[index];
                                        recordset4[]["gamma_c"][] = GlobalVariables.gamma_c[index];
                                        recordset4[]["resid"][] = GlobalVariables.resid[index];
                                        recordset4[]["resid_c"][] = GlobalVariables.resid_c[index];
                                        recordset4[]["cten"][] = GlobalVariables.cten[index];
                                        recordset4[]["cten_c"][] = GlobalVariables.cten_c[index];
                                        recordset4[]["zlamb"][] = GlobalVariables.vg_N[index];
                                        recordset4[]["zlamb_c"][] = GlobalVariables.zlamb_c[index];
                                        recordset4[]["ksatmin"][] = GlobalVariables.ksatmin[index];
                                        recordset4[]["ksatmin_c"][] = GlobalVariables.ksatmin_c[index];
                                        recordset4[]["ksm"][] = GlobalVariables.ksm[index];
                                        recordset4[]["ksm_c"][] = GlobalVariables.ksm_c[index];
                                        recordset4[]["zn"][] = GlobalVariables.zn[index];
                                        recordset4[]["zn_c"][] = GlobalVariables.zn_c[index];
                                        recordset4[]["zm"][] = GlobalVariables.zm[index];
                                        recordset4[]["zm_c"][] = GlobalVariables.zm_c[index];
                                        recordset4[]["zp"][] = GlobalVariables.zp[index];
                                        recordset4[]["zp_c"][] = GlobalVariables.zp_c[index];
                                        recordset4[]["za"][] = GlobalVariables.za[index];
                                        recordset4[]["za_c"][] = GlobalVariables.za_c[index];
                                        recordset4[]["ascale"][] = GlobalVariables.ascale[index];
                                        recordset4[]["ascale_c"][] = GlobalVariables.ascale_c[index];
                                        recordset4[]["scalepsi"][] = GlobalVariables.scalepsi[index];
                                        recordset4[]["scalepsi_c"][] = GlobalVariables.scalepsi_c[index];
                                        recordset4[]["scalevg"][] = GlobalVariables.vg_alpha[index];
                                        recordset4[]["scalevg_c"][] = GlobalVariables.scalevg_c[index];
                                        recordset4[]["trap_air"][] = GlobalVariables.trap_air[index];
                                        recordset4[]["trap_air_c"][] = GlobalVariables.trap_air_c[index];
                                        recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                        if (!SaveAs)
                                        {
                                            recordset4.MoveNext();
                                        }
                                        index = (short) (index + 1);
                                    }
                                }
                                if (SaveAs | (index > num7))
                                {
                                    recordset4.AddNew(Missing.Value, Missing.Value);
                                }
                                recordset4[]["R_ID"][] = num8;
                                recordset4[]["designat"][] = GlobalVariables.designat[index];
                                recordset4[]["Nlayer"][] = GlobalVariables.N_Layer[index];
                                recordset4[]["thick"][] = GlobalVariables.Hthick[index];
                                recordset4[]["sand"][] = GlobalVariables.sand[index];
                                recordset4[]["silt"][] = GlobalVariables.silt[index];
                                recordset4[]["clay"][] = GlobalVariables.clay[index];
                                recordset4[]["structur"][] = GlobalVariables.structur[index];
                                recordset4[]["bulk"][] = GlobalVariables.bulk[index];
                                recordset4[]["orgc"][] = GlobalVariables.orgc[index];
                                recordset4[]["Texture"][] = GlobalVariables.Texture[index];
                                recordset4[]["pH"][] = GlobalVariables.pH[index];
                                recordset4[]["horiz_no"][] = index;
                                recordset4[]["macro1"][] = Conversions.ToString(GlobalVariables.stone[index]);
                                recordset4.UpdateBatch(AffectEnum.adAffectAll);
                                if (!SaveAs)
                                {
                                    recordset4.MoveNext();
                                }
                                index = (short) (index + 1);
                            }
                        }
                        if (SaveAs | (index > num7))
                        {
                            recordset4.MoveLast();
                            recordset4.AddNew(Missing.Value, Missing.Value);
                        }
                        recordset4[]["R_ID"][] = num8;
                        recordset4[]["Layer_no"][] = index;
                        recordset4[]["tempini"][] = GlobalVariables.tempini[index];
                        recordset4[]["tempini_c"][] = GlobalVariables.tempini_c[index];
                        recordset4[]["thetaini"][] = GlobalVariables.thetaini[index];
                        recordset4[]["thetaini_c"][] = GlobalVariables.thetaini_c[index];
                        recordset4[]["solinit"][] = GlobalVariables.solinit[index];
                        recordset4[]["solinit_c"][] = GlobalVariables.solinit_c[index];
                        recordset4.UpdateBatch(AffectEnum.adAffectAll);
                        if (!SaveAs)
                        {
                            recordset4.MoveNext();
                        }
                        index = (short) (index + 1);
                    }
                }
                num9 = (short) (num9 + GlobalVariables.N_Layer[index]);
                index = (short) (index + 1);
            }
        }

        public static void ZeroVariables()
        {
            Array.Clear(GlobalVariables.tempini, 0, GlobalVariables.tempini.Length);
            Array.Clear(GlobalVariables.thetaini, 0, GlobalVariables.thetaini.Length);
            Array.Clear(GlobalVariables.solinit, 0, GlobalVariables.solinit.Length);
            Array.Clear(GlobalVariables.tempini_c, 0, GlobalVariables.tempini_c.Length);
            Array.Clear(GlobalVariables.thetaini_c, 0, GlobalVariables.thetaini_c.Length);
            Array.Clear(GlobalVariables.solinit_c, 0, GlobalVariables.solinit_c.Length);
            Array.Clear(GlobalVariables.Zthick, 0, GlobalVariables.Zthick.Length);
            Array.Clear(GlobalVariables.Hthick, 0, GlobalVariables.Hthick.Length);
            Array.Clear(GlobalVariables.N_Layer, 0, GlobalVariables.N_Layer.Length);
            Array.Clear(GlobalVariables.designat, 0, GlobalVariables.designat.Length);
            Array.Clear(GlobalVariables.resid, 0, GlobalVariables.resid.Length);
            Array.Clear(GlobalVariables.zm, 0, GlobalVariables.zm.Length);
            Array.Clear(GlobalVariables.zp, 0, GlobalVariables.zp.Length);
            Array.Clear(GlobalVariables.za, 0, GlobalVariables.za.Length);
            Array.Clear(GlobalVariables.scalepsi, 0, GlobalVariables.scalepsi.Length);
            Array.Clear(GlobalVariables.vg_alpha, 0, GlobalVariables.vg_alpha.Length);
            Array.Clear(GlobalVariables.Phys_layer, 0, GlobalVariables.Phys_layer.Length);
            GlobalVariables.amir = null;
            GlobalVariables.irrstart = null;
            GlobalVariables.irrend = null;
            GlobalVariables.irrig_no = null;
            GlobalVariables.z_fint = null;
            GlobalVariables.i_rrday = null;
            GlobalVariables.c_onci = null;
            Array.Clear(GlobalVariables.a_lpha, 0, GlobalVariables.a_lpha.Length);
            Array.Clear(GlobalVariables.fmobile, 0, GlobalVariables.fmobile.Length);
            Array.Clear(GlobalVariables.aexc, 0, GlobalVariables.aexc.Length);
            Array.Clear(GlobalVariables.psexc, 0, GlobalVariables.psexc.Length);
            Array.Clear(GlobalVariables.zkd, 0, GlobalVariables.zkd.Length);
            Array.Clear(GlobalVariables.degmil, 0, GlobalVariables.degmil.Length);
            Array.Clear(GlobalVariables.degmal, 0, GlobalVariables.degmal.Length);
            Array.Clear(GlobalVariables.degmis, 0, GlobalVariables.degmis.Length);
            Array.Clear(GlobalVariables.degmas, 0, GlobalVariables.degmas.Length);
            Array.Clear(GlobalVariables.critair, 0, GlobalVariables.critair.Length);
            Array.Clear(GlobalVariables.Y_ear, 0, GlobalVariables.Y_ear.Length);
            Array.Clear(GlobalVariables.ncrop, 0, GlobalVariables.ncrop.Length);
            Array.Clear(GlobalVariables.idstart2, 0, GlobalVariables.idstart2.Length);
            Array.Clear(GlobalVariables.idmax2, 0, GlobalVariables.idmax2.Length);
            Array.Clear(GlobalVariables.iharv2, 0, GlobalVariables.iharv2.Length);
            Array.Clear(GlobalVariables.zdatemin2, 0, GlobalVariables.zdatemin2.Length);
            Array.Clear(GlobalVariables.sand, 0, GlobalVariables.sand.Length);
            Array.Clear(GlobalVariables.pH, 0, GlobalVariables.pH.Length);
            Array.Clear(GlobalVariables.silt, 0, GlobalVariables.silt.Length);
            Array.Clear(GlobalVariables.clay, 0, GlobalVariables.clay.Length);
            Array.Clear(GlobalVariables.structur, 0, GlobalVariables.structur.Length);
            Array.Clear(GlobalVariables.bulk, 0, GlobalVariables.bulk.Length);
            Array.Clear(GlobalVariables.orgc, 0, GlobalVariables.orgc.Length);
            Array.Clear(GlobalVariables.Texture, 0, GlobalVariables.Texture.Length);
            Array.Clear(GlobalVariables.Z, 0, GlobalVariables.Z.Length);
            Array.Clear(GlobalVariables.xmpor, 0, GlobalVariables.xmpor.Length);
            Array.Clear(GlobalVariables.tporv, 0, GlobalVariables.tporv.Length);
            Array.Clear(GlobalVariables.wilt, 0, GlobalVariables.wilt.Length);
            Array.Clear(GlobalVariables.gamma, 0, GlobalVariables.gamma.Length);
            Array.Clear(GlobalVariables.vg_N, 0, GlobalVariables.vg_N.Length);
            Array.Clear(GlobalVariables.ksatmin, 0, GlobalVariables.ksatmin.Length);
            Array.Clear(GlobalVariables.ksm, 0, GlobalVariables.ksm.Length);
            Array.Clear(GlobalVariables.zn, 0, GlobalVariables.zn.Length);
            Array.Clear(GlobalVariables.ascale, 0, GlobalVariables.ascale.Length);
            Array.Clear(GlobalVariables.waten, 0, GlobalVariables.waten.Length);
            Array.Clear(GlobalVariables.rootinit, 0, GlobalVariables.rootinit.Length);
            Array.Clear(GlobalVariables.rootmax, 0, GlobalVariables.rootmax.Length);
            Array.Clear(GlobalVariables.rootdep, 0, GlobalVariables.rootdep.Length);
            Array.Clear(GlobalVariables.cform, 0, GlobalVariables.cform.Length);
            Array.Clear(GlobalVariables.rpin, 0, GlobalVariables.rpin.Length);
            Array.Clear(GlobalVariables.fawc, 0, GlobalVariables.fawc.Length);
            Array.Clear(GlobalVariables.beta, 0, GlobalVariables.beta.Length);
            Array.Clear(GlobalVariables.cancap, 0, GlobalVariables.cancap.Length);
            Array.Clear(GlobalVariables.zalp, 0, GlobalVariables.zalp.Length);
            Array.Clear(GlobalVariables.idstart, 0, GlobalVariables.idstart.Length);
            Array.Clear(GlobalVariables.idmax, 0, GlobalVariables.idmax.Length);
            Array.Clear(GlobalVariables.iharv, 0, GlobalVariables.iharv.Length);
            Array.Clear(GlobalVariables.zhmin, 0, GlobalVariables.zhmin.Length);
            Array.Clear(GlobalVariables.laic, 0, GlobalVariables.laic.Length);
            Array.Clear(GlobalVariables.laimin, 0, GlobalVariables.laimin.Length);
            Array.Clear(GlobalVariables.laimax, 0, GlobalVariables.laimax.Length);
            Array.Clear(GlobalVariables.zdatemin, 0, GlobalVariables.zdatemin.Length);
            Array.Clear(GlobalVariables.dform, 0, GlobalVariables.dform.Length);
            Array.Clear(GlobalVariables.laihar, 0, GlobalVariables.laihar.Length);
            Array.Clear(GlobalVariables.hmax, 0, GlobalVariables.hmax.Length);
            Array.Clear(GlobalVariables.rsmin, 0, GlobalVariables.rsmin.Length);
            Array.Clear(GlobalVariables.atten, 0, GlobalVariables.atten.Length);
            Array.Clear(GlobalVariables.hcrop, 0, GlobalVariables.hcrop.Length);
            Array.Clear(GlobalVariables.rsurf, 0, GlobalVariables.rsurf.Length);
            Array.Clear(GlobalVariables.resid_c, 0, GlobalVariables.resid_c.Length);
            Array.Clear(GlobalVariables.zm_c, 0, GlobalVariables.zm_c.Length);
            Array.Clear(GlobalVariables.zp_c, 0, GlobalVariables.zp_c.Length);
            Array.Clear(GlobalVariables.za_c, 0, GlobalVariables.za_c.Length);
            Array.Clear(GlobalVariables.scalepsi_c, 0, GlobalVariables.scalepsi_c.Length);
            Array.Clear(GlobalVariables.scalevg_c, 0, GlobalVariables.scalevg_c.Length);
            Array.Clear(GlobalVariables.amir_c, 0, GlobalVariables.amir_c.Length);
            Array.Clear(GlobalVariables.irrstart_c, 0, GlobalVariables.irrstart_c.Length);
            Array.Clear(GlobalVariables.irrend_c, 0, GlobalVariables.irrend_c.Length);
            Array.Clear(GlobalVariables.fmobile_c, 0, GlobalVariables.fmobile_c.Length);
            Array.Clear(GlobalVariables.aexc_c, 0, GlobalVariables.aexc_c.Length);
            Array.Clear(GlobalVariables.psexc_c, 0, GlobalVariables.psexc_c.Length);
            Array.Clear(GlobalVariables.zkd_c, 0, GlobalVariables.zkd_c.Length);
            Array.Clear(GlobalVariables.degmil_c, 0, GlobalVariables.degmil_c.Length);
            Array.Clear(GlobalVariables.degmal_c, 0, GlobalVariables.degmal_c.Length);
            Array.Clear(GlobalVariables.degmis_c, 0, GlobalVariables.degmis_c.Length);
            Array.Clear(GlobalVariables.degmas_c, 0, GlobalVariables.degmas_c.Length);
            Array.Clear(GlobalVariables.critair_c, 0, GlobalVariables.critair_c.Length);
            Array.Clear(GlobalVariables.idstart2_c, 0, GlobalVariables.idstart2_c.Length);
            Array.Clear(GlobalVariables.idmax2_c, 0, GlobalVariables.idmax2_c.Length);
            Array.Clear(GlobalVariables.iharv2_c, 0, GlobalVariables.iharv2_c.Length);
            Array.Clear(GlobalVariables.zdatemin2_c, 0, GlobalVariables.zdatemin2_c.Length);
            Array.Clear(GlobalVariables.z_c, 0, GlobalVariables.z_c.Length);
            Array.Clear(GlobalVariables.xmpor_c, 0, GlobalVariables.xmpor_c.Length);
            Array.Clear(GlobalVariables.tporv_c, 0, GlobalVariables.tporv_c.Length);
            Array.Clear(GlobalVariables.wilt_c, 0, GlobalVariables.wilt_c.Length);
            Array.Clear(GlobalVariables.gamma_c, 0, GlobalVariables.gamma_c.Length);
            Array.Clear(GlobalVariables.zlamb_c, 0, GlobalVariables.zlamb_c.Length);
            Array.Clear(GlobalVariables.ksatmin_c, 0, GlobalVariables.ksatmin_c.Length);
            Array.Clear(GlobalVariables.ksm_c, 0, GlobalVariables.ksm_c.Length);
            Array.Clear(GlobalVariables.zn_c, 0, GlobalVariables.zn_c.Length);
            Array.Clear(GlobalVariables.ascale_c, 0, GlobalVariables.ascale_c.Length);
            Array.Clear(GlobalVariables.waten_c, 0, GlobalVariables.waten_c.Length);
            Array.Clear(GlobalVariables.rootinit_c, 0, GlobalVariables.rootinit_c.Length);
            Array.Clear(GlobalVariables.rootmax_c, 0, GlobalVariables.rootmax_c.Length);
            Array.Clear(GlobalVariables.rootdep_c, 0, GlobalVariables.rootdep_c.Length);
            Array.Clear(GlobalVariables.cform_c, 0, GlobalVariables.cform_c.Length);
            Array.Clear(GlobalVariables.rpin_c, 0, GlobalVariables.rpin_c.Length);
            Array.Clear(GlobalVariables.fawc_c, 0, GlobalVariables.fawc_c.Length);
            Array.Clear(GlobalVariables.beta_c, 0, GlobalVariables.beta_c.Length);
            Array.Clear(GlobalVariables.cancap_c, 0, GlobalVariables.cancap_c.Length);
            Array.Clear(GlobalVariables.zalp_c, 0, GlobalVariables.zalp_c.Length);
            Array.Clear(GlobalVariables.idstart_c, 0, GlobalVariables.idstart_c.Length);
            Array.Clear(GlobalVariables.idmax_c, 0, GlobalVariables.idmax_c.Length);
            Array.Clear(GlobalVariables.iharv_c, 0, GlobalVariables.iharv_c.Length);
            Array.Clear(GlobalVariables.zhmin_c, 0, GlobalVariables.zhmin_c.Length);
            Array.Clear(GlobalVariables.laic_c, 0, GlobalVariables.laic_c.Length);
            Array.Clear(GlobalVariables.laimin_c, 0, GlobalVariables.laimin_c.Length);
            Array.Clear(GlobalVariables.laimax_c, 0, GlobalVariables.laimax_c.Length);
            Array.Clear(GlobalVariables.zdatemin_c, 0, GlobalVariables.zdatemin_c.Length);
            Array.Clear(GlobalVariables.dform_c, 0, GlobalVariables.dform_c.Length);
            Array.Clear(GlobalVariables.laihar_c, 0, GlobalVariables.laihar_c.Length);
            Array.Clear(GlobalVariables.hmax_c, 0, GlobalVariables.hmax_c.Length);
            Array.Clear(GlobalVariables.rsmin_c, 0, GlobalVariables.rsmin_c.Length);
            Array.Clear(GlobalVariables.atten_c, 0, GlobalVariables.atten_c.Length);
            Array.Clear(GlobalVariables.hcrop_c, 0, GlobalVariables.hcrop_c.Length);
            Array.Clear(GlobalVariables.rsurf_c, 0, GlobalVariables.rsurf_c.Length);
        }
    }
}

