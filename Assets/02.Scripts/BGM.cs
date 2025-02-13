using UnityEngine;

public class BGM : MonoBehaviour
{
    public SoundManager.BGM backgroundMusic;  //  BGM ���� (Inspector���� ���� ����)

    // BGM ���
    public void PlayBGM()
    {
        SoundManager.Instance.playBGM(backgroundMusic);  // ������ BGM ���
    }

    // BGM ���߱�
    public void StopBGM()
    {
        SoundManager.Instance.stopBGM();  // BGM ���߱�
    }

    // BGM�� ������ ���� ��� �߰� (FadeOutBGM)
    public void FadeOutBGM(float fadeDuration)
    {
        SoundManager.Instance.FadeOutBGM(fadeDuration);  // FadeOutBGM ȣ��
    }
}
