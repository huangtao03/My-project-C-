using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    //ÖÇÁ¦
    public int intellugence = 5;

    void Greet()
    {
        switch (intellugence) {
            case 5:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 4:
                print("Hello and good day!");
                break;
            case 3:
                print("Whadya want£¿");
                    break;
            case 2:
                print("Grog SMASH!");
                break;
            case 1:
                print("Ulg,hlib,Pblblblblb");
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
}
