using UnityEngine;

public class ObjectDisappearOnZAxis : MonoBehaviour
{
    public GameObject player;  // �趨��Ҷ���

    int frameCount = 0;

    void Update()
    {
        frameCount++;
        if (frameCount % 10 == 0)  // ÿ10֡���һ��
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
