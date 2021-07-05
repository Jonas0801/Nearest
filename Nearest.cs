
using UnityEngine;
public class Nearest : MonoBehaviour
{
    public Transform GetNearestObject(List<Transform> objects, Transform target)
    {
        Transform nearestObject = null;
        float minDistance = float.MaxValue;
        float distance = 0f;

        foreach (Transform o in objects)
        {
            distance = (o.position - target.position).magnitude;
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestObject = o;
            }
        }
        return nearestObject;
    }
}
