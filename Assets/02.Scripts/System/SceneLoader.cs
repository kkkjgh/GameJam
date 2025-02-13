using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // �ε��� �� �̸�

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName); // ������ �� �ε�
        }
        else
        {
            Debug.LogWarning("�� �̸��� ����ֽ��ϴ�! Unity���� sceneName�� �����ϼ���.");
        }
    }
}
