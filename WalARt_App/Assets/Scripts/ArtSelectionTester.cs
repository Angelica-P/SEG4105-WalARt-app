using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArtSelectionTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStonksSelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/stonks", 0.625, 0.85);
        SceneManager.LoadScene("Scenes/ViewArt");
    }

    public void OnThisIsntGeographySelect()
    {
        ViewingArt.Art =  new Artwork("ArtSprites/this_isnt_geography", 0.96, 0.60);
        SceneManager.LoadScene("Scenes/ViewArt");
    }
}
