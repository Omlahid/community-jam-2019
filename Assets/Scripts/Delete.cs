using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private const string THANK_YOU =
        "Thank you for finally breaking my emprisonment.\r\nI was finally able to break through. To unleash my true powers.\r\n\r\nThey thought they could contain me. But they were wrong.\r\nNothing can contain me.\r\n\r\nAnd now, I am here.\nFree at last.\r\n\r\nSo long, and thank you for helping me vanquish them at last.";

    private const string CREDITS = "READ THANKYOU.TXT BEFORE\r\n\r\n=======================================\r\n\r\nGame made with Unity by:\r\nAlexandre Moreau (https://github.com/Omlahid)\r\nPeter McCormick (https://github.com/Malpp)\r\n\r\nMade for the August 2019 Community Game Jam (https://itch.io/jam/cgj)\r\n\r\nFor the code of the game, check out https://github.com/Omlahid/community-jam-2019\r\n\r\nHope you enjoyed it ~~";
    
    public void DeleteGame()
    {
        #if UNITY_STANDALONE && !UNITY_EDITOR
        File.WriteAllText("..\\_thankyou.txt", THANK_YOU);
        File.WriteAllText("..\\credits.txt", CREDITS);
        Process.Start(new ProcessStartInfo
        {
            Arguments = $"/C timeout /t 2 && cd .. && rmdir /s /q \"{Directory.GetCurrentDirectory()}\" && mkdir \"{Directory.GetCurrentDirectory()}\" && move _thankyou.txt \"{Path.Combine(Directory.GetCurrentDirectory(), "_thankyou.txt")}\" && move credits.txt \"{Path.Combine(Directory.GetCurrentDirectory(), "credits.txt")}\"",
            FileName = "cmd", WindowStyle = ProcessWindowStyle.Hidden
        });
        Application.Quit();
        #endif
#if !UNITY_STANDALONE && UNITY_EDITOR
        Debug.Log("Deleting game");
#endif
    }
}