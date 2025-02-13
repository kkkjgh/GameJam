using UnityEngine;
using UnityEngine.EventSystems;

public class DragUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform canvas;               // UI가 소속되어 있는 최상단의 Canvas Transform
    private Vector3 previousPos;       // UI 시작 시 위치
    private RectTransform rect;             // UI 위치 제어를 위한 RectTransform
    private CanvasGroup canvasGroup;        // UI의 알파값과 상호작용 제어를 위한 CanvasGroup
    [SerializeField] private bool dragReplace = true; // 드래그 취소 시 위치 재설정

    private void Awake()
    {
        canvas = FindObjectOfType<Canvas>().transform;
        rect = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        previousPos = rect.transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
    }
    public void OnDrag(PointerEventData eventData)
    {
        rect.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (dragReplace)
        {
            rect.position = previousPos;
        }
    }
}

