// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string AdjustTimestamp(string timestamp, int hrs, int min, int sec)
{
    string[] dateTimeSplit= timestamp.Split(' ');
    string date = dateTimeSplit[0];
    string time = dateTimeSplit[1];

    string[] parts = time.Split(':');
    int hours = int.Parse(parts[0]);
    int minutes = int.Parse(parts[1]);
    int seconds = int.Parse(parts[2]);

    hours += hrs;
    minutes += min;
    seconds += sec;

    //while (seconds >= 60)
    //{
    //    minutes++;
    //    seconds -= 60;
    //}
    //while (minutes >= 60)
    //{
    //    hours++;
    //    minutes -= 60;
    //}   
    //while (hours >= 24)
    //{
    //    hours -= 24;
    //}    

    minutes += seconds / 60;
    seconds = seconds % 60;
    hours += minutes / 60;
    minutes = minutes % 60;
    hours = hours % 24;
    return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
}

string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
string adjustedTimestamp = AdjustTimestamp(currentTime, 1, 30, 15);
Console.WriteLine(adjustedTimestamp);

