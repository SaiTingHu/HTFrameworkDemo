using UnityEngine;

namespace HT.Framework.Demo
{
    public class MarkdownTest : HTBehaviour
    {
        public MarkdownText MT;

        protected override void Awake()
        {
            base.Awake();

            MT.OnClickHyperlink.AddListener((n, url) =>
            {
                Application.OpenURL(url);
            });
            MT.OnClickEmbedTexture.AddListener((sprite) =>
            {
                Log.Info("�����ͼ��");
            });
            MT.OnClickTable.AddListener((table) =>
            {
                Log.Info("����˱��");
            });
        }
    }
}