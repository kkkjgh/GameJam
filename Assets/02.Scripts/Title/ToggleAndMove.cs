using UnityEngine;

public class ToggleAndMove : MonoBehaviour
{
    public GameObject targetToDisable;
    public GameObject targetToDisable2;// ��Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable;  // Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable2;
    public GameObject targetToEnable3;
    public void StartToggle()
    {
        if (targetToDisable != null)
            targetToDisable.SetActive(false);

        if (targetToDisable2 != null)
            targetToDisable2.SetActive(false);
        if (targetToEnable != null)
            targetToEnable.SetActive(true);
        if (targetToEnable2 != null)
            targetToEnable2.SetActive(true);
        if (targetToEnable3 != null)
            targetToEnable3.SetActive(true);
    }
}
