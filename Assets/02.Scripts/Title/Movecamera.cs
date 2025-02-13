//using UnityEngine;
//using System.Collections;

//public class movecamera : MonoBehaviour
//{
//    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
//    public GameObject targetToEnable;  // Ȱ��ȭ �� 1�� �� ����� ������Ʈ
//    public GameObject objectToMove;    // �̵��� ������Ʈ
//    public float moveDistance = -2f;   // X�� �̵� �Ÿ� (-2)
//    public float moveDuration = 1f;    // �̵� �ð� (1��)
//    public float disableDelay = 1f;    // Ȱ��ȭ�� ������Ʈ�� ������� �ð� (1��)

//    private void OnEnable() // ������Ʈ�� Ȱ��ȭ�� �� �����
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
//        Vector3 targetPos = startPos + new Vector3(distance, 0, 0); // X�� -2 �̵�

//        float elapsedTime = 0f;

//        while (elapsedTime < duration)
//        {
//            obj.transform.position = Vector3.Lerp(startPos, targetPos, elapsedTime / duration);
//            elapsedTime += Time.deltaTime;
//            yield return null;
//        }

//        obj.transform.position = targetPos; // ��Ȯ�� ��ġ ����
//    }
//}


//using UnityEngine;
//using System.Collections;

//public class movecamera : MonoBehaviour
//{
//    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
//    public GameObject targetToEnable;  // Ȱ��ȭ �� 1�� �� ����� ������Ʈ
//    public GameObject targetToEnable2; // �߰��� Ȱ��ȭ�� ������Ʈ
//    public GameObject objectToMove;    // �̵��� ������Ʈ
//    public float moveDistance = -2f;   // X�� �̵� �Ÿ� (-2)
//    public float moveDuration = 1f;    // �̵� �ð� (1��)
//    public float disableDelay = 1f;    // Ȱ��ȭ�� ������Ʈ�� ������� �ð� (1��)

//    private void OnEnable() // ������Ʈ�� Ȱ��ȭ�� �� �����
//    {
//        if (targetToDisable != null)
//            targetToDisable.SetActive(false);

//        if (targetToEnable != null)
//        {
//            targetToEnable.SetActive(true);
//            StartCoroutine(DisableAfterDelay(targetToEnable, disableDelay));
//        }

//        if (targetToEnable2 != null) // ���ο� ������Ʈ�� Ȱ��ȭ
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
//        Vector3 targetPos = startPos + new Vector3(distance, 0, 0); // X�� -2 �̵�

//        float elapsedTime = 0f;

//        while (elapsedTime < duration)
//        {
//            obj.transform.position = Vector3.Lerp(startPos, targetPos, elapsedTime / duration);
//            elapsedTime += Time.deltaTime;
//            yield return null;
//        }

//        obj.transform.position = targetPos; // ��Ȯ�� ��ġ ����
//    }
//}

using UnityEngine;
using System.Collections;

public class movecamera : MonoBehaviour
{
    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable;  // Ȱ��ȭ �� 1�� �� ����� ������Ʈ
    public GameObject targetToEnable2; // �߰��� ��� Ȱ��ȭ�� ������Ʈ
    public GameObject targetToEnable3; // 1�� �ڿ� Ȱ��ȭ�� ������Ʈ
    public GameObject objectToMove;    // �̵��� ������Ʈ
    public float moveDistance = -2f;   // X�� �̵� �Ÿ� (-2)
    public float moveDuration = 1f;    // �̵� �ð� (1��)
    public float disableDelay = 1f;    // Ȱ��ȭ�� ������Ʈ�� ������� �ð� (1��)
    public float opendelay = 0.9f;
    private void OnEnable() // ������Ʈ�� Ȱ��ȭ�� �� �����
    {
        if (targetToDisable != null)
            targetToDisable.SetActive(false);

        if (targetToEnable != null)
        {
            targetToEnable.SetActive(true);
            StartCoroutine(DisableAfterDelay(targetToEnable, disableDelay));
        }

        if (targetToEnable2 != null) // ��� Ȱ��ȭ�� ������Ʈ
        {
            targetToEnable2.SetActive(true);
        }

        if (targetToEnable3 != null) // 1�� �ڿ� Ȱ��ȭ�� ������Ʈ
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
        Vector3 targetPos = startPos + new Vector3(distance, 0, 0); // X�� -2 �̵�

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            obj.transform.position = Vector3.Lerp(startPos, targetPos, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        obj.transform.position = targetPos; // ��Ȯ�� ��ġ ����
    }
}
