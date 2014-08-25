<h1>Splint

Simplistic web browser test automation framework for C#

<h2>What is Splint?</h2>

<h2>Why Splint</h2>
<ul>
    <li>Tests code is ugly</li>
    <li>Tests code is redundant</li>
    <li>Writing tests is expensive</li>
</ul>

<h2>Core Concepts</h2>
<ul>
    <li>Clean Test Specification</li>
    <li>Configurable Driver Groups</li>
    <li>Extensible Driver Configuration</li>
    <li>Fluid API Chaining</li>
</ul>

<h2>Examples</h2>

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



