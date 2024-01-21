using UnityEngine;

public class Scr_Reward : MonoBehaviour
{

    public Scr_PlayerConfig rewardStats;
    public Scr_PlayerStatistic playerStatistic;
    public Debugger debugger;


    [SerializeField] bool debugOn;

    private int prizeGood;
    private int prizeBad;
    public void GetPrize()
    {
        GetPrizeGood();
        GetPrizeBad();
    }

    void GetPrizeGood()
    {
        PrizePoolGood(prizeGood);
    }

    void GetPrizeBad()
    {
        PrizePoolBad(prizeBad);
    }

    private void Update()
    {
        prizeGood = RandomDrawTwo();
        prizeBad = RandomDrawOne();
    }

    private int RandomDrawTwo()
    {
        
        return Random.Range(0,11);
    }
     private int RandomDrawOne()
    {
        
        return Random.Range(0,11);
    }






    private void PrizePoolGood(int number)
    {
        switch (number)
        {
            case 0:
                playerStatistic.PlayerSpeed += rewardStats.MoreMoveSpeed;
                
                debugger.Log("Player Speed increased", debugOn);
                break;
            case 1:
                playerStatistic.DashSpeed += rewardStats.FasterDash;
               
                debugger.Log("Dash Speed increased", debugOn);
                break;
            case 2:
                playerStatistic.DashDuration += rewardStats.LongerDash;
                
                debugger.Log("Dash Distance increased", debugOn);
                break;
            case 3:
                playerStatistic.BulletSpeed += rewardStats.FasterBullets;
               
                debugger.Log("Bullet Speed increased", debugOn);
                break;
            case 4:
                if (playerStatistic.DashCooldown == 0.25)
                {
                    GetPrizeGood();
                }
                else
                {
                    playerStatistic.DashCooldown += rewardStats.SlowerDashCooldown;
                    
                    debugger.Log("Dash Cooldown decreased", debugOn);
                }
                break;
            case 5:
                playerStatistic.BulletDamage += rewardStats.MoreDamage;
              
                debugger.Log("Damage increased", debugOn);
                break;
            case 6:
                playerStatistic.MaxBullets += rewardStats.MoreMaxBullets;
              
                debugger.Log("Max Bullet increased", debugOn);
                break;
            case 7:
                if (playerStatistic.MaxBullets == 1)
                {
                    GetPrizeGood();
                }
                else
                {
                    playerStatistic.Cooldown += rewardStats.SlowerReload;
                    
                    debugger.Log("Reload Cooldown decreased", debugOn);
                }
                break;
            case 8:
                if (rewardStats.Health == 1)
                {
                    GetPrizeGood();
                }
                else
                {
                    rewardStats.Health += rewardStats.LessEnemyHealth;
                   
                    debugger.Log("Enemy Health decreased", debugOn);
                }
                break;
            case 9:
                if (rewardStats.SpawnRate == 1)
                {
                    GetPrizeGood();
                }
                else
                {
                    rewardStats.SpawnRate += rewardStats.SlowerSpawnEnemy;
                   
                    debugger.Log("Enemy Respawn decreased", debugOn);
                }
                break;
            case 10:
                rewardStats.MaxEnemy += rewardStats.MaxEnemyUpgrade;
               
                debugger.Log("Max Enemy Pool increased", debugOn);
                break;
        }
    }

    private void PrizePoolBad(int number)
    {
        switch (number)
        {
            case 0:
                if (playerStatistic.PlayerSpeed == 2)
                {
                    GetPrizeBad();
                }
                else
                {
                    playerStatistic.PlayerSpeed += rewardStats.LessMoveSpeed;
                   
                    debugger.Log("Player Speed decreased", debugOn);
                }
                break;
            case 1:
                if (playerStatistic.DashSpeed == 5)
                {
                    GetPrizeBad();
                }
                else
                {
                    playerStatistic.DashSpeed += rewardStats.SlowerDash;
                   
                    debugger.Log("Dash Speed decreased", debugOn);
                }
                break;
            case 2:
                if (playerStatistic.DashDuration == 0.1)
                {
                    GetPrizeBad();
                }
                else
                {
                    playerStatistic.DashDuration += rewardStats.ShorterDash;
                    
                    debugger.Log("Dash Distance decreased", debugOn);
                }
                break;
            case 3:
                playerStatistic.DashCooldown += rewardStats.FasterDashCooldown;
               
                debugger.Log("Dash Cooldown increased", debugOn);
                break;
            case 4:
                if (playerStatistic.BulletSpeed == 20)
                {
                    GetPrizeBad();
                }
                else
                {
                    playerStatistic.BulletSpeed += rewardStats.SlowerBullets;
                  
                    debugger.Log("Bullet Speed decreased", debugOn);
                }
                break;
            case 5:
                if (playerStatistic.BulletDamage == 1)
                {
                    GetPrizeBad();
                }
                else
                {
                    playerStatistic.BulletDamage += rewardStats.LessDamage;
                   
                    debugger.Log("Damage decreased", debugOn);
                }
                
                break;
            case 6:
                if (playerStatistic.MaxBullets == 1)
                {
                    GetPrizeBad();
                }
                else
                {
                    playerStatistic.MaxBullets += rewardStats.LessMaxBullets;
                   
                    debugger.Log("Max Bullet decreased", debugOn);
                }
                break;
            case 7:
                playerStatistic.Cooldown += rewardStats.FasterReload;
               
                debugger.Log("Reload Cooldown increased", debugOn);
                break;
            case 8:
                rewardStats.Health += rewardStats.MoreEnemyHealth;
               
                debugger.Log("Enemy Health increased", debugOn);
                break;
            case 9:
                rewardStats.SpawnRate += rewardStats.FasterSpawnEnemy;
               
                debugger.Log("Enemy Respawn increased", debugOn);
                break;
            case 10:
                if (rewardStats.MaxEnemy == 4)
                {
                    GetPrizeBad();
                }
                else
                {
                    rewardStats.MaxEnemy += rewardStats.MaxEnemyDowngrade;
                 
                    debugger.Log("Max Enemy Pool decreased", debugOn);
                }
                break;

        }


    }



}