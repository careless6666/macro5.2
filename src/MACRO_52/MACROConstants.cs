namespace MACRO_52
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;

    [StandardModule]
    internal sealed class MACROConstants
    {
        public const string C_VERSION = "5.2";
        public const bool bFREUND = false;
        public const string NICK_MAIL = "Nick.Jarvis@mv.slu.se";
        public const string MACRO_PAGE = "http://bgf.mv.slu.se/macro";
        public const string C_SUFIFILEPREFIX = "iter";
        public const string C_SUFIFILEMIDFIX = "_";
        public const string C_MACROEXECUTABLE = "Macro52Model.exe";
        public const float C_MAXMIN = 0.59f;
        public const short MAX_PATH = 260;
        public const string C_SEALNAME = "seal";
        public const string C_SEALTHICKNESS = "0.3";
        public const short C_SIXTY = 60;
        public const short C_TEN = 10;
        public const short C_HUNDRED = 100;
        public const string C_COVARY = "covary";
        public const double MISSING_DATA = -1.1E+38;
        public const string C_SUFILOGFILENAME = "sufilog.txt";
        public const string C_MACROLOGFILE = @"\macro_log.txt";
        public const string C_PROGRESSFILE = @"\run_time.txt";
        public const string C_BINFILEFILTER = "bin files (*.bin)|*.bin";
        public const string C_TEXTFILEFILTER = "txt files (*.txt)|*.txt";
        public const string C_VARFILEFILTER = "fam files (*.fam)|*.fam";
        public const string C_SCIFORMAT = "0.0000E+00";
        public const string C_SGNFORMAT = "0.00000000E+00";
        public const string C_FAMFORMAT = "0.000000000000000000";
        public const string C_PARVARLOGFILE = @"\parvar.log";
        public const string C_BALANCEFILE = @"\balance.txt";
        public const float C_CT = 0.5f;
        public const string F_INDUMPFILE = "indump.tmp";

        public enum BioporeFrequency
        {
            Rare = 1,
            Abundant = 2,
            Common = 3
        }

        public enum ColorCoding
        {
            DefaultValue = 1,
            EditedValue = 2,
            Pedotransfer = 3
        }

        public enum Disaggregation
        {
            StartAbove = 1,
            StartBelow = 2,
            EnclosedAbove = 3,
            EnclosedBelow = 4,
            EndAbove = 5,
            EndBelow = 6,
            IsolatedAbove = 7,
            IsolatedBelow = 8
        }

        public enum FootprintPedotransferStep
        {
            Introduction = 1,
            LandUse = 2,
            AdditionalInput = 3,
            Finish = 4
        }

        public enum GridIndex
        {
            Crop,
            Crop2,
            IBCond,
            Irrigation,
            Physical,
            Solute,
            Management,
            Numerical,
            Numerical2
        }

        public enum MaxMin
        {
            TillageEvents = 10,
            MaxNumericalLayers = 200,
            MinNumericalLayers = 60,
            OutputLayers = 200,
            IrrigationEvents = 100,
            Horizons = 10,
            Strata = 100,
            SUFIInterval = 5
        }

        public enum NumberOfOutputs
        {
            G2 = 20,
            D2 = 0x15,
            X2 = 13,
            X1 = 7,
            T1 = 0x21,
            G1 = 9,
            D1 = 0x20
        }

        public enum OutputState
        {
            Selected = 1,
            Enabled = -1,
            Disabled = 0
        }

        public enum Switch
        {
            Annual = 2,
            BareSoil = 1,
            Perennial = 3,
            Metabolite = 1,
            NoMetabolite = 0,
            Water = 1,
            Pesticide = 2,
            NonReactive = 3,
            Tritium = 4,
            ConstantHydraulicGradient = 1,
            WaterTableInTheSoilProfile = 3,
            PressurePotential = 4,
            LysimeterWithFreeDrainage = 5,
            NoTillage = 0,
            Tillage = 1,
            NoIrrigation = 0,
            Irrigation = 1,
            Drainage = 1,
            NoDrainage = 0,
            ConventionallyTilled = 1,
            ReducedTilled = 2,
            NoTillArable = 3,
            PerennialLanduse = 4
        }

        public enum TableHeading
        {
            Horizon,
            Upper,
            Lower
        }

        public enum TabPages
        {
            Crop,
            IBCond,
            Irrigation,
            PhysicalParameters,
            Site,
            Solute,
            Tillage,
            NumericalLayers
        }
    }
}

