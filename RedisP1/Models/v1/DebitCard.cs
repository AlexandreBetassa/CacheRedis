using RedisP1.Contracts.v1;

namespace RedisP1.Models.v1
{
    public class DebitCard : IEntity
    {
        public string Id { get; set; }
        public double Value { get; set; }
        public string TypePayment { get; set; }
    }
}
