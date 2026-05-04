using CheckValidators;
using CoreResourceManager;
using SingleFileExtractor.Core;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //var ww = Resource.Get("1_1_1.png");

            string name = "Pasha";
            //var qq = new Check<string>(name)
            //                .IfNull()
            //                .IfEmptyOrWhitespace()
            //                .IfNot(s => s.Contains("keyword"), "The string does not contain the keyword.")
            //                .ReturnErrors();

            var qq = new Check<int>(50)
                    .If(s => s <= 0 , "Текущее значение меньше нуля")
                    .If(s => s > 99, "Текущее значение больше 99")
                    .ReturnErrors();

            qq = qq;
        }
    }
}
