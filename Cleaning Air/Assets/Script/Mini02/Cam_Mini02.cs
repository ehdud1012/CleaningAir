using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Mini02 : MonoBehaviour
{
    int dist = 20;
    int height = 20;
    public Transform player;
    Vector3 offset;
    void LateUpdate()
    {
        offset = player.forward * dist + Vector3.down * height;
        transform.position = Vector3.Lerp(transform.position, player.position - offset, 0.5f);
        transform.LookAt(player.transform);
    }
}
