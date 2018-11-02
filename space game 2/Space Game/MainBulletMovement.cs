using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBulletMovement : MonoBehaviour {
    public float speed = 1f;
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(new Die());
    }
    public IEnumerator Die()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(this.gameObject);

    }
}
