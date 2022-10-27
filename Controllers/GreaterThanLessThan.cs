//Jeremy Lapham
//10-25-22
//Greater than less than endpoint
//This program will take the two of the users numbers and compare them either: Greater than, Less than, or Equal to
//Peer Review: Pedro Castaneda - Jeremy did a great job setting up his Endpoint. The number validation works and I get an erro message when making the wrong input. The comparison operations work perfectly. Great work.

using Microsoft.AspNetCore.Mvc;

namespace LaphamJGreaterLessThan_EndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanLessThanController : ControllerBase
{
    [HttpGet]
    [Route("GreaterLess/{num1}/{num2}")]

    public string GreaterThanLessThan(string num1, string num2)
    {
        string text = "";
        bool validNum;
        bool validNum2;
        int goodNum1 = 0;
        int goodNum2 = 0;
        validNum = Int32.TryParse(num1, out goodNum1);
        validNum2 = Int32.TryParse(num2, out goodNum2);
        if (validNum != true || validNum2 != true)
        {
            text = "You didn't enter two vaild numbers try again";
        }
        else if (validNum == true && validNum2 == true)
        {
            if (goodNum1 == goodNum2)
            {
                text = $"{goodNum1} is equal to {goodNum2}";
            }
            else if (goodNum1 > goodNum2)
            {
                text = $"{goodNum1} is Greater Than {goodNum2}";
            }
            else if (goodNum1 < goodNum2)
            {
                text = $"{goodNum1} is Less Than {goodNum2}";
            }
        }
        return text;
    }
}