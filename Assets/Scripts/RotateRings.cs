using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRings : MonoBehaviour
{
    [SerializeField] private float RotateSpeed;
    private float MoveX;

    void Update()
    {
        MoveX = Input.GetAxis("Horizontal");
        transform.Rotate(0f, MoveX * -RotateSpeed, 0f);
    }
}
