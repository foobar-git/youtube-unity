//====================================================================================================
// USE THIS SCRIPT IF YOU WANT YOUR INSTANCE TO BE PRIVATE
// When placing this file into Unity, rename it to Script_ObjectName_SingletonPattern
//====================================================================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ObjectName_SingletonPattern : MonoBehaviour
{
    int instanceCount;

    void Awake() {
        SetUpSingleton();
    }

    void SetUpSingleton() {
        instanceCount = FindObjectsOfType(GetType()).Length;
        if (instanceCount > 1) {
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        } else {
            DontDestroyOnLoad(this.gameObject);
        }
    }


} // end of class
