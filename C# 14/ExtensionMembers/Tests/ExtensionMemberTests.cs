using Helpers.ExtensionMembers;

namespace Tests;

public class ExtensionMemberTests
{
    [Test]
    [TestCase("", "")]
    [TestCase("A post.", "A post.")]
    [TestCase("Here we go again, with another .NET release.", "Here we go...")]
    public void ExcerptTests(string input, string expectedExcerpt)
    {
        Assert.That(input.ToExcerpt(10), Is.EqualTo(expectedExcerpt));
    }

    [Test]
    [TestCase("a b c", "a-b-c")]
    [TestCase("using new extension members", "using-new-extension-members")]
    public void SlugTests(string input, string expectedSlug)
    {
        Assert.That(input.ToSlug(), Is.EqualTo(expectedSlug));
    }

    [Test]
    [TestCase("", "")]
    [TestCase("a b c", "A B C")]
    [TestCase("using new extension members", "Using New Extension Members")]
    public void TitleCaseTests(string input, string expectedTitle)
    {
        Assert.That(input.ToTitleCase(), Is.EqualTo(expectedTitle));
    }

    [Test]
    [TestCase("Short title", false)]
    [TestCase("A Very Very Very Very Very Very Very Very Very " +
        "Very Very Very Very Very Very Very Very Very Long Title", true)]
    public void IsTitleTooLongTests(string title, bool expectedResult)
    {
        Assert.That(title.IsTitleTooLong, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase("Using Extension Members in CSharp 14", true)]
    [TestCase("Using Extension Members in C# 14", false)]
    public void IsTitleAlphanumericTests(string title, bool expectedResult)
    {
        Assert.That(title.IsTitleAlphanumeric, Is.EqualTo(expectedResult));
    }
}
