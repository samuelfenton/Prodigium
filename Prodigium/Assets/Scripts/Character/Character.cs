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

    [Header("Attacking and Shizz")]
    public float m_attackRange = 1.0f;
    public float m_attackDamage = 1.0f;

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
}
