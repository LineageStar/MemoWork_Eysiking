//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayMovement movement; // ����PlayMovement�ű�
    public Jump jump; // ����Jump�ű�
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false; // ����PlayMovement�ű�
            jump.enabled = false; // ����Jump�ű�
            Time.timeScale = 0f;
        }
    }
}
