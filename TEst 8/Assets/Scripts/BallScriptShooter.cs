 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScriptShooter : MonoBehaviour
{
    public GameObject destructablesphere;
    public GameObject normalSphere;
    public Rigidbody rigidbody;
    public GameObject scriptholder;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag.Equals("bullet") || collision.gameObject.tag.Equals("ground"))
        {
            destructablesphere.SetActive(true);
            normalSphere.SetActive(false);
            rigidbody.isKinematic = true;
            GetComponent<BallSpawner2>().enabled = false;
        }
    }
}
