using UnityEngine;
using UnityEngine.UI;

public class Button_VolDown : MonoBehaviour
{
    // ��ư UI�� ����
    public Button myButton;

    void Start()
    {
        // ��ư Ŭ�� �� OnButtonClick �޼��带 ȣ��
        myButton.onClick.AddListener(OnButtonClick);
    }

    // ��ư Ŭ�� �� BGM�� ������ ���� ��� ����
    void OnButtonClick()
    {
        // BGM�� 2�� ���� ������ ���̱�
        SoundManager.Instance.FadeOutBGM(2f); // 2�� ���� BGM ������ ����
    }
}