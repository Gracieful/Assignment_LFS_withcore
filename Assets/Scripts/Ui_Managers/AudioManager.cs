using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Refrences: I followed Lecture 6 to make the Audio manager 

//Audio files refrences
//Tester sound - https://freesound.org/people/GameAudio/sounds/220203/

//The functions below will be called within the game manager 

namespace GameManagers 
//Because we're only making one audio manager we don't need to give it a name within the game managers name space. We can if we want, bnut it's not needed 


{
public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance;
    //Above, is a singleton object

    public AudioClip[] soundEffects;
    //[] = calling from an array of clips 

    private AudioSource audioPlay;
    //Although I'd perfer to call the audio clips via the public array, creating the extra script for the private component was part of the lecture
    //I've made the extra script and added the component, just in case

    private AudioSource BackgroundMusic;
    //the background music is private because we'll only call it once and we don't want players ot be able to change it 


    private void Awake()
    //the boolean below will only ever call one audio clip at a time 
    {
        if(Instance == null)
        {
           Instance = this; 
           DontDestroyOnLoad(gameObject);
        }

        else if (Instance != this)
        {
           Destroy(gameObject);
           return;
        }
        audioPlay = GetComponent<AudioSource>();

        //this will look through the entire script for the audioSource inside the script
    }

    public void PlaySoundEffect(string clipName)
    {
        AudioClip clip = FindClipByName(clipName);
        if (clip != null)
        {
            audioPlay.PlayOneShot(clip);
            //I'm not sure why this isn't working. VS is saying it can't call PlayOneShot from audioPlay but I'm gonna keep it here just incase
            //Thankfully the lecture covers different methods of calling audio sources so if this doesn't work, I have options

            //the above wasn't working becuase I didn't have the audio source set up in Unity
        }
        else
        {
            Debug.LogWarning("Sound Effect Not Found" + clipName);
            //finding the clip this way is Syntax sensitive so if you have a letter wrong the error will appear
        }
    }

    private AudioClip FindClipByName(string clipName)
    {
        foreach(AudioClip clip in soundEffects)
        {
            if (clip.name.Equals(clipName))
            {
                return clip;
            }
            //here is the function that will search for the clip and bring it back without goign through the audiosource script 
        }
        return null;
    }
}
}
