using UnityEngine;

public class Scr_PlayerMovement : MonoBehaviour
{

    public Scr_PlayerInput playerInput;
    public Rigidbody2D playerRigidbody2D;
    public Scr_PlayerStatistic statistic;

    private void FixedUpdate()
    {
        Movement(statistic.PlayerSpeed);
    }

    void Movement(float speed)
    {
        if (!statistic.IsDashing)
        {
            playerRigidbody2D.velocity = playerInput.InputDirection() * speed * Time.fixedDeltaTime;
        }
    }


}
