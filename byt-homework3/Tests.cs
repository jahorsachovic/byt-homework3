public class Tests
{
    private readonly IShape sphere = new Sphere(5);
    private readonly IShape cube = new Cube(5);
    private readonly IShape rect = new Rectangle(6, 8);
    private readonly IShape cylinder = new Cylinder(45, 10);
    
    //Sphere tests
    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }

    // Cube tests
    [Test]
    public void TestCubeCalculateVolume()
    {
        Assert.That(cube.CalculateVolume(), Is.EqualTo(125));
    }

    [Test]
    public void TestCubeCalculateArea()
    {
        Assert.That(cube.CalculateArea(), Is.EqualTo(150));
    }
    
    //Rectangle tests
    [Test]
    public void TestRectangleCalculateArea()
    {
        Assert.That(rect.CalculateArea(), Is.EqualTo(48));
    }

    [Test]
    public void TestRectangleCalculateVolume()
    {
        Assert.That(rect.CalculateVolume(), Is.EqualTo(0));
    }
    
    //Cylinder tests
    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(2*Math.PI*45*10 + 2*Math.PI*45*45).Within(0.001));
    }

    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(Math.PI*45*45*10).Within(0.001));
    }

    //todo : Complete the remaning tests here
}