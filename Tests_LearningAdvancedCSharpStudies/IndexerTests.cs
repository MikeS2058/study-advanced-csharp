using Learning_AdvancedCSharpStudies.IndexerStudies;

namespace Tests_LearningAdvancedCSharpStudies;

public class IndexerTests
{
    [Fact]
    public void Test1()
    {
        var noteBooks = new NoteBooks(20)
        {
            [0] = "Introduction to C#",
            [1] = "Advanced C# Concepts"
        };

        // Check using fluent assertions if the notes are correctly set
        noteBooks[0].Should().Be("Introduction to C#");
    }
}