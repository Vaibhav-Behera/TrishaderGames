using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            FindObjectOfType<AudioManager>().Play("Enemy_Hit");
            Debug.Log("Hitting");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
