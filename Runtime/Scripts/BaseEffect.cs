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
            HandleVFXDestroy(gameObject, destroyAfter);
        }

        protected virtual void HandleVFXUpdate(Transform _transform, float value)
        {
            // Override this method
        }

        protected virtual void HandleVFXDestroy(GameObject gameObject, float destroyAfter)
        {
            // Override this method
            Destroy(gameObject, destroyAfter);
        }
    }
}