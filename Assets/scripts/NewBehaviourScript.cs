using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector2 speed;

    // Start is called before the first frame update
    void Start()
{
    Vector2 speed = new Vector2(1, 1);
    GetComponent<Rigidbody2D>().velocity = speed;
}

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        
    }
}