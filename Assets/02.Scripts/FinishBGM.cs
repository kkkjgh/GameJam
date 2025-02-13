using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class FimishBGM : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        


        //SoundManager.Instance.playBGM(SoundManager.BGM.BGM_TITLE); // 타이틀 브금
        //SoundManager.Instance.playBGM(SoundManager.BGM.BGM_STAGE); // 스테이지 브금
        SoundManager.Instance.playBGM(SoundManager.BGM.BGM_FINISH); // 엔딩 브금
    }

    // Update is called once per frame
    void Update()
    {

    }
}
