using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// tester for LifeSteal Augment
public class TestAugment : MonoBehaviour
{
    [SerializeField]
    private OnHitAugment onhit;
    [SerializeField]
    private ListenerAugment listener;
    [SerializeField]
    private AugmentManager augmentManager;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            listener.enableAugment();
            augmentManager.addListenerAugment(listener);
            augmentManager.startCoroutines();
        }
    }
}
