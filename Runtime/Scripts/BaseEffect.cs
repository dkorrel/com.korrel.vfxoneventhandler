using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Korrel.VFXOnEventHandler
{
    public class BaseEffectBehaviour : MonoBehaviour
    {
        public string eventIdentifier;

        void Start()
        {
            // Register events
            Events.current.onVFXUpdate += OnVFXUpdate;
        }

        void OnDestroy()
        {
            // Register events
            Events.current.onVFXUpdate -= OnVFXUpdate;
        }

        public void OnVFXUpdate(string _eventIdentifier, Transform _transform, float value)
        {
            if (eventIdentifier != _eventIdentifier) return;
            HandleVFXUpdate(_transform, value);
        }

        protected virtual void HandleVFXUpdate(Transform _transform, float value)
        {
            // Override this method
        }
    }
}