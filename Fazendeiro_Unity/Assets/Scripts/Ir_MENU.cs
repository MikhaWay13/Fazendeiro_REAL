using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class Ir_MENU : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private PlayerController despausar; //correção de bug, quando pausa e vai para o menu e clica na opção de sair/jogar, o jogo fica pausado quando inicia
    private GameObject player;
   
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        despausar = player.GetComponent<PlayerController>();
    }



     public void Menu()
    {
        despausar.PausarTela.SetActive(false);
        despausar.UpgradeTela.SetActive(false);
            despausar.InputActions.FindActionMap("UI").Disable();
            despausar.InputActions.FindActionMap("Player").Enable();
            Time.timeScale=1f;
        SceneManager.LoadScene("Menu");
    }

}
