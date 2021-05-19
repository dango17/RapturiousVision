﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

//Written by Daniel Oldham
//S1903729

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    Resolution[] resolutions;
    public Dropdown resolutionDropdown; 

    void start()
    {
        resolutions = Screen.resolutions; 

        resolutionDropdown.ClearOptions(); 

        List<string> options = new List<string>();

        int currentResolutionIndex = 0; 
        for (int i = 0; i < resolutions.Length; i ++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

       
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue(); 
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        Debug.Log(volume);
    } 

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex); 
    } 

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen; 
    }
}
