using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NCat.Layer
{
    /// <summary>
    /// To select a layer in the inspector.
    /// </summary>
    [System.Serializable]
    public struct Layer
    {

        [SerializeField] int value;

        public static implicit operator int(Layer layer)
        {
            return layer.value;
        }
    }
} // namespace NCat.Layer