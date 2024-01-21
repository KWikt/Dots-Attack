using UnityEngine;

public class Scr_Bullet : MonoBehaviour
{

    private GameObject player;
    private Scr_PlayerStatistic statistic;
    private int damage;

    private void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
       statistic = GameObject.FindObjectOfType< Scr_PlayerStatistic>();
       damage = statistic.BulletDamage;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            
        }
       
    }

    public int Damage()
    {
        return damage;
    }




}
