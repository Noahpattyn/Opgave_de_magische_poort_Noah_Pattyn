using System;

namespace Opgave_de_magische_poort_Noah_Pattyn.Components.Data
{
    public class Models
    {
        public enum Kleur
        {
            Rood, Blauw, Geel, Groen, Zwart, Wit
        }
        public class Poort
        {
            public Kleur Kleur { get; set; }
            public int Grootte { get; set; }
            public int AantalInkeppingen { get; set; }
            public int Gewicht { get; set; }

        }
    }
}
