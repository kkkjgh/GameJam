using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public Button button;  // 버튼 (Inspector에서 연결)
    public ButtonManager buttonManager;  // ButtonManager 연결

    void Start()
    {
        // 버튼 클릭 시 OnButtonClicked 호출
       // button.onClick.AddListener(OnButtonClicked);
    }

    // 버튼 클릭 시 호출되는 함수
    private void OnButtonClicked()
    {
       // button.interactable = false;  // 클릭된 버튼 비활성화
        buttonManager.OnButtonClicked();  // ButtonManager에 클릭 정보 전달
    }
}
