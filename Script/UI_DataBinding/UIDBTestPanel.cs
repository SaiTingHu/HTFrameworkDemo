using UnityEngine.UI;

namespace HT.Framework.Demo
{
    /// <summary>
    /// UI数据驱动测试界面
    /// </summary>
    [UIResource("ui", "Assets/HTFrameworkDemo/Script/UI_DataBinding/DBTestPanel.prefab", "ResourcePath")]
    public class UIDBTestPanel : UILogicResident, IDataDriver<TestData>
    {
        public TestData Data { get; set; }

        [ObjectPath("InputFieldName"), DataBinding("Name")] private InputField _inputFieldName;
        [ObjectPath("TextName"), DataBinding("Name")] private Text _textName;
        [ObjectPath("InputFieldAge"), DataBinding("Age")] private InputField _inputFieldAge;
        [ObjectPath("TextAge"), DataBinding("Age")] private Text _textAge;
        [ObjectPath("SliderPower"), DataBinding("Power")] private Slider _sliderPower;
        [ObjectPath("TextPower"), DataBinding("Power")] private Text _textPower;
        [ObjectPath("ToggleIsGod"), DataBinding("IsGod")] private Toggle _toggleIsGod;
        [ObjectPath("ButtonIsGod"), DataBinding("IsGod")] private Button _buttonIsGod;

        [ObjectPath("PrintButton")] private Button _printButton = null;
        [ObjectPath("ResetButton")] private Button _resetButton = null;

        /// <summary>
        /// 初始化
        /// </summary>
        public override void OnInit()
        {
            base.OnInit();

            _printButton.onClick.AddListener(() =>
            {
                Log.Info(Data.Name);
                Log.Info(Data.Age);
                Log.Info(Data.Power);
                Log.Info(Data.IsGod);
            });
            _resetButton.onClick.AddListener(() =>
            {
                Data.Name.Value = "张三";
                Data.Age.Value = 30;
                Data.Power.Value = 0.5f;
                Data.IsGod.Value = false;
            });
        }
    }

    /// <summary>
    /// 数据驱动测试数据
    /// </summary>
    public class TestData
    {
        public BindableString Name;
        public BindableInt Age;
        public BindableFloat Power;
        public BindableBool IsGod;
    }
}