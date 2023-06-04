using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 5f;
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
        Walk();
        Dash();
        LookAround();
    }
    #region Movement
    void Walk()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * moveSpeed);        
    }
    void Dash()
    {
        if (Input.GetButtonDown("Fire3") && dash == false && dashCount > 0)
        {
            dash = true;
            dashCount -= 1;
        }
        if (dash == true)
        {
            if (moveSpeed < 25 && swap == false) moveSpeed += 150 * Time.deltaTime;
            if (moveSpeed >= 25) swap = true;
            if (swap == true)
            {
                moveSpeed -= 150 * Time.deltaTime;
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
    #endregion Movement
    void LookAround()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Player.transform.rotation = Quaternion.LookRotation(move, move);
    }
}
