using UnityEngine;
using UnityEngine.UI;

public class PracticeArrays : MonoBehaviour
{
    //Deklaration eines Arrays namens array vom Datentyp int
    int[] array;
    //public GameObject[] arrayColoredImagesRed;


    private void Start()
    {
        //Deklaration von array1, array2, array3. array4 und deren Initialiserung auf 3 unterschiedliche Arten:
        // -- array1 Datentyp int, 4 Elemente
        int[] array1 = new int[4];

        // -- array2 Datentyp int, 4 Elemente, Werte 21,22,23,24
        int[] array2 = new int[] { 21, 22, 23, 24 };

        // -- array3 Datentyp int, 7 Elemente, Werte 31-37
        int[] array3 = { 31, 32, 33, 34, 35, 36, 37};

        // -- array4 Datentyp string, 10 Elemente, Werte "array4"
        string[] array4 = new string[10];
        for (int i = 0; i < 10; i++)
        {
            array4[i] = "array4";
        }

        // -- arrayColoredImagesRed Datentyp GameObject mittels GameObject.FindGameObjectsWithTag("RedImage"); dabei ist natürlich Voraussetzung, dass die Images im 2D Unity Projekt angelegt sind (4 Elemente) und das Tag RedImage jeweils ausgewählt ist.
        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
        
        foreach(GameObject i in arrayColoredImagesRed)
        {
            Debug.Log(i.name);
        }
    }

}