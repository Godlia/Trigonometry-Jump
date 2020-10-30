using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject cube;
    public float speed = 3f;
    public KeyCode jumpKey;
    public float jump = 5f;





    private void Awake() { 
        rb = this.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }


    private void FixedUpdate()
    {
        if(Input.GetKey(jumpKey))
        rb.AddForce(new Vector2(speed, jump), ForceMode2D.Impulse);
    }
}
