using UnityEngine;

public class Onoff : MonoBehaviour
{
    public GameObject targetToDisable; // 비활성화할 오브젝트
    public GameObject targetToEnable;  // 활성화할 오브젝트
    public GameObject counttarget; // 카운트할 오브젝트 지정

    public void ToggleObjects() // 버튼을 눌렀을 때 실행할 함수
    {
        if (targetToDisable != null)
            targetToDisable.SetActive(false); // 특정 오브젝트 비활성화
            

        if (targetToEnable != null)
            targetToEnable.SetActive(true); // 특정 오브젝트 활성화

        if (counttarget != null)
        {
            counttarget.GetComponent<ButtonManager>().buttonClickCount++; // 카운트 증가
        }
    }
}
