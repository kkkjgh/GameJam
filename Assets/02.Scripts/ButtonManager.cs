using UnityEngine;
using UnityEngine.UI; // UI 버튼을 다루기 위한 네임스페이스

public class ButtonManager : MonoBehaviour
{
    public Button nextButton; // NextButton (캔버스에 있는 버튼을 연결)
    public int buttonClickCount = 0; // 클릭된 버튼 수
    public bool flag;

    void Start()
    {
        // 처음에는 NextButton을 비활성화
      //  nextButton.interactable = false;
    }

    void Update()
    {
        if (buttonClickCount >= 5)
        {
            flag = true;
            //  nextButton.interactable = true; // NextButton 활성화
        }
    }
    // 버튼이 클릭될 때 호출되는 함수
    public void OnButtonClicked()
    {
        buttonClickCount++; // 버튼 클릭 수 증가

        // 5개 버튼을 모두 클릭한 경우 NextButton을 활성화
        
    }
}
