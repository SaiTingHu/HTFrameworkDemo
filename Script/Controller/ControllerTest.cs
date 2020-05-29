using UnityEngine;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 控制器测试
    /// </summary>
    public class ControllerTest : MonoBehaviour
    {
        public Transform Cube;
        public Transform Sphere;
        public GameObject NormalHelp;
        public GameObject TrackHelp;

        private void Awake()
        {
            Main.m_Controller.SetLookPoint(new Vector3(0.72f, -0.55f, -0.35f));
            Main.m_Controller.SetLookAngle(new Vector3(269.45f, 37.60f, 3.60f));
        }

        public void KeepTrackCube()
        {
            Main.m_Controller.EnterKeepTrack(Cube);
            NormalHelp.SetActive(false);
            TrackHelp.SetActive(true);
        }

        public void KeepTrackSphere()
        {
            Main.m_Controller.EnterKeepTrack(Sphere);
            NormalHelp.SetActive(false);
            TrackHelp.SetActive(true);
        }

        public void LeaveKeepTrack()
        {
            Main.m_Controller.LeaveKeepTrack();
            NormalHelp.SetActive(true);
            TrackHelp.SetActive(false);
        }
    }
}