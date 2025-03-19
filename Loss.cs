using System;
using System.Collections.Generic;

namespace tati_thiago_dos_santos_p1 {
    public class Loss {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }
        public string LostBy { get; set; }
        public DateTime Date { get; set; }
        public string NearestLocation { get; set; }
        public string Geo { get; set; }
        public string Unit { get; set; }
        public List<string> Tags { get; set; }
    }

    public class LossResponse {
        public List<Loss> Losses { get; set; }
    }
}
