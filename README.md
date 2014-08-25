<h1>Splint

Simplistic web browser test automation framework for C#

<h2>What is Splint?</h2>

<h2>Why Splint</h2>
<ul>
    <li>UI test code is ugly</li>
    <li>UI test code is redundant</li>
    <li>UI tests are expensive to write</li>
</ul>

<h2>Core Concepts</h2>
<ul>
    <li>Clean Test Specification</li>
    <li>Configurable Driver Groups</li>
    <li>Extensible Driver Configuration</li>
    <li>Fluid API Chaining</li>
</ul>

<h2>Examples - Basic Usage</h2>

<h4>Run Test Against a Single Browser Type</h4>
<pre>
[Test]
public void GoogleSearchPageTest()
{
    Splint.Test(()=> {
    
      GoogleHomePage homePage = new GoogleHomePage();
      GoogleResultsPage resultsPage = homePage.Search("Test Search");
      
      Assert.IsTrue(resultsPage != null)
      
    }).WithDriver(DriverType.InternetExplorer)
      .Run()
}
</pre>

<h4>Run Test Against Multiple Browser Type(s)</h4>
<pre>
[Test]
public void GoogleSearchPageTest()
{
    Splint.Test(()=> {
    
      GoogleHomePage homePage = new GoogleHomePage();
      GoogleResultsPage resultsPage = homePage.Search("Test Search");
      
      Assert.IsTrue(resultsPage != null)
      
    }).WithDrivers(new[]{DriverType.InternetExplorer,DriverType.Chrome})
      .Run()
}
</pre>

<h4>Run Test Against All Browser Types</h4>
<pre>
[Test]
public void GoogleSearchPageTest()
{
    Splint.Test(()=> {
    
      GoogleHomePage homePage = new GoogleHomePage();
      GoogleResultsPage resultsPage = homePage.Search("Test Search");
      
      Assert.IsTrue(resultsPage != null)
      
    }).WithAllDrivers()
      .Run()
}
</pre>

<h4>Run Test Against Single Driver Group</h4>
<pre>
[Test]
public void GoogleSearchPageTest()
{
    Splint.Test(()=> {
    
      GoogleHomePage homePage = new GoogleHomePage();
      GoogleResultsPage resultsPage = homePage.Search("Test Search");
      
      Assert.IsTrue(resultsPage != null)
      
    }).WithDriverGroup("Web")
      .Run()
}
</pre>

<h4>Run Test Against Multiple Driver Groups</h4>
<pre>
[Test]
public void GoogleSearchPageTest()
{
    Splint.Test(()=> {
    
      GoogleHomePage homePage = new GoogleHomePage();
      GoogleResultsPage resultsPage = homePage.Search("Test Search");
      
      Assert.IsTrue(resultsPage != null)
      
    }).WithDriverGroups("Web","Mobile")
      .Run()
}
</pre>

<h4>Run Test Against All Driver Groups</h4>
<pre>
[Test]
public void GoogleSearchPageTest()
{
    Splint.Test(()=> {
    
      GoogleHomePage homePage = new GoogleHomePage();
      GoogleResultsPage resultsPage = homePage.Search("Test Search");
      
      Assert.IsTrue(resultsPage != null)
      
    }).WithAllDriverGroups()
      .Run()
}
</pre>



