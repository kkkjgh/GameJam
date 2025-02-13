using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // 로드할 씬 이름

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SoundManager.Instance.stopBGM();  // BGM 멈추기
            SceneManager.LoadScene(sceneName); // 지정한 씬 로드
        }
        else
        {
            Debug.LogWarning("씬 이름이 비어있습니다! Unity에서 sceneName을 설정하세요.");
        }
    }
}
