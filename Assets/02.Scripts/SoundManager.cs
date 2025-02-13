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
        SFX_CLICK,
        SFX_BOOK,
        SFX_1ST_CLOCK,
        SFX_1ST_CIGARETTE,
        SFX_1ST_ARM,
        SFX_1ST_TEAR,
        SFX_2ST_CURTAIN,
        SFX_2ST_RESUME,
        SFX_2ST_CHARACTER,
        SFX_2ST_POSITIVE,
        SFX_3ST_PLAQUE,
        SFX_3ST_FAMILY,
        SFX_3ST_MIRROR,
        SFX_4ST_CHAIR,
        SFX_4ST_FRAME,
    }

    [SerializeField] private AudioClip[] bgms;
    [SerializeField] private AudioClip[] sfxs;

    [SerializeField] private AudioSource audioBGM;
    [SerializeField] private AudioSource audioSFX;

    private Dictionary<SFX, Coroutine> playingSFXCoroutines = new Dictionary<SFX, Coroutine>();
    private Dictionary<SFX, float> sfxCooldown = new Dictionary<SFX, float>();

    void OnSceneLoaded()
    {
        // ���� �ε�� �� BGM ������ �⺻������ �ʱ�ȭ
        audioBGM.volume = 1f;
    }

    public void playBGM(BGM bgmIndex)
    {
        if (audioBGM.clip == bgms[(int)bgmIndex] && audioBGM.isPlaying)
            return;

        audioBGM.clip = bgms[(int)bgmIndex];
        audioBGM.Play();
    }

    public void stopBGM()
    {
        audioBGM.Stop();
        audioBGM.volume = 1f; // BGM�� ������ ��, ������ �ʱ�ȭ (���� ������ �ٽ� 1�� ����)
    }

    public void playSFX(SFX sfxIndex)
    {
        if (sfxCooldown.ContainsKey(sfxIndex) && Time.time - sfxCooldown[sfxIndex] < 0.1f)
            return;

        sfxCooldown[sfxIndex] = Time.time;

        if (playingSFXCoroutines.ContainsKey(sfxIndex))
        {
            StopCoroutine(playingSFXCoroutines[sfxIndex]);
        }

        playingSFXCoroutines[sfxIndex] = StartCoroutine(PlaySFXWithLimit(sfxIndex));
    }

    private IEnumerator PlaySFXWithLimit(SFX sfxIndex)
    {
        audioSFX.clip = sfxs[(int)sfxIndex];
        audioSFX.Play();

        yield return new WaitForSeconds(3f);

        if (audioSFX.isPlaying && audioSFX.clip == sfxs[(int)sfxIndex])
        {
            audioSFX.Stop();
        }

        playingSFXCoroutines.Remove(sfxIndex);
    }

    // BGM�� ������ ���� ���
    public void FadeOutBGM(float duration)
    {
        StartCoroutine(FadeOutBGMCoroutine(duration));
    }

    private IEnumerator FadeOutBGMCoroutine(float duration)
    {
        float startVolume = audioBGM.volume;
        float targetVolume = 0.2f; // ���̵� �ƿ� ���� ��ǥ ����

        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            // ���������� BGM�� ������ ����
            audioBGM.volume = Mathf.Lerp(startVolume, targetVolume, t / duration);
            yield return null;
        }

        // ���������� BGM ������ ��Ȯ�� targetVolume���� ����
        audioBGM.volume = targetVolume;
    }


    // BGM ������ �����ϴ� �޼ҵ�
    public void SetBGMVolume(float volume)
    {
        audioBGM.volume = volume;
    }
}
