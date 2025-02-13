using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    public bool isFadeIn; // true=FadeIn, false=FadeOut
    public GameObject panel; // 불투명도를 조절할 Panel 오브젝트

    void Start()
    {
        if (!panel)
        {
            Debug.LogError("Panel 오브젝트를 찾을 수 없습니다.");
            throw new MissingComponentException();
        }

        if (isFadeIn) // Fade In Mode -> 바로 코루틴 시작
        {
            panel.SetActive(true); // Panel 활성화
            StartCoroutine(CoFadeIn());
        }
        else
        {
            panel.SetActive(false); // Panel 비활성화
        }
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
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade In 중...");
            yield return null;
        }
        Debug.Log("Fade In 끝");
        panel.SetActive(false); // Panel을 비활성화
        yield break;
    }

    IEnumerator CoFadeOut()
    {
        float elapsedTime = 0f; // 누적 경과 시간
        float fadedTime = 2.5f; // 총 소요 시간

        while (elapsedTime <= fadedTime)
        {
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade Out 중...");
            yield return null;
        }

        Debug.Log("Fade Out 끝");
        yield break;
    }
}
