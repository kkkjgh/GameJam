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
        float elapsedTime = 0f; // ���� ��� �ð�
        float fadedTime = 2.5f; // �� �ҿ� �ð�

        while (elapsedTime <= fadedTime)
        {
            gameObject.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade In ��...");
            yield return null;
        }
        Debug.Log("Fade In ��");
        gameObject.SetActive(false); // Panel�� ��Ȱ��ȭ
        yield break;
    }
}
