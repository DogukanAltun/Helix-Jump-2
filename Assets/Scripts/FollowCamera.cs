using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 Distance;
    [SerializeField] float SmoothRate = 0.04f;
    void Start()
    {
        Distance = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 newposition = Vector3.Lerp(transform.position, target.position+Distance,SmoothRate);
        transform.position= newposition;
    }
}
