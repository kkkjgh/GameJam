using UnityEngine;

public class onoffchange : MonoBehaviour
{
    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable;  // Ȱ��ȭ�� ������Ʈ

    public void Toggle()
    {
        if (targetToDisable != null)
            targetToDisable.SetActive(false);

        if (targetToEnable != null)
            targetToEnable.SetActive(true);
    }
}
