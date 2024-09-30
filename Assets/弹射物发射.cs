using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 弹射物发射 : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(9000, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
