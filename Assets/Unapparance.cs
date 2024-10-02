using UnityEngine;

public class ObjectDisappearOnCollision : MonoBehaviour
{
    // �������ͨ����ǩ��������ʽ��ȷ�������
    public string playerTag = "Player";

    // ����������һ�����巢��������ײʱ������
    private void OnTriggerEnter(Collider other)
    {
        // �����ײ�������Ƿ������
        if (other.CompareTag(playerTag))
        {
            // ���ٵ�ǰ����
            Destroy(gameObject);
        }
    }
}
