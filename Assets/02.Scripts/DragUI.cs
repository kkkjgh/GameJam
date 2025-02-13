using UnityEngine;
using UnityEngine.EventSystems;

public class DragUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform canvas;               // UI�� �ҼӵǾ� �ִ� �ֻ���� Canvas Transform
    private Vector3 previousPos;       // UI ���� �� ��ġ
    private RectTransform rect;             // UI ��ġ ��� ���� RectTransform
    private CanvasGroup canvasGroup;        // UI�� ���İ��� ��ȣ�ۿ� ��� ���� CanvasGroup
    [SerializeField] private bool dragReplace = true; // �巡�� ��� �� ��ġ �缳��

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

