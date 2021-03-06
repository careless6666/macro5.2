﻿namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Runtime.InteropServices;

    [StandardModule]
    internal sealed class GlobalVariables
    {
        public static int[] YearsForIHARV;
        public static int[] YearsForIDSTART;
        public static string SetupDrive;
        public static float Koc;
        public static string OutputFileDir;
        public static short[,,] m_StrataScore;
        public static object[,] LayOutputs;
        public static short C_MINUTESTOWAIT;
        public static short C_DELAY;
        public static short C_HARVESTDAYINDEX;
        public static short C_IDTSTARTINDEX;
        public static short m_Harvestday;
        public static bool bFirst;
        public static bool b_DefaultNaming;
        public static string MACROOutputFile;
        public static short IrrYears;
        public static bool b_Executing;
        public static short N_NUMERICAL_LAYERS;
        public static string[] pname;
        public static short[] FirstPos;
        public static float CropValue;
        public static string OutputPath;
        public static string DatabaseName;
        public static string SUFIDatabaseName;
        public static int ExeId;
        public static int IDExecute;
        public static int[] IrrigationYear;
        public static bool b_irrsame;
        public static string[,] Chapar;
        public static short NUM_OUTPX1;
        public static short NUM_OUTPT1;
        public static short NUM_OUTPG1;
        public static short NUM_OUTPD1;
        public static short[] grddata_col;
        public static short[] grddata_row;
        public static float[] gamma = new float[0x43];
        public static object soilnamn;
        public static float tref;
        public static float[] zn = new float[0x43];
        public static short Nhorizon;
        public static string location;
        public static float[] beta = new float[0x43];
        public static float[] cancap = new float[0x43];
        public static float[] cform = new float[0x43];
        public static float[] dform = new float[0x43];
        public static short[] idstart = new short[0x43];
        public static short[] idmax = new short[0x43];
        public static short[] iharv = new short[0x43];
        public static float[] laimax = new float[0x43];
        public static float[] laihar = new float[0x43];
        public static float[] rootmax = new float[0x43];
        public static float[] rpin = new float[0x43];
        public static float[] zalp = new float[0x43];
        public static float[] fawc = new float[0x43];
        public static float[] hmax = new float[0x43];
        public static float[] atten = new float[0x43];
        public static float[] rsmax = new float[0x43];
        public static float[] rsmin = new float[0x43];
        public static float[] ascale = new float[0x43];
        public static float tav;
        public static float amp;
        public static float annamp;
        public static float anntav;
        public static string stp;
        public static float profiledepth;
        public static object[] thickness = new object[11];
        public static float[] laimin = new float[0x3d];
        public static float[] waten = new float[11];
        public static float[] cten = new float[11];
        public static float[] xmpor = new float[11];
        public static float[] tporv = new float[11];
        public static float[] wilt = new float[11];
        public static float[] ksatmin = new float[11];
        public static float[] ksm = new float[11];
        public static float[] vg_N = new float[11];
        public static float[] stone = new float[11];
        public static float[] bd = new float[7];
        public static float[] nstar = new float[7];
        public static float[] deg = new float[7];
        public static float[] kd = new float[7];
        public static float tresp;
        public static float expb;
        public static float fext;
        public static float fracmac;
        public static float[] deff = new float[7];
        public static short choice;
        public static short nskikt;
        public static string[] cropname = new string[0x43];
        public static short[] zdatemin = new short[0x43];
        public static float drainspace;
        public static float[] rootinit = new float[0x43];
        public static float[] zhmin = new float[0x43];
        public static float draindep;
        public static short boundary;
        public static float[] laic = new float[0x43];
        public static float[] rootdep = new float[0x43];
        public static float[] hcrop = new float[0x43];
        public static float[] rsurf = new float[0x43];
        public static short oldvalue;
        public static float dgw;
        public static float es;
        public static float[] fs = new float[7];
        public static short[] missing = new short[7];
        public static string riskass;
        public static float[] ri50 = new float[0x43];
        public static short[] ri50_c = new short[0x43];
        public static float[] vpd50 = new float[0x43];
        public static short[] vpd50_c = new short[0x43];
        public static float zmix;
        public static short irrigate;
        public static short icycle;
        public static short driving;
        public static short solute;
        public static short colloid;
        public static short tiledrain;
        public static short initial;
        public static short crop;
        public static short[] till_day;
        public static float[] till_int;
        public static int[] till_day_c;
        public static int[] till_int_c;
        public static float gamma_ch;
        public static short[] till_lay;
        public static int gamma_ch_c;
        public static int[] till_lay_c;
        public static float halfrain;
        public static int halfrain_c;
        public static float macp_ch;
        public static float macd_ch;
        public static int macp_ch_c;
        public static int macd_ch_c;
        public static float[] trap_air = new float[11];
        public static short[] trap_air_c = new short[11];
        public static float[] t_ascale;
        public static float[] tillcons;
        public static int[] t_ascale_c;
        public static int[] tillcons_c;
        public static float cons_sta;
        public static int cons_sta_c;
        public static float i_ascale;
        public static int i_ascale_c;
        public static short NTILL;
        public static float znseal;
        public static float gammaseal;
        public static float ksmseal;
        public static float xmporseal;
        public static int znseal_c;
        public static int gammaseal_c;
        public static int ksmseal_c;
        public static int xmporseal_c;
        public static int ProjectIDno;
        public static string project_name;
        public static int RunIDno;
        public static short Re_place;
        public static string Project_dscrpt;
        public static string Run_dscrpt;
        public static string Modified_date;
        public static string Run_name;
        public static bool New_Project;
        public static MACROConstants.Switch sw_averagex;
        public static MACROConstants.Switch sw_averaget;
        public static MACROConstants.Switch sw_averageg;
        public static MACROConstants.Switch sw_averaged;
        public static MACROConstants.Switch sw_outforn;
        public static MACROConstants.Switch sw_instate;
        public static MACROConstants.Switch sw_outstate;
        public static MACROConstants.Switch sw_drivpg;
        public static MACROConstants.Switch sw_lisallv;
        public static MACROConstants.Switch sw_chapar;
        public static MACROConstants.Switch sw_addsim;
        public static MACROConstants.Switch sw_validpg;
        public static MACROConstants.Switch sw_solute;
        public static MACROConstants.Switch sw_rainfall;
        public static MACROConstants.Switch sw_nitrate;
        public static MACROConstants.Switch sw_irrigate;
        public static MACROConstants.Switch sw_crop;
        public static MACROConstants.Switch sw_tiledrain;
        public static MACROConstants.Switch sw_boundary;
        public static MACROConstants.Switch sw_initial;
        public static MACROConstants.Switch sw_evaporate;
        public static MACROConstants.Switch sw_driving;
        public static MACROConstants.Switch sw_metabolite;
        public static MACROConstants.Switch sw_colloid;
        public static MACROConstants.Switch sw_immobile;
        public static MACROConstants.Switch sw_massunits;
        public static MACROConstants.Switch sw_hysteres;
        public static MACROConstants.Switch sw_hydraulic;
        public static MACROConstants.Switch sw_icycle;
        public static MACROConstants.Switch sw_upstream;
        public static MACROConstants.Switch sw_degkin;
        public static MACROConstants.Switch sw_tempini;
        public static MACROConstants.Switch sw_vartension;
        public static MACROConstants.Switch sw_landuse;
        public static MACROConstants.Switch sw_toxswa;
        public static MACROConstants.Switch sw_crust;
        public static MACROConstants.Switch sw_management;
        public static MACROConstants.Switch sw_kinetic;
        public static MACROConstants.Switch sw_specout;
        public static string TensionFile;
        public static string DateFile;
        public static float Area;
        public static float bgrad;
        public static float boten;
        public static float gwflux;
        public static float concin;
        public static float partinit;
        public static short bgrad_c;
        public static short area_c;
        public static short boten_c;
        public static short gwflux_c;
        public static short concin_c;
        public static short partinit_c;
        public static float[] tempini = new float[0xc9];
        public static float[] thetaini = new float[0xc9];
        public static float[] solinit = new float[0xc9];
        public static short[] tempini_c = new short[0xc9];
        public static short[] thetaini_c = new short[0xc9];
        public static short[] solinit_c = new short[0xc9];
        public static float[] Zthick = new float[0xc9];
        public static float[] Hthick = new float[11];
        public static short[] N_Layer = new short[11];
        public static short TotalLayers;
        public static short[,] Groups;
        public static string[] designat = new string[11];
        public static float snowco;
        public static float rainco;
        public static float rgwflow;
        public static float dwrl;
        public static float snowmf;
        public static float rinten;
        public static float albedo;
        public static float layerd;
        public static float zmet;
        public static float phi;
        public static float s_pace;
        public static float[] resid = new float[11];
        public static float[] zm = new float[11];
        public static float[] zp = new float[11];
        public static float[] za = new float[11];
        public static float[] scalepsi = new float[11];
        public static double[] vg_alpha = new double[11];
        public static short TotPhys_layer;
        public static short[] Phys_layer = new short[0xc9];
        public static float[,] amir;
        public static float[,] irrstart;
        public static float[,] irrend;
        public static float[] nirr = new float[0xc9];
        public static float critdef;
        public static short[,] irrig_no;
        public static float[,] z_fint;
        public static float[,] i_rrday;
        public static float[,] c_onci;
        public static short Nlayer;
        public static float sorp_rate;
        public static short sorp_rate_c;
        public static float frac_eq;
        public static short frac_eq_c;
        public static float d_iff;
        public static float pmax;
        public static float dv;
        public static float fstar;
        public static float genkd;
        public static float conc;
        public static float pf1;
        public static float frack;
        public static float[] a_lpha = new float[11];
        public static float pf2;
        public static float[] fmobile = new float[11];
        public static float[] aexc = new float[11];
        public static float[] psexc = new float[11];
        public static float vref;
        public static float settle;
        public static float refilter;
        public static float filtermi;
        public static float replen;
        public static float candeg;
        public static float gravit;
        public static float zkdpc;
        public static float[] zkd = new float[11];
        public static float[] degmil = new float[11];
        public static float[] degmal = new float[11];
        public static float[] degmis = new float[11];
        public static float[] degmas = new float[11];
        public static float f_convert;
        public static short[] freund_c = new short[11];
        public static float[] f_reund = new float[11];
        public static float[] critair = new float[0x43];
        public static short[] Y_ear = new short[0x43];
        public static short NumOfYears;
        public static short[] ncrop = new short[0x43];
        public static short[] idstart2 = new short[0x43];
        public static short[] idmax2 = new short[0x43];
        public static short[] iharv2 = new short[0x43];
        public static short[] zdatemin2 = new short[0x43];
        public static short outintd;
        public static short outintm;
        public static string Met_file;
        public static string Rainfall_file;
        public static string Driving_file;
        public static string MetPeriod;
        public static string RainfallPeriod;
        public static string DrivingPeriod;
        public static float[] sand = new float[11];
        public static float[] pH = new float[11];
        public static float[] silt = new float[11];
        public static float[] clay = new float[11];
        public static string[] structur = new string[11];
        public static float[] bulk = new float[11];
        public static float[] orgc = new float[11];
        public static string[] Texture = new string[11];
        public static string profilnamn;
        public static string latitude;
        public static string landusage;
        public static string classify;
        public static float s_i;
        public static float s_a;
        public static float c_l;
        public static float[] Z = new float[0xc9];
        public static short[] xmpor_c = new short[11];
        public static short[] tporv_c = new short[11];
        public static short[] wilt_c = new short[11];
        public static short[] gamma_c = new short[11];
        public static short[] resid_c = new short[11];
        public static short[] cten_c = new short[11];
        public static short[] zlamb_c = new short[11];
        public static short[] ksatmin_c = new short[11];
        public static short[] ksm_c = new short[11];
        public static short[] zn_c = new short[11];
        public static short[] zm_c = new short[11];
        public static short[] zp_c = new short[11];
        public static short[] za_c = new short[11];
        public static short[] ascale_c = new short[11];
        public static short[] scalepsi_c = new short[11];
        public static short[] scalevg_c = new short[11];
        public static short dv_c;
        public static short diff_c;
        public static short pmax_c;
        public static short fracmac_c;
        public static short fstar_c;
        public static short candeg_c;
        public static short zmix_c;
        public static short fext_c;
        public static short zkdpc_c;
        public static short expb_c;
        public static short conc_c;
        public static short tresp_c;
        public static short genkd_c;
        public static short tref_c;
        public static short fconvert_c;
        public static short pf2_c;
        public static short pf1_c;
        public static short frack_c;
        public static short vref_c;
        public static short settle_c;
        public static short refilter_c;
        public static short filtermi_c;
        public static short replen_c;
        public static short gravit_c;
        public static float[] waten_c = new float[11];
        public static short[] alpha_c = new short[11];
        public static short[] zkd_c = new short[11];
        public static short[] degmil_c = new short[11];
        public static short[] degmal_c = new short[11];
        public static short[] degmas_c = new short[11];
        public static short[] degmis_c = new short[11];
        public static short[] fmobile_c = new short[11];
        public static short[] aexc_c = new short[11];
        public static short[] psexc_c = new short[11];
        public static short annamp_c;
        public static short albedo_c;
        public static short anntav_c;
        public static short dwrl_c;
        public static short draindep_c;
        public static short layerd_c;
        public static short space_c;
        public static short rainco_c;
        public static short phi_c;
        public static short rinten_c;
        public static short rgwflow_c;
        public static short snowco_c;
        public static short snowmf_c;
        public static short zmet_c;
        public static short[] nirr_c = new short[0xc9];
        public static short critdef_c;
        public static short[] amir_c = new short[0x65];
        public static short[] conci_c = new short[0x65];
        public static short[] irrstart_c = new short[0x65];
        public static short[] irrend_c = new short[0x65];
        public static short[] irrday_c = new short[0x65];
        public static short[] zfint_c = new short[0x65];
        public static short[] z_c = new short[0xc9];
        public static short[] rootinit_c = new short[0x3d];
        public static short[] rootmax_c = new short[0x3d];
        public static short[] rootdep_c = new short[0x3d];
        public static short[] cform_c = new short[0x3d];
        public static short[] rpin_c = new short[0x3d];
        public static short[] fawc_c = new short[0x3d];
        public static short[] critair_c = new short[0x3d];
        public static short[] beta_c = new short[0x3d];
        public static short[] cancap_c = new short[0x3d];
        public static short[] zalp_c = new short[0x3d];
        public static short[] idstart_c = new short[0x3d];
        public static short[] idmax_c = new short[0x3d];
        public static short[] iharv_c = new short[0x3d];
        public static short[] zhmin_c = new short[0x3d];
        public static short[] laic_c = new short[0x3d];
        public static short[] laimin_c = new short[0x3d];
        public static short[] laimax_c = new short[0x3d];
        public static short[] zdatemin_c = new short[0x3d];
        public static short[] dform_c = new short[0x3d];
        public static short[] laihar_c = new short[0x3d];
        public static short[] hmax_c = new short[0x3d];
        public static short[] rsmin_c = new short[0x3d];
        public static short[] atten_c = new short[0x3d];
        public static short[] hcrop_c = new short[0x3d];
        public static short[] rsurf_c = new short[0x3d];
        public static short[] idstart2_c = new short[0x3d];
        public static short[] zdatemin2_c = new short[0x3d];
        public static short[] idmax2_c = new short[0x3d];
        public static short[] iharv2_c = new short[0x3d];
        public static float[] CropDevelopment2;
        public static float[] CropDevelopment3;
        public static short num_boundary;
        public static Collection SelectedVariables = new Collection();
        public static Collection SelectedMeasured = new Collection();
        public static double NumberOfSelectedOutputs;
        public static string OutputFileName;
        public static float ksmtille;
        public static float halfcrus;
        public static float cruststa;
        public static float dummy;
        public static int ksmtille_c;
        public static int halfcrus_c;
        public static int cruststa_c;
        public static int dummy_c;
        public static o_p1[] outpx1;
        public static o_p1[] outpt1;
        public static o_p1[] outpg1;
        public static o_p1[] outpd1;
        public static o_p2[] outpx2;
        public static o_p2[] outpg2;
        public static o_p2[] outpd2;
        public static short warning1;
        public static short[] laysum = new short[0x15];
        public static string AppDrive;

        [StructLayout(LayoutKind.Sequential)]
        public struct o_p1
        {
            public string var;
            public short sl;
            public short enabled;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct o_p2
        {
            public string var;
            public short l1;
            public short l2;
            public short sl;
            public short enabled;
        }
    }
}

