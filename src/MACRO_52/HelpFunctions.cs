namespace MACRO_52
{
    using MACRO_52.My.Resources;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Windows.Forms;

    [StandardModule]
    internal sealed class HelpFunctions
    {
        public static void HELP_Crop1(ref string str_Renamed, ref Label box)
        {
            Label label = box;
            string str = str_Renamed;
            label.Text = (str != "IDSTART") ? ((str != "ZDATEMIN") ? ((str != "IDMAX") ? ((str != "IHARV") ? ((str != "ROOTDEP") ? ((str != "LEAF") ? ((str != "CFORM") ? ((str != "DFORM") ? ((str != "RPIN") ? ((str != "FAWC") ? ((str != "CRITAIR") ? ((str != "BETA") ? ((str != "CANCAP") ? ((str != "ZALP") ? ((str != "ATTEN") ? ((str != "RSMIN") ? ((str != "RSURF") ? ((str != "HEIGHT") ? ((str != "ROOTINIT") ? ((str != "ROOTMAX") ? ((str != "LAIMIN") ? ((str != "LAIMAX") ? ((str != "LAIHAR") ? ((str != "ZHMIN") ? ((str != "HMAX") ? ((str != "RI50") ? ((str != "VPD50") ? "" : MACRO_52.My.Resources.Resources.Help_VPD50) : MACRO_52.My.Resources.Resources.Help_RI50) : MACRO_52.My.Resources.Resources.Help_HMAX) : MACRO_52.My.Resources.Resources.Help_ZHMIN) : MACRO_52.My.Resources.Resources.Help_LAIHAR) : MACRO_52.My.Resources.Resources.Help_LAIMAX) : MACRO_52.My.Resources.Resources.Help_LAIMIN) : MACRO_52.My.Resources.Resources.Help_ROOTMAX) : MACRO_52.My.Resources.Resources.Help_ROOTINIT) : MACRO_52.My.Resources.Resources.Help_HCROP) : MACRO_52.My.Resources.Resources.Help_RSURF) : MACRO_52.My.Resources.Resources.Help_RSMIN) : MACRO_52.My.Resources.Resources.Help_ATTEN) : MACRO_52.My.Resources.Resources.Help_ZALP) : MACRO_52.My.Resources.Resources.Help_CANCAP) : MACRO_52.My.Resources.Resources.Help_BETA) : MACRO_52.My.Resources.Resources.Help_CRITAIR) : MACRO_52.My.Resources.Resources.Help_FAWC) : MACRO_52.My.Resources.Resources.Help_RPIN) : MACRO_52.My.Resources.Resources.Help_DFORM) : MACRO_52.My.Resources.Resources.Help_CFORM) : MACRO_52.My.Resources.Resources.Help_LAIC) : MACRO_52.My.Resources.Resources.Help_ROOTDEP) : MACRO_52.My.Resources.Resources.Help_IHARV) : MACRO_52.My.Resources.Resources.Help_IDMAX) : MACRO_52.My.Resources.Resources.Help_ZDATEMIN) : MACRO_52.My.Resources.Resources.Help_IDSTART;
            label = null;
        }

        public static void HELP_CropDev2(ref short index, ref Label box)
        {
            string str = "";
            switch (index)
            {
                case 0:
                    str = "ROOTINIT";
                    break;

                case 1:
                    str = "ROOTMAX";
                    break;

                case 2:
                    str = "ROOTMAX";
                    break;

                case 3:
                    str = "LAIMIN";
                    break;

                case 4:
                    str = "LAIMAX";
                    break;

                case 5:
                    str = "LAIHAR";
                    break;

                case 6:
                    str = "ZHMIN";
                    break;

                case 7:
                    str = "HMAX";
                    break;

                case 8:
                    str = "HMAX";
                    break;

                default:
                    break;
            }
            HELP_Crop1(ref str, ref box);
        }

        public static void HELP_CropDev3(ref short index, ref Label box)
        {
            string str = "";
            switch (index)
            {
                case 0:
                    str = "ROOTDEP";
                    break;

                case 1:
                    str = "LEAF";
                    break;

                case 2:
                    str = "HEIGHT";
                    break;

                default:
                    break;
            }
            HELP_Crop1(ref str, ref box);
        }

        public static void Help_IBcond(ref string v_tx, ref Label box)
        {
            Label label = box;
            string str = v_tx;
            if (str == "TEMPINI")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_TEMPINI;
            }
            else if (str == "THETAINI")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_THETAINI;
            }
            else if (str == "SOLINIT")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_SOLINIT;
            }
            else if (str == "cons_sta")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_CONS_STA;
            }
            else if (str == "i_ascale")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_I_ASCALE;
            }
            else if (str == "GRAD")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_GRAD;
            }
            else if (str == "CONCIN")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_CONCIN;
            }
            else if (str == "AREA")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_AREA;
            }
            else if (str == "BGRAD")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_BGRAD;
            }
            else if (str == "BOTEN")
            {
                label.Text = (GlobalVariables.sw_vartension != MACROConstants.Switch.NoMetabolite) ? MACRO_52.My.Resources.Resources.Help_BOTEN2 : MACRO_52.My.Resources.Resources.Help_BOTEN1;
            }
            else if (str == "PARTINIT")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_PARTINIT;
            }
            else if (str == "CONSOL_STATE")
            {
                label.Text = "";
            }
            else if (str == "INIT_ASCALE")
            {
                label.Text = "";
            }
            else
            {
                box.Text = "";
            }
            label = null;
        }

        public static void HELP_Irr(ref string str_Renamed, ref Label box)
        {
            Label label = box;
            string str = str_Renamed;
            label.Text = (str != "IRRDAY") ? ((str != "AMIR") ? ((str != "IRRSTART") ? ((str != "IRREND") ? ((str != "ZFINT") ? ((str != "CONCI") ? "" : MACRO_52.My.Resources.Resources.Help_CONCI) : MACRO_52.My.Resources.Resources.Help_ZFINT) : MACRO_52.My.Resources.Resources.Help_IRREND) : MACRO_52.My.Resources.Resources.Help_IRRSTART) : MACRO_52.My.Resources.Resources.Help_AMIR) : MACRO_52.My.Resources.Resources.Help_IRRDAY;
            label = null;
        }

        public static void Help_Management(ref string str_Renamed, ref Label box)
        {
            Label label = box;
            string str = str_Renamed;
            label.Text = (str != "CONSOL_STATE") ? ((str != "INIT_ASCALE") ? ((str != "TILL_DAY") ? ((str != "TILL_LAY") ? ((str != "TILL_INT") ? ((str != "DIFFPATH_CHANGE") ? ((str != "XMPOR_TILLED") ? ((str != "ZN_TILLED") ? ((str != "GAMMA_TILLED") ? ((str != "XMPOR_SEAL") ? ((str != "ZN_SEAL") ? ((str != "GAMMA_SEAL") ? ((str != "HALFRAIN") ? ((str != "NTILL") ? ((str != "T_ASCALE") ? ((str != "TILLCONS") ? ((str != "HALFAMOUNT_SEAL") ? ((str != "SEAL_STATE") ? ((str != "KSM_TILLED") ? ((str != "KSM_SEAL") ? "" : MACRO_52.My.Resources.Resources.Help_KSM_SEAL) : MACRO_52.My.Resources.Resources.Help_KSM_TILLED) : MACRO_52.My.Resources.Resources.Help_CRUST_STATE) : MACRO_52.My.Resources.Resources.Help_HALFAMOUNT_CRUST) : MACRO_52.My.Resources.Resources.Help_TILLCONS) : MACRO_52.My.Resources.Resources.Help_T_ASCALE) : MACRO_52.My.Resources.Resources.Help_NTILL) : MACRO_52.My.Resources.Resources.Help_HALFRAIN) : MACRO_52.My.Resources.Resources.Help_GAMMA_SEAL) : MACRO_52.My.Resources.Resources.Help_ZN_SEAL) : MACRO_52.My.Resources.Resources.Help_XMPOR_SEAL) : MACRO_52.My.Resources.Resources.Help_GAMMA_TILLED) : MACRO_52.My.Resources.Resources.Help_ZN_TILLED) : MACRO_52.My.Resources.Resources.Help_XMPOR_TILLED) : MACRO_52.My.Resources.Resources.Help_DIFFPATH_CHANGE) : MACRO_52.My.Resources.Resources.Help_TILL_INT) : MACRO_52.My.Resources.Resources.Help_TILL_LAY) : MACRO_52.My.Resources.Resources.Help_TILL_DAY) : MACRO_52.My.Resources.Resources.Help_I_ASCALE) : MACRO_52.My.Resources.Resources.Help_CONS_STA;
            label = null;
        }

        public static void HELP_Numerical(ref string str_Renamed, ref Label box)
        {
            Label label = box;
            string str = str_Renamed;
            if (str == "Difference:")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_DIFFERENCE;
            }
            else if (str == "Thickness:")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_THICKNESS;
            }
            else if (str == "Layer number:")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_NUMBER;
            }
            else if (str == "Horizon:")
            {
                label.Text = MACRO_52.My.Resources.Resources.Help_DESIGNATION;
            }
            label = null;
        }

        public static void HELP_Output(ref string str_Renamed, ref Label box)
        {
            Label label = box;
            string str = str_Renamed;
            label.Text = (str != "ADMI_KIN") ? ((str != "THETA") ? ((str != "THETI") ? ((str != "THETT") ? ((str != "CPSI") ? ((str != "WOUT") ? ((str != "EXCHANGE") ? ((str != "THETAMA") ? ((str != "WFLOWOUT") ? ((str != "THETAM") ? ((str != "TEMP") ? ((str != "SOLMIC") ? ((str != "SOLMAC") ? ((str != "SFLOW") ? ((str != "SFLOWOUT") ? ((str != "SOLIMOB") ? ((str != "CEXCH") ? ((str != "GLOBAL") ? ((str != "TMAX") ? ((str != "TMIN") ? ((str != "TAV") ? ((str != "SMICIN") ? ((str != "SMACIN") ? ((str != "BOTFLOW") ? ((str != "DRAINCON") ? ((str != "GRCON") ? ((str != "DEGMIC") ? ((str != "DEGMAC") ? ((str != "PAM") ? ((str != "CAM") ? ((str != "PCAA") ? ((str != "ADMI") ? ((str != "ADMA") ? ((str != "PAMT") ? ((str != "CAMT") ? ((str != "SFDMI") ? ((str != "SFDMA") ? ((str != "SFSDMA") ? ((str != "SFSDMI") ? ((str != "SAMS") ? ((str != "COLCMI") ? ((str != "COLCMA") ? ((str != "ZAM") ? ((str != "TSOUT") ? ((str != "TSS") ? ((str != "SSS") ? ((str != "TSRUN") ? ((str != "TPAM") ? ((str != "TCAM") ? ((str != "GSINK") ? ((str != "DRAINLOS") ? ((str != "DSOLTOSS") ? ((str != "DSOLTMIC") ? ((str != "TSOLTMIC") ? ((str != "TADMI") ? ((str != "TADMA") ? ((str != "TDEG") ? ((str != "CFOUT") ? ((str != "ACFOUT") ? ((str != "TCOLLMA") ? ((str != "TCOLLMI") ? ((str != "CFDRAIN") ? ((str != "ACFDRAIN") ? ((str != "ACFDRS") ? ((str != "CFDRS") ? ((str != "TUPT") ? ((str != "SAMS") ? ((str != "CDEG") ? ((str != "ELOSS") ? ((str != "TDEC") ? ((str != "SSRAT") ? ((str != "SSTOT") ? ((str != "GENERATE") ? ((str != "PC") ? ((str != "TIMMOB") ? ((str != "ACCMELT") ? ((str != "PWT") ? ((str != "INFILMI") ? ((str != "INFILMA") ? ((str != "CINFIL") ? ((str != "TMPOR") ? ((str != "DRAINFLO") ? ((str != "DRAINMI") ? ((str != "ZUPTAKE") ? ((str != "RAIN") ? ((str != "RRNRAIN") ? ((str != "CETA") ? ((str != "EPOT") ? ((str != "CCEPOT") ? ((str != "TPRECIP") ? ((str != "TTPRECIP") ? ((str != "SRUNOFF") ? ((str != "WWW") ? ((str != "TRUNOFF") ? ((str != "TFLOWOUT") ? ((str != "TFLOW") ? ((str != "TSTOREMI") ? ((str != "TSTOREMA") ? ((str != "PSOIL") ? ((str != "CPSOIL") ? ((str != "ESOIL") ? ((str != "CESOIL") ? ((str != "CCET") ? ((str != "WATEREQ") ? ((str != "CCETA") ? ((str != "CRES") ? ((str != "UPT") ? ((str != "CUPT") ? ((str != "ETA") ? ((str != "WETACT") ? ((str != "CETC") ? ((str != "SSEEP") ? ((str != "TSEEP") ? ((str != "SEEPMI") ? ((str != "SEEPMIAC") ? ((str != "PRECIRR") ? ((str != "PRECIRA") ? ((str != "GSRAT") ? ((str != "GSTOT") ? "" : MACRO_52.My.Resources.Resources.Help_GSTOT) : MACRO_52.My.Resources.Resources.Help_GSRAT) : MACRO_52.My.Resources.Resources.Help_PRECIRA) : MACRO_52.My.Resources.Resources.Help_PRECIRR) : MACRO_52.My.Resources.Resources.Help_SEEPMIAC) : MACRO_52.My.Resources.Resources.Help_SEEPMI) : MACRO_52.My.Resources.Resources.Help_TSEEP) : MACRO_52.My.Resources.Resources.Help_SSEEP) : MACRO_52.My.Resources.Resources.Help_CETC) : MACRO_52.My.Resources.Resources.Help_WETACT) : MACRO_52.My.Resources.Resources.Help_ETA) : MACRO_52.My.Resources.Resources.Help_CUPT) : MACRO_52.My.Resources.Resources.Help_UPT) : MACRO_52.My.Resources.Resources.Help_CRES) : MACRO_52.My.Resources.Resources.Help_CCETA) : MACRO_52.My.Resources.Resources.Help_WATEREQ) : MACRO_52.My.Resources.Resources.Help_CCET) : MACRO_52.My.Resources.Resources.Help_CESOIL) : MACRO_52.My.Resources.Resources.Help_ESOIL) : MACRO_52.My.Resources.Resources.Help_CPSOIL) : MACRO_52.My.Resources.Resources.Help_PSOIL) : MACRO_52.My.Resources.Resources.Help_TSTOREMA) : MACRO_52.My.Resources.Resources.Help_TSTOREMI) : MACRO_52.My.Resources.Resources.Help_TFLOW) : MACRO_52.My.Resources.Resources.Help_TFLOWOUT) : MACRO_52.My.Resources.Resources.Help_TRUNOFF) : MACRO_52.My.Resources.Resources.Help_WWW) : MACRO_52.My.Resources.Resources.Help_SRUNOFF) : MACRO_52.My.Resources.Resources.Help_TTPRECIP) : MACRO_52.My.Resources.Resources.Help_TPRECIP) : MACRO_52.My.Resources.Resources.Help_CCEPOT) : MACRO_52.My.Resources.Resources.Help_EPOT) : MACRO_52.My.Resources.Resources.Help_CETA) : MACRO_52.My.Resources.Resources.Help_RRNRAIN) : MACRO_52.My.Resources.Resources.Help_RAIN) : MACRO_52.My.Resources.Resources.Help_ZUPTAKE) : MACRO_52.My.Resources.Resources.Help_DRAINMI) : MACRO_52.My.Resources.Resources.Help_DRAINFLO) : MACRO_52.My.Resources.Resources.Help_TMPOR) : MACRO_52.My.Resources.Resources.Help_CINFIL) : MACRO_52.My.Resources.Resources.Help_INFILMA) : MACRO_52.My.Resources.Resources.Help_INFILMI) : MACRO_52.My.Resources.Resources.Help_PWT) : MACRO_52.My.Resources.Resources.Help_ACCMELT) : MACRO_52.My.Resources.Resources.Help_TIMMOB) : MACRO_52.My.Resources.Resources.Help_PC) : MACRO_52.My.Resources.Resources.Help_GENERATE) : MACRO_52.My.Resources.Resources.Help_SSTOT) : MACRO_52.My.Resources.Resources.Help_SSRAT) : MACRO_52.My.Resources.Resources.Help_TDEC) : MACRO_52.My.Resources.Resources.Help_ELOSS) : MACRO_52.My.Resources.Resources.Help_CDEG) : MACRO_52.My.Resources.Resources.Help_SAMS) : MACRO_52.My.Resources.Resources.Help_TUPT) : MACRO_52.My.Resources.Resources.Help_CFDRS) : MACRO_52.My.Resources.Resources.Help_ACFDRS) : MACRO_52.My.Resources.Resources.Help_ACFDRAIN) : MACRO_52.My.Resources.Resources.Help_CFDRAIN) : MACRO_52.My.Resources.Resources.Help_TCOLLMI) : MACRO_52.My.Resources.Resources.Help_TCOLLMA) : MACRO_52.My.Resources.Resources.Help_ACFOUT) : MACRO_52.My.Resources.Resources.Help_CFOUT) : MACRO_52.My.Resources.Resources.Help_TDEG) : MACRO_52.My.Resources.Resources.Help_TADMA) : MACRO_52.My.Resources.Resources.Help_TADMI) : MACRO_52.My.Resources.Resources.Help_TSOLTMIC) : MACRO_52.My.Resources.Resources.Help_DSOLTMIC) : MACRO_52.My.Resources.Resources.Help_DSOLTOSS) : MACRO_52.My.Resources.Resources.Help_DRAINLOS) : MACRO_52.My.Resources.Resources.Help_GSINK) : MACRO_52.My.Resources.Resources.Help_TCAM) : MACRO_52.My.Resources.Resources.Help_TPAM) : MACRO_52.My.Resources.Resources.Help_TSRUN) : MACRO_52.My.Resources.Resources.Help_SSS) : MACRO_52.My.Resources.Resources.Help_TSS) : MACRO_52.My.Resources.Resources.Help_TSOUT) : MACRO_52.My.Resources.Resources.Help_ZAM) : MACRO_52.My.Resources.Resources.Help_COLCMA) : MACRO_52.My.Resources.Resources.Help_COLCMI) : MACRO_52.My.Resources.Resources.Help_SAMS) : MACRO_52.My.Resources.Resources.Help_SFSDMI) : MACRO_52.My.Resources.Resources.Help_SFSDMA) : MACRO_52.My.Resources.Resources.Help_SFDMA) : MACRO_52.My.Resources.Resources.Help_SFDMI) : MACRO_52.My.Resources.Resources.Help_CAMT) : MACRO_52.My.Resources.Resources.Help_PAMT) : MACRO_52.My.Resources.Resources.Help_ADMA) : MACRO_52.My.Resources.Resources.Help_ADMI) : MACRO_52.My.Resources.Resources.Help_PCAA) : MACRO_52.My.Resources.Resources.Help_CAM) : MACRO_52.My.Resources.Resources.Help_PAM) : MACRO_52.My.Resources.Resources.Help_DEGMAC) : MACRO_52.My.Resources.Resources.Help_DEGMIC) : MACRO_52.My.Resources.Resources.Help_GRCON) : MACRO_52.My.Resources.Resources.Help_DRAINCON) : MACRO_52.My.Resources.Resources.Help_BOTFLOW) : MACRO_52.My.Resources.Resources.Help_SMACIN) : MACRO_52.My.Resources.Resources.Help_SMICIN) : MACRO_52.My.Resources.Resources.Help_TAV) : MACRO_52.My.Resources.Resources.Help_TMIN) : MACRO_52.My.Resources.Resources.Help_TMAX) : MACRO_52.My.Resources.Resources.Help_GLOBAL) : MACRO_52.My.Resources.Resources.Help_CEXCH) : MACRO_52.My.Resources.Resources.Help_SOLIMOB) : MACRO_52.My.Resources.Resources.Help_SFLOWOUT) : MACRO_52.My.Resources.Resources.Help_SFLOW) : MACRO_52.My.Resources.Resources.Help_SOLMAC) : MACRO_52.My.Resources.Resources.Help_SOLMIC) : MACRO_52.My.Resources.Resources.Help_TEMP) : MACRO_52.My.Resources.Resources.Help_THETAM) : MACRO_52.My.Resources.Resources.Help_WFLOWOUT) : MACRO_52.My.Resources.Resources.Help_THETAMA) : MACRO_52.My.Resources.Resources.Help_EXCHANGE) : MACRO_52.My.Resources.Resources.Help_WOUT) : MACRO_52.My.Resources.Resources.Help_CPSI) : MACRO_52.My.Resources.Resources.Help_THETT) : MACRO_52.My.Resources.Resources.Help_THETI) : MACRO_52.My.Resources.Resources.Help_THETA) : MACRO_52.My.Resources.Resources.Help_ADMI_KIN;
            label = null;
        }

        public static void Help_Physical(ref string v_n, ref Label box)
        {
            Label label = box;
            string str = v_n;
            label.Text = (str != "XMPOR") ? ((str != "TPORV") ? ((str != "WILT") ? ((str != "GAMMA") ? ((str != "RESID") ? ((str != "CTEN") ? ((str != "N") ? ((str != "KSATMIN") ? ((str != "KSM") ? ((str != "ZN") ? ((str != "ZM") ? ((str != "ZP") ? ((str != "ZA") ? ((str != "ASCALE") ? ((str != "ALPHA") ? ((str != "TRAP_AIR") ? ((str != "STONE") ? "" : MACRO_52.My.Resources.Resources.Help_STONE) : MACRO_52.My.Resources.Resources.Help_TRAP_AIR) : MACRO_52.My.Resources.Resources.Help_ALPHA) : MACRO_52.My.Resources.Resources.Help_ASCALE) : MACRO_52.My.Resources.Resources.Help_ZA) : MACRO_52.My.Resources.Resources.Help_ZP) : MACRO_52.My.Resources.Resources.Help_ZM) : MACRO_52.My.Resources.Resources.Help_ZN) : MACRO_52.My.Resources.Resources.Help_KSM) : MACRO_52.My.Resources.Resources.Help_KSATMIN) : MACRO_52.My.Resources.Resources.Help_N) : MACRO_52.My.Resources.Resources.Help_CTEN) : MACRO_52.My.Resources.Resources.Help_RESID) : MACRO_52.My.Resources.Resources.Help_GAMMA) : MACRO_52.My.Resources.Resources.Help_WILT) : MACRO_52.My.Resources.Resources.Help_TPORV) : MACRO_52.My.Resources.Resources.Help_XMPOR;
            label = null;
        }

        public static void HELP_Site(ref short index, ref Label box, ref string str_Renamed)
        {
            Label label = box;
            switch (index)
            {
                case 0:
                    label.Text = MACRO_52.My.Resources.Resources.Help_ANNTAV;
                    break;

                case 1:
                    label.Text = MACRO_52.My.Resources.Resources.Help_ANNAMP;
                    break;

                case 2:
                    label.Text = MACRO_52.My.Resources.Resources.Help_RAINCO;
                    break;

                case 3:
                    label.Text = MACRO_52.My.Resources.Resources.Help_SNOWCO;
                    break;

                case 4:
                    label.Text = MACRO_52.My.Resources.Resources.Help_SNOWMF;
                    break;

                case 5:
                    label.Text = MACRO_52.My.Resources.Resources.Help_DWRL;
                    break;

                case 6:
                    label.Text = MACRO_52.My.Resources.Resources.Help_PHI;
                    break;

                default:
                {
                    string str = str_Renamed;
                    label.Text = (str != "ANNTAV") ? ((str != "ANNAMP") ? ((str != "RAINCO") ? ((str != "SNOWCO") ? ((str != "SNOWMF") ? ((str != "DWRL\"") ? ((str != "PHI") ? ((str != "RINTEN") ? ((str != "LAYERD") ? ((str != "ALBEDO") ? ((str != "ZMET") ? ((str != "RGWFLOW") ? ((str != "DRAINDEP") ? ((str != "SPACE") ? "" : MACRO_52.My.Resources.Resources.Help_SPACE) : MACRO_52.My.Resources.Resources.Help_DRAINDEP) : MACRO_52.My.Resources.Resources.Help_RGWFLOW) : MACRO_52.My.Resources.Resources.Help_ZMET) : MACRO_52.My.Resources.Resources.Help_ALBEDO) : MACRO_52.My.Resources.Resources.Help_LAYERD) : MACRO_52.My.Resources.Resources.Help_RINTEN) : MACRO_52.My.Resources.Resources.Help_PHI) : MACRO_52.My.Resources.Resources.Help_DWRL) : MACRO_52.My.Resources.Resources.Help_SNOWMF) : MACRO_52.My.Resources.Resources.Help_SNOWCO) : MACRO_52.My.Resources.Resources.Help_RAINCO) : MACRO_52.My.Resources.Resources.Help_ANNAMP) : MACRO_52.My.Resources.Resources.Help_ANNTAV;
                    break;
                }
            }
            label = null;
        }

        public static void Help_Solute(ref string v_tx, ref Label box)
        {
            Label label = box;
            string str = v_tx;
            label.Text = (str != "PF1") ? ((str != "PF2") ? ((str != "PMAX") ? ((str != "GENKD") ? ((str != "VREF") ? ((str != "SETTLE") ? ((str != "FILTERMI") ? ((str != "REFILTER") ? ((str != "REPLEN") ? ((str != "ZMIX") ? ((str != "CONC") ? ((str != "DIFF") ? ((str != "DV") ? ((str != "FRACK") ? ((str != "FSTAR") ? ((str != "GRAVIT") ? ((str != "FRACMAC") ? ((str != "CANDEG") ? ((str != "FEXT") ? ((str != "ZKDPC") ? ((str != "EXPB") ? ((str != "TRESP") ? ((str != "TREF") ? ((str != "FCONVERT") ? ((str != "FREUND") ? ((str != "FMOBILE") ? ((str != "AEXC") ? ((str != "PSEXC") ? ((str != "ALPHA") ? ((str != "ZKD") ? ((str != "DEGMIL") ? ((str != "DEGMAL") ? ((str != "DEGMIS") ? ((str != "DEGMAS") ? ((str != "DEG") ? ((str != "SORP_RATE") ? ((str != "FRAC_KIN") ? ((str != "FRAC_EQ") ? "" : MACRO_52.My.Resources.Resources.Help_FRAC_EQ) : MACRO_52.My.Resources.Resources.Help_FRAQ_KIN) : MACRO_52.My.Resources.Resources.Help_SORP_RATE) : MACRO_52.My.Resources.Resources.Help_DEG) : MACRO_52.My.Resources.Resources.Help_DEGMAS) : MACRO_52.My.Resources.Resources.Help_DEGMIS) : MACRO_52.My.Resources.Resources.Help_DEGMAL) : MACRO_52.My.Resources.Resources.Help_DEGMIL) : MACRO_52.My.Resources.Resources.Help_ZKD) : "") : MACRO_52.My.Resources.Resources.Help_PSEXC) : MACRO_52.My.Resources.Resources.Help_AEXC) : MACRO_52.My.Resources.Resources.Help_FMOBILE) : MACRO_52.My.Resources.Resources.Help_FREUND) : MACRO_52.My.Resources.Resources.Help_FCONVERT) : MACRO_52.My.Resources.Resources.Help_TREF) : MACRO_52.My.Resources.Resources.Help_TRESP) : MACRO_52.My.Resources.Resources.Help_EXPB) : MACRO_52.My.Resources.Resources.Help_ZKDPC) : MACRO_52.My.Resources.Resources.Help_FEXT) : MACRO_52.My.Resources.Resources.Help_CANDEG) : MACRO_52.My.Resources.Resources.Help_FRACMAC) : "") : MACRO_52.My.Resources.Resources.Help_FSTAR) : MACRO_52.My.Resources.Resources.Help_FRACK) : MACRO_52.My.Resources.Resources.Help_DV) : MACRO_52.My.Resources.Resources.Help_DIFF) : MACRO_52.My.Resources.Resources.Help_CONC) : MACRO_52.My.Resources.Resources.Help_ZMIX) : "") : "") : MACRO_52.My.Resources.Resources.Help_FILTERMI) : "") : "") : "") : "") : MACRO_52.My.Resources.Resources.Help_PF2) : MACRO_52.My.Resources.Resources.Help_PF1;
            label = null;
        }
    }
}

