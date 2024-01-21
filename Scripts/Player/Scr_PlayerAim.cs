using UnityEngine;

public class Scr_PlayerAim : MonoBehaviour
{
    public Rigidbody2D playerRigidbody2D;
    public Camera mainCamera;


    void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        Vector2 mouseScreenPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 aimDirection = mouseScreenPosition - playerRigidbody2D.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        playerRigidbody2D.rotation = aimAngle;
    }
}
