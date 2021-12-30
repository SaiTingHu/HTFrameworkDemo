using UnityEngine.UI;

namespace HT.Framework.Demo
{
    /// <summary>
    /// UI数据驱动测试界面
    /// </summary>
    [UIResource("ui", "Assets/HTFrameworkDemo/Script/UI_DataBinding/DBTestPanel.prefab", "ResourcePath")]
    public class UIDBTestPanel : UILogicResident, IDataDriver
    {
        [InjectPath("InputFieldName"), DataBinding("HT.Framework.Demo.UIDBUserModel", "Name")] private InputField _inputFieldName;
        [InjectPath("TextName"), DataBinding("HT.Framework.Demo.UIDBUserModel", "Name")] private Text _textName;
        [InjectPath("InputFieldAge"), DataBinding("HT.Framework.Demo.UIDBUserModel", "Age")] private InputField _inputFieldAge;
        [InjectPath("TextAge"), DataBinding("HT.Framework.Demo.UIDBUserModel", "Age")] private Text _textAge;
        [InjectPath("SliderPower"), DataBinding("HT.Framework.Demo.UIDBUserModel", "Power")] private Slider _sliderPower;
        [InjectPath("TextPower"), DataBinding("HT.Framework.Demo.UIDBUserModel", "Power")] private Text _textPower;
        [InjectPath("ToggleIsGod"), DataBinding("HT.Framework.Demo.UIDBUserModel", "IsGod")] private Toggle _toggleIsGod;
        [InjectPath("ButtonIsGod"), DataBinding("HT.Framework.Demo.UIDBUserModel", "IsGod")] private Button _buttonIsGod;
        [InjectPath("DropdownRace"), DataBinding("HT.Framework.Demo.UIDBUserModel", "Race")] private Dropdown _dropdownRace;

        [InjectPath("PrintButton")] private Button _printButton = null;
        [InjectPath("ResetButton")] private Button _resetButton = null;
        [InjectPath("ClearBindButton")] private Button _clearBindButton = null;
        [InjectPath("DestroyButton")] private Button _destroyButton = null;

        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();

            _printButton.onClick.AddListener(() =>
            {
                UIDBUserModel model = Main.Current.GetDataModel<UIDBUserModel>();
                Log.Info(model.Name);
                Log.Info(model.Age);
                Log.Info(model.Power);
                Log.Info(model.IsGod);
                Log.Info(model.Race.Value + "." + model.Race.ValueString);
            });
            _resetButton.onClick.AddListener(() =>
            {
                UIDBUserModel model = Main.Current.GetDataModel<UIDBUserModel>();
                model.Name.Value = "张三";
                model.Age.Value = 30;
                model.Power.Value = 0.5f;
                model.IsGod.Value = false;
                model.Race.Value = 0;
            });
            _clearBindButton.onClick.AddListener(() =>
            {
                Main.Current.ClearDataBinding<UIDBUserModel>();
            });
            _destroyButton.onClick.AddListener(() =>
            {
                Main.m_UI.DestroyUI<UIDBTestPanel>();

                Main.Current.DelayExecute(() =>
                {
                    Main.m_UI.OpenUI<UIDBTestPanel>();
                }, 1);
            });
        }
    }
}