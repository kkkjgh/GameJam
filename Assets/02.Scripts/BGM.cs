using UnityEngine;

public class BGM : MonoBehaviour
{
    public SoundManager.BGM backgroundMusic;  // BGM 종류 (Inspector에서 설정 가능)
    public float volume = 1f;  // BGM 볼륨 (기본값: 1)

    // BGM 재생 (볼륨도 함께 받는 형태로 수정)
    public void PlayBGM()
    {
        SoundManager.Instance.playBGM(backgroundMusic);  // 선택한 BGM 재생
        SoundManager.Instance.SetBGMVolume(volume);  // 볼륨 설정
    }

    // BGM 멈추기
    public void StopBGM()
    {
        SoundManager.Instance.stopBGM();  // BGM 멈추기
    }

    // BGM을 서서히 끄는 기능 (FadeOutBGM)
    public void FadeOutBGM(float fadeDuration)
    {
        SoundManager.Instance.FadeOutBGM(fadeDuration);  // FadeOutBGM 호출
    }
}
