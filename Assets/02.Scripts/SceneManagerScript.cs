using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text showRetryText; // UI 텍스트 (Inspector에서 연결 필요)
    private int retry;

    void Start()
    {
        // 'retry' 값을 불러옴 (기본값 0)
        retry = PlayerPrefs.GetInt("retry", 0);

        // Ending 씬이면 UI에 표시
        if (SceneManager.GetActiveScene().name == "Ending")
        {
            if (showRetryText != null)
            {
                showRetryText.text = "회귀 횟수: " + retry + "번";
            }
        }
    }

    public void LoadScene(string sceneName)
    {
        // Main4 -> Main1으로 돌아갈 때 retry +1
        if (SceneManager.GetActiveScene().name == "Main4" && sceneName == "Main1")
        {
            retry++;
            PlayerPrefs.SetInt("retry", retry); // 값 저장
        }

        // 씬 이동
        SceneManager.LoadScene(sceneName);
    }
}