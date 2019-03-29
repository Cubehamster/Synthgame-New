using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{

    public GameObject GunFloor;
    public GameObject GunInHand;
    public GameObject FirstPersonController;
    //public GameObject BallSpawner;
    public GameObject Boss;
    public GameObject EventManager;

    // Start is called before the first frame update
    void Start()
    {

    }
        
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pickup Triggered");
        GunFloor.SetActive(false);
        GunInHand.SetActive(true);
        FirstPersonController.GetComponent<Shoot>().enabled = true;
        FirstPersonController.GetComponent<AudioSource>().enabled = true;
        Boss.GetComponent<CenterOrbetingScript>().enabled = true;
        //BallSpawner.SetActive(true);
        EventManager.SetActive(true);
    }
}
