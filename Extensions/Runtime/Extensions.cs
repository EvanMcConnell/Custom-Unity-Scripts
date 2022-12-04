using UnityEngine;

namespace oscail.extensions
{
    public static class Vector3Extensions
    {
        public static Vector3 With(this Vector3 it, float? x = null, float? y = null, float? z = null)
        {
            return new Vector3(x ?? it.x, y ?? it.y, z ?? it.z);
        }
    }

    public static class TransformExtentions
    {
        public static void SetEulerAngle(this Transform it, float? x = null, float? y = null, float? z = null)
        {
            var newEulerAngles = it.eulerAngles;
            it.eulerAngles = newEulerAngles.With(x: x ?? newEulerAngles.x, y: y ?? newEulerAngles.y,
                z: z ?? newEulerAngles.z);
        }

        public static void SetLocalEulerAngle(this Transform it, float? x = null, float? y = null, float? z = null)
        {
            var newLocalEulerAngles = it.localEulerAngles;
            it.localEulerAngles = newLocalEulerAngles.With(x: x ?? newLocalEulerAngles.x, y: y ?? newLocalEulerAngles.y,
                z: z ?? newLocalEulerAngles.z);
        }
    }
}