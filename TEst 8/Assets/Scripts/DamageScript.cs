using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScript : MonoBehaviour
          
{
    public int playerHealth = 100;
    public Image healthBar;
    int damage = 10;
    public GameObject TheManager;

    // Start is called before the first frame update
    void Start()
    {
        print (playerHealth);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision gotHit)
    {
        if (gotHit.gameObject.tag.Equals("enemy"))
        {
            playerHealth -= damage;

            healthBar.fillAmount = playerHealth / 100f;

            if (playerHealth <= 0f)
            {
                TheManager.GetComponent<GameManager>().EndGame();
            }
        }
    }

    private void Update()
    {
        if(transform.position.y <= 0f)
        {
            TheManager.GetComponent<GameManager>().EndGame();
        }
    }
}
