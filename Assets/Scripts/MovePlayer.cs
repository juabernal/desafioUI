using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{ 
    public float speed = 3f;

    private float movX;
    private float movZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(movX, 0, movZ);
        transform.Translate(direction * speed *Time.deltaTime);
    }

    
}
