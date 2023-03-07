using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int score;
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Coin")){
            Destroy(collision.gameObject);
            score += 1;
        }
    }
}
