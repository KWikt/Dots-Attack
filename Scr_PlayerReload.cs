using System.Collections;
using UnityEngine;

public class Scr_PlayerReload : MonoBehaviour
{

    public Scr_PlayerStatistic playerStatistic;
    public Scr_PlayerInput playerInput;
    public Scr_AnimationReload animationReload;

    // Update is called once per frame


    void Update()
    {
        Reload();
    }

    public IEnumerator ReloadingSequence()
    {
        
        animationReload.ReloadStart();
        playerStatistic.IsReloading = true;
        animationReload.StopReload();
        yield return new WaitForSeconds(playerStatistic.Cooldown);
        playerStatistic.IsReloading = false;
        playerStatistic.CurrentBullets = playerStatistic.MaxBullets;
        
        

    }

    public void Reload()
    {
        if (!playerStatistic.IsDashing)
        {
            if (playerInput.ReloadInput() && playerStatistic.CurrentBullets != playerStatistic.MaxBullets && !playerStatistic.IsReloading)
            {
                StartCoroutine(ReloadingSequence());
            }
        }

    }


}

