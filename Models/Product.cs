using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Blazor.Models
{
    public class Product
    {
        [JsonProperty("id")]
        public int? Id {get;set;}
        [JsonProperty("title")]
        public string? Title {get;set;}
        [JsonProperty("price")]
        public double? Price {get;set;}
        [JsonProperty("category")]
        public string? Category {get;set;}
        [JsonProperty("image")]
        public string? Image {get;set;}
    }
}