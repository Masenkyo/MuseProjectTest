using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpAnim : MonoBehaviour
{
    public float RotationSpeed;
    public Vector3 RotationDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationSpeed * RotationDirection * Time.deltaTime);
    }
}
