using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Vector2 _rotation;

    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
