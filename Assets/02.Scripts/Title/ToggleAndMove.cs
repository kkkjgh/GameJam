using UnityEngine;

public class ToggleAndMove : MonoBehaviour
{
    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable;  // Ȱ��ȭ�� ������Ʈ

    public void StartToggle()
    {
        if (targetToDisable != null)
            targetToDisable.SetActive(false);

        if (targetToEnable != null)
            targetToEnable.SetActive(true);
    }
}
