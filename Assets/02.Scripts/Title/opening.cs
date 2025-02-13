//using UnityEngine;
//using System.Collections;

//public class opening : MonoBehaviour
//{
//    public GameObject targetToDisable; // 비활성화할 오브젝트
//    public GameObject targetToEnable; // 활성화할 오브젝트
//    public GameObject targetToEnable2; // 활성2
//    public float delayTime = 2f;       // 지연 시간 (초)

//    private void Start()
//    {
//        StartCoroutine(ToggleAfterDelay());
//    }

//    private IEnumerator ToggleAfterDelay()
//    {
//        yield return new WaitForSeconds(delayTime);

//        if (targetToDisable != null)
//            targetToDisable.SetActive(false);

//        if (targetToEnable != null)
//            targetToEnable.SetActive(true);
//        if (targetToEnable2 != null)
//            targetToEnable2.SetActive(true);
//    }
//}

//using UnityEngine;
//using System.Collections;

//public class ToggleAndMove : MonoBehaviour
//{
//    public GameObject targetToDisable; // 비활성화할 오브젝트
//    public GameObject targetToEnable;  // 활성화할 오브젝트
//    public GameObject objectToMove;    // 이동할 오브젝트
//    public float moveDistance = 2f;    // 이동 거리 (X축 이동 값)
//    public float moveDuration = 1f;    // 이동 시간 (초)

//    public void StartToggle()
//    {
//        if (targetToDisable != null)
//            targetToDisable.SetActive(false);

//        if (targetToEnable != null)
//            targetToEnable.SetActive(true);

//        if (objectToMove != null)
//            StartCoroutine(MoveObject(objectToMove, moveDistance, moveDuration));
//    }

//    private IEnumerator MoveObject(GameObject obj, float distance, float duration)
//    {
//        Vector3 startPos = obj.transform.position;
//        Vector3 targetPos = startPos + new Vector3(distance, 0, 0); // X축으로 이동

//        float elapsedTime = 0f;

//        while (elapsedTime < duration)
//        {
//            obj.transform.position = Vector3.Lerp(startPos, targetPos, elapsedTime / duration);
//            elapsedTime += Time.deltaTime;
//            yield return null;
//        }

//        obj.transform.position = targetPos; // 정확한 위치 보정
//    }
//}
