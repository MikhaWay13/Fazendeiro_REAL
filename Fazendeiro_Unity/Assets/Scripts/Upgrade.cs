using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class Upgrade : MonoBehaviour
{
    private GameObject player;
    [SerializeField] public TextMeshProUGUI valor_vida;
    private VIDA_PONTOS config;

    public GameObject ButtonSpeed;
    [SerializeField] private GameObject comprar, comprar1;
    private float valor;
    

    public bool comprado1, comprado2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()

    {
        player=GameObject.FindWithTag("Player");
        config = player.GetComponent<VIDA_PONTOS>();
        ButtonSpeed.SetActive(false);
        valor = 150;
        comprado1 = false;
        comprado2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Vida_Extra();
        // Velocidade();
        // Alimentadouro();
    }

    public void Vida_Extra()
    {
        if (!(config.pontuacao - valor <= 0))
        {
            
        config.AddPontos(-Mathf.FloorToInt(valor));
        config.AddVida(+1);
        valor += Mathf.FloorToInt(valor * 1.20f);
        valor_vida.text = valor.ToString();
        }
    }

    public void Velocidade()
    {
        if (comprado1==false)
        {
            
        if (!(config.pontuacao-500<=0))
        {
        config.AddPontos(-500);
        comprado1 = true;
            ButtonSpeed.SetActive(true);
            comprar.SetActive(true); //aparece o icone de comprado
            
        }
        }
    
    }
    
   public void Alimentadouro()
    {
        if (comprado2 == false)
        {
            if (!(config.pontuacao - 5000 <= 0))
            {
                comprado2 = true;
                config.AddPontos(-5000);
                comprar1.SetActive(true); //aparece o icone de comprado
                SceneManager.LoadScene("Vitoria");
            }
        }
    }
    

}
