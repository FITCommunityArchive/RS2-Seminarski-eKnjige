﻿using System;

namespace eKnjige.Model
{
    public class KupovinaKnjige
    {
        
        public int KupovinaKnjigeID { get; set; }
        public DateTime DatumKupovine { get; set; }

        

        public int KlijentID { get; set; }

        public Klijent Klijent { get; set; }

      

        public int EKnjigaID { get; set; }

        public EKnjiga EKnjiga { get; set; }

       
    }
}
