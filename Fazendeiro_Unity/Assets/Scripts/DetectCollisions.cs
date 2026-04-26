using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Overlays;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
    public GameObject player;
private VIDA_PONTOS pontos;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindWithTag("Player");
pontos = player.GetComponent<VIDA_PONTOS>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag!="Player"&&gameObject.tag=="Tiro")
        {
        int valor = Random.Range(10, 15)*5;
       pontos.AddPontos(valor);
        Destroy(gameObject);
        Destroy(other.gameObject);
        }
    }
}
