using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public Camera camera; // ī�޶� ����
    private Vector3 mousePos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺 ��ġ�� ȭ�� ��ǥ�� �޾ƿɴϴ�.
            mousePos = Input.mousePosition;

            // ī�޶��� Z���� ���� ���� ��ǥ�� ��ȯ�մϴ�.
            mousePos.z = camera.nearClipPlane; // �Ǵ� ī�޶���� ������ �Ÿ��� ���� ����

            // ȭ�� ��ǥ�� ���� ��ǥ�� ��ȯ�մϴ�.
            Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);

            // ���� ��ǥ���� Raycast�� ����
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero); // Ŭ���� ��ġ���� Raycast

            // �浹�� ������Ʈ�� �ִ��� Ȯ��
            if (hit.collider != null)
            {
                // �浹�� ������Ʈ�� Default ���̾ ���� ���
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Default"))
                {
                    // �浹�� ������Ʈ ó��
                    Debug.Log("Hit object: " + hit.collider.gameObject.name);
                }
            }

            // ��ȯ�� ���� ��ǥ�� ���� ������Ʈ ��ġ ����
            transform.position = worldPos;
            // ��ȯ�� ���� ��ǥ ���
            Debug.Log("Mouse Position in World: " + worldPos);
        }
    }
}
