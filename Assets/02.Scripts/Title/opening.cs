//using UnityEngine;
//using System.Collections;

//public class opening : MonoBehaviour
//{
//    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
//    public GameObject targetToEnable; // Ȱ��ȭ�� ������Ʈ
//    public GameObject targetToEnable2; // Ȱ��2
//    public float delayTime = 2f;       // ���� �ð� (��)

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
//    public GameObject targetToDisable; // ��Ȱ��ȭ�� ������Ʈ
//    public GameObject targetToEnable;  // Ȱ��ȭ�� ������Ʈ
//    public GameObject objectToMove;    // �̵��� ������Ʈ
//    public float moveDistance = 2f;    // �̵� �Ÿ� (X�� �̵� ��)
//    public float moveDuration = 1f;    // �̵� �ð� (��)

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
//        Vector3 targetPos = startPos + new Vector3(distance, 0, 0); // X������ �̵�

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
