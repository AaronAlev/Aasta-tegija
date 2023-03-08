using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Vector3 playerOffset;
    public GameObject cameraToActivate;
    public GameObject cameraToDeactivate;
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            Vector3 teleportPosition = transform.TransformPoint(playerOffset);
            collision.gameObject.transform.position = teleportPosition;
            cameraToDeactivate.SetActive(false);
            cameraToActivate.SetActive(true);
        }
    }
}
