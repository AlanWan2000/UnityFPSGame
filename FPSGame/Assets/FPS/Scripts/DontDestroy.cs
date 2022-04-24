using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Game;
using Unity.FPS.Gameplay;

public class DontDestroy : MonoBehaviour
{


    // Start is called before the first frame update
    void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }


}
