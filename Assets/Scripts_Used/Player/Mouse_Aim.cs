using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Aim : MonoBehaviour
{
    public GameObject projectilePrefab1;
    public float projectileSpeed = 10f;
    public Transform spawnPos;
    public float maxRaycastDistance = 100f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, maxRaycastDistance))
            {
                FindObjectOfType<AudioManager>().Play("Gun");
                Vector3 targetPoint = hit.point;
                GameObject projectile = Instantiate(projectilePrefab1, spawnPos.position, spawnPos.rotation);
                Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();

                if (projectileRigidbody != null)
                {
                    Vector3 direction = (targetPoint - spawnPos.position).normalized;
                    projectileRigidbody.velocity = direction * projectileSpeed;
                }
            }
        }

    }
}

