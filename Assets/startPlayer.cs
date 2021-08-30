using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPlayer : MonoBehaviour
{
    GameObject player;
    Transform target;
    void Start()
    {
        player = GameObject.Find("Player"); //Player 란 이름의 오브젝트를 찾아서 연결     
        target = player.GetComponent<Transform>();
        target.position = new Vector3(-5.4983f, -4.16f, 0);
    }
}
