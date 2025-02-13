using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    public bool isStartFadeIn; // true=FadeIn, false=FadeOut
    public bool isStartFadeOut;
    public GameObject panel; // 불투명도를 조절할 Panel 오브젝트

    void Start()
    {
        if (!panel)
        {
            Debug.LogError("Panel 오브젝트를 찾을 수 없습니다.");
            throw new MissingComponentException();
        }
        if (isStartFadeIn && !isStartFadeOut) // Fade In Mode -> 바로 코루틴 시작
        {
            panel.SetActive(true); // Panel 활성화
            FadeIn();
        }
        if (!isStartFadeIn && isStartFadeOut)
        {
            panel.SetActive(true); // Panel 활성화
            FadeOut();
        }
        else
        {
            //panel.SetActive(false); // Panel 비활성화
        }

    }
    public void FadeIn()
    {
        panel.SetActive(true); // Panel 활성화
        Debug.Log("FadeCanvasController_ Fade In 시작");
        StartCoroutine(CoFadeIn());
        Debug.Log("FadeCanvasController_ Fade In 끝");
    }

    public void FadeOut()
    {
        panel.SetActive(true); // Panel 활성화
        Debug.Log("FadeCanvasController_ Fade Out 시작");
        StartCoroutine(CoFadeOut());
        Debug.Log("FadeCanvasController_ Fade Out 끝");
    }

    IEnumerator CoFadeIn()
    {
        float elapsedTime = 0f; // 누적 경과 시간
        float fadedTime = 2.5f; // 총 소요 시간

        while (elapsedTime <= fadedTime)
        {
            // 알파 값 변경 (1 -> 0으로)
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade In 중...");
            yield return null;
        }

        Debug.Log("Fade In 끝");
    }

    IEnumerator CoFadeOut()
    {
        float elapsedTime = 0f; // 누적 경과 시간
        float fadedTime = 2.5f; // 총 소요 시간

        while (elapsedTime <= fadedTime)
        {
            // 알파 값 변경 (0 -> 1로)
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade Out 중...");
            yield return null;
        }

       
        Debug.Log("Fade Out 끝");
        // 알파가 0인 상태로 남아있도록 처리 후 비활성화 안 함
    }
}
