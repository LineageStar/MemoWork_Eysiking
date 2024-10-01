using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{
    public Vector3 rotationPoint = new Vector3(-0.48f, 8.14f, 55.6f); // 旋转中心（世界坐标）
    public Vector3 rotationAxis = Vector3.up;            // 旋转轴（默认绕Y轴）
    public float rotationSpeed = 100f;                   // 旋转速度

    void Update()
    {
        // 绕指定点 rotationPoint 和指定轴 rotationAxis 进行旋转
        transform.RotateAround(rotationPoint, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
