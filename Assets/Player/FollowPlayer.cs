//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FllowPlayer : MonoBehaviour
{

    public Transform player; // �������λ��
    public Vector3 offset; // ���ƫ����
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position); // ��ӡ���λ��
        transform.position = player.position + offset;
    }
}
