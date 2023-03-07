using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;
    public bool isDashing = false;
    
    SpriteRenderer sprite;
    public Color dashColor = Color.white;
    public Color normColor;

    private float activeMoveSpeed;
    public float dashSpeed;

    public float dashLenght = .5f, dashCooldown = 1f;

    private float dashCounter;
    private float dashCoolCounter;

    // Start is called before the first frame update
    void Start()
    {
        activeMoveSpeed = moveSpeed;
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();
        rb2d.velocity = moveInput * activeMoveSpeed;

        if (Input.GetKeyDown(KeyCode.Space)){
            if (dashCoolCounter <=0 && dashCounter <= 0){
                activeMoveSpeed = dashSpeed;
                dashCounter = dashLenght;
                isDashing = true;
            }
        }

        if (dashCounter > 0){
            dashCounter -= Time.deltaTime;
            if (dashCounter <= 0){
                activeMoveSpeed = moveSpeed;
                dashCoolCounter = dashCooldown;
                isDashing = false;
            }
        }

        if (dashCoolCounter > 0){
            dashCoolCounter -= Time.deltaTime;
        }

        if (isDashing==true){
            sprite.color = dashColor;
        }
        else{
            sprite.color = normColor;
        }
    }
}