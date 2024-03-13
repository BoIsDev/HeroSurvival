using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShootManager : MonoBehaviour
{
    public GameObject bulletPrefab;
    public void ShootBullet(GameObject bulletPrefab, Transform spawnPoint, float delay)
    {
        StartCoroutine(ShootAfterDelay(bulletPrefab, spawnPoint, delay));
    }

    private IEnumerator ShootAfterDelay(GameObject bulletPrefab, Transform spawnPoint, float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    void update()
    {
        ShootSwordTime();
    }
    void ShootSwordTime()
    {}
}
