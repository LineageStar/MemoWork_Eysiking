//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start() {
        //Debug.Log("Hello World!");
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(0, 100, 0);
    }
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 200 * Time.deltaTime);
    }
}
