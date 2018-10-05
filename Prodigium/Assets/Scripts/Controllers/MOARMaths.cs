using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOARMaths : MonoBehaviour 
{
    public static float SqrDistance(Vector3 p_pos1, Vector3 p_pos2)
    {
        Vector3 distanceVector = p_pos2 - p_pos1;
        return distanceVector.x * distanceVector.x + distanceVector.y * distanceVector.y + distanceVector.z * distanceVector.z;
    }

    public static float SqrDistance(GameObject p_obj1, GameObject p_obj2)
    {
        return SqrDistance(p_obj1.transform.position, p_obj2.transform.position);
    }

}
