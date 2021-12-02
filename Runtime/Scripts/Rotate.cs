using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Korrel.VFXOnEventHandler
{
    public class Rotate : BaseEffectBehaviour
    {
        protected override void HandleVFXUpdate(Transform _transform, float value)
        {
            transform.rotation = _transform.rotation;
        }
    }
}