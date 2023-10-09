using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW6_ball
{

    public partial class MainWindow : Window
    {
        private string[] answers =
        {
            "Безперечно.",
            "Однозначно так!",
            "Без сумнівів!",
            "Можеш бути впевненим.",
            "Можеш розраховувати на це.",

            "Здається, що так.",
            "Вірогідно так.",
            "Значні перспективи.",
            "Зірки говорять - \"так\".",
            "Так.",

            "Поки що неясно, час покаже.",
            "Можливо.",
            "Краще не відповідати.",
            "Зараз рано щось говорити.",
            "Сконцентруйся і спитай ще раз.",

            "Навіть не думай.",
            "Перспективи не дуже хороші.",
            "Не розраховуй на це.",
            "Мої джерела говорять - ні.",
            "Вельми сумнівно."
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            // Генерування випадкової відповіді
            Random random = new Random();
            int index = random.Next(answers.Length);
            string answer = answers[index];

            // Виведення відповіді в текстове поле
            answerTextBox.Text = answer;
        }
    }
}
