using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeEffect : MonoBehaviour
{
    public Text TargetText;
    public string typetext;
    public float typeSecond;
    [SerializeField]private int index = 0;
    public GameObject endObj;
    public GameObject flagObj;
    public bool typeEnd;
    

    private void Start()
    {
        SetText(typetext);
    }
    public void SetText(string text)
    {
        typetext = text; // 입력값 백업
        EffectStart();
    }
    public void EffectStart()
    {
        TargetText.text = ""; // 텍스트 비우기
        index = 0;
        endObj.SetActive(false);
        Debug.Log("이펙팅 시작");
        Invoke("Effecting", 1 / typeSecond); // 1글자 당 딜레이에 맞춘 호출
    }
    public void Effecting()
    {
        if (TargetText.text == typetext)
        {
            EffectEnd();
            return;
        }
        TargetText.text += typetext[index];
        index++;
        Invoke("Effecting", 1 / typeSecond); // 1글자 당 딜레이에 맞춘 호출 반복
    }
    public void EffectEnd()
    {
        typeEnd = true;
        endObj.SetActive(true);
        if(flagObj != null)
        {
            flagObj.GetComponent<allSwitch>().flag = true;
        }
    }
}
