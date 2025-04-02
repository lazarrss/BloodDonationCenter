using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.formeDonor
{
    internal class HitniSlucajevi
    {
        public string mesto;
        public string bolnica;
        public string krvnaGrupa;
        public string ime;
        public string prezime;

        public HitniSlucajevi(string mesto, string bolnica, string krvnaGrupa, string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.mesto = mesto;
            this.bolnica = bolnica;
            this.krvnaGrupa = krvnaGrupa;
        }

        public string Mesto
        {
            get { return mesto; }
            set { mesto = value; }
        }    

        public string Bolnica
        {
            get { return bolnica; }
            set { bolnica = value; }
        }

        public string KrvnaGrupa
        {
            get { return krvnaGrupa; }
            set { krvnaGrupa = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

    }
}
