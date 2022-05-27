using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpForce;
    public GameObject splashprefab;
    private GameManager gm;
    private void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }
    private void Update()
    {
         
    }
    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * JumpForce);
        GameObject splash = Instantiate(splashprefab, transform.position + new Vector3(0f,-0.2f,0f), transform.rotation);
        string Material = other.gameObject.GetComponent<MeshRenderer>().material.name;
        
        if(Material == "DeadColor (Instance)")
        { //It will be died
            gm.RestartGame();  
        }
        else if(Material == "Last Ring (Instance)")
        {
            gm.RestartGame();
        }
    }

}
