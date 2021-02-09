namespace MACRO_52
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;

    [StandardModule]
    internal sealed class FootprintPedotransfer
    {
        public static object degr(ref short h, ref short ind) => 
            (h != 1) ? ((h != 2) ? (GlobalVariables.deg[ind] * 0.3) : (GlobalVariables.deg[ind] * 0.5)) : GlobalVariables.deg[ind];

        private static bool DepthRestriction(int horizon, frmFOOTPRINTPedotransferInput frm)
        {
            int num3 = horizon - 1;
            int index = 1;
            while (true)
            {
                float num2;
                int num4 = num3;
                if (index > num4)
                {
                    num2 = Conversions.ToSingle(Operators.AddObject(num2, Operators.DivideObject(GlobalVariables.thickness[horizon], 2)));
                    return !(((num2 > UpperLimit()) & (num2 < LowerLimit())) & ((LowerLimit() - UpperLimit()) > 20f));
                }
                num2 = Conversions.ToSingle(Operators.AddObject(num2, GlobalVariables.thickness[index]));
                index++;
            }
        }

        public static float fp_Alphavg(ref short h, ref short topsoil)
        {
            float num2 = (float) (GlobalVariables.orgc[h] * 1.724);
            return (float) Math.Exp((double) ((float) ((((((((((((((-14.96 + (0.03135 * GlobalVariables.clay[h])) + (0.0351 * GlobalVariables.silt[h])) + (0.646 * num2)) + (15.29 * GlobalVariables.gamma[h])) - (0.192 * ((double) topsoil))) - (4.671 * Math.Pow((double) GlobalVariables.gamma[h], 2.0))) - (0.000781 * Math.Pow((double) GlobalVariables.clay[h], 2.0))) - (0.00687 * Math.Pow((double) num2, 2.0))) + (0.0449 / ((double) num2))) + (0.0663 * Math.Log((double) GlobalVariables.silt[h]))) + (0.1482 * Math.Log((double) num2))) - ((0.04546 * GlobalVariables.gamma[h]) * GlobalVariables.silt[h])) - ((0.4852 * num2) * GlobalVariables.gamma[h])) + ((0.00673 * ((double) topsoil)) * GlobalVariables.clay[h]))));
        }

        public static float fp_ASCALE(ref short structclass)
        {
            float num;
            if (structclass == 1)
            {
                num = 1f;
            }
            else if (structclass == 2)
            {
                num = 15f;
            }
            else if (structclass == 3)
            {
                num = 50f;
            }
            else if (structclass == 4)
            {
                num = 150f;
            }
            return num;
        }

        public static float fp_KSATMIN(ref float macroporosity, ref float nstj) => 
            (6000f * (macroporosity / 100f)) / nstj;

        public static float fp_KSM(ref short h, ref float ts, ref short topsoil)
        {
            float num4 = 10.73f;
            float n = Nvg(ref h, ref topsoil);
            float alpha = fp_Alphavg(ref h, ref topsoil);
            return (float) ((0.186f * (fp_XMPOR(ref h, ref n, ref alpha, ref ts, ref topsoil) / 100f)) * Math.Pow((double) n, (double) num4));
        }

        public static short fp_StructureClass(int i, float midpoint, frmFOOTPRINTPedotransferInput frm)
        {
            short num;
            if (Strings.Left(GlobalVariables.designat[i], 1) == "A")
            {
                num = !((GlobalVariables.designat[i] == "At") | (TextureClassification(ref GlobalVariables.Texture[i]) == "coarse")) ? ((GlobalVariables.designat[i] != "Ap") ? (!(frm.chkTrafficked.Checked & ((LargeBiopores(frm, i) == MACROConstants.BioporeFrequency.Common) | (LargeBiopores(frm, i) == MACROConstants.BioporeFrequency.Abundant))) ? 2 : 3) : ((GlobalVariables.orgc[i] <= 5f) ? ((TextureClassification(ref GlobalVariables.Texture[i]) != "fine") ? 2 : 3) : 1)) : 1;
            }
            else if (((GlobalVariables.designat[i] == "C") | (GlobalVariables.designat[i] == "O")) | (GlobalVariables.designat[i] == "H"))
            {
                num = 1;
            }
            else if ((((GlobalVariables.designat[i] == "BC") | (GlobalVariables.designat[i] == "E")) | (GlobalVariables.designat[i] == "B")) | (GlobalVariables.designat[i] == "Bpan"))
            {
                num = (TextureClassification(ref GlobalVariables.Texture[i]) != "coarse") ? (!((TextureClassification(ref GlobalVariables.Texture[i]) == "fine") | (LargeBiopores(frm, i) == MACROConstants.BioporeFrequency.Abundant)) ? ((LargeBiopores(frm, i) != MACROConstants.BioporeFrequency.Common) ? 2 : ((GlobalVariables.designat[i] != "Bpan") ? 3 : 4)) : 4) : 1;
            }
            else
            {
                num = 1;
            }
            return num;
        }

        public static float fp_THETAS(ref short h, ref float fs, ref float es, ref short topsoil) => 
            (float) (((1f - (fs * (1f - es))) * (((((((((((0.7919 + (0.001691 * GlobalVariables.clay[h])) - (0.29619 * GlobalVariables.gamma[h])) - (1.491E-06 * Math.Pow((double) GlobalVariables.silt[h], 2.0))) + (8.21E-05 * Math.Pow(GlobalVariables.orgc[h] * 1.724, 2.0))) + (0.02427 / ((double) GlobalVariables.clay[h]))) + (0.01113 / ((double) GlobalVariables.silt[h]))) + (0.01472 * Math.Log((double) GlobalVariables.silt[h]))) - (((7.33E-05 * GlobalVariables.orgc[h]) * 1.724) * GlobalVariables.clay[h])) - ((0.000619 * GlobalVariables.gamma[h]) * GlobalVariables.clay[h])) - (((0.001183 * GlobalVariables.gamma[h]) * GlobalVariables.orgc[h]) * 1.724)) - ((0.0001664 * ((double) topsoil)) * GlobalVariables.silt[h]))) * 100.0);

        public static float fp_TPORV(ref float foc, ref short h)
        {
            float num2 = (float) ((((100.0 - (foc * 100f)) * 2.7) + (foc * 100f)) / 100.0);
            return (float) (((1.0 - (GlobalVariables.gamma[h] / num2)) * 0.96) * 100.0);
        }

        public static object fp_WILT(ref short h, ref float ts, ref short topsoil)
        {
            float num3 = (float) (GlobalVariables.orgc[h] * 1.724);
            float num2 = Nvg(ref h, ref topsoil);
            float num = fp_Alphavg(ref h, ref topsoil);
            return (((double) ts) / Math.Pow(1.0 + Math.Pow(num * 15000.0, (double) num2), (double) (1f - (1f / num2))));
        }

        public static float fp_XMPOR(ref short h, ref float n, ref float alpha, ref float ts, ref short topsoil) => 
            (float) (((double) ts) / Math.Pow(1.0 + Math.Pow((double) (alpha * 10f), (double) n), (double) (1f - (1f / n))));

        public static float fp_ZN(ref short StructureClass)
        {
            float num;
            if (StructureClass == 1)
            {
                num = 6f;
            }
            else if (StructureClass == 2)
            {
                num = 4f;
            }
            else if (StructureClass == 3)
            {
                num = 3f;
            }
            else if (StructureClass == 4)
            {
                num = 2f;
            }
            return num;
        }

        private static MACROConstants.BioporeFrequency LargeBiopores(frmFOOTPRINTPedotransferInput frm, int horizon) => 
            !(frm.chkAridicTorric.Checked | frm.chkCryicPergelic.Checked) ? (!DepthRestriction(horizon, frm) ? ((GlobalVariables.sw_landuse != MACROConstants.Switch.Tritium) ? (!(frm.chkZeroTillOrManure.Checked | frm.optNoTillPerennial.Checked) ? ((TextureClassification(ref GlobalVariables.Texture[horizon]) != "medium") ? MACROConstants.BioporeFrequency.Rare : MACROConstants.BioporeFrequency.Common) : ((TextureClassification(ref GlobalVariables.Texture[horizon]) != "medium") ? MACROConstants.BioporeFrequency.Common : MACROConstants.BioporeFrequency.Abundant)) : MACROConstants.BioporeFrequency.Abundant) : MACROConstants.BioporeFrequency.Rare) : MACROConstants.BioporeFrequency.Rare;

        public static short LimitingFactor(ref string des, ref float pH, ref float bd, ref float drain_dep, ref string Texture, ref float mp)
        {
            if (((((((((des == "R") | (des == "BC")) | (des == "C")) | (des == "O")) | (des == "H")) | (pH < 5f)) | (((double) bd) > 1.8)) | (Texture == "coarse")) | ((mp / 100f) > drain_dep))
            {
            }
            return 1;
        }

        private static bool LimitingTexture(ref short fcz, ref string Texture)
        {
            bool flag = false;
            if (Texture == "coarse")
            {
                flag = true;
            }
            else if (((Texture == "fine") & (GlobalVariables.sw_landuse == MACROConstants.Switch.Tritium)) && (((((((((fcz == 1) | (fcz == 8)) | (fcz == 9)) | (fcz == 2)) | (fcz == 3)) | (fcz == 7)) | (fcz == 11)) | (fcz == 13)) | (fcz == 15)))
            {
                flag = true;
            }
            return flag;
        }

        private static float LowerLimit()
        {
            float mp = 0f;
            float left = 0f;
            int nhorizon = GlobalVariables.Nhorizon;
            int index = 1;
            while (true)
            {
                int num6 = nhorizon;
                if (index <= num6)
                {
                    mp = Conversions.ToSingle(Operators.AddObject(left, Operators.DivideObject(GlobalVariables.thickness[index], 2)));
                    string texture = TextureClassification(ref GlobalVariables.Texture[index]);
                    if (LimitingFactor(ref GlobalVariables.designat[index], ref GlobalVariables.pH[index], ref GlobalVariables.bulk[index], ref GlobalVariables.draindep, ref texture, ref mp) == 0)
                    {
                        left = Conversions.ToSingle(Operators.AddObject(left, GlobalVariables.thickness[index]));
                        index++;
                        continue;
                    }
                }
                return left;
            }
        }

        public static float macroporosity(ref short seq, ref string text_class, ref string desig, ref float midpoint, frmFOOTPRINTPedotransferInput frm)
        {
            float num;
            if (Strings.Left(desig, 1) == "A")
            {
                num = !(((GlobalVariables.sw_landuse == MACROConstants.Switch.Tritium) | frm.chkZeroTillOrManure.Checked) | (desig == "A")) ? ((Strings.Left(desig, 2) != "At") ? ((Strings.Left(desig, 2) != "Ap") ? ((Strings.Left(desig, 1) != "A") ? (!((Strings.Left(desig, 1) == "O") | (Strings.Left(desig, 1) == "H")) ? 5f : 5f) : ((text_class != "fine") ? ((text_class != "coarse") ? 3f : 4f) : 2f)) : ((text_class != "fine") ? ((text_class != "coarse") ? 4f : 5f) : 3f)) : 5f) : 5f;
            }
            else if (desig == "BC")
            {
                num = (text_class != "fine") ? ((text_class != "coarse") ? 0.4f : 4f) : 0.2f;
            }
            else if (((Strings.Left(desig, 1) == "B") | (Strings.Left(desig, 1) == "E")) & (midpoint <= 50f))
            {
                num = (text_class != "fine") ? ((text_class != "coarse") ? 1.6f : 5f) : 1.6f;
            }
            else if (((Strings.Left(desig, 1) == "B") | (Strings.Left(desig, 1) == "E")) & (midpoint > 50f))
            {
                num = (text_class != "fine") ? ((text_class != "coarse") ? 0.8f : 5f) : 0.8f;
            }
            else if (Strings.Left(desig, 1) == "C")
            {
                num = (text_class != "fine") ? ((text_class != "coarse") ? 0.4f : 3f) : 0.2f;
            }
            else if ((Strings.Left(desig, 1) == "O") | (Strings.Left(desig, 1) == "H"))
            {
                num = 5f;
            }
            else if (desig == "Bpan")
            {
                num = 0.1f;
            }
            else
            {
                num = 0f;
            }
            return num;
        }

        public static float Nvg(ref short h, ref short topsoil)
        {
            float num2 = (float) (GlobalVariables.orgc[h] * 1.724);
            float num6 = (float) ((((((((((0.002885 * Math.Pow((double) num2, 2.0)) - (12.81 / ((double) GlobalVariables.gamma[h]))) - (0.1524 / ((double) GlobalVariables.silt[h]))) - (0.01958 / ((double) num2))) - (0.2876 * Math.Log((double) GlobalVariables.silt[h]))) - (0.0709 * Math.Log((double) num2))) - (44.6 * Math.Log((double) GlobalVariables.gamma[h]))) - ((0.02264 * GlobalVariables.gamma[h]) * GlobalVariables.clay[h])) + ((0.0896 * num2) * GlobalVariables.gamma[h])) + ((0.00718 * ((double) topsoil)) * GlobalVariables.clay[h]));
            return (float) (Math.Exp((double) ((((float) (((-25.23 - (0.02195 * GlobalVariables.clay[h])) + (0.0074 * GlobalVariables.silt[h])) - (0.194 * num2))) + ((float) (((45.5 * GlobalVariables.gamma[h]) - (7.24 * Math.Pow((double) GlobalVariables.gamma[h], 2.0))) + (0.0003658 * Math.Pow((double) GlobalVariables.clay[h], 2.0))))) + num6)) + 1.0);
        }

        public static string TextureClassification(ref string texture) => 
            !((Strings.UCase(texture) == "SAND") | (Strings.UCase(texture) == "LOAMY SAND")) ? (!(((Strings.UCase(texture) == "CLAY") | (Strings.UCase(texture) == "SILTY CLAY")) | (Strings.UCase(texture) == "SILTY CLAY LOAM")) ? "medium" : "fine") : "coarse";

        private static float UpperLimit()
        {
            float left = 0f;
            int nhorizon = GlobalVariables.Nhorizon;
            int index = 1;
            while (true)
            {
                int num5 = nhorizon;
                if (index > num5)
                {
                    return left;
                }
                if (GlobalVariables.designat[index] == "At")
                {
                    left = Conversions.ToSingle(Operators.AddObject(left, GlobalVariables.thickness[index]));
                }
                index++;
            }
        }
    }
}

