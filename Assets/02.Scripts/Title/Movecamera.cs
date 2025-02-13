//using UnityEngine;
//using System.Collections;

//public class movecamera : MonoBehaviour
//{
//    public GameObject targetToDisable; // 비활성화할 오브젝트
//    public GameObject targetToEnable;  // 활성화 후 1초 뒤 사라질 오브젝트
//    public GameObject objectToMove;    // 이동할 오브젝트
//    public float moveDistance = -2f;   // X축 이동 거리 (-2)
//    public float moveDuration = 1f;    // 이동 시간 (1초)
//    public float disableDelay = 1f;    // 활성화된 오브젝트가 사라지는 시간 (1초)

//    private void OnEnable() // 오브젝트가 활성화될 때 실행됨
//    {
//        if (targetToDisable != null)
//            targetToDisable.SetActive(false);

//        if (targetToEnable != null)
//        {
//            targetToEnable.SetActive(true);
//            StartCoroutine(DisableAfterDelay(targetToEnable, disableDelay));
//        }

//        if (objectToMove != null)
//            StartCoroutine(MoveObject(objectToMove, moveDistance, moveDuration));
//    }

//    private IEnumerator DisableAfterDelay(GameObject obj, float delay)
//    {
//        yield return new WaitForSeconds(delay);
//        obj.SetActive(false);
//    }

//    private IEnumerator MoveObject(GameObject obj, float distance, float duration)
//    {
//        Vector3 startPos = obj.transform.position;
//        Vector3 targetPos = startPos + new Vector3(distance, 0, 0); // X축 -2 이동

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


//using UnityEngine;
//using System.Collections;

//public class movecamera : MonoBehaviour
//{
//    public GameObject targetToDisable; // 비활성화할 오브젝트
//    public GameObject targetToEnable;  // 활성화 후 1초 뒤 사라질 오브젝트
//    public GameObject targetToEnable2; // 추가로 활성화할 오브젝트
//    public GameObject objectToMove;    // 이동할 오브젝트
//    public float moveDistance = -2f;   // X축 이동 거리 (-2)
//    public float moveDuration = 1f;    // 이동 시간 (1초)
//    public float disableDelay = 1f;    // 활성화된 오브젝트가 사라지는 시간 (1초)

//    private void OnEnable() // 오브젝트가 활성화될 때 실행됨
//    {
//        if (targetToDisable != null)
//            targetToDisable.SetActive(false);

//        if (targetToEnable != null)
//        {
//            targetToEnable.SetActive(true);
//            StartCoroutine(DisableAfterDelay(targetToEnable, disableDelay));
//        }

//        if (targetToEnable2 != null) // 새로운 오브젝트도 활성화
//        {
//            targetToEnable2.SetActive(true);
//        }

//        if (objectToMove != null)
//            StartCoroutine(MoveObject(objectToMove, moveDistance, moveDuration));
//    }

//    private IEnumerator DisableAfterDelay(GameObject obj, float delay)
//    {
//        yield return new WaitForSeconds(delay);
//        obj.SetActive(false);
//    }

//    private IEnumerator MoveObject(GameObject obj, float distance, float duration)
//    {
//        Vector3 startPos = obj.transform.position;
//        Vector3 targetPos = startPos + new Vector3(distance, 0, 0); // X축 -2 이동

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

using UnityEngine;
using System.Collections;

public class movecamera : MonoBehaviour
{
    public GameObject targetToDisable; // 비활성화할 오브젝트
    public GameObject targetToEnable;  // 활성화 후 1초 뒤 사라질 오브젝트
    public GameObject targetToEnable2; // 추가로 즉시 활성화할 오브젝트
    public GameObject targetToEnable3; // 1초 뒤에 활성화할 오브젝트
    public GameObject objectToMove;    // 이동할 오브젝트
    public float moveDistance = -2f;   // X축 이동 거리 (-2)
    public float moveDuration = 1f;    // 이동 시간 (1초)
    public float disableDelay = 1f;    // 활성화된 오브젝트가 사라지는 시간 (1초)
    public float opendelay = 0.9f;
    private void OnEnable() // 오브젝트가 활성화될 때 실행됨
    {
        if (targetToDisable != null)
            targetToDisable.SetActive(false);

        if (targetToEnable != null)
        {
            targetToEnable.SetActive(true);
            StartCoroutine(DisableAfterDelay(targetToEnable, disableDelay));
        }

        if (targetToEnable2 != null) // 즉시 활성화할 오브젝트
        {
            targetToEnable2.SetActive(true);
        }

        if (targetToEnable3 != null) // 1초 뒤에 활성화할 오브젝트
        {
            StartCoroutine(EnableAfterDelay(targetToEnable3, opendelay));
        }

        if (objectToMove != null)
            StartCoroutine(MoveObject(objectToMove, moveDistance, moveDuration));
    }

    private IEnumerator DisableAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(false);
    }

    private IEnumerator EnableAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        obj.SetActive(true);
    }

    private IEnumerator MoveObject(GameObject obj, float distance, float duration)
    {
        Vector3 startPos = obj.transform.position;
        Vector3 targetPos = startPos + new Vector3(distance, 0, 0); // X축 -2 이동

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            obj.transform.position = Vector3.Lerp(startPos, targetPos, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        obj.transform.position = targetPos; // 정확한 위치 보정
    }
}
