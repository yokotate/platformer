using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameClear(){
        Debug.Log("GameClear");
        Time.timeScale = 0;
    }
    public void GameOver(){
        Debug.Log("GameOver");
        Time.timeScale = 0;
    }
}
