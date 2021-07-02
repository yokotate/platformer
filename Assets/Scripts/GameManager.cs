using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameClearText;
    public GameObject gameOverText;

    public AudioClip gameClearClip;
    public AudioClip gameOverClip;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameClear(){
        Debug.Log("GameClear");
        gameClearText.SetActive(true);
        audioSource.PlayOneShot(gameClearClip);
        GameEnd();
    }
    public void GameOver(){
        Debug.Log("GameOver");
        gameOverText.SetActive(true);
        audioSource.PlayOneShot(gameOverClip);
        GameEnd();
    }
    void GameEnd(){
        Time.timeScale = 0;
    }

    public void PushRetryButton(){
        Time.timeScale = 1;
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);
    }
}
