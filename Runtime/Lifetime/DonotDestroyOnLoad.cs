using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NCat.Lifetime
{
    public class DonotDestroyOnLoad : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
