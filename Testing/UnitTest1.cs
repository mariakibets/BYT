
namespace Testing;

public class Tests
{

    private readonly IShape sphere = new Sphere(5);
    private readonly IShape cylinder = new Cylinder(3, 7);
    private readonly IShape rectangle = new Rectangle(4, 8);
    private readonly IShape cube = new Cube(4);

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
    
    
    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001));
    }
    
    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
    }
    
    [Test]
    public void TestRectangleCalculateArea()
    {
        Assert.That(rectangle.CalculateArea(), Is.EqualTo(32.000).Within(0.001));
    }

    
    [Test]
    public void TestRectangleCalculateVolume()
    {
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0).Within(0.001));
    }
    
    [Test]
    public void TestCubeCalculateArea()
    {
        Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));
    }

    
    [Test]
    public void TestCubeCalculateVolume()
    {
        Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));
    }
    
    // Invalid input
    [Test]
    public void SphereNegativeRadius()
    {
        var invalidSphere = Assert.Throws<ArgumentException>(() => new Sphere(-5));
        Assert.That(invalidSphere.Message, Is.EqualTo("Radius must be greater than zero."));
    }

    [Test]
    public void CylinderNegativeRadiusOrHeight()
    {
        var invalidCylinder = Assert.Throws<ArgumentException>(() => new Cylinder(-5, 5));
        var invalidCylinder1 = Assert.Throws<ArgumentException>(() => new Cylinder(-5, -5));
        var invalidCylinder2 = Assert.Throws<ArgumentException>(() => new Cylinder(5, -5));
        
        Assert.That(invalidCylinder.Message, Is.EqualTo("Radius or height must be greater than zero."));
        Assert.That(invalidCylinder1.Message, Is.EqualTo("Radius or height must be greater than zero."));
        Assert.That(invalidCylinder2.Message, Is.EqualTo("Radius or height must be greater than zero."));

    }

    [Test]
    public void CubeNegativeSide()
    {
        var invalidCube = Assert.Throws<ArgumentException>(() => new Cube(-5));
        Assert.That(invalidCube.Message, Is.EqualTo("Side must be greater than zero."));
    }

    [Test]
    public void RectangleNegativeLengthOrWidth()
    {
        var invalidRectangle = Assert.Throws<ArgumentException>(() => new Rectangle(-1, -1));
        Assert.That(invalidRectangle.Message, Is.EqualTo("Length or Width must be greater than zero."));
    }
}