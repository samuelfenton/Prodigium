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

}
