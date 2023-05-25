using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    
    void Start()
    {
        
    }
    void Update()
    {
            
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy" && Input.GetButtonDown("Fire2"))
        {
            Debug.Log("hit");
        }
    }
}
