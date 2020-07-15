using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePool : MonoBehaviour
{
    public GameObject pipeFactory; //파이프 프리팹

    public int pipeNum = 5;
    public float spawnTime = 2.0f;
    public float timer = 0;

    //파이프 높낮이만 랜덤값으로
    public float pipeMin = -0.5f;
    public float pipeMax = 0.7f;

    //파이프 오브젝트 배열
    GameObject[] pipes;
    int currentPipe = 0;

    //화면에 안보이는 곳에 파이프 짱박아두기
    Vector2 objectPoolPosition = new Vector2(-2, 0);

    void Start()
    {
        pipes = new GameObject[pipeNum];
        for (int i = 0; i < pipeNum; i++)
        {
           pipes[i] = Instantiate(pipeFactory, objectPoolPosition, Quaternion.identity);
        }
    }
    

    void Update()
    {
        timer += Time.deltaTime;
        if(timer>spawnTime)
        {
            timer = 0f;
            //파이프가 스폰될 위치
            float spawnPositionX = 5.0f;
            float spawnPositionY = Random.Range(pipeMin, pipeMax);
            pipes[currentPipe].transform.position = new Vector2(spawnPositionX, spawnPositionY);

            currentPipe++;
            if(currentPipe>=pipeNum)
            {
                currentPipe = 0;
            }
        }
    }
}
