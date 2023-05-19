using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visitor : MonoBehaviour
{
    [SerializeField]
   public  float speed;
    [SerializeField]
    public float range;
    [SerializeField]
    public float maxDistance;

    
    Vector2 wayPoint;

     void Start()
    {
        SetNewDestination();
    }
    void Update()
    {
        //  GameObject.FindGameObjectWithTag("Visitor").transform.position
        //      = Vector2.MoveTowards(GameObject.FindGameObjectWithTag("Visitor").transfom.position, wayPoint, speed * Time.deltaTime);

         
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
       if(Vector2.Distance(transform.position,wayPoint)<range)
        {
            SetNewDestination();
        }
    }
    public void SetNewDestination()
    {
       wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));

    }
}
