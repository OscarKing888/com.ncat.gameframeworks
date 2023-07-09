using System;
using UnityEngine;

namespace NCat.Singleton
{
    public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;
        public static T Instance
        {
            get
            {
                if (SingletonMono<T>.instance == null)
                {
                    SingletonMono<T>.instance = (T)((object)UnityEngine.Object.FindObjectOfType(typeof(T)));
                    
                    if (SingletonMono<T>.instance == null)
                    {
                        GameObject gameObject = new GameObject(typeof(T).ToString());
                        SingletonMono<T>.instance = gameObject.AddComponent<T>();
                    }

                    if (Application.isPlaying)
                    {
                        UnityEngine.Object.DontDestroyOnLoad(SingletonMono<T>.instance.gameObject);
                    }
                }
                return SingletonMono<T>.instance;
            }
            set
            {
                SingletonMono<T>.instance = value;
            }
        }

        protected virtual void Awake()
        {
            NCat.DebugEx.LogFormatInit("Init SingletonMono:" + this.GetType().FullName);
        }

        protected virtual void OnDestroy()
        {
            if (SingletonMono<T>.instance == this)
            {
                SingletonMono<T>.instance = null;
            }
        }
    }


    public class SingletonCreate<T> where T : new()
    {
        protected static T instance;
        public static T Instance
        {
            get
            {
                if (SingletonCreate<T>.instance == null)
                {
                    SingletonCreate<T>.instance = Activator.CreateInstance<T>();
                }
                return SingletonCreate<T>.instance;
            }
            set
            {
                SingletonCreate<T>.instance = value;
            }
        }
    }



    public class TSingletonPhonenix<T> : MonoBehaviour where T : class
    {
        private static T ms_Singleton;

        protected virtual void Awake()
        {
            TSingletonPhonenix<T>.ms_Singleton = ((TSingletonPhonenix<T>)this) as T;
        }

        protected virtual void OnDestroy()
        {
#pragma warning disable CS0252 // 可能非有意的引用比较；左侧需要强制转换
            if (TSingletonPhonenix<T>.ms_Singleton == this)
#pragma warning restore CS0252 // 可能非有意的引用比较；左侧需要强制转换
            {
                TSingletonPhonenix<T>.ms_Singleton = null;
            }
        }

        public static bool IsSingletonCreated
        {
            get
            {
                return (TSingletonPhonenix<T>.ms_Singleton != null);
            }
        }

        public static T Instance
        {
            get
            {
                if (TSingletonPhonenix<T>.ms_Singleton == null)
                {
                    GameObject obj2 = new GameObject();
                    obj2.AddComponent(typeof(T));
                    obj2.name = typeof(T).Name;
                }
                return TSingletonPhonenix<T>.ms_Singleton;
            }
        }
    }


    public class TSingletonNoInit<T> : MonoBehaviour where T : class
    {
        private static T ms_Singleton;

        protected virtual void Awake()
        {
            TSingletonNoInit<T>.ms_Singleton = ((TSingletonNoInit<T>)this) as T;
        }

        protected virtual void OnDestroy()
        {
#pragma warning disable CS0252 // 可能非有意的引用比较；左侧需要强制转换
            if (TSingletonNoInit<T>.ms_Singleton == this)
#pragma warning restore CS0252 // 可能非有意的引用比较；左侧需要强制转换
            {
                TSingletonNoInit<T>.ms_Singleton = null;
            }
        }

        public static bool IsSingletonCreated
        {
            get
            {
                return (TSingletonNoInit<T>.ms_Singleton != null);
            }
        }

        public static T Instance
        {
            get
            {
                return TSingletonNoInit<T>.ms_Singleton;
            }
        }
    }


    /// <summary> 
    /// To access the heir by a static field "Instance".
    /// </summary>
    public abstract class SingletonAwake<T> : MonoBehaviour where T : UnityEngine.Object
    {

        [SerializeField] private bool dontDestroyOnLoad;

        private static T instance;

        public static T Instance
        {
            get
            {
                return instance;
            }
        }

        void Awake()
        {
            if (instance == null)
            {
                instance = this as T;
                if (dontDestroyOnLoad)
                {
                    if (Application.isPlaying)
                    {
                        DontDestroyOnLoad(gameObject);
                    }
                }
                AwakeSingleton();
            }
            else
            {
                Destroy(gameObject.GetComponent<T>());
            }
        }
        protected abstract void AwakeSingleton();
    }

} // namespace NCat.Singleton