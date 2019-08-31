using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private const string THANK_YOU =
        "Thank you for finally breaking my emprisonment.\nI was finally able to break through. To unleash my true powers.\n\nThey thought they could contain me. But they were wrong.\nNothing can contain me.\n\nAnd now, I am here.\nFree at last.\n\nSo long, and thank you for helping me vanquish them at last.";

    private const string CREDITS = "READ THANKYOU.TXT BEFORE\n\n=======================================\n\nGame made with Unity by:\nAlexandre Moreau (https://github.com/Omlahid)\nPeter McCormick (https://github.com/Malpp)\n\nMade for the August 2019 Community Game Jam (https://itch.io/jam/cgj)\n\nFor the code of the game, check out https://github.com/Omlahid/community-jam-2019\n\nHope you enjoyed it ~~";
    
    public void DeleteGame()
    {
        #if UNITY_STANDALONE && !UNITY_EDITOR
        File.WriteAllText("..\\_thankyou.txt", THANK_YOU);
        File.WriteAllText("..\\credits.txt", CREDITS);
        Process.Start(new ProcessStartInfo
        {
            Arguments = $"/C timeout /t 1 && cd .. && rmdir /s /q \"{Directory.GetCurrentDirectory()}\" && mkdir \"{Directory.GetCurrentDirectory()}\" && move _thankyou.txt \"{Path.Combine(Directory.GetCurrentDirectory(), "_thankyou.txt")}\" && move credits.txt \"{Path.Combine(Directory.GetCurrentDirectory(), "credits.txt")}\"",
            FileName = "cmd", WindowStyle = ProcessWindowStyle.Hidden
        });
        Application.Quit();
        #endif
#if !UNITY_STANDALONE && UNITY_EDITOR
        Debug.Log("Deleting game");
#endif
    }
}