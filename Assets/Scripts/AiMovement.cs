using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 18.0f;


    // Update is called once per frame
    void Update()
    {
        // Move vehicle forwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
