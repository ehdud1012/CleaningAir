using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame01_Cam : MonoBehaviour
{
    int dist = 5;
    int height = 30;
    public Transform player;
    Vector3 offset;
    void LateUpdate()
    {
        offset = player.forward * dist + Vector3.down * height;
        transform.position = Vector3.Lerp(transform.position, player.position - offset, 0.5f);
        transform.LookAt(player.transform);
    }
}
