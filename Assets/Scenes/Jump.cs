using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 0.5f; // ���������
    public float groundYValue = 1.2f; // �����Y����ֵ
    private Rigidbody rb; // ����Rigidbody
    private bool isGrounded = false; // ���ڼ���Ƿ��ڵ�����

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ��鰴�¿ո����ȷ�������ڵ�����
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            JumpUp();
        }
        if (transform.position.y <= groundYValue)
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }
    }

    void JumpUp()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // ʩ�����ϵ���
    }
}
