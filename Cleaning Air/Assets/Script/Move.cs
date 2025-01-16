using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    CharacterController CC;
    public float Speed = 15;
    Vector3 sumVec, xVec, yVec, zVec;

    Animator anim;
    void Start()
    {
        CC = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Speed;
        float z = Input.GetAxis("Vertical") * Speed;

        xVec = transform.right * x * Time.deltaTime;
        zVec = transform.forward * z * Time.deltaTime;

        sumVec = xVec + yVec + zVec;
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        CC.Move(sumVec); 

        anim.SetBool("IsRun", Mathf.Abs(x) > 0 || Mathf.Abs(z) > 0);
    }
}
