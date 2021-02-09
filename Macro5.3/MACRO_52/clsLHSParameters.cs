namespace MACRO_52
{
    using System;

    internal class clsLHSParameters
    {
        private string mvarParameterName;
        private short mvarDistribution;
        private float mvarMean;
        private float mvarVariance;
        private float mvarMin;
        private float mvarMax;

        public float Max
        {
            get => 
                this.mvarMax;
            set => 
                this.mvarMax = value;
        }

        public float Min
        {
            get => 
                this.mvarMin;
            set => 
                this.mvarMin = value;
        }

        public float Variance
        {
            get => 
                this.mvarVariance;
            set => 
                this.mvarVariance = value;
        }

        public float mean
        {
            get => 
                this.mvarMean;
            set => 
                this.mvarMean = value;
        }

        public short Distribution
        {
            get => 
                this.mvarDistribution;
            set => 
                this.mvarDistribution = value;
        }

        public string ParameterName
        {
            get => 
                this.mvarParameterName;
            set => 
                this.mvarParameterName = value;
        }
    }
}

