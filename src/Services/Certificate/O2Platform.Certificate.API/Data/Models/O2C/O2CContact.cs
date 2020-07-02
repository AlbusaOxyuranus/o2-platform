using System.ComponentModel.DataAnnotations.Schema;
using O2Platform.Certificate.API.Data.Core.Data;

namespace O2Platform.Certificate.API.Data.Models.O2C
{
    public class O2CContact : BaseDbEntity
    {
        [Column("contact_key")] 
        public string Key { get; set; }

        [Column("contact_value")] 
        public string Value { get; set; }

        public O2CCertificate O2CCertificate {get;set;}
    }
}