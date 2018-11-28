using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour {

    public int SkillPoints = 0;

    public bool m_HealthSkill = false;
    int HealthTally = 0;

    public bool DamageSkill = false;
    int DamageTally = 0;

    public bool amorSkill = false;
    int amorTally = 0;

    public bool RageSkill = false;
    bool RageOn = false;

    public bool m_SweepingAttack = false;
    bool SweepOn = false;

    public bool m_SlamAttack = false;
    bool SlamOn = false;

    public bool m_throwAttack = false;
    bool throwOn = false;

    public bool m_RunAway = false;
    bool fearOn = false;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);    
    }

    // Update is called once per frame
    void Update()
    {

    }


    void healthCLickON()
    {
        
        if(SkillPoints >= 1 && HealthTally <= 5)
        {
            m_HealthSkill = true;
            HealthTally += 1;
            SkillPoints -= 1;

            //tp do: change sprite to light up mode later
        }
    }

    void DamageCLickON()
    {

        if (SkillPoints >= 1 && DamageTally <= 5)
        {
            DamageSkill = true;
            DamageTally += 1;
            SkillPoints -= 1;

            //tp do: change sprite to light up mode later
        }
    }

    void amorCLickON()
    {

        if ((m_HealthSkill) && SkillPoints >= 1 && amorTally <= 5)
        {
            amorSkill = true;
            amorTally += 1;
            SkillPoints -= 1;

            //tp do: change sprite to light up mode later
        }
    }

    void RageClickON()
    {
        if((DamageSkill) && SkillPoints >=1 && !RageOn)
        {
            RageOn = true;
            RageSkill = true;
            SkillPoints -= 1;
        }
    }

    void SweepClickON()
    {
        if(SkillPoints >= 1 && !SweepOn)
        {
            SweepOn = true;
            m_SweepingAttack = true;
            SkillPoints -= 1;
        }
    }

    void SlamClickON()
    {
        if ( (m_SweepingAttack) && SkillPoints >= 1 && !SlamOn)
        {
            SlamOn = true;
            m_SlamAttack = true;
            SkillPoints -= 1;
        }
    }

    void ThrowClickON()
    {
        if ((m_SlamAttack) && SkillPoints >= 1 && !throwOn)
        {
            throwOn = true;
            m_throwAttack = true;
            SkillPoints -= 1;
        }
    }

    void fearClickON()
    {
        if ((RageSkill) && SkillPoints >= 1 && !fearOn)
        {
           fearOn = true;
           m_RunAway = true;
           SkillPoints -= 1;
        }
    }

}
