using System.ComponentModel.DataAnnotations.Schema;
using O2Platform.Certificate.API.Data.Core.Data;

namespace O2Platform.Certificate.API.Data.Models
{
    public class Photo: BaseDbEntity
    {
        [Column("url")]
        public string Url { get; set; }
        
        [Column("isMain")]
        public bool IsMain { get; set; }
        
        [Column("fileName")]
        public string FileName { get; set; }
    }
}