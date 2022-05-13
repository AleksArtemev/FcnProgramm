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

namespace FcnProgramm
{
    public partial class Page_Test : Page
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int qNum = 0;
        int i;
        int score;
        public Page_Test()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }
        private void checkAnswer(object sender, RoutedEventArgs e)
        {

            Button senderButton = sender as Button; 
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Score " + score + "/" + questionNumbers.Count;
            numb.Content = "Question:" + qNum + "/" + 10;

            NextQuestion();
        }
        private void RestartGame()
        {
            score = 0;
            qNum = -1; 
            i = 0; 
            StartGame();
        }
        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkGray;
            }

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "This is _____ tree.";

                    ans1.Content = "the";
                    ans2.Content = "a";
                    ans3.Content = "an";
                    ans4.Content = "- (Nothing)";

                    ans2.Tag = "1";

                    break;

                case 2:

                    txtQuestion.Text = "My father is _____ doctor.";

                    ans1.Content = "a";
                    ans2.Content = "the";
                    ans3.Content = "an";
                    ans4.Content = "- (Nothing)";

                    ans1.Tag = "1";

                    break;

                case 3:

                    txtQuestion.Text = "My mother is _____ economist.";

                    ans1.Content = "the";
                    ans2.Content = "a";
                    ans3.Content = "an";
                    ans4.Content = "- (Nothing)";

                    ans3.Tag = "1";

                    break;

                case 4:

                    txtQuestion.Text = "John bought _____ cap.";

                    ans1.Content = "the";
                    ans2.Content = "an";
                    ans3.Content = "a";
                    ans4.Content = "- (Nothing)";

                    ans3.Tag = "1";

                    break;

                case 5:

                    txtQuestion.Text = "It’s _____ apple.";

                    ans1.Content = "an";
                    ans2.Content = "the";
                    ans3.Content = "a";
                    ans4.Content = "- (Nothing)";

                    ans1.Tag = "1";

                    break;
                case 6:

                    txtQuestion.Text = "Give me _____ book.";

                    ans1.Content = "the";
                    ans2.Content = "an";
                    ans3.Content = "a";
                    ans4.Content = "- (Nothing)";

                    ans3.Tag = "1";

                    break;
                case 7:

                    txtQuestion.Text = "There is _____ bed in my room.";

                    ans1.Content = "the";
                    ans2.Content = "a";
                    ans3.Content = "an";
                    ans4.Content = "- (Nothing)";

                    ans2.Tag = "1";

                    break;
                case 8:

                    txtQuestion.Text = "_____ pens are bad.";

                    ans1.Content = "The";
                    ans2.Content = "An";
                    ans3.Content = "A";
                    ans4.Content = "- (Nothing)";

                    ans1.Tag = "1";

                    break;
                case 9:

                    txtQuestion.Text = "_____ man showed me that article.";

                    ans1.Content = "The";
                    ans2.Content = "An";
                    ans3.Content = "A";
                    ans4.Content = "- (Nothing)";

                    ans3.Tag = "1";

                    break;

                case 10:

                    txtQuestion.Text = "We are _____ teachers.";

                    ans1.Content = "a";
                    ans2.Content = "the";
                    ans3.Content = "an";
                    ans4.Content = "- (Nothing)";

                    ans4.Tag = "1";

                    break;
            }
        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;
        }

    }
}
