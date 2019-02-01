using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int enemiesHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotHit() //called in TDForwardBullet
    {
        enemiesHealth -= 1;
        if (enemiesHealth <= 0)
        {
            GetComponent<Animator>().SetBool("dead", true);
            Destroy(GetComponentInChildren<bigassrattopdown>()); //will need to be changed to be more adaptable
            Destroy(GetComponent<damage>());
        }
        else
        {
            GetComponent<Animator>().SetTrigger("hit");
        }
    }
}
