using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NCat.Lifetime
{
    public class AutoDestroyOnLoad : MonoBehaviour
    {
        void Awake()
        {
            Destroy(gameObject);
        }
    }
} // namespace NCat.Lifetime
