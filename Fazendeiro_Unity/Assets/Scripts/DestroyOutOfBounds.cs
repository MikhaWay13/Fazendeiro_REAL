using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;

    private GameObject player;
    private VIDA_PONTOS vida;
    // Start is called before the first frame update
    void Start()
    {
         player=GameObject.FindWithTag("Player");
vida = player.GetComponent<VIDA_PONTOS>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Exit();
        }
    }

    public void Exit()
    {
      //  Debug.Log("Game Over!"); //Caso a animal saia do cenário sem levar pizzada na cara
       // vida.AddVida(-1);
        /*
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif*/
    }
}
