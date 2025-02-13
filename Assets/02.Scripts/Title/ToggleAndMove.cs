using UnityEngine;

public class ToggleAndMove : MonoBehaviour
{
    public GameObject targetToDisable; // 비활성화할 오브젝트
    public GameObject targetToEnable;  // 활성화할 오브젝트

    public void StartToggle()
    {
        if (targetToDisable != null)
            targetToDisable.SetActive(false);

        if (targetToEnable != null)
            targetToEnable.SetActive(true);
    }
}
