// Daniel Decoito
// 10-28-22
// Mini Challenge: Reverse it
// Recreate the reverse it game using webapi
// Reviewed by: Chris Martinez, I tested DC code and I was able to reverse every number I input it with no invalid errors. The requirements for this assignment have been meet. 



using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_ReverseIt.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{


[HttpGet]
[Route("Game/{number}")]
public string Game(string number)
{
    string numberOne = "";
    string numberTwo = "";
    int numInput = int.Parse(number);
      char[] intArray = number.ToCharArray();
                for (int i = 0; i < intArray.Length; i++)
                {
                    numberOne = numberOne + intArray[i].ToString();
                }
                
                for (int j = intArray.Length - 1; j > -1; j--)
                {
                    numberTwo = numberTwo + intArray[j].ToString();
                }
    return $" --Reverse it-- \nYour number is \n{number} \nYour number reversed is \n{numberTwo}";
}
}