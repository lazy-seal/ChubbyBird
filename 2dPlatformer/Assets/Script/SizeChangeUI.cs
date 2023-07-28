using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeChangeUI : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private Slider slider;
    public void FixedUpdate()
    {
        slider.value = playerMovement.GetMoveTime();
    }


}