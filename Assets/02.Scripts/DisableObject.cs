using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject targetObject; // ��Ȱ��ȭ�� ������Ʈ ����

    public GameObject counttarget; // ī��Ʈ�� ������Ʈ ����

    public void DisableTarget()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false); // ������Ʈ ��Ȱ��ȭ
            if (counttarget != null) {
                counttarget.GetComponent<ButtonManager>().buttonClickCount++; // ī��Ʈ ����
            }

        }
    }
}
