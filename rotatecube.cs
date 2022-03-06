using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecube : MonoBehaviour
{
    private Vector3 _rotation;
    [SerializeField] private float _speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.I)) _rotation = Vector3.up;
        else if (Input.GetKey(KeyCode.K)) _rotation = Vector3.down;
        else _rotation = Vector3.zero;

        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
