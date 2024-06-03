using System.Text.Json.Serialization;

namespace ForumCategoryAPI.Models
{
    public class Category
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Name { get; set; }
    }
}
