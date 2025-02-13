//using UnityEngine;

//public class Rotate : MonoBehaviour
//{
//    public float rotationSpeed = 200f; // ȸ�� �ӵ�
//    private bool isRotating = true;

//    public void ToggleRotation()
//    {
//      //  isRotating = !isRotating; // ��ư�� ���� ������ ȸ�� ON/OFF
//    }

//    void Update()
//    {
//        if (isRotating)
//        {
//            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
//        }
//    }
//}

using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 200f; // ȸ�� �ӵ�
    private bool isRotating = false; // ó������ ���� ����
    public GameObject counttarget; // ī��Ʈ�� ������Ʈ ����

    public void StartRotation()
    {
        isRotating = true; // ��ư�� ������ ȸ�� ����
        if (counttarget != null)
        {
            counttarget.GetComponent<ButtonManager>().buttonClickCount++; // ī��Ʈ ����
        }
    }

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}
