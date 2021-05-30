using WebsocketServerData.Model;

namespace WebsocketServerData.Observer
{
    public class PromotionEvent
    {
        public PromotionEvent(DiscountCode discountCode)
        {
            DiscountCode = discountCode;
        }

        public DiscountCode DiscountCode { get; private set; }
    }
}
