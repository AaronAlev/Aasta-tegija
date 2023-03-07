using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Movement dash;
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            if (dash.isDashing){
                Destroy(gameObject);
            } 
        }
    }
}
