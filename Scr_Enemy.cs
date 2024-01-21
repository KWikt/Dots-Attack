using UnityEngine;


public class Scr_Enemy : MonoBehaviour
{

    private int health;
    private GameObject gameLogic;
    private GameObject bullet;
    private Scr_Bullet bulletScript;
    private Scr_Score score;
    private Scr_PlayerConfig statistic;
    private Scr_Spawner spawner;

    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Scr_Spawner>();
        gameLogic = GameObject.FindGameObjectWithTag("GameLogic");
        score = gameLogic.GetComponent<Scr_Score>();
        statistic = gameLogic.GetComponent<Scr_PlayerConfig>();
        health = statistic.Health;
    }

    private void Update()
    {
        if (Health <= 0)
        {
            Death();
        }
    }

    public int Health { get => health; set => health = value; }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) 
        {
            SetupBullet();
            if (Health > 0)
            {
                Debug.Log("Hit Bullet");
                health -= bulletScript.Damage();
            }
            
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
            spawner.Spawner();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
        score.addPoints();
    }

    private void SetupBullet()
    {
            bullet = GameObject.FindGameObjectWithTag("Bullet");
            bulletScript = bullet.GetComponent<Scr_Bullet>();
    }


}
