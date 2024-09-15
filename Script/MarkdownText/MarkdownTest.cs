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
        }
    }
}