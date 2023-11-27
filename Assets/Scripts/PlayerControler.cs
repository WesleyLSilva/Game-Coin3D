using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    float XInput;
    float Yinput;
    int score = 0;
    public int WinScore;
    public GameObject WinText;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("Game");
        }
    }

    private void FixedUpdate()
    {
        XInput = Input.GetAxis("Horizontal");
        Yinput = Input.GetAxis("Vertical");

        rb.AddForce(XInput * speed, 0, Yinput * speed);
    }

    void OnTriggerEnter(Collider other)
    
    {
        if(other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            score++;

            if(score >= WinScore)
            {
                WinText.SetActive(true);
            }
        }
    }
}
