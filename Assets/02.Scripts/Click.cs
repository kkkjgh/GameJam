using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public Camera camera; // 카메라 참조
    private Vector3 mousePos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 위치를 화면 좌표로 받아옵니다.
            mousePos = Input.mousePosition;

            // 카메라의 Z값을 통해 월드 좌표로 변환합니다.
            mousePos.z = camera.nearClipPlane; // 또는 카메라와의 적당한 거리로 설정 가능

            // 화면 좌표를 월드 좌표로 변환합니다.
            Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);

            // 월드 좌표에서 Raycast를 실행
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero); // 클릭한 위치에서 Raycast

            // 충돌한 오브젝트가 있는지 확인
            if (hit.collider != null)
            {
                // 충돌한 오브젝트가 Default 레이어에 있을 경우
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Default"))
                {
                    // 충돌한 오브젝트 처리
                    Debug.Log("Hit object: " + hit.collider.gameObject.name);
                }
            }

            // 변환된 월드 좌표로 게임 오브젝트 위치 설정
            transform.position = worldPos;
            // 변환된 월드 좌표 출력
            Debug.Log("Mouse Position in World: " + worldPos);
        }
    }
}
