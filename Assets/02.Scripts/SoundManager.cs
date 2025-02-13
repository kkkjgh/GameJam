using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);

            if (audioBGM != null)
                audioBGM.loop = true; // BGM �ݺ� ����
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
            if (instance == null)
            {
                instance = FindObjectOfType<SoundManager>();
                if (instance == null)
                {
                    Debug.LogError("SoundManager �ν��Ͻ��� �������� �ʽ��ϴ�!");
                }
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

    [SerializeField] private AudioClip[] bgms;
    [SerializeField] private AudioClip[] sfxs;

    [SerializeField] private AudioSource audioBGM;
    [SerializeField] private AudioSource audioSFX;

    private Dictionary<SFX, float> sfxCooldown = new Dictionary<SFX, float>();

    public void playBGM(BGM bgmIndex)
    {
        if (audioBGM.clip == bgms[(int)bgmIndex] && audioBGM.isPlaying)
            return; // ���� BGM�� �̹� ��� ���̸� �ٽ� ������� ����.

        audioBGM.clip = bgms[(int)bgmIndex];
        audioBGM.Play();
    }

    public void stopBGM()
    {
        audioBGM.Stop();
    }

    public void playSFX(SFX sfxIndex)
    {
        if (sfxCooldown.ContainsKey(sfxIndex) && Time.time - sfxCooldown[sfxIndex] < 0.1f)
            return; // ���� SFX�� 0.1�� ���� �ٽ� ������� �ʵ��� ��.

        sfxCooldown[sfxIndex] = Time.time;
        audioSFX.PlayOneShot(sfxs[(int)sfxIndex]);
    }
}
