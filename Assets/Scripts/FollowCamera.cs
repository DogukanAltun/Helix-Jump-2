using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 Distance;
    void Start()
    {
        Distance = transform.position - rb.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Distance + rb.transform.position;
    }
}
