using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour 
{
	public CustomPhysics m_customPhysics = null;

	public float m_maxHealth = 1.0f;
    
    private float m_currentHealth = 1.0f;
    
	protected virtual void Start()
	{
		//m_customPhysics = GetComponent(
	}

	protected virtual void FixedUpdate()
	{

	}

	public bool IsAlive()
	{
		return m_currentHealth <= 0;
	}
}
