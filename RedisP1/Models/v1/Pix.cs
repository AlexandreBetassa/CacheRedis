using RedisP1.Contracts.v1;
using System.ComponentModel.DataAnnotations;

namespace RedisP1.Models.v1
{
    public class Pix : IEntity
    {
        [Key]
        public string Id { get; set; }
        public double Value { get; set; }
        public string TypePayment { get; set; }
    }
}
