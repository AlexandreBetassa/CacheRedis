using System.ComponentModel.DataAnnotations;

namespace RedisP1.Contracts.v1
{
    public interface IEntity
    {
        [Key]
        public string Id { get; set; }
        public double Value { get; set; }
        public string TypePayment { get; set; }
    }
}
