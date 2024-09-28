using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RaquetePlayer : MonoBehaviour
{
    public static RaquetePlayer PlayerInstance;
    public float speed = 7.0f;
    float ylimitBottom;
    float ylimitTop;
    private Rigidbody2D rb;
    public int Score;
    public Text scoreText;

    private void Awake()
    {
        if (PlayerInstance == null)
        {
            PlayerInstance = this;
        }
        else if (PlayerInstance != null)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ylimitTop = 4.3f;
        ylimitBottom = -4.3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, ylimitBottom, ylimitTop));
        float mov = 0f;

        if (Input.GetKey(KeyCode.W)){
            mov = speed * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.S)){ mov = -speed * Time.deltaTime; }

        rb.transform.position += new Vector3(0, mov, 0);
    }

}
