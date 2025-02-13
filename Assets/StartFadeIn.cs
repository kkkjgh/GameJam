using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFadeIn : MonoBehaviour
{
    public bool isTrigger;
    private void Start()
    {
    }
    private void Update()
    {
        if (isTrigger)
        {
            isTrigger = false;
            StartCoroutine(CoFadeIn());
        }
    }
    IEnumerator CoFadeIn()
    {
        float elapsedTime = 0f; // 누적 경과 시간
        float fadedTime = 2.5f; // 총 소요 시간

        while (elapsedTime <= fadedTime)
        {
            gameObject.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade In 중...");
            yield return null;
        }
        Debug.Log("Fade In 끝");
        gameObject.SetActive(false); // Panel을 비활성화
        yield break;
    }
}
