using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 音频测试
    /// </summary>
    public class AudioTest : MonoBehaviour
    {
        private AudioClip _clip;

        private void Awake()
        {
            _clip = Main.Current.GetAudioClipParameter("TestAudio");
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Play"))
            {
                Main.m_Audio.PlayBackgroundMusic(_clip);
            }
            if (GUILayout.Button("Pause"))
            {
                Main.m_Audio.PauseBackgroundMusic();
            }
            if (GUILayout.Button("UnPause"))
            {
                Main.m_Audio.UnPauseBackgroundMusic();
            }
            if (GUILayout.Button("Stop"))
            {
                Main.m_Audio.StopBackgroundMusic();
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Main.m_Audio.Mute = GUILayout.Toggle(Main.m_Audio.Mute, "Mute");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("Volume", GUILayout.Width(60));
            Main.m_Audio.BackgroundVolume = GUILayout.HorizontalSlider(Main.m_Audio.BackgroundVolume, 0f, 1f);
            GUILayout.EndHorizontal();
        }
    }
}