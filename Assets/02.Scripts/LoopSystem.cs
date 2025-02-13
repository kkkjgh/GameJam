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
    public Text stageText;
    public int wrongCount = 0;
    public int GetStage()
    {
        return stage;
    }
    public void GoToNextScene()
    {
        if ((stage + 1) == MaxStage)
        {
            SceneManager.LoadScene("Finish");
        }
        stage++;
        string sceneName = "Main" + stage;
        SceneManager.LoadScene(String.Format(sceneName));
        
    }
    public void GoToScene(int scene)
    {
        stage = scene; 
        SceneManager.LoadScene(String.Format(scene.ToString()));
    }
    public void GoToStart()
    {
        stage = 1;
        SceneManager.LoadScene("Main1");
        wrongCheck = false;

    }
}
