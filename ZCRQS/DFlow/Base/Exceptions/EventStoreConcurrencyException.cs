using System;
using System.Collections.Generic;
using DFlow.Interfaces;

namespace DFlow.Base.Exceptions
{
    public class EventStoreConcurrencyException : Exception
    {
        public List<IEvent> StoreEvents { get; protected set; }

        public long StoreVersion { get; protected set; }

        public EventStoreConcurrencyException(List<IEvent> storeEvents, long storeVersion)
        {
            StoreEvents = storeEvents;
            StoreVersion = storeVersion;
        }
    }
}