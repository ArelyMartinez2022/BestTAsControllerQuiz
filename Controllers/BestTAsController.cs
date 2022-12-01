/* 
* DONEEEE Create a new web api in Visual Studio Code.

* DONEEEE Create a new controller and name it BestTAsController.

* DONEEEE Create an endpoint called AddTwoNumbers and pass in two variables using the route.

* DONEEEE In AddTwoNumbers, take in the variables that was used in the route, add them together and return the sum.

* DONEEEE Create an endpoint called ReverseIt and let it pass in 1 variable using the route.
In ReverseIt, take in the variable that was used in the route and reverse it and return the solution.

* DONEEEE Create an endpoint called SayHello, and let it pass in 1 variable using the route.
In SayHello, take in the variable that was used in the route and return hello + variable.

* DONEEEE Create another endpoint called SayHelloTwo.
* DONEEEE  Instead of using variables in the route, use a model to enter in the name.

Hint (new folder/ file, get and set, constructor).
*/

using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class BestTasController : ControllerBase
{
    // 1. THIS IS FOR ADDTWO NUMBERS   1. THIS IS FOR ADDTWO NUMBERS   1. THIS IS FOR ADDTWO NUMBERS  
    [HttpGet]
    [Route("AddTwoNumbers")]
    public string AddTwoNumbers( )
    {

        return "LETS ADD TWO NUMBERS!! ";
    }

    [HttpGet]
    [Route("AddTwoNumbers/{number1}/{number2}")]
    public string AddTwoNumbers(string number1, string number2 )
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 =  Convert.ToInt32(number2);
        int answer =  convertNum1 + convertNum2;
        return $"{convertNum1} + {convertNum2} = {answer} ";
    }


    // 2. THIS IS FOR REVERSE IT   2. THIS IS FOR REVERSE IT   2. THIS IS FOR REVERSE IT   2. THIS IS FOR REVERSE IT  
    [HttpGet]
    [Route("ReverseIt")]
    //localHost9000/Input/Name
    public string Reverse()
    {
        return "ENTER IN SOMETHING AND ILL REVERSE IT!!";
    }

    [HttpGet]
    [Route("ReverseIt/{orignial}")]
    //localHost9000/Input/Name
    public string ReversIt(string orignial)
    {
        char[] array = orignial.ToCharArray();
        string reverse = String.Empty;
        for (int i = array.Length - 1; i > -1; i--)
        {
            reverse += array[i];
        }
        return $"YOUR ORIGINAL INPUT: {orignial} \nYOUR INPUT BUT REVERESED: {reverse}";
    }

    // 3. THIS IS FOR SAY HELLO   3. THIS IS FOR SAY HELLO  3. THIS IS FOR SAY HELLO   3. THIS IS FOR SAY HELLO 
    [HttpGet]
    [Route("SayHello")]
    //localHost9000/Input/Name
    public string SayHello()
    {
        return"Hello Whats Your Name? !";
    }

    [HttpGet]
    [Route("SayHello/{name}")]
    //localHost9000/Input/Name
    public string SayHello(string name)
    {
        return$"Whats up {name}!";
    }

    // 4. THIS IS FOR SAY HELLO PT2  4. THIS IS FOR SAY HELLO PT2  4. THIS IS FOR SAY HELLO PT2
    [HttpGet]
       [Route("SayHelloTwo/{name}")]

       public string SayHello(SayHelloModel name)
       {
        return " Say Hello " + name.userName + name.lastName;
       } 
    
    //return$"This would be my return {var} "
}