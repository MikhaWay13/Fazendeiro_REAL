using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    private VIDA_PONTOS health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = GetComponent<VIDA_PONTOS>();
    }


void Update()
    {
        if (health.vidas <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            health.AddVida(-1);
            Destroy(other.gameObject);

        }

    }


}
