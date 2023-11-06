using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;


public class Victim_Follow : MonoBehaviour
{
    public string targetTag = "Victim"; // Tag of the object to follow
    private GameObject targetObj; // GameObject to follow

    // Start is called before the first frame update
    void Start()
    {
        targetObj = GameObject.FindGameObjectWithTag(targetTag); // Find the GameObject based on the specified tag
        if (targetObj == null)
        {
            Debug.LogWarning("No object found with the specified tag.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (targetObj != null)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, targetObj.transform.position, 6 * Time.deltaTime);
        }
    }
}



