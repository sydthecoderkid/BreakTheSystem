using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CurrentBook : MonoBehaviour
{
    public static GameObject currentBook;
    public static GameObject image;
    public static bool bookChanged = false;
    public static GameObject oldbook;
    public static List<GameObject> bookList = new List<GameObject>();
    public static int index = 0;
     // Start is called before the first frame update
    void Start()
    {
        image = this.gameObject;
          
    }

    public CurrentBook(GameObject book)
    {
        changeBook(book);
    }
    // Update is called once per frame
    void Update()
    {
        
    }


   public static void changeBook(GameObject newBook)
    {
        
        Vector3 bookPosition = new Vector3(image.transform.position.x-20, image.transform.position.y + 10, image.transform.position.z);
        bookList.Add(Instantiate(newBook, bookPosition, image.transform.rotation,image.transform));
        GetTweetText.currentBook = bookList[index].GetComponent<Book>();
        if (bookList.Count > 1)
        {
            
            GameObject thisObject =   bookList[index-1];
            DestroyImmediate(thisObject);
            
        }
        index++;
        newBook.GetComponent<Button>().enabled = false;
        
    }
}
