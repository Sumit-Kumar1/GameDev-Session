using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Movement mmt;
    public Rigidbody playerRigid;
    void start()
    {
        playerRigid = GetComponent<Rigidbody>();
        mmt = FindObjectOfType<Movement>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Obstacle")
        {
           playerRigid.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
