using Newtonsoft.Json;

namespace VulnerableApp.Library.Contracts.Dto
{
    /// <summary>
    /// My foo request dto
    /// </summary>
    public class FooRqDto
    {
        
        /// <summary>
        /// My Data
        /// </summary>
        [JsonRequired]
        public string Data { get; set; }

        /// <summary>
        /// My Color
        /// </summary>
        public Color Color { get; set; }
    }
}