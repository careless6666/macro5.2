namespace MACRO_52
{
    using AxMSFlexGridLib;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Runtime.InteropServices;

    internal class CDisaggregation
    {
        private CParameters m_Parameters = new CParameters();
        private int m_nDisaggLevels;
        private collCRainfall m_RainfallSeries = new collCRainfall();

        public void Disaggregate(ref bool bPrintAllSteps = false, ref short nLevels = 4)
        {
            // Invalid method body.
        }

        public void PrintRainfallSeries(ref short Index, ref string filename, ref double startdate)
        {
            this.m_RainfallSeries[(short) Index].PrintRainfall(ref filename, ref startdate, ref 60);
        }

        public void ReadParameters(ref AxMSFlexGrid grid, ref string fname, ref double startdate)
        {
            this.m_Parameters.Init(ref 1);
            short fileNumber = (short) FileSystem.FreeFile();
            short index = 1;
            while (true)
            {
                this.m_Parameters.set_p10(index, Conversions.ToSingle(grid.get_TextMatrix(index, 1)));
                index = (short) (index + 1);
                short num4 = 8;
                if (index > num4)
                {
                    index = 1;
                    while (true)
                    {
                        this.m_Parameters.set_p01(index, Conversions.ToSingle(grid.get_TextMatrix(index, 2)));
                        index = (short) (index + 1);
                        num4 = 8;
                        if (index > num4)
                        {
                            index = 1;
                            while (true)
                            {
                                this.m_Parameters.set_pxx(index, Conversions.ToSingle(grid.get_TextMatrix(index, 3)));
                                index = (short) (index + 1);
                                num4 = 8;
                                if (index > num4)
                                {
                                    this.m_RainfallSeries.Add(ref "");
                                    FileSystem.FileOpen(fileNumber, fname, OpenMode.Binary, OpenAccess.Default, OpenShare.Default, -1);
                                    this.m_RainfallSeries[1].ReadRainfallFromBinFile(ref fileNumber, ref startdate);
                                    FileSystem.FileClose(new int[] { fileNumber });
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        // Warning: Properties with arguments are not supported in C#. Getter of a RainfallSeries property was decompiled as a method.
        public CRainfall get_RainfallSeries(short Index) => 
            this.m_RainfallSeries[Index];


        public short NumberOfRainfallSeries =>
            (short) this.m_RainfallSeries.Count;
    }
}

