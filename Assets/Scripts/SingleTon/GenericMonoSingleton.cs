using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericMonoSingleton<T>: MonoBehaviour where T : GenericMonoSingleton<T>
{
    private static T Instance;
    public static T instance { get { return Instance;  } }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = (T)this;
        }
        else
        {
            Destroy(this);
        }
    }

}
