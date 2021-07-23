using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rebon_infini : MonoBehaviour
{
    public Vector3 starter;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(starter,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
