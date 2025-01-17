using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject bulletPrefab;

    float timeUntilFire;

    private void Start()
    {
    }

    private void Update()
    {
        
        //Invoke("Shoot", Random.Range(1000f,6000f));
        //Shoot();
        timeUntilFire = Time.time + fireRate;
    }

    void Shoot()
    {
        /*Vector3 mouseDelta = Input.mousePosition;
        float angle = Mathf.Atan2(mouseDelta.y, mouseDelta.x) * Mathf.Rad2Deg;
        if (angle < 0) angle += 360;*/
        Vector3 posBullet = new Vector3(0, 0, 0);
        posBullet = transform.position;
        //Debug.Log(posBullet);
        //posBullet[0] += 1;
        posBullet[1] += 1;
        // pos[1] -= 1;
        Instantiate(bulletPrefab, posBullet, Quaternion.Euler(new Vector3(0f, 0f, 0)));
    }

}


