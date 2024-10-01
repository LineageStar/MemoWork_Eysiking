using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 弹射物发射 : MonoBehaviour
{
    public Rigidbody rb;
    public float StartForce = 10000f;
    public int ForceX = 0;
    public int ForceY = 0;
    public int ForceZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(ForceX * StartForce, ForceY * StartForce, ForceZ * StartForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
