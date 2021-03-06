using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using O2Platform.Certificate.API.Data.Core.Data;

namespace O2Platform.Certificate.API.Data.Models.O2C
{
    public class O2CLocation : BaseDbEntity
    {
        [MaxLength(255)]
        [Column("country")]
        public string Country { get; set; }

        [MaxLength(255)]
        [Column("region")]
        public string Region { get; set; }
        public List<O2CCertificateLocation> O2CCertificateLocation { get; set; } = new List<O2CCertificateLocation>();
    }
}