using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardClient.Models.Entities
{
    public class Product
    {
        [JsonProperty("sku")]
        public long SKU { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("salePrice")]
        public decimal Price { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
