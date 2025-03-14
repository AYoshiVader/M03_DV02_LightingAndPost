using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSpinner : MonoBehaviour
{
    public float rotateSpeed = 0.5f;
    public Vector3 target = new Vector3(0f, 1.5f, 0f);

    void FixedUpdate()
    {
        transform.LookAt(target);
        transform.RotateAround(target, Vector3.up, rotateSpeed);
    }
}
