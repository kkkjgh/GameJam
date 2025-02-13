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

    public void StartRotation()
    {
        isRotating = true; // ��ư�� ������ ȸ�� ����
    }

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}
