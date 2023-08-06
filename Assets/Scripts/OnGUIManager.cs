using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
namespace ErfanDeveloper
{
    public class OnGUIManager : MonoBehaviour
    {
        [Header("UI Refrense")]
        [SerializeField] private Text y_Field;
        [SerializeField] private Text x_Field;

        #region ButtonFunctions

        public void Genrate()
        {
            int y = Convert.ToInt32(y_Field.text);
            int x = Convert.ToInt32(x_Field.text);
            GameManager.instance.Generate(y, x);
        }
        #endregion
    }
}
