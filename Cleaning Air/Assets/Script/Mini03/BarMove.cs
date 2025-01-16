using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    Vector3 position;
    void Start()
    {
        position = transform.position;
    }
    void Update()
    {
        position.z += 5 * Time.deltaTime;
        transform.position = position;
    }

}
