using UnityEngine;

public static class Extensions
{
    /*
     *     Vector3
     */
    public static Vector3 With(this Vector3 it, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? it.x, y ?? it.y, z ?? it.z);
    }
    
    /*
     *     Transform
     */
    public static void SetEulerAngle(this Transform it, float? x = null, float? y = null, float? z = null)
    {
        var newEulerAngles = it.eulerAngles;
        it.eulerAngles = newEulerAngles.With(x: x ?? newEulerAngles.x, y: y ?? newEulerAngles.y, z: z ?? newEulerAngles.z);
    }
}
