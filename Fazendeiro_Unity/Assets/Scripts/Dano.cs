using UnityEngine;

public class Dano : MonoBehaviour
{
        private VIDA_PONTOS health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       health = GetComponent<VIDA_PONTOS>();
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
