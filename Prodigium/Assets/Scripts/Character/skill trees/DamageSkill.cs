﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSkill : SkillTree {


    private SkillTree m_treeSkill;
    private Player m_player;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void SKillClcikedOn()
    {

        if (m_treeSkill.DamageSkill)
        {
            m_player.m_attackMod += 0.2f ;
        }

    }
}
