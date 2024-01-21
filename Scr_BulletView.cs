using TMPro;
using UnityEngine;

public class Scr_BulletView : MonoBehaviour
{
    public Scr_PlayerStatistic stats;
    public TextMeshProUGUI bullets;


    // Update is called once per frame
    void Update()
    {
        bullets.text = "Bullets: " + stats.CurrentBullets + "/" + stats.MaxBullets;
    }
}
