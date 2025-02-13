using UnityEngine;

public class BGM : MonoBehaviour
{
    public SoundManager.BGM backgroundMusic;  // BGM ���� (Inspector���� ���� ����)
    public float volume = 1f;  // BGM ���� (�⺻��: 1)

    // BGM ��� (������ �Բ� �޴� ���·� ����)
    public void PlayBGM()
    {
        SoundManager.Instance.playBGM(backgroundMusic);  // ������ BGM ���
        SoundManager.Instance.SetBGMVolume(volume);  // ���� ����
    }

    // BGM ���߱�
    public void StopBGM()
    {
        SoundManager.Instance.stopBGM();  // BGM ���߱�
    }

    // BGM�� ������ ���� ��� (FadeOutBGM)
    public void FadeOutBGM(float fadeDuration)
    {
        SoundManager.Instance.FadeOutBGM(fadeDuration);  // FadeOutBGM ȣ��
    }
}
