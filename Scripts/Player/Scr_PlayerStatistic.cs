using UnityEngine;

public class Scr_PlayerStatistic : MonoBehaviour
{
    public Scr_PlayerConfig config;
    
    private float playerSpeed;
    private float dashCooldown;
    private float dashDuration;
    private float dashSpeed;
    private float bulletSpeed;
    private int maxBullets;
    private int currentBullets;
    private float reloadCooldown;
    private int bulletDamage;

    private bool isDashing = false;
    private bool isReloading = false;

    private void Start()
    {
        StartConfig();
    }


    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }
    public float DashCooldown { get => dashCooldown; set => dashCooldown = value; }
    public float DashDuration { get => dashDuration; set => dashDuration = value; }
    public float DashSpeed { get => dashSpeed; set => dashSpeed = value; }
    public bool IsDashing { get => isDashing; set => isDashing = value; }
    public float BulletSpeed { get => bulletSpeed; set => bulletSpeed = value; }
    public int MaxBullets { get => maxBullets; set => maxBullets = value; }
    public int CurrentBullets { get => currentBullets; set => currentBullets = value; }
    public float Cooldown { get => reloadCooldown; set => reloadCooldown = value; }
    public bool IsReloading { get => isReloading; set => isReloading = value; }
    public int BulletDamage { get => bulletDamage; set => bulletDamage = value; }

    void StartConfig()
    {
        if (config.GetComponent<Scr_PlayerConfig>())
        {


            this.playerSpeed = config.PlayerSpeed;
            this.dashCooldown = config.DashCooldown;
            this.dashDuration = config.DashDuration;
            this.dashSpeed = config.DashSpeed;
            this.bulletSpeed = config.BulletSpeed;
            this.maxBullets = config.MaxBullets;
            this.currentBullets = config.CurrentBullets;
            this.reloadCooldown = config.ReloadCooldown;
            this.bulletDamage = config.BulletDamage;
        }
        else
        {
            Debug.Log("Nie istnieje");
        }
    }

    public void Reset()
    {
        StartConfig();
    }

}
