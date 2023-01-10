using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float force = 1000;
    public float force_air = 720;
    GroundDetector_Raycast ground;
    public int jumps_max = 1;
    int jumps;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ground = GetComponent<GroundDetector_Raycast>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(ground.grounded)
        {
            jumps = jumps_max;
        }
        if (Input.GetButtonDown("Jump") && jumps > 0) // para solo un salto cambiar  jumps > 0 por ground.grounded y eliminar variables e if de jump
        {
            jumps--;

            if (ground.grounded)
            {
                rb.AddForce(new Vector2(0, force));
            }
            else
            {
                rb.AddForce(new Vector2(0, force_air));
            }
        }
        
    }
}
