using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class CustomPhysics : MonoBehaviour 
{
    public static float GRAVITY = -9.8f;

    public Vector3 m_velocity = Vector3.zero;
    private CapsuleCollider m_capsuleCollider = null;

    private Vector3 m_colliderExtents = Vector3.zero;   

    private void Start()
    {
        m_capsuleCollider = GetComponent<CapsuleCollider>();
        m_colliderExtents.x = m_colliderExtents.z = m_capsuleCollider.radius;
        m_colliderExtents.y = m_capsuleCollider.height / 2.0f;
    }

    public void UpdatePhysics()
    {
        SnapToGround();

        //Local translat, so moving forwards is simply vector3.forward, not translate.forward
        transform.Translate(m_velocity * Time.fixedDeltaTime);
    }

    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, m_colliderExtents.y, LayerController.m_enviroment);
    }

    public void SnapToGround()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, -Vector3.up, out hit, m_colliderExtents.y * 2.0f, LayerController.m_enviroment))
        {
            Vector3 position = transform.position;
            position.y = hit.point.y + m_colliderExtents.y;
            transform.position = position;
        }
    }

}
