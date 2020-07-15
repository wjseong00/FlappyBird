using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //초간단 싱글톤 만들기
    public static GameManager Instance;
    private void Awake() => Instance = this;

    //싱글톤 변수
    public bool gameOver = false;
    public int score = 0;    

    

    
    void Update()
    {
        if(gameOver)
        {
            SceneManager.LoadScene("startScene");
        }
    }
}
