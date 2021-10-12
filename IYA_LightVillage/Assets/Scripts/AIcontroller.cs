using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AIcontroller : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public float maxSpeed;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
        currentHealth = 1;
    }
    void Update()
    {
        //Stop speed
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }
        //Direction Sprite
        if (Input.GetButtonDown("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        if (Mathf.Abs(rigid.velocity.x) < 0.3)
            anim.SetBool("iswalking", false);
        else
            anim.SetBool("iswalking", true);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Move speed
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        // max speed
        if (rigid.velocity.x > maxSpeed) // Right
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed * (-1)) // Left
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
    }
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + '/' + maxHealth);
    }
}