using UnityEngine;
using UnityEngine.UI; // UI ��ư�� �ٷ�� ���� ���ӽ����̽�

public class ButtonManager : MonoBehaviour
{
    public Button nextButton; // NextButton (ĵ������ �ִ� ��ư�� ����)
    public int buttonClickCount = 0; // Ŭ���� ��ư ��
    public bool flag;

    void Start()
    {
        // ó������ NextButton�� ��Ȱ��ȭ
      //  nextButton.interactable = false;
    }

    void Update()
    {
        if (buttonClickCount >= 5)
        {
            flag = true;
            //  nextButton.interactable = true; // NextButton Ȱ��ȭ
        }
    }
    // ��ư�� Ŭ���� �� ȣ��Ǵ� �Լ�
    public void OnButtonClicked()
    {
        buttonClickCount++; // ��ư Ŭ�� �� ����

        // 5�� ��ư�� ��� Ŭ���� ��� NextButton�� Ȱ��ȭ
        
    }
}
