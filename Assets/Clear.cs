using UnityEngine;

public class ObjectDisappearOnZAxis : MonoBehaviour
{
    public GameObject player;  // 设定玩家对象

    int frameCount = 0;

    void Update()
    {
        frameCount++;
        if (frameCount % 10 == 0)  // 每10帧检查一次
        {
            float objectZ = transform.position.z;
            float playerZ = player.transform.position.z;

            if (objectZ < playerZ - 10)
            {
                Destroy(gameObject);
            }
        }
    }

}
