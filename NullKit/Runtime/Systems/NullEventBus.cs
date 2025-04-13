using System;
using System.Collections.Generic;

namespace NullKit
{
    public static class NullEventBus
    {
        private static Dictionary<string, Action> events = new Dictionary<string, Action>();

        public static void Subscribe(string eventName, Action callback)
        {
            if (!events.ContainsKey(eventName))
                events[eventName] = callback;
            else
                events[eventName] += callback;
        }

        public static void Unsubscribe(string eventName, Action callback)
        {
            if (events.ContainsKey(eventName))
                events[eventName] -= callback;
        }

        public static void Emit(string eventName)
        {
            if (events.TryGetValue(eventName, out var action))
                action?.Invoke();
        }
    }
}
