using DataLayer;
using DataLayer.Repositories.DiscountCodes;
using System;
using System.Reactive.Linq;
using System.Reactive.Concurrency;
using DataLayer.Model;
using DataLayer.Websockets;

namespace LogicLayer
{
    public class MessagePublisher : IDisposable
    {
        private IDiscountCodeRepository codeRepo;
        private IDisposable _subscription;
        public TimeSpan Period;
        public event EventHandler<Message> Message;

        public MessagePublisher(TimeSpan period)
        {
            codeRepo = new DiscountCodeRepository(DataStore.Instance.State.DiscountCodes);
            Period = period;
        }

        public void Start()
        {
            IObservable<long> timerObservable = Observable.Interval(Period);
            _subscription = timerObservable.ObserveOn(Scheduler.Default).Subscribe(RaiseTick);
        }

        private void RaiseTick(long counter)
        {
            DiscountCode discountCode = codeRepo.GetRandomDiscountCode();
            Message?.Invoke(this, new Message());
        }

        public void Dispose()
        {
            
        }
    }
}
