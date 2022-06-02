using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private string[] firstMusic = {"C2", "C3", "C4", "C3", "C2", "C4"}; // nota to play
    private float[] firstMusicWaitTimes = {5f, 10f, 5f, 10f, 5f, 10f}; // tempo que demora a "cair"

    //EACH NOTE
    private string notePlaying;
    private int numNotePlaying = 0; // counts notes
    private float nextActionTime = 10f; // seconds before first note is played

    void Update () {
        if (Time.time > nextActionTime )
        {
            nextActionTime = Time.time + firstMusicWaitTimes[numNotePlaying];
            playMusic(firstMusic[numNotePlaying], firstMusicWaitTimes[numNotePlaying]);
        }
    }

    void playMusic(string noteToPlay, float waitTime)
    {
        notePlaying = noteToPlay + " / " + waitTime;
        print(notePlaying);
        ++numNotePlaying;
    }
}
