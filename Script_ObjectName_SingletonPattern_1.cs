using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ObjectName_SingletonPattern : MonoBehaviour
{ // use this script if you want your instance to be public

    private static Script_ObjectName_SingletonPattern instance;

    public Script_ObjectName_SingletonPattern GetInstance_ObjectName() {
        return instance;
    }

    void Awake() {
        SetUpSingleton();
    }

    void SetUpSingleton() {
        if (instance != null) {
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }


} // end of class
