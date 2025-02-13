using UnityEngine;

public class Onoff : MonoBehaviour
{
    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable;  // Ȱ��ȭ�� ������Ʈ
    public GameObject counttarget; // ī��Ʈ�� ������Ʈ ����

    public void ToggleObjects() // ��ư�� ������ �� ������ �Լ�
    {
        if (targetToDisable != null)
            targetToDisable.SetActive(false); // Ư�� ������Ʈ ��Ȱ��ȭ
            

        if (targetToEnable != null)
            targetToEnable.SetActive(true); // Ư�� ������Ʈ Ȱ��ȭ

        if (counttarget != null)
        {
            counttarget.GetComponent<ButtonManager>().buttonClickCount++; // ī��Ʈ ����
        }
    }
}
