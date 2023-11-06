using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float StartingHealth;
    public static float health;

    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            Debug.Log(health);

            if (health <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
    void Start()
    {
        Health = StartingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
