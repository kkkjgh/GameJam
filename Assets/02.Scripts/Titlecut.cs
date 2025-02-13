using UnityEngine;
using UnityEngine.SceneManagement;  // 씬 관리 관련 네임스페이스

public class Titlecut : MonoBehaviour
{
    // 지정할 씬 이름 (Inspector에서 설정 가능)
    public string sceneName;

    // 씬 전환 함수
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
//    public string sceneName;  // 로드할 씬 이름
//    public CanvasGroup uiCanvas;  // UI를 감싸는 CanvasGroup (Inspector에서 연결 필요)

//    public void LoadSceneWithDelay()
//    {
//        StartCoroutine(LoadSceneAfterDelay(7f));
//    }

//    private IEnumerator LoadSceneAfterDelay(float delay)
//    {
//        if (uiCanvas != null)
//        {
//            uiCanvas.interactable = false;  // 버튼 및 터치 입력 차단
//            uiCanvas.blocksRaycasts = false; // UI 클릭 차단
//        }

//        yield return new WaitForSeconds(delay); // 7초 대기

//        SceneManager.LoadScene(sceneName); // 씬 로드
//    }
//}

//using UnityEngine;
//using UnityEngine.SceneManagement;
//using System.Collections;

//public class Titlecut : MonoBehaviour
//{
//    public string sceneName;  // 전환할 씬 이름
//    //public GameObject uiPanel;  // 터치 차단용 패널 (Inspector에서 연결)

//    //private void Start()
//    //{
//    //    if (uiPanel != null)
//    //    {
//    //        uiPanel.SetActive(false);  // 시작 시 패널 비활성화
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
//        //    uiPanel.SetActive(true);  // 패널 활성화 -> 터치 차단
//        //}

//        //yield return new WaitForSeconds(delay); // 7초 대기

//        SceneManager.LoadScene(sceneName); // 씬 로드
//    }
//}


