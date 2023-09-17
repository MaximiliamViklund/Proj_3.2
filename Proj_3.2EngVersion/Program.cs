int v=0;
string r;

Console.WriteLine("Welcome to Random Questions, where I ask you about random shit, and you try and answer correctly.");
Console.WriteLine("Please write the letter associated with your answer. For example:");
Console.WriteLine("Do you understand the instructions?");
Console.WriteLine("a)Yes b)No c)Ofcourse, let's go!");
r = Console.ReadLine().ToLower();

if(r=="a"){
    Console.WriteLine("Great, lets go.");
}
else if(r=="b"){
    Console.WriteLine("You seem to have understod tho??");
    Console.WriteLine("So let's go anyway.");
}
else if(r=="c"){
    Console.WriteLine("Love your enthusiasm, LETS GOOO!!");
}
else{
    Console.WriteLine("Are you fucking stupid???");
    Console.WriteLine("Write one of the given answers next time!!");
}

/*----------------------------------------------------------------------------------------*/
/*Frågorna*/


if (r=="a"||r=="b"||r=="c"){
    Console.WriteLine("Vem är skaparen av detta spelet?");
    Console.WriteLine("a)Sverre b)Maximiliam c)Sam");
    r=Console.ReadLine().ToLower();
    if(r=="b"){
        v++;
    }
    

    if(r=="a"||r=="b"||r=="c"){
        Console.WriteLine("Vad är namnet på en oordnad lista i HTML?");
        Console.WriteLine("a)ul b)ol c)hl");
        r=Console.ReadLine().ToLower();
        if(r=="a"){
            v++;
        }


        if(r=="a"||r=="b"||r=="c"){
            Console.WriteLine("Vem är den sämsta läraren på skolan?");
            Console.WriteLine("a)Kalle b)Mikael c)Vera");
            r=Console.ReadLine().ToLower();
            if(r=="a"||r=="c"){
                v++;
            }


            if(r=="a"||r=="b"||r=="c"){
                Console.WriteLine("Vem är bästa läraren på skolan?");
                Console.WriteLine("a)Jesus Skinberg b)Mikael c)Ulf");
                r=Console.ReadLine().ToLower();
                if(r=="a"||r=="b"){
                    v++;
                }


                if(r=="a"||r=="b"||r=="c"){
                    if(v<=1){
                        Console.WriteLine("You got "+v+" right answers, you're fucking shit mate.");
                        Console.WriteLine($"");
                    }
                    if(v>=3){
                        Console.WriteLine("Congratulations! You got "+v+" right answers, good job!");
                    }
                }

/*----------------------------------------------------------------------------------------*/
/*Fail safe*/

                else{
                    Console.WriteLine("Are you fucking stupid???");
                    Console.WriteLine("Write one of the given answers next time!!");
                    }
            }
            else{
                Console.WriteLine("Are you fucking stupid???");
                Console.WriteLine("Write one of the given answers next time!!");
                }
        }
        else{
            Console.WriteLine("Are you fucking stupid???");
            Console.WriteLine("Write one of the given answers next time!!");
            }
    }
    else{
        Console.WriteLine("Are you fucking stupid???");
        Console.WriteLine("Write one of the given answers next time!!");
        }
    
}
else{
    Console.WriteLine("Are you fucking stupid???");
    Console.WriteLine("Write one of the given answers next time!!");
}

Console.ReadLine();