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
            Events.current.onVFXDestroy += OnVFXDestroy;
        }

        void OnDestroy()
        {
            // Register events
            Events.current.onVFXUpdate -= OnVFXUpdate;
            Events.current.onVFXDestroy -= OnVFXDestroy;
        }

        public void OnVFXUpdate(string _eventIdentifier, Transform _transform, float value)
        {
            if (eventIdentifier != _eventIdentifier) return;
            HandleVFXUpdate(_transform, value);
        }

        public void OnVFXDestroy(string _eventIdentifier, float destroyAfter)
        {
            if (eventIdentifier != _eventIdentifier) return;
            Destroy(gameObject, destroyAfter);
        }

        protected virtual void HandleVFXUpdate(Transform _transform, float value)
        {
            // Override this method
        }
    }
}