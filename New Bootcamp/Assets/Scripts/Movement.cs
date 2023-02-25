using UnityEngine;

public class Movement : MonoBehaviour
    //Change "Movement" 
{
    public float fwdForce = 1000f;
    public float sideForce = 500f;
    public Rigidbody x;
    void Start()
    {
<<<<<<< HEAD
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        x.AddForce(0, 0, 1000 * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            x.AddForce(500 * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey("a"))
        {
            x.AddForce(-500 * Time.deltaTime, 0, 0);
=======
        x = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate() {
        x.AddForce(0, 0, fwdForce*Time.deltaTime);
        if(Input.GetKey("a"))
        {
            x.AddForce(-sideForce, 0,0);
        }
        if(Input.GetKey("d"))
        {
            x.AddForce(sideForce,0,0);
>>>>>>> 3949779b4d1cd5de15c8b830681c95989ac806a5
        }
    }
}