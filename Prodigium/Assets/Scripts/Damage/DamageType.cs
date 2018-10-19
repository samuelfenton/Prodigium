using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageType : MonoBehaviour {

    public enum Damage
    {
        normal,
        bleed,
        poison,
        fire,
        lightning,
        force,
        ice,
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DamageTypes(Damage dam)
    {

        switch (dam)
        {
            case Damage.normal:
                normalDam();
                break;
            case Damage.bleed:
                bleedDam();
                break;
            case Damage.poison:
                poisonDam();
                break;
            case Damage.fire:
                fireDam();
                break;
            case Damage.lightning:
                lightningDam();
                break;
            case Damage.force:
                forceDam();
                break;
            case Damage.ice:
                IceDam();
                break;
        }
    }

    void normalDam()
    {

    }

    void bleedDam()
    {

    }

    void poisonDam()
    {

    }

    void fireDam()
    {

    }

    void lightningDam()
    {

    }

    void forceDam()
    {

    }

    void IceDam()
    {

    }

}
