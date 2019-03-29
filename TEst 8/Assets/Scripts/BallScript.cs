using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    public GameObject destructablesphere;
    public GameObject normalSphere;
    public Rigidbody rigidbody;
    public GameObject trail;
    public bool exploded = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision");
        if (collision.gameObject.tag.Equals("bullet") || collision.gameObject.tag.Equals("shield") || collision.gameObject.tag.Equals("Player"))
        {
            destructablesphere.SetActive(true);
            normalSphere.SetActive(false);
            rigidbody.isKinematic = true;
            trail.SetActive(false);
        }

        
    }
}
