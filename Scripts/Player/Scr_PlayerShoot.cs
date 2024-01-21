using UnityEngine;

public class Scr_PlayerShoot : MonoBehaviour
{

    public Scr_PlayerStatistic statistic;
    public Scr_PlayerInput playerInput;
    public GameObject firePoint;
    private Scr_Weapon weaponScript;
    public Scr_PlayerReload playerReload;

    
    [Header("Debugging")]
    public Debugger debugger;
    [SerializeField] bool shootDebug;

    private void Start()
    {
        weaponScript = firePoint.GetComponent<Scr_Weapon>();
    }

    private void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if (!statistic.IsDashing && !statistic.IsReloading)
        {
            if (playerInput.FireInput())
            {
                if(statistic.CurrentBullets > 0)
                {
                    weaponScript.CreateBullet();
                    debugger.Log("Fire: " + statistic.CurrentBullets, shootDebug);
                    statistic.CurrentBullets -= 1;
                }
                else
                {
                    playerReload.StartCoroutine(playerReload.ReloadingSequence());
                }
                
            }
        }
    }

  
}
