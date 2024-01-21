using UnityEngine;

public class Scr_AnimationReload : MonoBehaviour
{


    public Animator relaodAnim;
    public Scr_PlayerStatistic playerStatistic;


    public void ReloadStart()
    {
        relaodAnim.speed = 1 / playerStatistic.Cooldown;
        relaodAnim.SetTrigger("Reload");
    }
    
    public void StopReload()
    {
        relaodAnim.SetTrigger("ExitReload");
    }

}
