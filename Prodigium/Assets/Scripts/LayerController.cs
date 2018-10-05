using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour 
{
    public static int m_enviroment = 0;

    static LayerController()
    {
        m_enviroment = LayerMask.GetMask("Enviroment");
    }
}
