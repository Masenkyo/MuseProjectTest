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
    public int dashCap = 3;
    bool dash = false,swap = false;
    [SerializeField] Text DashCount;
    public GameObject Player;
    public GameObject animatie;
    private Animator Animator;
    
    private float scale = 1f;
    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        Walk();
        Dash();
        LookAround();
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        Debug.Log(Input.GetAxisRaw("Vertical"));
    }
    #region Movement
    void Walk()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * moveSpeed);        
    }
    void Dash()
    {
        if (Input.GetButtonDown("Fire3") && !dash && dashCount > 0)
        {
            dash = true;
            dashCount--;
        }
        if (dash)
        {
            if (moveSpeed < 25 && !swap) moveSpeed += 150 * Time.deltaTime;
            if (moveSpeed >= 25) swap = true;
            if (swap)
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
        if (move != new Vector3(0, 0, 0))
            Player.transform.rotation = Quaternion.LookRotation(move, move);
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animatie.GetComponent<Animator>().SetBool("H", true);
            animatie.transform.localScale = new Vector3(-scale, scale, scale);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animatie.GetComponent<Animator>().SetBool("H", true);
            animatie.transform.localScale = new Vector3(scale, scale, scale);
        }
        else
        {
            animatie.GetComponent<Animator>().SetBool("H", false);
        }
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            animatie.GetComponent<Animator>().SetFloat("V", Input.GetAxisRaw("Vertical"));
            animatie.GetComponent<Animator>().SetBool("VV", false);
        }
        else
        {
            animatie.GetComponent<Animator>().SetBool("VV", true);
            animatie.GetComponent<Animator>().SetFloat("V", 0);
        }

    }
}
