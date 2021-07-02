using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private GameManager _gameManager;
    void Start(){
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("GameClear")){
            _gameManager.GameClear();
        }
        if(collision.gameObject.CompareTag("GameOver")){
            _gameManager.GameOver();
        }
    }
}
