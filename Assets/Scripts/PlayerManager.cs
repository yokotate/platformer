using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private GameManager _gameManager;
    private Animator _anim;
    void Start(){
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _anim = this.gameObject.GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("GameClear")){
            _gameManager.GameClear();
        }
        if(collision.gameObject.CompareTag("GameOver")){
            _anim.updateMode = AnimatorUpdateMode.UnscaledTime;
            _anim.SetTrigger("HurtTrigger");
            _gameManager.GameOver();
        }
    }
}
