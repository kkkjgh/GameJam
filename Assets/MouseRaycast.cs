using UnityEngine;

public class MouseRaycast : MonoBehaviour
{
    public LayerMask layer;
    private GameObject obj;
    void Update()
    {
        // 마우스 화면 좌표를 월드 공간의 Ray로 변환
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Raycast를 사용하여 마우스 위치에서 오브젝트가 있는지 확인
        RaycastHit hit;

        // 레이어 마스크를 사용하여 Default 레이어만 체크
        int layerMask = layer;

        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Raycast 시 Default 레이어에 있는 오브젝트만 체크
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            // 오브젝트가 마우스 위치에 접촉했을 때
            Debug.Log("오브젝트에 접촉됨: " + hit.collider.name);
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
            

            // hit.point는 마우스 위치에서 Ray가 닿은 WorldSpace 좌표입니다.
            Debug.Log("x좌표 : "+hit.point.x +"y좌표 : "+hit.point.y);
        }
    }
}
