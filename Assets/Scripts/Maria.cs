using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maria : MonoBehaviour
{
    #region Variaveis
    Rigidbody2D rb;
    Animator animator;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float jumpPower = 500;
    [SerializeField] bool rastejow = false;
    private const float detectionRadius = 0.2F;
    const float groundCheckRadius = 0.2f;
    public LayerMask detectionLayer;
    float horizontalValor;
    bool jump;
    #endregion

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {        
        if(Input.GetButtonDown("Jump")){
            jump = true;
        }else if(Input.GetButtonUp("Jump")){
            jump = false;
        }
    }

    void FixedUpdate()
    {
        GroundCheck();
        Move(horizontalValor, jump);
    }

    void GroundCheck()
    {
        rastejow = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
        if(colliders.Length>0)
        {
            rastejow = true;
        }
    }

    void Move(float dir, bool jumpFlag) 
    {
        animator.SetFloat("velocidade", Mathf.Abs(rb.velocity.x));
        
        if(rastejow && jumpFlag){
            rastejow = false;
            jumpFlag = false;
            rb.AddForce(new Vector2(0f, jumpPower));
        }
    }
    void OnTriggerEnter2D(Collider2D oi)
    {
        if(oi.CompareTag("Letra"))
        {
            Sprite var = oi.gameObject.GetComponent<Palavra>().Opa.sprite;
            GameObject.Find("SpawnLetra").GetComponent<LetraBehaviour>().Sprites.Remove(var);
            Destroy(oi.gameObject);
        }
    }
}