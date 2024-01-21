using UnityEngine;
using TMPro;

public class Scr_EnemyView : MonoBehaviour
{
    public Scr_Spawner enemy;
    public TextMeshProUGUI enemyText;
    public Scr_PlayerConfig config;

    // Update is called once per frame
    void Update()
    {
        enemyText.text = "Enemy: " + enemy.HowManyChildren + "/" + config.MaxEnemy;
    }
}
