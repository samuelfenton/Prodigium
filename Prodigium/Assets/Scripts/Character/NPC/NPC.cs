using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character 
{
    [Header("NPC stuff")]
    [SerializeField]
    protected float m_detectionRange = 10.0f;
    protected float m_detectionRangeSqr = 10.0f;

    protected List<Player> m_playerTargets = new List<Player>();

    protected Player m_selectedTarget = null;

    protected override void Start()
    {
        GameObject[] m_playerObjects = GameObject.FindGameObjectsWithTag("Player");
            
        for (int i = 0; i < m_playerObjects.Length; i++)
        {
            m_playerTargets.Add(m_playerObjects[i].GetComponent<Player>());
        }
    }

    protected override void FixedUpdate()
    {
        if(m_selectedTarget == null)
        {
            //See if any close target
            foreach (Player player in m_playerTargets)
            {
                player
            }
        }

        //Movement
        Vector3 velocity = m_customPhysics.m_velocity;

        velocity = m_customPhysics.m_velocity;
        velocity.z = m_forwardSpeed * Input.GetAxisRaw("Vertical");
        velocity.x = m_strafingSpeed * Input.GetAxisRaw("Horizontal");

        m_customPhysics.m_velocity = velocity;

        //Rotation
        transform.RotateAround(transform.position, Vector3.up, Input.GetAxisRaw("MouseX") * m_rotationSpeed * Time.fixedDeltaTime);

        base.FixedUpdate();
    }
}
