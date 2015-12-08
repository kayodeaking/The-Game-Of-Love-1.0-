using UnityEngine;
using System.Collections;

namespace BehaviorDesigner.Runtime
{
    [System.Serializable]
    public class SharedQuaternion : SharedVariable<Quaternion>
    {
        public override string ToString() { return mValue.ToString(); }
        public static implicit operator SharedQuaternion(Quaternion value) { return new SharedQuaternion { mValue = value }; }
    }
}