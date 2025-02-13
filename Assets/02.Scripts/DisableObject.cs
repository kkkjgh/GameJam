using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject targetObject; // 비활성화할 오브젝트 지정

    public GameObject counttarget; // 카운트할 오브젝트 지정

    public void DisableTarget()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false); // 오브젝트 비활성화
            if (counttarget != null) {
                counttarget.GetComponent<ButtonManager>().buttonClickCount++; // 카운트 증가
            }

        }
    }
}
