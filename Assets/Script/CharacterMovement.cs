using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(0, 0, 0);
        if (transform.position.x >= -14.83f)
        {
            if (Input.GetKey(KeyCode.D))
            {
                vel += new Vector3(speed, 0, 0);
                transform.position += vel;
            }
            if (Input.GetKey(KeyCode.A))
            {
                vel -= new Vector3(speed, 0, 0);
                transform.position += vel;
            }        
        }

        if (transform.position.x < -14.83){
            Vector3 start = new Vector3(-14.82f, -1.17f, 0);
            transform.position = start;
        }
        
    }
}
