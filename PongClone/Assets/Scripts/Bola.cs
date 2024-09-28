using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bola : MonoBehaviour
{
    public float speed;
    Rigidbody2D rig;
    float randomX = 0.5f;
    float randomY = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = new Vector2(speed, speed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // caso a bola toque na raquete
        if (collision.collider.CompareTag("Raquete"))
        {
            speed += 0.1f; // aumenta a velocidade da bola a cada   vez q ela encostar na raquete
            rig.velocity += new Vector2(randomX, randomY);
        }
        if (collision.collider.CompareTag("PlayerGol")){
            RaqueteBot.BotInstance.Score++;
            RaqueteBot.BotInstance.scoreText.text = RaqueteBot.BotInstance.Score.ToString();
            transform.position = new Vector2(0, 0);
        }else if (collision.collider.CompareTag("BotGol"))
        {
            RaquetePlayer.PlayerInstance.Score++;
            RaquetePlayer.PlayerInstance.scoreText.text = RaquetePlayer.PlayerInstance.Score.ToString();
            transform.position = new Vector2(0, 0);
        }
    }
}
