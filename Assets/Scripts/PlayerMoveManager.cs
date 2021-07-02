using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpPower = 10.0f;
    private Rigidbody2D rb;
    private Animator anim;
    
    private bool isJumpReady = false;
    private float offsetY;
    private float radius;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        anim = this.gameObject.GetComponent<Animator>();

        offsetY = this.gameObject.GetComponent<CircleCollider2D>().offset.y;
        radius = this.gameObject.GetComponent<CircleCollider2D>().radius;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if(horizontal==0){
            anim.SetBool("isRun", false);
        }else{
            this.transform.localScale = new Vector2(horizontal,1);
            anim.SetBool("isRun", true);
        }

        if(Input.GetKeyDown("space")){
            IsJumpReady();
            if(isJumpReady){
                isJumpReady = false;
                Jump();
            }
        }
        
    }

    void IsJumpReady(){
        // ビームの開始地点を算出している
        var originPos = this.transform.position;
        originPos = new Vector2(originPos.x - 0.5f, originPos.y - 1.01f);

        RaycastHit2D hit = Physics2D.Raycast(originPos, transform.right, 1f);

        if(hit.collider != null && hit.collider.gameObject.CompareTag("Ground")){
            isJumpReady = true;
        }else{
            isJumpReady = false;
        }

    }

    void Jump(){
        rb.AddForce(transform.up * jumpPower);
    }
}
