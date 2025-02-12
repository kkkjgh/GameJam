using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class LoopSystem : MonoBehaviour
{
    private static LoopSystem instance = null;

    void Awake()
    {
        if (null == instance)
        {
            //이 클래스 인스턴스가 탄생했을 때 전역변수 instance에 게임매니저 인스턴스가 담겨있지 않다면, 자신을 넣어준다.
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static LoopSystem Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    public bool wrongCheck = false;
    public int MaxStage = 4;
    public int MaxChapter = 4;
    public int stage = 0;
    public int chapter = 0;
    public Text stageText;
    public int wrongCount = 0;
    
    public Image a;
    void Start()
    {
        //GoToNextScene();
    }

    void Update()
    {
        
    }
    public void Printstage()
    {
        stageText.GetComponent<Text>().text = String.Format(chapter + " - " + stage);
    }
    public void GoToNextScene()
    {

        if (stage+1 == MaxStage)
        {
            chapter++;

        }
        else if ((stage + 1) == MaxChapter && (stage + 1) == MaxStage)
        {
            SceneManager.LoadScene("Finish");
        }
        stage++;
        SceneManager.LoadScene(stage.ToString());
        
    }
    public void GoToScene(int scene)
    {
        stage = scene; 
        SceneManager.LoadScene(String.Format(scene.ToString()));
    }
    public void GoToStart()
    {
        SceneManager.LoadScene("01");
        wrongCheck = false;
        stage = 1;
        chapter = 1;
    }
}
