using UnityEngine;
using UnityEngine.UI;

public class Button_VolDown : MonoBehaviour
{
    // 버튼 UI와 연결
    public Button myButton;

    void Start()
    {
        // 버튼 클릭 시 OnButtonClick 메서드를 호출
        myButton.onClick.AddListener(OnButtonClick);
    }

    // 버튼 클릭 시 BGM을 서서히 끄는 기능 실행
    void OnButtonClick()
    {
        // BGM을 2초 동안 서서히 줄이기
        SoundManager.Instance.FadeOutBGM(2f); // 2초 동안 BGM 서서히 끄기
    }
}