using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VistorBeh : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDistance;
    
    Vector2 WayPoint;

    void SetNewDestination(){
        WayPoint = new Vector2(Random.Range())
    }
}
