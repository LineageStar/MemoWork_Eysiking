using TMPro;
using UnityEngine;

public class GetSource : MonoBehaviour
{
    public string ScoreTag = "Score";
    public string ShootTag = "Shoot";
    public string AidTag = "Aid";
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI HPText;
    public int HP = 5;
    public int score = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        // 检查碰撞的物体是否是玩家
        if (other.CompareTag(ScoreTag))
        {
            score = score + 1;
            scoreText.text = "Score: " + score;
        }
        if (other.CompareTag(AidTag))
        {
            HP = HP + 1;
            HPText.text = "HP: " + HP;
        }
        if (other.CompareTag(ShootTag))
        {
            HP = HP - 1;
            HPText.text = "HP: " + HP;
            if (HP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
