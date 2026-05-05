using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject PausarTela;
    public GameObject UpgradeTela;
    public float speed = 17f;
    public float xRange = 25f;
    public GameObject projectilePrefab;
    public InputActionAsset InputActions;
    private InputAction moveAction;
    private InputAction fireAction;

    //pause
    private InputAction PauseActionPlayer;
    private InputAction PauseActionUI;

    //compras/upgrade
    private InputAction UpgradeActionPlayer;
    private InputAction UpgradeActionUI;

    
  


    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();


    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();

    }



    // Update is called once per frame
    void Update()
    {
        float horizontalInput = moveAction.ReadValue<Vector2>().x;
        // movimenta o player para esquerda e direita a partir da entrada do usu�rio
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        // mant�m o player dentro dos limites do jogo (eixo x)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.y);
        }

        if (fireAction.WasPressedThisFrame())
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }

        //evitar conflito entre telas
        if (!PausarTela.activeSelf)
        {
            Upgrade();

        }

        if (!UpgradeTela.activeSelf)
        {
        Pausar();
        }

    }

    private void Pausar()    //janela de pausar abre e fecha
    {


        if (PauseActionPlayer.WasPressedThisFrame())
        {
            
   
            PausarTela.SetActive(true);
            InputActions.FindActionMap("Player").Disable();
            InputActions.FindActionMap("UI").Enable();
            Time.timeScale = 0f;
        }
        else if (PauseActionUI.WasPressedThisFrame())
        {
            PausarTela.SetActive(false);
            InputActions.FindActionMap("UI").Disable();
            InputActions.FindActionMap("Player").Enable();
            Time.timeScale = 1f;

        }
    }
    
      private void Upgrade()              //janela de upgrade abre e fecha
    {

        if (UpgradeActionPlayer.WasPressedThisFrame())
        {
            UpgradeTela.SetActive(true);
            InputActions.FindActionMap("Player").Disable();
            InputActions.FindActionMap("UI").Enable();
            Time.timeScale=0f;
        }
        else if (UpgradeActionUI.WasPressedThisFrame())
        {
            UpgradeTela.SetActive(false);
            InputActions.FindActionMap("UI").Disable();
            InputActions.FindActionMap("Player").Enable();
            Time.timeScale=1f;
          
        }
    }

    private void Awake()
    {
        PausarTela.SetActive(false);
        UpgradeTela.SetActive(false); //jogo funciona após vencer/ perder/ voltar do menu
        Time.timeScale=1f;

        moveAction = InputSystem.actions.FindAction("Move");
        fireAction = InputSystem.actions.FindAction("Jump");
        PauseActionPlayer = InputSystem.actions.FindAction("Player/Pause");
        PauseActionUI = InputSystem.actions.FindAction("UI/Pause");
        UpgradeActionPlayer = InputSystem.actions.FindAction("Player/Upgrade");
        UpgradeActionUI = InputSystem.actions.FindAction("UI/Upgrade");

    }

    // public void MoveEvent(InputAction.CallbackContext context)
    // {
    //     horizontalInput = context.ReadValue<Vector2>().x;
    // }
    //     public void FireEvent(InputAction.CallbackContext context)
    // {
    //     Debug.Log("Disparar pizza!");
    //     if (context.performed)
    //     {
    //     }   
    // }
}

