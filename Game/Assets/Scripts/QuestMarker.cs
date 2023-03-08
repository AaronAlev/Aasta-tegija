using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMarker : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 1f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        Vector3 newPosition = startPos + new Vector3(0f, Mathf.Sin(Time.time * speed) * distance, 0f);
        transform.position = newPosition;
    }
}
