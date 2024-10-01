//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayMovement movement; // 引用PlayMovement脚本
    public Jump jump; // 引用Jump脚本
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false; // 禁用PlayMovement脚本
            jump.enabled = false; // 禁用Jump脚本
            Time.timeScale = 0f;
        }
    }
}
