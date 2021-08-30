using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Player : MonoBehaviour
{
    private GameObject m_goHpBar;
    private bool isGrabbed = false;
    public float speed = 1f;
    Rigidbody2D rbody;



    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        m_goHpBar = GameObject.Find("Canvas/Playercount");

    }

    void OnMouseDown()
    {
        Debug.Log("You grabbed " + name + "!");

        isGrabbed = true;
    }

    void Update()
    {
        if (!Input.GetMouseButton(0) && isGrabbed)
        {

            Debug.Log("You released " + name + "!");

            isGrabbed = false;
        }
        m_goHpBar.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(1.5f, 0.5f, 0));
    }
    void FixedUpdate()
    {
        if (isGrabbed)
        {


            Vector2 rawMouse = Input.mousePosition;


            Vector2 mouse = Camera.main.ScreenToWorldPoint(rawMouse);

            Vector2 deltaDist = mouse - new Vector2(transform.position.x, transform.position.y);
            Vector2 direction = deltaDist.normalized;

            Vector2 force = direction * speed;

            rbody.AddForceAtPosition(deltaDist * speed,transform.position);

        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Debug.Log("cut");
        }
    }
}
