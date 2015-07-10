namespace feeder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AirCondiction")]
    public partial class AirCondiction
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(250)]
        public string location { get; set; }

        public string locationCht { get; set; }

        public DateTime datetime { get; set; }

        public double pm10 { get; set; }

        public double pm25 { get; set; }

        public double o3 { get; set; }

        public double so2 { get; set; }

        public double co { get; set; }

        public double no2 { get; set; }

        public double fpmi { get; set; }
    }
}
