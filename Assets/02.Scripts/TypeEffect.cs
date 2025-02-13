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
        typetext = text; // �Է°� ���
        EffectStart();
    }
    public void EffectStart()
    {
        TargetText.text = ""; // �ؽ�Ʈ ����
        index = 0;
        endObj.SetActive(false);
        Debug.Log("������ ����");
        Invoke("Effecting", 1 / typeSecond); // 1���� �� �����̿� ���� ȣ��
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
        Invoke("Effecting", 1 / typeSecond); // 1���� �� �����̿� ���� ȣ�� �ݺ�
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
