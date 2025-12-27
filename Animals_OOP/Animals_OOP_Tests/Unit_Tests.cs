using Moq;

namespace Animals_Data_Engine_OOP_Tests;

[TestFixture]
public class Unit_Tests
{
    private readonly Mock<IPrinter> printer_mock = new();
    private IPrinter Printer => printer_mock.Object;

    [Test]
    public void Dog_Swim()
    {
        new Dog(Printer).Swim();

        Verify("The dog is swimming.");
    }

    [Test]
    public void Robot_Dog_Swim()
    {
        var robot_dog = new Robot_Dog(Printer);
        robot_dog.Swim();

        Verify_Never("The robot dog is swimming.");
    }

    [Test]
    public void Robot_Dog_Swim_Charged()
    {
        var robot_dog = new Robot_Dog(Printer);
        robot_dog.Charge();

        robot_dog.Swim();

        Verify("The robot dog is swimming.");
        Assert.That(robot_dog.Is_Charged, Is.False);
    }

    [Test]
    public void Robot_Dog_Walk()
    {
        var robot_dog = new Robot_Dog(Printer);
        robot_dog.Charge();

        robot_dog.Walk();

        Verify("The robot dog is walking on 4 legs.");
        Assert.That(robot_dog.Is_Charged, Is.False);
    }

    private void Verify(string message)
    {
        printer_mock.Verify(m => m.Print(message), Times.Once);
    }

    private void Verify_Never(string message)
    {
        printer_mock.Verify(m => m.Print(message), Times.Never);
    }
}
