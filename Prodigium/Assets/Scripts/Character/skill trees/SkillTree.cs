using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour {

    public int SkillPoints = 0;

    public bool HealthSkill = false;
    int HealthTally = 0;
   
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
            HealthSkill = true;
            HealthTally += 1;
            SkillPoints -= 1;

            //tp do: change sprite to light up mode later
        }
    }

}
