using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] private Transform ball;
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

        if( transform.position.y > ball.position.y+1f)
        {
            Destroy(gameObject);
            Singleton.Instance.CM.GameScore(25);
        }
    }
}
