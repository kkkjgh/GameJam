using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject targetObject; // ��Ȱ��ȭ�� ������Ʈ ����

    public void DisableTarget()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false); // ������Ʈ ��Ȱ��ȭ
        }
    }
}
