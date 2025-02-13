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
            if (instance == null)
            {
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
        SceneManager.LoadScene(sceneName);

    }
    public void GoToScene(int scene)
    {
        stage = scene;
        if (scene == -1)
        {
            stage = -1;
            SceneManager.LoadScene("Title");
        }
        else if (scene == 0)
        {
            SceneManager.LoadScene("Tuto");
            stage = 0;
        }
        else if (scene < MaxStage && scene > 0)
        {
            SceneManager.LoadScene("Main" + scene);
            stage = scene;
        }
        else if (scene == MaxStage - 1)
        {
            SceneManager.LoadScene("Finish");
            stage = MaxStage - 1;
        }
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
