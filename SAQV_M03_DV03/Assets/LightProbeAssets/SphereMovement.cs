using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public int changeDirection = 20;
    public Vector3 direction;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        changeDirection = changeDirection - 1;
        if (changeDirection < 0)
        {
            direction = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
            changeDirection = 20;
        }
        rb.AddForce(direction);
    }
}
