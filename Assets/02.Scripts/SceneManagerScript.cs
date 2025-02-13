using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text showRetryText; // UI �ؽ�Ʈ (Inspector���� ���� �ʿ�)
    private int retry;

    void Start()
    {
        // 'retry' ���� �ҷ��� (�⺻�� 0)
        retry = PlayerPrefs.GetInt("retry", 0);

        // Ending ���̸� UI�� ǥ��
        if (SceneManager.GetActiveScene().name == "Ending")
        {
            if (showRetryText != null)
            {
                showRetryText.text = "ȸ�� Ƚ��: " + retry + "��";
            }
        }
    }

    public void LoadScene(string sceneName)
    {
        // Main4 -> Main1���� ���ư� �� retry +1
        if (SceneManager.GetActiveScene().name == "Main4" && sceneName == "Main1")
        {
            retry++;
            PlayerPrefs.SetInt("retry", retry); // �� ����
        }

        // �� �̵�
        SceneManager.LoadScene(sceneName);
    }
}