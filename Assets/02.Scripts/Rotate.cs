//using UnityEngine;

//public class Rotate : MonoBehaviour
//{
//    public float rotationSpeed = 200f; // 회전 속도
//    private bool isRotating = true;

//    public void ToggleRotation()
//    {
//      //  isRotating = !isRotating; // 버튼을 누를 때마다 회전 ON/OFF
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
    public float rotationSpeed = 200f; // 회전 속도
    private bool isRotating = false; // 처음에는 멈춘 상태

    public void StartRotation()
    {
        isRotating = true; // 버튼을 누르면 회전 시작
    }

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}
