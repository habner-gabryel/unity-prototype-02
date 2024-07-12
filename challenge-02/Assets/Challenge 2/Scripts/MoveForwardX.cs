using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
