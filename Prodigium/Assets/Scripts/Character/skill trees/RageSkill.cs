using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RageSkill : SkillTree {

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

        if (m_treeSkill.RageSkill)
        {
            m_player.m_RageActive = true;
        }

    }
}
