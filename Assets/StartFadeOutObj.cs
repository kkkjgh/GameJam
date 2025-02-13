using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFadeOutObj : MonoBehaviour
{
    public bool isTrigger;
    bool play;
    public SpriteRenderer renderer;
    private void Start()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.color = new Color(1,1,1,0);
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

                renderer.color = new Color(1, 1, 1, Mathf.Lerp(0f, 1f, elapsedTime / fadedTime));
                elapsedTime += Time.deltaTime;
                Debug.Log("Fade Out 중...");
                yield return null;
            }
            Debug.Log("Fade Out 끝");
            isTrigger = false;
        }
        play = false;

        yield break;
    }
}
