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
            //�� Ŭ���� �ν��Ͻ��� ź������ �� �������� instance�� ���ӸŴ��� �ν��Ͻ��� ������� �ʴٸ�, �ڽ��� �־��ش�.
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
        SceneManager.LoadScene(String.Format(sceneName));
        
    }
    public void GoToScene(int scene)
    {
<<<<<<< Updated upstream
        stage = scene; 
        SceneManager.LoadScene(String.Format(scene.ToString()));
=======
<<<<<<< HEAD
        Debug.Log(scene+"dadasdasdasdsd");
        stage = scene;
        string sceneName = "Main" + scene;
        if (scene == 0)
        {
            SceneManager.LoadScene("Title");
        }
        else if (stage < MaxStage - 1 && stage != 0) // 0 �Է� �� Ÿ��Ʋ
        {
            SceneManager.LoadScene(String.Format(sceneName));
        } else if (stage == MaxStage - 1)
        {
            SceneManager.LoadScene("Finish");
        }

=======
        stage = scene; 
        SceneManager.LoadScene(String.Format(scene.ToString()));
>>>>>>> 6b8884265a1e99035418386b5427bdae9722f40e
>>>>>>> Stashed changes
    }
    public void GoToStart()
    {
        stage = 1;
        SceneManager.LoadScene("Main1");
        wrongCheck = false;

    }
}
