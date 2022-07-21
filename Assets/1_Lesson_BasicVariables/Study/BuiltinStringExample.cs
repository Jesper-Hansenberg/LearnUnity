using UnityEngine;

//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/

public class BuiltinStringExample : MonoBehaviour
{
    //Defining a string
    public string MyString = "This is how to define a string!";

    //A string is a list of characters
    public char[] listOfCharacters = {'H','e','l','l','o'};
        
    //It can also be a predecleration for work later in the code and just be empty for now
    public string MyEmptyString;

    //When the game starts, this method is the first to be called
    //If the script exists on an active GameObject in the Scene
    public void Start(){
        
        //Printing the string to the Console
        Debug.Log(MyString);

        //Length of string (How many characters)
        Debug.Log(MyString.Length);

        //A string is a list of characters
        
        string aCombinedString = new string (listOfCharacters); 
        Debug.Log(aCombinedString);

        //A "string" does not have a specific size in the memory, but can be calculated by
        int howManyBytes = MyString.Length * sizeof(char); //Bytes
        Debug.Log("Size of string: " + howManyBytes);
        
        
        //Changing the string value of the "Field" in the "BuiltinStringExample" Class
        MyString = "I Changed the string";
        Debug.Log(MyString);       
        
        //Defining a temporary local string, (This value only exists where it's defined; in the "Start()"-method, aka. it's local scope)
        string temporaryString = ", I have defined a string in the local scope of the 'Start()'-method called 'TemporaryString'";
        
        //C# Is able to join to strings together via the "+" sign, see below
        string finalString = MyString + temporaryString;
        Debug.Log(finalString);

        //C# doesn't understand how to subtract two strings
        //finalString = finalString - MyString;
        //finalString.Remove() can be used, but a better way is looking into regular expression

        //We can use conditional statements to check if 2 strings match
        if("I Changed the string" == MyString){
            Debug.Log("We have a match!");
        }
    }
}
