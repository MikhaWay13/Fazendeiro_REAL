using System.Collections;
using UnityEditor;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fantasma : MonoBehaviour
{
    public GameObject Player;
     private BoxCollider Colisor;
    public InputActionAsset inputActions;
    public InputAction ghost;
    private IEnumerator corotina;

    private bool intervalo;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        
    // }
     void Awake()
    {
        Colisor= GetComponent<BoxCollider>();
        ghost = InputSystem.actions.FindAction("fantasma");
    }

    // Update is called once per frame
    void Update()
    {
        if (intervalo == false)
        {

            if (ghost.IsPressed())
            {
              
                Colisor.enabled = false;
                Player.SetActive(false);
                corotina = Tempo(2.0f);
                StartCoroutine(corotina);
            }
        }
   

            
        if (!ghost.IsPressed())
        {
           
            Colisor.enabled=true;
            Player.SetActive(true);
        }
    }


    private IEnumerator Tempo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Player.SetActive(true);
        Colisor.enabled = true; //player volta
    }
    
    
}