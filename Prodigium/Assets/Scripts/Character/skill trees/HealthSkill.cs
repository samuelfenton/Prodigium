﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSkill : SkillTree
{

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
    
     if(m_treeSkill.m_HealthSkill)
        {
            m_player.m_maxHealth += 20;
        }

    }
}
