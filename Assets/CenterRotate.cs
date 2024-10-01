using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{
    public Vector3 rotationPoint = new Vector3(-0.48f, 8.14f, 55.6f); // ��ת���ģ��������꣩
    public Vector3 rotationAxis = Vector3.up;            // ��ת�ᣨĬ����Y�ᣩ
    public float rotationSpeed = 100f;                   // ��ת�ٶ�

    void Update()
    {
        // ��ָ���� rotationPoint ��ָ���� rotationAxis ������ת
        transform.RotateAround(rotationPoint, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
