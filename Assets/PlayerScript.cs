using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;
        float x  =  Input.GetAxisRaw("Horizontal");
        float z  =  Input.GetAxisRaw("Vertical");
 
        Vector3 direction = new Vector3 (10 * x, 0, 10 * z).normalized;
 
        Rigidbody rb = this.GetComponent<Rigidbody> ();
        rb.AddForce(direction * speed);
    }
}
