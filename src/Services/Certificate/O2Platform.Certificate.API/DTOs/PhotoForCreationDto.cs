using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using O2Platform.Certificate.API.Data.Core;

namespace O2Platform.Certificate.API.DTOs
{
    public class PhotoForCreationDto
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "file")] 
        public IFormFile File { get; set; }

        [JsonProperty(PropertyName = "dateAdded")]
        public long DateAdded { get; set; }

        [JsonProperty(PropertyName = "modifiedDate")]
        public long ModifiedDate { get; set; }

        
        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now.ConvertToUnixTime();
        }
    }
}