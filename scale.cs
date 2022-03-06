using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    [Range(0.1f, 1f)]
    public float scaleSpeed = 1f;
    void Update()
    {
        if (Input.GetKey(KeyCode.C)) 
            transform.localScale = new Vector3(transform.localScale.x - 0.1f * scaleSpeed, transform.localScale.y - 0.1f * scaleSpeed, 0);
        if (Input.GetKey(KeyCode.V))
            transform.localScale = new Vector3(transform.localScale.x + 0.1f * scaleSpeed, transform.localScale.y + 0.1f * scaleSpeed, 0);
    }
}
