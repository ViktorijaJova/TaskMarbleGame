using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float torqueRate;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float dt = Time.deltaTime;

        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(inputV, 0, -inputH);

        rb.AddRelativeTorque(direction * torqueRate * dt);

    }
}

