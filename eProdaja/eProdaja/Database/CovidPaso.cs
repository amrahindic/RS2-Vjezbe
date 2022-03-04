using System;
using System.Collections.Generic;

#nullable disable

namespace eProdaja.Database
{
    public partial class CovidPaso
    {
        public CovidPaso()
        {
            Kupcis = new HashSet<Kupci>();
        }

        public int CovidPasosId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumVazenja { get; set; }
        public string VazeciPasos { get; set; }

        public virtual ICollection<Kupci> Kupcis { get; set; }
    }
}
