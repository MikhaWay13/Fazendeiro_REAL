using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VIDA_PONTOS : MonoBehaviour
{
    [SerializeField] public int vidas = 3;
    [SerializeField] public int pontuacao = 0;
    
    [SerializeField] private float segundos = 0;
    public TextMeshProUGUI saude;
    public TextMeshProUGUI pontos;
    public TextMeshProUGUI tempo;

    void Start()
    {
        saude.text = "Vidas:" + vidas.ToString();
        pontos.text = "Pontos:" + pontuacao.ToString();
        tempo.text = "Tempo:" + segundos.ToString();
    }

    void Update()
    {
        segundos += Time.deltaTime;
        tempo.text = "Tempo:" + Mathf.FloorToInt(segundos).ToString()+" segundos";
        
    }

    public void AddVida(int valor)
    {
        vidas = vidas+ valor;
        saude.text = "Vidas:" + vidas.ToString();
    }

    public void AddPontos(int valor)
    {

pontuacao+=valor;
 pontos.text = "Pontos:" + pontuacao.ToString();
    
    }

}
