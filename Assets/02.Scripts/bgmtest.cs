using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmtest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.playBGM(SoundManager.BGM.BGM_TITLE);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
