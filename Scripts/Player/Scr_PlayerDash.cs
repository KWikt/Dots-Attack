using System.Collections;
using UnityEngine;

public class Scr_PlayerDash : MonoBehaviour
{

    public Scr_PlayerInput playerInput;
    public Scr_PlayerStatistic playerStatistic;
    public Rigidbody2D playerRigidbody2D;

    private void Update()
    {
        Dash();
    }

    public void Dash()
    {
        if (!playerStatistic.IsDashing)
        {
            if (playerInput.DashInput())
            {
                StartCoroutine(DashProperty());
            }
        }
    }



    private IEnumerator DashProperty()
    {
        playerStatistic.IsDashing = true;
        playerRigidbody2D.velocity = playerInput.InputDirection() * playerStatistic.DashSpeed * Time.fixedDeltaTime;
        yield return new WaitForSeconds(playerStatistic.DashDuration);
        playerStatistic.IsDashing = false;


    }


   



     

        


















    }
