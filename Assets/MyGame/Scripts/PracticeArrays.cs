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

        //Direkter Zugriff auf einzelne Elemente in den Arrays array1-array4 und arrayColoredImageRed
        Debug.Log("array1[0]= " + array1[0]);
        Debug.Log("array2[0]= " + array2[0]);
        Debug.Log("array3[0]= " + array3[0]);
        Debug.Log("array4[0]= " + array4[0]);

        Debug.Log("array1[" + (array1.Length - 1) + "]= " + array1[array1.Length - 1]);
        Debug.Log("array2[" + (array2.Length - 1) + "]= " + array2[array2.Length - 1]);
        Debug.Log("array3[" + (array3.Length - 1) + "]= " + array3[array3.Length - 1]);
        Debug.Log("array4[" + (array4.Length - 1) + "]= " + array4[array4.Length - 1]);

        // 1) auf erstes Element -- Jeweils ein Debug.Log ausgeben. Beim arrayColoredImageRed den Namen des Objektes ausgeben.
        Debug.Log(arrayColoredImagesRed[0].name);

        // 2) auf letzes Element -- Jeweils ein Debug.Log ausgeben. Beim arrayColoredImageRed den Namen des Objektes ausgeben.
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length-1].name);
    }

}