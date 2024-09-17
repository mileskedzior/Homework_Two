using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float move = speed * Time.deltaTime;
        transform.Translate(move, 0, 0);
        
    }
}
