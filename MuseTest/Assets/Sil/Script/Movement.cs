using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float time;
    float timeCap = 5;
    [SerializeField] int dashCount;
    int dashCap = 3;
    bool dash = false;
    bool swap = false;
    GameObject Player;
    [SerializeField] Text DashCount;
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        Player = GameObject.Find("Player");
    }
    void Update()
    {
        movement();
        
    }
    void movement()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * moveSpeed);

        if (Input.GetButtonDown("Fire1") && dash == false && dashCount > 0)
        {
            dash = true;
            dashCount -= 1;
        }
        if (dash == true)
        {
            if (moveSpeed < 20 && swap == false) moveSpeed += 75 * Time.deltaTime;
            if (moveSpeed >= 20) swap = true;
            if (swap == true)
            {
                moveSpeed -= 75 * Time.deltaTime;
            }
            if (moveSpeed <= 5)
            {
                moveSpeed = 5;
                swap = false;
                dash = false;
            }
        }   
        if (dashCount < dashCap) time += Time.deltaTime;
        if (time >= timeCap)
        {
            time = 0;
            dashCount += 1;
        }
        DashCount.text = "Dashes = " + dashCount.ToString();
    }
}
