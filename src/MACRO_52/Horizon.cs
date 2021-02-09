namespace MACRO_52
{
    using System;

    internal class Horizon
    {
        public float sand;
        public float silt;
        public float clay;
        public float oc;
        public float bd;
        public float th;
        public float thetas;
        public float thetab;
        public float psib;
        public float lambda;
        public float kb;
        public float nstar;
        public float theta15;
        public float theta50;
        public float waten;
        public float deff;
        public float ksub;
        public string Texture;
        public string Designation;
        public short Divhor;
        public float pH;
        private string[] structure_Renamed = new string[3];

        public void Init()
        {
            this.sand = 0f;
            this.silt = 0f;
            this.clay = 0f;
            this.oc = 0f;
            this.bd = 0f;
            this.th = 0f;
            this.pH = 0f;
            this.structure_Renamed[0] = "";
            this.structure_Renamed[1] = "";
            this.structure_Renamed[2] = "";
            this.Texture = "";
            this.Designation = "";
            this.Divhor = 0;
        }

        // Warning: Properties with arguments are not supported in C#. Getter of a struct property was decompiled as a method.
        public string get_struct(short index) => 
            this.structure_Renamed[index];

        // Warning: Properties with arguments are not supported in C#. Setter of a struct property was decompiled as a method.
        public void set_struct(short index, string Value)
        {
            this.structure_Renamed[index] = Value;
        }

    }
}

