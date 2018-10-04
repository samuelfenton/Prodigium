using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour {

    public int SkillPoints;

    [SerializeField]
    private GameObject m_baseSkills;

    private bool Skill = false;
    
	// Use this for initialization
	void Start ()
    {
        SkillPoints = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


   void SKillClcikedOn()
    {
        //game object light up and turn on code goes here
        Skill = true;
        


    }

    //in sepreate skript
    void lightup()
    {
        if(Skill)
        {
           //set what skill does
        }
    }

}
