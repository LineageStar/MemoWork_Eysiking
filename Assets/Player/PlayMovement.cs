//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int moveSpeed = 10;
    public int stopZValue = 100;
    public Vector3 customGravity = new Vector3(0, -30f, 0);
    public float ForwordsSpeed = 0.7f;
    
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(0, 0, 1000 * Time.deltaTime);
        float moveHorizontal = Input.GetAxis("Horizontal"); // 获取水平输入
        Vector3 movement = new Vector3(moveHorizontal, 0f, ForwordsSpeed); // 创建移动向量
        transform.position += movement * moveSpeed * Time.deltaTime; // 移动物体
        rb.AddForce(customGravity * Time.deltaTime, ForceMode.Acceleration);
        if (transform.position.z > stopZValue)
        {
            Time.timeScale = 0f; // 通过将时间缩放设置为0来暂停游戏
            //如果你想重新加载场景，可以使用以下代码
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
