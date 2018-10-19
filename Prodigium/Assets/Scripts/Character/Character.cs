using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CustomPhysics))]
public class Character : MonoBehaviour
{
    public CustomPhysics m_customPhysics = null;

    [Header("Health and Shizz")]
    public float m_maxHealth = 1.0f;
    [SerializeField]
    protected float m_currentHealth = 1.0f;

    [Header("Movement and Shizz")]

    [SerializeField]
    public float m_forwardSpeed = 1.0f;
    [SerializeField]
    public float m_strafingSpeed = 1.0f;
    [SerializeField]
    public float m_rotationSpeed = 1.0f;

    [Header("Attacking/Armour and Shizz")]
    public WeaponInventory m_currentWeapon = null;
    public ArmourInventoru m_currentArmour = null;
    public float m_attackRange = 1.0f;

    [Header("Stats modifiers")]
    public float m_attackMod = 0.0f;
    public float m_speedMod = 0.0f;
    public float m_armourMod = 0.0f;
    public float m_healthMod = 0.0f;

    public float m_naturalResistance = 0;

    protected virtual void Start()
    {
        m_customPhysics = GetComponent<CustomPhysics>();
    }

    protected virtual void FixedUpdate()
    {
        m_customPhysics.UpdatePhysics();
    }

    public bool IsAlive()
    {
        return m_currentHealth <= 0;
    }

    public void ModifyHealth(float p_value)
    {
        m_currentHealth += p_value;
    }

    public void DealDamage(Character p_attackCharacter)
    {
        float damage = 0.0f;
        damage = p_attackCharacter.m_currentWeapon != null ? p_attackCharacter.m_currentWeapon.m_weaponDamage : 1; //Flat damage
        damage *= 1 + p_attackCharacter.m_attackMod; //Attack modified

        damage *= 1 - Mathf.Atan((m_naturalResistance + m_armourMod) * m_armourMod);//Run resitance through invers tan function, Addes to dimishing returns
        m_currentHealth -= damage;
    }
}
