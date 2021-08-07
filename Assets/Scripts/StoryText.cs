using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryText
{
    public enum EnableTypes
    {
        Submit = 0,
        Strawberry = 1,
        Orange = 2,
        Apple = 3,
        Raspberry = 4,
        Pineapple = 5
    }

    public GameObject SubmitButton;
    public GameObject SubmissionName;
    public GameObject InfoDisplay;

    public GameObject StrawberryButton;
    public GameObject OrangeButton;
    public GameObject AppleButton;
    public GameObject RaspberryButton;
    public GameObject PineappleButton;

    public static string Story1 = "First, there was nothing.\n" +
        "Then, there was StrawberryClock.\n" +
        "StrawberryClock is the true King of the Portal and God of Newgrounds.\n" +
        "That Tom Fulp guy is just a lackey who carries out my will.";
    public static string Story2 = "The first legendary submission by StrawberryClock was named 'A'.\n" +
        "It was glorious.\n" +
        "Click it. NOW!";

    public static string Story3 = "The foolish users of Newgrounds, not recognizing the genius of StrawberryClock, BLAMMED 'A'.\n" +
        "Thus a legendary masterpiece was lost to the annals of portal history, never to be seen again...";
    public static string Story4 = "However, StrawberryClock knew the portal needed its King.\n" +
        "Consequently, he produced a SECOND legendary submission by the name of 'B'.\n" +
        "This too was glorious.\n" +
        "Keep clicking it until something happens!";

    public static string Story5 = "This time, the users listened. The legendary 'B' was saved.\n" +
        "Trillions of users began to worship the King of The Portal.\n" +
        "Among these users were a group of clocks that formed the Clock Crew, a gathering of God-Kings and Supreme Beings...";
    public static string Story6 = "Yes. It is I, the legendary Strawberry Clock.\n" +
        "It 'B' StrawberryClock himself! The leader of the Clock Crew!\n" +
        "You may click on my glorious form!";
}
