using FluentAssertions;

namespace LinqUnitTest;

public class SingleOrFirst_Tests
{
    [Fact]
    public void ResultShouldBe_Equal_3()
    {
        // arrange        
        List<int> collection = new List<int> { 1, 2, 3, 3 };

        // act
        var result = collection.Where(x => x == 3).First();

        //Assert
        result.Should().Be(3);
    }

    [Fact]
    public void ActShouldThowException()
    {
        // arrange        
        List<int> collection = new List<int> { 1, 2, 3, 3 };

        // act
        Action act = () => collection.Where(x => x == 3).Single();

        //Assert
        act.Should()
           .Throw<InvalidOperationException>()
           .WithMessage("Sequence contains more than one element");
    }
}