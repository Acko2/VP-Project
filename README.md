# Visual programming project
### Изработено од: Александар Алимаскоски, Петар Божиновски


Во овој проект е имплементиран едноставен Квиз кој содржи три категории на прашања: Историја, Географија и општи тривијални прашања.
Имплементиран е и систем на Highscore, како и преглед на одговорените прашања на крајот од играта.


Прашањата и податоците за Highscore се чуваат во едноставни текст фајлови кои служат како податочна база, за манипулација со овие податоци е искористена IO библиотеката.


### Упаство на користење

Целта на играта е да се одговорат 10 прашања со 4 понудени одговори, притоа имајќи период од 30 секунди за секој одговор поединечно,
 во случај да измине времето прашањето се рачуна како погрешно.
 
### Почеток на игра

За старт на квизот потребно е да се внесе име, а потоа да се кликне копчето Start quiz

![Start game](https://i.imgur.com/aE0nvdE.png)

По кликнување на копчето за старт се појавуваат опции за избор на категорија

![Choose category](https://i.imgur.com/mU7DGv0.png)

Со избор на катергорија се прикажува нова форма каде што се поставуваат прашањата

![Questions](https://i.imgur.com/ICIT7jV.png)

По одговарање на последното прашање се појавува форма за преглед на точните одговори

![Review](https://i.imgur.com/n43CCWq.png)

Со клик на копчето Highscores, се отвара нова форма во која се гледаат рекордите на играчите

![Highscore](https://i.imgur.com/ttj7EN4.png)


### Груб опис на функционирање

По проверка на која категорија е одбрана се вчитуваат прашањата од дадената категорија

```
if (startForm.category == "history")
{
    path = Path.Combine(Directory.GetCurrentDirectory(), "historyQuestions.txt");
}

List<string> questionsFromFile = File.ReadAllLines(path).ToList();

```

Следно, поради тоа што податоците во текст фајловите се чуваат оделени со запирка (CSV) потребен ни е следниот код за полеснa работа со тие податоци

```
List<Question> questions = new List<Question>();

foreach (var line in questionsFromFile)
{
    string[] parts = line.Split(',');
    Question question = new Question();
    question.question = parts[0];
    question.answer1 = parts[nums2[0]];
    question.answer2 = parts[nums2[1]];
    question.answer3 = parts[nums2[2]];
    question.answer4 = parts[nums2[3]];
    question.correntAnswer = parts[5];
    questions.Add(question);
}

```

За случајно прикажување на прашањата ја користиме Random класата

```

int[] nums = Enumerable.Range(0, 10).ToArray();

// овој бројач го зголемуваме при секој одговор, независно точен или неточен
int questionPosition = 0;

public Form1(){

  InitializeComponent();
  
  // Целта на овој код е да креира низа со уникатни случајни бројки од 0 до 9, кои ги користиме за случаен приказ на прашања
  
  for (int i = 0; i < nums.Length; ++i)
  {
      int randomIndex = rnd.Next(nums.Length);
      int temp = nums[randomIndex];
      nums[randomIndex] = nums[i];
      nums[i] = temp;
  }
  
}

// пример nums={3,5,7,4....}, на старт nums[questionPosition] ќе даде вредност 3 кој го прикажува прашањето од листата
на прашања со индекс број 3, ова ни овозможува случаен приказ

private void pickQuestion()
{
    lblQuestion.Text = questions[nums[questionPosition]].question;
    btnAnswer1.Text = questions[nums[questionPosition]].answer1;
    btnAnswer2.Text = questions[nums[questionPosition]].answer2;
    btnAnswer3.Text = questions[nums[questionPosition]].answer3;
    btnAnswer4.Text = questions[nums[questionPosition]].answer4;
}

```

Проверка на точен одговор

```
private void checkAnswer(object sender, EventArgs e)
{
    var button = (Button)sender;
    string buttonAnswer = button.Text;

    addQuestionForReview(buttonAnswer);

    // проверуваме дали текстот на кликнатото копче е еднаков со текстот на точното прашање
    
    if (buttonAnswer == questions[nums[questionPosition]].correntAnswer)
    {
        points++;

    }
    questionPosition++;
}

```
