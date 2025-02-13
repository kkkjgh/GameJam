using UnityEngine;

public class BGM : MonoBehaviour
{
    public SoundManager.BGM backgroundMusic;  //  BGM 종류 (Inspector에서 설정 가능)

    // BGM 재생
    public void PlayBGM()
    {
        SoundManager.Instance.playBGM(backgroundMusic);  // 선택한 BGM 재생
    }

    // BGM 멈추기
    public void StopBGM()
    {
        SoundManager.Instance.stopBGM();  // BGM 멈추기
    }

    // BGM을 서서히 끄는 기능 추가 (FadeOutBGM)
    public void FadeOutBGM(float fadeDuration)
    {
        SoundManager.Instance.FadeOutBGM(fadeDuration);  // FadeOutBGM 호출
    }
}
