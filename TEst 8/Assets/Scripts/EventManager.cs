using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public GameObject HomingSpawner1;
    public GameObject HomingShield1;
    public GameObject HomingSpawner2;
    public GameObject HomingShield2;
    public GameObject ShooterSpawner1;
    public GameObject ShooterShield1;
    public GameObject SwarmSpawner1;
    public GameObject SwarmShield1;
    public GameObject Boss;
    public GameObject BossShield;
    //public bool gameHasStarted = false;

    IEnumerator EventCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);
            HomingShield1.SetActive(true);
            yield return new WaitForSeconds(2.0f);
            HomingSpawner1.SetActive(true);
            yield return new WaitForSeconds(4.0f);
            HomingShield2.SetActive(true);
            yield return new WaitForSeconds(2.0f);
            HomingSpawner2.SetActive(true);
            yield return new WaitForSeconds(6.0f);
            HomingSpawner2.SetActive(false);
            HomingShield2.SetActive(false);
            ShooterShield1.SetActive(true);
            yield return new WaitForSeconds(2.0f);
            ShooterSpawner1.SetActive(true);
            yield return new WaitForSeconds(6.0f);
            yield return new WaitForSeconds(600.0f);
        }
            
    }

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EventCoroutine());
    }
        
}
