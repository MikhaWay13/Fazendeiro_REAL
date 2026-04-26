using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelSair;
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo");
    }


//opções
    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelMenuInicial.SetActive(true);
        painelOpcoes.SetActive(false);
    }

    //saida
    public void AbrirConfirmacao()
    {
        painelMenuInicial.SetActive(false);
        painelSair.SetActive(true);
    }

    public void Fecharconfirmacao()
    {
        painelMenuInicial.SetActive(true);
        painelSair.SetActive(false);
    }



    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }


    public void SairJogo()
    {
  #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Sair");
        Application.Quit();
        #endif
    }


}
