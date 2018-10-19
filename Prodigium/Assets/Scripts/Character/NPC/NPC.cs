using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character 
{
    [Header("NPC stuff")]
    [SerializeField]
    public float m_detectionRange = 10.0f;

    private StateMachine m_NPCStateMachine = null;

    protected override void Start()
    {
        base.Start();

        m_NPCStateMachine = GetComponent<StateMachine>();

#if UNITY_EDITOR
        if (m_NPCStateMachine == null)
            Debug.Log("NPC has no state machine attached");
#endif

        m_NPCStateMachine.InitStateMachine();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        m_NPCStateMachine.UpdateStateMachine();
    }
}
