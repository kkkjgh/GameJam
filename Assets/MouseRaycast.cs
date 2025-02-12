using UnityEngine;

public class MouseRaycast : MonoBehaviour
{
    public LayerMask layer;
    void Update()
    {
        // ���콺 ȭ�� ��ǥ�� ���� ������ Ray�� ��ȯ
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Raycast�� ����Ͽ� ���콺 ��ġ���� ������Ʈ�� �ִ��� Ȯ��
        RaycastHit hit;

        // ���̾� ����ũ�� ����Ͽ� Default ���̾ üũ
        int layerMask = layer;

        // Raycast �� Default ���̾ �ִ� ������Ʈ�� üũ
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            // ������Ʈ�� ���콺 ��ġ�� �������� ��
            Debug.Log("������Ʈ�� ���˵�: " + hit.collider.name);

            // hit.point�� ���콺 ��ġ���� Ray�� ���� WorldSpace ��ǥ�Դϴ�.
            Debug.Log("x��ǥ : "+hit.point.x +"y��ǥ : "+hit.point.y);
        }
    }
}
