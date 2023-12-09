using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.Domain
{
    public class DiscountCodeCoupoun
    {
        [Key]
        public int Id { get; set; }

        public int DiscountPrice { get; set; }

        public DiscountType DiscountType { get; set; }

        public bool Valid { get; set; }

    }

    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum DiscountType
    {
        percentage,
        value
    }
}
