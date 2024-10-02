using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 旋转 : MonoBehaviour
{
    public float rotateSpeed = 100f; // 旋转速度
    public int rotateX = 0; // X轴旋转
    public int rotateY = 0; // Y轴旋转
    public int rotateZ = 0; // Z轴旋转
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX * rotateSpeed * Time.deltaTime, rotateY * rotateSpeed * Time.deltaTime, rotateZ * rotateSpeed * Time.deltaTime); // 旋转物体
    }
}
