using UnityEngine;
using UnityEngine.SceneManagement;  // �� ���� ���� ���ӽ����̽�

public class Titlecut : MonoBehaviour
{
    // ������ �� �̸� (Inspector���� ���� ����)
    public string sceneName;

    // �� ��ȯ �Լ�
    public void LoadScene()
    {

        SceneManager.LoadScene(sceneName);
    }
}


//using UnityEngine;
//using UnityEngine.SceneManagement;
//using System.Collections;
//using UnityEngine.UI;

//public class Titlecut : MonoBehaviour
//{
//    public string sceneName;  // �ε��� �� �̸�
//    public CanvasGroup uiCanvas;  // UI�� ���δ� CanvasGroup (Inspector���� ���� �ʿ�)

//    public void LoadSceneWithDelay()
//    {
//        StartCoroutine(LoadSceneAfterDelay(7f));
//    }

//    private IEnumerator LoadSceneAfterDelay(float delay)
//    {
//        if (uiCanvas != null)
//        {
//            uiCanvas.interactable = false;  // ��ư �� ��ġ �Է� ����
//            uiCanvas.blocksRaycasts = false; // UI Ŭ�� ����
//        }

//        yield return new WaitForSeconds(delay); // 7�� ���

//        SceneManager.LoadScene(sceneName); // �� �ε�
//    }
//}

//using UnityEngine;
//using UnityEngine.SceneManagement;
//using System.Collections;

//public class Titlecut : MonoBehaviour
//{
//    public string sceneName;  // ��ȯ�� �� �̸�
//    //public GameObject uiPanel;  // ��ġ ���ܿ� �г� (Inspector���� ����)

//    //private void Start()
//    //{
//    //    if (uiPanel != null)
//    //    {
//    //        uiPanel.SetActive(false);  // ���� �� �г� ��Ȱ��ȭ
//    //    }
//    //}

//    //public void LoadSceneWithDelay()
//    //{
//    //    StartCoroutine(LoadSceneAfterDelay(7f));
//    //}

//    private IEnumerator LoadSceneAfterDelay(float delay)
//    {
//        //if (uiPanel != null)
//        //{
//        //    uiPanel.SetActive(true);  // �г� Ȱ��ȭ -> ��ġ ����
//        //}

//        //yield return new WaitForSeconds(delay); // 7�� ���

//        SceneManager.LoadScene(sceneName); // �� �ε�
//    }
//}


