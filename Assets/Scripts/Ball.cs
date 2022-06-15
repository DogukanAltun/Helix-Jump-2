using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] float JumpForce;
    [SerializeField] private GameObject splashprefab;
     void Start()
     {
        rb = GetComponent<Rigidbody>();
     }
    private void Update()
    {
    }

     public void OnTriggerEnter(Collider other)
     {
            if (other.tag == "SafeColor")
            {
             rb.velocity = Vector3.up * JumpForce; 
             GameObject splash = Instantiate(splashprefab, transform.position + new Vector3(0f, 0f, 0f), transform.rotation);
            }
            if (other.tag == "DeathColor")
            { //It will be died
             Singleton.Instance.GM.RestartGame();
            }
            else if (other.tag == "Finish")
            {
             Singleton.Instance.GM.RestartGame();
            }
     }
}
