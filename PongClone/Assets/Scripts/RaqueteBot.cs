using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaqueteBot : MonoBehaviour
{
    public static RaqueteBot BotInstance;
    public float speed = 4f;
    public Transform bola;
    public int Score;
    public Text scoreText;

    private void Awake()
    {
        if (BotInstance == null)
        {
            BotInstance = this;
        }
        else if (BotInstance != null)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bola.position.y > transform.position.y) // caso a bola esteja acima da raquete
        {
            transform.position += Vector3.up * speed * Time.deltaTime; //move a raquetew para cima
        }
        else if (bola.position.y < transform.position.y) // caso a bola esteja abaixo da raquetew
        {
            transform.position += Vector3.down * speed * Time.deltaTime; // move a raquete para baixo
        }
    }
}
