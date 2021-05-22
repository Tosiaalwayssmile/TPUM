namespace DataLayer.Model
{
    public class DiscountCode : BaseEntity
    {
        public string Code { get; set; }
        
        public decimal Amount { get; set; }

        public override bool Equals(object obj)
        {
            DiscountCode other = (DiscountCode)obj;

            return (string.Equals(Code, other.Code) && Amount == other.Amount);
        }
    }
}
