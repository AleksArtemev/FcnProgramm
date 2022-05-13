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
    /// <summary>
    /// Логика взаимодействия для Page_Dialogue.xaml
    /// </summary>
    public partial class Page_Dialogue : Page
    {
            List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int qNum = 0;
            int i;
            int score;
            public Page_Dialogue()
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
                numb.Content = "Page:" + qNum + "/" + 10;

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

                        txtQuestion.Text = "Waiter: Welcome to our restaurant. Did you book a table in advance? \nDavid: Hello.Yes, we ______ a table for Laurins.";

                        ans1.Content = "order";
                        ans2.Content = "ordered";
                        ans3.Content = "are";

                        ans2.Tag = "1";

                        break;

                    case 2:

                        txtQuestion.Text = "W: All right. Follow me. Here's your table, as you wanted, by the window. Let me take your and your lady's coats. \nD: Yes, please.Sit down, dear. \nW: Check out our menu. I'll ____ in a minute ... Are you ready to order?";

                        ans1.Content = "come";
                        ans2.Content = "coming";
                        ans3.Content = "going";

                        ans1.Tag = "1";

                        break;

                    case 3:

                        txtQuestion.Text = "D: No, not yet. Give us a little time to study the menu. \nW: Good.Call me when you're ready. \nD: Darling, what will you ___? \nAmanda: Oh, there is such a chic choice of dishes. I am even confused. What would you advise?";

                        ans1.Content = "want";
                        ans2.Content = "eating";
                        ans3.Content = "eat";

                        ans3.Tag = "1";

                        break;

                    case 4:

                        txtQuestion.Text = "D: I can recommend fried duck with cream sauce. A tasty dish. The fish here is also gorgeous. Actually, the chef in this restaurant is a true master. All his dishes are delicious. \nA: Then I'll order a _____ with seafood and a duck. \nD: And the dessert ? ";

                        ans1.Content = "apple";
                        ans2.Content = "salt";
                        ans3.Content = "salad";

                        ans3.Tag = "1";

                        break;

                    case 5:

                        txtQuestion.Text = "A: I would like to try a cheesecake. I love to cook it myself, but I will not refuse from the ready dish. \nA: Excellent.Waiter! \nW: I'm _______ to you.";

                        ans1.Content = "listening";
                        ans2.Content = "listen";
                        ans3.Content = "listened";

                        ans1.Tag = "1";

                        break;
                    case 6:

                        txtQuestion.Text = "D: Bring us, please, a salad with seafood and a duck for the lady, and I'll order a julien with mushrooms and entrecote. \nW: Will you order the ______? \nD: Yes, of course. One cheesecake and a slice of banana cake.";

                        ans1.Content = "desserted";
                        ans2.Content = "desert";
                        ans3.Content = "dessert";

                        ans3.Tag = "1";

                        break;
                    case 7:

                        txtQuestion.Text = "W: What will you drink? \nD: Today we have a holiday, an anniversary, which means that we will ______ champagne. \nW: Dry, sweet or semisweet ? ";

                        ans1.Content = "drinking";
                        ans2.Content = "drink";
                        ans3.Content = "drinks";

                        ans2.Tag = "1";

                        break;
                    case 8:

                        txtQuestion.Text = "D: White semisweet. \nW: Excellent choice. Your order will be ready in 15 minutes.Shall I bring the champagne right now? \nD: Yes, so it _____ not be boring to wait for our order.";

                        ans1.Content = "will not";
                        ans2.Content = "won't";
                        ans3.Content = "don't";

                        ans1.Tag = "1";

                        break;
                    case 9:

                        txtQuestion.Text = "W: Here is your champagne. And this is a gift from the chef in honor of your holiday. \nD: Thank you very much. We are ______ pleased!";

                        ans1.Content = "so";
                        ans2.Content = "very";
                        ans3.Content = "not";

                        ans2.Tag = "1";

                        break;

                    case 10:

                    txtQuestion.Text = "A: Your order, sir. Anything else? \nD: Thank you. All is _______.";

                    ans1.Content = "good";
                    ans2.Content = "perfectly";
                    ans3.Content = "perfect";

                    ans3.Tag = "1";

                    break;
            }
            }
        private void StartGame()
        {
            questionNumbers = questionNumbers;
        }
    }
}
