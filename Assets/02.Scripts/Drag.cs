using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Drag : MonoBehaviour
{
    private Camera cam;
    private Vector3 dragOffset; // Ŭ��������, object�� �߾���ǥ�Ͱ� Ŭ���� ��ǥ������ ����

    void Awake()
    {
        GameObject.Find("Main Camera");
    }

    void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePos();
    }
    void OnMouseDrag()
    {
        transform.position = GetMousePos() + dragOffset;
    }

    Vector3 GetMousePos()
    {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        return mousePos;
    }
}
