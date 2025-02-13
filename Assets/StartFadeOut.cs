using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFadeOut : MonoBehaviour
{
    public bool isTrigger;
    bool play;
    private void Start()
    {
        gameObject.GetComponent<CanvasRenderer>().SetAlpha(0);
    }
    private void Update()
    {
        if (isTrigger)
        {
            StartCoroutine(CoFadeOut());
        }
    }
    IEnumerator CoFadeOut()
    {
        if (!play)
        {
            play = true;
            float elapsedTime = 0f; // 누적 경과 시간
            float fadedTime = 2.5f; // 총 소요 시간

            while (elapsedTime <= fadedTime)
            {
                gameObject.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / fadedTime));

                elapsedTime += Time.deltaTime;
                yield return null;
            }
            isTrigger = false;
        }
        play = false;

        yield break;
    }
}
