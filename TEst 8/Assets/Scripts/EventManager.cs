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
    public GameObject ShooterSpawner2;
    public GameObject ShooterShield2;
    public GameObject SwarmSpawner1;
    public GameObject SwarmShield1;
    public GameObject Boss;
    public GameObject BossShield;
    private BallSpawner canShoot;
    //public bool gameHasStarted = false;

    IEnumerator EventCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f); //2
            HomingShield1.SetActive(true);
            yield return new WaitForSeconds(2.0f); //4
            HomingSpawner1.SetActive(true);
            yield return new WaitForSeconds(12.0f); //16
            HomingShield2.SetActive(true);
            yield return new WaitForSeconds(2.0f); //18
            HomingSpawner2.SetActive(true);
            yield return new WaitForSeconds(14.0f); //32
            HomingSpawner2.SetActive(false);
            HomingShield2.SetActive(false);
            HomingSpawner1.SetActive(false);
            HomingShield1.SetActive(false);
            ShooterShield1.SetActive(true);
            yield return new WaitForSeconds(2.0f); //34
            ShooterSpawner1.SetActive(true);
            yield return new WaitForSeconds(6.0f); //40
            ShooterShield2.SetActive(true);
            yield return new WaitForSeconds(2.0f); //42
            ShooterSpawner1.SetActive(true);
            yield return new WaitForSeconds(6.0f); //48
            ShooterSpawner1.SetActive(false);
            ShooterSpawner2.SetActive(false);
            ShooterShield1.SetActive(false);
            ShooterShield2.SetActive(false);
            SwarmShield1.SetActive(true);
            SwarmSpawner1.SetActive(true);
            SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(2f); //50
            SwarmSpawner1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            SwarmShield1.SetActive(false);
            yield return new WaitForSeconds(5.8f); //56
            SwarmShield1.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            SwarmSpawner1.SetActive(true);
            SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(2f); //58
            SwarmSpawner1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            SwarmShield1.SetActive(false);
            yield return new WaitForSeconds(5.8f); //64
            SwarmShield1.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            SwarmSpawner1.SetActive(true);
            SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(2f); //66
            SwarmShield1.SetActive(false);
            SwarmSpawner1.SetActive(false);
            yield return new WaitForSeconds(6.8f); //72
            SwarmShield1.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
            SwarmSpawner1.SetActive(true);
            yield return new WaitForSeconds(3.9f); //76
            SwarmShield1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            SwarmSpawner1.SetActive(false);
            yield return new WaitForSeconds(8f); //84
            HomingShield1.SetActive(true);
            HomingSpawner1.SetActive(true);
            HomingSpawner1.GetComponent<BallSpawner>().shootAble = true;
            HomingShield2.SetActive(true);
            HomingSpawner2.GetComponent<BallSpawner>().shootAble = true;
            HomingSpawner2.SetActive(true);
            ShooterShield1.SetActive(true);
            ShooterShield2.SetActive(true);
            ShooterSpawner1.SetActive(true);
            ShooterSpawner1.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner2.SetActive(true);
            ShooterSpawner2.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(4f); //88
            HomingSpawner1.SetActive(false);
            HomingSpawner2.SetActive(false);
            ShooterSpawner1.SetActive(false);
            ShooterSpawner2.SetActive(false);
            HomingShield1.SetActive(false);
            HomingShield2.SetActive(false);
            ShooterShield1.SetActive(false);
            ShooterShield2.SetActive(false);
            yield return new WaitForSeconds(4f); //92
            HomingShield1.SetActive(true);
            HomingSpawner1.SetActive(true);
            HomingShield2.SetActive(true);
            HomingSpawner2.SetActive(true);
            ShooterShield1.SetActive(true);
            ShooterShield2.SetActive(true);
            ShooterSpawner1.SetActive(true);
            ShooterSpawner2.SetActive(true);
            HomingSpawner1.GetComponent<BallSpawner>().shootAble = true;
            HomingSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(4f); //96
            HomingSpawner1.SetActive(false);
            HomingSpawner2.SetActive(false);
            ShooterSpawner1.SetActive(false);
            ShooterSpawner2.SetActive(false);
            HomingShield1.SetActive(false);
            HomingShield2.SetActive(false);
            ShooterShield1.SetActive(false);
            ShooterShield2.SetActive(false);
            yield return new WaitForSeconds(4f); //100
            HomingShield1.SetActive(true);
            HomingSpawner1.SetActive(true);
            HomingShield2.SetActive(true);
            HomingSpawner2.SetActive(true);
            ShooterShield1.SetActive(true);
            ShooterShield2.SetActive(true);
            ShooterSpawner1.SetActive(true);
            ShooterSpawner2.SetActive(true);
            HomingSpawner1.GetComponent<BallSpawner>().shootAble = true;
            HomingSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(4f); //104
            HomingSpawner1.SetActive(false);
            HomingSpawner2.SetActive(false);
            ShooterSpawner1.SetActive(false);
            ShooterSpawner2.SetActive(false);
            HomingShield1.SetActive(false);
            HomingShield2.SetActive(false);
            ShooterShield1.SetActive(false);
            ShooterShield2.SetActive(false);
            yield return new WaitForSeconds(8f); //112
            HomingShield1.SetActive(true);
            HomingSpawner1.SetActive(true);
            HomingShield2.SetActive(true);
            HomingSpawner2.SetActive(true);
            ShooterShield1.SetActive(true);
            ShooterSpawner1.SetActive(true);
            HomingSpawner1.GetComponent<BallSpawner>().shootAble = true;
            HomingSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(32f); //144
            HomingSpawner1.SetActive(false);
            HomingSpawner2.SetActive(false);
            HomingShield1.SetActive(false);
            HomingShield2.SetActive(false);
            SwarmShield1.SetActive(true);
            SwarmSpawner1.SetActive(true);
            SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(3f); //147
            SwarmSpawner1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            SwarmShield1.SetActive(false);
            yield return new WaitForSeconds(3.8f); //151
            SwarmShield1.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            SwarmSpawner1.SetActive(true);
            SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(2f); //153
            SwarmSpawner1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            SwarmShield1.SetActive(false);
            yield return new WaitForSeconds(2f); //155
            HomingShield1.SetActive(true);
            HomingSpawner1.SetActive(true);
            HomingShield2.SetActive(true);
            HomingSpawner2.SetActive(true);
            ShooterShield1.SetActive(true);
            ShooterShield2.SetActive(true);
            ShooterSpawner1.SetActive(true);
            ShooterSpawner2.SetActive(true);
            HomingSpawner1.GetComponent<BallSpawner>().shootAble = true;
            HomingSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(20.8f); //176
            HomingSpawner1.SetActive(false);
            HomingSpawner2.SetActive(false);
            ShooterSpawner1.SetActive(false);
            ShooterSpawner2.SetActive(false);
            HomingShield1.SetActive(false);
            HomingShield2.SetActive(false);
            ShooterShield1.SetActive(false);
            ShooterShield2.SetActive(false);
            SwarmShield1.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            SwarmSpawner1.SetActive(true);
            SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(11.8f); //188
            SwarmSpawner1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            SwarmShield1.SetActive(false);
            yield return new WaitForSeconds(3.9f); //192
            HomingShield1.SetActive(true);
            HomingSpawner1.SetActive(true);
            HomingShield2.SetActive(true);
            HomingSpawner2.SetActive(true);
            ShooterShield1.SetActive(true);
            ShooterShield2.SetActive(true);
            ShooterSpawner1.SetActive(true);
            ShooterSpawner2.SetActive(true);
            HomingSpawner1.GetComponent<BallSpawner>().shootAble = true;
            HomingSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(7.9f); //200
            HomingSpawner1.SetActive(false);
            HomingSpawner2.SetActive(false);
            ShooterSpawner1.SetActive(false);
            ShooterSpawner2.SetActive(false);
            HomingShield1.SetActive(false);
            HomingShield2.SetActive(false);
            ShooterShield1.SetActive(false);
            ShooterShield2.SetActive(false);
            yield return new WaitForSeconds(7.9f); //208
            HomingShield1.SetActive(true);
            HomingSpawner1.SetActive(true);
            HomingShield2.SetActive(true);
            HomingSpawner2.SetActive(true);
            ShooterShield1.SetActive(true);
            ShooterShield2.SetActive(true);
            ShooterSpawner1.SetActive(true);
            ShooterSpawner2.SetActive(true);
            HomingSpawner1.GetComponent<BallSpawner>().shootAble = true;
            HomingSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner2.GetComponent<BallSpawner>().shootAble = true;
            ShooterSpawner1.GetComponent<BallSpawner>().shootAble = true;
            SwarmShield1.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            SwarmSpawner1.SetActive(true);
            SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
            yield return new WaitForSeconds(600.0f);
        }
            
    }

    
    // Start is called before the first frame update
    void Start()
    {
        SwarmSpawner1.GetComponent<BallSpawner>().shootAble = true;
        StartCoroutine(EventCoroutine());
    }
        
}
