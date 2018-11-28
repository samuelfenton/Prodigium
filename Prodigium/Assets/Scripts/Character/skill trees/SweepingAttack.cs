using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweepingAttack : SkillTree {

    private SkillTree m_treeSkill;
    private Player m_player;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SKillClcikedOn()
    {

        if (m_treeSkill.m_SweepingAttack)
        {
            m_player.m_SweepActive = true;
        }

    }
}
