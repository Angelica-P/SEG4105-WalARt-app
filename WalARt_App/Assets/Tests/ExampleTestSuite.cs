using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ExampleTestSuite
{
    // A setup method is run before every test function is run
    [SetUp]
    public void Setup()
    {
        //do whatever setup we need here
    }

    // A Teardown method is run after every test method is run
    [TearDown]
    public void Teardown()
    {
        //do whatever cleanuo we need here
    }

    // A Test behaves as an ordinary method
    [Test]
    public void ExampleTestSuiteSimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.That((true || false), "simple test");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ExampleTestSuiteWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;

        //test our code using asserts
        Assert.IsTrue(true);
    }
}
