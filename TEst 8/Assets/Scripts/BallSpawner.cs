using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    //public Transform target;
    public GameObject theBall;
    public ParticleSystem spawnFlash;

    public int speed;
    public bool shootAble = true;
    public bool isBallSpawningAllowed = true;
    public float waitBeforeNextShot = 0.2f;
    public bool ballCanSpawn = true;

    private void Start()
    {
        shootAble = true;
    }

    private void Awake()
    {
        shootAble = true;
    }

    void Update()
    {
        //transform.LookAt(target);
        if (isBallSpawningAllowed)
        {
            if (shootAble)
            {
                shootAble = false;
                Shooting();
                StartCoroutine(ShootingYield());
            }
        }
    }

    IEnumerator ShootingYield()
    {
        yield return new WaitForSeconds(waitBeforeNextShot);
        shootAble = true;
    }

    private void Shooting()
    {
        var ball = Instantiate(theBall, transform.position, transform.rotation);
        Instantiate(spawnFlash, transform.position, transform.rotation);        
    }
}
