using Newtonsoft.Json;

namespace LinhChiDoiSOS.Application.Common.Base
{
    public class BasePagingQuery
    {
        [JsonProperty("Criteria")]
        public string? Criteria { get; set; } = string.Empty;
        
        [JsonProperty("PageSize")]
        public int? PageSize { get; set; } = 20;
        
        [JsonProperty("PageIndex")]
        public int? PageIndex { get; set; } = 1;
    }
}
