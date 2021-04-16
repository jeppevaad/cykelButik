using System;
using System.Collections.Generic;

namespace Cykel
{
    public class Cykel
    {
        public string Navn;
        public double Pris;
        public string Type;
        public int Gear;

        public Cykel(string Navn, double Pris, string Type, int Gear)
        {
            this.Navn = Navn;
            this.Pris = Pris;
            this.Type = Type;
            this.Gear = Gear;
        }

        public List<Cykel> cykelInventar = new List<Cykel>();

        public void opretNyCykel(string navn, double pris, string type, int gear)
        {
            cykelInventar.Add(new Cykel(navn, pris, type, gear));
        }
        public void sletCykelVedNummerIList(int nummer)
        {
            cykelInventar.RemoveAt(nummer);
        }
        
        public void opdaterCykel(int nrIList, string navn, double pris, string type, int gear)
        {
            cykelInventar.RemoveAt(nrIList);
            Cykel opdateretCykel = new Cykel(navn, pris, type, gear);
            cykelInventar.Insert(nrIList, opdateretCykel);
        }
        public Cykel[] HentInventar()
        {
            Cykel[] cykelInventar2 = new Cykel[cykelInventar.Count];
            for (int i = 0; i < cykelInventar2.Length; i++)
            {
                cykelInventar2[i] = cykelInventar[i];
            }
            return cykelInventar2;
        }


    }
}
