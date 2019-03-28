using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject destructablesphere;
    public GameObject normalSphere;
    public Rigidbody rigidbody;
    public Rigidbody spinSphere;
    public GameObject trail;
    public GameObject Explosion;
    public Transform ballcenter;
    public bool exploded = false;

    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag.Equals("bullet") || collision.gameObject.tag.Equals("Player") || collision.gameObject.tag.Equals("shield"))
        {
            destructablesphere.SetActive(true);
            spinSphere.velocity = rigidbody.velocity;
            normalSphere.SetActive(false);
            rigidbody.isKinematic = true;
            trail.SetActive(false);
            Instantiate(Explosion, ballcenter.position, ballcenter.rotation);
        }
    }
}
