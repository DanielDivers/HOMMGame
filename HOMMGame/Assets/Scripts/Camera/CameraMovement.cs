using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    float distance = 10f;
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + distance, target.position.z - distance);
        transform.LookAt(target);
    }
}
