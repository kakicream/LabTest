using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public int intelligence = 5;

    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Hellooooooooooooooooooo");
                break;
            case 4:
                print("Hiiiiiiiiiiiiiiiiiii");
                break;
            case 3:
                print("Heiiiii");
                break;
            case 2:
                print("Hiyo");
                break;
            case 1:
                print("hi");
                break;
            default:
                print("You're not smart enough to receive greeting");
                break;
        }
    }

    private void Update()
    {
        Greet();
    }
}
