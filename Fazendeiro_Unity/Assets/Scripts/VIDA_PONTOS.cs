using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VIDA_PONTOS : MonoBehaviour
{
    [SerializeField] private int vidas = 3;
    [SerializeField] private int pontuacao = 0;
    public TextMeshProUGUI saude;
    public TextMeshProUGUI pontos;

    void Start()
    {
        saude.text = "Vidas:" + vidas.ToString();
        pontos.text = "Pontos:" + pontuacao.ToString();
    }

    public void AddVida(int valor)
    {
        vidas = vidas+ valor;
        saude.text = "Vidas:" + vidas.ToString();
    }

    public void AddPontos()
    {
pontuacao+=10;
 pontos.text = "Pontos:" + pontuacao.ToString();
    }

}
