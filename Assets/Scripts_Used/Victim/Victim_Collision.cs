using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victim_Collision : MonoBehaviour
{
    private void Start()
    {
        
    }
    public GameObject winCanvas;
    public GameObject loseCanvas;
   // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            FindObjectOfType<AudioManager>().Play("Win");
            winCanvas.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("You Won");
        }
        if (collision.gameObject.tag == "Bullet")
        {
            FindObjectOfType<AudioManager>().Play("Lose");
            loseCanvas.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("You Lose");
        }
        if (collision.gameObject.tag == "Enemy")
        {
            FindObjectOfType<AudioManager>().Play("Lose");
            loseCanvas.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("You Lose");
        }

    }
}
