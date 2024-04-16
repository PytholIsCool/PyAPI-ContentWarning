using MelonLoader;
using pworld.Scripts.Extensions;
using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace PyAPI
{
    public static class BuildInfo
    {
        public const string Name = "PyAPI Example";
        public const string Description = null;
        public const string Author = "Pythol";
        public const string Company = null;
        public const string Version = "0.0.1"; 
        public const string DownloadLink = null; 
    }

    public class PyAPI : MelonMod
    {
        public override void OnInitializeMelon()
        {

        }
        public override void OnLateInitializeMelon() // Runs after OnApplicationStart.
        {
            
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasLoaded: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
            if(sceneName == "NewMainMenu")
            {
                MelonCoroutines.Start(LoadMainButtons());
            }
        }
        IEnumerator LoadMainButtons()
        {
            // Declare variables for UI elements and buttons
            GameObject tabsContainer = null;
            GameObject audioTab = null;

            while (tabsContainer == null || audioTab == null)
            {
                tabsContainer = GameObject.Find("Canvas/SettingsPage (1)/SettingsPage/Content/TABS/");
                audioTab = GameObject.Find("Canvas/SettingsPage (1)/SettingsPage/Content/TABS/AudioTab");

                if (tabsContainer == null || audioTab == null)
                {
                    yield return new WaitForEndOfFrame();
                }
            }
            Reference.Init();

            MelonCoroutines.Stop(LoadMainButtons());
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName) 
        {
            MelonLogger.Msg("OnSceneWasUnloaded: " + buildIndex.ToString() + " | " + sceneName);
        }

        public override void OnUpdate() // Runs once per frame.
        {
            
        }

        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
            
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            MelonLogger.Msg("OnPreferencesLoaded");
        }
    }
}