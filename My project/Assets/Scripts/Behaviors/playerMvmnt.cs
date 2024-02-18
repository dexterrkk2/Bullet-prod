using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerMvmnt : Seek
{
    public float speed;
    public float rotateSpeed;
    public override SteeringOutput getSteering()
    {
        SteeringOutput output = new SteeringOutput();
        Vector3 direction = character.transform.forward * speed;
        if (Input.GetKey(KeyCode.W))
        {
            output.linear = direction;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            output.linear = -direction;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            output.linear = character.transform.right* speed * 5;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            output.linear = -character.transform.right * speed *5;
        }
        return output;
    }
}
