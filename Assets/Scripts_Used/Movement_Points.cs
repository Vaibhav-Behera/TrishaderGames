using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Points : MonoBehaviour
{
    public GameObject obj;
    public GameObject[] pathPoints;
    public int numberOfPoints;
    public float speed;

    public float threshold = 0.1f;
    private Vector3 actualPosition;
    private int x;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;    
    }

    // Update is called once per frame
    void Update()
    {

        actualPosition = obj.transform.position;
        obj.transform.position = Vector3.MoveTowards(actualPosition, pathPoints[x].transform.position, speed * Time.deltaTime);

        if (actualPosition == pathPoints[x].transform.position && x != numberOfPoints - 1)
        {
            x++;
        }
    }
}
