using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character 
{
    [Header("NPC stuff")]
    [SerializeField]
    public float m_detectionRange = 10.0f;

    protected override void Start()
    {

    }

    protected override void FixedUpdate()
    {

        base.FixedUpdate();
    }
}
