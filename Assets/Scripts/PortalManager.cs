using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PortalManager : MonoBehaviour
{
    private int contadorTiempo = 1;

    Vector3 escalaNormal = new Vector3(1, 1, 1);
    Vector3 escalaModificada = new Vector3(0.5f, 0.5f, 0.5f);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MainMenu();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            contadorTiempo++;
            


            if (contadorTiempo % 3 == 1)
            {
                
                other.transform.localScale = escalaNormal;
                Debug.Log("tamaño normal");
            }
            else
            {
                
                other.transform.localScale = escalaModificada;
                Debug.Log("tamaño chico");
            }


        }


        
    }
    public void MainMenu()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene("Main");
            Debug.Log("Menú Principal");
        }
    }
}
