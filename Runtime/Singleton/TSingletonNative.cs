using System;
using UnityEngine;

namespace NCat.Singleton
{
    public class TSingletonNative<T> where T : new()
    {
        private static T ms_Singleton;

        public static bool IsSingletonCreated
        {
            get
            {
                return (TSingletonNative<T>.ms_Singleton != null);
            }
        }

        public static T Instance
        {
            get
            {
                if (TSingletonNative<T>.ms_Singleton == null)
                {
                    NCat.DebugEx.LogFormatInit("Init SingletonNative:" + typeof(T).FullName);
                    TSingletonNative<T>.ms_Singleton = new T();
                }
                return TSingletonNative<T>.ms_Singleton;
            }
        }
    }
} // namespace NCat.Singleton