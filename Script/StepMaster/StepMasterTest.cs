using UnityEngine.UI;

namespace HT.Framework.Demo
{
    /// <summary>
    /// 步骤控制器测试
    /// </summary>
    public class StepMasterTest : HTBehaviour
    {
        public StepContentAsset Content;
        public Text PromptText;

        private void Start()
        {
            Main.m_StepMaster.BeginStepEvent += OnBeginStep;
            Main.m_StepMaster.EndEvent += OnEnd;

            Main.m_StepMaster.ContentAsset = Content;
            Main.m_StepMaster.RecompileStepContent();
            Main.m_StepMaster.Begin();
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();

            if (Main.m_StepMaster != null)
            {
                Main.m_StepMaster.BeginStepEvent -= OnBeginStep;
                Main.m_StepMaster.EndEvent -= OnEnd;

                Main.m_StepMaster.End();
            }
        }

        private void OnBeginStep(StepContent stepContent, bool isEnable)
        {
            PromptText.text = stepContent.GetPrompt;

            Main.m_StepMaster.Guide();
        }
        private void OnEnd()
        {
            PromptText.text = "步骤流程结束！";
        }
    }
}