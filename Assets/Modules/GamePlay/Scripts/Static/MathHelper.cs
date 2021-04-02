using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Static
{
    public static class MathHelper
    {
        public static void GetLinesIntersection(Vector3 a0, Vector3 a1, Vector3 b0, Vector3 b1, out Vector3 intersectionPoint, bool a0IsEnd = true, bool a1IsEnd = true, bool b0IsEnd = true, bool b1IsEnd = true, bool x = true, bool y = true, bool z = true)
        {
            float uxy, uxz, uyz, u, tx, ty, tz, t;
            GetLinesRelationship(a0, a1, b0, b1, out intersectionPoint, out uxy, out uxz, out uyz, out u, out tx, out ty, out tz, out t, x, y, z);
        }

        private static bool GetLinesRelationship(Vector3 a0, Vector3 a1, Vector3 b0, Vector3 b1, out Vector3 intersectionPoint, out float uxy, out float uxz, out float uyz, out float u, out float tx, out float ty, out float tz, out float t, bool x = true, bool y = true, bool z = true)
        {
            if (!x)
                a0.x = a1.x = b0.x = b1.x = 0;
            if (!y)
                a0.y = a1.y = b0.y = b1.y = 0;
            if (!z)
                a0.z = a1.z = b0.z = b1.z = 0;

            uxy = (b0.x - a0.x - (b0.y - a0.y) / (a1.y - a0.y) * (a1.x - a0.x)) / ((b1.y - b0.y) / (a1.y - a0.y) * (a1.x - a0.x) - (b1.x - b0.x));
            uxz = (b0.x - a0.x - (b0.z - a0.z) / (a1.z - a0.z) * (a1.x - a0.x)) / ((b1.z - b0.z) / (a1.z - a0.z) * (a1.x - a0.x) - (b1.x - b0.x));
            uyz = (b0.y - a0.y - (b0.z - a0.z) / (a1.z - a0.z) * (a1.y - a0.y)) / ((b1.z - b0.z) / (a1.z - a0.z) * (a1.y - a0.y) - (b1.y - b0.y));

            u = !float.IsNaN(uxy) ? uxy : (!float.IsNaN(uxz) ? uxz : uyz);


            tx = (b0.x + u * (b1.x - b0.x) - a0.x) / (a1.x - a0.x);
            ty = (b0.y + u * (b1.y - b0.y) - a0.y) / (a1.y - a0.y);
            tz = (b0.z + u * (b1.z - b0.z) - a0.z) / (a1.z - a0.z);

            t = !float.IsNaN(tx) ? tx : (!float.IsNaN(ty) ? ty : tz);

            intersectionPoint = (a1 - a0) * t + a0;

            if (!(float.IsNaN(intersectionPoint.x) && a0.x - a1.x != 0 && b0.x - b1.x != 0 || float.IsNaN(intersectionPoint.y) && a0.y - a1.y != 0 && b0.y - b1.y != 0 || float.IsNaN(intersectionPoint.z) && a0.z - a1.z != 0 && b0.z - b1.z != 0))
                return true;
            return false;
        }
    }
}