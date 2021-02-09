namespace MACRO_52
{
    using ADODB;
    using AxMSFlexGridLib;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.Compatibility.VB6;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [StandardModule]
    internal sealed class ChecksAndAssignments
    {
        public static void AssignCropValues(ref CfrmMain frmMain)
        {
            // Invalid method body.
        }

        public static void AssignIBCondValues(ref CfrmMain frmMain)
        {
            // Invalid method body.
        }

        public static void AssignIrrigation(ref short irryear, ref CfrmMain frmMain, ref short modif = 0)
        {
            // Invalid method body.
        }

        public static void AssignManagementValues(ref CfrmMain frmMain)
        {
            // Invalid method body.
        }

        public static void AssignNumerical(CfrmParameters frm)
        {
            // Invalid method body.
        }

        public static void AssignPhysicalParameters(ref CfrmMain frmMain, ref bool desig = true)
        {
            short num6 = 0;
            AxMSFlexGrid grid = frmMain.frmParameters._flx_Parameters_4;
            short nhorizon = GlobalVariables.Nhorizon;
            short index = 1;
            while (true)
            {
                short num9 = nhorizon;
                if (index > num9)
                {
                    grid = null;
                    return;
                }
                if (desig)
                {
                    GlobalVariables.designat[index] = grid.get_TextMatrix(index, 0);
                }
                num6 = (short) Math.Round((double) (Conversions.ToShort(grid.get_TextMatrix(index, 1)) + GlobalVariables.Z[index]));
                num6 = Conversions.ToShort(grid.get_TextMatrix(index, 2));
                short num4 = index;
                short col = 5;
                GlobalVariables.tporv[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, 3));
                grid.Col = 3;
                grid.Row = index;
                grid.ColSel = 3;
                grid.RowSel = index;
                GlobalVariables.tporv_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                GlobalVariables.xmpor[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, 4));
                grid.Col = 4;
                grid.ColSel = 4;
                GlobalVariables.xmpor_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                {
                    GlobalVariables.wilt[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                    grid.Col = col;
                    grid.ColSel = col;
                    GlobalVariables.wilt_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                    col = (short) (col + 1);
                }
                GlobalVariables.resid[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.resid_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.gamma[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                GlobalVariables.bulk[index] = GlobalVariables.gamma[num4];
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.gamma_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.cten[num4] = Conversions.ToSingle(Support.Format(grid.get_TextMatrix(index, col), "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.cten_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.vg_N[num4] = Conversions.ToSingle(Support.Format(grid.get_TextMatrix(index, col), "0.0000E+00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.zlamb_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.ksatmin[num4] = Conversions.ToSingle(Support.Format(grid.get_TextMatrix(index, col), "###0.00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.ksatmin_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.ksm[num4] = Conversions.ToSingle(Support.Format(grid.get_TextMatrix(index, col), "0.0000E+00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.ksm_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.zn[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.zn_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.zm[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.zm_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.zp[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.zp_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.za[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.za_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.ascale[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.ascale_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                if (GlobalVariables.sw_hysteres == MACROConstants.Switch.Annual)
                {
                    GlobalVariables.scalepsi[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                    grid.Col = col;
                    grid.ColSel = col;
                    GlobalVariables.scalepsi_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                    col = (short) (col + 1);
                }
                if (GlobalVariables.sw_hydraulic == MACROConstants.Switch.BareSoil)
                {
                    GlobalVariables.vg_alpha[num4] = Conversions.ToDouble(grid.get_TextMatrix(index, col));
                    grid.Col = col;
                    grid.ColSel = col;
                    GlobalVariables.scalevg_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                    col = (short) (col + 1);
                }
                GlobalVariables.trap_air[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                grid.Col = col;
                grid.ColSel = col;
                GlobalVariables.trap_air_c[num4] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                col = (short) (col + 1);
                GlobalVariables.stone[num4] = Conversions.ToSingle(grid.get_TextMatrix(index, col));
                col = (short) (col + 1);
                index = (short) (index + 1);
            }
        }

        public static void AssignSiteValues(ref CfrmMain frmMain)
        {
            // Invalid method body.
        }

        public static void AssignSoilValues(ref CfrmMain frmMain, ref bool desig = true, ref bool convert = true)
        {
            int nhorizon = GlobalVariables.Nhorizon;
            GlobalVariables.Nhorizon = Convert.ToInt16(frmMain.frmDefineSoil.UpDown1.Value);
            GlobalVariables.profiledepth = 0f;
            int num4 = GlobalVariables.Nhorizon;
            int index = 1;
            while (true)
            {
                int num7 = num4;
                if (index > num7)
                {
                    if (GlobalVariables.N_NUMERICAL_LAYERS != Conversions.ToDouble(frmMain.frmDefineSoil.txtMaxNumLayers.Text))
                    {
                        convert = true;
                        int num5 = Conversions.ToInteger(frmMain.frmDefineSoil.txtMaxNumLayers.Text);
                        index = GlobalVariables.N_NUMERICAL_LAYERS;
                        while (true)
                        {
                            num7 = num5;
                            if (index > num7)
                            {
                                break;
                            }
                            GlobalVariables.thetaini[index] = GlobalVariables.thetaini[GlobalVariables.N_NUMERICAL_LAYERS];
                            GlobalVariables.solinit[index] = GlobalVariables.solinit[GlobalVariables.N_NUMERICAL_LAYERS];
                            if (GlobalVariables.sw_tempini == MACROConstants.Switch.NoMetabolite)
                            {
                                GlobalVariables.tempini[index] = GlobalVariables.tempini[GlobalVariables.N_NUMERICAL_LAYERS];
                            }
                            index++;
                        }
                    }
                    GlobalVariables.N_NUMERICAL_LAYERS = Conversions.ToShort(frmMain.frmDefineSoil.txtMaxNumLayers.Text);
                    if (convert)
                    {
                        MiscFUncs.ComputeLayerThickness();
                    }
                    AssignPhysicalParameters(ref frmMain, ref false);
                    AssignSoluteValues(ref frmMain);
                    int num6 = GlobalVariables.Nhorizon;
                    index = 1;
                    while (true)
                    {
                        num7 = num6;
                        if (index > num7)
                        {
                            return;
                        }
                        GlobalVariables.bulk[index] = Conversions.ToSingle(frmMain.frmDefineSoil.grdData.get_TextMatrix(index, 5));
                        GlobalVariables.gamma[index] = GlobalVariables.bulk[index];
                        index++;
                    }
                }
                AxMSFlexGrid grdData = frmMain.frmDefineSoil.grdData;
                if (desig)
                {
                    GlobalVariables.designat[index] = grdData.get_TextMatrix(index, 0);
                }
                GlobalVariables.clay[index] = Conversions.ToSingle(grdData.get_TextMatrix(index, 1));
                GlobalVariables.silt[index] = Conversions.ToSingle(grdData.get_TextMatrix(index, 2));
                GlobalVariables.sand[index] = Conversions.ToSingle(grdData.get_TextMatrix(index, 3));
                GlobalVariables.pH[index] = Conversions.ToSingle(grdData.get_TextMatrix(index, 4));
                GlobalVariables.orgc[index] = Conversions.ToSingle(grdData.get_TextMatrix(index, 6));
                GlobalVariables.Hthick[index] = Conversions.ToSingle(grdData.get_TextMatrix(index, 7));
                GlobalVariables.thickness[index] = grdData.get_TextMatrix(index, 7);
                GlobalVariables.profiledepth += GlobalVariables.Hthick[index];
                GlobalVariables.Texture[index] = grdData.get_TextMatrix(index, 8);
                string[] strArray = new string[] { Strings.Trim(grdData.get_TextMatrix(index, 10)), " ", Strings.Trim(grdData.get_TextMatrix(index, 9)), " ", Strings.Trim(grdData.get_TextMatrix(index, 11)) };
                GlobalVariables.structur[index] = string.Concat(strArray);
                grdData = null;
                index++;
            }
        }

        public static void AssignSoluteValues(ref CfrmMain frmMain)
        {
            if (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)
            {
                short row = -1;
                CfrmParameters frmParameters = frmMain.frmParameters;
                GlobalVariables.Koc = Conversions.ToSingle(frmParameters.txtkoc.Text);
                if (GlobalVariables.sw_immobile == MACROConstants.Switch.Annual)
                {
                    row = (short) (row + 1);
                    GlobalVariables.pf1 = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.pf1_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    row = (short) (row + 1);
                    GlobalVariables.pf2 = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.pf2_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                }
                if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) && (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil))
                {
                    row = (short) (row + 1);
                    GlobalVariables.pmax = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.pmax_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    row = (short) (row + 1);
                    GlobalVariables.genkd = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.genkd_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    row = (short) (row + 1);
                    GlobalVariables.vref = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.vref_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    row = (short) (row + 1);
                    GlobalVariables.settle = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.settle_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    row = (short) (row + 1);
                    GlobalVariables.filtermi = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.filtermi_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    row = (short) (row + 1);
                    GlobalVariables.refilter = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.refilter_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    row = (short) (row + 1);
                    GlobalVariables.replen = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.replen_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                }
                if (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)
                {
                    row = (short) (row + 1);
                    GlobalVariables.zmix = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.zmix_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    row = (short) (row + 1);
                    GlobalVariables.conc = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.conc_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    if (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)
                    {
                        row = (short) (row + 1);
                        GlobalVariables.d_iff = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.diff_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                        row = (short) (row + 1);
                        GlobalVariables.dv = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.dv_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    }
                }
                if (GlobalVariables.sw_immobile > MACROConstants.Switch.NoMetabolite)
                {
                    row = (short) (row + 1);
                    GlobalVariables.frack = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.frack_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                }
                if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) | (((GlobalVariables.sw_solute == MACROConstants.Switch.Perennial) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)) & (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)))
                {
                    row = (short) (row + 1);
                    GlobalVariables.fstar = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.fstar_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                }
                if ((GlobalVariables.sw_solute == ((MACROConstants.Switch) 0x13)) & (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil))
                {
                    row = (short) (row + 1);
                    GlobalVariables.gravit = Conversions.ToSingle(frmParameters.text12[row].Text);
                    GlobalVariables.gravit_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                }
                if (GlobalVariables.sw_solute != MACROConstants.Switch.BareSoil)
                {
                    if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                    {
                        row = (short) (row + 1);
                        GlobalVariables.fracmac = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.fracmac_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    }
                    if (((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)) & (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil))
                    {
                        row = (short) (row + 1);
                        GlobalVariables.candeg = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.candeg_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                        row = (short) (row + 1);
                        GlobalVariables.fext = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.fext_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    }
                    if (((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)) & (GlobalVariables.sw_driving == MACROConstants.Switch.Annual))
                    {
                        row = (short) (row + 1);
                        GlobalVariables.zkdpc = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.zkdpc_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    }
                    if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite))
                    {
                        row = (short) (row + 1);
                        GlobalVariables.expb = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.expb_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                        row = (short) (row + 1);
                        GlobalVariables.tresp = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.tresp_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                        row = (short) (row + 1);
                        GlobalVariables.tref = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.tref_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                        if (GlobalVariables.sw_driving == MACROConstants.Switch.BareSoil)
                        {
                            row = (short) (row + 1);
                            GlobalVariables.f_convert = Conversions.ToSingle(frmParameters.text12[row].Text);
                            GlobalVariables.fconvert_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                        }
                    }
                    if (GlobalVariables.sw_kinetic == MACROConstants.Switch.BareSoil)
                    {
                        row = (short) (row + 1);
                        GlobalVariables.sorp_rate = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.sorp_rate_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                        row = (short) (row + 1);
                        GlobalVariables.frac_eq = Conversions.ToSingle(frmParameters.text12[row].Text);
                        GlobalVariables.frac_eq_c = ColorID(ref ColorTranslator.ToOle(frmParameters.text12[row].ForeColor));
                    }
                    frmParameters = null;
                    short col = 2;
                    short num6 = 0;
                    AxMSFlexGrid grid = frmMain.frmParameters._flx_Parameters_5;
                    if (GlobalVariables.sw_solute != MACROConstants.Switch.Tritium)
                    {
                        short nhorizon = GlobalVariables.Nhorizon;
                        row = 1;
                        while (true)
                        {
                            short num9 = nhorizon;
                            if (row > num9)
                            {
                                break;
                            }
                            num6 = (short) Math.Round((double) (Conversions.ToShort(grid.get_TextMatrix(row, 1)) + GlobalVariables.Z[row]));
                            num6 = Conversions.ToShort(grid.get_TextMatrix(row, 2));
                            short index = row;
                            col = 2;
                            grid.Row = row;
                            grid.RowSel = row;
                            if (GlobalVariables.sw_immobile == MACROConstants.Switch.Perennial)
                            {
                                col = (short) (col + 1);
                                GlobalVariables.fmobile[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                grid.Col = col;
                                grid.ColSel = col;
                                GlobalVariables.fmobile_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                            }
                            if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) | ((GlobalVariables.sw_solute == MACROConstants.Switch.Perennial) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)))
                            {
                                col = (short) (col + 1);
                                GlobalVariables.aexc[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                grid.Col = col;
                                grid.ColSel = col;
                                GlobalVariables.aexc_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                            }
                            if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil))
                            {
                                col = (short) (col + 1);
                                GlobalVariables.psexc[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                grid.Col = col;
                                grid.ColSel = col;
                                GlobalVariables.psexc_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                            }
                            if (((GlobalVariables.sw_immobile > MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite))
                            {
                                col = (short) (col + 1);
                                GlobalVariables.a_lpha[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                grid.Col = col;
                                grid.ColSel = col;
                                GlobalVariables.alpha_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                            }
                            if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                            {
                                col = (short) (col + 1);
                                GlobalVariables.zkd[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                grid.Col = col;
                                grid.ColSel = col;
                                GlobalVariables.zkd_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                                if (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)
                                {
                                    col = (short) (col + 1);
                                    GlobalVariables.degmil[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    GlobalVariables.degmil_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                                    col = (short) (col + 1);
                                    GlobalVariables.degmal[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    GlobalVariables.degmal_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                                    col = (short) (col + 1);
                                    GlobalVariables.degmis[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    GlobalVariables.degmis_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                                    col = (short) (col + 1);
                                    GlobalVariables.degmas[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    GlobalVariables.degmas_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                                    col = (short) (col + 1);
                                    GlobalVariables.f_reund[index] = Conversions.ToSingle(grid.get_TextMatrix(row, col));
                                    grid.Col = col;
                                    grid.ColSel = col;
                                    GlobalVariables.freund_c[index] = ColorID(ref ColorTranslator.ToOle(grid.CellForeColor));
                                }
                            }
                            row = (short) (row + 1);
                        }
                    }
                    grid = null;
                }
            }
        }

        private static bool CheckConditional(ref string[] VarName, ref object[] Value, CfrmParameters frmParameters)
        {
            string str = VarName[Information.LBound(VarName, 1)];
            if (str != "GWFLUX")
            {
                if (str != "THETAINI")
                {
                    if (str != "ROOTINIT")
                    {
                        if (str != "ZHMIN")
                        {
                            if (str != "LAIMIN")
                            {
                                if (str != "LAIHAR")
                                {
                                    short num3;
                                    short num12;
                                    if (str != "AEXC")
                                    {
                                        if (str != "ZDATEMIN")
                                        {
                                            if (str != "XMPOR")
                                            {
                                                if (str != "KSATMIN")
                                                {
                                                    if (str != "TILL_LAY")
                                                    {
                                                        if ((str == "ZMIX") && Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(Operators.DivideObject(Value[Information.LBound(Value, 1)], (int) 10), Conversions.ToDouble(frmParameters._flx_Parameters_7.get_TextMatrix(1, 2)), false), Operators.CompareObjectLessEqual(Value[Information.LBound(Value, 1)], 0, false))))
                                                        {
                                                            MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter ZMIX = ", Value[Information.LBound(Value, 1)]), " out of valid range."), '\r'), "Valid range: 0 < ZMIX <= "), 10.0 * Conversions.ToDouble(frmParameters._flx_Parameters_7.get_TextMatrix(1, 2)))), 0x30, "Parameter error");
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        short num11 = (short) Information.UBound(Value, 1);
                                                        num3 = (short) Information.LBound(Value, 1);
                                                        while (true)
                                                        {
                                                            num12 = num11;
                                                            if (num3 > num12)
                                                            {
                                                                break;
                                                            }
                                                            if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[num3], 1, false), Operators.CompareObjectGreater(Value[num3], GlobalVariables.N_Layer[1], false))))
                                                            {
                                                                num3 = (short) (num3 + 1);
                                                                continue;
                                                            }
                                                            MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter TILL_LAY = ", Value[num3]), " out of valid range."), '\r'), "Valid range: 1 <= TILL_LAY <= "), GlobalVariables.N_Layer[1])), 0x30, "Parameter error");
                                                            return false;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    short num10 = (short) ((GlobalVariables.Nhorizon * 2) - 1);
                                                    num3 = 0;
                                                    while (true)
                                                    {
                                                        num12 = num10;
                                                        if (num3 > num12)
                                                        {
                                                            break;
                                                        }
                                                        if (!Operators.ConditionalCompareObjectGreaterEqual(Value[num3 + 1], Value[num3], false))
                                                        {
                                                            num3 = (short) (num3 + 2);
                                                            continue;
                                                        }
                                                        MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(("Parameter KSM out of valid range for horizon " + Conversions.ToString((double) ((((double) num3) / 2.0) + 1.0)) + ".") + "\r" + "Valid range: 0 < KSM < ", Value[num3]), " (KSATMIN)")), 0x30, "Parameter error");
                                                        return false;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                short num = (GlobalVariables.sw_crop <= MACROConstants.Switch.BareSoil) ? 2 : 3;
                                                short row = 1;
                                                AxMSFlexGrid grid = frmParameters._flx_Parameters_4;
                                                short num9 = num;
                                                short num8 = (short) (GlobalVariables.Nhorizon * num);
                                                num3 = 1;
                                                while (true)
                                                {
                                                    num12 = (short) ((num9 >> 15) ^ num8);
                                                    if (((num9 >> 15) ^ num3) <= num12)
                                                    {
                                                        bool flag;
                                                        short num5;
                                                        float num6;
                                                        if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                                                        {
                                                            num6 = (float) Conversions.ToDouble(grid.get_TextMatrix(row, 5));
                                                            num5 = 1;
                                                        }
                                                        else
                                                        {
                                                            num6 = (float) Conversions.ToDouble(grid.get_TextMatrix(row, 4));
                                                            num5 = 0;
                                                        }
                                                        if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[(short) (num3 + num5)], 0, false), Operators.CompareObjectGreater(Value[(short) (num3 + num5)], num6, false))))
                                                        {
                                                            float num4;
                                                            if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                                                            {
                                                                num4 = Conversions.ToSingle(Value[num3 + 1]);
                                                                num6 = Conversions.ToSingle(Value[num3 - 1]);
                                                                if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[num3], num4, false), Operators.CompareObjectGreater(Value[num3], num6, false))))
                                                                {
                                                                    MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter WILT = ", Value[num3]), " out of valid range for horizon "), row), '\r'), "Valid range: "), num4), " <= WILT <= "), num6)), 0x30, "Parameter error");
                                                                    return false;
                                                                }
                                                            }
                                                            num6 = (float) Conversions.ToDouble(grid.get_TextMatrix(row, 3));
                                                            num4 = Conversions.ToSingle(Value[num3]);
                                                            if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLessEqual(Value[num3 - 1], num4, false), Operators.CompareObjectGreaterEqual(Value[num3 - 1], num6, false))))
                                                            {
                                                                row = (short) (row + 1);
                                                                num3 = (short) (num3 + num9);
                                                                continue;
                                                            }
                                                            MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter XMPOR = ", Value[num3 - 1]), " out of valid range for horizon "), row), '\r'), "Valid range: "), num4), " < XMPOR < "), num6)), 0x30, "Parameter error");
                                                            flag = false;
                                                        }
                                                        else
                                                        {
                                                            MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter RESID = ", Value[(short) (num3 + num5)]), " out of valid range for horizon "), row), '\r'), "Valid range: 0"), " <= RESID <= "), num6)), 0x30, "Parameter error");
                                                            flag = false;
                                                        }
                                                        return flag;
                                                    }
                                                    else
                                                    {
                                                        grid = null;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        else if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[Information.LBound(Value, 1)], 0, false), Operators.CompareObjectGreater(Value[Information.LBound(Value, 1)], Value[Information.LBound(Value, 1) + 1], false))))
                                        {
                                            if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[Information.LBound(Value, 1) + 2], Value[Information.LBound(Value, 1) + 1], false), Operators.CompareObjectGreater(Value[Information.LBound(Value, 1) + 2], 0x16d, false))))
                                            {
                                                if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[Information.LBound(Value, 1) + 1], Value[Information.LBound(Value, 1)], false), Operators.CompareObjectGreater(Value[Information.LBound(Value, 1) + 1], Value[Information.LBound(Value, 1) + 2], false))))
                                                {
                                                    MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter IDMAX out of valid range.\rValid range: ", Value[Information.LBound(Value, 1)]), " <= IDMAX <= "), Value[Information.LBound(Value, 1) + 2])), 0x30, "Parameter error");
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter IHARV out of valid range.\rValid range: ", Value[Information.LBound(Value, 1) + 1]), " <= IDMAX <= 365")), 0x30, "Parameter error");
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject("Parameter ZDATEMIN out of valid range.\rValid range: 1 <= ZDATEMIN <= ", Value[Information.LBound(Value, 1) + 1])), 0x30, "Parameter error");
                                            return false;
                                        }
                                    }
                                    else if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                                    {
                                        short num7 = (short) (GlobalVariables.Nhorizon - 1);
                                        num3 = 0;
                                        while (true)
                                        {
                                            num12 = num7;
                                            if (num3 > num12)
                                            {
                                                break;
                                            }
                                            if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[num3], 0, false), Operators.CompareObjectGreater(Value[num3], 0.9 * Conversions.ToDouble(frmParameters._flx_Parameters_4.get_TextMatrix((1 + num3) - Information.LBound(VarName, 1), 5)), false))))
                                            {
                                                num3 = (short) (num3 + 1);
                                                continue;
                                            }
                                            MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter AEXC = ", Value[num3]), " out of valid range for at least one layer."), '\r'), "Valid range: 0 "), "<= AEXC <= "), 0.9 * Conversions.ToDouble(frmParameters._flx_Parameters_4.get_TextMatrix((1 + num3) - Information.LBound(VarName, 1), 5))), " (0.9*WILT)")), 0x30, "Parameter error");
                                            return false;
                                        }
                                    }
                                }
                                else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[0], 0.01, false), Operators.CompareObjectGreater(Value[0], GlobalVariables.CropValue, false))))
                                {
                                    MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter LAIHAR = ", Value[0]), " out of valid range."), '\r'), "Valid range: 0 <= LAIHAR <= "), GlobalVariables.CropValue)), 0x30, "Parameter error");
                                    return false;
                                }
                            }
                            else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[0], 0, false), Operators.CompareObjectGreater(Value[0], GlobalVariables.CropValue, false))))
                            {
                                MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter LAIMIN = ", Value[0]), " out of valid range."), '\r'), "Valid range: 0 <= LAIMIN <= "), GlobalVariables.CropValue)), 0x30, "Parameter error");
                                return false;
                            }
                        }
                        else if ((GlobalVariables.sw_evaporate != MACROConstants.Switch.BareSoil) && Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[0], 0, false), Operators.CompareObjectGreater(Value[0], GlobalVariables.CropValue, false))))
                        {
                            MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter ZHMIN = ", Value[0]), " out of valid range."), '\r'), "Valid range: 0 <= ZHMIN <= "), GlobalVariables.CropValue)), 0x30, "Parameter error");
                            return false;
                        }
                    }
                    else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[0], 0, false), Operators.CompareObjectGreater(Value[0], GlobalVariables.CropValue, false))))
                    {
                        MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Parameter ROOTINIT = ", Value[0]), " out of valid range."), '\r'), "Valid range: 0 <= ROOTINIT <= "), GlobalVariables.CropValue)), 0x30, "Parameter error");
                        return false;
                    }
                }
            }
            else if (GlobalVariables.sw_boundary == MACROConstants.Switch.Perennial)
            {
            }
            return true;
        }

        public static bool CheckCrop(ref CfrmMain frmMain)
        {
            bool flag;
            string[] varName = new string[(0x12 * (frmMain.frmParameters._flx_Parameters_0.Rows - 1)) + 1];
            object[] objArray2 = new object[(0x12 * (frmMain.frmParameters._flx_Parameters_0.Rows - 1)) + 1];
            object[] objArray = new object[2];
            string[] strArray = new string[2];
            AxMSFlexGrid grid = frmMain.frmParameters._flx_Parameters_0;
            strArray = new string[(grid.Rows * 10) + 1];
            objArray = new object[(grid.Rows * 10) + 1];
            short num6 = (short) (grid.Rows - 1);
            short row = 1;
            while (true)
            {
                short num3;
                short num10 = num6;
                if (row <= num10)
                {
                    if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                    {
                        short num4;
                        varName[num3] = "IDSTART";
                        objArray2[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, 2));
                        num3 = (short) (num3 + 1);
                        strArray[num4] = "ZDATEMIN";
                        objArray[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, 4));
                        num4 = (short) (num4 + 1);
                        strArray[num4] = "IDMAX";
                        objArray[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, 5));
                        num4 = (short) (num4 + 1);
                        strArray[num4] = "IHARV";
                        objArray[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, 6));
                        num4 = (short) (num4 + 1);
                        short num5 = 4;
                        if (GlobalVariables.ncrop[row] == 2)
                        {
                            varName[num3] = "IDSTART2";
                            objArray2[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, 8));
                            num3 = (short) (num3 + 1);
                            varName[num3] = "ZDATEMIN2";
                            objArray2[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, 9));
                            num3 = (short) (num3 + 1);
                            varName[num3] = "IDMAX2";
                            objArray2[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, 10));
                            num3 = (short) (num3 + 1);
                            varName[num3] = "IHARV2";
                            objArray2[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, 11));
                            num3 = (short) (num3 + 1);
                            num5 = 8;
                        }
                        AxMSFlexGrid grid2 = frmMain.frmParameters._flx_Parameters_0;
                        varName[num3] = "CFORM";
                        objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                        num3 = (short) (num3 + 1);
                        num5 = (short) (num5 + 1);
                        varName[num3] = "DFORM";
                        objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                        num3 = (short) (num3 + 1);
                        num5 = (short) (num5 + 1);
                        varName[num3] = "RPIN";
                        objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                        num3 = (short) (num3 + 1);
                        num5 = (short) (num5 + 1);
                        varName[num3] = "FAWC";
                        objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                        num3 = (short) (num3 + 1);
                        num5 = (short) (num5 + 1);
                        varName[num3] = "CRITAIR";
                        objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                        num3 = (short) (num3 + 1);
                        num5 = (short) (num5 + 1);
                        varName[num3] = "BETA";
                        objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                        num3 = (short) (num3 + 1);
                        num5 = (short) (num5 + 1);
                        varName[num3] = "CANCAP";
                        objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                        num3 = (short) (num3 + 1);
                        num5 = (short) (num5 + 1);
                        varName[num3] = "ZALP";
                        objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                        num3 = (short) (num3 + 1);
                        num5 = (short) (num5 + 1);
                        if (GlobalVariables.sw_evaporate == MACROConstants.Switch.Annual)
                        {
                            varName[num3] = "ATTEN";
                            objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                            num3 = (short) (num3 + 1);
                            num5 = (short) (num5 + 1);
                            varName[num3] = "RSMIN";
                            objArray2[num3] = Conversions.ToDouble(grid2.get_TextMatrix(row, num5 + 4));
                            num3 = (short) (num3 + 1);
                            num5 = (short) (num5 + 1);
                        }
                        grid2 = null;
                    }
                    row = (short) (row + 1);
                    continue;
                }
                if (GlobalVariables.sw_crop > MACROConstants.Switch.Annual)
                {
                    AxMSFlexGrid grid3 = frmMain.frmParameters._flx_Parameters_0;
                    short num7 = (short) (grid3.Rows - 1);
                    row = 1;
                    while (true)
                    {
                        num10 = num7;
                        if (row > num10)
                        {
                            grid3 = null;
                            break;
                        }
                        varName[num3] = "RPIN";
                        objArray2[num3] = Conversions.ToDouble(grid3.get_TextMatrix(row, 2));
                        num3 = (short) (num3 + 1);
                        varName[num3] = "FAWC";
                        objArray2[num3] = Conversions.ToDouble(grid3.get_TextMatrix(row, 3));
                        num3 = (short) (num3 + 1);
                        varName[num3] = "CRITAIR";
                        objArray2[num3] = Conversions.ToDouble(grid3.get_TextMatrix(row, 4));
                        num3 = (short) (num3 + 1);
                        varName[num3] = "BETA";
                        objArray2[num3] = Conversions.ToDouble(grid3.get_TextMatrix(row, 5));
                        num3 = (short) (num3 + 1);
                        varName[num3] = "CANCAP";
                        objArray2[num3] = Conversions.ToDouble(grid3.get_TextMatrix(row, 6));
                        num3 = (short) (num3 + 1);
                        varName[num3] = "ZALP";
                        objArray2[num3] = Conversions.ToDouble(grid3.get_TextMatrix(row, 7));
                        num3 = (short) (num3 + 1);
                        if (GlobalVariables.sw_evaporate == MACROConstants.Switch.Annual)
                        {
                            varName[num3] = "ATTEN";
                            objArray2[num3] = Conversions.ToDouble(grid3.get_TextMatrix(row, 8));
                            num3 = (short) (num3 + 1);
                            varName[num3] = "RSURF";
                            objArray2[num3] = Conversions.ToDouble(grid3.get_TextMatrix(row, 9));
                            num3 = (short) (num3 + 1);
                        }
                        row = (short) (row + 1);
                    }
                }
                if (CheckVariable(ref strArray, ref objArray, ref frmMain))
                {
                    short num = 0;
                    if (GlobalVariables.sw_crop == MACROConstants.Switch.Perennial)
                    {
                        short num8 = (short) (frmMain.frmParameters._flx_Parameters_0.Rows - 2);
                        row = 0;
                        while (true)
                        {
                            num10 = num8;
                            if (row > num10)
                            {
                                break;
                            }
                            num = (short) (num + 1);
                            varName[num3] = "ROOTDEP";
                            objArray2[num3] = GlobalVariables.CropDevelopment3[row];
                            num3 = (short) (num3 + 1);
                            varName[num3] = "LAIC";
                            objArray2[num3] = GlobalVariables.CropDevelopment3[row + 1];
                            num3 = (short) (num3 + 1);
                            varName[num3] = "HCROP";
                            objArray2[num3] = GlobalVariables.CropDevelopment3[row + 2];
                            num3 = (short) (num3 + 1);
                            row = (short) (row + 1);
                        }
                    }
                    if (GlobalVariables.sw_crop == MACROConstants.Switch.Annual)
                    {
                        short num9 = (short) (Information.UBound(GlobalVariables.CropDevelopment2, 1) - 1);
                        row = 0;
                        while (true)
                        {
                            num10 = num9;
                            if (row > num10)
                            {
                                break;
                            }
                            num = (short) (num + 1);
                            strArray[0] = "ROOTINIT";
                            objArray[0] = GlobalVariables.CropDevelopment2[row];
                            GlobalVariables.CropValue = GlobalVariables.CropDevelopment2[row + 1];
                            if (!CheckVariable(ref strArray, ref objArray, ref frmMain))
                            {
                                flag = false;
                            }
                            else
                            {
                                varName[num3] = "ROOTMAX";
                                objArray2[num3] = GlobalVariables.CropDevelopment2[row + 1];
                                num3 = (short) (num3 + 1);
                                varName[num3] = "ROOTMAX";
                                objArray2[num3] = GlobalVariables.CropDevelopment2[row + 2];
                                strArray[0] = "LAIMIN";
                                objArray[0] = GlobalVariables.CropDevelopment2[row + 3];
                                GlobalVariables.CropValue = GlobalVariables.CropDevelopment2[row + 4];
                                if (!CheckVariable(ref strArray, ref objArray, ref frmMain))
                                {
                                    flag = false;
                                }
                                else
                                {
                                    varName[num3] = "LAIMAX";
                                    objArray2[num3] = GlobalVariables.CropDevelopment2[row + 4];
                                    num3 = (short) (num3 + 1);
                                    strArray[0] = "LAIHAR";
                                    objArray[0] = GlobalVariables.CropDevelopment2[row + 5];
                                    GlobalVariables.CropValue = GlobalVariables.CropDevelopment2[row + 4];
                                    if (!CheckVariable(ref strArray, ref objArray, ref frmMain))
                                    {
                                        flag = false;
                                    }
                                    else
                                    {
                                        strArray[0] = "ZHMIN";
                                        objArray[0] = GlobalVariables.CropDevelopment2[row + 6];
                                        GlobalVariables.CropValue = GlobalVariables.CropDevelopment2[row + 7];
                                        if (CheckVariable(ref strArray, ref objArray, ref frmMain))
                                        {
                                            if (GlobalVariables.sw_evaporate != MACROConstants.Switch.BareSoil)
                                            {
                                                varName[num3] = "HMAX";
                                                objArray2[num3] = GlobalVariables.CropDevelopment2[row + 7];
                                                num3 = (short) (num3 + 1);
                                            }
                                            row = (short) (row + 9);
                                            continue;
                                        }
                                        flag = false;
                                    }
                                }
                            }
                            return flag;
                        }
                    }
                    grid = null;
                    flag = CheckVariable(ref varName, ref objArray2, ref frmMain);
                }
                else
                {
                    flag = false;
                }
                break;
            }
            return flag;
        }

        public static bool CheckIBCond(ref CfrmMain frmMain)
        {
            bool flag;
            short num3;
            short num4;
            object[] objArray;
            string[] strArray;
            AxMSFlexGrid grid;
            short num5;
            short num7;
            short num9;
            short col = -1;
            if ((GlobalVariables.sw_vartension != MACROConstants.Switch.BareSoil) || !((Strings.Len(frmMain.frmParameters.txtTensionFile.Text) == 0) | (frmMain.frmParameters.txtTensionFile.Text == "(none)")))
            {
                grid = frmMain.frmParameters.flx_Parameters[2];
                strArray = new string[GlobalVariables.TotPhys_layer + 1];
                objArray = new object[GlobalVariables.TotPhys_layer + 1];
                num5 = (short) (grid.Cols - 1);
                col = (short) grid.FixedCols;
            }
            else
            {
                MiscFUncs.MsgBox_Renamed("Please specify a file with the variable bottom boundary", 0x30, "Error");
                return false;
            }
            while (true)
            {
                if (col <= num5)
                {
                    grid.Col = col;
                    short num6 = GlobalVariables.TotPhys_layer;
                    num3 = 1;
                    while (true)
                    {
                        num9 = num6;
                        if (num3 <= num9)
                        {
                            grid.Row = num3;
                            strArray[num4] = grid.get_TextMatrix(0, col);
                            objArray[num4] = Conversions.ToDouble(grid.Text);
                            num4 = (short) (num4 + 1);
                            num3 = (short) (num3 + 1);
                            continue;
                        }
                        if (CheckVariable(ref strArray, ref objArray, ref frmMain))
                        {
                            num4 = 0;
                            col = (short) (col + 1);
                            continue;
                        }
                        else
                        {
                            flag = false;
                        }
                        break;
                    }
                    return flag;
                }
                else
                {
                    col = -1;
                    strArray = new string[(GlobalVariables.num_boundary + 2) + 1];
                    objArray = new object[(GlobalVariables.num_boundary + 2) + 1];
                    num7 = GlobalVariables.num_boundary;
                    col = 0;
                }
                break;
            }
            goto TR_001A;
        TR_0006:
            if (GlobalVariables.sw_vartension == MACROConstants.Switch.NoMetabolite)
            {
                objArray[num4] = Conversions.ToDouble(frmMain.frmParameters.text1[col].Text);
                num4 = (short) (num4 + 1);
            }
            Label label = null;
            col = (short) (col + 1);
        TR_001A:
            while (true)
            {
                if (col > num7)
                {
                    grid = null;
                    flag = CheckVariable(ref strArray, ref objArray, ref frmMain);
                    break;
                }
                label = frmMain.frmParameters.Label1[col];
                if (label.Text != "BGRAD")
                {
                    if (label.Text != "GRAD")
                    {
                        if (GlobalVariables.sw_vartension == MACROConstants.Switch.NoMetabolite)
                        {
                            strArray[num4] = label.Text;
                        }
                    }
                    else
                    {
                        strArray[num4] = "GRAD";
                        if (Conversions.ToDouble(frmMain.frmParameters.text1[col].Text) < 0.0)
                        {
                            MiscFUncs.MsgBox_Renamed("Parameter GRAD out of valid range:\rValid range: GRAD > 0", 0x30, "Error");
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    strArray[num4] = "GWFLUX";
                    short cols = (short) frmMain.frmParameters._flx_Parameters_4.Cols;
                    num3 = 1;
                    while (true)
                    {
                        short num2;
                        num9 = cols;
                        if (num3 <= num9)
                        {
                            frmMain.frmParameters._flx_Parameters_4.Row = 0;
                            if (frmMain.frmParameters._flx_Parameters_4.get_TextMatrix(0, num3 - 1) == "KSATMIN")
                            {
                                num2 = num3;
                            }
                            num3 = (short) (num3 + 1);
                            continue;
                        }
                        if (!((Conversions.ToDouble(frmMain.frmParameters.text1[col].Text) < 0.0) | (Conversions.ToDouble(frmMain.frmParameters.text1[col].Text) > (Conversions.ToDouble(frmMain.frmParameters._flx_Parameters_4.get_TextMatrix(frmMain.frmParameters._flx_Parameters_4.Rows - 1, num2 - 1)) / (Conversions.ToDouble(frmMain.frmParameters._flx_Parameters_4.get_TextMatrix(frmMain.frmParameters._flx_Parameters_4.Rows - 1, 2)) * 10.0)))))
                        {
                            goto TR_0006;
                        }
                        else
                        {
                            MiscFUncs.MsgBox_Renamed("Parameter BGRAD out of valid range:\rValid range: 0 < BGRAD < " + Conversions.ToString((double) (Conversions.ToDouble(frmMain.frmParameters._flx_Parameters_4.get_TextMatrix(frmMain.frmParameters._flx_Parameters_4.Rows - 1, num2)) / (Conversions.ToDouble(frmMain.frmParameters._flx_Parameters_4.get_TextMatrix(frmMain.frmParameters._flx_Parameters_4.Rows - 1, 2)) * 10.0))), 0x30, "Error");
                            flag = false;
                        }
                        break;
                    }
                    break;
                }
                goto TR_0006;
            }
            return flag;
        }

        public static bool CheckIrrigation(ref CfrmMain frmMain, ref bool CheckSubSets = true)
        {
            // Invalid method body.
        }

        public static bool CheckManagement(ref CfrmMain frmMain)
        {
            string[] varName = new string[((int) Math.Round((double) ((Convert.ToDouble(frmMain.frmParameters.txtNMan.Value) * 11.0) + 9.0))) + 1];
            object[] objArray2 = new object[((int) Math.Round((double) ((Convert.ToDouble(frmMain.frmParameters.txtNMan.Value) * 11.0) + 9.0))) + 1];
            string[] strArray = new string[Convert.ToInt32(frmMain.frmParameters.txtNMan.Value) + 1];
            object[] objArray = new object[Convert.ToInt32(frmMain.frmParameters.txtNMan.Value) + 1];
            short index = 1;
            short num2 = 1;
            CfrmParameters frmParameters = frmMain.frmParameters;
            short num4 = (short) (frmParameters.txtMan.Count() - 1);
            short num = 0;
            while (true)
            {
                short num6 = num4;
                if (num > num6)
                {
                    bool flag;
                    short num5 = (short) Math.Round((double) (Convert.ToDouble(frmParameters.txtNMan.Value) - 1.0));
                    num = 0;
                    while (true)
                    {
                        num6 = num5;
                        if (num > num6)
                        {
                            CfrmParameters parameters2 = frmMain.frmParameters;
                            num2 = (short) (num2 + 1);
                            varName[num2] = "I_ASCALE";
                            objArray2[num2] = Conversions.ToDouble(parameters2.txtMan[13].Text);
                            num2 = (short) (num2 + 1);
                            objArray2[num2] = Conversions.ToDouble(parameters2.txtMan[12].Text);
                            varName[num2] = "CONS_STA";
                            parameters2 = null;
                            if (!CheckVariable(ref strArray, ref objArray, ref frmMain))
                            {
                                flag = false;
                            }
                            else
                            {
                                CfrmParameters parameters3 = frmMain.frmParameters;
                                if (Conversions.ToDouble(parameters3.txtMan[0].Text) > GlobalVariables.gamma[1])
                                {
                                    MiscFUncs.MsgBox_Renamed("Parameter GAMMA_TILLED out of range. Valid range:\r0 < GAMMA_TILLED <= GAMMA(1) (" + Conversions.ToString(GlobalVariables.gamma[1]) + ")", 0x30, "Error");
                                    flag = false;
                                }
                                else if ((Conversions.ToDouble(parameters3.txtMan[2].Text) < GlobalVariables.zn[1]) | (Conversions.ToDouble(parameters3.txtMan[2].Text) > 7.0))
                                {
                                    MiscFUncs.MsgBox_Renamed("Parameterr ZN_TILLED out of range. Valid range:\rZN(1) (" + Conversions.ToString(GlobalVariables.zn[1]) + ") < ZN_TILLED <= 7", 0x30, "Error");
                                    flag = false;
                                }
                                else if ((Conversions.ToDouble(parameters3.txtMan[6].Text) < GlobalVariables.ksm[1]) | (Conversions.ToDouble(parameters3.txtMan[6].Text) > GlobalVariables.ksatmin[1]))
                                {
                                    MiscFUncs.MsgBox_Renamed("Parameter KSM_TILLED out of range. Valid range:\rKSM(1) (" + Conversions.ToString(GlobalVariables.ksm[1]) + ") < KSM_TILLED < KSATMIN(1) (" + Conversions.ToString(GlobalVariables.ksatmin[1]) + ")", 0x30, "Error");
                                    flag = false;
                                }
                                else
                                {
                                    if (GlobalVariables.sw_crust == MACROConstants.Switch.BareSoil)
                                    {
                                        if (Conversions.ToDouble(parameters3.txtMan[8].Text) < GlobalVariables.gamma[1])
                                        {
                                            MiscFUncs.MsgBox_Renamed("Parameter GAMMA_SEAL out of range. Valid range:\rGAMMA(1) (" + Conversions.ToString(GlobalVariables.gamma[1]) + ") < GAMMA_SEAL ", 0x30, "Error");
                                            flag = false;
                                            break;
                                        }
                                        if (Conversions.ToDouble(parameters3.txtMan[9].Text) > GlobalVariables.zn[1])
                                        {
                                            MiscFUncs.MsgBox_Renamed("Parameter ZN_SEAL out of range. Valid range:\r2 <= ZN_SEAL <= ZN(1) (" + Conversions.ToString(GlobalVariables.zn[1]) + ")", 0x30, "Error");
                                            flag = false;
                                            break;
                                        }
                                        if (Conversions.ToDouble(parameters3.txtMan[10].Text) > GlobalVariables.xmpor[1])
                                        {
                                            MiscFUncs.MsgBox_Renamed("Parameter XMPOR_SEAL out of range. Valid range:\rXMPOR_SEAL <= XMPOR(1) (" + Conversions.ToString(GlobalVariables.xmpor[1]) + ")", 0x30, "Error");
                                            flag = false;
                                            break;
                                        }
                                        if (Conversions.ToDouble(parameters3.txtMan[11].Text) > GlobalVariables.ksm[1])
                                        {
                                            MiscFUncs.MsgBox_Renamed("Parameter KSM_SEAL out of range. Valid range:\rKSM_SEAL <= KSM(1) (" + Conversions.ToString(GlobalVariables.ksm[1]) + ")", 0x30, "Error");
                                            flag = false;
                                            break;
                                        }
                                    }
                                    parameters3 = null;
                                    frmParameters = null;
                                    flag = CheckVariable(ref varName, ref objArray2, ref frmMain);
                                }
                            }
                            break;
                        }
                        AxMSFlexGrid grid = frmMain.frmParameters._flx_Parameters_6;
                        objArray2[num2] = Conversions.ToDouble(grid.get_TextMatrix(num + 1, 1));
                        varName[num2] = "TILL_DAY";
                        num2 = (short) (num2 + 1);
                        objArray[index] = Conversions.ToDouble(grid.get_TextMatrix(num + 1, 2));
                        strArray[index] = "TILL_LAY";
                        index = (short) (index + 1);
                        objArray2[num2] = Conversions.ToDouble(grid.get_TextMatrix(num + 1, 3));
                        varName[num2] = "TILL_INT";
                        num2 = (short) (num2 + 1);
                        objArray2[num2] = Conversions.ToDouble(grid.get_TextMatrix(num + 1, 4));
                        varName[num2] = "T_ASCALE";
                        num2 = (short) (num2 + 1);
                        objArray2[num2] = Conversions.ToDouble(grid.get_TextMatrix(num + 1, 5));
                        varName[num2] = "TILLCONS";
                        grid = null;
                        num = (short) (num + 1);
                    }
                    return flag;
                }
                varName[num + 1] = frmParameters.lblMan[num].Text;
                objArray2[num + 1] = Conversions.ToDouble(frmParameters.txtMan[num].Text);
                num2 = (short) (num2 + 1);
                num = (short) (num + 1);
            }
        }

        public static bool CheckNumerical(CfrmParameters frmParameters)
        {
            short totalLayers = GlobalVariables.TotalLayers;
            short row = 1;
            while (true)
            {
                short num3 = totalLayers;
                if (row > num3)
                {
                    if (frmParameters.ComputeDifference())
                    {
                        MiscFUncs.MsgBox_Renamed("The sum of the layers is not equal to the horizon thickness ", 0x30, "Parameter error");
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                {
                    if (Conversions.ToDouble(frmParameters._flx_Parameters_7.get_TextMatrix(row, 2)) != 0.0)
                    {
                        row = (short) (row + 1);
                        continue;
                    }
                    MiscFUncs.MsgBox_Renamed("Numerical layer " + Conversions.ToString((int) row) + " equal or less than 0", 0x30, "Parameter error");
                }
                return true;
            }
        }

        public static bool CheckPhysicalParameters(ref CfrmMain frmMain)
        {
            object[] objArray3 = new object[(0x11 * GlobalVariables.TotPhys_layer) + 1];
            string[] varName = new string[0xab];
            string[] strArray = new string[0x1f];
            object[] objArray = new object[0x1f];
            string[] strArray2 = new string[0x15];
            object[] objArray2 = new object[0x15];
            AxMSFlexGrid grid = frmMain.frmParameters._flx_Parameters_4;
            short nhorizon = GlobalVariables.Nhorizon;
            short row = 1;
            while (true)
            {
                short num3;
                short num4;
                short num5;
                short num7 = nhorizon;
                if (row > num7)
                {
                    grid = null;
                    return (CheckVariable(ref strArray, ref objArray, ref frmMain) ? (CheckVariable(ref strArray2, ref objArray2, ref frmMain) ? CheckVariable(ref varName, ref objArray3, ref frmMain) : false) : false);
                }
                short col = 5;
                varName[num3] = "TPORV";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, 3));
                num3 = (short) (num3 + 1);
                strArray[num4] = "XMPOR";
                objArray[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, 4));
                num3 = (short) (num3 + 1);
                num4 = (short) (num4 + 1);
                if (GlobalVariables.sw_crop > MACROConstants.Switch.BareSoil)
                {
                    strArray[num4] = "WILT";
                    objArray[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                    num4 = (short) (num4 + 1);
                    col = (short) (col + 1);
                }
                strArray[num4] = "RESID";
                objArray[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num4 = (short) (num4 + 1);
                col = (short) (col + 1);
                varName[num3] = "GAMMA";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                varName[num3] = "CTEN";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                varName[num3] = "ZLAMB";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                strArray2[num5] = "KSATMIN";
                objArray2[num5] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num5 = (short) (num5 + 1);
                col = (short) (col + 1);
                strArray2[num5] = "KSM";
                objArray2[num5] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num5 = (short) (num5 + 1);
                col = (short) (col + 1);
                varName[num3] = "ZN";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                varName[num3] = "ZM";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                varName[num3] = "ZP";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                varName[num3] = "ZA";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                varName[num3] = "ASCALE";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                if (GlobalVariables.sw_hysteres == MACROConstants.Switch.Annual)
                {
                    varName[num3] = "SCALEPSI";
                    objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                    num3 = (short) (num3 + 1);
                    col = (short) (col + 1);
                }
                if (GlobalVariables.sw_hydraulic == MACROConstants.Switch.BareSoil)
                {
                    varName[num3] = "SCALEVG";
                    objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                    num3 = (short) (num3 + 1);
                    col = (short) (col + 1);
                }
                varName[num3] = "TRAP_AIR";
                objArray3[num3] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                num3 = (short) (num3 + 1);
                col = (short) (col + 1);
                row = (short) (row + 1);
            }
        }

        public static bool CheckSite(ref CfrmMain frmMain)
        {
            object[] objArray = new object[15];
            string[] varName = new string[15];
            CfrmParameters frmParameters = frmMain.frmParameters;
            short index = 0;
            while (true)
            {
                TextBox txt = frmParameters.Text4[index];
                if (MiscFUncs.Numeric(ref txt))
                {
                    index = (short) (index + 1);
                    short num2 = 6;
                    if (index <= num2)
                    {
                        continue;
                    }
                    objArray[0] = Conversions.ToDouble(frmParameters.Text4[0].Text);
                    varName[0] = "ANNTAV";
                    objArray[1] = Conversions.ToDouble(frmParameters.Text4[1].Text);
                    varName[1] = "ANNAMP";
                    objArray[2] = Conversions.ToDouble(frmParameters.Text4[2].Text);
                    varName[2] = "RAINCO";
                    objArray[3] = Conversions.ToDouble(frmParameters.Text4[3].Text);
                    varName[3] = "SNOWCO";
                    objArray[4] = Conversions.ToDouble(frmParameters.Text4[4].Text);
                    varName[4] = "SNOWMF";
                    objArray[5] = Conversions.ToDouble(frmParameters.Text4[5].Text);
                    varName[5] = "DWRL";
                    objArray[6] = Conversions.ToDouble(frmParameters.Text4[6].Text);
                    varName[6] = "PHI";
                    index = 6;
                    if (GlobalVariables.sw_rainfall == MACROConstants.Switch.BareSoil)
                    {
                        index = (short) (index + 1);
                        if (!MiscFUncs.Numeric(ref frmParameters.Text4[index]))
                        {
                            break;
                        }
                        objArray[index] = Conversions.ToDouble(frmParameters.Text4[index].Text);
                        varName[index] = "RINTEN";
                    }
                    if (GlobalVariables.sw_boundary == MACROConstants.Switch.Perennial)
                    {
                        index = (short) (index + 1);
                        if (!MiscFUncs.Numeric(ref frmParameters.Text4[index]))
                        {
                            break;
                        }
                        objArray[index] = Conversions.ToDouble(frmParameters.Text4[index].Text);
                        varName[index] = "LAYERD";
                    }
                    if (GlobalVariables.sw_evaporate == MACROConstants.Switch.Annual)
                    {
                        index = (short) (index + 1);
                        if (!MiscFUncs.Numeric(ref frmParameters.Text4[index]))
                        {
                            break;
                        }
                        objArray[index] = frmParameters.Text4[index].Text;
                        varName[index] = "ALBEDO";
                        index = (short) (index + 1);
                        if (!MiscFUncs.Numeric(ref frmParameters.Text4[index]))
                        {
                            break;
                        }
                        objArray[index] = frmParameters.Text4[index].Text;
                        varName[index] = "ZMET";
                    }
                    if (((GlobalVariables.sw_boundary > MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_boundary < MACROConstants.Switch.Tritium)) & (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil))
                    {
                        index = (short) (index + 1);
                        if (!MiscFUncs.Numeric(ref frmParameters.Text4[index]))
                        {
                            break;
                        }
                        objArray[index] = Conversions.ToDouble(frmParameters.Text4[index].Text);
                        varName[index] = "RGWFLOW";
                    }
                    if (GlobalVariables.sw_tiledrain == MACROConstants.Switch.BareSoil)
                    {
                        index = (short) (index + 1);
                        if (!MiscFUncs.Numeric(ref frmParameters.Text4[index]))
                        {
                            break;
                        }
                        objArray[index] = Conversions.ToDouble(frmParameters.Text4[index].Text);
                        varName[index] = "DRAINDEP";
                        index = (short) (index + 1);
                        if (!MiscFUncs.Numeric(ref frmParameters.Text4[index]))
                        {
                            break;
                        }
                        objArray[index] = Conversions.ToDouble(frmParameters.Text4[index].Text);
                        varName[index] = "SPACE";
                    }
                    frmParameters = null;
                }
                break;
            }
            return CheckVariable(ref varName, ref objArray, ref frmMain);
        }

        public static bool CheckSolute(ref CfrmMain frmMain)
        {
            bool flag;
            if (GlobalVariables.sw_solute <= MACROConstants.Switch.BareSoil)
            {
                flag = true;
            }
            else
            {
                object[] objArray2 = new object[((9 * GlobalVariables.TotalLayers) + 12) + 1];
                string[] varName = new string[((9 * GlobalVariables.TotalLayers) + 12) + 1];
                object[] objArray = new object[GlobalVariables.TotalLayers + 1];
                string[] strArray = new string[GlobalVariables.TotalLayers + 1];
                short row = -1;
                short num6 = 0;
                CfrmParameters frmParameters = frmMain.frmParameters;
                short num8 = (short) (frmParameters.cmbParameters.Items.Count - 1);
                row = 0;
                while (true)
                {
                    short num11 = num8;
                    if (row > num11)
                    {
                        if (CheckConditional(ref varName, ref objArray2, frmMain.frmParameters))
                        {
                            short num9 = (short) (frmParameters.cmbParameters.Items.Count - 1);
                            row = 0;
                            while (true)
                            {
                                short num4;
                                num11 = num9;
                                if (row > num11)
                                {
                                    frmParameters = null;
                                    short col = 2;
                                    AxMSFlexGrid grid = frmMain.frmParameters._flx_Parameters_5;
                                    short nhorizon = GlobalVariables.Nhorizon;
                                    row = 1;
                                    while (true)
                                    {
                                        num11 = nhorizon;
                                        if (row > num11)
                                        {
                                            grid = null;
                                            flag = CheckVariable(ref strArray, ref objArray, ref frmMain) ? CheckVariable(ref varName, ref objArray2, ref frmMain) : false;
                                            break;
                                        }
                                        col = 2;
                                        if (GlobalVariables.sw_immobile == MACROConstants.Switch.Perennial)
                                        {
                                            col = (short) (col + 1);
                                            varName[num4] = "FMOBILE";
                                            objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                            num4 = (short) (num4 + 1);
                                        }
                                        if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) | ((GlobalVariables.sw_solute == MACROConstants.Switch.Perennial) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)))
                                        {
                                            short num5;
                                            col = (short) (col + 1);
                                            strArray[num5] = "AEXC";
                                            objArray[num5] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                            num5 = (short) (num5 + 1);
                                        }
                                        if ((GlobalVariables.sw_solute == MACROConstants.Switch.Annual) & (GlobalVariables.sw_colloid == MACROConstants.Switch.BareSoil))
                                        {
                                            col = (short) (col + 1);
                                            varName[num4] = "PSEXC";
                                            objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                            num4 = (short) (num4 + 1);
                                        }
                                        if (((GlobalVariables.sw_immobile > MACROConstants.Switch.BareSoil) & (GlobalVariables.sw_solute > MACROConstants.Switch.BareSoil)) & (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite))
                                        {
                                            col = (short) (col + 1);
                                            varName[num4] = "APLHA";
                                            objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                            num4 = (short) (num4 + 1);
                                        }
                                        if (GlobalVariables.sw_solute == MACROConstants.Switch.Annual)
                                        {
                                            col = (short) (col + 1);
                                            varName[num4] = "ZKD";
                                            objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                            num4 = (short) (num4 + 1);
                                            if (GlobalVariables.sw_colloid == MACROConstants.Switch.NoMetabolite)
                                            {
                                                col = (short) (col + 1);
                                                varName[num4] = "DEGMIL";
                                                objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                                num4 = (short) (num4 + 1);
                                                col = (short) (col + 1);
                                                varName[num4] = "DEGMAL";
                                                objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                                num4 = (short) (num4 + 1);
                                                col = (short) (col + 1);
                                                varName[num4] = "DEGMIS";
                                                objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                                num4 = (short) (num4 + 1);
                                                col = (short) (col + 1);
                                                varName[num4] = "DEGMAS";
                                                objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, col));
                                                num4 = (short) (num4 + 1);
                                                varName[num4] = "FREUND";
                                                objArray2[num4] = Conversions.ToDouble(grid.get_TextMatrix(row, (short) (col + 1)));
                                                num4 = (short) (num4 + 1);
                                            }
                                        }
                                        row = (short) (row + 1);
                                    }
                                    break;
                                }
                                if (Support.GetItemString(frmParameters.cmbParameters, row) != "ZMIX")
                                {
                                    if ((GlobalVariables.sw_immobile > MACROConstants.Switch.NoMetabolite) & (row > 4))
                                    {
                                        num6 = 1;
                                    }
                                    varName[num4] = Support.GetItemString(frmParameters.cmbParameters, row);
                                    objArray2[num4] = Conversions.ToDouble(frmParameters.text12[(short) (row + num6)].Text);
                                    num4 = (short) (num4 + 1);
                                }
                                row = (short) (row + 1);
                            }
                        }
                        break;
                    }
                    if (Support.GetItemString(frmParameters.cmbParameters, row) == "ZMIX")
                    {
                        if (Conversions.ToDouble(frmParameters.text12[row].Text) > (GlobalVariables.Z[1] * 10f))
                        {
                            MiscFUncs.MsgBox_Renamed("ZMIX out of range. Valid range:\r" + Conversions.ToString(0) + " < ZMIX =< " + Conversions.ToString((float) (GlobalVariables.Z[1] * 10f)), 0x30, "Error");
                            break;
                        }
                        varName[0] = "ZMIX";
                        objArray2[0] = Conversions.ToDouble(frmParameters.text12[row].Text);
                    }
                    row = (short) (row + 1);
                }
            }
            return flag;
        }

        private static bool CheckVariable(ref string[] VarName, ref object[] Value, ref CfrmMain frmMain)
        {
            bool flag;
            string right = "";
            Recordset recordset = new RecordsetClass();
            Recordset recordset2 = recordset;
            short num2 = (short) Information.UBound(VarName, 1);
            short index = (short) Information.LBound(VarName, 1);
            while (true)
            {
                short num3 = num2;
                if (index > num3)
                {
                    recordset2 = null;
                    flag = true;
                    break;
                }
                recordset2.Open("select * from [ParameterLimits] where VarName='" + VarName[index] + "'", frmMain.DatabaseConnection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
                bool flag2 = recordset.RecordCount > 0;
                if (flag2 && Operators.ConditionalCompareObjectEqual(recordset2[]["ErrorRange"][], true, false))
                {
                    if (Operators.ConditionalCompareObjectEqual(recordset2[]["Conditional"][], true, false))
                    {
                        flag = CheckConditional(ref VarName, ref Value, frmMain.frmParameters);
                        break;
                    }
                    if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectLess(Value[index], Conversions.ToDouble(recordset2[]["Lower"][]), false), Operators.AndObject(Operators.CompareObjectEqual(Value[index], Conversions.ToDouble(recordset2[]["Lower"][]), false), Operators.NotObject(recordset2[]["EqLower"][]))), Operators.CompareObjectGreater(Value[index], Conversions.ToDouble(recordset2[]["Upper"][]), false)), Operators.AndObject(Operators.CompareObjectEqual(Value[index], Conversions.ToDouble(recordset2[]["Upper"][]), false), Operators.NotObject(recordset2[]["EqUpper"][])))))
                    {
                        string str = !Conversions.ToBoolean(recordset2[]["EqLower"][]) ? "<" : "<=";
                        string str2 = !Conversions.ToBoolean(recordset2[]["EqUpper"][]) ? "<" : "<=";
                        right = VarName[index];
                        if (right == "ZLAMB")
                        {
                            right = "N";
                        }
                        MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Variable " + right + "=", Value[index]), " out of range."), '\r'), "Valid range: "), recordset2[]["Lower"][]), " "), str), " "), right), " "), str2), " "), recordset2[]["Upper"][])), 0x30, "Parameter error");
                        flag = false;
                        break;
                    }
                    if (Operators.ConditionalCompareObjectEqual(recordset2[]["Warning"][], true, false) && Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Value[index], recordset2[]["LowerWarning"][], false), Operators.CompareObjectGreater(Value[index], recordset2[]["UpperWarning"][], false))))
                    {
                        MiscFUncs.MsgBox_Renamed(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Variable " + right + "=", Value[index]), " out of recommended range."), '\r'), "Recommended range: "), recordset2[]["LowerWarning"][]), " "), "<"), " "), right), " "), "<"), " "), recordset2[]["UpperWarning"][])), 0x30, "Warning");
                    }
                }
                recordset.Close();
                index = (short) (index + 1);
            }
            return flag;
        }

        private static byte ColorID(ref int n)
        {
            byte num;
            int num2 = n;
            if (num2 == 0x8000)
            {
                num = 2;
            }
            else if (num2 == 0)
            {
                num = 0;
            }
            else if (num2 == 0xff)
            {
                num = 3;
            }
            return num;
        }
    }
}

