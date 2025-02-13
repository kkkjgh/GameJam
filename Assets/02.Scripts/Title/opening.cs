using UnityEngine;
using System.Collections;

public class opening : MonoBehaviour
{
    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable; // Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable2; // Ȱ��2
    public float delayTime = 2f;       // ���� �ð� (��)

    private void Start()
    {
        StartCoroutine(ToggleAfterDelay());
    }

    private IEnumerator ToggleAfterDelay()
    {
        yield return new WaitForSeconds(delayTime);

        if (targetToDisable != null)
            targetToDisable.SetActive(false);

        if (targetToEnable != null)
            targetToEnable.SetActive(true);
        if (targetToEnable2 != null)
            targetToEnable2.SetActive(true);
    }
}
