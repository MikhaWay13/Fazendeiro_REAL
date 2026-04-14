using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fantasma : MonoBehaviour
{
    public GameObject Player;
    // private bool Colisor;
    public InputActionAsset inputActions;
    public InputAction ghost;
    private IEnumerator corotina;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        
    // }
     void Awake()
    {
    //    Colisor = Player.GetComponent<BoxCollider>().enabled;
        ghost = InputSystem.actions.FindAction("fantasma");
    }

    // Update is called once per frame
    void Update()
    {
        if (ghost.WasPressedThisFrame())
        {
            Debug.Log("Não Posso Colidir");
            Player.SetActive(false);
            corotina = Tempo(2.0f);
            StartCoroutine(corotina);
        }
    }


   private IEnumerator Tempo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Player.SetActive(true);
        Debug.Log("Posso Colidir");
    }
    
}