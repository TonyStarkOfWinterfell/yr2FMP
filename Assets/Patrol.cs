using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public List<Transform> moveSpots;
    private int randomSpot;

    public bool refresh = false;
    
    
    void Start()
    {
        startWaitTime = Random.Range(8f, 90f);
        waitTime = startWaitTime;

        speed = 0.8f;

        //moveSpots = GameObject.FindGameObjectWithTag("Move").transform;
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Move"))
        {
            moveSpots.Add(go.GetComponent<Transform>());
        }


        randomSpot = Random.Range(0, moveSpots.Count);
    }

   
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 50f);        
        
        if (refresh == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f || refresh == true)
        {
            if(waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Count); //count was length /// lsit<Transform> was Transform[]
                waitTime = startWaitTime;

                refresh = false;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        
        
    }
}
