using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState_Attack : NPCState 
{
    private float m_detectionRangeSqr = 10.0f;
    private float m_attackRangeSqr = 10.0f;

    private float m_forwardSpeed = 1.0f;
    private float m_rotationSpeed = 10.0f;

    private List<Player> m_possibleTargets = new List<Player>();
    private Player m_targetPlayer = null;

    //-------------------
    //Initilse the state, runs only once at start
    //-------------------
    public override void StateInit()
    {
        base.StateInit();
        m_detectionRangeSqr = m_NPC.m_detectionRange * m_NPC.m_detectionRange;
        m_attackRangeSqr = m_NPC.m_attackRange * m_NPC.m_attackRange;

        //Getiing possible targets
        GameObject[] m_playerObjects = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < m_playerObjects.Length; i++)
        {
            m_possibleTargets.Add(m_playerObjects[i].GetComponent<Player>());
        }

        m_forwardSpeed = m_NPC.m_forwardSpeed;
        m_rotationSpeed = m_NPC.m_rotationSpeed;
    }

    //-------------------
    //When swapping to this state, this is called.
    //-------------------
    public override void StateStart()
    {

    }

    //-------------------
    //State update, perform any actions for the given state
    //
    //Return bool: Has this state been completed, e.g. Attack has completed, idle would always return true 
    //-------------------
    public override bool UpdateState()
    {
        if(!TargetInRange() || !m_targetPlayer.IsAlive()) //Early break out when target is no onger in range, or dead
            return true;

        Vector3 targetDir = m_targetPlayer.transform.position - transform.position;
        targetDir.y = 0;

        //Rotate towards target
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetDir), m_rotationSpeed * Time.fixedDeltaTime);

        //Move forwards
        if(MOARMaths.SqrDistance(m_targetPlayer.gameObject, gameObject) > m_attackRangeSqr)
        {
            m_NPC.m_customPhysics.m_velocity.z = m_forwardSpeed;
        }
        else // Close enough to attack
        {
            //
        }
        return false;
    }

    //-------------------
    //When swapping to a new state, this is called.
    //-------------------
    public override void StateEnd()
    {

    }

    //-------------------
    //Do all of this states preconditions return true
    //
    //Return bool: Is this valid, Has a possible target
    //-------------------
    public override bool IsValid()
    {
        //Check for target in range
        return TargetInRange();
    }

    private bool TargetInRange()
    {
        if(m_targetPlayer!=null)
        {
            if (MOARMaths.SqrDistance(gameObject, m_targetPlayer.gameObject) < m_detectionRangeSqr)
            {
                return true; //Early breakout
            }
            m_targetPlayer = null;
        }

        //See if any close target
        foreach (Player player in m_possibleTargets)
        {
            if (MOARMaths.SqrDistance(gameObject, player.gameObject) < m_detectionRangeSqr)
            {
                m_targetPlayer = player;
                return true; //Early breakout
            }
        }

        return false;
    }
}
