//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FllowPlayer : MonoBehaviour
{

    public Transform player; // 引用玩家位置
    public Vector3 offset; // 相机偏移量
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position); // 打印玩家位置
        transform.position = player.position + offset;
    }
}
