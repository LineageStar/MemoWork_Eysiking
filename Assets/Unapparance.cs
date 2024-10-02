using UnityEngine;

public class ObjectDisappearOnCollision : MonoBehaviour
{
    // 这里可以通过标签或其他方式来确认是玩家
    public string playerTag = "Player";

    // 当物体与另一个物体发生触发碰撞时被调用
    private void OnTriggerEnter(Collider other)
    {
        // 检查碰撞的物体是否是玩家
        if (other.CompareTag(playerTag))
        {
            // 销毁当前物体
            Destroy(gameObject);
        }
    }
}
