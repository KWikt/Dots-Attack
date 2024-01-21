using UnityEngine;


public class Scr_EnemyPrice : MonoBehaviour
{

    private int health;
    private GameObject gameLogic;
    private GameObject bullet;
    private Scr_Bullet bulletScript;
    private Scr_PlayerConfig statistic;
    private Scr_Reward reward;
    private Scr_Spawner spawner;
    private Scr_Score score;


    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Scr_Spawner>();
        gameLogic = GameObject.FindGameObjectWithTag("GameLogic");
        statistic = gameLogic.GetComponent<Scr_PlayerConfig>();
        score = gameLogic.GetComponent<Scr_Score>();
        reward = gameLogic.GetComponent<Scr_Reward>();

        health = statistic.HealthEnemyPrice;
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
       
        reward.GetPrize();
        if(score.Points == 0)
        {
            score.addPoints();
        }
        else
        {
            score.subtractPoints();
        }
        Destroy(gameObject);
       
    }

    private void SetupBullet()
    {
        bullet = GameObject.FindGameObjectWithTag("Bullet");
        bulletScript = bullet.GetComponent<Scr_Bullet>();
    }




}
