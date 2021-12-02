using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Korrel.VFXOnEventHandler
{
    public class Follow : BaseEffectBehaviour
    {
        protected override void HandleVFXUpdate(Transform _transform, float value)
        {
            transform.position = _transform.position;
        }
    }
}