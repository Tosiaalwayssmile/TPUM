using WebsocketServerData.Model;

namespace WebsocketServerData.Repositories.DiscountCodes
{
    public interface IDiscountCodeRepository : ICrudRepository<DiscountCode>
    {
        DiscountCode GetRandomDiscountCode();
    }
}