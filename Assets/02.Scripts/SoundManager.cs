using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance = null;

    void Awake()
    {
        if (null == instance)
        {
            //�� Ŭ���� �ν��Ͻ��� ź������ �� �������� instance�� ���ӸŴ��� �ν��Ͻ��� ������� �ʴٸ�, �ڽ��� �־��ش�.
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static SoundManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    public enum BGM
    {
        BGM_TITLE,
        BGM_STAGE,
        BGM_FINISH
    }
    public enum SFX
    {
        SFX_BUTTON,
        SFX_ENDING,
        SFX_NEXTSTAGE,
        SFX_CLEAR,
        SFX_FINISH
    }

    [SerializeField] AudioClip[] bgms;
    [SerializeField] AudioClip[] sfxs;

    [SerializeField] AudioSource audioBGM;
    [SerializeField] AudioSource audioSFX;

    public void playBGM(BGM bgmIndex)
    {
        audioBGM.clip = bgms[(int)bgmIndex];
        audioBGM.Play();
    }

    public void stopBGM() {
        audioBGM.Stop(); 
    }
    public void playSFX(SFX sfxIndex)
    {
        audioSFX.PlayOneShot(sfxs[(int)sfxIndex]);
    }
}
