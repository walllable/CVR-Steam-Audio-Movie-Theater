using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using ABI.CCK.Components;

namespace ABI.CCK.Scripts.Editor
{
    public class CVRBuildBundle : EditorWindow
    {
        [MenuItem("CCK Bundle / Bundle World")]
        private static void BundleWorld()
        {
            foreach (CVRWorld world in Resources.FindObjectsOfTypeAll<CVRWorld>())
            {
                if (world.gameObject.activeInHierarchy)
                {
                    CCK_BuildUtility.BuildAndUploadMapAsset(EditorSceneManager.GetActiveScene(), world.gameObject);
                    return;
                }
            }
        }

        [MenuItem("CCK Bundle / Bundle Avatar")]
        private static void BundleAvatar()
        {
            foreach (CVRAvatar avatar in Resources.FindObjectsOfTypeAll<CVRAvatar>())
            {
                if (avatar.gameObject.activeInHierarchy)
                {
                    CCK_BuildUtility.BuildAndUploadAvatar(avatar.gameObject);
                    return;
                }
            }
            
        }

        [MenuItem("CCK Bundle / Bundle Prop")]
        private static void BundleProp()
        {
            foreach (CVRSpawnable s in Resources.FindObjectsOfTypeAll<CVRSpawnable>())
            {
                if (s.gameObject.activeInHierarchy)
                {
                    CCK_BuildUtility.BuildAndUploadSpawnable(s.gameObject);
                }
            }
        }
    }

}
