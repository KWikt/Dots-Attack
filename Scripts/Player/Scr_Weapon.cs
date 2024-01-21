using UnityEngine;

public class Scr_Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Scr_PlayerStatistic bulletSpeed; 

    public void CreateBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * bulletSpeed.BulletSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }



}
