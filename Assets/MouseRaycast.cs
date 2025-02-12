using UnityEngine;

public class MouseRaycast : MonoBehaviour
{
    public LayerMask layer;
    private GameObject obj;
    void Update()
    {
        // ���콺 ȭ�� ��ǥ�� ���� ������ Ray�� ��ȯ
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Raycast�� ����Ͽ� ���콺 ��ġ���� ������Ʈ�� �ִ��� Ȯ��
        RaycastHit hit;

        // ���̾� ����ũ�� ����Ͽ� Default ���̾ üũ
        int layerMask = layer;

        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Raycast �� Default ���̾ �ִ� ������Ʈ�� üũ
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            // ������Ʈ�� ���콺 ��ġ�� �������� ��
            Debug.Log("������Ʈ�� ���˵�: " + hit.collider.name);
            if (Input.GetMouseButton(0))
            {
                obj = hit.transform.gameObject;
                //obj.transform.position = new Vector3(hit.point.x, hit.point.y, 0);
                obj.transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, obj.transform.position.z);
                Debug.Log(mouseWorldPos.x +" "+ mouseWorldPos.y);
            }
            if (Input.GetMouseButtonUp(0))
            {
                obj = null;
            }
            

            // hit.point�� ���콺 ��ġ���� Ray�� ���� WorldSpace ��ǥ�Դϴ�.
            Debug.Log("x��ǥ : "+hit.point.x +"y��ǥ : "+hit.point.y);
        }
    }
}
