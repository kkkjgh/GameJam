using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    public bool isStartFadeIn; // true=FadeIn, false=FadeOut
    public bool isStartFadeOut;
    public GameObject panel; // �������� ������ Panel ������Ʈ

    void Start()
    {
        if (!panel)
        {
            Debug.LogError("Panel ������Ʈ�� ã�� �� �����ϴ�.");
            throw new MissingComponentException();
        }
        if (isStartFadeIn && !isStartFadeOut) // Fade In Mode -> �ٷ� �ڷ�ƾ ����
        {
            panel.SetActive(true); // Panel Ȱ��ȭ
            FadeIn();
        }
        if (!isStartFadeIn && isStartFadeOut)
        {
            panel.SetActive(true); // Panel Ȱ��ȭ
            FadeOut();
        }
        else
        {
            //panel.SetActive(false); // Panel ��Ȱ��ȭ
        }

    }
    public void FadeIn()
    {
        panel.SetActive(true); // Panel Ȱ��ȭ
        Debug.Log("FadeCanvasController_ Fade In ����");
        StartCoroutine(CoFadeIn());
        Debug.Log("FadeCanvasController_ Fade In ��");
    }

    public void FadeOut()
    {
        panel.SetActive(true); // Panel Ȱ��ȭ
        Debug.Log("FadeCanvasController_ Fade Out ����");
        StartCoroutine(CoFadeOut());
        Debug.Log("FadeCanvasController_ Fade Out ��");
    }

    IEnumerator CoFadeIn()
    {
        float elapsedTime = 0f; // ���� ��� �ð�
        float fadedTime = 2.5f; // �� �ҿ� �ð�

        while (elapsedTime <= fadedTime)
        {
            // ���� �� ���� (1 -> 0����)
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade In ��...");
            yield return null;
        }

        Debug.Log("Fade In ��");
    }

    IEnumerator CoFadeOut()
    {
        float elapsedTime = 0f; // ���� ��� �ð�
        float fadedTime = 2.5f; // �� �ҿ� �ð�

        while (elapsedTime <= fadedTime)
        {
            // ���� �� ���� (0 -> 1��)
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade Out ��...");
            yield return null;
        }

       
        Debug.Log("Fade Out ��");
        // ���İ� 0�� ���·� �����ֵ��� ó�� �� ��Ȱ��ȭ �� ��
    }
}
