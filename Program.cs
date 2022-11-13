using System;



Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");



    // Ask a question
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
}

//phase 9
//Our moose is finally both enthusiastic and inquisitive, 
//but the code for asking each question is a little redundant.
//Refactor the app to reduce the redundancy in the code.
//create a method that encapsulates any duplicated code?


void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    // Console.WriteLine(isTrue);
    if (isTrue)
    {
        MooseSays($"Really? it seems very unikely.");
    }
    else
    {
        MooseSays("I Knew IT!!!");
    }
}

void EnthusiasticQuestion()
{
    bool isTrue = MooseAsks("Are you enthusiastic?");
    // Console.WriteLine(isTrue);
    if (isTrue)
    {
        MooseSays($"Yay!");
    }
    else
    {
        MooseSays("You should try it!!!");
    }
}

void LoveCSharpQuestion()
{
    bool isTrue = MooseAsks("Do you love c# yet?");
    // Console.WriteLine(isTrue);
    if (isTrue)
    {
        MooseSays($"Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool isTrue = MooseAsks("Do you want to know a secret?");
    // Console.WriteLine(isTrue);
    if (isTrue)
    {
        MooseSays($"ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no ...secrets are the best, I love to share them!");
    }
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    //ask the question
    Console.Write($"{question} (Y/N): ");
    //store the answer
    string answer = Console.ReadLine().ToLower();

    //while invalid answer continue to ask
    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }
    //if y return true otherwise return false;
    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}
