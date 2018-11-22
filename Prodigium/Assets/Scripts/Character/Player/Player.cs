using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character 
{
    public bool m_enraged = false;
    public bool m_bleedDamage = false;
    public bool m_sweep = false;
    public bool m_slam = false;
    public bool m_power = false;

    protected override void FixedUpdate()
    {
        //Movement
        Vector3 velocity = m_customPhysics.m_velocity;

        velocity = m_customPhysics.m_velocity;
        velocity.z = m_forwardSpeed * Input.GetAxisRaw("Vertical");
        velocity.x = m_strafingSpeed * Input.GetAxisRaw("Horizontal");

        m_customPhysics.m_velocity = velocity;

        //Rotation
        transform.RotateAround(transform.position, Vector3.up, Input.GetAxisRaw("MouseX") * m_rotationSpeed * Time.fixedDeltaTime);

        base.FixedUpdate();
    }

}
