using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    public Text PlayerHP;
    int count = 3;

    void Start()
    {
        PlayerHP = GameObject.Find("Playercount").GetComponent<Text>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            count = count - 1;
            PlayerHP.text = "" + count;
        }
    }
}
