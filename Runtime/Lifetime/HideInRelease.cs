using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NCat.Lifetime
{
    public class HideInRelease : MonoBehaviour
    {
        // Start is called before the first frame update

        private void Awake()
        {
#if DEVELOPMENT_BUILD || DEMO_VER || UNITY_EDITOR
#else
            gameObject.SetActive(false);
#endif
        }
    }

} // namespace NCat