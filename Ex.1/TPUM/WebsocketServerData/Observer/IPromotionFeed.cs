using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsocketServerData.Observer
{
    public interface IPromotionFeed
    {
        public IDisposable Subscribe(IObserver<PromotionEvent> observer);
        public void PublishPromotion(PromotionEvent promotion);
        public void End();
    }
}
