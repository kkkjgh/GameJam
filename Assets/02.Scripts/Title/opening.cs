using UnityEngine;
using System.Collections;

public class opening : MonoBehaviour
{
    public GameObject targetToDisable; // 비활성화할 오브젝트
    public GameObject targetToEnable;  // 활성화할 오브젝트
    public float delayTime = 2f;       // 지연 시간 (초)

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
    }
}
