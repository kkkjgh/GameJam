using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class FimishBGM : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        


        //SoundManager.Instance.playBGM(SoundManager.BGM.BGM_TITLE); // Ÿ��Ʋ ���
        //SoundManager.Instance.playBGM(SoundManager.BGM.BGM_STAGE); // �������� ���
        SoundManager.Instance.playBGM(SoundManager.BGM.BGM_FINISH); // ���� ���
    }

    // Update is called once per frame
    void Update()
    {

    }
}
