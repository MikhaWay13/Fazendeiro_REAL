using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class correr : MonoBehaviour
{

     public PlayerController velocidade;
    // public GameObject player;
    public Image imagemUI;
    private InputAction correrAction;
    public Upgrade upgcomprado;

    public bool pressionado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // player = GameObject.FindWithTag("Player");
        velocidade = /*player.*/GetComponent<PlayerController>();
        correrAction = InputSystem.actions.FindAction("Correr");
        upgcomprado = GetComponent<Upgrade>();
    }

    // Update is called once per frame
    void Update()
    {
        if (upgcomprado.comprado1==true)
        {
            Corrida();
        }
    }
    
    void Corrida()
    {

        if (correrAction.IsPressed())
        {
            pressionado = true;
            velocidade.speed = 30f;
            imagemUI.color = new Color32(159, 132, 26, 225); //amarelo/ativado

        }
          if (!correrAction.IsPressed())
        {
                pressionado = true;
                velocidade.speed = 20f;
                imagemUI.color = new Color32(26, 109, 159, 225); //azul/desativado

        }

            


    }
}
