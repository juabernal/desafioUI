using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChange : MonoBehaviour
{
    [SerializeField] [Range(1, 5)] private float cooldown;
    [SerializeField] [Range(1, 5)] private float cooldownScore;
    [SerializeField] Transform portal;
    private float timePortal = 0;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        timePortal = 0;
        Debug.Log("Espera en el portal y serás trasladado");
        
        
    }
    private void OnTriggerStay(Collider other)
    {
        
        timePortal += Time.deltaTime;
        if (timePortal >= cooldown)
        {
            other.transform.position = portal.position;
            Debug.Log("Bienvenido a tu nueva posición");

            
            
        }
        if(timePortal>cooldownScore)
        { 
        Score.score++;
            Score.score++;
            Score.score++;
        }
    }
}
