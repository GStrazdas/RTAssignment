/************************************************************************************************************
 *      Please write console app. User should be able to input hours and minutes of the analogue clock.     *
 *      Program must calculate lesser angle in degrees between hours arrow and minutes arrow and provide    *
 *      output in the console window.                                                                       *
 ************************************************************************************************************/

using Clock;

do
{
    Console.WriteLine("Please enter the time: hours and minutes separated by a colon (16:45) or type \"q\", \"Quit\" or \"Exit\" to exit");
    try
    {
        var inputString = Console.ReadLine();
        if (inputString.ToLower() is "q" or "exit" or "quit")
        {
            break;
        }
        var clocksFace = new ClocksFace(inputString);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message}");
    }
}
while (true);