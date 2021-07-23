using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terraincollision : MonoBehaviour
{
    Rigidbody bal1,bal2;
    

    void OnCollisionEnter(Collision col){
        if( col.gameObject.name == "terrain"){
            bal1 = GameObject.Find("cube1").GetComponent<Rigidbody>();
            bal1.useGravity = false;
            bal1.AddForce(0,1,0,ForceMode.Impulse);
            print("test");

            bal2 = GameObject.Find("cube2").GetComponent<Rigidbody>();
            bal2.useGravity = false;
            bal2.AddForce(0,1,0,ForceMode.Impulse);
        }
    }
}
