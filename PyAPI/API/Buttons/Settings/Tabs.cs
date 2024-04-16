using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Zorro.UI;
using Zorro.Settings;
using MelonLoader;
using static Photon.Pun.UtilityScripts.TabViewManager;
using pworld.Scripts.Extensions;
using Button = UnityEngine.UI.Button;

namespace PyAPI.API.Buttons.Settings
{
    public class PyTab
    {
        private GameObject referenceParent;
        public PyTab(string name, string text, UnityAction listener)
        {
            InitializeReferenceParent();

            GameObject refTab = GameObject.Find("Canvas/SettingsPage (1)/SettingsPage/Content/TABS/AudioTab");
            GameObject pyTab = GameObject.Instantiate<GameObject>(refTab);
            GameObject targetParent = GameObject.Find("Canvas/SettingsPage (1)/SettingsPage/Content/TABS/");
            pyTab.transform.parent = targetParent.transform;
            pyTab.name = name;

            pyTab.GetComponentInChildren<UnityEngine.Localization.PropertyVariants.GameObjectLocalizer>().enabled = false;


            void ManageAndCustomizeChildren()
            {
                // Check if reference parent exists
                if (referenceParent == null)
                {
                    Debug.LogWarning("Reference parent not found. Please initialize the reference parent.");
                    return;
                }

                // Create a copy of the reference parent for the new child
                GameObject newChild = GameObject.Instantiate(referenceParent, referenceParent.transform.parent);
                newChild.name = "New Child with Custom Purpose";

                // Customize the new child (e.g., add listeners, change properties, etc.)
                UnityAction newListener = () => Debug.Log("Custom listener for new child");
                Button newButton = newChild.GetComponent<Button>();
                if (newButton != null)
                {
                    newButton.onClick.AddListener(newListener);
                }

                // Further customize the new child as needed
                // For example, setting text, changing properties, etc.
            }

            UnityEngine.UI.Button component = pyTab.GetComponent<UnityEngine.UI.Button>();
            component.onClick = new UnityEngine.UI.Button.ButtonClickedEvent();
            component.onClick.RemoveAllListeners();
            component.onClick.AddListener(listener);
            component.onClick.AddListener(ManageAndCustomizeChildren);

            pyTab.transform.localScale = new Vector3(1, 1, 1);

            pyTab.GetComponentInChildren<TextMeshProUGUI>().text = text;
            pyTab.GetComponentInChildren<TextMeshProUGUI>().SetText(text);
            pyTab.GetComponentInChildren<TMP_Text>().text = text;
            pyTab.GetComponentInChildren<TMP_Text>().SetText(text);
        }
        private void InitializeReferenceParent()
        {
            referenceParent = new GameObject("Reference Parent");
            // Set up the reference parent as needed (e.g., assign it a transform, position, etc.)
        }
    }
    public class PySettingCell
    {
        public PySettingCell(String settingCellType, string name, string text, UnityAction listener)
        {

        }
    }
}
