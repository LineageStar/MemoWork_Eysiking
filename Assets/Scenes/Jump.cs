using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 0.5f; // 跳起的力量
    public float groundYValue = 1.2f; // 地面的Y轴阈值
    private Rigidbody rb; // 引用Rigidbody
    private bool isGrounded = false; // 用于检查是否在地面上

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 检查按下空格键并确保物体在地面上
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
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // 施加向上的力
    }
}
