using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbetingScript : MonoBehaviour
{
    public GameObject sphere;
    public GameObject centerofRotation;
    private Vector3 upAngle;
    public int rotationSpeed;


    private void Awake()
    {
        upAngle = new Vector3(0, 1, 0);
    }
    // Update is called once per frame

    void Update()
    {
        //transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform.position);

        Vector3 relativePos = centerofRotation.transform.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        if (sphere.activeSelf)
        {
            Quaternion rotation = Quaternion.LookRotation(relativePos, upAngle);
            transform.rotation = rotation;
        }
        transform.Translate(Vector3.right * Time.deltaTime * rotationSpeed);
    }
}
