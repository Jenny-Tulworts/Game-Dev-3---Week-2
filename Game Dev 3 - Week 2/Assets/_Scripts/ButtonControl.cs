using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDevWithMarco
{
    public class ButtonControl : MonoBehaviour
    {
        [SerializeField] private string nextWeapon = "Absolution";

        public void  SwitchWeaponButton()
        {
            SceneManager.LoadScene(nextWeapon);
        }

    }
}
