using UnityEngine;

public class Scr_PlayerConfig : MonoBehaviour
{
    [Header("Movement Properties")]
    [SerializeField] float playerSpeed;

    [Header("Dash Properties")]
    [SerializeField] float dashSpeed;
    [SerializeField] float dashDuration;
    [SerializeField] float dashCooldown;

    [Header("Bullet Properties")]
    [SerializeField] float bulletSpeed;
    [SerializeField] int bulletDamage;


    [Header("Reload Properties")]
    [SerializeField] int maxBullets;
    [SerializeField] int currentBullets;
    [SerializeField] float reloadCooldown;

    [Header("Enemy Properties")]
    [SerializeField] int health;
    [SerializeField] int points;

    [Header("Enemy Price Properties")]
    [SerializeField] int healthEnemyPrice;

    [Header("Spawner Properties")]
    [SerializeField] float spawnRate;
    [SerializeField] int maxEnemy;
    [SerializeField] int firstStart;

    [Header("Mutator Properties")]
    [SerializeField] float fasterSpawnEnemy;
    [SerializeField] float slowerSpawnEnemy;

    [SerializeField] float moreMoveSpeed;
    [SerializeField] float lessMoveSpeed;

    [SerializeField] int moreDamage;
    [SerializeField] int lessDamage;

    [SerializeField] float fasterReload;
    [SerializeField] float slowerReload;

    [SerializeField] float fasterBullets;
    [SerializeField] float slowerBullets;

    [SerializeField] int moreMaxBullets;
    [SerializeField] int lessMaxBullets;

    [SerializeField] int moreEnemyHealth;
    [SerializeField] int lessEnemyHealth;

    [SerializeField] float fasterEnemyRespown;
    [SerializeField] float slowerEnemyRespown;

    [SerializeField] float fasterDash;
    [SerializeField] float slowerDash;

    [SerializeField] float longerDash;
    [SerializeField] float shorterDash;

    [SerializeField] float fasterDashCooldown;
    [SerializeField] float slowerDashCooldown;

    [SerializeField] int maxEnemyDowngrade;
    [SerializeField] int maxEnemyUpgrade;


    public float DashSpeed { get => dashSpeed; set => dashSpeed = value; }
    public float DashDuration { get => dashDuration; set => dashDuration = value; }
    public float DashCooldown { get => dashCooldown; set => dashCooldown = value; }
    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }
    public float BulletSpeed { get => bulletSpeed; set => bulletSpeed = value; }
    public int MaxBullets { get => maxBullets; set => maxBullets = value; }
    public int CurrentBullets { get => currentBullets; set => currentBullets = value; }
    public float ReloadCooldown { get => reloadCooldown; set => reloadCooldown = value; }
    public int BulletDamage { get => bulletDamage; set => bulletDamage = value; }
    public int Health { get => health; set => health = value; }
    public int Points { get => points; set => points = value; }
    public float SpawnRate { get => spawnRate; set => spawnRate = value; }
    public int MaxEnemy { get => maxEnemy; set => maxEnemy = value; }
    public int FirstStart { get => firstStart; set => firstStart = value; }
    public int HealthEnemyPrice { get => healthEnemyPrice; set => healthEnemyPrice = value; }




    public float FasterSpawnEnemy { get => fasterSpawnEnemy; set => fasterSpawnEnemy = value; }
    public float SlowerSpawnEnemy { get => slowerSpawnEnemy; set => slowerSpawnEnemy = value; }
    public float MoreMoveSpeed { get => moreMoveSpeed; set => moreMoveSpeed = value; }
    public float LessMoveSpeed { get => lessMoveSpeed; set => lessMoveSpeed = value; }
    public int MoreDamage { get => moreDamage; set => moreDamage = value; }
    public int LessDamage { get => lessDamage; set => lessDamage = value; }
    public float FasterReload { get => fasterReload; set => fasterReload = value; }
    public float SlowerReload { get => slowerReload; set => slowerReload = value; }
    public float FasterBullets { get => fasterBullets; set => fasterBullets = value; }
    public float SlowerBullets { get => slowerBullets; set => slowerBullets = value; }
    public int MoreMaxBullets { get => moreMaxBullets; set => moreMaxBullets = value; }
    public int LessMaxBullets { get => lessMaxBullets; set => lessMaxBullets = value; }
    public int MoreEnemyHealth { get => moreEnemyHealth; set => moreEnemyHealth = value; }
    public int LessEnemyHealth { get => lessEnemyHealth; set => lessEnemyHealth = value; }
    public float FasterEnemyRespown { get => fasterEnemyRespown; set => fasterEnemyRespown = value; }
    public float SlowerEnemyRespown { get => slowerEnemyRespown; set => slowerEnemyRespown = value; }
    public float FasterDash { get => fasterDash; set => fasterDash = value; }
    public float SlowerDash { get => slowerDash; set => slowerDash = value; }
    public float FasterDashCooldown { get => fasterDashCooldown; set => fasterDashCooldown = value; }
    public float SlowerDashCooldown { get => slowerDashCooldown; set => slowerDashCooldown = value; }
    public int MaxEnemyDowngrade { get => maxEnemyDowngrade; set => maxEnemyDowngrade = value; }
    public int MaxEnemyUpgrade { get => maxEnemyUpgrade; set => maxEnemyUpgrade = value; }
    public float LongerDash { get => longerDash; set => longerDash = value; }
    public float ShorterDash { get => shorterDash; set => shorterDash = value; }
}
