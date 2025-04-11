using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenApplication
{
    // This class implements the IEnumerable interface to allow iteration over a collection of subscribers.
    internal class SubscriberCollection : IEnumerable

    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        public IEnumerator GetEnumerator()
        {
            return new SubscribersEnumerator(_subscribers);
        }
        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }
        private class SubscribersEnumerator : IEnumerator
        {
            private int _position = -1;
            private List<ISubscriber> _subscribers = new List<ISubscriber>();
            public object Current => _subscribers[_position];

            public bool MoveNext()
            {
                _position++;
                return (_position < _subscribers.Count);
            }
            public SubscribersEnumerator(List<ISubscriber> subscribers)
            {
                this._subscribers = subscribers;

            }
            public void Reset()
            {
                _position = -1;
            }
            public void Dispose()
            {}
        }
    }
}


