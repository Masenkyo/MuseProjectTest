using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
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
        Player = GameObject.Find("Player");
    }
    void Update()
    {
        movement();
        
    }
    void movement()
    {
        if (Input.GetKey(KeyCode.W)) Player.transform.position += new Vector3(0, 0, moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) Player.transform.position -= new Vector3(0, 0, moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)) Player.transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D)) Player.transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) && dash == false && dashCount > 0)
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
/*
public class Example : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
*/