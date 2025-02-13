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
            float elapsedTime = 0f; // ���� ��� �ð�
            float fadedTime = 2.5f; // �� �ҿ� �ð�

            while (elapsedTime <= fadedTime)
            {

                renderer.color = new Color(1, 1, 1, Mathf.Lerp(0f, 1f, elapsedTime / fadedTime));
                elapsedTime += Time.deltaTime;
                Debug.Log("Fade Out ��...");
                yield return null;
            }
            Debug.Log("Fade Out ��");
            isTrigger = false;
        }
        play = false;

        yield break;
    }
}
