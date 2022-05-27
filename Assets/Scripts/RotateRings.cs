using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRings : MonoBehaviour
{
    public float RotateSpeed;
    private float MoveX;

    void Update()
    {
        MoveX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, MoveX * RotateSpeed, 0f);
        }
    }
}
