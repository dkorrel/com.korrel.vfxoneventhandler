using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Korrel.VFXOnEventHandler
{
    public class Events : MonoBehaviour
    {
        public static Events current;

        void Awake()
        {
            current = this;
        }

        public event Action<string, Transform> onVFXUpdate;

        public void OnVFXUpdate(string eventIdentifier, Transform _transform)
        {
            if (onVFXUpdate != null) onVFXUpdate(eventIdentifier, _transform);
        }
    }
}