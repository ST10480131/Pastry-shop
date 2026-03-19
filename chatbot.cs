using systems;
using systems.Collection.Generic;

namespace chatbot{
    class program
    {
    static void main(string[] Args){
        //Creating the dictionary collection that stores keywords andtheir corresponding answers
        Dictionary<string,string>= new Dictionary<string,string>();{
        {"array","An array is a collection of items of the same variable type that are stored at contiguous memory locations."},
        {"loop","Looping in a programming language is a way to execute a statement or a set of statements multiple times, depending on the result of the condition to be evaluated to execute statements. "},
        {"debugging","Debugging is a process of finding errors, mistakes, or bugs in the code so that code gives the desired output."},
        {"variable","A variable is a named memory location used to store data and its value can change during program execution."},
        {"function", "A function is a block of code that performs a specific task."}
        };
        Console.WriteLine("Welcome to the softwaredevelopment chatbot");
        Console.WriteLine("Type your question or exit to quit")

        while(true){
            Console.write("\n:you");
            string input=Console.ReadLine();

            //Exit condition
            if(input.Tolowercase()=="Exit"){
                Console.WriteLine(Chatbot:Goodbye!,Goodluck on your coding journey);

                break;

            }

            
        }


        }

    }
}
}