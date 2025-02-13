using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public Button button;  // ��ư (Inspector���� ����)
    public ButtonManager buttonManager;  // ButtonManager ����

    void Start()
    {
        // ��ư Ŭ�� �� OnButtonClicked ȣ��
       // button.onClick.AddListener(OnButtonClicked);
    }

    // ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
    private void OnButtonClicked()
    {
       // button.interactable = false;  // Ŭ���� ��ư ��Ȱ��ȭ
        buttonManager.OnButtonClicked();  // ButtonManager�� Ŭ�� ���� ����
    }
}
