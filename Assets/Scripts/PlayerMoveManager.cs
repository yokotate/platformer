using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");

        if(horizontal==0){
            anim.SetBool("isRun", false);
        }if(horizontal > 0){
            this.transform.localScale = new Vector2(1,1);
            anim.SetBool("isRun", true);
        }if(horizontal < 0){
            this.transform.localScale = new Vector2(-1,1);
            anim.SetBool("isRun", true);
        }
        
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}
