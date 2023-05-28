using System;

class Program
{
    static void Main(string[] args)
    {
        Videos video1 = new Videos();
        video1._author = "Jonathan Myers";
        video1._tittle = "How to do a short chase in DBD";
        video1._length = 300;

        Comments comment11 = new Comments();
        comment11._name = "Mary Jones";
        comment11._text = "Great video";
        
        Comments comment12 = new Comments();
        comment12._name = "Jon Jones";
        comment12._text = "Helps me a lot, thanks";

        Comments comment13 = new Comments();
        comment13._name = "Tyler Park";
        comment13._text = "Excellent, super clear and funny";

        Videos video2 = new Videos();
        video2._author = "Steave Harritson";
        video2._tittle = "How to prepare pop corn in 5 minutes";
        video2._length = 320;

        Comments comment21 = new Comments();
        comment21._name = "Maria De La Rosa";
        comment21._text = "New suscriptor";
        
        Comments comment22 = new Comments();
        comment22._name = "Yoshi Atanawa";
        comment22._text = "You are the best man";

        Comments comment23 = new Comments();
        comment23._name = "Peter Parker";
        comment23._text = "Super fun, I want to try";

        Videos video3 = new Videos();
        video3._author = "Nancy Wheeler";
        video3._tittle = "Where to find monkeys";
        video3._length = 420;

        Comments comment31 = new Comments();
        comment31._name = "Meg Thomas";
        comment31._text = "I love the monkeys, thanks for information";
        
        Comments comment32 = new Comments();
        comment32._name = "Connor McGregor";
        comment32._text = "I planning to visit that place, thanks Nancy";

        Comments comment33 = new Comments();
        comment33._name = "Leon S. Kennedy";
        comment33._text = "I would to take a photo with a monkey";

        video1._comment.Add(comment11);
        video1._comment.Add(comment12);
        video1._comment.Add(comment13);

        video2._comment.Add(comment21);
        video2._comment.Add(comment22);
        video2._comment.Add(comment23);

        video3._comment.Add(comment31);
        video3._comment.Add(comment32);
        video3._comment.Add(comment33);

        Console.Clear();
        video1.Display();
        Console.WriteLine();
        video2.Display();
        Console.WriteLine();
        video3.Display();
    }
}