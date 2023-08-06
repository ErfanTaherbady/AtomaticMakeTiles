using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ErfanDeveloper
{
    public class GameManager : MonoBehaviour
    {
        #region Singelton
        public static GameManager instance;
        private void Awake()
        {
            if (instance != null)
                return;
            instance = this;
        }
        #endregion

        [Header("Objects Refrenses")]
        [SerializeField] private GameObject tile;
        [SerializeField] private Transform tileParent;

        [Space(5f)]

        [Header("Parametrs")]
        [SerializeField] private float x_BettwenTiels;
        [SerializeField] private float y_BettwenTiels;
      
        public void Generate(float y,float x)
        {
            ResetTiles();
            float y_Axis = 0;
            float x_Axis = 0;
            for (int i = 0; i < y; i++)
            {
                CreateTile(new Vector3(0, y_Axis, 0));  
                Debug.Log("Y");
                x_Axis = 0.143f;
                for (int j = 0; j < x - 1; j++)
                {
                    CreateTile(new Vector3(x_Axis, y_Axis, 0));
                    x_Axis += x_BettwenTiels;
                    Debug.Log("X");
                }
                y_Axis += y_BettwenTiels;
            }
        }
        private void CreateTile(Vector3 targetPosition)
        {
            GameObject newObject = Instantiate(tile, tileParent);
            newObject.transform.localPosition = targetPosition;   
        }
        private void ResetTiles()
        {
            if (tileParent.transform.childCount == 0)
                return;
            for (int i = 0; i < tileParent.transform.childCount; i++)
            {
                Destroy(tileParent.transform.GetChild(i).gameObject);
            }
        }
    }
}
