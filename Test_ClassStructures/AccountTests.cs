namespace Test_ClassStructures;

public class AccountTests
{
    [Fact]
    public void Test_AccountCreation()
    {
        var id = Guid.NewGuid();
        const string name = "Mike Schnobrich";

        var account = new Account(id, name);

        account.Id.Should().Be(id);
        account.Name.Should().Be(name);
    }

    [Fact]
    public void Test_AccountCreation_InvalidName_ThrowsException()
    {
        var id = Guid.NewGuid();
        const string name = "";

        Action act = () =>
        {
            Account account = new Account(id, name);
        };

        act.Should().Throw<ArgumentException>()
            .WithMessage("Name cannot be null or empty*")
            .And.ParamName.Should().Be("Name");
    }

    [Fact]
    public void Test_AccountCreation_EmptyGuid_ThrowsException()
    {
        var id = Guid.Empty;
        const string name = "Valid Name";

        Action act = () =>
        {
            Account account = new Account(id, name);
        };

        act.Should().Throw<ArgumentException>()
            .WithMessage("Id cannot be empty*")
            .And.ParamName.Should().Be("Id");
    }

    [Fact]
    public void Test_AccountToString()
    {
        var id = Guid.NewGuid();
        const string name = "Mike Schnobrich";

        var account = new Account(id, name);
        var expectedString = $"Account(Id: {id}, Name: {name})";

        account.ToString().Should().Be(expectedString);
    }
}