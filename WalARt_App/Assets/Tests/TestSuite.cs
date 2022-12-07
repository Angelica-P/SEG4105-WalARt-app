using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestSuite
{
    private ArtworkManager _artManager = new ArtworkManager();
    GameObject artBaseT;
    float x;
    float updatedX;


    // A setup method is run before every test function is run
    [SetUp]
    public void Setup()
    {
        //do whatever setup we need here
        SceneManager.LoadScene("Scenes/ViewArt");
        artBaseT= _artManager.artBase;
        x = artBaseT.transform.position.x;

    }

    // A Teardown method is run after every test method is run
    [TearDown]
    public void Teardown()
    {
        //do whatever cleanuo we need here
        // Reset x.
        x = 0.0f;

        // Reset updatedX.
        updatedX = 0.0f;
    }



    // A Test behaves as an ordinary method
    [Test]
    public void TestSuiteSimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.That((true || false), "simple test");
    }

    [Test]
    public void MoveUpPressedPasses()
    {
        //Save current position
        x = artBaseT.transform.position.x;

        //Call MoveUpPressed method
        _artManager.MoveUpPressed();

        //Save the updated x position       
        updatedX = artBaseT.transform.position.x;


        Assert.AreNotEqual(x, updatedX);

    }

    public void MoveLeftPressedPasses()
    {
        //Save current position
        x = artBaseT.transform.position.x;

        //Call MoveLeftPressed method
        _artManager.MoveLeftPressed();

        //Save the updated x position       
        updatedX = artBaseT.transform.position.x;


        Assert.AreNotEqual(x, updatedX);

    }

    public void MoveRightPressedPasses()
    {

        //Call MoveLeftPressed method
        _artManager.MoveRightPressed();

        //Save the updated x position       
        updatedX = artBaseT.transform.position.x;

        Assert.AreNotEqual(x, updatedX);

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestSuiteWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;

        //test our code using asserts
        Assert.IsTrue(true);
    }
}
