using System;

namespace O2Platform.Certificate.API.Data.Models.O2C
{
    public class O2CPhoto: Photo
    {
        public O2CCertificate O2CCertificate { get; set; }
        public Guid O2CCertificateId { get; set; }
    }
}